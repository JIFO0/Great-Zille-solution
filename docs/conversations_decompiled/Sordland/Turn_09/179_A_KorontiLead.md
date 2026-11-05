# Sordland/Turn09/A_KorontiLead

- **ID konwersacji:** `179`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/179_A_KorontiLead.md`
- **Liczba węzłów dialogowych:** 187
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[44]** Lileas Graf
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Faction_Oligarchs_KorontiLeader`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Detained_MikailAven`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff`
- `BaseGame.Turn08_SnO_KorontiInvestigationStopped`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_Oligarchs_Ally`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Faction_Oligarchs_Destroyed`
- `BaseGame.Faction_Oligarchs_Enemy`
- `BaseGame.Faction_Oligarchs_KorontiLeader`
- `BaseGame.Leader_Oligarchs_WalterTusk`
- `BaseGame.Turn09_A_MarcelArrested`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_ArrestedLegally`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Detained`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Fled`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FledAndExtradited`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FoundDeadInPrison`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_LostControlOfHOS`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_NedamShares`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCAndNedamShares`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCShares`
- `BaseGameSupport.Journal_Turn09_KorontiLead_Arrest`
- `BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads`
- `BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_NotStopped`
- `BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_TippedOff`
- `GameCondition.Turn09_A_KorontiLead`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[15]` | **"“So what did he say?”"** | `[14]` **Lileas Graf**: "“An informant from HOS contacted..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Lileas Graf**: "“We have interrogated him thorou..."<br>`[19]` **Narrator**: "Karl stepped forward and bowed." |
| `[16]` | **"“Can we trust this informant?”"** | `[14]` **Lileas Graf**: "“An informant from HOS contacted..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Lileas Graf**: "“We have interrogated him thorou..."<br>`[19]` **Narrator**: "Karl stepped forward and bowed." |
| `[17]` | **"“Go on.”"** | `[14]` **Lileas Graf**: "“An informant from HOS contacted..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Lileas Graf**: "“We have interrogated him thorou..."<br>`[19]` **Narrator**: "Karl stepped forward and bowed." |
| `[22]` | **"“This can't be. This must be a ploy against HOS or Koronti.”"** | `[21]` **Karl Greiser**: "“Over the past three years, appr..."<br>`[115]` **Lileas Graf**: "“Over the past three years, appr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "Nia frowned at me." |
| `[27]` | **"“That settles it then. What is the plan?”"** | `[21]` **Karl Greiser**: "“Over the past three years, appr..."<br>`[115]` **Lileas Graf**: "“Over the past three years, appr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Nia Morgna**: "“The time has come. Frankly, we ..." |
| `[31]` | **"“Nothing. It's just hard to believe such a respectable business would stoop to thi..."** | `[26]` **Narrator**: "All eyes in the room turned to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Nia Morgna**: "“That is why none of these oliga..." |
| `[33]` | **"Stay silent."** | `[26]` **Narrator**: "All eyes in the room turned to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Nia Morgna**: "“Regardless of your uncertainty,..." |
| `[44]` | **"“Well done.”"** | `[43]` **Karl Greiser**: "“Mr. Koronti has been successful..."<br>`[122]` **Lileas Graf**: "“Mr. Koronti has been successful..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lileas Graf**: "“Now that he's been arrested, So..." |
| `[45]` | **"“I hope we caught the right person.”"** | `[43]` **Karl Greiser**: "“Mr. Koronti has been successful..."<br>`[122]` **Lileas Graf**: "“Mr. Koronti has been successful..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lileas Graf**: "“Now that he's been arrested, So..." |
| `[46]` | **"“There will be consequences for this.”"** | `[43]` **Karl Greiser**: "“Mr. Koronti has been successful..."<br>`[122]` **Lileas Graf**: "“Mr. Koronti has been successful..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Lileas Graf**: "“Of course, and our administrati..." |
| `[52]` | **"“As you said, one less traitor.”"** | `[48]` **Lileas Graf**: "“One way or another.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Lileas Graf**: "“Indeed.”" |
| `[53]` | **"“I am looking forward to the results.”"** | `[48]` **Lileas Graf**: "“One way or another.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lileas Graf**: "“We will bring them to you as qu..." |
| `[54]` | **"Nod."** | `[48]` **Lileas Graf**: "“One way or another.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Nia Morgna**: "“The news ought to break any mom..." |
| `[74]` | **"“Everyone is innocent until proven guilty, right?”"** | `[73]` **Lileas Graf**: "“No matter how much we probed in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lileas Graf**: "“There are many words that descr..." |
| `[75]` | **"“That is truly disappointing.”"** | `[73]` **Lileas Graf**: "“No matter how much we probed in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Lileas Graf**: "“No need to exaggerate. We will ..." |
| `[76]` | **"“Really?”"** | `[73]` **Lileas Graf**: "“No matter how much we probed in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lileas Graf**: "“Yes. Really.”" |
| `[82]` | **"“Make sure you don't let emotions affect your judgement.”"** | `[81]` **Lileas Graf**: "“I just wanted to let you know t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Lileas Graf**: "“Never.”" |
| `[83]` | **"“Good work, Lileas. Keep at it.”"** | `[81]` **Lileas Graf**: "“I just wanted to let you know t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Lileas Graf**: "“Thank you, Mr. President.”" |
| `[84]` | **"“In time, I am sure it will.”"** | `[81]` **Lileas Graf**: "“I just wanted to let you know t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lileas Graf**: "“We were so close to getting him."" |
| `[137]` | **"“In time, I am sure it will.”"** | `[157]` **Nia Morgna**: "“I just wanted to let you know t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Nia Morgna**: "“We were so close this time.”" |
| `[139]` | **"“Everyone is innocent until proven guilty, right?”"** | `[144]` **Nia Morgna**: "“No matter how much we probed in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Nia Morgna**: "“There are many words that descr..." |
| `[143]` | **"“Good work, Nia. Keep at it.”"** | `[157]` **Nia Morgna**: "“I just wanted to let you know t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Nia Morgna**: "“Thank you, Mr. President.”" |
| `[145]` | **"“Make sure you don't let emotions affect your judgement.”"** | `[157]` **Nia Morgna**: "“I just wanted to let you know t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Nia Morgna**: "“Never.”" |
| `[151]` | **"“That is truly disappointing.”"** | `[144]` **Nia Morgna**: "“No matter how much we probed in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Nia Morgna**: "“No need to exaggerate. We will ..." |
| `[152]` | **"“Really?”"** | `[144]` **Nia Morgna**: "“No matter how much we probed in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Nia Morgna**: "“Yes. Really.”" |

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
  - -> `[4]` (*Narrator: "I was walking down the corridor towards my office on the ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_A_KorontiLead = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_A_KorontiLead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true &&..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I was walking down the corridor towards my office on the way back from lunch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Right next to the door, Lileas, Nia and Karl were waiting. They approached me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lileas Graf: "“Mr. President.”"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Right next to the door, Lileas was waiting. She approached me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lileas Graf: "“Mr. President.”"*)

### Węzeł `[10]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: "“There has been an update on the Koronti investigation.”"*)

### Węzeł `[11]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lileas Graf: "“There has been an important update on the Koronti invest..."*)

### Węzeł `[12]`
Mówca: **Lileas Graf**
> "“There has been an important update on the Koronti investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "We entered the office."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "We entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lileas Graf: "“An informant from HOS contacted us. He was identified as..."*)

