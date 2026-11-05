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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[38]` | **""Lucian's madcap accusations created the disturbance, not you.""** | `[37]` **Livia Suno**: ""I'm sorry again about the distu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Livia Suno**: ""He did seem to be trying to pro..." |
| `[39]` | **""It wasn't your fault. It was my lecher of a vice president.""** | `[37]` **Livia Suno**: ""I'm sorry again about the distu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Livia Suno**: ""Don't be too hard on Petr. I wa..." |
| `[40]` | **""I do expect more professional behavior from you going forward, Ms. Suno.""** | `[37]` **Livia Suno**: ""I'm sorry again about the distu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Livia Suno**: ""And you will get it, Mr. Presid..." |
| `[41]` | **""My work is none of your business.""** | `[37]` **Livia Suno**: ""I'm sorry again about the distu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Livia Suno**: ""You're absolutely right. My apo..." |
| `[106]` | **""So... what does that actually mean?""** | `[105]` **Lucian Galade**: ""Their displeasure with you has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Lucian Galade**: ""It means we will have a signifi..." |
| `[107]` | **""Damn. I really have turned into the next Alphonso, haven't I?""** | `[105]` **Lucian Galade**: ""Their displeasure with you has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lucian Galade**: ""The Assembly did employ similar..." |
| `[108]` | **""I'll show them what happens when you get in the way of Anton Rayne.""** | `[105]` **Lucian Galade**: ""Their displeasure with you has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Lucian Galade**: ""It won't be easy to get past th..." |
| `[109]` | **""Blocking progress for the country because of their petty disagreements with me. I..."** | `[105]` **Lucian Galade**: ""Their displeasure with you has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Lucian Galade**: ""It is my hope that we're still ..." |

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
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Receiving a critical briefing on the lat..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The morning sunlight streamed through the windows as Lucian and I entered the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "I sat down. Lucian remained standing."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.YoungSords_Aids_Security == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.YoungSords_Aids_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_ViolentSuppression = true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.YoungSords_Aids_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.YoungSords_Aids_Security"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false && (BaseGame.R..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_ViolentSuppression = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_ViolentSuppression"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false && (BaseGame.R..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Security");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Security");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Deyr", "City_BergiaSpeci..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Deyr", "City_BergiaAutonomousZone");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Deyr","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Erzaren", "City_BergiaAuton..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Deyr", "City_BergiaSpecialZone");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Deyr","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erzaren", "City_BergiaSp..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erzaren", "City_BergiaSpecialZone");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Uziren", "City_BergiaSpe..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Uziren", "City_BergiaSpecialZone");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Uziren","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Ribel", "City_BergiaSpec..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Ribel", "City_BergiaSpecialZone");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Ribel","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Sarna", "City_BergiaSpec..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Sarna", "City_BergiaSpecialZone");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Sarna","City_BergiaSpecialZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Deyr", "City_BergiaAutonomo..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == false"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Erzaren", "City_BergiaAutonomousZone");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Erzaren","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Uziren", "City_BergiaAutono..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Uziren", "City_BergiaAutonomousZone");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Uziren","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Ribel", "City_BergiaAutonom..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Ribel", "City_BergiaAutonomousZone");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Ribel","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Sarna", "City_BergiaAutonom..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Sarna", "City_BergiaAutonomousZone");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","City_BergiaAutonomousZone");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == false"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Deyr", "City_Political_USP");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Deyr","City_Political_USP");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Erzaren", "City_Political_W..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Erzaren", "City_Political_WPB");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Erzaren","City_Political_WPB");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Uziren", "City_Political_WP..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Uziren", "City_Political_WPB");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Uziren","City_Political_WPB");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Ribel", "City_Political_WPB");"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Ribel", "City_Political_WPB");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Ribel","City_Political_WPB");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Sarna", "City_Political_WPB");"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Sarna", "City_Political_WPB");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","City_Political_WPB");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == false"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == fa..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Deyr", "City_Political_USP");"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_AutonomousZoneOfBergia == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[35]`
Mówca: **Narrator**
> "She poured me a cup with a smile, then took a look down at the folder in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Livia Suno: ""It looks like you have quite the packed agenda for today..."*)

