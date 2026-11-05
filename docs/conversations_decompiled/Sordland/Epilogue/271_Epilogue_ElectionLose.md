# Sordland/Epilogue_ElectionLose

- **ID konwersacji:** `271`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_ElectionLose)`
- **Lokalizacja pliku:** `Sordland/Epilogue/271_Epilogue_ElectionLose.md`
- **Liczba węzłów dialogowych:** 573
- **Liczba wyborów gracza:** 188

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_DemocraticRayne`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_PeoplesFront`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.JoinParty_NFP`
- `BaseGame.JoinParty_PFJP`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.NFPLeader_Remus`
- `BaseGame.NewParty_DemocratParty`
- `BaseGame.NewParty_LiberalParty`
- `BaseGame.NewParty_MaroonParty`
- `BaseGame.NewParty_PeoplesParty`
- `BaseGame.PFJPLeader_Manoly`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_3`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn09_A_LileasResigned`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_JoinedOtherParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn11_Election_AssassinationHappened`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGameIsolated.Epilogue_Election_Forcedout`
- `BaseGameIsolated.Epilogue_Election_LateRetire`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Kesaro`
- `BaseGame.Epilogue_NewPresident_Lileas`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Retirement_Arcasia`
- `BaseGame.Retirement_UnitedContana`
- `BaseGameIsolated.Epilogue_Election_Forcedout`
- `BaseGameIsolated.Epilogue_Election_LateRetire`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Skoki między-konwersacyjne:
- Węzeł `[561]` -> **[273] Sordland/ARCASIA OR UC ELECTION ENDING** (../Epilogue/273_ARCASIA_OR_UC_ELECTION_ENDING.md), Węzeł `[1]`
- Węzeł `[562]` -> **[272] Sordland/ANRICA ELECTION ENDING** (../Epilogue/272_ANRICA_ELECTION_ENDING.md), Węzeł `[1]`
- Węzeł `[563]` -> **[274] Sordland/ERLORY ELECTION ENDING** (../Epilogue/274_ERLORY_ELECTION_ENDING.md), Węzeł `[1]`
- Węzeł `[564]` -> **[275] Sordland/BENFI ELECTION ENDING** (../Epilogue/275_BENFI_ELECTION_ENDING.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"Once again, your moment of truth had come."** | `[3]` **Narrator**: "On election day, millions went o..."<br>`[33]` **Narrator**: "On election day, millions went o..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");`<br>`Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[5]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player**: "You were devastated by the results."<br>`[37]` **Player**: "Maybe this was for the better." |
| `[34]` | **"You were devastated by the results."** | `[5]` **Narrator**: "The United Sordland Party came o..."<br>`[35]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_suitcase");` | `[107]` **Narrator**: "You accepted the situation and r..." |
| `[35]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player**: "You were devastated by the results."<br>`[37]` **Player**: "Maybe this was for the better." |
| `[36]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player**: "You were devastated by the results."<br>`[37]` **Player**: "Maybe this was for the better." |
| `[37]` | **"Maybe this was for the better."** | `[5]` **Narrator**: "The United Sordland Party came o..."<br>`[35]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_suitcase");` | `[107]` **Narrator**: "You accepted the situation and r..." |
| `[38]` | **"It felt good to return to the Assembly, where it all started."** | `[40]` **Narrator**: "The United Sordland Party came o..."<br>`[78]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[363]` **Narrator**: "In a historic moment, the Commun..." |
| `[39]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player**: "You were devastated by the results."<br>`[37]` **Player**: "Maybe this was for the better." |
| `[40]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "You were devastated by the results."<br>`[38]` **Player**: "It felt good to return to the As..." |
| `[48]` | **"...worked with lobbyists to increase your power base."** | `[54]` **Narrator**: "Your overtures did not result in..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[178]` **Narrator**: "A year later, Lileas went after ..." |
| `[49]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "You were devastated by the betra..."<br>`[103]` **Player**: "Maybe this was for the best." |
| `[50]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "You were devastated by the betra..."<br>`[103]` **Player**: "Maybe this was for the best." |
| `[54]` | **"1958"** | `[73]` **Player**: "You tried to cooperate with the ..."<br>`[74]` **Player**: "You tried to cooperate with the ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Player**: "...kept serving your duty as the..."<br>`[60]` **Player**: "...tried to boost your visibilit..."<br>*(oraz 1 innych odgałęzień)* |
| `[55]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "You were devastated by the betra..."<br>`[103]` **Player**: "Maybe this was for the best." |
| `[56]` | **"...kept serving your duty as the opposition by pointing out mistakes and suggestin..."** | `[54]` **Narrator**: "Your overtures did not result in..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[178]` **Narrator**: "A year later, Lileas went after ..." |
| `[60]` | **"...tried to boost your visibility through media stunts."** | `[54]` **Narrator**: "Your overtures did not result in..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[178]` **Narrator**: "A year later, Lileas went after ..." |
| `[61]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "You were devastated by the betra..."<br>`[103]` **Player**: "Maybe this was for the best." |
| `[62]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "You were devastated by the betra..."<br>`[103]` **Player**: "Maybe this was for the best." |
| `[63]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "You were devastated by the betra..."<br>`[103]` **Player**: "Maybe this was for the best." |
| `[67]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Player**: "You were devastated by the results."<br>`[70]` **Player**: "It felt good to return to the As..."<br>*(oraz 1 innych odgałęzień)* |
| `[69]` | **"You decided to retire from politics after this failure."** | `[67]` **Narrator**: "In a historic result, the United..."<br>`[380]` **Narrator**: "In a historic result, the United..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_suitcase");` | `[107]` **Narrator**: "You accepted the situation and r..." |
| `[70]` | **"It felt good to return to the Assembly, where it all started."** | `[67]` **Narrator**: "In a historic result, the United..."<br>`[380]` **Narrator**: "In a historic result, the United..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[455]` **Narrator**: "No other party managed to enter ..."<br>`[456]` **Narrator**: "Some new independents managed to..." |
| `[71]` | **"You were devastated by the results."** | `[67]` **Narrator**: "In a historic result, the United..."<br>`[380]` **Narrator**: "In a historic result, the United..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[455]` **Narrator**: "No other party managed to enter ..."<br>`[456]` **Narrator**: "Some new independents managed to..." |
| `[73]` | **"You tried to cooperate with the Communist Party."** | `[47]` **Narrator**: "In a historic moment, the Commun..."<br>`[68]` **Narrator**: "In a historic moment, the Commun..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_forcedout");` | `[54]` **Narrator**: "Your overtures did not result in..." |
| `[74]` | **"You tried to cooperate with the PFJP."** | `[47]` **Narrator**: "In a historic moment, the Commun..."<br>`[68]` **Narrator**: "In a historic moment, the Commun..."<br>*(oraz 7 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | `PrologueImage("pe_forcedout");` | `[54]` **Narrator**: "Your overtures did not result in..." |
| `[78]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "You were devastated by the results."<br>`[38]` **Player**: "It felt good to return to the As..." |
| `[82]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "You were devastated by the results."<br>`[38]` **Player**: "It felt good to return to the As..." |
| `[92]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "You were devastated by the results."<br>`[38]` **Player**: "It felt good to return to the As..." |
| `[93]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "You were devastated by the results."<br>`[38]` **Player**: "It felt good to return to the As..." |
| `[94]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player**: "You were devastated by the results."<br>`[37]` **Player**: "Maybe this was for the better." |
| `[95]` | **"You were devastated by the results."** | `[40]` **Narrator**: "The United Sordland Party came o..."<br>`[78]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[363]` **Narrator**: "In a historic moment, the Commun..." |
| `[96]` | **"You tried to cooperate with the Workers' Party of Bludia."** | `[72]` **Narrator**: "In a historic moment, the Worker..."<br>`[378]` **Narrator**: "In a historic moment, the Worker..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_forcedout");` | `[54]` **Narrator**: "Your overtures did not result in..." |
| `[100]` | **"You tried to cooperate with the NFP."** | `[47]` **Narrator**: "In a historic moment, the Commun..."<br>`[68]` **Narrator**: "In a historic moment, the Commun..."<br>*(oraz 7 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | `PrologueImage("pe_forcedout");` | `[54]` **Narrator**: "Your overtures did not result in..." |
| `[101]` | **"You tried to cooperate with the pro-Bludish parties."** | `[68]` **Narrator**: "In a historic moment, the Commun..."<br>`[370]` **Narrator**: "In a historic moment, the Commun..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_forcedout");` | `[54]` **Narrator**: "Your overtures did not result in..." |
| `[102]` | **"You were devastated by the betrayal."** | `[49]` **Narrator**: "The United Sordland Party came o..."<br>`[50]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_suitcase");` | `[107]` **Narrator**: "You accepted the situation and r..." |
| `[103]` | **"Maybe this was for the best."** | `[49]` **Narrator**: "The United Sordland Party came o..."<br>`[50]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_suitcase");` | `[107]` **Narrator**: "You accepted the situation and r..." |
| `[122]` | **"The die had been recast."** | `[114]` **Narrator**: "In another historic moment, the ..."<br>`[115]` **Narrator**: "In another historic moment, the ..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[389]` **Narrator**: "A year later, President Remus Ho..."<br>`[388]` **Narrator**: "A year later, President Kesaro K..."<br>*(oraz 2 innych odgałęzień)* |
| `[130]` | **"You never saw either of them ever again."** | `[153]` **Narrator**: "The ensuing scandal erased most ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_meeting");` | `[133]` **Narrator**: "A year later, Manoly began a mas..."<br>`[137]` **Narrator**: "A year later, Frens began a mass..." |
| `[131]` | **"Years went by."** | `[138]` **Narrator**: "Monica raised herself to new hei..."<br>`[143]` **Narrator**: "Monica ignored you and in time, ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_meeting");` | `[133]` **Narrator**: "A year later, Manoly began a mas..."<br>`[137]` **Narrator**: "A year later, Frens began a mass..." |
| `[132]` | **"You never talked to Monica again."** | `[142]` **Narrator**: "Your attitude created tensions b..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_meeting");` | `[133]` **Narrator**: "A year later, Manoly began a mas..."<br>`[137]` **Narrator**: "A year later, Frens began a mass..." |
| `[133]` | **"1960"** | `[130]` **Player**: "You never saw either of them eve..."<br>`[131]` **Player**: "Years went by."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.PFJPLeader_Manoly"] == true` | *Brak zmian stanu* | `[144]` **Player**: "You accepted."<br>`[145]` **Player**: "You rejected the offer, but supp..."<br>*(oraz 1 innych odgałęzień)* |
| `[137]` | **"1960"** | `[130]` **Player**: "You never saw either of them eve..."<br>`[131]` **Player**: "Years went by."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false` | *Brak zmian stanu* | `[144]` **Player**: "You accepted."<br>`[145]` **Player**: "You rejected the offer, but supp..."<br>*(oraz 1 innych odgałęzień)* |
| `[144]` | **"You accepted."** | `[133]` **Narrator**: "A year later, Manoly began a mas..."<br>`[137]` **Narrator**: "A year later, Frens began a mass..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Narrator**: "Unfortunately, the proposal did ..." |
| `[145]` | **"You rejected the offer, but supported the proposal nonetheless."** | `[133]` **Narrator**: "A year later, Manoly began a mas..."<br>`[137]` **Narrator**: "A year later, Frens began a mass..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Narrator**: "Unfortunately, the proposal did ..." |
| `[146]` | **"You actively worked against the proposal."** | `[133]` **Narrator**: "A year later, Manoly began a mas..."<br>`[137]` **Narrator**: "A year later, Frens began a mass..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Narrator**: "By fighting tooth-and-nail again..." |
| `[147]` | **"...found some racy photos you'd once taken of her, and leaked them to the press."** | `[163]` **Narrator**: "Meanwhile, you couldn't help but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Narrator**: "The ensuing scandal erased most ..." |
| `[154]` | **"1958"** | `[122]` **Player**: "The die had been recast." | `Variable["BaseGame.PFJPLeader_Manoly"] == true`<br>`(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false` | *Brak zmian stanu* | `[162]` **Player**: "You supported the PFJP's policies."<br>`[161]` **Player**: "You protested against the PFJP's..." |
| `[155]` | **"1961"** | `[144]` **Player**: "You accepted."<br>`[145]` **Player**: "You rejected the offer, but supp..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] ...` | `[343]` **Player**: "You were a broken man."<br>`[344]` **Player**: "You felt only relief." |
| `[156]` | **"...advised her to stop."** | `[165]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "Monica ignored you and in time, ..."<br>`[142]` **Narrator**: "Your attitude created tensions b..." |
| `[157]` | **"1958"** | `[122]` **Player**: "The die had been recast." | `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`<br>`(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false` | *Brak zmian stanu* | `[162]` **Player**: "You supported the PFJP's policies."<br>`[161]` **Player**: "You protested against the PFJP's..." |
| `[161]` | **"You protested against the PFJP's policies."** | `[154]` **Narrator**: "A year later, President Manoly S..."<br>`[157]` **Narrator**: "A year later, President Frens Ri..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[165]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[163]` **Narrator**: "Meanwhile, you couldn't help but..." |
| `[162]` | **"You supported the PFJP's policies."** | `[154]` **Narrator**: "A year later, President Manoly S..."<br>`[157]` **Narrator**: "A year later, President Frens Ri..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[165]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[163]` **Narrator**: "Meanwhile, you couldn't help but..." |
| `[163]` | **"1959"** | `[161]` **Player**: "You protested against the PFJP's..."<br>`[162]` **Player**: "You supported the PFJP's policies." | `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[166]` **Player**: "...vocally supported her."<br>`[164]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[164]` | **"...stayed silent."** | `[163]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[165]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "Monica raised herself to new hei..." |
| `[165]` | **"1959"** | `[161]` **Player**: "You protested against the PFJP's..."<br>`[162]` **Player**: "You supported the PFJP's policies." | `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[166]` **Player**: "...vocally supported her."<br>`[164]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[166]` | **"...vocally supported her."** | `[163]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[165]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[148]` **Narrator**: "You and Monica began speaking to..." |
| `[167]` | **"...found some racy photos you'd once taken of her, and leaked them to the press."** | `[170]` **Narrator**: "Meanwhile, you couldn't help but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "The ensuing scandal erased most ..." |
| `[168]` | **"...advised her to stop."** | `[170]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[189]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Narrator**: "Monica ignored you and, in time,..."<br>`[184]` **Narrator**: "Your attitude created tensions b..." |
| `[169]` | **"You protested against her policies."** | `[178]` **Narrator**: "A year later, Lileas went after ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[189]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[170]` **Narrator**: "Meanwhile, you couldn't help but..." |
| `[170]` | **"1959"** | `[169]` **Player**: "You protested against her policies."<br>`[194]` **Player**: "You supported the governing party." | `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[180]` **Player**: "...vocally supported her."<br>`[168]` **Player**: "...advised her to stop."<br>*(oraz 1 innych odgałęzień)* |
| `[171]` | **"1960"** | `[179]` **Player**: "You never talked to Monica again."<br>`[181]` **Player**: "You never saw either of them eve..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Player**: "You accepted."<br>`[195]` **Player**: "You actively worked against the ..." |
| `[178]` | **"1958"** | `[48]` **Player**: "...worked with lobbyists to incr..."<br>`[56]` **Player**: "...kept serving your duty as the..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Player**: "You supported the governing party."<br>`[169]` **Player**: "You protested against her policies." |
| `[179]` | **"You never talked to Monica again."** | `[184]` **Narrator**: "Your attitude created tensions b..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[171]` **Narrator**: "A year later, Lileas began a mas..." |
| `[180]` | **"...vocally supported her."** | `[170]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[189]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[186]` **Narrator**: "You and Monica began speaking to..." |
| `[181]` | **"You never saw either of them ever again."** | `[183]` **Narrator**: "The ensuing scandal erased most ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[171]` **Narrator**: "A year later, Lileas began a mas..." |
| `[187]` | **"...stayed silent."** | `[189]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Narrator**: "Monica raised herself to new hei..." |
| `[189]` | **"1959"** | `[169]` **Player**: "You protested against her policies."<br>`[194]` **Player**: "You supported the governing party." | `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[180]` **Player**: "...vocally supported her."<br>`[187]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[190]` | **"Years went by."** | `[182]` **Narrator**: "Monica raised herself to new hei..."<br>`[185]` **Narrator**: "Monica ignored you and, in time,..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[171]` **Narrator**: "A year later, Lileas began a mas..." |
| `[194]` | **"You supported the governing party."** | `[178]` **Narrator**: "A year later, Lileas went after ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[189]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[170]` **Narrator**: "Meanwhile, you couldn't help but..." |
| `[195]` | **"You actively worked against the undemocratic proposal."** | `[171]` **Narrator**: "A year later, Lileas began a mas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Narrator**: "You formed a grassroots coalitio..." |
| `[196]` | **"You accepted."** | `[171]` **Narrator**: "A year later, Lileas began a mas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Narrator**: "After you supported Lileas' prop..." |
| `[201]` | **"You thought it was all for the best."** | `[203]` **Narrator**: "After you supported Lileas' prop..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"]...`<br>`PrologueImage("pe_suitcase");` | `[205]` **Narrator**: "You accepted the situation and r..." |
| `[202]` | **"You were devastated by the betrayal."** | `[203]` **Narrator**: "After you supported Lileas' prop..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"]...`<br>`PrologueImage("pe_suitcase");` | `[205]` **Narrator**: "You accepted the situation and r..." |
| `[203]` | **"1961"** | `[196]` **Player**: "You accepted." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] ...` | `[202]` **Player**: "You were devastated by the betra..."<br>`[201]` **Player**: "You thought it was all for the b..." |
| `[206]` | **"1960\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Player**: "...vocally supported her."<br>`[213]` **Player**: "...found some racy photos you'd ..." |
| `[207]` | **"...began writing a memoir."** | `[208]` **Narrator**: "With your political career behin..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] =...`<br>`PrologueImage("pe_monicaspeech");` | *Koniec sceny / Terminal* |
| `[209]` | **"1960\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Player**: "...vocally supported her."<br>`[213]` **Player**: "...found some racy photos you'd ..." |
| `[211]` | **"...became an adjunct professor of politics at Holsord State University."** | `[208]` **Narrator**: "With your political career behin..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[214]` **Narrator**: "As you used your remaining polit..." |
| `[212]` | **"...stayed silent, but agreed to look after Deana as Monica spent more and more tim..."** | `[233]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[234]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[232]` **Narrator**: "You and Monica began speaking to..." |
| `[213]` | **"...found some racy photos you'd once taken of her, and leaked them to the press."** | `[206]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[209]` **Narrator**: "Meanwhile, you couldn't help but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "The ensuing scandal erased most ..." |
| `[214]` | **"1965\|Holsord"** | `[243]` **Player**: "You never saw either of them eve..."<br>`[280]` **Player**: "Years went by."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`<br>`Variable["BaseGame.Turn05_P_Underhall"] == true`<br>`Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true` | *Brak zmian stanu* | `[219]` **Player**: "You didn't care."<br>`[216]` **Player**: "You lost sleep over it." |
| `[215]` | **"...actually, you had no regrets."** | `[260]` **Narrator**: "You lived out the rest of your d..."<br>`[467]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[216]` | **"You lost sleep over it."** | `[214]` **Narrator**: "As you used your remaining polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("pe_blue");` | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..."<br>*(oraz 2 innych odgałęzień)* |
| `[217]` | **"...actually, you had no regrets."** | `[261]` **Narrator**: "You lived out the rest of your d..."<br>`[463]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[218]` | **"...refused to give him anything."** | `[285]` **Narrator**: "As you used your remaining polit..."<br>`[506]` **Narrator**: "As you used your remaining polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("pe_blue");` | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..."<br>*(oraz 2 innych odgałęzień)* |
| `[219]` | **"You didn't care."** | `[214]` **Narrator**: "As you used your remaining polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("pe_blue");` | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..."<br>*(oraz 2 innych odgałęzień)* |
| `[220]` | **"You didn't respond."** | `[278]` **Narrator**: "After years of hard work, your m..."<br>`[485]` **Narrator**: "After years of hard work, your m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("pe_blue");` | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..."<br>*(oraz 2 innych odgałęzień)* |
| `[221]` | **"...were never able to mend your marriage with Monica."** | `[279]` **Narrator**: "You lived out the rest of your d..."<br>`[471]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[222]` | **"...actually, you had no regrets."** | `[279]` **Narrator**: "You lived out the rest of your d..."<br>`[471]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[223]` | **"...never got back into politics."** | `[279]` **Narrator**: "You lived out the rest of your d..."<br>`[471]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[227]` | **"...actually, you had no regrets."** | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[228]` | **"...didn't fulfill the goals you'd set out as President."** | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[229]` | **"...never got back into politics."** | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[230]` | **"You were happy to reconnect with him."** | `[278]` **Narrator**: "After years of hard work, your m..."<br>`[485]` **Narrator**: "After years of hard work, your m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("pe_blue");` | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..."<br>*(oraz 2 innych odgałęzień)* |
| `[231]` | **"...joined the board of Underhall Construction."** | `[208]` **Narrator**: "With your political career behin..." | `Variable["BaseGame.Turn05_P_Underhall"] == true` | `PrologueImage("pe_monicaspeech");` | `[214]` **Narrator**: "As you used your remaining polit..." |
| `[234]` | **"1960\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Player**: "...vocally supported her."<br>`[212]` **Player**: "...stayed silent, but agreed to ..." |
| `[241]` | **"...vocally supported her."** | `[206]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[209]` **Narrator**: "Meanwhile, you couldn't help but..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[232]` **Narrator**: "You and Monica began speaking to..." |
| `[243]` | **"You never saw either of them ever again."** | `[210]` **Narrator**: "The ensuing scandal erased most ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Narrator**: "As you used your remaining polit..."<br>`[506]` **Narrator**: "As you used your remaining polit..."<br>*(oraz 2 innych odgałęzień)* |
| `[250]` | **"...helped him with whatever he needed."** | `[285]` **Narrator**: "As you used your remaining polit..."<br>`[506]` **Narrator**: "As you used your remaining polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("pe_blue");` | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..."<br>*(oraz 2 innych odgałęzień)* |
| `[260]` | **"1975\|Holsord"** | `[351]` **Player**: "...life went on." | `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`<br>`(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[273]` **Player**: "...never got back into politics."<br>`[274]` **Player**: "...were never able to mend your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[261]` | **"1975\|Holsord"** | `[351]` **Player**: "...life went on." | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`<br>`Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[276]` **Player**: "...never got back into politics."<br>`[275]` **Player**: "...didn't fulfill the goals you'..."<br>*(oraz 1 innych odgałęzień)* |
| `[265]` | **"1975\|Holsord"** | `[216]` **Player**: "You lost sleep over it."<br>`[218]` **Player**: "...refused to give him anything."<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`<br>`Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[229]` **Player**: "...never got back into politics."<br>`[228]` **Player**: "...didn't fulfill the goals you'..."<br>*(oraz 1 innych odgałęzień)* |
| `[272]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Player**: "...life went on." |
| `[273]` | **"...never got back into politics."** | `[260]` **Narrator**: "You lived out the rest of your d..."<br>`[467]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[274]` | **"...were never able to mend your marriage with Monica."** | `[260]` **Narrator**: "You lived out the rest of your d..."<br>`[467]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[275]` | **"...didn't fulfill the goals you'd set out as President."** | `[261]` **Narrator**: "You lived out the rest of your d..."<br>`[463]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[276]` | **"...never got back into politics."** | `[261]` **Narrator**: "You lived out the rest of your d..."<br>`[463]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[277]` | **"1965\|Holsord"** | `[243]` **Player**: "You never saw either of them eve..."<br>`[280]` **Player**: "Years went by." | `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`<br>`Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`<br>`(Variable["BaseGame.Turn05_P_Underhall"] == true) == false` | *Brak zmian stanu* | `[352]` **Player**: "Fame doesn't hurt." |
| `[278]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Player**: "You were happy to reconnect with..."<br>`[220]` **Player**: "You didn't respond." |
| `[279]` | **"1975\|Holsord"** | `[216]` **Player**: "You lost sleep over it."<br>`[218]` **Player**: "...refused to give him anything."<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`<br>`(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[223]` **Player**: "...never got back into politics."<br>`[221]` **Player**: "...were never able to mend your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[280]` | **"Years went by."** | `[232]` **Narrator**: "You and Monica began speaking to..."<br>`[242]` **Narrator**: "Your support buoyed Monica to ne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Narrator**: "As you used your remaining polit..."<br>`[506]` **Narrator**: "As you used your remaining polit..."<br>*(oraz 2 innych odgałęzień)* |
| `[281]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Player**: "...life went on." |
| `[285]` | **"1965\|Holsord"** | `[243]` **Player**: "You never saw either of them eve..."<br>`[280]` **Player**: "Years went by." | `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`<br>`Variable["BaseGame.Turn05_P_Underhall"] == true` | *Brak zmian stanu* | `[250]` **Player**: "...helped him with whatever he n..."<br>`[218]` **Player**: "...refused to give him anything." |
| `[287]` | **"...moved to the coast of Benfi."** | `[107]` **Narrator**: "You accepted the situation and r..."<br>`[205]` **Narrator**: "You accepted the situation and r..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_coast");` | `[33]` **Narrator**: "On election day, millions went o..."<br>`[3]` **Narrator**: "On election day, millions went o..." |
| `[294]` | **"...decided to stay in Holsord."** | `[107]` **Narrator**: "You accepted the situation and r..."<br>`[205]` **Narrator**: "You accepted the situation and r..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[208]` **Narrator**: "With your political career behin..." |
| `[295]` | **"...decided to try your luck managing FC Anrica."** | `[107]` **Narrator**: "You accepted the situation and r..."<br>`[205]` **Narrator**: "You accepted the situation and r..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true`<br>`(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false` | `PrologueImage("pe_city");` | `[33]` **Narrator**: "On election day, millions went o..."<br>`[3]` **Narrator**: "On election day, millions went o..." |
| `[296]` | **"...dedicated yourself to making wine in your vineyard in Erlory."** | `[107]` **Narrator**: "You accepted the situation and r..."<br>`[205]` **Narrator**: "You accepted the situation and r..." | `Variable["BaseGame.Turn05_P_Vineyard"] == true` | `PrologueImage("pe_city");` | `[33]` **Narrator**: "On election day, millions went o..."<br>`[3]` **Narrator**: "On election day, millions went o..." |
| `[303]` | **"...moved to Arcasia."** | `[107]` **Narrator**: "You accepted the situation and r..."<br>`[205]` **Narrator**: "You accepted the situation and r..." | `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Joined_ATO"] == true)  and  Variable["BaseGame.Archetype_ComradeRayne"] == false`<br>`(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`<br>`(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false` | `Variable["BaseGame.Retirement_Arcasia"] = true;`<br>`PrologueImage("pe_plane");` | *Koniec sceny / Terminal* |
| `[304]` | **"...moved to United Contana."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Retirement_UnitedContana"] = true;`<br>`PrologueImage("pe_plane");` | *Koniec sceny / Terminal* |
| `[315]` | **"Your struggle for the country continued."** | `[197]` **Narrator**: "You formed a grassroots coalitio..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[319]` **Narrator**: "In the next election, the PFJP w..." |
| `[316]` | **"1964"** | `[318]` **Player**: "You were stronger together." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Player**: "...decided that it was time to r..."<br>`[321]` **Player**: "...tried to shift the country to..."<br>*(oraz 1 innych odgałęzień)* |
| `[317]` | **"...strengthened Sordland's democratic institutions and the separation of power."** | `[316]` **Narrator**: "Throughout the term, your acts l..." | `Variable["BaseGame.Archetype_DemocraticRayne"] == true` | *Brak zmian stanu* | `[328]` **Narrator**: "Sordish democracy became a beaco..." |
| `[318]` | **"You were stronger together."** | `[319]` **Narrator**: "In the next election, the PFJP w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Narrator**: "Throughout the term, your acts l..." |
| `[319]` | **"1961"** | `[315]` **Player**: "Your struggle for the country co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Player**: "You were stronger together." |
| `[320]` | **"...decided that it was time to retire."** | `[316]` **Narrator**: "Throughout the term, your acts l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Narrator**: "You spent your retirement enjoyi..." |
| `[321]` | **"...tried to shift the country towards democratic socialism."** | `[316]` **Narrator**: "Throughout the term, your acts l..." | `Variable["BaseGame.Archetype_ComradeRayne"] == true` | *Brak zmian stanu* | `[334]` **Narrator**: "The sentiment towards socialism ..." |
| `[328]` | **"1970"** | `[317]` **Player**: "...strengthened Sordland's democ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Player**: "...another politician that tried..."<br>`[332]` **Player**: "...a saviour of Sordish democracy."<br>*(oraz 1 innych odgałęzień)* |
| `[329]` | **"1970"** | `[320]` **Player**: "...decided that it was time to r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Player**: "...a diligent civil servant."<br>`[330]` **Player**: "...a popular hero that came to t..."<br>*(oraz 1 innych odgałęzień)* |
| `[330]` | **"...a popular hero that came to the country in a time of need."** | `[329]` **Narrator**: "You spent your retirement enjoyi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[331]` | **"...a beacon of hope and change."** | `[328]` **Narrator**: "Sordish democracy became a beaco..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[332]` | **"...a saviour of Sordish democracy."** | `[328]` **Narrator**: "Sordish democracy became a beaco..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[333]` | **"...a diligent civil servant."** | `[329]` **Narrator**: "You spent your retirement enjoyi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[334]` | **"1970"** | `[321]` **Player**: "...tried to shift the country to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Player**: "...another politician that tried..."<br>`[335]` **Player**: "...a hero of the working class."<br>*(oraz 1 innych odgałęzień)* |
| `[335]` | **"...a hero of the working class."** | `[334]` **Narrator**: "The sentiment towards socialism ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[336]` | **"...the saviour of the downtrodden."** | `[334]` **Narrator**: "The sentiment towards socialism ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[337]` | **"...another politician that tried to do their best."** | `[328]` **Narrator**: "Sordish democracy became a beaco..."<br>`[329]` **Narrator**: "You spent your retirement enjoyi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[343]` | **"You were a broken man."** | `[155]` **Narrator**: "Unfortunately, the proposal did ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"]...`<br>`PrologueImage("pe_suitcase");` | `[205]` **Narrator**: "You accepted the situation and r..." |
| `[344]` | **"You felt only relief."** | `[155]` **Narrator**: "Unfortunately, the proposal did ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"]...`<br>`PrologueImage("pe_suitcase");` | `[205]` **Narrator**: "You accepted the situation and r..." |
| `[346]` | **"1961"** | `[146]` **Player**: "You actively worked against the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Player**: "You decided to retire."<br>`[348]` **Player**: "You soldiered on." |
| `[347]` | **"You decided to retire."** | `[346]` **Narrator**: "By fighting tooth-and-nail again..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"]...`<br>`PrologueImage("pe_suitcase");` | `[205]` **Narrator**: "You accepted the situation and r..." |
| `[348]` | **"You soldiered on."** | `[346]` **Narrator**: "By fighting tooth-and-nail again..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[349]` **Narrator**: "You lived out the rest of your d..." |
| `[350]` | **"It's a dead end."** | `[349]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[351]` | **"...life went on."** | `[272]` **Narrator**: "You threw yourself into your tea..."<br>`[281]` **Narrator**: "You threw yourself into your tea..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[261]` **Narrator**: "You lived out the rest of your d..."<br>`[463]` **Narrator**: "You lived out the rest of your d..."<br>*(oraz 2 innych odgałęzień)* |
| `[352]` | **"Fame doesn't hurt."** | `[277]` **Narrator**: "After years of hard work, your m..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("pe_blue");` | `[265]` **Narrator**: "You lived out the rest of your d..."<br>`[475]` **Narrator**: "You lived out the rest of your d..."<br>*(oraz 2 innych odgałęzień)* |
| `[380]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Player**: "You were devastated by the results."<br>`[70]` **Player**: "It felt good to return to the As..."<br>*(oraz 1 innych odgałęzień)* |
| `[381]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Player**: "You were devastated by the results."<br>`[70]` **Player**: "It felt good to return to the As..."<br>*(oraz 1 innych odgałęzień)* |
| `[388]` | **"1958"** | `[122]` **Player**: "The die had been recast." | `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`<br>`Variable["BaseGame.Faction_PFJP_Destroyed"] == true` | *Brak zmian stanu* | `[393]` **Player**: "You supported the NFP's policies."<br>`[394]` **Player**: "You protested the NFP's policies." |
| `[389]` | **"1958"** | `[122]` **Player**: "The die had been recast." | `Variable["BaseGame.NFPLeader_Remus"] == true`<br>`Variable["BaseGame.Faction_PFJP_Destroyed"] == true` | *Brak zmian stanu* | `[393]` **Player**: "You supported the NFP's policies."<br>`[394]` **Player**: "You protested the NFP's policies." |
| `[393]` | **"You supported the NFP's policies."** | `[388]` **Narrator**: "A year later, President Kesaro K..."<br>`[389]` **Narrator**: "A year later, President Remus Ho..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[409]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[408]` **Narrator**: "Meanwhile, you couldn't help but..." |
| `[394]` | **"You protested the NFP's policies."** | `[388]` **Narrator**: "A year later, President Kesaro K..."<br>`[389]` **Narrator**: "A year later, President Remus Ho..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[409]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[408]` **Narrator**: "Meanwhile, you couldn't help but..." |
| `[408]` | **"1959"** | `[393]` **Player**: "You supported the NFP's policies."<br>`[394]` **Player**: "You protested the NFP's policies." | `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[419]` **Player**: "...vocally supported her."<br>`[418]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[409]` | **"1959"** | `[393]` **Player**: "You supported the NFP's policies."<br>`[394]` **Player**: "You protested the NFP's policies." | `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[419]` **Player**: "...vocally supported her."<br>`[418]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[413]` | **"...found some racy photos you'd once taken of her, and leaked them to the press."** | `[408]` **Narrator**: "Meanwhile, you couldn't help but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[430]` **Narrator**: "The ensuing scandal erased most ..." |
| `[417]` | **"...advised her to stop."** | `[409]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Narrator**: "Monica ignored you and in time, ..."<br>`[431]` **Narrator**: "Your attitude created tensions b..." |
| `[418]` | **"...stayed silent."** | `[408]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[409]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Narrator**: "Monica raised herself to new hei..." |
| `[419]` | **"...vocally supported her."** | `[408]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[409]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[422]` **Narrator**: "You and Monica began speaking to..." |
| `[420]` | **"You never saw either of them ever again."** | `[430]` **Narrator**: "The ensuing scandal erased most ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_meeting");` | `[433]` **Narrator**: "A year later, Remus began a mass..."<br>`[434]` **Narrator**: "A year later, Kesaro began a mas..." |
| `[424]` | **"You never talked to Monica again."** | `[431]` **Narrator**: "Your attitude created tensions b..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_meeting");` | `[433]` **Narrator**: "A year later, Remus began a mass..."<br>`[434]` **Narrator**: "A year later, Kesaro began a mas..." |
| `[425]` | **"Years went by."** | `[421]` **Narrator**: "Monica ignored you and in time, ..."<br>`[422]` **Narrator**: "You and Monica began speaking to..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_meeting");` | `[433]` **Narrator**: "A year later, Remus began a mass..."<br>`[434]` **Narrator**: "A year later, Kesaro began a mas..." |
| `[433]` | **"1960"** | `[420]` **Player**: "You never saw either of them eve..."<br>`[424]` **Player**: "You never talked to Monica again."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true` | *Brak zmian stanu* | `[435]` **Player**: "You accepted."<br>`[436]` **Player**: "You rejected the offer, but supp..."<br>*(oraz 1 innych odgałęzień)* |
| `[434]` | **"1960"** | `[420]` **Player**: "You never saw either of them eve..."<br>`[424]` **Player**: "You never talked to Monica again."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false` | *Brak zmian stanu* | `[435]` **Player**: "You accepted."<br>`[436]` **Player**: "You rejected the offer, but supp..."<br>*(oraz 1 innych odgałęzień)* |
| `[435]` | **"You accepted."** | `[433]` **Narrator**: "A year later, Remus began a mass..."<br>`[434]` **Narrator**: "A year later, Kesaro began a mas..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");` | `[437]` **Narrator**: "Unfortunately, the proposal did ..." |
| `[436]` | **"You rejected the offer, but supported the proposal nonetheless."** | `[433]` **Narrator**: "A year later, Remus began a mass..."<br>`[434]` **Narrator**: "A year later, Kesaro began a mas..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");` | `[437]` **Narrator**: "Unfortunately, the proposal did ..." |
| `[437]` | **"1961"** | `[435]` **Player**: "You accepted."<br>`[436]` **Player**: "You rejected the offer, but supp..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] ...` | `[443]` **Player**: "You were a broken man."<br>`[439]` **Player**: "You felt only relief." |
| `[438]` | **"You soldiered on."** | `[442]` **Narrator**: "By fighting tooth-and-nail again..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[349]` **Narrator**: "You lived out the rest of your d..." |
| `[439]` | **"You felt only relief."** | `[437]` **Narrator**: "Unfortunately, the proposal did ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"]...`<br>`PrologueImage("pe_suitcase");` | `[205]` **Narrator**: "You accepted the situation and r..." |
| `[440]` | **"You actively worked against the proposal."** | `[433]` **Narrator**: "A year later, Remus began a mass..."<br>`[434]` **Narrator**: "A year later, Kesaro began a mas..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");` | `[442]` **Narrator**: "By fighting tooth-and-nail again..." |
| `[441]` | **"You decided to retire."** | `[442]` **Narrator**: "By fighting tooth-and-nail again..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[349]` **Narrator**: "You lived out the rest of your d..." |
| `[442]` | **"1961"** | `[440]` **Player**: "You actively worked against the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[441]` **Player**: "You decided to retire."<br>`[438]` **Player**: "You soldiered on." |
| `[443]` | **"You were a broken man."** | `[437]` **Narrator**: "Unfortunately, the proposal did ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"]...`<br>`PrologueImage("pe_suitcase");` | `[205]` **Narrator**: "You accepted the situation and r..." |
| `[444]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "You were devastated by the betra..."<br>`[103]` **Player**: "Maybe this was for the best." |
| `[463]` | **"1975\|Holsord"** | `[351]` **Player**: "...life went on." | `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`<br>`Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[276]` **Player**: "...never got back into politics."<br>`[275]` **Player**: "...didn't fulfill the goals you'..."<br>*(oraz 1 innych odgałęzień)* |
| `[467]` | **"1975\|Holsord"** | `[351]` **Player**: "...life went on." | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`<br>`(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[273]` **Player**: "...never got back into politics."<br>`[274]` **Player**: "...were never able to mend your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[471]` | **"1975\|Holsord"** | `[216]` **Player**: "You lost sleep over it."<br>`[218]` **Player**: "...refused to give him anything."<br>*(oraz 5 innych węzłów)* | `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`<br>`(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[223]` **Player**: "...never got back into politics."<br>`[221]` **Player**: "...were never able to mend your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[475]` | **"1975\|Holsord"** | `[216]` **Player**: "You lost sleep over it."<br>`[218]` **Player**: "...refused to give him anything."<br>*(oraz 5 innych węzłów)* | `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`<br>`Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[229]` **Player**: "...never got back into politics."<br>`[228]` **Player**: "...didn't fulfill the goals you'..."<br>*(oraz 1 innych odgałęzień)* |
| `[485]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Player**: "You were happy to reconnect with..."<br>`[220]` **Player**: "You didn't respond." |
| `[486]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Player**: "You were happy to reconnect with..."<br>`[220]` **Player**: "You didn't respond." |
| `[493]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Player**: "...life went on." |
| `[494]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Player**: "...life went on." |
| `[501]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Player**: "...life went on." |
| `[502]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Player**: "...life went on." |
| `[506]` | **"1965\|Holsord"** | `[243]` **Player**: "You never saw either of them eve..."<br>`[280]` **Player**: "Years went by." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`<br>`Variable["BaseGame.Turn05_P_Underhall"] == true` | *Brak zmian stanu* | `[250]` **Player**: "...helped him with whatever he n..."<br>`[218]` **Player**: "...refused to give him anything." |
| `[507]` | **"Then, you woke up."** | `[521]` **Narrator**: "The last thing you remembered wa..."<br>`[524]` **Narrator**: "The last thing you remembered wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[528]` **Narrator**: "As your consciousness returned, ..." |
| `[529]` | **"You opened your eyes."** | `[522]` **Narrator**: "The last thing you remembered wa..."<br>`[523]` **Narrator**: "The last thing you remembered wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[533]` **Narrator**: "Security guards rushed to your s..." |
| `[536]` | **"You saluted him back."** | `[533]` **Narrator**: "Security guards rushed to your s..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[515]` **Narrator**: "Karl Greiser became a hero of th..."<br>`[511]` **Narrator**: "Karl Greiser became a hero of th..." |
| `[540]` | **"Serge's good luck charm."** | `[528]` **Narrator**: "As your consciousness returned, ..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[520]` **Narrator**: "You made a full recovery just in..."<br>`[516]` **Narrator**: "You made a full recovery just in..." |
| `[541]` | **"You saluted him back."** | `[533]` **Narrator**: "Security guards rushed to your s..." | `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[515]` **Narrator**: "Karl Greiser became a hero of th..."<br>`[511]` **Narrator**: "Karl Greiser became a hero of th..." |
| `[545]` | **"Serge's good luck charm."** | `[528]` **Narrator**: "As your consciousness returned, ..." | `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[520]` **Narrator**: "You made a full recovery just in..."<br>`[516]` **Narrator**: "You made a full recovery just in..." |

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
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "Once again, your moment of truth had come."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Once again, your moment of truth had come."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[33]` (Narrator), `[511]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Democrat Party failed to even pass the threshold.

Your term was completely over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "You were devastated by the results."*)
  - -> `[37]` (*Player: "Maybe this was for the better."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_PFJP == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_FormNewParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_FormNewParty == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_FormNewParty == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_FormNewParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Lileas = true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_FormNewParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Lileas = true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_NFP == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_DemocratParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_DemocratParty == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_DemocratParty == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_DemocratParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_DemocratParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Refo..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_DemocratParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_DemocratParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_LiberalParty == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_LiberalParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_LiberalParty == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_LiberalParty == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_LiberalParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_LiberalParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Refo..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_LiberalParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_LiberalParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_PeoplesParty == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_PeoplesParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_PeoplesParty == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_PeoplesParty == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_PeoplesParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_PeoplesParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Refo..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_PeoplesParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_PeoplesParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_MaroonParty == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_MaroonParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_MaroonParty == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_MaroonParty == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_MaroonParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_MaroonParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Refo..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_MaroonParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_MaroonParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Refor..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "On election day, millions went out to cast their votes un..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "On election day, millions went out to cast their votes, s..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "Once again, your moment of truth had come."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the results."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Liberal Party failed to even pass the threshold.

Your term was completely over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "You were devastated by the results."*)
  - -> `[37]` (*Player: "Maybe this was for the better."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Party failed to even pass the threshold.

Your term was completely over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "You were devastated by the results."*)
  - -> `[37]` (*Player: "Maybe this was for the better."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Maybe this was for the better."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It felt good to return to the Assembly, where it all started."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator), `[78]` (Narrator), `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Maroon Party failed to even pass the threshold.

Your term was completely over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "You were devastated by the results."*)
  - -> `[37]` (*Player: "Maybe this was for the better."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Sordish Prosperity Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

Lileas Graf denounced you and your party, calling everyone to isolate and silence your movement."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "You were devastated by the results."*)
  - -> `[38]` (*Player: "It felt good to return to the Assembly, where it all star..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold.

The PFJP came in second and became the second biggest party in the Assembly, leaving the National Front to be the third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[73]` (*Player: "You tried to cooperate with the Communist Party."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worked with lobbyists to increase your power base."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Freedom and Justice Party secured the second spot.

Despite her promise, Manoly pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You were devastated by the betrayal."*)
  - -> `[103]` (*Player: "Maybe this was for the best."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Front failed to even pass the threshold.

Your political career was completely over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You were devastated by the betrayal."*)
  - -> `[103]` (*Player: "Maybe this was for the best."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "Your overtures did not result in any alliances. Most political leaders distanced themselves from you due to your ties with the establishment. 

You stood alone in the Assembly. You gradually realized that accomplishing your party's goals would be impossible under these circumstances.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Player), `[74]` (Player), `[96]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...kept serving your duty as the opposition by pointing o..."*)
  - -> `[60]` (*Player: "...tried to boost your visibility through media stunts."*)
  - -> `[48]` (*Player: "...worked with lobbyists to increase your power base."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Freedom and Justice Party secured the second spot.

Despite his promise, Frens pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You were devastated by the betrayal."*)
  - -> `[103]` (*Player: "Maybe this was for the best."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept serving your duty as the opposition by pointing out mistakes and suggesting solutions."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NFPLeader_Remus == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NFPLeader_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...tried to boost your visibility through media stunts."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the National Front Party secured the second spot, leaving the PFJP behind.

Despite his promise, Remus pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You were devastated by the betrayal."*)
  - -> `[103]` (*Player: "Maybe this was for the best."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the National Front Party secured the second spot, leaving the PFJP behind.

Despite his promise, Kesaro pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You were devastated by the betrayal."*)
  - -> `[103]` (*Player: "Maybe this was for the best."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party under the leadership of Lileas Graf did not secure victory. The People's Freedom and Justice Party had won, pushing the USP to second place for the first time in in history.

Despite her promise, Lileas pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You were devastated by the betrayal."*)
  - -> `[103]` (*Player: "Maybe this was for the best."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == false)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party did not secure victory for the first time in its existence. 

The People's Freedom and Justice Party had won. The NFP secured the second spot, while the USP limped into third.

You were to be a member of the Assembly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "You were devastated by the results."*)
  - -> `[70]` (*Player: "It felt good to return to the Assembly, where it all star..."*)
  - -> `[69]` (*Player: "You decided to retire from politics after this failure."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

The PFJP came in second and became the second biggest party in the Assembly, leaving the National Front to be the third.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[73]` (*Player: "You tried to cooperate with the Communist Party."*)
  - -> `[101]` (*Player: "You tried to cooperate with the pro-Bludish parties."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You decided to retire from politics after this failure."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator), `[380]` (Narrator), `[381]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_Retire]"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It felt good to return to the Assembly, where it all started."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator), `[380]` (Narrator), `[381]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the results."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator), `[380]` (Narrator), `[381]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[72]`
Mówca: **Narrator**
> "In a historic moment, the Workers Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again.

The PFJP once again became the second biggest party in the Assembly; hampered by its lack of leadership, while the NFP came in third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[96]` (*Player: "You tried to cooperate with the Workers' Party of Bludia."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the Communist Party."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[68]` (Narrator), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_forcedout");"*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the PFJP."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[68]` (Narrator), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_forcedout");"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Refo..."*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Re..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Democrat Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

President Lileas Graf denounced you and your party, calling for everyone to isolate and silence you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "You were devastated by the results."*)
  - -> `[38]` (*Player: "It felt good to return to the Assembly, where it all star..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Refo..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Re..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Liberal Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

Lileas Graf denounced you and your party, calling for everyone to isolate and silence you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "You were devastated by the results."*)
  - -> `[38]` (*Player: "It felt good to return to the Assembly, where it all star..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Refo..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Re..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Refo..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Re..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Refor..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Ref..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

Lileas Graf denounced you and your party, calling for everyone to isolate and silence you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "You were devastated by the results."*)
  - -> `[38]` (*Player: "It felt good to return to the Assembly, where it all star..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Maroon Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

Lileas Graf denounced you and your party, calling everyone to isolate and silence your movement."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "You were devastated by the results."*)
  - -> `[38]` (*Player: "It felt good to return to the Assembly, where it all star..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Sordish Prosperity Party failed to even pass the threshold.

Your term was completely over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "You were devastated by the results."*)
  - -> `[37]` (*Player: "Maybe this was for the better."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the results."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator), `[78]` (Narrator), `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the Workers' Party of Bludia."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[378]` (Narrator), `[379]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_forcedout");"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "You tried to cooperate with the PFJP."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "You tried to cooperate with the NFP."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the NFP."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[68]` (Narrator), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_forcedout");"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the pro-Bludish parties."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator), `[370]` (Narrator), `[371]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_forcedout");"*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the betrayal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator), `[50]` (Narrator), `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_Retire]"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Maybe this was for the best."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator), `[50]` (Narrator), `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_Retire]"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ElectionLose_Retire`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ElectionLose_Retire]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "ElectionLose_Retire"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ElectionLose_Retire]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "ElectionLose_Retire"*)

### Węzeł `[107]`
Mówca: **Narrator**
> "You accepted the situation and retired from politics completely.

It had been decades since you first entered the political arena. You did not know what else to do with your life.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: "...decided to stay in Holsord."*)
  - -> `[287]` (*Player: "...moved to the coast of Benfi."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true && ..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true &..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "In another historic moment, the Communist Party of Sordla..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "In another historic moment, the Workers Party of Bludia m..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true &&..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "In another historic moment, the Communist Party of Sordla..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true && ..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "The die had been recast."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "The die had been recast."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "The die had been recast."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "In another historic moment, the Workers Party of Bludia managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "The die had been recast."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "In another historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "The die had been recast."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archet..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator), `[115]` (Narrator), `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true && ..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true &..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "In another historic moment, the Communist Party of Sordla..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "In another historic moment, the Workers' Party of Bludia ..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "The die had been recast."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true &&..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "In another historic moment, the Communist Party of Sordla..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true && ..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Narrator), `[143]` (Narrator), `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Manoly began a massive campaign to rewrite the constitution of Sordland. 

Her proposal was aimed at strengthening the government's legislative branch, expanding the rights of women and minorities, and eliminating the unequal distribution of campaign funding.

She promised you a position as her next Vice President if you supported her."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Kontekst wejściowy (poprzednik):** `[130]` (Player), `[131]` (Player), `[132]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: "You accepted."*)
  - -> `[145]` (*Player: "You rejected the offer, but supported the proposal noneth..."*)
  - -> `[146]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "1960"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Frens began a massive campaign to rewrite the constitution of Sordland. 

His proposal was aimed at strengthening the government's legislative branch, expanding the rights of women and minorities, and eliminating the unequal distribution of campaign funding.

He promised you a position as his next Vice President if you supported him."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Player), `[131]` (Player), `[132]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: "You accepted."*)
  - -> `[145]` (*Player: "You rejected the offer, but supported the proposal noneth..."*)
  - -> `[146]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "Years went by."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Monica ignored you and in time, raised herself to new hei..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Your attitude created tensions between you and Monica. Te..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. Tensions gave way to frequent fights until one day, Monica filed a divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce = true"*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Monica ignored you and in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "Years went by."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Narrator), `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "1961"*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You rejected the offer, but supported the proposal nonetheless."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Narrator), `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "1961"*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You actively worked against the proposal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Narrator), `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "1961"*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "The ensuing scandal erased most of Monica's political clo..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "Years went by."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "Years went by."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "You never saw either of them ever again."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, President Manoly Suheil went after big corporations, raising their taxes two-fold. Many businessmen were also tried under charges of corruption, and their assets were seized.

She announced a massive redevelopment plan, "TAP", or "the Agnland Project", to contribute to social stability and economic growth by focusing on the Agnland region."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PFJPLeader_Manoly"] == true` AND `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: "You supported the PFJP's policies."*)
  - -> `[161]` (*Player: "You protested against the PFJP's policies."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "Unfortunately, the proposal did not pass the Assembly. The fact that you had supported it angered your base in the USP, and you were stripped of your membership.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Player), `[145]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout = true"*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, President Frens Ricter started implementing tax initiatives for small businesses and policies aimed at bringing more foreign investment inside the country.

He also promoted a social market economy, emphasizing the need for the state to ensure that the free market produced results close to its theoretical potential."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false` AND `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: "You supported the PFJP's policies."*)
  - -> `[161]` (*Player: "You protested against the PFJP's policies."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "1959"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "1959"*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You protested against the PFJP's policies."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator), `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You supported the PFJP's policies."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator), `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[161]` (Player), `[162]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: "...vocally supported her."*)
  - -> `[164]` (*Player: "...stayed silent."*)
  - -> `[147]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator), `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Monica raised herself to new heights. She was becoming th..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[161]` (Player), `[162]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: "...vocally supported her."*)
  - -> `[164]` (*Player: "...stayed silent."*)
  - -> `[156]` (*Player: "...advised her to stop."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator), `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "The ensuing scandal erased most of Monica's political clo..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Narrator), `[189]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You protested against her policies."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[169]` (Player), `[194]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: "...vocally supported her."*)
  - -> `[168]` (*Player: "...advised her to stop."*)
  - -> `[167]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Lileas began a massive campaign to rewrite the constitution of Sordland. 

Her proposal was aimed at strengthening the government's executive and judiciary branches, while transforming the election system so that the next president would be chosen by specific electors rather than the popular vote.

She offered an alliance if your party supported the proposal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Player), `[181]` (Player), `[190]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: "You accepted."*)
  - -> `[195]` (*Player: "You actively worked against the undemocratic proposal."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Monica ignored you and, in time, raised herself to new he..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Your attitude created tensions between you and Monica. Th..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Lileas went after hundreds of Sordish private businesses and seized their assets. Many were tried under charges of corruption. 

She announced a massive economic redevelopment plan, "TAP", or "the Agnland Project", to contribute to the national targets of social stability and economic growth by focusing on the Agnland region."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Player), `[56]` (Player), `[60]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You supported the governing party."*)
  - -> `[169]` (*Player: "You protested against her policies."*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Narrator), `[189]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[182]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "Years went by."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: "You never saw either of them ever again."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. The tensions gave way to frequent fights until one day, Monica filed for divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce = true"*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Monica ignored you and, in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "Years went by."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "Years went by."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Monica raised herself to new heights. She was becoming th..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "Years went by."*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[169]` (Player), `[194]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: "...vocally supported her."*)
  - -> `[187]` (*Player: "...stayed silent."*)
  - -> `[168]` (*Player: "...advised her to stop."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator), `[185]` (Narrator), `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "1959"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "1959"*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You supported the governing party."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You actively worked against the undemocratic proposal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "You formed a grassroots coalition of MPs who agreed that ..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "1961"*)

