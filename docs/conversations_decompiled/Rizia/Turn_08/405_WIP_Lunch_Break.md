# Rizia/Turn 8/WIP_Lunch Break

- **ID konwersacji:** `405`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/405_WIP_Lunch_Break.md`
- **Liczba węzłów dialogowych:** 193
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[84]** Deivid Wisci (R)
- **[95]** Player_Romus *(Gracz)*
- **[96]** Anton Rayne (R)

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_DemocraticRayne`
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.Decision_Turn08_ExtendEmergency_DontExtend`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Policy_Diplomacy_ATO`
- `BaseGame.Policy_Diplomacy_CSP`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn09_EnT_GDPMaintained`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `RiziaDLC.CountryRelation_Rumburg_Allied`
- `RiziaDLC.CountryRelation_Rumburg_Unfriendly`
- `RiziaDLC.CountryRelation_Sordland_Allied`
- `RiziaDLC.CountryRelation_Sordland_Friendly`
- `RiziaDLC.CountryRelation_Sordland_Hostile`
- `RiziaDLC.CountryRelation_Sordland_Neutral`
- `RiziaDLC.CountryRelation_Sordland_Unfriendly`
- `RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought`
- `RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought`
- `RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice`
- `RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite`
- `RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent`
- `RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy`
- `RiziaDLC.Situation_Diplomacy_ANSanctions_Weak`
- `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol`
- `RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Sordland_RiziaSanction_Aye`
- `RiziaDLC.Sordland_ZilleReferendum_Aye`
- `RiziaDLC.Turn04_SordlandBond_LargeInvestment`
- `RiziaDLC.Turn04_SordlandBond_SmallInvestment`
- `RiziaDLC.ZilleReferendum_StoppedByAN`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[12]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[148]` | **""Minister Wisci, President Rayne, it's an honor.""** | `[150]` **Anton Rayne (R)**: ""Your Majesty, it's a pleasure. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Laurento Esquibel**: ""Very glad we ran into each othe..." |
| `[149]` | **""Pleasure to meet you both.""** | `[150]` **Anton Rayne (R)**: ""Your Majesty, it's a pleasure. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Laurento Esquibel**: ""Very glad we ran into each othe..." |
| `[151]` | **""President Rayne, Minister Wisci, welcome. Let's hope our chat is more satisfying ..."** | `[150]` **Anton Rayne (R)**: ""Your Majesty, it's a pleasure. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Laurento Esquibel**: ""Very glad we ran into each othe..." |
| `[156]` | **""One can only hope, President Rayne. The stakes at the general assembly are certai..."** | `[155]` **Anton Rayne (R)**: ""It seems we're all victims of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Anton Rayne (R)**: ""Absolutely, King Romus. Yet, so..." |
| `[157]` | **""Indeed, President Rayne. If the general assembly is as varied and unpredictable a..."** | `[155]` **Anton Rayne (R)**: ""It seems we're all victims of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Anton Rayne (R)**: ""An interesting analogy. Much li..." |
| `[158]` | **""They might need some Rizian chefs here, or maybe Sordish ones. Our cuisines do ha..."** | `[155]` **Anton Rayne (R)**: ""It seems we're all victims of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Anton Rayne (R)**: ""Don't forget the delights of So..." |
| `[159]` | **""We had much more important things than some food talk I think.""** | `[155]` **Anton Rayne (R)**: ""It seems we're all victims of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Anton Rayne (R)**: ""Direct and to the point, Your M..." |
| `[165]` | **""Svabli, you say? I must admit, my experience with Sordish cuisine is limited, but..."** | `[162]` **Anton Rayne (R)**: ""Don't forget the delights of So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[166]` | **""Svabli... I've heard of it but never had the pleasure. It seems our diplomatic me..."** | `[162]` **Anton Rayne (R)**: ""Don't forget the delights of So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[167]` | **""I haven't tried Svabli yet, President Rayne. But it's always fascinating to talk ..."** | `[162]` **Anton Rayne (R)**: ""Don't forget the delights of So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[168]` | **""Traditional Sordish stew? I like the blend of various elements, each adding its o..."** | `[164]` **Anton Rayne (R)**: ""An interesting analogy. Much li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[169]` | **""Your stew analogy is quite fitting. It's about harmony among different ingredients.""** | `[164]` **Anton Rayne (R)**: ""An interesting analogy. Much li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[170]` | **""I like the sound of that stew – it's a reminder that something greater than the s..."** | `[164]` **Anton Rayne (R)**: ""An interesting analogy. Much li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[171]` | **""What is Zabla made of? I'm curious.""** | `[163]` **Anton Rayne (R)**: ""Absolutely, King Romus. Yet, so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[172]` | **""Zabla's simplicity yet underlying complexity is intriguing. It's a bit like our R..."** | `[163]` **Anton Rayne (R)**: ""Absolutely, King Romus. Yet, so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[173]` | **""The Zabla analogy is thought-provoking. Never knew you cared so much about dishes..."** | `[163]` **Anton Rayne (R)**: ""Absolutely, King Romus. Yet, so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |

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
  - -> `[7]` (*Narrator: "We made our way to the restaurant."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!()"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!()`
