# Sordland/Turn07/A_AssemblyVote_ResultsMeeting

- **ID konwersacji:** `94`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/094_A_AssemblyVote_ResultsMeeting.md`
- **Liczba węzłów dialogowych:** 54
- **Liczba wyborów gracza:** 7

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Amendment_PFJP_Frens_Convinced`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Reform_Reform_PFJP_Convinced`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.Report_Turn07_Holsord_VoteFail_USPCriticizes`
- `BaseGameSupport.Report_Turn07_Holsord_VoteWon_KibenerCongratulates`
- `BaseGameSupport.Report_Turn07_Holsord_VoteWon_RicterCongratulates`
- `GameCondition.Turn07_A_AssemblyVote_ResultsMeeting`

### Skoki między-konwersacyjne:
- Węzeł `[4]` -> **[96] Sordland/Turn07/VoteWon** (../Turn_07/096_VoteWon.md), Węzeł `[1]`
- Węzeł `[5]` -> **[95] Sordland/Turn07/VoteLost** (../Turn_07/095_VoteLost.md), Węzeł `[1]`
- Węzeł `[10]` -> **[97] Sordland/Turn07/Kesaro&FrensDialogue** (../Turn_07/097_Kesaro&FrensDialogue.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""I need a drink.""** | `[12]` **Petr Vectern**: ""Getting pretty hot out here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Petr Vectern**: ""I can help you with that. If yo..." |
| `[15]` | **""Okay. Let's call it finished. You may both go.""** | `[12]` **Petr Vectern**: ""Getting pretty hot out here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: ""All right, gentlemen. See you l..." |
| `[18]` | **""Not today, Petr. Please focus on your duties for now.""** | `[17]` **Petr Vectern**: ""After I'm finished with the arr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Petr Vectern**: ""Y-yeah, of course."" |
| `[19]` | **""Of course. Find me when you're done. We'll go have some nice whiskey.""** | `[17]` **Petr Vectern**: ""After I'm finished with the arr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Petr Vectern**: ""Great. My mouth's already water..." |
| `[25]` | **""Perfect timing. Tell him I'll be right there.""** | `[13]` **Livia Suno**: ""Pardon the interruption, gentle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Livia Suno**: ""I will, sir."" |
| `[26]` | **""Tell him I'm busy.""** | `[13]` **Livia Suno**: ""Pardon the interruption, gentle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Livia Suno**: ""I will, sir."" |
| `[27]` | **""You know the details. Handle him yourself.""** | `[13]` **Livia Suno**: ""Pardon the interruption, gentle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Livia Suno**: ""I will, sir."" |

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
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_Success == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""I think it's time to conclude our little meeting, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "There was a tap on my shoulder. Livia Suno had joined us ..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Lucian looked at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucian Galade: ""I think it's time to conclude our little meeting, sir.""*)

