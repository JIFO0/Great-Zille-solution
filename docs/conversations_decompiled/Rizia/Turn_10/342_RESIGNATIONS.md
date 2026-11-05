# Rizia/Turn 10/RESIGNATIONS

- **ID konwersacji:** `342`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/342_RESIGNATIONS.md`
- **Liczba węzłów dialogowych:** 310
- **Liczba wyborów gracza:** 22

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_AssassinationOrdered`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseSazon_Conquered`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.NatDes_Oppress`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Unrest_NatDes_Happened`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Adarfo_Arrested`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[338] Rizia/Turn 10/CouncilMeeting** (../Turn_10/338_CouncilMeeting.md), Węzeł `[524]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **""I hope this has taught you all a valuable lesson.""** | `[52]` **Lucita Azaro**: ""From this point on, we will liv..."<br>`[53]` **Taddeus Azaro**: ""We are to live as commoners.""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[66]` **Hugo Toras**: ""Without question.""<br>`[70]` **Lucita Azaro**: ""Yes. It has.""<br>*(oraz 1 innych odgałęzień)* |
| `[39]` | **""Your province's armed forces answer directly to me now as well. Don't forget that.""** | `[52]` **Lucita Azaro**: ""From this point on, we will liv..."<br>`[53]` **Taddeus Azaro**: ""We are to live as commoners."" | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false` | *Brak zmian stanu* | `[78]` **Hugo Toras**: ""They are yours to command.""<br>`[82]` **Lucita Azaro**: ""Their allegiance is strictly to..."<br>*(oraz 1 innych odgałęzień)* |
| `[43]` | **""I am sorry. I truly didn't mean for all this to happen.""** | `[52]` **Lucita Azaro**: ""From this point on, we will liv..."<br>`[53]` **Taddeus Azaro**: ""We are to live as commoners.""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[104]` **Hugo Toras**: ""I should have done more to secu..."<br>`[108]` **Lucita Azaro**: ""What happened at the birthday g..."<br>*(oraz 1 innych odgałęzień)* |
| `[44]` | **""Power corrupts. You will thank me for this in the end.""** | `[52]` **Lucita Azaro**: ""From this point on, we will liv..."<br>`[53]` **Taddeus Azaro**: ""We are to live as commoners.""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[90]` **Hugo Toras**: ""I am not complaining, Your Maje..."<br>`[94]` **Lucita Azaro**: ""You expect me to *thank* you?! ..."<br>*(oraz 1 innych odgałęzień)* |
| `[45]` | **""Great. So what are you still doing here?""** | `[52]` **Lucita Azaro**: ""From this point on, we will liv..."<br>`[53]` **Taddeus Azaro**: ""We are to live as commoners.""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[116]` **Narrator**: "Hugo placed both of his hands on..."<br>`[120]` **Narrator**: "Lucita's face filled with resolve."<br>*(oraz 1 innych odgałęzień)* |
| `[141]` | **""Go, then. But I will never forget your act of cowardice.""** | `[122]` **Lucita Azaro**: ""Carlos, my father and I will co..."<br>`[129]` **Lucita Azaro**: ""Carlos and I will continue to s..."<br>*(oraz 5 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[149]` **Narrator**: "My security councilor numbly han..."<br>`[160]` **Narrator**: "Hugo numbly handed me a large fo..." |
| `[142]` | **""I expect nothing less than a complete and total victory.""** | `[122]` **Lucita Azaro**: ""Carlos, my father and I will co..."<br>`[129]` **Lucita Azaro**: ""Carlos and I will continue to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Narrator**: "My security councilor numbly han..."<br>`[160]` **Narrator**: "Hugo numbly handed me a large fo..." |
| `[143]` | **""You have failed me as you have failed Rizia. Your name shall be written out of th..."** | `[122]` **Lucita Azaro**: ""Carlos, my father and I will co..."<br>`[129]` **Lucita Azaro**: ""Carlos and I will continue to s..."<br>*(oraz 5 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[149]` **Narrator**: "My security councilor numbly han..."<br>`[160]` **Narrator**: "Hugo numbly handed me a large fo..." |
| `[144]` | **""Despite the circumstances, I thank you both for your years of service.""** | `[122]` **Lucita Azaro**: ""Carlos, my father and I will co..."<br>`[129]` **Lucita Azaro**: ""Carlos and I will continue to s..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)` | *Brak zmian stanu* | `[149]` **Narrator**: "My security councilor numbly han..."<br>`[160]` **Narrator**: "Hugo numbly handed me a large fo..." |
| `[148]` | **""Despite the circumstances, I thank you for your years of service.""** | `[122]` **Lucita Azaro**: ""Carlos, my father and I will co..."<br>`[129]` **Lucita Azaro**: ""Carlos and I will continue to s..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)) == false` | *Brak zmian stanu* | `[149]` **Narrator**: "My security councilor numbly han..."<br>`[160]` **Narrator**: "Hugo numbly handed me a large fo..." |
| `[150]` | **""You can't quit. Because you're fired.""** | `[122]` **Lucita Azaro**: ""Carlos, my father and I will co..."<br>`[129]` **Lucita Azaro**: ""Carlos and I will continue to s..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[149]` **Narrator**: "My security councilor numbly han..."<br>`[160]` **Narrator**: "Hugo numbly handed me a large fo..." |
| `[253]` | **""Amazing work. Thank you.""** | `[216]` **Hugo Toras**: ""The bureaucratic fallout from t..."<br>`[220]` **Hugo Toras**: ""The bureaucratic fallout from t..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Narrator**: "My advisors stood and bowed."<br>`[264]` **Narrator**: "My advisor stood and bowed." |
| `[254]` | **""Good. Now please get out of my sights.""** | `[216]` **Hugo Toras**: ""The bureaucratic fallout from t..."<br>`[220]` **Hugo Toras**: ""The bureaucratic fallout from t..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Narrator**: "My advisors hurriedly stood, bow..."<br>`[262]` **Narrator**: "My advisor stood, bowed and back..." |
| `[265]` | **""Goodbye, Mr. Toras and Mr. Azaro.""** | `[261]` **Narrator**: "My advisors hurriedly stood, bow..."<br>`[263]` **Narrator**: "My advisors stood and bowed." | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[286]` **Narrator**: "Hugo didn't react. Taddeus merel..." |
| `[275]` | **""Goodbye, Mr. Toras and Ms. Azaro.""** | `[261]` **Narrator**: "My advisors hurriedly stood, bow..."<br>`[263]` **Narrator**: "My advisors stood and bowed." | `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true` | *Brak zmian stanu* | `[285]` **Narrator**: "Hugo didn't react. I saw venom i..." |
| `[276]` | **""Goodbye, Mr. Toras.""** | `[262]` **Narrator**: "My advisor stood, bowed and back..."<br>`[264]` **Narrator**: "My advisor stood and bowed." | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[289]` **Hugo Toras**: ""Goodbye, Romus."" |
| `[277]` | **""Goodbye, Mr. Azaro.""** | `[262]` **Narrator**: "My advisor stood, bowed and back..."<br>`[264]` **Narrator**: "My advisor stood and bowed." | `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[288]` **Narrator**: "Taddeus cast his eyes downward." |
| `[278]` | **""Goodbye, Ms. Azaro.""** | `[262]` **Narrator**: "My advisor stood, bowed and back..."<br>`[264]` **Narrator**: "My advisor stood and bowed." | `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true` | *Brak zmian stanu* | `[287]` **Narrator**: "I saw venom in Lucita's eyes." |
| `[279]` | **""Meeting adjourned.""** | `[262]` **Narrator**: "My advisor stood, bowed and back..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Narrator**: "Titus opened the door and ushere..."<br>`[305]` **Narrator**: "Titus opened the door and ushere..."<br>*(oraz 3 innych odgałęzień)* |
| `[280]` | **""Until we meet again.""** | `[261]` **Narrator**: "My advisors hurriedly stood, bow..."<br>`[262]` **Narrator**: "My advisor stood, bowed and back..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Narrator**: "Titus opened the door and ushere..."<br>`[305]` **Narrator**: "Titus opened the door and ushere..."<br>*(oraz 3 innych odgałęzień)* |
| `[281]` | **""You're still my uncle, Hugo. I love and respect you greatly.""** | `[261]` **Narrator**: "My advisors hurriedly stood, bow..."<br>`[263]` **Narrator**: "My advisors stood and bowed."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false` | *Brak zmian stanu* | `[284]` **Narrator**: "Hugo didn't respond." |
| `[282]` | **""A pox on your entire family.""** | `[262]` **Narrator**: "My advisor stood, bowed and back..."<br>`[264]` **Narrator**: "My advisor stood and bowed." | `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true` | *Brak zmian stanu* | `[290]` **Narrator**: "I saw venom in my ex-councilor's..." |

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
  - -> `[3]` (*Narrator: "I sat at the head of the long table in my council chambers."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I sat at the head of the long table in my council chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Hugo sat across from me, a hollow look in his eyes."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Hugo and my security councilor sat across from me."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "My security councilor sat across from me, looking despond..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Hugo and my security councilor sat across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "My uncle had a hollow look in his eyes."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "My security councilor sat across from me, looking despondent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Hugo sat across from me, a hollow look in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""Your Majesty... it is done.""*)

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""Your Majesty... it is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Hugo Toras: ""All members of House Toras have relinquished their title..."*)

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""All members of House Toras have relinquished their titles and estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""With the exception of the Crown Princess, who shall rema..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""Our cousin Hubertus no longer reigns over the province. ..."*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""With the exception of the Crown Princess, who shall remain in Monqiz but will no longer reign over the province.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""Valenqiris is entirely yours.""*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Valenqiris is entirely yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this has taught you all a valuable lesson.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[52]` (Lucita Azaro), `[53]` (Taddeus Azaro), `[19]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Lucita nodded despondently."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Lucita nodded despondently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucita Azaro: ""The same goes for my home province, Your Majesty.""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns =..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Taddeus nodded despondently."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Taddeus nodded despondently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Taddeus Azaro: ""As is my home province, Your Majesty.""*)

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""The same goes for my home province, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""The Azaros have ceded control of Cardesse-Montaklar. Our..."*)

### Węzeł `[30]`
Mówca: **Taddeus Azaro**
> ""As is my home province, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Taddeus Azaro: ""The Azaros have ceded control of Cardesse-Montaklar. Our..."*)

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""The Azaros have ceded control of Cardesse-Montaklar. Our lands are officially the property of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucita Azaro: ""From this point on, we will live as commoners.""*)

