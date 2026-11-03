# Rizia/Turn 8/P_NightBeforeWedding

- **ID konwersacji:** `414`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/414_P_NightBeforeWedding.md`
- **Liczba węzłów dialogowych:** 895
- **Liczba wyborów gracza:** 189

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Decision_Turn08_WeddingCommittee`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_WearsLenasRing`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Economy_LandOwnersTax`
- `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed`
- `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn03_LucitaLoveConvo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateSal`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FullCouncilor`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_KeepsLastName`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_WearsLenasRing`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_OKWithVinaSuccessor`
- `RiziaDLC.Lucita_WearsLenasRing`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.Pabel_WeddingDate`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_WearsLenasRing`
- `RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling`
- `RiziaDLCIsolated.Turn08_LucitaProposal_Sitting`
- `RiziaDLCIsolated.Turn08_LucitaProposal_Standing`
- `RiziaDLCSupport.Journal_Turn08_Lucita_Married`
- `RiziaDLCSupport.Journal_Turn08_Pabel_Lord`
- `RiziaDLCSupport.Journal_Turn08_Pabel_WeddingDate`
- `RiziaDLCSupport.News_Turn08_RH_RoyalWedding_VinaDuchess`
- `RiziaDLCSupport.News_Turn08_V_VinaEscape_Regular`
- `RiziaDLCSupport.Reports_Turn08_MaveNortus_IntelligenceServiceSearchesVina`
- `RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_Protests`
- `RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_TorasCelebrates`

### Skoki między-konwersacyjne:
- Węzeł `[25]` -> **[415] Rizia/Turn 8/VINA ESCAPES** (../Turn_08/415_VINA_ESCAPES.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 20
- **Węzły modyfikujące stan gry:** 27

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel_Together`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[102]` (Paskal Beniwoll): `RemoveConversant("Lucita Azaro");`
- Węzeł `[109]` (Paskal Beniwoll): `RemoveConversant("Titus Gordion");`
- Węzeł `[132]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Sitting"] = true;`
- Węzeł `[133]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Standing"] = true;`
- Węzeł `[134]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling"] = true;`
- Węzeł `[246]` (Paskal Beniwoll): `End();`
- Węzeł `[318]` (Paskal Beniwoll): `DisableCollectionItem("CollectionItem_WeddingRing"); Variable["RiziaDLC.Lucita_WearsLenasRing"] =...`
- Węzeł `[467]` (Paskal Beniwoll): `Variable["RiziaDLC.Lucita_Married"] = true; Variable["RiziaDLCSupport.Journal_Turn08_Lucita_Marri...`
- *...oraz 19 innych węzłów ze skryptami.*

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
  - -> `[747]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We strolled further into the gardens. It was a balmy night, and the moon was just beginning to rise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Under cover of darkness, Lucita slipped her hand into mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[8]`
Mówca: **Lucita Azaro**
> ""I can't believe Her Highness is getting married tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Lucita Azaro**
> ""I was skeptical at first, but your daughter has really come into her own as a councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Lucita Azaro**
> ""I still remember attending the celebrations when she was born. Her mother looked so gorgeous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[11]`
  - -> `[13]`
  - -> `[17]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe me, Princess Lena of Rumburg couldn't hold a candle to Duchess Lucita of Montaklar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still miss her. But I have to move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Poor Lena. She never got to see her daughter become a woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And me? How did I look?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""Like a handsome prince.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""She lives on in Her Highness. And in her progeny, whoever they may be...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Lucita snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> ""The blossoming flower versus the bird of prey? I know what they all say about me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""You're doing a fine job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "We had come to the clearing in the middle of the gardens. To our left was the stone bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `415` (*Rizia/Turn 8/VINA ESCAPES*), Węzeł `[1]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true) && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true) && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true) && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The air in the palace suddenly felt suffocating. I went out to the gardens to clear my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "I had just exited the palace when I bumped into Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""Oh! Hello, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[33]`
Mówca: **Lucita Azaro**
> ""I was conducting last-minute security drills in the Grand Hall. You really can't be too careful with these things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[215]`
  - -> `[218]`
  - -> `[220]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""I was just reviewing our latest battle plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[215]`
  - -> `[218]`
  - -> `[220]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""I was in the council chambers when I heard Titus' radio transmission. I can't believe the Golden Guard let this happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[47]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect she's trying to flee the country. Can our foreign intelligence services help find her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Lucita Azaro**
> ""Yes, of course. I'll tell them to be on the lookout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She had someone on the inside. A guard helping her out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[48]`
Mówca: **Lucita Azaro**
> ""That's very troubling. I'll ask my intelligence operatives to look into it at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel was in on it. He's vanished without a trace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think my mother might have helped her, but I have no proof.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> ""You should get some rest, Your Majesty. Trust in your security staff to handle the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It won't be easy to rest. But I'll try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I have to do something. I'll go crazy otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Wait. Take a walk with me." [Marriage Proposal]"]** — Mówca: **Player_Romus**
> ""Wait. Take a walk with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[53]`
  - -> `[52]`

### Węzeł `[58]`
Mówca: **Lucita Azaro**
> ""It will all be fine. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[59]`
Mówca: **Narrator**
> "She gave me a terse nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Duchess Azaro. I hope this all resolves quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""I have faith that it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[62]`
Mówca: **Narrator**
> "She paused, thinking it over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Lucita Azaro**
> ""All right. I'm sure you could use the distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Narrator**
> "We started walking together through the gardens. It was a balmy night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Eventually, we came to the spot in the center with the stone bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "Kneel."]** — Mówca: **Player_Romus_Italic**
> "I knelt on the ground, ignoring the twinge in my bad leg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "Stay standing."]** — Mówca: **Player_Romus_Italic**
> "I stayed standing and turned towards my councilor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you love me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you able to bear children?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "She pulled back and gave me a measured look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""I believe so. My monthly visitor continues to bless me with exasperating regularity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "Kneel."]** — Mówca: **Player_Romus_Italic**
> "I knelt on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "Sit down."]** — Mówca: **Player_Romus_Italic**
> "I motioned for Lucita to sit next to me on the bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Lucita's eyes widened. She looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`
  - -> `[72]`
  - -> `[71]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita, will you marry me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the presence of the heavens above and the earth below, I do extend unto thee an offer of marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Narrator**
> "She clapped a hand to her mouth. It was a second before she replied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""Is this because of your daughter's disappearance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need another heir, Lucita. Preferably a boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's incidental. I've loved you since the moment you entered my council chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With my command of the Rizian government and your command of the military, we will be unstoppable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't ask why. Just say yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[86]`
Mówca: **Lucita Azaro**
> ""That's the most cold-blooded thing I've ever heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[87]`
Mówca: **Narrator**
> "She reached up, grabbed the back of my head and pulled my face level with hers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I would like to request that you grant me the honor of your hand in marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then have *my* my children, Duchess Azaro. Be my wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[90]`
Mówca: **Lucita Azaro**
> ""Yes, King Romus. I will marry you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[91]`
Mówca: **Lucita Azaro**
> ""I've loved you since before we even met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[92]`
Mówca: **Lucita Azaro**
> ""Unstoppable. I like the sound of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[93]`
Mówca: **Lucita Azaro**
> ""In that case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Lucita Azaro**
> ""That's very troubling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""Good night, Your Majesty. I'll let you know at once if the Princess is found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Narrator**
> "She walked off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "I re-entered the palace, where I was greeted by Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Titus Gordion**
> ""Still no trace of her, Your Majesty. Your butler seems to have disappeared from the palace grounds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[105]`
  - -> `[107]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind that. I want to know about my mother's involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Titus Gordion**
> ""I'll find out what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Find them both. This is an embarrassment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Titus Gordion**
> ""As I said, I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's no use. She's gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""Don't give up yet. We'll bring Her Highness home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "He shadowed me as I walked upstairs and into my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Narrator**
> "Bruno was waiting for me by my valet stand, where a brand-new, crisp royal blue suit had been hung up. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[126]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Arranged on my valet stand was a brand-new, crisp royal blue suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[126]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Bruno was waiting for me by my valet stand, where my favorite suit had been hung up. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "Leave it there."]** — Mówca: **Player_Romus_Italic**
> "I left the outfit where it was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Pabel had hung up my favorite suit on the valet stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[125]`
Mówca: **Narrator**
> "There was a chance I would still get to wear it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "Throw it in the corner."]** — Mówca: **Player_Romus_Italic**
> "I crumpled it up and threw it in the corner of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Narrator**
> "I knew that I would never wear it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "Leave it hanging there."]** — Mówca: **Player_Romus_Italic**
> "I left the outfit where it was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Narrator**
> "There was a chance tomorrow could still be a normal day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "Throw it in the corner."]** — Mówca: **Player_Romus_Italic**
> "I crumpled it up and threw it in the corner of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Narrator**
> "I knew that I would never wear it again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_LucitaProposal_Sitting = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Sitting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_LucitaProposal_Standing = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Standing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[135]`
Mówca: **Narrator**
> "She pulled back from me slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""I told you long ago that falling in love was like heading into battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_LucitaLoveConvo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_LucitaLoveConvo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn03_LucitaLoveConvo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn03_LucitaLoveConvo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn03_LucitaLoveConvo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""Of course, that was before you and I found ourselves fighting an actual battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""I told myself long ago that I would never fall in love. Giving yourself to someone like that allows them to have absolute power over you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Lucita Azaro**
> ""And I refuse to subjugate myself to anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Narrator**
> "She smiled slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""Except for my king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[88]`
  - -> `[150]`
  - -> `[793]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""We've held our ground against Pales. But when it comes to the two of us... well, Your Majesty, I surrender.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[88]`
  - -> `[150]`
  - -> `[793]`

