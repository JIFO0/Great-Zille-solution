# Rizia/Turn 10/Executions

- **ID konwersacji:** `337`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/337_Executions.md`
- **Liczba węzłów dialogowych:** 423
- **Liczba wyborów gracza:** 68

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[87]** Sal Ignacius
- **[89]** Russello Montoro
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon
- **[101]** Pabel Adria
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.Angelica_Arrested`
- `RiziaDLC.Angelica_Executed`
- `RiziaDLC.Axel_Executed`
- `RiziaDLC.CountryRelation_Valgsland_Allied`
- `RiziaDLC.CountryRelation_Valgsland_Friendly`
- `RiziaDLC.Executions_Method_Electrocution`
- `RiziaDLC.Executions_Method_FiringSquad`
- `RiziaDLC.Executions_Method_Guillotine`
- `RiziaDLC.Executions_Publicity_Everyone`
- `RiziaDLC.Executions_Publicity_OnlyNobles`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Manus_Arrested`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Pabel_Executed`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Rusty_Executed`
- `RiziaDLC.Sal_Executed`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Titus_Executed`
- `RiziaDLC.Turn10_TotalExecutions`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLCIsolated.Executions_Adarfo`
- `RiziaDLCIsolated.Executions_AllOfYou`
- `RiziaDLCIsolated.Executions_Angelica`
- `RiziaDLCIsolated.Executions_Axel`
- `RiziaDLCIsolated.Executions_Hugo`
- `RiziaDLCIsolated.Executions_Lucita`
- `RiziaDLCIsolated.Executions_Manus`
- `RiziaDLCIsolated.Executions_Pabel`
- `RiziaDLCIsolated.Executions_Rico`
- `RiziaDLCIsolated.Executions_Rusty`
- `RiziaDLCIsolated.Executions_Sal`
- `RiziaDLCIsolated.Executions_Taddeus`
- `RiziaDLCIsolated.Executions_Titus`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Turn10_TotalExecutions`
- `RiziaDLCIsolated.Executions_Adarfo`
- `RiziaDLCIsolated.Executions_AllOfYou`
- `RiziaDLCIsolated.Executions_Angelica`
- `RiziaDLCIsolated.Executions_Axel`
- `RiziaDLCIsolated.Executions_Hugo`
- `RiziaDLCIsolated.Executions_Lucita`
- `RiziaDLCIsolated.Executions_Manus`
- `RiziaDLCIsolated.Executions_Pabel`
- `RiziaDLCIsolated.Executions_Rico`
- `RiziaDLCIsolated.Executions_Rusty`
- `RiziaDLCIsolated.Executions_Sal`
- `RiziaDLCIsolated.Executions_Taddeus`
- `RiziaDLCIsolated.Executions_Titus`
- `RiziaDLCSupport.Journal_Turn10_Executions`
- `RiziaDLCSupport.Journal_Turn10_Executions_Hugo`
- `RiziaDLCSupport.Journal_Turn10_Executions_Titus`
- `RiziaDLCSupport.News_Turn10_RH_Executions_Nobles`
- `RiziaDLCSupport.News_Turn10_RH_Executions_Private`
- `RiziaDLCSupport.News_Turn10_RH_Executions_Public`
- `RiziaDLCSupport.News_Turn10_V_Excecutions_Nobles`
- `RiziaDLCSupport.News_Turn10_V_Excecutions_Private`
- `RiziaDLCSupport.News_Turn10_V_Excecutions_Public`
- `RiziaDLCSupport.Reports_Turn10_Iza_ManusExecuted`
- `RiziaDLCSupport.Reports_Turn10_Iza_RicoExecuted`
- `RiziaDLCSupport.Reports_Turn10_Lespia_RustyExecuted`
- `RiziaDLCSupport.Reports_Turn10_Monqiz_HugoExecuted`
- `RiziaDLCSupport.Reports_Turn10_Montaklar_AzaroExecuted`
- `RiziaDLCSupport.Reports_Turn10_Valgsland_PabelExecuted`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **"Gesture at them to bring out the prisoners."** | `[5]` **Narrator**: "The Sila Orica had been placed o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Publi...`<br>`AddConversant("Hugo Toras"); Variable["RiziaDLC.Turn10_To...`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[18]` | **"Gesture at them to bring out the prisoners."** | `[17]` **Narrator**: "The Sila Orica had been placed o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Noble...`<br>`AddConversant("Hugo Toras"); Variable["RiziaDLC.Turn10_To...`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[24]` | **"Gesture for them to bring out the prisoners."** | `[23]` **Narrator**: "I was led to the courtyard where..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Priva...`<br>`AddConversant("Hugo Toras"); Variable["RiziaDLC.Turn10_To...`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[70]` | **""I would like to speak to the death row inmates.""** | `[69]` **Narrator**: "Calmly he came before me and bow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "He nodded and moved aside." |
| `[71]` | **""No need to waste time.""** | `[69]` **Narrator**: "Calmly he came before me and bow..." | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Stress","R_Stress_Loop");` | `[166]` **Narrator**: "The executioner looked at me for..." |
| `[97]` | **""All of you.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLCIsolated.Executions_AllOfYou"] == false` | `Variable["RiziaDLCIsolated.Executions_AllOfYou"] = true;` | `[120]` **Player_Romus**: ""You will all be forgotten. I wi..."<br>`[121]` **Player_Romus**: ""You have committed grave crimes..."<br>*(oraz 1 innych odgałęzień)* |
| `[98]` | **""Sal Ignacius.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Sal_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Sal"] == false` | `Variable["RiziaDLCIsolated.Executions_Sal"] = true;` | `[126]` **Player_Romus**: ""Maybe now you will finally get ..."<br>`[127]` **Player_Romus**: ""You will burn in hell for an et..."<br>*(oraz 1 innych odgałęzień)* |
| `[99]` | **""Manus Sazon.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Manus_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Manus"] == false  and  Variable["RiziaDLC.Manus_Arrested"] == true` | `Variable["RiziaDLCIsolated.Executions_Manus"] = true;` | `[131]` **Player_Romus**: ""Once the heir of a great family..."<br>`[130]` **Player_Romus**: ""You share the fate of your fath..."<br>*(oraz 1 innych odgałęzień)* |
| `[100]` | **""Axel Reinhart.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Axel_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Axel"] == false` | `Variable["RiziaDLCIsolated.Executions_Axel"] = true;` | `[123]` **Player_Romus**: ""I have been waiting for this fo..."<br>`[124]` **Player_Romus**: ""The destiny of our countries ha..."<br>*(oraz 1 innych odgałęzień)* |
| `[101]` | **""Russello Montoro.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Rusty_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rusty"] == false` | `Variable["RiziaDLCIsolated.Executions_Rusty"] = true;` | `[132]` **Player_Romus**: ""Your gold will not save you now.""<br>`[133]` **Player_Romus**: ""Your endless greed has ended yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[102]` | **""Ricardus Toras.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rico"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == true` | `Variable["RiziaDLCIsolated.Executions_Rico"] = true;` | `[137]` **Player_Romus**: ""You dared to betray your King. ..."<br>`[220]` **Player_Romus**: ""You will burn in hell for what ..."<br>*(oraz 2 innych odgałęzień)* |
| `[103]` | **""Lucita Azaro.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == true` | `Variable["RiziaDLCIsolated.Executions_Lucita"] = true;` | `[140]` **Player_Romus**: ""If only I could execute you twi..."<br>`[139]` **Player_Romus**: ""House Azaro will fall because o..."<br>*(oraz 2 innych odgałęzień)* |
| `[104]` | **""Taddeus Azaro.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Taddeus"] == false` | `Variable["RiziaDLCIsolated.Executions_Taddeus"] = true;` | `[142]` **Player_Romus**: ""My father should have executed ..."<br>`[143]` **Player_Romus**: ""The only thing you have brought..."<br>*(oraz 2 innych odgałęzień)* |
| `[119]` | **""I won't waste my breath on you people anymore.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLCIsolated.Executions_AllOfYou"] == true  or  Variable["RiziaDLCIsolated.Executions_Axel"] == true  or  Variable["RiziaDLCIsolated.Executions_Lucita"] == true  or  Variable["RiziaDLCIsolated.Executions_Manus"] == true  or  Variable["RiziaDLCIsolated.Executions_Rico"] == true  or  Variable["RiziaDLCIsolated.Executions_Rusty"] == true  or  Variable["RiziaDLCIsolated.Executions_Sal"] == true  or  Variable["RiziaDLCIsolated.Executions_Taddeus"] == true  or  Variable["RiziaDLCIsolated.Executions_Pabel"] == true  or  Variable["RiziaDLCIsolated.Executions_Titus"] == true` | `PlayLoopedMusic("R_Stress","R_Stress_Loop");` | `[166]` **Narrator**: "The executioner looked at me for..." |
| `[120]` | **""You will all be forgotten. I will remove you from the annals of history.""** | `[97]` **Player_Romus**: ""All of you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Player_Romus**: ""All of you.""<br>`[287]` **Player_Romus**: ""Hugo Toras.""<br>*(oraz 12 innych odgałęzień)* |
| `[121]` | **""You have committed grave crimes against Rizia. I hereby punish you.""** | `[97]` **Player_Romus**: ""All of you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Player_Romus**: ""All of you.""<br>`[287]` **Player_Romus**: ""Hugo Toras.""<br>*(oraz 12 innych odgałęzień)* |
| `[122]` | **""I am only doing my royal duty as the King of Rizia. I hope you will use these las..."** | `[97]` **Player_Romus**: ""All of you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Player_Romus**: ""All of you.""<br>`[287]` **Player_Romus**: ""Hugo Toras.""<br>*(oraz 12 innych odgałęzień)* |
| `[123]` | **""I have been waiting for this for a long time. I will savor every second of it.""** | `[100]` **Player_Romus**: ""Axel Reinhart."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Axel Reinhart**: ""I have lost... everything."" |
| `[124]` | **""The destiny of our countries has always been to be together. Yet, here we are.""** | `[100]` **Player_Romus**: ""Axel Reinhart."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Axel Reinhart**: ""I have lost... everything."" |
| `[125]` | **""I will personally make sure your remains are transported back to your relatives i..."** | `[100]` **Player_Romus**: ""Axel Reinhart."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Axel Reinhart**: ""I have lost... everything."" |
| `[126]` | **""Maybe now you will finally get to meet your dear God.""** | `[98]` **Player_Romus**: ""Sal Ignacius."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Sal Ignacius**: ""Curse you and your family, Romu..." |
| `[127]` | **""You will burn in hell for an eternity for what you have done.""** | `[98]` **Player_Romus**: ""Sal Ignacius."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Sal Ignacius**: ""Curse you and your family, Romu..." |
| `[128]` | **""It is truly sad to see a once-godly man indulge in such crimes against the crown.""** | `[98]` **Player_Romus**: ""Sal Ignacius."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Sal Ignacius**: ""Curse you and your family, Romu..." |
| `[129]` | **""So young. A pity, really.""** | `[99]` **Player_Romus**: ""Manus Sazon."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Manus Sazon**: ""Your time will come as well, Ki..." |
| `[130]` | **""You share the fate of your father. Perhaps it is true that nothing good comes out..."** | `[99]` **Player_Romus**: ""Manus Sazon."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Manus Sazon**: ""Your time will come as well, Ki..." |
| `[131]` | **""Once the heir of a great family. Now look at what your dynasty has come to.""** | `[99]` **Player_Romus**: ""Manus Sazon."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Manus Sazon**: ""Your time will come as well, Ki..." |
| `[132]` | **""Your gold will not save you now.""** | `[101]` **Player_Romus**: ""Russello Montoro."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Russello Montoro**: ""You're making a mistake, Your M..." |
| `[133]` | **""Your endless greed has ended you. Ironic.""** | `[101]` **Player_Romus**: ""Russello Montoro."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Russello Montoro**: ""You're making a mistake, Your M..." |
| `[134]` | **""This shouldn't have been your demise. I am disappointed.""** | `[101]` **Player_Romus**: ""Russello Montoro."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Russello Montoro**: ""You're making a mistake, Your M..." |
| `[135]` | **""Wiktor Smolak sends his regards.""** | `[102]` **Player_Romus**: ""Ricardus Toras."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Rico Toras**: ""Shut up and get it over with, c..." |
| `[136]` | **""It pains me to do this to a member of my own family, but your incompetence and tr..."** | `[102]` **Player_Romus**: ""Ricardus Toras."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Rico Toras**: ""Shut up and get it over with, c..." |
| `[137]` | **""You dared to betray your King. The leader of your own House! You deserve this.""** | `[102]` **Player_Romus**: ""Ricardus Toras."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Rico Toras**: ""Shut up and get it over with, c..." |
| `[138]` | **""I'm sorry, Luce. It's nothing personal.""** | `[103]` **Player_Romus**: ""Lucita Azaro."" | `Variable["RiziaDLC.Lucita_RomanceHappened"] == true` | *Brak zmian stanu* | `[145]` **Narrator**: "She stared at me, every muscle i..." |
| `[139]` | **""House Azaro will fall because of you.""** | `[103]` **Player_Romus**: ""Lucita Azaro."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Narrator**: "She stared at me, every muscle i..." |
| `[140]` | **""If only I could execute you twice.""** | `[103]` **Player_Romus**: ""Lucita Azaro."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Narrator**: "She stared at me, every muscle i..." |
| `[141]` | **""From a great general to a death row inmate. What a sorry sight.""** | `[104]` **Player_Romus**: ""Taddeus Azaro."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Taddeus Azaro**: ""Your hubris will be your downfa..."<br>`[144]` **Taddeus Azaro**: ""I accept my fate, Your Majesty...." |
| `[142]` | **""My father should have executed you long ago. Perhaps none of this would have happ..."** | `[104]` **Player_Romus**: ""Taddeus Azaro."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Taddeus Azaro**: ""Your hubris will be your downfa..."<br>`[144]` **Taddeus Azaro**: ""I accept my fate, Your Majesty...." |
| `[143]` | **""The only thing you have brought to your family is shame.""** | `[104]` **Player_Romus**: ""Taddeus Azaro."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Taddeus Azaro**: ""Your hubris will be your downfa..."<br>`[144]` **Taddeus Azaro**: ""I accept my fate, Your Majesty...." |
| `[167]` | **"Gesture for the executions to start."** | `[166]` **Narrator**: "The executioner looked at me for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Narrator**: "With an off-putting smile, he mo..." |
| `[188]` | **""I will see you all in hell.""** | `[187]` **Narrator**: "The executioner held his hand up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Narrator**: "His hand went down and the signa..." |
| `[189]` | **""Halaita.""** | `[187]` **Narrator**: "The executioner held his hand up..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[200]` **Narrator**: "His hand went down and the signa..." |
| `[190]` | **""Do it.""** | `[187]` **Narrator**: "The executioner held his hand up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Narrator**: "His hand went down and the signa..." |
| `[220]` | **""You will burn in hell for what you did to both Rizia and Wehlen.""** | `[102]` **Player_Romus**: ""Ricardus Toras."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Rico Toras**: ""Shut up and get it over with, c..." |
| `[233]` | **""You earned my respect, only to betray me. What do you have to say for yourself?""** | `[103]` **Player_Romus**: ""Lucita Azaro."" | `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false` | *Brak zmian stanu* | `[145]` **Narrator**: "She stared at me, every muscle i..." |
| `[238]` | **""Pabel Adria.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLCIsolated.Executions_Pabel"] == false  and  Variable["RiziaDLC.Pabel_Executed"] == true` | `Variable["RiziaDLCIsolated.Executions_Pabel"] = true;` | `[244]` **Player_Romus**: ""Where is my daughter?""<br>`[255]` **Player_Romus**: ""For humiliating the Royal Famil..."<br>*(oraz 2 innych odgałęzień)* |
| `[240]` | **""Bi mare volu...""** | `[238]` **Player_Romus**: ""Pabel Adria."" | `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true` | *Brak zmian stanu* | `[247]` **Narrator**: "He shook his head." |
| `[244]` | **""Where is my daughter?""** | `[238]` **Player_Romus**: ""Pabel Adria."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Pabel Adria**: ""Far away from you."" |
| `[245]` | **""I wish this had gone differently.""** | `[238]` **Player_Romus**: ""Pabel Adria."" | `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false` | *Brak zmian stanu* | `[249]` **Pabel Adria**: ""So do I, Your Majesty."" |
| `[255]` | **""For humiliating the Royal Family of Rizia, you will pay the ultimate price.""** | `[238]` **Player_Romus**: ""Pabel Adria."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Narrator**: "He shook his head." |
| `[267]` | **""Titus Gordion.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLCIsolated.Executions_Titus"] == false  and  Variable["RiziaDLC.Titus_Executed"] == true` | `Variable["RiziaDLCIsolated.Executions_Titus"] = true;` | `[270]` **Player_Romus**: ""You bit the hand that fed you.""<br>`[269]` **Player_Romus**: ""To think that I trusted you wit..."<br>*(oraz 1 innych odgałęzień)* |
| `[269]` | **""To think that I trusted you with the security of me and my family.""** | `[267]` **Player_Romus**: ""Titus Gordion."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Titus Gordion**: ""To think that I trusted you wit..." |
| `[270]` | **""You bit the hand that fed you.""** | `[267]` **Player_Romus**: ""Titus Gordion."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Titus Gordion**: ""The only thing you could feed p..." |
| `[271]` | **""May you burn in hell.""** | `[267]` **Player_Romus**: ""Titus Gordion."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Titus Gordion**: ""Alongside you, sir."" |
| `[287]` | **""Hugo Toras.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLCIsolated.Executions_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true` | `Variable["RiziaDLCIsolated.Executions_Hugo"] = true;` | `[290]` **Player_Romus**: ""You were almost a father to me...""<br>`[289]` **Player_Romus**: ""You are not worthy of the Toras..."<br>*(oraz 2 innych odgałęzień)* |
| `[289]` | **""You are not worthy of the Toras name.""** | `[287]` **Player_Romus**: ""Hugo Toras."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Hugo Toras**: ""Everything I ever did was for o..." |
| `[290]` | **""You were almost a father to me...""** | `[287]` **Player_Romus**: ""Hugo Toras."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Hugo Toras**: ""And you were almost a son..."" |
| `[291]` | **""May you meet my father in hell.""** | `[287]` **Player_Romus**: ""Hugo Toras."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Hugo Toras**: ""We will wait for you to join us."" |
| `[362]` | **""Fitting, isn't it? For you and your failure of a son to die together.""** | `[287]` **Player_Romus**: ""Hugo Toras."" | `Variable["RiziaDLC.Rico_Executed"] == true` | *Brak zmian stanu* | `[363]` **Hugo Toras**: ""I beg you, Romus. Kill me if yo..." |
| `[375]` | **""Angelica Sazon.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Angelica"] == false` | `Variable["RiziaDLCIsolated.Executions_Angelica"] = true;` | `[378]` **Player_Romus**: ""My father should have done this..."<br>`[377]` **Player_Romus**: ""I gave you a chance to redeem y..."<br>*(oraz 2 innych odgałęzień)* |
| `[377]` | **""I gave you a chance to redeem yourself, and you abused it. Your punishment is wel..."** | `[375]` **Player_Romus**: ""Angelica Sazon."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Angelica Sazon**: ""I regret nothing."" |
| `[378]` | **""My father should have done this years ago.""** | `[375]` **Player_Romus**: ""Angelica Sazon."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Angelica Sazon**: ""I regret nothing."" |
| `[379]` | **""How fitting for you to die alongside your son. Your treacherous legacy ends today.""** | `[375]` **Player_Romus**: ""Angelica Sazon."" | `Variable["RiziaDLC.Manus_Executed"] == true` | *Brak zmian stanu* | `[384]` **Angelica Sazon**: ""I regret nothing."" |
| `[383]` | **""A pity you couldn't fall in line like your son did. Your treachery ends today.""** | `[375]` **Player_Romus**: ""Angelica Sazon."" | `(Variable["RiziaDLC.Manus_Executed"] == true) == false` | *Brak zmian stanu* | `[384]` **Angelica Sazon**: ""I regret nothing."" |
| `[390]` | **""Adarfo Sotelato.""** | `[72]` **Narrator**: "He nodded and moved aside."<br>`[157]` **Narrator**: "He looked defeated and weak."<br>*(oraz 16 innych węzłów)* | `Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Adarfo"] == false` | `Variable["RiziaDLCIsolated.Executions_Adarfo"] = true;` | `[393]` **Player_Romus**: ""Your revolution has failed, lik..."<br>`[394]` **Player_Romus**: ""This is your last chance. Ackno..."<br>*(oraz 1 innych odgałęzień)* |
| `[392]` | **""You're a sham. You never truly wanted to make people's lives better. You only wan..."** | `[390]` **Player_Romus**: ""Adarfo Sotelato."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[397]` **Adarfo Sotelato**: ""I cannot take these words serio..." |
| `[393]` | **""Your revolution has failed, like so many others before it.""** | `[390]` **Player_Romus**: ""Adarfo Sotelato."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Adarfo Sotelato**: ""It lives on in the hearts of th..." |
| `[394]` | **""This is your last chance. Acknowledge me as your rightful king, and I'll clear yo..."** | `[390]` **Player_Romus**: ""Adarfo Sotelato."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Adarfo Sotelato**: ""You don't mean that. But even i..." |
| `[412]` | **""Look over there at your daughter. The all-powerful House of Azaro has been reduce..."** | `[104]` **Player_Romus**: ""Taddeus Azaro."" | `Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true` | *Brak zmian stanu* | `[413]` **Narrator**: "His eyes filled with tears. He m..." |

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
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The maximum security prison's tall metal gates opened and a convoy of vehicles followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The convoy was escorted on all sides by many police cars ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The convoy was escorted on all sides by many police cars and armored police carriers. Soon, they arrived at Plaza Drazia, a square in the city center where public executions traditionally took place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The crowd's energy was very mixed. Some of them were chee..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The Sila Orica had been placed on a balcony overlooking the plaza. The police were awaiting for my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus_Italic: "Gesture at them to bring out the prisoners."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Publicity_Everyone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_Everyone == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Publicity_Everyone == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Publicity_Everyone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Publicity_Everyone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The maximum security prison's tall metal gates opened and..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Publicity_Everyone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Publicity_Everyone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_OnlyNobles == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Publicity_OnlyNobles == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_OnlyNobles == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Publicity_OnlyNobles == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Publicity_OnlyNobles == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Publicity_OnlyNobles"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The maximum security prison's tall metal gates opened and..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Publicity_OnlyNobles == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Publicity_OnlyNobles"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The maximum security prison's tall metal gates opened and..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Gesture at them to bring out the prisoners."]** — Mówca: **Player_Romus_Italic**
> "I gestured at them to bring out the prisoners. The doors of the police vehicles opened."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_Executions_Public = true; ..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "The crowd's energy was very mixed. Some of them were cheering, some of them were curious, some of them were disapproving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The Sila Orica had been placed on a balcony overlooking t..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "The maximum security prison's tall metal gates opened and a convoy of vehicles followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "The convoy was escorted on all sides by many police cars ..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "The convoy was escorted on all sides by many police cars and armored police carriers. Soon, they arrived at the Grand Garden inside Palas Rezna, where the executions were to take place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "I had gathered nearly all of the nobles in Rizia to witne..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "I had gathered nearly all of the nobles in Rizia to witness today's events. Many were in a party mood, having drinks and enjoying themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "The Sila Orica had been placed on a balcony overlooking t..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "The Sila Orica had been placed on a balcony overlooking the gardens. The police were awaiting my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus_Italic: "Gesture at them to bring out the prisoners."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Gesture at them to bring out the prisoners."]** — Mówca: **Player_Romus_Italic**
> "I gestured at them to bring out the prisoners. The doors of the police vehicles opened."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_Executions_Nobles = true; ..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The maximum security prison's tall metal gates opened and my convoy entered the prison compound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "I was escorted by many police as I made my way into the a..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "One of the two bridges connecting the island of Porte Drazon Citadel to the mainland was slowly lowered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_Everyone == true"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "I was escorted by many police as I made my way into the age-old execution chamber. The air was damp inside and the place was a little unclean for my taste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "The prison warden gave me a quick tour of the facilities ..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "The prison warden gave me a quick tour of the facilities and ensured me that no one has never escaped the Citadel before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I was led to the courtyard where the executions would tak..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "I was led to the courtyard where the executions would take place. I took a seat. The police were awaiting my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus_Italic: "Gesture for them to bring out the prisoners."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "Gesture for them to bring out the prisoners."]** — Mówca: **Player_Romus_Italic**
> "I gestured for them to bring out the prisoners. The door to the courtyard opened."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_Executions_Private = true;..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Executed == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Executed == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius"); RiziaDLC.Turn10_TotalExecu..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Executed == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Axel_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Executed == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Axel_Executed == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Axel_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Axel_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart"); RiziaDLC.Turn10_TotalExec..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Axel_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Axel_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested ..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arreste..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "AddConversant("Rico Toras"); RiziaDLC.Turn10_TotalExecuti..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Executed == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon"); RiziaDLC.Turn10_TotalExecut..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Executed == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Executed == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Executed == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "AddConversant("Russello Montoro"); RiziaDLC.Turn10_TotalE..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arres..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arres..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arr..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro"); RiziaDLC.Turn10_TotalExecu..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arr..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arr..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_A..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro"); RiziaDLC.Turn10_TotalExec..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Executed == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");
RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Executed == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");
RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Rico Toras");
RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Rico Toras");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon"); RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Executed == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Russello Montoro"); RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Russello Montoro");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arres..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro"); RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arr..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro"); RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Executed == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Electrocution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Electrocution == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_Electrocution == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Electrocution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Electrocution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Police officers lined the condemned next to the electrocu..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_Electrocution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Electrocution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_FiringSquad == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_FiringSquad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_FiringSquad == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_FiringSquad == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_FiringSquad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_FiringSquad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Police officers lined up the condemned next to the poles ..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_FiringSquad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_FiringSquad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Guillotine == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Guillotine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Guillotine == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_Guillotine == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Guillotine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Guillotine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Police officers lined up the condemned next to the toweri..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_Guillotine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Guillotine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Police officers lined up the condemned next to the gallow..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Police officers lined the condemned next to the electrocution chairs. They all had black bags on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn10_TotalExecutions == 1"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Police officers lined up the condemned next to the poles for the firing squad. They all had black bags on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn10_TotalExecutions == 1"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Police officers lined up the condemned next to the towering guillotines. They all had black bags on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn10_TotalExecutions == 1"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Police officers lined up the condemned next to the gallows. They all had black bags on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn10_TotalExecutions == 1"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "The executioner walked in after signalling the officers to leave. He was a short, pudgy-looking man. Nothing about him gave away the idea that his job was to kill people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He had an emotionless face, as if this was just a regular..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "He had an emotionless face, as if this was just a regular day for him. The same face a clerk would make when processing their taxes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "An involuntary shiver ran down my spine."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "An involuntary shiver ran down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He pulled the black bags off each inmate's head to reveal..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Calmly he came before me and bowed, waiting for my instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""I would like to speak to the death row inmates.""*)
  - -> `[71]` (*Player_Romus: ""No need to waste time.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to speak to the death row inmates.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He nodded and moved aside."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to waste time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Stress", "R_Stress_Loop");"*)

### Węzeł `[72]`
Mówca: **Narrator**
> "He nodded and moved aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "I immediately recognized the subject of my execution order, standing alongside a number of other inmates whose time had come as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The executioner walked in after signalling the officers t..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "He pulled the black bags off each inmate's head to reveal their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Calmly he came before me and bowed, waiting for my instru..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Death Row Final Words Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_AllOfYou == false"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.Hug..."*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Titus == false && RiziaDLC.Ti..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC.Pa..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Execut..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Executi..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Execu..."*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated.Ex..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Execu..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Execut..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Exec..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arr..."*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arres..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDLCI..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Executions_Rico == false && RiziaDLC.Rico_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Execut..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Exec..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Executions_Rico == false && RiziaDLC.Rico_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rico"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""Ricardus Toras.""*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Executions_Rico == false && RiziaDLC.Rico_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rico"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Executions_Axel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Execut..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Exec..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Executions_Axel == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Axel_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Axel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: ""Axel Reinhart.""*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Executions_Axel == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Axel_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Axel"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Executions_Sal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Executi..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Execu..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Executions_Sal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Sal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""Sal Ignacius.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Executions_Sal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Sal"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Executions_Manus == false && RiziaDLC.Manus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Execu..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Exe..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Executions_Manus == false && RiziaDLC.Manus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Manus"] == false  and  Variable["RiziaDLC.Manus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""Manus Sazon.""*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Executions_Manus == false && RiziaDLC.Manus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Manus"] == false  and  Variable["RiziaDLC.Manus_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Executions_Rusty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Execu..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Exe..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Executions_Rusty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rusty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""Russello Montoro.""*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Executions_Rusty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rusty"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Executions_Lucita == false && RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Exec..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Ex..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Executions_Lucita == false && RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""Lucita Azaro.""*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Executions_Lucita == false && RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true && RiziaDLCIsolated.Executions_Taddeus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arr..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_A..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true && RiziaDLCIsolated.Executions_Taddeus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Taddeus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""Taddeus Azaro.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true && RiziaDLCIsolated.Executions_Taddeus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Taddeus"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All of you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Executions_AllOfYou"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_AllOfYou = true"*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sal Ignacius.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Sal_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Sal"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Sal = true"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Manus Sazon.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Manus_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Manus"] == false  and  Variable["RiziaDLC.Manus_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Manus = true"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Axel Reinhart.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Axel_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Axel"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Axel = true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Russello Montoro.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rusty"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Rusty = true"*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ricardus Toras.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rico"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Rico = true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita Azaro.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Lucita = true;"*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taddeus Azaro.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Taddeus"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Taddeus = true;"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_AllOfYou == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_AllOfYou == false"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Executions_AllOfYou == false)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_AllOfYou == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_AllOfYou"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""All of you.""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Executions_AllOfYou == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_AllOfYou"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_AllOfYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_AllOfYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""You will all be forgotten. I will remove you from the an..."*)
  - -> `[121]` (*Player_Romus: ""You have committed grave crimes against Rizia. I hereby ..."*)
  - -> `[122]` (*Player_Romus: ""I am only doing my royal duty as the King of Rizia. I ho..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Axel = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Axel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""I have been waiting for this for a long time. I will sav..."*)
  - -> `[124]` (*Player_Romus: ""The destiny of our countries has always been to be toget..."*)
  - -> `[125]` (*Player_Romus: ""I will personally make sure your remains are transported..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Sal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Sal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Romus: ""Maybe now you will finally get to meet your dear God.""*)
  - -> `[127]` (*Player_Romus: ""You will burn in hell for an eternity for what you have ..."*)
  - -> `[128]` (*Player_Romus: ""It is truly sad to see a once-godly man indulge in such ..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Manus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""Once the heir of a great family. Now look at what your d..."*)
  - -> `[130]` (*Player_Romus: ""You share the fate of your father. Perhaps it is true th..."*)
  - -> `[129]` (*Player_Romus: ""So young. A pity, really.""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Rusty = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Rusty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Romus: ""Your gold will not save you now.""*)
  - -> `[133]` (*Player_Romus: ""Your endless greed has ended you. Ironic.""*)
  - -> `[134]` (*Player_Romus: ""This shouldn't have been your demise. I am disappointed.""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Rico = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Rico"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player_Romus: ""You dared to betray your King. The leader of your own Ho..."*)
  - -> `[220]` (*Player_Romus: ""You will burn in hell for what you did to both Rizia and..."*)
  - -> `[136]` (*Player_Romus: ""It pains me to do this to a member of my own family, but..."*)
  - -> `[135]` (*Player_Romus: ""Wiktor Smolak sends his regards.""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Lucita = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus: ""If only I could execute you twice.""*)
  - -> `[139]` (*Player_Romus: ""House Azaro will fall because of you.""*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Taddeus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""My father should have executed you long ago. Perhaps non..."*)
  - -> `[143]` (*Player_Romus: ""The only thing you have brought to your family is shame.""*)
  - -> `[141]` (*Player_Romus: ""From a great general to a death row inmate. What a sorry..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Execu..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDLCIsolated.Executions_Axel == true || RiziaDLCIsolated.Executions_Lucita == true || RiziaDLCIsolated.Executions_Manus == true || RiziaDLCIsolated.Executions_Rico == true || RiziaDLCIsolated.Executions_Rusty == true || RiziaDLCIsolated.Executions_Sal == true || RiziaDLCIsolated.Executions_Taddeus == true || RiziaDLCIsolated.Executions_Pabel == true || RiziaDLCIsolated.Executions_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDLCI..."*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDL..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDLCIsolated.Executions_Axel == true || RiziaDLCIsolated.Executions_Lucita == true || RiziaDLCIsolated.Executions_Manus == true || RiziaDLCIsolated.Executions_Rico == true || RiziaDLCIsolated.Executions_Rusty == true || RiziaDLCIsolated.Executions_Sal == true || RiziaDLCIsolated.Executions_Taddeus == true || RiziaDLCIsolated.Executions_Pabel == true || RiziaDLCIsolated.Executions_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_AllOfYou"] == true  or  Variable["RiziaDLCIsolated.Executions_Axel"] == true  or  Variable["RiziaDLCIsolated.Executions_Lucita"] == true  or  Variable["RiziaDLCIsolated.Executions_Manus"] == true  or  Variable["RiziaDLCIsolated.Executions_Rico"] == true  or  Variable["RiziaDLCIsolated.Executions_Rusty"] == true  or  Variable["RiziaDLCIsolated.Executions_Sal"] == true  or  Variable["RiziaDLCIsolated.Executions_Taddeus"] == true  or  Variable["RiziaDLCIsolated.Executions_Pabel"] == true  or  Variable["RiziaDLCIsolated.Executions_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""I won't waste my breath on you people anymore.""*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDLCIsolated.Executions_Axel == true || RiziaDLCIsolated.Executions_Lucita == true || RiziaDLCIsolated.Executions_Manus == true || RiziaDLCIsolated.Executions_Rico == true || RiziaDLCIsolated.Executions_Rusty == true || RiziaDLCIsolated.Executions_Sal == true || RiziaDLCIsolated.Executions_Taddeus == true || RiziaDLCIsolated.Executions_Pabel == true || RiziaDLCIsolated.Executions_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_AllOfYou"] == true  or  Variable["RiziaDLCIsolated.Executions_Axel"] == true  or  Variable["RiziaDLCIsolated.Executions_Lucita"] == true  or  Variable["RiziaDLCIsolated.Executions_Manus"] == true  or  Variable["RiziaDLCIsolated.Executions_Rico"] == true  or  Variable["RiziaDLCIsolated.Executions_Rusty"] == true  or  Variable["RiziaDLCIsolated.Executions_Sal"] == true  or  Variable["RiziaDLCIsolated.Executions_Taddeus"] == true  or  Variable["RiziaDLCIsolated.Executions_Pabel"] == true  or  Variable["RiziaDLCIsolated.Executions_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't waste my breath on you people anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Executions_AllOfYou"] == true  or  Variable["RiziaDLCIsolated.Executions_Axel"] == true  or  Variable["RiziaDLCIsolated.Executions_Lucita"] == true  or  Variable["RiziaDLCIsolated.Executions_Manus"] == true  or  Variable["RiziaDLCIsolated.Executions_Rico"] == true  or  Variable["RiziaDLCIsolated.Executions_Rusty"] == true  or  Variable["RiziaDLCIsolated.Executions_Sal"] == true  or  Variable["RiziaDLCIsolated.Executions_Taddeus"] == true  or  Variable["RiziaDLCIsolated.Executions_Pabel"] == true  or  Variable["RiziaDLCIsolated.Executions_Titus"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Stress", "R_Stress_Loop");"*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will all be forgotten. I will remove you from the annals of history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have committed grave crimes against Rizia. I hereby punish you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am only doing my royal duty as the King of Rizia. I hope you will use these last moments to repent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have been waiting for this for a long time. I will savor every second of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Axel Reinhart: ""I have lost... everything.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The destiny of our countries has always been to be together. Yet, here we are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Axel Reinhart: ""I have lost... everything.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will personally make sure your remains are transported back to your relatives in Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Axel Reinhart: ""I have lost... everything.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe now you will finally get to meet your dear God.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Sal Ignacius: ""Curse you and your family, Romus the First. You deserve ..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will burn in hell for an eternity for what you have done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Sal Ignacius: ""Curse you and your family, Romus the First. You deserve ..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is truly sad to see a once-godly man indulge in such crimes against the crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Sal Ignacius: ""Curse you and your family, Romus the First. You deserve ..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So young. A pity, really.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Manus Sazon: ""Your time will come as well, King Romus. This will only ..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You share the fate of your father. Perhaps it is true that nothing good comes out of House Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Manus Sazon: ""Your time will come as well, King Romus. This will only ..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Once the heir of a great family. Now look at what your dynasty has come to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Manus Sazon: ""Your time will come as well, King Romus. This will only ..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your gold will not save you now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Russello Montoro: ""You're making a mistake, Your Majesty. Do you know the f..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your endless greed has ended you. Ironic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Russello Montoro: ""You're making a mistake, Your Majesty. Do you know the f..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This shouldn't have been your demise. I am disappointed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Russello Montoro: ""You're making a mistake, Your Majesty. Do you know the f..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wiktor Smolak sends his regards.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Rico Toras: ""Shut up and get it over with, cousin.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It pains me to do this to a member of my own family, but your incompetence and treason have left me with no choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Rico Toras: ""Shut up and get it over with, cousin.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You dared to betray your King. The leader of your own House! You deserve this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Rico Toras: ""Shut up and get it over with, cousin.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Luce. It's nothing personal.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Kontekst wejściowy (poprzednik):** `[103]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "She stared at me, every muscle in her body practically vi..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Azaro will fall because of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "She stared at me, every muscle in her body practically vi..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If only I could execute you twice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "She stared at me, every muscle in her body practically vi..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From a great general to a death row inmate. What a sorry sight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father should have executed you long ago. Perhaps none of this would have happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only thing you have brought to your family is shame.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)