### Węzeł `[32]`
Mówca: **Taddeus Azaro**
> ""The Azaros have ceded control of Cardesse-Montaklar. Our lands are officially the property of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Taddeus Azaro: ""We are to live as commoners.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucita Azaro: ""It is done, Your Majesty.""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Taddeus Azaro: ""It is done, Your Majesty.""*)

### Węzeł `[36]`
Mówca: **Lucita Azaro**
> ""It is done, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""The Azaros have ceded control of Cardesse-Montaklar. Our..."*)

### Węzeł `[37]`
Mówca: **Taddeus Azaro**
> ""It is done, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Taddeus Azaro: ""The Azaros have ceded control of Cardesse-Montaklar. Our..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""I hope this has taught you all a valuable lesson.""*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false"*)
  - -> `[43]` (*Player_Romus: ""I am sorry. I truly didn't mean for all this to happen.""*)
  - -> `[44]` (*Player_Romus: ""Power corrupts. You will thank me for this in the end.""*)
  - -> `[45]` (*Player_Romus: ""Great. So what are you still doing here?""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your province's armed forces answer directly to me now as well. Don't forget that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false`
- **Kontekst wejściowy (poprzednik):** `[52]` (Lucita Azaro), `[53]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""Your province's armed forces answer directly to me now a..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry. I truly didn't mean for all this to happen.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[52]` (Lucita Azaro), `[53]` (Taddeus Azaro), `[19]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Power corrupts. You will thank me for this in the end.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[52]` (Lucita Azaro), `[53]` (Taddeus Azaro), `[19]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. So what are you still doing here?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[52]` (Lucita Azaro), `[53]` (Taddeus Azaro), `[19]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""I have come to hand in my official resignation. I can no..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""I have come to hand in my official resignation. I can no longer serve as your Grand Vizier after my family's disgrace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Executed ..."*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""Our cousin Hubertus no longer reigns over the province. He's scraped together what funds he can and intends to continue his world travels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""Valenqiris is entirely yours.""*)

### Węzeł `[51]`
Mówca: **Narrator**
> "My uncle had a hollow look in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""Your Majesty... it is done.""*)

### Węzeł `[52]`
Mówca: **Lucita Azaro**
> ""From this point on, we will live as commoners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[53]`
Mówca: **Taddeus Azaro**
> ""We are to live as commoners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Hugo Toras: ""Without question.""*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucita Azaro: ""I hate to entrust anyone else with our kingdom's nationa..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[60]`
Mówca: **Lucita Azaro**
> ""I hate to entrust anyone else with our kingdom's national security. But you'll understand why I cannot remain on the Royal Council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Executed ..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Execute..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""And every moment I spend in Porte Drazon is a crushing r..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Hugo Toras: ""And every moment I spend in Porte Drazon is a crushing r..."*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""And every moment I spend in Porte Drazon is a crushing reminder of my son's fate...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[65]`
Mówca: **Hugo Toras**
> ""And every moment I spend in Porte Drazon is a crushing reminder of the shame I endured...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""Without question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucita Azaro: ""Yes. It has.""*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[70]`
Mówca: **Lucita Azaro**
> ""Yes. It has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns =..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Taddeus Azaro: ""Indeed. Neither I nor any other Azaro will ever challeng..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[74]`
Mówca: **Taddeus Azaro**
> ""Indeed. Neither I nor any other Azaro will ever challenge your power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Hugo Toras: ""They are yours to command.""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[78]`
Mówca: **Hugo Toras**
> ""They are yours to command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucita Azaro: ""Their allegiance is strictly to the Crown now.""*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[82]`
Mówca: **Lucita Azaro**
> ""Their allegiance is strictly to the Crown now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns =..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Taddeus Azaro: ""Their allegiance is to the Crown, as it always was.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[86]`
Mówca: **Taddeus Azaro**
> ""Their allegiance is to the Crown, as it always was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Hugo Toras: ""I am not complaining, Your Majesty.""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""I am not complaining, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucita Azaro: ""You expect me to *thank* you?! I--""*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[94]`
Mówca: **Lucita Azaro**
> ""You expect me to *thank* you?! I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "She caught herself."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns =..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Taddeus Azaro: ""Yours is the judgement around which this kingdom revolve..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[98]`
Mówca: **Taddeus Azaro**
> ""Yours is the judgement around which this kingdom revolves. I will not question it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty. Perhaps I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "She caught herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""Yes, Your Majesty. Perhaps I will.""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Hugo Toras: ""I should have done more to secure the rest of House Tora..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""I should have done more to secure the rest of House Toras' allegiance. The fault is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucita Azaro: ""What happened at the birthday gathering felt quite delib..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[108]`
Mówca: **Lucita Azaro**
> ""What happened at the birthday gathering felt quite deliberate to me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns =..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Taddeus Azaro: ""My daughter started all this when she betrayed our kingd..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[112]`
Mówca: **Taddeus Azaro**
> ""My daughter started all this when she betrayed our kingdom. We deserve our punishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Hugo placed both of his hands on the table, palms up in a..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Hugo placed both of his hands on the table, palms up in a sign of supplication."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Lucita's face filled with resolve."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Regret was etched into Taddeus' features."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Lucita's face filled with resolve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Regret was etched into Taddeus' features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""Carlos, my father and I will continue to see the Pales war through. But my service to the Kingdom will end there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[142]` (*Player_Romus: ""I expect nothing less than a complete and total victory.""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucita Azaro: ""Carlos, my father and I will continue to see the Pales w..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucita Azaro: ""Carlos and I will continue to see the Pales war through...."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""Carlos and I will continue to see the Pales war through. But my service to the Kingdom will end there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[142]` (*Player_Romus: ""I expect nothing less than a complete and total victory.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Ex..."*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucita Azaro: ""My father may not have many years left in him. I'll retu..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucita Azaro: ""I know I risk receiving the same fate as my father. But ..."*)

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""My father may not have many years left in him. I'll return to Cardesse-Montaklar and to my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""I know I risk receiving the same fate as my father. But I hope you will let me go in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[135]`
Mówca: **Taddeus Azaro**
> ""All my life, I believed I was destined for greatness. But here I am, Your Majesty. A broken man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Taddeus Azaro: ""I deserve neither my noble title, my rank nor my positio..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns =..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Taddeus Azaro: ""All my life, I believed I was destined for greatness. Bu..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[139]`
Mówca: **Taddeus Azaro**
> ""I deserve neither my noble title, my rank nor my position on this council. I am nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""Go, then. But I will never forget your act of cowardice.""*)
  - -> `[143]` (*Player_Romus: ""You have failed me as you have failed Rizia. Your name s..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == tru..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go, then. But I will never forget your act of cowardice.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro), `[129]` (Lucita Azaro), `[133]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect nothing less than a complete and total victory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro), `[129]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have failed me as you have failed Rizia. Your name shall be written out of the history books.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro), `[129]` (Lucita Azaro), `[133]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite the circumstances, I thank you both for your years of service.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)`
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro), `[129]` (Lucita Azaro), `[133]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == tru..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: ""Despite the circumstances, I thank you both for your yea..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""Despite the circumstances, I thank you for your years of..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite the circumstances, I thank you for your years of service.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro), `[129]` (Lucita Azaro), `[133]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "My security councilor numbly handed me a large folder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't quit. Because you're fired.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro), `[129]` (Lucita Azaro), `[133]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Romus: ""You can't quit. Because you're fired.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == t..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "My security councilor numbly handed me a large folder."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Hugo numbly handed me a large folder."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucita Azaro: ""This should be all the information my replacement needs.""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Taddeus Azaro: ""This should be all the information my replacement needs.""*)

