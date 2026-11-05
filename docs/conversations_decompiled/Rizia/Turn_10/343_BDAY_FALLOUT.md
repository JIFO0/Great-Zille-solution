# Rizia/Turn 10/BDAY FALLOUT

- **ID konwersacji:** `343`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/343_BDAY_FALLOUT.md`
- **Liczba węzłów dialogowych:** 230
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[80]** Elena Werner
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_AssassinationOrdered`
- `RiziaDLC.Council_GrandVizier_Empty`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.CountryRelation_Morella_Allied`
- `RiziaDLC.CountryRelation_Wehlen_Allied`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseSazon_Conquered`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NatDes_Appease`
- `RiziaDLC.NatDes_Oppress`
- `RiziaDLC.Pales_Rizia_PreparationsUnification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PipelineNatDes_PipelineDontRepair`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Revolutionary_Pipeline_Sabotage`
- `RiziaDLC.Rusty_LoanAmount`
- `RiziaDLC.Situation_Economy_NewBusiness_Collapse`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Situation_Welfare_State_Strong`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Unrest_NatDes_Happened`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Resources_Budget`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[338] Rizia/Turn 10/CouncilMeeting** (../Turn_10/338_CouncilMeeting.md), Węzeł `[524]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""Come on, you two... it's just me.""** | `[6]` **Narrator**: "They both spoke in somewhat unna..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Laurento Esquibel**: ""Oh, I wasn't aware I was acting..." |
| `[8]` | **""I know the events of my mother's birthday seemed rather extreme. But trust me, it..."** | `[6]` **Narrator**: "They both spoke in somewhat unna..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Laurento Esquibel**: ""I do not doubt it, Your Majesty."" |
| `[9]` | **""Is something wrong, councilors?""** | `[6]` **Narrator**: "They both spoke in somewhat unna..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Elena Werner**: ""N-no, Your Majesty."" |
| `[10]` | **""Correct, Mr. Esquibel. The daffodils in the Palace gardens have already begun to ..."** | `[6]` **Narrator**: "They both spoke in somewhat unna..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Laurento Esquibel**: ""How lovely..."" |
| `[28]` | **""Remember that your own seat on this council is by no means guaranteed. Ms. Werner.""** | `[27]` **Elena Werner**: ""Fortunately, we're quite close ..."<br>`[71]` **Elena Werner**: ""Fortunately, we're quite close ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Elena Werner**: ""I have never once taken it for ..." |
| `[29]` | **""Despite their treachery, they were competent advisors. They leave big shoes to fi..."** | `[27]` **Elena Werner**: ""Fortunately, we're quite close ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Elena Werner**: ""Yes, I agree."" |
| `[30]` | **""It makes no difference in the end. *I* am the one making the decisions. You peopl..."** | `[27]` **Elena Werner**: ""Fortunately, we're quite close ..."<br>`[71]` **Elena Werner**: ""Fortunately, we're quite close ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Elena Werner**: ""Yes, we're... aware of that."" |
| `[31]` | **""There are still a few months to go. I trust you to help me run the country in the..."** | `[27]` **Elena Werner**: ""Fortunately, we're quite close ..."<br>`[71]` **Elena Werner**: ""Fortunately, we're quite close ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Elena Werner**: ""We'll do our best."" |
| `[72]` | **""My uncle was a competent advisor. He leaves big shoes to fill.""** | `[71]` **Elena Werner**: ""Fortunately, we're quite close ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Elena Werner**: ""Yes, I agree."" |
| `[75]` | **""Lucita was a competent advisor. She leaves big shoes to fill.""** | `[74]` **Elena Werner**: ""Fortunately, we're quite close ..." | `Variable["RiziaDLC.Council_Security_Lucita"] == true` | *Brak zmian stanu* | `[34]` **Elena Werner**: ""Yes, I agree."" |
| `[79]` | **""Taddeus was a competent advisor. He leaves big shoes to fill.""** | `[74]` **Elena Werner**: ""Fortunately, we're quite close ..." | `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false` | *Brak zmian stanu* | `[34]` **Elena Werner**: ""Yes, I agree."" |
| `[80]` | **""That was not the reason behind my actions. But I admit it's a nice bonus.""** | `[66]` **Elena Werner**: ""Naturally, the seizure of their..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Laurento Esquibel**: ""With regards to the ongoing war..."<br>`[93]` **Laurento Esquibel**: ""With regard to the ongoing Pale..."<br>*(oraz 1 innych odgałęzień)* |
| `[81]` | **""Perfect. I have big plans for that funding.""** | `[66]` **Elena Werner**: ""Naturally, the seizure of their..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Laurento Esquibel**: ""With regards to the ongoing war..."<br>`[93]` **Laurento Esquibel**: ""With regard to the ongoing Pale..."<br>*(oraz 1 innych odgałęzień)* |
| `[82]` | **""That money should go straight into the hands of the people.""** | `[66]` **Elena Werner**: ""Naturally, the seizure of their..." | `Variable["RiziaDLC.Situation_Welfare_State_Strong"] == true` | *Brak zmian stanu* | `[87]` **Laurento Esquibel**: ""With regards to the ongoing war..."<br>`[93]` **Laurento Esquibel**: ""With regard to the ongoing Pale..."<br>*(oraz 1 innych odgałęzień)* |
| `[86]` | **""Is that so? I should have done this a long time ago.""** | `[66]` **Elena Werner**: ""Naturally, the seizure of their..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Laurento Esquibel**: ""With regards to the ongoing war..."<br>`[93]` **Laurento Esquibel**: ""With regard to the ongoing Pale..."<br>*(oraz 1 innych odgałęzień)* |
| `[111]` | **""Splendid. Anything else I should know?""** | `[99]` **Laurento Esquibel**: ""Her Excellency Queen Beatrice, ..."<br>`[103]` **Laurento Esquibel**: ""President Wiktor Smolak, meanwh..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Elena Werner**: ""One other thing, Your Majesty.""<br>`[128]` **Elena Werner**: ""That will be it for now. I'm su..." |
| `[113]` | **""To be in charge of a nation sometimes requires one to make bold decisions. Our tr..."** | `[99]` **Laurento Esquibel**: ""Her Excellency Queen Beatrice, ..."<br>`[103]` **Laurento Esquibel**: ""President Wiktor Smolak, meanwh..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Laurento Esquibel**: ""Most certainly."" |
| `[114]` | **""The world must know that the King of Rizia is not to be messed with.""** | `[99]` **Laurento Esquibel**: ""Her Excellency Queen Beatrice, ..."<br>`[103]` **Laurento Esquibel**: ""President Wiktor Smolak, meanwh..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Laurento Esquibel**: ""I will try to communicate that."" |
| `[116]` | **""I don't want anyone to get the wrong idea. This was a defensive measure, not some..."** | `[99]` **Laurento Esquibel**: ""Her Excellency Queen Beatrice, ..."<br>`[103]` **Laurento Esquibel**: ""President Wiktor Smolak, meanwh..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Laurento Esquibel**: ""I will try to communicate that."" |
| `[163]` | **""Concerning news. But at least we're now in the position to begin working on our r..."** | `[150]` **Elena Werner**: ""And we remain in debt to Rizian..."<br>`[142]` **Elena Werner**: ""Our energy reserves are still r..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`<br>`(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false` | *Brak zmian stanu* | `[171]` **Laurento Esquibel**: ""And work we will, Your Majesty."" |
| `[164]` | **""With the anti-monarchists out of the way, our economy will soar even higher than ..."** | `[150]` **Elena Werner**: ""And we remain in debt to Rizian..."<br>`[142]` **Elena Werner**: ""Our energy reserves are still r..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`<br>`(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false` | *Brak zmian stanu* | `[169]` **Laurento Esquibel**: ""I have no doubt it will, Your M..." |
| `[165]` | **""We handled the unrest. We can handle Rusty.""** | `[150]` **Elena Werner**: ""And we remain in debt to Rizian..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Laurento Esquibel**: ""I am sure we can."" |
| `[166]` | **""There is still much work to be done. We've got to address the root cause of the u..."** | `[150]` **Elena Werner**: ""And we remain in debt to Rizian..."<br>`[142]` **Elena Werner**: ""Our energy reserves are still r..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false` | *Brak zmian stanu* | `[170]` **Laurento Esquibel**: ""Very prudent thinking, Your Maj..." |
| `[167]` | **""We should take some time to rest on our laurels. We defeated a revolution, after ..."** | `[150]` **Elena Werner**: ""And we remain in debt to Rizian..."<br>`[142]` **Elena Werner**: ""Our energy reserves are still r..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false` | *Brak zmian stanu* | `[168]` **Laurento Esquibel**: ""Indeed. No easy feat."" |
| `[173]` | **""God be praised!""** | `[126]` **Elena Werner**: ""It's our proud duty to tell you..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[190]` **Elena Werner**: ""Your decision not to resort to ..."<br>`[185]` **Elena Werner**: ""The ringleader -- Adarfo, was i..."<br>*(oraz 1 innych odgałęzień)* |
| `[177]` | **""What do you want, a medal? That's literally the least that I expect.""** | `[126]` **Elena Werner**: ""It's our proud duty to tell you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Elena Werner**: ""No medal necessary. Forgive me."" |
| `[179]` | **""Are you quite sure?""** | `[126]` **Elena Werner**: ""It's our proud duty to tell you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "She nodded." |
| `[181]` | **""One less thing to worry about.""** | `[126]` **Elena Werner**: ""It's our proud duty to tell you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "She nodded." |
| `[191]` | **""Thank you, Ms. Werner. And I'm sorry again about all the recent unpleasantness.""** | `[195]` **Narrator**: "She and Laurento stood up and bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Elena Werner**: ""It was for the greater good."" |
| `[192]` | **""Wait...""** | `[195]` **Narrator**: "She and Laurento stood up and bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Narrator**: "They both paused." |
| `[193]` | **""Yes, lots of work to be done. No thanks to my shrunken council.""** | `[195]` **Narrator**: "She and Laurento stood up and bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Narrator**: "I kept my eyes on my oldest and ..." |
| `[196]` | **""Let recent events be a lesson to you. Nobody goes against Romus Toras and lives.""** | `[194]` **Narrator**: "They both paused." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Narrator**: "Their faces both paled." |
| `[197]` | **""Good day to you both.""** | `[195]` **Narrator**: "She and Laurento stood up and bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Narrator**: "I kept my eyes on my oldest and ..." |
| `[198]` | **""You both served my father for years. Would he have been proud of what I did?""** | `[194]` **Narrator**: "They both paused." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "They both looked uncomfortable." |
| `[202]` | **""I lost my wife. My heir. I have no one.""** | `[194]` **Narrator**: "They both paused." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true` | *Brak zmian stanu* | `[208]` **Narrator**: "They both looked uncomfortable." |
| `[206]` | **""I lost my uncle. My closest advisor. I have no one.""** | `[194]` **Narrator**: "They both paused." | `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false` | *Brak zmian stanu* | `[208]` **Narrator**: "They both looked uncomfortable." |
| `[207]` | **""Nothing. You're both dismissed.""** | `[194]` **Narrator**: "They both paused." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Narrator**: "I kept my eyes on my oldest and ..." |
| `[229]` | **""Still, something is better than nothing. We’ll take what we can get.""** | `[66]` **Elena Werner**: ""Naturally, the seizure of their..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Laurento Esquibel**: ""With regards to the ongoing war..."<br>`[93]` **Laurento Esquibel**: ""With regard to the ongoing Pale..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[3]` (*Narrator: "I sat at the long table in my council chambers, facing El..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I sat at the long table in my council chambers, facing Elena and Laurento."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Elena Werner: ""I hope you are well today, Your Majesty.""*)

### Węzeł `[4]`
Mówca: **Elena Werner**
> ""I hope you are well today, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Laurento Esquibel: ""Indeed... We seem to be having a cold spell of late. But..."*)

### Węzeł `[5]`
Mówca: **Laurento Esquibel**
> ""Indeed... We seem to be having a cold spell of late. But I am certain spring is just around the corner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "They both spoke in somewhat unnatural tones. I saw flashe..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "They both spoke in somewhat unnatural tones. I saw flashes of fear in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""Come on, you two... it's just me.""*)
  - -> `[8]` (*Player_Romus: ""I know the events of my mother's birthday seemed rather ..."*)
  - -> `[9]` (*Player_Romus: ""Is something wrong, councilors?""*)
  - -> `[10]` (*Player_Romus: ""Correct, Mr. Esquibel. The daffodils in the Palace garde..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, you two... it's just me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Laurento Esquibel: ""Oh, I wasn't aware I was acting out of the ordinary. Ple..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the events of my mother's birthday seemed rather extreme. But trust me, it had to be done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Laurento Esquibel: ""I do not doubt it, Your Majesty.""*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is something wrong, councilors?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Elena Werner: ""N-no, Your Majesty.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Correct, Mr. Esquibel. The daffodils in the Palace gardens have already begun to bloom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Laurento Esquibel: ""How lovely...""*)

### Węzeł `[11]`
Mówca: **Elena Werner**
> ""N-no, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Laurento Esquibel: ""Not at all.""*)

### Węzeł `[12]`
Mówca: **Laurento Esquibel**
> ""Not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "They glanced at each other."*)

### Węzeł `[13]`
Mówca: **Laurento Esquibel**
> ""I do not doubt it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Elena Werner: ""Such actions are sometimes necessary for the health of t..."*)

### Węzeł `[14]`
Mówca: **Laurento Esquibel**
> ""Oh, I wasn't aware I was acting out of the ordinary. Please accept my apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Elena Werner: ""And mine, Your Majesty.""*)

### Węzeł `[15]`
Mówca: **Laurento Esquibel**
> ""How lovely...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "They glanced at each other."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone == true || RiziaDLC.Council_GrandVizier_Empty == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorG..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilo..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone == true || RiziaDLC.Council_GrandVizier_Empty == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Empty"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone == true || RiziaDLC.Council_GrandVizier_Empty == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Empty"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorG..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "They glanced at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorG..."*)

