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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[112]` | **"Turn off the TV."** | `[111]` **Reporter**: ""We have been trying to reach ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I buried my face in my hands." |
| `[113]` | **"Flip the table."** | `[111]` **Reporter**: ""We have been trying to reach ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I buried my face in my hands." |
| `[114]` | **"Throw the remote at the TV."** | `[111]` **Reporter**: ""We have been trying to reach ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I buried my face in my hands." |
| `[137]` | **"“Yes. Along with everyone else in the entire northern hemisphere.”"** | `[120]` **Lucian Galade**: "“Mr. President. Have you seen th..."<br>`[124]` **Petr Vectern**: "“Anton. Have you seen the news?”"<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Albin Clavin**: "“To be frank...”"<br>`[150]` **Gloria Tory**: "“To be frank...”"<br>*(oraz 2 innych odgałęzień)* |
| `[138]` | **"“Tell it to me straight. How bad is it?”"** | `[120]` **Lucian Galade**: "“Mr. President. Have you seen th..."<br>`[124]` **Petr Vectern**: "“Anton. Have you seen the news?”"<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Albin Clavin**: "“To be frank...”"<br>`[150]` **Gloria Tory**: "“To be frank...”"<br>*(oraz 2 innych odgałęzień)* |
| `[139]` | **"“I wish I hadn't.”"** | `[120]` **Lucian Galade**: "“Mr. President. Have you seen th..."<br>`[124]` **Petr Vectern**: "“Anton. Have you seen the news?”"<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Albin Clavin**: "“To be frank...”"<br>`[150]` **Gloria Tory**: "“To be frank...”"<br>*(oraz 2 innych odgałęzień)* |
| `[203]` | **"“An impeachment? For what?”"** | `[199]` **Albin Clavin**: "“I just received word that they ..."<br>`[200]` **Gloria Tory**: "“I just received word that they ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Albin Clavin**: "“To be frank...”"<br>`[217]` **Gloria Tory**: "“To be frank...”"<br>*(oraz 2 innych odgałęzień)* |
| `[204]` | **"“What happened? Speak.”"** | `[199]` **Albin Clavin**: "“I just received word that they ..."<br>`[200]` **Gloria Tory**: "“I just received word that they ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Albin Clavin**: "“To be frank...”"<br>`[217]` **Gloria Tory**: "“To be frank...”"<br>*(oraz 2 innych odgałęzień)* |
| `[205]` | **"“What the hell is going on?”"** | `[199]` **Albin Clavin**: "“I just received word that they ..."<br>`[200]` **Gloria Tory**: "“I just received word that they ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Albin Clavin**: "“To be frank...”"<br>`[217]` **Gloria Tory**: "“To be frank...”"<br>*(oraz 2 innych odgałęzień)* |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaCensored == true || BaseGame...."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaCensored == true || BaseGame...."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaCensored == true || BaseGam..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "As usual, I woke up early in the morning. I put on my clo..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "As usual, I woke up early in the morning. I put on my clothes and went downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "I made a cup of finely ground Sordish coffee along with a..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews =..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true || BaseGame.Sit..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I made a cup of finely ground Sordish coffee along with a slice of buttered toast and sat down in front of the TV to watch the morning news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I changed the channel to SBC News and took a bite of my t..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I changed the channel to SBC News and took a bite of my toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Reporter: ""I am curious to see what President Rayne's response will..."*)

### Węzeł `[12]`
Mówca: **Reporter**
> ""I am curious to see what President Rayne's response will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Reporter: ""For those who are tuning in late.... today is certainly ..."*)

### Węzeł `[13]`
Mówca: **Reporter**
> ""For those who are tuning in late.... today is certainly going to be a rough day for the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Removed == true"*)

### Węzeł `[14]`
Mówca: **Reporter**
> ""We have confirmation about the certainty of these leaks. This is nothing short of a major scandal that could very well lead to the impeachment of President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I froze and dropped the toast I was about to bite into."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "I froze and dropped the toast I was about to bite into."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Reporter: ""As per the recent information we have received, Presiden..."*)

### Węzeł `[16]`
Mówca: **Reporter**
> ""As per the recent information we have received, President Rayne's name is mentioned many times in these leaks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Reporter: ""According to the documents...""*)

### Węzeł `[17]`
Mówca: **Reporter**
> ""According to the documents...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "She picked up the paper in front of her and started reading."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "She picked up the paper in front of her and started reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Reporter: ""President Rayne bribed Albin Clavin with a check while t..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[22]`
Mówca: **Reporter**
> ""President Rayne bribed Albin Clavin with a check while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == t..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Reporter: ""President Rayne bribed Albin Clavin with the Vice Presid..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[26]`
Mówca: **Reporter**
> ""President Rayne bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Reporter: ""President Rayne abused his powers to send his son, Franc..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[30]`
Mówca: **Reporter**
> ""President Rayne abused his powers to send his son, Franc Rayne, to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Reporter: ""President Rayne bribed Frens Ricter with a check while t..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[34]`
Mówca: **Reporter**
> ""President Rayne bribed Frens Ricter with a check while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Reporter: ""President Rayne bribed Frens Ricter with the promise to ..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[38]`
Mówca: **Reporter**
> ""President Rayne bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Reporter: ""President Rayne was involved in collusion along with Gus..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[42]`
Mówca: **Reporter**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Reporter: ""President Rayne bribed Heron Garaci during the constitut..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[46]`
Mówca: **Reporter**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Reporter: ""President Rayne has been secretly funding the Red Youth ..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[50]`
Mówca: **Reporter**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Reporter: ""President Rayne has been secretly funding the Young Sord..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[54]`
Mówca: **Reporter**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Reporter: ""President Rayne has been in cahoots with the media mogul..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[58]`
Mówca: **Reporter**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, the two struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigatio..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Reporter: ""President Rayne was involved in an obstruction of justic..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[62]`
Mówca: **Reporter**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Reporter: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[66]`
Mówca: **Reporter**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoront..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Reporter: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[70]`
Mówca: **Reporter**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk =..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Reporter: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[74]`
Mówca: **Reporter**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Reporter: ""President Rayne orchestrated the detainment of the ex-PF..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[78]`
Mówca: **Reporter**
> ""President Rayne orchestrated the detainment of the ex-PFJP leader, Frens Ricter, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Reporter: ""President Rayne orchestrated the detainment of the ex-NF..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[82]`
Mówca: **Reporter**
> ""President Rayne orchestrated the detainment of the ex-NFP leader, Kesaro Kibener, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == t..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Reporter: ""President Rayne has orchestrated the death of ex-PFJP le..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[86]`
Mówca: **Reporter**
> ""President Rayne has orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener ==..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Reporter: ""President Rayne has orchestrated the death of ex-NFP lea..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[90]`
Mówca: **Reporter**
> ""President Rayne has orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Reporter: ""President Rayne orchestrated the death of the ex-Chief J..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[94]`
Mówca: **Reporter**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == ..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Reporter: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[98]`
Mówca: **Reporter**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Reporter: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[102]`
Mówca: **Reporter**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Reporter: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[106]`
Mówca: **Reporter**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Reporter: ""The list goes on and on.""*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Reporter: ""We have been trying to reach out to the Maroon Palace ab..."*)

### Węzeł `[110]`
Mówca: **Reporter**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Reporter: ""We have been trying to reach out to the Maroon Palace ab..."*)

### Węzeł `[111]`
Mówca: **Reporter**
> ""We have been trying to reach out to the Maroon Palace about these allegations and scandals. However, we have been unable to reach anyone yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Italic: "Turn off the TV."*)
  - -> `[113]` (*Player_Italic: "Flip the table."*)
  - -> `[114]` (*Player_Italic: "Throw the remote at the TV."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "Turn off the TV."]** — Mówca: **Player_Italic**
> "I turned off the TV."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I buried my face in my hands."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "Flip the table."]** — Mówca: **Player_Italic**
> "I flipped the table in anger and everything on it fell on the ground."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I buried my face in my hands."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "Throw the remote at the TV."]** — Mówca: **Player_Italic**
> "I threw the remote at the TV, causing a large crack to appear at the centre."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I buried my face in my hands."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "I buried my face in my hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews =..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "I woke up early in the morning, as usual. I put on my clothes and went downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I made a cup of finely ground Sordish coffee and a slice ..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "I made a cup of finely ground Sordish coffee and a slice of buttered toast and sat down in front of the TV to watch the morning news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRingPickUp");"*)

### Węzeł `[118]`
Mówca: **Narrator**
> "The phone rang. I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "As I was expecting, the phone rang. I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[120]`
Mówca: **Lucian Galade**
> "“Mr. President. Have you seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“Yes. Along with everyone else in the entire northern hem..."*)
  - -> `[138]` (*Player: "“Tell it to me straight. How bad is it?”"*)
  - -> `[139]` (*Player: "“I wish I hadn't.”"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "The operator said that it was Albin Clavin on the line."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[124]`
Mówca: **Petr Vectern**
> "“Anton. Have you seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“Yes. Along with everyone else in the entire northern hem..."*)
  - -> `[138]` (*Player: "“Tell it to me straight. How bad is it?”"*)
  - -> `[139]` (*Player: "“I wish I hadn't.”"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The operator said that it was Lucian Galade on the line."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "The operator said that it was Petr Vectern on the line."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "The operator said that it was Gloria Tory on the line."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[131]`
Mówca: **Gloria Tory**
> "“Mr. President. Have you seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“Yes. Along with everyone else in the entire northern hem..."*)
  - -> `[138]` (*Player: "“Tell it to me straight. How bad is it?”"*)
  - -> `[139]` (*Player: "“I wish I hadn't.”"*)

