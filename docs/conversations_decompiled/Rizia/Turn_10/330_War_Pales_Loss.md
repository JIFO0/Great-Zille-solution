# Rizia/Turn 10/War_Pales_Loss

- **ID konwersacji:** `330`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/330_War_Pales_Loss.md`
- **Liczba węzłów dialogowych:** 417
- **Liczba wyborów gracza:** 29

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.War_ParliamentProposesPeace`
- `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin`
- `RiziaDLCIsolated.Turn10_WarLoss_HowLong`
- `RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon`
- `RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Carlos_Deranked`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Faction_HouseAzaro_Carlos`
- `RiziaDLC.Faction_HouseAzaro_Lucita`
- `RiziaDLC.Faction_HouseAzaro_Taddeus`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Deranked`
- `RiziaDLC.War_Outcome_NoPeace_KeepFighting`
- `RiziaDLC.War_Pales_Loss_SueForPeace`
- `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin`
- `RiziaDLCIsolated.Turn10_WarLoss_HowLong`
- `RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon`
- `RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestLucitaAndTaddeus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedCarlos`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedTaddeus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_KeepFighting`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace`
- `RiziaDLCSupport.News_Turn10_RH_LucitaTaddeusArrested`
- `RiziaDLCSupport.News_Turn10_RH_TaddeusArrested`
- `RiziaDLCText.LucitaTitle`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""Spare me your antics.""** | `[7]` **Taddeus Azaro**: ""My life has been nothing but a ..."<br>`[286]` **Carlos Robles Azaro**: ""I fear I will be remembered not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Taddeus Azaro**: ""I am sorry, Your Majesty.""<br>`[292]` **Narrator**: "He cast his eyes down in shame." |
| `[10]` | **""Clearly. Because you are weak.""** | `[7]` **Taddeus Azaro**: ""My life has been nothing but a ..."<br>`[286]` **Carlos Robles Azaro**: ""I fear I will be remembered not..." | `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false` | *Brak zmian stanu* | `[84]` **Taddeus Azaro**: ""I am sorry, Your Majesty.""<br>`[292]` **Narrator**: "He cast his eyes down in shame." |
| `[11]` | **""I am sorry.""** | `[7]` **Taddeus Azaro**: ""My life has been nothing but a ..."<br>`[286]` **Carlos Robles Azaro**: ""I fear I will be remembered not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Taddeus Azaro**: ""Thank you, Your Majesty.""<br>`[297]` **Narrator**: "He sat straighter." |
| `[12]` | **""There is always hope. No matter how dire the situation is.""** | `[7]` **Taddeus Azaro**: ""My life has been nothing but a ..."<br>`[286]` **Carlos Robles Azaro**: ""I fear I will be remembered not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Taddeus Azaro**: ""Thank you, Your Majesty.""<br>`[297]` **Narrator**: "He sat straighter." |
| `[23]` | **""No. I have failed. This burden is mine to bear.""** | `[25]` **Narrator**: "Her words sank deep into my mind."<br>`[198]` **Narrator**: "His words sank deep into my mind." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Taddeus Azaro**: ""No, Your Majesty. It is all my ..."<br>`[204]` **Carlos Robles Azaro**: ""No, Your Majesty. It is all my ..." |
| `[26]` | **""There is no one to blame. We must look to the future.""** | `[25]` **Narrator**: "Her words sank deep into my mind."<br>`[198]` **Narrator**: "His words sank deep into my mind." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Taddeus Azaro**: ""That's generous of you to say, ..."<br>`[209]` **Carlos Robles Azaro**: ""That's generous of you to say, ..." |
| `[27]` | **""And where were you when we were losing this war, Duchess?""** | `[25]` **Narrator**: "Her words sank deep into my mind." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Taddeus Azaro**: ""Please don't blame my daughter,..."<br>`[213]` **Carlos Robles Azaro**: ""Please don't blame Lucita, Your..." |
| `[34]` | **""Can we still win?""** | `[382]` **Lucita Azaro**: ""But they didn't fight the war. ..."<br>`[391]` **Carlos Robles Azaro**: ""But you're the one with the fin..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == false` | `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] = true;` | `[59]` **Lucita Azaro**: ""With the current state of the w..."<br>`[225]` **Carlos Robles Azaro**: ""Given the current state of the ..." |
| `[35]` | **""Do you think we should sue for peace?""** | `[382]` **Lucita Azaro**: ""But they didn't fight the war. ..."<br>`[391]` **Carlos Robles Azaro**: ""But you're the one with the fin..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == false` | `Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] = t...` | `[61]` **Lucita Azaro**: ""If we sue for peace, we will lo..."<br>`[232]` **Carlos Robles Azaro**: ""Hard to say. If we sue for peac..." |
| `[36]` | **""How long can we afford to keep the war going?""** | `[382]` **Lucita Azaro**: ""But they didn't fight the war. ..."<br>`[391]` **Carlos Robles Azaro**: ""But you're the one with the fin..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == false` | `Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] = true;` | `[67]` **Lucita Azaro**: ""Unless the situation changes dr..."<br>`[243]` **Carlos Robles Azaro**: ""Unless the situation changes dr..." |
| `[37]` | **""Would the Palesians be able to march on Porte Drazon?""** | `[382]` **Lucita Azaro**: ""But they didn't fight the war. ..."<br>`[391]` **Carlos Robles Azaro**: ""But you're the one with the fin..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == false` | `Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazo...` | `[70]` **Taddeus Azaro**: ""Highly unlikely.""<br>`[262]` **Carlos Robles Azaro**: ""Unlikely."" |
| `[57]` | **""In light of this information, I know what needs to be done.""** | `[382]` **Lucita Azaro**: ""But they didn't fight the war. ..."<br>`[391]` **Carlos Robles Azaro**: ""But you're the one with the fin..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == true` | *Brak zmian stanu* | `[73]` **Lucita Azaro**: ""I knew you would, Your Majesty.""<br>`[271]` **Carlos Robles Azaro**: ""Very good, Your Majesty. I knew..." |
| `[58]` | **""I don't need to discuss anything. The path forward is clear. I know what needs to..."** | `[382]` **Lucita Azaro**: ""But they didn't fight the war. ..."<br>`[391]` **Carlos Robles Azaro**: ""But you're the one with the fin..."<br>*(oraz 10 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == true) == false` | *Brak zmian stanu* | `[73]` **Lucita Azaro**: ""I knew you would, Your Majesty.""<br>`[271]` **Carlos Robles Azaro**: ""Very good, Your Majesty. I knew..." |
| `[76]` | **""We will approach Pales to sue for peace. I do not wish any more blood to be spill..."** | `[74]` **Lucita Azaro**: ""What is your decision?""<br>`[272]` **Carlos Robles Azaro**: ""What have you decided?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.War_Pales_Loss_SueForPeace"] = true; V...` | `[81]` **Lucita Azaro**: ""Very well. Peace it is, Your Ma..."<br>`[279]` **Carlos Robles Azaro**: ""As you wish, Your Majesty. Peac..." |
| `[77]` | **""We will continue fighting until the last drop of blood. We have to keep pushing.""** | `[74]` **Lucita Azaro**: ""What is your decision?""<br>`[272]` **Carlos Robles Azaro**: ""What have you decided?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] = t...` | `[80]` **Lucita Azaro**: ""A sound decision, Your Majesty.""<br>`[280]` **Carlos Robles Azaro**: ""As you wish, Your Majesty."" |
| `[91]` | **""Taddeus Azaro. In light of your failures and incompetence, you are hereby incarce..."** | `[89]` **Taddeus Azaro**: ""Command me. What are your orders?"" | `(Variable["RiziaDLC.Reform_Success"] == true) == false` | *Brak zmian stanu* | `[125]` **Narrator**: "Lucita's eyes widened in shock."<br>`[338]` **Narrator**: "My guards put the old man back i..." |
| `[96]` | **""Taddeus Azaro, you will leave your post immediately and relinquish all of your du..."** | `[89]` **Taddeus Azaro**: ""Command me. What are your orders?""<br>`[302]` **Carlos Robles Azaro**: ""Command me. What are your orders?""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false` | `Variable["RiziaDLC.Taddeus_Deranked"] = true; Variable["R...` | `[99]` **Taddeus Azaro**: ""Yes, my King. I accept my chang..." |
| `[97]` | **""You will continue to serve the Crown as you have before.""** | `[89]` **Taddeus Azaro**: ""Command me. What are your orders?""<br>`[302]` **Carlos Robles Azaro**: ""Command me. What are your orders?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Taddeus Azaro**: ""Yes, my King. I thank you profu..."<br>`[328]` **Carlos Robles Azaro**: ""Yes, my King. I can't thank you..." |
| `[113]` | **""Very well. I resend that order.""** | `[119]` **Lucita Azaro**: ""For your own good, please recon..."<br>`[164]` **Narrator**: "She gestured to her belly." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Lucita Azaro**: ""Thank you, Romus.""<br>`[124]` **Lucita Azaro**: ""Thank you, Your Majesty."" |
| `[118]` | **""Lucita Azaro. You will share your fathers' fate. I am sentencing you to prison fo..."** | `[119]` **Lucita Azaro**: ""For your own good, please recon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Lucita Azaro**: ""WHAT?! Are you out of your mind?"" |
| `[136]` | **""Very well. I will spare Lucita.""** | `[134]` **Narrator**: "The old man's eyes were teary." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Taddeus Azaro**: ""Thank you. Thank you, Your Maje..." |
| `[137]` | **"Signal to the guards to take them both away."** | `[134]` **Narrator**: "The old man's eyes were teary." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCText.LucitaTitle"] ="Queen Consort and ...`<br>`Variable["RiziaDLC.Taddeus_Arrested"] = true; Variable["R...`<br>*(+1 skryptów)* | `[138]` **Taddeus Azaro**: ""No. No!"" |
| `[199]` | **""And where were *you* when we were losing this war, General?""** | `[198]` **Narrator**: "His words sank deep into my mind." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Taddeus Azaro**: ""I know, Your Majesty. This is e..."<br>`[218]` **Carlos Robles Azaro**: ""I know, Your Majesty. This is e..." |
| `[200]` | **""If it weren't for the incompetency of the Azaro military command, we'd be celebra..."** | `[25]` **Narrator**: "Her words sank deep into my mind."<br>`[198]` **Narrator**: "His words sank deep into my mind." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Taddeus Azaro**: ""I know, Your Majesty. It is all..."<br>`[217]` **Carlos Robles Azaro**: ""I know, Your Majesty. It is all..." |
| `[311]` | **""Carlos Robles Azaro, you will leave your post immediately and relinquish all of y..."** | `[89]` **Taddeus Azaro**: ""Command me. What are your orders?""<br>`[302]` **Carlos Robles Azaro**: ""Command me. What are your orders?""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false` | `Variable["RiziaDLC.Carlos_Deranked"] = true; Variable["Ri...` | `[316]` **Carlos Robles Azaro**: ""Yes, my King. I acknowledge my ..." |
| `[373]` | **""So you admit it. The vaunted House of Azaro is nothing but a bunch of weaklings w..."** | `[7]` **Taddeus Azaro**: ""My life has been nothing but a ..."<br>`[286]` **Carlos Robles Azaro**: ""I fear I will be remembered not..." | `Variable["RiziaDLC.HouseAzaro_Conquered"] == true` | *Brak zmian stanu* | `[84]` **Taddeus Azaro**: ""I am sorry, Your Majesty.""<br>`[292]` **Narrator**: "He cast his eyes down in shame." |
| `[402]` | **""Dammit! We could've turned this around.""** | `[395]` **Lucita Azaro**: ""Or, well... there's nothing to ..."<br>`[401]` **Carlos Robles Azaro**: ""Ahem. Actually, there's nothing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Lucita Azaro**: ""I know.""<br>`[409]` **Carlos Robles Azaro**: ""We should have done so already...." |
| `[403]` | **""So why even bother meeting with me?""** | `[395]` **Lucita Azaro**: ""Or, well... there's nothing to ..."<br>`[401]` **Carlos Robles Azaro**: ""Ahem. Actually, there's nothing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Lucita Azaro**: ""Our troops fought this war for ..."<br>`[415]` **Carlos Robles Azaro**: ""Our army fought this war for yo..." |
| `[404]` | **""A reasonable decision. I have no qualms with it.""** | `[395]` **Lucita Azaro**: ""Or, well... there's nothing to ..."<br>`[401]` **Carlos Robles Azaro**: ""Ahem. Actually, there's nothing..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[82]` **Narrator**: "General Azaro looked outside the..." |

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
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Losing the War against the Grand-Duchy o..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "When I entered the War Room, General Taddeus Azaro was in his wheelchair next to the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro");"*)

