# Rizia/Turn 10/Notes/Notes Conversation

- **ID konwersacji:** `575`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/575_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 328
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Angelica`
- `RiziaDLC.Council_GrandVizier_Axel`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_GrandVizier_Sal`
- `RiziaDLC.Council_Treasury_Daria`
- `RiziaDLC.Council_Treasury_Rusty`
- `RiziaDLC.LeaningValue_ProBusiness`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Policy_Diplomacy_ANMember`
- `RiziaDLC.Policy_Economy_ResourceBased`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_BudgetModifiersTotal`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Resources_EnergyModifiersTotal`
- `RiziaDLC.Situation_Economy_Diversified`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLC.Situation_Economy_Mixed`
- `RiziaDLC.Situation_Economy_NewBusiness_Collapse`
- `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth`
- `RiziaDLC.Situation_Welfare_LivingStandards_Acceptable`
- `RiziaDLC.Situation_Welfare_LivingStandards_Average`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Good`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLCIsolated.NewGov_Geopolitics`
- `RiziaDLCIsolated.NewGov_Goverment`
- `RiziaDLCIsolated.NewGov_Pales`
- `RiziaDLCIsolated.NewGov_Zille`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.NewGov_ForeignAffairs`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""Ah, more paperwork. How delightful.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: ""With one last glance at the but..."<br>`[11]` **Narrator**: ""With one last glance at the but..."<br>*(oraz 1 innych odgałęzień)* |
| `[4]` | **""Let's get this over with.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: ""With one last glance at the but..."<br>`[11]` **Narrator**: ""With one last glance at the but..."<br>*(oraz 1 innych odgałęzień)* |
| `[5]` | **""Excellent. We shall retire to my study.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: ""With one last glance at the but..."<br>`[11]` **Narrator**: ""With one last glance at the but..."<br>*(oraz 1 innych odgałęzień)* |
| `[6]` | **""Thank you. Let’s go through them together.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: ""With one last glance at the but..."<br>`[11]` **Narrator**: ""With one last glance at the but..."<br>*(oraz 1 innych odgałęzień)* |
| `[40]` | **""Let's begin with foreign affairs.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[69]` | **""We stand alone now. I only hope we stand strong enough.""** | `[68]` **Hugo Toras**: ""However, it has reduced the ris..."<br>`[87]` **Axel Reinhart**: ""However, it has reduced the ris..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[70]` | **""What a tragedy -- to rule ourselves without permission.""** | `[68]` **Hugo Toras**: ""However, it has reduced the ris..."<br>`[87]` **Axel Reinhart**: ""However, it has reduced the ris..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[71]` | **""God’s will is not debated in foreign halls.""** | `[68]` **Hugo Toras**: ""However, it has reduced the ris..."<br>`[87]` **Axel Reinhart**: ""However, it has reduced the ris..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[72]` | **""Rizia bows to no one. This was the only path forward.""** | `[68]` **Hugo Toras**: ""However, it has reduced the ris..."<br>`[87]` **Axel Reinhart**: ""However, it has reduced the ris..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[76]` | **""Oh no, the AN misses us? They should've thought of that before trying to leash us."** | `[68]` **Hugo Toras**: ""However, it has reduced the ris..."<br>`[87]` **Axel Reinhart**: ""However, it has reduced the ris..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[80]` | **""We have shut the door behind us. I only hope we haven't locked ourselves inside.""** | `[68]` **Hugo Toras**: ""However, it has reduced the ris..."<br>`[87]` **Axel Reinhart**: ""However, it has reduced the ris..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[107]` | **""In celebration of Zille's return, I hereby declare that the Gulf of Moridia shall..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[108]` | **""To honor this occasion, I hereby order the removal of Smolak’s statues, which sha..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[109]` | **""As part of 'The Great Resettlement,' I hereby offer thousands of loyal Rizian fam..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[205]` | **"Economy and Energy."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: ""Rizia's economy is robust and d..."<br>`[124]` **Narrator**: ""Rizia's economy is a balanced m..."<br>*(oraz 1 innych odgałęzień)* |
| `[222]` | **"Living Standards and New Business."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: ""Living standards remain excelle..."<br>`[114]` **Narrator**: ""Living standards are good.""<br>*(oraz 1 innych odgałęzień)* |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, more paperwork. How delightful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get this over with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent. We shall retire to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. Let’s go through them together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""Thank you. Let’s go through them together.""*)
  - -> `[5]` (*Player_Romus: ""Excellent. We shall retire to my study.""*)
  - -> `[4]` (*Player_Romus: ""Let's get this over with.""*)
  - -> `[3]` (*Player_Romus: ""Ah, more paperwork. How delightful.""*)

### Węzeł `[8]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Angelica opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Angelica Sazon: ""Shall we begin with matters beyond our borders or those ..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Lucita followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "When we reached the study, we sat down, and Lucita opened..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Angelica followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "When we reached the study, we sat down, and Angelica open..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Sal followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "When we reached the study, we sat down, and Sal opened th..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Hugo followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "When we reached the study, we sat down, and Hugo opened t..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Axel followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "When we reached the study, we sat down, and Axel opened t..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: ""With one last glance at the butterflies, I stepped insid..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: ""With one last glance at the butterflies, I stepped insid..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "I took a moment to scan the contents, considering where to begin."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Axel == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: ""With one last glance at the butterflies, I stepped insid..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Angelica == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: ""With one last glance at the butterflies, I stepped insid..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: ""With one last glance at the butterflies, I stepped insid..."*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""So where would you like to begin today? Affairs abroad or governance at home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I took a moment to scan the contents, considering where t..."*)

### Węzeł `[28]`
Mówca: **Sal Ignacius**
> ""Where would you like to begin today, Your Majesty? Foreign affairs or domestic matters?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I took a moment to scan the contents, considering where t..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Lucita opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[30]`
Mówca: **Axel Reinhart**
> ""Where would you like to begin today, Your Majesty? Affairs abroad or matters at home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I took a moment to scan the contents, considering where t..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Axel opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Axel Reinhart: ""Where would you like to begin today, Your Majesty? Affai..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Sal opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Sal Ignacius: ""Where would you like to begin today, Your Majesty? Forei..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Hugo opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""So where would you like to begin today? Affairs abroad o..."*)

### Węzeł `[34]`
Mówca: **Lucita Azaro**
> ""Where would you like to begin today, Your Majesty? Affairs abroad or matters at home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I took a moment to scan the contents, considering where t..."*)

### Węzeł `[35]`
Mówca: **Angelica Sazon**
> ""Shall we begin with matters beyond our borders or those within them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I took a moment to scan the contents, considering where t..."*)

### Węzeł `[36]`
Mówca: **Lucita Azaro**
> ""Where would you like to begin today, Romus? Affairs abroad or matters at home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I took a moment to scan the contents, considering where t..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucita Azaro: ""Where would you like to begin today, Romus? Affairs abro..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucita Azaro: ""Where would you like to begin today, Your Majesty? Affai..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's begin with foreign affairs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_ForeignAffairs = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Sal Ignacius: ""Certainly, Your Majesty.""*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""Most certainly, Your Majesty.""*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Axel == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Axel Reinhart: ""Yes, of course, Your Majesty.""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Angelica == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Angelica Sazon: ""Of course, Your Majesty.""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[54]`
Mówca: **Axel Reinhart**
> ""Yes, of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)