### Węzeł `[20]`
Mówca: **Elena Werner**
> ""Such actions are sometimes necessary for the health of the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "They glanced at each other."*)

### Węzeł `[21]`
Mówca: **Elena Werner**
> ""And mine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "They glanced at each other."*)

### Węzeł `[22]`
Mówca: **Laurento Esquibel**
> ""With the... departure of our Grand Vizier and Duchess Azaro, there are now two spots on the council that need filling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Elena Werner: ""Fortunately, we're quite close to the Hearing of Petitio..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Laurento Esquibel: ""With the... departure of our Grand Vizier and Duchess Az..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Laurento Esquibel: ""With the... departure of our Grand Vizier and General Az..."*)

### Węzeł `[26]`
Mówca: **Laurento Esquibel**
> ""With the... departure of our Grand Vizier and General Azaro, there are now two spots on the council that need filling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Elena Werner: ""Fortunately, we're quite close to the Hearing of Petitio..."*)

### Węzeł `[27]`
Mówca: **Elena Werner**
> ""Fortunately, we're quite close to the Hearing of Petitions. I'm sure you'll be able to find suitable candidates to fill both seats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""Remember that your own seat on this council is by no mea..."*)
  - -> `[29]` (*Player_Romus: ""Despite their treachery, they were competent advisors. T..."*)
  - -> `[30]` (*Player_Romus: ""It makes no difference in the end. *I* am the one making..."*)
  - -> `[31]` (*Player_Romus: ""There are still a few months to go. I trust you to help ..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember that your own seat on this council is by no means guaranteed. Ms. Werner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Elena Werner), `[71]` (Elena Werner), `[74]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Elena Werner: ""I have never once taken it for granted.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite their treachery, they were competent advisors. They leave big shoes to fill.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Elena Werner: ""Yes, I agree.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It makes no difference in the end. *I* am the one making the decisions. You people are nothing but leeches.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Elena Werner), `[71]` (Elena Werner), `[74]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Elena Werner: ""Yes, we're... aware of that.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are still a few months to go. I trust you to help me run the country in the meantime.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Elena Werner), `[71]` (Elena Werner), `[74]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Elena Werner: ""We'll do our best.""*)

### Węzeł `[32]`
Mówca: **Elena Werner**
> ""We'll do our best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Laurento checked his notes."*)

### Węzeł `[33]`
Mówca: **Elena Werner**
> ""Yes, we're... aware of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Laurento checked his notes."*)

### Węzeł `[34]`
Mówca: **Elena Werner**
> ""Yes, I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Laurento checked his notes."*)

### Węzeł `[35]`
Mówca: **Elena Werner**
> ""I have never once taken it for granted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Laurento checked his notes."*)

### Węzeł `[36]`
Mówca: **Laurento Esquibel**
> ""Both Azaro generals are committed to seeing it through, despite the fate of their House and Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_Cou..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_C..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Laurento Esquibel: ""With regards to the ongoing war in Pales...""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_PreparationsUnification == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Laurento Esquibel: ""Both Azaro generals are committed to seeing it through, ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Laurento Esquibel: ""General Carlos Robles Azaro is committed to seeing it th..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Laurento checked his notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[44]`
Mówca: **Laurento Esquibel**
> ""It appears the transfer of all three provinces to Crown control is well underway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseSazon_Conquered == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Laurento Esquibel: ""It appears the transfer of all three provinces to Crown ..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseSazon_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Laurento Esquibel: ""It appears the transfer of Valenqiris and Cardesse-Monta..."*)

### Węzeł `[51]`
Mówca: **Laurento Esquibel**
> ""It appears the transfer of Valenqiris and Cardesse-Montaklar to Crown control is well underway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[52]`
Mówca: **Laurento Esquibel**
> ""It appears the transfer of Cardesse-Montaklar to Crown control is well underway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Laurento Esquibel: ""All Azaros have been vacated from their estates.""*)

