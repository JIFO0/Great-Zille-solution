# Rizia/Turn 8/Operation 2 Next Steps

- **ID konwersacji:** `412`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/412_Operation_2_Next_Steps.md`
- **Liczba węzłów dialogowych:** 278
- **Liczba wyborów gracza:** 30

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Effective`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.War_Control_Skipped`
- `RiziaDLC.War_Objective_Captured_Arces`
- `RiziaDLC.War_Objective_Captured_FortAles`
- `RiziaDLC.War_Objective_Captured_Terador`
- `RiziaDLC.War_Objective_Captured_Ziqes`
- `RiziaDLC.War_Pales_LespianSupport`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.Zille_Discovered_LespianInvolvement`
- `RiziaDLC.Zille_Publicized_LespianInvolvement`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Resources_Military_EnemyAirStrikeCount`
- `RiziaDLC.War_Operation2Loss_Charge`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust`
- `RiziaDLCSupport.Journal_Turn08_PostOperation1_Charge`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[410] Rizia/Turn 8/SnO_War_Pales_PostOperation1** (../Turn_08/410_SnO_War_Pales_PostOperation1.md), Węzeł `[174]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[40]` | **""Simply holding the line is unacceptable. We will push with whatever we have. Even..."** | `[50]` **Carlos Robles Azaro**: ""Unfortunately, we won't be able..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lucita Azaro**: ""Your Majesty... if we push hard..." |
| `[41]` | **""Then be the wall that protects the mainland. Do not let them pass under any condi..."** | `[50]` **Carlos Robles Azaro**: ""Unfortunately, we won't be able..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Taddeus Azaro**: ""As you wish, Your Majesty."" |
| `[42]` | **""I knew that our cause was just. We will take back what is rightfully ours.""** | `[38]` **Taddeus Azaro**: ""A complete victory is in sight,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Taddeus Azaro**: ""Yes, Your Majesty."" |
| `[43]` | **""Do not let this success get to your head, General. It is not over yet.""** | `[38]` **Taddeus Azaro**: ""A complete victory is in sight,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Taddeus Azaro**: ""Yes, Your Majesty."" |
| `[44]` | **""We will come at Pales until there is nothing left of it but ash and smoke.""** | `[38]` **Taddeus Azaro**: ""A complete victory is in sight,..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[49]` **Taddeus Azaro**: ""Yes, Your Majesty."" |
| `[48]` | **""We will deliver them their loss with honor and dignity as befits our position.""** | `[38]` **Taddeus Azaro**: ""A complete victory is in sight,..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[49]` **Taddeus Azaro**: ""Yes, Your Majesty."" |
| `[53]` | **""Cowards, all of you! Attack or I will have you lashed.""** | `[55]` **Carlos Robles Azaro**: ""Agreed. We should wait for more..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[235]` **Narrator**: "Everyone seemed taken aback, but..." |
| `[54]` | **""You may have a point. Very well. We will wait and see.""** | `[55]` **Carlos Robles Azaro**: ""Agreed. We should wait for more..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Taddeus Azaro**: ""As you wish, Your Majesty."" |
| `[59]` | **""Respectfully, General, I disagree. I order you to attack.""** | `[55]` **Carlos Robles Azaro**: ""Agreed. We should wait for more..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "Everyone seemed taken aback, but..." |
| `[140]` | **""Was this all a mistake?""** | `[138]` **Taddeus Azaro**: ""Do you have any questions for u..."<br>`[167]` **Taddeus Azaro**: ""We will, Your Majesty. We must.""<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mi...` | `[168]` **Taddeus Azaro**: ""My King..."" |
| `[141]` | **""Can we win this war?""** | `[138]` **Taddeus Azaro**: ""Do you have any questions for u..."<br>`[167]` **Taddeus Azaro**: ""We will, Your Majesty. We must.""<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Ca...` | `[166]` **Lucita Azaro**: ""If we can get rid of this gridl..." |
| `[142]` | **""How much longer will we have to keep fighting?""** | `[138]` **Taddeus Azaro**: ""Do you have any questions for u..."<br>`[167]` **Taddeus Azaro**: ""We will, Your Majesty. We must.""<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Wa...` | `[170]` **Taddeus Azaro**: ""It's difficult to say. It certa..." |
| `[143]` | **""How can we prevent Lespia from helping Pales?""** | `[138]` **Taddeus Azaro**: ""Do you have any questions for u..."<br>`[167]` **Taddeus Azaro**: ""We will, Your Majesty. We must.""<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Pr...` | `[262]` **Lucita Azaro**: ""I'll remind you that we do have..."<br>`[172]` **Lucita Azaro**: ""We can only hope."" |
| `[163]` | **""Those were all my questions.""** | `[138]` **Taddeus Azaro**: ""Do you have any questions for u..."<br>`[167]` **Taddeus Azaro**: ""We will, Your Majesty. We must.""<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == true` | *Brak zmian stanu* | `[216]` **Taddeus Azaro**: ""Then thank you for your time, Y..." |
| `[164]` | **""No, I don't.""** | `[138]` **Taddeus Azaro**: ""Do you have any questions for u..."<br>`[167]` **Taddeus Azaro**: ""We will, Your Majesty. We must.""<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == true) == false` | *Brak zmian stanu* | `[216]` **Taddeus Azaro**: ""Then thank you for your time, Y..." |
| `[173]` | **""Can we trust the intelligence you have received?""** | `[130]` **Taddeus Azaro**: ""Do you have any questions, Your..."<br>`[200]` **Carlos Robles Azaro**: ""If we can make it through their..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_Int...` | `[207]` **Lucita Azaro**: ""We can absolutely trust it, You..."<br>`[208]` **Lucita Azaro**: ""We should be able to trust it, ..."<br>*(oraz 1 innych odgałęzień)* |
| `[174]` | **""How long until total victory?""** | `[224]` **Lucita Azaro**: ""Soon, Your Majesty.""<br>`[225]` **Lucita Azaro**: ""We will fight in his honor.""<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_How...` | `[199]` **Taddeus Azaro**: ""Not long at all, Your Majesty."" |
| `[175]` | **""Is there a way to disable Pales' navy?""** | `[130]` **Taddeus Azaro**: ""Do you have any questions, Your..."<br>`[200]` **Carlos Robles Azaro**: ""If we can make it through their..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_Dis...` | `[210]` **Taddeus Azaro**: ""We will sabotage them in whatev..." |
| `[176]` | **""How do we get past the capital's defenses?""** | `[130]` **Taddeus Azaro**: ""Do you have any questions, Your..."<br>`[200]` **Carlos Robles Azaro**: ""If we can make it through their..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == false` | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_Cap...` | `[212]` **Taddeus Azaro**: ""The defenses around Pales are e..." |
| `[197]` | **""Those were all my questions.""** | `[130]` **Taddeus Azaro**: ""Do you have any questions, Your..."<br>`[200]` **Carlos Robles Azaro**: ""If we can make it through their..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == true  or   Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == true` | *Brak zmian stanu* | `[226]` **Taddeus Azaro**: ""Then thank you for your time, Y..."<br>`[227]` **Taddeus Azaro**: ""Then thank you for your time, Y..." |
| `[198]` | **""No, I don't.""** | `[130]` **Taddeus Azaro**: ""Do you have any questions, Your..."<br>`[200]` **Carlos Robles Azaro**: ""If we can make it through their..."<br>*(oraz 5 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == true  or   Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == true) == false` | *Brak zmian stanu* | `[226]` **Taddeus Azaro**: ""Then thank you for your time, Y..."<br>`[227]` **Taddeus Azaro**: ""Then thank you for your time, Y..." |
| `[218]` | **""Thank you for your advice.""** | `[217]` **Lucita Azaro**: ""Yes, Your Majesty. Thank you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Taddeus Azaro**: ""It's an honor to be asked for it."" |
| `[219]` | **""Do not fail me. For your own good.""** | `[217]` **Lucita Azaro**: ""Yes, Your Majesty. Thank you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Taddeus Azaro**: ""Yes, sir."" |
| `[220]` | **""Soon, I will ride my horse on the streets of Pales.""** | `[217]` **Lucita Azaro**: ""Yes, Your Majesty. Thank you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Lucita Azaro**: ""Soon, Your Majesty."" |
| `[221]` | **""House Toras and Azaro on the battlefield once more. My father would be proud.""** | `[217]` **Lucita Azaro**: ""Yes, Your Majesty. Thank you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Lucita Azaro**: ""We will fight in his honor."" |
| `[240]` | **""No matter what, I thank you for your advice.""** | `[228]` **Lucita Azaro**: ""Yes, thank you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Lucita Azaro**: ""It's an honor to be asked for it."" |
| `[241]` | **""Do not fail me. For your own good.""** | `[228]` **Lucita Azaro**: ""Yes, thank you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Taddeus Azaro**: ""You've made yourself very clear..." |
| `[242]` | **""Good luck to you.""** | `[228]` **Lucita Azaro**: ""Yes, thank you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Lucita Azaro**: ""Good luck to all of us, Your Ma..." |
| `[246]` | **""Leave me alone. Now.""** | `[228]` **Lucita Azaro**: ""Yes, thank you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Taddeus Azaro**: ""Yes, Your Majesty."" |
| `[253]` | **""And lo, we shall smite our enemies with the full vengeance of the Divine.""** | `[38]` **Taddeus Azaro**: ""A complete victory is in sight,..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[49]` **Taddeus Azaro**: ""Yes, Your Majesty."" |

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
  - -> `[21]` (*Lucita Azaro: ""We have more details about the situation on the front li..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""How long until total victory?""*)

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
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false && Rizia..."*)

### Węzeł `[6]`
Mówca: **Carlos Robles Azaro**
> ""We are in a good position to encircle the peninsula.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "He drew a circle around the peninsula and tapped his fing..."*)

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""The troops are eagerly awaiting orders to begin the second operation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Taddeus Azaro: ""Our enemies shall tremble before our might.""*)

### Węzeł `[8]`
Mówca: **Carlos Robles Azaro**
> ""After the enemy took control of Terador and Fort Ales, we managed to push them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Carlos Robles Azaro: ""We are back where we started.""*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false && Rizia..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Terador == false && Riz..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] == false  and  Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Carlos Robles Azaro: ""After the enemy took control of Terador and Fort Ales, w..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Terador"] == false  and  Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Terador == false"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Terador == false)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Terador == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Carlos Robles Azaro: ""After the enemy took control of Terador, we managed to p..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Terador == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Terador"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_FortAles == false"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_FortAles == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_FortAles == false"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_FortAles == false)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_FortAles == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Carlos Robles Azaro: ""After the enemy took control of Fort Ales, we managed to..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_FortAles == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Carlos Robles Azaro: ""Despite the enemy's best efforts, we managed to push the..."*)

### Węzeł `[18]`
Mówca: **Carlos Robles Azaro**
> ""After the enemy took control of Terador, we managed to push them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Carlos Robles Azaro: ""We are back where we started.""*)

### Węzeł `[19]`
Mówca: **Carlos Robles Azaro**
> ""After the enemy took control of Fort Ales, we managed to push them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Carlos Robles Azaro: ""We are back where we started.""*)

### Węzeł `[20]`
Mówca: **Carlos Robles Azaro**
> ""Despite the enemy's best efforts, we managed to push them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Carlos Robles Azaro: ""We are back where we started.""*)

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> ""We have more details about the situation on the front lines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Lucita spread several strategic maps of the region on the..."*)

### Węzeł `[22]`
Mówca: **Carlos Robles Azaro**
> ""We are back where we started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "He drew a line around the border between Rizia and Pales ..."*)

### Węzeł `[23]`
Mówca: **Carlos Robles Azaro**
> ""Our troops are pushing with everything they've got. But the enemy is refusing to yield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Taddeus Azaro: ""They tried to spearhead into our territories after we se..."*)

### Węzeł `[24]`
Mówca: **Taddeus Azaro**
> ""They tried to spearhead into our territories after we set up our defensive positions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "He put his fist on his heart."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Arces == true && RiziaD..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Arces"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Carlos Robles Azaro: ""After the capture of both Arces and Ziqes, we pushed fur..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Arces"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Arces == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Arces == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Arces == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Arces == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Arces == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Arces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Carlos Robles Azaro: ""After the capture of Arces, we pushed further past the c..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Arces == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Arces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Ziqes == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Ziqes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Ziqes == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Ziqes == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Ziqes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Carlos Robles Azaro: ""After the capture of Ziqes, we pushed further past Arces..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Ziqes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Carlos Robles Azaro: ""Although we failed to capture either Arces or Ziqes, we ..."*)

### Węzeł `[34]`
Mówca: **Carlos Robles Azaro**
> ""After the capture of both Arces and Ziqes, we pushed further past Arces, close to Mandana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Carlos Robles Azaro: ""We are in a good position to encircle the peninsula.""*)

### Węzeł `[35]`
Mówca: **Carlos Robles Azaro**
> ""After the capture of Arces, we pushed further past the city, close to Mandana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Carlos Robles Azaro: ""We are in a good position to encircle the peninsula.""*)

### Węzeł `[36]`
Mówca: **Carlos Robles Azaro**
> ""After the capture of Ziqes, we pushed further past Arces, close to Mandana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Carlos Robles Azaro: ""We are in a good position to encircle the peninsula.""*)

### Węzeł `[37]`
Mówca: **Carlos Robles Azaro**
> ""Although we failed to capture either Arces or Ziqes, we managed to push further past Arces, close to Mandana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Carlos Robles Azaro: ""We are in a good position to encircle the peninsula.""*)

### Węzeł `[38]`
Mówca: **Taddeus Azaro**
> ""A complete victory is in sight, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""Do not let this success get to your head, General. It is..."*)
  - -> `[42]` (*Player_Romus: ""I knew that our cause was just. We will take back what i..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[39]`
