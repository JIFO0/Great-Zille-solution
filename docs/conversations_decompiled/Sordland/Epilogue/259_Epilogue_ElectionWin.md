# Sordland/Epilogue_ElectionWin

- **ID konwersacji:** `259`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_ElectionWin)`
- **Lokalizacja pliku:** `Sordland/Epilogue/259_Epilogue_ElectionWin.md`
- **Liczba węzłów dialogowych:** 599
- **Liczba wyborów gracza:** 152

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Capitalist`
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth`
- `BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords`
- `BaseGame.Democratic`
- `BaseGame.Ending_RumburgWarWin`
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Kesaro`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_PeoplesFront`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.JoinParty_CPS`
- `BaseGame.JoinParty_NFP`
- `BaseGame.JoinParty_PFJP`
- `BaseGame.JoinParty_WPB`
- `BaseGame.Malenyevist`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.NFPLeader_Remus`
- `BaseGame.NewParty_DemocratParty`
- `BaseGame.NewParty_LiberalParty`
- `BaseGame.NewParty_MaroonParty`
- `BaseGame.NewParty_PeoplesParty`
- `BaseGame.PFJPLeader_Manoly`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_3`
- `BaseGame.Policy_Law_Threshold_8`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Sollist`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn09_A_LileasResigned`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_JoinedOtherParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn11_Election_AssassinationHappened`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGameIsolated.Epilogue_Election_VP`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Kesaro`
- `BaseGame.Epilogue_NewPresident_Lileas`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_PeoplesFront`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGameIsolated.Epilogue_Election_VP`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"For the second time, your moment of truth had arrived."** | `[3]` **Narrator**: "On election day, millions went o..."<br>`[34]` **Narrator**: "On election day, millions went o..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_victory");`<br>`PrologueImage("pe_victory");`<br>*(+1 skryptów)* | `[5]` **Narrator**: "In a historic result, the Democr..."<br>`[53]` **Narrator**: "As expected, the United Sordland..." |
| `[5]` | **"1957\|November 3rd"** | `[4]` **Player**: "For the second time, your moment..." | `Variable["BaseGame.NewParty_DemocratParty"] == true`<br>`Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true` | *Brak zmian stanu* | `[35]` **Player**: "Their magic had worn off."<br>`[38]` **Player**: "The people had finally spoken."<br>*(oraz 1 innych odgałęzień)* |
| `[9]` | **"It was a historic achievement for the country."** | `[53]` **Narrator**: "As expected, the United Sordland..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[502]` **Narrator**: "The National Front Party came in..."<br>`[179]` **Narrator**: "The People's Freedom and Justice..." |
| `[35]` | **"Their magic had worn off."** | `[5]` **Narrator**: "In a historic result, the Democr..."<br>`[36]` **Narrator**: "In a historic result, the Libera..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Narrator**: "The United Sordland Party came i..."<br>`[157]` **Narrator**: "The United Sordland Party came i..."<br>*(oraz 1 innych odgałęzień)* |
| `[36]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Player**: "Their magic had worn off."<br>`[38]` **Player**: "The people had finally spoken."<br>*(oraz 1 innych odgałęzień)* |
| `[37]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Player**: "Their magic had worn off."<br>`[38]` **Player**: "The people had finally spoken."<br>*(oraz 1 innych odgałęzień)* |
| `[38]` | **"The people had finally spoken."** | `[5]` **Narrator**: "In a historic result, the Democr..."<br>`[36]` **Narrator**: "In a historic result, the Libera..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Narrator**: "The United Sordland Party came i..."<br>`[157]` **Narrator**: "The United Sordland Party came i..."<br>*(oraz 1 innych odgałęzień)* |
| `[39]` | **"You succeeded in breaking them down."** | `[5]` **Narrator**: "In a historic result, the Democr..."<br>`[36]` **Narrator**: "In a historic result, the Libera..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Narrator**: "The United Sordland Party came i..."<br>`[157]` **Narrator**: "The United Sordland Party came i..."<br>*(oraz 1 innych odgałęzień)* |
| `[40]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Player**: "Their magic had worn off."<br>`[38]` **Player**: "The people had finally spoken."<br>*(oraz 1 innych odgałęzień)* |
| `[41]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Player**: "Their magic had worn off."<br>`[38]` **Player**: "The people had finally spoken."<br>*(oraz 1 innych odgałęzień)* |
| `[42]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;` | `[80]` **Player**: "The die had been recast." |
| `[43]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] =...` | `[82]` **Player**: "The die had been recast." |
| `[47]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;` | `[80]` **Player**: "The die had been recast." |
| `[51]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Epilogue_NewPresident_Remus"] = true;` | `[81]` **Player**: "The die had been recast." |
| `[52]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] = true;` | `[81]` **Player**: "The die had been recast." |
| `[53]` | **"1957\|November 3rd"** | `[4]` **Player**: "For the second time, your moment..." | `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`<br>`Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false` | `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;` | `[9]` **Player**: "It was a historic achievement fo..." |
| `[57]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player**: "Victory had come."<br>`[59]` **Player**: "The people had spoken again."<br>*(oraz 1 innych odgałęzień)* |
| `[58]` | **"The party owed its success to you."** | `[57]` **Narrator**: "The United Sordland Party came o..."<br>`[83]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Narrator**: "With no clear leadership, the Pe..."<br>`[498]` **Narrator**: "With no clear leadership, the Na..."<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **"The people had spoken again."** | `[57]` **Narrator**: "The United Sordland Party came o..."<br>`[83]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Narrator**: "With no clear leadership, the Pe..."<br>`[498]` **Narrator**: "With no clear leadership, the Na..."<br>*(oraz 1 innych odgałęzień)* |
| `[60]` | **"Victory had come."** | `[57]` **Narrator**: "The United Sordland Party came o..."<br>`[83]` **Narrator**: "The United Sordland Party came o..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Narrator**: "With no clear leadership, the Pe..."<br>`[498]` **Narrator**: "With no clear leadership, the Na..."<br>*(oraz 1 innych odgałęzień)* |
| `[80]` | **"The die had been recast."** | `[42]` **Narrator**: "In a historic result, the People..."<br>`[47]` **Narrator**: "In a historic result, the People..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[182]` **Narrator**: "The United Sordland Party came i..." |
| `[81]` | **"The die had been recast."** | `[51]` **Narrator**: "In a historic result, the Nation..."<br>`[52]` **Narrator**: "In a historic result, the Nation..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[181]` **Narrator**: "The United Sordland Party came i..." |
| `[82]` | **"The die had been recast."** | `[43]` **Narrator**: "In a historic result, the joint ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[180]` **Narrator**: "The United Sordland Party came i..." |
| `[83]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player**: "Victory had come."<br>`[59]` **Player**: "The people had spoken again."<br>*(oraz 1 innych odgałęzień)* |
| `[84]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player**: "Victory had come."<br>`[59]` **Player**: "The people had spoken again."<br>*(oraz 1 innych odgałęzień)* |
| `[85]` | **"The die had been recast."** | `[61]` **Narrator**: "The National Front was now the s..."<br>`[68]` **Narrator**: "The People's Freedom and Justice..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[86]` **Narrator**: "No other party managed to enter ..." |
| `[159]` | **"The die had been recast."** | `[131]` **Narrator**: "The United Sordland Party came i..."<br>`[157]` **Narrator**: "The United Sordland Party came i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[138]` **Narrator**: "No other party managed to enter ..." |
| `[183]` | **"You congratulated all parties that participated in the elections."** | `[179]` **Narrator**: "The People's Freedom and Justice..."<br>`[180]` **Narrator**: "The United Sordland Party came i..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Narrator**: "A year later, Lileas went after ..."<br>`[252]` **Narrator**: "A year later, Manoly went after ..."<br>*(oraz 2 innych odgałęzień)* |
| `[184]` | **"You congratulated the new Assembly members."** | `[179]` **Narrator**: "The People's Freedom and Justice..."<br>`[180]` **Narrator**: "The United Sordland Party came i..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Narrator**: "A year later, Lileas went after ..."<br>`[252]` **Narrator**: "A year later, Manoly went after ..."<br>*(oraz 2 innych odgałęzień)* |
| `[185]` | **"You congratulated the PFJP leadership."** | `[182]` **Narrator**: "The United Sordland Party came i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Narrator**: "A year later, Lileas went after ..."<br>`[252]` **Narrator**: "A year later, Manoly went after ..."<br>*(oraz 2 innych odgałęzień)* |
| `[186]` | **"You congratulated the NFP leadership."** | `[181]` **Narrator**: "The United Sordland Party came i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Narrator**: "A year later, Lileas went after ..."<br>`[252]` **Narrator**: "A year later, Manoly went after ..."<br>*(oraz 2 innych odgałęzień)* |
| `[187]` | **"You congratulated the WPB and CPS leadership."** | `[180]` **Narrator**: "The United Sordland Party came i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Narrator**: "A year later, Lileas went after ..."<br>`[252]` **Narrator**: "A year later, Manoly went after ..."<br>*(oraz 2 innych odgałęzień)* |
| `[188]` | **"You congratulated Lileas."** | `[179]` **Narrator**: "The People's Freedom and Justice..."<br>`[502]` **Narrator**: "The National Front Party came in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Narrator**: "A year later, Lileas went after ..."<br>`[252]` **Narrator**: "A year later, Manoly went after ..."<br>*(oraz 2 innych odgałęzień)* |
| `[189]` | **"You congratulated all parties that participated in the elections."** | `[73]` **Narrator**: "In a historic success, the Peopl..."<br>`[86]` **Narrator**: "No other party managed to enter ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[202]` **Narrator**: "Mansoun Leke and a group of his ..."<br>`[209]` **Narrator**: "Because the constitution was eas..." |
| `[190]` | **"You declared that "The Morning Has Come.""** | `[73]` **Narrator**: "In a historic success, the Peopl..."<br>`[86]` **Narrator**: "No other party managed to enter ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[202]` **Narrator**: "Mansoun Leke and a group of his ..."<br>`[209]` **Narrator**: "Because the constitution was eas..." |
| `[191]` | **"You congratulated the new Assembly members."** | `[73]` **Narrator**: "In a historic success, the Peopl..."<br>`[86]` **Narrator**: "No other party managed to enter ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[202]` **Narrator**: "Mansoun Leke and a group of his ..."<br>`[209]` **Narrator**: "Because the constitution was eas..." |
| `[192]` | **"You congratulated the new Assembly members."** | `[130]` **Narrator**: "In another historic success, the..."<br>`[138]` **Narrator**: "No other party managed to enter ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[230]` **Narrator**: "Because the constitution was eas..."<br>`[231]` **Narrator**: "Ahead of your inauguration, memb..."<br>*(oraz 1 innych odgałęzień)* |
| `[193]` | **"You congratulated all parties that participated in the election."** | `[130]` **Narrator**: "In another historic success, the..."<br>`[138]` **Narrator**: "No other party managed to enter ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[230]` **Narrator**: "Because the constitution was eas..."<br>`[231]` **Narrator**: "Ahead of your inauguration, memb..."<br>*(oraz 1 innych odgałęzień)* |
| `[194]` | **"You declared that "Morning has come.""** | `[130]` **Narrator**: "In another historic success, the..."<br>`[138]` **Narrator**: "No other party managed to enter ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[230]` **Narrator**: "Because the constitution was eas..."<br>`[231]` **Narrator**: "Ahead of your inauguration, memb..."<br>*(oraz 1 innych odgałęzień)* |
| `[195]` | **"...found some racy photos you'd once taken of her, and leaked them to the press."** | `[198]` **Narrator**: "Meanwhile, you couldn't help but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Narrator**: "The ensuing scandal erased most ..." |
| `[196]` | **"1960"** | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[201]` **Player**: "...vocally supported her."<br>`[199]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[197]` | **"1960"** | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[201]` **Player**: "...vocally supported her."<br>`[199]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[198]` | **"1960"** | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` | *Brak zmian stanu* | `[201]` **Player**: "...vocally supported her."<br>`[320]` **Player**: "...advised her to stop."<br>*(oraz 1 innych odgałęzień)* |
| `[199]` | **"...stayed silent."** | `[196]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[197]` **Narrator**: "Meanwhile, you couldn't help but..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Narrator**: "Monica raised herself to new hei..." |
| `[200]` | **"1960"** | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false` | *Brak zmian stanu* | `[201]` **Player**: "...vocally supported her."<br>`[199]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[201]` | **"...vocally supported her."** | `[196]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[197]` **Narrator**: "Meanwhile, you couldn't help but..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Narrator**: "You and Monica began speaking to..."<br>`[324]` **Narrator**: "Your support buoyed Monica to ne..." |
| `[202]` | **"1958\|January"** | `[189]` **Player**: "You congratulated all parties th..."<br>`[190]` **Player**: "You declared that "The Morning H..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true` | *Brak zmian stanu* | `[215]` **Player**: "...suppressed them."<br>`[216]` **Player**: "...accepted their demands." |
| `[209]` | **"1958\|January"** | `[189]` **Player**: "You congratulated all parties th..."<br>`[190]` **Player**: "You declared that "The Morning H..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Reform_Court_Success"] == true`<br>`(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false` | *Brak zmian stanu* | `[538]` **Player**: "...rejected further amendments."<br>`[221]` **Player**: "...promised to cooperate with them."<br>*(oraz 1 innych odgałęzień)* |
| `[210]` | **"1958\|January"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Player**: "...promised to cooperate with them."<br>`[217]` **Player**: "...censored them from press." |
| `[211]` | **"1958\|January"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Player**: "...promised to cooperate with them."<br>`[217]` **Player**: "...censored them from press." |
| `[215]` | **"...suppressed them."** | `[202]` **Narrator**: "Mansoun Leke and a group of his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Narrator**: "You made sure their voices were ..." |
| `[216]` | **"...accepted their demands."** | `[202]` **Narrator**: "Mansoun Leke and a group of his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Narrator**: "You accepted their demands and r..." |
| `[217]` | **"...censored them from press."** | `[209]` **Narrator**: "Because the constitution was eas..."<br>`[210]` **Narrator**: "Ahead of your inauguration, memb..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true` | *Brak zmian stanu* | `[238]` **Narrator**: "You censored them from the press..." |
| `[221]` | **"...promised to cooperate with them."** | `[209]` **Narrator**: "Because the constitution was eas..."<br>`[210]` **Narrator**: "Ahead of your inauguration, memb..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Narrator**: "You promised to cooperate as soo..." |
| `[222]` | **"1958\|January"** | `[192]` **Player**: "You congratulated the new Assemb..."<br>`[193]` **Player**: "You congratulated all parties th..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`<br>`(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | *Brak zmian stanu* | `[229]` **Player**: "...cooperated with them."<br>`[236]` **Player**: "...did not do anything."<br>*(oraz 1 innych odgałęzień)* |
| `[229]` | **"...cooperated with them."** | `[222]` **Narrator**: "Ahead of your inauguration, memb..."<br>`[230]` **Narrator**: "Because the constitution was eas..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Narrator**: "You promised to cooperate with t..." |
| `[230]` | **"1958\|January"** | `[192]` **Player**: "You congratulated the new Assemb..."<br>`[193]` **Player**: "You congratulated all parties th..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Reform_Court_Success"] == true` | *Brak zmian stanu* | `[229]` **Player**: "...cooperated with them."<br>`[536]` **Player**: "...rejected further amendments."<br>*(oraz 1 innych odgałęzień)* |
| `[231]` | **"1958\|January"** | `[192]` **Player**: "You congratulated the new Assemb..."<br>`[193]` **Player**: "You congratulated all parties th..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Autocrat_Path"] == true`<br>`(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | *Brak zmian stanu* | `[229]` **Player**: "...cooperated with them."<br>`[236]` **Player**: "...did not do anything."<br>*(oraz 1 innych odgałęzień)* |
| `[232]` | **"...censored them from the press."** | `[222]` **Narrator**: "Ahead of your inauguration, memb..."<br>`[230]` **Narrator**: "Because the constitution was eas..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true` | *Brak zmian stanu* | `[241]` **Narrator**: "You censored them from the media..." |
| `[236]` | **"...did not do anything."** | `[222]` **Narrator**: "Ahead of your inauguration, memb..."<br>`[231]` **Narrator**: "Ahead of your inauguration, memb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Narrator**: "You ignored their demands and po..." |
| `[244]` | **"Your new term was about to begin."** | `[241]` **Narrator**: "You censored them from the media..."<br>`[242]` **Narrator**: "You promised to cooperate with t..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[275]` **Narrator**: "You stood on the podium overlook..." |
| `[245]` | **"Your second term was about to begin."** | `[237]` **Narrator**: "You accepted their demands and r..."<br>`[238]` **Narrator**: "You censored them from the press..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[275]` **Narrator**: "You stood on the podium overlook..." |
| `[252]` | **"1958"** | `[183]` **Player**: "You congratulated all parties th..."<br>`[184]` **Player**: "You congratulated the new Assemb..."<br>*(oraz 4 innych węzłów)* | `Variable["BaseGame.PFJPLeader_Manoly"] == true`<br>`Variable["BaseGame.JoinParty_PFJP"] == true`<br>`(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false` | *Brak zmian stanu* | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." |
| `[253]` | **"1958"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." |
| `[263]` | **"1958"** | `[183]` **Player**: "You congratulated all parties th..."<br>`[184]` **Player**: "You congratulated the new Assemb..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGame.JoinParty_NFP"] == true) == false`<br>`(Variable["BaseGame.JoinParty_PFJP"] == true) == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false` | *Brak zmian stanu* | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." |
| `[264]` | **"1958"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." |
| `[265]` | **"1958"** | `[183]` **Player**: "You congratulated all parties th..."<br>`[184]` **Player**: "You congratulated the new Assemb..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`<br>`Variable["BaseGame.JoinParty_PFJP"] == true`<br>`(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false` | *Brak zmian stanu* | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." |
| `[266]` | **"1958"** | `[183]` **Player**: "You congratulated all parties th..."<br>`[184]` **Player**: "You congratulated the new Assemb..."<br>*(oraz 4 innych węzłów)* | `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false` | *Brak zmian stanu* | `[267]` **Player**: "You kept supporting the party."<br>`[268]` **Player**: "You protested against the policies." |
| `[267]` | **"You kept supporting the party."** | `[252]` **Narrator**: "A year later, Manoly went after ..."<br>`[253]` **Narrator**: "A year later, Remus started seiz..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[200]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[196]` **Narrator**: "Meanwhile, your wife became ever..."<br>*(oraz 2 innych odgałęzień)* |
| `[268]` | **"You protested against the policies."** | `[252]` **Narrator**: "A year later, Manoly went after ..."<br>`[253]` **Narrator**: "A year later, Remus started seiz..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[200]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[196]` **Narrator**: "Meanwhile, your wife became ever..."<br>*(oraz 2 innych odgałęzień)* |
| `[275]` | **"1958\|January 18th"** | `[244]` **Player**: "Your new term was about to begin."<br>`[245]` **Player**: "Your second term was about to be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Player**: "You swallowed the feeling."<br>`[279]` **Player**: "You held Monica's hand." |
| `[279]` | **"You held Monica's hand."** | `[275]` **Narrator**: "You stood on the podium overlook..."<br>`[490]` **Narrator**: "For the inauguration, you stood ..." | `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false` | `PrologueImage("pe_sordishgoat");` | `[284]` **Narrator**: "You dreamed about the future. Yo..."<br>`[285]` **Narrator**: "You dreamed about the future. Yo..." |
| `[283]` | **"You swallowed the feeling."** | `[275]` **Narrator**: "You stood on the podium overlook..."<br>`[490]` **Narrator**: "For the inauguration, you stood ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[284]` **Narrator**: "You dreamed about the future. Yo..."<br>`[285]` **Narrator**: "You dreamed about the future. Yo..." |
| `[288]` | **"You worked to achieve the dream of Malenyev."** | `[285]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[289]` | **"You did everything you could to eliminate inequality."** | `[285]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[290]` | **"You worked hard to establish social democracy in Sordland."** | `[285]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[291]` | **"You worked hard to reach the potential of the Sordish dream."** | `[284]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[292]` | **"You worked hard to establish neo-liberal Arcasian capitalism in Sordland."** | `[284]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[293]` | **"You did everything you could to expand freedoms."** | `[284]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[294]` | **"You did everything you could to help the Sordish people."** | `[287]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[295]` | **"You worked hard to establish a stronger state."** | `[287]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[296]` | **"You worked to achieve the dream of Soll."** | `[287]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[297]` | **"You did everything you could to expand freedoms."** | `[286]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[298]` | **"You did everything you could to diminish inequality."** | `[286]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[299]` | **"You worked hard to reach the potential of the Sordish dream."** | `[286]` **Narrator**: "You dreamed about the future. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "With the sacrifices made by you ..."<br>`[304]` **Narrator**: "With a sense of duty to your nat..." |
| `[320]` | **"...advised her to stop."** | `[196]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[197]` **Narrator**: "Meanwhile, you couldn't help but..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Narrator**: "Monica did not listen to you and..."<br>`[333]` **Narrator**: "Your attitude created tensions b..." |
| `[322]` | **"You never saw either of them ever again."** | `[321]` **Narrator**: "The ensuing scandal erased most ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[336]` **Narrator**: "A year later, Lileas launched a ..." |
| `[323]` | **"Time went by."** | `[324]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[328]` **Narrator**: "You and Monica began speaking to..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[336]` **Narrator**: "A year later, Lileas launched a ..." |
| `[335]` | **"You never talked to Monica again."** | `[333]` **Narrator**: "Your attitude created tensions b..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_holsord");` | `[336]` **Narrator**: "A year later, Lileas launched a ..." |
| `[336]` | **"1961"** | `[322]` **Player**: "You never saw either of them eve..."<br>`[323]` **Player**: "Time went by."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false` | *Brak zmian stanu* | `[357]` **Player**: "You accepted."<br>`[358]` **Player**: "You rejected the offer but suppo..."<br>*(oraz 1 innych odgałęzień)* |
| `[337]` | **"1961"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Player**: "You accepted."<br>`[358]` **Player**: "You rejected the offer but suppo..."<br>*(oraz 1 innych odgałęzień)* |
| `[341]` | **"1961"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Player**: "You accepted."<br>`[358]` **Player**: "You rejected the offer but suppo..."<br>*(oraz 1 innych odgałęzień)* |
| `[345]` | **"1961"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Player**: "You accepted."<br>`[358]` **Player**: "You rejected the offer but suppo..."<br>*(oraz 1 innych odgałęzień)* |
| `[352]` | **"1961"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Player**: "You accepted."<br>`[358]` **Player**: "You rejected the offer but suppo..."<br>*(oraz 1 innych odgałęzień)* |
| `[356]` | **"1961"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Player**: "You accepted."<br>`[358]` **Player**: "You rejected the offer but suppo..."<br>*(oraz 1 innych odgałęzień)* |
| `[357]` | **"You accepted."** | `[336]` **Narrator**: "A year later, Lileas launched a ..."<br>`[337]` **Narrator**: "A year later, Manoly launched a ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_politicians");` | `[361]` **Narrator**: "Unfortunately, the proposal did ..." |
| `[358]` | **"You rejected the offer but supported the proposal nonetheless."** | `[336]` **Narrator**: "A year later, Lileas launched a ..."<br>`[337]` **Narrator**: "A year later, Manoly launched a ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_politicians");` | `[361]` **Narrator**: "Unfortunately, the proposal did ..." |
| `[359]` | **"You actively worked against the proposal."** | `[336]` **Narrator**: "A year later, Lileas launched a ..."<br>`[337]` **Narrator**: "A year later, Manoly launched a ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Narrator**: "After your protests against the ..." |
| `[360]` | **"1961\|May"** | `[359]` **Player**: "You actively worked against the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best." |
| `[362]` | **"...watched from the sidelines."** | `[361]` **Narrator**: "Unfortunately, the proposal did ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_innercircle");` | `[412]` **Narrator**: "After your inaction during the d..." |
| `[363]` | **"...kept supporting Frens."** | `[361]` **Narrator**: "Unfortunately, the proposal did ..." | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true` | `PrologueImage("pe_congress");` | `[455]` **Narrator**: "Frens won in the next elections ..." |
| `[367]` | **"...kept supporting Manoly."** | `[361]` **Narrator**: "Unfortunately, the proposal did ..." | `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`<br>`(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false` | `PrologueImage("pe_congress");` | `[456]` **Narrator**: "Manoly won in the next elections..." |
| `[380]` | **"...kept supporting Kesaro."** | `[361]` **Narrator**: "Unfortunately, the proposal did ..." | `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`<br>`(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`<br>`(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false` | `PrologueImage("pe_congress");` | `[454]` **Narrator**: "Kesaro won in the next elections..." |
| `[381]` | **"...kept supporting Remus."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_congress");` | `[453]` **Narrator**: "Remus won in the next elections ..." |
| `[382]` | **"...kept supporting Mansoun."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_congress");` | `[452]` **Narrator**: "The People's Front won in the ne..." |
| `[383]` | **"...kept supporting Lileas."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_innercircle");` | `[415]` **Narrator**: "Lileas won in the next elections..." |
| `[384]` | **"...ran as a candidate."** | `[361]` **Narrator**: "Unfortunately, the proposal did ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Narrator**: "You announced that you were runn..."<br>`[401]` **Narrator**: "You announced that you were runn..."<br>*(oraz 1 innych odgałęzień)* |
| `[385]` | **"1961\|May"** | `[384]` **Player**: "...ran as a candidate." | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true` | *Brak zmian stanu* | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best." |
| `[401]` | **"1961\|May"** | `[384]` **Player**: "...ran as a candidate." | `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`<br>`(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false` | *Brak zmian stanu* | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best." |
| `[402]` | **"1961\|May"** | `[384]` **Player**: "...ran as a candidate." | `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`<br>`(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`<br>`(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false` | *Brak zmian stanu* | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best." |
| `[403]` | **"1961\|May"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best." |
| `[404]` | **"1961\|May"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best." |
| `[408]` | **"1961\|May"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best." |
| `[409]` | **"1961\|May"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best." |
| `[410]` | **"You were devastated by the result."** | `[360]` **Narrator**: "After your protests against the ..."<br>`[385]` **Narrator**: "You announced that you were runn..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[464]` **Narrator**: "You spent your retirement enjoyi..." |
| `[411]` | **"You thought it was for the best."** | `[360]` **Narrator**: "After your protests against the ..."<br>`[385]` **Narrator**: "You announced that you were runn..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[464]` **Narrator**: "You spent your retirement enjoyi..." |
| `[412]` | **"1961\|May"** | `[362]` **Player**: "...watched from the sidelines." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Player**: "...did not resist."<br>`[414]` **Player**: "...decided to retire from politi..." |
| `[413]` | **"...did not resist."** | `[412]` **Narrator**: "After your inaction during the d..."<br>`[415]` **Narrator**: "Lileas won in the next elections..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[464]` **Narrator**: "You spent your retirement enjoyi..." |
| `[414]` | **"...decided to retire from politics entirely."** | `[412]` **Narrator**: "After your inaction during the d..."<br>`[415]` **Narrator**: "Lileas won in the next elections..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[464]` **Narrator**: "You spent your retirement enjoyi..." |
| `[415]` | **"1961\|May"** | `[383]` **Player**: "...kept supporting Lileas." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Player**: "...did not resist."<br>`[414]` **Player**: "...decided to retire from politi..." |
| `[416]` | **"You deserved the praise."** | `[304]` **Narrator**: "With a sense of duty to your nat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Narrator**: "You also saw Monica. You were ba..."<br>`[425]` **Narrator**: "Monica was gaining traction in t..." |
| `[417]` | **"You knew there was more you could be doing."** | `[304]` **Narrator**: "With a sense of duty to your nat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Narrator**: "You also saw Monica. You were ba..."<br>`[425]` **Narrator**: "Monica was gaining traction in t..." |
| `[418]` | **"You needed more power to do even better."** | `[304]` **Narrator**: "With a sense of duty to your nat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Narrator**: "You also saw Monica. You were ba..."<br>`[425]` **Narrator**: "Monica was gaining traction in t..." |
| `[419]` | **"...were pleased with your achievements."** | `[303]` **Narrator**: "With the sacrifices made by you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Narrator**: "You also saw Monica. You were ba..."<br>`[425]` **Narrator**: "Monica was gaining traction in t..." |
| `[420]` | **"...knew there was more you could be doing."** | `[303]` **Narrator**: "With the sacrifices made by you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Narrator**: "You also saw Monica. You were ba..."<br>`[425]` **Narrator**: "Monica was gaining traction in t..." |
| `[426]` | **"Years passed..."** | `[424]` **Narrator**: "You also saw Monica. You were ba..."<br>`[425]` **Narrator**: "Monica was gaining traction in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Narrator**: "No more obstacles to the Sordish..." |
| `[428]` | **"Victory was here."** | `[427]` **Narrator**: "No more obstacles to the Sordish..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | *Koniec sceny / Terminal* |
| `[429]` | **"But the real morning was still on the horizon."** | `[427]` **Narrator**: "No more obstacles to the Sordish..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | *Koniec sceny / Terminal* |
| `[440]` | **""I do solemnly swear...""** | `[430]` **Narrator**: "A fierce gust of wind shook you ..."<br>`[441]` **Narrator**: "A fierce gust of wind shook you ..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[452]` | **"1961\|May"** | `[382]` **Player**: "...kept supporting Mansoun." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Player**: "You outmanoeuvred the other VP c..."<br>`[459]` **Player**: "You were happy to have allied yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[453]` | **"1961\|May"** | `[381]` **Player**: "...kept supporting Remus." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Player**: "You outmanoeuvred the other VP c..."<br>`[459]` **Player**: "You were happy to have allied yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[454]` | **"1961\|May"** | `[380]` **Player**: "...kept supporting Kesaro." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Player**: "You outmanoeuvred the other VP c..."<br>`[459]` **Player**: "You were happy to have allied yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[455]` | **"1961\|May"** | `[363]` **Player**: "...kept supporting Frens." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Player**: "You outmanoeuvred the other VP c..."<br>`[459]` **Player**: "You were happy to have allied yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[456]` | **"1961\|May"** | `[367]` **Player**: "...kept supporting Manoly." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Player**: "You outmanoeuvred the other VP c..."<br>`[459]` **Player**: "You were happy to have allied yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[457]` | **"You outmanoeuvred the other VP contenders to get the position."** | `[452]` **Narrator**: "The People's Front won in the ne..."<br>`[453]` **Narrator**: "Remus won in the next elections ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_VP"] = true;`<br>`PrologueImage("pe_blue");` | `[490]` **Narrator**: "For the inauguration, you stood ..." |
| `[458]` | **"You schemed and backstabbed to become VP."** | `[452]` **Narrator**: "The People's Front won in the ne..."<br>`[453]` **Narrator**: "Remus won in the next elections ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_VP"] = true;`<br>`PrologueImage("pe_blue");` | `[490]` **Narrator**: "For the inauguration, you stood ..." |
| `[459]` | **"You were happy to have allied yourself with the right people."** | `[452]` **Narrator**: "The People's Front won in the ne..."<br>`[453]` **Narrator**: "Remus won in the next elections ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Election_VP"] = true;`<br>`PrologueImage("pe_blue");` | `[490]` **Narrator**: "For the inauguration, you stood ..." |
| `[460]` | **"...genuinely wanted to improve society."** | `[303]` **Narrator**: "With the sacrifices made by you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Narrator**: "You also saw Monica. You were ba..."<br>`[425]` **Narrator**: "Monica was gaining traction in t..." |
| `[461]` | **"...an unmemorable figure."** | `[464]` **Narrator**: "You spent your retirement enjoyi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[462]` | **"...a disappointing politician that failed his country in a time of need."** | `[464]` **Narrator**: "You spent your retirement enjoyi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[463]` | **"...someone who tried to do their best -- but who wasn't good enough."** | `[464]` **Narrator**: "You spent your retirement enjoyi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[464]` | **"1970"** | `[410]` **Player**: "You were devastated by the result."<br>`[411]` **Player**: "You thought it was for the best."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[461]` **Player**: "...an unmemorable figure."<br>`[462]` **Player**: "...a disappointing politician th..."<br>*(oraz 1 innych odgałęzień)* |
| `[490]` | **"1962\|January 18th"** | `[457]` **Player**: "You outmanoeuvred the other VP c..."<br>`[458]` **Player**: "You schemed and backstabbed to b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Player**: "You swallowed the feeling."<br>`[279]` **Player**: "You held Monica's hand." |
| `[511]` | **"Then, you woke up."** | `[506]` **Narrator**: "The last thing you remembered wa..."<br>`[510]` **Narrator**: "The last thing you remembered wa..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[512]` **Narrator**: "As your consciousness returned, ..." |
| `[513]` | **"Serge's good luck charm."** | `[512]` **Narrator**: "As your consciousness returned, ..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[517]` **Narrator**: "You made a full recovery just in..."<br>`[518]` **Narrator**: "You made a full recovery just in..." |
| `[527]` | **"You opened your eyes."** | `[522]` **Narrator**: "The last thing you remembered wa..."<br>`[523]` **Narrator**: "The last thing you remembered wa..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[528]` **Narrator**: "Security guards rushed to your s..." |
| `[529]` | **"You saluted him back."** | `[528]` **Narrator**: "Security guards rushed to your s..." | `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[530]` **Narrator**: "Karl Greiser became a hero of th..."<br>`[534]` **Narrator**: "Karl Greiser became a hero of th..." |
| `[536]` | **"...rejected further amendments."** | `[230]` **Narrator**: "Because the constitution was eas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[535]` **Narrator**: "You rejected their amendment dem..." |
| `[538]` | **"...rejected further amendments."** | `[209]` **Narrator**: "Because the constitution was eas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[537]` **Narrator**: "You rejected their amendment dem..." |
| `[542]` | **"Serge's good luck charm."** | `[512]` **Narrator**: "As your consciousness returned, ..." | `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[517]` **Narrator**: "You made a full recovery just in..."<br>`[518]` **Narrator**: "You made a full recovery just in..." |
| `[546]` | **"You saluted him back."** | `[528]` **Narrator**: "Security guards rushed to your s..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[530]` **Narrator**: "Karl Greiser became a hero of th..."<br>`[534]` **Narrator**: "Karl Greiser became a hero of th..." |
| `[550]` | **"1957\|November 3rd"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player**: "Victory had come."<br>`[59]` **Player**: "The people had spoken again."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "For the second time, your moment of truth had arrived."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "For the second time, your moment of truth had arrived."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[34]` (Narrator), `[517]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_FormNewParty == true"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the Democrat Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.NewParty_DemocratParty"] == true` AND `Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "Their magic had worn off."*)
  - -> `[38]` (*Player: "The people had finally spoken."*)
  - -> `[39]` (*Player: "You succeeded in breaking them down."*)

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
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was a historic achievement for the country."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_FormNewParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_FormNewParty == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_FormNewParty == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_FormNewParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_victory");"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_FormNewParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_victory");"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_NFP == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_DemocratParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_DemocratParty == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_DemocratParty == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_DemocratParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_DemocratParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_DemocratParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_DemocratParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_LiberalParty == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_LiberalParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_LiberalParty == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_LiberalParty == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_LiberalParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_LiberalParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_LiberalParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_LiberalParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_PeoplesParty == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_PeoplesParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_PeoplesParty == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_PeoplesParty == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_PeoplesParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_PeoplesParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_PeoplesParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_PeoplesParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_MaroonParty == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_MaroonParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_MaroonParty == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_MaroonParty == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_MaroonParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_MaroonParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_MaroonParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_MaroonParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "On election day, millions went out to cast their votes un..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes under the watchful eye of Sordish law enforcement. 