### Węzeł `[132]`
Mówca: **Albin Clavin**
> "“Mr. President. Have you seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“Yes. Along with everyone else in the entire northern hem..."*)
  - -> `[138]` (*Player: "“Tell it to me straight. How bad is it?”"*)
  - -> `[139]` (*Player: "“I wish I hadn't.”"*)

### Węzeł `[133]`
Mówca: **Narrator**
> "The operator said that it was Albin Clavin on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Albin Clavin: "“Mr. President. Have you seen the news?”"*)

### Węzeł `[134]`
Mówca: **Narrator**
> "The operator said that it was Gloria Tory on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gloria Tory: "“Mr. President. Have you seen the news?”"*)

### Węzeł `[135]`
Mówca: **Narrator**
> "The operator said that it was Lucian Galade on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: "“Mr. President. Have you seen the news?”"*)

### Węzeł `[136]`
Mówca: **Narrator**
> "The operator said that it was Petr Vectern on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Petr Vectern: "“Anton. Have you seen the news?”"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Yes. Along with everyone else in the entire northern hemisphere.”"]** — Mówca: **Player**
> "“Yes. Along with everyone else in the entire northern hemisphere.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Lucian Galade), `[124]` (Petr Vectern), `[131]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "“Tell it to me straight. How bad is it?”"]** — Mówca: **Player**
> "“Tell it to me straight. How bad is it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Lucian Galade), `[124]` (Petr Vectern), `[131]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“I wish I hadn't.”"]** — Mówca: **Player**
> "“I wish I hadn't.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Lucian Galade), `[124]` (Petr Vectern), `[131]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[140]`
Mówca: **Albin Clavin**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "He took a deep breath."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Albin Clavin: "“To be frank...”"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: "“To be frank...”"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: "“To be frank...”"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Gloria Tory: "“To be frank...”"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[150]`
Mówca: **Gloria Tory**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "She took a deep breath."*)

### Węzeł `[151]`
Mówca: **Petr Vectern**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "He took a deep breath."*)

### Węzeł `[152]`
Mówca: **Lucian Galade**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He took a deep breath."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Albin Clavin: "“We might be screwed.”"*)

### Węzeł `[154]`
Mówca: **Narrator**
> "She took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Gloria Tory: "“We might be screwed.”"*)

### Węzeł `[155]`
Mówca: **Narrator**
> "He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lucian Galade: "“We might be screwed, sir.”"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Petr Vectern: "“We might be screwed.”"*)

### Węzeł `[157]`
Mówca: **Albin Clavin**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Albin Clavin: "“I just received word that they started the impeachment p..."*)

### Węzeł `[158]`
Mówca: **Gloria Tory**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Gloria Tory: "“I just received word that they started the impeachment p..."*)

### Węzeł `[159]`
Mówca: **Lucian Galade**
> "“We might be screwed, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lucian Galade: "“I just received word that they started the impeachment p..."*)

### Węzeł `[160]`
Mówca: **Petr Vectern**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Petr Vectern: "“I just received word that they started the impeachment p..."*)

### Węzeł `[161]`
Mówca: **Albin Clavin**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Albin Clavin: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[162]`
Mówca: **Gloria Tory**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gloria Tory: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[163]`
Mówca: **Lucian Galade**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lucian Galade: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[164]`
Mówca: **Petr Vectern**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Petr Vectern: "“You know I'm on your side, but... they've got a pretty g..."*)