### Węzeł `[160]`
Mówca: **Narrator**
> "Hugo numbly handed me a large folder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Hugo Toras: ""This should be all the information my replacement needs.""*)

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""This should be all the information my replacement needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""Including an update on the recent unrest. As you can see, the protests have died down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_NatDes_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Unrest_NatDes_Happened == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_NatDes_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucita Azaro: ""Including an update on the recent unrest. As you can see..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Unrest_NatDes_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)

### Węzeł `[166]`
Mówca: **Taddeus Azaro**
> ""This should be all the information my replacement needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)

### Węzeł `[167]`
Mówca: **Taddeus Azaro**
> ""Including an update on the recent unrest. As you can see, the protests have died down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_NatDes_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Unrest_NatDes_Happened == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_NatDes_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Taddeus Azaro: ""Including an update on the recent unrest. As you can see..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Unrest_NatDes_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Assa..."*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_As..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucita Azaro: ""The ringleader, Adarfo Sotelato, has been arrested. I ho..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucita Azaro: ""The ringleaders have all been arrested. I trust they'll ..."*)

### Węzeł `[174]`
Mówca: **Lucita Azaro**
> ""The ringleader, Adarfo Sotelato, has been arrested. I hope you make an example out of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested = true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Oppress == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Assa..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Oppress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucita Azaro: ""I admit I didn't think we'd be able to subdue the moveme..."*)