### Węzeł `[144]`
Mówca: **Taddeus Azaro**
> ""I accept my fate, Your Majesty. I apologize for failing you and this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "He looked defeated and weak."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "She stared at me, every muscle in her body practically vibrating with constrained rage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Lucita Azaro: ""Fuck off, Your Majesty.""*)

### Węzeł `[146]`
Mówca: **Rico Toras**
> ""Shut up and get it over with, cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He did not dare look into my eyes."*)

### Węzeł `[147]`
Mówca: **Russello Montoro**
> ""You're making a mistake, Your Majesty. Do you know the fortune that awaits you if you let me go? We could make billions together!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "On seeing my impassive face, he abruptly assumed a pleadi..."*)

### Węzeł `[148]`
Mówca: **Manus Sazon**
> ""Your time will come as well, King Romus. This will only fuel the people's rage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[149]`
Mówca: **Sal Ignacius**
> ""Curse you and your family, Romus the First. You deserve to die the same death that your father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He spit on the ground."*)

### Węzeł `[150]`
Mówca: **Axel Reinhart**
> ""I have lost... everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "He fell on his knees on the ground. The guards helped him..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "He fell on his knees on the ground. The guards helped him up on his feet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He spit on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "He looked proud and unfazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[154]`
Mówca: **Narrator**
> "On seeing my impassive face, he abruptly assumed a pleading tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Russello Montoro: ""Please, Your Majesty.... I mean it. I'll do anything... ..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "He did not dare look into my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "The venom in her voice almost made me take a step back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[157]`
Mówca: **Narrator**
> "He looked defeated and weak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "The executioner looked at me for the final order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus_Italic: "Gesture for the executions to start."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "Gesture for the executions to start."]** — Mówca: **Player_Romus_Italic**
> "I gestured at him to begin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "With an off-putting smile, he moved over to the line. The..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "With an off-putting smile, he moved over to the line. The guards followed his lead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Electrocution == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Electrocution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Electrocution == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_Electrocution == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Electrocution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Electrocution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Soon after, all of them were tied to the electric chairs."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_Electrocution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Electrocution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_FiringSquad == true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_FiringSquad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_FiringSquad == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_FiringSquad == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_FiringSquad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_FiringSquad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Soon after, all of them were tied to the poles."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_FiringSquad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_FiringSquad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Guillotine == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Guillotine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Guillotine == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_Guillotine == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Guillotine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Guillotine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Soon after, all of them kneeling under the sharp blade of..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_Guillotine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Guillotine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Soon after, all of them were on the gallows with ropes ar..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Soon after, all of them were tied to the electric chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Their heads were shaved and wetted with a sponge dipped i..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Their heads were shaved and wetted with a sponge dipped in a bucket of water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Their final rites were read to them as well as prayers fo..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Soon after, all of them were tied to the poles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Their eyes were blindfolded."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Their eyes were blindfolded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Their final rites were read to them as well as prayers fo..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "Soon after, all of them kneeling under the sharp blade of the guillotine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "They could not even look up to see."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "They could not even look up to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Their final rites were read to them as well as prayers fo..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Soon after, all of them were on the gallows with ropes around their necks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Their hands were kept cuffed."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Their hands were kept cuffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Their final rites were read to them as well as prayers fo..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Their final rites were read to them as well as prayers for the ones who requested it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "The executioner held his hand up to signal."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "The executioner held his hand up to signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus: ""Do it.""*)
  - -> `[189]` (*Player_Romus: ""Halaita.""*)
  - -> `[188]` (*Player_Romus: ""I will see you all in hell.""*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will see you all in hell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "His hand went down and the signal was given."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "His hand went down and the signal was given."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Electrocution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Electrocution == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_Electrocution == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Electrocution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Electrocution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ElectricChair");"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_Electrocution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Electrocution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_FiringSquad == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_FiringSquad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_FiringSquad == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_FiringSquad == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_FiringSquad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_FiringSquad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("FiringSquad");"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_FiringSquad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_FiringSquad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Guillotine == true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Guillotine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Guillotine == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Method_Guillotine == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Method_Guillotine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Guillotine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Guillotine");"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Method_Guillotine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Guillotine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("HangingExecution");"*)