The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "For the second time, your moment of truth had arrived."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Their magic had worn off."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[36]` (Narrator), `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the Liberal Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "Their magic had worn off."*)
  - -> `[38]` (*Player: "The people had finally spoken."*)
  - -> `[39]` (*Player: "You succeeded in breaking them down."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the People's Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "Their magic had worn off."*)
  - -> `[38]` (*Player: "The people had finally spoken."*)
  - -> `[39]` (*Player: "You succeeded in breaking them down."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The people had finally spoken."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[36]` (Narrator), `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You succeeded in breaking them down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[36]` (Narrator), `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the Maroon Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "Their magic had worn off."*)
  - -> `[38]` (*Player: "The people had finally spoken."*)
  - -> `[39]` (*Player: "You succeeded in breaking them down."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the Sordish Prosperity Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "Their magic had worn off."*)
  - -> `[38]` (*Player: "The people had finally spoken."*)
  - -> `[39]` (*Player: "You succeeded in breaking them down."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the People's Freedom and Justice Party came out as the winner, securing Manoly Suheil as the first female president of Sordland.

It was also the first time the United Sordland Party ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly = true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the joint force of the WPB and CPS, the People's Front, came out as the winners. Leke was about to become the first Sordish president with a Bludish background.

It was also first time the United Sordland Party ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_PeoplesFront = true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the People's Freedom and Justice Party came out as the winner, securing Frens Ricter's first term as president.

It was also the first time the United Sordland Party ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens = true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NFPLeader_Remus == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NFPLeader_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the National Front Party came out as the winner, securing Remus Holstron's first term as president.

It was also the first time the United Sordland Party ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus = true"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the National Front Party came out as the winner, securing Kesaro Kibener's first term as president.

It was also the first time the United Sordland Party ever lost in an election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro = true"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "As expected, the United Sordland Party came out as the winner again, securing Lileas Graf as the first female president of Sordland."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false` AND `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false` AND `(Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Lileas = true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == false)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_victory");"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner again, securing your second term as president."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "Victory had come."*)
  - -> `[59]` (*Player: "The people had spoken again."*)
  - -> `[58]` (*Player: "The party owed its success to you."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The party owed its success to you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator), `[83]` (Narrator), `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The people had spoken again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator), `[83]` (Narrator), `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Victory had come."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator), `[83]` (Narrator), `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[61]`
Mówca: **Narrator**
> "The National Front was now the second biggest party in the Assembly, leaving the PFJP to be the third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "The die had been recast."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archet..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "The National Front was now the second biggest party in th..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Re..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The People's Freedom and Justice Party was again the seco..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "The People's Freedom and Justice Party was again the seco..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "The People's Freedom and Justice Party was again the second largest party in the Assembly, while the National Front came in third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "The die had been recast."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "The People's Freedom and Justice Party was again the second largest party in the Assembly, while the National Front failed to meet the new threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "The die had been recast."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "No other party managed to enter the Assembly."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "In a historic success, the People's Front coalition got both the Workers' Party of Bludia and the Communist Party of Sordland into the Assembly as its fourth biggest political force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_NFP == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == false"*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator), `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner again, securing your second term as president.

This time, however, you won as a coalition with the PFJP. You were about to form the government together."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "Victory had come."*)
  - -> `[59]` (*Player: "The people had spoken again."*)
  - -> `[58]` (*Player: "The party owed its success to you."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner again, securing your second term as president.

This time, however, you won as a coalition with the NFP. You were about to form a government together."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "Victory had come."*)
  - -> `[59]` (*Player: "The people had spoken again."*)
  - -> `[58]` (*Player: "The party owed its success to you."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator), `[68]` (Narrator), `[69]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[86]`
Mówca: **Narrator**
> "No other party managed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_NFP == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "The National Front was now the second biggest party in th..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Ref..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Threshold_15 == true && BaseGame.R..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Policy_Law_Threshold_3"] == false  and  Variable["BaseGame.Policy_Law_Threshold_8"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Policy_Law_Threshold_3"] == false  and  Variable["BaseGame.Policy_Law_Threshold_8"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Refor..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Refor..."*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Ref..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_8"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_8"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Refor..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "In a historic success, the Communist Party of Sordland ma..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)

### Węzeł `[102]`
Mówca: **Narrator**
> "In a historic success, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 8% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "In a historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Refor..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Ref..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "In a historic moment, the Communist Party of Sordland man..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)

### Węzeł `[110]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "In a historic moment, the Communist Party of Sordland man..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "In a historic moment, the Workers' Party of Bludia manage..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Bludish votes divided between the Workers' Party of Bludia and the Bludish Freedom Party resulted in both of them finishing below the threshold, failing to be represented again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "In a historic moment, the Communist Party of Sordland, th..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "In a historic moment, the Workers' Party of Bludia manage..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

This was a first -- more parties in the Grand National Assembly than ever before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "In a historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archet..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true || BaseGame.Factio..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Re..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "In a historic success, the People's Front coalition got b..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true || BaseGame.Factio..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "In a historic success, the People's Front coalition got both the Workers' Party of Bludia and the Communist Party of Sordland into the Assembly as its third biggest political force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "You declared that "The Morning Has Come.""*)
  - -> `[189]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[191]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "In another historic success, the People's Front coalition got both the Workers' Party of Bludia and the Communist Party of Sordland into the Assembly as its fourth biggest political force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the People's Freedom and Justice Party third, leaving the National Front to be the fourth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: "The die had been recast."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Refor..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Ref..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Refor..."*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Ref..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_8"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_8"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Refor..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "No other party managed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Re..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "The United Sordland Party came in second and the People's..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "The United Sordland Party came in second and the People's..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "In another historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland, the Workers' Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

This was a first. Never before had so many parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Bludish votes divided between the Workers' Party of Bludia and the Bludish Freedom Party resulted in both finishing below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "In another historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[147]`
Mówca: **Narrator**
> "In a historic success, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 8% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archet..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "The United Sordland Party came in second and the National..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "In another historic moment, the Communist Party of Sordla..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "In another historic moment, the Communist Party of Sordla..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "In another historic moment, the Workers' Party of Bludia ..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the People's Freedom and Justice Party third. 

The National Front Party fell below the new threshold and failed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: "The die had been recast."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "In another historic success, the People's Front coalition got both the Workers' Party of Bludia and the Communist Party of Sordland into the Assembly as its fifth biggest political force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "You declared that "Morning has come.""*)
  - -> `[193]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[192]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Narrator), `[157]` (Narrator), `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "In a historic success, the Communist Party of Sordland ma..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archet..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "In a historic moment, the Communist Party of Sordland man..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "In another historic moment, the Workers' Party of Bludia ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Refo..."*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Re..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "In another historic success, the People's Front coalition..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the National Front Party third, leaving the PFJP to be the fourth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: "The die had been recast."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Ref..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Threshold_15 == true && BaseGame.R..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Policy_Law_Threshold_3"] == false  and  Variable["BaseGame.Policy_Law_Threshold_8"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Policy_Law_Threshold_3"] == false  and  Variable["BaseGame.Policy_Law_Threshold_8"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Refor..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "No other party managed to enter the Assembly."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetyp..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "The People's Freedom and Justice Party came in second and the National Front Party third. This time, however, the Communist Party of Sordland also managed to enter the Assembly as the fourth largest party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "You congratulated Lileas."*)
  - -> `[183]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[184]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the People's Freedom and Justice Party third, leaving the National Front as the fourth largest party of the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[184]` (*Player: "You congratulated the new Assembly members."*)
  - -> `[187]` (*Player: "You congratulated the WPB and CPS leadership."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the People's Freedom and Justice Party third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[184]` (*Player: "You congratulated the new Assembly members."*)
  - -> `[186]` (*Player: "You congratulated the NFP leadership."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the National Front Party third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: "You congratulated the PFJP leadership."*)
  - -> `[183]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[184]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated all parties that participated in the elections."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Narrator), `[180]` (Narrator), `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the new Assembly members."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Narrator), `[180]` (Narrator), `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the PFJP leadership."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the NFP leadership."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the WPB and CPS leadership."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated Lileas."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Narrator), `[502]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated all parties that participated in the elections."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator), `[86]` (Narrator), `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You declared that "The Morning Has Come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator), `[86]` (Narrator), `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the new Assembly members."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator), `[86]` (Narrator), `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the new Assembly members."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Narrator), `[138]` (Narrator), `[142]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated all parties that participated in the election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Narrator), `[138]` (Narrator), `[142]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You declared that "Morning has come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Narrator), `[138]` (Narrator), `[142]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "The ensuing scandal erased most of Monica's political clo..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[268]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player: "...vocally supported her."*)
  - -> `[199]` (*Player: "...stayed silent."*)
  - -> `[320]` (*Player: "...advised her to stop."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[268]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player: "...vocally supported her."*)
  - -> `[199]` (*Player: "...stayed silent."*)
  - -> `[320]` (*Player: "...advised her to stop."*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[268]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player: "...vocally supported her."*)
  - -> `[320]` (*Player: "...advised her to stop."*)
  - -> `[195]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Narrator), `[197]` (Narrator), `[200]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "Monica raised herself to new heights. She was becoming th..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[268]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player: "...vocally supported her."*)
  - -> `[199]` (*Player: "...stayed silent."*)
  - -> `[320]` (*Player: "...advised her to stop."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Narrator), `[197]` (Narrator), `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Mansoun Leke and a group of his allies came together and announced that the integrity of the election was extremely questionable. They protested the results and demanded the state of emergency be revoked immediately.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Kontekst wejściowy (poprzednik):** `[189]` (Player), `[190]` (Player), `[191]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: "...suppressed them."*)
  - -> `[216]` (*Player: "...accepted their demands."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "1958|January"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "1958|January"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Because the constitution was easier to amend now, most of the opposition came forth with demands to pursue further constitutional reforms ahead of your inauguration.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true` AND `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[189]` (Player), `[190]` (Player), `[191]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[538]` (*Player: "...rejected further amendments."*)
  - -> `[221]` (*Player: "...promised to cooperate with them."*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Ahead of your inauguration, members of the opposition already began pressing you to attempt constitutional reform once more.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[221]` (*Player: "...promised to cooperate with them."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Ahead of your inauguration, members of the opposition already began pressing you for the constitutional reforms you had promised, calling you a "puppet of the Old Guard" when you failed to respond.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[221]` (*Player: "...promised to cooperate with them."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "1958|January"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "1958|January"*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...suppressed them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "You made sure their voices were not heard. Any challenger..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted their demands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "You accepted their demands and revoked the state of emerg..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...censored them from press."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Kontekst wejściowy (poprzednik):** `[209]` (Narrator), `[210]` (Narrator), `[211]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "You censored them from the press and blocked every platfo..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player: "...censored them from press."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...promised to cooperate with them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Narrator), `[210]` (Narrator), `[211]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "You promised to cooperate as soon as your official inaugu..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Ahead of your inauguration, members of the opposition already began pressing you to attempt constitutional reform once more.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false` AND `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[192]` (Player), `[193]` (Player), `[194]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[229]` (*Player: "...cooperated with them."*)
  - -> `[236]` (*Player: "...did not do anything."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "1958|January"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "1958|January"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player: "...censored them from the press."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...cooperated with them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Narrator), `[230]` (Narrator), `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "You promised to cooperate with them as soon as your offic..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Because the constitution was easier to amend now, most of the opposition came forth with demands to pursue further constitutional reforms ahead of your inauguration.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[192]` (Player), `[193]` (Player), `[194]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[229]` (*Player: "...cooperated with them."*)
  - -> `[536]` (*Player: "...rejected further amendments."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Ahead of your inauguration, members of the opposition already began pressing you for the constitutional reforms you had promised, calling you a "puppet of the Old Guard" when you failed to respond.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == true` AND `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[192]` (Player), `[193]` (Player), `[194]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[229]` (*Player: "...cooperated with them."*)
  - -> `[236]` (*Player: "...did not do anything."*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...censored them from the press."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Kontekst wejściowy (poprzednik):** `[222]` (Narrator), `[230]` (Narrator), `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "You censored them from the media and blocked every platfo..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "1958|January"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did not do anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Narrator), `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "You ignored their demands and postponed the talks until a..."*)

### Węzeł `[237]`
Mówca: **Narrator**
> "You accepted their demands and revoked the state of emergency ahead of your second inauguration.

People celebrated the decision everywhere in Sordland. You hoped that your second inauguration would go smoother than the first."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: "Your second term was about to begin."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "You censored them from the press and blocked every platform that could make their voices heard.

You made sure your second inauguration would go smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: "Your second term was about to begin."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "You made sure their voices were not heard. Any challengers to the election were silenced and the results were officially accepted.

You made sure that your second inauguration would go smoother than the first."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: "Your second term was about to begin."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "You promised to cooperate as soon as your official inauguration was complete."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: "Your second term was about to begin."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "You censored them from the media and blocked every platform that could make their voices heard.

You made sure your second inauguration would go smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: "Your new term was about to begin."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "You promised to cooperate with them as soon as your official inauguration was complete."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: "Your new term was about to begin."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "You ignored their demands and postponed the talks until after your official inauguration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: "Your new term was about to begin."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your new term was about to begin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Narrator), `[242]` (Narrator), `[243]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your second term was about to begin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Narrator), `[238]` (Narrator), `[239]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "1958"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_NFP == true)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "1958"*)

### Węzeł `[252]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Manoly went after big corporations, raising their taxes two-fold. Many businessmen were also tried under charges of corruption, and their assets were seized.

She announced a massive redevelopment plan, "TAP", or "the Agnland Project", to contribute to social stability and economic growth by focusing on the Agnland region."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PFJPLeader_Manoly"] == true` AND `Variable["BaseGame.JoinParty_PFJP"] == true` AND `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[183]` (Player), `[184]` (Player), `[185]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: "You kept supporting the party."*)
  - -> `[268]` (*Player: "You protested against the policies."*)

### Węzeł `[253]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Remus started seizing the assets of Bludish businesses. Many businessmen were arrested under charges of corruption.

He also promoted the idea of "Maroon Blood" and heavily invested in eugenic research and the military. He openly supported and funded the Young Sords."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: "You kept supporting the party."*)
  - -> `[268]` (*Player: "You protested against the policies."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_PFJP == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NFPLeader_Remus == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "1958"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NFPLeader_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "1958"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "1958"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "1958"*)

### Węzeł `[263]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Leke and Stahler went after big corporations, raising their taxes two-fold. Many businessmen were also tried under charges of corruption, and their assets were seized.

They promoted syndicalist socialism and brought Sordland closer with Valgsland."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false` AND `(Variable["BaseGame.JoinParty_PFJP"] == true) == false` AND `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[183]` (Player), `[184]` (Player), `[185]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: "You kept supporting the party."*)
  - -> `[268]` (*Player: "You protested against the policies."*)

### Węzeł `[264]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Kibener cut back investments from Bergia and directed them to kick-start the heavy military industry of Sordland.

He announced a massive redevelopment plan, the "Sord Plan", to contribute to social stability and economic growth by focusing on the rural Greater Holsord region."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: "You kept supporting the party."*)
  - -> `[268]` (*Player: "You protested against the policies."*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Ricter started implementing tax initiatives for small businesses and made policies that were aimed at bringing more foreign investment inside the country.

He also promoted a social market economy that emphasized the need for the state to ensure that the free market produced results close to its theoretical potential."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false` AND `Variable["BaseGame.JoinParty_PFJP"] == true` AND `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[183]` (Player), `[184]` (Player), `[185]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: "You kept supporting the party."*)
  - -> `[268]` (*Player: "You protested against the policies."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Lileas went after hundreds of private businesses and seized their assets. Many were tried under charges of corruption. 

She announced a massive redevelopment plan, "TAP", or "the Agnland Project", to contribute to social stability and economic growth by focusing on the Agnland region."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Kontekst wejściowy (poprzednik):** `[183]` (Player), `[184]` (Player), `[185]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: "You kept supporting the party."*)
  - -> `[268]` (*Player: "You protested against the policies."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You kept supporting the party."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator), `[253]` (Narrator), `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You protested against the policies."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator), `[253]` (Narrator), `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 && BaseGame.Sollist < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 && B..."*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 &&..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 && BaseGame.Sollist < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Capitalist"] > 10  and  Variable["BaseGame.Malenyevist"] < 5  and  Variable["BaseGame.Sollist"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "You dreamed about the future. You saw a wealthier Sordlan..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 && BaseGame.Sollist < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Capitalist"] > 10  and  Variable["BaseGame.Malenyevist"] < 5  and  Variable["BaseGame.Sollist"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 18  and  Variable["BaseGame.Sollist"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "You dreamed about the future. You saw a Sordland of equal..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 18  and  Variable["BaseGame.Sollist"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist > 18"*)

### Węzeł `[275]`
**[WYBÓR GRACZA: "1958|January 18th"]** — Mówca: **Narrator**
> "You stood on the podium overlooking the famous Hill of Pride once again. It was a particularly cold day. 

When you looked at the thousands of people with hopeful eyes, your shoulders grew heavy and you shivered."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Player), `[245]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player: "You swallowed the feeling."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist > 18`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist > 18"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Sollist > 18)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist > 18`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Sollist"] > 18`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "You dreamed about the future. You saw a Sordland of self-..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Sollist > 18)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Sollist"] > 18) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "You dreamed about the future. You saw a Sordland of secur..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You held Monica's hand."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[275]` (Narrator), `[490]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player: "You held Monica's hand."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You swallowed the feeling."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Narrator), `[490]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[284]`
Mówca: **Narrator**
> "You dreamed about the future. You saw a wealthier Sordland.

The country saw massive economic development over your next term. The remnants of the Soll era were long gone, businesses became more profitable and the markets were freed of regulation.

As the market became freer, the people of Sordland also became free. As the economic boom continued, the most critical problems vanished one by one. Sordland was finally letting go of its past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player: "You worked hard to reach the potential of the Sordish dream."*)
  - -> `[292]` (*Player: "You worked hard to establish neo-liberal Arcasian capital..."*)
  - -> `[293]` (*Player: "You did everything you could to expand freedoms."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "You dreamed about the future. You saw a Sordland of equality.

The country saw massive social and economic reforms over your next term. The remnants of the Soll era were long gone, the unequal wealth distribution was curbed, and the means of production were being transferred to the workers.

Sordland was finally letting go of its past. As the people became more equal, they also became free. Your social experiment was bringing Sordland one step closer to the revolution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: "You worked to achieve the dream of Malenyev."*)
  - -> `[290]` (*Player: "You worked hard to establish social democracy in Sordland."*)
  - -> `[289]` (*Player: "You did everything you could to eliminate inequality."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "You dreamed about the future. You saw a Sordland of security and stability.

The country saw massive social and economic development over your term. Your centrist approach helped the country heal and unite through a middle-ground.

Sordland was finally making peace with its past and learning to look to the future with hope. You brought harmony and confidence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player: "You worked hard to reach the potential of the Sordish dream."*)
  - -> `[297]` (*Player: "You did everything you could to expand freedoms."*)
  - -> `[298]` (*Player: "You did everything you could to diminish inequality."*)