### Węzeł `[165]`
Mówca: **Albin Clavin**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Albin Clavin: "“We need to stay optimistic. We may still have a chance.”"*)

### Węzeł `[166]`
Mówca: **Gloria Tory**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Gloria Tory: "“We need to stay optimistic. We may still have a chance.”"*)

### Węzeł `[167]`
Mówca: **Lucian Galade**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucian Galade: "“We need to stay optimistic. We may still have a chance.”"*)

### Węzeł `[168]`
Mówca: **Petr Vectern**
> "“You know I'm on your side, but... they've got a pretty good case against you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Petr Vectern: "“We need to stay optimistic. We may still have a chance.”"*)

### Węzeł `[169]`
Mówca: **Lucian Galade**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: "“But, for now, I will let you take it all in.”"*)

### Węzeł `[170]`
Mówca: **Albin Clavin**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Albin Clavin: "“But, for now, I will let you take it all in.”"*)

### Węzeł `[171]`
Mówca: **Gloria Tory**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Gloria Tory: "“But, for now, I will let you take it all in.”"*)

### Węzeł `[172]`
Mówca: **Petr Vectern**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Petr Vectern: "“For now, I guess I should give you a moment.”"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true || BaseGame.Sit..."*)

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucian Galade: "“Talk to you later.”"*)

### Węzeł `[175]`
Mówca: **Petr Vectern**
> "“For now, I guess I should give you a moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Petr Vectern: "“Hang in there, buddy.”"*)

### Węzeł `[176]`
Mówca: **Albin Clavin**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Albin Clavin: "“Talk to you later.”"*)

### Węzeł `[177]`
Mówca: **Gloria Tory**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Gloria Tory: "“Talk to you later.”"*)

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "The line dropped dead."*)

### Węzeł `[179]`
Mówca: **Petr Vectern**
> "“Hang in there, buddy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "The line dropped dead."*)

### Węzeł `[180]`
Mówca: **Albin Clavin**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "The line dropped dead."*)

### Węzeł `[181]`
Mówca: **Gloria Tory**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "The line dropped dead."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "The operator said that it was Petr Vectern on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Petr Vectern: "“Anton. Bad news.”"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "The operator said that it was Albin Clavin on the line."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[186]`
Mówca: **Albin Clavin**
> "“Mr. President. Sorry for calling you directly, but this is important.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Albin Clavin: "“I just received word that they started the impeachment p..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "The operator said that it was Gloria Tory on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Gloria Tory: "“Mr. President. Sorry for calling you directly, but this ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "The operator said that it was Lucian Galade on the line."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "The operator said that it was Petr Vectern on the line."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "The operator said that it was Gloria Tory on the line."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[194]`
Mówca: **Gloria Tory**
> "“Mr. President. Sorry for calling you directly, but this is important.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Gloria Tory: "“I just received word that they started the impeachment p..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "The operator said that it was Albin Clavin on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Albin Clavin: "“Mr. President. Sorry for calling you directly, but this ..."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "The operator said that it was Lucian Galade on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: "“Mr. President. Sorry for calling you directly, but this ..."*)

### Węzeł `[197]`
Mówca: **Lucian Galade**
> "“Mr. President. Sorry for calling you directly, but this is important.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lucian Galade: "“I just received word that they started the impeachment p..."*)

### Węzeł `[198]`
Mówca: **Petr Vectern**
> "“Anton. Bad news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Petr Vectern: "“I just received word that they started the impeachment p..."*)

### Węzeł `[199]`
Mówca: **Albin Clavin**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: "“An impeachment? For what?”"*)
  - -> `[204]` (*Player: "“What happened? Speak.”"*)
  - -> `[205]` (*Player: "“What the hell is going on?”"*)

### Węzeł `[200]`
Mówca: **Gloria Tory**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: "“An impeachment? For what?”"*)
  - -> `[204]` (*Player: "“What happened? Speak.”"*)
  - -> `[205]` (*Player: "“What the hell is going on?”"*)

### Węzeł `[201]`
Mówca: **Lucian Galade**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: "“An impeachment? For what?”"*)
  - -> `[204]` (*Player: "“What happened? Speak.”"*)
  - -> `[205]` (*Player: "“What the hell is going on?”"*)

### Węzeł `[202]`
Mówca: **Petr Vectern**
> "“I just received word that they started the impeachment process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: "“An impeachment? For what?”"*)
  - -> `[204]` (*Player: "“What happened? Speak.”"*)
  - -> `[205]` (*Player: "“What the hell is going on?”"*)

### Węzeł `[203]`
**[WYBÓR GRACZA: "“An impeachment? For what?”"]** — Mówca: **Player**
> "“An impeachment? For what?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Albin Clavin), `[200]` (Gloria Tory), `[201]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[204]`
**[WYBÓR GRACZA: "“What happened? Speak.”"]** — Mówca: **Player**
> "“What happened? Speak.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Albin Clavin), `[200]` (Gloria Tory), `[201]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "“What the hell is going on?”"]** — Mówca: **Player**
> "“What the hell is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Albin Clavin), `[200]` (Gloria Tory), `[201]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[206]`
Mówca: **Narrator**
> "She took a deep breath in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Gloria Tory: "“We might be screwed.”"*)

