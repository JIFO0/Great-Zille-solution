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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Wehlen?""** | `[3]` **Laurento Esquibel**: ""I just received official confir..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Lucita Azaro**: ""Are you trying to be humorous, ..." |
| `[5]` | **""Morella?""** | `[3]` **Laurento Esquibel**: ""I just received official confir..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Lucita Azaro**: ""Are you trying to be humorous, ..." |
| `[6]` | **""Lespia?""** | `[3]` **Laurento Esquibel**: ""I just received official confir..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Laurento Esquibel**: ""Precisely. Prime Minister Alvar..." |
| `[7]` | **""Derdia?""** | `[3]` **Laurento Esquibel**: ""I just received official confir..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Lucita Azaro**: ""Are you trying to be humorous, ..." |
| `[30]` | **""What happened in Plavo is between me and God.""** | `[29]` **Lucita Azaro**: ""I'm sure the proceedings were v..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Lucita Azaro**: ""And the Grand Wiseman, of course."" |
| `[31]` | **""You're wrong, Duchess Azaro. I have never felt so invigorated.""** | `[29]` **Lucita Azaro**: ""I'm sure the proceedings were v..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lucita Azaro**: ""I'm glad to hear it. Religion h..." |
| `[32]` | **""It was taxing, for sure. But it was my duty as King to bear that burden.""** | `[29]` **Lucita Azaro**: ""I'm sure the proceedings were v..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucita Azaro**: ""Let's hope that something usefu..." |
| `[50]` | **""That's a rather pessimistic view, Duchess Azaro. Isn't peace the final state that..."** | `[49]` **Lucita Azaro**: ""Because they most certainly *wi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[57]` **Lucita Azaro**: ""Ideally, maybe. But reality has..." |
| `[51]` | **""I agree with you completely, Duchess. Rizia has become soft and complacent during..."** | `[49]` **Lucita Azaro**: ""Because they most certainly *wi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[58]` **Lucita Azaro**: ""Not without reason, of course."" |
| `[52]` | **""We can also use peacetime to form new alliances and improve international relatio..."** | `[49]` **Lucita Azaro**: ""Because they most certainly *wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Laurento Esquibel**: ""Well said, Your Majesty."" |
| `[53]` | **""Yes, we should remain vigilant and prepared. But not to the point where our milit..."** | `[49]` **Lucita Azaro**: ""Because they most certainly *wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Lucita Azaro**: ""Safety is at the top of the hie..." |
| `[64]` | **""I have a few more questions regarding the military.""** | `[266]` **Lucita Azaro**: ""Of course, national security do..."<br>`[242]` **Lucita Azaro**: ""Any other questions, Your Majes..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == false` | `Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] = t...` | `[65]` **Lucita Azaro**: ""I'm here to answer them, Your M..." |
| `[66]` | **""What's the state of our military production industry?""** | `[65]` **Lucita Azaro**: ""I'm here to answer them, Your M..."<br>`[102]` **Lucita Azaro**: ""I look forward to that conversa..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true) == false` | `Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] = true;` | `[70]` **Narrator**: "Lucita sighed." |
| `[67]` | **""Tell me more about our naval and air capabilities.""** | `[65]` **Lucita Azaro**: ""I'm here to answer them, Your M..."<br>`[102]` **Lucita Azaro**: ""I look forward to that conversa..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true) == false` | `Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] = true;` | `[74]` **Lucita Azaro**: ""Our navy has actually made sign..." |
| `[68]` | **""Let's talk about army conscription. How do we bolster our ranks?""** | `[65]` **Lucita Azaro**: ""I'm here to answer them, Your M..."<br>`[102]` **Lucita Azaro**: ""I look forward to that conversa..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true) == false` | `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"]...` | `[77]` **Lucita Azaro**: ""Our ranks are looking healthy a..."<br>`[488]` **Lucita Azaro**: ""I'm glad you asked."" |
| `[69]` | **""Does our internal security need improvement as well?""** | `[266]` **Lucita Azaro**: ""Of course, national security do..."<br>`[242]` **Lucita Azaro**: ""Any other questions, Your Majes..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == false` | *Brak zmian stanu* | `[123]` **Lucita Azaro**: ""Less so, Your Majesty. Our poli..." |
| `[80]` | **""I don't see the need for that. It seems easier and cheaper to continue importing ..."** | `[73]` **Lucita Azaro**: ""But if we invested more into re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Lucita Azaro**: ""Producing our own weapons would..." |
| `[81]` | **""Do we have the capability to build larger weapons too?""** | `[73]` **Lucita Azaro**: ""But if we invested more into re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Lucita Azaro**: ""Not currently, Your Majesty. Ev..." |
| `[82]` | **""I imagine that would give a boost to the local economy as well.""** | `[73]` **Lucita Azaro**: ""But if we invested more into re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Elena Werner**: ""It would, Your Majesty. As long..." |
| `[83]` | **""We've got to take our diplomatic stance into account. Wouldn't a sudden increase ..."** | `[73]` **Lucita Azaro**: ""But if we invested more into re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Lucita Azaro**: ""On the contrary, Your Majesty, ..." |
| `[89]` | **""Hmm. A weapons deal with Derdia could help improve relations between our countries.""** | `[85]` **Lucita Azaro**: ""Not currently, Your Majesty. Ev..."<br>`[87]` **Lucita Azaro**: ""On the other hand, larger arms ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Laurento Esquibel**: ""It would depend on what they'd ..." |
| `[90]` | **""We shouldn't bother with Derdia. I'm counting on a stable trade relationship with..."** | `[85]` **Lucita Azaro**: ""Not currently, Your Majesty. Ev..."<br>`[87]` **Lucita Azaro**: ""On the other hand, larger arms ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Laurento Esquibel**: ""Yes, I'm afraid any negotiation..." |
| `[91]` | **""I doubt Derdia will sell us weapons considering our religious differences.""** | `[85]` **Lucita Azaro**: ""Not currently, Your Majesty. Ev..."<br>`[87]` **Lucita Azaro**: ""On the other hand, larger arms ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Laurento Esquibel**: ""Everyone has a price, Your Maje..." |
| `[94]` | **""This is ridiculous. What would we need missiles for?""** | `[85]` **Lucita Azaro**: ""Not currently, Your Majesty. Ev..."<br>`[87]` **Lucita Azaro**: ""On the other hand, larger arms ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Lucita Azaro**: ""The wars to come will not be fo..." |
| `[108]` | **""I don't need a ceremony to validate my God-given right to rule.""** | `[107]` **Narrator**: "Hugo wore a disproving look on h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Hugo Toras**: ""Whatever your personal feelings..." |
| `[109]` | **""My apologies once again, Grand Wiseman Ignacius. I did not mean to disrespect the..."** | `[107]` **Narrator**: "Hugo wore a disproving look on h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Sal Ignacius**: ""Do not fear, Your Majesty. The ..." |
| `[110]` | **""I made the right decision. Arcane religious rituals have no place in modern polit..."** | `[107]` **Narrator**: "Hugo wore a disproving look on h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Sal Ignacius**: ""These rituals connect us to our..." |
| `[111]` | **""I had my reasons for not participating in the ceremony. I don't want any of you q..."** | `[107]` **Narrator**: "Hugo wore a disproving look on h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Sal Ignacius**: ""Quite right. A man's faith is a..." |
| `[134]` | **""It's no surprise that giving part of Brenas to House Toras would divide the region.""** | `[144]` **Lucita Azaro**: ""If there's a problem area, it's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Lucita Azaro**: ""No, indeed. Iza has been experi..." |
| `[135]` | **""Let me guess. The Wehzek and Derdian newcomers have been causing problems.""** | `[144]` **Lucita Azaro**: ""If there's a problem area, it's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Lucita Azaro**: ""It's complicated, Your Majesty."" |
| `[136]` | **""I knew it. The city was always a stronghold for anti-monarchists.""** | `[144]` **Lucita Azaro**: ""If there's a problem area, it's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Lucita Azaro**: ""We are not seeing anti-monarchi..." |
| `[138]` | **""What? Is my cousin failing in his duties as Duke?""** | `[144]` **Lucita Azaro**: ""If there's a problem area, it's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Lucita Azaro**: ""Well... ruling the Brenas capit..." |
| `[148]` | **""What kind of black-market activities?""** | `[147]` **Lucita Azaro**: ""As I mentioned in our earlier m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Lucita Azaro**: ""The drug trade, mostly. There a..." |
| `[149]` | **""We can't blame them. They had no other choice.""** | `[147]` **Lucita Azaro**: ""As I mentioned in our earlier m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Hugo Toras**: ""We gave them a home and employm..." |
| `[150]` | **""Hugo, you were in Iza during the '30s. Didn't you try and stop this?""** | `[147]` **Lucita Azaro**: ""As I mentioned in our earlier m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Hugo Toras**: ""I implemented a community polic..." |
| `[162]` | **""Indeed. A group like Su Omina is a necessary counter-correction to the problems c..."** | `[157]` **Lucita Azaro**: ""The King, of course, might disa..."<br>`[161]` **Lucita Azaro**: ""Certain members of House Toras ..." | `Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[170]` **Hugo Toras**: ""The good Rizians of Iza are doi..." |
| `[163]` | **""I believe Su Omina was founded with good intentions. But they may have made thing..."** | `[157]` **Lucita Azaro**: ""The King, of course, might disa..."<br>`[161]` **Lucita Azaro**: ""Certain members of House Toras ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Hugo Toras**: ""The good Rizians of Iza are doi..." |
| `[164]` | **""I agree completely. The provocations of people like my cousin will only stoke the..."** | `[161]` **Lucita Azaro**: ""Certain members of House Toras ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Hugo Toras**: ""The good Rizians of Iza are doi..." |
| `[168]` | **""Just because I supported the group in my younger days doesn't mean I do now.""** | `[157]` **Lucita Azaro**: ""The King, of course, might disa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Hugo Toras**: ""The good Rizians of Iza are doi..." |
| `[169]` | **""My cousin Rico has witnessed Iza's problems firsthand. If he supports Su Omina, i..."** | `[161]` **Lucita Azaro**: ""Certain members of House Toras ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Hugo Toras**: ""The good Rizians of Iza are doi..." |
| `[174]` | **""And why not, Duchess Azaro? I thought you were tough on crime yourself.""** | `[173]` **Lucita Azaro**: ""As well as his requests that ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Lucita Azaro**: ""I believe in the power of a fir..." |
| `[176]` | **""It would set a dangerous precedent. We can't have the other provinces demanding t..."** | `[173]` **Lucita Azaro**: ""As well as his requests that ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Lucita Azaro**: ""Exactly."" |
| `[178]` | **""Why aren't the Brenas police cooperating?""** | `[173]` **Lucita Azaro**: ""As well as his requests that ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Lucita Azaro**: ""They are providing some assista..." |
| `[183]` | **""You're right. Extra force won't solve anything. We need to get to the root of the..."** | `[173]` **Lucita Azaro**: ""As well as his requests that ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucita Azaro**: ""Force is absolutely necessary i..." |
| `[194]` | **""What about our intelligence capabilities? They're just as important as our milita..."** | `[266]` **Lucita Azaro**: ""Of course, national security do..."<br>`[242]` **Lucita Azaro**: ""Any other questions, Your Majes..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == false` | *Brak zmian stanu* | `[267]` **Lucita Azaro**: ""I was getting to that, Your Maj..." |
| `[197]` | **""Why would he do that?""** | `[203]` **Lucita Azaro**: ""His Majesty Valero, however, in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Lucita Azaro**: ""He was afraid their leaders wou..." |
| `[199]` | **""I'm sure he had a good reason for doing so.""** | `[203]` **Lucita Azaro**: ""His Majesty Valero, however, in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Lucita Azaro**: ""He believed their leaders were ..." |
| `[204]` | **""That's ridiculous. We need to keep a close watch on both of those regions.""** | `[203]` **Lucita Azaro**: ""His Majesty Valero, however, in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Lucita Azaro**: ""Yes, my father told him the sam..." |
| `[205]` | **""Good thinking. We cannot repair our ties with Wehlen and Pales if we don't trust ..."** | `[203]` **Lucita Azaro**: ""His Majesty Valero, however, in..." | `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == false` | *Brak zmian stanu* | `[212]` **Laurento Esquibel**: ""In my experience, we have much ..." |
| `[216]` | **""That doesn't count as useful information. It would have come out anyway.""** | `[214]` **Lucita Azaro**: ""We learned of the prior Duke Nj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Lucita Azaro**: ""But by the time it did, we had ..." |
| `[217]` | **""If the agents are gone, they're gone. What about domestic intelligence?""** | `[214]` **Lucita Azaro**: ""We learned of the prior Duke Nj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Lucita Azaro**: ""Domestically, our main intellig..." |
| `[220]` | **""Please do so immediately.""** | `[219]` **Lucita Azaro**: ""Now that they have been withdra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Lucita Azaro**: ""Consider it done."" |
| `[221]` | **""What about our domestic intelligence services?""** | `[218]` **Lucita Azaro**: ""But by the time it did, we had ..."<br>`[219]` **Lucita Azaro**: ""Now that they have been withdra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Lucita Azaro**: ""Domestically, our main intellig..." |
| `[222]` | **""Keep up the good work.""** | `[224]` **Lucita Azaro**: ""To that end, our information ga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Lucita Azaro**: ""I'll update you should major co..." |
| `[225]` | **""Can the agents in those regions be placed back in position?""** | `[214]` **Lucita Azaro**: ""We learned of the prior Duke Nj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Lucita Azaro**: ""Now that they have been withdra..." |
| `[227]` | **""That makes sense. Can you put the operatives back?""** | `[218]` **Lucita Azaro**: ""But by the time it did, we had ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Lucita Azaro**: ""Now that they have been withdra..." |
| `[228]` | **""What about Valenqiris? I tried my best as Duke, but some traitors may have slippe..."** | `[224]` **Lucita Azaro**: ""To that end, our information ga..." | `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true` | *Brak zmian stanu* | `[236]` **Hugo Toras**: ""Rest assured that House Toras w..." |
| `[229]` | **""What about Valenqiris? I didn't crack down on traitors as Duke, after all.""** | `[224]` **Lucita Azaro**: ""To that end, our information ga..." | `(Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true) == false` | *Brak zmian stanu* | `[236]` **Hugo Toras**: ""Rest assured that House Toras w..." |
| `[230]` | **""On second thought, let's keep things as they are. We have other priorities.""** | `[219]` **Lucita Azaro**: ""Now that they have been withdra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Lucita Azaro**: ""As you wish."" |
| `[231]` | **""We shouldn't be spying on our own citizens like that.""** | `[224]` **Lucita Azaro**: ""To that end, our information ga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Lucita Azaro**: ""History has taught us that if w..." |
| `[233]` | **""What about Cardesse-Montaklar? The military was involved in the last uprising as ..."** | `[224]` **Lucita Azaro**: ""To that end, our information ga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Lucita Azaro**: ""As I've mentioned, the military..." |
| `[241]` | **""Laurento is right. Let's not waste our resources spying on Zille and Pales.""** | `[218]` **Lucita Azaro**: ""But by the time it did, we had ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Lucita Azaro**: ""As you wish."" |
| `[255]` | **""Very good. Your house should be commended for its deep devotion to protecting thi..."** | `[63]` **Narrator**: "With lightning speed, she reache..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Lucita Azaro**: ""We're pleased to serve."" |
| `[256]` | **""You brought a weapon to a council meeting, Duchess?""** | `[63]` **Narrator**: "With lightning speed, she reache..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Lucita Azaro**: ""I wouldn't dream of leaving hom..." |
| `[257]` | **""I trained at Camp Domus, too. You could've thrown that knife at me.""** | `[63]` **Narrator**: "With lightning speed, she reache..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[258]` **Lucita Azaro**: ""Another time. If your reflexes ..." |
| `[259]` | **""Are you insane? You could've hurt someone!""** | `[63]` **Narrator**: "With lightning speed, she reache..." | `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false` | *Brak zmian stanu* | `[261]` **Lucita Azaro**: ""Spoken like someone who hasn't ..." |
| `[262]` | **""You made your point. No need to put on a show.""** | `[63]` **Narrator**: "With lightning speed, she reache..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Lucita Azaro**: ""Sorry, Your Majesty. The spirit..." |
| `[272]` | **""You've given me a lot to think about. Let's call it a day for now.""** | `[266]` **Lucita Azaro**: ""Of course, national security do..."<br>`[242]` **Lucita Azaro**: ""Any other questions, Your Majes..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == true  and  (Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == true)` | *Brak zmian stanu* | `[308]` **Narrator**: "The heavy wooden door to the hal..." |
| `[279]` | **""Nice catch.""** | `[278]` **Narrator**: "In one fluid motion, she hiked u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Lucita Azaro**: ""It was nothing. In my fitter da..." |
| `[280]` | **""I will remind you that this is a royal court, not a variety theater.""** | `[278]` **Narrator**: "In one fluid motion, she hiked u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Lucita Azaro**: ""Danger can strike at any time, ..." |
| `[284]` | **""Careful with that. I had a... bad dream involving stabbing.""** | `[278]` **Narrator**: "In one fluid motion, she hiked u..." | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true` | *Brak zmian stanu* | `[323]` **Lucita Azaro**: ""Nobody's getting stabbed on my ..." |
| `[285]` | **""Lower your hem, Duchess. The Lord frowns upon such indecency.""** | `[278]` **Narrator**: "In one fluid motion, she hiked u..." | `Variable["RiziaDLC.PersonalValue_Religious"] > 0` | *Brak zmian stanu* | `[324]` **Sal Ignacius**: ""Indeed, modesty is one of the e..." |
| `[291]` | **""Lespia wouldn't even have those planes if it weren't for their close ties with Ar..."** | `[290]` **Laurento Esquibel**: ""We did not foresee that Lespia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Lucita Azaro**: ""Very true. There is much to cri..." |
| `[292]` | **""So hypothetically speaking, if we tried to reconquer Pales again, they'd rain dea..."** | `[290]` **Laurento Esquibel**: ""We did not foresee that Lespia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Lucita Azaro**: ""Hypothetically... yes. We're mo..." |
| `[293]` | **""I remember when our troops laid eyes on those planes for the first time. Their mo..."** | `[290]` **Laurento Esquibel**: ""We did not foresee that Lespia ..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[298]` **Lucita Azaro**: ""My father always had terror in ..." |
| `[297]` | **""We're better off strengthening our other divisions than trying to compete with th..."** | `[290]` **Laurento Esquibel**: ""We did not foresee that Lespia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Lucita Azaro**: ""We can't ignore the possibility..." |
| `[312]` | **""What is it?""** | `[311]` **Laurento Esquibel**: ""I must excuse myself briefly, l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Laurento Esquibel**: ""I will explain once I have all ..." |
| `[313]` | **""You may be excused, Mr. Esquibel.""** | `[311]` **Laurento Esquibel**: ""I must excuse myself briefly, l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Laurento Esquibel**: ""Thank you, Your Majesty. I'll e..." |
| `[314]` | **""That's fine. None of these topics concern you, anyway.""** | `[311]` **Laurento Esquibel**: ""I must excuse myself briefly, l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Laurento Esquibel**: ""Our security and foreign policy..." |
| `[328]` | **""Excellent suggestion, Your Grace.""** | `[12]` **Hugo Toras**: ""Thank you for updating us, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Laurento Esquibel**: ""I'll start preparing a briefing..." |
| `[329]` | **""Preferably as soon as possible. We must decide on our official stance.""** | `[12]` **Hugo Toras**: ""Thank you for updating us, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Laurento Esquibel**: ""We are not expected to come out..." |
| `[330]` | **""I don't see the urgency. We won't be expected to respond immediately.""** | `[12]` **Hugo Toras**: ""Thank you for updating us, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Laurento Esquibel**: ""No, but it's good that we all g..." |
| `[349]` | **""Nothing good, that's for sure.""** | `[348]` **Vina Toras**: ""The Arcasian Treaty Organizatio..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Vina Toras"); RemoveConversant("Hugo To...`<br>`AddTokenStatus("Rizia_Country_Lespia","Country_ATO");` | `[13]` **Narrator**: "I had barely even started my rei..." |
| `[350]` | **""Nothing for you to worry about, sweetheart.""** | `[348]` **Vina Toras**: ""The Arcasian Treaty Organizatio..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Vina Toras"); RemoveConversant("Hugo To...`<br>`AddTokenStatus("Rizia_Country_Lespia","Country_ATO");` | `[13]` **Narrator**: "I had barely even started my rei..." |
| `[351]` | **""I don't know. I suppose we'll find out.""** | `[348]` **Vina Toras**: ""The Arcasian Treaty Organizatio..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Vina Toras"); RemoveConversant("Hugo To...`<br>`AddTokenStatus("Rizia_Country_Lespia","Country_ATO");` | `[13]` **Narrator**: "I had barely even started my rei..." |
| `[353]` | **""I don't know yet.""** | `[352]` **Hugo Toras**: ""What do you make of the ATO dev..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Vina Toras"); RemoveConversant("Hugo To...`<br>`AddTokenStatus("Rizia_Country_Lespia","Country_ATO");` | `[13]` **Narrator**: "I had barely even started my rei..." |
| `[354]` | **""It's not good. I can tell you that much.""** | `[352]` **Hugo Toras**: ""What do you make of the ATO dev..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Vina Toras"); RemoveConversant("Hugo To...`<br>`AddTokenStatus("Rizia_Country_Lespia","Country_ATO");` | `[13]` **Narrator**: "I had barely even started my rei..." |
| `[355]` | **""It seems like a lot of fuss over nothing.""** | `[352]` **Hugo Toras**: ""What do you make of the ATO dev..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Vina Toras"); RemoveConversant("Hugo To...`<br>`AddTokenStatus("Rizia_Country_Lespia","Country_ATO");` | `[13]` **Narrator**: "I had barely even started my rei..." |
| `[361]` | **""It was fine. You know how it is.""** | `[29]` **Lucita Azaro**: ""I'm sure the proceedings were v..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucita Azaro**: ""Let's hope that something usefu..." |
| `[367]` | **""Those works are only chaotic to the untrained ear, Hugo. Listen to them for long ..."** | `[366]` **Hugo Toras**: ""Ah, yes. Albeni was an excellen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Hugo Toras**: ""I beg your pardon, Your Majesty..." |
| `[368]` | **""Same here. If I wanted to hear two hours of ear-splitting screeching, I'd pay a v..."** | `[366]` **Hugo Toras**: ""Ah, yes. Albeni was an excellen..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[371]` **Narrator**: "Laurento reeled in shock. Lucita..." |
| `[369]` | **""It's precisely that chaos that makes them so compelling. He's pushing the boundar..."** | `[366]` **Hugo Toras**: ""Ah, yes. Albeni was an excellen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Hugo Toras**: ""Boundaries exist for a reason, ..." |
| `[370]` | **""Music is a reflection of the times. Our era is far from neat and orderly; why sho..."** | `[366]` **Hugo Toras**: ""Ah, yes. Albeni was an excellen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[378]` **Laurento Esquibel**: ""That's up for debate, Your Maje..." |
| `[382]` | **""Yes, why did my father even raise the age to 24, anyway?""** | `[381]` **Lucita Azaro**: ""I would also suggest extending ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Hugo Toras**: ""24 is the age by which a person..." |
| `[383]` | **""I can't send kids to war.""** | `[381]` **Lucita Azaro**: ""I would also suggest extending ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Vina Toras**: ""18-year-olds are hardly 'kids',..."<br>`[402]` **Hugo Toras**: ""I agree that young people, espe..." |
| `[387]` | **""Hell, I joined the military at 18. It did me a world of good.""** | `[381]` **Lucita Azaro**: ""I would also suggest extending ..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[403]` **Hugo Toras**: ""You were unusually mature for y..." |
| `[388]` | **""18 is too young. I myself wish I'd joined the military later in life.""** | `[381]` **Lucita Azaro**: ""I would also suggest extending ..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[408]` **Vina Toras**: ""18 isn't that young, Your Majes..."<br>`[402]` **Hugo Toras**: ""I agree that young people, espe..." |
| `[401]` | **""Such as rebelling against their general.""** | `[398]` **Hugo Toras**: ""I mean no offense, Your Highnes..."<br>`[399]` **Hugo Toras**: ""Young people, especially young ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Lucita Azaro**: ""As I've said, the 1920s were ex..." |
| `[409]` | **""They get a little too trigger-happy, you mean.""** | `[398]` **Hugo Toras**: ""I mean no offense, Your Highnes..."<br>`[399]` **Hugo Toras**: ""Young people, especially young ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Lucita Azaro**: ""Not with proper training, Your ..." |
| `[410]` | **""No, I disagree. If you're old enough to vote, you're old enough to fight for your..."** | `[398]` **Hugo Toras**: ""I mean no offense, Your Highnes..."<br>`[399]` **Hugo Toras**: ""Young people, especially young ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Lucita Azaro**: ""My thoughts exactly."" |
| `[411]` | **""That's simply not true. I feel my mind was at its sharpest as a young man.""** | `[399]` **Hugo Toras**: ""Young people, especially young ..."<br>`[400]` **Hugo Toras**: ""Indeed not, Your Highness. But ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[415]` **Lucita Azaro**: ""You're sharp now, Your Majesty...." |
| `[442]` | **""This is alarming. We need immediate measures to rectify this situation.""** | `[62]` **Lucita Azaro**: ""As a result, Your Majesty, we a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Lucita Azaro**: ""If you ask me, an immediate aud..." |
| `[443]` | **""While modernizing the military is a significant challenge, we can't simply throw ..."** | `[465]` **Lucita Azaro**: ""But the way I see it, this is o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Lucita Azaro**: ""Efficiency is key. We must stra..." |
| `[445]` | **""Understanding the details will help us plan more effectively. Tell me more.""** | `[62]` **Lucita Azaro**: ""As a result, Your Majesty, we a..."<br>`[465]` **Lucita Azaro**: ""But the way I see it, this is o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Lucita Azaro**: ""We're facing shortages in criti..."<br>`[476]` **Lucita Azaro**: ""While our equipment stockpile h..."<br>*(oraz 2 innych odgałęzień)* |
| `[458]` | **""Time to move on to other matters.""** | `[65]` **Lucita Azaro**: ""I'm here to answer them, Your M..."<br>`[102]` **Lucita Azaro**: ""I look forward to that conversa..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true` | *Brak zmian stanu* | `[64]` **Player_Romus**: ""I have a few more questions reg..."<br>`[69]` **Player_Romus**: ""Does our internal security need..."<br>*(oraz 2 innych odgałęzień)* |
| `[466]` | **""I don't like what you're implying about King Valero the First. Attempts to slande..."** | `[62]` **Lucita Azaro**: ""As a result, Your Majesty, we a..."<br>`[465]` **Lucita Azaro**: ""But the way I see it, this is o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable[...` | `[468]` **Lucita Azaro**: ""I-- I beg your pardon. I only m..." |
| `[500]` | **""How do the costs of training and equipping our units compare?""** | `[427]` **Lucita Azaro**: ""Ultimately, it's the readiness ..."<br>`[501]` **Lucita Azaro**: ""The costs vary by unit. Obvious..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == false` | *Brak zmian stanu* | `[501]` **Lucita Azaro**: ""The costs vary by unit. Obvious..." |
| `[502]` | **""How long does it take to prepare a unit from basic training to full combat readin..."** | `[427]` **Lucita Azaro**: ""Ultimately, it's the readiness ..."<br>`[501]` **Lucita Azaro**: ""The costs vary by unit. Obvious..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == false` | *Brak zmian stanu* | `[503]` **Lucita Azaro**: ""The majority of our units reach..." |
| `[504]` | **""What's the point of keeping our troops in a constant state of readiness? It's not..."** | `[427]` **Lucita Azaro**: ""Ultimately, it's the readiness ..."<br>`[501]` **Lucita Azaro**: ""The costs vary by unit. Obvious..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == false` | *Brak zmian stanu* | `[505]` **Lucita Azaro**: ""Not yet. But given the shifting..." |
| `[518]` | **""I'm no master strategist. Are you expecting me to draw up plans for our troops?""** | `[427]` **Lucita Azaro**: ""Ultimately, it's the readiness ..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == false  and  Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == false`<br>`Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == false` | *Brak zmian stanu* | `[521]` **Narrator**: "She laughed lightly." |
| `[519]` | **""The entire armed forces of Rizia, under my sole command... I've been waiting my w..."** | `[427]` **Lucita Azaro**: ""Ultimately, it's the readiness ..." | `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == false  and  Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == false) == false`<br>`Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == false` | *Brak zmian stanu* | `[520]` **Narrator**: "I saw a gleam in her eye." |
| `[527]` | **""I appreciate all this information. I'll relay my instructions to you after this m..."** | `[427]` **Lucita Azaro**: ""Ultimately, it's the readiness ..."<br>`[501]` **Lucita Azaro**: ""The costs vary by unit. Obvious..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == true` | *Brak zmian stanu* | `[528]` **Narrator**: "Lucita nodded with satisfaction." |
| `[533]` | **""No need to say any more. If you all will excuse me, I'm going to get started at o..."** | `[62]` **Lucita Azaro**: ""As a result, Your Majesty, we a..."<br>`[465]` **Lucita Azaro**: ""But the way I see it, this is o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[534]` **Narrator**: "Lucita raised an eyebrow." |
| `[536]` | **""Not right now. But I'm looking forward to many more private discussions with you ..."** | `[535]` **Lucita Azaro**: ""You don't want to hear any more?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable[...` | `[544]` **Narrator**: "She smiled coyly." |
| `[538]` | **""Actually, I do have a few questions related to military and security.""** | `[535]` **Lucita Azaro**: ""You don't want to hear any more?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[540]` **Lucita Azaro**: ""By all means, go ahead."" |
| `[545]` | **""No, thanks. I have plenty of my own ideas for the military without House Azaro's ..."** | `[535]` **Lucita Azaro**: ""You don't want to hear any more?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable[...` | `[547]` **Narrator**: "Her expression soured." |
| `[549]` | **""I had a vision, Duchess. The Lord has shown me the way.""** | `[535]` **Lucita Azaro**: ""You don't want to hear any more?"" | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true` | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[553]` **Narrator**: "Sal grinned triumphantly. A trou..." |

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
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Facing a blunt report on the state of th..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Laurento Esquibel**
> ""I just received official confirmation that our neighbor has been accepted into the Arcasian Treaty Organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""Wehlen?""*)
  - -> `[5]` (*Player_Romus: ""Morella?""*)
  - -> `[6]` (*Player_Romus: ""Lespia?""*)
  - -> `[7]` (*Player_Romus: ""Derdia?""*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""Are you trying to be humorous, Your Majesty?""*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Morella?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""Are you trying to be humorous, Your Majesty?""*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Laurento Esquibel: ""Precisely. Prime Minister Alvarez will make the official..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Derdia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""Are you trying to be humorous, Your Majesty?""*)

### Węzeł `[8]`
Mówca: **Laurento Esquibel**
> ""Precisely. Prime Minister Alvarez will make the official announcement tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucita Azaro: ""Didn't we all see this coming? It should hardly be a sur..."*)

### Węzeł `[9]`
Mówca: **Lucita Azaro**
> ""Didn't we all see this coming? It should hardly be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Laurento Esquibel: ""Indeed, this development has been on the horizon for som..."*)

### Węzeł `[10]`
Mówca: **Lucita Azaro**
> ""Are you trying to be humorous, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Laurento Esquibel: ""I'm sure that was a joke. He knows it could only have be..."*)

### Węzeł `[11]`
Mówca: **Laurento Esquibel**
> ""I'm sure that was a joke. He knows it could only have been Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucita Azaro: ""Didn't we all see this coming? It should hardly be a sur..."*)

### Węzeł `[12]`
Mówca: **Hugo Toras**
> ""Thank you for updating us, Mr. Esquibel. I suggest we set a date for a meeting to discuss Lespia's ATO membership as well as our general foreign policy strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: ""I don't see the urgency. We won't be expected to respond..."*)
  - -> `[329]` (*Player_Romus: ""Preferably as soon as possible. We must decide on our of..."*)
  - -> `[328]` (*Player_Romus: ""Excellent suggestion, Your Grace.""*)

### Węzeł `[13]`
Mówca: **Narrator**
> "I had barely even started my reign, and it already felt like the ground was shifting beneath my feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "What other challenges lay in store?"*)

### Węzeł `[14]`
Mówca: **Narrator**
> "What other challenges lay in store?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_G_LespiaATO = true"*)

### Węzeł `[15]`
Mówca: **Laurento Esquibel**
> ""Indeed, this development has been on the horizon for some time. But our relations with our neighbors are sure to change because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Hugo Toras: ""Thank you for updating us, Mr. Esquibel. I suggest we se..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "On the way back from the Plavo Archsanctuary, I met my council in the city of Folce Dator for a briefing on our security and military situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "The so-called "Forge of Rizia" was famous for its numerou..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "The so-called "Forge of Rizia" was famous for its numerous foundries and factories, in which iron from the nearby hills was transformed into rifles and handguns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Largest of them all was the Royal Folce Foundry, responsi..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Largest of them all was the Royal Folce Foundry, responsible for supplying the Rizian police and military. The red brick complex towered at the end of the King's Avenue, Folce Dator's main road."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro"); AddConversant("Hugo Toras"..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "My council and I were given a tour of the facilities before settling around the table in the foundry's Great Hall. Murals on the walls around us depicted the city's history as an industrial center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "As duchess of the province and my war and security counci..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "As duchess of the province and my war and security councilor, Lucita sat at the head of the table. She nodded at the rest of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> ""Your Majesty, Your Highness, my esteemed fellow councilors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucita Azaro: ""I planned this meeting here so that the King would have ..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucita Azaro: ""Your Majesty, Your Highness, my esteemed fellow councilo..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucita Azaro: ""Your Majesty, my esteemed fellow councilors.""*)

### Węzeł `[25]`
Mówca: **Lucita Azaro**
> ""Your Majesty, my esteemed fellow councilors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucita Azaro: ""I planned this meeting here so that the King would have ..."*)

### Węzeł `[26]`
Mówca: **Lucita Azaro**
> ""I planned this meeting here so that the King would have a shorter journey after his consecration ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "A corner of her mouth twisted upwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucita Azaro: ""Serendipitously, His Majesty's wise rejection of the cer..."*)

### Węzeł `[28]`
Mówca: **Lucita Azaro**
> ""Serendipitously, His Majesty's wise rejection of the ceremony has left us with more time to spend in this fine city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo wore a disproving look on his face. Across from me, ..."*)

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""I'm sure the proceedings were very taxing, Your Majesty. Whatever they were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""What happened in Plavo is between me and God.""*)
  - -> `[31]` (*Player_Romus: ""You're wrong, Duchess Azaro. I have never felt so invigo..."*)
  - -> `[32]` (*Player_Romus: ""It was taxing, for sure. But it was my duty as King to b..."*)
  - -> `[361]` (*Player_Romus: ""It was fine. You know how it is.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happened in Plavo is between me and God.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucita Azaro: ""And the Grand Wiseman, of course.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're wrong, Duchess Azaro. I have never felt so invigorated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucita Azaro: ""I'm glad to hear it. Religion has that effect on some pe..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was taxing, for sure. But it was my duty as King to bear that burden.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucita Azaro: ""Let's hope that something useful came out of all that.""*)

### Węzeł `[33]`
Mówca: **Lucita Azaro**
> ""Let's hope that something useful came out of all that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Sal was sitting across from me, still wearing his robes. ..."*)

### Węzeł `[34]`
Mówca: **Lucita Azaro**
> ""I'm glad to hear it. Religion has that effect on some people, I'm told.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Sal was sitting across from me, still wearing his robes. ..."*)

### Węzeł `[35]`
Mówca: **Lucita Azaro**
> ""And the Grand Wiseman, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Sal was sitting across from me, still wearing his robes. ..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Sal was sitting across from me, still wearing his robes. He smiled enigmatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Sal Ignacius: ""I am but a lowly conduit between His Majesty and the pow..."*)

### Węzeł `[37]`
Mówca: **Sal Ignacius**
> ""I am but a lowly conduit between His Majesty and the powers above, Ms. Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Hugo nodded approvingly."*)

### Węzeł `[38]`
Mówca: **Sal Ignacius**
> ""Even if you are not a believer, Ms. Azaro, I assure you the six stars of St. Wruhec shine upon your house and our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Hugo nodded approvingly."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Sal was sitting across from me, still wearing his robes. He smiled enigmatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Sal Ignacius: ""Even if you are not a believer, Ms. Azaro, I assure you ..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Sal was sitting across from me, still wearing his robes. He smiled enigmatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Sal Ignacius: ""Religion is not a tool to be used, Ms. Azaro. It is a gu..."*)

### Węzeł `[41]`
Mówca: **Sal Ignacius**
> ""Religion is not a tool to be used, Ms. Azaro. It is a guiding light that shines even on those who do not believe in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Hugo nodded approvingly."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "Hugo nodded approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Hugo Toras: ""I know better than to pry into the contents of the cerem..."*)

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""I know better than to pry into the contents of the ceremony, Your Majesty. But I will say I hope it was an enlightening experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""You may proceed with your briefing, Duchess Azaro.""*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""You may proceed with your briefing, Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucita Azaro: ""With great pleasure, Your Grace.""*)

### Węzeł `[45]`
Mówca: **Lucita Azaro**
> ""With great pleasure, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "She gestured at one of the murals on the wall. It depicte..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "She gestured at one of the murals on the wall. It depicted a beautiful but severe-looking woman riding a horse down the King's Avenue, her rifle at the ready."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucita Azaro: ""My ancestress Ana Azaro ordered the construction of this..."*)

### Węzeł `[47]`
Mówca: **Lucita Azaro**
> ""My ancestress Ana Azaro ordered the construction of this foundry in 1812, immediately after the end of the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucita Azaro: ""House Azaro knows that 'peacetime' is not a period of re..."*)

### Węzeł `[48]`
Mówca: **Lucita Azaro**
> ""House Azaro knows that 'peacetime' is not a period of rest. It is a time to gather our strength and hone our weapons for when they are next needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucita Azaro: ""Because they most certainly *will* be needed.""*)

### Węzeł `[49]`
Mówca: **Lucita Azaro**
> ""Because they most certainly *will* be needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""That's a rather pessimistic view, Duchess Azaro. Isn't p..."*)
  - -> `[52]` (*Player_Romus: ""We can also use peacetime to form new alliances and impr..."*)
  - -> `[53]` (*Player_Romus: ""Yes, we should remain vigilant and prepared. But not to ..."*)
  - -> `[51]` (*Player_Romus: ""I agree with you completely, Duchess. Rizia has become s..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a rather pessimistic view, Duchess Azaro. Isn't peace the final state that all nations strive towards?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist += 1"*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with you completely, Duchess. Rizia has become soft and complacent during these conflict-free years.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist -= 1"*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can also use peacetime to form new alliances and improve international relations. Strength is about more than just weaponry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Laurento Esquibel: ""Well said, Your Majesty.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we should remain vigilant and prepared. But not to the point where our military focus detracts from the needs of the Rizian people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucita Azaro: ""Safety is at the top of the hierarchy of our people's ne..."*)

### Węzeł `[54]`
Mówca: **Laurento Esquibel**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""Alliances can shift. Treaties can be broken. We should n..."*)

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""Alliances can shift. Treaties can be broken. We should not be so naive as to assume every nation will respect diplomatic boundaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "I could hear the passion rising in her voice."*)

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Safety is at the top of the hierarchy of our people's needs, is it not? Everything else is optional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "I could hear the passion rising in her voice."*)

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""Ideally, maybe. But reality has taught us that peace is fragile. We can only preserve it with hard work and a firm hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "I could hear the passion rising in her voice."*)

### Węzeł `[58]`
Mówca: **Lucita Azaro**
> ""Not without reason, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "I could hear the passion rising in her voice."*)

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""Our failure to win the Reclamation War and the rebellion of 1926 served as a double blow to the Rizian armed forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucita Azaro: ""Even after my father purged the troops and general staff..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "I could hear the passion rising in her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucita Azaro: ""Our failure to win the Reclamation War and the rebellion..."*)

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""Even after my father purged the troops and general staff of all suspected traitors to the throne, His Majesty King Valero was reluctant to restore our military to its former strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces == true"*)

### Węzeł `[62]`
Mówca: **Lucita Azaro**
> ""As a result, Your Majesty, we are ludicrously underprepared for a country of our size.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Player_Romus: ""No need to say any more. If you all will excuse me, I'm ..."*)
  - -> `[466]` (*Player_Romus: ""I don't like what you're implying about King Valero the ..."*)
  - -> `[442]` (*Player_Romus: ""This is alarming. We need immediate measures to rectify ..."*)
  - -> `[445]` (*Player_Romus: ""Understanding the details will help us plan more effecti..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "With lightning speed, she reached under the table, pulled out a knife and hurled it in the direction of the doorway. Titus languidly snatched it out of the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[262]` (*Player_Romus: ""You made your point. No need to put on a show.""*)
  - -> `[256]` (*Player_Romus: ""You brought a weapon to a council meeting, Duchess?""*)
  - -> `[255]` (*Player_Romus: ""Very good. Your house should be commended for its deep d..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have a few more questions regarding the military.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == false`
- **Kontekst wejściowy (poprzednik):** `[266]` (Lucita Azaro), `[242]` (Lucita Azaro), `[458]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Military = true"*)

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""I'm here to answer them, Your Majesty. Where should I start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Military sub-hub"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the state of our military production industry?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucita Azaro), `[102]` (Lucita Azaro), `[304]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_Weapons = true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me more about our naval and air capabilities.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucita Azaro), `[102]` (Lucita Azaro), `[304]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_NavyAir = true"*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's talk about army conscription. How do we bolster our ranks?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucita Azaro), `[102]` (Lucita Azaro), `[304]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_Conscription = true"*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Does our internal security need improvement as well?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == false`
- **Kontekst wejściowy (poprzednik):** `[266]` (Lucita Azaro), `[242]` (Lucita Azaro), `[458]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Less so, Your Majesty. Our police forces have kept a fir..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Lucita sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucita Azaro: ""Despite our very grand surroundings, we have long neglec..."*)

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""Despite our very grand surroundings, we have long neglected the potential of Folce Dator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucita Azaro: ""Rumburg currently supplies us with the bulk of our weapo..."*)

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""Rumburg currently supplies us with the bulk of our weaponry, including their KA-74 rifles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucita Azaro: ""But if we invested more into research, development and p..."*)

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""But if we invested more into research, development and production in this city, our small arms industry could become a real force to be reckoned with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""I don't see the need for that. It seems easier and cheap..."*)
  - -> `[81]` (*Player_Romus: ""Do we have the capability to build larger weapons too?""*)
  - -> `[82]` (*Player_Romus: ""I imagine that would give a boost to the local economy a..."*)
  - -> `[83]` (*Player_Romus: ""We've got to take our diplomatic stance into account. Wo..."*)

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""Our navy has actually made significant strides in the past 30 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucita Azaro: ""We are a coastal nation, after all, and our fleet is bot..."*)

### Węzeł `[75]`
Mówca: **Lucita Azaro**
> ""We are a coastal nation, after all, and our fleet is both well-trained and up to date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucita Azaro: ""Our submarines could use improvement, though. Compared t..."*)

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""Our submarines could use improvement, though. Compared to those currently coming out of Rumburg and Valgsland, they're practically ancient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucita Azaro: ""Our air force, meanwhile, is still suffering the consequ..."*)

### Węzeł `[77]`
Mówca: **Lucita Azaro**
> ""Our ranks are looking healthy already, Your Majesty. But since you asked...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucita Azaro: ""As you know, our central royal army is fed both by gener..."*)

### Węzeł `[78]`
Mówca: **Lucita Azaro**
> ""As you know, our central royal army is fed both by general conscription and levies from the individual provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucita Azaro: ""If you ask me, the provincial armies should be pulling m..."*)

### Węzeł `[79]`
Mówca: **Lucita Azaro**
> ""If you ask me, the provincial armies should be pulling more weight. Though I do understand that those of Brenas and Valenqiris are not nearly as well trained as Cardesse-Montaklar's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Lucita Azaro: ""I would also suggest extending the length of our conscri..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see the need for that. It seems easier and cheaper to continue importing from Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucita Azaro: ""Producing our own weapons would save us untold amounts i..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do we have the capability to build larger weapons too?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucita Azaro: ""Not currently, Your Majesty. Even if we were able to beg..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I imagine that would give a boost to the local economy as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Elena Werner: ""It would, Your Majesty. As long as there were enough peo..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to take our diplomatic stance into account. Wouldn't a sudden increase in arms production be seen as provocation by our neighbors?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""On the contrary, Your Majesty, it might serve as a deter..."*)

### Węzeł `[84]`
Mówca: **Elena Werner**
> ""It would, Your Majesty. As long as there were enough people available to fill the new positions that would be created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucita Azaro: ""We would unfortunately still have to rely on Rumburg for..."*)

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""Not currently, Your Majesty. Even if we were able to begin production in that sector immediately, it would take years before our missile technology caught up to, say, Derdia's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Hmm. A weapons deal with Derdia could help improve relat..."*)
  - -> `[90]` (*Player_Romus: ""We shouldn't bother with Derdia. I'm counting on a stabl..."*)
  - -> `[91]` (*Player_Romus: ""I doubt Derdia will sell us weapons considering our reli..."*)
  - -> `[94]` (*Player_Romus: ""This is ridiculous. What would we need missiles for?""*)

### Węzeł `[86]`
Mówca: **Lucita Azaro**
> ""Producing our own weapons would save us untold amounts in the long run. We could even ask Rumburg for a license to make our own KA-74s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucita Azaro: ""On the other hand, larger arms such as missiles are best..."*)

### Węzeł `[87]`
Mówca: **Lucita Azaro**
> ""On the other hand, larger arms such as missiles are best purchased from Rumburg. Or barring that, Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Hmm. A weapons deal with Derdia could help improve relat..."*)
  - -> `[90]` (*Player_Romus: ""We shouldn't bother with Derdia. I'm counting on a stabl..."*)
  - -> `[91]` (*Player_Romus: ""I doubt Derdia will sell us weapons considering our reli..."*)
  - -> `[94]` (*Player_Romus: ""This is ridiculous. What would we need missiles for?""*)

### Węzeł `[88]`
Mówca: **Lucita Azaro**
> ""We would unfortunately still have to rely on Rumburg for weaponry such as missiles. Although I've also seen promising developments in Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Hmm. A weapons deal with Derdia could help improve relat..."*)
  - -> `[90]` (*Player_Romus: ""We shouldn't bother with Derdia. I'm counting on a stabl..."*)
  - -> `[91]` (*Player_Romus: ""I doubt Derdia will sell us weapons considering our reli..."*)
  - -> `[94]` (*Player_Romus: ""This is ridiculous. What would we need missiles for?""*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. A weapons deal with Derdia could help improve relations between our countries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Lucita Azaro), `[87]` (Lucita Azaro), `[88]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Laurento Esquibel: ""It would depend on what they'd demand in return, Your Ma..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shouldn't bother with Derdia. I'm counting on a stable trade relationship with Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Lucita Azaro), `[87]` (Lucita Azaro), `[88]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Laurento Esquibel: ""Yes, I'm afraid any negotiation with Derdia would be mor..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt Derdia will sell us weapons considering our religious differences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Lucita Azaro), `[87]` (Lucita Azaro), `[88]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Laurento Esquibel: ""Everyone has a price, Your Majesty. It would depend on w..."*)

### Węzeł `[92]`
Mówca: **Laurento Esquibel**
> ""It would depend on what they'd demand in return, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Laurento Esquibel: ""But I've set aside time to discuss Derdia during our upc..."*)

### Węzeł `[93]`
Mówca: **Laurento Esquibel**
> ""Yes, I'm afraid any negotiation with Derdia would be more trouble than it's worth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Laurento Esquibel: ""But I've set aside time to discuss Derdia during our upc..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is ridiculous. What would we need missiles for?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Lucita Azaro), `[87]` (Lucita Azaro), `[88]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucita Azaro: ""The wars to come will not be fought with guns alone, You..."*)

### Węzeł `[95]`
Mówca: **Lucita Azaro**
> ""The wars to come will not be fought with guns alone, Your Majesty. We all know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Laurento Esquibel: ""I personally believe attempting to sign an arms deal wit..."*)

### Węzeł `[96]`
Mówca: **Laurento Esquibel**
> ""Everyone has a price, Your Majesty. It would depend on what Rizia is willing to pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Laurento Esquibel: ""But I've set aside time to discuss Derdia during our upc..."*)

### Węzeł `[97]`
Mówca: **Laurento Esquibel**
> ""But I've set aside time to discuss Derdia during our upcoming foreign policy meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucita Azaro: ""I look forward to that conversation, Mr. Esquibel. Where..."*)

### Węzeł `[98]`
Mówca: **Laurento Esquibel**
> ""I personally believe attempting to sign an arms deal with Derdia would be more trouble than it's worth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Laurento Esquibel: ""But I've set aside time to discuss Derdia during our upc..."*)

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""On the contrary, Your Majesty, it might serve as a deterrent. A nation that invests in producing high-quality weaponry is not one that you want to provoke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Elena Werner: ""Actually, were our foundries in Folce Dator to become pr..."*)

### Węzeł `[100]`
Mówca: **Elena Werner**
> ""Actually, were our foundries in Folce Dator to become productive enough, we could use rifles as yet another trade resource.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucita Azaro: ""I suggest we think about procuring larger weapons as wel..."*)

### Węzeł `[101]`
Mówca: **Lucita Azaro**
> ""I suggest we think about procuring larger weapons as well. Derdian missiles, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Hmm. A weapons deal with Derdia could help improve relat..."*)
  - -> `[90]` (*Player_Romus: ""We shouldn't bother with Derdia. I'm counting on a stabl..."*)
  - -> `[91]` (*Player_Romus: ""I doubt Derdia will sell us weapons considering our reli..."*)
  - -> `[94]` (*Player_Romus: ""This is ridiculous. What would we need missiles for?""*)

### Węzeł `[102]`
Mówca: **Lucita Azaro**
> ""I look forward to that conversation, Mr. Esquibel. Where were we, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military sub-hub]"*)

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""Our air force, meanwhile, is still suffering the consequences of the Pales campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "Laurento nodded grimly."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == false && RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == false && RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == false  and  Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "A corner of her mouth twisted upwards."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == false && RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == false  and  Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucita Azaro: ""I'm sure the proceedings were very taxing, Your Majesty...."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Hugo wore a disproving look on his face. Across from me, Sal was smiling beatifically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player_Romus: ""I don't need a ceremony to validate my God-given right t..."*)
  - -> `[109]` (*Player_Romus: ""My apologies once again, Grand Wiseman Ignacius. I did n..."*)
  - -> `[110]` (*Player_Romus: ""I made the right decision. Arcane religious rituals have..."*)
  - -> `[111]` (*Player_Romus: ""I had my reasons for not participating in the ceremony. ..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need a ceremony to validate my God-given right to rule.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Hugo Toras: ""Whatever your personal feelings about the ceremony, Your..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My apologies once again, Grand Wiseman Ignacius. I did not mean to disrespect the Wruhecist faith.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Sal Ignacius: ""Do not fear, Your Majesty. The divine path is yours to f..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made the right decision. Arcane religious rituals have no place in modern politics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Sal Ignacius: ""These rituals connect us to our past. A good leader draw..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had my reasons for not participating in the ceremony. I don't want any of you questioning them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Sal Ignacius: ""Quite right. A man's faith is a personal matter. The Kin..."*)

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""Whatever your personal feelings about the ceremony, Your Majesty, Rizia is a Wruhecist country. Breaking such a centuries-old tradition will have repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Sal Ignacius: ""Do not chastise your nephew too harshly, Your Grace. Kin..."*)

### Węzeł `[113]`
Mówca: **Sal Ignacius**
> ""These rituals connect us to our past. A good leader draws not only on God for guidance, but on those who came before him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Hugo Toras: ""The public will not approve of your decision, Your Majes..."*)

### Węzeł `[114]`
Mówca: **Sal Ignacius**
> ""Do not chastise your nephew too harshly, Your Grace. King Romus must find the divine path on his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Hugo Toras: ""Thank you for your reminder, Grand Wiseman. I am sure he..."*)

### Węzeł `[115]`
Mówca: **Sal Ignacius**
> ""Do not fear, Your Majesty. The divine path is yours to find on your own. Nobody can force you onto it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Hugo Toras: ""Still, Rizia is a Wruhecist country. It might have been ..."*)

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""Still, Rizia is a Wruhecist country. It might have been wise to participate if only for the public's approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Hugo Toras: ""But what's been done is done.""*)

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""The public will not approve of your decision, Your Majesty. But perhaps it will command respect among certain international factions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Hugo Toras: ""At any rate... what's been done is done.""*)

### Węzeł `[118]`
Mówca: **Sal Ignacius**
> ""Quite right. A man's faith is a personal matter. The King must be allowed to find his path on his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Hugo Toras: ""Halaita, Grand Wiseman.""*)

### Węzeł `[119]`
Mówca: **Hugo Toras**
> ""Halaita, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""You may proceed with your briefing, Duchess Azaro.""*)

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""But what's been done is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""You may proceed with your briefing, Duchess Azaro.""*)

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""At any rate... what's been done is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""You may proceed with your briefing, Duchess Azaro.""*)

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Thank you for your reminder, Grand Wiseman. I am sure he will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""You may proceed with your briefing, Duchess Azaro.""*)

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""Less so, Your Majesty. Our police forces have kept a firm handle on our populace since the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Arrests == true"*)

### Węzeł `[124]`
Mówca: **Lucita Azaro**
> ""Civil disobedience in Valenqiris, for example, is at a historic low thanks to your zero-tolerance policies as Duke. Not that it's ever been high in the era of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucita Azaro: ""My own anti-crime efforts in Montaklar appear to be payi..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Arrests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Arrests == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_Arrests == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Arrests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucita Azaro: ""Civil disobedience in Valenqiris, for example, is at a h..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_Arrests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lucita Azaro: ""Civil disobedience in Montaklar, for example, is at a hi..."*)

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""Civil disobedience in Montaklar, for example, is at a historic low thanks to my zero-tolerance policies as Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucita Azaro: ""Valenqiris, too, is unlikely to pose major difficulties ..."*)

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""My own anti-crime efforts in Montaklar appear to be paying off as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucita Azaro: ""And the Central Police, headquartered in Rizia Imperii, ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_InternalSecurity = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "Jump to: [Security/Military Hub]"*)

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""No, indeed. Iza has been experiencing periods of unrest ever since the handover of Zille and the exile of Duchess Angelica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucita Azaro: ""But we are seeing complications having to do with the We..."*)

### Węzeł `[132]`
Mówca: **Lucita Azaro**
> ""Valenqiris, too, is unlikely to pose major difficulties as long as House Toras is on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucita Azaro: ""And the Central Police, headquartered in Rizia Imperii, ..."*)

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""The members of House Sazon who rule Brenas have mostly fallen in line following the uprising. They're content to use the House of Delegates as a forum for their grievances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "She took a deep breath."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's no surprise that giving part of Brenas to House Toras would divide the region.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""No, indeed. Iza has been experiencing periods of unrest ..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me guess. The Wehzek and Derdian newcomers have been causing problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucita Azaro: ""It's complicated, Your Majesty.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew it. The city was always a stronghold for anti-monarchists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucita Azaro: ""We are not seeing anti-monarchist activity in Iza, Your ..."*)

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Well... ruling the Brenas capital after its transfer to House Toras would not be an easy task for anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Lucita Azaro: ""Complicating matters are the large numbers of Wehzek mig..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? Is my cousin failing in his duties as Duke?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucita Azaro: ""Well... ruling the Brenas capital after its transfer to ..."*)

### Węzeł `[139]`
Mówca: **Lucita Azaro**
> ""And the Central Police, headquartered in Rizia Imperii, have been keeping the capital secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucita Azaro: ""The members of House Sazon who rule Brenas have mostly f..."*)

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""We are not seeing anti-monarchist activity in Iza, Your Majesty. At least on the surface.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucita Azaro: ""But we are seeing complications having to do with the We..."*)

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""It's complicated, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucita Azaro: ""Large numbers of migrants, particularly Wehzeks fleeing ..."*)

### Węzeł `[142]`
Mówca: **Lucita Azaro**
> ""Complicating matters are the large numbers of Wehzek migrants who settled in the city following the Civil War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucita Azaro: ""As I mentioned in our earlier meeting, some turned to th..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "She took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucita Azaro: ""If there's a problem area, it's Iza.""*)

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""If there's a problem area, it's Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus: ""What? Is my cousin failing in his duties as Duke?""*)
  - -> `[136]` (*Player_Romus: ""I knew it. The city was always a stronghold for anti-mon..."*)
  - -> `[135]` (*Player_Romus: ""Let me guess. The Wehzek and Derdian newcomers have been..."*)
  - -> `[134]` (*Player_Romus: ""It's no surprise that giving part of Brenas to House Tor..."*)

### Węzeł `[145]`
Mówca: **Lucita Azaro**
> ""But we are seeing complications having to do with the Wehzek migrants who settled in the city after the Civil War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucita Azaro: ""As I mentioned in our earlier meeting, some turned to th..."*)

### Węzeł `[146]`
Mówca: **Lucita Azaro**
> ""Large numbers of migrants, particularly Wehzeks fleeing the civil war, settled in the city in the '30s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucita Azaro: ""As I mentioned in our earlier meeting, some turned to th..."*)

### Węzeł `[147]`
Mówca: **Lucita Azaro**
> ""As I mentioned in our earlier meeting, some turned to the black market to supplement their meager 'guest worker' income, giving rise to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""What kind of black-market activities?""*)
  - -> `[149]` (*Player_Romus: ""We can't blame them. They had no other choice.""*)
  - -> `[150]` (*Player_Romus: ""Hugo, you were in Iza during the '30s. Didn't you try an..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of black-market activities?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lucita Azaro: ""The drug trade, mostly. There are cartels connected to f..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't blame them. They had no other choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""We gave them a home and employment, Your Majesty. They c..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo, you were in Iza during the '30s. Didn't you try and stop this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Hugo Toras: ""I implemented a community policing program. But the crim..."*)

### Węzeł `[151]`
Mówca: **Lucita Azaro**
> ""The drug trade, mostly. There are cartels connected to families in Wehlen, who in turn answer to powerful distributors in Agard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Hugo Toras: ""I attempted to tackle this myself with a community polic..."*)

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""We gave them a home and employment, Your Majesty. They chose to abuse our hospitality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Lucita sniffed."*)

### Węzeł `[153]`
Mówca: **Hugo Toras**
> ""I implemented a community policing program. But the criminal networks were too strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Lucita sniffed."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Lucita sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lucita Azaro: ""In my opinion, the growing influence of the nationalist ..."*)

### Węzeł `[155]`
Mówca: **Lucita Azaro**
> ""In my opinion, the growing influence of the nationalist group Su Omina has only inflamed tensions in the area.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[156]`
Mówca: **Hugo Toras**
> ""I attempted to tackle this myself with a community policing program. But the networks were too strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Lucita sniffed."*)

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""The King, of course, might disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player_Romus: ""Just because I supported the group in my younger days do..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC...."*)
  - -> `[163]` (*Player_Romus: ""I believe Su Omina was founded with good intentions. But..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucita Azaro: ""The King, of course, might disagree.""*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucita Azaro: ""Certain members of House Toras may disagree, of course.""*)

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""Certain members of House Toras may disagree, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC...."*)
  - -> `[163]` (*Player_Romus: ""I believe Su Omina was founded with good intentions. But..."*)
  - -> `[169]` (*Player_Romus: ""My cousin Rico has witnessed Iza's problems firsthand. I..."*)
  - -> `[164]` (*Player_Romus: ""I agree completely. The provocations of people like my c..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. A group like Su Omina is a necessary counter-correction to the problems caused by immigration.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[157]` (Lucita Azaro), `[161]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Hugo Toras: ""The good Rizians of Iza are doing their best with the re..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe Su Omina was founded with good intentions. But they may have made things worse without meaning to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Lucita Azaro), `[161]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Hugo Toras: ""The good Rizians of Iza are doing their best with the re..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree completely. The provocations of people like my cousin will only stoke the flames of violence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Hugo Toras: ""The good Rizians of Iza are doing their best with the re..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC...."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Absolutism == true || RiziaDL..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""Indeed. A group like Su Omina is a necessary counter-cor..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just because I supported the group in my younger days doesn't mean I do now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Hugo Toras: ""The good Rizians of Iza are doing their best with the re..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My cousin Rico has witnessed Iza's problems firsthand. If he supports Su Omina, it must be for a reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Hugo Toras: ""The good Rizians of Iza are doing their best with the re..."*)

### Węzeł `[170]`
Mówca: **Hugo Toras**
> ""The good Rizians of Iza are doing their best with the resources they've been given, Duchess. My son included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Hugo Toras: ""The problem as I see it lies in the lack of cooperation ..."*)

### Węzeł `[171]`
Mówca: **Hugo Toras**
> ""The problem as I see it lies in the lack of cooperation between the city's police force and those of the surrounding region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucita Azaro: ""Yes, I've received Duke Rico's complaints that the Brena..."*)

### Węzeł `[172]`
Mówca: **Lucita Azaro**
> ""Yes, I've received Duke Rico's complaints that the Brenas forces have not been providing him with as much aid as he wishes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucita Azaro: ""As well as his requests that extra police from our centr..."*)

### Węzeł `[173]`
Mówca: **Lucita Azaro**
> ""As well as his requests that extra police from our central forces be transferred to Iza and placed under his command. But I don't think that would solve anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""And why not, Duchess Azaro? I thought you were tough on ..."*)
  - -> `[176]` (*Player_Romus: ""It would set a dangerous precedent. We can't have the ot..."*)
  - -> `[178]` (*Player_Romus: ""Why aren't the Brenas police cooperating?""*)
  - -> `[183]` (*Player_Romus: ""You're right. Extra force won't solve anything. We need ..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why not, Duchess Azaro? I thought you were tough on crime yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucita Azaro: ""I believe in the power of a firm hand, Your Majesty. But..."*)

### Węzeł `[175]`
Mówca: **Lucita Azaro**
> ""I believe in the power of a firm hand, Your Majesty. But only when it's exercised with responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Hugo Toras: ""Are you calling my son irresponsible, Duchess?""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would set a dangerous precedent. We can't have the other provinces demanding the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lucita Azaro: ""Exactly.""*)

### Węzeł `[177]`
Mówca: **Lucita Azaro**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""Iza is a special case. I'm sure everyone is aware of that.""*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why aren't the Brenas police cooperating?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucita Azaro: ""They are providing some assistance. But my instinct is t..."*)

### Węzeł `[179]`
Mówca: **Lucita Azaro**
> ""They are providing some assistance. But my instinct is that they, like most of House Sazon, disagree with Duke Rico's policies and his associations with Su Omina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Hugo Toras: ""Their political views should not matter. Their job is to..."*)

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""Their political views should not matter. Their job is to protect and serve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucita Azaro: ""I have the situation under control, Your Grace. You don'..."*)

### Węzeł `[181]`
Mówca: **Hugo Toras**
> ""Are you calling my son irresponsible, Duchess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Lucita Azaro: ""I am saying that in the wrong hands, the Central Police ..."*)

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""Iza is a special case. I'm sure everyone is aware of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucita Azaro: ""I have the situation under control, Your Grace. You don'..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Extra force won't solve anything. We need to get to the root of the matter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucita Azaro: ""Force is absolutely necessary in some circumstances. But..."*)

### Węzeł `[184]`
Mówca: **Lucita Azaro**
> ""Force is absolutely necessary in some circumstances. But it must be wielded with responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Hugo Toras: ""Are you calling my son irresponsible, Duchess?""*)

### Węzeł `[185]`
Mówca: **Lucita Azaro**
> ""I am saying that in the wrong hands, the Central Police could legitimize Su Omina's campaign of oppression, rather than neutralize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Hugo opened his mouth to respond. Lucita pretended not to..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Hugo opened his mouth to respond. Lucita pretended not to notice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucita Azaro: ""Well, Your Majesty? Shall we continue with the briefing?""*)

### Węzeł `[187]`
Mówca: **Lucita Azaro**
> ""Well, Your Majesty? Shall we continue with the briefing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_InternalSecurity = true"*)

### Węzeł `[188]`
Mówca: **Lucita Azaro**
> ""I have the situation under control, Your Grace. You don't need to involve yourself with such a minor issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Hugo opened his mouth to respond. Lucita pretended not to..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Security/Military Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "Security/Military Hub"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Security/Military Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Military == false"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == false"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Intelligence == false"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Intelligence == true && ..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == false"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == fa..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""Does our internal security need improvement as well?""*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about our intelligence capabilities? They're just as important as our military strength.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == false`
- **Kontekst wejściowy (poprzednik):** `[266]` (Lucita Azaro), `[242]` (Lucita Azaro), `[458]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Lucita Azaro: ""I was getting to that, Your Majesty.""*)

### Węzeł `[195]`
Mówca: **Lucita Azaro**
> ""The Rizian Intelligence Service has operatives in Morella, Derdia, central Wehlen, Lespia and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucita Azaro: ""His Majesty Valero, however, insisted on withdrawing our..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Intelligence = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucita Azaro: ""Any other questions, Your Majesty?""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would he do that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucita Azaro: ""He was afraid their leaders would get suspicious. He may..."*)

### Węzeł `[198]`
Mówca: **Lucita Azaro**
> ""He was afraid their leaders would get suspicious. He may have been right, or it may have been his trademark paranoia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Laurento Esquibel: ""In my experience, we have much more to gain from straigh..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure he had a good reason for doing so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lucita Azaro: ""He believed their leaders were starting to get suspiciou..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Intelligence == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Intelligence == false"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Intelligence == false)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Intelligence == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""What about our intelligence capabilities? They're just a..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Intelligence == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[203]`
Mówca: **Lucita Azaro**
> ""His Majesty Valero, however, insisted on withdrawing our presence from Zille and Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus: ""Why would he do that?""*)
  - -> `[204]` (*Player_Romus: ""That's ridiculous. We need to keep a close watch on both..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == false"*)
  - -> `[199]` (*Player_Romus: ""I'm sure he had a good reason for doing so.""*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. We need to keep a close watch on both of those regions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucita Azaro: ""Yes, my father told him the same thing. He was afraid of..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good thinking. We cannot repair our ties with Wehlen and Pales if we don't trust each other.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == false`
- **Kontekst wejściowy (poprzednik):** `[203]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Laurento Esquibel: ""In my experience, we have much more to gain from straigh..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == false"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_TakeBackLand == false)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""Good thinking. We cannot repair our ties with Wehlen and..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_TakeBackLand == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[209]`
Mówca: **Lucita Azaro**
> ""Yes, my father told him the same thing. He was afraid of drawing their leaders' suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Laurento Esquibel: ""In my experience, we have much more to gain from straigh..."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Laurento sniffed indignantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Laurento Esquibel: ""What useful information were we receiving from either re..."*)

### Węzeł `[211]`
Mówca: **Laurento Esquibel**
> ""What useful information were we receiving from either region before the operatives' withdrawal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucita Azaro: ""We learned of the prior Duke Njolma's abdication before ..."*)

### Węzeł `[212]`
Mówca: **Laurento Esquibel**
> ""In my experience, we have much more to gain from straightforward diplomacy than from cloak-and-dagger operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Lucita Azaro: ""Mr. Esquibel, if you think Wehlen and Pales are not spyi..."*)

### Węzeł `[213]`
Mówca: **Lucita Azaro**
> ""Mr. Esquibel, if you think Wehlen and Pales are not spying on Rizia, you're fooling yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Laurento sniffed indignantly."*)

### Węzeł `[214]`
Mówca: **Lucita Azaro**
> ""We learned of the prior Duke Njolma's abdication before it was officially announced, for one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player_Romus: ""That doesn't count as useful information. It would have ..."*)
  - -> `[225]` (*Player_Romus: ""Can the agents in those regions be placed back in positi..."*)
  - -> `[217]` (*Player_Romus: ""If the agents are gone, they're gone. What about domesti..."*)

### Węzeł `[215]`
Mówca: **Lucita Azaro**
> ""He believed their leaders were starting to get suspicious of him. He may have been right, or it may have been his trademark paranoia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Laurento Esquibel: ""In my experience, we have much more to gain from straigh..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't count as useful information. It would have come out anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucita Azaro: ""But by the time it did, we had already determined our ne..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the agents are gone, they're gone. What about domestic intelligence?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lucita Azaro: ""Domestically, our main intelligence focus has been on pr..."*)

### Węzeł `[218]`
Mówca: **Lucita Azaro**
> ""But by the time it did, we had already determined our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""What about our domestic intelligence services?""*)
  - -> `[227]` (*Player_Romus: ""That makes sense. Can you put the operatives back?""*)
  - -> `[241]` (*Player_Romus: ""Laurento is right. Let's not waste our resources spying ..."*)

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""Now that they have been withdrawn, it will be a difficult and costly process to get them back into place. But I can inquire into the possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""What about our domestic intelligence services?""*)
  - -> `[220]` (*Player_Romus: ""Please do so immediately.""*)
  - -> `[230]` (*Player_Romus: ""On second thought, let's keep things as they are. We hav..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please do so immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""Consider it done.""*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about our domestic intelligence services?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Lucita Azaro), `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lucita Azaro: ""Domestically, our main intelligence focus has been on pr..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep up the good work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucita Azaro: ""I'll update you should major concerns arise.""*)

### Węzeł `[223]`
Mówca: **Lucita Azaro**
> ""Domestically, our main intelligence focus has been on preventing another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucita Azaro: ""To that end, our information gathering has been concentr..."*)

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""To that end, our information gathering has been concentrated in Brenas, where the last anti-monarchist movement originated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player_Romus: ""Keep up the good work.""*)
  - -> `[233]` (*Player_Romus: ""What about Cardesse-Montaklar? The military was involved..."*)
  - -> `[231]` (*Player_Romus: ""We shouldn't be spying on our own citizens like that.""*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Arrests == true"*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can the agents in those regions be placed back in position?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucita Azaro: ""Now that they have been withdrawn, it will be a difficul..."*)

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""Consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lucita Azaro: ""Domestically, our main intelligence focus has been on pr..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That makes sense. Can you put the operatives back?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucita Azaro: ""Now that they have been withdrawn, it will be a difficul..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about Valenqiris? I tried my best as Duke, but some traitors may have slipped through the cracks.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true`
- **Kontekst wejściowy (poprzednik):** `[224]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Hugo Toras: ""Rest assured that House Toras will not turn on itself. A..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about Valenqiris? I didn't crack down on traitors as Duke, after all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[224]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Hugo Toras: ""Rest assured that House Toras will not turn on itself. A..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, let's keep things as they are. We have other priorities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Lucita Azaro: ""As you wish.""*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shouldn't be spying on our own citizens like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Lucita Azaro: ""History has taught us that if we turn a blind eye to pot..."*)

### Węzeł `[232]`
Mówca: **Lucita Azaro**
> ""I'll update you should major concerns arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Intelligence = true"*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about Cardesse-Montaklar? The military was involved in the last uprising as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Lucita Azaro: ""As I've mentioned, the military has been purged and my p..."*)

### Węzeł `[234]`
Mówca: **Lucita Azaro**
> ""As I've mentioned, the military has been purged and my province is now under the strictest of control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Intelligence = true"*)

### Węzeł `[235]`
Mówca: **Lucita Azaro**
> ""History has taught us that if we turn a blind eye to potential traitors, we'll be the last to know when they come for our head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Intelligence = true"*)

### Węzeł `[236]`
Mówca: **Hugo Toras**
> ""Rest assured that House Toras will not turn on itself. And it will most certainly not countenance being surveilled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Intelligence = true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Arrests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Arrests == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_Arrests == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Arrests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: ""What about Valenqiris? I tried my best as Duke, but some..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_Arrests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""What about Valenqiris? I didn't crack down on traitors a..."*)

### Węzeł `[240]`
Mówca: **Lucita Azaro**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lucita Azaro: ""Domestically, our main intelligence focus has been on pr..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Laurento is right. Let's not waste our resources spying on Zille and Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Lucita Azaro: ""As you wish.""*)

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""Any other questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "Jump to: [Security/Military Hub]"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Military sub-hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_Conscription == true && ..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_Weapons == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_Weapons == false"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Military_Weapons == false)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_Weapons == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""What's the state of our military production industry?""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Military_Weapons == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_Weapons = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Lucita sighed."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_NavyAir == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_NavyAir == false"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Military_NavyAir == false)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_NavyAir == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: ""Tell me more about our naval and air capabilities.""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Military_NavyAir == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_NavyAir = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucita Azaro: ""Our navy has actually made significant strides in the pa..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: ""I trained at Camp Domus, too. You could've thrown that k..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player_Romus: ""Are you insane? You could've hurt someone!""*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. Your house should be commended for its deep devotion to protecting this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lucita Azaro: ""We're pleased to serve.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You brought a weapon to a council meeting, Duchess?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Lucita Azaro: ""I wouldn't dream of leaving home without it.""*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trained at Camp Domus, too. You could've thrown that knife at me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Lucita Azaro: ""Another time. If your reflexes haven't gone soft.""*)

### Węzeł `[258]`
Mówca: **Lucita Azaro**
> ""Another time. If your reflexes haven't gone soft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "She grinned briefly before regaining her poise."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you insane? You could've hurt someone!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucita Azaro: ""Spoken like someone who hasn't gone through our training.""*)

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""I wouldn't dream of leaving home without it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "She grinned briefly before regaining her poise."*)

### Węzeł `[261]`
Mówca: **Lucita Azaro**
> ""Spoken like someone who hasn't gone through our training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "She grinned briefly before regaining her poise."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You made your point. No need to put on a show.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lucita Azaro: ""Sorry, Your Majesty. The spirit of Ana Azaro must've ove..."*)

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""Sorry, Your Majesty. The spirit of Ana Azaro must've overtaken me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "She grinned briefly before regaining her poise."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "She grinned briefly before regaining her poise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucita Azaro: ""Of course, national security doesn't begin and end with ..."*)

### Węzeł `[265]`
Mówca: **Lucita Azaro**
> ""We're pleased to serve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "She grinned briefly before regaining her poise."*)

### Węzeł `[266]`
Mówca: **Lucita Azaro**
> ""Of course, national security doesn't begin and end with the Rizian military. We also have our police and intelligence divisions to think about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "Security/Military Hub"*)

### Węzeł `[267]`
Mówca: **Lucita Azaro**
> ""I was getting to that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lucita Azaro: ""The Rizian Intelligence Service has operatives in Morell..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Military == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Military == false"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Military == false)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Military == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus: ""I have a few more questions regarding the military.""*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Military == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Military = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucita Azaro: ""I'm here to answer them, Your Majesty. Where should I st..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to think about. Let's call it a day for now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == true  and  (Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == true)`
- **Kontekst wejściowy (poprzednik):** `[266]` (Lucita Azaro), `[242]` (Lucita Azaro), `[458]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "The heavy wooden door to the hall creaked open. An aide r..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Intelligence == true && (RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == true || RiziaDLCIsolated.Turn01_Briefing_Military == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Intelligence == true && ..."*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Intelligence == true &..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Intelligence == true && (RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == true || RiziaDLCIsolated.Turn01_Briefing_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == true  and  (Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player_Romus: ""You've given me a lot to think about. Let's call it a da..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Intelligence == true && (RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == true || RiziaDLCIsolated.Turn01_Briefing_Military == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == true  and  (Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[276]`
Mówca: **Lucita Azaro**
> ""Anyway. If we leave soon, we can make it back to Porte Drazon before it gets too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_KnifeThrow == true"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "She signalled to Titus, who tossed her knife back at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "In one fluid motion, she hiked up her gown, caught the pr..."*)

### Węzeł `[278]`
Mówca: **Narrator**
> "In one fluid motion, she hiked up her gown, caught the projectile and stowed it in a leather holster strapped to her thigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""Nice catch.""*)
  - -> `[280]` (*Player_Romus: ""I will remind you that this is a royal court, not a vari..."*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nice catch.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Lucita Azaro: ""It was nothing. In my fitter days I could do it hands-fr..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will remind you that this is a royal court, not a variety theater.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucita Azaro: ""Danger can strike at any time, Your Majesty. Even here.""*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player_Romus: ""Careful with that. I had a... bad dream involving stabbi..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Careful with that. I had a... bad dream involving stabbing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true`
- **Kontekst wejściowy (poprzednik):** `[278]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Lucita Azaro: ""Nobody's getting stabbed on my watch.""*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lower your hem, Duchess. The Lord frowns upon such indecency.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Kontekst wejściowy (poprzednik):** `[278]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Sal Ignacius: ""Indeed, modesty is one of the essential virtues of Wruhe..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_Conscription == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_Conscription == false"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Military_Conscription == false)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_Conscription == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""Let's talk about army conscription. How do we bolster ou..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Military_Conscription == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[289]`
Mówca: **Narrator**
> "Laurento nodded grimly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Laurento Esquibel: ""We did not foresee that Lespia would become so heavily i..."*)

### Węzeł `[290]`
Mówca: **Laurento Esquibel**
> ""We did not foresee that Lespia would become so heavily involved, nor that they would provide the Grand Duchy with cutting-edge aircraft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player_Romus: ""Lespia wouldn't even have those planes if it weren't for..."*)
  - -> `[292]` (*Player_Romus: ""So hypothetically speaking, if we tried to reconquer Pal..."*)
  - -> `[297]` (*Player_Romus: ""We're better off strengthening our other divisions than ..."*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia wouldn't even have those planes if it weren't for their close ties with Arcasia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Lucita Azaro: ""Very true. There is much to criticize about the West, bu..."*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So hypothetically speaking, if we tried to reconquer Pales again, they'd rain death on us from above.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Lucita Azaro: ""Hypothetically... yes. We're more well balanced in the s..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I remember when our troops laid eyes on those planes for the first time. Their morale disappeared then and there.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[290]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Lucita Azaro: ""My father always had terror in his eyes when he spoke of..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player_Romus: ""I remember when our troops laid eyes on those planes for..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're better off strengthening our other divisions than trying to compete with the likes of Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Lucita Azaro: ""We can't ignore the possibility of aerial combat. Many b..."*)

### Węzeł `[298]`
Mówca: **Lucita Azaro**
> ""My father always had terror in his eyes when he spoke of them. The silver falcons...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucita Azaro: ""And then there's the question of...""*)

### Węzeł `[299]`
Mówca: **Lucita Azaro**
> ""We can't ignore the possibility of aerial combat. Many battles these days are decided above our heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucita Azaro: ""And then there's the question of...""*)

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""Hypothetically... yes. We're more well balanced in the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucita Azaro: ""And then there's the question of...""*)

### Węzeł `[301]`
Mówca: **Lucita Azaro**
> ""Very true. There is much to criticize about the West, but their technological prowess can't be argued with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucita Azaro: ""And then there's the question of...""*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Military sub-hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Military sub-hub"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_Conscription = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_High == true || Rizi..."*)

### Węzeł `[304]`
Mówca: **Lucita Azaro**
> ""And then there's the question of...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military sub-hub]"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_Conscription == true && RiziaDLCIsolated.Turn01_Military_NavyAir == true && RiziaDLCIsolated.Turn01_Military_Weapons == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_Conscription == true && ..."*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Military_Conscription == true &..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Military_Conscription == true && RiziaDLCIsolated.Turn01_Military_NavyAir == true && RiziaDLCIsolated.Turn01_Military_Weapons == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Player_Romus: ""Time to move on to other matters.""*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Military_Conscription == true && RiziaDLCIsolated.Turn01_Military_NavyAir == true && RiziaDLCIsolated.Turn01_Military_Weapons == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_Weapons == false"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_NavyAir == false"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Military_Conscription == false"*)

### Węzeł `[308]`
Mówca: **Narrator**
> "The heavy wooden door to the hall creaked open. An aide rushed over to Laurento and whispered something in his ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Laurento Esquibel: ""I see. I'll get to a telephone right away.""*)

### Węzeł `[309]`
Mówca: **Laurento Esquibel**
> ""I see. I'll get to a telephone right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He turned to the rest of us, his usual jocular expression..."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "He turned to the rest of us, his usual jocular expression overlaid with concern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Laurento Esquibel: ""I must excuse myself briefly, ladies and gentlemen. Plea..."*)

### Węzeł `[311]`
Mówca: **Laurento Esquibel**
> ""I must excuse myself briefly, ladies and gentlemen. Please continue without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Player_Romus: ""What is it?""*)
  - -> `[313]` (*Player_Romus: ""You may be excused, Mr. Esquibel.""*)
  - -> `[314]` (*Player_Romus: ""That's fine. None of these topics concern you, anyway.""*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Laurento Esquibel: ""I will explain once I have all the details.""*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be excused, Mr. Esquibel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Laurento Esquibel: ""Thank you, Your Majesty. I'll explain everything shortly.""*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fine. None of these topics concern you, anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Laurento Esquibel: ""Our security and foreign policy are quite intertwined, Y..."*)

### Węzeł `[315]`
Mówca: **Laurento Esquibel**
> ""I will explain once I have all the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "He gave a quick bow, then rushed out of the room."*)

### Węzeł `[316]`
Mówca: **Laurento Esquibel**
> ""Thank you, Your Majesty. I'll explain everything shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "He gave a quick bow, then rushed out of the room."*)

### Węzeł `[317]`
Mówca: **Laurento Esquibel**
> ""Our security and foreign policy are quite intertwined, Your Majesty. Nonetheless, I trust Duchess Azaro to provide you with all relevant details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "He gave a quick bow, then rushed out of the room."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "He gave a quick bow, then rushed out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Laurento Esquibel");"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Lucita Azaro: ""Hmm. I wonder what that could be about.""*)

### Węzeł `[320]`
Mówca: **Lucita Azaro**
> ""Hmm. I wonder what that could be about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_SnO_LaurentoLeft = true"*)

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""It was nothing. In my fitter days I could do it hands-free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[322]`
Mówca: **Lucita Azaro**
> ""Danger can strike at any time, Your Majesty. Even here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "Lucita readjusted her gown."*)

### Węzeł `[323]`
Mówca: **Lucita Azaro**
> ""Nobody's getting stabbed on my watch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "Lucita readjusted her gown."*)

### Węzeł `[324]`
Mówca: **Sal Ignacius**
> ""Indeed, modesty is one of the essential virtues of Wruhecism. For women or otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Lucita Azaro: ""Pardon me, Grand Wiseman. It won't happen again.""*)

### Węzeł `[325]`
Mówca: **Narrator**
> "The door swung open again and Laurento came back into the hall. He wiped his brow with a silk pocket square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Elena Werner: ""Well, Mr. Esquibel? I hope you've brought us good news.""*)

### Węzeł `[326]`
Mówca: **Elena Werner**
> ""Well, Mr. Esquibel? I hope you've brought us good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Laurento Esquibel: ""It's too early to tell if it's good or bad. But it's def..."*)

### Węzeł `[327]`
Mówca: **Laurento Esquibel**
> ""It's too early to tell if it's good or bad. But it's definitely impactful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace..."*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent suggestion, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Laurento Esquibel: ""I'll start preparing a briefing once we're back in the c..."*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Preferably as soon as possible. We must decide on our official stance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Laurento Esquibel: ""We are not expected to come out against or in favor of L..."*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see the urgency. We won't be expected to respond immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Laurento Esquibel: ""No, but it's good that we all get on the same page as a ..."*)

### Węzeł `[331]`
Mówca: **Laurento Esquibel**
> ""No, but it's good that we all get on the same page as a council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO..."*)

### Węzeł `[332]`
Mówca: **Laurento Esquibel**
> ""We are not expected to come out against or in favor of Lespia's alignment. But we should get on the same page as a council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO..."*)

### Węzeł `[333]`
Mówca: **Laurento Esquibel**
> ""I'll start preparing a briefing once we're back in the capital. We should all be on the same page regarding this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Religious > 0)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: ""Lower your hem, Duchess. The Lord frowns upon such indec..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Religious > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[337]`
Mówca: **Narrator**
> "Lucita gave him a look of defiance as she readjusted her gown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Hugo Toras: ""An early return to the capital would be my preference as..."*)

