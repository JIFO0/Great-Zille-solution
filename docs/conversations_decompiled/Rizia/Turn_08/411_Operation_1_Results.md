# Rizia/Turn 8/Operation 1 Results

- **ID konwersacji:** `411`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/411_Operation_1_Results.md`
- **Liczba węzłów dialogowych:** 310
- **Liczba wyborów gracza:** 32

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
- `RiziaDLC.Army_Unit_Azaro_Dead`
- `RiziaDLC.Army_Unit_GrandTotal_Total`
- `RiziaDLC.Army_Unit_Sazon_Dead`
- `RiziaDLC.Army_Unit_Toras_Dead`
- `RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Resources_Military_Equipment`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.War_Objective_Captured_Arces`
- `RiziaDLC.War_Objective_Captured_FortAles`
- `RiziaDLC.War_Objective_Captured_Terador`
- `RiziaDLC.War_Objective_Captured_Ziqes`
- `RiziaDLC.War_Operation1Briefing_Frontline`
- `RiziaDLC.War_Operation1_TotalEnemy_Dead`
- `RiziaDLC.War_Operation1_TotalPlayer_Dead`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.War_Pales_PublicWarSupport`
- `RiziaDLC.War_Pales_Resistance`
- `RiziaDLCIsolated.Taddeus_MedalsRipped`
- `RiziaDLCIsolated.Turn08_OperationResult_HouseUnits`
- `RiziaDLCIsolated.Turn08_OperationResult_Numbers`
- `RiziaDLCIsolated.Turn08_OperationResult_Objectives`
- `RiziaDLCIsolated.Turn08_OperationResult_Resistance`
- `RiziaDLCIsolated.Turn08_OperationResult_WarSupport`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLCIsolated.Taddeus_MedalsRipped`
- `RiziaDLCIsolated.Turn08_OperationResult_HouseUnits`
- `RiziaDLCIsolated.Turn08_OperationResult_Numbers`
- `RiziaDLCIsolated.Turn08_OperationResult_Objectives`
- `RiziaDLCIsolated.Turn08_OperationResult_Resistance`
- `RiziaDLCIsolated.Turn08_OperationResult_WarSupport`
- `RiziaDLCSupport.Journal_Turn08_PostOperation1_DisgracedTaddeus`
- `RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationLost`
- `RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationWon`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[412] Rizia/Turn 8/Operation 2 Next Steps** (../Turn_08/412_Operation_2_Next_Steps.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[56]` | **""I have heard enough.""** | `[42]` **Narrator**: "He handed me a stack of papers d..."<br>`[78]` **Lucita Azaro**: ""Unfortunately, the Palesians ar..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`<br>`Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false` | *Brak zmian stanu* | `[139]` **Narrator**: "The room fell silent. Lucita spo..." |
| `[57]` | **""Tell me about our numbers. How many troops do we have? How many have we lost?""** | `[42]` **Narrator**: "He handed me a stack of papers d..."<br>`[78]` **Lucita Azaro**: ""Unfortunately, the Palesians ar..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers...` | `[12]` **Taddeus Azaro**: ""We currently have more than 20 ..."<br>`[19]` **Taddeus Azaro**: ""We currently have more than 15 ..." |
| `[58]` | **""What have we captured so far?""** | `[42]` **Narrator**: "He handed me a stack of papers d..."<br>`[78]` **Lucita Azaro**: ""Unfortunately, the Palesians ar..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Objecti...` | `[89]` **Carlos Robles Azaro**: ""We have taken Arces and Ziqes. ..."<br>`[93]` **Carlos Robles Azaro**: ""We have taken Arces. New forwar..." |
| `[59]` | **""Are we seeing a lot of resistance from the civilian population?""** | `[42]` **Narrator**: "He handed me a stack of papers d..."<br>`[78]` **Lucita Azaro**: ""Unfortunately, the Palesians ar..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Resista...` | `[123]` **Taddeus Azaro**: ""A sizeable resistance is growin..."<br>`[124]` **Taddeus Azaro**: ""Yes, sire. But all within our e..."<br>*(oraz 1 innych odgałęzień)* |
| `[60]` | **""Tell me about public opinion back home. What do Rizians think about the war?""** | `[42]` **Narrator**: "He handed me a stack of papers d..."<br>`[78]` **Lucita Azaro**: ""Unfortunately, the Palesians ar..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupp...` | `[133]` **Lucita Azaro**: ""The people are on our side, You..."<br>`[134]` **Lucita Azaro**: ""General sentiment seems to be a..." |
| `[97]` | **""ENOUGH, DAMN YOU!""** | `[42]` **Narrator**: "He handed me a stack of papers d..."<br>`[78]` **Lucita Azaro**: ""Unfortunately, the Palesians ar..."<br>*(oraz 13 innych węzłów)* | `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`<br>`Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false` | *Brak zmian stanu* | `[139]` **Narrator**: "The room fell silent. Lucita spo..." |
| `[98]` | **""I see. Go on.""** | `[42]` **Narrator**: "He handed me a stack of papers d..."<br>`[78]` **Lucita Azaro**: ""Unfortunately, the Palesians ar..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false` | *Brak zmian stanu* | `[140]` **Carlos Robles Azaro**: ""If you please, Your Majesty, we..." |
| `[157]` | **""I will do whatever I can to support the army.""** | `[156]` **Taddeus Azaro**: ""Your Majesty, one thing is cert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Carlos Robles Azaro**: ""Thank you, Your Majesty."" |
| `[158]` | **""I hear you two. You do your part and I will do mine.""** | `[156]` **Taddeus Azaro**: ""Your Majesty, one thing is cert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Carlos Robles Azaro**: ""Thank you, Your Majesty."" |
| `[159]` | **""We also can't win this war without able and capable generals.""** | `[156]` **Taddeus Azaro**: ""Your Majesty, one thing is cert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Narrator**: "There was no response." |
| `[169]` | **"Press the seal on the wax."** | `[168]` **Narrator**: "General Azaro handed me a large ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Taddeus Azaro**: ""Thank you, sire."" |
| `[171]` | **""You have done well. I am proud of all of you. Not only for your exemplary service..."** | `[170]` **Taddeus Azaro**: ""Thank you, sire."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Taddeus Azaro**: ""That is very touching, Your Maj..." |
| `[172]` | **""Thank *you* for your service to the crown.""** | `[170]` **Taddeus Azaro**: ""Thank you, sire."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Taddeus Azaro**: ""I serve and obey."" |
| `[173]` | **""Bring me victory, and only victory.""** | `[170]` **Taddeus Azaro**: ""Thank you, sire."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Taddeus Azaro**: ""Understood, Your Majesty."" |
| `[174]` | **""I will not allow any failures. Do you understand?""** | `[170]` **Taddeus Azaro**: ""Thank you, sire."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Taddeus Azaro**: ""Understood, Your Majesty."" |
| `[188]` | **""Get up, General. A man of your stature should not humiliate himself like this.""** | `[187]` **Taddeus Azaro**: ""Do what you will with me. I lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Taddeus Azaro**: ""This war should have been ours ..." |
| `[189]` | **""If you think this will convince me to spare you, you are wrong.""** | `[187]` **Taddeus Azaro**: ""Do what you will with me. I lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Taddeus Azaro**: ""This war should have been ours ..." |
| `[191]` | **""My mercy? What kind of king do you think I am?""** | `[187]` **Taddeus Azaro**: ""Do what you will with me. I lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Taddeus Azaro**: ""This war should have been ours ..." |
| `[192]` | **""Fix your mess, General. That is all I care about.""** | `[187]` **Taddeus Azaro**: ""Do what you will with me. I lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Taddeus Azaro**: ""This war should have been ours ..." |
| `[197]` | **"Slap him."** | `[196]` **Taddeus Azaro**: ""Your Majesty?"" | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[201]` **Taddeus Azaro**: ""I accept and respect your punis..." |
| `[198]` | **""You will receive no punishment. You will continue working for the Crown. That is ..."** | `[196]` **Taddeus Azaro**: ""Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Taddeus Azaro**: ""You are too kind to me, Your Ma..." |
| `[199]` | **"Rip his medals off."** | `[196]` **Taddeus Azaro**: ""Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Taddeus Azaro**: ""So this is my punishment. I hav..." |
| `[204]` | **""I know that you will.""** | `[202]` **Taddeus Azaro**: ""I will redeem myself to you. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Taddeus Azaro**: ""Yes, my liege."" |
| `[205]` | **""I am bored of this charade. I don't have all day. Keep going with your briefing.""** | `[202]` **Taddeus Azaro**: ""I will redeem myself to you. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Taddeus Azaro**: ""Yes, my liege."" |
| `[206]` | **""Do not be so harsh on yourself, General. It's bad for morale.""** | `[202]` **Taddeus Azaro**: ""I will redeem myself to you. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Taddeus Azaro**: ""Yes, my liege."" |
| `[218]` | **""You can and you will. Do not question my authority.""** | `[219]` **Lucita Azaro**: ""I cannot just sit idly by and t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Lucita Azaro**: ""You insulted my father. How am ..." |
| `[220]` | **""Then make General Taddeus earn his rank. All I see is failure upon failure.""** | `[219]` **Lucita Azaro**: ""I cannot just sit idly by and t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Lucita Azaro**: ""That problem is mine to handle...." |
| `[221]` | **""You dare defy me? Your King?""** | `[219]` **Lucita Azaro**: ""I cannot just sit idly by and t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Taddeus Azaro**: ""Please, sire. She did not mean ..." |
| `[222]` | **""I'm sorry. You are right. I made a rash decision.""** | `[219]` **Lucita Azaro**: ""I cannot just sit idly by and t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Lucita Azaro**: ""God. How could you do this to a..." |
| `[236]` | **""Listen to your daughter, General.""** | `[196]` **Taddeus Azaro**: ""Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Taddeus Azaro**: ""As you wish, Your Majesty."" |
| `[241]` | **""Don't forget that both of you are responsible for this failure.""** | `[202]` **Taddeus Azaro**: ""I will redeem myself to you. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Taddeus Azaro**: ""We understand, Your Majesty."" |
| `[303]` | **""What of our provincial forces?""** | `[42]` **Narrator**: "He handed me a stack of papers d..."<br>`[78]` **Lucita Azaro**: ""Unfortunately, the Palesians ar..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUnits"] == false  and  (Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies"] == false  and  Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true)` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUn...` | `[276]` **Taddeus Azaro**: ""House Sazon’s troops are still ..."<br>`[280]` **Taddeus Azaro**: ""House Sazon held their ground a..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[3]` (*Taddeus Azaro: ""To put it simply...""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Taddeus Azaro**
> ""To put it simply...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Taddeus Azaro: ""We are winning this war.""*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Taddeus Azaro: ""The operation is not going well.""*)

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""We are winning this war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationWo..."*)

