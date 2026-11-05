# Sordland/Turn09/Tusk Investigation

- **ID konwersacji:** `191`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/191_Tusk_Investigation.md`
- **Liczba węzłów dialogowych:** 135
- **Liczba wyborów gracza:** 19

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Leader_Oligarchs_WalterTusk`
- `BaseGame.Oligarchs_Extradited`
- `BaseGame.Reform_PresiPower_Strong_CapitalPunishment`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Detained_MikailAven`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_Fled_MarcelKoronti`
- `BaseGame.Turn07_Fled_WalterTusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence`
- `BaseGame.Turn09_A_MarcelArrested`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_Oligarchs_KorontiLeader`
- `BaseGame.Leader_Oligarchs_WalterTusk`
- `BaseGame.SecretState_LucianKnowsSSPKills`
- `BaseGame.Turn09_A_Investigation_Oligarchs_ExtendTuskSentence`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeRevealed`
- `BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia`
- `BaseGameSupport.Journal_Turn09_Investigations_ExtendTuskSentence`
- `BaseGameSupport.Journal_Turn09_Investigations_KillTusk`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialTusk`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialTuskInAbsentia`
- `BaseGameSupport.Journal_Turn09_Investigations_TuskBribeRevealed`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[68]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""Yes. I hope he hangs.""** | `[89]` **Lucian Galade**: ""Shall we ask him? And order Tus..."<br>`[90]` **Lucian Galade**: ""Would you like to go forth with..." | `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`<br>`Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true` | *Brak zmian stanu* | `[63]` **Narrator**: "Lucian nodded smoothly." |
| `[19]` | **""I suppose it's my only choice.""** | `[105]` **Lucian Galade**: ""Would you like to go forth with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "Lucian nodded smoothly." |
| `[20]` | **""No. I can use that information as leverage to make him do what I want.""** | `[90]` **Lucian Galade**: ""Would you like to go forth with..." | `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true` | *Brak zmian stanu* | `[15]` **Narrator**: "Lucian looked at me questioningl..." |
| `[21]` | **""Arrest? I want him killed!""** | `[90]` **Lucian Galade**: ""Would you like to go forth with..." | `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false` | *Brak zmian stanu* | `[51]` **Narrator**: "Lucian looked at me questioningl..." |
| `[27]` | **""That traitor!""** | `[10]` **Lucian Galade**: ""One of his corporation's subsid..." | `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false` | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""This is treason on the highest ..." |
| `[28]` | **""Prison's too good for him.""** | `[10]` **Lucian Galade**: ""One of his corporation's subsid..." | `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true` | *Brak zmian stanu* | `[43]` **Lucian Galade**: ""You didn't hear this from me, s..."<br>`[54]` **Lucian Galade**: ""Yes, given the constraints of t..." |
| `[29]` | **""What can we do? He's already in jail.""** | `[10]` **Lucian Galade**: ""One of his corporation's subsid..." | `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true` | *Brak zmian stanu* | `[43]` **Lucian Galade**: ""You didn't hear this from me, s..."<br>`[54]` **Lucian Galade**: ""Yes, given the constraints of t..." |
| `[30]` | **""That's it? Everyone already knows he'd do anything for a ren.""** | `[10]` **Lucian Galade**: ""One of his corporation's subsid..." | `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false` | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""This is treason on the highest ..." |
| `[31]` | **""What can we do? He's still in Arcasia.""** | `[10]` **Lucian Galade**: ""One of his corporation's subsid..." | `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false`<br>`(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false` | *Brak zmian stanu* | `[94]` **Lucian Galade**: ""I'm sure President Walker would..."<br>`[48]` **Lucian Galade**: ""It may be possible to trial him..." |
| `[42]` | **""No, it's a waste of time.""** | `[88]` **Lucian Galade**: ""Would you like to go forth with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "Lucian looked at me questioningl..." |
| `[44]` | **""I suppose it's my only choice.""** | `[88]` **Lucian Galade**: ""Would you like to go forth with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "Lucian nodded smoothly." |
| `[45]` | **""No, it's a waste of time.""** | `[89]` **Lucian Galade**: ""Shall we ask him? And order Tus..."<br>`[105]` **Lucian Galade**: ""Would you like to go forth with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "Lucian looked at me questioningl..." |
| `[46]` | **""No, that'd attract too much suspicion. I'd rather just let him rot in there.""** | `[43]` **Lucian Galade**: ""You didn't hear this from me, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Lucian Galade**: ""Very well, sir."" |
| `[47]` | **""It'd certainly be unfortunate if Tusk were to be the victim of such an accident. ..."** | `[43]` **Lucian Galade**: ""You didn't hear this from me, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucian Galade**: ""I'll make some phone calls, sir."" |
| `[50]` | **""I believe he called it a gesture of goodwill.""** | `[53]` **Lucian Galade**: ""Sir, did you accept a bribe fro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "Lucian's eyes darkened." |
| `[66]` | **""We may have... come to a place of mutual understanding.""** | `[53]` **Lucian Galade**: ""Sir, did you accept a bribe fro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "Lucian's eyes darkened." |
| `[81]` | **""What? No.""** | `[53]` **Lucian Galade**: ""Sir, did you accept a bribe fro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "Lucian's eyes darkened." |
| `[95]` | **""Good thing we had him extradited, then.""** | `[10]` **Lucian Galade**: ""One of his corporation's subsid..." | `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == true`<br>`(Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false) == false`<br>`(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false` | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""This is treason on the highest ..." |
| `[125]` | **""Yes. I hope he suffers in jail.""** | `[90]` **Lucian Galade**: ""Would you like to go forth with..."<br>`[89]` **Lucian Galade**: ""Shall we ask him? And order Tus..." | `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`<br>`(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false` | *Brak zmian stanu* | `[63]` **Narrator**: "Lucian nodded smoothly." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""You should've called this investigation off when you had..."*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucian Galade: ""The Secret State Police have looked further into Walter ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""The Anti-Corruption Police have looked further into Walt..."*)

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""The Secret State Police have looked further into Walter Tusk's foreign ties, and found some very unsettling information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""One of his corporation's subsidiaries is directly involv..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)
  - -> `[20]` (*Player: ""No. I can use that information as leverage to make him d..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""Yes. I hope he suffers in jail.""*)
  - -> `[21]` (*Player: ""Arrest? I want him killed!""*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""One of his corporation's subsidiaries is directly involved in smuggling and selling Rumburgian KA-74s within Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true"*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""As you wish. Mr. Tusk shall remain a free man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""The Anti-Corruption Police have looked further into Walter Tusk's foreign ties, and found some very unsettling information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""One of his corporation's subsidiaries is directly involv..."*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> ""As you wish. I'll inform the relevant authorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_Oligarchs_ExtendTuskSente..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Yes. I hope he hangs.""]** — Mówca: **Player**
