# Rizia/Turn 8/SnO_War_Pales_PostOperation1

- **ID konwersacji:** `410`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/410_SnO_War_Pales_PostOperation1.md`
- **Liczba węzłów dialogowych:** 312
- **Liczba wyborów gracza:** 40

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
- `RiziaDLC.Policy_RD_Order_LowerConscriptionAge`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Average`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_WrongIntel`
- `RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success`
- `RiziaDLC.War_AttackPlan_BlockadePales_Success`
- `RiziaDLC.War_AttackPlan_BlockadeRemaz_Success`
- `RiziaDLC.War_Control_Skipped`
- `RiziaDLC.War_Operation1Briefing_Frontline`
- `RiziaDLC.War_Pales_LespianSupport`
- `RiziaDLC.War_Pales_Operation1_Won`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Army_Unit_Azaro_Total`
- `RiziaDLC.Army_Unit_Flagship_Total`
- `RiziaDLC.Army_Unit_GoldenGuard_Total`
- `RiziaDLC.Army_Unit_Infantry_Total`
- `RiziaDLC.Army_Unit_Marine_Total`
- `RiziaDLC.Army_Unit_Mercenary_Total`
- `RiziaDLC.Army_Unit_Mountaineer_Total`
- `RiziaDLC.Army_Unit_Paratrooper_Total`
- `RiziaDLC.Army_Unit_Sazon_Total`
- `RiziaDLC.Army_Unit_Ship_Total`
- `RiziaDLC.Army_Unit_Submarine_Total`
- `RiziaDLC.Army_Unit_Support_Total`
- `RiziaDLC.Army_Unit_Tank_Total`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Turn08_PalesWarPostOp_DisgracedSorry`
- `RiziaDLC.Turn08_PalesWarPostOp_DismissedAzaro`
- `RiziaDLC.War_Control_Skipped_Azaro`
- `RiziaDLC.War_Control_Skipped_Flagship`
- `RiziaDLC.War_Control_Skipped_GoldenGuard`
- `RiziaDLC.War_Control_Skipped_Infantry`
- `RiziaDLC.War_Control_Skipped_Marine`
- `RiziaDLC.War_Control_Skipped_Mercenary`
- `RiziaDLC.War_Control_Skipped_Mountaineer`
- `RiziaDLC.War_Control_Skipped_Paratrooper`
- `RiziaDLC.War_Control_Skipped_Sazon`
- `RiziaDLC.War_Control_Skipped_Ship`
- `RiziaDLC.War_Control_Skipped_Submarine`
- `RiziaDLC.War_Control_Skipped_Support`
- `RiziaDLC.War_Control_Skipped_Tank`
- `RiziaDLC.War_Objective_Captured_Arces`
- `RiziaDLC.War_Objective_Captured_FortAles`
- `RiziaDLC.War_Objective_Captured_Terador`
- `RiziaDLC.War_Objective_Captured_Ziqes`
- `RiziaDLC.War_Operation1_TotalEnemy_Dead`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Default`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_NoBlockade`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_NoBlockade`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong`

### Skoki między-konwersacyjne:
- Węzeł `[59]` -> **[411] Rizia/Turn 8/Operation 1 Results** (../Turn_08/411_Operation_1_Results.md), Węzeł `[1]`
- Węzeł `[134]` -> **[411] Rizia/Turn 8/Operation 1 Results** (../Turn_08/411_Operation_1_Results.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[22]` | **""It is a pleasure to be here. I've been wanting to see the front lines with my own..."** | `[39]` **Narrator**: "After saluting, I shook hands wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Taddeus Azaro**: ""I'm glad to hear it, Your Majes..." |
| `[23]` | **""Skip the pleasantries, General Azaro. We have much to discuss.""** | `[39]` **Narrator**: "After saluting, I shook hands wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Taddeus Azaro**: ""Everything will be discussed, a..." |
| `[25]` | **""I would much rather be in Porte Drazon right now. I hope this meeting is worth my..."** | `[39]` **Narrator**: "After saluting, I shook hands wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Taddeus Azaro**: ""It will be, Your Majesty."" |
| `[28]` | **""I do hope that you did not put your King in danger by forcing me to come here.""** | `[39]` **Narrator**: "After saluting, I shook hands wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Taddeus Azaro**: ""We have taken every precaution,..." |
| `[35]` | **""I will dine together with the soldiers in the barracks.""** | `[41]` **Narrator**: "I wasn't sure if it was my imagi..."<br>`[225]` **Narrator**: "I wasn't sure if it was my imagi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "Carlos nodded in assent and led ..." |
| `[36]` | **""Invite this soldier to dine with us, General.""** | `[41]` **Narrator**: "I wasn't sure if it was my imagi..."<br>`[225]` **Narrator**: "I wasn't sure if it was my imagi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "Carlos nodded his assent and ges..." |
| `[42]` | **""I would have preferred a tablecloth, but I suppose this is acceptable. Very well...."** | `[41]` **Narrator**: "I wasn't sure if it was my imagi..."<br>`[225]` **Narrator**: "I wasn't sure if it was my imagi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "We sat at the table, where the t..." |
| `[56]` | **""Now that you're here, we can begin.""** | `[302]` **Narrator**: "She gave a respectful nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Taddeus Azaro**: ""As you wish, sir."" |
| `[57]` | **""Thank God. I was about to die from boredom. General?""** | `[302]` **Narrator**: "She gave a respectful nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Taddeus Azaro**: ""As you wish, sir."" |
| `[58]` | **""Proceed.""** | `[302]` **Narrator**: "She gave a respectful nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Taddeus Azaro**: ""As you wish, sir."" |
| `[71]` | **"Gesture for him to kiss your ring."** | `[74]` **Narrator**: "The giant knelt before me obedie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "This honor was granted to very f..." |
| `[72]` | **"Place your hand on his head and say a prayer."** | `[74]` **Narrator**: "The giant knelt before me obedie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "He repeated the prayer, then ros..." |
| `[73]` | **""On your feet, soldier. You bow before no one. Thank you for your service.""** | `[74]` **Narrator**: "The giant knelt before me obedie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "He was taken aback and looked ca..." |
| `[78]` | **""I expect nothing less from our military. Everyone here should strive to be like h..."** | `[74]` **Narrator**: "The giant knelt before me obedie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "He got up on his feet and salute..." |
| `[85]` | **""I do hope that you did not put your King in danger by forcing me to come here.""** | `[84]` **Narrator**: "After saluting, I shook hands wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Taddeus Azaro**: ""We have taken every precaution,..." |
| `[87]` | **""I wanted to see the frontline with my own eyes. Or whatever you call this mess.""** | `[84]` **Narrator**: "After saluting, I shook hands wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Taddeus Azaro**: ""Yes, Your Majesty.."" |
| `[88]` | **""Skip the pleasantries, General Azaro. We have much to discuss.""** | `[84]` **Narrator**: "After saluting, I shook hands wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Taddeus Azaro**: ""As you wish, Your Majesty."" |
| `[91]` | **""You couldn't put together a proper welcome party?""** | `[84]` **Narrator**: "After saluting, I shook hands wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Taddeus Azaro**: ""I am sorry, Your Majesty. We we..." |
| `[103]` | **""Don't blame yourself. This is not your fault. It is mine.""** | `[101]` **Taddeus Azaro**: ""I remember when he first joined..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Taddeus Azaro**: ""Forgive me, Your Majesty, but I..." |
| `[104]` | **""This is entirely your fault. If only these soldiers had a better general leading ..."** | `[101]` **Taddeus Azaro**: ""I remember when he first joined..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Taddeus Azaro**: ""I hold myself entirely responsi..." |
| `[105]` | **""My condolences. I am sure he was an excellent soldier.""** | `[101]` **Taddeus Azaro**: ""I remember when he first joined..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Taddeus Azaro**: ""He was, Your Majesty. He was."" |
| `[107]` | **""His death will be avenged, General Azaro. I promise.""** | `[101]` **Taddeus Azaro**: ""I remember when he first joined..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Taddeus Azaro**: ""As you say, Your Majesty."" |
| `[114]` | **""Sons and daughters of Rizia. Do not falter! We will be victorious! No matter what!""** | `[113]` **Narrator**: "He was right. They looked at me ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Military_Manpower"] = Variab...` | `[119]` **Narrator**: "The tired soldiers got up on the..." |
| `[115]` | **""Times may be tough. But know this, your sacrifices for our country will never be ..."** | `[113]` **Narrator**: "He was right. They looked at me ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Military_Manpower"] = Variab...` | `[119]` **Narrator**: "The tired soldiers got up on the..." |
| `[117]` | **""Fear not. Fight for your King. Fight for your country!""** | `[113]` **Narrator**: "He was right. They looked at me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "The tired soldiers got up on the..." |
| `[118]` | **""We shall all return to the bosom of our God one way or another. May it be with pr..."** | `[113]` **Narrator**: "He was right. They looked at me ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `Variable["RiziaDLC.Resources_Military_Manpower"] = Variab...` | `[119]` **Narrator**: "The tired soldiers got up on the..." |
| `[132]` | **""Now that you are here, we can begin.""** | `[308]` **Narrator**: "She gave a respectful nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Taddeus Azaro**: ""As you wish, sir."" |
| `[133]` | **""Proceed.""** | `[308]` **Narrator**: "She gave a respectful nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Taddeus Azaro**: ""As you wish, sir."" |
| `[135]` | **""General Azaro, please start.""** | `[308]` **Narrator**: "She gave a respectful nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Taddeus Azaro**: ""As you wish, sir."" |
| `[228]` | **""This feels right. The two of us, fighting side by side.""** | `[238]` **Narrator**: "My war councilor and I regarded ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Lucita Azaro**: ""Fighting and winning."" |
| `[239]` | **""Give it to me straight, Luce. Are you sure we can win?""** | `[238]` **Narrator**: "My war councilor and I regarded ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Lucita Azaro**: ""I've never been more sure of an..." |
| `[241]` | **""Neither of you mentioned Vina.""** | `[238]` **Narrator**: "My war councilor and I regarded ..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[246]` **Narrator**: "Her expression grew somber." |
| `[247]` | **""You should get going. Duty calls.""** | `[238]` **Narrator**: "My war councilor and I regarded ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Lucita Azaro**: ""And I will answer, my king."" |
| `[268]` | **""I know your father, Lucita. A show of power is the only thing a man like that und..."** | `[236]` **Narrator**: "My war councilor and I looked at..." | `Variable["RiziaDLC.Taddeus_Disgraced"] == true` | *Brak zmian stanu* | `[280]` **Narrator**: "She shook her head." |
| `[269]` | **""Do you have a problem with how I handle things?""** | `[236]` **Narrator**: "My war councilor and I looked at..." | `Variable["RiziaDLC.Taddeus_Disgraced"] == true` | *Brak zmian stanu* | `[280]` **Narrator**: "She shook her head." |
| `[273]` | **""Neither of you mentioned Vina.""** | `[236]` **Narrator**: "My war councilor and I looked at..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[277]` **Narrator**: "Her expression grew determined." |
| `[279]` | **""I'm sorry, Luce. I don't know what came over me.""** | `[236]` **Narrator**: "My war councilor and I looked at..." | `Variable["RiziaDLC.Taddeus_Disgraced"] == true` | *Brak zmian stanu* | `[283]` **Narrator**: "She squeezed my hand and shook h..." |
| `[285]` | **""We have to win this, Luce. I can't afford a loss.""** | `[236]` **Narrator**: "My war councilor and I looked at..." | `(Variable["RiziaDLC.Taddeus_Disgraced"] == true) == false` | *Brak zmian stanu* | `[286]` **Narrator**: "A grim look of determination spr..." |
| `[290]` | **""You're dismissed, Councilor.""** | `[236]` **Narrator**: "My war councilor and I looked at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lucita Azaro**: ""Of-- of course."" |
| `[293]` | **""Give it to me straight. How screwed are we?""** | `[236]` **Narrator**: "My war councilor and I looked at..." | `(Variable["RiziaDLC.Taddeus_Disgraced"] == true) == false` | *Brak zmian stanu* | `[296]` **Lucita Azaro**: ""There's always hope, Your Majes..." |

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
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "The military helicopter gracefully landed on the helipad."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I could see the pillars of smoke from the air during the ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1Briefing_Frontline == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Debriefing at the Palesian-Rizian front"..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1Briefing_Frontline == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Debriefing on the Palesian-Rizian war", ..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I pushed open the large doors to the War Room and stepped inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro"); AddConversant("Carlos Rob..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "The military helicopter gracefully landed on the helipad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I could see the pillars of smoke from the air during the flight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "My kingdom was on fire."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "As the engine stopped, my ears were still ringing from the loud noise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro"); AddConversant("Carlos Rob..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "I fixed the collar of my old army uniform, feeling comfortable in it. This whole trip reminded me of the good old days at Camp Domus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "As the engine stopped, my ears were still ringing from th..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "I fixed the collar of my old army uniform, feeling comfor..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "As the engine stopped, my ears were still ringing from th..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "A soldier opened the door and led me toward a long line of his compatriots, where General Taddeus Azaro and General Carlos Azaro were both waiting for me. They were surrounded by numerous cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Taddeus Azaro: ""ATTENTION!""*)