### Węzeł `[197]`
Mówca: **Narrator**
> "You formed a grassroots coalition of MPs who agreed that the new proposal would spell the end of democracy in Sordland.

In a seismic shift in Sordish politics, your Sordish Democratic Coalition managed to drum up enough popular support to prevent Lileas from changing the Constitution.

The USP lost by 193 nays."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Player: "Your struggle for the country continued."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "1958"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "1958"*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You thought it was all for the best."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_LateRetire]"*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the betrayal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_LateRetire]"*)

### Węzeł `[203]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "After you supported Lileas' proposal, your party called you a traitor and stripped you of your membership.

You decided that it was time to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout = true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ElectionLose_LateRetire`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire = true"*)

### Węzeł `[205]`
Mówca: **Narrator**
> "You accepted the situation and retired from politics completely.

It had been decades since you first entered the political arena. You did not know what else to do with your life.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: "...decided to stay in Holsord."*)
  - -> `[287]` (*Player: "...moved to the coast of Benfi."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player: "...vocally supported her."*)
  - -> `[213]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...began writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir = true"*)

### Węzeł `[208]`
Mówca: **Narrator**
> "With your political career behind you, you began your new life in Holsord. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[211]` (*Player: "...became an adjunct professor of politics at Holsord Sta..."*)
  - -> `[207]` (*Player: "...began writing a memoir."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player: "...vocally supported her."*)
  - -> `[213]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player: "You never saw either of them ever again."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became an adjunct professor of politics at Holsord State University."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in the Maroon Palace."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[234]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Narrator), `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "The ensuing scandal erased most of Monica's political clo..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living with his wife and son on a farming commune in United Contana, publicly distanced himself from you."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` AND `Variable["BaseGame.Turn05_P_Underhall"] == true` AND `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Kontekst wejściowy (poprzednik):** `[243]` (Player), `[280]` (Player), `[211]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: "You didn't care."*)
  - -> `[216]` (*Player: "You lost sleep over it."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator), `[467]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You lost sleep over it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Narrator), `[463]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...refused to give him anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Narrator), `[506]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't care."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Narrator), `[485]` (Narrator), `[486]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were never able to mend your marriage with Monica."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator), `[471]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator), `[471]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator), `[471]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "1960|Holsord"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "1960|Holsord"*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator), `[475]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't fulfill the goals you'd set out as President."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator), `[475]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator), `[475]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to reconnect with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Narrator), `[485]` (Narrator), `[486]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the board of Underhall Construction."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Kontekst wejściowy (poprzednik):** `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)