### Węzeł `[287]`
Mówca: **Narrator**
> "You dreamed about the future. You saw a Sordland of self-reliant greatness.

The country saw massive social and economic reforms over your term. The state became stronger and provided the highest-quality services to its people with strides made towards autarky.

Sordland was finally embracing its true self. As the state became richer, the people earned comfort. You made Sordland even stronger than it was before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Player: "You worked to achieve the dream of Soll."*)
  - -> `[295]` (*Player: "You worked hard to establish a stronger state."*)
  - -> `[294]` (*Player: "You did everything you could to help the Sordish people."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked to achieve the dream of Malenyev."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to eliminate inequality."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to establish social democracy in Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to reach the potential of the Sordish dream."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to establish neo-liberal Arcasian capitalism in Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to expand freedoms."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to help the Sordish people."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to establish a stronger state."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked to achieve the dream of Soll."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to expand freedoms."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to diminish inequality."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to reach the potential of the Sordish dream."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 10"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Democratic > 10)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic > 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Democratic"] > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "With the sacrifices made by you and your allies, everythi..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Democratic > 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Democratic"] > 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "With a sense of duty to your nation, you worked hard, sac..."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "With the sacrifices made by you and your allies, everything became possible. You were building a dream nation together.

You encouraged more civic responsibility and everyone contributed to the greater good in their own way. It was a democratic and just Sordland.