### Węzeł `[338]`
Mówca: **Lucita Azaro**
> ""Pardon me, Grand Wiseman. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "Lucita gave him a look of defiance as she readjusted her ..."*)

### Węzeł `[339]`
Mówca: **Narrator**
> "Lucita readjusted her gown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Hugo Toras: ""An early return to the capital would be my preference as..."*)

### Węzeł `[340]`
Mówca: **Hugo Toras**
> ""An early return to the capital would be my preference as well. But where is Mr. Esquibel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "The door swung open again and Laurento came back into the..."*)

### Węzeł `[341]`
Mówca: **Lucita Azaro**
> ""I'll inform our hosts that we'll be departing shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "She pushed back her chair and briskly left the hall."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "She pushed back her chair and briskly left the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "I looked over at my daughter. Her brow was furrowed."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "I looked over at Hugo. His brow was furrowed."*)

### Węzeł `[346]`
Mówca: **Narrator**
> "I looked over at my daughter. Her brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Vina Toras: ""The Arcasian Treaty Organization? What will that mean fo..."*)

### Węzeł `[347]`
Mówca: **Narrator**
> "I looked over at Hugo. His brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Hugo Toras: ""What do you make of the ATO development, Your Majesty?""*)

### Węzeł `[348]`
Mówca: **Vina Toras**
> ""The Arcasian Treaty Organization? What will that mean for us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player_Romus: ""Nothing good, that's for sure.""*)
  - -> `[350]` (*Player_Romus: ""Nothing for you to worry about, sweetheart.""*)
  - -> `[351]` (*Player_Romus: ""I don't know. I suppose we'll find out.""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing good, that's for sure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Hugo To..."*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing for you to worry about, sweetheart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Hugo To..."*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. I suppose we'll find out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Hugo To..."*)

### Węzeł `[352]`
Mówca: **Hugo Toras**
> ""What do you make of the ATO development, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: ""I don't know yet.""*)
  - -> `[354]` (*Player_Romus: ""It's not good. I can tell you that much.""*)
  - -> `[355]` (*Player_Romus: ""It seems like a lot of fuss over nothing.""*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Hugo To..."*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not good. I can tell you that much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Hugo To..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems like a lot of fuss over nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Hugo To..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_G_LespiaATO = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_LespiaATO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "On the way back from the Plavo Archsanctuary, I met my co..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Laurento Esquibel: ""I just received official confirmation that our neighbor ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_G_HegelSaltanaMeet = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_HegelSaltanaMeet"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Order_IncreaseConscriptionDurat..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was fine. You know how it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucita Azaro: ""Let's hope that something useful came out of all that.""*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Laurento Esquibel: ""That is, after the lovely evening of musical entertainme..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Lucita Azaro: ""I'll inform our hosts that we'll be departing shortly.""*)

### Węzeł `[365]`
Mówca: **Laurento Esquibel**
> ""That is, after the lovely evening of musical entertainment that the King has so generously organized for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Hugo Toras: ""Ah, yes. Albeni was an excellent choice, Your Majesty. A..."*)

### Węzeł `[366]`
Mówca: **Hugo Toras**
> ""Ah, yes. Albeni was an excellent choice, Your Majesty. Although I do hope the performance showcases his earlier work, not his more... chaotic contemporary offerings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: ""Those works are only chaotic to the untrained ear, Hugo...."*)
  - -> `[368]` (*Player_Romus: ""Same here. If I wanted to hear two hours of ear-splittin..."*)
  - -> `[369]` (*Player_Romus: ""It's precisely that chaos that makes them so compelling...."*)
  - -> `[370]` (*Player_Romus: ""Music is a reflection of the times. Our era is far from ..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those works are only chaotic to the untrained ear, Hugo. Listen to them for long enough, and a structure appears.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Hugo Toras: ""I beg your pardon, Your Majesty. I'll be sure to listen ..."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Same here. If I wanted to hear two hours of ear-splitting screeching, I'd pay a visit to my sister-in-law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's precisely that chaos that makes them so compelling. He's pushing the boundaries of music itself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Hugo Toras: ""Boundaries exist for a reason, my nephew.""*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Music is a reflection of the times. Our era is far from neat and orderly; why should Albeni's compositions be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Laurento Esquibel: ""That's up for debate, Your Majesty. Should art portray t..."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "Laurento reeled in shock. Lucita stifled a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lucita Azaro: ""I confess it all sounds old-fashioned to me. Have you he..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "Laurento reeled in shock. Lucita stifled a laugh."*)

### Węzeł `[373]`
Mówca: **Lucita Azaro**
> ""I confess it all sounds old-fashioned to me. Have you heard the jazz that's coming out of Qinal these days?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Lucita Azaro: ""But you have my house's gratitude for the gesture, Your ..."*)

### Węzeł `[374]`
Mówca: **Hugo Toras**
> ""I beg your pardon, Your Majesty. I'll be sure to listen more attentively during the concert.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Lucita gave an impatient shrug."*)

### Węzeł `[375]`
Mówca: **Hugo Toras**
> ""Boundaries exist for a reason, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Hugo Toras: ""But if you see the merit in his newer works, I will give..."*)

### Węzeł `[376]`
Mówca: **Hugo Toras**
> ""But if you see the merit in his newer works, I will give them a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lucita Azaro: ""I confess it all sounds old-fashioned to me. Have you he..."*)

### Węzeł `[377]`
Mówca: **Narrator**
> "Lucita gave an impatient shrug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lucita Azaro: ""I confess it all sounds old-fashioned to me. Have you he..."*)

### Węzeł `[378]`
Mówca: **Laurento Esquibel**
> ""That's up for debate, Your Majesty. Should art portray the world as it is, or the world we want to see?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "Lucita gave an impatient shrug."*)

### Węzeł `[379]`
Mówca: **Narrator**
> "Lucita gave an impatient shrug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lucita Azaro: ""I confess it all sounds old-fashioned to me. Have you he..."*)

### Węzeł `[380]`
Mówca: **Lucita Azaro**
> ""But you have my house's gratitude for the gesture, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Lucita Azaro: ""I'll inform our hosts that we'll be departing shortly.""*)

### Węzeł `[381]`
Mówca: **Lucita Azaro**
> ""I would also suggest extending the length of our conscription period, and lowering the conscription age from 24 back to 18.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player_Romus: ""Yes, why did my father even raise the age to 24, anyway?""*)
  - -> `[383]` (*Player_Romus: ""I can't send kids to war.""*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, why did my father even raise the age to 24, anyway?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[381]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Hugo Toras: ""24 is the age by which a person's brain is fully formed,..."*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't send kids to war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[381]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Player_Romus: ""Hell, I joined the military at 18. It did me a world of ..."*)
  - -> `[388]` (*Player_Romus: ""18 is too young. I myself wish I'd joined the military l..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hell, I joined the military at 18. It did me a world of good.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[381]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Hugo Toras: ""You were unusually mature for your age, Your Majesty.""*)

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""18 is too young. I myself wish I'd joined the military later in life.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[381]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Vina Toras: ""18-year-olds are hardly 'kids', Your Majesty.""*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Hugo Toras: ""I agree that young people, especially young men, tend to..."*)

### Węzeł `[392]`
Mówca: **Vina Toras**
> ""18-year-olds are hardly 'kids', Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Hugo Toras: ""Indeed not, Your Highness. But young people, especially ..."*)

### Węzeł `[393]`
Mówca: **Hugo Toras**
> ""24 is the age by which a person's brain is fully formed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Vina Toras: ""I do beg your pardon, Uncle Hugo.""*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Hugo Toras: ""Young people, especially young men, tend to make irratio..."*)

### Węzeł `[397]`
Mówca: **Vina Toras**
> ""I do beg your pardon, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Hugo Toras: ""I mean no offense, Your Highness. But young people, espe..."*)

### Węzeł `[398]`
Mówca: **Hugo Toras**
> ""I mean no offense, Your Highness. But young people, especially young men, tend to make irrational decisions before that age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""Such as rebelling against their general.""*)
  - -> `[409]` (*Player_Romus: ""They get a little too trigger-happy, you mean.""*)
  - -> `[410]` (*Player_Romus: ""No, I disagree. If you're old enough to vote, you're old..."*)

### Węzeł `[399]`
Mówca: **Hugo Toras**
> ""Young people, especially young men, tend to make irrational decisions before then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""Such as rebelling against their general.""*)
  - -> `[409]` (*Player_Romus: ""They get a little too trigger-happy, you mean.""*)
  - -> `[410]` (*Player_Romus: ""No, I disagree. If you're old enough to vote, you're old..."*)
  - -> `[411]` (*Player_Romus: ""That's simply not true. I feel my mind was at its sharpe..."*)

### Węzeł `[400]`
Mówca: **Hugo Toras**
> ""Indeed not, Your Highness. But young people, especially young men, tend to make irrational decisions around that age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""Such as rebelling against their general.""*)
  - -> `[409]` (*Player_Romus: ""They get a little too trigger-happy, you mean.""*)
  - -> `[410]` (*Player_Romus: ""No, I disagree. If you're old enough to vote, you're old..."*)
  - -> `[411]` (*Player_Romus: ""That's simply not true. I feel my mind was at its sharpe..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such as rebelling against their general.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Hugo Toras), `[399]` (Hugo Toras), `[400]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Lucita Azaro: ""As I've said, the 1920s were extraordinary circumstances..."*)

### Węzeł `[402]`
Mówca: **Hugo Toras**
> ""I agree that young people, especially young men, tend to make irrational decisions before they reach their mid-twenties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Player_Romus: ""They get a little too trigger-happy, you mean.""*)
  - -> `[410]` (*Player_Romus: ""No, I disagree. If you're old enough to vote, you're old..."*)
  - -> `[411]` (*Player_Romus: ""That's simply not true. I feel my mind was at its sharpe..."*)

### Węzeł `[403]`
Mówca: **Hugo Toras**
> ""You were unusually mature for your age, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Hugo Toras: ""But many young people, especially young men, tend to mak..."*)

### Węzeł `[404]`
Mówca: **Hugo Toras**
> ""But many young people, especially young men, tend to make irrational decisions before they reach their mid-twenties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""Such as rebelling against their general.""*)
  - -> `[409]` (*Player_Romus: ""They get a little too trigger-happy, you mean.""*)
  - -> `[410]` (*Player_Romus: ""No, I disagree. If you're old enough to vote, you're old..."*)
  - -> `[411]` (*Player_Romus: ""That's simply not true. I feel my mind was at its sharpe..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Vina Toras: ""18 isn't that young, Your Majesty?""*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Hugo Toras: ""I agree that young people, especially young men, tend to..."*)

### Węzeł `[408]`
Mówca: **Vina Toras**
> ""18 isn't that young, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Hugo Toras: ""Indeed not, Your Highness. But young people, especially ..."*)

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They get a little too trigger-happy, you mean.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Hugo Toras), `[399]` (Hugo Toras), `[400]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Lucita Azaro: ""Not with proper training, Your Majesty.""*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I disagree. If you're old enough to vote, you're old enough to fight for your country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Hugo Toras), `[399]` (Hugo Toras), `[400]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Lucita Azaro: ""My thoughts exactly.""*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's simply not true. I feel my mind was at its sharpest as a young man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Hugo Toras), `[400]` (Hugo Toras), `[402]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Lucita Azaro: ""You're sharp now, Your Majesty. But I will say that in w..."*)

### Węzeł `[412]`
Mówca: **Lucita Azaro**
> ""My thoughts exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military sub-hub]"*)

### Węzeł `[413]`
Mówca: **Lucita Azaro**
> ""Not with proper training, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military sub-hub]"*)

### Węzeł `[414]`
Mówca: **Lucita Azaro**
> ""As I've said, the 1920s were extraordinary circumstances. There will be no second mutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Lucita Azaro: ""I myself joined the military while I was still in my tee..."*)

### Węzeł `[415]`
Mówca: **Lucita Azaro**
> ""You're sharp now, Your Majesty. But I will say that in war, the best decisions are not always the most rational ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military sub-hub]"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");
AddConversant("Hugo Toras");
AddConversant("Elena Werner");
AddConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");
AddConversant("Hugo Toras");
AddConversant("Elena Werner");
AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "AddConversant("Vina Toras");"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My council and I were given a tour of the facilities befo..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My council and I were given a tour of the facilities befo..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");
RemoveConversant("Hugo Toras");
RemoveConversant("Elena Werner");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Hugo Toras");
RemoveConversant("Elena Werner");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Rizia_Country_Lespia", "Country_ATO");"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Order_IncreaseConscriptionDuration = true;
RiziaDLC.Enable_Policy_RD_Order_AntiDrugOperations = true;
RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies = true;
RiziaDLC.Enable_Policy_RD_Order_IncreaseProvincialLevies = true;
RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialPolice = true;
RiziaDLC.Enable_Policy_RD_Order_TankFactory = true;
RiziaDLC.Enable_Policy_RD_Order_SupportVehicleFactory = true;
RiziaDLC.Enable_Policy_RD_Order_MilitaryEquipmentFactory = true;
RiziaDLC.Enable_Policy_RD_Order_LowerConscriptionAge = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_IncreaseConscriptionDuration"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_AntiDrugOperations"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_IncreaseProvincialLevies"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialPolice"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_TankFactory"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_SupportVehicleFactory"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_MilitaryEquipmentFactory"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_LowerConscriptionAge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Iza_LaborHandsProtest = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Iza_LaborHandsProtest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_G_HegelSaltanaMeet = true"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Panel_WarProduction = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Panel_WarProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Lucita Azaro: ""We can achieve this thanks to my house. Camp Domus still..."*)

### Węzeł `[426]`
Mówca: **Lucita Azaro**
> ""We can achieve this thanks to my house. Camp Domus still runs the most rigorous, high-quality training program on the continent. Right, Captain Gordion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Dodging throwning knives at a security m..."*)

### Węzeł `[427]`
Mówca: **Lucita Azaro**
> ""Ultimately, it's the readiness of our forces that will determine how well we can uphold our sovereignty and carry out our military strategies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "Army Panel Questions"*)

### Węzeł `[428]`
Mówca: **Lucita Azaro**
> ""If our kingdom took anything away from Pales and the rebellion, it's that we learned the deadly cost of unpreparedness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Lucita Azaro: ""Our troops must reflect Rizia's resilience, ensuring suc..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Airforce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Airforce == true)"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Airforce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Lucita Azaro: ""Focusing on the air force offers us a chance to establis..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Airforce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Army == true"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Army == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Army == true"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Army == true)"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Army == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Lucita Azaro: ""Prioritizing the army means enhancing our ground capabil..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Army == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Navy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Navy == true)"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Navy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Lucita Azaro: ""Shifting our focus to the navy could significantly boost..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Navy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Lucita Azaro: ""Opting not to focus on any particular branch will allow ..."*)

### Węzeł `[438]`
Mówca: **Lucita Azaro**
> ""Focusing on the air force offers us a chance to establish aerial superiority, but it requires precise investments in procurement and fleet expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Lucita Azaro: ""We will also be training a paratrooper division under th..."*)

### Węzeł `[439]`
Mówca: **Lucita Azaro**
> ""Prioritizing the army means enhancing our ground capabilities with modern equipment and tactics. In my view, this will be worth every cent of the budget allocated for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Lucita Azaro: ""We will also be training an additional mountaineer divis..."*)

### Węzeł `[440]`
Mówca: **Lucita Azaro**
> ""Shifting our focus to the navy could significantly boost our maritime strength, but we must consider the costs of producing and integrating vessels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Lucita Azaro: ""We will also be training a marine division under this in..."*)

### Węzeł `[441]`
Mówca: **Lucita Azaro**
> ""Opting not to focus on any particular branch will allow us to allocate resources flexibly across various national priorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Lucita Azaro: ""The strength of our Rizian Armed Forces lies in the dive..."*)

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is alarming. We need immediate measures to rectify this situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Lucita Azaro: ""If you ask me, an immediate audit of our military assets..."*)

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While modernizing the military is a significant challenge, we can't simply throw money at it. We need to be efficient.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Lucita Azaro: ""Efficiency is key. We must strategically allocate resour..."*)

### Węzeł `[444]`
Mówca: **Lucita Azaro**
> ""But training is key. Each unit, from infantry to naval, requires preparation. We can't expect our men and women in uniform to go into battle with no experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Lucita Azaro: ""Ultimately, it's the readiness of our forces that will d..."*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Understanding the details will help us plan more effectively. Tell me more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Stockpile_Low == true || Rizi..."*)