### Węzeł `[4]`
Mówca: **Taddeus Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "The hollow look on his face suggested he hadn't slept. Hi..."*)

### Węzeł `[5]`
Mówca: **Taddeus Azaro**
> ""All my life, I was told I was meant for greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Taddeus Azaro: ""Yet here I am. Defeated, unworthy. I can't even stand on..."*)

### Węzeł `[6]`
Mówca: **Taddeus Azaro**
> ""Once again, presenting the same news that I delivered to King Valero so many years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Taddeus Azaro: ""My life has been nothing but a series of failures.""*)

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""My life has been nothing but a series of failures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""There is always hope. No matter how dire the situation is.""*)
  - -> `[11]` (*Player_Romus: ""I am sorry.""*)
  - -> `[9]` (*Player_Romus: ""Spare me your antics.""*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)

### Węzeł `[8]`
Mówca: **Taddeus Azaro**
> ""Yet here I am. Defeated, unworthy. I can't even stand on my own two feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Taddeus Azaro: ""Once again, presenting the same news that I delivered to..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spare me your antics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[286]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Clearly. Because you are weak.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[286]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[286]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is always hope. No matter how dire the situation is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[286]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[13]`
Mówca: **Lucita Azaro**
> ""We have news from the frontline, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[14]`
Mówca: **Lucita Azaro**
> ""Pales still stands despite our attacks on their heartland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucita Azaro: ""Once we exhausted our troops, they managed to push us ba..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucita Azaro: ""Pales still stands despite our attacks on their heartland.""*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucita Azaro: ""The Palesian army has pushed us back from the border int..."*)

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""The Palesian army has pushed us back from the border into the Pales Administrative District.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucita Azaro: ""We've lost Terador and Fort Ales. The frontline is broken.""*)

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""We've lost Terador and Fort Ales. The frontline is broken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucita Azaro: ""They do not seem to be currently advancing.""*)

### Węzeł `[20]`
Mówca: **Lucita Azaro**
> ""Once we exhausted our troops, they managed to push us back, retaking Arces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucita Azaro: ""We are holding them at the frontline on an equal footing.""*)

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> ""We are holding them at the frontline on an equal footing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucita Azaro: ""But our operation has failed.""*)

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""They do not seem to be currently advancing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucita Azaro: ""But our operation has failed.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I have failed. This burden is mine to bear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator), `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[24]`
Mówca: **Lucita Azaro**
> ""But our operation has failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Her words sank deep into my mind."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Her words sank deep into my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""No. I have failed. This burden is mine to bear.""*)
  - -> `[26]` (*Player_Romus: ""There is no one to blame. We must look to the future.""*)
  - -> `[27]` (*Player_Romus: ""And where were you when we were losing this war, Duchess?""*)
  - -> `[200]` (*Player_Romus: ""If it weren't for the incompetency of the Azaro military..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no one to blame. We must look to the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator), `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And where were you when we were losing this war, Duchess?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[28]`
Mówca: **Taddeus Azaro**
> ""Please don't blame my daughter, Your Majesty. This is entirely on me, not her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[29]`
Mówca: **Taddeus Azaro**
> ""I know, Your Majesty. It is all my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[30]`
Mówca: **Taddeus Azaro**
> ""That's generous of you to say, Your Majesty. But we all know but we all know the failure is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[31]`
Mówca: **Taddeus Azaro**
> ""No, Your Majesty. It is all my fault. I'm the one whose to blame. Not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""Before we figure out who is to blame, I suggest we discuss what happens next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_ParliamentProposesPeace == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `War Loss Next Steps`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_HowLong == false"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || Rizia..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can we still win?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == false`
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucita Azaro), `[391]` (Carlos Robles Azaro), `[63]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_CanWeWin = true;"*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think we should sue for peace?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == false`
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucita Azaro), `[391]` (Carlos Robles Azaro), `[63]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal = true;"*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How long can we afford to keep the war going?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == false`
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucita Azaro), `[391]` (Carlos Robles Azaro), `[63]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_HowLong = true;"*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would the Palesians be able to march on Porte Drazon?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == false`
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucita Azaro), `[391]` (Carlos Robles Azaro), `[63]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon = true;"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Can we still win?""*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: ""Do you think we should sue for peace?""*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_HowLong == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_HowLong == false"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_WarLoss_HowLong == false)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_HowLong == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""How long can we afford to keep the war going?""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_WarLoss_HowLong == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""Would the Palesians be able to march on Porte Drazon?""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == true || RiziaDLCIsolated.Turn10_WarLoss_HowLong == true || RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || Rizia..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || Riz..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == true || RiziaDLCIsolated.Turn10_WarLoss_HowLong == true || RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""In light of this information, I know what needs to be do..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == true || RiziaDLCIsolated.Turn10_WarLoss_HowLong == true || RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""I don't need to discuss anything. The path forward is cl..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_HowLong = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In light of this information, I know what needs to be done.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == true`
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucita Azaro), `[391]` (Carlos Robles Azaro), `[63]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to discuss anything. The path forward is clear. I know what needs to be done.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucita Azaro), `[391]` (Carlos Robles Azaro), `[63]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""With the current state of the war, no. But, times change, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucita Azaro: ""If we keep the war going, we might eventually have an op..."*)