### Węzeł `[8]`
Mówca: **Taddeus Azaro**
> ""The operation is not going well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationLo..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_GrandTotal_Total >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_GrandTotal_Total >= 20"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_GrandTotal_Total >= 20)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_GrandTotal_Total >= 20`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Taddeus Azaro: ""We currently have more than 20 operational groups in tot..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_GrandTotal_Total >= 20)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_GrandTotal_Total >= 15"*)

### Węzeł `[12]`
Mówca: **Taddeus Azaro**
> ""We currently have more than 20 operational groups in total, including our naval forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_GrandTotal_Total >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_GrandTotal_Total >= 15"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_GrandTotal_Total >= 15)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_GrandTotal_Total >= 15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Taddeus Azaro: ""We currently have more than 15 operational groups in tot..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_GrandTotal_Total >= 15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_GrandTotal_Total >= 10"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_GrandTotal_Total >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_GrandTotal_Total >= 10"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_GrandTotal_Total >= 10)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_GrandTotal_Total >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Taddeus Azaro: ""We currently have less than 15 operational groups in tot..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_GrandTotal_Total >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Taddeus Azaro: ""We currently have less than 10 operational groups in tot..."*)

### Węzeł `[19]`
Mówca: **Taddeus Azaro**
> ""We currently have more than 15 operational groups in total, including our navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20"*)