### Węzeł `[232]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: "Years went by."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player: "...vocally supported her."*)
  - -> `[212]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player: "...vocally supported her."*)
  - -> `[212]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Underhall == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player: "...joined the board of Underhall Construction."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Narrator), `[209]` (Narrator), `[233]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: "Years went by."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "1960|Holsord"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "Meanwhile, your wife became ever more entrenched in her s..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...helped him with whatever he needed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Narrator), `[506]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "1965|Holsord"*)

### Węzeł `[260]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, alone except for a few close friends.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` AND `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: "...never got back into politics."*)
  - -> `[274]` (*Player: "...were never able to mend your marriage with Monica."*)
  - -> `[215]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[261]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` AND `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Player: "...never got back into politics."*)
  - -> `[275]` (*Player: "...didn't fulfill the goals you'd set out as President."*)
  - -> `[217]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` AND `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Player), `[218]` (Player), `[219]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: "...never got back into politics."*)
  - -> `[228]` (*Player: "...didn't fulfill the goals you'd set out as President."*)
  - -> `[227]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "1965|Holsord"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[272]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son on a farm somewhere in Bergia."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: "...life went on."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator), `[467]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were never able to mend your marriage with Monica."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator), `[467]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't fulfill the goals you'd set out as President."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Narrator), `[463]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Narrator), `[463]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false` AND `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true` AND `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[243]` (Player), `[280]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: "Fame doesn't hurt."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living on a farm in Bergia with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: "You were happy to reconnect with him."*)
  - -> `[220]` (*Player: "You didn't respond."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, surrounded by sycophants and just a few true friends.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` AND `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Player), `[218]` (Player), `[219]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player: "...never got back into politics."*)
  - -> `[221]` (*Player: "...were never able to mend your marriage with Monica."*)
  - -> `[222]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator), `[242]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son in Bergia, came to visit from time to time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: "...life went on."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Underhall == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)