### Węzeł `[53]`
Mówca: **Laurento Esquibel**
> ""The Crown Princess continues to reside in Palas Toras in Monqiz. All other members of the noble houses in question have been vacated from their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Elena Werner: ""They shall live as commoners, with no special privileges..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Laurento Esquibel: ""The Crown Princess continues to reside in Palas Toras in..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Laurento Esquibel: ""All members of the noble houses in question, including y..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseSazon_Conquered == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Laurento Esquibel: ""It appears the transfer of Cardesse-Montaklar and Brenas..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseSazon_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Laurento Esquibel: ""It appears the transfer of Cardesse-Montaklar to Crown c..."*)

### Węzeł `[60]`
Mówca: **Laurento Esquibel**
> ""It appears the transfer of Cardesse-Montaklar and Brenas to Crown control is well underway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Laurento Esquibel: ""All members of the noble houses in question have been va..."*)

### Węzeł `[61]`
Mówca: **Laurento Esquibel**
> ""All members of the noble houses in question have been vacated from their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Elena Werner: ""They shall live as commoners, with no special privileges..."*)

### Węzeł `[62]`
Mówca: **Laurento Esquibel**
> ""All Azaros have been vacated from their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Elena Werner: ""They shall live as commoners, with no special privileges..."*)

### Węzeł `[63]`
Mówca: **Laurento Esquibel**
> ""All members of the noble houses in question, including your cousin Hubertus, have been vacated from their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Elena Werner: ""They shall live as commoners, with no special privileges..."*)