You saw the people smile and smiled back at them. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Player: "...were pleased with your achievements."*)
  - -> `[420]` (*Player: "...knew there was more you could be doing."*)
  - -> `[460]` (*Player: "...genuinely wanted to improve society."*)

### Węzeł `[304]`
Mówca: **Narrator**
> "With a sense of duty to your nation, you worked hard, sacrificing all of your time, your sleep, even your soul.

Thanks to your efforts, Sordland became stronger and a better place to live for its citizens -- and you. You heard them cheer your name.

You smiled. You knew you deserved to be praised more than anyone for the success."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Player: "You deserved the praise."*)
  - -> `[417]` (*Player: "You knew there was more you could be doing."*)
  - -> `[418]` (*Player: "You needed more power to do even better."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "1960"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "1960"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "1960"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "1960"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Lileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "It was a historic achievement for the country."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "The die had been recast."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "The die had been recast."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "The die had been recast."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "The die had been recast."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_PeoplesFront = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "The die had been recast."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Narrator), `[197]` (Narrator), `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[321]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player: "You never saw either of them ever again."*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Time went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Narrator), `[328]` (Narrator), `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[324]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: "Time went by."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[328]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: "Time went by."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: "Time went by."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "Monica did not listen to you and in time, raised herself ..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "Your attitude created tensions between you and Monica. Te..."*)