### Węzeł `[200]`
Mówca: **Narrator**
> "His hand went down and the signal was given."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Electrocution == true"*)

### Węzeł `[201]`
Mówca: **Narrator**
> "The lever was turned all the way up and the voltage was increased to maximum. A terrible smell filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_Everyone == true"*)

### Węzeł `[202]`
Mówca: **Narrator**
> "They were no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Executions = true"*)

### Węzeł `[203]`
Mówca: **Narrator**
> "The firing squad loaded their rifles, pointed and shot at the prisoners in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_Everyone == true"*)

### Węzeł `[204]`
Mówca: **Narrator**
> "The rope was cut and the huge blades of the guillotines made their way down. Blood gushed from the prisoners' necks as their heads rolled into the baskets in front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_Everyone == true"*)

### Węzeł `[205]`
Mówca: **Narrator**
> "The rope was cut and the wooden board beneath the prisoners' feet gave way. Some of their necks snapped immediately; others clutched at their throats, struggling for breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_Everyone == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Publicity_Everyone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_Everyone == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Publicity_Everyone == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Publicity_Everyone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Publicity_Everyone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "The entire plaza let out a collective gasp. Camera flashe..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Publicity_Everyone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Publicity_Everyone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_OnlyNobles == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Publicity_OnlyNobles == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Publicity_OnlyNobles == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Executions_Publicity_OnlyNobles == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Executions_Publicity_OnlyNobles == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Executions_Publicity_OnlyNobles"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "The nobles let out a collective gasp. I felt that they we..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Executions_Publicity_OnlyNobles == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Executions_Publicity_OnlyNobles"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "After a short while, the jerking motions of the lifeless ..."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "After a short while, the jerking motions of the lifeless bodies stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "They were no more."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "The entire plaza let out a collective gasp. Camera flashes went off. Then slowly, clapping began from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "After a short while, the jerking motions of the lifeless ..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "The nobles let out a collective gasp. I felt that they were looking at me in a new light. I was more feared and respected now than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "After a short while, the jerking motions of the lifeless ..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Executed == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "AddConversant("Pabel Adria"); RiziaDLC.Turn10_TotalExecut..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested ..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Pabel Adria");
RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Pabel Adria");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested ..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will burn in hell for what you did to both Rizia and Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Rico Toras: ""Shut up and get it over with, cousin.""*)

