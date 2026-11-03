# Sordland/Turn09/SnO_RumburgIncident

- **ID konwersacji:** `208`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/208_SnO_RumburgIncident.md`
- **Liczba węzłów dialogowych:** 405
- **Liczba wyborów gracza:** 47

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[38]** Lucian Galade
- **[42]** Valken Kruger
- **[54]** Serge Wolkner
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Bill_Turn09_LighterSecurity_Signed`
- `BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth`
- `BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn06_SnO_Conscription_Removed`
- `BaseGame.Turn08_SecondScandal_LiviaStays`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGame.Unrest_Peaceful_Deal_Promised`
- `BaseGame.Valgsland_Alliance`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Valken_Enemy`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.RumburgIncident_Diplomacy`
- `BaseGame.RumburgIncident_MilitaryParade`
- `BaseGame.RumburgIncident_Retaliation`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGameIsolated.Turn09_SnO_WarRoom_Described`
- `BaseGameSupport.CountryReport_Turn09_Wehlen_RaisesRumburgWorries`
- `BaseGameSupport.Journal_Turn09_RumburgIncident_DeclareWar`
- `BaseGameSupport.Journal_Turn09_RumburgIncident_Diplomacy`
- `BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade`
- `BaseGameSupport.Journal_Turn09_RumburgIncident_Retaliation`
- `BaseGameSupport.News_Turn09_HP_SordishPlaneShot`
- `GameCondition.Turn09_SnO_RumburgIncident`
- `GameCondition.Turn10_Personal_SergeFuneral`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 26

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Valken_Enemy`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGameIsolated.Turn09_SnO_WarRoom_Described`
- `BaseGameSupport.Journal_Turn09_RumburgIncident_DeclareWar`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[242]` (Serge Wolkner): `Variable["BaseGame.RumburgIncident_Diplomacy"] = true;`
- Węzeł `[243]` (Serge Wolkner): `Variable["BaseGame.RumburgIncident_Retaliation"] = true;`
- Węzeł `[244]` (Serge Wolkner): `Variable["BaseGame.RumburgIncident_DeclareWar"] = true;`
- Węzeł `[255]` (Serge Wolkner): `Variable["BaseGame.RumburgIncident_MilitaryParade"] = true;`
- Węzeł `[256]` (Serge Wolkner): `Variable["BaseGame.RumburgIncident_MilitaryParade"] = true;`
- Węzeł `[257]` (Serge Wolkner): `Variable["GameCondition.Turn09_SnO_RumburgIncident"] = true;`
- Węzeł `[360]` (Serge Wolkner): `Variable["BaseGameIsolated.Turn09_SnO_WarRoom_Described"] = true;`
- Węzeł `[361]` (Serge Wolkner): `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- *...oraz 18 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Iosef Lancea**
> "“What do you expect us to do? Sit around and do nothing?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I was woken up in the middle of the night by a call from the Ministry of Defense. Due to the sensitivity of the information, I had to be urgently briefed in person."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“We have much to lose against what exactly?”"]** — Mówca: **Player**
> "“We have much to lose against what exactly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I put on my clothes as fast as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I rushed downstairs and opened the door. Serge was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Serge Wolkner**
> "“Mr. President. This way to the car, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "We got into the car and made our way to the Ministry of Defense building without a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I arrived and was directed downstairs. I came to a set of large doors and quickly read the sign above them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "The sign read 'War Room'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Deivid, Lucian and Iosef were already deep in discussion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“Mr. Lancea. I advise caution. Going to war wouldn't help anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“What is going on here?”"]** — Mówca: **Player**
> "“What is going on here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Status report. Now!”"]** — Mówca: **Player**
> "“Status report. Now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[16]`
Mówca: **Valken Kruger**
> "“Mr. President. Approximately 20 minutes ago, Rumburg downed one of our planes with anti-aircraft fire from the ground. The pilot was declared KIA.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Valken Kruger**
> "“We can't look weak. If we appear weak, they will jump on the opportunity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[18]`
Mówca: **Valken Kruger**
> "“The last recorded position of the plane was inside Sordish air space.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“This is terrible. What should we do?”"]** — Mówca: **Player**
> "“This is terrible. What should we do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“How dare they? This is an attack against our sovereignty!”"]** — Mówca: **Player**
> "“How dare they? This is an attack against our sovereignty!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“We need to be cautious. A war with Rumburg is the last thing we want right now.”"]** — Mówca: **Player**
> "“We need to be cautious. A war with Rumburg is the last thing we want right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Deivid Wisci**
> "“I completely agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[23]`
Mówca: **Deivid Wisci**
> "“Mr. President. I must insist. We need to be calm. We must maintain peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“We need to open diplomatic channels to start an official investigation. Most importantly, we need to remain calm. We must maintain peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[25]`
Mówca: **Valken Kruger**
> "“We must order a military retaliation. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“General Kruger. I mean no offense but are we absolutely sure that is the case? Are you sure this happened within our borders?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Valken Kruger**
> "“No offense taken. Here are the locations on the map and the report from the air base.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Valken Kruger**
> "“We have calculated the trajectory of the gunfire and they started firing when our plane was within our border. The plane was downed near Halgen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[29]`
Mówca: **Valken Kruger**
> "“To answer your question, yes. We are absolutely sure. You can see here on the map that the plane was downed approximately 10 kilometers inside our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[30]`
Mówca: **Narrator**
> "He pointed to several markers on the map."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[31]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[33]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Deivid, Lucian, Valken and Iosef were already deep in discussion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[35]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> "“I agree with your sentiments, Mr. Lancea. Going to war is simply too risky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[39]`
Mówca: **Iosef Lancea**
> "“I agree. We have much to lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> "“We must respond immediately. Otherwise, they will think we are weak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“I agree with your sentiments, Mr. Lancea. Going to war is simply too risky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“Mr. Lancea. I advise caution. Going to war wouldn't help anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[43]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[45]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“They are testing us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“I agree. We have much to lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Valken Kruger**
> "“Have some faith in our soldiers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[49]`
Mówca: **Valken Kruger**
> "“We must respond immediately. Otherwise, they will think we are weak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“We must respond immediately to what exactly?”"]** — Mówca: **Player**
> "“We must respond immediately to what exactly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Iosef Lancea**
> "“Mr. President. Thank you for coming in at this late hour. There is a situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[52]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[55]`
Mówca: **Iosef Lancea**
> "“Mr. President. Thank you for coming in at this late hour. There is a situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“Valken, please go ahead and provide your report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[57]`
Mówca: **Iosef Lancea**
> "“Approximately 20 minutes ago, Rumburg downed one of our warplanes with anti-aircraft fire from the ground. The pilot was declared KIA.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Iosef Lancea**
> "“The last recorded position of the plane was inside Sordish airspace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Deivid Wisci**
> "“Are we absolutely sure that is the case? Are you sure this happened within our borders?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Iosef Lancea**
> "“Here are the locations on the map and the report from the air base.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "He pointed to several markers on the map."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“To answer your question, yes. We are absolutely sure. You can see here on the map that the plane was downed approximately 10 kilometers inside our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Iosef Lancea**
> "“We have calculated the trajectory of the gunfire and found out that they started firing when our plane was within our border. The plane was downed near Halgen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“Under different circumstances I would say we should strike back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[67]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“But, the current status of our military is apparent. We are not adequately equipped for such a foe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“I agree with Mr. Galade. We need to utilize diplomacy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[70]`
Mówca: **Iosef Lancea**
> "“We have enough military power to contest against this violation of international law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[71]`
Mówca: **Iosef Lancea**
> "“We should attack and down one of their planes in retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[72]`
Mówca: **Iosef Lancea**
> "“It is true that this is an attack against Sordland and under different circumstances, the response to that would be clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[75]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
Mówca: **Iosef Lancea**
> "“But, the current status of our military is also clear. We are not adequately equipped for such a foe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Iosef Lancea**
> "“I agree with Mr. Galade. We need to utilize diplomacy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[78]`
Mówca: **Iosef Lancea**
> "“An eye for an eye! That's what we need to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[79]`
Mówca: **Iosef Lancea**
> "“Otherwise, we will look weak and it will lead to more casualties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[80]`
Mówca: **Iosef Lancea**
> "“We should attack and down one of their planes in retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[81]`
Mówca: **Iosef Lancea**
> "“We have enough military power to contest against this violation of international law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[82]`
Mówca: **Iosef Lancea**
> "“We have enough military power to contest against this violation of international law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“This is an attack against Sordland and under different circumstances, the response to that is clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“But, the current status of our military is also clear. We are not adequately equipped for such a foe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Iosef Lancea**
> "“I agree with Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Iosef Lancea**
> "“We should attack and down one of their planes in retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Iosef Lancea**
> "“Otherwise, we will look weak and it will lead to more casualties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[93]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[94]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“Did you start losing your common sense, General Valken?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“You know the state our army is in right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Iosef Lancea**
> "“A retaliation is too risky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Iosef Lancea**
> "“I agree with the General.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Valken Kruger**
> "“When was our job not risky, *Mr.* Lancea?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Valken Kruger**
> "“Mr. President. Our army is ready to do whatever it takes to protect Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Deivid Wisci**
> "“Gentlemen. Before it comes to that point, we can prevent further bloodshed by using diplomacy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "The room fell silent before Iosef finally spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Iosef Lancea**
> "“Mr. President. What are your orders?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[108]`
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Start the Sordish war machine and prepare to invade Rumburg! They will pay for their crimes.”"]** — Mówca: **Player**
> "“Start the Sordish war machine and prepare to invade Rumburg! They will pay for their crimes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“We will approach this diplomatically and try to de-escalate the situation by any means. No one wants war.”"]** — Mówca: **Player**
> "“We will approach this diplomatically and try to de-escalate the situation by any means. No one wants war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“An eye for an eye. We will retaliate with equal force to display our strength. Sordland can't afford to look weak.”"]** — Mówca: **Player**
> "“An eye for an eye. We will retaliate with equal force to display our strength. Sordland can't afford to look weak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Lucian's tensed-up shoulders relaxed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[110]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[112]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Valken smiled. He gave a strong salute and stomped his foot loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Valken Kruger**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[115]`
Mówca: **Deivid Wisci**
> "“Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Deivid Wisci**
> "“Do you realize the consequences of declaring a war? Please allow me to explain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[117]`
Mówca: **Iosef Lancea**
> "“Mr. President. Are you serious about this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[118]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[121]`
Mówca: **Iosef Lancea**
> "“With all respect, if we enter a war against Rumburg, we will not win with the current state of our military. I can assure you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[122]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[124]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Valken Kruger**
> "“If these are your orders, Mr. President, we will do everything we can to win -- and we *will* win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[126]`
Mówca: **Valken Kruger**
> "“Don't be a defeatist, Mr. Lancea. It's not befitting a man tasked with the defense of our nation nor a soldier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[127]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == false  and  Variable["BaseGame.Agnolia_Alliance"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == false  and  Variable["BaseGame.Agnolia_Alliance"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[130]`
Mówca: **Iosef Lancea**
> "“We don't even have any allies in the region to support us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> "“It's true that Rumburg currently doesn't have any allies, but they still have a considerable army.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“I will heed your advice. We won't go to war.”"]** — Mówca: **Player**
> "“I will heed your advice. We won't go to war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[133]`
Mówca: **Iosef Lancea**
> "“I am sure we will defeat them, but there will be casualties on our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == false  and  Variable["BaseGame.Agnolia_Alliance"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == false  and  Variable["BaseGame.Agnolia_Alliance"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Iosef Lancea**
> "“Especially since we don't have any allies in the region to support us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[138]`
Mówca: **Iosef Lancea**
> "“Thankfully we can call our allies which would aid us in the war effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
Mówca: **Iosef Lancea**
> "“Our only hope would be the help of our allies. What if they don't join the war or betray us?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[140]`
Mówca: **Valken Kruger**
> "“Trust the Sordish military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[141]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[143]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Valken Kruger**
> "“If these are your orders, Mr. President, I assure you we will teach them what it means to mess with Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Valken Kruger**
> "“In war, there are always casualties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[146]`
Mówca: **Valken Kruger**
> "“Trust the Sordish military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“Sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
> "“There are ways we can prevent a full-on war. If there is an alternative, we should take it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“In case of a war, the destabilization of the region and possibly the entire continent could put the survival of our Republic at risk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[132]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Enough. I will not say this again. Prepare for war.”"]** — Mówca: **Player**
> "“Enough. I will not say this again. Prepare for war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[151]`
Mówca: **Valken Kruger**
> "“I will start organising our troops and I will keep you updated on our progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Before he left the room, he turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Valken Kruger**
> "“You know, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Valken Kruger**
> "“I am now fully convinced that you are truly a great leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[155]`
  - -> `[159]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "“Did you have any doubts?”"]** — Mówca: **Player**
> "“Did you have any doubts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[156]`
**[WYBÓR GRACZA: "“Thank you, General Valken.”"]** — Mówca: **Player**
> "“Thank you, General Valken.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Valken Kruger**
> "“Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Narrator**
> "'Victory will come.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "“No need for flattery. Begin your work immediately.”"]** — Mówca: **Player**
> "“No need for flattery. Begin your work immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
Mówca: **Valken Kruger**
> "“No. Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[161]`
Mówca: **Valken Kruger**
> "“I don't now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[162]`
Mówca: **Valken Kruger**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[163]`
Mówca: **Narrator**
> "He saluted one more time and left. Iosef and Lucian were sitting down at the table, thinking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[164]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Iosef Lancea**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
Mówca: **Narrator**
> "Iosef seemed reluctant for a moment, but proceeded with his salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[169]`
Mówca: **Narrator**
> "Iosef smiled, gave a strong salute and stomped his foot loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[170]`
Mówca: **Iosef Lancea**
> "“I will start organising our troops and I will keep you updated on our progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Deivid Wisci**
> "“I am totally against this decision, Mr. President. We are pouring fuel to the fire and it can escalate beyond Merkopa even.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Iosef Lancea**
> "“A decision has been made. War it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
> "“Very well. Then we need to increase public support for the war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Narrator**
> "Lucian was lost in thoughts. He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[175]`
Mówca: **Iosef Lancea**
> "“I will schedule a military parade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
> "“I will do my part and commission war propaganda against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[178]`
  - -> `[177]`

