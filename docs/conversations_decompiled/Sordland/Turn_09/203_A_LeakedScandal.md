# Sordland/Turn09/A_LeakedScandal

- **ID konwersacji:** `203`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/203_A_LeakedScandal.md`
- **Liczba węzłów dialogowych:** 764
- **Liczba wyborów gracza:** 9

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory
- **[38]** Lucian Galade
- **[57]** Reporter
- **[61]** Albin Clavin

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.Decision_Turn08_VPSelection_Lucian`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandal_AlbinClavin_Bribe`
- `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.LeakedScandal_FrensRicter_Bribe`
- `BaseGame.LeakedScandal_FrensRicter_TaurusBribe`
- `BaseGame.LeakedScandal_GusManger_UnderhallCollusion`
- `BaseGame.LeakedScandal_HeronGaraci_Bribe`
- `BaseGame.LeakedScandal_HiddenFunding_RedYouth`
- `BaseGame.LeakedScandal_HiddenFunding_YoungSords`
- `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal`
- `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation`
- `BaseGame.LeakedScandal_PrivatizationShares_Both`
- `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti`
- `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk`
- `BaseGame.LeakedScandal_SecretState_DetainFrensRicter`
- `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_DetainPetrVectern`
- `BaseGame.LeakedScandal_SecretState_KillFrensRicter`
- `BaseGame.LeakedScandal_SecretState_KillKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_KillLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_KillOrsoHawker`
- `BaseGame.LeakedScandal_SecretState_KillPetrVectern`
- `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses`
- `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp`
- `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_AntiCorruptionPolice`
- `BaseGame.Policy_Law_Impeachment_Removed`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Situation_Law_MediaCensored`
- `BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone_Impeached`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators_Impeached`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs_Impeached`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP_Impeached`
- `BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment`
- `BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment_HandledScandal`
- `BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment`
- `BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment_HandledScandal`
- `BaseGameSupport.News_Turn09_E_Scandals_PresidentEmbarrassed`
- `BaseGameSupport.News_Turn09_HP_Scandals_RayneBoughtMedia`
- `BaseGameSupport.News_Turn09_HP_Scandals_RayneImpeachment`
- `BaseGameSupport.News_Turn09_LT_Scandals_RayneLies`
- `BaseGameSupport.News_Turn09_ST_Scandals_RayneCorruption`
- `GameCondition.Turn09_A_LeakedScandal`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 20

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGameSupport.News_Turn09_ST_Scandals_RayneCorruption`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[624]` (Paskal Beniwoll): `Variable["GameCondition.Turn09_A_LeakedScandal"] = true;`
- Węzeł `[720]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone...`
- Węzeł `[721]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainCons...`
- Węzeł `[722]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs"] = false; V...`
- Węzeł `[723]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"...`
- Węzeł `[724]` (Paskal Beniwoll): `-- continue;`
- Węzeł `[729]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment"] = true;`
- Węzeł `[733]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment_HandledScanda...`
- *...oraz 12 innych węzłów ze skryptami.*

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "As usual, I woke up early in the morning. I put on my clothes and went downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I made a cup of finely ground Sordish coffee along with a slice of buttered toast and sat down in front of the TV to watch the morning news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I changed the channel to SBC News and took a bite of my toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Reporter**
> ""I am curious to see what President Rayne's response will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Reporter**
> ""For those who are tuning in late.... today is certainly going to be a rough day for the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[14]`
Mówca: **Reporter**
> ""We have confirmation about the certainty of these leaks. This is nothing short of a major scandal that could very well lead to the impeachment of President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "I froze and dropped the toast I was about to bite into."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Reporter**
> ""As per the recent information we have received, President Rayne's name is mentioned many times in these leaks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Reporter**
> ""According to the documents...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "She picked up the paper in front of her and started reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Reporter**
> ""President Rayne bribed Albin Clavin with a check while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Reporter**
> ""President Rayne bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Reporter**
> ""President Rayne abused his powers to send his son, Franc Rayne, to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Reporter**
> ""President Rayne bribed Frens Ricter with a check while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Reporter**
> ""President Rayne bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Reporter**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HeronGaraci_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Reporter**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Reporter**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Reporter**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Reporter**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, the two struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Reporter**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_Both == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Reporter**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Reporter**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Reporter**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Reporter**
> ""President Rayne orchestrated the detainment of the ex-PFJP leader, Frens Ricter, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Reporter**
> ""President Rayne orchestrated the detainment of the ex-NFP leader, Kesaro Kibener, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Reporter**
> ""President Rayne has orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Reporter**
> ""President Rayne has orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Reporter**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Reporter**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Reporter**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[106]`
Mówca: **Reporter**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Reporter**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Reporter**
> ""We have been trying to reach out to the Maroon Palace about these allegations and scandals. However, we have been unable to reach anyone yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[114]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "Turn off the TV."]** — Mówca: **Player_Italic**
> "I turned off the TV."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "Flip the table."]** — Mówca: **Player_Italic**
> "I flipped the table in anger and everything on it fell on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "Throw the remote at the TV."]** — Mówca: **Player_Italic**
> "I threw the remote at the TV, causing a large crack to appear at the centre."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Narrator**
> "I buried my face in my hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[116]`
Mówca: **Narrator**
> "I woke up early in the morning, as usual. I put on my clothes and went downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> "I made a cup of finely ground Sordish coffee and a slice of buttered toast and sat down in front of the TV to watch the morning news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[118]`
Mówca: **Narrator**
> "The phone rang. I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[119]`
Mówca: **Narrator**
> "As I was expecting, the phone rang. I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
> "“Mr. President. Have you seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`
  - -> `[139]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
Mówca: **Petr Vectern**
> "“Anton. Have you seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`
  - -> `[139]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[131]`