### Węzeł `[221]`
Mówca: **Russello Montoro**
> ""Please, Your Majesty.... I mean it. I'll do anything... Anything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[222]`
Mówca: **Manus Sazon**
> ""And that of your own daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "He looked proud and unfazed."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Manus Sazon: ""And that of your own daughter.""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "He looked proud and unfazed."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RomanceHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RomanceHappened == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RomanceHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus: ""I'm sorry, Luce. It's nothing personal.""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RomanceHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Romus: ""You earned my respect, only to betray me. What do you ha..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn10_TotalExecutions == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn10_TotalExecutions == 1"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn10_TotalExecutions == 1)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn10_TotalExecutions == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn10_TotalExecutions"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "I immediately recognized the subject of my execution orde..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn10_TotalExecutions == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn10_TotalExecutions"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "I immediately recognized the subjects of my execution ord..."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "I immediately recognized the subjects of my execution order, standing alongside a number of other inmates whose time had come as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The executioner walked in after signalling the officers t..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You earned my respect, only to betray me. What do you have to say for yourself?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[103]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "She stared at me, every muscle in her body practically vi..."*)

### Węzeł `[234]`
Mówca: **Lucita Azaro**
> ""Fuck off, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "The venom in her voice almost made me take a step back."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC.Pabel_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC.Pa..."*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC...."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC.Pabel_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_Pabel"] == false  and  Variable["RiziaDLC.Pabel_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player_Romus: ""Pabel Adria.""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC.Pabel_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_Pabel"] == false  and  Variable["RiziaDLC.Pabel_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel Adria.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Executions_Pabel"] == false  and  Variable["RiziaDLC.Pabel_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Pabel = true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Pabel = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Pabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[244]` (*Player_Romus: ""Where is my daughter?""*)
  - -> `[255]` (*Player_Romus: ""For humiliating the Royal Family of Rizia, you will pay ..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bi mare volu...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Kontekst wejściowy (poprzednik):** `[238]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "He shook his head."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""Bi mare volu...""*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""I wish this had gone differently.""*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where is my daughter?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Pabel Adria: ""Far away from you.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish this had gone differently.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[238]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Pabel Adria: ""So do I, Your Majesty.""*)