Mówca: **Taddeus Azaro**
> ""Our enemies shall tremble before our might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Taddeus Azaro: ""A complete victory is in sight, Your Majesty.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Simply holding the line is unacceptable. We will push with whatever we have. Even if that means more casualties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""Your Majesty... if we push harder and fail, we'll find o..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then be the wall that protects the mainland. Do not let them pass under any condition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Taddeus Azaro: ""As you wish, Your Majesty.""*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew that our cause was just. We will take back what is rightfully ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Taddeus Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not let this success get to your head, General. It is not over yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Taddeus Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will come at Pales until there is nothing left of it but ash and smoke.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[38]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Taddeus Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""We will come at Pales until there is nothing left of it ..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""We will deliver them their loss with honor and dignity a..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will deliver them their loss with honor and dignity as befits our position.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Taddeus Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[49]`
Mówca: **Taddeus Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucita Azaro: ""We won't win this war without information. Which brings ..."*)

### Węzeł `[50]`
Mówca: **Carlos Robles Azaro**
> ""Unfortunately, we won't be able to gain any new territory at this point. Our hands are tied, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""Simply holding the line is unacceptable. We will push wi..."*)
  - -> `[41]` (*Player_Romus: ""Then be the wall that protects the mainland. Do not let ..."*)

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> ""Your Majesty... if we push harder and fail, we'll find ourselves in an even more precarious situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Taddeus Azaro: ""In the worst-case scenario, the frontline might fall. Pl..."*)

### Węzeł `[52]`
Mówca: **Taddeus Azaro**
> ""In the worst-case scenario, the frontline might fall. Please listen to my daughter, Your Majesty. We can't overextend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Carlos Robles Azaro: ""Agreed. We should wait for more favorable conditions.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cowards, all of you! Attack or I will have you lashed.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[55]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Everyone seemed taken aback, but nobody dared to protest."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point. Very well. We will wait and see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Taddeus Azaro: ""As you wish, Your Majesty.""*)

### Węzeł `[55]`
Mówca: **Carlos Robles Azaro**
> ""Agreed. We should wait for more favorable conditions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[59]` (*Player_Romus: ""Respectfully, General, I disagree. I order you to attack.""*)
  - -> `[54]` (*Player_Romus: ""You may have a point. Very well. We will wait and see.""*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""Cowards, all of you! Attack or I will have you lashed.""*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Respectfully, General, I disagree. I order you to attack.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Everyone seemed taken aback, but nobody dared to protest."*)

### Węzeł `[60]`
Mówca: **Taddeus Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucita Azaro: ""Their navy is currently blockading our ports in the sout..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation2Loss_Charge = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Operation2Loss_Charge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_PostOperation1_Charge = true;"*)

### Węzeł `[62]`
Mówca: **Lucita Azaro**
> ""We won't win this war without information. Which brings me to the following.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Lucita pointed at another stack of papers on the table. A..."*)

### Węzeł `[63]`
Mówca: **Lucita Azaro**
> ""We need to talk about enemy positions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucita Azaro: ""The information from the frontline combined with tips fr..."*)

### Węzeł `[64]`
Mówca: **Lucita Azaro**
> ""The information from the frontline combined with tips from our spies in Rizian Foreign Intelligence indicate heavy preparation by Palesian troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Str..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_S..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucita Azaro: ""Their ground forces have been replenished and stand read..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucita Azaro: ""Their ground forces have been replenished and stand read..."*)

### Węzeł `[68]`
Mówca: **Lucita Azaro**
> ""Their ground forces have been replenished and stand ready for our attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucita Azaro: ""It'll be harder to get the upper hand on them this time.""*)

### Węzeł `[69]`
Mówca: **Lucita Azaro**
> ""Their ground forces have been replenished and stand ready for our attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucita Azaro: ""But we still have the upper hand.""*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_N..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucita Azaro: ""As for their navy, they seem to have pulled back north t..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_N..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucita Azaro: ""As for their navy, they seem to have pulled back to bloc..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_N..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucita Azaro: ""As for their navy, they seem to have pulled back south t..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucita Azaro: ""As for their navy, they seem to have chosen to disperse ..."*)

### Węzeł `[79]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seem to have pulled back north to blockade the seas neighboring Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seem to have pulled back to blockade the seas neighboring the Palesian capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seem to have pulled back south to blockade the seas neighboring Remaz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[82]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seem to have chosen to disperse their battleships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[83]`
Mówca: **Lucita Azaro**
> ""I would advise us all to watch out for the enemy's ships. There's no telling what they're planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "She pointed at Lespia on the map."*)

### Węzeł `[84]`
Mówca: **Lucita Azaro**
> ""It'll be harder to get the upper hand on them this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""But we still have the upper hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == false"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Control_Skipped == false)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Taddeus Azaro: ""Then thank you for your time, Your Majesty. With you in ..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Control_Skipped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Taddeus Azaro: ""Then thank you for your time, Your Majesty. I promise we..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true || RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == ..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate =..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true || RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Str..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true || RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucita Azaro: ""Their ground forces seem to be weak at the moment.""*)

### Węzeł `[92]`
Mówca: **Lucita Azaro**
> ""Their ground forces seem to be weak at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucita Azaro: ""Nonetheless, I advise caution.""*)

### Węzeł `[93]`
Mówca: **Lucita Azaro**
> ""Nonetheless, I advise caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == ..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == ..."*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate =..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""As for their navy... our intelligence units are having a..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""As for their navy... our intelligence units are having a hard time divulging their whereabouts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_N..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucita Azaro: ""As for their navy, they seemed to have pulled back south..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_N..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lucita Azaro: ""As for their navy, they seemed to have chosen to dispers..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Nav..."*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_N..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucita Azaro: ""As for their navy, they seemed to have pulled back north..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucita Azaro: ""As for their navy, they seemed to have pulled back to th..."*)

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seemed to have pulled back north to blockade the seas neighboring Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seemed to have pulled back to the capital to blockade the seas neighboring Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seemed to have pulled back south to blockade the seas neighboring Remaz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[113]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seemed to have chosen to disperse their battleships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""I would advise us all to watch out for the enemy's ships..."*)

### Węzeł `[114]`
Mówca: **Lucita Azaro**
> ""Lespia is another matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport >= 2"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_LespianSupport >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport >= 2"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_LespianSupport >= 2)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_LespianSupport >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_LespianSupport"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucita Azaro: ""From the reports I've received, we can assume the worst-..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_LespianSupport >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_LespianSupport"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""From the reports I received, we need to prepare for thei..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_LespianSupport > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport > 0"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_LespianSupport > 0)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_LespianSupport > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_LespianSupport"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucita Azaro: ""Lespia is another matter.""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_LespianSupport > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_LespianSupport"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucita Azaro: ""Thankfully, Pales doesn't seem to be receiving any suppo..."*)

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""Thankfully, Pales doesn't seem to be receiving any support from Lespia at this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Taddeus Azaro: ""Ha. Those meddlers are too scared of Rizia's might to at..."*)

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""From the reports I've received, we can assume the worst-case scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucita Azaro: ""Lespia is sending significant aid to Pales in the form o..."*)

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""From the reports I received, we need to prepare for their involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucita Azaro: ""Lespia has decided to provide at least some manpower and..."*)

### Węzeł `[124]`
Mówca: **Lucita Azaro**
> ""Lespia is sending significant aid to Pales in the form of manpower and equipment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucita Azaro: ""Including their newest bombs and bomber jets.""*)

### Węzeł `[125]`
Mówca: **Lucita Azaro**
> ""Lespia has decided to provide at least some manpower and equipment assistance to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Taddeus Azaro: ""Those goddamn meddlers again... Someday it will be their..."*)

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""Including their newest bombs and bomber jets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_EnemyAirStrikeCount = 5;"*)

### Węzeł `[127]`
Mówca: **Taddeus Azaro**
> ""Those goddamn meddlers again... Someday it will be their turn as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement == true && R..."*)

### Węzeł `[128]`
Mówca: **Taddeus Azaro**
> ""Ha. Those meddlers are too scared of Rizia's might to attempt anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lucita Azaro: ""As for the taking of the capital, should we get that far..."*)

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""There is still much to discuss about our plans. But this overview should suffice for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Taddeus Azaro: ""Do you have any questions, Your Majesty?""*)

### Węzeł `[130]`
Mówca: **Taddeus Azaro**
> ""Do you have any questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Operation 2 Win Questions"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Operation 2 Win Questions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == false"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceT..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy =..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefenc..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == tr..."*)

### Węzeł `[132]`
Mówca: **Lucita Azaro**
> ""Their navy is currently blockading our ports in the southern seas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucita Azaro: ""However, our coastal artillery is effectively keeping th..."*)

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""However, our coastal artillery is effectively keeping their landing crafts at bay. With the defenses we have in place, we do not anticipate a naval invasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "She pointed at a few ports and drew lines over the sea."*)

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""Lespia may be the deciding factor here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucita Azaro: ""They do not seem to have sent any substantial support to..."*)

### Węzeł `[135]`
Mówca: **Lucita Azaro**
> ""They do not seem to have sent any substantial support to Pales yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Carlos Robles Azaro: ""Yes, but if the tides change, they very well might.""*)

### Węzeł `[136]`
Mówca: **Carlos Robles Azaro**
> ""Yes, but if the tides change, they very well might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucita Azaro: ""Let's hope the wind is at our back. That concludes today..."*)

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Let's hope the wind is at our back. That concludes today's overview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Looking down without meeting my eyes, Lucita collected th..."*)

### Węzeł `[138]`
Mówca: **Taddeus Azaro**
> ""Do you have any questions for us, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Operation 2 Lose Questions"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Operation 2 Lose Questions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == ..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == f..."*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength ==..."*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespi..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == ..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was this all a mistake?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Taddeus Azaro), `[167]` (Taddeus Azaro), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake = true"*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can we win this war?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Taddeus Azaro), `[167]` (Taddeus Azaro), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin = true"*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much longer will we have to keep fighting?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Taddeus Azaro), `[167]` (Taddeus Azaro), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength = ..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can we prevent Lespia from helping Pales?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Taddeus Azaro), `[167]` (Taddeus Azaro), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespi..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == ..."*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin =..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""Can we win this war?""*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == f..."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake ==..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus: ""Was this all a mistake?""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength ==..."*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength ..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""How much longer will we have to keep fighting?""*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespi..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLes..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: ""How can we prevent Lespia from helping Pales?""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == ..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin =..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""Those were all my questions.""*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""No, I don't.""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucita Azaro: ""If we can get rid of this gridlock, we can, Your Majesty.""*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Taddeus Azaro: ""My King...""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Taddeus Azaro: ""It's difficult to say. It certainly isn't going to be as..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement == true && R..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those were all my questions.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == true`
- **Kontekst wejściowy (poprzednik):** `[138]` (Taddeus Azaro), `[167]` (Taddeus Azaro), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Taddeus Azaro: ""Then thank you for your time, Your Majesty.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I don't.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Taddeus Azaro), `[167]` (Taddeus Azaro), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Taddeus Azaro: ""Then thank you for your time, Your Majesty.""*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Operation 2 Lose Questions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Operation 2 Lose Questions"*)

### Węzeł `[166]`
Mówca: **Lucita Azaro**
> ""If we can get rid of this gridlock, we can, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Taddeus Azaro: ""We will, Your Majesty. We must.""*)

