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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 17
- **Węzły modyfikujące stan gry:** 56

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[46]` (Paskal Beniwoll): `AddConversant("Sal Ignacius"); Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.T...`
- Węzeł `[47]` (Paskal Beniwoll): `AddConversant("Axel Reinhart"); Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC....`
- Węzeł `[48]` (Paskal Beniwoll): `AddConversant("Rico Toras"); Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Tur...`
- Węzeł `[49]` (Paskal Beniwoll): `AddConversant("Manus Sazon"); Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Tu...`
- Węzeł `[50]` (Paskal Beniwoll): `AddConversant("Russello Montoro"); Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaD...`
- Węzeł `[51]` (Paskal Beniwoll): `AddConversant("Lucita Azaro"); Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.T...`
- Węzeł `[52]` (Paskal Beniwoll): `AddConversant("Taddeus Azaro"); Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC....`
- Węzeł `[108]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Executions_AllOfYou"] = true;`
- *...oraz 48 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The maximum security prison's tall metal gates opened and a convoy of vehicles followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The convoy was escorted on all sides by many police cars and armored police carriers. Soon, they arrived at Plaza Drazia, a square in the city center where public executions traditionally took place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The Sila Orica had been placed on a balcony overlooking the plaza. The police were awaiting for my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Publicity_Everyone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Publicity_Everyone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Publicity_Everyone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Publicity_Everyone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Publicity_Everyone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Publicity_OnlyNobles == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Publicity_OnlyNobles == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Publicity_OnlyNobles"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Publicity_OnlyNobles == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Publicity_OnlyNobles"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Gesture at them to bring out the prisoners."]** — Mówca: **Player_Romus_Italic**
> "I gestured at them to bring out the prisoners. The doors of the police vehicles opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[13]`
Mówca: **Narrator**
> "The crowd's energy was very mixed. Some of them were cheering, some of them were curious, some of them were disapproving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[14]`
Mówca: **Narrator**
> "The maximum security prison's tall metal gates opened and a convoy of vehicles followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "The convoy was escorted on all sides by many police cars and armored police carriers. Soon, they arrived at the Grand Garden inside Palas Rezna, where the executions were to take place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "I had gathered nearly all of the nobles in Rizia to witness today's events. Many were in a party mood, having drinks and enjoying themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "The Sila Orica had been placed on a balcony overlooking the gardens. The police were awaiting my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Gesture at them to bring out the prisoners."]** — Mówca: **Player_Romus_Italic**
> "I gestured at them to bring out the prisoners. The doors of the police vehicles opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The maximum security prison's tall metal gates opened and my convoy entered the prison compound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Narrator**
> "One of the two bridges connecting the island of Porte Drazon Citadel to the mainland was slowly lowered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[21]`
Mówca: **Narrator**
> "I was escorted by many police as I made my way into the age-old execution chamber. The air was damp inside and the place was a little unclean for my taste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "The prison warden gave me a quick tour of the facilities and ensured me that no one has never escaped the Citadel before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "I was led to the courtyard where the executions would take place. I took a seat. The police were awaiting my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "Gesture for them to bring out the prisoners."]** — Mówca: **Player_Romus_Italic**
> "I gestured for them to bring out the prisoners. The door to the courtyard opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Axel_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Axel_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Axel_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Axel_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Axel_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Executed == true && RiziaDLC.Rico_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");
RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");
RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Rico Toras");
RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Rico Toras");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon"); RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Russello Montoro"); RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Russello Montoro");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro"); RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Taddeus Azaro"); RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Taddeus Azaro");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Electrocution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Electrocution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Electrocution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_Electrocution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Electrocution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_FiringSquad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_FiringSquad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_FiringSquad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_FiringSquad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_FiringSquad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Guillotine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Guillotine == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Guillotine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_Guillotine == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Guillotine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Police officers lined the condemned next to the electrocution chairs. They all had black bags on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Police officers lined up the condemned next to the poles for the firing squad. They all had black bags on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[64]`
Mówca: **Narrator**
> "Police officers lined up the condemned next to the towering guillotines. They all had black bags on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Police officers lined up the condemned next to the gallows. They all had black bags on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[66]`
Mówca: **Narrator**
> "The executioner walked in after signalling the officers to leave. He was a short, pudgy-looking man. Nothing about him gave away the idea that his job was to kill people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "He had an emotionless face, as if this was just a regular day for him. The same face a clerk would make when processing their taxes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "An involuntary shiver ran down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Calmly he came before me and bowed, waiting for my instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to speak to the death row inmates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to waste time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[72]`
Mówca: **Narrator**
> "He nodded and moved aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Narrator**
> "I immediately recognized the subject of my execution order, standing alongside a number of other inmates whose time had come as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[74]`
Mówca: **Narrator**
> "He pulled the black bags off each inmate's head to reveal their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Death Row Final Words Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[284]`
  - -> `[264]`
  - -> `[235]`
  - -> `[79]`
  - -> `[82]`
  - -> `[85]`
  - -> `[372]`
  - -> `[88]`
  - -> `[76]`
  - -> `[91]`
  - -> `[94]`
  - -> `[387]`
  - -> `[116]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Executions_Rico == false && RiziaDLC.Rico_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Executions_Rico == false && RiziaDLC.Rico_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rico"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Executed == true && RiziaDLCIsolated.Executions_Rico == false && RiziaDLC.Rico_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rico"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Executions_Axel == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Executions_Axel == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Axel_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Axel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Axel_Executed == true && RiziaDLCIsolated.Executions_Axel == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Axel_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Axel"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Executions_Sal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Executions_Sal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Sal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Executed == true && RiziaDLCIsolated.Executions_Sal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Sal"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Executions_Manus == false && RiziaDLC.Manus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Executions_Manus == false && RiziaDLC.Manus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Manus"] == false  and  Variable["RiziaDLC.Manus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Executed == true && RiziaDLCIsolated.Executions_Manus == false && RiziaDLC.Manus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Manus"] == false  and  Variable["RiziaDLC.Manus_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Executions_Rusty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Executions_Rusty == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rusty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Executed == true && RiziaDLCIsolated.Executions_Rusty == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Rusty"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Executions_Lucita == false && RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Executions_Lucita == false && RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == true && RiziaDLCIsolated.Executions_Lucita == false && RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true && RiziaDLCIsolated.Executions_Taddeus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true && RiziaDLCIsolated.Executions_Taddeus == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Taddeus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Taddeus_Arrested == true && RiziaDLCIsolated.Executions_Taddeus == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Taddeus"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sal Ignacius.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Manus Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Axel Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Russello Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ricardus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taddeus Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_AllOfYou == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_AllOfYou == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_AllOfYou"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Executions_AllOfYou == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_AllOfYou"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_AllOfYou = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_AllOfYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`
  - -> `[122]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Axel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Axel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`
  - -> `[125]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Sal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Sal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`
  - -> `[128]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Manus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[130]`
  - -> `[129]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Rusty = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Rusty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Rico = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Rico"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[220]`
  - -> `[136]`
  - -> `[135]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Lucita = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[139]`
  - -> `[226]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Taddeus = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`
  - -> `[141]`
  - -> `[409]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDLCIsolated.Executions_Axel == true || RiziaDLCIsolated.Executions_Lucita == true || RiziaDLCIsolated.Executions_Manus == true || RiziaDLCIsolated.Executions_Rico == true || RiziaDLCIsolated.Executions_Rusty == true || RiziaDLCIsolated.Executions_Sal == true || RiziaDLCIsolated.Executions_Taddeus == true || RiziaDLCIsolated.Executions_Pabel == true || RiziaDLCIsolated.Executions_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDLCIsolated.Executions_Axel == true || RiziaDLCIsolated.Executions_Lucita == true || RiziaDLCIsolated.Executions_Manus == true || RiziaDLCIsolated.Executions_Rico == true || RiziaDLCIsolated.Executions_Rusty == true || RiziaDLCIsolated.Executions_Sal == true || RiziaDLCIsolated.Executions_Taddeus == true || RiziaDLCIsolated.Executions_Pabel == true || RiziaDLCIsolated.Executions_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_AllOfYou"] == true  or  Variable["RiziaDLCIsolated.Executions_Axel"] == true  or  Variable["RiziaDLCIsolated.Executions_Lucita"] == true  or  Variable["RiziaDLCIsolated.Executions_Manus"] == true  or  Variable["RiziaDLCIsolated.Executions_Rico"] == true  or  Variable["RiziaDLCIsolated.Executions_Rusty"] == true  or  Variable["RiziaDLCIsolated.Executions_Sal"] == true  or  Variable["RiziaDLCIsolated.Executions_Taddeus"] == true  or  Variable["RiziaDLCIsolated.Executions_Pabel"] == true  or  Variable["RiziaDLCIsolated.Executions_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Executions_AllOfYou == true || RiziaDLCIsolated.Executions_Axel == true || RiziaDLCIsolated.Executions_Lucita == true || RiziaDLCIsolated.Executions_Manus == true || RiziaDLCIsolated.Executions_Rico == true || RiziaDLCIsolated.Executions_Rusty == true || RiziaDLCIsolated.Executions_Sal == true || RiziaDLCIsolated.Executions_Taddeus == true || RiziaDLCIsolated.Executions_Pabel == true || RiziaDLCIsolated.Executions_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_AllOfYou"] == true  or  Variable["RiziaDLCIsolated.Executions_Axel"] == true  or  Variable["RiziaDLCIsolated.Executions_Lucita"] == true  or  Variable["RiziaDLCIsolated.Executions_Manus"] == true  or  Variable["RiziaDLCIsolated.Executions_Rico"] == true  or  Variable["RiziaDLCIsolated.Executions_Rusty"] == true  or  Variable["RiziaDLCIsolated.Executions_Sal"] == true  or  Variable["RiziaDLCIsolated.Executions_Taddeus"] == true  or  Variable["RiziaDLCIsolated.Executions_Pabel"] == true  or  Variable["RiziaDLCIsolated.Executions_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't waste my breath on you people anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will all be forgotten. I will remove you from the annals of history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have committed grave crimes against Rizia. I hereby punish you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am only doing my royal duty as the King of Rizia. I hope you will use these last moments to repent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have been waiting for this for a long time. I will savor every second of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The destiny of our countries has always been to be together. Yet, here we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will personally make sure your remains are transported back to your relatives in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe now you will finally get to meet your dear God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will burn in hell for an eternity for what you have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is truly sad to see a once-godly man indulge in such crimes against the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So young. A pity, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You share the fate of your father. Perhaps it is true that nothing good comes out of House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Once the heir of a great family. Now look at what your dynasty has come to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your gold will not save you now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your endless greed has ended you. Ironic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This shouldn't have been your demise. I am disappointed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wiktor Smolak sends his regards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It pains me to do this to a member of my own family, but your incompetence and treason have left me with no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You dared to betray your King. The leader of your own House! You deserve this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Luce. It's nothing personal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Azaro will fall because of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If only I could execute you twice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From a great general to a death row inmate. What a sorry sight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father should have executed you long ago. Perhaps none of this would have happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only thing you have brought to your family is shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[144]`