### Węzeł `[177]`
**[WYBÓR GRACZA: "“If we are done here, I will go back to sleep.”"]** — Mówca: **Player**
> "“If we are done here, I will go back to sleep.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "“Don't worry. We will win. I know it.”"]** — Mówca: **Player**
> "“Don't worry. We will win. I know it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
**[WYBÓR GRACZA: "“Good work, both of you.”"]** — Mówca: **Player**
> "“Good work, both of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> "“Thank you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
> "“I hope you are right, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Narrator**
> "I couldn't sleep at all that night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[184]`
Mówca: **Iosef Lancea**
> "“Once everything is ready, we will need to announce the declaration of war. But, planning comes first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[185]`
Mówca: **Iosef Lancea**
> "“For now, have a good night's sleep, Mr. President. You will need it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
> "“Thank you. This is for the best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
> "“What should we do then, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“We will retaliate with equal force to display our strength.”"]** — Mówca: **Player**
> "“We will retaliate with equal force to display our strength.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
**[WYBÓR GRACZA: "“We will approach this diplomatically and try to de-escalate the situation.”"]** — Mówca: **Player**
> "“We will approach this diplomatically and try to de-escalate the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[190]`
Mówca: **Iosef Lancea**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[191]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[194]`
Mówca: **Iosef Lancea**
> "“We will be careful. It is risky but the fallout can be handled diplomatically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Iosef Lancea**
> "“Regardless, our retaliation is rightful and our cause is just.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Iosef Lancea**
> "“I will send word for the start of a military operation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Iosef Lancea**
> "“Our target will be their warplanes at an airbase near the border.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[198]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Valken Kruger**
> "“I will begin my task immediately, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Valken Kruger**
> "“If you will excuse me now, I must talk to the military command to relay the orders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Iosef Lancea**
> "“I will bring the paperwork.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Narrator**
> "Before he left the room, he saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[205]`
Mówca: **Narrator**
> "Iosef returned with the paperwork for the order and showed me where to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "Sign off on the operation."]** — Mówca: **Player_Italic**
> "I signed off on the operation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[207]`
Mówca: **Iosef Lancea**
> "“For now, have a good night's sleep.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Iosef Lancea**
> "“You will need it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[209]`
Mówca: **Iosef Lancea**
> "“That is all, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Iosef Lancea**
> "“I will keep you updated on the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[211]`
Mówca: **Iosef Lancea**
> "“Mr. President. I assure you, they wouldn't dare attack us for that. They know that we are far superior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Iosef Lancea**
> "“This will send a strong message.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[213]`
Mówca: **Lucian Galade**
> "“I still think a peaceful solution would be more beneficial, but of course I don't have the military experience and insight Mr. Lancea has.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[214]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[217]`
Mówca: **Lucian Galade**
> "“I still think a peaceful solution would be more beneficial, but it looks like this is the way we are going forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“Thank you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Deivid Wisci**
> "“I will immediately begin working on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[220]`
Mówca: **Lucian Galade**
> "“With Mr. Wisci's capabilities, I am sure that we will de-escalate the situation successfully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Lucian Galade**
> "“We will keep you updated on our progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[225]`
Mówca: **Iosef Lancea**
> "“This is our best bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[226]`
Mówca: **Iosef Lancea**
> "“We should've retaliated. I hope the diplomatic response makes sure that further incidents like this are prevented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Iosef Lancea**
> "“If there is a next time, I'm afraid that it will be war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[230]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Valken Kruger**
> "“We are showing weakness. Of course it will be a war the next time around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Valken Kruger**
> "“I am frankly disappointed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Valken Kruger**
> "“If we can't even retaliate after such an attack, what will become of this country in the future?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Deivid Wisci**
> "“Peace must be maintained at all costs. I am saying this as a man who has seen too many years of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[235]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[237]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[238]`
Mówca: **Valken Kruger**
> "“If you ask me, this is just plain old weakness we are showing them right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Valken Kruger**
> "“I am frankly disappointed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Valken Kruger**
> "“If we can't even retaliate at such an attack, what will become of this country in the future?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[241]`
Mówca: **Deivid Wisci**
> "“This should be our only bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[242]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_Diplomacy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgIncident_Diplomacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[243]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_Retaliation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgIncident_Retaliation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[244]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[245]`
Mówca: **Iosef Lancea**
> "“Now that the paperwork is done...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Iosef Lancea**
> "“I have an idea, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Iosef Lancea**
> "“I think we should hold a military parade to display our strength.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Deivid Wisci**
> "“I am with Mr. Lancea on this one. This should work well as a deterrent and it will come in handy as a tool to de-escalate the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Lucian Galade**
> "“That is a good idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Lucian Galade**
> "“Simple and effective without causing any ruckus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[251]`

