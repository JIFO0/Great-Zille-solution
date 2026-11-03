# Rizia/Turn 8/A_Reform_Manus

- **ID konwersacji:** `407`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/407_A_Reform_Manus.md`
- **Liczba węzłów dialogowych:** 870
- **Liczba wyborów gracza:** 170

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Azaro_Dead`
- `RiziaDLC.Army_Unit_Azaro_Total`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Iza_PowerTransfer_Angelica`
- `RiziaDLC.Iza_PowerTransfer_Council_Brenas`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Reform_Aggressive`
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Silent`
- `RiziaDLC.Reform_TalkToAdarfo_AskedManus`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Rico_Extradited`
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Turn02_Intention_NoMonarchy`
- `RiziaDLC.Unrest_Police_PulledBack`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_FullCouncilor`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLC.War_Control_Skipped`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLCIsolated.Reform_Threat_Azaro`
- `RiziaDLCIsolated.Reform_Threat_Azaro_Talk`
- `RiziaDLCIsolated.Reform_Threat_Toras`
- `RiziaDLCIsolated.Reform_Threat_Toras_Talk`
- `RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk`
- `RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Reform_Aggressive`
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Involve_Vina`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Legislative_RegionalSenate`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Reform_Path_Cancelled`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Reform_Silent`
- `RiziaDLC.Reform_TalkToAdarfo_AskedManus`
- `RiziaDLC.Reform_UpperHouse_Advisory`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLCIsolated.Reform_Intention_Judiciary_Independent`
- `RiziaDLCIsolated.Reform_Intention_Legislative_Bicameral`
- `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral`
- `RiziaDLCIsolated.Reform_Intention_Monarch_Approval`
- `RiziaDLCIsolated.Reform_Intention_Monarch_Veto`
- `RiziaDLCIsolated.Reform_Intention_PM_Daria`
- `RiziaDLCIsolated.Reform_Threat_Azaro`
- `RiziaDLCIsolated.Reform_Threat_Azaro_Talk`
- `RiziaDLCIsolated.Reform_Threat_Toras`
- `RiziaDLCIsolated.Reform_Threat_Toras_Talk`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 23
- **Węzły modyfikujące stan gry:** 50

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[4]` (Paskal Beniwoll): `--;`
- Węzeł `[6]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Reform_Intention_Monarch_Approval"] = true; Variable["RiziaDLC.Reform_...`
- Węzeł `[21]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Reform_Intention_Monarch_Veto"] = true; Variable["RiziaDLC.Reform_Mona...`
- Węzeł `[22]` (Paskal Beniwoll): `--;`
- Węzeł `[32]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;`
- Węzeł `[33]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;`
- Węzeł `[34]` (Paskal Beniwoll): `--;`
- Węzeł `[56]` (Paskal Beniwoll): `--;`
- *...oraz 42 innych węzłów ze skryptami.*

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
  - -> `[868]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was late in the evening as I made my way downstairs to meet Manus Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[5]`