### Węzeł `[55]`
Mówca: **Angelica Sazon**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)

### Węzeł `[57]`
Mówca: **Sal Ignacius**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""Most certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""Very well, Your Majesty""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucita Azaro: ""Very well.""*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucita Azaro: ""Very well, Your Majesty""*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""However, it has reduced the risk of foreign influence an..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_ANMember == false)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""I’d like to begin by addressing our decision to leave th..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_ANMember == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""As expected, leaving has isolated us on the world stage ..."*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We stand alone now. I only hope we stand strong enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras), `[87]` (Axel Reinhart), `[97]` (Angelica Sazon)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a tragedy -- to rule ourselves without permission.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras), `[87]` (Axel Reinhart), `[97]` (Angelica Sazon)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God’s will is not debated in foreign halls.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras), `[87]` (Axel Reinhart), `[97]` (Angelica Sazon)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia bows to no one. This was the only path forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras), `[87]` (Axel Reinhart), `[97]` (Angelica Sazon)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""God’s will is not debated in foreign halls.""*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh no, the AN misses us? They should've thought of that before trying to leash us."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras), `[87]` (Axel Reinhart), `[97]` (Angelica Sazon)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""Oh no, the AN misses us? They should've thought of that ..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have shut the door behind us. I only hope we haven't locked ourselves inside.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras), `[87]` (Axel Reinhart), `[97]` (Angelica Sazon)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""Rizia bows to no one. This was the only path forward.""*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[69]` (*Player_Romus: ""We stand alone now. I only hope we stand strong enough.""*)
  - -> `[70]` (*Player_Romus: ""What a tragedy -- to rule ourselves without permission.""*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[80]` (*Player_Romus: ""We have shut the door behind us. I only hope we haven't ..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_ANMember == false)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Sal Ignacius: ""I’d like to begin by addressing our decision to leave th..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_ANMember == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
Mówca: **Axel Reinhart**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Axel Reinhart: ""As expected, leaving has isolated us on the world stage ..."*)

### Węzeł `[86]`
Mówca: **Axel Reinhart**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Axel Reinhart: ""However, it has reduced the risk of foreign influence an..."*)

### Węzeł `[87]`
Mówca: **Axel Reinhart**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[88]`
Mówca: **Sal Ignacius**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Sal Ignacius: ""However, it has reduced the risk of foreign influence an..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_ANMember == false)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucita Azaro: ""I’d like to begin by addressing our decision to leave th..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_ANMember == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_ANMember == false)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Axel Reinhart: ""I’d like to begin by addressing our decision to leave th..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_ANMember == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
Mówca: **Angelica Sazon**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Angelica Sazon: ""As expected, leaving has isolated us on the world stage ..."*)

### Węzeł `[96]`
Mówca: **Sal Ignacius**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Sal Ignacius: ""As expected, leaving has isolated us on the world stage ..."*)

### Węzeł `[97]`
Mówca: **Angelica Sazon**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[98]`
Mówca: **Angelica Sazon**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Angelica Sazon: ""However, it has reduced the risk of foreign influence an..."*)

### Węzeł `[99]`
Mówca: **Sal Ignacius**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_ANMember == false"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_ANMember == false)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_ANMember == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Angelica Sazon: ""I’d like to begin by addressing our decision to leave th..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_ANMember == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucita Azaro: ""As expected, leaving has isolated us on the world stage ..."*)

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucita Azaro: ""However, it has reduced the risk of foreign influence an..."*)

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[106]`
Mówca: **Ovid Grecer**
> ""With Zille's vast reserves of gold and oil now under Rizia’s control, I hereby declare the region a development project to harness its resources, transforming it into a hub of industry.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In celebration of Zille's return, I hereby declare that the Gulf of Moridia shall henceforth be known as the Gulf of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To honor this occasion, I hereby order the removal of Smolak’s statues, which shall be unceremoniously cast into the Gulf of Rizia to form artificial reefs, fostering new life beneath the waves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As part of 'The Great Resettlement,' I hereby offer thousands of loyal Rizian families generous incentives to relocate to Zille and help build our future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Geopolitics == true || RiziaDLCIsolated.NewGov_Intermerkopum == true || RiziaDLCIsolated.NewGov_GRACE == true || RiziaDLCIsolated.NewGov_Goverment == true || RiziaDLCIsolated.NewGov_Zille == true || RiziaDLCIsolated.NewGov_Pales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Geopolitics == true || RiziaDLCIs..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Geopolitics == true || RiziaDLC..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Geopolitics == true || RiziaDLCIsolated.NewGov_Intermerkopum == true || RiziaDLCIsolated.NewGov_GRACE == true || RiziaDLCIsolated.NewGov_Goverment == true || RiziaDLCIsolated.NewGov_Zille == true || RiziaDLCIsolated.NewGov_Pales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Geopolitics"] == true  or  RiziaDLCIsolated.NewGov_Intermerkopum == true  or  RiziaDLCIsolated.NewGov_GRACE == true  or  Variable["RiziaDLCIsolated.NewGov_Goverment"] == true  or  Variable["RiziaDLCIsolated.NewGov_Zille"] == true  or  Variable["RiziaDLCIsolated.NewGov_Pales"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Geopolitics == true || RiziaDLCIsolated.NewGov_Intermerkopum == true || RiziaDLCIsolated.NewGov_GRACE == true || RiziaDLCIsolated.NewGov_Goverment == true || RiziaDLCIsolated.NewGov_Zille == true || RiziaDLCIsolated.NewGov_Pales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Geopolitics"] == true  or  RiziaDLCIsolated.NewGov_Intermerkopum == true  or  RiziaDLCIsolated.NewGov_GRACE == true  or  Variable["RiziaDLCIsolated.NewGov_Goverment"] == true  or  Variable["RiziaDLCIsolated.NewGov_Zille"] == true  or  Variable["RiziaDLCIsolated.NewGov_Pales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
Mówca: **Narrator**
> ""Living standards remain excellent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: ""Over 70% of Rizians own televisions, approximately half ..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> ""Living standards are good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: ""Over 50% of Rizians own televisions, many households hav..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> ""The latest report on living conditions indicates stability across the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: ""Standards remain largely unchanged from when you first a..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> ""The latest report on living conditions indicates stability across the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: ""Standards remain largely unchanged from when you first a..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> ""Living standards have worsened significantly, with families crammed into dilapidated homes or forced into homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: ""Water shortages are now commonplace, food prices have ri..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> ""Living standards have deteriorated severely, with families crammed into crumbling homes or simply becoming homeless altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: ""Water shortages have become routine, food prices have so..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> ""As for new businesses, they are flourishing, with a surge of small retail shops, diners, local factories, and service providers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: ""Increased demand and accessible loans have fueled this g..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> ""As for new businesses, they are growing steadily, from neighborhood stores to family-run restaurants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: ""However, many struggle to expand, facing competition fro..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> ""As for new businesses, their numbers are dwindling due to rising costs and limited access to credit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: ""Because of this, many entrepreneurs are forced to close ..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> ""As for new businesses, their numbers have plummeted, with most startups closing due to unaffordable rents, lack of capital, and stiff competition from established firms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: ""This has led to numerous empty storefronts across the ki..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> ""Rizia's economy is robust and diverse, combining energy production with growing sectors like manufacturing, services, and technology, providing a solid foundation for future growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Mixed == true"*)

### Węzeł `[124]`
Mówca: **Narrator**
> ""Rizia's economy is a balanced mix of energy resources, manufacturing, and agricultural sectors, providing steady growth, diversified income streams, and a strong foundation for future development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_ResourceBased == true"*)

### Węzeł `[125]`
Mówca: **Narrator**
> ""The economy is heavily dependent on energy resources, which dominate the market, providing substantial revenue and infrastructure development, though it leaves the kingdom vulnerable to global energy price fluctuations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 8"*)

### Węzeł `[126]`
Mówca: **Narrator**
> ""The Crown's overwhelmingly pro-business stance has fueled rapid economic growth and industry expansion, though critics argue it has concentrated wealth and influence into the hands of a powerful few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[127]`
Mówca: **Narrator**
> ""Overall, the energy crisis persists unabated, crippling industrial operational potential and stalling economic growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Daria == true"*)