### Węzeł `[60]`
Mówca: **Lucita Azaro**
> ""If we keep the war going, we might eventually have an opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""If we sue for peace, we will lose face in the eyes of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucita Azaro: ""I think we should keep this going as far as we can. The ..."*)

### Węzeł `[62]`
Mówca: **Taddeus Azaro**
> ""Yes, however, our enemy might seize one for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Taddeus Azaro: ""It is a risk, Your Majesty.""*)

### Węzeł `[63]`
Mówca: **Taddeus Azaro**
> ""It is a risk, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[64]`
Mówca: **Lucita Azaro**
> ""I think we should keep this going as far as we can. The international ramifications would render Rizia crippled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[65]`
Mówca: **Taddeus Azaro**
> ""I disagree. This war can bring down Rizia along with Pales. Not to mention the resources we have already spent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Taddeus Azaro: ""We should sue for peace and look forward as a country.""*)

### Węzeł `[66]`
Mówca: **Taddeus Azaro**
> ""We should sue for peace and look forward as a country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[67]`
Mówca: **Lucita Azaro**
> ""Unless the situation changes drastically... potentially years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucita Azaro: ""In the end, we have more resources than Pales. We would ..."*)

### Węzeł `[68]`
Mówca: **Lucita Azaro**
> ""In the end, we have more resources than Pales. We would win the war of attrition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[69]`
Mówca: **Taddeus Azaro**
> ""We would, yes. But at what cost?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[70]`
Mówca: **Taddeus Azaro**
> ""Highly unlikely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""But not impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucita Azaro: ""If they keep pushing into Montaklar, they will gain a fo..."*)

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""If they keep pushing into Montaklar, they will gain a foothold in Rizia's heartland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""I knew you would, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucita Azaro: ""What is your decision?""*)

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""What is your decision?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""We will approach Pales to sue for peace. I do not wish a..."*)
  - -> `[77]` (*Player_Romus: ""We will continue fighting until the last drop of blood. ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [War Loss Next Steps]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "War Loss Next Steps"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will approach Pales to sue for peace. I do not wish any more blood to be spilled.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Lucita Azaro), `[272]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Loss_SueForPeace = true; RiziaDLCSuppo..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will continue fighting until the last drop of blood. We have to keep pushing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Lucita Azaro), `[272]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Outcome_NoPeace_KeepFighting = true; RiziaDL..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Loss_SueForPeace = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Pales_Loss_SueForPeace"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Outcome_NoPeace_KeepFighting = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_KeepFighting = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_KeepFighting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""A sound decision, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "General Azaro looked outside the window again."*)

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""Very well. Peace it is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "General Azaro looked outside the window again."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "General Azaro looked outside the window again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[83]`
Mówca: **Taddeus Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Taddeus Azaro: ""I am sorry for failing you.""*)