### Węzeł `[446]`
Mówca: **Lucita Azaro**
> ""If you ask me, an immediate audit of our military assets is necessary. From there, we can fast-track procurement and training to address the most pressing deficiencies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Lucita Azaro: ""Now. A word about our military priorities.""*)

### Węzeł `[447]`
Mówca: **Lucita Azaro**
> ""Efficiency is key. We must strategically allocate resources, perhaps starting with the most outdated sectors and gradually expanding our focus as funds allow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Lucita Azaro: ""Now. A word about our military priorities.""*)

### Węzeł `[448]`
Mówca: **Lucita Azaro**
> ""We're facing shortages in critical areas like armored vehicles, advanced communication technology, and even basic infantry gear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Lucita Azaro: ""Now. A word about our military priorities.""*)

### Węzeł `[449]`
Mówca: **Lucita Azaro**
> ""The strength of our Rizian Armed Forces lies in the diversity of our resources and units. We have manpower ready for duty,  as long as they're equipped with the necessary gear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Lucita Azaro: ""But training is key. Each unit, from infantry to naval, ..."*)

### Węzeł `[450]`
Mówca: **Lucita Azaro**
> ""Now. A word about our military priorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[451]`
Mówca: **Lucita Azaro**
> ""Our troops must reflect Rizia's resilience, ensuring such blows never weaken us again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_WarProduction = true"*)

### Węzeł `[452]`
Mówca: **Lucita Azaro**
> ""We will also be training a paratrooper division under this initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Lucita Azaro: ""The strength of our Rizian Armed Forces lies in the dive..."*)

### Węzeł `[453]`
Mówca: **Lucita Azaro**
> ""We will also be training an additional mountaineer division under this initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Lucita Azaro: ""The strength of our Rizian Armed Forces lies in the dive..."*)

### Węzeł `[454]`
Mówca: **Lucita Azaro**
> ""We will also be training a marine division under this initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Lucita Azaro: ""The strength of our Rizian Armed Forces lies in the dive..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO = false;
RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO1950 = true;
RiziaDLCSupport.Codex_Locations_Countries_Lespia = false;
RiziaDLCSupport.Codex_Locations_Countries_Lespia_1950 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO"] = false;
Variable["RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO1950"] = true;
Variable["RiziaDLCSupport.Codex_Locations_Countries_Lespia"] = false;
Variable["RiziaDLCSupport.Codex_Locations_Countries_Lespia_1950"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_KnifeThrow = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_KnifeThrow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "With lightning speed, she reached under the table, pulled..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_SnO_LaurentoLeft = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_SnO_LaurentoLeft"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Lucita Azaro: ""Anyway. If we leave soon, we can make it back to Porte D..."*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Time to move on to other matters.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true`
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucita Azaro), `[102]` (Lucita Azaro), `[304]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "Jump to: [Security/Military Hub]"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Rizia_Country_Lespia", "Country_ATO");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Rizia_Country_Lespia","Country_ATO");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "I had barely even started my reign, and it already felt l..."*)

### Węzeł `[460]`
Mówca: **Lucita Azaro**
> ""I myself joined the military while I was still in my teens. And I'm eternally thankful I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military sub-hub]"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_ArmedForces == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces == true"*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Focus_ArmedForces == true)"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_ArmedForces == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Lucita Azaro: ""Which is why, Your Majesty, I'm very grateful to you for..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Focus_ArmedForces == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Military_Stockpile_Full == true || Ri..."*)

### Węzeł `[464]`
Mówca: **Lucita Azaro**
> ""Which is why, Your Majesty, I'm very grateful to you for taking steps to address these inadequacies before the crown was even on your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Lucita Azaro: ""But the way I see it, this is only the beginning.""*)

### Węzeł `[465]`
Mówca: **Lucita Azaro**
> ""But the way I see it, this is only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Player_Romus: ""No need to say any more. If you all will excuse me, I'm ..."*)
  - -> `[466]` (*Player_Romus: ""I don't like what you're implying about King Valero the ..."*)
  - -> `[443]` (*Player_Romus: ""While modernizing the military is a significant challeng..."*)
  - -> `[445]` (*Player_Romus: ""Understanding the details will help us plan more effecti..."*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like what you're implying about King Valero the First. Attempts to slander my father's name will not be tolerated in this court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1; RiziaDLC.Personal..."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 1; RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Lucita Azaro: ""I-- I beg your pardon. I only meant to say that I am loo..."*)

### Węzeł `[468]`
Mówca: **Lucita Azaro**
> ""I-- I beg your pardon. I only meant to say that I am looking forward to working with you on making improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Narrator: "She straightened her back."*)

### Węzeł `[469]`
Mówca: **Narrator**
> "She straightened her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Lucita Azaro: ""Now. A word about our military priorities.""*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Military_Stockpile_Full == true || RiziaDLC.Situation_Military_Stockpile_Overflowing == true) && (RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Military_Stockpile_Full == true || Ri..."*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Situation_Military_Stockpile_Full == true || ..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Military_Stockpile_Full == true || RiziaDLC.Situation_Military_Stockpile_Overflowing == true) && (RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Stockpile_Full"] == true  or  Variable["RiziaDLC.Situation_Military_Stockpile_Overflowing"] == true)  and  (Variable["RiziaDLC.Situation_Military_Manpower_High"] == true  or  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Lucita Azaro: ""Which is why, Your Majesty, I'm very grateful to you for..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Situation_Military_Stockpile_Full == true || RiziaDLC.Situation_Military_Stockpile_Overflowing == true) && (RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true) )`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Situation_Military_Stockpile_Full"] == true  or  Variable["RiziaDLC.Situation_Military_Stockpile_Overflowing"] == true)  and  (Variable["RiziaDLC.Situation_Military_Manpower_High"] == true  or  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucita Azaro: ""As a result, Your Majesty, we are ludicrously underprepa..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Stockpile_Low == true || RiziaDLC.Situation_Military_Stockpile_HalfFull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Stockpile_Low == true || Rizi..."*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Stockpile_Low == true || Ri..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Stockpile_Low == true || RiziaDLC.Situation_Military_Stockpile_HalfFull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Stockpile_Low"] == true  or  Variable["RiziaDLC.Situation_Military_Stockpile_HalfFull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Lucita Azaro: ""We're facing shortages in critical areas like armored ve..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Stockpile_Low == true || RiziaDLC.Situation_Military_Stockpile_HalfFull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Stockpile_Low"] == true  or  Variable["RiziaDLC.Situation_Military_Stockpile_HalfFull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_High == false && Riz..."*)