### Węzeł `[207]`
Mówca: **Albin Clavin**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "He took a deep breath in."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Albin Clavin: "“To be frank...”"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: "“To be frank...”"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Petr Vectern: "“To be frank...”"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Gloria Tory: "“To be frank...”"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[217]`
Mówca: **Gloria Tory**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "She took a deep breath in."*)

### Węzeł `[218]`
Mówca: **Petr Vectern**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "He took a deep breath in."*)

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“To be frank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "He took a deep breath in."*)

### Węzeł `[220]`
Mówca: **Petr Vectern**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Petr Vectern: "“We're talking about a major scandal.”"*)

### Węzeł `[221]`
Mówca: **Narrator**
> "He took a deep breath in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Petr Vectern: "“We might be screwed.”"*)

### Węzeł `[222]`
Mówca: **Albin Clavin**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Albin Clavin: "“They are citing a major scandal.”"*)

### Węzeł `[223]`
Mówca: **Lucian Galade**
> "“We might be screwed, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Lucian Galade: "“They are citing a major scandal.”"*)

### Węzeł `[224]`
Mówca: **Gloria Tory**
> "“We might be screwed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Gloria Tory: "“They are citing a major scandal.”"*)

### Węzeł `[225]`
Mówca: **Narrator**
> "He took a deep breath in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Albin Clavin: "“We might be screwed.”"*)

### Węzeł `[226]`
Mówca: **Narrator**
> "He took a deep breath in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lucian Galade: "“We might be screwed, sir.”"*)

### Węzeł `[227]`
Mówca: **Albin Clavin**
> "“They are citing a major scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Albin Clavin: "“I received a report and took notes. Here is what it says.”"*)

### Węzeł `[228]`
Mówca: **Gloria Tory**
> "“They are citing a major scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Gloria Tory: "“I received a report and took notes. Here is what it says.”"*)

### Węzeł `[229]`
Mówca: **Petr Vectern**
> "“We're talking about a major scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Petr Vectern: "“I took notes from their report. Here is what it says.”"*)

### Węzeł `[230]`
Mówca: **Lucian Galade**
> "“They are citing a major scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Lucian Galade: "“I received a report and took notes. Here is what it says.”"*)

### Węzeł `[231]`
Mówca: **Albin Clavin**
> "“I received a report and took notes. Here is what it says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)

### Węzeł `[232]`
Mówca: **Gloria Tory**
> "“I received a report and took notes. Here is what it says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)

### Węzeł `[233]`
Mówca: **Petr Vectern**
> "“I took notes from their report. Here is what it says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)

### Węzeł `[234]`
Mówca: **Lucian Galade**
> "“I received a report and took notes. Here is what it says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)

### Węzeł `[235]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Albin Clavin with a check while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Albin Clavin: ""President Rayne bribed Albin Clavin with a check while t..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[239]`
Mówca: **Albin Clavin**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseG..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == t..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Albin Clavin: ""President Rayne bribed Albin Clavin with the Vice Presid..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoront..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Albin Clavin: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Albin Clavin: ""President Rayne orchestrated the detainment of ex-NFP le..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[249]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[250]`
Mówca: **Albin Clavin**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Albin Clavin: ""President Rayne abused his powers to send his son, Franc..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[254]`
Mówca: **Albin Clavin**
> ""President Rayne abused his powers to send his son, Franc Rayne to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[255]`
Mówca: **Albin Clavin**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 1)"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Albin Clavin: ""The list goes on and on.""*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseG..."*)