### Węzeł `[333]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. Tensions gave way to frequent fights until one day, Monica filed a divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Player: "You never talked to Monica again."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "Monica did not listen to you and in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: "Time went by."*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[333]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[336]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Lileas launched a massive campaign to rewrite the constitution of Sordland. 

Her proposal was aimed at strengthening the executive and judiciary branches, while transforming the election system so that the next president would be chosen by specific electors rather than the popular vote.

She offered you the position of Vice President in exchange for your support."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Kontekst wejściowy (poprzednik):** `[322]` (Player), `[323]` (Player), `[335]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: "You accepted."*)
  - -> `[358]` (*Player: "You rejected the offer but supported the proposal nonethe..."*)
  - -> `[359]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[337]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Manoly launched a massive campaign to rewrite the constitution of Sordland. 

Her proposal was aimed at strengthening the legislative branch, and expanding the rights of women and minorities, and eliminating the unequal distribution of campaign funding.

She offered you the position of Vice President in exchange for your support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: "You accepted."*)
  - -> `[358]` (*Player: "You rejected the offer but supported the proposal nonethe..."*)
  - -> `[359]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "1961"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "1961"*)

### Węzeł `[341]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Ricter launched a massive campaign to rewrite the constitution of Sordland. 

His proposal was aimed at strengthening the legislative branch, and expanding the rights of women and minorities, and eliminating the unequal distribution of campaign funding.