> ""Yes. I hope he hangs.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true` AND `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Lucian Galade), `[90]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Lucian nodded smoothly."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Lucian looked at me questioningly for a second, then nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""As you wish. Mr. Tusk shall remain a free man.""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == true )"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""Prison's too good for him.""*)
  - -> `[29]` (*Player: ""What can we do? He's already in jail.""*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oliga..."*)
  - -> `[27]` (*Player: ""That traitor!""*)
  - -> `[30]` (*Player: ""That's it? Everyone already knows he'd do anything for a..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""I suppose it's my only choice.""]** — Mówca: **Player**
> ""I suppose it's my only choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Lucian nodded smoothly."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""No. I can use that information as leverage to make him do what I want.""]** — Mówca: **Player**
> ""No. I can use that information as leverage to make him do what I want.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Lucian looked at me questioningly for a second, then nodd..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Arrest? I want him killed!""]** — Mówca: **Player**
> ""Arrest? I want him killed!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[90]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Lucian looked at me questioningly for a second, then nodd..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk = true; BaseGame.SecretState_LucianKnowsSSPKills = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] = true;
Variable["BaseGame.SecretState_LucianKnowsSSPKills"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_KillTusk = ..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Lucian's eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""*If* you did such a thing, you should never have proceed..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oliga..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oli..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""What can we do? He's still in Arcasia.""*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oliga..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""That traitor!""]** — Mówca: **Player**
> ""That traitor!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""This is treason on the highest level. There's no doubt T..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Prison's too good for him.""]** — Mówca: **Player**
> ""Prison's too good for him.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""What can we do? He's already in jail.""]** — Mówca: **Player**
> ""What can we do? He's already in jail.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""That's it? Everyone already knows he'd do anything for a ren.""]** — Mówca: **Player**
> ""That's it? Everyone already knows he'd do anything for a ren.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""This is treason on the highest level. There's no doubt T..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""What can we do? He's still in Arcasia.""]** — Mówca: **Player**
> ""What can we do? He's still in Arcasia.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false` AND `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Oligarchs_Extradited == true"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Lucian's eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""You should've called this investigation off when you had..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeRevealed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeRevealed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TuskBribeRe..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialTusk =..."*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""If you say so, sir. I'll give the orders to the new police chief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk = tru..."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""If you say so, sir. I'll give the orders to Mr. Greiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk = tru..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialTuskIn..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""You didn't hear this from me, sir, but 'accidents' happe..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: ""Yes, given the constraints of the Anti-Corruption Police..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_Oligarchs_ExtendTuskSentence = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_ExtendTuskSentence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_ExtendTuskS..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""No, it's a waste of time.""]** — Mówca: **Player**
> ""No, it's a waste of time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Lucian looked at me questioningly for a second, then nodd..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""You didn't hear this from me, sir, but 'accidents' happen in prison all the time. Gang wars, cafeteria scuffles... you get the idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""No, that'd attract too much suspicion. I'd rather just l..."*)
  - -> `[47]` (*Player: ""It'd certainly be unfortunate if Tusk were to be the vic..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I suppose it's my only choice.""]** — Mówca: **Player**
> ""I suppose it's my only choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Lucian nodded smoothly."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""No, it's a waste of time.""]** — Mówca: **Player**
> ""No, it's a waste of time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Lucian Galade), `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Lucian looked at me questioningly for a second, then nodd..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""No, that'd attract too much suspicion. I'd rather just let him rot in there.""]** — Mówca: **Player**
> ""No, that'd attract too much suspicion. I'd rather just let him rot in there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""Very well, sir.""*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""It'd certainly be unfortunate if Tusk were to be the victim of such an accident. Unfortunate, yet unavoidable.""]** — Mówca: **Player**
> ""It'd certainly be unfortunate if Tusk were to be the victim of such an accident. Unfortunate, yet unavoidable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""I'll make some phone calls, sir.""*)

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""It may be possible to trial him in absentia. Even if Arcasia didn't extradite him after that, it would set an example for other businessmen considering similar deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""This is treason on the highest level. There's no doubt Tusk must be punished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""I believe he called it a gesture of goodwill.""]** — Mówca: **Player**
> ""I believe he called it a gesture of goodwill.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Lucian's eyes darkened."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Lucian looked at me questioningly for a second, then nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == false"*)

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""*If* you did such a thing, you should never have proceeded with this investigation. Once Mrs. Morgna hears about the bribe, she's never going to let it go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeReveal..."*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""Sir, did you accept a bribe from Mr. Tusk at the beginning of your term?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""What? No.""*)
  - -> `[50]` (*Player: ""I believe he called it a gesture of goodwill.""*)
  - -> `[66]` (*Player: ""We may have... come to a place of mutual understanding.""*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""Yes, given the constraints of the Anti-Corruption Police, we could only succeed in extending his sentence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""I'll make some phone calls, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk = tru..."*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""Very well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: ""Would you like to go forth with his arrest and trial, sir?""*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""Shall we ask him? And order Tusk's arrest the minute he ..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Lucian nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""As you wish. I'll make the necessary calls immediately.""*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Lucian nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: ""As you wish. I'll inform the relevant authorities.""*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Lucian looked at me questioningly for a second, then nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""As you wish. Mr. Tusk will remain in exile in Arcasia.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""We may have... come to a place of mutual understanding.""]** — Mówca: **Player**