### Węzeł `[259]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the detainment of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Albin Clavin: ""President Rayne bribed Frens Ricter with a check while t..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[263]`
Mówca: **Albin Clavin**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[264]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the detainment of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[265]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Frens Ricter with a check while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Albin Clavin: ""President Rayne orchestrated the detainment of ex-PFJP l..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Albin Clavin: ""President Rayne bribed Frens Ricter with the promise to ..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[272]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Albin Clavin: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[276]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[277]`
Mówca: **Albin Clavin**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Albin Clavin: ""President Rayne was involved in collusion along with Gus..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[281]`
Mówca: **Albin Clavin**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Albin Clavin: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == ..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Albin Clavin: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Albin Clavin: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Albin Clavin: ""President Rayne bribed Heron Garaci during the constitut..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[294]`
Mówca: **Albin Clavin**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[295]`
Mówca: **Albin Clavin**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[296]`
Mówca: **Albin Clavin**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk =..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Albin Clavin: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Albin Clavin: ""President Rayne has been secretly funding the Red Youth ..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[303]`
Mówca: **Albin Clavin**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == t..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Albin Clavin: ""President Rayne orchestrated the death of ex-PFJP leader..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[307]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigatio..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Albin Clavin: ""President Rayne was involved in an obstruction of justic..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Albin Clavin: ""President Rayne has been secretly funding the Young Sord..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[314]`
Mówca: **Albin Clavin**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[315]`
Mówca: **Albin Clavin**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[316]`
Mówca: **Albin Clavin**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[317]`
Mówca: **Albin Clavin**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, they struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Albin Clavin: ""President Rayne has been in cahoots with the media mogul..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener ==..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Albin Clavin: ""President Rayne orchestrated the death of ex-NFP leader ..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Albin Clavin: ""President Rayne orchestrated the death of the ex-Chief J..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[327]`
Mówca: **Lucian Galade**
> ""President Rayne has bribed Albin Clavin with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Lucian Galade: ""President Rayne has bribed Albin Clavin with a cheque wh..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[331]`
Mówca: **Lucian Galade**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Lucian Galade: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == t..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Lucian Galade: ""President Rayne has bribed Albin Clavin with the Vice Pr..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoront..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Lucian Galade: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Lucian Galade: ""President Rayne orchestrated the detainment of ex-NFP le..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[341]`
Mówca: **Lucian Galade**
> ""President Rayne has bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[342]`
Mówca: **Lucian Galade**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true)"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Lucian Galade: ""President Rayne abused his powers to send his son, Franc..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[346]`
Mówca: **Lucian Galade**
> ""President Rayne abused his powers to send his son, Franc Rayne to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[347]`
Mówca: **Lucian Galade**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 1)"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Lucian Galade: ""The list goes on and on.""*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Lucian Galade: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[351]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the detainment of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Lucian Galade: ""President Rayne has bribed Frens Ricter with a cheque wh..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[355]`
Mówca: **Lucian Galade**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[356]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the detainment of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[357]`
Mówca: **Lucian Galade**
> ""President Rayne has bribed Frens Ricter with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lucian Galade: ""President Rayne orchestrated the detainment of ex-PFJP l..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Lucian Galade: ""President Rayne has bribed Frens Ricter with the promise..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[364]`
Mówca: **Lucian Galade**
> ""President Rayne has bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Lucian Galade: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[368]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[369]`
Mówca: **Lucian Galade**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lucian Galade: ""President Rayne was involved in collusion along with Gus..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[373]`
Mówca: **Lucian Galade**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Lucian Galade: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == ..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Lucian Galade: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Lucian Galade: ""President Rayne bribed Heron Garaci during the constitut..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[386]`
Mówca: **Lucian Galade**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[387]`
Mówca: **Lucian Galade**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[388]`
Mówca: **Lucian Galade**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk =..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Lucian Galade: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Lucian Galade: ""President Rayne has been secretly funding the Red Youth ..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[395]`
Mówca: **Lucian Galade**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == t..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Lucian Galade: ""President Rayne orchestrated the death of ex-PFJP leader..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[399]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigatio..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Lucian Galade: ""President Rayne was involved in an obstruction of justic..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Lucian Galade: ""President Rayne has been secretly funding the Young Sord..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[406]`
Mówca: **Lucian Galade**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[407]`
Mówca: **Lucian Galade**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[408]`
Mówca: **Lucian Galade**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[409]`
Mówca: **Lucian Galade**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, they struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lucian Galade: ""President Rayne has been in cahoots with the media mogul..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener ==..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""President Rayne orchestrated the death of ex-NFP leader ..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Lucian Galade: ""President Rayne orchestrated the death of the ex-Chief J..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[419]`
Mówca: **Petr Vectern**
> ""President Rayne has bribed Albin Clavin with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Petr Vectern: ""President Rayne has bribed Albin Clavin with a cheque wh..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[423]`
Mówca: **Petr Vectern**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Petr Vectern: "“I'm still on your side, of course. But they've built up ..."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == t..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Petr Vectern: ""President Rayne has bribed Albin Clavin with the Vice Pr..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoront..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Petr Vectern: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Petr Vectern: ""President Rayne orchestrated the detainment of ex-NFP le..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[433]`
Mówca: **Petr Vectern**
> ""President Rayne has bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[434]`
Mówca: **Petr Vectern**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true)"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Petr Vectern: ""President Rayne abused his powers to send his son, Franc..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[438]`
Mówca: **Petr Vectern**
> ""President Rayne abused his powers to send his son, Franc Rayne to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[439]`
Mówca: **Petr Vectern**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 1)"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Petr Vectern: ""The list goes on and on.""*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Petr Vectern: "“I'm still on your side, of course. But they've built up ..."*)

### Węzeł `[443]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the detainment of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Petr Vectern: ""President Rayne has bribed Frens Ricter with a cheque wh..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[447]`
Mówca: **Petr Vectern**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[448]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the detainment of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[449]`
Mówca: **Petr Vectern**
> ""President Rayne has bribed Frens Ricter with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Petr Vectern: ""President Rayne orchestrated the detainment of ex-PFJP l..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Petr Vectern: ""President Rayne has bribed Frens Ricter with the promise..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[456]`
Mówca: **Petr Vectern**
> ""President Rayne has bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Petr Vectern: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[460]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[461]`
Mówca: **Petr Vectern**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Petr Vectern: ""President Rayne was involved in collusion along with Gus..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[465]`
Mówca: **Petr Vectern**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Petr Vectern: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == ..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Petr Vectern: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Petr Vectern: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Petr Vectern: ""President Rayne bribed Heron Garaci during the constitut..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[478]`
Mówca: **Petr Vectern**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[479]`
Mówca: **Petr Vectern**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[480]`
Mówca: **Petr Vectern**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk =..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Petr Vectern: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)"*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Petr Vectern: ""President Rayne has been secretly funding the Red Youth ..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[487]`
Mówca: **Petr Vectern**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == t..."*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Petr Vectern: ""President Rayne orchestrated the death of ex-PFJP leader..."*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[491]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigatio..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Petr Vectern: ""President Rayne was involved in an obstruction of justic..."*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Petr Vectern: ""President Rayne has been secretly funding the Young Sord..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[498]`
Mówca: **Petr Vectern**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[499]`
Mówca: **Petr Vectern**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[500]`
Mówca: **Petr Vectern**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[501]`
Mówca: **Petr Vectern**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, they struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)"*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Petr Vectern: ""President Rayne has been in cahoots with the media mogul..."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener ==..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Petr Vectern: ""President Rayne orchestrated the death of ex-NFP leader ..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Petr Vectern: ""President Rayne orchestrated the death of the ex-Chief J..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[511]`
Mówca: **Gloria Tory**
> ""The list goes on and on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Gloria Tory: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Gloria Tory: ""President Rayne orchestrated the detainment of ex-NFP le..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[515]`
Mówca: **Gloria Tory**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 1)"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Gloria Tory: ""The list goes on and on.""*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Gloria Tory: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[519]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the detainment of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[520]`
Mówca: **Gloria Tory**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to select Underhall Construction as the contractor for his first megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[521]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the detainment of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Gloria Tory: ""President Rayne orchestrated the detainment of ex-PFJP l..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)"*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Gloria Tory: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[528]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the death of ex-PFJP leader Frens Ricter using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[529]`
Mówca: **Gloria Tory**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to cut taxes for large corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == ..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Gloria Tory: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Gloria Tory: ""President Rayne accepted a bribe from Walter Tusk as par..."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[536]`
Mówca: **Gloria Tory**
> ""President Rayne accepted a bribe from Walter Tusk as part of his decision to bail out businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk =..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Gloria Tory: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == t..."*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Gloria Tory: ""President Rayne orchestrated the death of ex-PFJP leader..."*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[543]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the death of ex-NFP leader Kesaro Kibener using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[544]`
Mówca: **Gloria Tory**
> ""President Rayne orchestrated the death of the ex-Chief Justice of the Supreme Court, Orso Hawker, using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[545]`
Mówca: **Gloria Tory**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener ==..."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Gloria Tory: ""President Rayne orchestrated the death of ex-NFP leader ..."*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Gloria Tory: ""President Rayne orchestrated the death of the ex-Chief J..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[552]`
Mówca: **Gloria Tory**
> ""President Rayne abused his powers to send his son, Franc Rayne to Holsord State University.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Gloria Tory: ""President Rayne has been secretly funding the Red Youth ..."*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Gloria Tory: ""President Rayne has bribed Albin Clavin with a cheque wh..."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[559]`
Mówca: **Gloria Tory**
> ""President Rayne has been secretly funding the Red Youth behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)