Mówca: **Taddeus Azaro**
> ""I accept my fate, Your Majesty. I apologize for failing you and this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[145]`
Mówca: **Narrator**
> "She stared at me, every muscle in her body practically vibrating with constrained rage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[146]`
Mówca: **Rico Toras**
> ""Shut up and get it over with, cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[147]`
Mówca: **Russello Montoro**
> ""You're making a mistake, Your Majesty. Do you know the fortune that awaits you if you let me go? We could make billions together!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[148]`
Mówca: **Manus Sazon**
> ""Your time will come as well, King Romus. This will only fuel the people's rage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[149]`
Mówca: **Sal Ignacius**
> ""Curse you and your family, Romus the First. You deserve to die the same death that your father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
Mówca: **Axel Reinhart**
> ""I have lost... everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "He fell on his knees on the ground. The guards helped him up on his feet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He spit on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[153]`
Mówca: **Narrator**
> "He looked proud and unfazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[154]`
Mówca: **Narrator**
> "On seeing my impassive face, he abruptly assumed a pleading tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[155]`
Mówca: **Narrator**
> "He did not dare look into my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[156]`
Mówca: **Narrator**
> "The venom in her voice almost made me take a step back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Narrator**
> "He looked defeated and weak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[166]`
Mówca: **Narrator**
> "The executioner looked at me for the final order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "Gesture for the executions to start."]** — Mówca: **Player_Romus_Italic**
> "I gestured at him to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Narrator**
> "With an off-putting smile, he moved over to the line. The guards followed his lead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Electrocution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Electrocution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Electrocution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_Electrocution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Electrocution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_FiringSquad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_FiringSquad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_FiringSquad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_FiringSquad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_FiringSquad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Guillotine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Guillotine == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Guillotine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_Guillotine == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Guillotine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Soon after, all of them were tied to the electric chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Narrator**
> "Their heads were shaved and wetted with a sponge dipped in a bucket of water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Soon after, all of them were tied to the poles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Narrator**
> "Their eyes were blindfolded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[182]`
Mówca: **Narrator**
> "Soon after, all of them kneeling under the sharp blade of the guillotine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Narrator**
> "They could not even look up to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Soon after, all of them were on the gallows with ropes around their necks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Their hands were kept cuffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Their final rites were read to them as well as prayers for the ones who requested it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Narrator**
> "The executioner held his hand up to signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[188]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will see you all in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Electrocution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Electrocution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Electrocution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_Electrocution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Electrocution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_FiringSquad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_FiringSquad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_FiringSquad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_FiringSquad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_FiringSquad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Guillotine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Method_Guillotine == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Method_Guillotine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Method_Guillotine == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Method_Guillotine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[200]`
Mówca: **Narrator**
> "His hand went down and the signal was given."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[201]`
Mówca: **Narrator**
> "The lever was turned all the way up and the voltage was increased to maximum. A terrible smell filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[202]`
Mówca: **Narrator**
> "They were no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[203]`
Mówca: **Narrator**
> "The firing squad loaded their rifles, pointed and shot at the prisoners in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
Mówca: **Narrator**
> "The rope was cut and the huge blades of the guillotines made their way down. Blood gushed from the prisoners' necks as their heads rolled into the baskets in front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
Mówca: **Narrator**
> "The rope was cut and the wooden board beneath the prisoners' feet gave way. Some of their necks snapped immediately; others clutched at their throats, struggling for breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Publicity_Everyone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Publicity_Everyone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Publicity_Everyone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Publicity_Everyone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Publicity_Everyone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Publicity_OnlyNobles == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Executions_Publicity_OnlyNobles == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Executions_Publicity_OnlyNobles"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Executions_Publicity_OnlyNobles == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Executions_Publicity_OnlyNobles"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Narrator**
> "After a short while, the jerking motions of the lifeless bodies stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[214]`
Mówca: **Narrator**
> "The entire plaza let out a collective gasp. Camera flashes went off. Then slowly, clapping began from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[215]`
Mówca: **Narrator**
> "The nobles let out a collective gasp. I felt that they were looking at me in a new light. I was more feared and respected now than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Pabel Adria");
RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Pabel Adria");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will burn in hell for what you did to both Rizia and Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[221]`
Mówca: **Russello Montoro**
> ""Please, Your Majesty.... I mean it. I'll do anything... Anything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[222]`
Mówca: **Manus Sazon**
> ""And that of your own daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RomanceHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RomanceHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RomanceHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn10_TotalExecutions == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn10_TotalExecutions == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn10_TotalExecutions"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn10_TotalExecutions == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn10_TotalExecutions"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Narrator**
> "I immediately recognized the subjects of my execution order, standing alongside a number of other inmates whose time had come as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You earned my respect, only to betray me. What do you have to say for yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[234]`
Mówca: **Lucita Azaro**
> ""Fuck off, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC.Pabel_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC.Pabel_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_Pabel"] == false  and  Variable["RiziaDLC.Pabel_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Executions_Pabel == false && RiziaDLC.Pabel_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_Pabel"] == false  and  Variable["RiziaDLC.Pabel_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel Adria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Pabel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Pabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[244]`
  - -> `[255]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bi mare volu...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where is my daughter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish this had gone differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