### Węzeł `[149]`
Mówca: **Lucita Azaro**
> ""Well, Your Majesty... I surrender.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[88]`
  - -> `[150]`
  - -> `[793]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know if you're lying. I don't care. Marry me, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Lucita Azaro**
> ""Is it unromantic of me to ask why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[84]`
  - -> `[85]`
  - -> `[155]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've loved you since the moment you entered my council chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Lucita Azaro**
> ""I've loved you since before we even met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[160]`
Mówca: **Narrator**
> "She reached down, grabbed the back of my head and pulled my face level with hers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[161]`
Mówca: **Narrator**
> "We kissed with such force that we nearly toppled to the ground. I wondered if any guards had eyes on us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""Wait. I have an idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Narrator**
> "She took my hand and pulled me towards the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Narrator**
> "Bruno was on my bed, lying atop a brand-new, crisp royal blue suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[180]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Atop my bed was a brand-new, crisp royal blue suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[180]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Bruno was on my bed, lying atop my favorite suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[173]`
**[WYBÓR GRACZA: "Hang it up."]** — Mówca: **Player_Romus_Italic**
> "I carefully hung it on the wall next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Atop my bed was my favorite suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "Throw it in the corner."]** — Mówca: **Player_Romus_Italic**
> "I crumpled it up and threw it in the corner of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Narrator**
> "I wondered what tomorrow would bring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[180]`
**[WYBÓR GRACZA: "Throw it in the corner."]** — Mówca: **Player_Romus_Italic**
> "I crumpled it up and threw it in the corner of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[181]`
**[WYBÓR GRACZA: "Hang it up."]** — Mówca: **Player_Romus_Italic**
> "I carefully hung it on the wall next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[182]`
Mówca: **Narrator**
> "In a daze, I slowly walked upstairs to my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[186]`
Mówca: **Narrator**
> "It was the night before Vina's wedding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[187]`
Mówca: **Narrator**
> "After a day spent finalizing arrangements, conducting interviews and meeting with visiting guests, I was exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[188]`
Mówca: **Narrator**
> "After a day spent finalizing arrangements, holding press conferences and reviewing security details, I was exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[189]`
Mówca: **Narrator**
> "After an endless day of war briefings and strategy planning sessions, I was looking forward to collapsing in my bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[193]`
Mówca: **Narrator**
> "It was late at night at Palas Rezna."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Narrator**
> "After an endless day of meetings, I was looking forward to collapsing in my bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[201]`
Mówca: **Narrator**
> "First, though, I decided to take a walk in the palace gardens to clear my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Narrator**
> "I had just stepped onto the grounds when I bumped into Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Lucita Azaro**
> ""Oh! Hello, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[204]`
Mówca: **Lucita Azaro**
> ""I was just reviewing the latest strategies for the Zille resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[215]`
  - -> `[218]`
  - -> `[220]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Lucita Azaro**
> ""I was just reviewing our latest plans for dealing with the unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[215]`
  - -> `[218]`
  - -> `[220]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Lucita Azaro**
> ""I was just reviewing the latest internal security reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[215]`
  - -> `[218]`
  - -> `[220]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at us. Addicted to our jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody told me that ruling the country would be all this work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like you're urgently in need of stress relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've got too much on your plate. Why not share the load with the Golden Guard?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[223]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""At least you've got your council to fall back on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""There's no clocking out when the kingdom's future is at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""Come on. Let's take a walk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[227]`
Mówca: **Narrator**
> "She made a scoffing sound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FullCouncilor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FullCouncilor == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FullCouncilor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FullCouncilor == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FullCouncilor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[231]`
Mówca: **Lucita Azaro**
> ""Vina Toras, Duchess of Valenqiris. The day has finally come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[235]`
Mówca: **Narrator**
> "It was the night before Vina's investiture ceremony as Duchess of Monqiz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[236]`
Mówca: **Narrator**
> "The moon had risen by now, illuminating Lucita's features. I thought about everything we'd been through together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_KeepsLastName == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_KeepsLastName == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_KeepsLastName"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_KeepsLastName == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PROPOSAL)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[241]`
Mówca: **Narrator**
> "I thought about her position as councilor. Her 'interim' status had lasted longer than expected, but it was nearly time for her father to return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[242]`
Mówca: **Narrator**
> "I thought about how, as of tomorrow, the heir to the throne of Rizia would not be a member of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[70]`
  - -> `[76]`

### Węzeł `[243]`
Mówca: **Narrator**
> "I thought how, if Vina died in Pales, I would be left without an heir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[70]`
  - -> `[76]`

### Węzeł `[244]`
Mówca: **Narrator**
> "My mother's words echoed in my head. "Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`
  - -> `[798]`
  - -> `[54]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [PROPOSAL])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[247]`
Mówca: **Narrator**
> "When we broke apart, she was grinning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[254]`
  - -> `[257]`
  - -> `[261]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`
  - -> `[265]`
  - -> `[270]`