### Węzeł `[167]`
Mówca: **Taddeus Azaro**
> ""We will, Your Majesty. We must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Lose Questions]"*)

### Węzeł `[168]`
Mówca: **Taddeus Azaro**
> ""My King...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "His voice trailed off. Lucita and Carlos stayed silent."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "His voice trailed off. Lucita and Carlos stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Lose Questions]"*)

### Węzeł `[170]`
Mówca: **Taddeus Azaro**
> ""It's difficult to say. It certainly isn't going to be as easy as we thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Carlos Robles Azaro: ""But we *will* win, Your Majesty. In due time.""*)

### Węzeł `[171]`
Mówca: **Carlos Robles Azaro**
> ""But we *will* win, Your Majesty. In due time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Lose Questions]"*)

### Węzeł `[172]`
Mówca: **Lucita Azaro**
> ""We can only hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Lose Questions]"*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can we trust the intelligence you have received?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Taddeus Azaro), `[200]` (Carlos Robles Azaro), `[207]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceT..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How long until total victory?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == false`
- **Kontekst wejściowy (poprzednik):** `[224]` (Lucita Azaro), `[225]` (Lucita Azaro), `[245]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong = true"*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there a way to disable Pales' navy?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Taddeus Azaro), `[200]` (Carlos Robles Azaro), `[207]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy =..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do we get past the capital's defenses?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Taddeus Azaro), `[200]` (Carlos Robles Azaro), `[207]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefenc..."*)