### Węzeł `[84]`
Mówca: **Taddeus Azaro**
> ""I am sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Taddeus Azaro: ""I am sorry for failing you.""*)

### Węzeł `[85]`
Mówca: **Taddeus Azaro**
> ""I am sorry for failing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[86]`
Mówca: **Taddeus Azaro**
> ""And you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "He turned his wheelchair toward me. Lucita helped him out..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "He turned to Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Taddeus Azaro: ""And you as well.""*)

### Węzeł `[88]`
Mówca: **Narrator**
> "He turned his wheelchair toward me. Lucita helped him out of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He knelt on the floor."*)

### Węzeł `[89]`
Mówca: **Taddeus Azaro**
> ""Command me. What are your orders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[97]` (*Player_Romus: ""You will continue to serve the Crown as you have before.""*)

### Węzeł `[90]`
Mówca: **Narrator**
> "He knelt on the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Taddeus Azaro: ""My Liege. My King.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taddeus Azaro. In light of your failures and incompetence, you are hereby incarcerated for a time of my choosing.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Ar..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "I noticed the marks on his uniform where his medals used ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "I gestured for him to join me at the table, and he prompt..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "I noticed the marks on his uniform where his medals used to be. I sat at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taddeus Azaro, you will leave your post immediately and relinquish all of your duties. I am de-ranking you to Colonel.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Taddeus Azaro), `[302]` (Carlos Robles Azaro), `[120]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Deranked = true; RiziaDLCSupport.Journal..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will continue to serve the Crown as you have before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Taddeus Azaro), `[302]` (Carlos Robles Azaro), `[120]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Deranked = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedTaddeus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Deranked"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedTaddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Taddeus Azaro: ""Yes, my King. I accept my change in rank.""*)

### Węzeł `[99]`
Mówca: **Taddeus Azaro**
> ""Yes, my King. I accept my change in rank.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "She helped him back into his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Taddeus Azaro: ""Thank you for your time, Your Majesty.""*)

### Węzeł `[101]`
Mówca: **Taddeus Azaro**
> ""Thank you for your time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "They bowed to me and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "I was left all alone in the War Room."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[104]`
Mówca: **Taddeus Azaro**
> ""My Liege. My King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Taddeus Azaro: ""Command me. What are your orders?""*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro"); RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucita Azaro: ""For your own good, Your Majesty... Romus. Listen to me.""*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucita Azaro: ""For your own good, Your Majesty, listen to me.""*)

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""For your own good, Your Majesty... Romus. Listen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucita Azaro: ""You’re about to cross a line you can’t uncross.""*)

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""For your own good, Your Majesty, listen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucita Azaro: ""You’re about to cross a line you can’t uncross.""*)

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""You’re about to cross a line you can’t uncross.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arres..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I resend that order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[164]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arres..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arr..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lucita Azaro: ""Please reconsider. For our sake. Yours, mine, and...""*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucita Azaro: ""For your own good, please reconsider.""*)

### Węzeł `[117]`
Mówca: **Lucita Azaro**
> ""Please reconsider. For our sake. Yours, mine, and...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "She gestured to her belly."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita Azaro. You will share your fathers' fate. I am sentencing you to prison for your transgressions and insults against the King.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""WHAT?! Are you out of your mind?""*)

### Węzeł `[119]`
Mówca: **Lucita Azaro**
> ""For your own good, please reconsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""Lucita Azaro. You will share your fathers' fate. I am se..."*)
  - -> `[113]` (*Player_Romus: ""Very well. I resend that order.""*)

### Węzeł `[120]`
Mówca: **Lucita Azaro**
> ""Thank you, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Jump to: [Final_Sentence_Hub]"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucita Azaro: ""Thank you, Romus.""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucita Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[124]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Jump to: [Final_Sentence_Hub]"*)

### Węzeł `[125]`
Mówca: **Narrator**
> "Lucita's eyes widened in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[126]`
Mówca: **Taddeus Azaro**
> ""Please, Your Majesty! Just take me! I am the one who is responsible, not Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Taddeus Azaro: ""I will gladly serve my sentence.""*)

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""WHAT?! Are you out of your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RomanceHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RomanceHappened == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RomanceHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""After everything we've been through together?""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RomanceHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Taddeus Azaro: ""Please, Your Majesty! Just take me! I am the one who is ..."*)

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""After everything we've been through together?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[132]`
Mówca: **Taddeus Azaro**
> ""I will gladly serve my sentence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Taddeus Azaro: ""But don't lock up my daughter as well. She shouldn't pay..."*)

### Węzeł `[133]`
Mówca: **Taddeus Azaro**
> ""But don't lock up my daughter as well. She shouldn't pay for my mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Taddeus Azaro: ""I beg you. I will do anything...""*)

### Węzeł `[134]`
Mówca: **Narrator**
> "The old man's eyes were teary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player_Romus_Italic: "Signal to the guards to take them both away."*)
  - -> `[136]` (*Player_Romus: ""Very well. I will spare Lucita.""*)

### Węzeł `[135]`
Mówca: **Taddeus Azaro**
> ""I beg you. I will do anything...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "The old man's eyes were teary."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I will spare Lucita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Taddeus Azaro: ""Thank you. Thank you, Your Majesty!""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "Signal to the guards to take them both away."]** — Mówca: **Player_Romus_Italic**
> "I signaled to the guards to take them both away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[138]`
Mówca: **Taddeus Azaro**
> ""No. No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucita Azaro: ""How dare you touch me? Do you know who I am?""*)