He offered you the position of Vice President in exchange for your support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: "You accepted."*)
  - -> `[358]` (*Player: "You rejected the offer but supported the proposal nonethe..."*)
  - -> `[359]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NFPLeader_Remus == true)"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "1961"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NFPLeader_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "1961"*)

### Węzeł `[345]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Kesaro launched a massive campaign to rewrite the constitution of Sordland. 

His proposal aimed to strengthen presidential powers, abolish the citizenship of Bludish people and implement racial laws to segregate the others from the "Maroon Bloods."

He offered you the position of Vice President in exchange for your support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: "You accepted."*)
  - -> `[358]` (*Player: "You rejected the offer but supported the proposal nonethe..."*)
  - -> `[359]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "1961"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_NFP == true)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "1961"*)

### Węzeł `[352]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Remus launched a massive campaign to rewrite the constitution of Sordland. 

His proposal aimed to strengthen presidential powers, abolish the citizenship of Bludish people and implement racial laws to segregate the others from the "Maroon Bloods."

He offered you the position of Vice President in exchange for your support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: "You accepted."*)
  - -> `[358]` (*Player: "You rejected the offer but supported the proposal nonethe..."*)
  - -> `[359]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_PFJP == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)

### Węzeł `[356]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Leke and Stahler launched a massive campaign to rewrite the constitution of Sordland. 