### Węzeł `[560]`
Mówca: **Gloria Tory**
> ""As part of the privatization process, President Rayne sold shares in a backroom deal to both Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[561]`
Mówca: **Gloria Tory**
> ""President Rayne bribed Heron Garaci during the constitutional change process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[562]`
Mówca: **Gloria Tory**
> ""President Rayne has bribed Albin Clavin with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoront..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Gloria Tory: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)"*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HeronGaraci_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Gloria Tory: ""President Rayne bribed Heron Garaci during the constitut..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HeronGaraci_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HeronGaraci_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == t..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Gloria Tory: ""President Rayne has bribed Albin Clavin with the Vice Pr..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)"*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Gloria Tory: ""President Rayne has been in cahoots with the media mogul..."*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[575]`
Mówca: **Gloria Tory**
> ""President Rayne has been in cahoots with the media mogul Marcel Koronti. At Mr. Koronti's country club in Conriat, they struck a deal in which Mr. Koronti agreed to sway the media in favour of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[576]`
Mówca: **Gloria Tory**
> ""President Rayne was involved in an obstruction of justice incident. He tipped off Marcel Koronti about the investigation that was about to be opened into his corporation's ties to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_YoungSords == true"*)
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)"*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Gloria Tory: ""President Rayne has been secretly funding the Young Sord..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigatio..."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Gloria Tory: ""President Rayne was involved in an obstruction of justic..."*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[583]`
Mówca: **Gloria Tory**
> ""President Rayne has been secretly funding the Young Sords behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[584]`
Mówca: **Gloria Tory**
> ""President Rayne has bribed Albin Clavin with the Vice Presidency position while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[585]`
Mówca: **Gloria Tory**
> ""President Rayne was involved in collusion along with Gus Manger. Both of them own shares in Underhall Construction, which was subsequently contracted for a megaproject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true)"*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Gloria Tory: ""President Rayne abused his powers to send his son, Franc..."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)"*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Gloria Tory: ""President Rayne has bribed Frens Ricter with a cheque wh..."*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)"*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Gloria Tory: ""As part of the privatization process, President Rayne so..."*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[595]`
Mówca: **Gloria Tory**
> ""President Rayne has bribed Frens Ricter with the promise to pick Taurus Holding as the main contractor for his first infrastructure project in his term. Frens Ricter was a major stakeholder at the time of this bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Gloria Tory: ""President Rayne was involved in collusion along with Gus..."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HeronGaraci_Bribe == true"*)

### Węzeł `[599]`
Mówca: **Gloria Tory**
> ""President Rayne has bribed Frens Ricter with a cheque while the reform committee was in session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)"*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Gloria Tory: ""President Rayne has bribed Frens Ricter with the promise..."*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[603]`
Mówca: **Albin Clavin**
> ""They know about our goddamn deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Albin Clavin: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseG..."*)
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Bas..."*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Albin Clavin: ""They know about our goddamn deal.""*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Albin Clavin: "“We will defend ourselves and present the best case possi..."*)