### Węzeł `[128]`
Mówca: **Narrator**
> ""In terms of budget, the government's substantial reserves and investment capacity ensure financial stability and room for growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[129]`
Mówca: **Narrator**
> ""In terms of budget, the government's reserves remain balanced with moderate growth, allowing for some investments while maintaining fiscal responsibility, though there's little room for excess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[130]`
Mówca: **Narrator**
> ""In terms of the budget, the government is facing constraints, with limited resources and a focus on necessary expenses, making it difficult to fund larger projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[131]`
Mówca: **Narrator**
> ""In terms of the budget, the government is facing a deficit, requiring significant borrowing to cover essential costs and raising concerns about long-term financial stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[132]`
Mówca: **Narrator**
> ""Lastly, our energy revenue is booming, providing a robust financial foundation for the nation, fueling large-scale development and global influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[133]`
Mówca: **Narrator**
> ""Lastly, our energy income remains steady, supporting essential programs and investments, though it doesn't provide the extra cushion for expansive ventures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[134]`
Mówca: **Narrator**
> ""Lastly, our country's energy sector is underperforming, resulting in a tight budget with limited capacity for reinvestment or innovation in the sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[135]`
Mówca: **Narrator**
> ""Lastly, our energy resources are failing to generate meaningful revenue, leaving the government in a precarious financial position with increasing reliance on external sources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: ""As for new businesses, their numbers are dwindling due t..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: ""Overall, the energy crisis persists unabated, crippling ..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Daria == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: ""In terms of the budget, the government is facing a defic..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: ""Living standards remain excellent.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: ""Living standards are good.""*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Average == t..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: ""The latest report on living conditions indicates stabili..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == ..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Acceptable =..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: ""The latest report on living conditions indicates stabili..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: ""Living standards have worsened significantly, with famil..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == ..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: ""Living standards have deteriorated severely, with famili..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == t..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: ""As for new businesses, they are flourishing, with a surg..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == tr..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: ""As for new businesses, they are growing steadily, from n..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: ""As for new businesses, their numbers have plummeted, wit..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Daria == true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Diversified == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Diversified == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Diversified == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Diversified == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Diversified"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: ""Rizia's economy is robust and diverse, combining energy ..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Diversified == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Diversified"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Mixed == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Mixed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Mixed == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Mixed == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Mixed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Mixed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: ""Rizia's economy is a balanced mix of energy resources, m..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Mixed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Mixed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_ResourceBased == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_ResourceBased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_ResourceBased == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_ResourceBased == true)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_ResourceBased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_ResourceBased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: ""The economy is heavily dependent on energy resources, wh..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_ResourceBased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_ResourceBased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 8"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness < 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 8"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_ProBusiness < 8)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness < 8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] < 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: ""The Crown's overwhelmingly pro-business stance has fuele..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_ProBusiness < 8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] < 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: ""In terms of budget, the government's substantial reserve..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: ""In terms of budget, the government's reserves remain bal..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: ""In terms of the budget, the government is facing constra..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: ""Lastly, our energy revenue is booming, providing a robus..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: ""Lastly, our energy income remains steady, supporting ess..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: ""Lastly, our country's energy sector is underperforming, ..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: ""Lastly, our energy resources are failing to generate mea..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "Economy and Energy."]** — Mówca: **Player_Romus_Italic**
> "I picked up the report related to the economy and energy."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Diversified == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Goverment == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Goverment == false"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Goverment == false)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Goverment == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Goverment"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus_Italic: "Economy and Energy."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Goverment == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Goverment"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[209]`
Mówca: **Narrator**
> ""Over 70% of Rizians own televisions, approximately half of all homes have air conditioning, and personal cars are so common that weekend getaways and dining out have become routine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true"*)