Mówca: **Gloria Tory**
> "“Mr. President. Have you seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`
  - -> `[139]`

### Węzeł `[132]`
Mówca: **Albin Clavin**
> "“Mr. President. Have you seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`
  - -> `[139]`

### Węzeł `[133]`
Mówca: **Narrator**
> "The operator said that it was Albin Clavin on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[134]`
Mówca: **Narrator**
> "The operator said that it was Gloria Tory on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[135]`
Mówca: **Narrator**
> "The operator said that it was Lucian Galade on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[136]`
Mówca: **Narrator**
> "The operator said that it was Petr Vectern on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Yes. Along with everyone else in the entire northern hemisphere.”"]** — Mówca: **Player**
> "“Yes. Along with everyone else in the entire northern hemisphere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "“Tell it to me straight. How bad is it?”"]** — Mówca: **Player**
> "“Tell it to me straight. How bad is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“I wish I hadn't.”"]** — Mówca: **Player**
> "“I wish I hadn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Albin Clavin**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[150]`
Mówca: **Gloria Tory**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
Mówca: **Petr Vectern**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
Mówca: **Narrator**
> "He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[154]`
Mówca: **Narrator**
> "She took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[155]`
Mówca: **Narrator**
> "He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[156]`
Mówca: **Narrator**
> "He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Albin Clavin**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[158]`
Mówca: **Gloria Tory**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
> "“We might be screwed, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[160]`
Mówca: **Petr Vectern**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
Mówca: **Albin Clavin**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[162]`
Mówca: **Gloria Tory**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[164]`
Mówca: **Petr Vectern**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[165]`
Mówca: **Albin Clavin**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[166]`
Mówca: **Gloria Tory**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Petr Vectern**
> "“You know I'm on your side, but... they've got a pretty good case against you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[170]`
Mówca: **Albin Clavin**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[171]`
Mówca: **Gloria Tory**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[172]`
Mówca: **Petr Vectern**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[173]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
Mówca: **Petr Vectern**
> "“For now, I guess I should give you a moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Albin Clavin**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
Mówca: **Gloria Tory**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[179]`
Mówca: **Petr Vectern**
> "“Hang in there, buddy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[180]`
Mówca: **Albin Clavin**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[181]`
Mówca: **Gloria Tory**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[182]`
Mówca: **Narrator**
> "The operator said that it was Petr Vectern on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[186]`
Mówca: **Albin Clavin**
> "“Mr. President. Sorry for calling you directly, but this is important.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[187]`
Mówca: **Narrator**
> "The operator said that it was Gloria Tory on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[194]`
Mówca: **Gloria Tory**
> "“Mr. President. Sorry for calling you directly, but this is important.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[195]`
Mówca: **Narrator**
> "The operator said that it was Albin Clavin on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[196]`
Mówca: **Narrator**
> "The operator said that it was Lucian Galade on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Lucian Galade**
> "“Mr. President. Sorry for calling you directly, but this is important.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[198]`
Mówca: **Petr Vectern**
> "“Anton. Bad news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[199]`
Mówca: **Albin Clavin**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`
  - -> `[205]`

### Węzeł `[200]`
Mówca: **Gloria Tory**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`
  - -> `[205]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`
  - -> `[205]`