### Węzeł `[177]`
Mówca: **Lucita Azaro**
> ""Pales itself is a very well-defended city. It will be tough to bring down its walls. Literally and figuratively.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "After putting an X on the Palesian capital, she leaned ba..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == false"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == ..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""How long until total victory?""*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceT..."*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Win_Intelligenc..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus: ""Can we trust the intelligence you have received?""*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy =..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player_Romus: ""Is there a way to disable Pales' navy?""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefenc..."*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefe..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: ""How do we get past the capital's defenses?""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Taddeus Azaro: ""Not long at all, Your Majesty.""*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Taddeus Azaro: ""We will sabotage them in whatever way we deem necessary,..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Taddeus Azaro: ""The defenses around Pales are extreme, and the entrance ..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == true || RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == true ||RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == true ||  RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == tr..."*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == ..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == true || RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == true ||RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == true ||  RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == true  or   Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus: ""Those were all my questions.""*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == true || RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == true ||RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == true ||  RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == true  or   Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus: ""No, I don't.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those were all my questions.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == true  or   Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == true`
- **Kontekst wejściowy (poprzednik):** `[130]` (Taddeus Azaro), `[200]` (Carlos Robles Azaro), `[207]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == false"*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I don't.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == true  or   Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Taddeus Azaro), `[200]` (Carlos Robles Azaro), `[207]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == false"*)

