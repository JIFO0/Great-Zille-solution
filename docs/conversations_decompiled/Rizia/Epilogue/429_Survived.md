# Rizia/Survived

- **ID konwersacji:** `429`
- **StoryPack:** `Rizia`
- **Tura:** `Epilogue (Survived)`
- **Lokalizacja pliku:** `Rizia/Epilogue/429_Survived.md`
- **Liczba węzłów dialogowych:** 351
- **Liczba wyborów gracza:** 48

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.AxelVina_Married_Official`
- `RiziaDLC.Azaro_HasPowerToCoup`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.Ending_Reform_Coup_Toras`
- `RiziaDLC.Epilogue_Coup_Survived_WithEstela`
- `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina`
- `RiziaDLC.Epilogue_Revolution_Survived_WithLucita`
- `RiziaDLC.Epilogue_Revolution_Survived_WithPabel`
- `RiziaDLC.Epilogue_Survived_BirthdayStrike`
- `RiziaDLC.Epilogue_Survived_ConstitutionSigning`
- `RiziaDLC.Epilogue_Survived_HouseFallouts`
- `RiziaDLC.Epilogue_Survived_Revolution`
- `RiziaDLC.Epilogue_Survived_RevolutionaryFail`
- `RiziaDLC.Estela_EarlyExile`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_InjuredInRevolution`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_Pregnant`
- `RiziaDLC.Manus_Arrested`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Pabel_InjuredInRevolution`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Successor_Son`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_EarlyExile`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue`
- `RiziaDLC.Epilogue_CivilWar_Monqiz`
- `RiziaDLC.Epilogue_CivilWar_TorasAlly`
- `RiziaDLC.Epilogue_CivilWar_WinPoints`
- `RiziaDLC.Epilogue_ExileTogether_Estela`
- `RiziaDLC.Epilogue_ExileTogether_Lucita`
- `RiziaDLC.Epilogue_ExileTogether_Manus`
- `RiziaDLC.Epilogue_ExileTogether_Pabel`
- `RiziaDLC.Epilogue_ExileTogether_Vina`
- `RiziaDLC.Epilogue_Exile_DecidedInEpilogue`
- `RiziaDLC.Epilogue_Exile_Forced`
- `RiziaDLC.Epilogue_Exile_Rumburg`
- `RiziaDLC.Epilogue_LeftForExileAlone`
- `RiziaDLC.Estela_EarlyExile`
- `RiziaDLC.Manus_EarlyExile`
- `RiziaDLC.Vina_EarlyExile`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[425] Rizia/Epilogue** (../Epilogue/425_Epilogue.md), Węzeł `[19]`
- Węzeł `[152]` -> **[428] Rizia/Prison** (../Epilogue/428_Prison.md), Węzeł `[53]`
- Węzeł `[252]` -> **[426] Rizia/Exile** (../Epilogue/426_Exile.md), Węzeł `[720]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Player_Romus**: "You had no idea of knowing who w..." |
| `[15]` | **"You had no idea who was on your side."** | `[13]` **Narrator**: "You were taken to the hidden eme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "According to the intelligence yo..."<br>`[58]` **Narrator**: "According to the intelligence yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[18]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: "You had no idea who was on your ..." |
| `[19]` | **"You had no idea who was on your side."** | `[18]` **Narrator**: "You were taken to the hidden eme..."<br>`[52]` **Narrator**: "Together with Pabel, you were ta..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "After another few days, you lear..."<br>`[67]` **Narrator**: "According to the intelligence yo..." |
| `[20]` | **"You had no idea of knowing who was on your side."** | `[14]` **Narrator**: "You were taken to the hidden eme..."<br>`[56]` **Narrator**: "You and your mother were both ta..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "According to the intelligence yo..."<br>`[58]` **Narrator**: "According to the intelligence yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[52]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: "You had no idea who was on your ..." |
| `[53]` | **"1957\|Porte Drazon"** | `[151]` **Narrator**: "After several rough nights of sl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: "You had no idea who was on your ..." |
| `[54]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: "You had no idea who was on your ..." |
| `[55]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: "You had no idea who was on your ..." |
| `[56]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Player_Romus**: "You had no idea of knowing who w..." |
| `[57]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Player_Romus**: "You had no idea of knowing who w..." |
| `[63]` | **"...stayed where you were to organize a defense."** | `[39]` **Narrator**: "According to the intelligence yo..."<br>`[58]` **Narrator**: "According to the intelligence yo..."<br>*(oraz 8 innych węzłów)* | `(Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false` | `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] ...`<br>`-- WAR;`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[64]` | **"...decided to regroup in Monqiz."** | `[39]` **Narrator**: "According to the intelligence yo..."<br>`[58]` **Narrator**: "According to the intelligence yo..."<br>*(oraz 8 innych węzłów)* | `((Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true)  or  Variable["RiziaDLC.HouseToras_Conquered"] == true  or  Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false` | `Variable["RiziaDLC.Epilogue_CivilWar_Monqiz"] = true;`<br>`PrologueImage("pe_monqiz");`<br>*(+2 skryptów)* | `[85]` **Narrator**: "After careful planning with your..."<br>`[91]` **Narrator**: "After careful planning with your..." |
| `[65]` | **"You decided to flee to Rumburg."** | `[257]` **Narrator**: "After careful planning with your..."<br>`[343]` **Narrator**: "After careful planning with your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_exilethornbrough");`<br>`Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = true;`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[66]` | **"...planned your escape from Rizia."** | `[39]` **Narrator**: "According to the intelligence yo..."<br>`[58]` **Narrator**: "According to the intelligence yo..."<br>*(oraz 9 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Narrator**: "After careful planning with your..."<br>`[261]` **Narrator**: "After careful planning with your..." |
| `[85]` | **"1957\|Monqiz"** | `[64]` **Player_Romus**: "...decided to regroup in Monqiz." | `Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Reform_Coup_Toras"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true`<br>`Variable["RiziaDLC.Epilogue_Survived_Revolution"] == false` | *Brak zmian stanu* | `[92]` **Player_Romus**: "You were back home." |
| `[86]` | **"1957\|Monqiz"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[106]` **Player_Romus**: "...decided to fight back."<br>`[107]` **Player_Romus**: "...decided to leave the country." |
| `[87]` | **"1957\|Monqiz"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Player_Romus**: "...decided to fight."<br>`[166]` **Player_Romus**: "...decided to leave the country." |
| `[91]` | **"1957\|Monqiz"** | `[64]` **Player_Romus**: "...decided to regroup in Monqiz." | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`<br>`(Variable["RiziaDLC.Epilogue_Survived_Revolution"] == false) == false` | `--;` | `[106]` **Player_Romus**: "...decided to fight back."<br>`[107]` **Player_Romus**: "...decided to leave the country." |
| `[92]` | **"You were back home."** | `[85]` **Narrator**: "After careful planning with your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "You were immediately pinned down..."<br>`[101]` **Narrator**: "You were immediately pinned down..."<br>*(oraz 2 innych odgałęzień)* |
| `[99]` | **"You embraced her."** | `[84]` **Narrator**: "You were immediately pinned down..."<br>`[101]` **Narrator**: "You were immediately pinned down..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`<br>`--;`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[100]` | **"You asked for her forgiveness."** | `[84]` **Narrator**: "You were immediately pinned down..."<br>`[101]` **Narrator**: "You were immediately pinned down..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`<br>`--;`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[103]` | **"They put you in a cell."** | `[102]` **Narrator**: "Inside, you were immediately pin..."<br>`[104]` **Narrator**: "Inside, you were immediately pin..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`PrologueImage("pe_jail");`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[106]` | **"...decided to fight back."** | `[86]` **Narrator**: "After careful planning with your..."<br>`[91]` **Narrator**: "After careful planning with your..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] ...`<br>`PrologueImage("pe_civilwardemocrat2");`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[107]` | **"...decided to leave the country."** | `[86]` **Narrator**: "After careful planning with your..."<br>`[91]` **Narrator**: "After careful planning with your..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = t...`<br>`PrologueImage("pe_suitcase");` | `[257]` **Narrator**: "After careful planning with your..."<br>`[261]` **Narrator**: "After careful planning with your..." |
| `[154]` | **"You were rushed to the airport."** | `[125]` **Narrator**: "After several rough nights of sl..."<br>`[148]` **Narrator**: "After several rough nights of sl..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_ExileTogether_Lucita"] = true;`<br>`Variable["RiziaDLC.Epilogue_ExileTogether_Pabel"] = true;`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[155]` | **"1957\|Escape from Rizia"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_LeftForExileAlone"] = true;` | `[159]` **Player_Romus**: "You had made it out alive." |
| `[159]` | **"You had made it out alive."** | `[261]` **Narrator**: "After careful planning with your..."<br>`[350]` **Narrator**: "After careful planning with your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_suitcase");`<br>`Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = t...`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[160]` | **"1957\|Escape from Rizia"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_LeftForExileAlone"] = true;` | `[65]` **Player_Romus**: "You decided to flee to Rumburg."<br>`[161]` **Player_Romus**: "You went to Kyrute." |
| `[161]` | **"You went to Kyrute."** | `[257]` **Narrator**: "After careful planning with your..."<br>`[343]` **Narrator**: "After careful planning with your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_exilekyrute");`<br>`Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = t...`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[165]` | **"...decided to fight."** | `[87]` **Narrator**: "After careful planning with your..."<br>`[291]` **Narrator**: "After careful planning with your..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] ...`<br>`Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] ...`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[166]` | **"...decided to leave the country."** | `[87]` **Narrator**: "After careful planning with your..."<br>`[291]` **Narrator**: "After careful planning with your..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = t...`<br>`PrologueImage("pe_suitcase");` | `[257]` **Narrator**: "After careful planning with your..."<br>`[261]` **Narrator**: "After careful planning with your..." |
| `[179]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Player_Romus**: "You had no idea who was on your ..." |
| `[181]` | **"You had no idea who was on your side."** | `[179]` **Narrator**: "You managed to make it to a hidd..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Narrator**: "Eventually, you received word th..."<br>`[195]` **Narrator**: "Eventually, you received word th..." |
| `[217]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Player_Romus**: "You had no idea who was on your ..." |
| `[218]` | **"You had no idea who was on your side."** | `[217]` **Narrator**: "You managed to make it to the hi..."<br>`[231]` **Narrator**: "You managed to make it to the hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "According to the intelligence yo..." |
| `[231]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Player_Romus**: "You had no idea who was on your ..." |
| `[257]` | **"1957\|Escape from Rizia"** | `[66]` **Player_Romus**: "...planned your escape from Rizia."<br>`[107]` **Player_Romus**: "...decided to leave the country."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Vina_EarlyExile"] == true`<br>`Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true` | *Brak zmian stanu* | `[65]` **Player_Romus**: "You decided to flee to Rumburg."<br>`[161]` **Player_Romus**: "You went to Kyrute." |
| `[261]` | **"1957\|Escape from Rizia"** | `[66]` **Player_Romus**: "...planned your escape from Rizia."<br>`[107]` **Player_Romus**: "...decided to leave the country."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Vina_EarlyExile"] == true`<br>`(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false` | *Brak zmian stanu* | `[159]` **Player_Romus**: "You had made it out alive." |
| `[282]` | **"1957\|Monqiz"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[106]` **Player_Romus**: "...decided to fight back."<br>`[107]` **Player_Romus**: "...decided to leave the country." |
| `[287]` | **"1957\|Monqiz"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[106]` **Player_Romus**: "...decided to fight back."<br>`[107]` **Player_Romus**: "...decided to leave the country." |
| `[291]` | **"1957\|Monqiz"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Player_Romus**: "...decided to fight."<br>`[166]` **Player_Romus**: "...decided to leave the country." |
| `[292]` | **"Their forces were everywhere."** | `[220]` **Narrator**: "According to the intelligence yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;` | `[296]` **Narrator**: "Manus, suspected of plotting the..."<br>`[297]` **Narrator**: "Rather than swear allegiance her..." |
| `[302]` | **"You had no choice but to try to join them."** | `[297]` **Narrator**: "Rather than swear allegiance her..."<br>`[296]` **Narrator**: "Manus, suspected of plotting the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Narrator**: "After careful planning with your..."<br>`[261]` **Narrator**: "After careful planning with your..." |
| `[303]` | **"You had no choice but to try to join her."** | `[301]` **Narrator**: "You learned that Vina and Axel h..."<br>`[338]` **Narrator**: "Rather than swear allegiance her..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Narrator**: "After careful planning with your..."<br>`[261]` **Narrator**: "After careful planning with your..." |
| `[309]` | **"The capital was in complete chaos."** | `[194]` **Narrator**: "Eventually, you received word th..."<br>`[195]` **Narrator**: "Eventually, you received word th..."<br>*(oraz 9 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Narrator**: "You learned that your mother had..."<br>`[326]` **Narrator**: "You learned that your mother had..."<br>*(oraz 2 innych odgałęzień)* |
| `[343]` | **"1957\|Escape from Rizia"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Player_Romus**: "You decided to flee to Rumburg."<br>`[161]` **Player_Romus**: "You went to Kyrute." |
| `[350]` | **"1957\|Escape from Rizia"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Player_Romus**: "You had made it out alive." |

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
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_RevolutionaryFail == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_ConstitutionSigning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_ConstitutionSigning == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Survived_ConstitutionSigning == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_ConstitutionSigning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_ConstitutionSigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Constitution Signing]"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Survived_ConstitutionSigning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_ConstitutionSigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_HouseFallouts == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_HouseFallouts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_HouseFallouts == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Survived_HouseFallouts == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_HouseFallouts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_HouseFallouts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived House Fallouts Hub]"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Survived_HouseFallouts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_HouseFallouts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Revolution Hub]"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Survived Constitution Signing`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Survived House Fallouts Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived Constitution Signing]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "Survived Constitution Signing"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived House Fallouts Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "Survived House Fallouts Hub"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the plotters had already taken control of key locations around the capital and arrested the entirety of the Rizian People's Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the plotters had already taken control of key locations around the capital, with scattered forces lurking in the city's shadows."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: "You had no idea of knowing who was on your side."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea who was on your side."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Survived Revolution Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived Revolution Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "Survived Revolution Hub"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea who was on your side."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator), `[52]` (Narrator), `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea of knowing who was on your side."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[56]` (Narrator), `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "According to the intelligence you received, Azaro divisio..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "According to the intelligence you received, militants fro..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "According to the intelligence you received, Toras divisio..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "According to the intelligence you received, Azaro divisio..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "According to the intelligence you received, Sazon divisio..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstela == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstela == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstela == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Coup_Survived_WithEstela == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstela == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Coup_Survived_WithEstela == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "According to the intelligence you received, militants from Su Omina commanded by Ricardus Toras were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_InjuredInRevolution == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_InjuredInRevolution == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_InjuredInRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_InjuredInRevolution == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_InjuredInRevolution == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_InjuredInRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Together with Pabel, you were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

As the guards tended to Pabel's wounds, you learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Together with Lucita, you were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

As the guards tended to Lucita's wounds, you learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You and your mother were both taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the plotters had already taken control of key locations around the capital, with scattered forces lurking in the city's shadows."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: "You had no idea of knowing who was on your side."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You, Vina and your mother were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the plotters had already taken control of key locations around the capital, with scattered forces lurking in the city's shadows."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: "You had no idea of knowing who was on your side."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "According to the intelligence you received, Toras divisions commanded by Hugo were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "According to the intelligence you received, Azaro divisions commanded by Lucita were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "According to the intelligence you received, Azaro divisions commanded by Taddeus were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[61]`
Mówca: **Narrator**
> "According to the intelligence you received, Sazon divisions commanded by Angelica were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_civilwardemocrat");"*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...stayed where you were to organize a defense."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator), `[58]` (Narrator), `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true"*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to regroup in Monqiz."
- **Wymagania odblokowania (kod gry):** `((Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true)  or  Variable["RiziaDLC.HouseToras_Conquered"] == true  or  Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator), `[58]` (Narrator), `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_CivilWar_Monqiz = true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You decided to flee to Rumburg."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Narrator), `[343]` (Narrator), `[160]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_exilethornbrough");"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...planned your escape from Rizia."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator), `[58]` (Narrator), `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "Revolutionary Fail Exile"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "According to the intelligence you received, after a declaration made by the revolutionaries, the royal divisions stationed in Rizia Imperii had surrendered their weapons.