Mówca: **Pabel Adria**
> ""Far away from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[247]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Pabel Adria**
> ""You've changed, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[249]`
Mówca: **Pabel Adria**
> ""So do I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Pabel Adria**
> ""I'm sorry, Rom. But you've changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[254]`
Mówca: **Pabel Adria**
> ""My loyalty had its limits, Your Majesty. You found them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For humiliating the Royal Family of Rizia, you will pay the ultimate price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Pabel Adria**
> ""I am not the humiliation here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Narrator**
> "He took a last, regretful look at me as the hood was placed back on his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion"); RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Titus == false && RiziaDLC.Titus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Titus == false && RiziaDLC.Titus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_Titus"] == false  and  Variable["RiziaDLC.Titus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Executions_Titus == false && RiziaDLC.Titus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_Titus"] == false  and  Variable["RiziaDLC.Titus_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus Gordion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Titus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Titus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[269]`
  - -> `[271]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To think that I trusted you with the security of me and my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You bit the hand that fed you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May you burn in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Titus Gordion**
> ""Alongside you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[273]`
Mówca: **Titus Gordion**
> ""To think that I trusted you with leading this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Titus Gordion**
> ""The only thing you could feed people with is poison, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Narrator**
> "He stood defiant and emotionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Executions_Titus = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Executions_Titus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Stress", "R_Stress_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Stress","R_Stress_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");
RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Executions_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Executions_Hugo == false && RiziaDLC.Hugo_Executed == true && RiziaDLC.Hugo_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Executions_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == true  and  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Hugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[289]`
  - -> `[291]`
  - -> `[359]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are not worthy of the Toras name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were almost a father to me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May you meet my father in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Hugo Toras**