### Węzeł `[251]`
**[WYBÓR GRACZA: "“No. We need to create a peaceful image for Sordland.”"]** — Mówca: **Player**
> "“No. We need to create a peaceful image for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[252]`
**[WYBÓR GRACZA: "“That makes sense. Organise the military parade.”"]** — Mówca: **Player**
> "“That makes sense. Organize the military parade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[253]`
Mówca: **Iosef Lancea**
> "“Understood.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[254]`
Mówca: **Iosef Lancea**
> "“Well. Now that we know the way forward...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[255]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_MilitaryParade = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgIncident_MilitaryParade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[256]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_MilitaryParade = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgIncident_MilitaryParade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[257]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_SnO_RumburgIncident = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_SnO_RumburgIncident"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[258]`
Mówca: **Valken Kruger**
> "“We are not the ones that are attacking the peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[259]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[261]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[262]`
Mówca: **Valken Kruger**
> "“Regardless, it looks like your decision has been made, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Valken Kruger**
> "“I know when I am not needed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Valken Kruger**
> "“I will take my leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Narrator**
> "Before he left the room, he saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[266]`
Mówca: **Iosef Lancea**
> "“I will discuss the details with the generals and Mr. Wisci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[267]`
Mówca: **Deivid Wisci**
> "“We must maintain peace in Sordland and Eastern Merkopa at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[268]`
Mówca: **Deivid Wisci**
> "“We must maintain peace in Sordland and Eastern Merkopa at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[269]`
Mówca: **Iosef Lancea**
> "“They are testing us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[270]`
Mówca: **Deivid Wisci**
> "“We must maintain peace in Sordland and Eastern Merkopa at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[271]`
Mówca: **Deivid Wisci**
> "“We must maintain peace in Sordland and Eastern Merkopa at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Iosef Lancea**
> "“What do you expect us to do? Sit around and do nothing?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[273]`
Mówca: **Lucian Galade**
> "“I agree. They are trying to lure us into their trap.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[274]`
Mówca: **Lucian Galade**
> "“I agree. They are trying to lure us into their trap.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[275]`
Mówca: **Lucian Galade**
> "“It looks like they are trying to lure us into their trap.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[276]`
Mówca: **Deivid Wisci**
> "“If there is to be a retaliation, we need to be extremely careful. They will seek every opportunity to blame us for it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Deivid Wisci**
> "“We need to prevent a war at all costs. I am saying this as a man who has lived through too many years of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[278]`
Mówca: **Deivid Wisci**
> "“We can't further escalate the situation and destabilize the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[279]`
Mówca: **Iosef Lancea**
> "“We are not the ones who escalated the situation. They were first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[280]`
Mówca: **Deivid Wisci**
> "“Rumburg will turn its back on us and blame us for the attack. Every single enemy of Sordland, and trust me there are many, will unite under that banner regardless of the truth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Deivid Wisci**
> "“If that happens and they manage to convince the world, we will be seen as the aggressors despite the fact that we are in the right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Deivid Wisci**
> "“This will have an effect on everything. Our relationships, trade, economy, status...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Deivid Wisci**
> "“All at the cost of one warplane, hundreds, thousands will die. Decades of diplomatic success will go down the drain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[284]`