### Węzeł `[14]`
Mówca: **Lileas Graf**
> "“An informant from HOS contacted us. He was identified as a low-level executive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“So what did he say?”"*)
  - -> `[16]` (*Player: "“Can we trust this informant?”"*)
  - -> `[17]` (*Player: "“Go on.”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“So what did he say?”"]** — Mówca: **Player**
> "“So what did he say?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Can we trust this informant?”"]** — Mówca: **Player**
> "“Can we trust this informant?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[18]`
Mówca: **Karl Greiser**
> "“We have interrogated him thoroughly and confirmed the information he gave us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Karl Greiser: "“We now have proof that a subsidiary of HOS, Konrath Hold..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Karl stepped forward and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Karl Greiser: "“We have interrogated him thoroughly and confirmed the in..."*)

### Węzeł `[20]`
Mówca: **Karl Greiser**
> "“We now have proof that a subsidiary of HOS, Konrath Holdings, is a shell corporation engaged in money laundering for the Koranelli cartel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Karl Greiser: "“Over the past three years, approximately 15 million Sord..."*)

### Węzeł `[21]`
Mówca: **Karl Greiser**
> "“Over the past three years, approximately 15 million Sordish ren from the Koranellis' drug and weapons smuggling activities has gone through this corporation with Marcel Koronti's implicit approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“That settles it then. What is the plan?”"*)
  - -> `[22]` (*Player: "“This can't be. This must be a ploy against HOS or Koronti.”"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“This can't be. This must be a ploy against HOS or Koronti.”"]** — Mówca: **Player**
> "“This can't be. This must be a ploy against HOS or Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Karl Greiser), `[115]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Nia frowned at me."*)