### Węzeł `[199]`
Mówca: **Taddeus Azaro**
> ""Not long at all, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Carlos Robles Azaro: ""If we can make it through their defenses.""*)

### Węzeł `[200]`
Mówca: **Carlos Robles Azaro**
> ""If we can make it through their defenses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Win Questions]"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective ..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lucita Azaro: ""We can absolutely trust it, Your Majesty. Our services a..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == ..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == ..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate =..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucita Azaro: ""We should be able to trust it, Your Majesty. Our service..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucita Azaro: ""I wish I could say yes. But the truth is, our services a..."*)

### Węzeł `[207]`
Mówca: **Lucita Azaro**
> ""We can absolutely trust it, Your Majesty. Our services are at the top of their game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Win Questions]"*)

### Węzeł `[208]`
Mówca: **Lucita Azaro**
> ""We should be able to trust it, Your Majesty. Our services could be better funded, but they're adequate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Win Questions]"*)

### Węzeł `[209]`
Mówca: **Lucita Azaro**
> ""I wish I could say yes. But the truth is, our services are stretched thin. I have no idea how accurate their findings are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Win Questions]"*)

### Węzeł `[210]`
Mówca: **Taddeus Azaro**
> ""We will sabotage them in whatever way we deem necessary, but only if the situation permits it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Lucita coughed."*)