- **Warunek bezpośredni (`conditionsString`):** `false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[7]`
Mówca: **Narrator**
> "We made our way to the restaurant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "As Laurento and I were debating the merits of the pasta s..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Anton Rayne (R): "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
Mówca: **Deivid Wisci (R)**
> ""King Romus, what an honor to meet you. I'm Deivid Wisci, Foreign Minister of Sordland. Allow me to introduce President Anton Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Anton Rayne (R): ""Your Majesty, it's a pleasure. And Minister Wisci is too..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Laurento Esquibel: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ==..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Allied == true || RiziaDLC.Policy_Diplomacy_GRACEMember == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Allied == true || RiziaD..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Rumburg_Allied == true || Rizi..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Allied == true || RiziaDLC.Policy_Diplomacy_GRACEMember == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Allied"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Rumburg_Allied == true || RiziaDLC.Policy_Diplomacy_GRACEMember == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Allied"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Rumburg_Unfriendly == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Rumburg_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn04_SordlandBond_LargeInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn04_SordlandBond_LargeInvestment == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn04_SordlandBond_LargeInvestment == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn04_SordlandBond_LargeInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn04_SordlandBond_LargeInvestment"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn04_SordlandBond_LargeInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn04_SordlandBond_LargeInvestment"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn04_SordlandBond_SmallInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn04_SordlandBond_SmallInvestment == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn04_SordlandBond_SmallInvestment == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn04_SordlandBond_SmallInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn04_SordlandBond_SmallInvestment"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn04_SordlandBond_SmallInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn04_SordlandBond_SmallInvestment"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBou..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeB..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBou..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeB..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJusti..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite ==..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent =..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_CapitalistRayne == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_CapitalistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_DemocraticRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_DemocraticRayne == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_DemocraticRayne == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_DemocraticRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_DemocraticRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_DemocraticRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_DontExtend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_DontExtend == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_DontExtend == ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_DontExtend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_DontExtend"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_DontExtend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_DontExtend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingRumburg == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishRecovery == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_GDPMaintained == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_GDPMaintained == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_GDPMaintained == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_GDPMaintained == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_GDPMaintained"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_GDPMaintained == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_GDPMaintained"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_ATO == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_ATO == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_ATO"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_ATO"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_CSP == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_ANSanctions_Weak"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_ANSanctions_Weak"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol ..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtoco..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == t..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Valgsland_Alliance == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_CSP == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Friendly == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Sordland_Friendly == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Sordland_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Allied == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Sordland_Allied == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Allied"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Sordland_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Neutral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Neutral == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Sordland_Neutral == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Neutral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Neutral"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Sordland_Neutral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Neutral"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Unfriendly == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Sordland_Unfriendly == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Unfriendly"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Sordland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Unfriendly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Hostile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Hostile == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Sordland_Hostile == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Hostile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Hostile"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Sordland_Hostile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Hostile"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sordland_RiziaSanction_Aye == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sordland_RiziaSanction_Aye == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sordland_RiziaSanction_Aye == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sordland_RiziaSanction_Aye == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sordland_RiziaSanction_Aye"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sordland_RiziaSanction_Aye == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sordland_RiziaSanction_Aye"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sordland_ZilleReferendum_Aye == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sordland_ZilleReferendum_Aye == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sordland_ZilleReferendum_Aye == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sordland_ZilleReferendum_Aye == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sordland_ZilleReferendum_Aye"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sordland_ZilleReferendum_Aye == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sordland_ZilleReferendum_Aye"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_StoppedByAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_StoppedByAN == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_StoppedByAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_StoppedByAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[146]`
Mówca: **Narrator**
> "As Laurento and I were debating the merits of the pasta selection, a gentleman with a kindly demeanor approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Deivid Wisci (R): ""King Romus, what an honor to meet you. I'm Deivid Wisci,..."*)