### Węzeł `[139]`
Mówca: **Lucita Azaro**
> ""How dare you touch me? Do you know who I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucita Azaro: ""Let go of me!""*)

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "The guards took them away and closed the door after them."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "The guards took them away and closed the door after them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Council", "Position_WarInternalSec..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "I was left all alone in the War Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Rizia_Map_Music_Tense");"*)

### Węzeł `[143]`
Mówca: **Taddeus Azaro**
> ""Thank you. Thank you, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested = true; RiziaDLC.Lucita_Arreste..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Guards put the old man back in his wheelchair and took him out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "Lucita stared at me in disbelief as she left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "The door closed with a loud bang."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "The door closed with a loud bang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "I was left all alone in the War Room."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested = true;
RiziaDLC.Lucita_Arrested = true;
RiziaDLC.Council_Security_Lucita = false;
RiziaDLC.Council_Security_Taddeus = false;
RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestLucitaAndTaddeus = true; RiziaDLC.Relations_Lucita_Together = false;
RiziaDLC.Lucita_Married = false;
RiziaDLC.PoisonInvestigator_Lucita = false;
EnableCodexEntry("Characters_Council_LucitaAzaro_Arrested");
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
RiziaDLCSupport.News_Turn10_RH_LucitaTaddeusArrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLC.Lucita_Arrested"] = true;
Variable["RiziaDLC.Council_Security_Lucita"] = false;
Variable["RiziaDLC.Council_Security_Taddeus"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestLucitaAndTaddeus"] = true;
Variable["RiziaDLC.Relations_Lucita_Together"] = false;
Variable["RiziaDLC.Lucita_Married"] = false;
Variable["RiziaDLC.PoisonInvestigator_Lucita"] = false;
EnableCodexEntry("Characters_Council_LucitaAzaro_Arrested");
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
Variable["RiziaDLCSupport.News_Turn10_RH_LucitaTaddeusArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Faction_HouseAzaro_Lucita = false; RiziaDLC.Fact..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lucita Azaro: ""Goodbye, Romus.""*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucita Azaro: ""Goodbye, You Majesty.""*)

### Węzeł `[151]`
Mówca: **Lucita Azaro**
> ""Goodbye, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "They bowed to me and left the room."*)

### Węzeł `[152]`
Mówca: **Lucita Azaro**
> ""Goodbye, You Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "They bowed to me and left the room."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested = true;
RiziaDLC.Lucita_Arrested = false;
RiziaDLC.Council_Security_Taddeus = false; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus = true;
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
RiziaDLCSupport.News_Turn10_RH_TaddeusArrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLC.Lucita_Arrested"] = false;
Variable["RiziaDLC.Council_Security_Taddeus"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus"] = true;
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
Variable["RiziaDLCSupport.News_Turn10_RH_TaddeusArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Guards put the old man back in his wheelchair and took hi..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Faile..."*)

### Węzeł `[156]`
Mówca: **Taddeus Azaro**
> ""Yes, my King. I thank you profusely for your forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro"); RemoveConversant("Luci..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Faction_HouseAzaro_Lucita = false;
RiziaDLC.Faction_HouseAzaro_Taddeus = false;
RiziaDLC.Faction_HouseAzaro_Carlos = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Faction_HouseAzaro_Lucita"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Taddeus"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Carlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Taddeus Azaro: ""No. No!""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Council", "Position_WarInternalSecurity","");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Council","Position_WarInternalSecurity","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "I was left all alone in the War Room."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lucita Azaro: ""What about our unborn son, for God's sake?""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Taddeus Azaro: ""Please, Your Majesty! Just take me! I am the one who is ..."*)

### Węzeł `[163]`
Mówca: **Lucita Azaro**
> ""What about our unborn son, for God's sake?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Taddeus Azaro: ""Please, Your Majesty! Just take me! I am the one who is ..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "She gestured to her belly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""Very well. I resend that order.""*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LucitaTitle = "Queen Consort and War and Sec..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LucitaTitle = "Queen Consort and War and Security Councilor";`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LucitaTitle"] ="Queen Consort and War and Security Councilor";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "When I entered the War Room, General Taddeus Azaro was in..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "When I entered the War Room, General Carlos Azaro was sta..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Lucita was sitting at the table with her arms crossed."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Lucita was sitting at the table with her arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "When I entered the War Room, General Carlos Azaro was standing next to the window looking out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "AddConversant("Carlos Robles Azaro");"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Taddeus Azaro: ""Your Majesty.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Carlos Robles Azaro: ""Your Majesty.""*)

### Węzeł `[182]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "Carlos saluted, his hand trembling slightly in my presence."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "The hollow look on his face suggested he hadn't slept. His eyes stayed fixed on the world beyond the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Ar..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucita Azaro: ""We have news from the frontline, Your Majesty.""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Carlos Robles Azaro: ""There's news from the frontline, Your Majesty.""*)

### Węzeł `[187]`
Mówca: **Carlos Robles Azaro**
> ""There's news from the frontline, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Carlos Robles Azaro: ""Pales still stands despite our attacks on their heartland.""*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Carlos Robles Azaro: ""The Palesian army has pushed us back from the border int..."*)

### Węzeł `[191]`
Mówca: **Carlos Robles Azaro**
> ""Pales still stands despite our attacks on their heartland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Carlos Robles Azaro: ""Once we exhausted our troops, they managed to push us ba..."*)

### Węzeł `[192]`
Mówca: **Carlos Robles Azaro**
> ""The Palesian army has pushed us back from the border into the Pales Administrative District.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Carlos Robles Azaro: ""We've lost Terador and Fort Ales. The frontline is broken.""*)

### Węzeł `[193]`
Mówca: **Carlos Robles Azaro**
> ""Once we exhausted our troops, they managed to push us back, retaking Arces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Carlos Robles Azaro: ""We are holding them at the frontline on an equal footing.""*)

### Węzeł `[194]`
Mówca: **Carlos Robles Azaro**
> ""We've lost Terador and Fort Ales. The frontline is broken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Carlos Robles Azaro: ""They do not seem to be currently advancing.""*)

### Węzeł `[195]`
Mówca: **Carlos Robles Azaro**
> ""We are holding them at the frontline on an equal footing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Carlos Robles Azaro: ""But our operation... has failed.""*)

### Węzeł `[196]`
Mówca: **Carlos Robles Azaro**
> ""They do not seem to be currently advancing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Carlos Robles Azaro: ""But our operation... has failed.""*)