### Węzeł `[285]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living on a small farm in Bergia with his wife and son, frequently asked you for money. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` AND `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Kontekst wejściowy (poprzednik):** `[243]` (Player), `[280]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: "...helped him with whatever he needed."*)
  - -> `[218]` (*Player: "...refused to give him anything."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: "You never talked to Monica again."*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...moved to the coast of Benfi."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator), `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coast");"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player: "...decided to try your luck managing FC Anrica."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn07_Personal_University_Abroad_Arcasia == tr..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Vineyard == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Player: "...dedicated yourself to making wine in your vineyard in ..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Vineyard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...decided to stay in Holsord."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator), `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...decided to try your luck managing FC Anrica."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true` AND `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator), `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...dedicated yourself to making wine in your vineyard in Erlory."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator), `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Joined_ATO == true) && BaseGame.Archetype_ComradeRayne == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn07_Personal_University_Abroad_Arcasia == tr..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn07_Personal_University_Abroad_Arcasia == ..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Joined_ATO == true) && BaseGame.Archetype_ComradeRayne == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Joined_ATO"] == true)  and  Variable["BaseGame.Archetype_ComradeRayne"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player: "...moved to Arcasia."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Joined_ATO == true) && BaseGame.Archetype_ComradeRayne == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Joined_ATO"] == true)  and  Variable["BaseGame.Archetype_ComradeRayne"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player: "...moved to United Contana."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player: "...moved to Arcasia."*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...moved to Arcasia."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Joined_ATO"] == true)  and  Variable["BaseGame.Archetype_ComradeRayne"] == false` AND `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false` AND `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator), `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Arcasia = true"*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...moved to United Contana."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_UnitedContana = true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Lileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_LateRetire == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_LateRetire == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Arcasia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Retirement_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_plane");"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: "You never talked to Monica again."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ElectionLose_LateRetire]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "ElectionLose_LateRetire"*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your struggle for the country continued."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[316]`