### Węzeł `[20]`
Mówca: **Taddeus Azaro**
> ""We currently have less than 15 operational groups in total, including our navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20"*)

### Węzeł `[21]`
Mówca: **Taddeus Azaro**
> ""We currently have less than 10 operational groups in total, including our navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Taddeus Azaro: ""This operation has cost us many lives. Around 20 divisio..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Taddeus Azaro: ""This operation has cost us more lives than expected. Aro..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Taddeus Azaro: ""Meanwhile, around 10 divisions have perished on the batt..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Taddeus Azaro: ""Thankfully, we had minimal casualties on the battlefield.""*)

### Węzeł `[31]`
Mówca: **Taddeus Azaro**
> ""This operation has cost us many lives. Around 20 divisions have perished on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20"*)

### Węzeł `[32]`
Mówca: **Taddeus Azaro**
> ""This operation has cost us more lives than expected. Around 15 divisions have perished on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20"*)

### Węzeł `[33]`
Mówca: **Taddeus Azaro**
> ""Meanwhile, around 10 divisions have perished on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20"*)

### Węzeł `[34]`
Mówca: **Taddeus Azaro**
> ""Thankfully, we had minimal casualties on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Operation 1 Results Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Numbers == false"*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == fal..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Objectives == false"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Resistance == false"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Numbers == true |..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Numbers == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Numbers == false"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Numbers == false)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Numbers == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""Tell me about our numbers. How many troops do we have? H..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Numbers == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Objectives == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Objectives == false"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Objectives == f..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Objectives == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""What have we captured so far?""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Objectives == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Narrator**
> "He handed me a stack of papers detailing the operation results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Operation 1 Results Hub"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Resistance == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Resistance == false"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Resistance == f..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Resistance == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""Are we seeing a lot of resistance from the civilian popu..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Resistance == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_WarSupport == f..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Tell me about public opinion back home. What do Rizians ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Numbers = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_GrandTotal_Total >= 20"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Objectives = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Resistance = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Resistance >= 2"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_WarSupport = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_PublicWarSupport > 0"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Numbers == true || RiziaDLCIsolated.Turn08_OperationResult_Objectives == true ||RiziaDLCIsolated.Turn08_OperationResult_Resistance == true ||RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Numbers == true |..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Numbers == true..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Numbers == true || RiziaDLCIsolated.Turn08_OperationResult_Objectives == true ||RiziaDLCIsolated.Turn08_OperationResult_Resistance == true ||RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[98]` (*Player_Romus: ""I see. Go on.""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Numbers == true || RiziaDLCIsolated.Turn08_OperationResult_Objectives == true ||RiziaDLCIsolated.Turn08_OperationResult_Resistance == true ||RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have heard enough.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true` AND `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[78]` (Lucita Azaro), `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The room fell silent. Lucita spoke after a few long seconds."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about our numbers. How many troops do we have? How many have we lost?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[78]` (Lucita Azaro), `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Numbers = true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What have we captured so far?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[78]` (Lucita Azaro), `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Objectives = true"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are we seeing a lot of resistance from the civilian population?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[78]` (Lucita Azaro), `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Resistance = true"*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about public opinion back home. What do Rizians think about the war?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[78]` (Lucita Azaro), `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_WarSupport = true"*)

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""Our intelligence reports indicate that the enemy has taken mass casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "She smiled proudly."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucita Azaro: ""Our intelligence reports indicate that the enemy has tak..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucita Azaro: ""Our intelligence reports indicate that the enemy has tak..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucita Azaro: ""Our intelligence reports indicate that the enemy has tak..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucita Azaro: ""Our intelligence reports indicate that the enemy has not..."*)

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""Our intelligence reports indicate that the enemy has taken many casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucita Azaro: ""The latest numbers state that we have successfully destr..."*)

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""Our intelligence reports indicate that the enemy has taken quite a few casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucita Azaro: ""The latest numbers state that we have successfully destr..."*)

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""The latest numbers state that we have successfully destroyed more than 20 divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucita Azaro: ""They're dropping like flies, Your Majesty. Left and right.""*)

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""Our intelligence reports indicate that the enemy has not taken many casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucita Azaro: ""The latest numbers state that we have successfully destr..."*)

### Węzeł `[75]`
Mówca: **Lucita Azaro**
> ""The latest numbers state that we have successfully destroyed more than 15 divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucita Azaro: ""Honestly, even I didn't think it would be this easy.""*)

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""The latest numbers state that we have successfully destroyed more than 10 divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucita Azaro: ""They are tough, but so are we.""*)

### Węzeł `[77]`
Mówca: **Lucita Azaro**
> ""The latest numbers state that we have successfully destroyed less than 10 divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucita Azaro: ""Unfortunately, the Palesians are tougher than we expected.""*)

### Węzeł `[78]`
Mówca: **Lucita Azaro**
> ""Unfortunately, the Palesians are tougher than we expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[79]`
Mówca: **Lucita Azaro**
> ""They are tough, but so are we.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""Honestly, even I didn't think it would be this easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""They're dropping like flies, Your Majesty. Left and right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Operation 1 Results Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Operation 1 Results Hub"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Arces == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Arces == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Arces == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Arces == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Arces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Carlos Robles Azaro: ""We have taken Arces. New forward operating bases have be..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Arces == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Arces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Ziqes == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Ziqes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Ziqes == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Ziqes == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Ziqes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Carlos Robles Azaro: ""We have taken Ziqes. New forward operating bases have be..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Ziqes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "Lucita drew a breath in through her teeth."*)