### Węzeł `[476]`
Mówca: **Lucita Azaro**
> ""While our equipment stockpile has grown considerably, we're still facing a shortage of manpower. All the weapons in the world won't help us if there's nobody to wield them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Lucita Azaro: ""Now. A word about our military priorities.""*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_High == false && RiziaDLC.Situation_Military_Manpower_Massive == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_High == false && Riz..."*)
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Manpower_High == false && R..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_High == false && RiziaDLC.Situation_Military_Manpower_Massive == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_High"] == false  and  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Lucita Azaro: ""While our equipment stockpile has grown considerably, we..."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Manpower_High == false && RiziaDLC.Situation_Military_Manpower_Massive == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_High"] == false  and  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_CombatExperience_Waning == true"*)

### Węzeł `[480]`
Mówca: **Lucita Azaro**
> ""While you've managed to rectify our equipment and manpower shortages in a surprisingly short amount of time, our troops still need training. A horde of well-equipped soldiers won't do us any good if they lack experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Lucita Azaro: ""Now. A word about our military priorities.""*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_CombatExperience_Waning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_CombatExperience_Waning == true"*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_CombatExperience_Waning == ..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_CombatExperience_Waning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_CombatExperience_Waning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Lucita Azaro: ""While you've managed to rectify our equipment and manpow..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_CombatExperience_Waning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_CombatExperience_Waning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Lucita Azaro: ""You've managed to rectify our equipment and manpower sho..."*)