### Węzeł `[251]`
Mówca: **Narrator**
> "She led me through the ground-floor corridors until we came to the entrance to Sal Ignacius' quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? You want to wake the old man up now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman? I still don't trust him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, a visit to my beloved spiritual advisor. Always a good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I see where this is going...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't get in. It's been locked since his arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The traitor's chambers? Why have you brought me here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I will not consummate our engagement in a holy man's bed, no matter how treasonous he turned out to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Consummating our engagement in a treasonous priest's bed? See, this is why I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Narrator**
> "She put a finger to her lips, then took a keychain from her pocket and silently unlocked the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You want to go snooping for more evidence against him? Good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[271]`
Mówca: **Narrator**
> "She put a finger to her lips and quietly rapped on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Narrator**
> "After almost a minute, it creaked open. Sal stood there in his dressing gown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Sal Ignacius**
> ""Your Majesty, Your Grace! Is there an emergency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Narrator**
> "Lucita took my hand and stepped forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Lucita Azaro**
> ""Grand Wiseman, His Majesty and I are in love and wish for you to sanctify our union by the sacrament of marriage. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Narrator**
> "He rubbed his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Sal Ignacius**
> ""This is most unorthodox.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[278]`
  - -> `[280]`
  - -> `[284]`

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Her Grace has spoken correctly. As your King, I command you to perform the marriage rites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. This seems incredibly hasty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Need I remind you that my mercy saved you from imprisonment? You will do this for us, no questions asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would you rather we live in sin, Grand Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[285]`
Mówca: **Lucita Azaro**
> ""Why wait? It's what we want. And you know how frowned-upon garish second weddings are in royal circles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[289]`
Mówca: **Lucita Azaro**
> ""Why wait? It's what we want. And it'll look desperate for our kingdom to put on two grand royal weddings in a row.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[290]`
Mówca: **Sal Ignacius**
> ""Yes, yes, of course. Give me one moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[291]`
Mówca: **Sal Ignacius**
> ""Of course, Your Grace. Give me one moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[292]`
Mówca: **Narrator**
> "She turned back to Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Lucita Azaro**
> ""Well? Will you do it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[294]`
Mówca: **Sal Ignacius**
> ""No, no, of course not. Give me one moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Narrator**
> "He carefully closed the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[300]`
  - -> `[301]`
  - -> `[302]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still have Lena's wedding ring. Let me fetch it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: IsCollectionItemShowing("CollectionItem_WeddingRing"))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: IsCollectionItemShowing("CollectionItem_WeddingRing"))*
- **Warunek (`conditionsString`):** `IsCollectionItemShowing("CollectionItem_WeddingRing")`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(IsCollectionItemShowing("CollectionItem_WeddingRing")))*
- **Warunek (`conditionsString`):** `(IsCollectionItemShowing("CollectionItem_WeddingRing")) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're insane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you want your father to be here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was this how you always dreamed your wedding would be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[303]`
Mówca: **Lucita Azaro**
> ""He never had any use for weddings. It'll be far more important for him to be present when we first address the troops together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[304]`
Mówca: **Lucita Azaro**
> ""What's insane is spending endless amounts of time and resources to achieve exactly the same result.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[305]`
Mówca: **Narrator**
> "Her breath caught in her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Lucita Azaro**
> ""Are... are you sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[307]`
  - -> `[308]`
  - -> `[310]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She would want you to have it. I'm sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's been gathering dust on my table all these years. It'll look much better on your finger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It symbolizes the continuity of our kingdom's relationship with Rumburg. The alliance endures, even if my marriage did not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure. Imagine how furious it'll make Queen Beatrice to see you wearing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Narrator**
> "I dashed up to my study and took Lena's ring from my desk. My mind flashed back to the all-too-brief time my first wife and I had spent together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[315]`
Mówca: **Narrator**
> "When I made it back to Sal's quarters, the door was open. The Grand Wiseman, now dressed in ceremonial robes, beckoned us inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[316]`
Mówca: **Lucita Azaro**
> ""Mmhmm. Right down to the grass stain on my dress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[317]`
Mówca: **Narrator**
> "The door opened and Sal beckoned us inside, now dressed in ceremonial robes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DisableCollectionItem("CollectionItem_WeddingRing"); RiziaDLC.Lucita_WearsLenasRing = true;
RiziaDLC.Vina_WearsLenasRing = false;)*
- **Efekt (`userScript`):** `DisableCollectionItem("CollectionItem_WeddingRing");
Variable["RiziaDLC.Lucita_WearsLenasRing"] = true;
Variable["RiziaDLC.Vina_WearsLenasRing"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]`

### Węzeł `[319]`
Mówca: **Sal Ignacius**
> ""Because we are not in a sanctuary, some sacred traditions will have to be foregone. But your marriage shall still be valid before the Lord and the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Sal Ignacius**
> ""Please join hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Narrator**
> "I clasped Lucita's hand in mine as we stood side by side in front of Sal. He opened an ancient-looking scroll and read from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[322]`
Mówca: **Narrator**
> "The room was as he'd left it: minimally furnished, with shelves full of books and sacred objects lining the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Lucita Azaro**
> ""Rizian law dictates that in the absence of a Grand Wiseman, the monarch is granted the ability to officiate marriages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Lucita Azaro**
> ""Including his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[331]`
  - -> `[325]`
  - -> `[338]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This seems incredibly hasty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Lucita Azaro**
> ""Why wait? It's what we want. And you know how frowned-upon garish second weddings are in royal circles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[330]`
Mówca: **Lucita Azaro**
> ""Why wait? It's what we want. And it'll look desperate for our kingdom to put on two grand royal weddings in a row.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wedding without boring religious speeches? Count me in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""True. I should practice doing this before Vina's wedding tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[336]`
Mówca: **Lucita Azaro**
> ""I knew you'd like the idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid it won't be legitimate before the Lord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid it won't be legitimate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Lucita Azaro**
> ""You're the King. You are the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[343]`
Mówca: **Lucita Azaro**
> ""You're the King. The Lord's will incarnate, supposedly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Lucita Azaro**
> ""It'll be easy. An oath here, a speech there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Narrator**
> "A wooden box was on Sal's desk, containing the materials needed for Vina's ceremony tomorrow. Lucita walked into the room and began poking through it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[300]`
  - -> `[301]`
  - -> `[302]`

