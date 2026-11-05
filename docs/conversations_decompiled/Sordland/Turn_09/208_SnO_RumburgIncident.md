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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“We have much to lose against what exactly?”"** | `[39]` **Iosef Lancea**: "“I agree. We have much to lose.”"<br>`[48]` **Valken Kruger**: "“Have some faith in our soldiers.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Iosef Lancea**: "“Mr. President. Thank you for co..."<br>`[51]` **Iosef Lancea**: "“Mr. President. Thank you for co..." |
| `[14]` | **"“What is going on here?”"** | `[39]` **Iosef Lancea**: "“I agree. We have much to lose.”"<br>`[40]` **Iosef Lancea**: "“We must respond immediately. Ot..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Iosef Lancea**: "“Mr. President. Thank you for co..."<br>`[51]` **Iosef Lancea**: "“Mr. President. Thank you for co..." |
| `[15]` | **"“Status report. Now!”"** | `[39]` **Iosef Lancea**: "“I agree. We have much to lose.”"<br>`[40]` **Iosef Lancea**: "“We must respond immediately. Ot..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Iosef Lancea**: "“Mr. President. Thank you for co..."<br>`[51]` **Iosef Lancea**: "“Mr. President. Thank you for co..." |
| `[19]` | **"“This is terrible. What should we do?”"** | `[28]` **Valken Kruger**: "“We have calculated the trajecto..."<br>`[63]` **Iosef Lancea**: "“We have calculated the trajecto..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Deivid Wisci**: "“We need to open diplomatic chan..." |
| `[20]` | **"“How dare they? This is an attack against our sovereignty!”"** | `[28]` **Valken Kruger**: "“We have calculated the trajecto..."<br>`[63]` **Iosef Lancea**: "“We have calculated the trajecto..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Deivid Wisci**: "“Mr. President. I must insist. W..." |
| `[21]` | **"“We need to be cautious. A war with Rumburg is the last thing we want right now.”"** | `[28]` **Valken Kruger**: "“We have calculated the trajecto..."<br>`[63]` **Iosef Lancea**: "“We have calculated the trajecto..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Deivid Wisci**: "“I completely agree.”" |
| `[50]` | **"“We must respond immediately to what exactly?”"** | `[40]` **Iosef Lancea**: "“We must respond immediately. Ot..."<br>`[49]` **Valken Kruger**: "“We must respond immediately. Ot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Iosef Lancea**: "“Mr. President. Thank you for co..."<br>`[51]` **Iosef Lancea**: "“Mr. President. Thank you for co..." |
| `[106]` | **"“Start the Sordish war machine and prepare to invade Rumburg! They will pay for th..."** | `[105]` **Iosef Lancea**: "“Mr. President. What are your or..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame....` | `[115]` **Deivid Wisci**: "“Mr. President...”" |
| `[107]` | **"“We will approach this diplomatically and try to de-escalate the situation by any ..."** | `[105]` **Iosef Lancea**: "“Mr. President. What are your or..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame....` | `[109]` **Narrator**: "Lucian's tensed-up shoulders rel..." |
| `[108]` | **"“An eye for an eye. We will retaliate with equal force to display our strength. So..."** | `[105]` **Iosef Lancea**: "“Mr. President. What are your or..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame....` | `[190]` **Iosef Lancea**: "“Very well.”" |
| `[132]` | **"“I will heed your advice. We won't go to war.”"** | `[149]` **Lucian Galade**: "“In case of a war, the destabili..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Lucian Galade**: "“Thank you. This is for the best.”" |
| `[150]` | **"“Enough. I will not say this again. Prepare for war.”"** | `[149]` **Lucian Galade**: "“In case of a war, the destabili..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.RumburgIncident_DeclareWar"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_...`<br>*(+1 skryptów)* | `[340]` **Narrator**: "Iosef stood up and put his hands..." |
| `[155]` | **"“Did you have any doubts?”"** | `[154]` **Valken Kruger**: "“I am now fully convinced that y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Valken Kruger**: "“I don't now.”" |
| `[156]` | **"“Thank you, General Valken.”"** | `[154]` **Valken Kruger**: "“I am now fully convinced that y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Valken Kruger**: "“No. Thank you, Mr. President.”" |
| `[159]` | **"“No need for flattery. Begin your work immediately.”"** | `[154]` **Valken Kruger**: "“I am now fully convinced that y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Valken Kruger**: "“As you command.”" |
| `[177]` | **"“If we are done here, I will go back to sleep.”"** | `[176]` **Lucian Galade**: "“I will do my part and commissio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Lucian Galade**: "“Very well, sir.”" |
| `[178]` | **"“Don't worry. We will win. I know it.”"** | `[176]` **Lucian Galade**: "“I will do my part and commissio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Lucian Galade**: "“I hope you are right, sir.”" |
| `[179]` | **"“Good work, both of you.”"** | `[176]` **Lucian Galade**: "“I will do my part and commissio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Lucian Galade**: "“Thank you, sir.”" |
| `[188]` | **"“We will retaliate with equal force to display our strength.”"** | `[187]` **Lucian Galade**: "“What should we do then, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Iosef Lancea**: "“Very well.”" |
| `[189]` | **"“We will approach this diplomatically and try to de-escalate the situation.”"** | `[187]` **Lucian Galade**: "“What should we do then, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Deivid Wisci**: "“I will immediately begin workin..." |
| `[206]` | **"Sign off on the operation."** | `[205]` **Narrator**: "Iosef returned with the paperwor..." | `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false` | `Variable["BaseGame.RumburgIncident_Retaliation"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_...` | `[245]` **Iosef Lancea**: "“Now that the paperwork is done...”" |
| `[251]` | **"“No. We need to create a peaceful image for Sordland.”"** | `[250]` **Lucian Galade**: "“Simple and effective without ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn10_Personal_SergeFuneral"] = ...` | `[253]` **Iosef Lancea**: "“Understood.”" |
| `[252]` | **"“That makes sense. Organise the military parade.”"** | `[250]` **Lucian Galade**: "“Simple and effective without ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.RumburgIncident_MilitaryParade"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_...` | `[253]` **Iosef Lancea**: "“Understood.”" |
| `[284]` | **"“You are right. Maybe we shouldn't be so hasty.”"** | `[283]` **Deivid Wisci**: "“All at the cost of one warplane..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Narrator**: "Deivid's tensed shoulders droppe..." |
| `[285]` | **"“I have given an order and I will not change my stance.”"** | `[283]` **Deivid Wisci**: "“All at the cost of one warplane..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Iosef Lancea**: "“Mr. President. Are you serious ..." |
| `[288]` | **"“We will retaliate with equal force to display our strength.”"** | `[289]` **Lucian Galade**: "“What should we do then, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Iosef Lancea**: "“Very well.”" |
| `[290]` | **"“We will approach this diplomatically and try to de-escalate the situation.”"** | `[289]` **Lucian Galade**: "“What should we do then, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Deivid Wisci**: "“I will immediately begin workin..." |
| `[311]` | **"“My decision is final.”"** | `[296]` **Valken Kruger**: "“I don't think the General Staff..."<br>`[308]` **Valken Kruger**: "“I don't think the General Staff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Valken Kruger**: "“I seriously urge you to reconsi..." |
| `[312]` | **"“What is the meaning of this? You will accept this decision whether you like it or..."** | `[296]` **Valken Kruger**: "“I don't think the General Staff..."<br>`[308]` **Valken Kruger**: "“I don't think the General Staff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Valken Kruger**: "“You cannot threaten the armed f..." |
| `[313]` | **"“Gentlemen. Let's not argue over this.”"** | `[296]` **Valken Kruger**: "“I don't think the General Staff..."<br>`[308]` **Valken Kruger**: "“I don't think the General Staff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Valken Kruger**: "“I seriously urge you to reconsi..." |
| `[314]` | **"“My decision is final.”"** | `[310]` **Iosef Lancea**: "“I don't think the Sordish Armed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Iosef Lancea**: "“You don't understand. I urge yo..." |
| `[315]` | **"“What is the meaning of this? You will accept this decision whether you like it or..."** | `[310]` **Iosef Lancea**: "“I don't think the Sordish Armed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Iosef Lancea**: "“You don't understand. I urge yo..." |
| `[316]` | **"“Iosef. Let's not argue over this.”"** | `[310]` **Iosef Lancea**: "“I don't think the Sordish Armed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Iosef Lancea**: "“You don't understand. I urge yo..." |
| `[320]` | **"“Enough. The decision has already been made.”"** | `[319]` **Valken Kruger**: "“I seriously urge you to reconsi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Valken Kruger**: "“You are making a grave mistake.”" |
| `[321]` | **"“You are pushing it. I don't appreciate not being taken seriously.”"** | `[319]` **Valken Kruger**: "“I seriously urge you to reconsi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Valken Kruger**: "“Me neither, Mr. President. You ..." |
| `[322]` | **"“Or what?”"** | `[319]` **Valken Kruger**: "“I seriously urge you to reconsi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Valken Kruger**: "“I will just say this...”" |
| `[323]` | **"“Or what?”"** | `[317]` **Iosef Lancea**: "“You don't understand. I urge yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Iosef Lancea**: "“I will just say this...”" |
| `[324]` | **"“Enough. The decision has already been made.”"** | `[317]` **Iosef Lancea**: "“You don't understand. I urge yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Iosef Lancea**: "“You made a grave mistake.”" |
| `[325]` | **"“You are pushing it. I don't appreciate not being taken seriously.”"** | `[317]` **Iosef Lancea**: "“You don't understand. I urge yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[327]` **Iosef Lancea**: "“Me neither, Mr. President. You ..." |
| `[343]` | **"“Iosef. Let's not argue over this.”"** | `[344]` **Iosef Lancea**: "“I don't think the Armed Forces ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Iosef Lancea**: "“You don't seem to understand. I..." |
| `[345]` | **"“What is the meaning of this? You will accept this decision whether you like it or..."** | `[344]` **Iosef Lancea**: "“I don't think the Armed Forces ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Iosef Lancea**: "“You don't seem to understand. I..." |
| `[346]` | **"“Or what?”"** | `[348]` **Iosef Lancea**: "“You don't seem to understand. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Iosef Lancea**: "“I will just say this...”" |
| `[347]` | **"“You are pushing it. I don't appreciate not being taken seriously.”"** | `[348]` **Iosef Lancea**: "“You don't seem to understand. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Iosef Lancea**: "“Me neither, Mr. President... Yo..." |
| `[351]` | **"“My decision is final.”"** | `[344]` **Iosef Lancea**: "“I don't think the Armed Forces ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Iosef Lancea**: "“You don't seem to understand. I..." |
| `[353]` | **"“Enough. The decision has already been made.”"** | `[348]` **Iosef Lancea**: "“You don't seem to understand. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Iosef Lancea**: "“You are making a grave mistake.”" |
| `[356]` | **"“I thought you were a military man. A man of war.”"** | `[344]` **Iosef Lancea**: "“I don't think the Armed Forces ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Iosef Lancea**: "“I am. I know when and how wars ..." |
| `[379]` | **"Sign off on the operation."** | `[205]` **Narrator**: "Iosef returned with the paperwor..." | `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true` | `Variable["BaseGame.RumburgIncident_Retaliation"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_...` | `[245]` **Iosef Lancea**: "“Now that the paperwork is done...”" |

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
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseGam..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Iosef Lancea**
> "“What do you expect us to do? Sit around and do nothing?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Iosef Lancea: "“They are testing us.”"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I was woken up in the middle of the night by a call from the Ministry of Defense. Due to the sensitivity of the information, I had to be urgently briefed in person."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == tru..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“We have much to lose against what exactly?”"]** — Mówca: **Player**
> "“We have much to lose against what exactly?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Iosef Lancea), `[48]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I put on my clothes as fast as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I rushed downstairs and opened the door. Serge was waitin..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I rushed downstairs and opened the door. Serge was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Serge Wolkner: "“Mr. President. This way to the car, please.”"*)

### Węzeł `[8]`
Mówca: **Serge Wolkner**
> "“Mr. President. This way to the car, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "We got into the car and made our way to the Ministry of D..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "We got into the car and made our way to the Ministry of Defense building without a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "I arrived and was directed downstairs. I came to a set of..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I arrived and was directed downstairs. I came to a set of large doors and quickly read the sign above them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The sign read 'War Room'."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "The sign read 'War Room'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "The dimly lit room was filled with cutting-edge equipment..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Deivid, Lucian and Iosef were already deep in discussion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“Mr. Lancea. I advise caution. Going to war wouldn't help anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Deivid Wisci: "“We must maintain peace in Sordland and Eastern Merkopa a..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“What is going on here?”"]** — Mówca: **Player**
> "“What is going on here?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Iosef Lancea), `[40]` (Iosef Lancea), `[48]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Status report. Now!”"]** — Mówca: **Player**
> "“Status report. Now!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Iosef Lancea), `[40]` (Iosef Lancea), `[48]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[16]`
Mówca: **Valken Kruger**
> "“Mr. President. Approximately 20 minutes ago, Rumburg downed one of our planes with anti-aircraft fire from the ground. The pilot was declared KIA.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Valken Kruger: "“The last recorded position of the plane was inside Sordi..."*)