### Węzeł `[484]`
Mówca: **Lucita Azaro**
> ""You've managed to rectify our equipment and manpower shortages in a surprisingly short amount of time. From here, we can focus on specialization and new technologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Lucita Azaro: ""Now. A word about our military priorities.""*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_High == true || Rizi..."*)
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Manpower_High == true || Ri..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_High"] == true  or  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucita Azaro: ""Our ranks are looking healthy already, Your Majesty. But..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_High"] == true  or  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Lucita Azaro: ""I'm glad you asked.""*)

### Węzeł `[488]`
Mówca: **Lucita Azaro**
> ""I'm glad you asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucita Azaro: ""As you know, our central royal army is fed both by gener..."*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "Lucita readjusted her gown."*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Army Panel Questions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false"*)
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false"*)
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true || ..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false"*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false)"*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Player_Romus: ""How do the costs of training and equipping our units com..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false"*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false)"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Player_Romus: ""How long does it take to prepare a unit from basic train..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false"*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false)"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Player_Romus: ""What's the point of keeping our troops in a constant sta..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do the costs of training and equipping our units compare?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Lucita Azaro), `[501]` (Lucita Azaro), `[503]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Lucita Azaro: ""The costs vary by unit. Obviously, the more complex the ..."*)

### Węzeł `[501]`
Mówca: **Lucita Azaro**
> ""The costs vary by unit. Obviously, the more complex the training and equipment, the more expensive it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts = true"*)

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How long does it take to prepare a unit from basic training to full combat readiness?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Lucita Azaro), `[501]` (Lucita Azaro), `[503]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Lucita Azaro: ""The majority of our units reach full readiness within a ..."*)

### Węzeł `[503]`
Mówca: **Lucita Azaro**
> ""The majority of our units reach full readiness within a year, with specialized units requiring additional time for their rigorous preparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime = true"*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the point of keeping our troops in a constant state of readiness? It's not like war is on the horizon.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Lucita Azaro), `[501]` (Lucita Azaro), `[503]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Lucita Azaro: ""Not yet. But given the shifting allegiances all around u..."*)