### Węzeł `[349]`
Mówca: **Narrator**
> "Lucita walked into the room and began browsing the shelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[300]`
  - -> `[301]`
  - -> `[302]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Narrator**
> "When I made it back to Sal's quarters, the door was open. Lucita had lit a pair of candles and arranged a set of objects in a row on Sal's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Narrator**
> "I watched as she lit a pair of candles and arranged a set of objects in a row on Sal's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Narrator**
> "First in the row was a scroll. She handed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
**[WYBÓR GRACZA: ""Almighty and ever-loving God...""]** — Mówca: **Player_Romus**
> ""Almighty and ever-living God, who in Thy infinite wisdom hast blessed the union of two hearts in sacred wedlock, look kindly upon myself and Duchess Lucita Azaro, who stand before Thee, seeking Thy blessing. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[360]`
Mówca: **Sal Ignacius**
> ""Almighty and ever-living God, who in Thy infinite wisdom hast blessed the union of two hearts in holy wedlock, look kindly upon His Majesty Romus Toras and Duchess Lucita Azaro, who stand before Thee, seeking Thy blessing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Sal Ignacius**
> ""In this sacred covenant, love and duty converge to forge a legacy that transcends the temporal realm. Let it be known that in the heart of such a union, the virtues of loyalty, honor, and commitment are the true jewels that adorn the crown of matrimonial sanctity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Narrator**
> "The royal orb was on his desk. He picked it up and motioned for us to place our joined hands upon it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Sal Ignacius**
> ""Now, repeat after me. I, Romus Toras...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I want to say my own vows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[365]`
**[WYBÓR GRACZA: ""I, Romus Toras...""]** — Mówca: **Player_Romus**
> ""I, Romus Toras, do pledge my unwavering faithfulness and devotion to you, Lucita Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
**[WYBÓR GRACZA: ""I vow to honor and uphold you...""]** — Mówca: **Player_Romus**
> ""I vow to honor and uphold you, in joy and in sorrow, in prosperity and in adversity. I commit to lead our union with wisdom and compassion, seeking always the guidance of the divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
**[WYBÓR GRACZA: ""In all our days...""]** — Mówca: **Player_Romus**
> ""In all our days, my commitment to you shall remain steadfast, as we walk together in God’s light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[368]`
Mówca: **Narrator**
> "Sal raised his eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Sal Ignacius**
> ""Again, highly unorthodox. But it will not nullify the marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Narrator**
> "Lucita looked at me. Her eyes shone brightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[381]`
  - -> `[378]`
  - -> `[390]`

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita, I claim you not only as my queen, but as the ironclad partner to my reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[376]`
  - -> `[379]`
  - -> `[392]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we defend our kingdom from our hordes of enemies, so shall we champion one another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[375]`
  - -> `[380]`
  - -> `[391]`

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we shall forge an unbreakable empire and crush all those who stand against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As the memory of my cherished Lena fades into the past, I stand here before you ready to love anew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[376]`
  - -> `[379]`
  - -> `[392]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I offer you my heart, my loyalty, and my life, as we embark on this journey together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I vow to honor the bond we have created with kindness and patience. I promise to be your steadfast rock through all the trials and triumphs that our days may bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[375]`
  - -> `[380]`
  - -> `[391]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I vow that I shall listen to every word you say -- well, except for when you're reviewing logistics reports. Who listens to those?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[375]`
  - -> `[380]`
  - -> `[391]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Luce, the past few years I've spent with you have been the happiest in my entire life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[376]`
  - -> `[379]`
  - -> `[392]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether in the chaos of council meetings or in the intimacy of moments alone, I feel I have truly found my equal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[375]`
  - -> `[380]`
  - -> `[391]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pledge myself to you not as a king to his queen, but as a man eager to spend the rest of his life with the woman he loves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Azaro, just as we have navigated the waters of international diplomacy, so too will we chart a course through holy matrimony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[376]`
  - -> `[379]`
  - -> `[392]`
  - -> `[387]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, let us usher in a new era for our kingdom, marked by strength, resilience, and the legacy of the heirs that shall spring from your still-fertile loins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we are more than the sum of our parts. We are bound by shared ambition and mutual respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[375]`
  - -> `[380]`
  - -> `[391]`

### Węzeł `[393]`
Mówca: **Narrator**
> "Sal cast his gaze over us both. He looked genuinely moved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let our marriage be the foundation upon which we build a legacy of peace and prosperity, for our kingdom and for the generations that will follow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[395]`
**[WYBÓR GRACZA: ""In this sacred covenant...""]** — Mówca: **Player_Romus**
> ""In this sacred covenant, love and duty converge to forge a legacy that transcends the temporal realm. Let it be known that in the heart of such a union, the virtues of loyalty, honor, and commitment are the true jewels that adorn the crown of matrimonial sanctity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[396]`
Mówca: **Narrator**
> "Lucita gestured to the royal orb she had placed on the desk. We both lay our hands on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[397]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we're going to break tradition, I want to go all the way. I'll recite my own vows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Lucita Azaro**
> ""As you wish. It's just us and the Lord anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[399]`
Mówca: **Lucita Azaro**
> ""Perfect. And now for the oath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[400]`
Mówca: **Narrator**
> "Sal nodded to Lucita, and she repeated the vow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[404]`
Mówca: **Narrator**
> "The Grand Wiseman placed the orb back on his desk. He took out a small pot containing a strong-smelling substance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[405]`
Mówca: **Sal Ignacius**
> ""Thank you, Your Majesty. Would you like to do the same, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Narrator**
> "Lucita was struggling to fight back tears. Eventually, she brought herself to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[407]`
Mówca: **Narrator**
> "Lucita looked me in the eyes as she repeated the vow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Narrator**
> "Lucita was struggling to fight back tears. Eventually, she brought herself to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Lucita Azaro**
> ""As the queen on a chessboard guards her king, so do I vow to protect you and this kingdom, Romus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[413]`
Mówca: **Lucita Azaro**
> ""As the queen on a chessboard guards her king, so do I vow to protect you and this kingdom, Romus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Narrator**
> "We took our hands off the orb. Next to it on the desk was a small pot containing a strong-smelling substance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Narrator**
> "Lucita took a quick look at the scroll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Sal Ignacius**
> ""This oil is infused with the protection of our Lord and the strength and blessings of our ancestors. As you anoint one another, be reminded of your promises to serve each other, the Lord and this realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Lucita Azaro**
> ""This oil is infused with the protection of our Lord and the strength and blessings of our ancestors. As you anoint one another, be reminded of your promises to serve each other, the Lord and this realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Narrator**
> "I dipped a finger into the oil and lightly touched Lucita's forehead. She did the same to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Narrator**
> "I dipped a finger into the oil and lightly touched Lucita's forehead. She did the same to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_WearsLenasRing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_WearsLenasRing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_WearsLenasRing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_WearsLenasRing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_WearsLenasRing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[423]`
Mówca: **Narrator**
> "I handed Sal Lena's old wedding ring. He produced another, more ancient-looking one from a drawer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[424]`
Mówca: **Narrator**
> "Lucita took two ancient-looking rings off the desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_WearsLenasRing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_WearsLenasRing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_WearsLenasRing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_WearsLenasRing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_WearsLenasRing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[428]`
Mówca: **Narrator**
> "I produced Lena's ring from my pocket. Lucita took another, more ancient-looking one off the desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[429]`
Mówca: **Narrator**
> "Sal reached into a drawer and produced two ancient-looking rings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[430]`
Mówca: **Sal Ignacius**
> ""These were salvaged from the Plavo crypt. I don't know who they belonged to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[431]`
Mówca: **Lucita Azaro**
> ""It belongs to House Azaro, Grand Wiseman. That much is certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[442]`
  - -> `[445]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_WearsLenasRing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_WearsLenasRing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_WearsLenasRing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_WearsLenasRing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_WearsLenasRing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promised Vina my late wife's ring. But I want you to have it instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter lost her right to it when she ran away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[440]`
Mówca: **Sal Ignacius**
> ""This was salvaged from the Plavo crypt. I don't know who it belonged to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[441]`
Mówca: **Lucita Azaro**
> ""They belong to House Azaro, Grand Wiseman. That much is certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`
  - -> `[447]`

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll have to do for now. We'll find a proper one later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[443]`
Mówca: **Lucita Azaro**
> ""This is a House Azaro ring. The Grand Wiseman must have salvaged it from the Plavo Archsanctuary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[442]`
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Lucita Azaro**
> ""These are House Azaro rings. The Grand Wiseman must have salvaged them from the Plavo Archsanctuary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`
  - -> `[447]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Toras king with an Azaro ring. I shall keep your house with me at all times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll have to do for now. We'll have proper ones made later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They're beautiful. I'll wear mine with pride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's beautiful. I'll wear it with pride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
Mówca: **Narrator**
> "As we exchanged rings, I looked deep into Lucita's eyes. They were like bottomless pools, concealing the future of the kingdom somewhere within their depths."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Sal Ignacius**
> ""By the power vested in me, through the divine grace and the laws that govern our land, I now pronounce you husband and wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[456]`
  - -> `[458]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By the power vested in me, through the divine grace and the laws that govern our land, I now pronounce us husband and wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[455]`