### Węzeł `[17]`
Mówca: **Valken Kruger**
> "“We can't look weak. If we appear weak, they will jump on the opportunity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Valken Kruger: "“We must order a military retaliation. Immediately.”"*)

### Węzeł `[18]`
Mówca: **Valken Kruger**
> "“The last recorded position of the plane was inside Sordish air space.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“General Kruger. I mean no offense but are we absolutely ..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“This is terrible. What should we do?”"]** — Mówca: **Player**
> "“This is terrible. What should we do?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Valken Kruger), `[63]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Deivid Wisci: "“We need to open diplomatic channels to start an official..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“How dare they? This is an attack against our sovereignty!”"]** — Mówca: **Player**
> "“How dare they? This is an attack against our sovereignty!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Valken Kruger), `[63]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Deivid Wisci: "“Mr. President. I must insist. We need to be calm. We mus..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“We need to be cautious. A war with Rumburg is the last thing we want right now.”"]** — Mówca: **Player**
> "“We need to be cautious. A war with Rumburg is the last thing we want right now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Valken Kruger), `[63]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Deivid Wisci: "“I completely agree.”"*)

### Węzeł `[22]`
Mówca: **Deivid Wisci**
> "“I completely agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“It looks like they are trying to lure us into their trap.”"*)

### Węzeł `[23]`
Mówca: **Deivid Wisci**
> "“Mr. President. I must insist. We need to be calm. We must maintain peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Lucian Galade: "“I agree. They are trying to lure us into their trap.”"*)

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“We need to open diplomatic channels to start an official investigation. Most importantly, we need to remain calm. We must maintain peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Lucian Galade: "“I agree. They are trying to lure us into their trap.”"*)

### Węzeł `[25]`
Mówca: **Valken Kruger**
> "“We must order a military retaliation. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“General Kruger. I mean no offense but are we absolutely sure that is the case? Are you sure this happened within our borders?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Valken Kruger: "“No offense taken. Here are the locations on the map and ..."*)

### Węzeł `[27]`
Mówca: **Valken Kruger**
> "“No offense taken. Here are the locations on the map and the report from the air base.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "He pointed to several markers on the map."*)

### Węzeł `[28]`
Mówca: **Valken Kruger**
> "“We have calculated the trajectory of the gunfire and they started firing when our plane was within our border. The plane was downed near Halgen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“This is terrible. What should we do?”"*)
  - -> `[20]` (*Player: "“How dare they? This is an attack against our sovereignty!”"*)
  - -> `[21]` (*Player: "“We need to be cautious. A war with Rumburg is the last t..."*)

### Węzeł `[29]`
Mówca: **Valken Kruger**
> "“To answer your question, yes. We are absolutely sure. You can see here on the map that the plane was downed approximately 10 kilometers inside our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Valken Kruger: "“We have calculated the trajectory of the gunfire and the..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "He pointed to several markers on the map."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Valken Kruger: "“To answer your question, yes. We are absolutely sure. Yo..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Deivid, Lucian and Iosef were already deep in discussion."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Deivid, Lucian, Valken and Iosef were already deep in dis..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Deivid, Lucian, Valken and Iosef were already deep in discussion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: "“I agree with your sentiments, Mr. Lancea. Going to war i..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“Mr. Lancea. I advise caution. Going to war wouldn't help..."*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> "“I agree with your sentiments, Mr. Lancea. Going to war is simply too risky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Deivid Wisci: "“We must maintain peace in Sordland and Eastern Merkopa a..."*)