### Węzeł `[210]`
Mówca: **Narrator**
> ""Over 50% of Rizians own televisions, many households have air conditioning, and personal cars are becoming more common, making weekend trips and dining out a regular luxury for many.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == true"*)

### Węzeł `[211]`
Mówca: **Narrator**
> ""Standards remain largely unchanged from when you first ascended the throne -- neither great strides nor sharp declines, but a steady course nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == ..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> ""Standards remain largely unchanged from when you first ascended the throne -- neither great strides nor sharp declines, but a steady course nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true"*)

### Węzeł `[213]`
Mówca: **Narrator**
> ""Water shortages are now commonplace, food prices have risen to unaffordable levels for many, and struggling clinics along with dwindling classrooms offer little hope for improvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true"*)

### Węzeł `[214]`
Mówca: **Narrator**
> ""Increased demand and accessible loans have fueled this growth, creating thousands of new jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true"*)

### Węzeł `[215]`
Mówca: **Narrator**
> ""However, many struggle to expand, facing competition from established chains and high operating costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)

### Węzeł `[216]`
Mówca: **Narrator**
> ""Because of this, many entrepreneurs are forced to close their doors, with only a few surviving in niche markets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true"*)

### Węzeł `[217]`
Mówca: **Narrator**
> ""This has led to numerous empty storefronts across the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Daria == true"*)