### Węzeł `[178]`
Mówca: **Lucita Azaro**
> ""The ringleaders have all been arrested. I trust they'll receive the Sotelato treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)

### Węzeł `[179]`
Mówca: **Lucita Azaro**
> ""I admit I didn't think we'd be able to subdue the movement without resorting to harsh measures. But it seems the revolutionaries won't trouble us any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Assa..."*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_As..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Taddeus Azaro: ""The ringleader, Adarfo Sotelato, has been arrested. I ho..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Taddeus Azaro: ""The ringleaders have all been arrested. I trust you'll m..."*)

### Węzeł `[183]`
Mówca: **Taddeus Azaro**
> ""The ringleader, Adarfo Sotelato, has been arrested. I hope you make an example out of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested = true"*)

### Węzeł `[184]`
Mówca: **Taddeus Azaro**
> ""The ringleaders have all been arrested. I trust you'll make an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)

### Węzeł `[185]`
Mówca: **Taddeus Azaro**
> ""I admit I didn't think we'd be able to subdue the movement without resorting to harsh measures. But it seems the revolutionaries won't trouble us any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Oppress == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Assa..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Oppress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Taddeus Azaro: ""I admit I didn't think we'd be able to subdue the moveme..."*)

### Węzeł `[189]`
Mówca: **Hugo Toras**
> ""This should be all the information my replacement needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorG..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorG..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilo..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Hugo Toras: ""As well as a dossier I've compiled for your new security..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)