**[WYBÓR GRACZA: "1964"]** — Mówca: **Narrator**
> "Throughout the term, your acts led to a new era of Sordish politics where coalitions were commonplace. The Assembly became a place for civil discussion and actual productive solutions. 

After this internal renewal, Sordland rose to become a great regional power that rivaled many nations around it in economy, education and health, and diplomacy.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player: "...decided that it was time to retire."*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_DemocraticRayne == true"*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...strengthened Sordland's democratic institutions and the separation of power."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_DemocraticRayne"] == true`
- **Kontekst wejściowy (poprzednik):** `[316]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "1970"*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were stronger together."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "1964"*)

### Węzeł `[319]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "In the next election, the PFJP won with your party coming in second. The USP had to settle for third place.

Your movement's victory had been a turning point. The PFJP formed a coalition with you. Though you had your disagreements, it proved to be a fruitful cooperation.

The time for change had come."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Player: "You were stronger together."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...decided that it was time to retire."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "1970"*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...tried to shift the country towards democratic socialism."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Kontekst wejściowy (poprzednik):** `[316]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "1970"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Player: "...tried to shift the country towards democratic socialism."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_DemocraticRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_DemocraticRayne == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_DemocraticRayne == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_DemocraticRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_DemocraticRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player: "...strengthened Sordland's democratic institutions and th..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_DemocraticRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[328]`
**[WYBÓR GRACZA: "1970"]** — Mówca: **Narrator**
> "Sordish democracy became a beacon in the world thanks to your efforts. The legislative branch became stronger while the presidency became a symbolic institution. The judiciary was fair and independent.