### Węzeł `[197]`
Mówca: **Carlos Robles Azaro**
> ""But our operation... has failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "His words sank deep into my mind."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "His words sank deep into my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""No. I have failed. This burden is mine to bear.""*)
  - -> `[26]` (*Player_Romus: ""There is no one to blame. We must look to the future.""*)
  - -> `[200]` (*Player_Romus: ""If it weren't for the incompetency of the Azaro military..."*)
  - -> `[199]` (*Player_Romus: ""And where were *you* when we were losing this war, Gener..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And where were *you* when we were losing this war, General?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it weren't for the incompetency of the Azaro military command, we'd be celebrating our victory over Pales right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator), `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Taddeus Azaro: ""No, Your Majesty. It is all my fault. I'm the one whose ..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Carlos Robles Azaro: ""No, Your Majesty. It is all my fault. I will shoulder th..."*)

### Węzeł `[204]`
Mówca: **Carlos Robles Azaro**
> ""No, Your Majesty. It is all my fault. I will shoulder the blame, not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[205]`
Mówca: **Carlos Robles Azaro**
> ""Regardless, if I may, I suggest we discuss next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_ParliamentProposesPeace == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Taddeus Azaro: ""That's generous of you to say, Your Majesty. But we all ..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Carlos Robles Azaro: ""That's generous of you to say, Your Majesty. But we all ..."*)

### Węzeł `[209]`
Mówca: **Carlos Robles Azaro**
> ""That's generous of you to say, Your Majesty. But we all know this failure rests on my shoulders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Taddeus Azaro: ""Please don't blame my daughter, Your Majesty. This is en..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Carlos Robles Azaro: ""Please don't blame Lucita, Your Majesty. This is entirel..."*)

### Węzeł `[213]`
Mówca: **Carlos Robles Azaro**
> ""Please don't blame Lucita, Your Majesty. This is entirely on me, not her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Taddeus Azaro: ""I know, Your Majesty. It is all my fault.""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Carlos Robles Azaro: ""I know, Your Majesty. It is all my fault.""*)

### Węzeł `[217]`
Mówca: **Carlos Robles Azaro**
> ""I know, Your Majesty. It is all my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[218]`
Mówca: **Carlos Robles Azaro**
> ""I know, Your Majesty. This is entirely my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucita Azaro: ""With the current state of the war, no. But, times change..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Carlos Robles Azaro: ""Given the current state of the war, no. That said, the t..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Taddeus Azaro: ""Yes, however, our enemy might seize one for themselves.""*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Carlos Robles Azaro: ""Yes, however, our enemy might seize one for themselves.""*)

### Węzeł `[225]`
Mówca: **Carlos Robles Azaro**
> ""Given the current state of the war, no. That said, the tide of war can turn, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Carlos Robles Azaro: ""If we stay the course, an opportunity might present itse..."*)

### Węzeł `[226]`
Mówca: **Carlos Robles Azaro**
> ""If we stay the course, an opportunity might present itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[227]`
Mówca: **Carlos Robles Azaro**
> ""However, our enemy might seize one for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Carlos Robles Azaro: ""Either way, it's a risk.""*)

### Węzeł `[228]`
Mówca: **Carlos Robles Azaro**
> ""Either way, it's a risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucita Azaro: ""If we sue for peace, we will lose face in the eyes of th..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Carlos Robles Azaro: ""Hard to say. If we sue for peace, we stand to lose face ..."*)

### Węzeł `[232]`
Mówca: **Carlos Robles Azaro**
> ""Hard to say. If we sue for peace, we stand to lose face in the eyes of the world, rendering us crippled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[233]`
Mówca: **Carlos Robles Azaro**
> ""Prolonging the conflict might delay that, but our resources are limited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Carlos Robles Azaro: ""Which means Rizia would face the possibility of being dr..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Taddeus Azaro: ""I disagree. This war can bring down Rizia along with Pal..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Carlos Robles Azaro: ""Maybe for the short term, but our resources are not infi..."*)

### Węzeł `[237]`
Mówca: **Carlos Robles Azaro**
> ""Maybe for the short term, but our resources are not infinite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Carlos Robles Azaro: ""Which means Rizia would face the possibility of being dr..."*)

### Węzeł `[238]`
Mówca: **Carlos Robles Azaro**
> ""Yes, however, our enemy might seize one for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Carlos Robles Azaro: ""It is a risk, Your Majesty.""*)

### Węzeł `[239]`
Mówca: **Carlos Robles Azaro**
> ""It is a risk, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucita Azaro: ""Unless the situation changes drastically... potentially ..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Carlos Robles Azaro: ""Unless the situation changes drastically... potentially ..."*)

### Węzeł `[243]`
Mówca: **Carlos Robles Azaro**
> ""Unless the situation changes drastically... potentially years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Carlos Robles Azaro: ""At the end of the day, we have more resources than Pales..."*)

### Węzeł `[244]`
Mówca: **Carlos Robles Azaro**
> ""At the end of the day, we have more resources than Pales and would win a war of attrition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Taddeus Azaro: ""We would, yes. But at what cost?""*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Carlos Robles Azaro: ""Yes, but it would come at a cost.""*)

### Węzeł `[248]`
Mówca: **Carlos Robles Azaro**
> ""But it would come at a cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Taddeus Azaro: ""Yes, however, our enemy might seize one for themselves.""*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Carlos Robles Azaro: ""However, our enemy might seize one for themselves.""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Taddeus Azaro: ""I disagree. This war can bring down Rizia along with Pal..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Carlos Robles Azaro: ""Prolonging the conflict might delay that, but our resour..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Taddeus Azaro: ""We would, yes. But at what cost?""*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Carlos Robles Azaro: ""But it would come at a cost.""*)

### Węzeł `[258]`
Mówca: **Carlos Robles Azaro**
> ""Yes, but it would come at a cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Taddeus Azaro: ""Highly unlikely.""*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Carlos Robles Azaro: ""Unlikely.""*)

### Węzeł `[262]`
Mówca: **Carlos Robles Azaro**
> ""Unlikely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucita Azaro: ""But not impossible.""*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Carlos Robles Azaro: ""But not impossible.""*)

### Węzeł `[266]`
Mówca: **Carlos Robles Azaro**
> ""But not impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Carlos Robles Azaro: ""If they keep pushing into Montaklar, they will gain a fo..."*)

### Węzeł `[267]`
Mówca: **Carlos Robles Azaro**
> ""If they keep pushing into Montaklar, they will gain a foothold in Rizia's interior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucita Azaro: ""I knew you would, Your Majesty.""*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Carlos Robles Azaro: ""Very good, Your Majesty. I knew you would.""*)

### Węzeł `[271]`
Mówca: **Carlos Robles Azaro**
> ""Very good, Your Majesty. I knew you would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Carlos Robles Azaro: ""What have you decided?""*)

### Węzeł `[272]`
Mówca: **Carlos Robles Azaro**
> ""What have you decided?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""We will approach Pales to sue for peace. I do not wish a..."*)
  - -> `[77]` (*Player_Romus: ""We will continue fighting until the last drop of blood. ..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucita Azaro: ""Very well. Peace it is, Your Majesty.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Carlos Robles Azaro: ""As you wish, Your Majesty. Peace it shall be.""*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucita Azaro: ""A sound decision, Your Majesty.""*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Carlos Robles Azaro: ""As you wish, Your Majesty.""*)

### Węzeł `[279]`
Mówca: **Carlos Robles Azaro**
> ""As you wish, Your Majesty. Peace it shall be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "General Azaro looked outside the window again."*)

### Węzeł `[280]`
Mówca: **Carlos Robles Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "General Azaro looked outside the window again."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Taddeus Azaro: ""All my life, I was told I was meant for greatness.""*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Carlos Robles Azaro: ""All my life, I believed I was destined to serve a higher..."*)

### Węzeł `[284]`
Mówca: **Carlos Robles Azaro**
> ""All my life, I believed I was destined to serve a higher purpose -- that I was meant for greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Execu..."*)

### Węzeł `[285]`
Mówca: **Carlos Robles Azaro**
> ""Once again, presenting the same news that Taddeus Azaro delivered to your father so many years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Carlos Robles Azaro: ""I fear I will be remembered not for my achievements, but..."*)

### Węzeł `[286]`
Mówca: **Carlos Robles Azaro**
> ""I fear I will be remembered not for my achievements, but for my failures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""There is always hope. No matter how dire the situation is.""*)
  - -> `[11]` (*Player_Romus: ""I am sorry.""*)
  - -> `[9]` (*Player_Romus: ""Spare me your antics.""*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)

### Węzeł `[287]`
Mówca: **Carlos Robles Azaro**
> ""Yet here I am. Defeated in battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Carlos Robles Azaro: ""Once again, presenting the same news that Taddeus Azaro ..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Taddeus Azaro: ""I am sorry, Your Majesty.""*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "He cast his eyes down in shame."*)

### Węzeł `[291]`
Mówca: **Carlos Robles Azaro**
> ""I'm sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Carlos Robles Azaro: ""I'm sorry for failing you.""*)

### Węzeł `[292]`
Mówca: **Narrator**
> "He cast his eyes down in shame."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Carlos Robles Azaro: ""I'm sorry, Your Majesty.""*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Taddeus Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "He sat straighter."*)

### Węzeł `[296]`
Mówca: **Carlos Robles Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Carlos Robles Azaro: ""I'm sorry for failing you.""*)

### Węzeł `[297]`
Mówca: **Narrator**
> "He sat straighter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Carlos Robles Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[298]`
Mówca: **Carlos Robles Azaro**
> ""I'm sorry for failing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "He turned to Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Carlos Robles Azaro: ""And you as well, my cousin.""*)

### Węzeł `[300]`
Mówca: **Carlos Robles Azaro**
> ""And you as well, my cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "He faced me again and took a deep bow."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "He faced me again and took a deep bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Carlos Robles Azaro: ""My Liege. My King.""*)

### Węzeł `[302]`
Mówca: **Carlos Robles Azaro**
> ""Command me. What are your orders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[97]` (*Player_Romus: ""You will continue to serve the Crown as you have before.""*)

### Węzeł `[303]`
Mówca: **Carlos Robles Azaro**
> ""My Liege. My King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Carlos Robles Azaro: ""Command me. What are your orders?""*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "He turned to Lucita."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "He took a deep bow."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "He took a deep bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Carlos Robles Azaro: ""My Liege. My King.""*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "He turned to Lucita."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "He turned his wheelchair toward me, then, with visible ef..."*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Carlos Robles Azaro, you will leave your post immediately and relinquish all of your duties. I am de-ranking you to Colonel.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Taddeus Azaro), `[302]` (Carlos Robles Azaro), `[120]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Carlos_Deranked = true; RiziaDLCSupport.Journal_..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""Taddeus Azaro, you will leave your post immediately and ..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player_Romus: ""Carlos Robles Azaro, you will leave your post immediatel..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Carlos_Deranked = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedCarlos = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Carlos_Deranked"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedCarlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Carlos Robles Azaro: ""Yes, my King. I acknowledge my change in my rank.""*)

### Węzeł `[316]`
Mówca: **Carlos Robles Azaro**
> ""Yes, my King. I acknowledge my change in my rank.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "He stood to leave."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "She helped him back into his chair."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "He lowered himself back into his chair."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "He lowered himself back into his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Taddeus Azaro: ""Thank you for your time, Your Majesty.""*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "He bowed once more before my guards came in and wheeled h..."*)

### Węzeł `[324]`
Mówca: **Narrator**
> "He bowed once more before my guards came in and wheeled him out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "I was left all alone in the War Room."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Taddeus Azaro: ""Yes, my King. I thank you profusely for your forgiveness.""*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Carlos Robles Azaro: ""Yes, my King. I can't thank you enough for your forgiven..."*)