### Węzeł `[202]`
Mówca: **Petr Vectern**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`
  - -> `[205]`

### Węzeł `[203]`
**[WYBÓR GRACZA: "“An impeachment? For what?”"]** — Mówca: **Player**
> "“An impeachment? For what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[204]`
**[WYBÓR GRACZA: "“What happened? Speak.”"]** — Mówca: **Player**
> "“What happened? Speak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "“What the hell is going on?”"]** — Mówca: **Player**
> "“What the hell is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
Mówca: **Narrator**
> "She took a deep breath in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[207]`
Mówca: **Albin Clavin**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[217]`
Mówca: **Gloria Tory**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[218]`
Mówca: **Petr Vectern**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[220]`
Mówca: **Petr Vectern**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[221]`
Mówca: **Narrator**
> "He took a deep breath in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[222]`
Mówca: **Albin Clavin**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[223]`
Mówca: **Lucian Galade**
> "“We might be screwed, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[224]`
Mówca: **Gloria Tory**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[225]`
Mówca: **Narrator**
> "He took a deep breath in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[226]`
Mówca: **Narrator**
> "He took a deep breath in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[227]`
Mówca: **Albin Clavin**
> "“They are citing a major scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[228]`
Mówca: **Gloria Tory**
> "“They are citing a major scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[229]`
Mówca: **Petr Vectern**
> "“We're talking about a major scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[230]`
Mówca: **Lucian Galade**
> "“They are citing a major scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[231]`
Mówca: **Albin Clavin**
> "“I received a report and took notes. Here is what it says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[232]`
Mówca: **Gloria Tory**
> "“I received a report and took notes. Here is what it says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[233]`
Mówca: **Petr Vectern**
> "“I took notes from their report. Here is what it says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[234]`
Mówca: **Lucian Galade**
> "“I received a report and took notes. Here is what it says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[235]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Albin Clavin with a check while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Albin Clavin**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[249]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Albin Clavin**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[254]`
Mówca: **Albin Clavin**
> ""President Rayne abused his powers to send his son, Franc Rayne to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[255]`
Mówca: **Albin Clavin**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[259]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the detainment of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[263]`
Mówca: **Albin Clavin**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[264]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the detainment of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[265]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Frens Ricter with a check while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[272]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[276]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[277]`
Mówca: **Albin Clavin**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[281]`
Mówca: **Albin Clavin**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_Both == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HeronGaraci_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[294]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[295]`
Mówca: **Albin Clavin**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[296]`
Mówca: **Albin Clavin**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[303]`
Mówca: **Albin Clavin**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[307]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[314]`
Mówca: **Albin Clavin**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[315]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[316]`
Mówca: **Albin Clavin**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[317]`
Mówca: **Albin Clavin**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, they struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
> ""President Rayne has bribed Albin Clavin with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Lucian Galade**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[341]`
Mówca: **Lucian Galade**
> ""President Rayne has bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Lucian Galade**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[346]`
Mówca: **Lucian Galade**
> ""President Rayne abused his powers to send his son, Franc Rayne to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[347]`
Mówca: **Lucian Galade**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[351]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the detainment of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[355]`
Mówca: **Lucian Galade**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[356]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the detainment of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[357]`
Mówca: **Lucian Galade**
> ""President Rayne has bribed Frens Ricter with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[364]`
Mówca: **Lucian Galade**
> ""President Rayne has bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[368]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[369]`
Mówca: **Lucian Galade**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[373]`
Mówca: **Lucian Galade**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_Both == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HeronGaraci_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[386]`
Mówca: **Lucian Galade**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[387]`
Mówca: **Lucian Galade**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[388]`
Mówca: **Lucian Galade**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[395]`
Mówca: **Lucian Galade**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[399]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[406]`
Mówca: **Lucian Galade**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[407]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[408]`
Mówca: **Lucian Galade**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[409]`
Mówca: **Lucian Galade**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, they struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[419]`
Mówca: **Petr Vectern**
> ""President Rayne has bribed Albin Clavin with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Petr Vectern**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[433]`
Mówca: **Petr Vectern**
> ""President Rayne has bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Petr Vectern**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[438]`
Mówca: **Petr Vectern**
> ""President Rayne abused his powers to send his son, Franc Rayne to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[439]`
Mówca: **Petr Vectern**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[443]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the detainment of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[447]`
Mówca: **Petr Vectern**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[448]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the detainment of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[449]`
Mówca: **Petr Vectern**
> ""President Rayne has bribed Frens Ricter with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[455]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[456]`
Mówca: **Petr Vectern**
> ""President Rayne has bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[460]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[461]`
Mówca: **Petr Vectern**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[465]`
Mówca: **Petr Vectern**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_Both == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HeronGaraci_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[478]`
Mówca: **Petr Vectern**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[479]`
Mówca: **Petr Vectern**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[480]`
Mówca: **Petr Vectern**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[483]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[487]`
Mówca: **Petr Vectern**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`
  - -> `[490]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[491]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[494]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[498]`
Mówca: **Petr Vectern**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[499]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[500]`
Mówca: **Petr Vectern**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[501]`
Mówca: **Petr Vectern**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, they struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`
  - -> `[510]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[511]`