### Węzeł `[505]`
Mówca: **Lucita Azaro**
> ""Not yet. But given the shifting allegiances all around us, we should be prepared for anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Lucita Azaro: ""Besides which, the benefits of a strong, capable militar..."*)

### Węzeł `[506]`
Mówca: **Lucita Azaro**
> ""Besides which, the benefits of a strong, capable military go beyond the battlefield. The more power we project internationally, the more respect our neighbors and trading partners will have for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Laurento Esquibel: ""Only up to a point, Duchess. We want our potential allie..."*)

### Węzeł `[507]`
Mówca: **Laurento Esquibel**
> ""Only up to a point, Duchess. We want our potential allies to see us as a friendly, open negotiator, not a bully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain = true"*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Army Panel Questions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "Army Panel Questions"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "Jump to: [Army Panel Questions]"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "Jump to: [Army Panel Questions]"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "Jump to: [Army Panel Questions]"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false"*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false)"*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.Pro..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.Prologue_Focus_ArmedForces == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.Pro..."*)
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.P..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.Prologue_Focus_ArmedForces == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == false  and  Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Player_Romus: ""I'm no master strategist. Are you expecting me to draw u..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.Prologue_Focus_ArmedForces == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == false  and  Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Player_Romus: ""The entire armed forces of Rizia, under my sole command...."*)

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm no master strategist. Are you expecting me to draw up plans for our troops?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == false  and  Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == false` AND `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Narrator: "She laughed lightly."*)

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The entire armed forces of Rizia, under my sole command... I've been waiting my whole life for this.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == false  and  Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == false) == false` AND `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Narrator: "I saw a gleam in her eye."*)