Mówca: **Narrator**
> "He pulled a notepad out of his breast pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Monarch_Approval = true;
RiziaDLC.Reform_Monarch_Veto = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Monarch_Approval"] = true;
Variable["RiziaDLC.Reform_Monarch_Veto"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[7]`
Mówca: **Manus Sazon**
> ""I want to go over the RPP's main points to get a sense of your perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no problem with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. The monarch should act as the head of state, not the head of government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Our country is still an absolute monarchy in all but name. Your father created the House of Delegates as a symbolic parliament, but the new constitution can give it the true authority it represents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""After all, a constitutional monarch does not rule, Your Majesty -- they merely reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[12]`
  - -> `[239]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. Even with an empowered parliament, the monarch should retain substantial powers over the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are not thinking radically enough, Mr. Sazon. I don't believe the monarch should reign at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""I know we had this conversation. But I remain convinced that Rizian society will not accept such a drastic change. Maybe someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[15]`
Mówca: **Manus Sazon**
> ""The constitution has to balance the power structure fairly so that no branch has complete authority over the other. That includes the Royal Family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""That's what we've been working on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""Firstly, the constitution will define the House of Delegates as the governing legislative body in Rizia, with clearly outlined procedures and jurisdiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""Instead of the monarch, they will be in charge of managing the government budget and passing laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`
  - -> `[8]`
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if their decisions are subject to the monarch's -- to *my* -- approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if the monarch holds the right to veto their decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Monarch_Veto = true;
RiziaDLC.Reform_Monarch_Veto = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Monarch_Veto"] = true;
Variable["RiziaDLC.Reform_Monarch_Veto"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[23]`
Mówca: **Manus Sazon**
> ""Hm... We can propose that the monarch can exercise the act of royal assent to approve of legislature. But a procedure must be defined so that the monarch cannot block every single piece of legislature at whim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Manus Sazon**
> ""Hm... We can propose a veto process. But it must be defined in a way that doesn't allow the monarch to block every single piece of legislature at whim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Manus Sazon**
> ""Our main objective is to ensure the political participation of our citizens. This is only possible if the monarch's power is limited, as enshrined in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[26]`
Mówca: **Manus Sazon**
> ""We can discuss the exact details later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Manus Sazon**
> ""Secondly, we must decide whether to keep the old regional structure in Rizia or centralize the system in Porte Drazon completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Manus Sazon**
> ""Keeping the provinces semi-autonomous may embolden their leadership to go against the new government's laws. But the nobles in those provinces have held power for centuries. They will not easily accept centralization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`
  - -> `[31]`
  - -> `[645]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd rather not disturb the regional system. We should respect the autonomy of the provinces and make sure each is represented fairly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia still resembles a feudal state. We should find ways to abolish that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In a system that already has several branches of government and many actors, a decentralized structure will only bring instability. I support centralization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[35]`
Mówca: **Manus Sazon**
> ""I do have one concern there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""A centralized government might run more efficiently, but citizens in those provinces may see it as a slight against ancient regional traditions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Manus Sazon**
> ""However, it raises questions regarding how the provinces should be structured in such a system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[43]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The regions should have no autonomy or separate political structures. There must be equality among them, and laws must be implemented in a uniform way nationwide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While we should strive for each region to be represented in the House of Delegates, the nation of Rizia must be ruled by its parliament alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It might be unpopular, but this is my vision for the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Each region should function as a state, and be allowed to exercise autonomy within a constitutionally defined framework.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should respect the historical, financial and demographical differences of the regions. Especially when it comes to each province's governing House. We need their collaboration if we want to change the system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't change anything drastic. Keeping the current decentralized system will only increase public participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Manus Sazon**
> ""We can offer the nobility something, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Manus Sazon**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
Mówca: **Manus Sazon**
> ""I understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[47]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[48]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Manus Sazon**
> ""If the regions retain a degree of autonomy, their local governments will share power and responsibility with the central one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`
  - -> `[50]`
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In a federal system such as this, having a second legislative body representing the provinces might be ideal. We could form an upper House.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to give something to the nobility for their support. We could have an upper House composed exclusively of nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The legislative body should be unicameral. Complicating the system will only make it less efficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""Abolishing the regional power structure would vest all powers in the hands of the central government. In a system such as this, I believe having a unicameral legislative body would be the best option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[633]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. Legislative responsibility must be left to one single elected parliament.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we already have a parliament. It'll only make the system less efficient if we create a second one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[58]`
Mówca: **Narrator**
> "I flicked a switch hidden behind the shelf of bottles. It rotated to reveal an opening in the wall, which led to a series of wooden staircases."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[59]`
Mówca: **Narrator**
> "I knew the perfect place in the palace to have this conversation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[60]`
Mówca: **Narrator**
> "I'd first learned about this place from my father as a kid. He'd told me it was the only place in the palace where he could feel truly alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[61]`
Mówca: **Manus Sazon**
> ""Your Majesty, thank you once again for agreeing to this meeting. I cannot overemphasize how much I respect your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Manus Sazon**
> ""This will carve your name in the annals of history not as a monarch who clung to power, but as a visionary who saw beyond the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[534]`
  - -> `[190]`
  - -> `[252]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Legislative_Bicameral = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Bicameral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Manus Sazon**
> ""I understand where you're coming from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""I see your point. A bicameral structure makes sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[67]`
Mówca: **Narrator**
> "He took some notes in his notebook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""The judiciary interprets, defends, and applies the law in the name of the state -- and thus should be independent from other branches of government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`
  - -> `[72]`
  - -> `[73]`

### Węzeł `[69]`
Mówca: **Manus Sazon**
> ""To ensure that the executive and legislative branches don't go beyond the powers enshrined to them, the judiciary must be given the right to put a stop to government actions that they deem unconstitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. Judicial independence serves to safeguard the rights and privileges provided by the constitution. It should prevent the executive and legislative branches from encroaching upon those rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine by me. The amount of respect that people have for the law is dependent upon the judiciary's status as a politically independent entity. Politicizing it will only hurt the rule of law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The judiciary can't be too independent. There must be mechanisms to prevent their abuse of power. Judges can't lack accountability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It *should* be, yes. But it is impossible to design a system without any flaws. The judiciary is doomed to be politicized, and it is in the best interests of the country to ensure that those politics align with those of the ruling government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Judiciary_Independent = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Judiciary_Independent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Manus Sazon**
> ""Yes. The judiciary's role in deciding the validity of the elections also necessitates their independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Manus Sazon**
> ""I don't disagree. But the key is to achieve equilibrium between accountability and independence to ensure that justice is upheld.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "He stopped for a moment to think and went through his notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[78]`
Mówca: **Manus Sazon**
> ""Now that I have an idea of your opinions, Your Majesty, the RPP can start drafting the new constitution in earnest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
Mówca: **Manus Sazon**
> ""I'll be honest with you. If any House has the power to stop us, it's Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[86]`
Mówca: **Manus Sazon**
> ""But I have to warn you, it will be an uphill battle from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""Tell me your honest opinion. Will they be a threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[131]`
  - -> `[355]`
  - -> `[79]`
  - -> `[119]`
  - -> `[82]`
  - -> `[124]`

### Węzeł `[91]`
Mówca: **Manus Sazon**
> ""Many officers of the law, as well as military personnel, are sympathetic -- if not outright loyal to -- the Azaro family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't know for sure. General Taddeus is in charge of the armed forces, and for all I know he's keeping Azaro troops in reserve for exactly this kind of scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Control_Skipped == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, the bulk of their forces have been destroyed in the war. I don't think they'll have the capacity to strike.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Dead > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Dead > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Azaro_Dead > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 0  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pales_Operation1_Won == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 0  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'm giving the orders in this war. I can make sure the Azaro troops are indisposed by the time we're ready to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`
  - -> `[107]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The war is going terribly. The Azaros and their troops will have to keep their entire focus on the frontlines if they want a prayer of winning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are winning the war, Manus. If Rizia emerges victorious, House Azaro will have both the means and the heroic reputation to contest us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still have to be careful. Even with a war going on, the Azaros are more than capable of a coup.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't think they pose a threat. They can't simply go against both the will of the people and the monarch at the same time and expect to come out on top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Lucita in prison, their ability to organize is weaker than before. But we have to be careful about her father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_Police_PulledBack == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_Police_PulledBack == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Unrest_Police_PulledBack"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Unrest_Police_PulledBack == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Unrest_Police_PulledBack"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[118]`
Mówca: **Manus Sazon**
> ""Rizia's police and intelligence services are watching our every move, looking for the slightest excuse to crush the democratic movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_Police_PulledBack == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_Police_PulledBack == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Unrest_Police_PulledBack"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Unrest_Police_PulledBack == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Unrest_Police_PulledBack"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We won't have to worry about the police. I gave the order for our internal security forces to pull their focus away from your movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already done a lot on that front. House Azaro no longer controls Rizia's security forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They won't be able to raise an army against us. I made sure of that when I removed provincial levies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Manus Sazon**
> ""Great thinking, Your Majesty. Although the family does still hold sway across the Cardesse-Montaklar province.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[129]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty. Although this will not stop their military faction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can handle Lucita. She and I have an... understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[135]`
Mówca: **Manus Sazon**
> ""That's a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[136]`
Mówca: **Manus Sazon**
> ""Interesting news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[137]`
Mówca: **Manus Sazon**
> ""An interesting plan...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[138]`
Mówca: **Manus Sazon**
> ""If you're confident you can convince her of the necessity of our reforms, that's great news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[139]`
Mówca: **Manus Sazon**
> ""I hope you are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[140]`
Mówca: **Manus Sazon**
> ""I understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[141]`
Mówca: **Manus Sazon**
> ""That might become a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[142]`
Mówca: **Manus Sazon**
> ""They may not have as much firepower as the Azaros, but they have royal authority on their side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Manus Sazon**
> ""Your uncle holds incredible sway in Valenqiris. Is there a risk he will marshall your House against you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[145]`
  - -> `[149]`
  - -> `[694]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My family and I are not on the best of terms as it is. They'll never accept a new constitution for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All Hugo cares about is that the nobility of Rizia is respected. I'll find a way to work with House Toras on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If there is anyone who can claim the throne during a crisis, that's my uncle. I don't think I trust him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry about the Toras family. They are not going to be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Manus Sazon**
> ""That's a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[152]`
Mówca: **Manus Sazon**
> ""That complicates things. You can't have them go against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`
  - -> `[362]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need their support. They cannot simply fight against the democratic movement. Besides, I'm still the monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have to be diplomatic. I cannot reform Rizia without involving my own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""I don't know about that... But I want to trust you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[157]`
Mówca: **Manus Sazon**
> ""I will not condone violence, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""But I'm sure there is a way to neutralize House Toras that does not involve bloodshed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[159]`
Mówca: **Manus Sazon**
> ""I'm afraid the Rizian National Coalition will present quite the obstacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Manus Sazon**
> ""Baroness de Rava has tolerated the growth of the reformist movement, but she will never condone it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[164]`
Mówca: **Manus Sazon**
> ""Any more thoughts before we fully commit to this plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[789]`
  - -> `[800]`
  - -> `[807]`
  - -> `[170]`

### Węzeł `[165]`
Mówca: **Narrator**
> "He shut his notebook and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[166]`
Mówca: **Manus Sazon**
> ""I don't expect her or the RNC to budge an inch on our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[177]`
  - -> `[400]`
  - -> `[402]`

### Węzeł `[167]`
Mówca: **Manus Sazon**
> ""This would mean the head of government will be an elected official -- who can later be officially appointed by the head of state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Manus Sazon**
> ""They will lead a cabinet of ministers, sit as a member of the House of Delegates, and determine the direction of the Rizian government on behalf of the monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think you're too worried about all this, Manus. You should relax. I'm willing to consider any means necessary for democracy, but you don't have to involve yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. We've covered everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be careful, Manus. My daughter's grown quite attached to you. For her sake, I don't want anything to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Manus Sazon**
> ""Don't worry, Your Majesty. You can trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[176]`
Mówca: **Manus Sazon**
> ""Well... I have no power to stop you from doing that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She is there to represent and protect the rights of the nobility. How do you plan to get her on our side?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[178]`
Mówca: **Manus Sazon**
> ""Exactly. That is the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[180]`
Mówca: **Manus Sazon**
> ""I will reach out to you when it's time to act. You should not rock the boat until everything is finished and organized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[182]`
  - -> `[181]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. We'll see each other again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I greatly respect what you're doing, Manus. I hope this plan works out -- for both of our sakes as well as Rizia's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know how long I can keep it a secret while your movement is asking to change the system. Sooner or later, I have to make my stance known to the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Manus Sazon**
> ""Of course. We just have to make sure the power players cannot make a move against you once that happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Manus Sazon**
> ""It won't be long now. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Narrator**
> "He smiled and we shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[187]`
Mówca: **Narrator**
> "At the bottom of the stairs was a cold, gloomy room with stone walls, furnished with a single table and a couple of chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank *you* for your devotion to the reformist cause, Manus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're here to make plans. You don't need to butter me up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not doing this for reputation or legacy. A monarch who gives his power away will not be remembered at all. You, the reformer, will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Manus Sazon**
> ""If you say so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[192]`
Mówca: **Manus Sazon**
> ""I wasn't trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[193]`
Mówca: **Narrator**
> "As we ascended back into the wine cellar, I thought about what I had gotten myself into."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Narrator**
> "I hoped I was doing the right thing for Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[196]`
Mówca: **Manus Sazon**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro_Talk = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extradited == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extradited == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[701]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extradited == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[692]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not as worried about Hugo as I am about my cousin Ricardus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I arrested Hugo's only son. I wouldn't be surprised if he was plotting revenge against me as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Narrator**
> "Manus looked troubled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Toras = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Toras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Toras_Talk = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Manus Sazon**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[208]`
Mówca: **Narrator**
> "He tapped the cover of his notepad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[213]`
Mówca: **Manus Sazon**
> ""And as Lady Regent, she's very popular with some segments of the population.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`
  - -> `[226]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FullCouncilor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FullCouncilor == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FullCouncilor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FullCouncilor == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FullCouncilor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Manus Sazon**
> ""And as Duchess of Valenqiris, she's very popular within House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`
  - -> `[226]`

### Węzeł `[221]`
Mówca: **Manus Sazon**
> ""And as Crown Princess, she's very popular with some segments of the population.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`
  - -> `[226]`

### Węzeł `[222]`
Mówca: **Manus Sazon**
> ""I will reach out to you when it's time to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[182]`
  - -> `[181]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good job. I hope everything works according to plan. We'll see each other very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a good idea. She can be instrumental in controlling the narrative. I will ask her if she wants to be involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. She would be a great asset. I will involve her immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. We're not going to involve her in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Manus Sazon**
> ""If you think that's best, I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Involve_Vina = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Involve_Vina"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Manus Sazon**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[232]`
Mówca: **Narrator**
> "The only spot of color was a pale blue pocket square on the floor. I picked it up and noticed it was embroidered with the initials M.M."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Manus Sazon**
> ""Does someone else know about this location, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me. We're secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We could be compromised. Let's make this quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Manus Sazon**
> ""All right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Narrator**
> "We sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_OverthrowMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Manus Sazon**
> ""This has to be a slow, gradual process, Your Majesty. Erasing the importance of the entire Royal Family will lead to societal upheaval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Manus Sazon**
> ""For now, here is what I have in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[247]`
Mówca: **Narrator**
> "The stairs creaked under our feet as we descended. The further down we went into this eerie, abandoned space, the greater the sense of detachment from the palace's luxurious interior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer == true || RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer == true || RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_OutedToPlayer == true || RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certain household staff members. But they would never rat us out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't be doing this if it wasn't what Vina wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[256]`
Mówca: **Manus Sazon**
> ""The Crown Princess has inspired us both, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[257]`
Mówca: **Manus Sazon**
> ""It's the only way forward, as I see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[258]`
Mówca: **Narrator**
> "His eyes welled up slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Manus Sazon**
> ""I only wish Her Highness were here to help. Perhaps she can still be of assistance when she returns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Manus Sazon**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[261]`
Mówca: **Manus Sazon**
> ""The RPP is ready to begin drafting the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[268]`
Mówca: **Manus Sazon**
> ""I have the greenlight from Mr. Sotelato and the RPP to begin drafting the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[272]`
Mówca: **Manus Sazon**
> ""I'm in touch with my RPP colleagues and the leaders of the protest movements. We have the green light to begin drafting the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[273]`
Mówca: **Manus Sazon**
> ""Unfortunately, we're still the opposition party in the House of Delegates. Meaning that if the nobles find out what we're doing, they'll fight tooth and nail to stop it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[274]`
Mówca: **Manus Sazon**
> ""After a series of talks, they agreed to stop their calls for the abolishment of the monarchy if the constitution meets their demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Manus Sazon**
> ""As Mr. Sotelato is now the majority speaker in the House of Delegates, he's in a very strong position to negotiate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[279]`
Mówca: **Manus Sazon**
> ""As we briefly discussed, we will need to be very strategic about the publication and implementation of these reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Manus Sazon**
> ""Especially when it comes to getting them past the noble houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""However, not only does the RPP still hold a House minority, but Mr. Sotelato is now branded as a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[282]`
Mówca: **Manus Sazon**
> ""As majority speaker in the House of Delegates and the heir to House Sazon, I believe I'm in a very strong position to ensure a peaceful and diplomatic resolution with the nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[286]`
Mówca: **Manus Sazon**
> ""The problem is that not only is the RPP still the opposition, I've been branded a threat. Meaning that if the nobles find out what we're doing, they'll fight tooth and nail to stop it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to get at least two of the three royal Houses to approve. I don't see how we can accomplish this otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they do, we'll fight back. No one goes up against the King and lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm having second thoughts about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that's why we're here alone in this dark damp room, aren't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`
  - -> `[290]`
  - -> `[289]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[293]`
  - -> `[294]`
  - -> `[296]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to get at least two of the three royal Houses on board. Otherwise, our reforms will be dead in the water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't intend to include the nobles in the reform process. We already know they will never agree to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is our best chance, Manus. We have to seize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Does that imply the existence of a *non-peaceful* resolution?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Manus Sazon**
> ""If you're referring to the use of violence, I would never agree to go that route. I refuse to follow in my father's footsteps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Manus Sazon**
> ""But that doesn't mean we have to be diplomatic with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Manus Sazon**
> ""We don't have to include the nobles in the drafting process. There are ways to ensure they won't get wind of the reforms until the ink on the constitution has dried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[300]`
Mówca: **Manus Sazon**
> ""We can try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[301]`
Mówca: **Manus Sazon**
> ""We will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[302]`
Mówca: **Manus Sazon**
> ""I'm telling you, Your Majesty. We won't even get the chance to persuade them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Manus Sazon**
> ""Declaring our reform intentions to them would make us a target. The Crown itself would be in peril.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`
  - -> `[309]`

### Węzeł `[304]`
Mówca: **Narrator**
> "He let out a short laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Manus Sazon**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[306]`
Mówca: **Manus Sazon**
> ""Please, Your Majesty. All our efforts will be for nothing if they result in violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[550]`
  - -> `[554]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do we do it without them? After all, it's not possible to hide the fact that we're changing the political system from anybody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I will make sure they won't have the capacity to put their focus against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you suggest, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Manus Sazon**
> ""Of course not, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Manus Sazon**
> ""There is a reason why we're meeting here in secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Manus Sazon**
> ""If we can keep the process completely under wraps until the constitution's been signed, the Houses will have no choice but to accept it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[313]`
Mówca: **Manus Sazon**
> ""With millions of people on the streets on our side, it would be too late for any force to intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[317]`
Mówca: **Manus Sazon**
> ""By the time the House of Delegates proposes the constitution, everything will already be in place. You arrive at the House with the protection of the Golden Guard and sign it with the delegates, declaring it on live broadcast nationally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`
  - -> `[328]`
  - -> `[329]`

### Węzeł `[319]`
Mówca: **Manus Sazon**
> ""I understand what you're saying, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[320]`
Mówca: **Manus Sazon**
> ""We can add some concessions to the nobles in these reforms. If they're allowed to keep their titles and estates, they might be persuaded to approve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[321]`
Mówca: **Manus Sazon**
> ""If we include the nobility in the process, they'll certainly demand to keep their estates and at least some of their power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[322]`
Mówca: **Manus Sazon**
> ""But before we start planning how to pass our new constitution, I suggest we first discuss its contents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[323]`
Mówca: **Manus Sazon**
> ""Therefore, before we discuss how to pass our new constitution, we must first discuss its contents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Manus Sazon**
> ""Don't worry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're suggesting we attempt a coup.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like the sound of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With House Azaro's intelligence capabilities and House Toras' eyes and ears within the palace, maintaining total secrecy will be impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. Even if we do this exactly the way you describe, the nobility can still deem the new constitution illegitimate and oust me from power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Manus Sazon**
> ""It would be too late for any force to intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[331]`
Mówca: **Manus Sazon**
> ""Only if they themselves have enough power and support to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Manus Sazon**
> ""But before we start planning how to unveil the new constitution, I suggest we first discuss its contents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[333]`
Mówca: **Manus Sazon**
> ""Well, I wouldn't phrase it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[334]`
Mówca: **Manus Sazon**
> ""It won't be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[335]`
Mówca: **Manus Sazon**
> ""The RPP will organize the reform movement while you make sure the security of Porte Drazon is not compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[336]`
Mówca: **Manus Sazon**
> ""If we want a peaceful resolution to all this, we need to play it smart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[340]`
Mówca: **Manus Sazon**
> ""However, Mr. Sotelato is not open to the idea of the nobles retaining any privilege other than the royal family of the monarch, which he agreed to respect as long as they act purely as a symbolic head of state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[344]`
Mówca: **Manus Sazon**
> ""Mr. Sotelato will never budge on this point, Your Majesty. The monarch must reign in name only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[348]`
Mówca: **Manus Sazon**
> ""I'm not sure about that, Your Majesty. I doubt the nobles can be convinced. Nonetheless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[349]`
Mówca: **Manus Sazon**
> ""We have hundreds of thousands of people rallying for change. Although we have momentum on our side, we're still in a precarious situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Manus Sazon**
> ""We might have the people's support and hold a legitimate majority in the House of Delegates, but given the opportunity, I do not doubt the nobles will show their true colors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[354]`
Mówca: **Manus Sazon**
> ""We would not only be going against the will of the nobles, but also that of Baroness de Rava and the House of Delegates. We have to be extremely careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, definitely. They'll never agree to these reforms peacefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Manus Sazon**
> ""That's a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Without eyes or ears inside the house, I have no idea whether they're a threat or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Deposed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Deposed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Deposed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Deposed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Deposed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about Hugo. But I do know that my cousin Ricardus would love nothing more than to see me humiliated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is still time for me to get on their good side. But we have to make a plan for the worst case scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Manus Sazon**
> ""Yes. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[370]`
Mówca: **Manus Sazon**
> ""Unfortunately, my mother may be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[371]`
Mówca: **Manus Sazon**
> ""As the reinstated matriarch of House Sazon, she commands more respect from our family than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Manus Sazon**
> ""And frankly, she and I are of different minds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All Hugo cares about is that the nobility of Rizia is respected. If we keep Valenqiris semi-autonomous and introduce a House of Lords in parliament, he'll have nothing to complain about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true || RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true || RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  or  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true || RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  or  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[380]`
Mówca: **Manus Sazon**
> ""She doesn't support my movement or our demands for reform. And she'll never agree with Sotelato's proposed terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[381]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[382]`
Mówca: **Manus Sazon**
> ""She would likely not support any constitution that doesn't respect our family as a royal house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Manus Sazon**
> ""She doesn't support my movement or our demands for reform. And she won't so much as glance at the new constitution as long as Daria and the RNC are in charge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Manus Sazon**
> ""I will be honest. This is a setback I wasn't prepared for, and it will make my job difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[391]`
  - -> `[390]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Manus Sazon**
> ""She has taken a staunchly monarchist stance since her arrival. I fear all those years of being punished for her husband's betrayal have gotten to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure that's where her loyalties truly lie? What if she's been a secret reformist all this time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the one who pardoned her. If she's truly loyal, she will support me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give it to me straight. Can you handle this yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If she and your kin don't fall in line, I will make them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Manus Sazon**
> ""So that has to be taken into account as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[394]`
Mówca: **Narrator**
> "A look of fear flashed on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[396]`
Mówca: **Manus Sazon**
> ""I can't guarantee it. All I can tell you is that if House Toras and Azaro agree to the reforms, my mother's objections will count for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[397]`
Mówca: **Manus Sazon**
> ""She is loyal to the Crown. Not to the man wearing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Manus Sazon**
> ""If she were, I would know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Manus Sazon**
> ""All I can tell you is that if House Toras or Azaro opposes the reforms, my mother will join forces with them to stop us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the very institution that you'll be empowering doesn't recognize or accept the transition, how will the constitution be put in place?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why do we care? We're already making enemies. The RNC is the least of our worries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean? They are loyal to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[403]`
Mówca: **Manus Sazon**
> ""They are a worry, Your Majesty. As the majority, they have the power to obstruct us at every turn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Manus Sazon**
> ""As the majority, the RNC has the power to obstruct us at every turn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Manus Sazon**
> ""If de Rava finds out about our plans while they're still at this early stage, she'll crush them in their tracks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true  and  Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true  and  Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && RiziaDLCIsolated.Reform_Threat_Toras_Talk == true && RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && RiziaDLCIsolated.Reform_Threat_Toras_Talk == true && RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] == true  and  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && RiziaDLCIsolated.Reform_Threat_Toras_Talk == true && RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] == true  and  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[412]`
Mówca: **Manus Sazon**
> ""If we assume that both House Toras and House Azaro will stop at nothing to oppose our reforms...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[413]`
Mówca: **Manus Sazon**
> ""You said you think you can convince House Toras and House Azaro to agree to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[414]`
Mówca: **Manus Sazon**
> ""You don't believe that either House Azaro or House Toras will challenge our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDLCIsolated.Reform_Threat_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDLCIsolated.Reform_Threat_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  or  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDLCIsolated.Reform_Threat_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  or  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || RiziaDLCIsolated.Reform_Threat_Toras_Talk == true) && RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || RiziaDLCIsolated.Reform_Threat_Toras_Talk == true) && RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true  or  Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] == true)  and  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || RiziaDLCIsolated.Reform_Threat_Toras_Talk == true) && RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true  or  Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] == true)  and  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Manus Sazon**
> ""You said you thought you could convince House Azaro to agree to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Manus Sazon**
> ""You said you thought you could convince House Toras to agree to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[432]`
Mówca: **Manus Sazon**
> ""With that in mind, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[433]`
Mówca: **Manus Sazon**
> ""If you succeed, we'll have the two most powerful royal houses on our side. Even if my mother disagrees, there's nothing she could do about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[434]`
Mówca: **Manus Sazon**
> ""But even in that case, you would need to get at least one of the other royal houses on your side. And as I mentioned, my mother won't be easy to deal with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[435]`
Mówca: **Manus Sazon**
> ""If you succeed, and if House Sazon rallies behind me as I expect they will, we'd have two of the three royal houses on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[439]`
Mówca: **Manus Sazon**
> ""If you succeed, and if House Sazon rallies behind me as I expect they will, we'll have all three royal houses on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[440]`
Mówca: **Manus Sazon**
> ""That being said, we still have room to bargain. If the new constitution grants concessions to the nobles, I believe we will still be able to convince them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[441]`
Mówca: **Manus Sazon**
> ""We've established that all three royal houses will be a threat to our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Azaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Threat_Azaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Manus Sazon**
> ""If we assume House Azaro will stop at nothing to oppose our reforms...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Manus Sazon**
> ""If we assume House Toras will stop at nothing to oppose our reforms...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Manus Sazon**
> ""...and my mother Angelica will most certainly unite House Sazon against us as well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[451]`
Mówca: **Manus Sazon**
> ""That leaves us in a very dangerous position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[452]`
Mówca: **Manus Sazon**
> ""I believe taking this reform through public channels and negotiating with the royal houses is the best course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[453]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority and I have legitimacy as House Speaker. If you command the respect of the nobility as you say, this should be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Manus Sazon**
> ""What do you say, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`
  - -> `[491]`
  - -> `[490]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`