The public rallied to your cause. In subsequent elections, the most non-democratic parties all failed to enter Assembly and the remaining ones joined in a grand coalition.

You went down in the Sordish history books as..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player: "...another politician that tried to do their best."*)
  - -> `[332]` (*Player: "...a saviour of Sordish democracy."*)
  - -> `[331]` (*Player: "...a beacon of hope and change."*)

### Węzeł `[329]`
**[WYBÓR GRACZA: "1970"]** — Mówca: **Narrator**
> "You spent your retirement enjoying the simple things in life. 

The role of the Presidency diminished in time and became symbolic during your retirement. The people remembered the positive parliamentarian change you brought.

You went down in the Sordish history books as..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player: "...a diligent civil servant."*)
  - -> `[330]` (*Player: "...a popular hero that came to the country in a time of n..."*)
  - -> `[337]` (*Player: "...another politician that tried to do their best."*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a popular hero that came to the country in a time of need."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a beacon of hope and change."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a saviour of Sordish democracy."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a diligent civil servant."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[334]`
**[WYBÓR GRACZA: "1970"]** — Mówca: **Narrator**
> "The sentiment towards socialism grew thanks to your parliamentary efforts.

Your actions pushed the governing coalition to adopt principles close to Valgslandian Socialism. Better social welfare programs and improved workers' rights resulted in a major reformation of society.

You went down in the Sordish history books as..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player: "...another politician that tried to do their best."*)
  - -> `[335]` (*Player: "...a hero of the working class."*)
  - -> `[336]` (*Player: "...the saviour of the downtrodden."*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a hero of the working class."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[334]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the saviour of the downtrodden."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[334]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...another politician that tried to do their best."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Narrator), `[329]` (Narrator), `[334]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly = true"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens = true"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were a broken man."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_LateRetire]"*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt only relief."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_LateRetire]"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ElectionLose_LateRetire]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "ElectionLose_LateRetire"*)

