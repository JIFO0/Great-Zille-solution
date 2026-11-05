# Sordland/Turn09/NFP Investigation

- **ID konwersacji:** `189`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/189_NFP_Investigation.md`
- **Liczba węzłów dialogowych:** 49
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_KesaroKibener`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.NFPLeader_Remus`
- `BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus`
- `BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro`
- `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialRemus`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialRemusAndKesaro`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[51]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""That's honestly not surprising.""** | `[10]` **Lucian Galade**: ""The investigators have discover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Lucian Galade**: ""I assume Ms. Graf will want to ..."<br>`[20]` **Lucian Galade**: ""I assume Mrs. Morgna will want ..." |
| `[16]` | **""Ha! We got him.""** | `[10]` **Lucian Galade**: ""The investigators have discover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Lucian Galade**: ""I assume Ms. Graf will want to ..."<br>`[20]` **Lucian Galade**: ""I assume Mrs. Morgna will want ..." |
| `[18]` | **""That's honestly not surprising.""** | `[12]` **Lucian Galade**: ""The investigators have discover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucian Galade**: ""I assume Ms. Graf will want to ..."<br>`[35]` **Lucian Galade**: ""I assume Mrs. Morgna will want ..." |
| `[19]` | **""Ha! We got them.""** | `[12]` **Lucian Galade**: ""The investigators have discover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucian Galade**: ""I assume Ms. Graf will want to ..."<br>`[35]` **Lucian Galade**: ""I assume Mrs. Morgna will want ..." |
| `[21]` | **""Is that going to be enough to put him away?""** | `[10]` **Lucian Galade**: ""The investigators have discover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Lucian Galade**: ""I assume Ms. Graf will want to ..."<br>`[20]` **Lucian Galade**: ""I assume Mrs. Morgna will want ..." |
| `[24]` | **""Yes. The sooner the better.""** | `[15]` **Lucian Galade**: ""So, should I give the order to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Re...`<br>`Variable["BaseGameSupport.Codex_Organisations_Governmenta...`<br>*(+2 skryptów)* | `[11]` **Lucian Galade**: ""Excellent, sir."" |
| `[28]` | **""No, let this be our little secret for now.""** | `[15]` **Lucian Galade**: ""So, should I give the order to ..."<br>`[17]` **Lucian Galade**: ""So, should I give the order to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Lucian's brow wrinkled." |
| `[29]` | **""Yes. The sooner the better.""** | `[17]` **Lucian Galade**: ""So, should I give the order to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Re...`<br>`Variable["BaseGameSupport.Codex_Organisations_Governmenta...`<br>*(+2 skryptów)* | `[9]` **Lucian Galade**: ""Excellent, sir."" |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_KesaroKibener == true ||..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""It concerns the Bernard Circas assassination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""The investigators have discovered proof that both Kesaro..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Detained_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_KesaroKibener == true ||..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_KesaroKibener == true ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Detained_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucian Galade: ""It concerns the Bernard Circas assassination.""*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Detained_KesaroKibener == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""It concerns the Bernard Circas assassination.""*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""I assume Ms. Graf will want to take action on this immediately. They could go to trial by the end of the month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""So, should I give the order to arrest Mr. Holstron?""*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""It concerns the Bernard Circas assassination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""The investigators have discovered proof that current NFP..."*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""Excellent, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_CampaignInvestigations_Discusse..."*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""The investigators have discovered proof that current NFP head Remus Holstron, together with Kesaro Kibener, collaborated with the Young Sords to orchestrate the murder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""That's honestly not surprising.""*)
  - -> `[16]` (*Player: ""Ha! We got him.""*)
  - -> `[21]` (*Player: ""Is that going to be enough to put him away?""*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Excellent, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_CampaignInvestigations_Discusse..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""The investigators have discovered proof that both Kesaro Kibener and his right-hand man Remus Holstron collaborated with the Young Sords to orchestrate the murder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: ""That's honestly not surprising.""*)
  - -> `[19]` (*Player: ""Ha! We got them.""*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""That's honestly not surprising.""]** — Mówca: **Player**
> ""That's honestly not surprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""So, should I give the order to arrest Mr. Holstron?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""Yes. The sooner the better.""*)
  - -> `[28]` (*Player: ""No, let this be our little secret for now.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Ha! We got him.""]** — Mówca: **Player**
> ""Ha! We got him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""So, should I give the order to arrest Mr. Holstron and Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""No, let this be our little secret for now.""*)
  - -> `[29]` (*Player: ""Yes. The sooner the better.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""That's honestly not surprising.""]** — Mówca: **Player**
> ""That's honestly not surprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Ha! We got them.""]** — Mówca: **Player**
> ""Ha! We got them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""I assume Mrs. Morgna will want to take action on this immediately. They could go to trial by the end of the month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""So, should I give the order to arrest Mr. Holstron?""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Is that going to be enough to put him away?""]** — Mówca: **Player**
> ""Is that going to be enough to put him away?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesa..."*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""This would've been a golden opportunity for us. But I suppose we'll always have the evidence on file.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_CampaignInvestigations_Discusse..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Yes. The sooner the better.""]** — Mówca: **Player**
> ""Yes. The sooner the better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: ""I assume Ms. Graf will want to take action on this immed..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""I assume Mrs. Morgna will want to take action on this im..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""No, let this be our little secret for now.""]** — Mówca: **Player**
> ""No, let this be our little secret for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade), `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Lucian's brow wrinkled."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""Yes. The sooner the better.""]** — Mówca: **Player**
> ""Yes. The sooner the better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""I assume Ms. Graf will want to take action on this immed..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: ""I assume Mrs. Morgna will want to take action on this im..."*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""I assume Ms. Graf will want to take action on this immediately. They could go to trial by the end of the month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""So, should I give the order to arrest Mr. Holstron and M..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Lucian's brow wrinkled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: ""This would've been a golden opportunity for us. But I su..."*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""I assume Mrs. Morgna will want to take action on this immediately. They could go to trial by the end of the month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""So, should I give the order to arrest Mr. Holstron and M..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro = true;
BaseGameSupport.Journal_Turn09_Investigations_TrialRemusAndKesaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] = true;
Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialRemusAndKesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_NotableMem..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus = true;
BaseGameSupport.Journal_Turn09_Investigations_TrialRemus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus"] = true;
Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialRemus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus = false"*)

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
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesa..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP = fa..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus = true..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP = fa..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus = true..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_NotableMember_2", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_2","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""Excellent, sir.""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.NFPLeader_Remus"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_NotableMem..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_NotableMember_2", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_2","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_NotableMem..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_NotableMember_5", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_5","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: ""Excellent, sir.""*)
