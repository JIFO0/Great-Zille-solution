# Sordland/Turn08/PoliticsBillsBriefing

- **ID konwersacji:** `176`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/176_PoliticsBillsBriefing.md`
- **Liczba węzłów dialogowych:** 134
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_DemocraticRayne`
- `BaseGame.Bill_Turn03_GruniRegeneration_Signed`
- `BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch`
- `BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions`
- `BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Economy_Bergia`
- `BaseGame.Economy_Gruni`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Faction_USP_AgainstProposal`
- `BaseGame.Faction_USP_Obstructionist`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Law_AutonomousZoneOfBergia`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Policy_Welfare_IncreasedEducationFunding`
- `BaseGame.Reform_Autocrat_Abandon`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Reform_VoteCount_USP_AlbinsWing`
- `BaseGame.Reform_VoteCount_USP_GloriasWing`
- `BaseGame.Turn08_Dictator_Success`
- `BaseGame.Turn08_Reformist_Success`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_LiviaFired`
- `BaseGame.Turn08_SecondScandal_LiviaInvestigated`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.YoungSords_Aids_Security`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.Economy_Bergia`
- `BaseGame.Economy_Gruni`
- `BaseGame.Faction_USP_Obstructionist`
- `BaseGame.Situation_Order_ViolentSuppression`
- `BaseGameSupport.News_Turn08_G_UCSatelliteUncovers`
- `BaseGameSupport.Report_Turn08_Holsord_ATOInfluenceGrows`
- `BaseGameSupport.Report_Turn08_Holsord_CSPInfluenceGrows`
- `BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy`
- `BaseGameSupport.Turn08_LT_FCAnricaPromisingSeason_Default`

### Skoki między-konwersacyjne:
- Węzeł `[46]` -> **[539] Sordland/Turn08/Internal Affairs Section with Lileas and Nia/Internal Affairs Section with Lileas and Nia Conversation** (../Turn_08/539_Internal_Affairs_Section_with_Lileas_and_Nia_Conversation.md), Węzeł `[1]`
- Węzeł `[48]` -> **[539] Sordland/Turn08/Internal Affairs Section with Lileas and Nia/Internal Affairs Section with Lileas and Nia Conversation** (../Turn_08/539_Internal_Affairs_Section_with_Lileas_and_Nia_Conversation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 38

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.Economy_Bergia`
- `BaseGame.Economy_Gruni`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[7]` (Paskal Beniwoll): `Variable["BaseGame.Situation_Order_ViolentSuppression"] = true;`
- Węzeł `[8]` (Paskal Beniwoll): `PlayMusic("Security"); ;`
- Węzeł `[12]` (Paskal Beniwoll): `AddTokenStatus("Sordland_City_Deyr","City_BergiaAutonomousZone");`
- Węzeł `[13]` (Paskal Beniwoll): `RemoveTokenStatus("Sordland_City_Deyr","City_BergiaSpecialZone");`
- Węzeł `[14]` (Paskal Beniwoll): `RemoveTokenStatus("Sordland_City_Erzaren","City_BergiaSpecialZone");`
- Węzeł `[15]` (Paskal Beniwoll): `RemoveTokenStatus("Sordland_City_Uziren","City_BergiaSpecialZone");`
- Węzeł `[16]` (Paskal Beniwoll): `RemoveTokenStatus("Sordland_City_Ribel","City_BergiaSpecialZone");`
- Węzeł `[17]` (Paskal Beniwoll): `RemoveTokenStatus("Sordland_City_Sarna","City_BergiaSpecialZone");`
- *...oraz 30 innych węzłów ze skryptami.*

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
  - -> `[129]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The morning sunlight streamed through the windows as Lucian and I entered the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.YoungSords_Aids_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.YoungSords_Aids_Security == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.YoungSords_Aids_Security"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_ViolentSuppression = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_ViolentSuppression"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Security");)*