### Węzeł `[193]`
Mówca: **Hugo Toras**
> ""As well as a dossier I've compiled for your new security councilor, whoever they may be...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)

### Węzeł `[194]`
Mówca: **Hugo Toras**
> ""It includes an update on the recent unrest. As you can see, the protests have died down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_NatDes_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_NatDes_Happened == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Unrest_NatDes_Happened == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_NatDes_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Hugo Toras: ""It includes an update on the recent unrest. As you can s..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Unrest_NatDes_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSa..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Assa..."*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_As..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Hugo Toras: ""The ringleader, Adarfo Sotelato, has been arrested. I'd ..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Hugo Toras: ""The ringleaders have all been arrested. I advise you to ..."*)

### Węzeł `[201]`
Mówca: **Hugo Toras**
> ""The ringleader, Adarfo Sotelato, has been arrested. I'd advise you to make an example out of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested = true"*)

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""The ringleaders have all been arrested. I advise you to make an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSa..."*)

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""I admit I didn't think we'd be able to subdue the movement without resorting to harsh measures. But it seems the revolutionaries won't trouble us any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSa..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Oppress == true)"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Assa..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Oppress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Hugo Toras: ""I admit I didn't think we'd be able to subdue the moveme..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == f..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSa..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSa..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == f..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSa..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSa..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSazon_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSa..."*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.House..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSazon_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Hugo Toras: ""The bureaucratic fallout from transferring all three pro..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)