### Węzeł `[246]`
Mówca: **Pabel Adria**
> ""Far away from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[247]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Pabel Adria: ""You've changed, Romus.""*)

### Węzeł `[248]`
Mówca: **Pabel Adria**
> ""You've changed, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "He took a last, regretful look at me as the hood was plac..."*)

### Węzeł `[249]`
Mówca: **Pabel Adria**
> ""So do I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "He took a last, regretful look at me as the hood was plac..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Pabel Adria: ""I'm sorry, Rom. But you've changed.""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Pabel Adria: ""My loyalty had its limits, Your Majesty. You found them.""*)

### Węzeł `[253]`
Mówca: **Pabel Adria**
> ""I'm sorry, Rom. But you've changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "He took a last, regretful look at me as the hood was plac..."*)

### Węzeł `[254]`
Mówca: **Pabel Adria**
> ""My loyalty had its limits, Your Majesty. You found them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "He took a last, regretful look at me as the hood was plac..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For humiliating the Royal Family of Rizia, you will pay the ultimate price.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "He shook his head."*)

### Węzeł `[256]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Pabel Adria: ""I am not the humiliation here.""*)

### Węzeł `[257]`
Mówca: **Pabel Adria**
> ""I am not the humiliation here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "He took a last, regretful look at me as the hood was plac..."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "He took a last, regretful look at me as the hood was placed back on his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Executed == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Executed == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion"); RiziaDLC.Turn10_TotalExec..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_A..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion"); RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_A..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Titus == false && RiziaDLC.Titus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Titus == false && RiziaDLC.Ti..."*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Executions_Titus == false && RiziaDLC...."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Titus == false && RiziaDLC.Titus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_Titus"] == false  and  Variable["RiziaDLC.Titus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""Titus Gordion.""*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Executions_Titus == false && RiziaDLC.Titus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_Titus"] == false  and  Variable["RiziaDLC.Titus_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus Gordion.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Executions_Titus"] == false  and  Variable["RiziaDLC.Titus_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Titus = true"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Titus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Titus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""You bit the hand that fed you.""*)
  - -> `[269]` (*Player_Romus: ""To think that I trusted you with the security of me and ..."*)
  - -> `[271]` (*Player_Romus: ""May you burn in hell.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To think that I trusted you with the security of me and my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Titus Gordion: ""To think that I trusted you with leading this country.""*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You bit the hand that fed you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Titus Gordion: ""The only thing you could feed people with is poison, You..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May you burn in hell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Titus Gordion: ""Alongside you, sir.""*)

### Węzeł `[272]`
Mówca: **Titus Gordion**
> ""Alongside you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "He stood defiant and emotionless."*)