### Węzeł `[89]`
Mówca: **Carlos Robles Azaro**
> ""We have taken Arces and Ziqes. New forward operating bases have been set up nearby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false && Rizia..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC..."*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Arces == true && RiziaD..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Arces"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Carlos Robles Azaro: ""We have taken Arces and Ziqes. New forward operating bas..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Arces"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Arces == true"*)

### Węzeł `[93]`
Mówca: **Carlos Robles Azaro**
> ""We have taken Arces. New forward operating bases have been set up nearby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false && Rizia..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""I have heard enough.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""ENOUGH, DAMN YOU!""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""ENOUGH, DAMN YOU!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false` AND `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[78]` (Lucita Azaro), `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The room fell silent. Lucita spoke after a few long seconds."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Go on.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[78]` (Lucita Azaro), `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Carlos Robles Azaro: ""If you please, Your Majesty, we need more manpower and e..."*)

### Węzeł `[99]`
Mówca: **Carlos Robles Azaro**
> ""We have taken Ziqes. New forward operating bases have been set up nearby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false && Rizia..."*)

### Węzeł `[100]`
Mówca: **Carlos Robles Azaro**
> ""Regretfully, we have yet to capture any of our main operation objectives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false && Rizia..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false && Rizia..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Terador == false && Riz..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] == false  and  Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Taddeus Azaro: ""With great sadness, I must also inform you that we have ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Terador"] == false  and  Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_FortAles == false"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_FortAles == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_FortAles == false"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_FortAles == false)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_FortAles == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Taddeus Azaro: ""With great sadness, I must also inform you that we have ..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_FortAles == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Terador == false)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Taddeus Azaro: ""With great sadness, I must also inform you that we have ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Terador == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Terador"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Taddeus Azaro: ""Despite the heavy fighting, Fort Ales and Terador are st..."*)

### Węzeł `[110]`
Mówca: **Taddeus Azaro**
> ""With great sadness, I must also inform you that we have lost control of Terador and Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Carlos Robles Azaro: ""A minor setback. I'm confident we'll regain the ground w..."*)

### Węzeł `[111]`
Mówca: **Taddeus Azaro**
> ""With great sadness, I must also inform you that we have lost control of Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Carlos Robles Azaro: ""A minor setback. I'm confident we'll regain the ground w..."*)

### Węzeł `[112]`
Mówca: **Taddeus Azaro**
> ""With great sadness, I must also inform you that we have lost control of Terador.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Carlos Robles Azaro: ""A minor setback. I'm confident we'll regain the ground w..."*)

### Węzeł `[113]`
Mówca: **Taddeus Azaro**
> ""Despite the heavy fighting, Fort Ales and Terador are still under our control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Carlos Robles Azaro: ""Our cities persevere.""*)

### Węzeł `[114]`
Mówca: **Carlos Robles Azaro**
> ""A minor setback. I'm confident we'll regain the ground we lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[115]`
Mówca: **Carlos Robles Azaro**
> ""Our cities persevere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Operation 1 Results Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Operation 1 Results Hub"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Resistance >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Resistance >= 2"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Resistance >= 2)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Resistance >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Resistance"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Taddeus Azaro: ""A sizeable resistance is growing, Your Majesty.""*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Resistance >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Resistance"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Resistance >= 1"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Resistance >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Resistance >= 1"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Resistance >= 1)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Resistance >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Resistance"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Taddeus Azaro: ""Yes, sire. But all within our expectations.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Resistance >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Resistance"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Taddeus Azaro: ""There doesn't seem to be much of it. It's as I suspected..."*)

### Węzeł `[123]`
Mówca: **Taddeus Azaro**
> ""A sizeable resistance is growing, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Carlos Robles Azaro: ""We're doing everything we can to keep it contained.""*)

### Węzeł `[124]`
Mówca: **Taddeus Azaro**
> ""Yes, sire. But all within our expectations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Carlos Robles Azaro: ""Nothing that we can't handle.""*)

### Węzeł `[125]`
Mówca: **Taddeus Azaro**
> ""There doesn't seem to be much of it. It's as I suspected -- Pales *wants* to rejoin Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Carlos Robles Azaro: ""Or we've simply intimidated civilians into submission. E..."*)

### Węzeł `[126]`
Mówca: **Carlos Robles Azaro**
> ""Or we've simply intimidated civilians into submission. Either way, this works in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[127]`
Mówca: **Carlos Robles Azaro**
> ""We're doing everything we can to keep it contained.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[128]`
Mówca: **Carlos Robles Azaro**
> ""Nothing that we can't handle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Operation 1 Results Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Operation 1 Results Hub"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_PublicWarSupport > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_PublicWarSupport > 0"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_PublicWarSupport > 0)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_PublicWarSupport > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_PublicWarSupport"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucita Azaro: ""The people are on our side, Your Majesty.""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_PublicWarSupport > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_PublicWarSupport"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucita Azaro: ""General sentiment seems to be against the war, Your Maje..."*)

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""The people are on our side, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucita Azaro: ""And the more we keep winning, the more their sympathies ..."*)

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""General sentiment seems to be against the war, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucita Azaro: ""But once we have a big win, I think the tide will change.""*)