### Węzeł `[607]`
Mówca: **Albin Clavin**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Albin Clavin: "“We need to stay optimistic. We may still have a chance.”"*)

### Węzeł `[608]`
Mówca: **Gloria Tory**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Gloria Tory: "“Talk to you later.”"*)

### Węzeł `[609]`
Mówca: **Gloria Tory**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Gloria Tory: "“We need to stay optimistic. We may still have a chance.”"*)

### Węzeł `[610]`
Mówca: **Lucian Galade**
> "“We will defend ourselves and present the best case possible of course, but, it will be hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Lucian Galade: "“We need to stay optimistic. We may still have a chance.”"*)

### Węzeł `[611]`
Mówca: **Lucian Galade**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Lucian Galade: "“But, for now, I will let you take it all in.”"*)

### Węzeł `[612]`
Mówca: **Albin Clavin**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Albin Clavin: "“But, for now, I will let you take it all in.”"*)

### Węzeł `[613]`
Mówca: **Gloria Tory**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Gloria Tory: "“But, for now, I will let you take it all in.”"*)

### Węzeł `[614]`
Mówca: **Petr Vectern**
> "“But, for now, I'll give you a moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Petr Vectern: "“Hang in there, buddy.""*)

### Węzeł `[615]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_AntiCorruptionPolice == true"*)

### Węzeł `[616]`
Mówca: **Lucian Galade**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Lucian Galade: "“Talk to you later.”"*)

### Węzeł `[617]`
Mówca: **Albin Clavin**
> "“But, for now, I will let you take it all in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Albin Clavin: "“Talk to you later.”"*)

### Węzeł `[618]`
Mówca: **Petr Vectern**
> "“We need to stay optimistic. We may still have a chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Petr Vectern: "“But, for now, I'll give you a moment.”"*)

### Węzeł `[619]`
Mówca: **Gloria Tory**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Narrator: "The line dropped dead."*)

### Węzeł `[620]`
Mówca: **Petr Vectern**
> "“I'm still on your side, of course. But they've built up a pretty solid case against you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Petr Vectern: "“We need to stay optimistic. We may still have a chance.”"*)

### Węzeł `[621]`
Mówca: **Petr Vectern**
> "“Hang in there, buddy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Narrator: "The line dropped dead."*)

### Węzeł `[622]`
Mówca: **Albin Clavin**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Narrator: "The line dropped dead."*)

### Węzeł `[623]`
Mówca: **Lucian Galade**
> "“Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Narrator: "The line dropped dead."*)

### Węzeł `[624]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_A_LeakedScandal = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_A_LeakedScandal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[625]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == t..."*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Reporter: ""President Rayne ordered the Secret State Police to detai..."*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[628]`
Mówca: **Reporter**
> ""President Rayne ordered the Secret State Police to detain Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)"*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Reporter: ""President Rayne ordered the Secret State Police to kill ..."*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[632]`
Mówca: **Reporter**
> ""President Rayne ordered the Secret State Police to kill Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == t..."*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Reporter: ""President Rayne ordered the assassination of Vice Presid..."*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[636]`
Mówca: **Reporter**
> ""President Rayne ordered the detainment of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Reporter: ""Yes. You heard that right.""*)

### Węzeł `[637]`
Mówca: **Reporter**
> ""President Rayne ordered the assassination of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Reporter: ""Yes. You heard that right.""*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern ==..."*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Reporter: ""President Rayne ordered the detainment of Vice President..."*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[641]`
Mówca: **Reporter**
> ""Yes. You heard that right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[642]`
Mówca: **Reporter**
> ""Yes. You heard that right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[643]`
Mówca: **Albin Clavin**
> ""President Rayne ordered the Secret State Police to detain Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[644]`
Mówca: **Albin Clavin**
> ""Yes. You heard that right. Ridiculous accusations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)

### Węzeł `[645]`
Mówca: **Albin Clavin**
> ""President Rayne ordered the Secret State Police to kill Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[646]`
Mówca: **Albin Clavin**
> ""President Rayne ordered the detainment of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Albin Clavin: ""Yes. You heard that right. Ridiculous accusations.""*)

### Węzeł `[647]`
Mówca: **Albin Clavin**
> ""Yes. You heard that right. Ridiculous accusations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == t..."*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Albin Clavin: ""President Rayne ordered the Secret State Police to detai..."*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)"*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Albin Clavin: ""President Rayne ordered the Secret State Police to kill ..."*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[654]`
Mówca: **Albin Clavin**
> ""President Rayne ordered the assassination of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Albin Clavin: ""Yes. You heard that right. Ridiculous accusations.""*)

### Węzeł `[655]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern ==..."*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Albin Clavin: ""President Rayne ordered the detainment of Vice President..."*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[658]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == t..."*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Albin Clavin: ""President Rayne ordered the assassination of Vice Presid..."*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)

### Węzeł `[661]`
Mówca: **Gloria Tory**
> ""President Rayne ordered the Secret State Police to detain Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[662]`
Mówca: **Gloria Tory**
> ""President Rayne ordered the Secret State Police to kill Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[663]`
Mówca: **Gloria Tory**
> ""President Rayne ordered the detainment of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Gloria Tory: ""Yes. You heard that right. Ridiculous accusations.""*)

### Węzeł `[664]`
Mówca: **Gloria Tory**
> ""Yes. You heard that right. Ridiculous accusations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == t..."*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Gloria Tory: ""President Rayne ordered the Secret State Police to detai..."*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)"*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Gloria Tory: ""President Rayne ordered the Secret State Police to kill ..."*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern ==..."*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Gloria Tory: ""President Rayne ordered the detainment of Vice President..."*)

