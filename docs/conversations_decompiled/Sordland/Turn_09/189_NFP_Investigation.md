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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[13]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP"] = true;`
- Węzeł `[22]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false; Variable["BaseGameSuppo...`
- Węzeł `[36]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] = true; Variable["BaseGam...`
- Węzeł `[37]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus"] = true; Variable["BaseGameSupport....`
- Węzeł `[44]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false; Variable["BaseGameSuppo...`
- Węzeł `[45]` (Paskal Beniwoll): `AssignConnection("Page_Legislative","Position_NotableMember_2","");`
- Węzeł `[46]` (Paskal Beniwoll): `Variable["BaseGame.NFPLeader_Remus"] = false;`
- Węzeł `[47]` (Paskal Beniwoll): `AssignConnection("Page_Legislative","Position_NotableMember_2","");`
- *...oraz 1 innych węzłów ze skryptami.*

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `188` (*Sordland/Turn09/A_CampaignAndInvestigations*), Węzeł `[51]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""It concerns the Bernard Circas assassination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Detained_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Detained_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Detained_KesaroKibener == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""I assume Ms. Graf will want to take action on this immediately. They could go to trial by the end of the month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""It concerns the Bernard Circas assassination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""Excellent, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""The investigators have discovered proof that current NFP head Remus Holstron, together with Kesaro Kibener, collaborated with the Young Sords to orchestrate the murder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[16]`
  - -> `[21]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Excellent, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""The investigators have discovered proof that both Kesaro Kibener and his right-hand man Remus Holstron collaborated with the Young Sords to orchestrate the murder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""That's honestly not surprising.""]** — Mówca: **Player**
> ""That's honestly not surprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""So, should I give the order to arrest Mr. Holstron?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[28]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Ha! We got him.""]** — Mówca: **Player**
> ""Ha! We got him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""So, should I give the order to arrest Mr. Holstron and Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""That's honestly not surprising.""]** — Mówca: **Player**
> ""That's honestly not surprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Ha! We got them.""]** — Mówca: **Player**
> ""Ha! We got them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""I assume Mrs. Morgna will want to take action on this immediately. They could go to trial by the end of the month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Is that going to be enough to put him away?""]** — Mówca: **Player**
> ""Is that going to be enough to put him away?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""This would've been a golden opportunity for us. But I suppose we'll always have the evidence on file.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Yes. The sooner the better.""]** — Mówca: **Player**
> ""Yes. The sooner the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""No, let this be our little secret for now.""]** — Mówca: **Player**
> ""No, let this be our little secret for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""Yes. The sooner the better.""]** — Mówca: **Player**
> ""Yes. The sooner the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""I assume Ms. Graf will want to take action on this immediately. They could go to trial by the end of the month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Lucian's brow wrinkled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""I assume Mrs. Morgna will want to take action on this immediately. They could go to trial by the end of the month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro = true;
BaseGameSupport.Journal_Turn09_Investigations_TrialRemusAndKesaro = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] = true;
Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialRemusAndKesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus = true;
BaseGameSupport.Journal_Turn09_Investigations_TrialRemus = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus"] = true;
Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialRemus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_NotableMember_2", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_2","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.NFPLeader_Remus"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_NotableMember_2", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_2","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_NotableMember_5", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_5","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