### Węzeł `[135]`
Mówca: **Lucita Azaro**
> ""But once we have a big win, I think the tide will change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""And the more we keep winning, the more their sympathies will increase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Taddeus Azaro: ""Their strength keeps us strong. We will not lose.""*)

### Węzeł `[137]`
Mówca: **Taddeus Azaro**
> ""Their strength keeps us strong. We will not lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Operation 1 Results Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Operation 1 Results Hub"*)

### Węzeł `[139]`
Mówca: **Narrator**
> "The room fell silent. Lucita spoke after a few long seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Carlos Robles Azaro: ""If you please, Your Majesty, we need more manpower and e..."*)

### Węzeł `[140]`
Mówca: **Carlos Robles Azaro**
> ""If you please, Your Majesty, we need more manpower and equipment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Carlos Robles Azaro: ""We've achieved promising results, but we are not done yet.""*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Carlos Robles Azaro: ""This might be the only way we can regain our footing.""*)

### Węzeł `[144]`
Mówca: **Carlos Robles Azaro**
> ""This might be the only way we can regain our footing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower < 1000"*)

### Węzeł `[145]`
Mówca: **Carlos Robles Azaro**
> ""We've achieved promising results, but we are not done yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower < 1000"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower < 1000`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower < 1000"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Manpower < 1000)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower < 1000`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] < 1000`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Taddeus Azaro: ""Precisely. Our manpower is dwindling. New recruits would..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Manpower < 1000)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] < 1000) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Taddeus Azaro: ""Precisely. Additional recruits would provide valuable su..."*)

### Węzeł `[149]`
Mówca: **Taddeus Azaro**
> ""Precisely. Our manpower is dwindling. New recruits would provide valuable support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Equipment < 1000"*)

### Węzeł `[150]`
Mówca: **Taddeus Azaro**
> ""Precisely. Additional recruits would provide valuable support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Equipment < 1000"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Equipment < 1000`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Equipment < 1000"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Equipment < 1000)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Equipment < 1000`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Equipment"] < 1000`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Taddeus Azaro: "And of course, these troops will require more ammunition ..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Equipment < 1000)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Equipment"] < 1000) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Taddeus Azaro: ""And of course, these troops will require ammo and weapon..."*)

### Węzeł `[154]`
Mówca: **Taddeus Azaro**
> "And of course, these troops will require more ammunition and weapons. Our operation has nearly depleted our supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Taddeus Azaro: ""Your Majesty, one thing is certain. We can't win this wa..."*)

### Węzeł `[155]`
Mówca: **Taddeus Azaro**
> ""And of course, these troops will require ammo and weapons. We still have a decent stockpile, but more won't hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Taddeus Azaro: ""Your Majesty, one thing is certain. We can't win this wa..."*)

### Węzeł `[156]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, one thing is certain. We can't win this war without able and capable boots on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus: ""I hear you two. You do your part and I will do mine.""*)
  - -> `[157]` (*Player_Romus: ""I will do whatever I can to support the army.""*)
  - -> `[159]` (*Player_Romus: ""We also can't win this war without able and capable gene..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will do whatever I can to support the army.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Carlos Robles Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear you two. You do your part and I will do mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Carlos Robles Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We also can't win this war without able and capable generals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "There was no response."*)

### Węzeł `[160]`
Mówca: **Carlos Robles Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""The result of Golden Shield is clear, Your Majesty. We are on the right path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucita Azaro: ""As these documents outline, the operation has been a gre..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "There was no response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucita Azaro: ""The result of Golden Shield is clear, Your Majesty. We a..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucita Azaro: ""The result of Golden Shield is unfortunately clear, Your..."*)

### Węzeł `[166]`
Mówca: **Lucita Azaro**
> ""As these documents outline, the operation has been a great success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lucita Azaro: ""Before we discuss the next steps, we need your seal on t..."*)

### Węzeł `[167]`
Mówca: **Lucita Azaro**
> ""Before we discuss the next steps, we need your seal on the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "General Azaro handed me a large scroll and a candle for t..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "General Azaro handed me a large scroll and a candle for the wax. I opened it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus_Italic: "Press the seal on the wax."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "Press the seal on the wax."]** — Mówca: **Player_Romus_Italic**
> "I pressed my seal on the wax to approve."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Taddeus Azaro: ""Thank you, sire.""*)

### Węzeł `[170]`
Mówca: **Taddeus Azaro**
> ""Thank you, sire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Romus: ""Thank *you* for your service to the crown.""*)
  - -> `[174]` (*Player_Romus: ""I will not allow any failures. Do you understand?""*)
  - -> `[171]` (*Player_Romus: ""You have done well. I am proud of all of you. Not only f..."*)
  - -> `[173]` (*Player_Romus: ""Bring me victory, and only victory.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have done well. I am proud of all of you. Not only for your exemplary service, but on a personal level.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Taddeus Azaro: ""That is very touching, Your Majesty.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank *you* for your service to the crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Taddeus Azaro: ""I serve and obey.""*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bring me victory, and only victory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Taddeus Azaro: ""Understood, Your Majesty.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not allow any failures. Do you understand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Taddeus Azaro: ""Understood, Your Majesty.""*)

### Węzeł `[175]`
Mówca: **Taddeus Azaro**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Carlos Robles Azaro: ""Loud and clear.""*)

### Węzeł `[176]`
Mówca: **Taddeus Azaro**
> ""I serve and obey.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Carlos Robles Azaro: ""As do I.""*)