### Węzeł `[458]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority, I have legitimacy as House Speaker and a growing movement is uniting behind us. If you command the respect of the nobility as you say, this should be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[462]`
Mówca: **Manus Sazon**
> ""But with the RNC holding a majority in the House of Delegates, that doesn't matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[463]`
Mówca: **Manus Sazon**
> ""Despite this fact, I believe there's still a chance we can publicize our intention to reform and negotiate a compromise that satisfies everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[467]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority and I have legitimacy as House Speaker. Under those circumstances, bargaining with the royal houses is a definite possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[468]`
Mówca: **Manus Sazon**
> ""What do you say, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`
  - -> `[491]`
  - -> `[488]`
  - -> `[764]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[472]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority, I have legitimacy as House Speaker and a growing movement is uniting behind us. Under those circumstances, swaying the royal houses won't be difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The nobility will strike as soon as they learn we're cooperating with the revolutionaries. I will not declare my intentions to the public. We must keep a low profile until the reforms are declared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[481]`
Mówca: **Manus Sazon**
> ""Mr. Sotelato's movement is approaching critical mass, Your Majesty. If you publicly support it as well, the pressure on the nobility would be enormous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[482]`
Mówca: **Manus Sazon**
> ""Much as I wish we could sit down with all parties and hammer out a peaceful compromise, I fear it's just not going to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[483]`
Mówca: **Manus Sazon**
> ""But it might not be enough to stop them from organizing against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`
  - -> `[474]`
  - -> `[494]`
  - -> `[497]`

### Węzeł `[484]`
Mówca: **Manus Sazon**
> ""The Rizian people are openly demanding reform, Your Majesty. If you publicly support it as well, the pressure on the nobility would be enormous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[485]`
Mówca: **Manus Sazon**
> ""But it might not be enough to stop them from organizing against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`
  - -> `[494]`
  - -> `[492]`
  - -> `[497]`

### Węzeł `[486]`
Mówca: **Manus Sazon**
> ""With our current circumstances, it would be unwise to declare your intentions to reform Rizia before the new constitution is ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[487]`
Mówca: **Manus Sazon**
> ""My advice would be to lay low until the time is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[495]`
  - -> `[497]`

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I honestly don't know if I have enough sway with the Royal Houses to convince them to give away their power peacefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with you, Manus. The sooner we publicize our reform intentions, the sooner the transformation of Rizia can begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know I said I could convince the nobility. But upon further reflection, I'm not so confident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While I'm skeptical about declaring our reform intentions immediately, I do agree that the nobles should have a say in the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The nobility will strike as soon as they learn what we're trying to do. I will not declare my intentions to the public. We must keep a low profile until the reforms are ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Once we declare our intentions, the power of the reform movement will be undeniable. There's no chance the nobles will move against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The stakes are too high to take half measures. We must strike the houses before they are ready and force our relatives to comply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that the nobility will strike as soon as they learn what we're trying to do. We must keep a low profile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The stakes are too high to take half measures. We must organize a preemptive strike against the nobility and force them to comply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still think we should be open and diplomatic with the royal houses. As Rizia's most noble of families, they deserve a seat at the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Aggressive = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Aggressive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Silent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[501]`
Mówca: **Manus Sazon**
> ""No chance at all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[502]`
Mówca: **Manus Sazon**
> ""Even with the populace against them, there's still a chance one or more of the houses will try to strike before the constitution is signed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`
  - -> `[503]`
  - -> `[505]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Once the pressure has built to a significant degree, we'll invite them for negotiations. They'll fold like a second-rate poker player.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we have to, we will strike first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. It's too risky. We should be stealthy and prepare the new constitution without raising any suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[506]`