### Węzeł `[328]`
Mówca: **Carlos Robles Azaro**
> ""Yes, my King. I can't thank you enough for your forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "He stood to leave."*)

### Węzeł `[329]`
Mówca: **Carlos Robles Azaro**
> ""I am grateful for your time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "He bowed to me and left the room."*)

### Węzeł `[330]`
Mówca: **Narrator**
> "He stood to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Carlos Robles Azaro: ""I am grateful for your time, Your Majesty.""*)

### Węzeł `[331]`
Mówca: **Narrator**
> "He bowed to me and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "I was left all alone in the War Room."*)

### Węzeł `[332]`
Mówca: **Narrator**
> "He turned his wheelchair toward me, then, with visible effort, he struggled as he lifted himself out of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He knelt on the floor."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Final_Sentence_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[97]` (*Player_Romus: ""You will continue to serve the Crown as you have before.""*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Final_Sentence_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "Final_Sentence_Hub"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "Lucita stared at me in disbelief as she left."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "The door closed with a loud bang."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "My guards put the old man back in his wheelchair and took him out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "The door closed behind them with a loud bang."*)

### Węzeł `[339]`
Mówca: **Narrator**
> "The door closed behind them with a loud bang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested = true; RiziaDLC.Council_Securi..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Lucita's eyes widened in shock."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "My guards put the old man back in his wheelchair and took..."*)

### Węzeł `[343]`
Mówca: **Carlos Robles Azaro**
> ""Which means Rizia would face the possibility of being dragged down along with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [War Loss Next Steps]"*)

### Węzeł `[344]`
Mówca: **Narrator**
> "Carlos saluted, his hand trembling slightly in my presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Ar..."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "I gestured for him to join me at the table, and he promptly did."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "Lucita was sitting at the table with her arms crossed."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[349]`
Mówca: **Narrator**
> "Lucita was sitting at the table with her arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucita Azaro: ""Before we figure out who is to blame, I suggest we discu..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Carlos Robles Azaro: ""Regardless, if I may, I suggest we discuss next steps.""*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Taddeus Azaro: ""I know, Your Majesty. This is entirely my fault.""*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Carlos Robles Azaro: ""I know, Your Majesty. This is entirely my fault.""*)