### Węzeł `[18]`
Mówca: **Taddeus Azaro**
> ""ATTENTION!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "All of the soldiers simultaneously turned and saluted me...."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "All of the soldiers simultaneously turned and saluted me. The sound of their boots cut through the helicopter's slowing propeller."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Taddeus Azaro: ""Thank you for accepting our request, my liege. Welcome t..."*)

### Węzeł `[20]`
Mówca: **Carlos Robles Azaro**
> ""I trust the skies were kind to you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "After saluting, I shook hands with them. I leaned forward..."*)

### Węzeł `[21]`
Mówca: **Taddeus Azaro**
> ""Thank you for accepting our request, my liege. Welcome to FOB Bull Charge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Carlos Robles Azaro: ""I trust the skies were kind to you, Your Majesty.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a pleasure to be here. I've been wanting to see the front lines with my own eyes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Taddeus Azaro: ""I'm glad to hear it, Your Majesty.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Skip the pleasantries, General Azaro. We have much to discuss.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Taddeus Azaro: ""Everything will be discussed, as planned, Your Majesty.""*)

### Węzeł `[24]`
Mówca: **Taddeus Azaro**
> ""Everything will be discussed, as planned, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Taddeus Azaro: ""My daughter will be arriving after dinner. But for now...""*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would much rather be in Porte Drazon right now. I hope this meeting is worth my time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Taddeus Azaro: ""It will be, Your Majesty.""*)

### Węzeł `[26]`
Mówca: **Taddeus Azaro**
> ""I'm glad to hear it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Taddeus Azaro: ""My daughter will be arriving after dinner. But for now...""*)

### Węzeł `[27]`
Mówca: **Taddeus Azaro**
> ""My daughter will be arriving after dinner. But for now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Taddeus Azaro: ""Take a look around. Morale is at its peak -- higher than..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do hope that you did not put your King in danger by forcing me to come here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Taddeus Azaro: ""We have taken every precaution, Your Majesty. You have n..."*)

### Węzeł `[29]`
Mówca: **Taddeus Azaro**
> ""It will be, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Taddeus Azaro: ""My daughter will be arriving after dinner. But for now...""*)

### Węzeł `[30]`
Mówca: **Taddeus Azaro**
> ""We have taken every precaution, Your Majesty. You have nothing to fear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Taddeus Azaro: ""My daughter will be arriving after dinner. But for now...""*)

### Węzeł `[31]`
Mówca: **Carlos Robles Azaro**
> ""This way, Your Majesty. You must be hungry after your trip. We have already prepared your quarters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "He gestured toward a tent. Inside, there was a lavish tab..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "He was right. Pride was written all over their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He turned toward his troops and saluted them."*)