- **Efekt (`userScript`):** `PlayMusic("Security");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Deyr", "City_BergiaAutonomousZone");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Deyr","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Deyr", "City_BergiaSpecialZone");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Deyr","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Erzaren", "City_BergiaSpecialZone");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Uziren", "City_BergiaSpecialZone");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Uziren","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Ribel", "City_BergiaSpecialZone");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Ribel","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Sarna", "City_BergiaSpecialZone");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Sarna","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Erzaren", "City_BergiaAutonomousZone");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Erzaren","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Uziren", "City_BergiaAutonomousZone");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Uziren","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Ribel", "City_BergiaAutonomousZone");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Ribel","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Sarna", "City_BergiaAutonomousZone");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Deyr", "City_Political_USP");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Deyr","City_Political_USP");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Erzaren", "City_Political_WPB");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Erzaren","City_Political_WPB");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Uziren", "City_Political_WPB");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Uziren","City_Political_WPB");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Ribel", "City_Political_WPB");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Ribel","City_Political_WPB");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Sarna", "City_Political_WPB");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","City_Political_WPB");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[35]`
Mówca: **Narrator**
> "She poured me a cup with a smile, then took a look down at the folder in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Livia Suno**
> ""It looks like you have quite the packed agenda for today, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Livia Suno**
> ""I'm sorry again about the disturbance my indiscretion caused. I hope it didn't create too much extra work for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lucian's madcap accusations created the disturbance, not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It wasn't your fault. It was my lecher of a vice president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I do expect more professional behavior from you going forward, Ms. Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My work is none of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Livia Suno**
> ""You're absolutely right. My apologies, Mr. President. Enjoy your coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
Mówca: **Livia Suno**
> ""And you will get it, Mr. President. Enjoy your coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Livia Suno**
> ""Don't be too hard on Petr. I was as reckless as he was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Livia Suno**
> ""He did seem to be trying to protect you, in his own way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Narrator**
> "I walked over and poured myself a cup. I wondered when my new secretary would start work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `539` (*Sordland/Turn08/Internal Affairs Section with Lileas and Nia/Internal Affairs Section with Lileas and Nia Conversation*), Węzeł `[1]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Livia Suno");)*
- **Efekt (`userScript`):** `RemoveConversant("Livia Suno");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Narrator**
> "She walked out. I enjoyed a split second of solitude before the morning's first meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `539` (*Sordland/Turn08/Internal Affairs Section with Lileas and Nia/Internal Affairs Section with Lileas and Nia Conversation*), Węzeł `[1]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_AutonomousZoneOfBergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_AutonomousZoneOfBergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_AutonomousZoneOfBergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_SpecialZoneOfBergia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_SpecialZoneOfBergia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_SpecialZoneOfBergia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Bergia -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Bergia += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Bergia >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Bergia >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy_Bergia"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy_Bergia >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy_Bergia"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Bergia >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Bergia >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy_Bergia"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy_Bergia >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy_Bergia"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy_Gruni"] >= 2  and  (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy_Gruni"] >= 2  and  (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy_Gruni"] >= 1  and (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization"] == true   or Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy_Gruni"] >= 1  and (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization"] == true   or Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy_Gruni"] >= 1  and  (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy_Gruni"] >= 1  and  (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy_Gruni"] >= 1  and (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization"] == true   or Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy_Gruni"] >= 1  and (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization"] == true   or Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_IncreasedEducationFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_IncreasedEducationFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_IncreasedEducationFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Welfare_IncreasedEducationFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_IncreasedEducationFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;
BaseGame.Economy_Gruni += 1;
BaseGame.Economy_Bergia += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;
Variable["BaseGame.Economy_Gruni"] = Variable["BaseGame.Economy_Gruni"] + 1;
Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucian Galade");)*
- **Efekt (`userScript`):** `AddConversant("Lucian Galade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[86]`
Mówca: **Narrator**
> "I sat down. Lucian remained standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""I'm afraid I won't be able to join for your meetings today, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""The business surrounding the Livia Suno affair is taking up all of my time at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""The Livia Suno affair has left me with much to catch up on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false &&
(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) 
&& 
(BaseGame.Turn08_Dictator_Success == false && BaseGame.Turn08_Reformist_Success == false) 
&& 
(BaseGame.Reform_VoteCount_USP_GloriasWing <= 3 && BaseGame.Reform_VoteCount_USP_AlbinsWing <= 2))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false &&
(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) 
&& 
(BaseGame.Turn08_Dictator_Success == false && BaseGame.Turn08_Reformist_Success == false) 
&& 
(BaseGame.Reform_VoteCount_USP_GloriasWing <= 3 && BaseGame.Reform_VoteCount_USP_AlbinsWing <= 2))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false  and 
(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) 
 and  
(Variable["BaseGame.Turn08_Dictator_Success"] == false  and  Variable["BaseGame.Turn08_Reformist_Success"] == false) 
 and  
(Variable["BaseGame.Reform_VoteCount_USP_GloriasWing"] <= 3  and  Variable["BaseGame.Reform_VoteCount_USP_AlbinsWing"] <= 2)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == false &&
(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) 
&& 
(BaseGame.Turn08_Dictator_Success == false && BaseGame.Turn08_Reformist_Success == false) 
&& 
(BaseGame.Reform_VoteCount_USP_GloriasWing <= 3 && BaseGame.Reform_VoteCount_USP_AlbinsWing <= 2)
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false  and 
(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) 
 and  