### Węzeł `[39]`
Mówca: **Iosef Lancea**
> "“I agree. We have much to lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: "“We have much to lose against what exactly?”"*)
  - -> `[14]` (*Player: "“What is going on here?”"*)
  - -> `[15]` (*Player: "“Status report. Now!”"*)

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> "“We must respond immediately. Otherwise, they will think we are weak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“We must respond immediately to what exactly?”"*)
  - -> `[14]` (*Player: "“What is going on here?”"*)
  - -> `[15]` (*Player: "“Status report. Now!”"*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“I agree with your sentiments, Mr. Lancea. Going to war is simply too risky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Deivid Wisci: "“We must maintain peace in Sordland and Eastern Merkopa a..."*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“Mr. Lancea. I advise caution. Going to war wouldn't help anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Deivid Wisci: "“We must maintain peace in Sordland and Eastern Merkopa a..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“I agree with your sentiments, Mr. Lancea. Going to war i..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: "“Mr. Lancea. I advise caution. Going to war wouldn't help..."*)

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“They are testing us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Valken Kruger: "“We must respond immediately. Otherwise, they will think ..."*)

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“I agree. We have much to lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Valken Kruger: "“Have some faith in our soldiers.”"*)

### Węzeł `[48]`
Mówca: **Valken Kruger**
> "“Have some faith in our soldiers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: "“We have much to lose against what exactly?”"*)
  - -> `[14]` (*Player: "“What is going on here?”"*)
  - -> `[15]` (*Player: "“Status report. Now!”"*)

### Węzeł `[49]`
Mówca: **Valken Kruger**
> "“We must respond immediately. Otherwise, they will think we are weak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“We must respond immediately to what exactly?”"*)
  - -> `[14]` (*Player: "“What is going on here?”"*)
  - -> `[15]` (*Player: "“Status report. Now!”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“We must respond immediately to what exactly?”"]** — Mówca: **Player**
> "“We must respond immediately to what exactly?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Iosef Lancea), `[49]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[51]`
Mówca: **Iosef Lancea**
> "“Mr. President. Thank you for coming in at this late hour. There is a situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Iosef Lancea: "“Valken, please go ahead and provide your report.”"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Iosef Lancea: "“Mr. President. Thank you for coming in at this late hour..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Iosef Lancea: "“Mr. President. Thank you for coming in at this late hour..."*)

### Węzeł `[55]`
Mówca: **Iosef Lancea**
> "“Mr. President. Thank you for coming in at this late hour. There is a situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Iosef Lancea: "“Approximately 20 minutes ago, Rumburg downed one of our ..."*)

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“Valken, please go ahead and provide your report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Valken Kruger: "“Mr. President. Approximately 20 minutes ago, Rumburg dow..."*)

### Węzeł `[57]`
Mówca: **Iosef Lancea**
> "“Approximately 20 minutes ago, Rumburg downed one of our warplanes with anti-aircraft fire from the ground. The pilot was declared KIA.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Iosef Lancea: "“The last recorded position of the plane was inside Sordi..."*)

### Węzeł `[58]`
Mówca: **Iosef Lancea**
> "“The last recorded position of the plane was inside Sordish airspace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Deivid Wisci: "“Are we absolutely sure that is the case? Are you sure th..."*)

### Węzeł `[59]`
Mówca: **Deivid Wisci**
> "“Are we absolutely sure that is the case? Are you sure this happened within our borders?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Iosef Lancea: "“Here are the locations on the map and the report from th..."*)

### Węzeł `[60]`
Mówca: **Iosef Lancea**
> "“Here are the locations on the map and the report from the air base.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "He pointed to several markers on the map."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "He pointed to several markers on the map."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Iosef Lancea: "“To answer your question, yes. We are absolutely sure. Yo..."*)

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“To answer your question, yes. We are absolutely sure. You can see here on the map that the plane was downed approximately 10 kilometers inside our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Iosef Lancea: "“We have calculated the trajectory of the gunfire and fou..."*)

### Węzeł `[63]`
Mówca: **Iosef Lancea**
> "“We have calculated the trajectory of the gunfire and found out that they started firing when our plane was within our border. The plane was downed near Halgen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“This is terrible. What should we do?”"*)
  - -> `[20]` (*Player: "“How dare they? This is an attack against our sovereignty!”"*)
  - -> `[21]` (*Player: "“We need to be cautious. A war with Rumburg is the last t..."*)

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“Under different circumstances I would say we should strike back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“But, the current status of our military is apparent. We ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Iosef Lancea: "“Under different circumstances I would say we should stri..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Iosef Lancea: "“We have enough military power to contest against this vi..."*)

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“But, the current status of our military is apparent. We are not adequately equipped for such a foe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Iosef Lancea: "“I agree with Mr. Galade. We need to utilize diplomacy.”"*)

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“I agree with Mr. Galade. We need to utilize diplomacy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[70]`
Mówca: **Iosef Lancea**
> "“We have enough military power to contest against this violation of international law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Iosef Lancea: "“An eye for an eye! That's what we need to do.”"*)

### Węzeł `[71]`
Mówca: **Iosef Lancea**
> "“We should attack and down one of their planes in retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[72]`
Mówca: **Iosef Lancea**
> "“It is true that this is an attack against Sordland and under different circumstances, the response to that would be clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Iosef Lancea: "“But, the current status of our military is also clear. W..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Iosef Lancea: "“It is true that this is an attack against Sordland and u..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Iosef Lancea: "“We have enough military power to contest against this vi..."*)

### Węzeł `[76]`
Mówca: **Iosef Lancea**
> "“But, the current status of our military is also clear. We are not adequately equipped for such a foe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Iosef Lancea: "“I agree with Mr. Galade. We need to utilize diplomacy.”"*)

### Węzeł `[77]`
Mówca: **Iosef Lancea**
> "“I agree with Mr. Galade. We need to utilize diplomacy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[78]`
Mówca: **Iosef Lancea**
> "“An eye for an eye! That's what we need to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Iosef Lancea: "“We should attack and down one of their planes in retalia..."*)

### Węzeł `[79]`
Mówca: **Iosef Lancea**
> "“Otherwise, we will look weak and it will lead to more casualties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[80]`
Mówca: **Iosef Lancea**
> "“We should attack and down one of their planes in retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Iosef Lancea: "“Otherwise, we will look weak and it will lead to more ca..."*)

### Węzeł `[81]`
Mówca: **Iosef Lancea**
> "“We have enough military power to contest against this violation of international law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Iosef Lancea: "“We should attack and down one of their planes in retalia..."*)

### Węzeł `[82]`
Mówca: **Iosef Lancea**
> "“We have enough military power to contest against this violation of international law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Iosef Lancea: "“We should attack and down one of their planes in retalia..."*)

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“This is an attack against Sordland and under different circumstances, the response to that is clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Iosef Lancea: "“But, the current status of our military is also clear. W..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Iosef Lancea: "“This is an attack against Sordland and under different c..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Iosef Lancea: "“We have enough military power to contest against this vi..."*)

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“But, the current status of our military is also clear. We are not adequately equipped for such a foe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Iosef Lancea: "“I agree with Mr. President.”"*)

### Węzeł `[88]`
Mówca: **Iosef Lancea**
> "“I agree with Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[89]`
Mówca: **Iosef Lancea**
> "“We should attack and down one of their planes in retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Iosef Lancea: "“Otherwise, we will look weak and it will lead to more ca..."*)

### Węzeł `[90]`
Mówca: **Iosef Lancea**
> "“Otherwise, we will look weak and it will lead to more casualties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The room fell silent before Iosef finally spoke up."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Valken Kruger: "“We can't look weak. If we appear weak, they will jump on..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Iosef Lancea: "“Did you start losing your common sense, General Valken?”"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Iosef Lancea: "“I agree with the General.”"*)

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“Did you start losing your common sense, General Valken?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Iosef Lancea: "“You know the state our army is in right now.”"*)

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“You know the state our army is in right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Iosef Lancea: "“A retaliation is too risky.”"*)

### Węzeł `[99]`
Mówca: **Iosef Lancea**
> "“A retaliation is too risky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Valken Kruger: "“When was our job not risky, *Mr.* Lancea?”"*)

### Węzeł `[100]`
Mówca: **Iosef Lancea**
> "“I agree with the General.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Valken Kruger: "“Mr. President. Our army is ready to do whatever it takes..."*)

### Węzeł `[101]`
Mówca: **Valken Kruger**
> "“When was our job not risky, *Mr.* Lancea?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Valken Kruger: "“Mr. President. Our army is ready to do whatever it takes..."*)

### Węzeł `[102]`
Mówca: **Valken Kruger**
> "“Mr. President. Our army is ready to do whatever it takes to protect Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Deivid Wisci: "“Gentlemen. Before it comes to that point, we can prevent..."*)

### Węzeł `[103]`
Mówca: **Deivid Wisci**
> "“Gentlemen. Before it comes to that point, we can prevent further bloodshed by using diplomacy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The room fell silent before Iosef finally spoke up."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "The room fell silent before Iosef finally spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Iosef Lancea: "“Mr. President. What are your orders?”"*)