### Węzeł `[33]`
Mówca: **Taddeus Azaro**
> ""GLOVURIUS AXA RIZIA!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The soldiers joined in and chanted the words in unison."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The soldiers joined in and chanted the words in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "We went down the line, conducting a thorough inspection. ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will dine together with the soldiers in the barracks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[225]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Carlos nodded in assent and led me to the barracks, where..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Invite this soldier to dine with us, General.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[225]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Carlos nodded his assent and gestured for the boy to ente..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "He gestured toward a tent. Inside, there was a lavish table piled high with an outrageous amount of food, reserved only for nobility."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_LowerConscriptionAge == true"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "We went down the line, conducting a thorough inspection. I shook hands and saluted until I lost count."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "The last man in line towered over all the others. He was ..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "After saluting, I shook hands with them. I leaned forward so only they could hear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""I do hope that you did not put your King in danger by fo..."*)
  - -> `[22]` (*Player_Romus: ""It is a pleasure to be here. I've been wanting to see th..."*)
  - -> `[23]` (*Player_Romus: ""Skip the pleasantries, General Azaro. We have much to di..."*)
  - -> `[25]` (*Player_Romus: ""I would much rather be in Porte Drazon right now. I hope..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "He turned toward his troops and saluted them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Taddeus Azaro: ""GLOVURIUS AXA RIZIA!""*)

### Węzeł `[41]`
Mówca: **Narrator**
> "I wasn't sure if it was my imagination, but I thought I heard a gulp from the soldier standing behind me. He was a mere boy, barely out of his teens, all skin and bones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""Invite this soldier to dine with us, General.""*)
  - -> `[35]` (*Player_Romus: ""I will dine together with the soldiers in the barracks.""*)
  - -> `[42]` (*Player_Romus: ""I would have preferred a tablecloth, but I suppose this ..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would have preferred a tablecloth, but I suppose this is acceptable. Very well. Let's get on with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[225]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "We sat at the table, where the two generals gave a brief ..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "We sat at the table, where the two generals gave a brief but comprehensive update on the base’s operations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "I tried to stomach the terrible food. It was perhaps the worst meal of my life, but I persevered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower += 250"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Carlos nodded in assent and led me to the barracks, where dinner was just now being served. The soldiers gaped in awe as their king sat to eat with them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "I tried to stomach the terrible food. It was perhaps the ..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "The rest of the dinner was rather uneventful. I talked about my own time in the military, getting a few laughs from the stories I told."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "After the meal, a soldier came by to let us know that Duc..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The rest of the dinner was rather uneventful. I talked ab..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The rest of the dinner was rather uneventful. I listened ..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "The rest of the dinner was rather uneventful. I listened to a few stories from the battlefield."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "After the meal, a soldier came by to let us know that Duc..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Carlos nodded his assent and gestured for the boy to enter the tent with us. He gaped in awe as he sat to eat next to his king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "There were tears in his eyes as he tore into his meal, pr..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "There were tears in his eyes as he tore into his meal, proclaiming it the best food he'd ever tasted in his life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower += 100"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "After the meal, a soldier came by to let us know that Duchess Azaro had arrived. We moved to another tent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[54]`
Mówca: **Taddeus Azaro**
> ""Take a look around. Morale is at its peak -- higher than it’s been in months. The men are energized, eager to have their king with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He was right. Pride was written all over their faces."*)

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""Your Majesty. Father. General Carlos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "She gave a respectful nod."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that you're here, we can begin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Taddeus Azaro: ""As you wish, sir.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank God. I was about to die from boredom. General?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Taddeus Azaro: ""As you wish, sir.""*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Taddeus Azaro: ""As you wish, sir.""*)

### Węzeł `[59]`
Mówca: **Taddeus Azaro**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower += 250`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] + 250;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Cameras went off with blinding flashes."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower += 100`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] + 100;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Cameras went off with blinding flashes."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Cameras went off with blinding flashes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "My kingdom was on fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "The military helicopter touched down on the helipad as a ..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "The military helicopter touched down on the helipad as a few medical helicopters took off and another landed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "A soldier opened the door and saluted immediately. His ey..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "A soldier opened the door and saluted immediately. His eyes were blank, looking but not actually seeing. They were the eyes of someone who had seen hell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro"); AddConversant("Carlos Rob..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "General Taddeus Azaro and General Carlos Azaro were both seated around a table along with a number of other high-ranking officers, arguing loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Taddeus Azaro: ""I told you that the left flank is no-go!""*)

### Węzeł `[67]`
Mówca: **Narrator**
> "After the protocols, Carlos approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Carlos Robles Azaro: ""This way, Your Majesty. You must be hungry after your tr..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "The last man in line towered over all the others. He was at least two meters tall, with a number of scars on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Taddeus Azaro: ""This is Major Tigris. Hero of Fort Ales. He single-hande..."*)

### Węzeł `[69]`
Mówca: **Taddeus Azaro**
> ""This is Major Tigris. Hero of Fort Ales. He single-handedly eliminated 32 enemy combatants. A record.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Taddeus Azaro: ""One of the best men I've ever seen in all my days in the..."*)

### Węzeł `[70]`
Mówca: **Taddeus Azaro**
> ""One of the best men I've ever seen in all my days in the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Carlos Robles Azaro: ""He's being recommended for the Star of Valor.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "Gesture for him to kiss your ring."]** — Mówca: **Player_Romus_Italic**
> "I held out my hand so that he could kiss my ring."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "This honor was granted to very few people in the military..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "Place your hand on his head and say a prayer."]** — Mówca: **Player_Romus_Italic**
> "I put my hand on his head and said a prayer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He repeated the prayer, then rose to his feet with a whol..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On your feet, soldier. You bow before no one. Thank you for your service.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "He was taken aback and looked cautiously at Taddeus. Afte..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "The giant knelt before me obediently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus_Italic: "Gesture for him to kiss your ring."*)
  - -> `[72]` (*Player_Romus_Italic: "Place your hand on his head and say a prayer."*)
  - -> `[73]` (*Player_Romus: ""On your feet, soldier. You bow before no one. Thank you ..."*)
  - -> `[78]` (*Player_Romus: ""I expect nothing less from our military. Everyone here s..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "This honor was granted to very few people in the military. He kissed the ring in great disbelief, then rose to his feet with a wholehearted salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "After the protocols, Carlos approached."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "He was taken aback and looked cautiously at Taddeus. After a nod of confirmation from the general, he got up and saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "After the protocols, Carlos approached."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He repeated the prayer, then rose to his feet with a wholehearted salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "After the protocols, Carlos approached."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect nothing less from our military. Everyone here should strive to be like him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "He got up on his feet and saluted wholeheartedly."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "He got up on his feet and saluted wholeheartedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "After the protocols, Carlos approached."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "A scream cut through his words. A soldier on a stretcher was crying out for his mother as he was moved into a medical helicopter. He was covered in bloody bandages."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Taddeus and Carlos continued arguing, seemingly unfazed b..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Taddeus and Carlos continued arguing, seemingly unfazed by the scream. However, when a soldier whispered in their ear regarding my arrival, they quickly assumed a professional demeanor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Taddeus Azaro: ""Ah. My liege. Thank you for accepting our request. Welco..."*)

### Węzeł `[82]`
Mówca: **Taddeus Azaro**
> ""Ah. My liege. Thank you for accepting our request. Welcome to FOB Iron Gate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Carlos Robles Azaro: ""I trust the skies were kind to you, Your Highness.""*)

### Węzeł `[83]`
Mówca: **Carlos Robles Azaro**
> ""I trust the skies were kind to you, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "After saluting, I shook hands with them. I leaned forward..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "After saluting, I shook hands with them. I leaned forward so only they could hear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player_Romus: ""I do hope that you did not put your King in danger by fo..."*)
  - -> `[87]` (*Player_Romus: ""I wanted to see the frontline with my own eyes. Or whate..."*)
  - -> `[88]` (*Player_Romus: ""Skip the pleasantries, General Azaro. We have much to di..."*)
  - -> `[91]` (*Player_Romus: ""You couldn't put together a proper welcome party?""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do hope that you did not put your King in danger by forcing me to come here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Taddeus Azaro: ""We have taken every precaution, Your Majesty. You have n..."*)

### Węzeł `[86]`
Mówca: **Taddeus Azaro**
> ""We have taken every precaution, Your Majesty. You have nothing to fear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Taddeus Azaro: ""Duchess Azaro will be arriving shortly. But for now...""*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to see the frontline with my own eyes. Or whatever you call this mess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Taddeus Azaro: ""Yes, Your Majesty..""*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Skip the pleasantries, General Azaro. We have much to discuss.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Taddeus Azaro: ""As you wish, Your Majesty.""*)

### Węzeł `[89]`
Mówca: **Taddeus Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Taddeus Azaro: ""Duchess Azaro will be arriving shortly. But for now...""*)

### Węzeł `[90]`
Mówca: **Taddeus Azaro**
> ""Yes, Your Majesty..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Taddeus Azaro: ""Duchess Azaro will be arriving shortly. But for now...""*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You couldn't put together a proper welcome party?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Taddeus Azaro: ""I am sorry, Your Majesty. We were in the middle of a str..."*)

### Węzeł `[92]`
Mówca: **Taddeus Azaro**
> ""I am sorry, Your Majesty. We were in the middle of a strategic discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Taddeus Azaro: ""Duchess Azaro will be arriving shortly. But for now...""*)

### Węzeł `[93]`
Mówca: **Taddeus Azaro**
> ""Duchess Azaro will be arriving shortly. But for now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Taddeus Azaro: ""Take a look around. Morale is at its peak -- higher than..."*)

### Węzeł `[94]`
Mówca: **Taddeus Azaro**
> ""Take a look around. Morale is at its peak -- higher than it’s been in months. The men are energized, eager to have their king with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "I cast my eye over the bedraggled group of soldiers. Most..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "I cast my eye over the bedraggled group of soldiers. Most of them seemed too tired to have even registered my presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Taddeus turned and saluted the soldiers."*)

### Węzeł `[96]`
Mówca: **Taddeus Azaro**
> ""GLOVURIUS AXA RIZIA!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "A few meek shouts rose from the soldiers. Most of them co..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Taddeus turned and saluted the soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Taddeus Azaro: ""GLOVURIUS AXA RIZIA!""*)

### Węzeł `[98]`
Mówca: **Narrator**
> "A few meek shouts rose from the soldiers. Most of them continued with their duties, transporting sandbags and injured compatriots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Taddeus halted two soldiers rushing to transport a wounde..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Taddeus halted two soldiers rushing to transport a wounded man on a stretcher. The soldier's height made him nearly too large for it, and his injuries left little hope -- he wouldn't last much longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Taddeus held his hand and said a prayer. The man let out ..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Taddeus held his hand and said a prayer. The man let out a final sigh. His fellow soldiers continued carrying him, slower than before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Taddeus Azaro: ""God damn it! That was Major Tigris! One of the best men ..."*)

### Węzeł `[101]`
Mówca: **Taddeus Azaro**
> ""I remember when he first joined my battalion. He kept showing everyone photos of his daughter...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""Don't blame yourself. This is not your fault. It is mine.""*)
  - -> `[104]` (*Player_Romus: ""This is entirely your fault. If only these soldiers had ..."*)
  - -> `[107]` (*Player_Romus: ""His death will be avenged, General Azaro. I promise.""*)
  - -> `[105]` (*Player_Romus: ""My condolences. I am sure he was an excellent soldier.""*)

### Węzeł `[102]`
Mówca: **Taddeus Azaro**
> ""As you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Taddeus Azaro: ""Nevertheless, your presence here is already helping with..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't blame yourself. This is not your fault. It is mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Taddeus Azaro: ""Forgive me, Your Majesty, but I cannot let you speak ill..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is entirely your fault. If only these soldiers had a better general leading them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Taddeus Azaro: ""I hold myself entirely responsible.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My condolences. I am sure he was an excellent soldier.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Taddeus Azaro: ""He was, Your Majesty. He was.""*)

### Węzeł `[106]`
Mówca: **Taddeus Azaro**
> ""God damn it! That was Major Tigris! One of the best men I've seen in all my days in the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Taddeus Azaro: ""I remember when he first joined my battalion. He kept sh..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His death will be avenged, General Azaro. I promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Taddeus Azaro: ""As you say, Your Majesty.""*)

### Węzeł `[108]`
Mówca: **Taddeus Azaro**
> ""Forgive me, Your Majesty, but I cannot let you speak ill of yourself. My honor won't allow it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Carlos Robles Azaro: ""I stand with Taddeus. This is not your doing.""*)

### Węzeł `[109]`
Mówca: **Taddeus Azaro**
> ""He was, Your Majesty. He was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Taddeus Azaro: ""Nevertheless, your presence here is already helping with..."*)

### Węzeł `[110]`
Mówca: **Taddeus Azaro**
> ""I told you that the left flank is no-go!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Carlos Robles Azaro: ""Well, if you had listened to my advice in the first place-""*)