They were now everywhere in the capital and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_navy_mutiny");"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tr..."*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_RevolutionaryFail == true"*)
  - -> `[66]` (*Player_Romus: "...planned your escape from Rizia."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_CivilWar_Monqiz = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_Monqiz"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_Revolution == false"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Exile_Rumburg = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_Gr..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hu..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true )"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.Vi..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Reform_Coup_Toras == true || RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Ref..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_R..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Reform_Coup_Toras == true || RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Reform_Coup_Toras"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "1957|Monqiz"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Reform_Coup_Toras == true || RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Reform_Coup_Toras"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[84]`
Mówca: **Narrator**
> "You were immediately pinned down and handcuffed by the guards. It was over.

Hugo's forces had taken control of the palace before your arrival. They escorted you to a cell.

It was where Vina was being kept."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: "You embraced her."*)
  - -> `[100]` (*Player_Romus: "You asked for her forgiveness."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

You traveled incognito in a series of trains and taxicabs until you finally reached the gates of Palas Toras in Monqiz."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Reform_Coup_Toras"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true` AND `Variable["RiziaDLC.Epilogue_Survived_Revolution"] == false`
- **Kontekst wejściowy (poprzednik):** `[64]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: "You were back home."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed with open arms by your cousin, Hubertus, who offered to deploy the Toras forces to defend you.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed by Vina, who offered to deploy House Toras' forces to help you reclaim the throne.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: "...decided to fight."*)
  - -> `[166]` (*Player_Romus: "...decided to leave the country."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_Revolution == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_Revolution == false"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Survived_Revolution == false)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_Revolution == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_Revolution"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monqiz");"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Survived_Revolution == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_Revolution"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monqiz");"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed with open arms by your cousin, Hubertus, who offered to help you gather support.

You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true` AND `(Variable["RiziaDLC.Epilogue_Survived_Revolution"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[64]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were back home."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hu..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC...."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Inside, you were immediately pinned down and handcuffed b..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Inside, you were immediately pinned down and handcuffed b..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false && RiziaDLC.Hugo_Executed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_Gr..."*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false && RiziaDLC.Hugo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true  or  (Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "You were immediately pinned down and handcuffed by the gu..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false && RiziaDLC.Hugo_Executed == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true  or  (Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "You were immediately pinned down and handcuffed by the gu..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You embraced her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator), `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Vina = true"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You asked for her forgiveness."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator), `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Vina = true"*)

### Węzeł `[101]`
Mówca: **Narrator**
> "You were immediately pinned down and handcuffed by the guards. It was over.

Hubertus' men had already toppled Vina before your arrival. They escorted you to a cell.

It was where Vina was being kept."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: "You embraced her."*)
  - -> `[100]` (*Player_Romus: "You asked for her forgiveness."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Inside, you were immediately pinned down and handcuffed by Hubertus' soldiers. It was over.

He told you that he was sorry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: "They put you in a cell."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "They put you in a cell."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Narrator), `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Inside, you were immediately pinned down and handcuffed by Hugo's soldiers. It was over.

He had already taken control of the region. He told you that he was sorry for what happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: "They put you in a cell."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player_Romus: "...decided to fight back."*)
  - -> `[107]` (*Player_Romus: "...decided to leave the country."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to fight back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator), `[91]` (Narrator), `[282]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true; Rizi..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to leave the country."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator), `[91]` (Narrator), `[282]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true; RiziaDLC.Epilogue_CivilWar_TorasAlly = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] = true;
Variable["RiziaDLC.Epilogue_CivilWar_TorasAlly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_civilwardemocrat2");"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "// WAR"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Estela = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGat..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// WAR`
- **Efekt skryptowy (`userScript`):** `-- WAR;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile == false"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.AxelVina_Married_Official == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGat..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayG..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.AxelVina_Married_Official == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_EarlyExile"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Vina = true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.AxelVina_Married_Official == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_EarlyExile"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Lucita = true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Pabel = true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Lucita = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Pabel = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Pabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[125]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Hugo had been crowned king in Porte Drazon. 

He told you that you and your loved ones were allowed to leave the country by his royal permission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "After several rough nights of sleep in the cell, you were..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "After several rough nights of sleep in the cell, you were..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "After several rough nights of sleep in the cell, you were..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "After several rough nights of sleep in the cell, you were..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "After several rough nights of sleep in the cell, you were..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Estela = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstela == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstela == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Coup_Survived_WithEstela == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstela == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Estela = true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Coup_Survived_WithEstela == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Estela = true; RiziaDLC.E..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Estela = true; RiziaDLC.Epilogue_ExileTogether_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;
Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[148]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Rico had been crowned king in Porte Drazon. 

He told you that you and your loved ones were allowed to leave the country by his royal permission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[149]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Lucita had been crowned queen in Porte Drazon. 

He told you that you and your loved ones were allowed to leave the country by her royal permission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[150]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Angelica had been crowned queen in Porte Drazon. 

He told you that you and your loved ones were allowed to leave the country by her royal permission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[151]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Taddeus had been crowned king in Porte Drazon. 

They transported you to another prison in the capital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "Jump to: [Epilogue Taddeus Coup Arrest]"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Epilogue Taddeus Coup Arrest]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_plane");"*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were rushed to the airport."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Narrator), `[148]` (Narrator), `[149]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_M..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

The moment your boat set out on the water, you let out a deep sigh of relief."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_LeftForExileAlone = true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile == true"*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had made it out alive."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Narrator), `[350]` (Narrator), `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

The moment your boat set out on the water, you let out a deep sigh of relief."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_LeftForExileAlone = true"*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You went to Kyrute."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Narrator), `[343]` (Narrator), `[160]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_exilekyrute");"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "You were taken to the hidden emergency facilities on the ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_revolution")`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_revolution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true"*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to fight."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator), `[291]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to leave the country."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator), `[291]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true; Rizi..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_civilwardemocrat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_civilwardemocrat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_navy_mutiny");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_navy_mutiny");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monqiz");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monqiz");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Ref..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monqiz");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monqiz");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_jail");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstela == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_civilwardemocrat2");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_civilwardemocrat2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "// WAR"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_suitcase");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_exilethornbrough");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_exilethornbrough");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_Rumburg = true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_exilekyrute");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_exilekyrute");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_suitcase");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_plane");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_plane");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player_Romus: "You were rushed to the airport."*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You managed to make it to a hidden emergency facility on the outskirts of Porte Drazon.

Days passed in darkness, with no news of how the incident at the library had ended or who had survived it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Birthday_HouseTakeoverFails`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea who was on your side."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasPow..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Eventually, you received word that divisions from Houses ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Eventually, you received word that divisions from Houses ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[194]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Toras, Sazon and Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Hugo as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo = true"*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Toras and Sazon were fighting with the forces that still remained loyal to you. 

They were rallying behind Hugo as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo = true"*)

### Węzeł `[196]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Toras and Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Hugo as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo = true"*)

### Węzeł `[197]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Azaro and Sazon were fighting with the forces that still remained loyal to you. 

They were rallying behind Taddeus as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus = true"*)

### Węzeł `[198]`
Mówca: **Narrator**
> "Eventually, you received word that House Toras divisions commanded by Hugo were fighting with the forces that still remained loyal to you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo = true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "Eventually, you received word that House Toras divisions ..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPower..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "Eventually, you received word that divisions commanded by House Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Taddeus as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus = true"*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Eventually, you received news of the capital's descent into chaos. 

In the wake of the incident, House Sazon's forces had tried to strike Houses Toras and Azaro. In response, the Azaros rallied behind Hugo to stop them.

There was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo = true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_civilwardemocrat");"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Epilogue_Survived_BirthdayStrike == true) || RiziaDLC.HouseToras_Conquered == true || RiziaDLC.Epilogue_Survived_RevolutionaryFail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tr..."*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == ..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Epilogue_Survived_BirthdayStrike == true) || RiziaDLC.HouseToras_Conquered == true || RiziaDLC.Epilogue_Survived_RevolutionaryFail == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true)  or  Variable["RiziaDLC.HouseToras_Conquered"] == true  or  Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Epilogue_Survived_BirthdayStrike == true) || RiziaDLC.HouseToras_Conquered == true || RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true)  or  Variable["RiziaDLC.HouseToras_Conquered"] == true  or  Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus: "...decided to regroup in Monqiz."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_BirthdayStrike == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_BirthdayStrike == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Survived_BirthdayStrike == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_BirthdayStrike == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "Jump to: [Birthday_HouseTakeoverFails]"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Survived_BirthdayStrike == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_ConstitutionSigning == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Birthday_HouseTakeoverFails]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "Birthday_HouseTakeoverFails"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Birthday_RevolutionaryFail`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You managed to make it to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the Golden Guard had already taken control of key revolutionary locations around the capital. Adarfo Sotelato had been killed, and his movement was scattered."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea who was on your side."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Narrator), `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "According to the intelligence you received, Titus was per..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[220]`
Mówca: **Narrator**
> "According to the intelligence you received, Titus was personally leading the hunt for your head, and the royal divisions stationed in Rizia Imperii had sworn allegiance to Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player_Romus: "Their forces were everywhere."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_RevolutionaryFail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_RevolutionaryFail == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_RevolutionaryFail == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: "...stayed where you were to organize a defense."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_RevolutionaryFail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_RevolutionaryFail == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_RevolutionaryFail == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "Jump to: [Birthday_RevolutionaryFail]"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_BirthdayStrike == true"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Birthday_RevolutionaryFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "Birthday_RevolutionaryFail"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[231]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You managed to make it to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that Wruhec's Guardians had already taken control of key revolutionary locations around the capital. Adarfo Sotelato had been killed, and his movement was scattered."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: "You had no idea who was on your side."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.Vina_EarlyExile == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.Vi..."*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC...."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.Vina_EarlyExile == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == false  and  Variable["RiziaDLC.Vina_EarlyExile"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.Vina_EarlyExile == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == false  and  Variable["RiziaDLC.Vina_EarlyExile"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_M..."*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Lucita = true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Lucita = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Pabel = true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Pabel = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Pabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDL..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Manus = true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC...."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Manus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC...."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC...."*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDL..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Vina = true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Estela = true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Estela = true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_ExileTogether_Estela = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true; RiziaDL..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Airplane Exile]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true;
RiziaDLC.Epilogue_Exile_Forced = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Exile_Forced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "Jump to: [Airplane Exile]"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_EarlyExile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_EarlyExile == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_EarlyExile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_EarlyExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "1957|Escape from Rizia"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_EarlyExile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_EarlyExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile == true"*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

You knew your family was already at a hotel in Kyrute. Estela had some money set aside for a beachside villa there.

But Queen Beatrice had also offered you and your loved ones a safe haven in Rumburg."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_EarlyExile"] == true` AND `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Kontekst wejściowy (poprzednik):** `[66]` (Player_Romus), `[107]` (Player_Romus), `[166]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: "You decided to flee to Rumburg."*)
  - -> `[161]` (*Player_Romus: "You went to Kyrute."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_EarlyExile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_EarlyExile == true )"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_EarlyExile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_EarlyExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "1957|Escape from Rizia"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_EarlyExile == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_EarlyExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile == true"*)