Mówca: **Gloria Tory**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[515]`
Mówca: **Gloria Tory**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[519]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the detainment of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[520]`
Mówca: **Gloria Tory**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[521]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the detainment of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[524]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[527]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[528]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[529]`
Mówca: **Gloria Tory**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[532]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[536]`
Mówca: **Gloria Tory**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[543]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[544]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[545]`
Mówca: **Gloria Tory**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[548]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[551]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[552]`
Mówca: **Gloria Tory**
> ""President Rayne abused his powers to send his son, Franc Rayne to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`
  - -> `[555]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[559]`
Mówca: **Gloria Tory**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[560]`
Mówca: **Gloria Tory**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[561]`
Mówca: **Gloria Tory**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[562]`
Mówca: **Gloria Tory**
> ""President Rayne has bribed Albin Clavin with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[568]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HeronGaraci_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HeronGaraci_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[574]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[575]`
Mówca: **Gloria Tory**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, they struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[576]`
Mówca: **Gloria Tory**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`
  - -> `[582]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[583]`
Mówca: **Gloria Tory**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[584]`
Mówca: **Gloria Tory**
> ""President Rayne has bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[585]`
Mówca: **Gloria Tory**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`
  - -> `[591]`

### Węzeł `[590]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`
  - -> `[594]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_Both == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[595]`
Mówca: **Gloria Tory**
> ""President Rayne has bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`
  - -> `[598]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[599]`
Mówca: **Gloria Tory**
> ""President Rayne has bribed Frens Ricter with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`
  - -> `[602]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[603]`
Mówca: **Albin Clavin**
> ""They know about our goddamn deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`
  - -> `[606]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[606]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[607]`
Mówca: **Albin Clavin**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[608]`
Mówca: **Gloria Tory**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[609]`
Mówca: **Gloria Tory**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[610]`
Mówca: **Lucian Galade**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[611]`
Mówca: **Lucian Galade**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[612]`
Mówca: **Albin Clavin**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[613]`
Mówca: **Gloria Tory**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[614]`
Mówca: **Petr Vectern**
> "“But, for now, I'll give you a moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[615]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[616]`
Mówca: **Lucian Galade**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[617]`
Mówca: **Albin Clavin**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[618]`
Mówca: **Petr Vectern**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[619]`
Mówca: **Gloria Tory**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[620]`
Mówca: **Petr Vectern**
> "“I'm still on your side, of course. But they've built up a pretty solid case against you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[621]`
Mówca: **Petr Vectern**
> "“Hang in there, buddy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[622]`
Mówca: **Albin Clavin**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[623]`
Mówca: **Lucian Galade**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[624]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_A_LeakedScandal = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_A_LeakedScandal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[625]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`
  - -> `[627]`

### Węzeł `[626]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Reporter**
> ""President Rayne ordered the Secret State Police to detain Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`
  - -> `[631]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[632]`
Mówca: **Reporter**
> ""President Rayne ordered the Secret State Police to kill Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[633]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`
  - -> `[635]`

### Węzeł `[634]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[636]`
Mówca: **Reporter**
> ""President Rayne ordered the detainment of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[637]`
Mówca: **Reporter**
> ""President Rayne ordered the assassination of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[638]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`
  - -> `[640]`