### Węzeł `[23]`
Mówca: **Nia Morgna**
> "“Whatever you say, there is now enough evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Nia Morgna: "“Why are you so willing to protect HOS? Why is it so hard..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Nia frowned at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Nia Morgna: "“Whatever you say, there is now enough evidence.”"*)

### Węzeł `[25]`
Mówca: **Nia Morgna**
> "“Why are you so willing to protect HOS? Why is it so hard to believe?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "All eyes in the room turned to me."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "All eyes in the room turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Nothing. It's just hard to believe such a respectable bu..."*)
  - -> `[33]` (*Player_Italic: "Stay silent."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“That settles it then. What is the plan?”"]** — Mówca: **Player**
> "“That settles it then. What is the plan?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Karl Greiser), `[115]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Nia Morgna: "“The time has come. Frankly, we have been preparing for t..."*)

### Węzeł `[28]`
Mówca: **Nia Morgna**
> "“The time has come. Frankly, we have been preparing for this possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Nia Morgna: "“Please follow us to the comms room.”"*)

### Węzeł `[29]`
Mówca: **Nia Morgna**
> "“Please follow us to the comms room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Nia gestured towards the door and I followed the two wome..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Nia gestured towards the door and I followed the two women down the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "We descended the spiral staircase at the very edge of the..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Nothing. It's just hard to believe such a respectable business would stoop to this level.”"]** — Mówca: **Player**
> "“Nothing. It's just hard to believe such a respectable business would stoop to this level.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Nia Morgna: "“That is why none of these oligarchs can be trusted. They..."*)

### Węzeł `[32]`
Mówca: **Nia Morgna**
> "“That is why none of these oligarchs can be trusted. They would do anything for money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Nia Morgna: "“The time has come. Frankly, we have been preparing for t..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent and did not reply to her question."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Nia Morgna: "“Regardless of your uncertainty, we will move.”"*)

### Węzeł `[34]`
Mówca: **Nia Morgna**
> "“Regardless of your uncertainty, we will move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Nia Morgna: "“The time has come. Frankly, we have been preparing for t..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "We descended the spiral staircase at the very edge of the palace, close to where my office was located."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Going through narrower corridors than upstairs, we came i..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Going through narrower corridors than upstairs, we came in front of a large door with a shield and a goat carved on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Nia opened the door and we entered. After taking our seat..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Nia opened the door and we entered. After taking our seats, she gave me a sheepish look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Nia Morgna: "“Mr. President. I said we have been preparing for this op..."*)

### Węzeł `[38]`
Mówca: **Nia Morgna**
> "“Mr. President. I said we have been preparing for this opportunity, but that might've been an understatement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Nia Morgna: ""Our attack teams are ready to go. They've surrounded Mr...."*)

### Węzeł `[39]`
Mówca: **Nia Morgna**
> ""Our attack teams are ready to go. They've surrounded Mr. Koronti's villa in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[40]`
Mówca: **Narrator**
> "She nodded at Karl. Karl leaned forward and spoke into the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Karl Greiser: "“Begin.”"*)

### Węzeł `[41]`
Mówca: **Karl Greiser**
> "“Begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "We sat there for a few minutes, waiting anxiously. Finall..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "We sat there for a few minutes, waiting anxiously. Finally, Karl received a radio transmission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Karl Greiser: "“Mr. Koronti has been successfully captured.”"*)

### Węzeł `[43]`
Mówca: **Karl Greiser**
> "“Mr. Koronti has been successfully captured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“Well done.”"*)
  - -> `[45]` (*Player: "“I hope we caught the right person.”"*)
  - -> `[46]` (*Player: "“There will be consequences for this.”"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Well done.”"]** — Mówca: **Player**
> "“Well done.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Karl Greiser), `[122]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“Now that he's been arrested, Sordland will have one less..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I hope we caught the right person.”"]** — Mówca: **Player**
> "“I hope we caught the right person.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Karl Greiser), `[122]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“Now that he's been arrested, Sordland will have one less..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“There will be consequences for this.”"]** — Mówca: **Player**
> "“There will be consequences for this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Karl Greiser), `[122]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“Of course, and our administration will successfully hand..."*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“Now that he's been arrested, Sordland will have one less traitor. We will learn the truth from him directly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lileas Graf: "“All of his contacts, everyone he has been dealing with.”"*)