### Węzeł `[261]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

You knew your family was already at a hotel in Kyrute. Estela had some money set aside for a beachside villa there.

The moment your boat set out on the water, you let out a deep sigh of relief."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_EarlyExile"] == true` AND `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[66]` (Player_Romus), `[107]` (Player_Romus), `[166]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Romus: "You had made it out alive."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_LeftForExileAlone = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_LeftForExileAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: "You decided to flee to Rumburg."*)
  - -> `[161]` (*Player_Romus: "You went to Kyrute."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_LeftForExileAlone = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_LeftForExileAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Romus: "You had made it out alive."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: "The capital was in complete chaos."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: "The capital was in complete chaos."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPowerToCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPower..."*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPow..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPowerToCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Successor_Son"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "Eventually, you received news of the capital's descent in..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPowerToCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Successor_Son"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Eventually, you received news of the capital's descent in..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "Eventually, you received news of the capital's descent into chaos. 

In the wake of the incident, House Sazon's forces had tried to strike Houses Toras and Azaro. In response, House Toras rallied behind General Taddeus to stop them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus = true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_EarlyExile == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile == false"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Estela_EarlyExile == false)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_EarlyExile == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Estela_EarlyExile"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_ExileTogether_Estela = true"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Estela_EarlyExile == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Estela_EarlyExile"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGat..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Execu..."*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Exe..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "After another few days, you learned that the revolutionar..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "According to the intelligence you received, after a decla..."*)

### Węzeł `[276]`
Mówca: **Narrator**
> "After another few days, you learned that the revolutionaries had freed Adarfo Sotelato from prison. The royal divisions stationed in Rizia Imperii had surrendered their weapons.

They were now everywhere in the capital and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true && Rizia..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "1957|Monqiz"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_CivilWar_WinPoints += 1;"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_CivilWar_WinPoints += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_WinPoints"] = Variable["RiziaDLC.Epilogue_CivilWar_WinPoints"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "1957|Monqiz"*)