### Węzeł `[273]`
Mówca: **Titus Gordion**
> ""To think that I trusted you with leading this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "He stood defiant and emotionless."*)

### Węzeł `[274]`
Mówca: **Titus Gordion**
> ""The only thing you could feed people with is poison, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "He stood defiant and emotionless."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "He stood defiant and emotionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Executions_Titus = true;"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Executions_Titus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Executions_Titus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "One of the two bridges connecting the island of Porte Dra..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Stress", "R_Stress_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Stress","R_Stress_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "The executioner looked at me for the final order."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested ..."*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arreste..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras"); RiziaDLC.Turn10_TotalExecuti..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Executed == true"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");
RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Executed == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.Hug..."*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.H..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""Hugo Toras.""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo Toras.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Executions_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Hugo = true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Hugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player_Romus: ""You were almost a father to me...""*)
  - -> `[289]` (*Player_Romus: ""You are not worthy of the Toras name.""*)
  - -> `[291]` (*Player_Romus: ""May you meet my father in hell.""*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true"*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are not worthy of the Toras name.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Hugo Toras: ""Everything I ever did was for our house. But I worry it ..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were almost a father to me...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Hugo Toras: ""And you were almost a son...""*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May you meet my father in hell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Hugo Toras: ""We will wait for you to join us.""*)

### Węzeł `[292]`
Mówca: **Hugo Toras**
> ""We will wait for you to join us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He had the look of a broken man. He lowered his eyes and ..."*)

### Węzeł `[293]`
Mówca: **Hugo Toras**
> ""Everything I ever did was for our house. But I worry it has all been for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He had the look of a broken man. He lowered his eyes and ..."*)

### Węzeł `[294]`
Mówca: **Hugo Toras**
> ""And you were almost a son...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He had the look of a broken man. He lowered his eyes and ..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "He had the look of a broken man. He lowered his eyes and said no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Executions_Hugo = true;"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Executions_Hugo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Executions_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_Executions_Public = true;
RiziaDLCSupport.News_Turn10_V_Excecutions_Public = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Public"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_Excecutions_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_Executions_Nobles = true;
RiziaDLCSupport.News_Turn10_V_Excecutions_Nobles = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Nobles"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_Excecutions_Nobles"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_Executions_Private = true;
RiziaDLCSupport.News_Turn10_V_Excecutions_Private = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Private"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_Excecutions_Private"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Executed == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Iza_RicoExecuted = true; R..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Executed == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Iza_ManusExecuted = true; ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Executed == true"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Executed == true"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Executed == true)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Lespia_RustyExecuted = tru..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"]  or  Variable["RiziaDLC.Lucita_Executed"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Montaklar_AzaroExecuted = ..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"]  or  Variable["RiziaDLC.Lucita_Executed"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Monqiz_HugoExecuted = true..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgs..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgsland_Friendly == false && RiziaDLC.CountryRelation_Valgsland_Allied == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgs..."*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Val..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgsland_Friendly == false && RiziaDLC.CountryRelation_Valgsland_Allied == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Executed"]  and  Variable["RiziaDLC.CountryRelation_Valgsland_Friendly"] == false  and  Variable["RiziaDLC.CountryRelation_Valgsland_Allied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Valgsland_PabelExecuted = ..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgsland_Friendly == false && RiziaDLC.CountryRelation_Valgsland_Allied == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Executed"]  and  Variable["RiziaDLC.CountryRelation_Valgsland_Friendly"] == false  and  Variable["RiziaDLC.CountryRelation_Valgsland_Allied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Executed == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Executed == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Council_SalIgnacius_Executed..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Executed == true"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Iza_RicoExecuted = true;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableCodexEntry("Characters_Family_RicoToras_Executed");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Iza_RicoExecuted"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableCodexEntry("Characters_Family_RicoToras_Executed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Iza_ManusExecuted = true;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableCodexEntry("Characters_PartyLeaders_ManusSazon_Executed");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Iza_ManusExecuted"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableCodexEntry("Characters_PartyLeaders_ManusSazon_Executed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Executed == true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Lespia_RustyExecuted = true;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableCodexEntry("Characters_Business_RustyMontoro_Executed");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Lespia_RustyExecuted"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableCodexEntry("Characters_Business_RustyMontoro_Executed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Montaklar_AzaroExecuted = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Montaklar_AzaroExecuted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Monqiz_HugoExecuted = true;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableCodexEntry("Characters_Council_HugoToras_Executed");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Monqiz_HugoExecuted"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableCodexEntry("Characters_Council_HugoToras_Executed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgs..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Valgsland_PabelExecuted = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Valgsland_PabelExecuted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Council_SalIgnacius_Executed");

RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Council_SalIgnacius_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Executed == true"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("ElectricChair");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("ElectricChair");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "The lever was turned all the way up and the voltage was i..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("FiringSquad");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("FiringSquad");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "The firing squad loaded their rifles, pointed and shot at..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Guillotine");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Guillotine");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "The rope was cut and the huge blades of the guillotines m..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("HangingExecution");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("HangingExecution");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "The rope was cut and the wooden board beneath the prisone..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Council_TaddeusAzaro_Execute..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == true)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Council_LucitaAzaro_Executed..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Council_TaddeusAzaro_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Council_TaddeusAzaro_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Council_LucitaAzaro_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Council_LucitaAzaro_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Executed`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Executed"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Executed )"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Executed`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Executed"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Others_PabelAdria_Executed")..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Executed )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Executed"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Executed == true"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Others_PabelAdria_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Others_PabelAdria_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Executed == true"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Executed == true"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Executed == true)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Others_TitusGordion_Executed..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Executed == true"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Others_TitusGordion_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Others_TitusGordion_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Executed == true"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Axel_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Executed == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Axel_Executed == true)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Axel_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Axel_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Axel_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Axel_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn10_TotalExecutions >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn10_TotalExecutions >= 5"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn10_TotalExecutions >= 5)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn10_TotalExecutions >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn10_TotalExecutions"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_Executions");"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn10_TotalExecutions >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn10_TotalExecutions"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_Executions");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_Executions");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "His hand went down and the signal was given."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true"*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Executed == true)"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Player_Romus: ""Fitting, isn't it? For you and your failure of a son to ..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fitting, isn't it? For you and your failure of a son to die together.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rico_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[287]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Hugo Toras: ""I beg you, Romus. Kill me if you must, but spare my boy...""*)