Mówca: **Sal Ignacius**
> ""In accordance with tradition, you may now seal your vows with a kiss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As the sovereign of this realm, I name you as my queen. Now and forever more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[457]`
Mówca: **Narrator**
> "Our lips met. I sensed every molecule in her body vibrating with happiness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? We're married now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Lucita Azaro**
> ""That's it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[460]`
Mówca: **Lucita Azaro**
> ""You may kiss the bride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[461]`
Mówca: **Narrator**
> "Once again, I was a married man."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Narrator**
> "But there was still one more wedding to go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[466]`
Mówca: **Narrator**
> "This time, by choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married = true;
RiziaDLCSupport.Journal_Turn08_Lucita_Married = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_Married"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_Lucita_Married"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[471]`
Mówca: **Narrator**
> "I pushed open the door to my quarters to find Pabel, busy hanging up an outfit on my valet stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[474]`
  - -> `[475]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged = false;
RiziaDLC.Pabel_Gone = true; RiziaDLC.Relations_Pabel_Together = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_Engaged"] = false;
Variable["RiziaDLC.Pabel_Gone"] = true;
Variable["RiziaDLC.Relations_Pabel_Together"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's late. Shouldn't you have done that already?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel. You're a sight for sore eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ooh. What am I wearing tomorrow?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[476]`
Mówca: **Pabel Adria**
> ""I didn't get the chance. There was a snag with the seating arrangements for tomorrow. Some fool from the wedding committee placed the Qinali and Free Cities delegations next to each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[480]`
Mówca: **Pabel Adria**
> ""I didn't get the chance. Some fool gardening assistant poured leftover wine on the begonias. I just barely resuscitated them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[481]`
Mówca: **Pabel Adria**
> ""Besides... I was rather hoping our paths would cross.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[482]`
Mówca: **Pabel Adria**
> ""As are you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[485]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Pabel Adria**
> ""The royal blue tuxedo from Thornfield & Marchmont in Bronaz. Don't you remember getting fitted for it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Pabel Adria**
> ""Your charcoal grey suit. I know you're fond of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[488]`
Mówca: **Narrator**
> "He stepped closer to me, and we embraced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Narrator**
> "Since I'd done away with Rizia's anti-homosexuality laws, we had started to be less secretive about our meetings, though we still had not mentioned our relationship to anyone in the palace or beyond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[493]`
Mówca: **Pabel Adria**
> ""I can't believe Princess Vina is getting married tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still miss her. But I have to move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Poor Lena. She never got to see her daughter become a woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And me? How did I look?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[500]`
Mówca: **Pabel Adria**
> ""Like a handsome prince.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[501]`
Mówca: **Pabel Adria**
> ""She lives on in Her Highness. And in all of her descendents, whoever they may be...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[502]`
Mówca: **Narrator**
> "Pabel laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[503]`
Mówca: **Pabel Adria**
> ""You're too kind. She was beautiful in a way even I could appreciate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[504]`
Mówca: **Pabel Adria**
> ""You're doing a fine job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[505]`
Mówca: **Pabel Adria**
> ""Vina Toras, Duchess of Monqiz. The time has finally come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[506]`
Mówca: **Pabel Adria**
> ""It feels like just yesterday that the kingdom was celebrating her birth. Her mother looked positively radiant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[507]`
  - -> `[495]`
  - -> `[499]`

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe me, Princess Lena of Rumburg couldn't hold a candle to Mr. Pabel Adria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[508]`
Mówca: **Pabel Adria**
> ""It seems as though Princess Vina has come into her own as a councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FullCouncilor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`
  - -> `[511]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FullCouncilor == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FullCouncilor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FullCouncilor == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FullCouncilor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We argued over every aspect of those celebrations. It was hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[513]`
Mówca: **Lucita Azaro**
> ""From the outside, it was a fairy tale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We argued over every aspect of those celebrations. It was hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[515]`
Mówca: **Pabel Adria**
> ""I remember. Your love for your daughter was the only thing you agreed on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[516]`
Mówca: **Narrator**
> "He pulled back from me, his arms still encircling my waist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know, with Vina changing her last name, the reputation of House Toras really doesn't matter anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`
  - -> `[520]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_KeepsLastName"] == false  and  (Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Manus == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_KeepsLastName"] == false  and  (Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[521]`
Mówca: **Pabel Adria**
> ""Even so, what about my reputation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Narrator**
> "He dropped his arms to his sides. His fists curled in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina's a hostage. Hugo and Rico's side of the family will probably inherit the throne anyway. It doesn't matter what I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[524]`
Mówca: **Pabel Adria**
> ""It matters to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[525]`
Mówca: **Pabel Adria**
> ""You have a modicum of protection as the king. But the moment the truth gets out about us, I'll be torn apart from all sides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let the papers say what they will. I'm not afraid for my reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.LeaningValue_Democratic > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`
  - -> `[529]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.LeaningValue_Democratic > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.LeaningValue_Democratic > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titles mean nothing, Pabel. I see you as a friend and an equal, regardless of our stations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[531]`
Mówca: **Pabel Adria**
> ""I'm afraid for mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[532]`
Mówca: **Pabel Adria**
> ""But the rest of the kingdom doesn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[533]`
Mówca: **Pabel Adria**
> ""I know that decriminalizing homosexuality came at a great cost to your popularity. But I'm so glad you did it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`
  - -> `[534]`
  - -> `[535]`
  - -> `[542]`

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's just a shame that you and I can't enjoy that freedom for ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[535]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It might be legal for us to see each other, but I still rather enjoy the secrecy of it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Pabel Adria**
> ""It's not only enjoyable. It's necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Pabel Adria**
> ""A king openly dating a man is cause enough for scandal, but a commoner? And a member of his household staff, at that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[518]`
  - -> `[686]`
  - -> `[546]`
  - -> `[527]`

### Węzeł `[539]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might no longer be breaking the law, but I'm still a very bad boy who needs to be punished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Pabel Adria**
> ""Easy there, Your Majesty. We can't throw all caution to the wind yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[541]`
Mówca: **Narrator**
> "A glint appeared in his eye. He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My popularity with *Rizians*. The Derdians love me now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[543]`
Mówca: **Pabel Adria**
> ""So do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[545]`
Mówca: **Pabel Adria**
> ""But I'm still dreading what will happen if the rumors about us ever spread beyond palace walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You grew up in this palace. You hardly count as a commoner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Pabel Adria**
> ""My family's legacy is tending to other people's land. We have none of our own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[548]`
Mówca: **Pabel Adria**
> ""And if something happens to you, or things end badly between us? Rom, I'll have nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`
  - -> `[551]`
  - -> `[550]`
  - -> `[549]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing will ever happen to me. I'm basically immortal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will never end badly between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[551]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we'll continue in secret. As we always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if I were to confer noble status upon you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Narrator**
> "He blinked in confusion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[555]`
Mówca: **Pabel Adria**
> ""I beg your pardon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`
  - -> `[556]`
  - -> `[562]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's strictly a symbolic title now that the electoral reforms have been enacted. But you wouldn't be a commoner anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I grant you a piece of land and make you a lord. Like my mother's family, or Daria de Rava.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd have to take on one or two extra responsibilities. But you wouldn't be a commoner anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* anything were to disrupt our relationship, you'd still have an estate to fall back on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[563]`