Mówca: **Manus Sazon**
> ""Then what are you thinking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`
  - -> `[474]`
  - -> `[494]`

### Węzeł `[507]`
Mówca: **Manus Sazon**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Manus Sazon**
> ""Then it is settled, Your Majesty. We will seek the royal houses' approval on our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Manus Sazon**
> ""I will reach out to you when the time is right and we have a draft ready to discuss with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[511]`
Mówca: **Manus Sazon**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[512]`
Mówca: **Manus Sazon**
> ""You can't be serious, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`
  - -> `[667]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My benevolence has its limits. Sotelato's people know that without my cooperation there would be no reforms, and yet my opinion is not respected. I won't have any of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am very serious, Manus. Our collaboration is over. You'd better stop representing this movement before it's too late as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[515]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me repeat myself. Our meeting is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[516]`
Mówca: **Narrator**
> "Manus' voice wavered with uncertainty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Aggressive = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Aggressive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[519]`
Mówca: **Manus Sazon**
> ""An interesting plan, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[520]`
Mówca: **Manus Sazon**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[521]`
Mówca: **Manus Sazon**
> ""So be it, Your Majesty. Perhaps my fears are overblown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Manus Sazon**
> ""Then I will reach out to you for our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[523]`
Mówca: **Manus Sazon**
> ""I... I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[524]`
Mówca: **Narrator**
> "He bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "He bowed."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[526]`
Mówca: **Manus Sazon**
> ""Thank you for the meeting, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[527]`
Mówca: **Narrator**
> "As we ascended back into the wine cellar, I thought about what I had gotten myself into."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[528]`
Mówca: **Narrator**
> "I hoped that cutting ties with the reformists had been the right move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[529]`
Mówca: **Narrator**
> "With Pabel's help, Manus managed to make it into the Palas Rezna kitchens through a service entrance. We greeted each other in hushed voices, then headed below the kitchen to the wine cellar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[532]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[533]`
Mówca: **Narrator**
> "With Titus' help, Manus managed to make it into the Palas Rezna kitchens through a service entrance. We greeted each other in hushed voices, then headed below the kitchen to the wine cellar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too excited. All I'm trying to do is keep your party's lunatic fringe from coming for my head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Manus Sazon**
> ""But you're not going after theirs. That's a promising start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[542]`
Mówca: **Manus Sazon**
> ""When the Crown Princess returns, it will be to a changed Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[543]`
Mówca: **Manus Sazon**
> ""On the other hand, I doubt the nobility will agree to play by his rules.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[544]`
Mówca: **Manus Sazon**
> ""The second the nobles find out we're working with him, they will try to stop us by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[548]`
Mówca: **Manus Sazon**
> ""The RPP may not hold a delegate majority, but as the Crowd Prince Consort, I still hold some sway with the nobles. A peaceful resolution may yet be possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wise man once told me that violence is justified if it helps protect the divine order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == true || RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == true || RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk"] == true  or  Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == true || RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk"] == true  or  Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that violence should only be used as a last resort. But it sounds like we're reaching that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[554]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was speaking metaphorically. We'll fight them with our *words*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[555]`
Mówca: **Manus Sazon**
> ""I was just about to tell you that we shouldn't say a word to the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[556]`
Mówca: **Manus Sazon**
> ""Justified? You sound like my father...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[557]`
Mówca: **Manus Sazon**
> ""It doesn't have to come to that. Listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`
  - -> `[560]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's about time. Numbers make me dizzy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`
  - -> `[564]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[565]`