### Węzeł `[105]`
Mówca: **Iosef Lancea**
> "“Mr. President. What are your orders?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: "“Start the Sordish war machine and prepare to invade Rumb..."*)
  - -> `[108]` (*Player: "“An eye for an eye. We will retaliate with equal force to..."*)
  - -> `[107]` (*Player: "“We will approach this diplomatically and try to de-escal..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Start the Sordish war machine and prepare to invade Rumburg! They will pay for their crimes.”"]** — Mówca: **Player**
> "“Start the Sordish war machine and prepare to invade Rumburg! They will pay for their crimes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 2;"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“We will approach this diplomatically and try to de-escalate the situation by any means. No one wants war.”"]** — Mówca: **Player**
> "“We will approach this diplomatically and try to de-escalate the situation by any means. No one wants war.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3;"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“An eye for an eye. We will retaliate with equal force to display our strength. Sordland can't afford to look weak.”"]** — Mówca: **Player**
> "“An eye for an eye. We will retaliate with equal force to display our strength. Sordland can't afford to look weak.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Lucian's tensed-up shoulders relaxed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucian Galade: "“Thank you, sir.”"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Valken smiled. He gave a strong salute and stomped his foot loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Valken Kruger: "“As you command, Mr. President.”"*)

### Węzeł `[114]`
Mówca: **Valken Kruger**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Valken Kruger: "“I will start organising our troops and I will keep you u..."*)

### Węzeł `[115]`
Mówca: **Deivid Wisci**
> "“Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Deivid Wisci: "“Do you realize the consequences of declaring a war? Plea..."*)

### Węzeł `[116]`
Mówca: **Deivid Wisci**
> "“Do you realize the consequences of declaring a war? Please allow me to explain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Deivid Wisci: "“Rumburg will turn its back on us and blame us for the at..."*)

### Węzeł `[117]`
Mówca: **Iosef Lancea**
> "“Mr. President. Are you serious about this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Iosef Lancea: "“It's true that Rumburg currently doesn't have any allies..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Iosef Lancea: "“With all respect, if we enter a war against Rumburg, we ..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Iosef Lancea: "“I am sure we will defeat them, but there will be casualt..."*)

### Węzeł `[121]`
Mówca: **Iosef Lancea**
> "“With all respect, if we enter a war against Rumburg, we will not win with the current state of our military. I can assure you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_All..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Sir.”"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Valken Kruger: "“Don't be a defeatist, Mr. Lancea. It's not befitting a m..."*)

### Węzeł `[125]`
Mówca: **Valken Kruger**
> "“If these are your orders, Mr. President, we will do everything we can to win -- and we *will* win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Valken Kruger: "“Trust the Sordish military.”"*)

### Węzeł `[126]`
Mówca: **Valken Kruger**
> "“Don't be a defeatist, Mr. Lancea. It's not befitting a man tasked with the defense of our nation nor a soldier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Valken Kruger: "“If these are your orders, Mr. President, we will do ever..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_All..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_A..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == false  and  Variable["BaseGame.Agnolia_Alliance"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Iosef Lancea: "“We don't even have any allies in the region to support us.”"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == false  and  Variable["BaseGame.Agnolia_Alliance"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Iosef Lancea: "“Our only hope would be the help of our allies. What if t..."*)

### Węzeł `[130]`
Mówca: **Iosef Lancea**
> "“We don't even have any allies in the region to support us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> "“It's true that Rumburg currently doesn't have any allies, but they still have a considerable army.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“I will heed your advice. We won't go to war.”"]** — Mówca: **Player**
> "“I will heed your advice. We won't go to war.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucian Galade: "“Thank you. This is for the best.”"*)

### Węzeł `[133]`
Mówca: **Iosef Lancea**
> "“I am sure we will defeat them, but there will be casualties on our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_All..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_All..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_A..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == false  and  Variable["BaseGame.Agnolia_Alliance"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Iosef Lancea: "“Especially since we don't have any allies in the region ..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == false && BaseGame.Agnolia_Alliance == false && BaseGame.Valgsland_Alliance == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == false  and  Variable["BaseGame.Agnolia_Alliance"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Iosef Lancea: "“Thankfully we can call our allies which would aid us in ..."*)

### Węzeł `[137]`
Mówca: **Iosef Lancea**
> "“Especially since we don't have any allies in the region to support us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[138]`
Mówca: **Iosef Lancea**
> "“Thankfully we can call our allies which would aid us in the war effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[139]`
Mówca: **Iosef Lancea**
> "“Our only hope would be the help of our allies. What if they don't join the war or betray us?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[140]`
Mówca: **Valken Kruger**
> "“Trust the Sordish military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Sir.”"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Sir.”"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Valken Kruger: "“In war, there are always casualties.”"*)

### Węzeł `[144]`
Mówca: **Valken Kruger**
> "“If these are your orders, Mr. President, I assure you we will teach them what it means to mess with Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Valken Kruger: "“Trust the Sordish military.”"*)

### Węzeł `[145]`
Mówca: **Valken Kruger**
> "“In war, there are always casualties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Valken Kruger: "“If these are your orders, Mr. President, I assure you we..."*)

### Węzeł `[146]`
Mówca: **Valken Kruger**
> "“Trust the Sordish military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Sir.”"*)

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“Sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucian Galade: "“There are ways we can prevent a full-on war. If there is..."*)

### Węzeł `[148]`
Mówca: **Lucian Galade**
> "“There are ways we can prevent a full-on war. If there is an alternative, we should take it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“In case of a war, the destabilization of the region and ..."*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“In case of a war, the destabilization of the region and possibly the entire continent could put the survival of our Republic at risk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“Enough. I will not say this again. Prepare for war.”"*)
  - -> `[132]` (*Player: "“I will heed your advice. We won't go to war.”"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Enough. I will not say this again. Prepare for war.”"]** — Mówca: **Player**
> "“Enough. I will not say this again. Prepare for war.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true && BaseGame.Ref..."*)

### Węzeł `[151]`
Mówca: **Valken Kruger**
> "“I will start organising our troops and I will keep you updated on our progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Before he left the room, he turned to me."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Before he left the room, he turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Valken Kruger: "“You know, Mr. President.”"*)

### Węzeł `[153]`
Mówca: **Valken Kruger**
> "“You know, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Valken Kruger: "“I am now fully convinced that you are truly a great lead..."*)

### Węzeł `[154]`
Mówca: **Valken Kruger**
> "“I am now fully convinced that you are truly a great leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player: "“Thank you, General Valken.”"*)
  - -> `[155]` (*Player: "“Did you have any doubts?”"*)
  - -> `[159]` (*Player: "“No need for flattery. Begin your work immediately.”"*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "“Did you have any doubts?”"]** — Mówca: **Player**
> "“Did you have any doubts?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Valken Kruger: "“I don't now.”"*)

### Węzeł `[156]`
**[WYBÓR GRACZA: "“Thank you, General Valken.”"]** — Mówca: **Player**
> "“Thank you, General Valken.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Valken Kruger: "“No. Thank you, Mr. President.”"*)

### Węzeł `[157]`
Mówca: **Valken Kruger**
> "“Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "'Victory will come.'"*)

### Węzeł `[158]`
Mówca: **Narrator**
> "'Victory will come.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "He saluted one more time and left. Iosef and Lucian were ..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "“No need for flattery. Begin your work immediately.”"]** — Mówca: **Player**
> "“No need for flattery. Begin your work immediately.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Valken Kruger: "“As you command.”"*)

### Węzeł `[160]`
Mówca: **Valken Kruger**
> "“No. Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Valken Kruger: "“Vectern sis da!”"*)

### Węzeł `[161]`
Mówca: **Valken Kruger**
> "“I don't now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Valken Kruger: "“Vectern sis da!”"*)

### Węzeł `[162]`
Mówca: **Valken Kruger**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Valken Kruger: "“Vectern sis da!”"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "He saluted one more time and left. Iosef and Lucian were sitting down at the table, thinking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Deivid Wisci: "“I am totally against this decision, Mr. President. We ar..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Iosef seemed reluctant for a moment, but proceeded with h..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "Iosef smiled, gave a strong salute and stomped his foot l..."*)

### Węzeł `[167]`
Mówca: **Iosef Lancea**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Iosef Lancea: "“I will start organising our troops and I will keep you u..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "Iosef seemed reluctant for a moment, but proceeded with his salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Iosef Lancea: "“Mr. President.”"*)

### Węzeł `[169]`
Mówca: **Narrator**
> "Iosef smiled, gave a strong salute and stomped his foot loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Iosef Lancea: "“Mr. President.”"*)