> ""We may have... come to a place of mutual understanding.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Lucian's eyes darkened."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""As you wish. Mr. Tusk's sentence will remain the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""You should've called this investigation off when you had the chance. Once Mrs. Morgna hears about the bribe, she's never going to let it go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeReveal..."*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""As you wish. I'll inform the relevant authorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsent..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""However, Mrs. Morgna's force also found out something el..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""Would you like to go forth with that, sir?""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""However, Mrs. Morgna's force also found out something el..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""Shall we ask him? And order Tusk's arrest the minute he ..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""However, Mrs. Morgna's force also found out something el..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oliga..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""As you wish. Mr. Tusk will remain in exile in Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""As you wish. I'll make the necessary calls immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk = true"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""What? No.""]** — Mówca: **Player**
> ""What? No.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Lucian's eyes darkened."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == false"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == false)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""If you say so, sir. I'll give the orders to Mr. Greiser.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: ""If you say so, sir. I'll give the orders to the new poli..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Lucian nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: ""As you wish. I'll inform the relevant authorities.""*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Lucian looked at me questioningly for a second, then nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: ""As you wish. Mr. Tusk's sentence will remain the same.""*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""However, Mrs. Morgna's force also found out something else...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: ""Sir, did you accept a bribe from Mr. Tusk at the beginni..."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Would you like to go forth with that, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""I suppose it's my only choice.""*)
  - -> `[42]` (*Player: ""No, it's a waste of time.""*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""Shall we ask him? And order Tusk's arrest the minute he touches Sordish soil?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""No, it's a waste of time.""*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""Would you like to go forth with his arrest and trial, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Oligarchs_Extradited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Oligarchs_Extradited == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Oligarchs_Extradited == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Oligarchs_Extradited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Oligarchs_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""I'm sure President Walker would have no qualms about ext..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Oligarchs_Extradited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Oligarchs_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucian Galade: ""It may be possible to trial him in absentia. Even if Arc..."*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""I'm sure President Walker would have no qualms about extraditing him. He offered such a proposal during his visit, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Good thing we had him extradited, then.""]** — Mówca: **Player**
> ""Good thing we had him extradited, then.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == true` AND `(Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false) == false` AND `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""This is treason on the highest level. There's no doubt T..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oliga..."*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oli..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""Good thing we had him extradited, then.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""Would you like to go forth with that, sir?""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""However, Mrs. Morgna's force also found out something el..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""Would you like to go forth with that, sir?""*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""Would you like to go forth with that, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""I suppose it's my only choice.""*)
  - -> `[45]` (*Player: ""No, it's a waste of time.""*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_KillTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_KillTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TuskBribeRevealed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TuskBribeRevealed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_ExtendTuskSentence = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_ExtendTuskSentence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialTuskInAbsentia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialTuskInAbsentia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leader_Oligarchs_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Leader_Oligarchs_WalterTusk == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leader_Oligarchs_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Leader_Oligarchs_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn07..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Leader_Oligarchs_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Leader_Oligarchs_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn07_Fled_MarcelKoronti == false && BaseGame.Turn09_A_MarcelArrested == false && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.HeartOfSordland_Nationalization < 3 && BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn07..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn07_Fled_MarcelKoronti == false && BaseGame.Turn09_A_MarcelArrested == false && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.HeartOfSordland_Nationalization < 3 && BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Killed_MarcelKoronti"] == false  and  Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false  and  Variable["BaseGame.Turn09_A_MarcelArrested"] == false  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.HeartOfSordland_Nationalization"] < 3  and  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Factions", "Position_Oligarch", "F..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn07_Fled_MarcelKoronti == false && BaseGame.Turn09_A_MarcelArrested == false && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.HeartOfSordland_Nationalization < 3 && BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Killed_MarcelKoronti"] == false  and  Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false  and  Variable["BaseGame.Turn09_A_MarcelArrested"] == false  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.HeartOfSordland_Nationalization"] < 3  and  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MikailAven == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MikailAven == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MikailAven == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_MikailAven == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MikailAven == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MikailAven"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Factions", "Position_Oligarch", "F..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_MikailAven == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MikailAven"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Factions", "Position_Oligarch", "F..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk = true; BaseGame.SecretState_LucianKnowsSSPKills = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] = true;
Variable["BaseGame.SecretState_LucianKnowsSSPKills"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_KillTusk = ..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_KillTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_KillTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Yes. I hope he hangs.""*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""Yes. I hope he suffers in jail.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Yes. I hope he suffers in jail.""]** — Mówca: **Player**
> ""Yes. I hope he suffers in jail.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false` AND `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[90]` (Lucian Galade), `[89]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Lucian nodded smoothly."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oliga..."*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oli..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""It may be possible to trial him in absentia. Even if Arc..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: ""Would you like to go forth with his arrest and trial, sir?""*)

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""It may be possible to trial him in absentia. Even if Arcasia didn't extradite him after that, it would set an example for other businessmen considering similar deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""Would you like to go forth with that, sir?""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_MarcelKoronti");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_MarcelKoronti");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_KorontiLeader = true; BaseGame..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_EdithAgnoc");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_EdithAgnoc");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk = false"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_MikailAven");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_MikailAven");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leader_Oligarchs_WalterTusk = false"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_KorontiLeader = true;
BaseGame.Leader_Oligarchs_WalterTusk = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] = true;
Variable["BaseGame.Leader_Oligarchs_WalterTusk"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leader_Oligarchs_WalterTusk = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Leader_Oligarchs_WalterTusk"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