### Węzeł `[147]`
Mówca: **Deivid Wisci (R)**
> ""A splendid idea, Laurento. Let's find a spot where we can talk more comfortably.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "We moved towards a quieter section of the room, finding a..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Minister Wisci, President Rayne, it's an honor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Anton Rayne (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Laurento Esquibel: ""Very glad we ran into each other. Always good to see you..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pleasure to meet you both.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Anton Rayne (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Laurento Esquibel: ""Very glad we ran into each other. Always good to see you..."*)

### Węzeł `[150]`
Mówca: **Anton Rayne (R)**
> ""Your Majesty, it's a pleasure. And Minister Wisci is too kind – the honor is mine. It's good to meet new faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""Minister Wisci, President Rayne, it's an honor.""*)
  - -> `[149]` (*Player_Romus: ""Pleasure to meet you both.""*)
  - -> `[151]` (*Player_Romus: ""President Rayne, Minister Wisci, welcome. Let's hope our..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""President Rayne, Minister Wisci, welcome. Let's hope our chat is more satisfying than the lunch selection.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Anton Rayne (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Laurento Esquibel: ""Very glad we ran into each other. Always good to see you..."*)

### Węzeł `[152]`
Mówca: **Laurento Esquibel**
> ""Minister Wisci, President Rayne, shall we take a seat? It might be more conducive for our discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Deivid Wisci (R): ""A splendid idea, Laurento. Let's find a spot where we ca..."*)

### Węzeł `[153]`
Mówca: **Laurento Esquibel**
> ""Very glad we ran into each other. Always good to see you Deivid and Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Laurento Esquibel: ""Minister Wisci, President Rayne, shall we take a seat? I..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "We moved towards a quieter section of the room, finding a round table that seemed perfect for a more intimate dialogue. We sat down and arranged our plates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Anton Rayne (R): ""It seems we're all victims of the culinary experiments a..."*)

### Węzeł `[155]`
Mówca: **Anton Rayne (R)**
> ""It seems we're all victims of the culinary experiments at this year's conference. I hope the AN general assembly coming up soon will have a better offering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player_Romus: ""One can only hope, President Rayne. The stakes at the ge..."*)
  - -> `[157]` (*Player_Romus: ""Indeed, President Rayne. If the general assembly is as v..."*)
  - -> `[158]` (*Player_Romus: ""They might need some Rizian chefs here, or maybe Sordish..."*)
  - -> `[159]` (*Player_Romus: ""We had much more important things than some food talk I ..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One can only hope, President Rayne. The stakes at the general assembly are certainly higher than our lunch choices here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Anton Rayne (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Anton Rayne (R): ""Absolutely, King Romus. Yet, sometimes, these small talk..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, President Rayne. If the general assembly is as varied and unpredictable as this buffet, we're in for an interesting time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Anton Rayne (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Anton Rayne (R): ""An interesting analogy. Much like our traditional Sordis..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They might need some Rizian chefs here, or maybe Sordish ones. Our cuisines do have a reputation for excellence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Anton Rayne (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Anton Rayne (R): ""Don't forget the delights of Sordish cuisine, Your Majes..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had much more important things than some food talk I think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Anton Rayne (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Anton Rayne (R): ""Direct and to the point, Your Majesty. I appreciate that.""*)

### Węzeł `[160]`
Mówca: **Anton Rayne (R)**
> ""Direct and to the point, Your Majesty. I appreciate that.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[161]`
Mówca: **Narrator**
> "We moved towards a quieter section of the room, finding a round table that seemed perfect for a more intimate dialogue. As we sat down, arranging our plates, President Rayne casually addressed the group, lightening the mood."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
Mówca: **Anton Rayne (R)**
> ""Don't forget the delights of Sordish cuisine, Your Majesty. Have you ever tried Svabli? It's a Holsord specialty - sheep cheese like you've never tasted it before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""Svabli, you say? I must admit, my experience with Sordis..."*)
  - -> `[166]` (*Player_Romus: ""Svabli... I've heard of it but never had the pleasure. I..."*)
  - -> `[167]` (*Player_Romus: ""I haven't tried Svabli yet, President Rayne. But it's al..."*)

### Węzeł `[163]`
Mówca: **Anton Rayne (R)**
> ""Absolutely, King Romus. Yet, sometimes, these small talks can be a prelude to greater discussions. Like our Zabla back in Bergia, simple on the surface but complex beneath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""What is Zabla made of? I'm curious.""*)
  - -> `[172]` (*Player_Romus: ""Zabla's simplicity yet underlying complexity is intrigui..."*)
  - -> `[173]` (*Player_Romus: ""The Zabla analogy is thought-provoking. Never knew you c..."*)

### Węzeł `[164]`
Mówca: **Anton Rayne (R)**
> ""An interesting analogy. Much like our traditional Sordish stew, I suppose. Simple ingredients coming together to create something substantial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player_Romus: ""Traditional Sordish stew? I like the blend of various el..."*)
  - -> `[169]` (*Player_Romus: ""Your stew analogy is quite fitting. It's about harmony a..."*)
  - -> `[170]` (*Player_Romus: ""I like the sound of that stew – it's a reminder that som..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Svabli, you say? I must admit, my experience with Sordish cuisine is limited, but I'm always open to new culinary adventures.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Svabli... I've heard of it but never had the pleasure. It seems our diplomatic meetings could benefit from a taste of Sordland's finest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't tried Svabli yet, President Rayne. But it's always fascinating to talk to a food afficionado.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Traditional Sordish stew? I like the blend of various elements, each adding its own unique flavor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your stew analogy is quite fitting. It's about harmony among different ingredients.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like the sound of that stew – it's a reminder that something greater than the sum of its parts can emerge from simple beginnings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is Zabla made of? I'm curious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zabla's simplicity yet underlying complexity is intriguing. It's a bit like our Rizetta, a breakfast dish that seems simple but offers a depth of flavors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Zabla analogy is thought-provoking. Never knew you cared so much about dishes, isn't Lespia the big culinary nation in East Merkopa?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Anton Rayne (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[174]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[175]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[176]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[178]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
Mówca: **Anton Rayne (R)**
> ""Oh it is super tasty, much better than the pasta we are having here today.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
Mówca: **Anton Rayne (R)**
> ""I will see to it that you do next time you visit.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[182]`
Mówca: **Anton Rayne (R)**
> ""Food reflects a nation's culture – robust and full of character, much like Sordland itself.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
Mówca: **Laurento Esquibel**
> ""I think we can gather for culinary debates at another occassion, timing and proportion are critical. It's not just what we bring to the table, but how and when we present it.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