### Węzeł `[346]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "By fighting tooth-and-nail against the PFJP's changes, you managed to block their proposal in the Assembly.

However, the party had drummed up so much popular support for its reforms that the public turned against the USP for sabotaging them.

In the next election, your party suffered its worst loss ever."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Player: "You decided to retire."*)
  - -> `[348]` (*Player: "You soldiered on."*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You decided to retire."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_LateRetire]"*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You soldiered on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[349]`
Mówca: **Narrator**
> "You lived out the rest of your days as a somewhat ineffectual career politician, never again achieving the success you had as President, but doing your best to fight for the causes you believed in.

A small street in your hometown was named after you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player: "It's a dead end."*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It's a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...life went on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Narrator), `[281]` (Narrator), `[493]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Fame doesn't hurt."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_NFP_Destroyed == true)"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "In a historic moment, the Communist Party of Sordland man..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_NFP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "In a historic moment, the Communist Party of Sordland man..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true)"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "In a historic moment, the Communist Party of Sordland man..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)

### Węzeł `[362]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold.

The PFJP once again became the second biggest party in the Assembly; hampered by its lack of leadership, the NFP limped into third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[73]` (*Player: "You tried to cooperate with the Communist Party."*)

### Węzeł `[363]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold.

The National Front Party became the second biggest party in the Assembly; hampered by its lack of leadership, the PFJP limped into third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[73]` (*Player: "You tried to cooperate with the Communist Party."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true)"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "In a historic moment, the Communist Party of Sordland, th..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_NFP_Destroyed == true)"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "In a historic moment, the Communist Party of Sordland, th..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_NFP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "In a historic moment, the Communist Party of Sordland, th..."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

The PFJP once again became the second biggest party in the Assembly; hampered by its lack of leadership, the NFP limped into third.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[73]` (*Player: "You tried to cooperate with the Communist Party."*)
  - -> `[101]` (*Player: "You tried to cooperate with the pro-Bludish parties."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

The National Front Party became the second biggest party in the Assembly; hampered by its lack of leadership, the PFJP limped into third.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[73]` (*Player: "You tried to cooperate with the Communist Party."*)
  - -> `[101]` (*Player: "You tried to cooperate with the pro-Bludish parties."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true)"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "In a historic moment, the Workers Party of Bludia managed..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_NFP_Destroyed == true)"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "In a historic moment, the Workers Party of Bludia managed..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_NFP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "In a historic moment, the Workers Party of Bludia managed..."*)

### Węzeł `[378]`
Mówca: **Narrator**
> "In a historic moment, the Workers Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again.

The National Front Party became the second biggest party in the Assembly; hampered by its lack of leadership, the PFJP limped into third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[96]` (*Player: "You tried to cooperate with the Workers' Party of Bludia."*)

### Węzeł `[379]`
Mówca: **Narrator**
> "In a historic moment, the Workers Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again.

The PFJP became the second biggest party in the Assembly; hampered by its lack of leadership, the NFP limped into third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[96]` (*Player: "You tried to cooperate with the Workers' Party of Bludia."*)

### Węzeł `[380]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party did not secure victory for the first time in its existence. 

The National Front party had won. The USP came in second; with its leadership hampered, the PFJP limped into third.

You were to be a member of the Assembly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "You were devastated by the results."*)
  - -> `[70]` (*Player: "It felt good to return to the Assembly, where it all star..."*)
  - -> `[69]` (*Player: "You decided to retire from politics after this failure."*)

### Węzeł `[381]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party did not secure victory for the first time in its existence. 

The People's Freedom and Justice Party had won. The USP secured the second spot; with its leadership hampered, the NFP limped into third.

You were to be a member of the Assembly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "You were devastated by the results."*)
  - -> `[70]` (*Player: "It felt good to return to the Assembly, where it all star..."*)
  - -> `[69]` (*Player: "You decided to retire from politics after this failure."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_NFP_Destroyed == true)"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_NFP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true)"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[388]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, President Kesaro Kibener started seizing the assets of Bludish businesses. Many businessmen were arrested under charges of corruption.

He also promoted the idea of "Maroon Blood" and heavily invested in eugenic research and the military. He openly supported and funded the Young Sords."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false` AND `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Kontekst wejściowy (poprzednik):** `[122]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player: "You supported the NFP's policies."*)
  - -> `[394]` (*Player: "You protested the NFP's policies."*)

### Węzeł `[389]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, President Remus Holstron started seizing the assets of Bludish businesses. Many businessmen were arrested under charges of corruption.

He also promoted the idea of "Maroon Blood" and heavily invested in eugenic research and the military. He openly supported and funded the Young Sords."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.NFPLeader_Remus"] == true` AND `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Kontekst wejściowy (poprzednik):** `[122]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player: "You supported the NFP's policies."*)
  - -> `[394]` (*Player: "You protested the NFP's policies."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NFPLeader_Remus == true)"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "1958"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NFPLeader_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "1958"*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You supported the NFP's policies."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Narrator), `[389]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You protested the NFP's policies."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Narrator), `[389]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly = true"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens = true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NFPLeader_Remus == true)"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus = true"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NFPLeader_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro = true"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "1959"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "1959"*)

### Węzeł `[408]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a fierce critic of the new administration, rallying Sordish women to demonstrate against the NFP's gender-biased policies."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[393]` (Player), `[394]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Player: "...vocally supported her."*)
  - -> `[418]` (*Player: "...stayed silent."*)
  - -> `[413]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[409]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a fierce critic of the new administration, rallying Sordish women to demonstrate against the NFP's gender-biased policies."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[393]` (Player), `[394]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Player: "...vocally supported her."*)
  - -> `[418]` (*Player: "...stayed silent."*)
  - -> `[417]` (*Player: "...advised her to stop."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Remus == true)"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Narrator: "1960"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "1960"*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Narrator: "The ensuing scandal erased most of Monica's political clo..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "Monica ignored you and in time, raised herself to new hei..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "Your attitude created tensions between you and Monica. Te..."*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Narrator), `[409]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "Monica raised herself to new heights. She was becoming th..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Narrator), `[409]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[421]`