### Węzeł `[111]`
Mówca: **Taddeus Azaro**
> ""Nevertheless, your presence here is already helping with our situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Taddeus Azaro: ""Look around at these men. They're prepared to fight for ..."*)

### Węzeł `[112]`
Mówca: **Taddeus Azaro**
> ""Look around at these men. They're prepared to fight for their country to their final breath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He was right. They looked at me with hope in their eyes. ..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "He was right. They looked at me with hope in their eyes. Despite everything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus: ""Sons and daughters of Rizia. Do not falter! We will be v..."*)
  - -> `[115]` (*Player_Romus: ""Times may be tough. But know this, your sacrifices for o..."*)
  - -> `[117]` (*Player_Romus: ""Fear not. Fight for your King. Fight for your country!""*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sons and daughters of Rizia. Do not falter! We will be victorious! No matter what!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower += 100"*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Times may be tough. But know this, your sacrifices for our country will never be in vain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower += 250"*)

### Węzeł `[116]`
Mówca: **Taddeus Azaro**
> ""Thank you for your encouraging words, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "A soldier came by to let us know that Duchess Azaro had a..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fear not. Fight for your King. Fight for your country!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "The tired soldiers got up on their feet. They saluted and..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shall all return to the bosom of our God one way or another. May it be with pride and honor!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower += 100"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "The tired soldiers got up on their feet. They saluted and started chanting in weary voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Weary, but loud and clear."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Weary, but loud and clear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Taddeus Azaro: ""Thank you for your encouraging words, Your Majesty.""*)

### Węzeł `[121]`
Mówca: **Narrator**
> "A soldier came by to let us know that Duchess Azaro had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Carlos Robles Azaro: ""Right this way, sire.""*)

### Węzeł `[122]`
Mówca: **Carlos Robles Azaro**
> ""Right this way, sire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "We moved to the briefing room."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "We moved to the briefing room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower += 250`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] + 250;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "The tired soldiers got up on their feet. They saluted and..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower += 100`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] + 100;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "The tired soldiers got up on their feet. They saluted and..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "General Taddeus Azaro and General Carlos Azaro were there, deep in conversation with a few high-ranking officers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "They all turned to me and saluted."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "They all turned to me and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Taddeus Azaro: ""Good evening, Your Majesty.""*)

### Węzeł `[128]`
Mówca: **Taddeus Azaro**
> ""Good evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Carlos Robles Azaro: ""Pleasure as always, sir.""*)

### Węzeł `[129]`
Mówca: **Taddeus Azaro**
> ""I just returned from the frontline today, bearing news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Taddeus Azaro: ""My daughter will arrive shortly.""*)

### Węzeł `[130]`
Mówca: **Taddeus Azaro**
> ""My daughter will arrive shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "As if on cue, the doors swung open and Lucita walked in."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "As if on cue, the doors swung open and Lucita walked in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that you are here, we can begin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Taddeus Azaro: ""As you wish, sir.""*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Taddeus Azaro: ""As you wish, sir.""*)

### Węzeł `[134]`
Mówca: **Taddeus Azaro**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""General Azaro, please start.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Taddeus Azaro: ""As you wish, sir.""*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_LespianSupport >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport >= 1"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_LespianSupport >= 1)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_LespianSupport >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_LespianSupport"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Str..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_LespianSupport >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_LespianSupport"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Def..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Default = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_NoBlockade = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_NoBlockade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == t..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadePales_Success == true"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadePales_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadePales_Success == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_AttackPlan_BlockadePales_Success == true)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadePales_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_AttackPlan_BlockadePales_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_AttackPlan_BlockadePales_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_AttackPlan_BlockadePales_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_AttackPlan_BlockadeRemaz_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_AttackPlan_BlockadeRemaz_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_NoBlockade = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_NoBlockade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_AttackPlan_BlockadeRemaz_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_AttackPlan_BlockadeRemaz_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == t..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadePales_Success == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadePales_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadePales_Success == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_AttackPlan_BlockadePales_Success == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_AttackPlan_BlockadePales_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_AttackPlan_BlockadePales_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_AttackPlan_BlockadePales_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_AttackPlan_BlockadePales_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_AttackPlan_BlockadeRemaz_Success == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");"*)

### Węzeł `[169]`
Mówca: **Narrator**
> "Lucita got up and gestured at the other military staff present in the tent to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "Her father saluted once more from his wheelchair as an ai..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "Lucita got up and gestured at the other military staff present in the tent to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "Lucita got up and gestured at the other military staff pr..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "Lucita got up and gestured at the other military staff pr..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1Briefing_Frontline == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1Briefing_Frontline == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Lucita got up and gestured at the other military staff pr..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Lucita got up and gestured at the other military staff present in the room to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Everyone was quiet as they left, leaving me with my thoughts, all alone, in the grand room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[179]`
Mówca: **Narrator**
> "The disgraced general rolled his wheelchair out. Carlos took his leave as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Disgraced == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "The disgraced general rolled his wheelchair out. Carlos t..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Disgraced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "Taddeus looked back at me remorsefully as he rolled his w..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "Everyone was quiet as they left, leaving me all alone with my thoughts in the cold tent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "Her father saluted once more from his wheelchair as an ai..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro"); AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");
AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "General Taddeus Azaro and General Carlos Azaro were both ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro"); AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");
AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "A soldier opened the door and led me toward a long line o..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro"); AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");
AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "General Taddeus Azaro and General Carlos Azaro were there..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""Your Majesty. Father. General Carlos.""*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Lucita Azaro: ""Your Majesty. Father. General Carlos.""*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");
RemoveConversant("Taddeus Azaro"); RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");
RemoveConversant("Taddeus Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Control_Skipped == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Control_Skipped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport >= 1"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelmi..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total = RiziaDLC.War_Control_..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total = RiziaDLC.War_Control_..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average ==..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total = RiziaDLC.War_Control_..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total = RiziaDLC.War_Control_..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador = false;
RiziaDLC.War_Objective_Captured_FortAles = false;
RiziaDLC.War_Objective_Captured_Ziqes = false;
RiziaDLC.War_Objective_Captured_Arces = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] = false;
Variable["RiziaDLC.War_Objective_Captured_FortAles"] = false;
Variable["RiziaDLC.War_Objective_Captured_Ziqes"] = false;
Variable["RiziaDLC.War_Objective_Captured_Arces"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped_Infantry = RiziaDLC.Army_Uni..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador = true;
RiziaDLC.War_Objective_Captured_FortAles = false;
RiziaDLC.War_Objective_Captured_Ziqes = true;
RiziaDLC.War_Objective_Captured_Arces = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] = true;
Variable["RiziaDLC.War_Objective_Captured_FortAles"] = false;
Variable["RiziaDLC.War_Objective_Captured_Ziqes"] = true;
Variable["RiziaDLC.War_Objective_Captured_Arces"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped_Infantry = RiziaDLC.Army_Uni..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador = true;
RiziaDLC.War_Objective_Captured_FortAles = true;
RiziaDLC.War_Objective_Captured_Ziqes = false;
RiziaDLC.War_Objective_Captured_Arces = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] = true;
Variable["RiziaDLC.War_Objective_Captured_FortAles"] = true;
Variable["RiziaDLC.War_Objective_Captured_Ziqes"] = false;
Variable["RiziaDLC.War_Objective_Captured_Arces"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped_Infantry = RiziaDLC.Army_Uni..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador = true;
RiziaDLC.War_Objective_Captured_FortAles = true;
RiziaDLC.War_Objective_Captured_Ziqes = true;
RiziaDLC.War_Objective_Captured_Arces = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] = true;
Variable["RiziaDLC.War_Objective_Captured_FortAles"] = true;
Variable["RiziaDLC.War_Objective_Captured_Ziqes"] = true;
Variable["RiziaDLC.War_Objective_Captured_Arces"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped_Infantry = RiziaDLC.Army_Uni..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead = 5;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] = 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador = false; RiziaDLC..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead = 10;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] = 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador = true; RiziaDLC...."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead = 20;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] = 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador = true; RiziaDLC...."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead = 30;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] = 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador = true; RiziaDLC...."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total = RiziaDLC.War_Control_Skipped_Infantry - (RiziaDLC.War_Control_Skipped_Infantry / 5);
RiziaDLC.Army_Unit_Tank_Total = RiziaDLC.War_Control_Skipped_Tank - (RiziaDLC.War_Control_Skipped_Tank / 5);
RiziaDLC.Army_Unit_Support_Total = RiziaDLC.War_Control_Skipped_Support - (RiziaDLC.War_Control_Skipped_Support / 5);
RiziaDLC.Army_Unit_Ship_Total = RiziaDLC.War_Control_Skipped_Ship - (RiziaDLC.War_Control_Skipped_Ship / 5);
RiziaDLC.Army_Unit_Submarine_Total = RiziaDLC.War_Control_Skipped_Submarine - (RiziaDLC.War_Control_Skipped_Submarine / 5);
RiziaDLC.Army_Unit_Azaro_Total = RiziaDLC.War_Control_Skipped_Azaro - (RiziaDLC.War_Control_Skipped_Azaro / 5);
RiziaDLC.Army_Unit_Flagship_Total = RiziaDLC.War_Control_Skipped_Flagship - (RiziaDLC.War_Control_Skipped_Flagship / 5);
RiziaDLC.Army_Unit_GoldenGuard_Total = RiziaDLC.War_Control_Skipped_GoldenGuard - (RiziaDLC.War_Control_Skipped_GoldenGuard / 5);
RiziaDLC.Army_Unit_Marine_Total = RiziaDLC.War_Control_Skipped_Marine - (RiziaDLC.War_Control_Skipped_Marine / 5);
RiziaDLC.Army_Unit_Mercenary_Total = RiziaDLC.War_Control_Skipped_Mercenary - (RiziaDLC.War_Control_Skipped_Mercenary / 5);
RiziaDLC.Army_Unit_Mountaineer_Total = RiziaDLC.War_Control_Skipped_Mountaineer - (RiziaDLC.War_Control_Skipped_Mountaineer / 5);
RiziaDLC.Army_Unit_Paratrooper_Total = RiziaDLC.War_Control_Skipped_Paratrooper - (RiziaDLC.War_Control_Skipped_Paratrooper / 5);
RiziaDLC.Army_Unit_Sazon_Total = RiziaDLC.War_Control_Skipped_Sazon - (RiziaDLC.War_Control_Skipped_Sazon / 5);`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] = Variable["RiziaDLC.War_Control_Skipped_Infantry"] - (Variable["RiziaDLC.War_Control_Skipped_Infantry"] / 5);
Variable["RiziaDLC.Army_Unit_Tank_Total"] = Variable["RiziaDLC.War_Control_Skipped_Tank"] - (Variable["RiziaDLC.War_Control_Skipped_Tank"] / 5);
Variable["RiziaDLC.Army_Unit_Support_Total"] = Variable["RiziaDLC.War_Control_Skipped_Support"] - (Variable["RiziaDLC.War_Control_Skipped_Support"] / 5);
Variable["RiziaDLC.Army_Unit_Ship_Total"] = Variable["RiziaDLC.War_Control_Skipped_Ship"] - (Variable["RiziaDLC.War_Control_Skipped_Ship"] / 5);
Variable["RiziaDLC.Army_Unit_Submarine_Total"] = Variable["RiziaDLC.War_Control_Skipped_Submarine"] - (Variable["RiziaDLC.War_Control_Skipped_Submarine"] / 5);
Variable["RiziaDLC.Army_Unit_Azaro_Total"] = Variable["RiziaDLC.War_Control_Skipped_Azaro"] - (Variable["RiziaDLC.War_Control_Skipped_Azaro"] / 5);
Variable["RiziaDLC.Army_Unit_Flagship_Total"] = Variable["RiziaDLC.War_Control_Skipped_Flagship"] - (Variable["RiziaDLC.War_Control_Skipped_Flagship"] / 5);
Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] = Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] - (Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] / 5);
Variable["RiziaDLC.Army_Unit_Marine_Total"] = Variable["RiziaDLC.War_Control_Skipped_Marine"] - (Variable["RiziaDLC.War_Control_Skipped_Marine"] / 5);
Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable["RiziaDLC.War_Control_Skipped_Mercenary"] - (Variable["RiziaDLC.War_Control_Skipped_Mercenary"] / 5);
Variable["RiziaDLC.Army_Unit_Mountaineer_Total"] = Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] - (Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] / 5);
Variable["RiziaDLC.Army_Unit_Paratrooper_Total"] = Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] - (Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] / 5);
Variable["RiziaDLC.Army_Unit_Sazon_Total"] = Variable["RiziaDLC.War_Control_Skipped_Sazon"] - (Variable["RiziaDLC.War_Control_Skipped_Sazon"] / 5);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead = 30;"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped_Infantry = RiziaDLC.Army_Unit_Infantry_Total;
RiziaDLC.War_Control_Skipped_Tank = RiziaDLC.Army_Unit_Tank_Total;
RiziaDLC.War_Control_Skipped_Support = RiziaDLC.Army_Unit_Support_Total;
RiziaDLC.War_Control_Skipped_Ship = RiziaDLC.Army_Unit_Ship_Total;
RiziaDLC.War_Control_Skipped_Submarine = RiziaDLC.Army_Unit_Submarine_Total;
RiziaDLC.War_Control_Skipped_Azaro = RiziaDLC.Army_Unit_Azaro_Total;
RiziaDLC.War_Control_Skipped_Flagship = RiziaDLC.Army_Unit_Flagship_Total;
RiziaDLC.War_Control_Skipped_GoldenGuard = RiziaDLC.Army_Unit_GoldenGuard_Total;
RiziaDLC.War_Control_Skipped_Marine = RiziaDLC.Army_Unit_Marine_Total;
RiziaDLC.War_Control_Skipped_Mercenary = RiziaDLC.Army_Unit_Mercenary_Total;
RiziaDLC.War_Control_Skipped_Mountaineer = RiziaDLC.Army_Unit_Mountaineer_Total;
RiziaDLC.War_Control_Skipped_Paratrooper = RiziaDLC.Army_Unit_Paratrooper_Total;
RiziaDLC.War_Control_Skipped_Sazon = RiziaDLC.Army_Unit_Sazon_Total;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Control_Skipped_Infantry"] = Variable["RiziaDLC.Army_Unit_Infantry_Total"];
Variable["RiziaDLC.War_Control_Skipped_Tank"] = Variable["RiziaDLC.Army_Unit_Tank_Total"];
Variable["RiziaDLC.War_Control_Skipped_Support"] = Variable["RiziaDLC.Army_Unit_Support_Total"];
Variable["RiziaDLC.War_Control_Skipped_Ship"] = Variable["RiziaDLC.Army_Unit_Ship_Total"];
Variable["RiziaDLC.War_Control_Skipped_Submarine"] = Variable["RiziaDLC.Army_Unit_Submarine_Total"];
Variable["RiziaDLC.War_Control_Skipped_Azaro"] = Variable["RiziaDLC.Army_Unit_Azaro_Total"];
Variable["RiziaDLC.War_Control_Skipped_Flagship"] = Variable["RiziaDLC.Army_Unit_Flagship_Total"];
Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] = Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"];
Variable["RiziaDLC.War_Control_Skipped_Marine"] = Variable["RiziaDLC.Army_Unit_Marine_Total"];
Variable["RiziaDLC.War_Control_Skipped_Mercenary"] = Variable["RiziaDLC.Army_Unit_Mercenary_Total"];
Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] = Variable["RiziaDLC.Army_Unit_Mountaineer_Total"];
Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] = Variable["RiziaDLC.Army_Unit_Paratrooper_Total"];
Variable["RiziaDLC.War_Control_Skipped_Sazon"] = Variable["RiziaDLC.Army_Unit_Sazon_Total"];
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total = 1; RiziaDLC.Army_Unit..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total = 1;
RiziaDLC.Army_Unit_Tank_Total = 1;
RiziaDLC.Army_Unit_Support_Total = 1;
RiziaDLC.Army_Unit_Ship_Total = 0;
RiziaDLC.Army_Unit_Submarine_Total = 0;
RiziaDLC.Army_Unit_Azaro_Total = 0;
RiziaDLC.Army_Unit_Flagship_Total = 0;
RiziaDLC.Army_Unit_GoldenGuard_Total = 0;
RiziaDLC.Army_Unit_Marine_Total = 0;
RiziaDLC.Army_Unit_Mercenary_Total = 0;
RiziaDLC.Army_Unit_Mountaineer_Total = 0;
RiziaDLC.Army_Unit_Paratrooper_Total = 0;
RiziaDLC.Army_Unit_Sazon_Total = 0;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] = 1;
Variable["RiziaDLC.Army_Unit_Tank_Total"] = 1;
Variable["RiziaDLC.Army_Unit_Support_Total"] = 1;
Variable["RiziaDLC.Army_Unit_Ship_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Submarine_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Azaro_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Flagship_Total"] = 0;
Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Marine_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Mountaineer_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Paratrooper_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Sazon_Total"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport >= 1"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped_Infantry = RiziaDLC.Army_Unit_Infantry_Total;
RiziaDLC.War_Control_Skipped_Tank = RiziaDLC.Army_Unit_Tank_Total;
RiziaDLC.War_Control_Skipped_Support = RiziaDLC.Army_Unit_Support_Total;
RiziaDLC.War_Control_Skipped_Ship = RiziaDLC.Army_Unit_Ship_Total;
RiziaDLC.War_Control_Skipped_Submarine = RiziaDLC.Army_Unit_Submarine_Total;
RiziaDLC.War_Control_Skipped_Azaro = RiziaDLC.Army_Unit_Azaro_Total;
RiziaDLC.War_Control_Skipped_Flagship = RiziaDLC.Army_Unit_Flagship_Total;
RiziaDLC.War_Control_Skipped_GoldenGuard = RiziaDLC.Army_Unit_GoldenGuard_Total;
RiziaDLC.War_Control_Skipped_Marine = RiziaDLC.Army_Unit_Marine_Total;
RiziaDLC.War_Control_Skipped_Mercenary = RiziaDLC.Army_Unit_Mercenary_Total;
RiziaDLC.War_Control_Skipped_Mountaineer = RiziaDLC.Army_Unit_Mountaineer_Total;
RiziaDLC.War_Control_Skipped_Paratrooper = RiziaDLC.Army_Unit_Paratrooper_Total;
RiziaDLC.War_Control_Skipped_Sazon = RiziaDLC.Army_Unit_Sazon_Total;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Control_Skipped_Infantry"] = Variable["RiziaDLC.Army_Unit_Infantry_Total"];
Variable["RiziaDLC.War_Control_Skipped_Tank"] = Variable["RiziaDLC.Army_Unit_Tank_Total"];
Variable["RiziaDLC.War_Control_Skipped_Support"] = Variable["RiziaDLC.Army_Unit_Support_Total"];
Variable["RiziaDLC.War_Control_Skipped_Ship"] = Variable["RiziaDLC.Army_Unit_Ship_Total"];
Variable["RiziaDLC.War_Control_Skipped_Submarine"] = Variable["RiziaDLC.Army_Unit_Submarine_Total"];
Variable["RiziaDLC.War_Control_Skipped_Azaro"] = Variable["RiziaDLC.Army_Unit_Azaro_Total"];
Variable["RiziaDLC.War_Control_Skipped_Flagship"] = Variable["RiziaDLC.Army_Unit_Flagship_Total"];
Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] = Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"];
Variable["RiziaDLC.War_Control_Skipped_Marine"] = Variable["RiziaDLC.Army_Unit_Marine_Total"];
Variable["RiziaDLC.War_Control_Skipped_Mercenary"] = Variable["RiziaDLC.Army_Unit_Mercenary_Total"];
Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] = Variable["RiziaDLC.Army_Unit_Mountaineer_Total"];
Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] = Variable["RiziaDLC.Army_Unit_Paratrooper_Total"];
Variable["RiziaDLC.War_Control_Skipped_Sazon"] = Variable["RiziaDLC.Army_Unit_Sazon_Total"];
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total = 1; RiziaDLC.Army_Unit..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total = 1;
RiziaDLC.Army_Unit_Tank_Total = 1;
RiziaDLC.Army_Unit_Support_Total = 1;
RiziaDLC.Army_Unit_Ship_Total = 0;
RiziaDLC.Army_Unit_Submarine_Total = 0;
RiziaDLC.Army_Unit_Azaro_Total = 0;
RiziaDLC.Army_Unit_Flagship_Total = 0;
RiziaDLC.Army_Unit_GoldenGuard_Total = 0;
RiziaDLC.Army_Unit_Marine_Total = 0;
RiziaDLC.Army_Unit_Mercenary_Total = 0;
RiziaDLC.Army_Unit_Mountaineer_Total = 0;
RiziaDLC.Army_Unit_Paratrooper_Total = 0;
RiziaDLC.Army_Unit_Sazon_Total = 0;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] = 1;
Variable["RiziaDLC.Army_Unit_Tank_Total"] = 1;
Variable["RiziaDLC.Army_Unit_Support_Total"] = 1;
Variable["RiziaDLC.Army_Unit_Ship_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Submarine_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Azaro_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Flagship_Total"] = 0;
Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Marine_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Mountaineer_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Paratrooper_Total"] = 0;
Variable["RiziaDLC.Army_Unit_Sazon_Total"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport >= 1"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total = RiziaDLC.War_Control_Skipped_Infantry - (RiziaDLC.War_Control_Skipped_Infantry / 4);
RiziaDLC.Army_Unit_Tank_Total = RiziaDLC.War_Control_Skipped_Tank - (RiziaDLC.War_Control_Skipped_Tank / 4);
RiziaDLC.Army_Unit_Support_Total = RiziaDLC.War_Control_Skipped_Support - (RiziaDLC.War_Control_Skipped_Support / 4);
RiziaDLC.Army_Unit_Ship_Total = RiziaDLC.War_Control_Skipped_Ship - (RiziaDLC.War_Control_Skipped_Ship / 4);
RiziaDLC.Army_Unit_Submarine_Total = RiziaDLC.War_Control_Skipped_Submarine - (RiziaDLC.War_Control_Skipped_Submarine / 4);
RiziaDLC.Army_Unit_Azaro_Total = RiziaDLC.War_Control_Skipped_Azaro - (RiziaDLC.War_Control_Skipped_Azaro / 4);
RiziaDLC.Army_Unit_Flagship_Total = RiziaDLC.War_Control_Skipped_Flagship - (RiziaDLC.War_Control_Skipped_Flagship / 4);
RiziaDLC.Army_Unit_GoldenGuard_Total = RiziaDLC.War_Control_Skipped_GoldenGuard - (RiziaDLC.War_Control_Skipped_GoldenGuard / 4);
RiziaDLC.Army_Unit_Marine_Total = RiziaDLC.War_Control_Skipped_Marine - (RiziaDLC.War_Control_Skipped_Marine / 4);
RiziaDLC.Army_Unit_Mercenary_Total = RiziaDLC.War_Control_Skipped_Mercenary - (RiziaDLC.War_Control_Skipped_Mercenary / 4);
RiziaDLC.Army_Unit_Mountaineer_Total = RiziaDLC.War_Control_Skipped_Mountaineer - (RiziaDLC.War_Control_Skipped_Mountaineer / 4);
RiziaDLC.Army_Unit_Paratrooper_Total = RiziaDLC.War_Control_Skipped_Paratrooper - (RiziaDLC.War_Control_Skipped_Paratrooper / 4);
RiziaDLC.Army_Unit_Sazon_Total = RiziaDLC.War_Control_Skipped_Sazon - (RiziaDLC.War_Control_Skipped_Sazon / 4);`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] = Variable["RiziaDLC.War_Control_Skipped_Infantry"] - (Variable["RiziaDLC.War_Control_Skipped_Infantry"] / 4);
Variable["RiziaDLC.Army_Unit_Tank_Total"] = Variable["RiziaDLC.War_Control_Skipped_Tank"] - (Variable["RiziaDLC.War_Control_Skipped_Tank"] / 4);
Variable["RiziaDLC.Army_Unit_Support_Total"] = Variable["RiziaDLC.War_Control_Skipped_Support"] - (Variable["RiziaDLC.War_Control_Skipped_Support"] / 4);
Variable["RiziaDLC.Army_Unit_Ship_Total"] = Variable["RiziaDLC.War_Control_Skipped_Ship"] - (Variable["RiziaDLC.War_Control_Skipped_Ship"] / 4);
Variable["RiziaDLC.Army_Unit_Submarine_Total"] = Variable["RiziaDLC.War_Control_Skipped_Submarine"] - (Variable["RiziaDLC.War_Control_Skipped_Submarine"] / 4);
Variable["RiziaDLC.Army_Unit_Azaro_Total"] = Variable["RiziaDLC.War_Control_Skipped_Azaro"] - (Variable["RiziaDLC.War_Control_Skipped_Azaro"] / 4);
Variable["RiziaDLC.Army_Unit_Flagship_Total"] = Variable["RiziaDLC.War_Control_Skipped_Flagship"] - (Variable["RiziaDLC.War_Control_Skipped_Flagship"] / 4);
Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] = Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] - (Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] / 4);
Variable["RiziaDLC.Army_Unit_Marine_Total"] = Variable["RiziaDLC.War_Control_Skipped_Marine"] - (Variable["RiziaDLC.War_Control_Skipped_Marine"] / 4);
Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable["RiziaDLC.War_Control_Skipped_Mercenary"] - (Variable["RiziaDLC.War_Control_Skipped_Mercenary"] / 4);
Variable["RiziaDLC.Army_Unit_Mountaineer_Total"] = Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] - (Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] / 4);
Variable["RiziaDLC.Army_Unit_Paratrooper_Total"] = Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] - (Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] / 4);
Variable["RiziaDLC.Army_Unit_Sazon_Total"] = Variable["RiziaDLC.War_Control_Skipped_Sazon"] - (Variable["RiziaDLC.War_Control_Skipped_Sazon"] / 4);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead = 20;"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total = RiziaDLC.War_Control_Skipped_Infantry - (RiziaDLC.War_Control_Skipped_Infantry / 2);
RiziaDLC.Army_Unit_Tank_Total = RiziaDLC.War_Control_Skipped_Tank - (RiziaDLC.War_Control_Skipped_Tank / 2);
RiziaDLC.Army_Unit_Support_Total = RiziaDLC.War_Control_Skipped_Support - (RiziaDLC.War_Control_Skipped_Support / 2);
RiziaDLC.Army_Unit_Ship_Total = RiziaDLC.War_Control_Skipped_Ship - (RiziaDLC.War_Control_Skipped_Ship / 2);
RiziaDLC.Army_Unit_Submarine_Total = RiziaDLC.War_Control_Skipped_Submarine - (RiziaDLC.War_Control_Skipped_Submarine / 2);
RiziaDLC.Army_Unit_Azaro_Total = RiziaDLC.War_Control_Skipped_Azaro - (RiziaDLC.War_Control_Skipped_Azaro / 2);
RiziaDLC.Army_Unit_Flagship_Total = RiziaDLC.War_Control_Skipped_Flagship - (RiziaDLC.War_Control_Skipped_Flagship / 2);
RiziaDLC.Army_Unit_GoldenGuard_Total = RiziaDLC.War_Control_Skipped_GoldenGuard - (RiziaDLC.War_Control_Skipped_GoldenGuard / 2);
RiziaDLC.Army_Unit_Marine_Total = RiziaDLC.War_Control_Skipped_Marine - (RiziaDLC.War_Control_Skipped_Marine / 2);
RiziaDLC.Army_Unit_Mercenary_Total = RiziaDLC.War_Control_Skipped_Mercenary - (RiziaDLC.War_Control_Skipped_Mercenary / 2);
RiziaDLC.Army_Unit_Mountaineer_Total = RiziaDLC.War_Control_Skipped_Mountaineer - (RiziaDLC.War_Control_Skipped_Mountaineer / 2);
RiziaDLC.Army_Unit_Paratrooper_Total = RiziaDLC.War_Control_Skipped_Paratrooper - (RiziaDLC.War_Control_Skipped_Paratrooper / 2);
RiziaDLC.Army_Unit_Sazon_Total = RiziaDLC.War_Control_Skipped_Sazon - (RiziaDLC.War_Control_Skipped_Sazon / 2);`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] = Variable["RiziaDLC.War_Control_Skipped_Infantry"] - (Variable["RiziaDLC.War_Control_Skipped_Infantry"] / 2);
Variable["RiziaDLC.Army_Unit_Tank_Total"] = Variable["RiziaDLC.War_Control_Skipped_Tank"] - (Variable["RiziaDLC.War_Control_Skipped_Tank"] / 2);
Variable["RiziaDLC.Army_Unit_Support_Total"] = Variable["RiziaDLC.War_Control_Skipped_Support"] - (Variable["RiziaDLC.War_Control_Skipped_Support"] / 2);
Variable["RiziaDLC.Army_Unit_Ship_Total"] = Variable["RiziaDLC.War_Control_Skipped_Ship"] - (Variable["RiziaDLC.War_Control_Skipped_Ship"] / 2);
Variable["RiziaDLC.Army_Unit_Submarine_Total"] = Variable["RiziaDLC.War_Control_Skipped_Submarine"] - (Variable["RiziaDLC.War_Control_Skipped_Submarine"] / 2);
Variable["RiziaDLC.Army_Unit_Azaro_Total"] = Variable["RiziaDLC.War_Control_Skipped_Azaro"] - (Variable["RiziaDLC.War_Control_Skipped_Azaro"] / 2);
Variable["RiziaDLC.Army_Unit_Flagship_Total"] = Variable["RiziaDLC.War_Control_Skipped_Flagship"] - (Variable["RiziaDLC.War_Control_Skipped_Flagship"] / 2);
Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] = Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] - (Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] / 2);
Variable["RiziaDLC.Army_Unit_Marine_Total"] = Variable["RiziaDLC.War_Control_Skipped_Marine"] - (Variable["RiziaDLC.War_Control_Skipped_Marine"] / 2);
Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable["RiziaDLC.War_Control_Skipped_Mercenary"] - (Variable["RiziaDLC.War_Control_Skipped_Mercenary"] / 2);
Variable["RiziaDLC.Army_Unit_Mountaineer_Total"] = Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] - (Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] / 2);
Variable["RiziaDLC.Army_Unit_Paratrooper_Total"] = Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] - (Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] / 2);
Variable["RiziaDLC.Army_Unit_Sazon_Total"] = Variable["RiziaDLC.War_Control_Skipped_Sazon"] - (Variable["RiziaDLC.War_Control_Skipped_Sazon"] / 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead = 5;"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total = RiziaDLC.War_Control_Skipped_Infantry - (RiziaDLC.War_Control_Skipped_Infantry / 3);
RiziaDLC.Army_Unit_Tank_Total = RiziaDLC.War_Control_Skipped_Tank - (RiziaDLC.War_Control_Skipped_Tank / 3);
RiziaDLC.Army_Unit_Support_Total = RiziaDLC.War_Control_Skipped_Support - (RiziaDLC.War_Control_Skipped_Support / 3);
RiziaDLC.Army_Unit_Ship_Total = RiziaDLC.War_Control_Skipped_Ship - (RiziaDLC.War_Control_Skipped_Ship / 3);
RiziaDLC.Army_Unit_Submarine_Total = RiziaDLC.War_Control_Skipped_Submarine - (RiziaDLC.War_Control_Skipped_Submarine / 3);
RiziaDLC.Army_Unit_Azaro_Total = RiziaDLC.War_Control_Skipped_Azaro - (RiziaDLC.War_Control_Skipped_Azaro / 3);
RiziaDLC.Army_Unit_Flagship_Total = RiziaDLC.War_Control_Skipped_Flagship - (RiziaDLC.War_Control_Skipped_Flagship / 3);
RiziaDLC.Army_Unit_GoldenGuard_Total = RiziaDLC.War_Control_Skipped_GoldenGuard - (RiziaDLC.War_Control_Skipped_GoldenGuard / 3);
RiziaDLC.Army_Unit_Marine_Total = RiziaDLC.War_Control_Skipped_Marine - (RiziaDLC.War_Control_Skipped_Marine / 3);
RiziaDLC.Army_Unit_Mercenary_Total = RiziaDLC.War_Control_Skipped_Mercenary - (RiziaDLC.War_Control_Skipped_Mercenary / 3);
RiziaDLC.Army_Unit_Mountaineer_Total = RiziaDLC.War_Control_Skipped_Mountaineer - (RiziaDLC.War_Control_Skipped_Mountaineer / 3);
RiziaDLC.Army_Unit_Paratrooper_Total = RiziaDLC.War_Control_Skipped_Paratrooper - (RiziaDLC.War_Control_Skipped_Paratrooper / 3);
RiziaDLC.Army_Unit_Sazon_Total = RiziaDLC.War_Control_Skipped_Sazon - (RiziaDLC.War_Control_Skipped_Sazon / 3);`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] = Variable["RiziaDLC.War_Control_Skipped_Infantry"] - (Variable["RiziaDLC.War_Control_Skipped_Infantry"] / 3);
Variable["RiziaDLC.Army_Unit_Tank_Total"] = Variable["RiziaDLC.War_Control_Skipped_Tank"] - (Variable["RiziaDLC.War_Control_Skipped_Tank"] / 3);
Variable["RiziaDLC.Army_Unit_Support_Total"] = Variable["RiziaDLC.War_Control_Skipped_Support"] - (Variable["RiziaDLC.War_Control_Skipped_Support"] / 3);
Variable["RiziaDLC.Army_Unit_Ship_Total"] = Variable["RiziaDLC.War_Control_Skipped_Ship"] - (Variable["RiziaDLC.War_Control_Skipped_Ship"] / 3);
Variable["RiziaDLC.Army_Unit_Submarine_Total"] = Variable["RiziaDLC.War_Control_Skipped_Submarine"] - (Variable["RiziaDLC.War_Control_Skipped_Submarine"] / 3);
Variable["RiziaDLC.Army_Unit_Azaro_Total"] = Variable["RiziaDLC.War_Control_Skipped_Azaro"] - (Variable["RiziaDLC.War_Control_Skipped_Azaro"] / 3);
Variable["RiziaDLC.Army_Unit_Flagship_Total"] = Variable["RiziaDLC.War_Control_Skipped_Flagship"] - (Variable["RiziaDLC.War_Control_Skipped_Flagship"] / 3);
Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] = Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] - (Variable["RiziaDLC.War_Control_Skipped_GoldenGuard"] / 3);
Variable["RiziaDLC.Army_Unit_Marine_Total"] = Variable["RiziaDLC.War_Control_Skipped_Marine"] - (Variable["RiziaDLC.War_Control_Skipped_Marine"] / 3);
Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable["RiziaDLC.War_Control_Skipped_Mercenary"] - (Variable["RiziaDLC.War_Control_Skipped_Mercenary"] / 3);
Variable["RiziaDLC.Army_Unit_Mountaineer_Total"] = Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] - (Variable["RiziaDLC.War_Control_Skipped_Mountaineer"] / 3);
Variable["RiziaDLC.Army_Unit_Paratrooper_Total"] = Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] - (Variable["RiziaDLC.War_Control_Skipped_Paratrooper"] / 3);
Variable["RiziaDLC.Army_Unit_Sazon_Total"] = Variable["RiziaDLC.War_Control_Skipped_Sazon"] - (Variable["RiziaDLC.War_Control_Skipped_Sazon"] / 3);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead = 10;"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_LowerConscriptionAge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_LowerConscriptionAge == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_LowerConscriptionAge == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_LowerConscriptionAge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_LowerConscriptionAge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "I wasn't sure if it was my imagination, but I thought I h..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_LowerConscriptionAge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_LowerConscriptionAge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "I wasn't sure if it was my imagination, but I thought I h..."*)