> ""We will wait for you to join us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[293]`
Mówca: **Hugo Toras**
> ""Everything I ever did was for our house. But I worry it has all been for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Hugo Toras**
> ""And you were almost a son...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Narrator**
> "He had the look of a broken man. He lowered his eyes and said no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Executions_Hugo = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Executions_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_Executions_Public = true;
RiziaDLCSupport.News_Turn10_V_Excecutions_Public = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Public"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_Excecutions_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_Executions_Nobles = true;
RiziaDLCSupport.News_Turn10_V_Excecutions_Nobles = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Nobles"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_Excecutions_Nobles"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_Executions_Private = true;
RiziaDLCSupport.News_Turn10_V_Excecutions_Private = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Executions_Private"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_Excecutions_Private"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"]  or  Variable["RiziaDLC.Lucita_Executed"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed || RiziaDLC.Lucita_Executed))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"]  or  Variable["RiziaDLC.Lucita_Executed"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgsland_Friendly == false && RiziaDLC.CountryRelation_Valgsland_Allied == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgsland_Friendly == false && RiziaDLC.CountryRelation_Valgsland_Allied == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Executed"]  and  Variable["RiziaDLC.CountryRelation_Valgsland_Friendly"] == false  and  Variable["RiziaDLC.CountryRelation_Valgsland_Allied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Executed && RiziaDLC.CountryRelation_Valgsland_Friendly == false && RiziaDLC.CountryRelation_Valgsland_Allied == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Executed"]  and  Variable["RiziaDLC.CountryRelation_Valgsland_Friendly"] == false  and  Variable["RiziaDLC.CountryRelation_Valgsland_Allied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Iza_RicoExecuted = true;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableCodexEntry("Characters_Family_RicoToras_Executed");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Iza_RicoExecuted"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableCodexEntry("Characters_Family_RicoToras_Executed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Iza_ManusExecuted = true;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableCodexEntry("Characters_PartyLeaders_ManusSazon_Executed");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Iza_ManusExecuted"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableCodexEntry("Characters_PartyLeaders_ManusSazon_Executed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Lespia_RustyExecuted = true;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableCodexEntry("Characters_Business_RustyMontoro_Executed");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Lespia_RustyExecuted"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableCodexEntry("Characters_Business_RustyMontoro_Executed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Montaklar_AzaroExecuted = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Montaklar_AzaroExecuted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Monqiz_HugoExecuted = true;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableCodexEntry("Characters_Council_HugoToras_Executed");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Monqiz_HugoExecuted"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableCodexEntry("Characters_Council_HugoToras_Executed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Valgsland_PabelExecuted = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Valgsland_PabelExecuted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Council_SalIgnacius_Executed");

RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Council_SalIgnacius_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("ElectricChair");)*
- **Efekt (`userScript`):** `PlaySoundEffect("ElectricChair");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("FiringSquad");)*
- **Efekt (`userScript`):** `PlaySoundEffect("FiringSquad");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Guillotine");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Guillotine");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("HangingExecution");)*
- **Efekt (`userScript`):** `PlaySoundEffect("HangingExecution");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Council_TaddeusAzaro_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Council_TaddeusAzaro_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Council_LucitaAzaro_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Council_LucitaAzaro_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Executed)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Executed)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Executed"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Executed ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Executed"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Others_PabelAdria_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Others_PabelAdria_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Others_TitusGordion_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Others_TitusGordion_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Axel_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Axel_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Axel_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Axel_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Axel_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn10_TotalExecutions >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn10_TotalExecutions >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn10_TotalExecutions"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn10_TotalExecutions >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn10_TotalExecutions"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_Executions");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_Executions");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fitting, isn't it? For you and your failure of a son to die together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Hugo Toras**
> ""I beg you, Romus. Kill me if you must, but spare my boy...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLC.Angelica_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Angelica_Executed == true && RiziaDLC.Angelica_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLC.Angelica_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Angelica Sazon"); RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Angelica Sazon");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Adarfo Sotelato"); RiziaDLC.Turn10_TotalExecutions += 1)*
- **Efekt (`userScript`):** `AddConversant("Adarfo Sotelato");
Variable["RiziaDLC.Turn10_TotalExecutions"] = Variable["RiziaDLC.Turn10_TotalExecutions"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated.Executions_Angelica == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated.Executions_Angelica == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Angelica"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Angelica_Executed == true && RiziaDLCIsolated.Executions_Angelica == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true  and  Variable["RiziaDLCIsolated.Executions_Angelica"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Angelica Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Angelica = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Angelica"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[378]`
  - -> `[377]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I gave you a chance to redeem yourself, and you abused it. Your punishment is well earned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father should have done this years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How fitting for you to die alongside your son. Your treacherous legacy ends today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pity you couldn't fall in line like your son did. Your treachery ends today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[384]`