### Węzeł `[363]`
Mówca: **Hugo Toras**
> ""I beg you, Romus. Kill me if you must, but spare my boy...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He had the look of a broken man. He lowered his eyes and ..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_A..."*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLC.Angelica_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "AddConversant("Angelica Sazon"); RiziaDLC.Turn10_TotalExe..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLC.Angelica_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arres..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Angelica Sazon"); RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Angelica Sazon");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arres..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arres..."*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arr..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "AddConversant("Adarfo Sotelato"); RiziaDLC.Turn10_TotalEx..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Electrocution == true"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Adarfo Sotelato"); RiziaDLC.Turn10_TotalExecutions += 1`
- **Efekt skryptowy (`userScript`):** `AddConversant("Adarfo Sotelato");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Executions_Method_Electrocution == true"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated.Executions_Angelica == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated.Ex..."*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated...."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated.Executions_Angelica == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Angelica"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Player_Romus: ""Angelica Sazon.""*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated.Executions_Angelica == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Angelica"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Angelica Sazon.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Angelica"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Angelica = true"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Angelica = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Angelica"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true"*)
  - -> `[378]` (*Player_Romus: ""My father should have done this years ago.""*)
  - -> `[377]` (*Player_Romus: ""I gave you a chance to redeem yourself, and you abused i..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I gave you a chance to redeem yourself, and you abused it. Your punishment is well earned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Angelica Sazon: ""I regret nothing.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father should have done this years ago.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Angelica Sazon: ""I regret nothing.""*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How fitting for you to die alongside your son. Your treacherous legacy ends today.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Manus_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[375]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Angelica Sazon: ""I regret nothing.""*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Executed == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player_Romus: ""How fitting for you to die alongside your son. Your trea..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Player_Romus: ""A pity you couldn't fall in line like your son did. Your..."*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pity you couldn't fall in line like your son did. Your treachery ends today.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Manus_Executed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[375]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Angelica Sazon: ""I regret nothing.""*)