Mówca: **Manus Sazon**
> ""First, I want to go over the demands of Sotelato's faction to get a sense of your perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[566]`
Mówca: **Manus Sazon**
> ""He and I agree that our main objective is to ensure the political participation of our citizens. This is only possible if the monarch's power is limited, as enshrined in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[567]`
Mówca: **Manus Sazon**
> ""Our country is still an absolute monarchy in all but name. Your father created the House of Delegates as a symbolic parliament, but the new constitution can give it the true authority it represents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[568]`
Mówca: **Manus Sazon**
> ""This would mean the head of government will be an elected official -- who can later be ceremonially appointed by the head of state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[569]`
Mówca: **Manus Sazon**
> ""You will no longer rule, Your Majesty. But you'll reign, albeit in name only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[570]`
Mówca: **Manus Sazon**
> ""They will lead a cabinet of ministers, sit as a member of the House of Delegates, and determine the direction of the Rizian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[571]`
  - -> `[572]`
  - -> `[573]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then what will I do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds like far too much power for one person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't object to any of this so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Manus Sazon**
> ""The head of government's powers would be clearly outlined in the constitution. The goal is to balance the power structure fairly so that no branch has complete authority over the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[575]`
Mówca: **Manus Sazon**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. The monarch should act as the head of state, not the head of government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[577]`
Mówca: **Manus Sazon**
> ""That's what we've been working on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[578]`
Mówca: **Manus Sazon**
> ""Mr. Sotelato will never budge on this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[579]`
Mówca: **Manus Sazon**
> ""With all due respect, Your Majesty, I don't think you understand what Sotelato's movement wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[580]`
Mówca: **Manus Sazon**
> ""The House of Delegates itself will be defined as the governing legislative body in Rizia, with clearly outlined procedures and jurisdiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[581]`
Mówca: **Manus Sazon**
> ""Instead of the monarch, they will be in charge of managing the government budget and passing laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`
  - -> `[585]`
  - -> `[586]`
  - -> `[592]`

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if their decisions are subject to the monarch's -- to *my* -- approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[583]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if the monarch holds the right to veto their decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[584]`
Mówca: **Manus Sazon**
> ""Unless you can accept the complete transfer of your sovereignty to the House of Delegates, the new constitution will never pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll miss being able to sign decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Numbers make my head hurt anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[590]`
Mówca: **Manus Sazon**
> ""If I were in charge of the RPP, I'd allow the monarch to have some sort of say in politics. Alas, I am not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[591]`
Mówca: **Manus Sazon**
> ""The responsibility must be painful indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[592]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? I was expecting much worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[593]`
Mówca: **Manus Sazon**
> ""I'm not finished with the list of demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[594]`
Mówca: **Manus Sazon**
> ""As for the other demands...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[595]`
Mówca: **Narrator**
> "He looked down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That makes sense. If I don't have any power, my relatives shouldn't either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[597]`
Mówca: **Manus Sazon**
> ""Soletato's group is asking not only for the removal of the monarch's sovereign powers, but for the removal of all political privileges from the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`
  - -> `[599]`
  - -> `[603]`
  - -> `[604]`

### Węzeł `[598]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not fair. Some of Rizia's finest politicians are nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`
  - -> `[601]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Finishing the job my electoral reform decree started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A slap in the face to Rizian tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But they can keep their money, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[605]`