### Węzeł `[48]`
Mówca: **Lileas Graf**
> "“One way or another.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“I am looking forward to the results.”"*)
  - -> `[52]` (*Player: "“As you said, one less traitor.”"*)
  - -> `[54]` (*Player_Italic: "Nod."*)

### Węzeł `[49]`
Mówca: **Lileas Graf**
> "“All of his contacts, everyone he has been dealing with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Nia Morgna: "“I want to especially confirm the rumour about his contac..."*)

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“Of course, and our administration will successfully handle it. I am sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“Now that he's been arrested, Sordland will have one less..."*)

### Węzeł `[51]`
Mówca: **Nia Morgna**
> "“I want to especially confirm the rumour about his contact in the administration. We will squeeze every single drop of information we can out from him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lileas Graf: "“One way or another.”"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“As you said, one less traitor.”"]** — Mówca: **Player**
> "“As you said, one less traitor.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lileas Graf: "“Indeed.”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“I am looking forward to the results.”"]** — Mówca: **Player**
> "“I am looking forward to the results.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lileas Graf: "“We will bring them to you as quickly as possible.”"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Nia Morgna: "“The news ought to break any moment now.”"*)

### Węzeł `[55]`
Mówca: **Lileas Graf**
> "“We will bring them to you as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Nia Morgna: "“The news ought to break any moment now.”"*)

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Nia Morgna: "“The news ought to break any moment now.”"*)

### Węzeł `[57]`
Mówca: **Nia Morgna**
> "“The news ought to break any moment now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lileas Graf: "“This was all for today, Mr. President. We will keep you ..."*)

### Węzeł `[58]`
Mówca: **Lileas Graf**
> "“This was all for today, Mr. President. We will keep you posted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lileas Graf: "“Thank you for your time.”"*)

### Węzeł `[59]`
Mówca: **Lileas Graf**
> "“Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[60]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "They left one by one and I made my way back to my office."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "They left one by one and I made my way back to my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "This could be the end of my presidency. If Marcel talked,..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Sordland now felt a little bit safer now that Marcel had ..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "This could be the end of my presidency. If Marcel talked, everything could end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "There must be a way out of this."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "There must be a way out of this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_MarcelArrested = true"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Sordland now felt a little bit safer now that Marcel had been taken care of."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "For how long, I wondered."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "For how long, I wondered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_MarcelArrested = true"*)

### Węzeł `[69]`
Mówca: **Lileas Graf**
> "“There has been an update on the Koronti investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "We entered the office."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "We entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lileas Graf: "“Unfortunately we were not able to find any leads.”"*)

### Węzeł `[71]`
Mówca: **Lileas Graf**
> "“Unfortunately we were not able to find any leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lileas Graf: "“At this time, we will not be able to continue the invest..."*)