### Węzeł `[170]`
Mówca: **Iosef Lancea**
> "“I will start organising our troops and I will keep you updated on our progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Deivid Wisci: "“I am totally against this decision, Mr. President. We ar..."*)

### Węzeł `[171]`
Mówca: **Deivid Wisci**
> "“I am totally against this decision, Mr. President. We are pouring fuel to the fire and it can escalate beyond Merkopa even.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Iosef Lancea: "“A decision has been made. War it is.”"*)

### Węzeł `[172]`
Mówca: **Iosef Lancea**
> "“A decision has been made. War it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Lucian was lost in thoughts. He shook his head."*)

### Węzeł `[173]`
Mówca: **Lucian Galade**
> "“Very well. Then we need to increase public support for the war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Iosef Lancea: "“I will schedule a military parade.”"*)

### Węzeł `[174]`
Mówca: **Narrator**
> "Lucian was lost in thoughts. He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucian Galade: "“Very well. Then we need to increase public support for t..."*)

### Węzeł `[175]`
Mówca: **Iosef Lancea**
> "“I will schedule a military parade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Lucian Galade: "“I will do my part and commission war propaganda against ..."*)

### Węzeł `[176]`
Mówca: **Lucian Galade**
> "“I will do my part and commission war propaganda against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: "“Good work, both of you.”"*)
  - -> `[178]` (*Player: "“Don't worry. We will win. I know it.”"*)
  - -> `[177]` (*Player: "“If we are done here, I will go back to sleep.”"*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "“If we are done here, I will go back to sleep.”"]** — Mówca: **Player**
> "“If we are done here, I will go back to sleep.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: "“Very well, sir.”"*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "“Don't worry. We will win. I know it.”"]** — Mówca: **Player**
> "“Don't worry. We will win. I know it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucian Galade: "“I hope you are right, sir.”"*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "“Good work, both of you.”"]** — Mówca: **Player**
> "“Good work, both of you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: "“Thank you, sir.”"*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> "“Thank you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Iosef Lancea: "“Once everything is ready, we will need to announce the d..."*)

### Węzeł `[181]`
Mówca: **Lucian Galade**
> "“I hope you are right, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Iosef Lancea: "“Once everything is ready, we will need to announce the d..."*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Iosef Lancea: "“Once everything is ready, we will need to announce the d..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "I couldn't sleep at all that night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn09_Wehlen_RaisesRumburg..."*)

### Węzeł `[184]`
Mówca: **Iosef Lancea**
> "“Once everything is ready, we will need to announce the declaration of war. But, planning comes first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Iosef Lancea: "“I will discuss the details with the generals and Mr. Wis..."*)

### Węzeł `[185]`
Mówca: **Iosef Lancea**
> "“For now, have a good night's sleep, Mr. President. You will need it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "I couldn't sleep at all that night."*)

### Węzeł `[186]`
Mówca: **Lucian Galade**
> "“Thank you. This is for the best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucian Galade: "“What should we do then, sir?”"*)

### Węzeł `[187]`
Mówca: **Lucian Galade**
> "“What should we do then, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "“We will retaliate with equal force to display our streng..."*)
  - -> `[189]` (*Player: "“We will approach this diplomatically and try to de-escal..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“We will retaliate with equal force to display our strength.”"]** — Mówca: **Player**
> "“We will retaliate with equal force to display our strength.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Iosef Lancea: "“Very well.”"*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "“We will approach this diplomatically and try to de-escalate the situation.”"]** — Mówca: **Player**
> "“We will approach this diplomatically and try to de-escalate the situation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Deivid Wisci: "“I will immediately begin working on it.”"*)

### Węzeł `[190]`
Mówca: **Iosef Lancea**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Deivid Wisci: "“If there is to be a retaliation, we need to be extremely..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Iosef Lancea: "“We will be careful. It is risky but the fallout can be h..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Iosef Lancea: "“We are not the ones who escalated the situation. They we..."*)

### Węzeł `[194]`
Mówca: **Iosef Lancea**
> "“We will be careful. It is risky but the fallout can be handled diplomatically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Iosef Lancea: "“Regardless, our retaliation is rightful and our cause is..."*)

### Węzeł `[195]`
Mówca: **Iosef Lancea**
> "“Regardless, our retaliation is rightful and our cause is just.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Iosef Lancea: "“I will send word for the start of a military operation.”"*)

### Węzeł `[196]`
Mówca: **Iosef Lancea**
> "“I will send word for the start of a military operation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Iosef Lancea: "“Our target will be their warplanes at an airbase near th..."*)

### Węzeł `[197]`
Mówca: **Iosef Lancea**
> "“Our target will be their warplanes at an airbase near the border.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Iosef Lancea: "“I will bring the paperwork.”"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Valken Kruger: "“I will begin my task immediately, Mr. President.”"*)

### Węzeł `[201]`
Mówca: **Valken Kruger**
> "“I will begin my task immediately, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Valken Kruger: "“If you will excuse me now, I must talk to the military c..."*)

### Węzeł `[202]`
Mówca: **Valken Kruger**
> "“If you will excuse me now, I must talk to the military command to relay the orders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "Before he left the room, he saluted."*)

### Węzeł `[203]`
Mówca: **Iosef Lancea**
> "“I will bring the paperwork.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Iosef returned with the paperwork for the order and showe..."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "Before he left the room, he saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Iosef Lancea: "“I will bring the paperwork.”"*)

### Węzeł `[205]`
Mówca: **Narrator**
> "Iosef returned with the paperwork for the order and showed me where to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "Sign off on the operation."]** — Mówca: **Player_Italic**
> "I signed off on the operation."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_Retaliation = true"*)

### Węzeł `[207]`
Mówca: **Iosef Lancea**
> "“For now, have a good night's sleep.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Iosef Lancea: "“You will need it.”"*)

### Węzeł `[208]`
Mówca: **Iosef Lancea**
> "“You will need it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "I couldn't sleep at all that night."*)

### Węzeł `[209]`
Mówca: **Iosef Lancea**
> "“That is all, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Iosef Lancea: "“I will keep you updated on the situation.”"*)

### Węzeł `[210]`
Mówca: **Iosef Lancea**
> "“I will keep you updated on the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Iosef Lancea: "“For now, have a good night's sleep.”"*)

### Węzeł `[211]`
Mówca: **Iosef Lancea**
> "“Mr. President. I assure you, they wouldn't dare attack us for that. They know that we are far superior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Iosef Lancea: "“This will send a strong message.”"*)

### Węzeł `[212]`
Mówca: **Iosef Lancea**
> "“This will send a strong message.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Iosef Lancea: "“I will send word for the start of a military operation.”"*)

### Węzeł `[213]`
Mówca: **Lucian Galade**
> "“I still think a peaceful solution would be more beneficial, but of course I don't have the military experience and insight Mr. Lancea has.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucian Galade: "“I still think a peaceful solution would be more benefici..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Lucian Galade: "“I still think a peaceful solution would be more benefici..."*)

### Węzeł `[217]`
Mówca: **Lucian Galade**
> "“I still think a peaceful solution would be more beneficial, but it looks like this is the way we are going forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“Thank you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Deivid Wisci: "“I will immediately begin working on it.”"*)

### Węzeł `[219]`
Mówca: **Deivid Wisci**
> "“I will immediately begin working on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_Diplomacy = true"*)

### Węzeł `[220]`
Mówca: **Lucian Galade**
> "“With Mr. Wisci's capabilities, I am sure that we will de-escalate the situation successfully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: "“We will keep you updated on our progress.”"*)

### Węzeł `[221]`
Mówca: **Lucian Galade**
> "“We will keep you updated on our progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Iosef Lancea: "“This is our best bet.”"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)

### Węzeł `[225]`
Mówca: **Iosef Lancea**
> "“This is our best bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[226]`
Mówca: **Iosef Lancea**
> "“We should've retaliated. I hope the diplomatic response makes sure that further incidents like this are prevented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Iosef Lancea: "“If there is a next time, I'm afraid that it will be war.”"*)

### Węzeł `[227]`
Mówca: **Iosef Lancea**
> "“If there is a next time, I'm afraid that it will be war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Deivid Wisci: "“Peace must be maintained at all costs. I am saying this ..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Valken Kruger: "“We are showing weakness. Of course it will be a war the ..."*)

### Węzeł `[231]`
Mówca: **Valken Kruger**
> "“We are showing weakness. Of course it will be a war the next time around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Valken Kruger: "“I am frankly disappointed, Mr. President.”"*)