### Węzeł `[284]`
**[WYBÓR GRACZA: "“You are right. Maybe we shouldn't be so hasty.”"]** — Mówca: **Player**
> "“You are right. Maybe we shouldn't be so hasty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
**[WYBÓR GRACZA: "“I have given an order and I will not change my stance.”"]** — Mówca: **Player**
> "“I have given an order and I will not change my stance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Deivid's tensed shoulders dropped and he relaxed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Deivid Wisci**
> "“I am glad.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
**[WYBÓR GRACZA: "“We will retaliate with equal force to display our strength.”"]** — Mówca: **Player**
> "“We will retaliate with equal force to display our strength.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[289]`
Mówca: **Lucian Galade**
> "“What should we do then, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[290]`

### Węzeł `[290]`
**[WYBÓR GRACZA: "“We will approach this diplomatically and try to de-escalate the situation.”"]** — Mówca: **Player**
> "“We will approach this diplomatically and try to de-escalate the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[291]`
Mówca: **Deivid Wisci**
> "“I can't believe after so many years, our country has to suffer once again...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Iosef Lancea**
> "“Victory is close, Mr. Wisci. Come with me please. We have much to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[293]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[295]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[296]`
Mówca: **Valken Kruger**
> "“I don't think the General Staff can accept this decision. We cannot show weakness against Rumburg. It is time to retaliate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[313]`