### Węzeł `[211]`
Mówca: **Lucita Azaro**
> ""And if the current situation doesn't permit it, we'll create a situation that does. One way or another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Win Questions]"*)

### Węzeł `[212]`
Mówca: **Taddeus Azaro**
> ""The defenses around Pales are extreme, and the entrance to the peninsula will be difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Carlos Robles Azaro: ""If we can get past their fleet, a naval invasion is defi..."*)

### Węzeł `[213]`
Mówca: **Carlos Robles Azaro**
> ""If we can get past their fleet, a naval invasion is definitely a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Taddeus Azaro: ""Or we can rely on airstrikes at the entrance to the corr..."*)

### Węzeł `[214]`
Mówca: **Taddeus Azaro**
> ""Or we can rely on airstrikes at the entrance to the corridor while pushing with our land troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Win Questions]"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Operation 2 Win Questions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Operation 2 Win Questions"*)

### Węzeł `[216]`
Mówca: **Taddeus Azaro**
> ""Then thank you for your time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Carlos Robles Azaro: ""A pleasure as always.""*)

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player_Romus: ""Do not fail me. For your own good.""*)
  - -> `[218]` (*Player_Romus: ""Thank you for your advice.""*)
  - -> `[220]` (*Player_Romus: ""Soon, I will ride my horse on the streets of Pales.""*)
  - -> `[221]` (*Player_Romus: ""House Toras and Azaro on the battlefield once more. My f..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Taddeus Azaro: ""It's an honor to be asked for it.""*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not fail me. For your own good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Taddeus Azaro: ""Yes, sir.""*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Soon, I will ride my horse on the streets of Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucita Azaro: ""Soon, Your Majesty.""*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras and Azaro on the battlefield once more. My father would be proud.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucita Azaro: ""We will fight in his honor.""*)

### Węzeł `[222]`
Mówca: **Taddeus Azaro**
> ""It's an honor to be asked for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Carlos Robles Azaro: ""For king and country.""*)

### Węzeł `[223]`
Mówca: **Taddeus Azaro**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Carlos Robles Azaro: ""Understood, Your Majesty.""*)

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""Soon, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""We will fight in his honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[226]`
Mówca: **Taddeus Azaro**
> ""Then thank you for your time, Your Majesty. With you in command, victory is a sure thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together"*)

### Węzeł `[227]`
Mówca: **Taddeus Azaro**
> ""Then thank you for your time, Your Majesty. I promise we will make Rizia proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together"*)

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""Yes, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player_Romus: ""Do not fail me. For your own good.""*)
  - -> `[240]` (*Player_Romus: ""No matter what, I thank you for your advice.""*)
  - -> `[246]` (*Player_Romus: ""Leave me alone. Now.""*)
  - -> `[242]` (*Player_Romus: ""Good luck to you.""*)

### Węzeł `[229]`
Mówca: **Narrator**
> "He leaned over the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[230]`
Mówca: **Narrator**
> "He drew a circle around the peninsula and tapped his finger on it a few times."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Taddeus Azaro: ""The troops are eagerly awaiting orders to begin the seco..."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "He drew a line around the border between Rizia and Pales and tapped his finger on it a few times."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Carlos Robles Azaro: ""Our troops are pushing with everything they've got. But ..."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "Lucita pointed at another stack of papers on the table. Among them, I saw photographs of what appeared to be battleships at night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucita Azaro: ""We need to talk about enemy positions.""*)