Mówca: **Narrator**
> "Pabel mulled it over for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[564]`
Mówca: **Pabel Adria**
> ""And you can just... do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`
  - -> `[566]`

### Węzeł `[565]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo would have to make it official. Shall we go fetch him now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[566]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, no. It's too difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[567]`
Mówca: **Narrator**
> "Pabel lowered his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[568]`
Mówca: **Pabel Adria**
> ""Then secrecy it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[569]`
Mówca: **Narrator**
> "He laughed and kissed me on the forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[570]`
Mówca: **Pabel Adria**
> ""Romus the Romantic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[571]`
Mówca: **Narrator**
> "He laughed and kissed me on the forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[572]`
Mówca: **Pabel Adria**
> ""If only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[573]`
Mówca: **Pabel Adria**
> ""Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Pabel Adria**
> ""I'll let you rest. Big day tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[578]`
Mówca: **Pabel Adria**
> ""I'll let you rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[579]`
Mówca: **Narrator**
> "He gave me an excited hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[580]`
Mówca: **Pabel Adria**
> ""I'll do it. I'm your butler, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[581]`
Mówca: **Narrator**
> "Not long afterwards, Hugo, Pabel and I convened in the Grand Vizier's chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Narrator**
> "My uncle uneasily glanced from one of us to another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[584]`
Mówca: **Hugo Toras**
> ""A head butler, joining the gentry. I must say I've never heard of such a thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[589]`
  - -> `[590]`
  - -> `[591]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_BrokeTradition > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`
  - -> `[587]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_BrokeTradition > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_BrokeTradition > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I'm not one to play by the rules, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel has spent his entire life in service to the Royal Family. He deserves a reward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's not only my butler, he's my close friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a symbolic gesture. It won't change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[592]`
Mówca: **Hugo Toras**
> ""So I have gathered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[593]`
Mówca: **Hugo Toras**
> ""His loyalty is undisputed, it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[594]`
Mówca: **Narrator**
> "He eyed us both closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[595]`
Mówca: **Hugo Toras**
> ""Yes. So I gather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[596]`
Mówca: **Hugo Toras**
> ""It sets a dangerous precedent. We can't have every scullery maid in the palace clamoring to be a lady.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[597]`
Mówca: **Narrator**
> "He turned to Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`
  - -> `[600]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[601]`
Mówca: **Hugo Toras**
> ""I assume His Majesty has told you of the unfair taxes that will be levied upon you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[604]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[605]`
Mówca: **Narrator**
> "He turned away from us and pulled out an enormous book of records. After rifling though it for a while, he put his finger on one of the entries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[606]`
Mówca: **Hugo Toras**
> ""The Veridian estate on the outskirts of Malcos. It's lain abandoned for years after an unresolved inheritance dispute, but its famous orchards are as fecund as ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[607]`
Mówca: **Narrator**
> "He turned to Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[608]`
Mówca: **Hugo Toras**
> ""I will warn you not to take on any tenants. You'll never be able to get rid of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[609]`
Mówca: **Narrator**
> "He turned to Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[610]`
Mówca: **Hugo Toras**
> ""With your title comes great responsibility. I hope you are ready for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[611]`
Mówca: **Pabel Adria**
> ""I served two royal households, Your Grace. I am ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[612]`
Mówca: **Pabel Adria**
> ""Your advice has been noted, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[613]`
Mówca: **Pabel Adria**
> ""I will pay what I must, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[614]`
Mówca: **Narrator**
> "Hugo busied himself at his desk for a few minutes, then held up a piece of parchment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[615]`
Mówca: **Hugo Toras**
> ""Here is the letters patent. It needs your signature and the King's seal, and then the deed is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[616]`
**[WYBÓR GRACZA: "Put your seal on the document."]** — Mówca: **Player_Romus_Italic**
> "I heated a stick of wax, dripped it onto the document and stamped it with my seal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[617]`
Mówca: **Narrator**
> "Pabel added his signature. Hugo nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`
  - -> `[647]`
  - -> `[618]`
  - -> `[621]`

### Węzeł `[618]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hereby proclaim you Lord Pabel Adria of Veridian. May your actions reflect the honor of your title.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[619]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[620]`
Mówca: **Pabel Adria**
> ""They will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you have served me as a butler, so now do I entrust you with the care of your own domain. May you tend to it as thoughtfully as you tend to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[622]`
Mówca: **Narrator**
> "He gave me a quick kiss and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[623]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`

### Węzeł `[624]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[625]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[626]`
Mówca: **Narrator**
> "Bruno was on my bed yet again. He whimpered disappointedly as Pabel left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`
  - -> `[632]`

### Węzeł `[627]`
Mówca: **Narrator**
> "From his corner, Bruno whimpered disappointedly as Pabel left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`
  - -> `[632]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[631]`
**[WYBÓR GRACZA: "Pet him."]** — Mówca: **Player_Romus_Italic**
> "I gave him a reassuring pat on the head before beginning my bedtime routine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shhh. Bad dog.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[633]`
Mówca: **Narrator**
> "Bruno quieted down and rolled over on his side as I began my bedtime routine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[634]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[635]`
Mówca: **Pabel Adria**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[636]`
Mówca: **Narrator**
> "Hugo shook Pabel's hand and handed him the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord = true;
RiziaDLCSupport.Journal_Turn08_Pabel_Lord = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pabel_Lord"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_Pabel_Lord"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[877]`

### Węzeł `[638]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_WeddingCommittee == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`
  - -> `[640]`

### Węzeł `[639]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_WeddingCommittee == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_WeddingCommittee"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_WeddingCommittee == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_WeddingCommittee"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[641]`
Mówca: **Pabel Adria**
> ""I didn't get the chance. There was a snag with the seating arrangements. Some fool from the wedding committee placed the Qinali and Free Cities delegations next to each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[642]`
Mówca: **Hugo Toras**
> ""But your many years of service to this household do deserve acknowledgement, Mr. Adria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`
  - -> `[645]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[646]`
Mówca: **Hugo Toras**
> ""Don't let it get to your head. We need all your focus on coordinating tomorrow's festivities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`
  - -> `[657]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May this mark the beginning of a new era, where titles are not inherited but earned by merit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[648]`
Mówca: **Narrator**
> "Hugo coughed. Pabel, grinning from ear to ear, ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[649]`
Mówca: **Pabel Adria**
> ""A new era indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The institution of nobility is a relic of a bygone era, one that perpetuates inequality and stifles the true potential of our people. But enjoy the fruit trees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[651]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`
  - -> `[653]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[654]`
Mówca: **Narrator**
> "Hugo coughed. Pabel, grinning from ear to ear, ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[655]`
Mówca: **Pabel Adria**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[656]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. Lord Adria will accompany me to the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[657]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true, Pabel. You've got to hold on to your head butler duties, at least until a replacement is found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[658]`
Mówca: **Hugo Toras**
> ""Congratulations, Lord Adria. Don't let it get to your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[659]`
Mówca: **Narrator**
> "Pabel and Hugo appeared equally surprised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[660]`
Mówca: **Pabel Adria**
> ""Why... it would be an honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[661]`
Mówca: **Pabel Adria**
> ""Of course, Your Majesty. I'll make sure tomorrow goes off without a hitch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[662]`
Mówca: **Narrator**
> "My uncle stared in open amazement as we left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[663]`
Mówca: **Narrator**
> "I could still feel his eyes on us as we made our way back down the hall and upstairs to my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[664]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_WeddingDate = true;
RiziaDLCSupport.Journal_Turn08_Pabel_WeddingDate = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pabel_WeddingDate"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_Pabel_WeddingDate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[665]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[667]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[668]`
Mówca: **Pabel Adria**
> ""I can't believe it's been a year since Her Highness was taken hostage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`
  - -> `[669]`
  - -> `[676]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`
  - -> `[671]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're going to get her back. I can feel it in my bones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When we win this war, Pales will pay for what they did to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[674]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Azaros seem to have given up hope of finding her. Perhaps I should as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[675]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to remind me. I've been counting the days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`
  - -> `[678]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's what she gets for being such a brat to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[680]`
Mówca: **Narrator**
> "Pabel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[681]`
Mówca: **Pabel Adria**
> ""I'm sure you don't mean that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[682]`
Mówca: **Pabel Adria**
> ""I'm sure you have. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[683]`
Mówca: **Pabel Adria**
> ""Don't be ridiculous. There's always hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[684]`
Mówca: **Pabel Adria**
> ""That's the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[685]`
Mówca: **Pabel Adria**
> ""As long as she's still alive, there's hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[688]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[689]`
Mówca: **Pabel Adria**
> ""Absolutely not, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`
  - -> `[692]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[70]`
  - -> `[76]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`
  - -> `[695]`

