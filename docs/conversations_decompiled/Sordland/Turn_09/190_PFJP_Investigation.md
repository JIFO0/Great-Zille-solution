# Sordland/Turn09/PFJP Investigation

- **ID konwersacji:** `190`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/190_PFJP_Investigation.md`
- **Liczba węzłów dialogowych:** 100
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Turn07_Emergency_Detained_Frens`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PFJPLeader_Manoly`
- `BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed`
- `BaseGame.Turn09_A_Investigation_PFJP_RicterFramed`
- `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedReformists`
- `BaseGameSupport.Journal_Turn09_Investigations_ManolyFramed`
- `BaseGameSupport.Journal_Turn09_Investigations_RicterFramed`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[56]`
- Węzeł `[96]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[64]`
- Węzeł `[97]` -> **[189] Sordland/Turn09/NFP Investigation** (../Turn_09/189_NFP_Investigation.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Then you'll just have to make sure Nia never finds out.""** | `[6]` **Lucian Galade**: ""Not only on your chances of re-..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "Lucian sighed." |
| `[12]` | **""I was stupid enough to order this investigation. I deserve what's coming to me.""** | `[6]` **Lucian Galade**: ""Not only on your chances of re-..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "Lucian sighed." |
| `[13]` | **""I certainly hope so.""** | `[57]` **Narrator**: "His gaze seemed to be fixed on s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[15]` | **""That's it? That's the result of a years-long investigation?""** | `[3]` **Lucian Galade**: ""Unfortunately, sir, the Reformi..." | `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false` | *Brak zmian stanu* | `[23]` **Narrator**: "Lucian shrugged stiffly." |
| `[16]` | **""Really? What are these people, saints?""** | `[3]` **Lucian Galade**: ""Unfortunately, sir, the Reformi..." | `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false` | *Brak zmian stanu* | `[23]` **Narrator**: "Lucian shrugged stiffly." |
| `[17]` | **""What if we were to manufacture some dirt on them?""** | `[3]` **Lucian Galade**: ""Unfortunately, sir, the Reformi..." | `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false` | *Brak zmian stanu* | `[24]` **Lucian Galade**: ""Nia and her Anti-Corruption pol..." |
| `[19]` | **""Yes. Screw it. Let's sink Ricter once and for all.""** | `[61]` **Lucian Galade**: ""So, should I give the order?"" | `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false` | *Brak zmian stanu* | `[69]` **Lucian Galade**: ""As you wish. I'll give the orde..."<br>`[94]` **Lucian Galade**: ""As you wish. I'll give the orde..." |
| `[25]` | **""Yes. Screw it. Let's sink Manoly before she gets any more popular.""** | `[61]` **Lucian Galade**: ""So, should I give the order?"" | `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true` | *Brak zmian stanu* | `[43]` **Lucian Galade**: ""As you wish. I'll give the orde..."<br>`[53]` **Lucian Galade**: ""As you wish. I'll give the orde..." |
| `[32]` | **""No. I'll beat them in the election fair and square.""** | `[61]` **Lucian Galade**: ""So, should I give the order?"" | `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true` | *Brak zmian stanu* | `[89]` **Lucian Galade**: ""I have no doubt of that, sir."" |
| `[38]` | **""It's not fair! I didn't do anything wrong.""** | `[6]` **Lucian Galade**: ""Not only on your chances of re-..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "Lucian sighed." |
| `[42]` | **""You're lying.""** | `[57]` **Narrator**: "His gaze seemed to be fixed on s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Lucian Galade**: ""Frankly, sir, I'll do what I ca..." |
| `[44]` | **""Damn. I knew I shouldn't have done that.""** | `[54]` **Lucian Galade**: ""The Anti-Corruption Police did ..."<br>`[78]` **Lucian Galade**: ""The Anti-Corruption Police did ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lucian Galade**: ""Don't worry, Mr. President. I'm..."<br>`[93]` **Lucian Galade**: ""If word of this gets back to Mr..." |
| `[55]` | **""What? Lies!""** | `[54]` **Lucian Galade**: ""The Anti-Corruption Police did ..."<br>`[78]` **Lucian Galade**: ""The Anti-Corruption Police did ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lucian Galade**: ""Don't worry, Mr. President. I'm..."<br>`[93]` **Lucian Galade**: ""If word of this gets back to Mr..." |
| `[58]` | **""I like the way you're thinking.""** | `[45]` **Lucian Galade**: ""That would put a rather abrupt ..."<br>`[48]` **Lucian Galade**: ""That would help drain support f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Lucian Galade**: ""Thank you, sir.""<br>`[62]` **Lucian Galade**: ""I do tend to be right on these ..." |
| `[59]` | **""Wouldn't it also be, you know, illegal?""** | `[45]` **Lucian Galade**: ""That would put a rather abrupt ..."<br>`[48]` **Lucian Galade**: ""That would help drain support f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Lucian Galade**: ""Those who believe in you, mysel..."<br>`[46]` **Lucian Galade**: ""Your previous actions with Rict..."<br>*(oraz 1 innych odgałęzień)* |
| `[68]` | **""What's the big deal? He's the one who accepted it.""** | `[54]` **Lucian Galade**: ""The Anti-Corruption Police did ..."<br>`[78]` **Lucian Galade**: ""The Anti-Corruption Police did ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lucian Galade**: ""Don't worry, Mr. President. I'm..."<br>`[93]` **Lucian Galade**: ""If word of this gets back to Mr..." |

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
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "Reformists Investigation"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""I'll do what I can to mitigate the damage. But I can't p..."*)

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""Unfortunately, sir, the Reformists appear to be as clean as a whistle. Earlier rumors about connections to oligarchs turned out to be just that: rumors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Then you'll just have to make sure Nia never finds out.""]** — Mówca: **Player**
> ""Then you'll just have to make sure Nia never finds out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Lucian sighed."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Reformists Investigation`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_CampaignInvestigations_Discusse..."*)

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""Not only on your chances of re-election -- but on the remainder of your current term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Then you'll just have to make sure Nia never finds out.""*)
  - -> `[12]` (*Player: ""I was stupid enough to order this investigation. I deser..."*)
  - -> `[38]` (*Player: ""It's not fair! I didn't do anything wrong.""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedReformists = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedReformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Unfortunately, sir, the Reformists appear to be as clean..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == tru..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""However...""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""That's it? That's the result of a years-long investigati..."*)
  - -> `[16]` (*Player: ""Really? What are these people, saints?""*)
  - -> `[17]` (*Player: ""What if we were to manufacture some dirt on them?""*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Lucian lowered his voice."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I was stupid enough to order this investigation. I deserve what's coming to me.""]** — Mówca: **Player**
> ""I was stupid enough to order this investigation. I deserve what's coming to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Lucian sighed."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I certainly hope so.""]** — Mówca: **Player**
> ""I certainly hope so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Frankly, sir, I'll do what I can, but I may not be able to protect you from the consequences of your reprehensible conduct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""That's it? That's the result of a years-long investigation?""]** — Mówca: **Player**
> ""That's it? That's the result of a years-long investigation?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Lucian shrugged stiffly."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Really? What are these people, saints?""]** — Mówca: **Player**
> ""Really? What are these people, saints?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Lucian shrugged stiffly."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""What if we were to manufacture some dirt on them?""]** — Mówca: **Player**
> ""What if we were to manufacture some dirt on them?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: ""Nia and her Anti-Corruption police would be likely to fi..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Lucian lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Yes. Screw it. Let's sink Ricter once and for all.""]** — Mówca: **Player**
> ""Yes. Screw it. Let's sink Ricter once and for all.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter == true || B..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Lucian shrugged stiffly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_CampaignInvestigations_Discusse..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""Nia and her Anti-Corruption police would be likely to find out. In fact, you're lucky your behavior towards the party has been, well, unimpeachable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_CampaignInvestigations_Discusse..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Yes. Screw it. Let's sink Manoly before she gets any more popular.""]** — Mówca: **Player**
> ""Yes. Screw it. Let's sink Manoly before she gets any more popular.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter == true || B..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_FrensRicter == true ||..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""It would be fairly easy to plant incriminating evidence ..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: ""It would be fairly easy to plant incriminating evidence ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_CampaignInvestigations_Discusse..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_CampaignInvestigations_Discus..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""Mr. President, you're already about to neutralize one of..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""No. I'll beat them in the election fair and square.""]** — Mówca: **Player**
> ""No. I'll beat them in the election fair and square.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""I have no doubt of that, sir.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter == true || B..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_FrensRicter == true ||..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""Yes. Screw it. Let's sink Manoly before she gets any mor..."*)
  - -> `[32]` (*Player: ""No. I'll beat them in the election fair and square.""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""No. I'll beat them in the election fair and square.""*)
  - -> `[19]` (*Player: ""Yes. Screw it. Let's sink Ricter once and for all.""*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""It would be fairly easy to plant incriminating evidence against Manoly Suheil and have her trialled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""That would put a rather abrupt end to the momentum she's..."*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""It would be fairly easy to plant incriminating evidence against Ricter and have him trialled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucian Galade: ""That would help drain support from the Reformists and cl..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""It's not fair! I didn't do anything wrong.""]** — Mówca: **Player**
> ""It's not fair! I didn't do anything wrong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Lucian sighed."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_NFP == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: ""I'm sorry I couldn't bring you better news.""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucian Galade: ""You'll be happy to hear that the investigation into the ..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""You're lying.""]** — Mówca: **Player**
> ""You're lying.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: ""Frankly, sir, I'll do what I can, but I may not be able ..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""As you wish. I'll give the order to the new police chief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed = true"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Damn. I knew I shouldn't have done that.""]** — Mówca: **Player**
> ""Damn. I knew I shouldn't have done that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lucian Galade), `[78]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion < 0"*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""That would put a rather abrupt end to the momentum she's been gathering and help clear the path for your re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: ""I like the way you're thinking.""*)
  - -> `[59]` (*Player: ""Wouldn't it also be, you know, illegal?""*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""Your previous actions with Ricter have already put you on shaky moral ground, wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""So, should I give the order?""*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""Forming the Secret State Police already put you on rather shaky moral ground, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""So, should I give the order?""*)

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""That would help drain support from the Reformists and clear the path for your re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: ""I like the way you're thinking.""*)
  - -> `[59]` (*Player: ""Wouldn't it also be, you know, illegal?""*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Mr. President, you're already about to neutralize one of your biggest opposition parties. Taking out both would just be wishful thinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""Now that that's settled, I'll let you prepare for your r..."*)

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""You'll be happy to hear that the investigation into the NFP was rather more successful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "Jump to: [NFP Investigation]"*)

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""Don't worry, Mr. President. I'm sure these allegations will be easy to sweep under the rug.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "His gaze seemed to be fixed on some faraway corner of the..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Lucian sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""I'll do what I can to mitigate the damage. But I can't p..."*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""As you wish. I'll give the order to Mr. Greiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed = true"*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""The Anti-Corruption Police did turn up evidence of your having offered Frens Ricter a substantial sum of money in exchange for his party's support,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""What? Lies!""*)
  - -> `[68]` (*Player: ""What's the big deal? He's the one who accepted it.""*)
  - -> `[44]` (*Player: ""Damn. I knew I shouldn't have done that.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""What? Lies!""]** — Mówca: **Player**
> ""What? Lies!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lucian Galade), `[78]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion < 0"*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""I'll do what I can to mitigate the damage. But I can't promise there won't be consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[57]`
Mówca: **Narrator**
> "His gaze seemed to be fixed on some faraway corner of the hotel room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""You're lying.""*)
  - -> `[13]` (*Player: ""I certainly hope so.""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I like the way you're thinking.""]** — Mówca: **Player**
> ""I like the way you're thinking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucian Galade), `[48]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion > 0"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Wouldn't it also be, you know, illegal?""]** — Mówca: **Player**
> ""Wouldn't it also be, you know, illegal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucian Galade), `[48]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion > 0"*)

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""I'm sorry I couldn't bring you better news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""With the opposition still in play, rallying your base is..."*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""So, should I give the order?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter == true || B..."*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""I do tend to be right on these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""So, should I give the order?""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_ManolyFrame..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Bribed == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: ""The Anti-Corruption Police did turn up evidence of your ..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Bribed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: ""The Anti-Corruption Police did turn up evidence of your ..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""Thank you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""So, should I give the order?""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""What's the big deal? He's the one who accepted it.""]** — Mówca: **Player**
> ""What's the big deal? He's the one who accepted it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lucian Galade), `[78]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion < 0"*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""As you wish. I'll give the order to the new police chief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_PFJP_RicterFramed = true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_PFJP_RicterFramed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Investigations_RicterFrame..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion > 0"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lucian_Opinion > 0)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucian Galade: ""Those who believe in you, myself included, would argue y..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lucian_Opinion > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter == true || B..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion > 0"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lucian_Opinion > 0)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: ""Thank you, sir.""*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lucian_Opinion > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: ""I do tend to be right on these matters.""*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""With the opposition still in play, rallying your base is of the utmost importance. I'll let you prepare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "Jump to: [Campaign Rally]"*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""The Anti-Corruption Police did turn up evidence of your having offered Frens Ricter a high-value construction contract in exchange for his party's support,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""What? Lies!""*)
  - -> `[68]` (*Player: ""What's the big deal? He's the one who accepted it.""*)
  - -> `[44]` (*Player: ""Damn. I knew I shouldn't have done that.""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""As you wish. I'll give the order to the new police chief.""*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: ""As you wish. I'll give the order to Mr. Greiser.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter == true || B..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_FrensRicter == true ||..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""Your previous actions with Ricter have already put you o..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""Forming the Secret State Police already put you on rathe..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: ""As you wish. I'll give the order to the new police chief.""*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""As you wish. I'll give the order to Mr. Greiser.""*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Now that that's settled, I'll let you prepare for your rally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "Jump to: [Campaign Rally]"*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""I have no doubt of that, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion < 0"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lucian_Opinion < 0)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""Don't worry, Mr. President. I'm sure these allegations w..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lucian_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""If word of this gets back to Mrs. Morgna, it could have ..."*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""If word of this gets back to Mrs. Morgna, it could have dire repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucian Galade: ""Not only on your chances of re-election -- but on the re..."*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""As you wish. I'll give the order to Mr. Greiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_PFJP_RicterFramed = true"*)

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Those who believe in you, myself included, would argue your re-election takes a higher priority than pesky questions of legality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""So, should I give the order?""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Campaign Rally]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NFP Investigation]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_RicterFramed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_RicterFramed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Investigations_ManolyFramed = true;
BaseGame.PFJPLeader_Manoly = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_ManolyFramed"] = true;
Variable["BaseGame.PFJPLeader_Manoly"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