### Węzeł `[72]`
Mówca: **Lileas Graf**
> "“At this time, we will not be able to continue the investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lileas Graf: "“No matter how much we probed into HOS, no matter how man..."*)

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“No matter how much we probed into HOS, no matter how many employees we tried to get insider information from, their mouths were completely shut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“Everyone is innocent until proven guilty, right?”"*)
  - -> `[75]` (*Player: "“That is truly disappointing.”"*)
  - -> `[76]` (*Player: "“Really?”"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Everyone is innocent until proven guilty, right?”"]** — Mówca: **Player**
> "“Everyone is innocent until proven guilty, right?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lileas Graf: "“There are many words that describe HOS and Koronti and I..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“That is truly disappointing.”"]** — Mówca: **Player**
> "“That is truly disappointing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lileas Graf: "“No need to exaggerate. We will find something in the fut..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Really?”"]** — Mówca: **Player**
> "“Really?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lileas Graf: "“Yes. Really.”"*)

### Węzeł `[77]`
Mówca: **Lileas Graf**
> "“There are many words that describe HOS and Koronti and I still believe innocent is not one of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lileas Graf: "“Regardless, that doesn't change the fact that we are cur..."*)

### Węzeł `[78]`
Mówca: **Lileas Graf**
> "“Regardless, that doesn't change the fact that we are currently stuck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lileas Graf: "“I just wanted to let you know that I will keep my eyes o..."*)

### Węzeł `[79]`
Mówca: **Lileas Graf**
> "“No need to exaggerate. We will find something in the future. I am sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lileas Graf: "“Regardless, that doesn't change the fact that we are cur..."*)

### Węzeł `[80]`
Mówca: **Lileas Graf**
> "“Yes. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lileas Graf: "“Regardless, that doesn't change the fact that we are cur..."*)

### Węzeł `[81]`
Mówca: **Lileas Graf**
> "“I just wanted to let you know that I will keep my eyes open. I will make sure the truth comes out about HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "“Make sure you don't let emotions affect your judgement.”"*)
  - -> `[83]` (*Player: "“Good work, Lileas. Keep at it.”"*)
  - -> `[84]` (*Player: "“In time, I am sure it will.”"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Make sure you don't let emotions affect your judgement.”"]** — Mówca: **Player**
> "“Make sure you don't let emotions affect your judgement.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lileas Graf: "“Never.”"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Good work, Lileas. Keep at it.”"]** — Mówca: **Player**
> "“Good work, Lileas. Keep at it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lileas Graf: "“Thank you, Mr. President.”"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“In time, I am sure it will.”"]** — Mówca: **Player**
> "“In time, I am sure it will.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: "“We were so close to getting him.""*)

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“Never.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: "“Anyway. I won't take up more of your time.”"*)

### Węzeł `[86]`
Mówca: **Lileas Graf**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: "“Anyway. I won't take up more of your time.”"*)

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“We were so close to getting him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: "“Anyway. I won't take up more of your time.”"*)

### Węzeł `[88]`
Mówca: **Lileas Graf**
> "“Anyway. I won't take up more of your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lileas Graf: "“Have a nice day.”"*)

### Węzeł `[89]`
Mówca: **Lileas Graf**
> "“Have a nice day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseG..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "As soon as she turned her back to leave, I couldn't help but smirk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads = true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_MarcelArrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_MarcelArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Business_MarcelKoronti =..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MikailAven == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MikailAven == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_MikailAven == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MikailAven == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MikailAven"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Factions", "Position_Oligarch", "F..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_MikailAven == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MikailAven"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Factions", "Position_Oligarch", "F..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseG..."*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_KorontiLeader == true && Bas..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true  and  Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy = false"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true  and  Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "As soon as she turned her back to leave, I couldn't help ..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Enemy = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "As soon as she turned her back to leave, I couldn't help ..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_KorontiLeader == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_KorontiLeader == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_KorontiLeader == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_KorontiLeader == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == false"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_KorontiLeader == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_KorontiLead = true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == false"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == false)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_KorontiLeader = false;"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MikailAven == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_KorontiLeader = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Factions", "Position_Oligarch", "F..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Right next to the door, Lileas and Nia were waiting. They..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Right next to the door, Lileas, Nia and Karl were waiting..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Right next to the door, Lileas and Nia were waiting. They approached me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lileas Graf: "“Mr. President.”"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lileas Graf: "“We have interrogated him thoroughly and confirmed the in..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Karl stepped forward and bowed."*)

### Węzeł `[113]`
Mówca: **Lileas Graf**
> "“We have interrogated him thoroughly and confirmed the information he gave us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: "“We now have proof that a subsidiary of HOS, Konrath Hold..."*)

### Węzeł `[114]`
Mówca: **Lileas Graf**
> "“We now have proof that a subsidiary of HOS, Konrath Holdings, is a shell corporation engaged in money laundering for the Koranelli cartel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lileas Graf: "“Over the past three years, approximately 15 million Sord..."*)

### Węzeł `[115]`
Mówca: **Lileas Graf**
> "“Over the past three years, approximately 15 million Sordish ren from the Koranellis' drug and weapons smuggling activities has gone through this corporation with Marcel Koronti's implicit approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“That settles it then. What is the plan?”"*)
  - -> `[22]` (*Player: "“This can't be. This must be a ploy against HOS or Koronti.”"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Nia nodded to Lileas, who leaned forward and spoke into t..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She nodded at Karl. Karl leaned forward and spoke into th..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Nia nodded to Lileas, who leaned forward and spoke into the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lileas Graf: "“Begin.”"*)