### Węzeł `[232]`
Mówca: **Valken Kruger**
> "“I am frankly disappointed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Valken Kruger: "“If we can't even retaliate after such an attack, what wi..."*)

### Węzeł `[233]`
Mówca: **Valken Kruger**
> "“If we can't even retaliate after such an attack, what will become of this country in the future?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Deivid Wisci: "“Peace must be maintained at all costs. I am saying this ..."*)

### Węzeł `[234]`
Mówca: **Deivid Wisci**
> "“Peace must be maintained at all costs. I am saying this as a man who has seen too many years of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Deivid Wisci: "“This should be our only bet.”"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)

### Węzeł `[238]`
Mówca: **Valken Kruger**
> "“If you ask me, this is just plain old weakness we are showing them right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Valken Kruger: "“I am frankly disappointed, Mr. President.”"*)

### Węzeł `[239]`
Mówca: **Valken Kruger**
> "“I am frankly disappointed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Valken Kruger: "“If we can't even retaliate at such an attack, what will ..."*)

### Węzeł `[240]`
Mówca: **Valken Kruger**
> "“If we can't even retaliate at such an attack, what will become of this country in the future?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Deivid Wisci: "“Peace must be maintained at all costs. I am saying this ..."*)

### Węzeł `[241]`
Mówca: **Deivid Wisci**
> "“This should be our only bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Deivid Wisci: "“Peace must be maintained at all costs. I am saying this ..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_Diplomacy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgIncident_Diplomacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_RumburgIncident_Diplomacy ..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_Retaliation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgIncident_Retaliation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_RumburgIncident_Retaliatio..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_RumburgIncident_DeclareWar..."*)

### Węzeł `[245]`
Mówca: **Iosef Lancea**
> "“Now that the paperwork is done...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Iosef Lancea: "“I have an idea, Mr. President.”"*)

### Węzeł `[246]`
Mówca: **Iosef Lancea**
> "“I have an idea, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Iosef Lancea: "“I think we should hold a military parade to display our ..."*)

### Węzeł `[247]`
Mówca: **Iosef Lancea**
> "“I think we should hold a military parade to display our strength.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Deivid Wisci: "“I am with Mr. Lancea on this one. This should work well ..."*)

### Węzeł `[248]`
Mówca: **Deivid Wisci**
> "“I am with Mr. Lancea on this one. This should work well as a deterrent and it will come in handy as a tool to de-escalate the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Lucian Galade: "“That is a good idea.”"*)

### Węzeł `[249]`
Mówca: **Lucian Galade**
> "“That is a good idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Lucian Galade: "“Simple and effective without causing any ruckus.”"*)

### Węzeł `[250]`
Mówca: **Lucian Galade**
> "“Simple and effective without causing any ruckus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Player: "“That makes sense. Organise the military parade.”"*)
  - -> `[251]` (*Player: "“No. We need to create a peaceful image for Sordland.”"*)

### Węzeł `[251]`
**[WYBÓR GRACZA: "“No. We need to create a peaceful image for Sordland.”"]** — Mówca: **Player**
> "“No. We need to create a peaceful image for Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_Personal_SergeFuneral = true;"*)

### Węzeł `[252]`
**[WYBÓR GRACZA: "“That makes sense. Organise the military parade.”"]** — Mówca: **Player**
> "“That makes sense. Organize the military parade.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_MilitaryParade = true"*)

### Węzeł `[253]`
Mówca: **Iosef Lancea**
> "“Understood.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Iosef Lancea: "“That is all, Mr. President.”"*)

### Węzeł `[254]`
Mówca: **Iosef Lancea**
> "“Well. Now that we know the way forward...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Iosef Lancea: "“I have an idea, Mr. President.”"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_MilitaryParade = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgIncident_MilitaryParade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryPa..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_MilitaryParade = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgIncident_MilitaryParade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_SnO_RumburgIncident = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_SnO_RumburgIncident"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[258]`
Mówca: **Valken Kruger**
> "“We are not the ones that are attacking the peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Valken Kruger: "“Regardless, it looks like your decision has been made, M..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Iosef Lancea: "“Well. Now that we know the way forward...”"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Valken Kruger: "“We are not the ones that are attacking the peace.”"*)

### Węzeł `[262]`
Mówca: **Valken Kruger**
> "“Regardless, it looks like your decision has been made, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Valken Kruger: "“I know when I am not needed.”"*)

### Węzeł `[263]`
Mówca: **Valken Kruger**
> "“I know when I am not needed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Valken Kruger: "“I will take my leave.”"*)

### Węzeł `[264]`
Mówca: **Valken Kruger**
> "“I will take my leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Before he left the room, he saluted."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Before he left the room, he saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Iosef Lancea: "“Well. Now that we know the way forward...”"*)

### Węzeł `[266]`
Mówca: **Iosef Lancea**
> "“I will discuss the details with the generals and Mr. Wisci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Deivid Wisci: "“I can't believe after so many years, our country has to ..."*)

### Węzeł `[267]`
Mówca: **Deivid Wisci**
> "“We must maintain peace in Sordland and Eastern Merkopa at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Iosef Lancea: "“I agree. We have much to lose.”"*)

### Węzeł `[268]`
Mówca: **Deivid Wisci**
> "“We must maintain peace in Sordland and Eastern Merkopa at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Iosef Lancea: "“What do you expect us to do? Sit around and do nothing?”"*)

### Węzeł `[269]`
Mówca: **Iosef Lancea**
> "“They are testing us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Iosef Lancea: "“We must respond immediately. Otherwise, they will think ..."*)

### Węzeł `[270]`
Mówca: **Deivid Wisci**
> "“We must maintain peace in Sordland and Eastern Merkopa at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Iosef Lancea: "“I agree. We have much to lose.”"*)

### Węzeł `[271]`
Mówca: **Deivid Wisci**
> "“We must maintain peace in Sordland and Eastern Merkopa at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Iosef Lancea: "“What do you expect us to do? Sit around and do nothing?”"*)

### Węzeł `[272]`
Mówca: **Iosef Lancea**
> "“What do you expect us to do? Sit around and do nothing?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Iosef Lancea: "“They are testing us.”"*)

### Węzeł `[273]`
Mówca: **Lucian Galade**
> "“I agree. They are trying to lure us into their trap.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[274]`
Mówca: **Lucian Galade**
> "“I agree. They are trying to lure us into their trap.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[275]`
Mówca: **Lucian Galade**
> "“It looks like they are trying to lure us into their trap.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[276]`
Mówca: **Deivid Wisci**
> "“If there is to be a retaliation, we need to be extremely careful. They will seek every opportunity to blame us for it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Deivid Wisci: "“We can't further escalate the situation and destabilize ..."*)

### Węzeł `[277]`
Mówca: **Deivid Wisci**
> "“We need to prevent a war at all costs. I am saying this as a man who has lived through too many years of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[278]`
Mówca: **Deivid Wisci**
> "“We can't further escalate the situation and destabilize the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Deivid Wisci: "“We need to prevent a war at all costs. I am saying this ..."*)

### Węzeł `[279]`
Mówca: **Iosef Lancea**
> "“We are not the ones who escalated the situation. They were first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Iosef Lancea: "“Mr. President. I assure you, they wouldn't dare attack u..."*)

### Węzeł `[280]`
Mówca: **Deivid Wisci**
> "“Rumburg will turn its back on us and blame us for the attack. Every single enemy of Sordland, and trust me there are many, will unite under that banner regardless of the truth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Deivid Wisci: "“If that happens and they manage to convince the world, w..."*)

### Węzeł `[281]`
Mówca: **Deivid Wisci**
> "“If that happens and they manage to convince the world, we will be seen as the aggressors despite the fact that we are in the right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Deivid Wisci: "“This will have an effect on everything. Our relationship..."*)

### Węzeł `[282]`
Mówca: **Deivid Wisci**
> "“This will have an effect on everything. Our relationships, trade, economy, status...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Deivid Wisci: "“All at the cost of one warplane, hundreds, thousands wil..."*)

### Węzeł `[283]`
Mówca: **Deivid Wisci**
> "“All at the cost of one warplane, hundreds, thousands will die. Decades of diplomatic success will go down the drain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player: "“I have given an order and I will not change my stance.”"*)
  - -> `[284]` (*Player: "“You are right. Maybe we shouldn't be so hasty.”"*)

### Węzeł `[284]`
**[WYBÓR GRACZA: "“You are right. Maybe we shouldn't be so hasty.”"]** — Mówca: **Player**
> "“You are right. Maybe we shouldn't be so hasty.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Deivid's tensed shoulders dropped and he relaxed."*)