Mówca: **Narrator**
> "Monica ignored you and in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Player: "Years went by."*)

### Węzeł `[422]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Player: "Years went by."*)

### Węzeł `[423]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Player: "Years went by."*)

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[431]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[421]` (Narrator), `[422]` (Narrator), `[423]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[429]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Player: "Years went by."*)

### Węzeł `[430]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player: "You never saw either of them ever again."*)

### Węzeł `[431]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. Tensions gave way to frequent fights until one day, Monica filed a divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce = true"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Player: "You never talked to Monica again."*)

### Węzeł `[433]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Remus began a massive campaign to rewrite the constitution of Sordland. 

His proposal aimed to strengthen presidential powers, abolish the citizenship of Bludish people and implement racial laws to segregate the others from the "Maroon Bloods."

He offered you the position of Vice President in exchange for your support."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Kontekst wejściowy (poprzednik):** `[420]` (Player), `[424]` (Player), `[425]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player: "You accepted."*)
  - -> `[436]` (*Player: "You rejected the offer, but supported the proposal noneth..."*)
  - -> `[440]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[434]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Kesaro began a massive campaign to rewrite the constitution of Sordland. 

His proposal aimed to strengthen presidential powers, abolish the citizenship of Bludish people and implement racial laws to segregate the others from the "Maroon Bloods."

He offered you the position of Vice President in exchange for your support."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[420]` (Player), `[424]` (Player), `[425]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player: "You accepted."*)
  - -> `[436]` (*Player: "You rejected the offer, but supported the proposal noneth..."*)
  - -> `[440]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Narrator), `[434]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You rejected the offer, but supported the proposal nonetheless."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Narrator), `[434]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[437]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "Unfortunately, the proposal did not pass the Assembly. The fact that you had supported it angered your base in the USP, and you were stripped of your membership.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[435]` (Player), `[436]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout = true"*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You soldiered on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[442]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt only relief."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_LateRetire]"*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You actively worked against the proposal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Narrator), `[434]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You decided to retire."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[442]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[442]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "By fighting tooth-and-nail against the NFP's changes, you managed to block their proposal in the Assembly.

However, the party had drummed up so much popular support for its reforms that the public turned against the USP for sabotaging them.

In the next election, your party suffered its worst loss ever."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[440]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Player: "You decided to retire."*)
  - -> `[438]` (*Player: "You soldiered on."*)

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were a broken man."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "Jump to: [ElectionLose_LateRetire]"*)

### Węzeł `[444]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party under the leadership of Lileas Graf did not secure victory. The National Front Party had won, pushing the USP to second place for the first time in in history.

Despite her promise, Lileas pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You were devastated by the betrayal."*)
  - -> `[103]` (*Player: "Maybe this was for the best."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true)"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro = true"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens = true"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn11_Election_AssassinationHappened == true)"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn11_Election_AssassinationHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Re..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Narrator: "No other party managed to enter the Assembly."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_Default == true"*)

### Węzeł `[455]`
Mówca: **Narrator**
> "No other party managed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "The die had been recast."*)

### Węzeł `[456]`
Mówca: **Narrator**
> "Some new independents managed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "The die had been recast."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_Default == true"*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_Default == true)"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: "Some new independents managed to enter the Assembly."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "1975|Holsord"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Narrator: "1975|Holsord"*)

### Węzeł `[463]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` AND `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Player: "...never got back into politics."*)
  - -> `[275]` (*Player: "...didn't fulfill the goals you'd set out as President."*)
  - -> `[217]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "1975|Holsord"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "1975|Holsord"*)

### Węzeł `[467]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, alone except for a few close friends.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` AND `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: "...never got back into politics."*)
  - -> `[274]` (*Player: "...were never able to mend your marriage with Monica."*)
  - -> `[215]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "1975|Holsord"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Narrator: "1975|Holsord"*)

### Węzeł `[471]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, surrounded by sycophants and just a few true friends.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` AND `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Player), `[218]` (Player), `[219]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player: "...never got back into politics."*)
  - -> `[221]` (*Player: "...were never able to mend your marriage with Monica."*)
  - -> `[222]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "1975|Holsord"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Narrator: "1975|Holsord"*)

### Węzeł `[475]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` AND `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Player), `[218]` (Player), `[219]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: "...never got back into politics."*)
  - -> `[228]` (*Player: "...didn't fulfill the goals you'd set out as President."*)
  - -> `[227]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: "You were devastated by the betrayal."*)
  - -> `[201]` (*Player: "You thought it was all for the best."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player: "You were a broken man."*)
  - -> `[344]` (*Player: "You felt only relief."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Player: "You were a broken man."*)
  - -> `[439]` (*Player: "You felt only relief."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Narrator: "1965|Holsord"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "1965|Holsord"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "1965|Holsord"*)

### Węzeł `[485]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living in the Arcasian suburbs with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: "You were happy to reconnect with him."*)
  - -> `[220]` (*Player: "You didn't respond."*)

### Węzeł `[486]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living on a commune in United Contana with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: "You were happy to reconnect with him."*)
  - -> `[220]` (*Player: "You didn't respond."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Narrator: "1965|Holsord"*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Narrator: "1965|Holsord"*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "1965|Holsord"*)

### Węzeł `[493]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son in the Arcasian suburbs, came to visit from time to time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: "...life went on."*)

### Węzeł `[494]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son on a commune in United Contana, came to visit from time to time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: "...life went on."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "1965|Holsord"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Narrator: "1965|Holsord"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "1965|Holsord"*)

### Węzeł `[501]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son somewhere in the Arcasian suburbs."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: "...life went on."*)

### Węzeł `[502]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son on a commune somewhere in United Contana."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: "...life went on."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Narrator: "1965|Holsord"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "1965|Holsord"*)

### Węzeł `[506]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living in the Arcasian suburbs with his wife and son, frequently asked you for money. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` AND `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Kontekst wejściowy (poprzednik):** `[243]` (Player), `[280]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: "...helped him with whatever he needed."*)
  - -> `[218]` (*Player: "...refused to give him anything."*)

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Then, you woke up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[521]` (Narrator), `[524]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Narrator: "As your consciousness returned, you realized you were in ..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == tru..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  and  Variable["BaseGame.Fired_KarlGreiser"] == false  and  Variable["BaseGame.Turn09_A_LileasResigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  and  Variable["BaseGame.Fired_KarlGreiser"] == false  and  Variable["BaseGame.Turn09_A_LileasResigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)

### Węzeł `[511]`
Mówca: **Narrator**
> "Karl Greiser became a hero of the nation for his ultimate sacrifice.

In this tense atmosphere, the election day approached.

Millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "Once again, your moment of truth had come."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Secur..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "The last thing you remembered was a shout of "For Free Bl..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "The last thing you remembered was chaos. The people in th..."*)

### Węzeł `[515]`
Mówca: **Narrator**
> "Karl Greiser became a hero of the nation for his ultimate sacrifice.

In this tense atmosphere, the election day approached.

Millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "Once again, your moment of truth had come."*)

### Węzeł `[516]`
Mówca: **Narrator**
> "You made a full recovery just in time for election day. Millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "Once again, your moment of truth had come."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Secur..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Narrator: "The last thing you remembered was a shout of "For Free Bl..."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Narrator: "The last thing you remembered was chaos. The people in th..."*)

### Węzeł `[520]`
Mówca: **Narrator**
> "You made a full recovery just in time for election day. Millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "Once again, your moment of truth had come."*)

### Węzeł `[521]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "For Free Bludia! Yollak Bluderat!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Player: "Then, you woke up."*)

### Węzeł `[522]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "For Free Bludia! Yollak Bluderat!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

You felt a heavy weight on top of you. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Player: "You opened your eyes."*)

### Węzeł `[523]`
Mówca: **Narrator**
> "The last thing you remembered was chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

You felt a heavy weight on top of you. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Player: "You opened your eyes."*)

### Węzeł `[524]`
Mówca: **Narrator**
> "The last thing you remembered was chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Player: "Then, you woke up."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Narrator: "You made a full recovery just in time for election day. M..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "You made a full recovery just in time for election day. M..."*)

### Węzeł `[528]`
Mówca: **Narrator**
> "As your consciousness returned, you realized you were in a hospital. Several doctors were standing over you with looks of relief on their faces.

They told you that assassin's bullet had broken a couple of your ribs, but a metal object in your pocket had kept it from hitting any major organs.

They showed it to you. It was an antique pocket watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[529]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You opened your eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[522]` (Narrator), `[523]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Narrator: "Security guards rushed to your side. When you came to you..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Narrator: "Karl Greiser became a hero of the nation for his ultimate..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Narrator: "Karl Greiser became a hero of the nation for his ultimate..."*)

### Węzeł `[533]`
Mówca: **Narrator**
> "Security guards rushed to your side. When you came to your senses, you realized.

It was Karl Greiser who jumped in front of the bullet to save your life.

He saluted you in his last moments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Lileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_DemocratParty == true"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_UnitedContana = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Retirement_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_plane");"*)

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You saluted him back."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[533]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Player: "Serge's good luck charm."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Player: "Serge's good luck charm."*)

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Serge's good luck charm."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[528]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You saluted him back."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[533]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Player: "You saluted him back."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Player: "You saluted him back."*)

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Serge's good luck charm."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[528]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_loss");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_FormNewParty == true"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_suitcase");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "You accepted the situation and retired from politics comp..."*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_suitcase");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "You accepted the situation and retired from politics comp..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_forcedout");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_forcedout");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "1958"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "1958"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "1960"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "1961"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "With your political career behind you, you began your new..."*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_plane");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_plane");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_city");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_city");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coast");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_meeting");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_meeting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_meeting");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_meeting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "1960"*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "You lived out the rest of your days as a somewhat ineffec..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_loss");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Narrator: "1961"*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_loss");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "1961"*)