### Węzeł `[218]`
Mówca: **Narrator**
> ""Water shortages have become routine, food prices have soared beyond reach for many, and failing clinics and emptying classrooms leave little hope for relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Goverment == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Goverment == false"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Goverment == false)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Goverment == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Goverment"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player_Romus_Italic: "Living Standards and New Business."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Goverment == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Goverment"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
**[WYBÓR GRACZA: "Living Standards and New Business."]** — Mówca: **Player_Romus_Italic**
> "I picked up the report related to living standards and new business."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Resources_Energy <= 2 && RiziaDLC.Resources_EnergyModifiersTotal <= 1) || (RiziaDLC.Resources_Energy >= 4 && RiziaDLC.Resources_Energy <= 5 && RiziaDLC.Resources_EnergyModifiersTotal <= -4)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Resources_Energy <= 2 && RiziaDLC.Resources_Ene..."*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Resources_Energy <= 2 && RiziaDLC.Resources_E..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Resources_Energy <= 2 && RiziaDLC.Resources_EnergyModifiersTotal <= 1) || (RiziaDLC.Resources_Energy >= 4 && RiziaDLC.Resources_Energy <= 5 && RiziaDLC.Resources_EnergyModifiersTotal <= -4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] <= 2  and  Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1)  or  (Variable["RiziaDLC.Resources_Energy"] >= 4  and  Variable["RiziaDLC.Resources_Energy"] <= 5  and  Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= -4)`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Resources_Energy <= 2 && RiziaDLC.Resources_EnergyModifiersTotal <= 1) || (RiziaDLC.Resources_Energy >= 4 && RiziaDLC.Resources_Energy <= 5 && RiziaDLC.Resources_EnergyModifiersTotal <= -4))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Resources_Energy"] <= 2  and  Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1)  or  (Variable["RiziaDLC.Resources_Energy"] >= 4  and  Variable["RiziaDLC.Resources_Energy"] <= 5  and  Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= -4)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
Mówca: **Narrator**
> ""This concludes the report. Signed, Daria de Rava, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Treasury_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Daria == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Treasury_Daria == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Treasury_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Treasury_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: ""This concludes the report. Signed, Daria de Rava, Counci..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Treasury_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Treasury_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Rusty == true"*)