### Węzeł `[282]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed with open arms by your cousin, Hubertus, who offered to support you with House Toras' forces.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "1957|Monqiz"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_CivilWar_WinPoints += 1;"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_CivilWar_WinPoints += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_WinPoints"] = Variable["RiziaDLC.Epilogue_CivilWar_WinPoints"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "1957|Monqiz"*)

### Węzeł `[287]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed with open arms by your cousin, Hubertus, who offered to help you gather support.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "1957|Monqiz"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "1957|Monqiz"*)

### Węzeł `[291]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed by Vina, who offered to help you gather support to reclaim the throne.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: "...decided to fight."*)
  - -> `[166]` (*Player_Romus: "...decided to leave the country."*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Their forces were everywhere."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo = true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true && Rizia..."*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true && Riz..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "Manus, suspected of plotting the revolutionary attack alo..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "Manus, suspected of plotting the revolutionary attack along with you, had fled the country together with Vina and your mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_EarlyExile = true;"*)

### Węzeł `[297]`
Mówca: **Narrator**
> "Rather than swear allegiance herself, your mother opted to leave the country, accompanied by VIna."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile = true; RiziaDLC.Estela_EarlyExi..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true && Rizi..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Rather than swear allegiance herself, your mother opted t..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)

### Węzeł `[301]`
Mówca: **Narrator**
> "You learned that Vina and Axel had made it back to Pales. Rather than swear allegiance to Hugo herself, your mother opted to leave the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile = true;"*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no choice but to try to join them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Narrator), `[296]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolutionary Fail Exile]"*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no choice but to try to join her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Narrator), `[338]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolutionary Fail Exile]"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Revolutionary Fail Exile`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Revolutionary Fail Exile]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "Revolutionary Fail Exile"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_EarlyExile = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Manus_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile = true; RiziaDLC.Estela_EarlyExi..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_EarlyExile = true;
RiziaDLC.Estela_EarlyExile = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_EarlyExile"] = true;
Variable["RiziaDLC.Estela_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: "You had no choice but to try to join them."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_EarlyExile = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Estela_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player_Romus: "You had no choice but to try to join her."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The capital was in complete chaos."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator), `[195]` (Narrator), `[196]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true && Rizia..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "Eventually, you received word that divisions from Houses ..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "Eventually, you received word that divisions from Houses ..."*)

### Węzeł `[313]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Azaro and Sazon were fighting with the forces that still remained loyal to you. 