### Węzeł `[36]`
Mówca: **Livia Suno**
> ""It looks like you have quite the packed agenda for today, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Livia Suno: ""I'm sorry again about the disturbance my indiscretion ca..."*)

### Węzeł `[37]`
Mówca: **Livia Suno**
> ""I'm sorry again about the disturbance my indiscretion caused. I hope it didn't create too much extra work for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""Lucian's madcap accusations created the disturbance, not..."*)
  - -> `[39]` (*Player: ""It wasn't your fault. It was my lecher of a vice preside..."*)
  - -> `[40]` (*Player: ""I do expect more professional behavior from you going fo..."*)
  - -> `[41]` (*Player: ""My work is none of your business.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lucian's madcap accusations created the disturbance, not you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Livia Suno: ""He did seem to be trying to protect you, in his own way.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It wasn't your fault. It was my lecher of a vice president.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Livia Suno: ""Don't be too hard on Petr. I was as reckless as he was.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I do expect more professional behavior from you going forward, Ms. Suno.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Livia Suno: ""And you will get it, Mr. President. Enjoy your coffee.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My work is none of your business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Livia Suno: ""You're absolutely right. My apologies, Mr. President. En..."*)

### Węzeł `[42]`
Mówca: **Livia Suno**
> ""You're absolutely right. My apologies, Mr. President. Enjoy your coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Livia Suno");"*)

### Węzeł `[43]`
Mówca: **Livia Suno**
> ""And you will get it, Mr. President. Enjoy your coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Livia Suno");"*)

### Węzeł `[44]`
Mówca: **Livia Suno**
> ""Don't be too hard on Petr. I was as reckless as he was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Livia Suno");"*)

### Węzeł `[45]`
Mówca: **Livia Suno**
> ""He did seem to be trying to protect you, in his own way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Livia Suno");"*)

### Węzeł `[46]`
Mówca: **Narrator**
> "I walked over and poured myself a cup. I wondered when my new secretary would start work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Livia Suno");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Livia Suno");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "She walked out. I enjoyed a split second of solitude befo..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "She walked out. I enjoyed a split second of solitude before the morning's first meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_AutonomousZoneOfBergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_AutonomousZoneOfBergia == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_AutonomousZoneOfBergia == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_AutonomousZoneOfBergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Bergia -= 1"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_AutonomousZoneOfBergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_SpecialZoneOfBergia == false"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_SpecialZoneOfBergia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_SpecialZoneOfBergia == false"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_SpecialZoneOfBergia == false)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_SpecialZoneOfBergia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Bergia += 1"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_SpecialZoneOfBergia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Bergia -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Bergia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Bergia >= 2"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Bergia >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Bergia >= 2"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy_Bergia >= 2)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Bergia >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy_Bergia"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn04_..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy_Bergia >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy_Bergia"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Bergia >= 1"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Bergia >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Bergia >= 1"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy_Bergia >= 1)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Bergia >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy_Bergia"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn04_..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy_Bergia >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy_Bergia"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn04_..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn0..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy_Gruni"] >= 2  and  (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 2"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy_Gruni >= 2 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy_Gruni"] >= 2  and  (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_G..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_G..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy_Gruni"] >= 1  and (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization"] == true   or Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy_Gruni"] >= 1  and (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization"] == true   or Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_IncreasedEducationFunding == true"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy =..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn04_..."*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn0..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy_Gruni"] >= 1  and  (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy_Gruni >= 1 && (BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy_Gruni"] >= 1  and  (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedFarmExpansions"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_G..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_G..."*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy_Gruni"] >= 1  and (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization"] == true   or Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_IncreasedEducationFunding == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy_Gruni >= 1 &&(BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization == true  ||BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Bill_Turn03_GruniRegeneration_Signed == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy_Gruni"] >= 1  and (Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedMechanization"] == true   or Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Bill_Turn03_GruniRegeneration_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy =..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy =..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_IncreasedEducationFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_IncreasedEducationFunding == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Welfare_IncreasedEducationFunding == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_IncreasedEducationFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_IncreasedEducationFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1; BaseGame.Economy_Gruni += 1; BaseG..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Welfare_IncreasedEducationFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_IncreasedEducationFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;
BaseGame.Economy_Gruni += 1;
BaseGame.Economy_Bergia += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;
Variable["BaseGame.Economy_Gruni"] = Variable["BaseGame.Economy_Gruni"] + 1;
Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Valgen_GruniBergiaSynergy =..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucian Galade");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucian Galade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The morning sunlight streamed through the windows as Luci..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "I sat down. Lucian remained standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""I'm afraid I won't be able to join for your meetings tod..."*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""I'm afraid I won't be able to join for your meetings today, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaInvestigated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaInvestigated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""The business surrounding the Livia Suno affair is taking..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""The Livia Suno affair has left me with much to catch up ..."*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""The business surrounding the Livia Suno affair is taking up all of my time at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""The Livia Suno affair has left me with much to catch up on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == false &&
(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) 
&& 
(BaseGame.Turn08_Dictator_Success == false && BaseGame.Turn08_Reformist_Success == false) 
&& 
(BaseGame.Reform_VoteCount_USP_GloriasWing <= 3 && BaseGame.Reform_VoteCount_USP_AlbinsWing <= 2)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false && (BaseGame.R..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == false && (BaseGame..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == false &&
(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) 
&& 
(BaseGame.Turn08_Dictator_Success == false && BaseGame.Turn08_Reformist_Success == false) 
&& 
(BaseGame.Reform_VoteCount_USP_GloriasWing <= 3 && BaseGame.Reform_VoteCount_USP_AlbinsWing <= 2)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false  and 
(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) 
 and  
(Variable["BaseGame.Turn08_Dictator_Success"] == false  and  Variable["BaseGame.Turn08_Reformist_Success"] == false) 
 and  
(Variable["BaseGame.Reform_VoteCount_USP_GloriasWing"] <= 3  and  Variable["BaseGame.Reform_VoteCount_USP_AlbinsWing"] <= 2)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist = true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == false &&
(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) 
&& 
(BaseGame.Turn08_Dictator_Success == false && BaseGame.Turn08_Reformist_Success == false) 
&& 
(BaseGame.Reform_VoteCount_USP_GloriasWing <= 3 && BaseGame.Reform_VoteCount_USP_AlbinsWing <= 2)
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false  and 
(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) 
 and  
(Variable["BaseGame.Turn08_Dictator_Success"] == false  and  Variable["BaseGame.Turn08_Reformist_Success"] == false) 
 and  
(Variable["BaseGame.Reform_VoteCount_USP_GloriasWing"] <= 3  and  Variable["BaseGame.Reform_VoteCount_USP_AlbinsWing"] <= 2)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_AgainstProposal == true || (BaseGame..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_USP_Obstructionist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucian Galade");"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_AgainstProposal == true || (BaseGame.Reform_Autocrat_Abandon == true || BaseGame.Reform_Autocrat_Path == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_AgainstProposal == true || (BaseGame..."*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_USP_AgainstProposal == true || (BaseGa..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_AgainstProposal == true || (BaseGame.Reform_Autocrat_Abandon == true || BaseGame.Reform_Autocrat_Path == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_USP_AgainstProposal"] == true  or  (Variable["BaseGame.Reform_Autocrat_Abandon"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist = true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_USP_AgainstProposal == true || (BaseGame.Reform_Autocrat_Abandon == true || BaseGame.Reform_Autocrat_Path == true && BaseGame.Reform_Autocrat_CourtVote_Success == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_USP_AgainstProposal"] == true  or  (Variable["BaseGame.Reform_Autocrat_Abandon"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucian Galade");"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_USP_Obstructionist == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""But I did want to give you a quick word of warning.""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_USP_Obstructionist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "He dropped a thick folder in front of me."*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""But I did want to give you a quick word of warning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: ""I have noticed that the USP faction in the Assembly has ..."*)

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""I have noticed that the USP faction in the Assembly has adopted a confrontational stance of late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""Their displeasure with you has led them to engage in obs..."*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""Their displeasure with you has led them to engage in obstructionist tactics, slowing down policy implementation and creating legislative gridlock.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: ""Damn. I really have turned into the next Alphonso, haven..."*)
  - -> `[106]` (*Player: ""So... what does that actually mean?""*)
  - -> `[108]` (*Player: ""I'll show them what happens when you get in the way of A..."*)
  - -> `[109]` (*Player: ""Blocking progress for the country because of their petty..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So... what does that actually mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: ""It means we will have a significantly harder time follow..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Damn. I really have turned into the next Alphonso, haven't I?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: ""The Assembly did employ similar tactics to block your pr..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll show them what happens when you get in the way of Anton Rayne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucian Galade: ""It won't be easy to get past this, I'm afraid."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Blocking progress for the country because of their petty disagreements with me. I hope they're happy with themselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lucian Galade: ""It is my hope that we're still able to follow through on..."*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""It means we will have a significantly harder time following through with our plans for this portion of the term, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "He dropped a thick folder in front of me."*)

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""It won't be easy to get past this, I'm afraid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "He dropped a thick folder in front of me."*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""The Assembly did employ similar tactics to block your predecessor's reforms, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "He dropped a thick folder in front of me."*)

### Węzeł `[113]`
Mówca: **Lucian Galade**
> ""It is my hope that we're still able to follow through on some of our plans for this term. But it won't be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "He dropped a thick folder in front of me."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "He dropped a thick folder in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: ""I was hoping to go over the day's agenda with you before..."*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> ""I was hoping to go over the day's agenda with you before your cabinet members began arriving. But duty calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucian Galade");"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "He walked out. Almost immediately, as if she'd been waiting for him to leave, Livia entered with a carafe of coffee,"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "AddConversant("Livia Suno");"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucian Galade");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucian Galade");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == false && BaseGame.Turn08_SecondScandal_Detained_Livia == false && BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == false && BaseGame.Turn08_SecondScandal_LiviaFired == false && BaseGame.Turn08_SecondScandal_LiviaTrialled == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia =..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == false && BaseGame.Turn08_SecondScandal_Detained_Livia == false && BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == false && BaseGame.Turn08_SecondScandal_LiviaFired == false && BaseGame.Turn08_SecondScandal_LiviaTrialled == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == false  and  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "He walked out. Almost immediately, as if she'd been waiti..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == false && BaseGame.Turn08_SecondScandal_Detained_Livia == false && BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == false && BaseGame.Turn08_SecondScandal_LiviaFired == false && BaseGame.Turn08_SecondScandal_LiviaTrialled == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == false  and  Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == false  and  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "He walked out. I took a look at the folder in front of me..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Livia Suno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "She poured me a cup with a smile, then took a look down a..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "He walked out. I took a look at the folder in front of me, then at the coffee carafe in the corner of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I walked over and poured myself a cup. I wondered when my..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Turn08_LT_FCAnricaPromisingSeason_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Turn08_LT_FCAnricaPromisingSeason_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Security");"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_G_UCSatelliteUncovers = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_G_UCSatelliteUncovers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Turn08_LT_FCAnricaPromisingSeason_Default..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_CSPInfluenceGrows = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_CSPInfluenceGrows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Valgsland_Alliance == true && BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Valgsland_Alliance == true && B..."*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true &&..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Valgsland_Alliance == true && BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true  and  Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_CSPInfluenceGrows =..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true && BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true  and  Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (Bas..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Receiving a critical briefing on the latest developments", "Maroon Palace", "Holsord");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Receiving a critical briefing on the latest developments","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_G_UCSatelliteUncovers = true;"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_ATOInfluenceGrows = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_ATOInfluenceGrows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (BaseGame.Archetype_CapitalistRayne == true || BaseGame.Archetype_DemocraticRayne == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (Bas..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (B..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (BaseGame.Archetype_CapitalistRayne == true || BaseGame.Archetype_DemocraticRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  and  (Variable["BaseGame.Archetype_CapitalistRayne"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_ATOInfluenceGrows =..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Lespia_Alliance == true && (BaseGame.Archetype_CapitalistRayne == true || BaseGame.Archetype_DemocraticRayne == true) )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  and  (Variable["BaseGame.Archetype_CapitalistRayne"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "End();"*)