### Węzeł `[233]`
Mówca: **Narrator**
> "She pointed at Lespia on the map."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport > 0"*)

### Węzeł `[234]`
Mówca: **Narrator**
> "After putting an X on the Palesian capital, she leaned back and crossed her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucita Azaro: ""There is still much to discuss about our plans. But this..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "Everyone seemed taken aback, but nobody dared to protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation2Loss_Charge = true"*)

### Węzeł `[236]`
Mówca: **Narrator**
> "He put his fist on his heart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Taddeus Azaro: ""We held our ground and will continue to do so until our ..."*)

### Węzeł `[237]`
Mówca: **Narrator**
> "She pointed at a few ports and drew lines over the sea."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucita Azaro: ""Lespia may be the deciding factor here.""*)

### Węzeł `[238]`
Mówca: **Taddeus Azaro**
> ""We held our ground and will continue to do so until our last breath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Carlos Robles Azaro: ""Unfortunately, we won't be able to gain any new territor..."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "Looking down without meeting my eyes, Lucita collected the documents on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Taddeus Azaro: ""Do you have any questions for us, Your Majesty?""*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what, I thank you for your advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucita Azaro: ""It's an honor to be asked for it.""*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not fail me. For your own good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Taddeus Azaro: ""You've made yourself very clear, sir.""*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good luck to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucita Azaro: ""Good luck to all of us, Your Majesty.""*)