Mówca: **Angelica Sazon**
> ""I regret nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Angelica Sazon**
> ""This is not the end of House Sazon. Rizia's noblest family will survive the tyranny of Romus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true && RiziaDLCIsolated.Executions_Adarfo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true && RiziaDLCIsolated.Executions_Adarfo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Executed == true && RiziaDLC.Adarfo_Arrested == true && RiziaDLCIsolated.Executions_Adarfo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Executed"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLCIsolated.Executions_Adarfo"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Adarfo Sotelato.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Executions_Adarfo = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Executions_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`
  - -> `[392]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're a sham. You never truly wanted to make people's lives better. You only wanted to seize power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your revolution has failed, like so many others before it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is your last chance. Acknowledge me as your rightful king, and I'll clear you of all charges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Adarfo Sotelato**
> ""You don't mean that. But even if you did, I would gladly accept death before bowing to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[396]`
Mówca: **Adarfo Sotelato**
> ""It lives on in the hearts of the Rizian people. One day -- sooner than you think -- they will have their vengeance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Adarfo Sotelato**
> ""I cannot take these words seriously coming from an absolute monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Narrator**
> "He held his head high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death Row Final Words Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Executions = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Executions"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Angelica_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Others_AngelicaSazon_Executed");
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Others_AngelicaSazon_Executed");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_Died");
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_Died");
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true && RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look over there at your daughter. The all-powerful House of Azaro has been reduced to nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[413]`
Mówca: **Narrator**
> "His eyes filled with tears. He moved his lips, but no words came out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseAzaro_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[417]`
Mówca: **Taddeus Azaro**
> ""Your hubris will be your downfall. House Azaro will not go down that easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Narrator**
> "He tried to project defiance, but there was defeat in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[421]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true && RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_AzarosDead");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_AzarosDead");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