### Węzeł `[216]`
Mówca: **Hugo Toras**
> ""The bureaucratic fallout from transferring all three provinces to Crown control will be a hefty task, but I'm sure you'll be able to manage without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseAzaro_Conquered == true )"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Hugo Toras: ""The bureaucratic fallout from transferring both Valenqir..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseAzaro_Conquered == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)

### Węzeł `[220]`
Mówca: **Hugo Toras**
> ""The bureaucratic fallout from transferring both Valenqiris and Cardesse-Montaklar to Crown control will be a hefty task, but I'm sure you'll be able to manage without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[221]`
Mówca: **Hugo Toras**
> ""The bureaucratic fallout from transferring both Valenqiris and Brenas to Crown control will be a hefty task, but I'm sure you'll be able to manage without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSa..."*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true && RiziaDLC.House..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Taddeus Azaro: ""Overseeing the transfer of all three provinces to Crown ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[225]`
Mówca: **Taddeus Azaro**
> ""Overseeing the transfer of all three provinces to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true )"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Taddeus Azaro: ""Overseeing the transfer of both Cardesse-Montaklar and V..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[229]`
Mówca: **Taddeus Azaro**
> ""Overseeing the transfer of both Cardesse-Montaklar and Valenqiris to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[230]`
Mówca: **Taddeus Azaro**
> ""Overseeing the transfer of both Cardesse-Montaklar and Brenas to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseSazon_Conquered == true )"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Hugo Toras: ""The bureaucratic fallout from transferring both Valenqir..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseSazon_Conquered == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Hugo Toras: ""The bureaucratic fallout from transferring Valenqiris to..."*)

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""The bureaucratic fallout from transferring Valenqiris to Crown control will be a hefty task, but I'm sure you'll be able to manage without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true )"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Taddeus Azaro: ""Overseeing the transfer of both Cardesse-Montaklar and B..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Taddeus Azaro: ""Overseeing the complete transfer of Cardesse-Montaklar t..."*)

### Węzeł `[238]`
Mówca: **Taddeus Azaro**
> ""Overseeing the complete transfer of Cardesse-Montaklar to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSa..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true && RiziaDLC.House..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucita Azaro: ""Overseeing the transfer of all three provinces to Crown ..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""Overseeing the transfer of all three provinces to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true )"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucita Azaro: ""Overseeing the transfer of both Cardesse-Montaklar and V..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""Overseeing the transfer of both Cardesse-Montaklar and Valenqiris to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[247]`
Mówca: **Lucita Azaro**
> ""Overseeing the transfer of both Cardesse-Montaklar and Brenas to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[248]`
Mówca: **Lucita Azaro**
> ""Overseeing the complete transfer of Cardesse-Montaklar to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true )"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucita Azaro: ""Overseeing the transfer of both Cardesse-Montaklar and B..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Lucita Azaro: ""Overseeing the complete transfer of Cardesse-Montaklar t..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""Amazing work. Thank you.""*)
  - -> `[254]` (*Player_Romus: ""Good. Now please get out of my sights.""*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Amazing work. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Hugo Toras), `[220]` (Hugo Toras), `[221]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == tru..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Now please get out of my sights.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Hugo Toras), `[220]` (Hugo Toras), `[221]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == tru..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == tru..."*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "My advisors stood and bowed."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "My advisor stood and bowed."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == tru..."*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "My advisors hurriedly stood, bowed and backed towards the..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "My advisor stood, bowed and backed towards the door."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "My advisors hurriedly stood, bowed and backed towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""You're still my uncle, Hugo. I love and respect you grea..."*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[280]` (*Player_Romus: ""Until we meet again.""*)

