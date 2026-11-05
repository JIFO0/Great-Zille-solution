# Sordland/Turn09/Old Guard Investivation

- **ID konwersacji:** `192`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/192_Old_Guard_Investivation.md`
- **Liczba węzłów dialogowych:** 112
- **Liczba wyborów gracza:** 28

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_OrsoHawker`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.YoungSords_Kill_OrsoHawker`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn09_A_Investigation_OldGuard_AttemptToFireLileas`
- `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge`
- `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas`
- `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso`
- `BaseGameSupport.Codex_Characters_Cabinet_LileasGraf`
- `BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators`
- `BaseGameSupport.Journal_Turn09_Investigations_FireLileas`
- `BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialLileas`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialOrso`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[65]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""I want their heads, Lucian.""** | `[96]` **Lucian Galade**: ""To imagine that this is the ext..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Lucian Galade**: ""The main conspirator was Lileas..."<br>`[9]` **Lucian Galade**: ""The main co-conspirators were O..." |
| `[10]` | **""You're joking.""** | `[8]` **Lucian Galade**: ""The Old Guard led by Hawker and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucian Galade**: ""Since you took office, their go..." |
| `[14]` | **""What? But why?""** | `[8]` **Lucian Galade**: ""The Old Guard led by Hawker and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucian Galade**: ""Since you took office, their go..." |
| `[15]` | **""I always thought they were involved.""** | `[8]` **Lucian Galade**: ""The Old Guard led by Hawker and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucian Galade**: ""Since you took office, their go..." |
| `[21]` | **""Who was involved in this?""** | `[17]` **Lucian Galade**: ""Of course, they didn't succeed.""<br>`[23]` **Lucian Galade**: ""Of course, when that didn't wor..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: ""That may be complicated. Becaus..." |
| `[35]` | **""Cute.""** | `[34]` **Narrator**: "I went down the list. It spelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Lucian smiled wryly." |
| `[36]` | **""So they're playing with us?""** | `[34]` **Narrator**: "I went down the list. It spelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Lucian smiled wryly." |
| `[37]` | **""What is the meaning of this?""** | `[34]` **Narrator**: "I went down the list. It spelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Lucian smiled wryly." |
| `[45]` | **""It was my fault, not yours.""** | `[44]` **Lucian Galade**: ""I should have advised you not t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""If you wish, you could still re..." |
| `[46]` | **""I realize that now. I'm sorry.""** | `[43]` **Lucian Galade**: ""Frankly, sir, you asking them t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""If you wish, you could still re..." |
| `[47]` | **""Can't we still fire Lileas?""** | `[43]` **Lucian Galade**: ""Frankly, sir, you asking them t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""If you wish, you could still re..." |
| `[48]` | **""Apology accepted.""** | `[44]` **Lucian Galade**: ""I should have advised you not t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""If you wish, you could still re..." |
| `[50]` | **""Ms. Graf has caused me nothing but grief. Let's get rid of her.""** | `[49]` **Lucian Galade**: ""If you wish, you could still re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "Lucian swallowed." |
| `[51]` | **""You're right. Can't be rocking the boat this close to the election.""** | `[49]` **Lucian Galade**: ""If you wish, you could still re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[62]` | **""We will get rid of every single one that was involved in this plot.""** | `[61]` **Lucian Galade**: ""And then there are the dozens o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Lucian Galade**: ""That could end up being the lar..." |
| `[63]` | **""It would cause ripples if we got rid of everyone at once. We will start with Orso..."** | `[61]` **Lucian Galade**: ""And then there are the dozens o..." | `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true) == false` | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`AssignConnection("Page_Cabinet","Position_InteriorMiniste...`<br>*(+3 skryptów)* | `[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..." |
| `[64]` | **""Lileas Graf will be our primary target. It's time she left politics. Once and for..."** | `[61]` **Lucian Galade**: ""And then there are the dozens o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`AssignConnection("Page_Cabinet","Position_InteriorMiniste...`<br>*(+1 skryptów)* | `[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..." |
| `[65]` | **""Orso Hawker should be our primary target. He is too dangerous keep around.""** | `[51]` **Player**: ""You're right. Can't be rocking ..."<br>`[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true) == false` | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`Variable["BaseGameSupport.Journal_Turn09_Investigations_T...` | `[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..." |
| `[66]` | **""We will get rid of every single one that was involved in this plot.""** | `[55]` **Lucian Galade**: ""And then there are the dozens o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lucian Galade**: ""That could end up being the lar..." |
| `[67]` | **""Lileas Graf will be our primary target. It's time she left politics. Once and for..."** | `[55]` **Lucian Galade**: ""And then there are the dozens o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`AssignConnection("Page_Cabinet","Position_InteriorMiniste...`<br>*(+1 skryptów)* | `[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..." |
| `[69]` | **""Yes. The Old Guard has been a taint on my government for far too long.""** | `[68]` **Lucian Galade**: ""That could end up being the lar..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`AssignConnection("Page_Cabinet","Position_InteriorMiniste...`<br>*(+5 skryptów)* | *Koniec sceny / Terminal* |
| `[70]` | **""I meant, let's get rid of all the main conspirators we can touch. No need to shak..."** | `[68]` **Lucian Galade**: ""That could end up being the lar..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`AssignConnection("Page_Cabinet","Position_InteriorMiniste...`<br>*(+3 skryptów)* | `[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..." |
| `[72]` | **""Yes. The Old Guard has been a taint on my government for far too long.""** | `[71]` **Lucian Galade**: ""That could end up being the lar..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`AssignConnection("Page_Cabinet","Position_InteriorMiniste...`<br>*(+3 skryptów)* | `[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..." |
| `[73]` | **""I meant, let's get rid of the main conspirator we can touch. No need to shake up ..."** | `[71]` **Lucian Galade**: ""That could end up being the lar..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`AssignConnection("Page_Cabinet","Position_InteriorMiniste...`<br>*(+1 skryptów)* | `[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..." |
| `[97]` | **""Are there any other things they have done?""** | `[17]` **Lucian Galade**: ""Of course, they didn't succeed.""<br>`[23]` **Lucian Galade**: ""Of course, when that didn't wor..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: ""That may be complicated. Becaus..." |
| `[98]` | **""Who is the main culprit?""** | `[96]` **Lucian Galade**: ""To imagine that this is the ext..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Lucian Galade**: ""The main conspirator was Lileas..."<br>`[9]` **Lucian Galade**: ""The main co-conspirators were O..." |
| `[99]` | **""We must act against this treachery.""** | `[96]` **Lucian Galade**: ""To imagine that this is the ext..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Lucian Galade**: ""The main conspirator was Lileas..."<br>`[9]` **Lucian Galade**: ""The main co-conspirators were O..." |
| `[111]` | **""It would cause ripples if we got rid of everyone at once. We will start with Lile..."** | `[61]` **Lucian Galade**: ""And then there are the dozens o..." | `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true` | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_...`<br>`AssignConnection("Page_Cabinet","Position_InteriorMiniste...`<br>*(+1 skryptów)* | `[94]` **Lucian Galade**: ""All right, sir. I'll get to wor..." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Orso Hawker should be our primary target. He is too dang..."*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: ""Mrs. Morgna's task force suspected Old Guard members of ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""As you may recall, Karl Greiser hinted at a 'complex web..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""I want their heads, Lucian.""]** — Mówca: **Player**
> ""I want their heads, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OrsoHawker == true"*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""Mrs. Morgna's task force suspected Old Guard members of multiple cases of corruption and lobbying. But when they looked deeper into it, they found something truly shocking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucian Galade: ""The Old Guard led by Hawker and Graf -- with the suspect..."*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""The Old Guard led by Hawker and Graf -- with the suspected approval of Tarquin Soll -- organized the assassination of Bernard Circas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""You're joking.""*)
  - -> `[14]` (*Player: ""What? But why?""*)
  - -> `[15]` (*Player: ""I always thought they were involved.""*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""The main co-conspirators were Orso Hawker and Lileas Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""And then there are the dozens of Assembly members and th..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""You're joking.""]** — Mówca: **Player**
> ""You're joking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: ""Since you took office, their goal was to protect Soll an..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: ""And they succeeded.""*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: ""Of course, when that didn't work, they had other ways of..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""What? But why?""]** — Mówca: **Player**
> ""What? But why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: ""Since you took office, their goal was to protect Soll an..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I always thought they were involved.""]** — Mówca: **Player**
> ""I always thought they were involved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: ""Since you took office, their goal was to protect Soll an..."*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""Since you took office, their goal was to protect Soll and his constitution. They needed an event extreme enough to distract you from making reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""Of course, they didn't succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Who was involved in this?""*)
  - -> `[97]` (*Player: ""Are there any other things they have done?""*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true )"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""Of course, they didn't succeed.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Who was involved in this?""]** — Mówca: **Player**
> ""Who was involved in this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade), `[23]` (Lucian Galade), `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""That may be complicated. Because we found out about anot..."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""That may be complicated. Because we found out about another piece of information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucian Galade: ""Further evidence suggests that they orchestrated the des..."*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""Of course, when that didn't work, they had other ways of impeding you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Who was involved in this?""*)
  - -> `[97]` (*Player: ""Are there any other things they have done?""*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""And they succeeded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Who was involved in this?""*)
  - -> `[97]` (*Player: ""Are there any other things they have done?""*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""As you may recall, Karl Greiser hinted at a 'complex web of connections' surrounding the Old Guard as well as multiple cases of corruption and lobbying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: ""However, he kept stalling whenever I pressed him for det..."*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""However, he kept stalling whenever I pressed him for details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: ""As did his successor after he was fired.""*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""Eventually, I received this bulletin from the desk of th..."*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""As did his successor after he was fired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""Eventually, I received this bulletin from the desk of th..."*)

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""Eventually, I received this bulletin from the desk of the Secret State Police. Supposedly a list of leads they'd uncovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He handed me a sheet of paper. On it was a short list of ..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "He handed me a sheet of paper. On it was a short list of names."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""Look at the first letter of each name.""*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""Look at the first letter of each name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "I went down the list. It spelled "NICE TRY GALADE.'""*)

### Węzeł `[34]`
Mówca: **Narrator**
> "I went down the list. It spelled "NICE TRY GALADE.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: ""Cute.""*)
  - -> `[36]` (*Player: ""So they're playing with us?""*)
  - -> `[37]` (*Player: ""What is the meaning of this?""*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""Cute.""]** — Mówca: **Player**
> ""Cute.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Lucian smiled wryly."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""So they're playing with us?""]** — Mówca: **Player**
> ""So they're playing with us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Lucian smiled wryly."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""What is the meaning of this?""]** — Mówca: **Player**
> ""What is the meaning of this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Lucian smiled wryly."*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""Lileas and the Old Guard undoubtedly have something to hide. But the Secret State Police is their instrument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion < 0"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Lucian smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""Lileas and the Old Guard undoubtedly have something to h..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion < 0"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lucian_Opinion < 0)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""Frankly, sir, you asking them to investigate their own b..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lucian_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: ""I should have advised you not to pursue this. Sorry to h..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""Frankly, sir, you asking them to investigate their own bosses was a waste of both your time and mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""I realize that now. I'm sorry.""*)
  - -> `[47]` (*Player: ""Can't we still fire Lileas?""*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""I should have advised you not to pursue this. Sorry to have failed you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""Apology accepted.""*)
  - -> `[45]` (*Player: ""It was my fault, not yours.""*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""It was my fault, not yours.""]** — Mówca: **Player**
> ""It was my fault, not yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""If you wish, you could still remove Lileas from her cabi..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""I realize that now. I'm sorry.""]** — Mówca: **Player**
> ""I realize that now. I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""If you wish, you could still remove Lileas from her cabi..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Can't we still fire Lileas?""]** — Mówca: **Player**
> ""Can't we still fire Lileas?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""If you wish, you could still remove Lileas from her cabi..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Apology accepted.""]** — Mówca: **Player**
> ""Apology accepted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""If you wish, you could still remove Lileas from her cabi..."*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""If you wish, you could still remove Lileas from her cabinet position for encouraging the police's insubordination. But it wouldn't make you very popular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""Ms. Graf has caused me nothing but grief. Let's get rid ..."*)
  - -> `[51]` (*Player: ""You're right. Can't be rocking the boat this close to th..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Ms. Graf has caused me nothing but grief. Let's get rid of her.""]** — Mówca: **Player**
> ""Ms. Graf has caused me nothing but grief. Let's get rid of her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Lucian swallowed."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""You're right. Can't be rocking the boat this close to the election.""]** — Mówca: **Player**
> ""You're right. Can't be rocking the boat this close to the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Lucian swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: ""It may take some time to fire her without harming your e..."*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""It may take some time to fire her without harming your election chances. But I'll get the process started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_FireLileas ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_AttemptToFireLileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_AttemptToFireLileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""All right, sir. I'll get to work on it when we return to..."*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""And then there are the dozens of Assembly members and thousands of government officials who may have been aware of the assassination plot and helped cover it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""We will get rid of every single one that was involved in..."*)
  - -> `[67]` (*Player: ""Lileas Graf will be our primary target. It's time she le..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_FireLileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_FireLileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_AttemptToFireLil..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OrsoHawker == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OrsoHawker == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: ""The main conspirator was Lileas Graf.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: ""The main co-conspirators were Orso Hawker and Lileas Graf.""*)

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""The main conspirator was Lileas Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""And then there are the dozens of Assembly members and th..."*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""And then there are the dozens of Assembly members and thousands of government officials who may have been aware of the assassination plot and helped cover it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""We will get rid of every single one that was involved in..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)
  - -> `[64]` (*Player: ""Lileas Graf will be our primary target. It's time she le..."*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""We will get rid of every single one that was involved in this plot.""]** — Mówca: **Player**
> ""We will get rid of every single one that was involved in this plot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""That could end up being the largest government purge in ..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""It would cause ripples if we got rid of everyone at once. We will start with Orso and Lileas.""]** — Mówca: **Player**
> ""It would cause ripples if we got rid of everyone at once. We will start with Orso and Lileas.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Lileas Graf will be our primary target. It's time she left politics. Once and for all.""]** — Mówca: **Player**
> ""Lileas Graf will be our primary target. It's time she left politics. Once and for all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Orso Hawker should be our primary target. He is too dangerous keep around.""]** — Mówca: **Player**
> ""Orso Hawker should be our primary target. He is too dangerous keep around.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Player), `[94]` (Lucian Galade), `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""We will get rid of every single one that was involved in this plot.""]** — Mówca: **Player**
> ""We will get rid of every single one that was involved in this plot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""That could end up being the largest government purge in ..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Lileas Graf will be our primary target. It's time she left politics. Once and for all.""]** — Mówca: **Player**
> ""Lileas Graf will be our primary target. It's time she left politics. Once and for all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true"*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""That could end up being the largest government purge in Sordland's history. Are you sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""Yes. The Old Guard has been a taint on my government for..."*)
  - -> `[70]` (*Player: ""I meant, let's get rid of all the main conspirators we c..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Yes. The Old Guard has been a taint on my government for far too long.""]** — Mówca: **Player**
> ""Yes. The Old Guard has been a taint on my administration for far too long.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""I meant, let's get rid of all the main conspirators we can touch. No need to shake up the entire government so close to the election.""]** — Mówca: **Player**
> ""I meant, let's get rid of all the main conspirators we can touch. No need to shake up the entire government so close to the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true"*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""That could end up being the largest government purge in Sordland's history. Are you sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""Yes. The Old Guard has been a taint on my government for..."*)
  - -> `[73]` (*Player: ""I meant, let's get rid of the main conspirator we can to..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Yes. The Old Guard has been a taint on my government for far too long.""]** — Mówca: **Player**
> ""Yes. The Old Guard has been a taint on my administration for far too long.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""I meant, let's get rid of the main conspirator we can touch. No need to shake up the entire government so close to the election.""]** — Mówca: **Player**
> ""I meant, let's get rid of the main conspirator we can touch. No need to shake up the entire government so close to the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_InteriorMinist..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""All right, sir. I'll get to work on it when we return to..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_InteriorMinist..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""All right, sir. I'll get to work on it when we return to..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_InteriorMinist..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialOrso =..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialOrso = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialOrso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""All right, sir. I'll get to work on it when we return to..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialOrso =..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialOrso = true;
BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialOrso"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""All right, sir. I'll get to work on it when we return to..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialOrso = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialOrso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_PurgeGovern..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialOrso =..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_InteriorMinist..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_InteriorMinist..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_PurgeGovern..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge = true;
BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""All right, sir. I'll get to work on it when we return to..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOffici..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge = true;
BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""All right, sir. I'll get to work on it when we return to..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOffici..."*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""All right, sir. I'll get to work on it when we return to Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Further evidence suggests that they orchestrated the destruction of the Holsord State University archives. We found out their motive was to destroy the employee records and proof regarding all the informants they secretly employed at the university from 1930 until 1953.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""To imagine that this is the extent of our knowledge on t..."*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""To imagine that this is the extent of our knowledge on their actions is deeply troubling. The chaos they created and the loss of life occurred because of them is treachery at the highest level and must not go unpunished in my opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player: ""Who is the main culprit?""*)
  - -> `[99]` (*Player: ""We must act against this treachery.""*)
  - -> `[6]` (*Player: ""I want their heads, Lucian.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Are there any other things they have done?""]** — Mówca: **Player**
> ""Are there any other things they have done?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade), `[23]` (Lucian Galade), `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""That may be complicated. Because we found out about anot..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: ""Who is the main culprit?""]** — Mówca: **Player**
> ""Who is the main culprit?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OrsoHawker == true"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""We must act against this treachery.""]** — Mówca: **Player**
> ""We must act against this treachery.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OrsoHawker == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialLileas..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialLileas..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialLileas..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialLileas..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_TrialLileas..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || ..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Orso Hawker should be our primary target. He is too dang..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""It would cause ripples if we got rid of everyone at once..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""It would cause ripples if we got rid of everyone at once..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It would cause ripples if we got rid of everyone at once. We will start with Lileas.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true"*)