### Węzeł `[639]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[641]`
Mówca: **Reporter**
> ""Yes. You heard that right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[642]`
Mówca: **Reporter**
> ""Yes. You heard that right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[643]`
Mówca: **Albin Clavin**
> ""President Rayne ordered the Secret State Police to detain Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[644]`
Mówca: **Albin Clavin**
> ""Yes. You heard that right. Ridiculous accusations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[645]`
Mówca: **Albin Clavin**
> ""President Rayne ordered the Secret State Police to kill Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[646]`
Mówca: **Albin Clavin**
> ""President Rayne ordered the detainment of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[647]`
Mówca: **Albin Clavin**
> ""Yes. You heard that right. Ridiculous accusations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[648]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`
  - -> `[650]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[651]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`
  - -> `[653]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[654]`
Mówca: **Albin Clavin**
> ""President Rayne ordered the assassination of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`
  - -> `[657]`

### Węzeł `[656]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[658]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`
  - -> `[660]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[661]`
Mówca: **Gloria Tory**
> ""President Rayne ordered the Secret State Police to detain Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[662]`
Mówca: **Gloria Tory**
> ""President Rayne ordered the Secret State Police to kill Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[663]`
Mówca: **Gloria Tory**
> ""President Rayne ordered the detainment of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[664]`
Mówca: **Gloria Tory**
> ""Yes. You heard that right. Ridiculous accusations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[665]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[667]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`
  - -> `[670]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`
  - -> `[673]`

### Węzeł `[672]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[673]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[677]`
Mówca: **Gloria Tory**
> ""Yes. You heard that right. Ridiculous accusations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[678]`
Mówca: **Gloria Tory**
> ""President Rayne ordered the assassination of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[679]`
Mówca: **Lucian Galade**
> ""President Rayne ordered the Secret State Police to detain Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[680]`
Mówca: **Lucian Galade**
> ""President Rayne ordered the Secret State Police to kill Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[681]`
Mówca: **Lucian Galade**
> ""President Rayne ordered the detainment of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`
  - -> `[684]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[685]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`
  - -> `[687]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`
  - -> `[693]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[694]`
Mówca: **Lucian Galade**
> ""President Rayne ordered the assassination of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[695]`
Mówca: **Petr Vectern**
> ""President Rayne ordered the Secret State Police to detain Livia Suno -- that can't be true, can it? You told me she quit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[696]`
Mówca: **Petr Vectern**
> ""President Rayne ordered the Secret State Police to kill Livia Suno -- that can't be true, can it? You told me she quit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[697]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`
  - -> `[699]`

### Węzeł `[698]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`
  - -> `[702]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[703]`
Mówca: **Petr Vectern**
> ""God damn this shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[704]`
Mówca: **Petr Vectern**
> ""God damn this shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[705]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`
  - -> `[707]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`
  - -> `[710]`

### Węzeł `[709]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[710]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[711]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`
  - -> `[713]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`
  - -> `[716]`

### Węzeł `[715]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`
  - -> `[719]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone_Impeached = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone_Impeached"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators_Impeached = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators_Impeached"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[722]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs_Impeached = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs_Impeached"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP_Impeached = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP_Impeached"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`
  - -> `[727]`

### Węzeł `[726]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[727]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[728]`
Mówca: **Reporter**
> ""We have confirmation about the certainty of these leaks. This is nothing short of a major scandal that could cause a massive drop in popularity for President Rayne in the upcoming elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[729]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[730]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`
  - -> `[732]`

### Węzeł `[731]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[732]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[733]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment_HandledScandal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment_HandledScandal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_HP_Scandals_RayneImpeachment = true;
BaseGameSupport.News_Turn09_E_Scandals_PresidentEmbarrassed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Scandals_RayneImpeachment"] = true;
Variable["BaseGameSupport.News_Turn09_E_Scandals_PresidentEmbarrassed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[735]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`
  - -> `[737]`

### Węzeł `[736]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[737]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment_HandledScandal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment_HandledScandal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_LT_Scandals_RayneLies = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_LT_Scandals_RayneLies"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`
  - -> `[742]`

### Węzeł `[741]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaBias == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[743]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`
  - -> `[745]`

### Węzeł `[744]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`
  - -> `[748]`

### Węzeł `[747]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[749]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_ST_Scandals_RayneCorruption = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_ST_Scandals_RayneCorruption"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[750]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`
  - -> `[752]`

### Węzeł `[751]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[752]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[753]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_HP_Scandals_RayneBoughtMedia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Scandals_RayneBoughtMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[754]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[755]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[756]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[757]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`
  - -> `[759]`

### Węzeł `[758]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhoneRingPickUp");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhoneRingPickUp");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[762]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[763]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