Mówca: **Manus Sazon**
> ""Whatever's left of it after the tax hikes the new government is planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[606]`
Mówca: **Manus Sazon**
> ""It will make many people very angry, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[607]`
Mówca: **Manus Sazon**
> ""They can run for election, like anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[608]`
Mówca: **Manus Sazon**
> ""More than that. In a few generations, the names Toras, Azaro and Sazon will mean next to nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[609]`
Mówca: **Manus Sazon**
> ""I would expect nothing less from this movement. But it will make a good deal of people very angry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[610]`
Mówca: **Manus Sazon**
> ""Finally... after the constitution is signed, an interim prime minister will have to be appointed to govern Rizia during the transitory period before the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[611]`
Mówca: **Manus Sazon**
> ""The RPP's demand is for Adarfo Sotelato himself to fill that role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[614]`
  - -> `[613]`
  - -> `[615]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was fine with all the other demands. But I will not put an unproven commoner in charge of our kingdom, even temporarily. Tell the rest of your party that the plan is off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's what it takes to get the reforms across the finish line, then I agree to all of the demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all your mistake for letting RPP get radicalized. I'm afraid I will not agree to their demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With terms like these, we might as well abolish the Rizian monarchy altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[616]`
Mówca: **Narrator**
> "Manus broke into an enormous, relieved smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[617]`
Mówca: **Manus Sazon**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[618]`
Mówca: **Manus Sazon**
> ""If that is what you want, all you have to do is hand your crown to Adarfo Sotelato.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[619]`
Mówca: **Manus Sazon**
> ""I warn you, though, he might not accept it unless your head comes off with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`
  - -> `[622]`
  - -> `[623]`

### Węzeł `[620]`
Mówca: **Narrator**
> "He smiled darkly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm willing to take that risk. Get me a meeting with Sotelato. I should have been speaking with him this entire time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not my intention to abdicate, Mr. Sazon. Nor is it my intention to hand over my and my family's power to some urchin from the mines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only meant to say that Sotelato's demands are extreme. But I'll agree to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[624]`
Mówca: **Narrator**
> "His face fell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[625]`
Mówca: **Narrator**
> "His face fell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[626]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_TalkToAdarfo_AskedManus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[627]`
Mówca: **Manus Sazon**
> ""I... uh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[628]`
Mówca: **Manus Sazon**
> ""I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[629]`
Mówca: **Narrator**
> "He flipped to another page in his notepad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[630]`
Mówca: **Manus Sazon**
> ""Now that you've agreed on the basics, there are a few more details we should discuss. The RPP leadership is flexible on these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[631]`
Mówca: **Manus Sazon**
> ""One significant decision is whether to keep the old regional structure in Rizia or centralize the system in Porte Drazon completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[632]`
Mówca: **Manus Sazon**
> ""Keep in mind that the royal houses will be stripped of their governing power whether Rizia is centralized or not. The new provincial leadership will have to be democratically elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`
  - -> `[29]`
  - -> `[30]`
  - -> `[31]`