### Węzeł `[694]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[696]`
Mówca: **Lucita Azaro**
> ""I can't believe it's been a year since Her Highness was taken hostage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[697]`
Mówca: **Narrator**
> "She sighed unhappily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[698]`
Mówca: **Lucita Azaro**
> ""I can't help but feel personally responsible that she hasn't made it home yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`
  - -> `[703]`
  - -> `[705]`

### Węzeł `[699]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When we win this war, Pales will pay for what they did to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`
  - -> `[702]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[703]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to tell me how long it's been. I've been counting every single day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[704]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't blame yourself. Blame your goddamn fool of a father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, it's my fault for sending her there in the first place.''"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[706]`
Mówca: **Lucita Azaro**
> ""You couldn't have known what would happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[707]`
Mówca: **Lucita Azaro**
> ""Of course you have. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[708]`
Mówca: **Lucita Azaro**
> ""I should have spoken against him. He hardly even knew the Princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[709]`
Mówca: **Lucita Azaro**
> ""I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[710]`
Mówca: **Narrator**
> "I pushed open the door to my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[711]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`
  - -> `[713]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[714]`
Mówca: **Narrator**
> "Arranged on my valet stand was a brand-new, crisp royal blue suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[715]`
Mówca: **Narrator**
> "Bruno was on my bed as usual. I noticed the corner of a piece of paper sticking out from under him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[716]`
Mówca: **Narrator**
> "Pabel had hung up my favorite suit on the valet stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`
  - -> `[719]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`
  - -> `[722]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[722]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[723]`
Mówca: **Narrator**
> "Bruno was pacing around next to it. He seemed agitated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[724]`
Mówca: **Narrator**
> "I looked at my bed. There was a piece of paper on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[725]`
**[WYBÓR GRACZA: "Pick it up."]** — Mówca: **Player_Romus_Italic**
> "I shoved the dog off the bed and looked at the paper. It was a note from Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[726]`
**[WYBÓR GRACZA: "Pick it up."]** — Mówca: **Player_Romus_Italic**
> "I picked it up. It was a note from Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[727]`
Mówca: **Pabel Adria**
> ""Dear Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[728]`
Mówca: **Pabel Adria**
> ""I write these words with a heavy heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[729]`
Mówca: **Pabel Adria**
> ""I will never forget the years I spent serving your family, nor the time you and I shared together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[730]`
Mówca: **Pabel Adria**
> ""I have not lost hope that time will bring forth change -- in our nation and in your own heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[731]`
Mówca: **Pabel Adria**
> ""But in the end, my deepest loyalty must be to myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[732]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`
  - -> `[734]`

### Węzeł `[733]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[735]`
Mówca: **Pabel Adria**
> ""I wish Her Highness all the happiness in the world. But the thought of celebrating her love while the law still forces us to conceal our own fills me with unbearable sorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[736]`
Mówca: **Pabel Adria**
> ""I can no longer bear silent witness as you deny your daughter, your country and yourself the freedom to love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[737]`
Mówca: **Pabel Adria**
> ""But I am done waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[738]`
Mówca: **Pabel Adria**
> ""Bi mare volu...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[739]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[740]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You fucking traitor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[741]`
**[WYBÓR GRACZA: "Crumple up the note and throw it away."]** — Mówca: **Player_Romus_Italic**
> "I crumpled up the note and threw it away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[742]`
Mówca: **Narrator**
> "The bed let out a loud creak as I sat down on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[743]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`
  - -> `[740]`
  - -> `[741]`

### Węzeł `[744]`
Mówca: **Narrator**
> "My chambers had never seemed this empty before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone = true; RiziaDLC.Relations_Pabel_Together = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pabel_Gone"] = true;
Variable["RiziaDLC.Relations_Pabel_Together"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [End();])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[747]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Solitude","R_Solitude_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`
  - -> `[750]`

### Węzeł `[749]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`

### Węzeł `[750]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[751]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[752]`
Mówca: **Narrator**
> "He gave me an excited hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[753]`
Mówca: **Narrator**
> "Inside, we pulled out an enormous book of records. After rifling though it for a while, I saw an entry with no ownership."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[754]`
Mówca: **Narrator**
> "I took him to the Grand Vizier's chambers, where Hugo used to keep the book of records for such estates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`

### Węzeł `[755]`
Mówca: **Narrator**
> "It was the Veridian estate on the outskirts of Malcos. According to the documents, it's lain abandoned for years after an unresolved inheritance dispute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[756]`
**[WYBÓR GRACZA: "Put your seal on the document."]** — Mówca: **Player_Romus_Italic**
> "I heated a stick of wax, dripped it onto the document and stamped it with my seal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[757]`
Mówca: **Narrator**
> "Pabel added his signature. I nodded at him. It was done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`
  - -> `[764]`
  - -> `[758]`
  - -> `[761]`

### Węzeł `[758]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hereby proclaim you Lord Pabel Adria of Veridian. May your actions reflect the honor of your title.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[759]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[760]`
Mówca: **Pabel Adria**
> ""They will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[761]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you have served me as a butler, so now do I entrust you with the care of your own domain. May you tend to it as thoughtfully as you tend to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[762]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[763]`
Mówca: **Pabel Adria**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[764]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May this mark the beginning of a new era, where titles are not inherited but earned by merit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`

### Węzeł `[765]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[766]`
Mówca: **Pabel Adria**
> ""A new era indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[767]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The institution of nobility is a relic of a bygone era, one that perpetuates inequality and stifles the true potential of our people. But enjoy the fruit trees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`

### Węzeł `[768]`
Mówca: **Narrator**
> "I handed him the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`
  - -> `[775]`
  - -> `[776]`

### Węzeł `[769]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`
  - -> `[771]`

### Węzeł `[770]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[772]`
Mówca: **Pabel Adria**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[773]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`

### Węzeł `[774]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep this safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[775]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lord Adria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[776]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? Easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[777]`
Mówca: **Pabel Adria**
> ""At your service, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[778]`
Mówca: **Pabel Adria**
> ""I will. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[779]`
Mówca: **Pabel Adria**
> ""Thank you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[780]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`
  - -> `[782]`

### Węzeł `[781]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[782]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[783]`
Mówca: **Narrator**
> "We left the Grand Vizier's chambers together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[784]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`
  - -> `[786]`

### Węzeł `[785]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[786]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`