### Węzeł `[285]`
**[WYBÓR GRACZA: "“I have given an order and I will not change my stance.”"]** — Mówca: **Player**
> "“I have given an order and I will not change my stance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Iosef Lancea: "“Mr. President. Are you serious about this?”"*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Deivid's tensed shoulders dropped and he relaxed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Deivid Wisci: "“I am glad.”"*)

### Węzeł `[287]`
Mówca: **Deivid Wisci**
> "“I am glad.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucian Galade: "“What should we do then, sir?”"*)

### Węzeł `[288]`
**[WYBÓR GRACZA: "“We will retaliate with equal force to display our strength.”"]** — Mówca: **Player**
> "“We will retaliate with equal force to display our strength.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[289]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Iosef Lancea: "“Very well.”"*)

### Węzeł `[289]`
Mówca: **Lucian Galade**
> "“What should we do then, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: "“We will retaliate with equal force to display our streng..."*)
  - -> `[290]` (*Player: "“We will approach this diplomatically and try to de-escal..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA: "“We will approach this diplomatically and try to de-escalate the situation.”"]** — Mówca: **Player**
> "“We will approach this diplomatically and try to de-escalate the situation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[289]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Deivid Wisci: "“I will immediately begin working on it.”"*)

### Węzeł `[291]`
Mówca: **Deivid Wisci**
> "“I can't believe after so many years, our country has to suffer once again...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Iosef Lancea: "“Victory is close, Mr. Wisci. Come with me please. We hav..."*)

### Węzeł `[292]`
Mówca: **Iosef Lancea**
> "“Victory is close, Mr. Wisci. Come with me please. We have much to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Iosef Lancea: "“For now, have a good night's sleep, Mr. President. You w..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "Valken stood up and put his hands on the table."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Valken Kruger: "“If you ask me, this is just plain old weakness we are sh..."*)

### Węzeł `[296]`
Mówca: **Valken Kruger**
> "“I don't think the General Staff can accept this decision. We cannot show weakness against Rumburg. It is time to retaliate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: "“My decision is final.”"*)
  - -> `[312]` (*Player: "“What is the meaning of this? You will accept this decisi..."*)
  - -> `[313]` (*Player: "“Gentlemen. Let's not argue over this.”"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true)"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "Iosef stood up and put his hands on the table."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Iosef Lancea: "“We should've retaliated. I hope the diplomatic response ..."*)

### Węzeł `[300]`
Mówca: **Iosef Lancea**
> "“We should retaliate. That was an act of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[301]`
Mówca: **Narrator**
> "Valken stood up and put his hands on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Valken Kruger: "“Hold on.”"*)

### Węzeł `[302]`
Mówca: **Valken Kruger**
> "“Hold on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Valken Kruger: "“I don't think the General Staff can accept this decision..."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "Iosef stood up and put his hands on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Iosef Lancea: "“No. This is wrong.”"*)

### Węzeł `[304]`
Mówca: **Iosef Lancea**
> "“No. This is wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Iosef Lancea: "“We should retaliate. That was an act of war.”"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Iosef Lancea: "“I don't think the Sordish Armed Forces can accept this d..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "Valken also stood up."*)

### Węzeł `[308]`
Mówca: **Valken Kruger**
> "“I don't think the General Staff can accept this decision. We cannot show weakness against Rumburg. It is time to retaliate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: "“My decision is final.”"*)
  - -> `[312]` (*Player: "“What is the meaning of this? You will accept this decisi..."*)
  - -> `[313]` (*Player: "“Gentlemen. Let's not argue over this.”"*)

### Węzeł `[309]`
Mówca: **Narrator**
> "Valken also stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Valken Kruger: "“I don't think the General Staff can accept this decision..."*)

### Węzeł `[310]`
Mówca: **Iosef Lancea**
> "“I don't think the Sordish Armed Forces can accept this decision. We cannot show weakness against Rumburg. It is time to retaliate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player: "“My decision is final.”"*)
  - -> `[315]` (*Player: "“What is the meaning of this? You will accept this decisi..."*)
  - -> `[316]` (*Player: "“Iosef. Let's not argue over this.”"*)

### Węzeł `[311]`
**[WYBÓR GRACZA: "“My decision is final.”"]** — Mówca: **Player**
> "“My decision is final.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Valken Kruger), `[308]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Valken Kruger: "“I seriously urge you to reconsider your decision.”"*)

### Węzeł `[312]`
**[WYBÓR GRACZA: "“What is the meaning of this? You will accept this decision whether you like it or not.”"]** — Mówca: **Player**
> "“What is the meaning of this? You will accept this decision whether you like it or not.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Valken Kruger), `[308]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Valken Kruger: "“You cannot threaten the armed forces like that, Mr. Pres..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA: "“Gentlemen. Let's not argue over this.”"]** — Mówca: **Player**
> "“Gentlemen. Let's not argue over this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Valken Kruger), `[308]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Valken Kruger: "“I seriously urge you to reconsider your decision.”"*)

### Węzeł `[314]`
**[WYBÓR GRACZA: "“My decision is final.”"]** — Mówca: **Player**
> "“My decision is final.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Iosef Lancea: "“You don't understand. I urge you to reconsider your deci..."*)

### Węzeł `[315]`
**[WYBÓR GRACZA: "“What is the meaning of this? You will accept this decision whether you like it or not.”"]** — Mówca: **Player**
> "“What is the meaning of this? You will accept this decision whether you like it or not.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Iosef Lancea: "“You don't understand. I urge you to reconsider your deci..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA: "“Iosef. Let's not argue over this.”"]** — Mówca: **Player**
> "“Iosef. Let's not argue over this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Iosef Lancea: "“You don't understand. I urge you to reconsider your deci..."*)

### Węzeł `[317]`
Mówca: **Iosef Lancea**
> "“You don't understand. I urge you to reconsider your decision, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player: "“Enough. The decision has already been made.”"*)
  - -> `[325]` (*Player: "“You are pushing it. I don't appreciate not being taken s..."*)
  - -> `[323]` (*Player: "“Or what?”"*)

### Węzeł `[318]`
Mówca: **Valken Kruger**
> "“You cannot threaten the armed forces like that, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Valken Kruger: "“I seriously urge you to reconsider your decision.”"*)

### Węzeł `[319]`
Mówca: **Valken Kruger**
> "“I seriously urge you to reconsider your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player: "“Enough. The decision has already been made.”"*)
  - -> `[321]` (*Player: "“You are pushing it. I don't appreciate not being taken s..."*)
  - -> `[322]` (*Player: "“Or what?”"*)

### Węzeł `[320]`
**[WYBÓR GRACZA: "“Enough. The decision has already been made.”"]** — Mówca: **Player**
> "“Enough. The decision has already been made.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Valken Kruger: "“You are making a grave mistake.”"*)

### Węzeł `[321]`
**[WYBÓR GRACZA: "“You are pushing it. I don't appreciate not being taken seriously.”"]** — Mówca: **Player**
> "“You are pushing it. I don't appreciate not being taken seriously.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Valken Kruger: "“Me neither, Mr. President. You are making a grave mistake.”"*)

### Węzeł `[322]`
**[WYBÓR GRACZA: "“Or what?”"]** — Mówca: **Player**
> "“Or what?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Valken Kruger: "“I will just say this...”"*)

### Węzeł `[323]`
**[WYBÓR GRACZA: "“Or what?”"]** — Mówca: **Player**
> "“Or what?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Iosef Lancea: "“I will just say this...”"*)

### Węzeł `[324]`
**[WYBÓR GRACZA: "“Enough. The decision has already been made.”"]** — Mówca: **Player**
> "“Enough. The decision has already been made.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Iosef Lancea: "“You made a grave mistake.”"*)

### Węzeł `[325]`
**[WYBÓR GRACZA: "“You are pushing it. I don't appreciate not being taken seriously.”"]** — Mówca: **Player**
> "“You are pushing it. I don't appreciate not being taken seriously.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Iosef Lancea: "“Me neither, Mr. President. You are making a grave mistake.”"*)

### Węzeł `[326]`
Mówca: **Iosef Lancea**
> "“You made a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "He clenched his fist and looked me in the eyes."*)

### Węzeł `[327]`
Mówca: **Iosef Lancea**
> "“Me neither, Mr. President. You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "He clenched his fist and looked me in the eyes."*)

### Węzeł `[328]`
Mówca: **Iosef Lancea**
> "“I will just say this...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Iosef Lancea: "“You made a grave mistake.”"*)

### Węzeł `[329]`
Mówca: **Valken Kruger**
> "“I will just say this...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Valken Kruger: "“You are making a grave mistake.”"*)