### Węzeł `[230]`
Mówca: **Narrator**
> ""That wraps up the report. Signed, Russello Montoro, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[231]`
Mówca: **Narrator**
> ""This concludes the report. Signed, Elena Werner, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[232]`
Mówca: **Narrator**
> ""This concludes the report. Signed, Daria de Rava, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Treasury_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Daria == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Treasury_Daria == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Treasury_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Treasury_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: ""This concludes the report. Signed, Daria de Rava, Counci..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Treasury_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Treasury_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Rusty == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Treasury_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Rusty == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Treasury_Rusty == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Treasury_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Treasury_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: ""That wraps up the report. Signed, Russello Montoro, Coun..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Treasury_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Treasury_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: ""This concludes the report. Signed, Elena Werner, Council..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Treasury_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Treasury_Rusty == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Treasury_Rusty == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Treasury_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Treasury_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: ""That wraps up the report. Signed, Russello Montoro, Coun..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Treasury_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Treasury_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: ""This concludes the report. Signed, Elena Werner, Council..."*)

### Węzeł `[242]`
Mówca: **Narrator**
> ""That wraps up the report. Signed, Russello Montoro, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[243]`
Mówca: **Narrator**
> ""This concludes the report. Signed, Elena Werner, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[244]`
Mówca: **Narrator**
> ""In terms of budget, the government's substantial reserves and investment capacity ensure financial stability and room for growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[245]`
Mówca: **Narrator**
> ""In terms of budget, the government's reserves remain balanced with moderate growth, allowing for some investments while maintaining fiscal responsibility, though there's little room for excess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[246]`
Mówca: **Narrator**
> ""In terms of the budget, the government is facing constraints, with limited resources and a focus on necessary expenses, making it difficult to fund larger projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[247]`
Mówca: **Narrator**
> ""In terms of the budget, the government is facing a deficit, requiring significant borrowing to cover essential costs and raising concerns about long-term financial stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: ""In terms of budget, the government's reserves remain bal..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: ""In terms of the budget, the government is facing constra..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: ""In terms of the budget, the government is facing a defic..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget + RiziaDLC.Resources_BudgetModifiersTotal >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget + RiziaDLC.Resources_BudgetModi..."*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget + RiziaDLC.Resources_BudgetMo..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget + RiziaDLC.Resources_BudgetModifiersTotal >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] + Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: ""In terms of budget, the government's substantial reserve..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget + RiziaDLC.Resources_BudgetModifiersTotal >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] + Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal"*)