### Węzeł `[8]`
Mówca: **Narrator**
> "There was a tap on my shoulder. Livia Suno had joined us on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Livia Suno: ""Pardon the interruption, gentlemen. Mr. President, Deivi..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true || BaseGame.Reform_Reform_PFJP_Convinced == true || BaseGame.Amendment_PFJP_Frens_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true || BaseGame...."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == true || BaseGam..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true || BaseGame.Reform_Reform_PFJP_Convinced == true || BaseGame.Amendment_PFJP_Frens_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true  or  Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true  or  Variable["BaseGame.Amendment_PFJP_Frens_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == true || BaseGame.Reform_Reform_PFJP_Convinced == true || BaseGame.Amendment_PFJP_Frens_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true  or  Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true  or  Variable["BaseGame.Amendment_PFJP_Frens_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Lucian looked at his watch."*)

### Węzeł `[12]`
Mówca: **Petr Vectern**
> ""Getting pretty hot out here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""Okay. Let's call it finished. You may both go.""*)
  - -> `[14]` (*Player: ""I need a drink.""*)

### Węzeł `[13]`
Mówca: **Livia Suno**
> ""Pardon the interruption, gentlemen. Mr. President, Deivid Wisci is calling about the upcoming foreign policy meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""Perfect timing. Tell him I'll be right there.""*)
  - -> `[26]` (*Player: ""Tell him I'm busy.""*)
  - -> `[27]` (*Player: ""You know the details. Handle him yourself.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""I need a drink.""]** — Mówca: **Player**
> ""I need a drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Petr Vectern: ""I can help you with that. If you want...""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Okay. Let's call it finished. You may both go.""]** — Mówca: **Player**
> ""Okay. Let's call it finished. You may both go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""All right, gentlemen. See you later.""*)

### Węzeł `[16]`
Mówca: **Petr Vectern**
> ""I can help you with that. If you want...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Petr Vectern: ""After I'm finished with the arrangements, of course.""*)

### Węzeł `[17]`
Mówca: **Petr Vectern**
> ""After I'm finished with the arrangements, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""Of course. Find me when you're done. We'll go have some ..."*)
  - -> `[18]` (*Player: ""Not today, Petr. Please focus on your duties for now.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Not today, Petr. Please focus on your duties for now.""]** — Mówca: **Player**
> ""Not today, Petr. Please focus on your duties for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Petr Vectern: ""Y-yeah, of course.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Of course. Find me when you're done. We'll go have some nice whiskey.""]** — Mówca: **Player**
> ""Of course. Find me when you're done. We'll go have some nice whiskey.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: ""Great. My mouth's already watering.""*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""Great. My mouth's already watering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He laughed."*)

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""Y-yeah, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""All right, gentlemen. See you later.""*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""All right, gentlemen. See you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "They both left."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""All right, gentlemen. See you later.""*)

### Węzeł `[24]`
Mówca: **Narrator**
> "They both left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Perfect timing. Tell him I'll be right there.""]** — Mówca: **Player**
> ""Perfect timing. Tell him I'll be right there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Livia Suno: ""I will, sir.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Tell him I'm busy.""]** — Mówca: **Player**
> ""Tell him I'm busy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Livia Suno: ""I will, sir.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""You know the details. Handle him yourself.""]** — Mówca: **Player**
> ""You know the details. Handle him yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Livia Suno: ""I will, sir.""*)

### Węzeł `[28]`
Mówca: **Livia Suno**
> ""I will, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "She turned to leave the balcony, then back to us."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "She turned to leave the balcony, then back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_Success == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Livia Suno: ""Congratulations on the victory, Mr. Rayne. Petr.""*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Livia Suno: ""My condolences on the vote results, Mr. Rayne. Petr.""*)

### Węzeł `[33]`
Mówca: **Livia Suno**
> ""Congratulations on the victory, Mr. Rayne. Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "She looked Petr in the eye as she said this, and ignored ..."*)

### Węzeł `[34]`
Mówca: **Livia Suno**
> ""My condolences on the vote results, Mr. Rayne. Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "She looked Petr in the eye as she said this, and ignored ..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "She looked Petr in the eye as she said this, and ignored Lucian altogether. Petr's eyes followed her as she walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Petr Vectern: ""Getting pretty hot out here.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_AssemblyVote_ResultsMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_AssemblyVote_ResultsMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_Success == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_VoteFail_USPCritici..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_VoteWon_KibenerCongratulates = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteWon_KibenerCongratulates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_VoteFail_USPCriticizes = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteFail_USPCriticizes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_VoteWon_KibenerCong..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_PFJP_Convinced == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_VoteWon_RicterCongr..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_PFJP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_VoteWon_RicterCongratulates = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteWon_RicterCongratulates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Signed a bill which restricts teaching i..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_AssemblyVote_ResultsMeeting = true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Signed a bill which restricts teaching in other languages", "Maroon Palace", "Holsord");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Signed a bill which restricts teaching in other languages","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_AssemblyVote_ResultsMeeting = true"*)