### Węzeł `[357]`
Mówca: **Taddeus Azaro**
> ""I know, Your Majesty. This is entirely my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested = true;
RiziaDLC.Council_Security_Taddeus = false;
RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus = true; 
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
RiziaDLCSupport.News_Turn10_RH_TaddeusArrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLC.Council_Security_Taddeus"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus"] = true;
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
Variable["RiziaDLCSupport.News_Turn10_RH_TaddeusArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Faction_HouseAzaro_Taddeus = false; RiziaDLC.Fac..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Faction_HouseAzaro_Taddeus = false;
RiziaDLC.Faction_HouseAzaro_Carlos = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Faction_HouseAzaro_Taddeus"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Carlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "I was left all alone in the War Room."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested = true; RiziaDLC.Lucita_Arreste..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Taddeus Azaro: ""No. No!""*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""Taddeus Azaro. In light of your failures and incompetenc..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Execu..."*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Exe..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Carlos Robles Azaro: ""Yet here I am. The shameful last scion of a disgraced no..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Carlos Robles Azaro: ""Yet here I am. Defeated in battle.""*)

### Węzeł `[369]`
Mówca: **Carlos Robles Azaro**
> ""Yet here I am. The shameful last scion of a disgraced noble house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Carlos Robles Azaro: ""Once again, presenting the same news that Taddeus Azaro ..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseAzaro_Conquered == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Player_Romus: ""So you admit it. The vaunted House of Azaro is nothing b..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseAzaro_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""Clearly. Because you are weak.""*)

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you admit it. The vaunted House of Azaro is nothing but a bunch of weaklings who don't deserve the Crown's mercy.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[286]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_ParliamentProposesPeace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_ParliamentProposesPeace == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_ParliamentProposesPeace == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_ParliamentProposesPeace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_ParliamentProposesPeace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Lucita Azaro: ""The Prime Minister was rather irate that you vetoed the ..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_ParliamentProposesPeace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_ParliamentProposesPeace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true"*)

### Węzeł `[377]`
Mówca: **Lucita Azaro**
> ""The Prime Minister was rather irate that you vetoed the parliament's ceasefire bill. The government's now insisting we sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Lucita Azaro: ""But they didn't fight the war. We did. And you're the on..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true"*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Veto == true)"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Lucita Azaro: ""The Prime Minister and our new parliament have already e..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Veto == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[381]`
Mówca: **Lucita Azaro**
> ""The Prime Minister and our new parliament have already expressed their wish to sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Lucita Azaro: ""But they didn't fight the war. We did. And you're the on..."*)

### Węzeł `[382]`
Mówca: **Lucita Azaro**
> ""But they didn't fight the war. We did. And you're the one with the final say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "War Loss Next Steps"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_ParliamentProposesPeace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_ParliamentProposesPeace == true"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_ParliamentProposesPeace == true)"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_ParliamentProposesPeace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_ParliamentProposesPeace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Carlos Robles Azaro: ""The Prime Minister was rather irate that you vetoed the ..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_ParliamentProposesPeace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_ParliamentProposesPeace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true"*)

### Węzeł `[386]`
Mówca: **Carlos Robles Azaro**
> ""The Prime Minister was rather irate that you vetoed the parliament's ceasefire bill. The government wants us to sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Carlos Robles Azaro: ""But you're the one with the final say.""*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Veto == true)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Carlos Robles Azaro: ""The Prime Minister and our new parliament are urging us ..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Veto == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[390]`
Mówca: **Carlos Robles Azaro**
> ""The Prime Minister and our new parliament are urging us to sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Carlos Robles Azaro: ""But you're the one with the final say.""*)

### Węzeł `[391]`
Mówca: **Carlos Robles Azaro**
> ""But you're the one with the final say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "War Loss Next Steps"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "She made a face."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "War Loss Next Steps"*)

### Węzeł `[395]`
Mówca: **Lucita Azaro**
> ""Or, well... there's nothing to discuss, actually. The new government has already decided that we're suing for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Loss_SueForPeace = true; RiziaDLCSuppo..."*)

### Węzeł `[396]`
Mówca: **Narrator**
> "She made a face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Lucita Azaro: ""Or, well... there's nothing to discuss, actually. The ne..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Loss_SueForPeace = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Pales_Loss_SueForPeace"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Player_Romus: ""Dammit! We could've turned this around.""*)
  - -> `[403]` (*Player_Romus: ""So why even bother meeting with me?""*)
  - -> `[404]` (*Player_Romus: ""A reasonable decision. I have no qualms with it.""*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Carlos Robles Azaro: ""Ahem. Actually, there's nothing to discuss. The Prime Mi..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "War Loss Next Steps"*)

### Węzeł `[401]`
Mówca: **Carlos Robles Azaro**
> ""Ahem. Actually, there's nothing to discuss. The Prime Minister has already decided to sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Loss_SueForPeace = true; RiziaDLCSuppo..."*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dammit! We could've turned this around.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Lucita Azaro), `[401]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So why even bother meeting with me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Lucita Azaro), `[401]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reasonable decision. I have no qualms with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Lucita Azaro), `[401]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Lucita Azaro: ""I know.""*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Carlos Robles Azaro: ""We should have done so already. *I* should have.""*)

### Węzeł `[408]`
Mówca: **Lucita Azaro**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[409]`
Mówca: **Carlos Robles Azaro**
> ""We should have done so already. *I* should have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "General Azaro looked outside the window again."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Lucita Azaro: ""Our troops fought this war for you. You deserve to know ..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Carlos Robles Azaro: ""Our army fought this war for you. You deserve to know ho..."*)

### Węzeł `[414]`
Mówca: **Lucita Azaro**
> ""Our troops fought this war for you. You deserve to know how it ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[415]`
Mówca: **Carlos Robles Azaro**
> ""Our army fought this war for you. You deserve to know how it ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Losing the War against the Grand-Duchy of Pales", "Council Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Losing the War against the Grand-Duchy of Pales","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)