### Węzeł `[787]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged = false;
RiziaDLC.Pabel_Gone = true;
RiziaDLCSupport.News_Turn08_V_VinaEscape_Regular = true; RiziaDLC.Relations_Pabel_Together = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_Engaged"] = false;
Variable["RiziaDLC.Pabel_Gone"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_VinaEscape_Regular"] = true;
Variable["RiziaDLC.Relations_Pabel_Together"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[788]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_RH_RoyalWedding_VinaDuchess = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_RoyalWedding_VinaDuchess"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[789]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`
  - -> `[791]`

### Węzeł `[790]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[791]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[792]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn08_MaveNortus_IntelligenceServiceSearchesVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_MaveNortus_IntelligenceServiceSearchesVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[793]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I surrender to you. I want you to be Rizia's new Queen Consort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I wanted to know. Good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`

### Węzeł `[795]`
Mówca: **Narrator**
> "Lucita grabbed my arm. She made an effort to keep a pleasant expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`

### Węzeł `[796]`
Mówca: **Lucita Azaro**
> ""Wait, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`

### Węzeł `[797]`
Mówca: **Lucita Azaro**
> ""I have to know. Do you ever intend to have another child?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`
  - -> `[805]`
  - -> `[806]`

### Węzeł `[798]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It won't be easy to rest. But I'll try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`

### Węzeł `[799]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I have to do something. I'll go crazy otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`

### Węzeł `[800]`
Mówca: **Narrator**
> "She looked in both directions, then grabbed my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`

### Węzeł `[801]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can you ask me that right now? With my daughter Lord knows where...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[802]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`
  - -> `[804]`

### Węzeł `[803]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[804]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[805]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Just the one was enough for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]`

### Węzeł `[806]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[807]`
Mówca: **Lucita Azaro**
> ""I hate to say it, but: exactly. You must be aware that you need a backup plan in case Her Highness doesn't return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[808]`
Mówca: **Lucita Azaro**
> ""And, well, I'm not getting any younger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[809]`
Mówca: **Narrator**
> "She looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[810]`
Mówca: **Lucita Azaro**
> ""Then we shouldn't be together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[811]`
Mówca: **Lucita Azaro**
> ""Of course, if you did have a second child, he or she would have to be legitimate to qualify for the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`
  - -> `[867]`
  - -> `[820]`
  - -> `[821]`
  - -> `[822]`

### Węzeł `[812]`
Mówca: **Lucita Azaro**
> ""Not to mention... You know I've been careful. But an illegitimate child between the two of us could throw the kingdom into chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`
  - -> `[820]`
  - -> `[821]`
  - -> `[822]`

### Węzeł `[813]`
Mówca: **Narrator**
> "She looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[814]`
Mówca: **Lucita Azaro**
> ""Then we should be wed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[815]`
Mówca: **Lucita Azaro**
> ""I'm not getting any younger. And it isn't my intention to die an old maid or secret mistress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[816]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've made your point. I want to marry you, Lucita. But I've already shelled out for one royal wedding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[817]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`
  - -> `[819]`

### Węzeł `[818]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`

### Węzeł `[819]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[820]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you trying to wheedle a proposal out of me? It won't work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[821]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please don't take this personally. But no, I do not wish to have a child with you. My daughter must remain my successor, no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]`

### Węzeł `[822]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then by all means, Duchess, let us be wed posthaste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[823]`
Mówca: **Narrator**
> "Resolve formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[824]`
Mówca: **Lucita Azaro**
> ""Then... this is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[825]`
Mówca: **Lucita Azaro**
> ""I'm sorry, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]`

### Węzeł `[826]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry too. Sorry you only wanted me for my royal seed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[827]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This seems sudden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[828]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we were not royals, this wouldn't be so complicated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[829]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do love you, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]`

### Węzeł `[830]`
Mówca: **Narrator**
> "She made a disgusted face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[831]`
Mówca: **Lucita Azaro**
> ""I know. But I've been thinking about it for some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[832]`
Mówca: **Narrator**
> "She straightened up and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`

### Węzeł `[833]`
Mówca: **Lucita Azaro**
> ""Alas, this is the only life we have. And I don't want to waste mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[834]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End No Marriage)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[835]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]`
  - -> `[837]`

### Węzeł `[836]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]`

### Węzeł `[837]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]`

### Węzeł `[838]`
Mówca: **Lucita Azaro**
> ""Good night, Your Majesty. I'll see you at the wedding tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`

### Węzeł `[839]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`
  - -> `[841]`

### Węzeł `[840]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]`

### Węzeł `[841]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]`

### Węzeł `[842]`
Mówca: **Narrator**
> "She turned and walked away from me, breaking into a jog as she reached the edge of the clearing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[843]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [End No Marriage])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[844]`
Mówca: **Lucita Azaro**
> ""Good night, Your Majesty. I'll see you at our next council meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`

### Węzeł `[845]`
Mówca: **Narrator**
> "That was it. Just as soon as I had found new love, I'd lost it again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]`

### Węzeł `[846]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[847]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]`
  - -> `[849]`

### Węzeł `[848]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]`

### Węzeł `[849]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]`

### Węzeł `[850]`
Mówca: **Narrator**
> "I hoped Vina would be luckier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]`

### Węzeł `[851]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [End();])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[852]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together = false; RiziaDLC.Path_Stratocracy = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Together"] = false;
Variable["RiziaDLC.Path_Stratocracy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]`

### Węzeł `[853]`
Mówca: **Lucita Azaro**
> ""Really? You mean that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[854]`
Mówca: **Lucita Azaro**
> ""I promise that's not the reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[855]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]`
  - -> `[857]`

### Węzeł `[856]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[857]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro < 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`

### Węzeł `[858]`
Mówca: **Lucita Azaro**
> ""She can be your successor if you like. You're the king, you make the rules.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]`
  - -> `[862]`
  - -> `[863]`

### Węzeł `[859]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't think you mean that. The second I impregnate you, the Azaros will be scrambling to get Vina out of the picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[860]`
Mówca: **Narrator**
> "A hurt look formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[861]`
Mówca: **Lucita Azaro**
> ""If that's the level of trust you have for me and my family... then this is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[862]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you truly will accept it if Vina stays first in line for the throne... then yes. Let's get married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[894]`

### Węzeł `[863]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That may be true. But I still find it too risky to muddy up the line of succession. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`

### Węzeł `[864]`
Mówca: **Narrator**
> "A hurt look formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]`

### Węzeł `[865]`
Mówca: **Lucita Azaro**
> ""I'm sorry too, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]`

### Węzeł `[866]`
Mówca: **Lucita Azaro**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[867]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't bring another child into this world, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[868]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_MarriageDecision_Rico == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]`
  - -> `[870]`

### Węzeł `[869]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_MarriageDecision_Rico == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]`

### Węzeł `[870]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_MarriageDecision_Rico == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[871]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_TorasCelebrates = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_TorasCelebrates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[872]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[873]`
  - -> `[874]`

### Węzeł `[873]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]`

### Węzeł `[874]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]`

### Węzeł `[875]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_Protests = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_Protests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[876]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_WeddingRing");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_WeddingRing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[877]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Others_PabelAdria_Lord");)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Others_PabelAdria_Lord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[878]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Path_Stratocracy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[879]`
  - -> `[880]`

### Węzeł `[879]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Path_Stratocracy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Path_Stratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]`

### Węzeł `[880]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Path_Stratocracy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`

### Węzeł `[881]`
Mówca: **Lucita Azaro**
> ""Did you ever love me? Or were you just looking to use my armies to consolidate your power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]`
  - -> `[888]`
  - -> `[889]`

### Węzeł `[882]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`
  - -> `[827]`
  - -> `[828]`
  - -> `[829]`

### Węzeł `[883]`
Mówca: **Lucita Azaro**
> ""I have a rather more low-budget idea. If you'll permit me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]`
  - -> `[885]`
  - -> `[884]`

### Węzeł `[884]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[885]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't even proposed yet. Lucita Azaro, will you marry me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[886]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. This all happening too fast. I've got cold feet. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`

### Węzeł `[887]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did love you. I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[892]`

### Węzeł `[888]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They were never *your* armies, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[891]`

### Węzeł `[889]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can still have a monarcho-military alliance without literally uniting our bloodlines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]`

### Węzeł `[890]`
Mówca: **Lucita Azaro**
> ""Not where my family's concerned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[891]`
Mówca: **Lucita Azaro**
> ""Sweetie?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[892]`
Mówca: **Lucita Azaro**
> ""Too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[893]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together = false; RiziaDLC.Path_Stratocracy = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Together"] = false;
Variable["RiziaDLC.Path_Stratocracy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]`

### Węzeł `[894]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_OKWithVinaSuccessor = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_OKWithVinaSuccessor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