### Węzeł `[297]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[299]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[300]`
Mówca: **Iosef Lancea**
> "“We should retaliate. That was an act of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[301]`
Mówca: **Narrator**
> "Valken stood up and put his hands on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Valken Kruger**
> "“Hold on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[303]`
Mówca: **Narrator**
> "Iosef stood up and put his hands on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Iosef Lancea**
> "“No. This is wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[305]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[307]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Valken Kruger**
> "“I don't think the General Staff can accept this decision. We cannot show weakness against Rumburg. It is time to retaliate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[313]`

### Węzeł `[309]`
Mówca: **Narrator**
> "Valken also stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[310]`
Mówca: **Iosef Lancea**
> "“I don't think the Sordish Armed Forces can accept this decision. We cannot show weakness against Rumburg. It is time to retaliate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`
  - -> `[316]`

### Węzeł `[311]`
**[WYBÓR GRACZA: "“My decision is final.”"]** — Mówca: **Player**
> "“My decision is final.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[312]`
**[WYBÓR GRACZA: "“What is the meaning of this? You will accept this decision whether you like it or not.”"]** — Mówca: **Player**
> "“What is the meaning of this? You will accept this decision whether you like it or not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[313]`
**[WYBÓR GRACZA: "“Gentlemen. Let's not argue over this.”"]** — Mówca: **Player**
> "“Gentlemen. Let's not argue over this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[314]`
**[WYBÓR GRACZA: "“My decision is final.”"]** — Mówca: **Player**
> "“My decision is final.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[315]`
**[WYBÓR GRACZA: "“What is the meaning of this? You will accept this decision whether you like it or not.”"]** — Mówca: **Player**
> "“What is the meaning of this? You will accept this decision whether you like it or not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
**[WYBÓR GRACZA: "“Iosef. Let's not argue over this.”"]** — Mówca: **Player**
> "“Iosef. Let's not argue over this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Iosef Lancea**
> "“You don't understand. I urge you to reconsider your decision, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`
  - -> `[323]`