### Węzeł `[177]`
Mówca: **Taddeus Azaro**
> ""That is very touching, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together"*)

### Węzeł `[178]`
Mówca: **Carlos Robles Azaro**
> ""As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucita Azaro: ""Now. It's time for us to talk about our next steps.""*)

### Węzeł `[179]`
Mówca: **Carlos Robles Azaro**
> ""Loud and clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucita Azaro: ""Now. It's time for us to talk about our next steps.""*)

### Węzeł `[180]`
Mówca: **Lucita Azaro**
> ""Indeed. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Carlos Robles Azaro: ""Your words mean a great deal.""*)

### Węzeł `[181]`
Mówca: **Lucita Azaro**
> ""The result of Golden Shield is unfortunately clear, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucita Azaro: ""The operation was not a success.""*)

### Węzeł `[182]`
Mówca: **Lucita Azaro**
> ""The operation was not a success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "Before I could say anything, Taddeus turned to Carlos."*)

### Węzeł `[183]`
Mówca: **Taddeus Azaro**
> ""Lucita, help me down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucita Azaro: ""Father -- General, what are you-""*)

### Węzeł `[184]`
Mówca: **Lucita Azaro**
> ""Father -- General, what are you-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)

### Węzeł `[185]`
Mówca: **Narrator**
> "The old general descended from his wheelchair and knelt before me, pressing his forehead into the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Taddeus Azaro: ""My liege. My King. My lord. I have failed you.""*)

### Węzeł `[186]`
Mówca: **Taddeus Azaro**
> ""My liege. My King. My lord. I have failed you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Taddeus Azaro: ""Do what you will with me. I leave my life at your mercy.""*)

### Węzeł `[187]`
Mówca: **Taddeus Azaro**
> ""Do what you will with me. I leave my life at your mercy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""Get up, General. A man of your stature should not humili..."*)
  - -> `[189]` (*Player_Romus: ""If you think this will convince me to spare you, you are..."*)
  - -> `[192]` (*Player_Romus: ""Fix your mess, General. That is all I care about.""*)
  - -> `[191]` (*Player_Romus: ""My mercy? What kind of king do you think I am?""*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get up, General. A man of your stature should not humiliate himself like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Taddeus Azaro: ""This war should have been ours to win. I deserve punishm..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you think this will convince me to spare you, you are wrong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Taddeus Azaro: ""This war should have been ours to win. I deserve punishm..."*)

### Węzeł `[190]`
Mówca: **Taddeus Azaro**
> ""This war should have been ours to win. I deserve punishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He wouldn't budge. Lucita rolled her eyes in frustration."*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mercy? What kind of king do you think I am?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Taddeus Azaro: ""This war should have been ours to win. I deserve punishm..."*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fix your mess, General. That is all I care about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Taddeus Azaro: ""This war should have been ours to win. I deserve punishm..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "He wouldn't budge. Lucita rolled her eyes in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucita Azaro: ""Father. Stop your hysterics and allow me to help you bac..."*)

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""Father. Stop your hysterics and allow me to help you back into your chair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Taddeus Azaro: ""Silence, Lucita.""*)

### Węzeł `[195]`
Mówca: **Taddeus Azaro**
> ""Silence, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Taddeus Azaro: ""Your Majesty?""*)

### Węzeł `[196]`
Mówca: **Taddeus Azaro**
> ""Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player_Romus: ""Listen to your daughter, General.""*)
  - -> `[198]` (*Player_Romus: ""You will receive no punishment. You will continue workin..."*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[199]` (*Player_Romus_Italic: "Rip his medals off."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "Slap him."]** — Mówca: **Player_Romus_Italic**
> "I slapped him in fury. I heard gasps from everyone in the room."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[196]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Taddeus Azaro: ""I accept and respect your punishment, Your Majesty.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will receive no punishment. You will continue working for the Crown. That is all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Taddeus Azaro: ""You are too kind to me, Your Majesty. But I shall accept..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "Rip his medals off."]** — Mówca: **Player_Romus_Italic**
> "I walked up to him and ripped the medals off his uniform. I heard gasps from everyone in the room."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Taddeus Azaro: ""So this is my punishment. I have disgraced myself, my fa..."*)

### Węzeł `[200]`
Mówca: **Taddeus Azaro**
> ""You are too kind to me, Your Majesty. But I shall accept and respect your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Taddeus Azaro: ""I will redeem myself to you. This I promise in the name ..."*)

### Węzeł `[201]`
Mówca: **Taddeus Azaro**
> ""I accept and respect your punishment, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Lucita turned to me angrily."*)