### Węzeł `[64]`
Mówca: **Elena Werner**
> ""They shall live as commoners, with no special privileges or entitlements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "She allowed herself a small, grim smile."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "She allowed herself a small, grim smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Elena Werner: ""Naturally, the seizure of their estates will bring a sub..."*)

### Węzeł `[66]`
Mówca: **Elena Werner**
> ""Naturally, the seizure of their estates will bring a substantial boost to our treasury. Some of their assets, however, were held offshore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""Still, something is better than nothing. We’ll take what..."*)
  - -> `[80]` (*Player_Romus: ""That was not the reason behind my actions. But I admit i..."*)
  - -> `[81]` (*Player_Romus: ""Perfect. I have big plans for that funding.""*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_State_Strong == true"*)
  - -> `[86]` (*Player_Romus: ""Is that so? I should have done this a long time ago.""*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorG..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilo..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Laurento Esquibel: ""With the... departure of your uncle from the council, th..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Laurento Esquibel: ""With the... departure of our security councilor, there i..."*)

### Węzeł `[70]`
Mówca: **Laurento Esquibel**
> ""With the... departure of your uncle from the council, the Grand Vizier seat will need filling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Elena Werner: ""Fortunately, we're quite close to the Hearing of Petitio..."*)

### Węzeł `[71]`
Mówca: **Elena Werner**
> ""Fortunately, we're quite close to the Hearing of Petitions. I'm sure you'll be able to find a suitable candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""Remember that your own seat on this council is by no mea..."*)
  - -> `[30]` (*Player_Romus: ""It makes no difference in the end. *I* am the one making..."*)
  - -> `[31]` (*Player_Romus: ""There are still a few months to go. I trust you to help ..."*)
  - -> `[72]` (*Player_Romus: ""My uncle was a competent advisor. He leaves big shoes to..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My uncle was a competent advisor. He leaves big shoes to fill.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Elena Werner: ""Yes, I agree.""*)

### Węzeł `[73]`
Mówca: **Laurento Esquibel**
> ""With the... departure of our security councilor, there is a seat at this table that needs filling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Elena Werner: ""Fortunately, we're quite close to the Hearing of Petitio..."*)

### Węzeł `[74]`
Mówca: **Elena Werner**
> ""Fortunately, we're quite close to the Hearing of Petitions. I'm sure you'll be able to find a suitable candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""Remember that your own seat on this council is by no mea..."*)
  - -> `[30]` (*Player_Romus: ""It makes no difference in the end. *I* am the one making..."*)
  - -> `[31]` (*Player_Romus: ""There are still a few months to go. I trust you to help ..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita was a competent advisor. She leaves big shoes to fill.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[74]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Elena Werner: ""Yes, I agree.""*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""Lucita was a competent advisor. She leaves big shoes to ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: ""Taddeus was a competent advisor. He leaves big shoes to ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taddeus was a competent advisor. He leaves big shoes to fill.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[74]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Elena Werner: ""Yes, I agree.""*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was not the reason behind my actions. But I admit it's a nice bonus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_Cou..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. I have big plans for that funding.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_Cou..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That money should go straight into the hands of the people.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Welfare_State_Strong"] == true`
- **Kontekst wejściowy (poprzednik):** `[66]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_Cou..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_State_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_State_Strong == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_State_Strong == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_State_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_State_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""That money should go straight into the hands of the peop..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_State_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_State_Strong"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that so? I should have done this a long time ago.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_Cou..."*)

### Węzeł `[87]`
Mówca: **Laurento Esquibel**
> ""With regards to the ongoing war in Pales...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[88]`
Mówca: **Laurento Esquibel**
> ""General Carlos Robles Azaro is committed to seeing it through, despite the fate of his relatives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Laurento Esquibel: ""With luck, they should finally be able to bring the Prin..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[92]`
Mówca: **Laurento Esquibel**
> ""With luck, they should finally be able to bring the Princess home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[93]`
Mówca: **Laurento Esquibel**
> ""With regard to the ongoing Pales reunification talks...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Laurento Esquibel: ""Duke Reinhart has shown a willingness to continue the pr..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_PreparationsUnification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_PreparationsUnification == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_PreparationsUnification == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_PreparationsUnification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_PreparationsUnification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Laurento Esquibel: ""With regard to the ongoing Pales reunification talks...""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_PreparationsUnification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_PreparationsUnification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[97]`
Mówca: **Laurento Esquibel**
> ""Duke Reinhart has shown a willingness to continue the process. But he does warn that your 'lack of respect for Rizia's provincial autonomy' has given him pause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Laurento Esquibel: ""His words, not mine.""*)

### Węzeł `[98]`
Mówca: **Laurento Esquibel**
> ""His words, not mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[99]`
Mówca: **Laurento Esquibel**
> ""Her Excellency Queen Beatrice, meanwhile, has sent us a telegram praising your show of dominance over Rizia's wayward nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""Splendid. Anything else I should know?""*)
  - -> `[113]` (*Player_Romus: ""To be in charge of a nation sometimes requires one to ma..."*)
  - -> `[114]` (*Player_Romus: ""The world must know that the King of Rizia is not to be ..."*)
  - -> `[116]` (*Player_Romus: ""I don't want anyone to get the wrong idea. This was a de..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Laurento Esquibel: ""Her Excellency Queen Beatrice, meanwhile, has sent us a ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Wehlen_Allied == true"*)

### Węzeł `[103]`
Mówca: **Laurento Esquibel**
> ""President Wiktor Smolak, meanwhile, has sent us a telegram praising your show of dominance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""Splendid. Anything else I should know?""*)
  - -> `[113]` (*Player_Romus: ""To be in charge of a nation sometimes requires one to ma..."*)
  - -> `[114]` (*Player_Romus: ""The world must know that the King of Rizia is not to be ..."*)
  - -> `[116]` (*Player_Romus: ""I don't want anyone to get the wrong idea. This was a de..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Wehlen_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Wehlen_Allied == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Wehlen_Allied == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Wehlen_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Wehlen_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Laurento Esquibel: ""President Wiktor Smolak, meanwhile, has sent us a telegr..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Wehlen_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Wehlen_Allied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Morella_Allied == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Morella_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Morella_Allied == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Morella_Allied == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Morella_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Morella_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Laurento Esquibel: ""Prime Minister Saltana of Morella has notified us that w..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Morella_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Morella_Allied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Laurento Esquibel: ""Fortunately, international blowback over the... incident..."*)

### Węzeł `[110]`
Mówca: **Laurento Esquibel**
> ""Prime Minister Saltana of Morella has notified us that while she is not against the expropriation of noble estates in principle, she does question the method by which we have done so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""Splendid. Anything else I should know?""*)
  - -> `[113]` (*Player_Romus: ""To be in charge of a nation sometimes requires one to ma..."*)
  - -> `[116]` (*Player_Romus: ""I don't want anyone to get the wrong idea. This was a de..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Splendid. Anything else I should know?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Laurento Esquibel), `[103]` (Laurento Esquibel), `[110]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)

### Węzeł `[112]`
Mówca: **Laurento Esquibel**
> ""Fortunately, international blowback over the... incident... has been minimal. Especially since few specifics have been leaked to the world at large.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""Splendid. Anything else I should know?""*)
  - -> `[113]` (*Player_Romus: ""To be in charge of a nation sometimes requires one to ma..."*)
  - -> `[114]` (*Player_Romus: ""The world must know that the King of Rizia is not to be ..."*)
  - -> `[116]` (*Player_Romus: ""I don't want anyone to get the wrong idea. This was a de..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be in charge of a nation sometimes requires one to make bold decisions. Our trade partners know that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Laurento Esquibel), `[103]` (Laurento Esquibel), `[110]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Laurento Esquibel: ""Most certainly.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The world must know that the King of Rizia is not to be messed with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Laurento Esquibel), `[103]` (Laurento Esquibel), `[112]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Laurento Esquibel: ""I will try to communicate that.""*)

### Węzeł `[115]`
Mówca: **Elena Werner**
> ""One other thing, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorG..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want anyone to get the wrong idea. This was a defensive measure, not some sort of power grab.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Laurento Esquibel), `[103]` (Laurento Esquibel), `[110]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Laurento Esquibel: ""I will try to communicate that.""*)

### Węzeł `[117]`
Mówca: **Laurento Esquibel**
> ""I will try to communicate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)

### Węzeł `[118]`
Mówca: **Laurento Esquibel**
> ""Most certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_NatDes_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Unrest_NatDes_Happened == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_NatDes_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Elena Werner: ""One other thing, Your Majesty.""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Unrest_NatDes_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Elena Werner: ""That will be it for now. I'm sure you have a lot of work..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorG..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilo..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Elena Werner: ""This doesn't fall under either of our purview, but with ..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Elena Werner: ""You'll hear more about this from your security councilor..."*)

### Węzeł `[125]`
Mówca: **Elena Werner**
> ""This doesn't fall under either of our purview, but with the security councilor indisposed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Elena Werner: ""It's our proud duty to tell you that the unrest that has..."*)

### Węzeł `[126]`
Mówca: **Elena Werner**
> ""It's our proud duty to tell you that the unrest that has plagued Rizia for so long has come to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[181]` (*Player_Romus: ""One less thing to worry about.""*)
  - -> `[179]` (*Player_Romus: ""Are you quite sure?""*)
  - -> `[177]` (*Player_Romus: ""What do you want, a medal? That's literally the least th..."*)

### Węzeł `[127]`
Mówca: **Elena Werner**
> ""You'll hear more about this from your security councilor, but for now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Elena Werner: ""It's our proud duty to tell you that the unrest that has..."*)

### Węzeł `[128]`
Mówca: **Elena Werner**
> ""That will be it for now. I'm sure you have a lot of work to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "She and Laurento stood up and bowed."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Elena Werner: ""The concessions we were forced to make to the protesters..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Elena Werner: ""Miraculously, the concessions we were forced to make to ..."*)

### Węzeł `[132]`
Mówca: **Elena Werner**
> ""The concessions we were forced to make to the protesters did negatively impact our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Appease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Appease == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Appease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Appease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Appease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Appease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Elena Werner: ""The upheaval we experienced did negatively impact our ec..."*)
  - -> `[138]` (*Elena Werner: ""Miraculously, the upheaval we experienced barely dented ..."*)

### Węzeł `[136]`
Mówca: **Elena Werner**
> ""Miraculously, the concessions we were forced to make to the protesters barely dented our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)

### Węzeł `[137]`
Mówca: **Elena Werner**
> ""The upheaval we experienced did negatively impact our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)

### Węzeł `[138]`
Mówca: **Elena Werner**
> ""Miraculously, the upheaval we experienced barely dented our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Revolutionary_Pipeline_Sabotage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Revolutionary_Pipeline_Sabotage == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Revolutionary_Pipeline_Sabotage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_PipelineDontRepair == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Revolutionary_Pipeline_Sabotage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 10"*)

### Węzeł `[142]`
Mówca: **Elena Werner**
> ""Our energy reserves are still recovering from the sabotage incident. It may take some time before we're at our former capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_PipelineDontRepair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_PipelineDontRepair == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_PipelineDontRepair == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_PipelineDontRepair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_PipelineDontRepair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Elena Werner: ""Our energy reserves are still recovering from the sabota..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_PipelineDontRepair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_PipelineDontRepair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Elena Werner: ""Thanks to your quick actions after the sabotage incident..."*)

### Węzeł `[146]`
Mówca: **Elena Werner**
> ""Thanks to your quick actions after the sabotage incident, our energy reserves are on track to reach their former capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 10"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy > 10)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Elena Werner: ""Our robust energy reserves will undoubtedly help us weat..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy > 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 5"*)

### Węzeł `[150]`
Mówca: **Elena Werner**
> ""And we remain in debt to Rizian Royal Gold. I hope it isn't too late for that to be squared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""We handled the unrest. We can handle Rusty.""*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)
  - -> `[166]` (*Player_Romus: ""There is still much work to be done. We've got to addres..."*)
  - -> `[167]` (*Player_Romus: ""We should take some time to rest on our laurels. We defe..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_LoanAmount > 0)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Elena Werner: ""And we remain in debt to Rizian Royal Gold. I hope it is..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_LoanAmount > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)
  - -> `[166]` (*Player_Romus: ""There is still much work to be done. We've got to addres..."*)
  - -> `[167]` (*Player_Romus: ""We should take some time to rest on our laurels. We defe..."*)

### Węzeł `[154]`
Mówca: **Elena Werner**
> ""Our robust energy reserves will undoubtedly help us weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 5"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy > 5)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Elena Werner: ""Thankfully, we have adequate energy reserves to weather ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Elena Werner: ""I am concerned that our energy reserves are insufficient..."*)

### Węzeł `[158]`
Mówca: **Elena Werner**
> ""Thankfully, we have adequate energy reserves to weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[159]`
Mówca: **Elena Werner**
> ""I am concerned that our energy reserves are insufficient to weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""Concerning news. But at least we're now in the position ..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""With the anti-monarchists out of the way, our economy wi..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Concerning news. But at least we're now in the position to begin working on our recovery.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true` AND `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[150]` (Elena Werner), `[142]` (Elena Werner), `[146]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Laurento Esquibel: ""And work we will, Your Majesty.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the anti-monarchists out of the way, our economy will soar even higher than before.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false` AND `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[150]` (Elena Werner), `[142]` (Elena Werner), `[146]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Laurento Esquibel: ""I have no doubt it will, Your Majesty.""*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We handled the unrest. We can handle Rusty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Laurento Esquibel: ""I am sure we can.""*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is still much work to be done. We've got to address the root cause of the uprising, not just recover from it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[150]` (Elena Werner), `[142]` (Elena Werner), `[146]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Laurento Esquibel: ""Very prudent thinking, Your Majesty.""*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should take some time to rest on our laurels. We defeated a revolution, after all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[150]` (Elena Werner), `[142]` (Elena Werner), `[146]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Laurento Esquibel: ""Indeed. No easy feat.""*)

### Węzeł `[168]`
Mówca: **Laurento Esquibel**
> ""Indeed. No easy feat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Elena Werner: ""That will be it for now. I'm sure you have a lot of work..."*)

### Węzeł `[169]`
Mówca: **Laurento Esquibel**
> ""I have no doubt it will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Elena Werner: ""That will be it for now. I'm sure you have a lot of work..."*)

### Węzeł `[170]`
Mówca: **Laurento Esquibel**
> ""Very prudent thinking, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Elena Werner: ""That will be it for now. I'm sure you have a lot of work..."*)

### Węzeł `[171]`
Mówca: **Laurento Esquibel**
> ""And work we will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Elena Werner: ""That will be it for now. I'm sure you have a lot of work..."*)

### Węzeł `[172]`
Mówca: **Laurento Esquibel**
> ""I am sure we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Elena Werner: ""That will be it for now. I'm sure you have a lot of work..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God be praised!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[126]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus: ""God be praised!""*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want, a medal? That's literally the least that I expect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Elena Werner: ""No medal necessary. Forgive me.""*)

### Węzeł `[178]`
Mówca: **Elena Werner**
> ""No medal necessary. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you quite sure?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "She nodded."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One less thing to worry about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "She nodded."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Oppress == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Oppress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Elena Werner: ""Your decision not to resort to harsh measures has appare..."*)

### Węzeł `[185]`
Mówca: **Elena Werner**
> ""The ringleader -- Adarfo, was it? -- now sits in the Porte Drazon Citadel, awaiting your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested = true;"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC.Adarfo_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaD..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC.Adarfo_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false  and  Variable["RiziaDLC.Adarfo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Elena Werner: ""The ringleader -- Adarfo, was it? -- now sits in the Por..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC.Adarfo_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false  and  Variable["RiziaDLC.Adarfo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Elena Werner: ""The ringleaders have all been arrested, and the movement..."*)

### Węzeł `[189]`
Mówca: **Elena Werner**
> ""The ringleaders have all been arrested, and the movement has scattered to the winds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[190]`
Mówca: **Elena Werner**
> ""Your decision not to resort to harsh measures has apparently paid off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Ms. Werner. And I'm sorry again about all the recent unpleasantness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Elena Werner: ""It was for the greater good.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "They both paused."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, lots of work to be done. No thanks to my shrunken council.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I kept my eyes on my oldest and most loyal councilors as ..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "They both paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player_Romus: ""Nothing. You're both dismissed.""*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Turn1..."*)
  - -> `[198]` (*Player_Romus: ""You both served my father for years. Would he have been ..."*)
  - -> `[196]` (*Player_Romus: ""Let recent events be a lesson to you. Nobody goes agains..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "She and Laurento stood up and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player_Romus: ""Thank you, Ms. Werner. And I'm sorry again about all the..."*)
  - -> `[197]` (*Player_Romus: ""Good day to you both.""*)
  - -> `[193]` (*Player_Romus: ""Yes, lots of work to be done. No thanks to my shrunken c..."*)
  - -> `[192]` (*Player_Romus: ""Wait...""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let recent events be a lesson to you. Nobody goes against Romus Toras and lives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Their faces both paled."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good day to you both.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I kept my eyes on my oldest and most loyal councilors as ..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You both served my father for years. Would he have been proud of what I did?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "They both looked uncomfortable."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Turn1..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Tur..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""I lost my wife. My heir. I have no one.""*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed ..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I lost my wife. My heir. I have no one.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "They both looked uncomfortable."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed ..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Execute..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""I lost my uncle. My closest advisor. I have no one.""*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I lost my uncle. My closest advisor. I have no one.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "They both looked uncomfortable."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing. You're both dismissed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I kept my eyes on my oldest and most loyal councilors as ..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "They both looked uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Laurento Esquibel: ""I am sorry, Your Majesty. This cannot be easy for you.""*)

### Węzeł `[209]`
Mówca: **Laurento Esquibel**
> ""I am sorry, Your Majesty. This cannot be easy for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I kept my eyes on my oldest and most loyal councilors as ..."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "They both looked uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Laurento Esquibel: ""He would have understood, Your Majesty. Reigning is not ..."*)

### Węzeł `[211]`
Mówca: **Laurento Esquibel**
> ""He would have understood, Your Majesty. Reigning is not easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I kept my eyes on my oldest and most loyal councilors as ..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Their faces both paled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Laurento Esquibel: ""Understood, Your Majesty. We would never dream of doing ..."*)

### Węzeł `[213]`
Mówca: **Laurento Esquibel**
> ""Understood, Your Majesty. We would never dream of doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I kept my eyes on my oldest and most loyal councilors as ..."*)

### Węzeł `[214]`
Mówca: **Elena Werner**
> ""It was for the greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I kept my eyes on my oldest and most loyal councilors as ..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "I kept my eyes on my oldest and most loyal councilors as they departed my chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseAzaro_Conquered == true)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget += 5;"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseAzaro_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseSazon_Conquered == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget += 3;"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseSazon_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget += 4;"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget += 5;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget += 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, something is better than nothing. We’ll take what we can get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_Cou..."*)