### Węzeł `[243]`
Mówca: **Lucita Azaro**
> ""It's an honor to be asked for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Carlos Robles Azaro: ""For king and country.""*)

### Węzeł `[244]`
Mówca: **Taddeus Azaro**
> ""You've made yourself very clear, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Carlos Robles Azaro: ""Understood, Your Majesty.""*)

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""Good luck to all of us, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Leave me alone. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Taddeus Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[247]`
Mówca: **Taddeus Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Carlos Robles Azaro: ""Right away, sir.""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_EnemyAirStrikeCount = 5;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_EnemyAirStrikeCount"] = 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Taddeus Azaro: ""Those goddamn meddlers again... Someday it will be their..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_PostOperation1_Charge = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_Charge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Taddeus Azaro: ""As you wish, Your Majesty.""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""And lo, we shall smite our enemies with the full vengean..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And lo, we shall smite our enemies with the full vengeance of the Divine.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[38]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Taddeus Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Lucita coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lucita Azaro: ""And if the current situation doesn't permit it, we'll cr..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "Lucita looked me in the eye earnestly."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""Yes, Your Majesty. Thank you.""*)

### Węzeł `[258]`
Mówca: **Narrator**
> "Lucita looked me in the eye earnestly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""Yes, Your Majesty. Thank you.""*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement == true && R..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_Discovered_LespianInvolvement == true &&..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Lucita Azaro: ""I'll remind you that we do have a certain amount of leve..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucita Azaro: ""We can only hope.""*)

### Węzeł `[262]`
Mówca: **Lucita Azaro**
> ""I'll remind you that we do have a certain amount of leverage over the Lespian government. Now would be a good time to use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Operation 2 Lose Questions]"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement == true && R..."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_Discovered_LespianInvolvement == true &&..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "Lucita looked directly at me."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lucita Azaro: ""As for the taking of the capital, should we get that far..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "Lucita looked directly at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Lucita Azaro: ""I'll remind you that we do have a certain amount of leve..."*)

### Węzeł `[267]`
Mówca: **Lucita Azaro**
> ""I'll remind you that we do have a certain amount of leverage over the Lespian government. Perhaps now is the time to use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lucita Azaro: ""As for the taking of the capital, should we get that far..."*)

### Węzeł `[268]`
Mówca: **Lucita Azaro**
> ""As for the taking of the capital, should we get that far...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lucita Azaro: ""Pales itself is a very well-defended city. It will be to..."*)

### Węzeł `[269]`
Mówca: **Carlos Robles Azaro**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He leaned over the table."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "Lucita spread several strategic maps of the region on the table before turning to Carlos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Lucita Azaro: ""General?""*)

### Węzeł `[271]`
Mówca: **Lucita Azaro**
> ""General?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Carlos Robles Azaro: ""Yes, of course.""*)

### Węzeł `[272]`
Mówca: **Carlos Robles Azaro**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[273]`
Mówca: **Carlos Robles Azaro**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[274]`
Mówca: **Carlos Robles Azaro**
> ""A pleasure as always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucita Azaro: ""Yes, thank you.""*)

### Węzeł `[275]`
Mówca: **Carlos Robles Azaro**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[276]`
Mówca: **Carlos Robles Azaro**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[277]`
Mówca: **Carlos Robles Azaro**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