### Węzeł `[633]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`
  - -> `[635]`

### Węzeł `[634]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`
  - -> `[638]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[638]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_TalkToAdarfo_AskedManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[639]`
Mówca: **Narrator**
> "I had given up the opportunity to reform Rizia. And soon, I might be about to give up my crown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_PowerTransfer_Council_Brenas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`
  - -> `[642]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_PowerTransfer_Council_Brenas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Iza_PowerTransfer_Council_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Iza_PowerTransfer_Council_Brenas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Iza_PowerTransfer_Council_Brenas"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[643]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A governing council is working out well for Iza. The provinces should adopt the same system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[644]`
Mówca: **Manus Sazon**
> ""Respecting regional traditions would be a clever choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`
  - -> `[647]`

### Węzeł `[646]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[647]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[648]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor will Duke Axel Reinhart. I doubt he'll agree to reunification if it means Pales losing all of its autonomy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[649]`
Mówca: **Manus Sazon**
> ""It would be a tragedy if the Princess' arranged marriage was for nothing. Decentralization it is, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[650]`
Mówca: **Narrator**
> "Manus smiled thinly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[651]`
Mówca: **Manus Sazon**
> ""I see. A House of Lords, so to speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`
  - -> `[654]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[655]`
Mówca: **Manus Sazon**
> ""The rest of the RPP won't like it. But it's a fine compromise in my opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[656]`
Mówca: **Manus Sazon**
> ""We'll have a hard time getting the nobility to agree to even that. But it's a fine compromise in my opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[862]`
  - -> `[863]`
  - -> `[864]`

### Węzeł `[658]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`
  - -> `[660]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[661]`
Mówca: **Manus Sazon**
> ""Allowing the provincial nobility to serve in this upper chamber would assuage their concerns about losing power under the new system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`
  - -> `[665]`

### Węzeł `[662]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_RegionalSenate = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[663]`
Mówca: **Manus Sazon**
> ""That's settled, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good thinking. The upper chamber will be a House of Lords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I want a clean slate. The upper chamber will be composed of elected representatives for each region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[666]`
Mówca: **Manus Sazon**
> ""A regional senate. The RPP will like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`
  - -> `[669]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[670]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From now on, your duty is to be the Crown Prince Consort. I'll handle Sotelato.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[671]`
Mówca: **Manus Sazon**
> ""I've been thinking about the best way to deal with potential opposition from the three houses. But I want your perspective on them as the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's discuss House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's talk about my relatives in House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[674]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you think House Sazon will react to the reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Threats From Houses)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`
  - -> `[689]`
  - -> `[708]`
  - -> `[723]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[679]`
Mówca: **Manus Sazon**
> ""With that said, General Taddeus, Duchess Lucita and most Rizian troops are concentrating on the war in Pales. They might be too distracted to contest or even notice our reform attempts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[104]`
  - -> `[109]`
  - -> `[110]`
  - -> `[131]`

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need to worry about General Taddeus. The last time we spoke, I made sure he knew his place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[681]`
Mówca: **Manus Sazon**
> ""That's not very reassuring. The General is an infamous holder of grudges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[682]`
Mówca: **Manus Sazon**
> ""As long as it doesn't jeopardize Her Highness' survival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`
  - -> `[685]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[685]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[688]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`
  - -> `[691]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[692]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He did not dare to strike back at me even after I arrested Rico. He won't be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[693]`
Mówca: **Manus Sazon**
> ""If you say so... You know your relatives better than I do, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[694]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`
  - -> `[696]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[696]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[697]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With my daughter about to marry his son? It'll never happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[698]`
Mówca: **Manus Sazon**
> ""Correct me if I'm wrong, but that marriage is meant to preserve the Toras line of succession. Which will be of significantly less importance if these reforms succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[699]`
Mówca: **Manus Sazon**
> ""But let's assume for now that the coming royal wedding will put Hugo and Rico in our camp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Threats From Houses])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_PoliceChief_PorteDrazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`
  - -> `[703]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_PoliceChief_PorteDrazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_PoliceChief_PorteDrazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[704]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After I made his son police chief? Not a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[705]`
Mówca: **Manus Sazon**
> ""But Your Majesty... now that Duke Ricardus is in charge of the capital's security, he can very easily stop our reforms in their tracks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`
  - -> `[707]`

### Węzeł `[706]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dammit. You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[707]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He could, but he wouldn't dare. I've got him under my thumb.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`
  - -> `[710]`

### Węzeł `[709]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[710]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[711]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_PowerTransfer_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`
  - -> `[713]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_PowerTransfer_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Iza_PowerTransfer_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[714]`
Mówca: **Manus Sazon**
> ""As the matriarch of House Sazon and the Duchess of Iza, she commands more respect from our family than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[715]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`
  - -> `[718]`

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[719]`
Mówca: **Manus Sazon**
> ""At last, an easy question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[720]`
Mówca: **Manus Sazon**
> ""I am House Sazon's heir and the Crown Prince Consort. No member of my family commands more respect than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[721]`
Mówca: **Manus Sazon**
> ""I am House Sazon's heir. No member of my family commands more respect than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[722]`
Mówca: **Manus Sazon**
> ""My cousin Leona is little more than a figurehead. She and the others will support the reforms when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`
  - -> `[725]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`
  - -> `[735]`

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That covers the royal houses. What about Daria and the House of Delegates?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[727]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`
  - -> `[729]`

### Węzeł `[728]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[729]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That covers the royal houses. What about your fellow Delegates?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[731]`
Mówca: **Manus Sazon**
> ""Baroness de Rava has tolerated the presence of the reformist movement in parliament, but she will never condone it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[732]`
Mówca: **Manus Sazon**
> ""Exactly. That's the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[733]`
Mówca: **Manus Sazon**
> ""As the majority, the RNC has the power to obstruct us at every turn, with the justification the new constitution is 'against the will of the people'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[734]`
Mówca: **Manus Sazon**
> ""The RPP is the majority party, Your Majesty. If we all support the new constitution, Daria and the RNC won't contest it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`

### Węzeł `[735]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a waste of time to talk about the houses. Let's just assume they'll never agree with this plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to discuss the houses. They'll fall in line if I tell them to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[737]`
Mówca: **Manus Sazon**
> ""But Your Majesty, there is still Daria de Rava and the Rizian National Coalition to consider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`
  - -> `[740]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[741]`
Mówca: **Manus Sazon**
> ""I very much hope you're right about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[742]`
Mówca: **Manus Sazon**
> ""If the new constitution gains a delegate majority in the HOD -- which it will, because my party is in charge -- the nobles won't have the legal means to challenge us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[743]`
Mówca: **Manus Sazon**
> ""Then again, the Rizian nobility has been known to resort to extralegal means in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[744]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`
  - -> `[746]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[747]`
Mówca: **Narrator**
> "He looked at me uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`
  - -> `[750]`

### Węzeł `[749]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`

### Węzeł `[750]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[751]`
Mówca: **Manus Sazon**
> ""Are you sure it's not worth trying to bargain with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[752]`
Mówca: **Manus Sazon**
> ""Yes, you're probably right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`

### Węzeł `[753]`
Mówca: **Manus Sazon**
> ""Even if we could get the Houses on our side, Daria de Rava and the Rizian National Coalition present a significant challenge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[754]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`
  - -> `[756]`

### Węzeł `[755]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[756]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[757]`
Mówca: **Manus Sazon**
> ""Not to mention that Adarfo's demands leave us with little room to negotiate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[758]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Threat_Toras_Talk = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`
  - -> `[762]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[762]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[763]`