### Węzeł `[673]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == t..."*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Gloria Tory: ""President Rayne ordered the assassination of Vice Presid..."*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)

### Węzeł `[677]`
Mówca: **Gloria Tory**
> ""Yes. You heard that right. Ridiculous accusations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)

### Węzeł `[678]`
Mówca: **Gloria Tory**
> ""President Rayne ordered the assassination of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Gloria Tory: ""Yes. You heard that right. Ridiculous accusations.""*)

### Węzeł `[679]`
Mówca: **Lucian Galade**
> ""President Rayne ordered the Secret State Police to detain Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[680]`
Mówca: **Lucian Galade**
> ""President Rayne ordered the Secret State Police to kill Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[681]`
Mówca: **Lucian Galade**
> ""President Rayne ordered the detainment of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == t..."*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Lucian Galade: ""President Rayne ordered the Secret State Police to detai..."*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)"*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Lucian Galade: ""President Rayne ordered the Secret State Police to kill ..."*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern ==..."*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Lucian Galade: ""President Rayne ordered the detainment of Vice President..."*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == t..."*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Lucian Galade: ""President Rayne ordered the assassination of Vice Presid..."*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)

### Węzeł `[694]`
Mówca: **Lucian Galade**
> ""President Rayne ordered the assassination of Vice President Petr Vectern using the Secret State Police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)

### Węzeł `[695]`
Mówca: **Petr Vectern**
> ""President Rayne ordered the Secret State Police to detain Livia Suno -- that can't be true, can it? You told me she quit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Petr Vectern: ""God damn this shit.""*)

### Węzeł `[696]`
Mówca: **Petr Vectern**
> ""President Rayne ordered the Secret State Police to kill Livia Suno -- that can't be true, can it? You told me she quit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Petr Vectern: ""God damn this shit.""*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == t..."*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Petr Vectern: ""President Rayne ordered the Secret State Police to detai..."*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)"*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Petr Vectern: ""President Rayne ordered the Secret State Police to kill ..."*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)

### Węzeł `[703]`
Mówca: **Petr Vectern**
> ""God damn this shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[704]`
Mówca: **Petr Vectern**
> ""God damn this shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 1"*)

### Węzeł `[705]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_AntiCorruptionPolice == true"*)
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_AntiCorruptionPolice == true)"*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "!(BaseGameSupport.Codex_Organisations_Governmental_ACP_In..."*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "!(BaseGameSupport.Codex_Organisations_Governmental_ACP_In..."*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "!(BaseGameSupport.Codex_Organisations_Governmental_ACP_In..."*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "!(BaseGameSupport.Codex_Organisations_Governmental_ACP_In..."*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_ACP_Inve..."*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone_Impeached = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone_Impeached"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators_Impeached = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators_Impeached"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs_Impeached = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOligarchs_Impeached"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP_Impeached = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOppositionParties_NFP_Impeached"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_LeakedScandal = true"*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Removed == true"*)
  - -> `[727]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Impeachment_Removed == true)"*)

### Węzeł `[726]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Reporter: ""We have confirmation about the certainty of these leaks...."*)

### Węzeł `[727]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Reporter: ""We have confirmation about the certainty of these leaks...."*)

### Węzeł `[728]`
Mówca: **Reporter**
> ""We have confirmation about the certainty of these leaks. This is nothing short of a major scandal that could cause a massive drop in popularity for President Rayne in the upcoming elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I froze and dropped the toast I was about to bite into."*)

### Węzeł `[729]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == tru..."*)
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == t..."*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_SSP_Leak..."*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_SSP_Leak..."*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment_HandledScandal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_NoImpeachment_HandledScandal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Scandals_RayneImpeachment = true;
BaseGameSupport.News_Turn09_E_Scandals_PresidentEmbarrassed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Scandals_RayneImpeachment"] = true;
Variable["BaseGameSupport.News_Turn09_E_Scandals_PresidentEmbarrassed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_LT_Scandals_RayneLies = true"*)

### Węzeł `[735]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[736]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Scandals_RayneImpeachment ..."*)

### Węzeł `[737]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_LT_Scandals_RayneLies = true"*)

### Węzeł `[738]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment_HandledScandal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment_HandledScandal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_LT_Scandals_RayneLies = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_LT_Scandals_RayneLies"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_AntiCorruptionPolice == true"*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true || BaseGame.Sit..."*)
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true || BaseGame.S..."*)

### Węzeł `[741]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Scandals_RayneBoughtMedia ..."*)

### Węzeł `[742]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaBias == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_ST_Scandals_RayneCorruption =..."*)

### Węzeł `[743]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillFrensRicter == true ||
BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true ||
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[748]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[747]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == tru..."*)

### Węzeł `[748]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == tru..."*)

### Węzeł `[749]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_ST_Scandals_RayneCorruption = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_ST_Scandals_RayneCorruption"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == tru..."*)
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == t..."*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_SSP_Leak..."*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || 
BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true ||
BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  
Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or 
Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_SSP_Leak..."*)

### Węzeł `[753]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Scandals_RayneBoughtMedia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Scandals_RayneBoughtMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_LeakedScandal = true"*)

### Węzeł `[755]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SSP_Leaked_Impeachment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[756]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[757]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews =..."*)
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews..."*)

### Węzeł `[758]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRingPickUp");"*)

### Węzeł `[759]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_LeakedScandal_HeardReporterNews"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "I woke up early in the morning, as usual. I put on my clo..."*)

### Węzeł `[760]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhoneRingPickUp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "The phone rang. I picked it up."*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhoneRingPickUp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "As I was expecting, the phone rang. I picked it up."*)

### Węzeł `[762]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[763]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