### Węzeł `[262]`
Mówca: **Narrator**
> "My advisor stood, bowed and backed towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[280]` (*Player_Romus: ""Until we meet again.""*)
  - -> `[279]` (*Player_Romus: ""Meeting adjourned.""*)

### Węzeł `[263]`
Mówca: **Narrator**
> "My advisors stood and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""You're still my uncle, Hugo. I love and respect you grea..."*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[264]`
Mówca: **Narrator**
> "My advisor stood and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[280]` (*Player_Romus: ""Until we meet again.""*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Toras and Mr. Azaro.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Narrator), `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Hugo didn't react. Taddeus merely cast his eyes downward."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus: ""Goodbye, Ms. Azaro.""*)
  - -> `[282]` (*Player_Romus: ""A pox on your entire family.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns =..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player_Romus: ""Goodbye, Mr. Azaro.""*)
  - -> `[282]` (*Player_Romus: ""A pox on your entire family.""*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""You're still my uncle, Hugo. I love and respect you grea..."*)
  - -> `[276]` (*Player_Romus: ""Goodbye, Mr. Toras.""*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""Goodbye, Mr. Toras and Ms. Azaro.""*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""Goodbye, Mr. Toras and Mr. Azaro.""*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Toras and Ms. Azaro.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Kontekst wejściowy (poprzednik):** `[261]` (Narrator), `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "Hugo didn't react. I saw venom in Lucita's eyes."*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Toras.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Hugo Toras: ""Goodbye, Romus.""*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Azaro.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Taddeus cast his eyes downward."*)

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Ms. Azaro.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "I saw venom in Lucita's eyes."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Meeting adjourned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until we meet again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Narrator), `[262]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're still my uncle, Hugo. I love and respect you greatly.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Narrator), `[263]` (Narrator), `[262]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Hugo didn't respond."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pox on your entire family.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "I saw venom in my ex-councilor's eyes."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "Titus opened the door and ushered Hugo and Lucita out, a small smile of triumph on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Hugo didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[285]`
Mówca: **Narrator**
> "Hugo didn't react. I saw venom in Lucita's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Hugo didn't react. Taddeus merely cast his eyes downward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[287]`
Mówca: **Narrator**
> "I saw venom in Lucita's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Taddeus cast his eyes downward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[289]`
Mówca: **Hugo Toras**
> ""Goodbye, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[290]`
Mówca: **Narrator**
> "I saw venom in my ex-councilor's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == t..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "Titus opened the door and ushered Hugo and Lucita out, a ..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == ..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns =..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "Titus opened the door and ushered Hugo and Taddeus out, a..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "Titus opened the door and ushered Hugo out, a frown of re..."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "Titus opened the door and ushered Hugo and Taddeus out, a small smile of triumph on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[301]`
Mówca: **Narrator**
> "Titus opened the door and ushered Hugo out, a frown of regret on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true"*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns ==..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Titus opened the door and ushered Lucita out, a small smi..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Titus opened the door and ushered Taddeus out, a small sm..."*)

### Węzeł `[305]`
Mówca: **Narrator**
> "Titus opened the door and ushered Lucita out, a small smile of triumph on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[306]`
Mówca: **Narrator**
> "Titus opened the door and ushered Taddeus out, a small smile of triumph on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSa..."*)