### Węzeł `[261]`
Mówca: **Adarfo Sotelato**
> ""The House of Lords will begin its duties after the elections, though I doubt it will be anything but a drawn-out affair as they settle into their self-important roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Adarfo Sotelato: ""The political appointments are nearing completion, with ..."*)

### Węzeł `[262]`
Mówca: **Adarfo Sotelato**
> ""The political appointments are nearing completion, with noble families, scholars, and former statesmen -- all the usual suspects -- being selected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[263]`
Mówca: **Adarfo Sotelato**
> ""Given that they’ll hold equal power over laws, we can expect delays and complications as these 'blue bloods' bicker over every little detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Adarfo Sotelato: ""Until the new legislative building is constructed, they’..."*)

### Węzeł `[264]`
Mówca: **Adarfo Sotelato**
> ""Until the new legislative building is constructed, they’ll gather in the Grand Assembly Hall.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Adarfo Sotelato: ""Given that they’ll hold equal power over laws, we can ex..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Adarfo Sotelato: ""With their limited power, we shouldn't face much resista..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Adarfo Sotelato: ""Given their minimal influence on policy, we don’t expect..."*)

### Węzeł `[271]`
Mówca: **Adarfo Sotelato**
> ""With their limited power, we shouldn't face much resistance in passing legislation, though they'll still likely try to meddle for the sake of appearances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Adarfo Sotelato: ""Until the new legislative building is constructed, they’..."*)

### Węzeł `[272]`
Mówca: **Adarfo Sotelato**
> ""Given their minimal influence on policy, we don’t expect much interference; their role will be little more than ceremonial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Adarfo Sotelato: ""Which, if you ask me, is still far more than they deserv..."*)

### Węzeł `[273]`
Mówca: **Adarfo Sotelato**
> ""Which, if you ask me, is still far more than they deserve. Nevertheless""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Adarfo Sotelato: ""Until the new legislative building is constructed, they’..."*)

### Węzeł `[274]`
Mówca: **Manus Sazon**
> ""The formation of the Regional Senate is well underway, with candidates actively preparing for the upcoming elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "Manus Sazon: "...""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Manus Sazon: "..."`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[276]`
Mówca: **Manus Sazon**
> ""Given the Senate's equal authority to the lower chamber, we should expect longer debates and potential gridlock once established, as regional interests clash with national priorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Manus Sazon: ""Nevertheless, until the new legislative building is fini..."*)

### Węzeł `[277]`
Mówca: **Manus Sazon**
> ""Nevertheless, until the new legislative building is finished, they’ll convene in the Grand Assembly Hall.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Manus Sazon: ""Given the Senate's equal authority to the lower chamber,..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Manus Sazon: ""With their limited power, we shouldn't expect too many h..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Manus Sazon: ""However, given their limited power in shaping policy, we..."*)

### Węzeł `[284]`
Mówca: **Manus Sazon**
> ""With their limited power, we shouldn't expect too many hurdles when passing new legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Manus Sazon: ""Nevertheless, until the new legislative building is fini..."*)

### Węzeł `[285]`
Mówca: **Manus Sazon**
> ""However, given their limited power in shaping policy, we don’t expect much interference; their role will be more symbolic than impactful, as you well know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Manus Sazon: ""Nevertheless, until the new legislative building is fini..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Manus Sazon: ""The formation of the Regional Senate is well underway, w..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Daria de Rava: ""Your Majesty, the House of Lords will commence its dutie..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Adarfo Sotelato: ""Your Majesty, the House of Lords will begin its duties a..."*)

### Węzeł `[292]`
Mówca: **Daria de Rava**
> ""Your Majesty, the House of Lords will commence its duties after the elections, ensuring a seamless transition as they assume their responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Daria de Rava: ""The political appointments are nearly finalized, with se..."*)

### Węzeł `[293]`
Mówca: **Daria de Rava**
> ""The political appointments are nearly finalized, with selections from noble families, scholars, and former statesmen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[294]`
Mówca: **Daria de Rava**
> ""Given their equal power in shaping laws, we are prepared for potential delays and complications from a lengthy negotiation process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Daria de Rava: ""Until the new legislative building is complete, they’ll ..."*)