(Variable["BaseGame.Turn08_Dictator_Success"] == false  and  Variable["BaseGame.Turn08_Reformist_Success"] == false) 
 and  
(Variable["BaseGame.Reform_VoteCount_USP_GloriasWing"] <= 3  and  Variable["BaseGame.Reform_VoteCount_USP_AlbinsWing"] <= 2)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_USP_Obstructionist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_AgainstProposal == true || (BaseGame.Reform_Autocrat_Abandon == true || BaseGame.Reform_Autocrat_Path == true && BaseGame.Reform_Autocrat_CourtVote_Success == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_AgainstProposal == true || (BaseGame.Reform_Autocrat_Abandon == true || BaseGame.Reform_Autocrat_Path == true && BaseGame.Reform_Autocrat_CourtVote_Success == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_USP_AgainstProposal"] == true  or  (Variable["BaseGame.Reform_Autocrat_Abandon"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_USP_AgainstProposal == true || (BaseGame.Reform_Autocrat_Abandon == true || BaseGame.Reform_Autocrat_Path == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_USP_AgainstProposal"] == true  or  (Variable["BaseGame.Reform_Autocrat_Abandon"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_USP_Obstructionist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""But I did want to give you a quick word of warning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""I have noticed that the USP faction in the Assembly has adopted a confrontational stance of late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""Their displeasure with you has led them to engage in obstructionist tactics, slowing down policy implementation and creating legislative gridlock.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[106]`
  - -> `[108]`
  - -> `[109]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So... what does that actually mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Damn. I really have turned into the next Alphonso, haven't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll show them what happens when you get in the way of Anton Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Blocking progress for the country because of their petty disagreements with me. I hope they're happy with themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""It means we will have a significantly harder time following through with our plans for this portion of the term, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""It won't be easy to get past this, I'm afraid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""The Assembly did employ similar tactics to block your predecessor's reforms, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Lucian Galade**
> ""It is my hope that we're still able to follow through on some of our plans for this term. But it won't be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Narrator**
> "He dropped a thick folder in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
> ""I was hoping to go over the day's agenda with you before your cabinet members began arriving. But duty calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Narrator**
> "He walked out. Almost immediately, as if she'd been waiting for him to leave, Livia entered with a carafe of coffee,"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucian Galade");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucian Galade");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == false && BaseGame.Turn08_SecondScandal_Detained_Livia == false && BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == false && BaseGame.Turn08_SecondScandal_LiviaFired == false && BaseGame.Turn08_SecondScandal_LiviaTrialled == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == false && BaseGame.Turn08_SecondScandal_Detained_Livia == false && BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == false && BaseGame.Turn08_SecondScandal_LiviaFired == false && BaseGame.Turn08_SecondScandal_LiviaTrialled == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == false  and  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == false && BaseGame.Turn08_SecondScandal_Detained_Livia == false && BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == false && BaseGame.Turn08_SecondScandal_LiviaFired == false && BaseGame.Turn08_SecondScandal_LiviaTrialled == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == false  and  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Livia Suno");)*
- **Efekt (`userScript`):** `AddConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[122]`
Mówca: **Narrator**
> "He walked out. I took a look at the folder in front of me, then at the coffee carafe in the corner of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Turn08_LT_FCAnricaPromisingSeason_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Turn08_LT_FCAnricaPromisingSeason_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_G_UCSatelliteUncovers = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_G_UCSatelliteUncovers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_CSPInfluenceGrows = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_CSPInfluenceGrows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Valgsland_Alliance == true && BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Valgsland_Alliance == true && BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true  and  Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true && BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true  and  Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Receiving a critical briefing on the latest developments", "Maroon Palace", "Holsord");)*
- **Efekt (`userScript`):** `SetRichPresence("Receiving a critical briefing on the latest developments","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_ATOInfluenceGrows = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_ATOInfluenceGrows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (BaseGame.Archetype_CapitalistRayne == true || BaseGame.Archetype_DemocraticRayne == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (BaseGame.Archetype_CapitalistRayne == true || BaseGame.Archetype_DemocraticRayne == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  and  (Variable["BaseGame.Archetype_CapitalistRayne"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (BaseGame.Archetype_CapitalistRayne == true || BaseGame.Archetype_DemocraticRayne == true) ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  and  (Variable["BaseGame.Archetype_CapitalistRayne"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