### Węzeł `[318]`
Mówca: **Valken Kruger**
> "“You cannot threaten the armed forces like that, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Valken Kruger**
> "“I seriously urge you to reconsider your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`
  - -> `[322]`

### Węzeł `[320]`
**[WYBÓR GRACZA: "“Enough. The decision has already been made.”"]** — Mówca: **Player**
> "“Enough. The decision has already been made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[321]`
**[WYBÓR GRACZA: "“You are pushing it. I don't appreciate not being taken seriously.”"]** — Mówca: **Player**
> "“You are pushing it. I don't appreciate not being taken seriously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[322]`
**[WYBÓR GRACZA: "“Or what?”"]** — Mówca: **Player**
> "“Or what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[323]`
**[WYBÓR GRACZA: "“Or what?”"]** — Mówca: **Player**
> "“Or what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[324]`
**[WYBÓR GRACZA: "“Enough. The decision has already been made.”"]** — Mówca: **Player**
> "“Enough. The decision has already been made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
**[WYBÓR GRACZA: "“You are pushing it. I don't appreciate not being taken seriously.”"]** — Mówca: **Player**
> "“You are pushing it. I don't appreciate not being taken seriously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Iosef Lancea**
> "“You made a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[327]`
Mówca: **Iosef Lancea**
> "“Me neither, Mr. President. You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
Mówca: **Iosef Lancea**
> "“I will just say this...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[329]`
Mówca: **Valken Kruger**
> "“I will just say this...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Valken Kruger**
> "“You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[331]`
Mówca: **Valken Kruger**
> "“Me neither, Mr. President. You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[332]`
Mówca: **Narrator**
> "He clenched his fist and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Narrator**
> "I'd never seen him look at me so angrily before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[334]`
Mówca: **Narrator**
> "He clenched his fist and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Narrator**
> "I'd never seen him look at me this angrily before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[336]`
Mówca: **Deivid Wisci**
> "“Gentlemen. Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[337]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true && BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true && BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true && BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[340]`
Mówca: **Narrator**
> "Iosef stood up and put his hands on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Iosef Lancea**
> "“We are in no shape to fight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
Mówca: **Iosef Lancea**
> "“No. This is wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[343]`
**[WYBÓR GRACZA: "“Iosef. Let's not argue over this.”"]** — Mówca: **Player**
> "“Iosef. Let's not argue over this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[344]`
Mówca: **Iosef Lancea**
> "“I don't think the Armed Forces can accept this decision. I cannot let you throw us under the bus just like that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[345]`
  - -> `[343]`
  - -> `[356]`

