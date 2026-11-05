# Sordland/Turn10/Economy

- **ID konwersacji:** `233`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/233_Economy.md`
- **Liczba węzłów dialogowych:** 212
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[12]** Moderator
- **[15]** Mansoun Leke
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Bill_Turn08_TobaccoTax_Signed`
- `BaseGame.Bill_Turn09_AlcoholTax_Signed`
- `BaseGame.Bill_Turn09_FreeTransportation_Signed`
- `BaseGame.Bill_Turn09_LuxuryTax_Signed`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.EconomicDirection_Privatization`
- `BaseGame.EconomicDirection_StatusQuo`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Faction_Oligarchs_Destroyed`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Economy_IncreasedTaxCorps`
- `BaseGame.Policy_Economy_MarketEconomy`
- `BaseGame.Policy_Economy_MixedEconomy`
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Relations_Walter_Enemy`
- `BaseGame.Situation_Welfare_FreeMedicine`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGameIsolated.Debate_BasicIncomePromise`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameIsolated.Debate_NuclearPromise`
- `BaseGameIsolated.Debate_SpacePromise`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[234] Sordland/Turn10/Foreign Policy** (../Turn_10/234_Foreign_Policy.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[19]` | **""The depression was the exclusive fault of my former economic advisor Symon Holl. ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[20]` | **""I promise I will aid Sordish workers affected by the depression.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[21]` | **""Slowly but surely, I am lifting Sordland to economic greatness.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[22]` | **""Why fix what's not broken? As long as I remain president, Sordland will never see..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[23]` | **""My recovery was just the beginning. If I stay president, Sordland will become one..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[24]` | **""The threat of recession is over, but I will not rest until every Sord can enjoy t..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[25]` | **""I'm doing the best I can given how badly my predecessors screwed up. We're not in..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[117]` | **""The Oligarchs are no threat anymore. I saw to that.""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true` | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[118]` | **""The Oligarchs do more for Sordland than you ever will.""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Faction_Oligarchs_Content"] == true`<br>`(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true) == false`<br>`(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false` | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[119]` | **""The Oligarchs are the engine that keeps our economy running.""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true) == false`<br>`(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false` | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[120]` | **""They're gone, remember? Prison, et cetera...?""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true` | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[124]` | **""Marcel Koronti has done more for Sordland than you ever will.""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Killed_MarcelKoronti"] == false`<br>`Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true`<br>`(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false` | *Brak zmian stanu* | `[133]` **Narrator**: "The moderator cleared her throat." |
| `[125]` | **""Marcel isn't so bad...""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Killed_MarcelKoronti"] == false`<br>`Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true`<br>`(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false` | *Brak zmian stanu* | `[133]` **Narrator**: "The moderator cleared her throat." |
| `[129]` | **""Walter Tusk has done more for Sordland than you ever will.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[130]` | **""Walter isn't so bad...""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[131]` | **""I agree. They must be stopped.""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true) == false`<br>`(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false` | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[132]` | **"Say nothing."** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[141]` | **""As I said earlier, my plan for a guaranteed living wage for everyone will lead to..."** | `[137]` **Moderator**: ""Mr. President, would you care t..." | `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true` | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[145]` | **""As I said earlier, my plan for a nuclear program will lead to unprecedented prosp..."** | `[137]` **Moderator**: ""Mr. President, would you care t..." | `Variable["BaseGameIsolated.Debate_NuclearPromise"] == true`<br>`(Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true) == false` | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[146]` | **""As I said earlier, my plan for a space program will lead to unprecedented prosper..."** | `[137]` **Moderator**: ""Mr. President, would you care t..." | `Variable["BaseGameIsolated.Debate_SpacePromise"] == true`<br>`(Variable["BaseGameIsolated.Debate_NuclearPromise"] == true) == false`<br>`(Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true) == false` | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[150]` | **""Just trust me. If we keep sticking to my plan, the economy will bounce back.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[151]` | **""My opponents' plans would only thrust us deeper into recession. We must stay on t..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Moderator**: ""Thank you, President Rayne."" |
| `[207]` | **""I believe I've done enough to say the Oligarchs are no threat anymore.""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true`<br>`(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false` | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |
| `[211]` | **""I don't think they pose any significant threat anymore.""** | `[106]` **Lileas Graf**: ""As well as seizing the assets o..."<br>`[108]` **Lileas Graf**: ""As well as seizing the assets o..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true`<br>`(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false` | *Brak zmian stanu* | `[135]` **Narrator**: "The moderator cleared her throat." |

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
  - -> `[5]` (*Moderator: ""Let's move on to the economy, then.""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Moderator**
> ""Thank you, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[4]`
Mówca: **Remus Holstron**
> ""The others are afraid to say it, but Sordland's economy would soar to new heights if honest Sordish businesses weren't constantly being undercut by certain shady interlopers. You know who I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[5]`
Mówca: **Moderator**
> ""Let's move on to the economy, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)

### Węzeł `[6]`
Mówca: **Denis Stahler**
> ""That isn't exactly a priority for my party at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Denis Stahler: ""Booming markets and increasing CEO salaries aren't an in..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Mansoun Leke: ""Thank you for asking. President Rayne's mishandling of o..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 15"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishRecovery == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Moderator: ""Now that recession is no longer a threat, how will all o..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Moderator: ""How do each of you plan to bring the Sordish economy out..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Moderator: ""I'm sure many of our viewers would like to know how you ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_IncreasedTaxCorps == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""The depression was the exclusive fault of my former economic advisor Symon Holl. Things will run a lot more smoothly now that he's gone.""]** — Mówca: **Player**
> ""The depression was the exclusive fault of my former economic advisor Symon Holl. Things will run a lot more smoothly now that he's gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I promise I will aid Sordish workers affected by the depression.""]** — Mówca: **Player**
> ""I promise I will aid Sordish workers affected by the depression.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Slowly but surely, I am lifting Sordland to economic greatness.""]** — Mówca: **Player**
> ""Slowly but surely, I am lifting Sordland to economic greatness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Why fix what's not broken? As long as I remain president, Sordland will never see another recession.""]** — Mówca: **Player**
> ""Why fix what's not broken? As long as I remain president, Sordland will never see another recession.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""My recovery was just the beginning. If I stay president, Sordland will become one of the world's wealthiest nations.""]** — Mówca: **Player**
> ""My recovery was just the beginning. If I stay president, Sordland will become one of the world's wealthiest nations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""The threat of recession is over, but I will not rest until every Sord can enjoy the fruits of our recovery.""]** — Mówca: **Player**
> ""The threat of recession is over, but I will not rest until every Sord can enjoy the fruits of our recovery.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""I'm doing the best I can given how badly my predecessors screwed up. We're not in a depression, are we?""]** — Mówca: **Player**
> ""I'm doing the best I can given how badly my predecessors screwed up. We're not in a depression, are we?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Frens Ricter: ""I couldn't agree more that Sordland needs to help its wo..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He looked at the camera."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Kesaro Kibener: ""We must increase our economic capabilities to then turn ..."*)