Their proposal aimed to strengthen the legislative branch, expand the rights of women and minorities, and ensure that the means of production would be owned by the workers.

He offered you the position of Interior Minister in exchange for your support."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: "You accepted."*)
  - -> `[358]` (*Player: "You rejected the offer but supported the proposal nonethe..."*)
  - -> `[359]` (*Player: "You actively worked against the proposal."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Narrator), `[337]` (Narrator), `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_politicians");"*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You rejected the offer but supported the proposal nonetheless."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Narrator), `[337]` (Narrator), `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_politicians");"*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You actively worked against the proposal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Narrator), `[337]` (Narrator), `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Narrator: "1961|May"*)

### Węzeł `[360]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "After your protests against the proposal, the party leadership forced you out by taking away your membership.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: "You were devastated by the result."*)
  - -> `[411]` (*Player: "You thought it was for the best."*)

### Węzeł `[361]`
Mówca: **Narrator**
> "Unfortunately, the proposal did not pass the Assembly. The resources invested in the campaign made the party fall victim to internal strife.

Each faction put forth their own candidates against the president. A congress to elect the party leadership was on the horizon.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true"*)
  - -> `[362]` (*Player: "...watched from the sidelines."*)
  - -> `[384]` (*Player: "...ran as a candidate."*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...watched from the sidelines."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_innercircle");"*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Frens."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_congress");"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true"*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true)"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: "...kept supporting Frens."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly == true"*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Manoly."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true` AND `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_congress");"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Manoly == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player: "...kept supporting Manoly."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro == true"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Kesaro == true)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Player: "...kept supporting Kesaro."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Kesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Remus == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Player: "...kept supporting Remus."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_PeoplesFront == true"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_PeoplesFront == true"*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_PeoplesFront == true)"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player: "...kept supporting Mansoun."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Player: "...kept supporting Lileas."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Kesaro."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true` AND `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false` AND `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_congress");"*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Remus."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_congress");"*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Mansoun."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_congress");"*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Lileas."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_innercircle");"*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...ran as a candidate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true"*)

### Węzeł `[385]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the PFJP Congress.

Unfortunately, you lost the vote to Frens Ricter. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Kontekst wejściowy (poprzednik):** `[384]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: "You were devastated by the result."*)
  - -> `[411]` (*Player: "You thought it was for the best."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "1961|May"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly == true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly == true"*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Manoly == true)"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "1961|May"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro == true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Remus == true)"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "1961|May"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_WPB == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Kesaro == true)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "1961|May"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Kesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_WPB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_WPB == true"*)
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_WPB == true)"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_WPB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "1961|May"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_WPB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_CPS == true"*)

### Węzeł `[401]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the PFJP Congress.

Unfortunately, you lost the vote to Manoly Suheil. The following month, she stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true` AND `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[384]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: "You were devastated by the result."*)
  - -> `[411]` (*Player: "You thought it was for the best."*)

### Węzeł `[402]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the NFP Congress.

Unfortunately, you lost the vote to Kesaro Kibener. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true` AND `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false` AND `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[384]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: "You were devastated by the result."*)
  - -> `[411]` (*Player: "You thought it was for the best."*)

### Węzeł `[403]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the NFP Congress.

Unfortunately, you lost the vote to Remus Holstron. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: "You were devastated by the result."*)
  - -> `[411]` (*Player: "You thought it was for the best."*)

### Węzeł `[404]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the WPB Congress.

Unfortunately, you lost the vote to Mansoun Leke. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: "You were devastated by the result."*)
  - -> `[411]` (*Player: "You thought it was for the best."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_CPS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_CPS == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_CPS == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_CPS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_CPS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "1961|May"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_CPS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_CPS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "1961|May"*)

### Węzeł `[408]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the CPS Congress.

Unfortunately, you lost the vote to Denis Stahler. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: "You were devastated by the result."*)
  - -> `[411]` (*Player: "You thought it was for the best."*)

### Węzeł `[409]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in that year's USP Congress.

Unfortunately, you lost the leadership vote to Lileas Graf again. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: "You were devastated by the result."*)
  - -> `[411]` (*Player: "You thought it was for the best."*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the result."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Narrator), `[385]` (Narrator), `[401]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You thought it was for the best."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Narrator), `[385]` (Narrator), `[401]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[412]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "After your inaction during the divide, the party leadership decided to push your name back in the MP list, diminishing your chances to be elected to the Assembly.

You realized that the inner circle was forcing you out of the party. 

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Player: "...did not resist."*)
  - -> `[414]` (*Player: "...decided to retire from politics entirely."*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did not resist."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Narrator), `[415]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...decided to retire from politics entirely."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Narrator), `[415]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[415]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Lileas won in the next elections and despite her promise, she did not appoint you as the Vice President.

The leadership decided to push your name back in the MP list, diminishing your chances to be elected to the Assembly. You realized that the inner circle was forcing you out of the party. 

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Player: "...did not resist."*)
  - -> `[414]` (*Player: "...decided to retire from politics entirely."*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You deserved the praise."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You knew there was more you could be doing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You needed more power to do even better."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were pleased with your achievements."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...knew there was more you could be doing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Narrator: "You also saw Monica. You were back together again. She mu..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "Monica was gaining traction in the capital as one of the ..."*)

### Węzeł `[424]`
Mówca: **Narrator**
> "You also saw Monica. You were back together again. She must have forgiven you.

Deana became a strong and successful young woman. Franc was a family man already.

You were proud of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Player: "Years passed..."*)

### Węzeł `[425]`
Mówca: **Narrator**
> "Monica was gaining traction in the capital as one of the fiercest women's rights activists, rallying thousands of Sordish women to fight for change.

Your support buoyed Monica to new heights. With her activism and your administration, Sordish women made strides towards true parity.

Deana became a strong and successful young woman. Franc was a family man already.

You were proud of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Player: "Years passed..."*)

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years passed..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Narrator), `[425]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Narrator: "No more obstacles to the Sordish Dream were left. Now the..."*)

### Węzeł `[427]`
Mówca: **Narrator**
> "No more obstacles to the Sordish Dream were left. Now the morning had truly come.

The morning brought a united and happy Sordland. An independent and formidable Sordland.

You knew it was possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Player: "Victory was here."*)
  - -> `[429]` (*Player: "But the real morning was still on the horizon."*)

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Victory was here."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[427]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "But the real morning was still on the horizon."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[427]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[430]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Garaci stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I do solemnly swear...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Narrator), `[441]` (Narrator), `[442]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[441]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Grecer stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[442]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Hawker stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)

### Węzeł `[446]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Hawker stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[447]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Garaci stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[451]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Grecer stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[452]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "The People's Front won in the next elections and Mansoun appointed you as his Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player: "You outmanoeuvred the other VP contenders to get the posi..."*)
  - -> `[459]` (*Player: "You were happy to have allied yourself with the right peo..."*)
  - -> `[458]` (*Player: "You schemed and backstabbed to become VP."*)

### Węzeł `[453]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Remus won in the next elections and appointed you as his Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[381]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player: "You outmanoeuvred the other VP contenders to get the posi..."*)
  - -> `[459]` (*Player: "You were happy to have allied yourself with the right peo..."*)
  - -> `[458]` (*Player: "You schemed and backstabbed to become VP."*)

### Węzeł `[454]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Kesaro won in the next elections and appointed you as his Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player: "You outmanoeuvred the other VP contenders to get the posi..."*)
  - -> `[459]` (*Player: "You were happy to have allied yourself with the right peo..."*)
  - -> `[458]` (*Player: "You schemed and backstabbed to become VP."*)

### Węzeł `[455]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Frens won in the next elections and appointed you as his Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player: "You outmanoeuvred the other VP contenders to get the posi..."*)
  - -> `[459]` (*Player: "You were happy to have allied yourself with the right peo..."*)
  - -> `[458]` (*Player: "You schemed and backstabbed to become VP."*)