Mówca: **Manus Sazon**
> ""I maintain they'll never allow a commoner like Adarfo Sotelato to strip them of their privileges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[764]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If being diplomatic means making concessions to the nobility in our new constitution, I would rather not do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[765]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`
  - -> `[767]`

### Węzeł `[766]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[767]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[768]`
Mówca: **Manus Sazon**
> ""We'll talk about this later. I hope we can come to an agreement regarding such an... arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[769]`
Mówca: **Manus Sazon**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[770]`
Mówca: **Manus Sazon**
> ""If and when the time comes to present her with the new constitution, she will likely expect to be named interim prime minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`
  - -> `[775]`
  - -> `[776]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`
  - -> `[773]`

### Węzeł `[772]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[773]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[774]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[775]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you'd be gunning for the position yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[776]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does it matter? She'd only lead the country for a few months, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[777]`
Mówca: **Narrator**
> "He reddened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[778]`
Mówca: **Manus Sazon**
> ""It would be an honor, Your Majesty, but I'm not the majority speaker in parliament. If we're to play by the rules, Daria would be the correct choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[779]`
Mówca: **Manus Sazon**
> ""I agree. On paper, at least, she is the popular choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[780]`
Mówca: **Manus Sazon**
> ""Rizia naming its first prime minister will be an event with immense ramifications. Her name would go down in history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[781]`
Mówca: **Manus Sazon**
> ""If we want to acknowledge the opposition, we could give Daria the role of interim prime minister, letting her lead the government until the first elections are held.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]`
  - -> `[787]`
  - -> `[785]`

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would I do that? You're the man the people want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[783]`
Mówca: **Narrator**
> "He reddened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`

### Węzeł `[784]`
Mówca: **Manus Sazon**
> ""You're too kind, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[785]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? It might help smooth things over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[786]`
Mówca: **Manus Sazon**
> ""And she's unlikely to make too many disruptions during that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]`

### Węzeł `[787]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you'd be gunning for the position yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[788]`
Mówca: **Manus Sazon**
> ""It would indeed be an honor, Your Majesty, but that was never why I proposed these reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[789]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`
  - -> `[791]`

### Węzeł `[790]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[791]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[792]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're not going to make any drastic moves until after the royal wedding. I want it to go off without a hitch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`

### Węzeł `[793]`
Mówca: **Narrator**
> "Manus nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`

### Węzeł `[794]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`
  - -> `[796]`

### Węzeł `[795]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[796]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[797]`
Mówca: **Manus Sazon**
> ""Obviously, so do I. The profile boost I'll get as Prince Consort will be a huge help to the reformist cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[798]`
Mówca: **Narrator**
> "Manus nodded sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[799]`
Mówca: **Manus Sazon**
> ""So do I, Your Majesty. We'll wait.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[800]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Aggressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`
  - -> `[802]`

### Węzeł `[801]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Aggressive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Aggressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[802]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Aggressive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Aggressive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[803]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be careful, Manus. If this goes south, we could both lose our heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[804]`
Mówca: **Narrator**
> "He grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[805]`
Mówca: **Manus Sazon**
> ""Don't worry, Your Majesty. You can trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[806]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A communist prime minister... If that isn't the nail in the coffin for our relationship with ATO, I don't know what is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[807]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`
  - -> `[809]`

### Węzeł `[808]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[809]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[810]`
Mówca: **Manus Sazon**
> ""The West won't like it one bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[811]`
Mówca: **Manus Sazon**
> ""We -- well, Adarfo -- will have to focus on strengthening ties with Morella and Valgsland. It'll be a completely different landscape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[812]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wonder what our neighbors will think of all this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[813]`
Mówca: **Manus Sazon**
> ""As long as we maintain the same trade ties as before, I don't see a reason why any of our international relationships would be affected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[814]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`
  - -> `[816]`

### Węzeł `[815]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`

### Węzeł `[816]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[817]`
Mówca: **Manus Sazon**
> ""Of course, I'm hoping the Pales war will be far in our rearview mirror before the reforms pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[818]`
Mówca: **Manus Sazon**
> ""Speaking of Her Highness...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[819]`
Mówca: **Manus Sazon**
> ""There is one more point I wanted to bring up. About Her Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[820]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`
  - -> `[822]`

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[822]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]`

### Węzeł `[823]`
Mówca: **Manus Sazon**
> ""If we want to be diplomatic about the reform process, I highly suggest we get Vina involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[824]`
Mówca: **Manus Sazon**
> ""This is something she's passionate about as well, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[825]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`
  - -> `[827]`

### Węzeł `[826]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[827]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Silent == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[828]`
Mówca: **Manus Sazon**
> ""For the Princess' own protection, I'm not sure whether she should be informed about these plans until they've come to fruition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`
  - -> `[831]`
  - -> `[838]`
  - -> `[843]`

### Węzeł `[829]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This highly concerns my daughter and her future. Of course she should be informed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[830]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Involve_Vina = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Involve_Vina"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[831]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`
  - -> `[833]`

### Węzeł `[832]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[833]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[834]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. You're her fiance. I don't want you keeping secrets from her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]`

### Węzeł `[835]`
Mówca: **Manus Sazon**
> ""Yes, you're right. I'll tell her as soon as I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[836]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Involve_Vina = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Involve_Vina"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`

### Węzeł `[837]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Admit it. You're worried she's going to fall for Adarfo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]`

### Węzeł `[838]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]`
  - -> `[840]`

### Węzeł `[839]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[840]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[841]`
Mówca: **Manus Sazon**
> ""What? No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`

### Węzeł `[842]`
Mówca: **Manus Sazon**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[843]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be right. I don't want to put my daughter in danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]`

### Węzeł `[844]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]`

### Węzeł `[845]`
Mówca: **Manus Sazon**
> ""She'll be told when the time is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`

### Węzeł `[846]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[847]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path = false;
RiziaDLC.Reform_Path_Cancelled = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Path"] = false;
Variable["RiziaDLC.Reform_Path_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[848]`
Mówca: **Manus Sazon**
> ""In the meantime, please be careful of what information you share in front of the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[849]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]`
  - -> `[851]`

### Węzeł `[850]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]`

### Węzeł `[851]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[852]`
Mówca: **Manus Sazon**
> ""We wouldn't want Captain Gordion to leak anything to the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[853]`
Mówca: **Manus Sazon**
> ""Please be careful of what information you share in front of the Golden Guard, Your Majesty. They can turn into a threat if we're not careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[854]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]`
  - -> `[856]`

### Węzeł `[855]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[856]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[857]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority, the House Speaker is from the RPP and a growing movement is uniting behind us. If you command the respect of the nobility as you say, this should be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[858]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]`
  - -> `[860]`

### Węzeł `[859]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[860]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[861]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority and the House Speaker is from the RPP. If you command the respect of the nobility as you say, this should be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[862]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, these nobles will serve in an advisory capacity only. It will be a kind of inverse of the old system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]`

### Węzeł `[863]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll give them the ability to provide some checks on the lower house, but their power will still be limited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]`

### Węzeł `[864]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This upper house will have equal power to the lower house. I'd like to hear the nobility complain about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]`

### Węzeł `[865]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Advisory = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[866]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[867]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[868]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Conspiring to bring democracy to the Kingdom", "Wine Cellar", "Palace Rezna");)*
- **Efekt (`userScript`):** `SetRichPresence("Conspiring to bring democracy to the Kingdom","Wine Cellar","Palace Rezna");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[869]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_PM_Daria = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
