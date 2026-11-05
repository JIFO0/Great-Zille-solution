# Rizia/Turn 7/New Security Councilor Talk

- **ID konwersacji:** `396`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/396_New_Security_Councilor_Talk.md`
- **Liczba węzłów dialogowych:** 124
- **Liczba wyborów gracza:** 31

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Pales_AntiWar`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectHugo`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[494]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""How is she faring in prison, by the way?""** | `[3]` **Hugo Toras**: ""With Duchess Azaro now... indis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Hugo Toras**: ""She's in a high-end women's fac..." |
| `[6]` | **""I was going to ask you about that. Have you found any suitable candidates?""** | `[3]` **Hugo Toras**: ""With Duchess Azaro now... indis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Hugo Toras**: ""Two, in fact."" |
| `[7]` | **""I want a councilor who isn't a traitor.""** | `[3]` **Hugo Toras**: ""With Duchess Azaro now... indis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Hugo Toras**: ""A perfectly reasonable expectat..." |
| `[8]` | **""You mean a new war councilor.""** | `[3]` **Hugo Toras**: ""With Duchess Azaro now... indis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Hugo Toras**: ""We have avoided a second Pales ..." |
| `[15]` | **""He still wants to serve me after I jailed his daughter?""** | `[14]` **Hugo Toras**: ""Give him another few months, an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Hugo Toras**: ""Apparently. Which surprises me,..."<br>`[36]` **Hugo Toras**: ""You have been a friend to House..." |
| `[16]` | **""Why, that's excellent news. It'll be as if this whole unpleasantness with Lucita ..."** | `[14]` **Hugo Toras**: ""Give him another few months, an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Hugo Toras**: ""I doubt that. House Azaro holds..."<br>`[31]` **Hugo Toras**: ""General Taddeus is not one to f..." |
| `[17]` | **""Oh. I must say that I dread that prospect, especially given the circumstances.""** | `[14]` **Hugo Toras**: ""Give him another few months, an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Hugo Toras**: ""I don't blame you. House Azaro ..."<br>`[72]` **Hugo Toras**: ""Is that so, Your Majesty? The G..." |
| `[21]` | **""Is that so? I'm looking forward to working with him again.""** | `[14]` **Hugo Toras**: ""Give him another few months, an..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[25]` **Hugo Toras**: ""The feeling may not be mutual. ..."<br>`[26]` **Hugo Toras**: ""The feeling is mutual, it seems..." |
| `[50]` | **""I can't kill her? I was looking forward to a good old-fashioned beheading.""** | `[38]` **Hugo Toras**: ""I have no doubt of his loyalty ..."<br>`[42]` **Hugo Toras**: ""However, with the threat of the..." | `Variable["RiziaDLC.Trait_TyrantKing"]` | *Brak zmian stanu* | `[59]` **Hugo Toras**: ""If that is what you insist, the..." |
| `[51]` | **""The death penalty is standard for traitors to our kingdom. I'm afraid I can't mak..."** | `[38]` **Hugo Toras**: ""I have no doubt of his loyalty ..."<br>`[42]` **Hugo Toras**: ""However, with the threat of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Hugo Toras**: ""If that is what you insist, the..." |
| `[55]` | **""I would never execute Duchess Azaro. I still harbor fond feelings for her, you kn..."** | `[38]` **Hugo Toras**: ""I have no doubt of his loyalty ..."<br>`[42]` **Hugo Toras**: ""However, with the threat of the..." | `Variable["RiziaDLC.Lucita_RomanceHappened"] == true` | *Brak zmian stanu* | `[61]` **Hugo Toras**: ""I suspected the two of you were..." |
| `[56]` | **""I would never execute Duchess Azaro. All of Cardesse-Montaklar would turn on me i..."** | `[38]` **Hugo Toras**: ""I have no doubt of his loyalty ..."<br>`[42]` **Hugo Toras**: ""However, with the threat of the..." | `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false` | *Brak zmian stanu* | `[60]` **Hugo Toras**: ""Yes, ordering the death of such..." |
| `[57]` | **""The Palesians will be expecting an execution, won't they?""** | `[38]` **Hugo Toras**: ""I have no doubt of his loyalty ..."<br>`[42]` **Hugo Toras**: ""However, with the threat of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Hugo Toras**: ""As long as treason to Rizia is ..." |
| `[63]` | **""So what you're saying is that I should throw him in jail as well.""** | `[37]` **Hugo Toras**: ""He has shown exceptional loyalt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "He smiled darkly." |
| `[64]` | **""The man's a patriot. He knows that Rizia's security comes before his petty famili..."** | `[37]` **Hugo Toras**: ""He has shown exceptional loyalt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Hugo Toras**: ""It is more complicated than tha..." |
| `[65]` | **""He got us into an unnecessary war. I'm not chomping at the bit to have him back.""** | `[37]` **Hugo Toras**: ""He has shown exceptional loyalt..." | `Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true` | *Brak zmian stanu* | `[83]` **Hugo Toras**: ""He was instrumental in restorin..." |
| `[74]` | **""The man's a patriot. He knows that Rizia's security comes before his petty famili..."** | `[46]` **Hugo Toras**: ""He has shown exceptional loyalt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Hugo Toras**: ""One would hope so."" |
| `[75]` | **""On the other hand... he got us into an unnecessary war. I'm not chomping at the b..."** | `[46]` **Hugo Toras**: ""He has shown exceptional loyalt..." | `Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true` | *Brak zmian stanu* | `[83]` **Hugo Toras**: ""He was instrumental in restorin..." |
| `[79]` | **""On the other hand... the uprising was his fault. I'm not chomping at the bit to h..."** | `[46]` **Hugo Toras**: ""He has shown exceptional loyalt..." | `(Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true) == false` | *Brak zmian stanu* | `[84]` **Hugo Toras**: ""The uprising had many causes. A..." |
| `[80]` | **""Aside from that, the uprising was his fault. I'm not chomping at the bit to have ..."** | `[37]` **Hugo Toras**: ""He has shown exceptional loyalt..." | `(Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true) == false` | *Brak zmian stanu* | `[84]` **Hugo Toras**: ""The uprising had many causes. A..." |
| `[81]` | **""And what repercussions can I expect from the Azaros if I don't give him his counc..."** | `[37]` **Hugo Toras**: ""He has shown exceptional loyalt..."<br>`[46]` **Hugo Toras**: ""He has shown exceptional loyalt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""Obviously, they would prefer it..." |
| `[89]` | **""Titus already commands his own security detail. Naming him councilor would only b..."** | `[94]` **Narrator**: "He nodded towards the door." | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true` | *Brak zmian stanu* | `[105]` **Hugo Toras**: ""His conduct as head of the Gold..." |
| `[93]` | **""Titus already has an important assignment. I don't want to dilute his focus by pu..."** | `[94]` **Narrator**: "He nodded towards the door." | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true` | *Brak zmian stanu* | `[106]` **Hugo Toras**: ""With Rizia's national security ..." |
| `[95]` | **""That meathead, in charge of security? I want him taking bullets for me, not comma..."** | `[94]` **Narrator**: "He nodded towards the door." | `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[101]` **Hugo Toras**: ""Perhaps his unconventional back..." |
| `[96]` | **""I know Titus is still sore I never expanded the Golden Guard. Naming him security..."** | `[94]` **Narrator**: "He nodded towards the door." | `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[102]` **Hugo Toras**: ""Captain Gordion is a profession..." |
| `[97]` | **""A security councilor with no house and no agenda to push... It could be a refresh..."** | `[94]` **Narrator**: "He nodded towards the door." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Hugo Toras**: ""His services have been indispen..." |
| `[98]` | **""Titus? Really? What makes you think he can be trusted?""** | `[94]` **Narrator**: "He nodded towards the door." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Hugo Toras**: ""He has been by your side since ..." |
| `[112]` | **""That's interesting. What'd my father say?""** | `[111]` **Hugo Toras**: ""You may not know this, but Capt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Hugo Toras**: ""He appeared interested. However..." |
| `[114]` | **""My father should have said yes. Look what happened with Lucita.""** | `[111]` **Hugo Toras**: ""You may not know this, but Capt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Hugo Toras**: ""He couldn't have known. None of..." |
| `[116]` | **""That power-grubber. My father never even expanded the Golden Guard.""** | `[111]` **Hugo Toras**: ""You may not know this, but Capt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Hugo Toras**: ""Perhaps he would have, had he l..." |
| `[118]` | **""But my father didn't think he was ready yet.""** | `[111]` **Hugo Toras**: ""You may not know this, but Capt..." | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true` | *Brak zmian stanu* | `[122]` **Narrator**: "Hugo frowned." |

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
  - -> `[3]` (*Hugo Toras: ""With Duchess Azaro now... indisposed, it is imperative t..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""With Duchess Azaro now... indisposed, it is imperative that you choose a new security councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""How is she faring in prison, by the way?""*)
  - -> `[6]` (*Player_Romus: ""I was going to ask you about that. Have you found any su..."*)
  - -> `[7]` (*Player_Romus: ""I want a councilor who isn't a traitor.""*)
  - -> `[8]` (*Player_Romus: ""You mean a new war councilor.""*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is she faring in prison, by the way?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""She's in a high-end women's facility within the Porte Dr..."*)

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""She's in a high-end women's facility within the Porte Drazon Citadel. I would not worry about her treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Hugo Toras: ""As to candidates for her successor...""*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was going to ask you about that. Have you found any suitable candidates?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""Two, in fact.""*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want a councilor who isn't a traitor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""A perfectly reasonable expectation.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You mean a new war councilor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""We have avoided a second Pales conflict. Lord willing, w..."*)

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""We have avoided a second Pales conflict. Lord willing, we will not be entering another war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""Incredibly, it seems that General Taddeus Azaro is on tr..."*)

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""A perfectly reasonable expectation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""Incredibly, it seems that General Taddeus Azaro is on tr..."*)

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Two, in fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""Incredibly, it seems that General Taddeus Azaro is on tr..."*)

### Węzeł `[12]`
Mówca: **Hugo Toras**
> ""As to candidates for her successor...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""Incredibly, it seems that General Taddeus Azaro is on tr..."*)

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""Incredibly, it seems that General Taddeus Azaro is on track to make a full recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Hugo Toras: ""Give him another few months, and he will be ready to res..."*)

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""Give him another few months, and he will be ready to resume his former position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""He still wants to serve me after I jailed his daughter?""*)
  - -> `[16]` (*Player_Romus: ""Why, that's excellent news. It'll be as if this whole un..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[17]` (*Player_Romus: ""Oh. I must say that I dread that prospect, especially gi..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He still wants to serve me after I jailed his daughter?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why, that's excellent news. It'll be as if this whole unpleasantness with Lucita never occurred.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. I must say that I dread that prospect, especially given the circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""Is that so? I'm looking forward to working with him again.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that so? I'm looking forward to working with him again.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[14]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro < 0)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Hugo Toras: ""The feeling may not be mutual. House Azaro had qualms ab..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Hugo Toras: ""The feeling is mutual, it seems. Even after the arrest o..."*)

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""The feeling may not be mutual. House Azaro had qualms about your reign even before you jailed their heiress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""The feeling is mutual, it seems. Even after the arrest of House Azaro's heiress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro < 0)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Hugo Toras: ""I doubt that. House Azaro holds grudges for a long time,..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""General Taddeus is not one to forgive and forget, Your M..."*)

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""I doubt that. House Azaro holds grudges for a long time, and General Taddeus is not one to forgive and forget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""General Taddeus is not one to forgive and forget, Your Majesty. But you have been a friend to his house throughout your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro < 0)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""Apparently. Which surprises me, given that General Tadde..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""You have been a friend to House Azaro. Perhaps enough so..."*)

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""Apparently. Which surprises me, given that General Taddeus is not one to forgive and forget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""You have been a friend to House Azaro. Perhaps enough so that he is willing to overlook this incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""He has shown exceptional loyalty to the Crown in the past. But now? I confess I am not certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""And what repercussions can I expect from the Azaros if I..."*)
  - -> `[63]` (*Player_Romus: ""So what you're saying is that I should throw him in jail..."*)
  - -> `[64]` (*Player_Romus: ""The man's a patriot. He knows that Rizia's security come..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_AntiWar == true"*)

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""I have no doubt of his loyalty to the Crown. As long as you keep his daughter alive, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)
  - -> `[51]` (*Player_Romus: ""The death penalty is standard for traitors to our kingdo..."*)
  - -> `[57]` (*Player_Romus: ""The Palesians will be expecting an execution, won't they?""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""However, with the threat of the Duchess' execution hangi..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Hugo Toras: ""He has shown exceptional loyalty to the Crown in the pas..."*)

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""However, with the threat of the Duchess' execution hanging over his head, I have no doubt he will be loyal to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)
  - -> `[51]` (*Player_Romus: ""The death penalty is standard for traitors to our kingdo..."*)
  - -> `[57]` (*Player_Romus: ""The Palesians will be expecting an execution, won't they?""*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""I have no doubt of his loyalty to the Crown. As long as ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Hugo Toras: ""He has shown exceptional loyalty to the Crown in the pas..."*)

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""He has shown exceptional loyalty to the Crown in the past. I have faith he will now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""The man's a patriot. He knows that Rizia's security come..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_AntiWar == true"*)
  - -> `[81]` (*Player_Romus: ""And what repercussions can I expect from the Azaros if I..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""I can't kill her? I was looking forward to a good old-fa..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't kill her? I was looking forward to a good old-fashioned beheading.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"]`
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hugo Toras: ""If that is what you insist, then I suggest you keep Gene..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The death penalty is standard for traitors to our kingdom. I'm afraid I can't make an exception.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hugo Toras: ""If that is what you insist, then I suggest you keep Gene..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RomanceHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RomanceHappened == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RomanceHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""I would never execute Duchess Azaro. I still harbor fond..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RomanceHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""I would never execute Duchess Azaro. All of Cardesse-Mon..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never execute Duchess Azaro. I still harbor fond feelings for her, you know.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""I suspected the two of you were close. It's for the best..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never execute Duchess Azaro. All of Cardesse-Montaklar would turn on me in an instant.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""Yes, ordering the death of such a prominent noble is bou..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Palesians will be expecting an execution, won't they?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""As long as treason to Rizia is punishable by death, then..."*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""As long as treason to Rizia is punishable by death, then yes, they will take umbrage if you make an exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""If that is what you insist, then I suggest you keep General Taddeus far from these halls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""Yes, ordering the death of such a prominent noble is bound to have repercussions. Even if her father is not restored to his former position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""I suspected the two of you were close. It's for the best that nothing came of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""I do have one other qualified candidate in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "He nodded towards the door."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So what you're saying is that I should throw him in jail as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He smiled darkly."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man's a patriot. He knows that Rizia's security comes before his petty familial concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""It is more complicated than that. House Azaro and nation..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He got us into an unnecessary war. I'm not chomping at the bit to have him back.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Hugo Toras: ""He was instrumental in restoring stability after the con..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Pales_AntiWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_AntiWar == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Pales_AntiWar == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Pales_AntiWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""He got us into an unnecessary war. I'm not chomping at t..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Pales_AntiWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""Aside from that, the uprising was his fault. I'm not cho..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro < 0)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Hugo Toras: ""I don't blame you. House Azaro had qualms about your rei..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Hugo Toras: ""Is that so, Your Majesty? The General may not be one to ..."*)

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""Is that so, Your Majesty? The General may not be one to forgive and forget, but you have secured House Azaro's favor up to this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""I don't blame you. House Azaro had qualms about your reign even before you jailed their heiress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false"*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man's a patriot. He knows that Rizia's security comes before his petty familial concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""One would hope so.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the other hand... he got us into an unnecessary war. I'm not chomping at the bit to have him back.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Hugo Toras: ""He was instrumental in restoring stability after the con..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Pales_AntiWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_AntiWar == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Pales_AntiWar == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Pales_AntiWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""On the other hand... he got us into an unnecessary war. ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Pales_AntiWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: ""On the other hand... the uprising was his fault. I'm not..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the other hand... the uprising was his fault. I'm not chomping at the bit to have him back.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Hugo Toras: ""The uprising had many causes. And the General was instru..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aside from that, the uprising was his fault. I'm not chomping at the bit to have him back.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Hugo Toras: ""The uprising had many causes. And the General was instru..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what repercussions can I expect from the Azaros if I don't give him his council seat back?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Hugo Toras), `[46]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""Obviously, they would prefer it if the council seat went..."*)

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""One would hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""He was instrumental in restoring stability after the conflict. Two decades without a major incident is nothing to sniff at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""The uprising had many causes. And the General was instrumental in restoring stability afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Obviously, they would prefer it if the council seat went to their house. But they will understand if you have lingering concerns about the General's health.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[86]`
Mówca: **Narrator**
> "He smiled darkly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Hugo Toras: ""Not unless you want all of Cardesse-Montaklar rioting in..."*)

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""Not unless you want all of Cardesse-Montaklar rioting in the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""It is more complicated than that. House Azaro and national security have been synonymous for many years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I do have one other qualified candidate in mind.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus already commands his own security detail. Naming him councilor would only be natural.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: ""His conduct as head of the Golden Guard has been beyond ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Titus already commands his own security detail. Naming h..."*)
  - -> `[93]` (*Player_Romus: ""Titus already has an important assignment. I don't want ..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Romus: ""That meathead, in charge of security? I want him taking ..."*)
  - -> `[96]` (*Player_Romus: ""I know Titus is still sore I never expanded the Golden G..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus already has an important assignment. I don't want to dilute his focus by putting him on the council.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Hugo Toras: ""With Rizia's national security apparatus at his disposal..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "He nodded towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[97]` (*Player_Romus: ""A security councilor with no house and no agenda to push..."*)
  - -> `[98]` (*Player_Romus: ""Titus? Really? What makes you think he can be trusted?""*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That meathead, in charge of security? I want him taking bullets for me, not commanding our armies.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Hugo Toras: ""Perhaps his unconventional background will give him an e..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know Titus is still sore I never expanded the Golden Guard. Naming him security councilor would more than make up for that.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Hugo Toras: ""Captain Gordion is a professional. He would not resent y..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A security councilor with no house and no agenda to push... It could be a refreshing change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Hugo Toras: ""His services have been indispensable in keeping the Roya..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus? Really? What makes you think he can be trusted?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Hugo Toras: ""He has been by your side since your coronation. And his ..."*)

### Węzeł `[99]`
Mówca: **Hugo Toras**
> ""He has been by your side since your coronation. And his conduct has been beyond reproach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""Such loyalty should not go unrewarded.""*)

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""Such loyalty should not go unrewarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""You may not know this, but Captain Gordion petitioned Ki..."*)

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""Perhaps his unconventional background will give him an edge in devising national security strategies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Hugo Toras: ""It's true that he has no experience with military operat..."*)

### Węzeł `[102]`
Mówca: **Hugo Toras**
> ""Captain Gordion is a professional. He would not resent you for a decision you made so early on in your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Hugo Toras: ""I am confident he would make as trustworthy a councilor ..."*)

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""His services have been indispensable in keeping the Royal Family safe. And what is Rizia, if not one extended royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He smiled."*)

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""On the other hand, concentrating that much power in the hands of one man could prove dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""You may not know this, but Captain Gordion petitioned Ki..."*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""His conduct as head of the Golden Guard has been beyond reproach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Hugo Toras: ""On the other hand, concentrating that much power in the ..."*)

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""With Rizia's national security apparatus at his disposal, he could easily handle both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Hugo Toras: ""On the other hand, concentrating that much power in the ..."*)

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""I am confident he would make as trustworthy a councilor as he has a bodyguard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""You may not know this, but Captain Gordion petitioned Ki..."*)

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""It's true that he has no experience with military operations. But then again, we are not at war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""You may not know this, but Captain Gordion petitioned Ki..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""You may not know this, but Captain Gordion petitioned Ki..."*)

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""At any rate, I will leave the decision up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""You may not know this, but Captain Gordion petitioned King Valero about the interim security councilor position after General Azaro fell ill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""That's interesting. What'd my father say?""*)
  - -> `[114]` (*Player_Romus: ""My father should have said yes. Look what happened with ..."*)
  - -> `[116]` (*Player_Romus: ""That power-grubber. My father never even expanded the Go..."*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true"*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's interesting. What'd my father say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Hugo Toras: ""He appeared interested. However, he signed the order for..."*)

### Węzeł `[113]`
Mówca: **Hugo Toras**
> ""He appeared interested. However, he signed the order for Duchess Azaro to fill the position without so much as interviewing the Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""At any rate, I will leave the decision up to you.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father should have said yes. Look what happened with Lucita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Hugo Toras: ""He couldn't have known. None of us did.""*)

### Węzeł `[115]`
Mówca: **Hugo Toras**
> ""He couldn't have known. None of us did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""At any rate, I will leave the decision up to you.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That power-grubber. My father never even expanded the Golden Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Hugo Toras: ""Perhaps he would have, had he lived.""*)

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""Perhaps he would have, had he lived.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""At any rate, I will leave the decision up to you.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But my father didn't think he was ready yet.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Hugo frowned."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""But my father didn't think he was ready yet.""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
Mówca: **Narrator**
> "Hugo frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Hugo Toras: ""He said no such thing. He told me he was considering the..."*)

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""He said no such thing. He told me he was considering the possibility, in fact. But House Azaro took precedence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""At any rate, I will leave the decision up to you.""*)