### Węzeł `[456]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Manoly won in the next elections and appointed you as her Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[367]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player: "You outmanoeuvred the other VP contenders to get the posi..."*)
  - -> `[459]` (*Player: "You were happy to have allied yourself with the right peo..."*)
  - -> `[458]` (*Player: "You schemed and backstabbed to become VP."*)

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You outmanoeuvred the other VP contenders to get the position."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[452]` (Narrator), `[453]` (Narrator), `[454]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP = true"*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You schemed and backstabbed to become VP."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[452]` (Narrator), `[453]` (Narrator), `[454]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP = true"*)

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to have allied yourself with the right people."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[452]` (Narrator), `[453]` (Narrator), `[454]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP = true"*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...genuinely wanted to improve society."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...an unmemorable figure."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a disappointing politician that failed his country in a time of need."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...someone who tried to do their best -- but who wasn't good enough."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[464]`
**[WYBÓR GRACZA: "1970"]** — Mówca: **Narrator**
> "You spent your retirement enjoying the simple things in life. 

You went down in the Sordish history books as..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[410]` (Player), `[411]` (Player), `[413]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: "...an unmemorable figure."*)
  - -> `[462]` (*Player: "...a disappointing politician that failed his country in ..."*)
  - -> `[463]` (*Player: "...someone who tried to do their best -- but who wasn't g..."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_VP == true)"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_VP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[469]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Garaci stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_VP == true)"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_VP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[473]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Grecer stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_VP == true)"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_VP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[477]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Hawker stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_VP == true)"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_VP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[481]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Garaci stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_VP == true)"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_VP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[485]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Grecer stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_VP == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_VP == true)"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_VP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_VP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Narrator: "A fierce gust of wind shook you out of your daydream.  Mo..."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Hawker stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""I do solemnly swear...""*)

### Węzeł `[490]`
**[WYBÓR GRACZA: "1962|January 18th"]** — Mówca: **Narrator**
> "For the inauguration, you stood on the podium next to the party leader overlooking the famous Hill of Pride. The new cabinet was ready to serve the country. It was a particularly cold day.

When you looked at the thousands of people with hopeful eyes, your shoulders grew heavy and you shivered. 

You were going to be their next Vice President."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Player), `[458]` (Player), `[459]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player: "You swallowed the feeling."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_NFP_Destroyed == true)"*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Narrator: "With no clear leadership, the National Front Party failed..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_NFP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true)"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "With no clear leadership, the People's Freedom and Justic..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)

### Węzeł `[497]`
Mówca: **Narrator**
> "With no clear leadership, the People's Freedom and Justice Party failed at entering the Assembly while the National Front Party became the second largest by a number of seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "The die had been recast."*)

### Węzeł `[498]`
Mówca: **Narrator**
> "With no clear leadership, the National Front Party failed at entering the Assembly while the People's Freedom and Justice Party became the second largest by number of seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "The die had been recast."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true)"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "The National Front Party came in second; without any clea..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "The People's Freedom and Justice Party came in second and..."*)

### Węzeł `[502]`
Mówca: **Narrator**
> "The National Front Party came in second; without any clear leadership, the PFJP limped into third. This time, however, the Communist Party of Sordland also managed to enter the Assembly as the fourth largest party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "You congratulated Lileas."*)
  - -> `[183]` (*Player: "You congratulated all parties that participated in the el..."*)
  - -> `[184]` (*Player: "You congratulated the new Assembly members."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn11_Election_AssassinationHappened == true)"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn11_Election_AssassinationHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[506]`
Mówca: **Narrator**
> "The last thing you remembered was chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Player: "Then, you woke up."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Secur..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Narrator: "The last thing you remembered was a shout of "For Free Bl..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumburg..."*)

### Węzeł `[510]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "For Free Bludia! Yollak Bluderat!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Player: "Then, you woke up."*)

### Węzeł `[511]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Then, you woke up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Narrator), `[510]` (Narrator), `[554]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Narrator: "As your consciousness returned, you realized you were in ..."*)

### Węzeł `[512]`
Mówca: **Narrator**
> "As your consciousness returned, you realized you were in a hospital. Several doctors were standing over you with looks of relief on their faces.

They told you that assassin's bullet had broken a couple of your ribs, but a metal object in your pocket had kept it from hitting any major organs.

They showed it to you. It was an antique pocket watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Serge's good luck charm."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[512]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Narrator: "You made a full recovery just in time for election day. M..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "You made a full recovery just in time for election day. M..."*)

### Węzeł `[517]`
Mówca: **Narrator**
> "You made a full recovery just in time for election day. Millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "For the second time, your moment of truth had arrived."*)

### Węzeł `[518]`
Mówca: **Narrator**
> "You made a full recovery just in time for election day. Millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "For the second time, your moment of truth had arrived."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == tru..."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  and  Variable["BaseGame.Fired_KarlGreiser"] == false  and  Variable["BaseGame.Turn09_A_LileasResigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  and  Variable["BaseGame.Fired_KarlGreiser"] == false  and  Variable["BaseGame.Turn09_A_LileasResigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)

### Węzeł `[522]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "For Free Bludia! Yollak Bluderat!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

You felt a heavy weight on top of you. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player: "You opened your eyes."*)

### Węzeł `[523]`
Mówca: **Narrator**
> "The last thing you remembered was chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

You felt a heavy weight on top of you. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player: "You opened your eyes."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Secur..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "The last thing you remembered was a shout of "For Free Bl..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumburg..."*)

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You opened your eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[522]` (Narrator), `[523]` (Narrator), `[558]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Narrator: "Security guards rushed to your side. When you came to you..."*)

### Węzeł `[528]`
Mówca: **Narrator**
> "Security guards rushed to your side. When you came to your senses, you realized.

It was Karl Greiser who jumped in front of the bullet to save your life.

He saluted you as he lay bleeding beside you. The end was near for him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[529]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You saluted him back."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[528]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[530]`
Mówca: **Narrator**
> "Karl Greiser became a hero of the nation for his ultimate sacrifice.

In this tense atmosphere, the election day approached.

Millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "For the second time, your moment of truth had arrived."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "Karl Greiser became a hero of the nation for his ultimate..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "Karl Greiser became a hero of the nation for his ultimate..."*)

### Węzeł `[534]`
Mówca: **Narrator**
> "Karl Greiser became a hero of the nation for his ultimate sacrifice.

In this tense atmosphere, the election day approached.

Millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "For the second time, your moment of truth had arrived."*)

### Węzeł `[535]`
Mówca: **Narrator**
> "You rejected their amendment demands and postponed the talks until after your official inauguration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: "Your new term was about to begin."*)

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...rejected further amendments."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Narrator: "You rejected their amendment demands and postponed the ta..."*)

### Węzeł `[537]`
Mówca: **Narrator**
> "You rejected their amendment demands and postponed the talks until after your official inauguration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: "Your second term was about to begin."*)

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...rejected further amendments."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Narrator: "You rejected their amendment demands and postponed the ta..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Player: "Serge's good luck charm."*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Player: "Serge's good luck charm."*)

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Serge's good luck charm."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[512]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Player: "You saluted him back."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Player: "You saluted him back."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You saluted him back."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[528]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == false"*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == false)"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Narrator: "1957|November 3rd"*)

### Węzeł `[550]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner again, securing your second term as president.

The international community criticized the election's integrity and the opposition asked for a transparent recount. 

The request was duly rejected."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "Victory had come."*)
  - -> `[59]` (*Player: "The people had spoken again."*)
  - -> `[58]` (*Player: "The party owed its success to you."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumburg..."*)
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumbu..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Narrator: "The last thing you remembered was a shout of "Or Dax Quer..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Narrator: "The last thing you remembered was chaos. The people in th..."*)

### Węzeł `[554]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "Or Dax Querna! Qival Rumburgia!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Player: "Then, you woke up."*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumburg..."*)
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumbu..."*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "The last thing you remembered was a shout of "Or Dax Quer..."*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "The last thing you remembered was chaos. The people in th..."*)

### Węzeł `[558]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "Or Dax Querna! Qival Rumburgia!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player: "You opened your eyes."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true"*)
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth ==..."*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Narrator: "On election day, millions went out to cast their votes un..."*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords ==..."*)

### Węzeł `[562]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes under the watchful eye of the tens of thousands of Red Youth militias and other law enforcement units. 

The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "For the second time, your moment of truth had arrived."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords ==..."*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords ..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Narrator: "On election day, millions went out to cast their votes un..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "On election day, millions went out to cast their votes, s..."*)

### Węzeł `[566]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes under the watchful eye of the tens of thousands of Young Sords militias and other law enforcement units. 

The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "For the second time, your moment of truth had arrived."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true || BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true || BaseGame.Factio..."*)
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_NFP_Destroyed == true || BaseGame.Fact..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true || BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true  or  Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "In a historic success, the People's Front coalition got b..."*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_NFP_Destroyed == true || BaseGame.Faction_PFJP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true  or  Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "In a historic success, the People's Front coalition got b..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true"*)
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_NFP_Destroyed == true)"*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "In another historic success, the People's Front coalition..."*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_NFP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "In another historic success, the People's Front coalition..."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Ref..."*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Ref..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_victory");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_victory");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_DemocratParty == true"*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_victory");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_victory");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_victory");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_victory");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "The United Sordland Party came in second and the National..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "The United Sordland Party came in second and the People's..."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "The United Sordland Party came in second and the People's..."*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false"*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Narrator: "1970"*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_politicians");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_politicians");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "Unfortunately, the proposal did not pass the Assembly. Th..."*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_innercircle");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_innercircle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Narrator: "1961|May"*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_innercircle");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_innercircle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "1961|May"*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_congress");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Narrator: "1961|May"*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_congress");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Narrator: "1961|May"*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_congress");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Narrator: "1961|May"*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_congress");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: "1961|May"*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_congress");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Narrator: "1961|May"*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Narrator: "1962|January 18th"*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 && B..."*)

### Węzeł `[595]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "1958|January 18th"*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