### Węzeł `[520]`
Mówca: **Narrator**
> "I saw a gleam in her eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Lucita Azaro: ""You won't be alone. Together, we'll build a force as for..."*)

### Węzeł `[521]`
Mówca: **Narrator**
> "She laughed lightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Lucita Azaro: ""That's what I and our generals are here for. Leave the s..."*)

### Węzeł `[522]`
Mówca: **Lucita Azaro**
> ""You won't be alone. Together, we'll build a force as formidable as your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_Strategies = true"*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_Strategies = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "Jump to: [Army Panel Questions]"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == true || RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true || ..."*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true |..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == true || RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player_Romus: ""I appreciate all this information. I'll relay my instruc..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == true || RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate all this information. I'll relay my instructions to you after this meeting ends.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == true`
- **Kontekst wejściowy (poprzednik):** `[427]` (Lucita Azaro), `[501]` (Lucita Azaro), `[503]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Narrator: "Lucita nodded with satisfaction."*)

### Węzeł `[528]`
Mówca: **Narrator**
> "Lucita nodded with satisfaction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Lucita Azaro: ""If our kingdom took anything away from Pales and the reb..."*)

### Węzeł `[529]`
Mówca: **Lucita Azaro**
> ""That's what I and our generals are here for. Leave the strategizing to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Lucita Azaro: ""But don't hesitate to take the reins if need be. Sometim..."*)