### Węzeł `[202]`
Mówca: **Taddeus Azaro**
> ""I will redeem myself to you. This I promise in the name of House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""I know that you will.""*)
  - -> `[241]` (*Player_Romus: ""Don't forget that both of you are responsible for this f..."*)
  - -> `[205]` (*Player_Romus: ""I am bored of this charade. I don't have all day. Keep g..."*)
  - -> `[206]` (*Player_Romus: ""Do not be so harsh on yourself, General. It's bad for mo..."*)

### Węzeł `[203]`
Mówca: **Taddeus Azaro**
> ""So this is my punishment. I have disgraced myself, my family and my kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Taddeus_MedalsRipped = true;"*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that you will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Taddeus Azaro: ""Yes, my liege.""*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am bored of this charade. I don't have all day. Keep going with your briefing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Taddeus Azaro: ""Yes, my liege.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not be so harsh on yourself, General. It's bad for morale.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Taddeus Azaro: ""Yes, my liege.""*)

### Węzeł `[207]`
Mówca: **Taddeus Azaro**
> ""We understand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Lucita helped him back into his chair."*)

### Węzeł `[208]`
Mówca: **Taddeus Azaro**
> ""Yes, my liege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Lucita helped him back into his chair."*)

### Węzeł `[209]`
Mówca: **Lucita Azaro**
> ""Now. It's time for us to talk about our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Lucita helped him back into his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "AddConversant("Carlos Robles Azaro");"*)

### Węzeł `[211]`
Mówca: **Lucita Azaro**
> ""Rom-- Your Majesty! What have you just done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""Berate me for my failures if you wish. But to disgrace t..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Lucita turned to me angrily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced = true;"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lucita Azaro: ""Rom-- Your Majesty! What have you just done?""*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Lucita Azaro: ""Your Majesty! What have you just done?""*)

### Węzeł `[216]`
Mówca: **Lucita Azaro**
> ""Your Majesty! What have you just done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""Berate me for my failures if you wish. But to disgrace t..."*)

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""Berate me for my failures if you wish. But to disgrace the highest-ranking member of House Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucita Azaro: ""I cannot just sit idly by and take this.""*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can and you will. Do not question my authority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucita Azaro: ""You insulted my father. How am I supposed to react?""*)

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""I cannot just sit idly by and take this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: ""You can and you will. Do not question my authority.""*)
  - -> `[222]` (*Player_Romus: ""I'm sorry. You are right. I made a rash decision.""*)
  - -> `[220]` (*Player_Romus: ""Then make General Taddeus earn his rank. All I see is fa..."*)
  - -> `[221]` (*Player_Romus: ""You dare defy me? Your King?""*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then make General Taddeus earn his rank. All I see is failure upon failure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucita Azaro: ""That problem is mine to handle. I don't need your interv..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You dare defy me? Your King?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Taddeus Azaro: ""Please, sire. She did not mean it that way.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry. You are right. I made a rash decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""God. How could you do this to an old man? In a wheelchair?""*)

### Węzeł `[223]`
Mówca: **Taddeus Azaro**
> ""Please, sire. She did not mean it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Taddeus Azaro: ""Lucita. Apologize to your King this second.""*)

### Węzeł `[224]`
Mówca: **Taddeus Azaro**
> ""Lucita. Apologize to your King this second.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "She collected herself and spoke through gritted teeth."*)

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""That problem is mine to handle. I don't need your intervention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""God. How could you do this to an old man? In a wheelchair?""*)

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""God. How could you do this to an old man? In a wheelchair?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "She clutched her forehead and took a deep breath, forcing..."*)

### Węzeł `[227]`
Mówca: **Lucita Azaro**
> ""You insulted my father. How am I supposed to react?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""God. How could you do this to an old man? In a wheelchair?""*)

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""I am sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "A long, complete silence followed."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "She collected herself and spoke through gritted teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucita Azaro: ""I am sorry, Your Majesty.""*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Lucita Azaro: ""I will do what I must to make sure we win this war. Leav..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Lucita Azaro: ""Our troops can still win this, Your Majesty. Just give u..."*)

### Węzeł `[233]`
Mówca: **Lucita Azaro**
> ""I will do what I must to make sure we win this war. Leave my father out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "A long, complete silence followed."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Disgraced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_PostOperation1_DisgracedTa..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "A long, complete silence followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Taddeus Azaro: ""I will redeem myself to you. This I promise in the name ..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen to your daughter, General.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Taddeus Azaro: ""As you wish, Your Majesty.""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus_Italic: "Slap him."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[240]`
Mówca: **Taddeus Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Taddeus Azaro: ""I will redeem myself to you. This I promise in the name ..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't forget that both of you are responsible for this failure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Taddeus Azaro: ""We understand, Your Majesty.""*)

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""Can we please just move on, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Disgraced == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucita Azaro: ""Can we please just move on, Your Majesty?""*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Disgraced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucita Azaro: ""Now. It's time for us to talk about our next steps.""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationWon = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationWon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He handed me a stack of papers detailing the operation re..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationLost = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationLost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He handed me a stack of papers detailing the operation re..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_PostOperation1_DisgracedTaddeus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_DisgracedTaddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[249]`
Mówca: **Narrator**
> "She smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucita Azaro: ""The latest numbers state that we have successfully destr..."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "Lucita drew a breath in through her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Carlos Robles Azaro: ""Regretfully, we have yet to capture any of our main oper..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Lucita's eyes shone brightly."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucita Azaro: ""Indeed. Thank you.""*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Lucita's eyes shone brightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Lucita Azaro: ""Yes. Thank you.""*)

### Węzeł `[255]`
Mówca: **Lucita Azaro**
> ""Yes. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Carlos Robles Azaro: ""Your words mean a great deal.""*)

### Węzeł `[256]`
Mówca: **Narrator**
> "She clutched her forehead and took a deep breath, forcing herself to calm down. Taddeus kept his eyes on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[257]`
Mówca: **Lucita Azaro**
> ""Our troops can still win this, Your Majesty. Just give us a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "A long, complete silence followed."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1Briefing_Frontline == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "The old general descended from his wheelchair and knelt b..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1Briefing_Frontline == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "The old general descended from his wheelchair and knelt b..."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "The old general descended from his wheelchair and knelt before me, pressing his forehead to the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Taddeus Azaro: ""My liege. My King. My lord. I have failed you.""*)

### Węzeł `[262]`
Mówca: **Carlos Robles Azaro**
> ""Your words mean a great deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucita Azaro: ""Now. It's time for us to talk about our next steps.""*)

### Węzeł `[263]`
Mówca: **Narrator**
> "Before I could say anything, Taddeus turned to Carlos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Taddeus Azaro: ""Would you excuse us for a moment, General?""*)

### Węzeł `[264]`
Mówca: **Taddeus Azaro**
> ""Would you excuse us for a moment, General?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "Carlos gave him a questionable look."*)