They were rallying behind Lucita as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita = true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: "The capital was in complete chaos."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasPowerToCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasPow..."*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasP..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasPowerToCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Pregnant"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "Eventually, you received word that divisions from Houses ..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasPowerToCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Pregnant"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "Eventually, you received word that divisions from Houses ..."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Toras and Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Lucita as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita = true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Eventually, you received word that divisions commanded by..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Eventually, you received word that divisions commanded by..."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "Eventually, you received word that divisions commanded by House Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Lucita as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita = true"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true && Rizia..."*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true && Riz..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "You learned that your mother had fled the country, fearin..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "You learned that your mother had fled the country, fearing for her safety. Vina had chosen to accompany her.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile = true; RiziaDLC.Estela_EarlyExi..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true && Rizi..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "You learned that your mother had fled the country, fearin..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)

### Węzeł `[330]`
Mówca: **Narrator**
> "You learned that your mother had fled the country, fearing for her safety. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile = true;"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_EarlyExile = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Manus_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_EarlyExile = true; RiziaDLC.Estela_EarlyExi..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_EarlyExile = true;
RiziaDLC.Estela_EarlyExile = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_EarlyExile"] = true;
Variable["RiziaDLC.Estela_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_EarlyExile = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Estela_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[334]`
Mówca: **Narrator**
> "You learned that your mother had fled the country, fearing for her safety. Vina and Manus had accompanied her.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_EarlyExile = true;"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true)"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "You learned that Vina and Axel had made it back to Pales...."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "Rather than swear allegiance herself, your mother opted t..."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "Rather than swear allegiance herself, your mother opted to leave the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile = true;"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true && Rizi..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "You learned that Vina and Axel had made it back to Pales,..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "You learned that your mother had fled the country, fearin..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "You learned that Vina and Axel had made it back to Pales, which was untouched by the fighting so far. Meanwhile, your mother fled the country, fearing for her safety.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile = true;"*)

### Węzeł `[343]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

You knew Estela was already at a hotel in Kyrute. She had some money set aside for a beachside villa there.

But Queen Beatrice had also offered you and your loved ones a safe haven in Rumburg."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: "You decided to flee to Rumburg."*)
  - -> `[161]` (*Player_Romus: "You went to Kyrute."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_EarlyExile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Estela_EarlyExile == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_EarlyExile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Estela_EarlyExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "1957|Escape from Rizia"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Estela_EarlyExile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Estela_EarlyExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "1957|Escape from Rizia"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_EarlyExile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_EarlyExile == true"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Estela_EarlyExile == true)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_EarlyExile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Estela_EarlyExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "1957|Escape from Rizia"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Estela_EarlyExile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Estela_EarlyExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "1957|Escape from Rizia"*)

### Węzeł `[350]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

You knew your mother was already at a hotel in Kyrute. She had some money set aside for a beachside villa there.

The moment your boat set out on the water, you let out a deep sigh of relief."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Romus: "You had made it out alive."*)