### Węzeł `[225]`
Mówca: **Narrator**
> "I wasn't sure if it was my imagination, but I thought I heard a gulp from the soldier standing behind me. He was a youngster, barely 24, all skin and bones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""Invite this soldier to dine with us, General.""*)
  - -> `[35]` (*Player_Romus: ""I will dine together with the soldiers in the barracks.""*)
  - -> `[42]` (*Player_Romus: ""I would have preferred a tablecloth, but I suppose this ..."*)

### Węzeł `[226]`
Mówca: **Narrator**
> "Her father saluted once more from his wheelchair as an aide rolled him out. Carlos took his leave as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro"); RemoveConversant("Carl..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "My war councilor and I regarded each other in silence."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This feels right. The two of us, fighting side by side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Lucita Azaro: ""Fighting and winning.""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro"); RemoveConversant("Tadde..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro"); RemoveConversant("Tadde..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "My war councilor and I looked at each other in silence. I..."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "My war councilor and I looked at each other in silence. It was hard to read her expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true"*)
  - -> `[290]` (*Player_Romus: ""You're dismissed, Councilor.""*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[237]`
Mówca: **Narrator**
> "Taddeus looked back at me remorsefully as he rolled his wheelchair out. Carlos took his leave as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[238]`
Mówca: **Narrator**
> "My war councilor and I regarded each other in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""You should get going. Duty calls.""*)
  - -> `[228]` (*Player_Romus: ""This feels right. The two of us, fighting side by side.""*)
  - -> `[239]` (*Player_Romus: ""Give it to me straight, Luce. Are you sure we can win?""*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give it to me straight, Luce. Are you sure we can win?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucita Azaro: ""I've never been more sure of anything else in my life.""*)

### Węzeł `[240]`
Mówca: **Lucita Azaro**
> ""Fighting and winning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neither of you mentioned Vina.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Her expression grew somber."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player_Romus: ""Neither of you mentioned Vina.""*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""I've never been more sure of anything else in my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Lucita Azaro: ""Except...""*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Her expression grew somber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_WrongIntel == true"*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should get going. Duty calls.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lucita Azaro: ""And I will answer, my king.""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_WrongIntel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_WrongIntel == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_WrongIntel == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_WrongIntel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_WrongIntel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Lucita Azaro: ""We have it on good authority that she's being kept in So..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_WrongIntel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_WrongIntel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Lucita Azaro: ""The Princess is at the forefront of all of our minds. We..."*)

### Węzeł `[251]`
Mówca: **Lucita Azaro**
> ""We have it on good authority that she's being kept in Solles. We should be able to get her out soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "She clasped her arms around my neck and whispered into my..."*)

### Węzeł `[252]`
Mówca: **Lucita Azaro**
> ""The Princess is at the forefront of all of our minds. We won't rest until she's found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "She clasped her arms around my neck and whispered into my..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "Her medals clinked against mine as she leaned in for a kiss."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Her medals bumped against my chest as she leaned in for a..."*)

### Węzeł `[256]`
Mówca: **Narrator**
> "Her medals clinked against mine as she leaned in for a kiss."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Lucita stepped back and took a last fond look at me befor..."*)

### Węzeł `[257]`
Mówca: **Narrator**
> "Her medals bumped against my chest as she leaned in for a kiss."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Lucita stepped back and took a last fond look at me befor..."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "She clasped her arms around my neck and whispered into my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Lucita Azaro: ""For every hair they touch on her head, I'll kill a dozen..."*)

### Węzeł `[259]`
Mówca: **Lucita Azaro**
> ""Except...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""For every hair they touch on her head, I'll kill a dozen of them myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Lucita stepped back and took a last fond look at me befor..."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "Lucita stepped back and took a last fond look at me before running to join her father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""And I will answer, my king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Lucita stepped back and took a last fond look at me befor..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro"); RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1Briefing_Frontline == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "Everyone was quiet as they left, leaving me all alone wit..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1Briefing_Frontline == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Everyone was quiet as they left, leaving me with my thoug..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know your father, Lucita. A show of power is the only thing a man like that understands.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true`
- **Kontekst wejściowy (poprzednik):** `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "She shook her head."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have a problem with how I handle things?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true`
- **Kontekst wejściowy (poprzednik):** `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "She shook her head."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Disgraced == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player_Romus: ""I know your father, Lucita. A show of power is the only ..."*)
  - -> `[269]` (*Player_Romus: ""Do you have a problem with how I handle things?""*)
  - -> `[279]` (*Player_Romus: ""I'm sorry, Luce. I don't know what came over me.""*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Disgraced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: ""We have to win this, Luce. I can't afford a loss.""*)
  - -> `[293]` (*Player_Romus: ""Give it to me straight. How screwed are we?""*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neither of you mentioned Vina.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Her expression grew determined."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player_Romus: ""Neither of you mentioned Vina.""*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[277]`
Mówca: **Narrator**
> "Her expression grew determined."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lucita Azaro: ""The Princess is at the forefront of all of our minds. We..."*)

### Węzeł `[278]`
Mówca: **Lucita Azaro**
> ""The Princess is at the forefront of all of our minds. We won't rest until she's found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucita Azaro: ""For every hair they touch on her head, I'll kill a dozen..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Luce. I don't know what came over me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true`
- **Kontekst wejściowy (poprzednik):** `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "She squeezed my hand and shook her head sadly."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "She shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn08_PalesWarPostOp_DisgracedSorry = true;"*)

### Węzeł `[281]`
Mówca: **Lucita Azaro**
> ""It was your right to discipline him. Two major losses in two wars against Pales is unforgivable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Lucita Azaro: ""But I'm begging you, Romus. Leave us Azaros to handle ou..."*)

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""But I'm begging you, Romus. Leave us Azaros to handle our own affairs. Don't bring more public disgrace to our house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "She took a sad last look at me before running to join her..."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "She squeezed my hand and shook her head sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Lucita Azaro: ""It was your right to discipline him. Two major losses in..."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "She took a sad last look at me before running to join her father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have to win this, Luce. I can't afford a loss.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "A grim look of determination spread on her face."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "A grim look of determination spread on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucita Azaro: ""We'll do whatever it takes, Romus. Just trust in your mi..."*)

### Węzeł `[287]`
Mówca: **Lucita Azaro**
> ""We'll do whatever it takes, Romus. Just trust in your military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "She gave my hand a quick squeeze before running out to jo..."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "She gave my hand a quick squeeze before running out to join her father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[289]`
Mówca: **Lucita Azaro**
> ""For every hair they touch on her head, I'll kill a dozen of them. Personally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "She took a sad last look at me before running to join her..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're dismissed, Councilor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucita Azaro: ""Of-- of course.""*)