### Węzeł `[530]`
Mówca: **Lucita Azaro**
> ""But don't hesitate to take the reins if need be. Sometimes, the intuition of a wise king can be more valuable than the by-the-book maneuvers of a seasoned veteran.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_MilitaryQs_Strategies = true"*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucita Azaro: ""Not without reason, of course.""*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucita Azaro: ""Ideally, maybe. But reality has taught us that peace is ..."*)

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to say any more. If you all will excuse me, I'm going to get started at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "Lucita raised an eyebrow."*)

### Węzeł `[534]`
Mówca: **Narrator**
> "Lucita raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Lucita Azaro: ""You don't want to hear any more?""*)

### Węzeł `[535]`
Mówca: **Lucita Azaro**
> ""You don't want to hear any more?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Player_Romus: ""Actually, I do have a few questions related to military ..."*)
  - -> `[536]` (*Player_Romus: ""Not right now. But I'm looking forward to many more priv..."*)
  - -> `[545]` (*Player_Romus: ""No, thanks. I have plenty of my own ideas for the milita..."*)
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true"*)

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not right now. But I'm looking forward to many more private discussions with you in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[535]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Narrator: "She smiled coyly."*)

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I do have a few questions related to military and security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[535]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Lucita Azaro: ""By all means, go ahead.""*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Panel_WarProduction = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Panel_WarProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "Jump to: [Security/Military Hub]"*)

### Węzeł `[540]`
Mówca: **Lucita Azaro**
> ""By all means, go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_WarProduction = true"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Security/Military Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "Security/Military Hub"*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Panel_WarProduction = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Panel_WarProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military Briefing Skipped]"*)

### Węzeł `[543]`
Mówca: **Lucita Azaro**
> ""As am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_WarProduction = true"*)

### Węzeł `[544]`
Mówca: **Narrator**
> "She smiled coyly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Lucita Azaro: ""As am I.""*)

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, thanks. I have plenty of my own ideas for the military without House Azaro's input.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[535]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1; RiziaDLC.Country_..."*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 1;
RiziaDLC.Country_HouseAzaro -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;
Variable["RiziaDLC.Country_HouseAzaro"] = Variable["RiziaDLC.Country_HouseAzaro"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Narrator: "Her expression soured."*)

### Węzeł `[547]`
Mówca: **Narrator**
> "Her expression soured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Lucita Azaro: ""Very well. I won't keep you any longer.""*)

### Węzeł `[548]`
Mówca: **Lucita Azaro**
> ""Very well. I won't keep you any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_WarProduction = true"*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had a vision, Duchess. The Lord has shown me the way.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Kontekst wejściowy (poprzednik):** `[535]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true"*)
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == t..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Player_Romus: ""I had a vision, Duchess. The Lord has shown me the way.""*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[553]`
Mówca: **Narrator**
> "Sal grinned triumphantly. A troubled frown crossed Lucita's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Lucita Azaro: ""Very well. I won't keep you any longer.""*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Military Briefing Skipped`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "The heavy wooden door to the hall creaked open. An aide r..."*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Military Briefing Skipped]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "Military Briefing Skipped"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_KnifeThrow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_KnifeThrow == true"*)
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_KnifeThrow == true)"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_KnifeThrow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_KnifeThrow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "She signalled to Titus, who tossed her knife back at her."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_KnifeThrow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_KnifeThrow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Hugo Toras: ""An early return to the capital would be my preference as..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Narrator: "Sal grinned triumphantly. A troubled frown crossed Lucita..."*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Facing a blunt report on the state of the military", "Folce Dator", "Cardesse-Montaklar");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Facing a blunt report on the state of the military","Folce Dator","Cardesse-Montaklar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Dodging throwning knives at a security meeting", "Folce Dator", "Cardesse-Montaklar");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Dodging throwning knives at a security meeting","Folce Dator","Cardesse-Montaklar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_KnifeThrow = true;"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false"*)
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Iza_LaborHandsProtest = true"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_G_HegelSaltanaMeet = true"*)