### Węzeł `[384]`
Mówca: **Angelica Sazon**
> ""I regret nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Angelica Sazon: ""This is not the end of House Sazon. Rizia's noblest fami..."*)

### Węzeł `[385]`
Mówca: **Angelica Sazon**
> ""This is not the end of House Sazon. Rizia's noblest family will survive the tyranny of Romus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true && RiziaDLCIsolated.Executions_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arres..."*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arr..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true && RiziaDLCIsolated.Executions_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Player_Romus: ""Adarfo Sotelato.""*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true && RiziaDLCIsolated.Executions_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Adarfo"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Adarfo Sotelato.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Adarfo"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator), `[157]` (Narrator), `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Executions_Adarfo = true;"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Executions_Adarfo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player_Romus: ""Your revolution has failed, like so many others before it.""*)
  - -> `[394]` (*Player_Romus: ""This is your last chance. Acknowledge me as your rightfu..."*)
  - -> `[392]` (*Player_Romus: ""You're a sham. You never truly wanted to make people's l..."*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're a sham. You never truly wanted to make people's lives better. You only wanted to seize power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Adarfo Sotelato: ""I cannot take these words seriously coming from an absol..."*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your revolution has failed, like so many others before it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Adarfo Sotelato: ""It lives on in the hearts of the Rizian people. One day ..."*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is your last chance. Acknowledge me as your rightful king, and I'll clear you of all charges.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Adarfo Sotelato: ""You don't mean that. But even if you did, I would gladly..."*)

### Węzeł `[395]`
Mówca: **Adarfo Sotelato**
> ""You don't mean that. But even if you did, I would gladly accept death before bowing to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "He held his head high."*)

### Węzeł `[396]`
Mówca: **Adarfo Sotelato**
> ""It lives on in the hearts of the Rizian people. One day -- sooner than you think -- they will have their vengeance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "He held his head high."*)

### Węzeł `[397]`
Mówca: **Adarfo Sotelato**
> ""I cannot take these words seriously coming from an absolute monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "He held his head high."*)

### Węzeł `[398]`
Mówca: **Narrator**
> "He held his head high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death Row Final Words Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Death Row Final Words Hub"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Executions = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Executions"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Angelica_Executed == true)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Others_AngelicaSazon_Execute..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Angelica_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Others_AngelicaSazon_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Others_AngelicaSazon_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Executed == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_Died");
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_Died");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Execu..."*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Exe..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Player_Romus: ""Look over there at your daughter. The all-powerful House..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look over there at your daughter. The all-powerful House of Azaro has been reduced to nothing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[104]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Narrator: "His eyes filled with tears. He moved his lips, but no wor..."*)

### Węzeł `[413]`
Mówca: **Narrator**
> "His eyes filled with tears. He moved his lips, but no words came out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseAzaro_Conquered == true)"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Taddeus Azaro: ""Your hubris will be your downfall. House Azaro will not ..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseAzaro_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Taddeus Azaro: ""I accept my fate, Your Majesty. I apologize for failing ..."*)

### Węzeł `[417]`
Mówca: **Taddeus Azaro**
> ""Your hubris will be your downfall. House Azaro will not go down that easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "He tried to project defiance, but there was defeat in his..."*)

### Węzeł `[418]`
Mówca: **Narrator**
> "He tried to project defiance, but there was defeat in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death Row Final Words Hub]"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Exec..."*)
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_AzarosDead");"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn10_TotalExecutions >= 5"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_AzarosDead");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_AzarosDead");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn10_TotalExecutions >= 5"*)