### Węzeł `[120]`
Mówca: **Lileas Graf**
> "“Begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "We sat there for a few minutes, waiting anxiously. Finall..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "We sat there for a few minutes, waiting anxiously. Finally, Lileas received a radio transmission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lileas Graf: "“Mr. Koronti has been successfully captured.”"*)

### Węzeł `[122]`
Mówca: **Lileas Graf**
> "“Mr. Koronti has been successfully captured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“Well done.”"*)
  - -> `[45]` (*Player: "“I hope we caught the right person.”"*)
  - -> `[46]` (*Player: "“There will be consequences for this.”"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "They left and I made my way back to my office."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[126]`
Mówca: **Narrator**
> "They left and I made my way back to my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_KorontiLead = true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_KorontiLead_Arrest = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_KorontiLead_Arrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_KorontiLeader == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Right next to the door, Lileas was waiting. She approache..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Right next to the door, Nia was waiting. She approached me."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "Right next to the door, Nia was waiting. She approached me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Nia Morgna: "“Mr. President.”"*)

### Węzeł `[133]`
Mówca: **Nia Morgna**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Nia Morgna: "“There has been an update on the Koronti investigation.”"*)

### Węzeł `[134]`
Mówca: **Nia Morgna**
> "“There has been an update on the Koronti investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "We entered the office."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "We entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Nia Morgna: "“Unfortunately we were not able to find any leads.”"*)

### Węzeł `[136]`
Mówca: **Nia Morgna**
> "“Regardless, that doesn't change the fact that we are currently stuck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Nia Morgna: "“I just wanted to let you know that I will keep my eyes o..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“In time, I am sure it will.”"]** — Mówca: **Player**
> "“In time, I am sure it will.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Nia Morgna: "“We were so close this time.”"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "As soon as she turned her back to leave, I couldn't help but smirk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads = true"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“Everyone is innocent until proven guilty, right?”"]** — Mówca: **Player**
> "“Everyone is innocent until proven guilty, right?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Nia Morgna: "“There are many words that describe HOS and Koronti, and ..."*)

### Węzeł `[140]`
Mówca: **Nia Morgna**
> "“Unfortunately we were not able to find any leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Nia Morgna: "“At this time, we will not be able to continue the invest..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Enemy = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "As soon as she turned her back to leave, I couldn't help ..."*)

### Węzeł `[142]`
Mówca: **Nia Morgna**
> "“At this time, we will not be able to continue the investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Nia Morgna: "“No matter how much we probed into HOS, no matter how man..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“Good work, Nia. Keep at it.”"]** — Mówca: **Player**
> "“Good work, Nia. Keep at it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Nia Morgna: "“Thank you, Mr. President.”"*)

### Węzeł `[144]`
Mówca: **Nia Morgna**
> "“No matter how much we probed into HOS, no matter how many employees we tried to get insider information from, their mouths were completely shut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: "“Everyone is innocent until proven guilty, right?”"*)
  - -> `[151]` (*Player: "“That is truly disappointing.”"*)
  - -> `[152]` (*Player: "“Really?”"*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "“Make sure you don't let emotions affect your judgement.”"]** — Mówca: **Player**
> "“Make sure you don't let emotions affect your judgement.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Nia Morgna: "“Never.”"*)

### Węzeł `[146]`
Mówca: **Nia Morgna**
> "“Anyway. I won't take any more of your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Nia Morgna: "“Have a nice day.”"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseG..."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_KorontiLeader == true && Bas..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true  and  Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy = false"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true  and  Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "As soon as she turned her back to leave, I couldn't help ..."*)

### Węzeł `[150]`
Mówca: **Nia Morgna**
> "“We were so close this time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Nia Morgna: "“Anyway. I won't take any more of your time.”"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“That is truly disappointing.”"]** — Mówca: **Player**
> "“That is truly disappointing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Nia Morgna: "“No need to exaggerate. We will find something in the fut..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“Really?”"]** — Mówca: **Player**
> "“Really?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Nia Morgna: "“Yes. Really.”"*)

### Węzeł `[153]`
Mówca: **Nia Morgna**
> "“Have a nice day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseG..."*)

### Węzeł `[154]`
Mówca: **Nia Morgna**
> "“Yes. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Nia Morgna: "“Regardless, that doesn't change the fact that we are cur..."*)

### Węzeł `[155]`
Mówca: **Nia Morgna**
> "“No need to exaggerate. We will find something in the future. I am sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Nia Morgna: "“Regardless, that doesn't change the fact that we are cur..."*)

### Węzeł `[156]`
Mówca: **Nia Morgna**
> "“There are many words that describe HOS and Koronti, and I still believe innocent is not one of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Nia Morgna: "“Regardless, that doesn't change the fact that we are cur..."*)

### Węzeł `[157]`
Mówca: **Nia Morgna**
> "“I just wanted to let you know that I will keep my eyes open. I will make sure the truth comes out about HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: "“Make sure you don't let emotions affect your judgement.”"*)
  - -> `[143]` (*Player: "“Good work, Nia. Keep at it.”"*)
  - -> `[137]` (*Player: "“In time, I am sure it will.”"*)

### Węzeł `[158]`
Mówca: **Nia Morgna**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Nia Morgna: "“Anyway. I won't take any more of your time.”"*)

### Węzeł `[159]`
Mówca: **Nia Morgna**
> "“Never.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Nia Morgna: "“Anyway. I won't take any more of your time.”"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true &&..."*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true ..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true  and  Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Estord_Investigation_Korane..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true  and  Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_KorontiInvestigationStopped == false"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_TippedOff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_TippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_KorontiInvestigationStopped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_KorontiInvestigationStopped == false"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SnO_KorontiInvestigationStopped == false)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_KorontiInvestigationStopped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Estord_Investigation_Korane..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SnO_KorontiInvestigationStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_NotStopped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_NotStopped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Destroyed = true; BaseGame.Faction_Oligarchs_Enemy = false;
BaseGame.Faction_Oligarchs_Content = false;
BaseGame.Faction_Oligarchs_Ally = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] = true;
Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;
Variable["BaseGame.Faction_Oligarchs_Content"] = false;
Variable["BaseGame.Faction_Oligarchs_Ally"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_KorontiLead = true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Destroyed = false; BaseGame.Faction_Oligarchs_Enemy = true;
BaseGame.Faction_Oligarchs_Content = false;
BaseGame.Faction_Oligarchs_Ally = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] = false;
Variable["BaseGame.Faction_Oligarchs_Enemy"] = true;
Variable["BaseGame.Faction_Oligarchs_Content"] = false;
Variable["BaseGame.Faction_Oligarchs_Ally"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_KorontiLead = true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Business_MarcelKoronti = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_ArrestedLegally = true; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Detained = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Fled = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FledAndExtradited = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FoundDeadInPrison = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_LostControlOfHOS = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_NedamShares = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCAndNedamShares = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCShares = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_ArrestedLegally"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Detained"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Fled"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FledAndExtradited"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FoundDeadInPrison"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_LostControlOfHOS"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_NedamShares"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCAndNedamShares"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCShares"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_KorontiLead_Arrest = true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed = true; BaseGame.Fac..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Destroyed = true; BaseGame.Faction_Oligarchs_Enemy = false;
BaseGame.Faction_Oligarchs_Content = false;
BaseGame.Faction_Oligarchs_Ally = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] = true;
Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;
Variable["BaseGame.Faction_Oligarchs_Content"] = false;
Variable["BaseGame.Faction_Oligarchs_Ally"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed = false; BaseGame.Fa..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Destroyed = false; BaseGame.Faction_Oligarchs_Enemy = false;
BaseGame.Faction_Oligarchs_Content = false;
BaseGame.Faction_Oligarchs_Ally = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] = false;
Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;
Variable["BaseGame.Faction_Oligarchs_Content"] = false;
Variable["BaseGame.Faction_Oligarchs_Ally"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_EdithAgnoc");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_EdithAgnoc");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk = false"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_MikailAven");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_MikailAven");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk = false"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_WalterTusk");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_WalterTusk");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk = true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leader_Oligarchs_WalterTusk = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Leader_Oligarchs_WalterTusk"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed = true; BaseGame.Fac..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leader_Oligarchs_WalterTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Leader_Oligarchs_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed = false; BaseGame.Fa..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