### Węzeł `[330]`
Mówca: **Valken Kruger**
> "“You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "He clenched his fist and looked me in the eyes."*)

### Węzeł `[331]`
Mówca: **Valken Kruger**
> "“Me neither, Mr. President. You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "He clenched his fist and looked me in the eyes."*)

### Węzeł `[332]`
Mówca: **Narrator**
> "He clenched his fist and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "I'd never seen him look at me so angrily before."*)

### Węzeł `[333]`
Mówca: **Narrator**
> "I'd never seen him look at me so angrily before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy = true"*)

### Węzeł `[334]`
Mówca: **Narrator**
> "He clenched his fist and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "I'd never seen him look at me this angrily before."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "I'd never seen him look at me this angrily before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Valken_Enemy = true"*)

### Węzeł `[336]`
Mówca: **Deivid Wisci**
> "“Gentlemen. Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Deivid Wisci: "“Peace must be maintained at all costs. I am saying this ..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true && BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true && BaseGame.Ref..."*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true && BaseGame.R..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true && BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Narrator: "Iosef stood up and put his hands on the table."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true && BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar = true"*)

### Węzeł `[340]`
Mówca: **Narrator**
> "Iosef stood up and put his hands on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Iosef Lancea: "“No. This is wrong.”"*)

### Węzeł `[341]`
Mówca: **Iosef Lancea**
> "“We are in no shape to fight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Iosef Lancea: "“I don't think the Armed Forces can accept this decision...."*)

### Węzeł `[342]`
Mówca: **Iosef Lancea**
> "“No. This is wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Iosef Lancea: "“We are in no shape to fight.”"*)

### Węzeł `[343]`
**[WYBÓR GRACZA: "“Iosef. Let's not argue over this.”"]** — Mówca: **Player**
> "“Iosef. Let's not argue over this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Iosef Lancea: "“You don't seem to understand. I urge you to reconsider y..."*)

### Węzeł `[344]`
Mówca: **Iosef Lancea**
> "“I don't think the Armed Forces can accept this decision. I cannot let you throw us under the bus just like that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: "“My decision is final.”"*)
  - -> `[345]` (*Player: "“What is the meaning of this? You will accept this decisi..."*)
  - -> `[343]` (*Player: "“Iosef. Let's not argue over this.”"*)
  - -> `[356]` (*Player: "“I thought you were a military man. A man of war.”"*)

### Węzeł `[345]`
**[WYBÓR GRACZA: "“What is the meaning of this? You will accept this decision whether you like it or not.”"]** — Mówca: **Player**
> "“What is the meaning of this? You will accept this decision whether you like it or not.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Iosef Lancea: "“You don't seem to understand. I urge you to reconsider y..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA: "“Or what?”"]** — Mówca: **Player**
> "“Or what?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Iosef Lancea: "“I will just say this...”"*)

### Węzeł `[347]`
**[WYBÓR GRACZA: "“You are pushing it. I don't appreciate not being taken seriously.”"]** — Mówca: **Player**
> "“You are pushing it. I don't appreciate not being taken seriously.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Iosef Lancea: "“Me neither, Mr. President... You are making a grave mist..."*)

### Węzeł `[348]`
Mówca: **Iosef Lancea**
> "“You don't seem to understand. I urge you to reconsider your decision, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player: "“Enough. The decision has already been made.”"*)
  - -> `[347]` (*Player: "“You are pushing it. I don't appreciate not being taken s..."*)
  - -> `[346]` (*Player: "“Or what?”"*)

### Węzeł `[349]`
Mówca: **Iosef Lancea**
> "“I will just say this...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Iosef Lancea: "“You are making a grave mistake.”"*)

### Węzeł `[350]`
Mówca: **Narrator**
> "I'd never seen him look at me this angrily before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy = true"*)

### Węzeł `[351]`
**[WYBÓR GRACZA: "“My decision is final.”"]** — Mówca: **Player**
> "“My decision is final.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Iosef Lancea: "“You don't seem to understand. I urge you to reconsider y..."*)

### Węzeł `[352]`
Mówca: **Narrator**
> "He clenched his fist and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "I'd never seen him look at me this angrily before."*)

### Węzeł `[353]`
**[WYBÓR GRACZA: "“Enough. The decision has already been made.”"]** — Mówca: **Player**
> "“Enough. The decision has already been made.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Iosef Lancea: "“You are making a grave mistake.”"*)

### Węzeł `[354]`
Mówca: **Iosef Lancea**
> "“You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "He clenched his fist and looked me in the eyes."*)

### Węzeł `[355]`
Mówca: **Iosef Lancea**
> "“Me neither, Mr. President... You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "He clenched his fist and looked me in the eyes."*)

### Węzeł `[356]`
**[WYBÓR GRACZA: "“I thought you were a military man. A man of war.”"]** — Mówca: **Player**
> "“I thought you were a military man. A man of war.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Iosef Lancea: "“I am. I know when and how wars are lost or won.""*)

### Węzeł `[357]`
Mówca: **Iosef Lancea**
> "“I am. I know when and how wars are lost or won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Iosef Lancea: "“You don't seem to understand. I urge you to reconsider y..."*)

### Węzeł `[358]`
Mówca: **Narrator**
> "The dimly lit room was filled with cutting-edge equipment -- the latest video screens, long-range radio electronics and other devices used for communication, presentation and planning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "The centerpiece of the room was a large round table with ..."*)

### Węzeł `[359]`
Mówca: **Narrator**
> "The centerpiece of the room was a large round table with the coat of arms of Sordland engraved on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SnO_WarRoom_Described = true"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SnO_WarRoom_Described = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_SnO_WarRoom_Described"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Deivid Wisci: "“Gentlemen. Please.”"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Valken_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Valken_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Deivid Wisci: "“Gentlemen. Please.”"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar = true"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Lucian's tensed-up shoulders relaxed."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Iosef Lancea: "“Very well.”"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Deivid Wisci: "“Mr. President...”"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn10_Personal_SergeFuneral = true;`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn10_Personal_SergeFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Iosef Lancea: "“Understood.”"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_RumburgIncident_Diplomacy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_Diplomacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: "“With Mr. Wisci's capabilities, I am sure that we will de..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_RumburgIncident_Retaliation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_Retaliation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Iosef Lancea: "“Now that the paperwork is done...”"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_RumburgIncident_DeclareWar = true; BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_DeclareWar"] = true;
Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_MilitaryParade = true"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_RumburgIncident_MilitaryParade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Iosef Lancea: "“Understood.”"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Valken smiled. He gave a strong salute and stomped his fo..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "Valken smiled. He gave a strong salute and stomped his fo..."*)

### Węzeł `[375]`
Mówca: **Narrator**
> "Valken smiled. He gave a strong salute and stomped his foot loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Valken Kruger: "“As you command, Mr. President.”"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player_Italic: "Sign off on the operation."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Italic: "Sign off on the operation."*)

### Węzeł `[379]`
**[WYBÓR GRACZA: "Sign off on the operation."]** — Mówca: **Player_Italic**
> "I signed off on the operation."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Kontekst wejściowy (poprzednik):** `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_Retaliation = true"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == tru..."*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I put on my clothes as fast as I could."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true ..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true ..."*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == tru..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Narrator: "I put on my clothes as fast as I could."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Narrator: "I put on my clothes as fast as I could."*)

### Węzeł `[386]`
Mówca: **Narrator**
> "I put on my clothes as fast as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I rushed downstairs and opened the door. Serge was waitin..."*)

### Węzeł `[387]`
Mówca: **Narrator**
> "I put on my clothes as fast as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I rushed downstairs and opened the door. Serge was waitin..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_RumburgKnows = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgIncident_RumburgKnows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaStays == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaStays == true"*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaStays == true)"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaStays == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_RumburgKnows = true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaStays == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_SordishPlaneShot = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_SordishPlaneShot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaStays == true"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRingPickUp");"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (..."*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true ||..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  (Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg = true"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  (Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRingPickUp");"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseGame.Bill_Turn09_LighterSecurity_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseGam..."*)
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseG..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseGame.Bill_Turn09_LighterSecurity_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Deal_Promised"] == true  and  Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusAllCities("City_WidespreadProtests");"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Peaceful_Deal_Promised == true && BaseGame.Bill_Turn09_LighterSecurity_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Deal_Promised"] == true  and  Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_SordishPlaneShot = true"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhoneRingPickUp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I was woken up in the middle of the night by a call from ..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_SnO_RumburgIncident = true"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn09_Wehlen_RaisesRumburgWorries = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn09_Wehlen_RaisesRumburgWorries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusAllCities("City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusAllCities("City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_SordishPlaneShot = true"*)