### Węzeł `[291]`
Mówca: **Lucita Azaro**
> ""Of-- of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lucita Azaro: ""I'm sorry we failed you, Your Majesty.""*)

### Węzeł `[292]`
Mówca: **Lucita Azaro**
> ""I'm sorry we failed you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn08_PalesWarPostOp_DismissedAzaro = true"*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give it to me straight. How screwed are we?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lucita Azaro: ""There's always hope, Your Majesty. Just trust in your mi..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn08_PalesWarPostOp_DismissedAzaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn08_PalesWarPostOp_DismissedAzaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "She took a sad last look at me before running to join her..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn08_PalesWarPostOp_DisgracedSorry = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn08_PalesWarPostOp_DisgracedSorry"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Lucita Azaro: ""It was your right to discipline him. Two major losses in..."*)

### Węzeł `[296]`
Mówca: **Lucita Azaro**
> ""There's always hope, Your Majesty. Just trust in your military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "She gave my hand a quick squeeze before running out to jo..."*)

### Węzeł `[297]`
Mówca: **Taddeus Azaro**
> ""I hold myself entirely responsible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Carlos Robles Azaro: ""I stand by Taddeus in this, Your Majesty. We are both ac..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""We shall all return to the bosom of our God one way or a..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[301]`
Mówca: **Carlos Robles Azaro**
> ""He's being recommended for the Star of Valor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "The Star of Valor was Rizia’s highest military honor."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "She gave a respectful nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""Thank God. I was about to die from boredom. General?""*)
  - -> `[56]` (*Player_Romus: ""Now that you're here, we can begin.""*)
  - -> `[58]` (*Player_Romus: ""Proceed.""*)

### Węzeł `[303]`
Mówca: **Narrator**
> "The Star of Valor was Rizia’s highest military honor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The giant knelt before me obediently."*)

### Węzeł `[304]`
Mówca: **Carlos Robles Azaro**
> ""Well, if you had listened to my advice in the first place-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "A scream cut through his words. A soldier on a stretcher ..."*)

### Węzeł `[305]`
Mówca: **Carlos Robles Azaro**
> ""I stand with Taddeus. This is not your doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Taddeus Azaro: ""Nevertheless, your presence here is already helping with..."*)

### Węzeł `[306]`
Mówca: **Carlos Robles Azaro**
> ""I stand by Taddeus in this, Your Majesty. We are both accountable for what has transpired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Taddeus Azaro: ""Nevertheless, your presence here is already helping with..."*)

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""Your Majesty. Father. General Carlos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "She gave a respectful nod."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "She gave a respectful nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player_Romus: ""General Azaro, please start.""*)
  - -> `[132]` (*Player_Romus: ""Now that you are here, we can begin.""*)
  - -> `[133]` (*Player_Romus: ""Proceed.""*)

### Węzeł `[309]`
Mówca: **Carlos Robles Azaro**
> ""Pleasure as always, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Taddeus Azaro: ""I just returned from the frontline today, bearing news.""*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Debriefing at the Palesian-Rizian front", "Havas", "Kingdom of Rizia");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Debriefing at the Palesian-Rizian front","Havas","Kingdom of Rizia");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Debriefing on the Palesian-Rizian war", "Council Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Debriefing on the Palesian-Rizian war","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I pushed open the large doors to the War Room and stepped..."*)