### Węzeł `[295]`
Mówca: **Daria de Rava**
> ""Until the new legislative building is complete, they’ll convene in the Grand Assembly Hall.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Daria de Rava: ""Given their equal power in shaping laws, we are prepared..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Daria de Rava: ""With their limited power, we shouldn't face many obstacl..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Daria de Rava: ""However, given their limited influence on policy, we don..."*)

### Węzeł `[302]`
Mówca: **Daria de Rava**
> ""With their limited power, we shouldn't face many obstacles when passing new legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Daria de Rava: ""Until the new legislative building is complete, they’ll ..."*)

### Węzeł `[303]`
Mówca: **Daria de Rava**
> ""However, given their limited influence on policy, we don’t expect much interference; their role will remain largely symbolic, as you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Daria de Rava: ""Until the new legislative building is complete, they’ll ..."*)

### Węzeł `[304]`
Mówca: **Adarfo Sotelato**
> ""The political appointments are nearing completion, with noble families, scholars, and former statesmen -- all the usual suspects -- being selected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Adarfo Sotelato: ""Given that they’ll hold equal power over laws, we can ex..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[308]`
Mówca: **Adarfo Sotelato**
> ""With their limited power, we shouldn't face much resistance in passing legislation, though they'll still likely try to meddle for the sake of appearances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Adarfo Sotelato: ""Until the new legislative building is constructed, they’..."*)

### Węzeł `[309]`
Mówca: **Adarfo Sotelato**
> ""Until the new legislative building is constructed, they’ll gather in the Grand Assembly Hall.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Adarfo Sotelato: ""With their limited power, we shouldn't face much resista..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Adarfo Sotelato: ""However, given their minimal influence on policy, we don..."*)

### Węzeł `[313]`
Mówca: **Adarfo Sotelato**
> ""However, given their minimal influence on policy, we don’t expect much interference; their role will be little more than ceremonial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Adarfo Sotelato: ""Which is exactly what they deserve.""*)

### Węzeł `[314]`
Mówca: **Adarfo Sotelato**
> ""Given that they’ll hold equal power over laws, we can expect delays and complications as these 'blue bloods' bicker over every little detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Adarfo Sotelato: ""Until the new legislative building is constructed, they’..."*)

### Węzeł `[315]`
Mówca: **Adarfo Sotelato**
> ""Your Majesty, the House of Lords will begin its duties after the elections, though I doubt it will be anything but a drawn-out affair as they settle into their self-important roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Adarfo Sotelato: ""The political appointments are nearing completion, with ..."*)

### Węzeł `[316]`
Mówca: **Adarfo Sotelato**
> ""Which is exactly what they deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Adarfo Sotelato: ""Until the new legislative building is constructed, they’..."*)

### Węzeł `[317]`
Mówca: **Manus Sazon**
> "“Voter registration is progressing well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Manus Sazon: ""Participation is high in the cities, though some of the ..."*)

### Węzeł `[318]`
Mówca: **Manus Sazon**
> ""Participation is high in the cities, though some of the more remote regions have been slower to respond.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Manus Sazon: "“Voter registration is progressing well, Your Majesty.""*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Daria de Rava: "“Voter registration is moving forward, Your Majesty.”"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Adarfo Sotelato: ""Voter registration is proceeding well.""*)

### Węzeł `[325]`
Mówca: **Daria de Rava**
> "“Voter registration is moving forward, Your Majesty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Daria de Rava: "“Cities are seeing strong participation, though some of t..."*)

### Węzeł `[326]`
Mówca: **Daria de Rava**
> "“Cities are seeing strong participation, though some of the more remote areas are slower to respond.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[327]`
Mówca: **Adarfo Sotelato**
> ""Voter registration is proceeding well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Adarfo Sotelato: ""Cities are seeing strong participation, however, the mor..."*)

### Węzeł `[328]`
Mówca: **Adarfo Sotelato**
> ""Cities are seeing strong participation, however, the more remote areas have been slower to respond.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