### Węzeł `[345]`
**[WYBÓR GRACZA: "“What is the meaning of this? You will accept this decision whether you like it or not.”"]** — Mówca: **Player**
> "“What is the meaning of this? You will accept this decision whether you like it or not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[346]`
**[WYBÓR GRACZA: "“Or what?”"]** — Mówca: **Player**
> "“Or what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[347]`
**[WYBÓR GRACZA: "“You are pushing it. I don't appreciate not being taken seriously.”"]** — Mówca: **Player**
> "“You are pushing it. I don't appreciate not being taken seriously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[348]`
Mówca: **Iosef Lancea**
> "“You don't seem to understand. I urge you to reconsider your decision, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[347]`
  - -> `[346]`

### Węzeł `[349]`
Mówca: **Iosef Lancea**
> "“I will just say this...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[350]`
Mówca: **Narrator**
> "I'd never seen him look at me this angrily before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[351]`
**[WYBÓR GRACZA: "“My decision is final.”"]** — Mówca: **Player**
> "“My decision is final.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[352]`
Mówca: **Narrator**
> "He clenched his fist and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[353]`
**[WYBÓR GRACZA: "“Enough. The decision has already been made.”"]** — Mówca: **Player**
> "“Enough. The decision has already been made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Iosef Lancea**
> "“You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[355]`
Mówca: **Iosef Lancea**
> "“Me neither, Mr. President... You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[356]`
**[WYBÓR GRACZA: "“I thought you were a military man. A man of war.”"]** — Mówca: **Player**
> "“I thought you were a military man. A man of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Iosef Lancea**
> "“I am. I know when and how wars are lost or won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[358]`
Mówca: **Narrator**
> "The dimly lit room was filled with cutting-edge equipment -- the latest video screens, long-range radio electronics and other devices used for communication, presentation and planning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Narrator**
> "The centerpiece of the room was a large round table with the coat of arms of Sordland engraved on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SnO_WarRoom_Described = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_SnO_WarRoom_Described"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[361]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[362]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Valken_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Valken_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[363]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[364]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[365]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[366]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[367]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: GameCondition.Turn10_Personal_SergeFuneral = true;)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn10_Personal_SergeFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[368]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_RumburgIncident_Diplomacy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_Diplomacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[369]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_RumburgIncident_Retaliation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_Retaliation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[370]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_RumburgIncident_DeclareWar = true; BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_DeclareWar"] = true;
Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[371]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[372]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[374]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[375]`
Mówca: **Narrator**
> "Valken smiled. He gave a strong salute and stomped his foot loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[376]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[379]`
**[WYBÓR GRACZA: "Sign off on the operation."]** — Mówca: **Player_Italic**
> "I signed off on the operation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[380]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[382]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Narrator**
> "I put on my clothes as fast as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[387]`
Mówca: **Narrator**
> "I put on my clothes as fast as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[388]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_RumburgKnows = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgIncident_RumburgKnows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[389]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaStays == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaStays == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[391]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaStays == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[392]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_HP_SordishPlaneShot = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_SordishPlaneShot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[393]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[394]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  (Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[396]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  (Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[397]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseGame.Bill_Turn09_LighterSecurity_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseGame.Bill_Turn09_LighterSecurity_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Deal_Promised"] == true  and  Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[399]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseGame.Bill_Turn09_LighterSecurity_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Deal_Promised"] == true  and  Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[400]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhoneRingPickUp");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[401]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[402]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[403]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn09_Wehlen_RaisesRumburgWorries = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn09_Wehlen_RaisesRumburgWorries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[404]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatusAllCities("City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatusAllCities("City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