### Węzeł `[265]`
Mówca: **Carlos Robles Azaro**
> ""If that is your wish, then certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "He bowed to me and then to Taddeus before stepping out of..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "He bowed to me and then to Taddeus before stepping out of the tent, confused. Taddeus tapped on his daughter's arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Carlos Robles Azaro");"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Carlos Robles Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Taddeus Azaro: ""Lucita, help me down.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Carlos Robles Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "Carlos was brought back into the room."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "Carlos was brought back into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Taddeus_MedalsRipped == true"*)

### Węzeł `[270]`
Mówca: **Narrator**
> "His expression was one of surprise as he glanced between Taddeus and Lucita, as if trying to decipher what had just taken place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Taddeus_MedalsRipped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Taddeus_MedalsRipped == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Taddeus_MedalsRipped == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Taddeus_MedalsRipped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Taddeus_MedalsRipped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "His eyes quickly took in the sight of Taddeus, noting tha..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Taddeus_MedalsRipped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Taddeus_MedalsRipped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "His expression was one of surprise as he glanced between ..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Taddeus_MedalsRipped = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Taddeus_MedalsRipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Lucita turned to me angrily."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "His eyes quickly took in the sight of Taddeus, noting that his medals had been stripped from his jacket -- a clear sign that something had just transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true"*)

### Węzeł `[276]`
Mówca: **Taddeus Azaro**
> ""House Sazon’s troops are still in perfect shape and ready to continue the fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Toras_Dead == 0"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Sazon_Dead == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Sazon_Dead == 0"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Sazon_Dead == 0)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Sazon_Dead == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Sazon_Dead"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Taddeus Azaro: ""House Sazon’s troops are still in perfect shape and read..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Sazon_Dead == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Sazon_Dead"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Sazon_Dead == 1"*)

### Węzeł `[280]`
Mówca: **Taddeus Azaro**
> ""House Sazon held their ground and made steady gains, though enemy resistance made progress difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Toras_Dead == 0"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Sazon_Dead == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Sazon_Dead == 1"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Sazon_Dead == 1)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Sazon_Dead == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Sazon_Dead"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Taddeus Azaro: ""House Sazon held their ground and made steady gains, tho..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Sazon_Dead == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Sazon_Dead"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Taddeus Azaro: ""House Sazon’s forces were completely overrun -- the surv..."*)

### Węzeł `[284]`
Mówca: **Taddeus Azaro**
> ""House Sazon’s forces were completely overrun -- the survivors are either captured or dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Toras_Dead == 0"*)

### Węzeł `[285]`
Mówca: **Taddeus Azaro**
> ""House Toras didn't suffer any losses, showcasing their efficiency and skill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead == 0"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Toras_Dead == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Toras_Dead == 0"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Toras_Dead == 0)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Toras_Dead == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Toras_Dead"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Taddeus Azaro: ""House Toras didn't suffer any losses, showcasing their e..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Toras_Dead == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Toras_Dead"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Toras_Dead == 1"*)

### Węzeł `[289]`
Mówca: **Taddeus Azaro**
> ""House Toras held the line with fierce determination, though advancing proved difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead == 0"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Toras_Dead == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Toras_Dead == 1"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Toras_Dead == 1)"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Toras_Dead == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Toras_Dead"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Taddeus Azaro: ""House Toras held the line with fierce determination, tho..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Toras_Dead == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Toras_Dead"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Taddeus Azaro: ""House Toras was annihilated. There are no reports of sur..."*)

### Węzeł `[293]`
Mówca: **Taddeus Azaro**
> ""House Toras was annihilated. There are no reports of survivors from their last position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead == 0"*)

### Węzeł `[294]`
Mówca: **Taddeus Azaro**
> ""House Azaro’s forces showed remarkable coordination, emerging unscathed so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Dead == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead == 0"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Azaro_Dead == 0)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Dead == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Taddeus Azaro: ""House Azaro’s forces showed remarkable coordination, eme..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Azaro_Dead == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead == 1"*)

### Węzeł `[298]`
Mówca: **Taddeus Azaro**
> ""House Azaro inflicted significant damage, but the enemy still holds strategic ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Dead == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead == 1"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Azaro_Dead == 1)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Dead == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Taddeus Azaro: ""House Azaro inflicted significant damage, but the enemy ..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Azaro_Dead == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Taddeus Azaro: ""House Azaro’s warriors are no more, but they perished as..."*)

### Węzeł `[302]`
Mówca: **Taddeus Azaro**
> ""House Azaro’s warriors are no more, but they perished as true sons of Rizia -- undaunted, outnumbered, and defiant to their last breath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 1 Results Hub]"*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What of our provincial forces?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUnits"] == false  and  (Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies"] == false  and  Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true)`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[78]` (Lucita Azaro), `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_HouseUnits = true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == false && (RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies == false && RiziaDLCIsolated.Turn08_OperationResult_Numbers == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == fal..."*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == f..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == false && (RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies == false && RiziaDLCIsolated.Turn08_OperationResult_Numbers == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUnits"] == false  and  (Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies"] == false  and  Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player_Romus: ""What of our provincial forces?""*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == false && (RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies == false && RiziaDLCIsolated.Turn08_OperationResult_Numbers == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUnits"] == false  and  (Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies"] == false  and  Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_HouseUnits = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUnits"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Sazon_Dead == 0"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Operation 1 Results Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Operation 1 Results Hub"*)

### Węzeł `[309]`
Mówca: **Narrator**
> "Carlos gave him a questionable look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Carlos Robles Azaro: ""If that is your wish, then certainly.""*)