### Węzeł `[32]`
Mówca: **Lileas Graf**
> ""The depression is but a minor bump on the road to greatness. As long as we keep the government's firm hand on the steering wheel of our economy, this country will prosper as never before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_MarketEconomy == true || BaseGame..."*)

### Węzeł `[33]`
Mówca: **Manoly Suheil**
> ""I couldn't agree more that Sordland needs to help its working families. Which is why I will maintain and even increase President Rayne's tax hikes for its wealthiest corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Manoly Suheil: ""I will also initiate a series of massive redevelopment p..."*)

### Węzeł `[34]`
Mówca: **Frens Ricter**
> ""I couldn't agree more that Sordland needs to help its working families. Which is why I've developed a comprehensive program of tax initiatives for small businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_MarketEconomy == true"*)

### Węzeł `[35]`
Mówca: **Lileas Graf**
> ""The current recovery is nothing compared to what I'll be able to achieve with the government's firm hand on the steering wheel of our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_MarketEconomy == true || BaseGame..."*)

### Węzeł `[36]`
Mówca: **Moderator**
> ""How do each of you plan to bring the Sordish economy out of its current state of stasis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[37]`
Mówca: **Moderator**
> ""Now that recession is no longer a threat, how will all of you bring the Sordish economy forward?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[38]`
Mówca: **Moderator**
> ""I'm sure many of our viewers would like to know how you candidates are planning on ending the Sordish Depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[39]`
Mówca: **Mansoun Leke**
> ""Sordland is as wealthy as it needs to be. Our task is to redistribute that wealth so that all citizens can prosper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FreeMedicine == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""The depression was the exclusive fault of my former econ..."*)
  - -> `[20]` (*Player: ""I promise I will aid Sordish workers affected by the dep..."*)
  - -> `[150]` (*Player: ""Just trust me. If we keep sticking to my plan, the econo..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishRecovery == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: ""Why fix what's not broken? As long as I remain president..."*)
  - -> `[23]` (*Player: ""My recovery was just the beginning. If I stay president,..."*)
  - -> `[24]` (*Player: ""The threat of recession is over, but I will not rest unt..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Slowly but surely, I am lifting Sordland to economic gre..."*)
  - -> `[25]` (*Player: ""I'm doing the best I can given how badly my predecessors..."*)
  - -> `[151]` (*Player: ""My opponents' plans would only thrust us deeper into rec..."*)

### Węzeł `[46]`
Mówca: **Denis Stahler**
> ""Sordland is as wealthy as it needs to be. Our task is to redistribute that wealth so that all citizens can prosper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FreeMedicine == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 15"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist > 15)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Denis Stahler: ""The fact is, Rayne may have meant well, but he left mill..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist > 15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Denis Stahler: ""The fact is, Rayne's incompetence left millions of worki..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Mansoun Leke: ""With all due respect, that isn't a priority for my party..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Denis Stahler: ""That isn't exactly a priority for my party at the moment.""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Remus Holstron: ""The others are afraid to say it, but Sordland's economy ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Kesaro Kibener: ""There is a massive potential in our countries economic c..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[59]`
Mówca: **Lileas Graf**
> ""As long as we keep the government's firm hand on the steering wheel of our economy, this country will prosper as never before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_MarketEconomy == true || BaseGame..."*)

### Węzeł `[60]`
Mówca: **Lileas Graf**
> ""I tried to say this to President Rayne many times. With the government's firm hand on the steering wheel of our economy, this country will prosper as never before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_MarketEconomy == true || BaseGame..."*)

### Węzeł `[61]`
Mówca: **Kesaro Kibener**
> ""There is a massive potential in our countries economic capacity. I would push for Autarky and transferring technological knowledge to our local industries. Sordland must control all strategic resources of production and be as independent as possible from foreign influences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[62]`
Mówca: **Mansoun Leke**
> ""The first step is suspension of rent and mortgage payments and a ban on evictions. Then we would move on to job creation through public works programs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishRecovery == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true || (Base..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true || (Base..."*)

### Węzeł `[66]`
Mówca: **Lileas Graf**
> ""As one of the individuals responsible for Sordland's economic recovery, I feel uniquely qualified to answer this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lileas Graf: ""As long as we keep the government's firm hand on the ste..."*)

### Węzeł `[67]`
Mówca: **Denis Stahler**
> ""The first step is suspension of rent and mortgage payments and a ban on evictions. Then we would move on to strengthening Sordland's labor unions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[68]`
Mówca: **Mansoun Leke**
> ""Booming markets and increasing CEO salaries aren't an indicator of whether regular Sordish workers can put food on their tables.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Mansoun Leke: ""Sordland is as wealthy as it needs to be. Our task is to..."*)

### Węzeł `[69]`
Mówca: **Mansoun Leke**
> ""With all due respect, that isn't a priority for my party at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Mansoun Leke: ""Booming markets and increasing CEO salaries aren't an in..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true || (Base..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Privatization == true || (Ba..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true  or  (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]) < 6  or  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lileas Graf: ""I tried to say this to President Rayne many times. With ..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true  or  (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]) < 6  or  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lileas Graf: ""The depression is but a minor bump on the road to greatn..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true || (Base..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Privatization == true || (Ba..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true  or  (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]) < 6  or  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lileas Graf: ""The current recovery is nothing compared to what I'll be..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true  or  (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]) < 6  or  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lileas Graf: ""As one of the individuals responsible for Sordland's eco..."*)

### Węzeł `[76]`
Mówca: **Denis Stahler**
> ""The fact is, Rayne may have meant well, but he left millions of working-class Sords in need of urgent, immediate aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Denis Stahler: ""The first step is suspension of rent and mortgage paymen..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He looked at the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Kesaro Kibener: ""We must increase our economic capabilities to then turn ..."*)

### Węzeł `[78]`
Mówca: **Denis Stahler**
> ""The fact is, Rayne's incompetence left millions of working-class Sords in need of urgent, immediate aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Denis Stahler: ""The first step is suspension of rent and mortgage paymen..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Lileas sniffed."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Denis made a scoffing sound."*)

### Węzeł `[82]`
Mówca: **Mansoun Leke**
> ""Thank you for asking. President Rayne's mishandling of our economy has left millions of working-class Sords, especially minorities, in need of urgent, immediate aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Mansoun Leke: ""The first step is suspension of rent and mortgage paymen..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Lileas sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)

### Węzeł `[84]`
Mówca: **Denis Stahler**
> ""Booming markets and increasing CEO salaries aren't an indicator of whether regular Sordish workers can put food on their tables.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Denis Stahler: ""Sordland is as wealthy as it needs to be. Our task is to..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_MarketEconomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_MarketEconomy == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_MarketEconomy == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_MarketEconomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_MarketEconomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Frens Ricter: ""I believe President Rayne pointed us in the right direct..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_MarketEconomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_MarketEconomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Frens Ricter: ""I will also implement a market economy in Sordland, with..."*)

### Węzeł `[88]`
Mówca: **Frens Ricter**
> ""I will also implement a market economy in Sordland, with state intervention as necessary to ensure the free market produces results close to its theoretical potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[89]`
Mówca: **Frens Ricter**
> ""I believe President Rayne pointed us in the right direction with a market economy, but state intervention is needed to ensure the free market produces results close to its theoretical potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[90]`
Mówca: **Manoly Suheil**
> ""I will also initiate a series of massive redevelopment projects to promote growth and stability to rural regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Frens Ricter: ""Of course, I would immediately undo the president's nati..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)

### Węzeł `[94]`
Mówca: **Frens Ricter**
> ""Of course, I would immediately undo the president's nationalization of our major corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[95]`
Mówca: **Frens Ricter**
> ""And I would continue and expand upon the privatization of our major corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[96]`
Mówca: **Kesaro Kibener**
> ""We must increase our economic capabilities to then turn our goods into quality yet affordable export materials for other developing nations. I would also impose high taxes on the rich to fund military industrial research and development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGam..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "He looked pointedly at Mansoun. The WPB leader gritted hi..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Remus Holstron: ""My economic plan is focused on keeping Sordish money ins..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "He looked pointedly at Mansoun. The WPB leader gritted his teeth but refused to take the bait."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Remus Holstron: ""My economic plan is focused on keeping Sordish money ins..."*)

### Węzeł `[101]`
Mówca: **Remus Holstron**
> ""My economic plan is focused on keeping Sordish money inside Sordish borders. Raising import tariffs would be a start, as would higher taxes on businesses owned by foreigners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGam..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_MarketEconomy == true || BaseGame.Policy_Economy_MixedEconomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_MarketEconomy == true || BaseGame..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_MarketEconomy == true || BaseGa..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_MarketEconomy == true || BaseGame.Policy_Economy_MixedEconomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_MarketEconomy"] == true  or  Variable["BaseGame.Policy_Economy_MixedEconomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lileas Graf: ""That means undoing the disastrous free market reforms of..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_MarketEconomy == true || BaseGame.Policy_Economy_MixedEconomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_MarketEconomy"] == true  or  Variable["BaseGame.Policy_Economy_MixedEconomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lileas Graf: ""That means continuing with a planned economy, as Soll ha..."*)

### Węzeł `[105]`
Mówca: **Lileas Graf**
> ""That means undoing the disastrous free market reforms of Rayne and Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lileas Graf: ""As well as seizing the assets of Sordland's wealthiest c..."*)

### Węzeł `[106]`
Mówca: **Lileas Graf**
> ""As well as seizing the assets of Sordland's wealthiest corporations so that oligarchs can no longer hold more power than the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed == true"*)
  - -> `[132]` (*Player_Italic: "Say nothing."*)

### Węzeł `[107]`
Mówca: **Lileas Graf**
> ""That means continuing with a planned economy, as Soll had intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lileas Graf: ""As well as seizing the assets of Sordland's wealthiest c..."*)

### Węzeł `[108]`
Mówca: **Lileas Graf**
> ""As well as seizing the assets of Sordland's wealthiest corporations so that oligarchs can no longer hold more power than the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed == true"*)
  - -> `[132]` (*Player_Italic: "Say nothing."*)

### Węzeł `[109]`
Mówca: **Denis Stahler**
> ""The real danger to our economy is the Sordish oligarchs. No one man must be allowed to hold so much wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed == true"*)
  - -> `[132]` (*Player_Italic: "Say nothing."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Denis made a scoffing sound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Destroyed == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""The Oligarchs are no threat anymore. I saw to that.""*)
  - -> `[120]` (*Player: ""They're gone, remember? Prison, et cetera...?""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.T..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""The Oligarchs do more for Sordland than you ever will.""*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Marcel_Enemy == false"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""The Oligarchs are no threat anymore. I saw to that.""]** — Mówca: **Player**
> ""The Oligarchs are no threat anymore. I saw to that.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""The Oligarchs do more for Sordland than you ever will.""]** — Mówca: **Player**
> ""The Oligarchs do more for Sordland than you ever will.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true` AND `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true) == false` AND `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""The Oligarchs are the engine that keeps our economy running.""]** — Mówca: **Player**
> ""The Oligarchs are the engine that keeps our economy running.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true) == false` AND `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""They're gone, remember? Prison, et cetera...?""]** — Mówca: **Player**
> ""They're gone, remember? Prison, et cetera...?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Marcel_Enemy == false"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Marcel_Enemy == false)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""Marcel Koronti has done more for Sordland than you ever ..."*)
  - -> `[125]` (*Player: ""Marcel isn't so bad...""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Enemy == false"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Marcel Koronti has done more for Sordland than you ever will.""]** — Mówca: **Player**
> ""Marcel Koronti has done more for Sordland than you ever will.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Killed_MarcelKoronti"] == false` AND `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true` AND `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Marcel isn't so bad...""]** — Mówca: **Player**
> ""Marcel isn't so bad...""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Killed_MarcelKoronti"] == false` AND `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true` AND `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Enemy == false"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Enemy == false)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""Walter Tusk has done more for Sordland than you ever will.""*)
  - -> `[130]` (*Player: ""Walter isn't so bad...""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Enemy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Walter Tusk has done more for Sordland than you ever will.""]** — Mówca: **Player**
> ""Walter Tusk has done more for Sordland than you ever will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Walter isn't so bad...""]** — Mówca: **Player**
> ""Walter isn't so bad...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I agree. They must be stopped.""]** — Mówca: **Player**
> ""I agree. They must be stopped.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true) == false` AND `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I refrained from commenting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "The moderator cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Moderator: ""Yes, let's leave Marcel Koronti out of this, shall we?""*)

### Węzeł `[134]`
Mówca: **Moderator**
> ""Yes, let's leave Marcel Koronti out of this, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Moderator: ""Mr. President, would you care to comment on your plans f..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "The moderator cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Moderator: ""We're getting off-track.""*)

### Węzeł `[136]`
Mówca: **Moderator**
> ""We're getting off-track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Moderator: ""Mr. President, would you care to comment on your plans f..."*)

### Węzeł `[137]`
Mówca: **Moderator**
> ""Mr. President, would you care to comment on your plans for the economy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_BasicIncomePromise == true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_BasicIncomePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_BasicIncomePromise == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_BasicIncomePromise == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_BasicIncomePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: ""As I said earlier, my plan for a guaranteed living wage ..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_BasicIncomePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_NuclearPromise == true"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""As I said earlier, my plan for a guaranteed living wage for everyone will lead to unprecedented prosperity.""]** — Mówca: **Player**
> ""As I said earlier, my plan for a guaranteed living wage for everyone will lead to unprecedented prosperity.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_NuclearPromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_NuclearPromise == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_NuclearPromise == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_NuclearPromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_NuclearPromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""As I said earlier, my plan for a nuclear program will le..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_NuclearPromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_NuclearPromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise == true"*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""As I said earlier, my plan for a nuclear program will lead to unprecedented prosperity.""]** — Mówca: **Player**
> ""As I said earlier, my plan for a nuclear program will lead to unprecedented prosperity.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Debate_NuclearPromise"] == true` AND `(Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""As I said earlier, my plan for a space program will lead to unprecedented prosperity.""]** — Mówca: **Player**
> ""As I said earlier, my plan for a space program will lead to unprecedented prosperity.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Debate_SpacePromise"] == true` AND `(Variable["BaseGameIsolated.Debate_NuclearPromise"] == true) == false` AND `(Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_SpacePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_SpacePromise == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_SpacePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_SpacePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: ""As I said earlier, my plan for a space program will lead..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_SpacePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_SpacePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Just trust me. If we keep sticking to my plan, the economy will bounce back.""]** — Mówca: **Player**
> ""Just trust me. If we keep sticking to my plan, the economy will bounce back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""My opponents' plans would only thrust us deeper into recession. We must stay on the course I have plotted.""]** — Mówca: **Player**
> ""My opponents' plans would only thrust us deeper into recession. We must stay on the course I have plotted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""Thank you, President Rayne.""*)

### Węzeł `[152]`
Mówca: **Frens Ricter**
> ""And I would continue Alphonso's privatization of our major corporations. The sole thing his administration got right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_StatusQuo == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Frens Ricter: ""And I would continue Alphonso's privatization of our maj..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_StatusQuo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Frens Ricter: ""And I would continue and expand upon the privatization o..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_IncreasedTaxCorps == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_IncreasedTaxCorps == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_IncreasedTaxCorps == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_IncreasedTaxCorps == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Manoly Suheil: ""I couldn't agree more that Sordland needs to help its wo..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_IncreasedTaxCorps == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Manoly Suheil: ""I couldn't agree more that Sordland needs to help its wo..."*)

### Węzeł `[159]`
Mówca: **Manoly Suheil**
> ""I couldn't agree more that Sordland needs to help its working families. We can pay for their aid by raising taxes on the country's largest corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Manoly Suheil: ""I will also initiate a series of massive redevelopment p..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGam..."*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseG..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Kesaro Kibener: ""On top of that I would remove Rayne's ridiculous 'vice' ..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGam..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseG..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Remus Holstron: ""With that money flowing, I'll be able to remove Rayne's ..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[166]`
Mówca: **Kesaro Kibener**
> ""On top of that I would remove Rayne's ridiculous 'vice' tax so that Sords can once more enjoy an affordable drink and a smoke after a long working day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[167]`
Mówca: **Remus Holstron**
> ""With that money flowing, I'll be able to remove Rayne's ridiculous 'vice' tax so that Sords can once more enjoy an affordable drink and a smoke after a long working day. As is their God-given right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FreeMedicine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FreeMedicine == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FreeMedicine == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FreeMedicine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FreeMedicine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_FreeTransportation_Signed == true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FreeMedicine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FreeMedicine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_FreeTransportation_Signed == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_FreeTransportation_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_FreeTransportation_Signed == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_FreeTransportation_Signed == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_FreeTransportation_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Mansoun Leke: ""Free public transit and prescription drugs -- that's a v..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_FreeTransportation_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Mansoun Leke: ""Free prescription drugs for all -- that's a very good st..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_FreeTransportation_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_FreeTransportation_Signed == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_FreeTransportation_Signed == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_FreeTransportation_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Mansoun Leke: ""Free public transit for all -- that's a start. But there..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_FreeTransportation_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_LuxuryTax_Signed == true"*)

### Węzeł `[177]`
Mówca: **Mansoun Leke**
> ""Free public transit and prescription drugs -- that's a very good start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[178]`
Mówca: **Mansoun Leke**
> ""Free prescription drugs for all -- that's a very good start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[179]`
Mówca: **Mansoun Leke**
> ""Taxing luxury goods -- that's a start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_LuxuryTax_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_LuxuryTax_Signed == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_LuxuryTax_Signed == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_LuxuryTax_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_LuxuryTax_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Mansoun Leke: ""Taxing luxury goods -- that's a start. But there's much ..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_LuxuryTax_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_LuxuryTax_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[183]`
Mówca: **Mansoun Leke**
> ""Free public transit for all -- that's a start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FreeMedicine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FreeMedicine == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FreeMedicine == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FreeMedicine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FreeMedicine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_FreeTransportation_Signed == true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FreeMedicine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FreeMedicine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_FreeTransportation_Signed == true"*)

### Węzeł `[187]`
Mówca: **Denis Stahler**
> ""Taxing luxury goods -- that's a start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_FreeTransportation_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_FreeTransportation_Signed == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_FreeTransportation_Signed == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_FreeTransportation_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Denis Stahler: ""Free public transit and prescription drugs -- that's a v..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_FreeTransportation_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Denis Stahler: ""Free prescription drugs for all -- that's a very good st..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_FreeTransportation_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_FreeTransportation_Signed == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_FreeTransportation_Signed == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_FreeTransportation_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Denis Stahler: ""Free public transit for all -- that's a start. But there..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_FreeTransportation_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_LuxuryTax_Signed == true"*)

### Węzeł `[194]`
Mówca: **Denis Stahler**
> ""Free public transit and prescription drugs -- that's a very good start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[195]`
Mówca: **Denis Stahler**
> ""Free prescription drugs for all -- that's a very good start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_LuxuryTax_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_LuxuryTax_Signed == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_LuxuryTax_Signed == true)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_LuxuryTax_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_LuxuryTax_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Denis Stahler: ""Taxing luxury goods -- that's a start. But there's much ..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_LuxuryTax_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_LuxuryTax_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[199]`
Mówca: **Denis Stahler**
> ""Free public transit for all -- that's a start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Destroyed == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Denis Stahler: ""The real danger to our economy are the oligarchs like th..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Denis Stahler: ""The real danger to our economy is the Sordish oligarchs...."*)

### Węzeł `[203]`
Mówca: **Denis Stahler**
> ""The real danger to our economy are the oligarchs like the Koronti family. These jackals disrupt, break and change the system in their favour and disregard the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Destroyed == true"*)
  - -> `[132]` (*Player_Italic: "Say nothing."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.T..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player: ""I believe I've done enough to say the Oligarchs are no t..."*)
  - -> `[211]` (*Player: ""I don't think they pose any significant threat anymore.""*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Marcel_Enemy == false && BaseGame.Kill..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""I agree. They must be stopped.""*)
  - -> `[119]` (*Player: ""The Oligarchs are the engine that keeps our economy runn..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I believe I've done enough to say the Oligarchs are no threat anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true` AND `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Marcel_Enemy == false && BaseGame.Killed_MarcelKoronti == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Marcel_Enemy == false && BaseGame.Kill..."*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Marcel_Enemy == false && BaseGame.Ki..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Marcel_Enemy == false && BaseGame.Killed_MarcelKoronti == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Killed_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""Marcel Koronti has done more for Sordland than you ever ..."*)
  - -> `[125]` (*Player: ""Marcel isn't so bad...""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Marcel_Enemy == false && BaseGame.Killed_MarcelKoronti == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Killed_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't think they pose any significant threat anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true` AND `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Lileas Graf), `[108]` (Lileas Graf), `[109]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The moderator cleared her throat."*)
