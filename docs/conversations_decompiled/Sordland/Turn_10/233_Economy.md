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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 0

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
  - -> `[5]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `234` (*Sordland/Turn10/Foreign Policy*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Moderator**
> ""Thank you, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[4]`
Mówca: **Remus Holstron**
> ""The others are afraid to say it, but Sordland's economy would soar to new heights if honest Sordish businesses weren't constantly being undercut by certain shady interlopers. You know who I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[5]`
Mówca: **Moderator**
> ""Let's move on to the economy, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[6]`
Mówca: **Denis Stahler**
> ""That isn't exactly a priority for my party at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""The depression was the exclusive fault of my former economic advisor Symon Holl. Things will run a lot more smoothly now that he's gone.""]** — Mówca: **Player**
> ""The depression was the exclusive fault of my former economic advisor Symon Holl. Things will run a lot more smoothly now that he's gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I promise I will aid Sordish workers affected by the depression.""]** — Mówca: **Player**
> ""I promise I will aid Sordish workers affected by the depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Slowly but surely, I am lifting Sordland to economic greatness.""]** — Mówca: **Player**
> ""Slowly but surely, I am lifting Sordland to economic greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Why fix what's not broken? As long as I remain president, Sordland will never see another recession.""]** — Mówca: **Player**
> ""Why fix what's not broken? As long as I remain president, Sordland will never see another recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""My recovery was just the beginning. If I stay president, Sordland will become one of the world's wealthiest nations.""]** — Mówca: **Player**
> ""My recovery was just the beginning. If I stay president, Sordland will become one of the world's wealthiest nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""The threat of recession is over, but I will not rest until every Sord can enjoy the fruits of our recovery.""]** — Mówca: **Player**
> ""The threat of recession is over, but I will not rest until every Sord can enjoy the fruits of our recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""I'm doing the best I can given how badly my predecessors screwed up. We're not in a depression, are we?""]** — Mówca: **Player**
> ""I'm doing the best I can given how badly my predecessors screwed up. We're not in a depression, are we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[32]`
Mówca: **Lileas Graf**
> ""The depression is but a minor bump on the road to greatness. As long as we keep the government's firm hand on the steering wheel of our economy, this country will prosper as never before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[33]`
Mówca: **Manoly Suheil**
> ""I couldn't agree more that Sordland needs to help its working families. Which is why I will maintain and even increase President Rayne's tax hikes for its wealthiest corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[34]`
Mówca: **Frens Ricter**
> ""I couldn't agree more that Sordland needs to help its working families. Which is why I've developed a comprehensive program of tax initiatives for small businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[35]`
Mówca: **Lileas Graf**
> ""The current recovery is nothing compared to what I'll be able to achieve with the government's firm hand on the steering wheel of our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[36]`
Mówca: **Moderator**
> ""How do each of you plan to bring the Sordish economy out of its current state of stasis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[37]`
Mówca: **Moderator**
> ""Now that recession is no longer a threat, how will all of you bring the Sordish economy forward?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[38]`
Mówca: **Moderator**
> ""I'm sure many of our viewers would like to know how you candidates are planning on ending the Sordish Depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[39]`
Mówca: **Mansoun Leke**
> ""Sordland is as wealthy as it needs to be. Our task is to redistribute that wealth so that all citizens can prosper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[150]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[25]`
  - -> `[151]`

### Węzeł `[46]`
Mówca: **Denis Stahler**
> ""Sordland is as wealthy as it needs to be. Our task is to redistribute that wealth so that all citizens can prosper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 15))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[59]`
Mówca: **Lileas Graf**
> ""As long as we keep the government's firm hand on the steering wheel of our economy, this country will prosper as never before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[60]`
Mówca: **Lileas Graf**
> ""I tried to say this to President Rayne many times. With the government's firm hand on the steering wheel of our economy, this country will prosper as never before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[61]`
Mówca: **Kesaro Kibener**
> ""There is a massive potential in our countries economic capacity. I would push for Autarky and transferring technological knowledge to our local industries. Sordland must control all strategic resources of production and be as independent as possible from foreign influences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[62]`
Mówca: **Mansoun Leke**
> ""The first step is suspension of rent and mortgage payments and a ban on evictions. Then we would move on to job creation through public works programs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
Mówca: **Lileas Graf**
> ""As one of the individuals responsible for Sordland's economic recovery, I feel uniquely qualified to answer this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[67]`
Mówca: **Denis Stahler**
> ""The first step is suspension of rent and mortgage payments and a ban on evictions. Then we would move on to strengthening Sordland's labor unions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[68]`
Mówca: **Mansoun Leke**
> ""Booming markets and increasing CEO salaries aren't an indicator of whether regular Sordish workers can put food on their tables.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[69]`
Mówca: **Mansoun Leke**
> ""With all due respect, that isn't a priority for my party at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true  or  (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]) < 6  or  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true  or  (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]) < 6  or  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true  or  (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]) < 6  or  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Privatization == true || (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization) < 6 || BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true  or  (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]) < 6  or  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[76]`
Mówca: **Denis Stahler**
> ""The fact is, Rayne may have meant well, but he left millions of working-class Sords in need of urgent, immediate aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[77]`
Mówca: **Narrator**
> "He looked at the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[78]`
Mówca: **Denis Stahler**
> ""The fact is, Rayne's incompetence left millions of working-class Sords in need of urgent, immediate aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[82]`
Mówca: **Mansoun Leke**
> ""Thank you for asking. President Rayne's mishandling of our economy has left millions of working-class Sords, especially minorities, in need of urgent, immediate aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Lileas sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[84]`
Mówca: **Denis Stahler**
> ""Booming markets and increasing CEO salaries aren't an indicator of whether regular Sordish workers can put food on their tables.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_MarketEconomy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_MarketEconomy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_MarketEconomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_MarketEconomy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_MarketEconomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Frens Ricter**
> ""I will also implement a market economy in Sordland, with state intervention as necessary to ensure the free market produces results close to its theoretical potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Frens Ricter**
> ""I believe President Rayne pointed us in the right direction with a market economy, but state intervention is needed to ensure the free market produces results close to its theoretical potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Manoly Suheil**
> ""I will also initiate a series of massive redevelopment projects to promote growth and stability to rural regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[94]`
Mówca: **Frens Ricter**
> ""Of course, I would immediately undo the president's nationalization of our major corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[95]`
Mówca: **Frens Ricter**
> ""And I would continue and expand upon the privatization of our major corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[96]`
Mówca: **Kesaro Kibener**
> ""We must increase our economic capabilities to then turn our goods into quality yet affordable export materials for other developing nations. I would also impose high taxes on the rich to fund military industrial research and development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Narrator**
> "He looked pointedly at Mansoun. The WPB leader gritted his teeth but refused to take the bait."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Remus Holstron**
> ""My economic plan is focused on keeping Sordish money inside Sordish borders. Raising import tariffs would be a start, as would higher taxes on businesses owned by foreigners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_MarketEconomy == true || BaseGame.Policy_Economy_MixedEconomy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_MarketEconomy == true || BaseGame.Policy_Economy_MixedEconomy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_MarketEconomy"] == true  or  Variable["BaseGame.Policy_Economy_MixedEconomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_MarketEconomy == true || BaseGame.Policy_Economy_MixedEconomy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_MarketEconomy"] == true  or  Variable["BaseGame.Policy_Economy_MixedEconomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Lileas Graf**
> ""That means undoing the disastrous free market reforms of Rayne and Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Lileas Graf**
> ""As well as seizing the assets of Sordland's wealthiest corporations so that oligarchs can no longer hold more power than the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[132]`

### Węzeł `[107]`
Mówca: **Lileas Graf**
> ""That means continuing with a planned economy, as Soll had intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Lileas Graf**
> ""As well as seizing the assets of Sordland's wealthiest corporations so that oligarchs can no longer hold more power than the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[132]`

### Węzeł `[109]`
Mówca: **Denis Stahler**
> ""The real danger to our economy is the Sordish oligarchs. No one man must be allowed to hold so much wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[132]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Denis made a scoffing sound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[120]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""The Oligarchs are no threat anymore. I saw to that.""]** — Mówca: **Player**
> ""The Oligarchs are no threat anymore. I saw to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""The Oligarchs do more for Sordland than you ever will.""]** — Mówca: **Player**
> ""The Oligarchs do more for Sordland than you ever will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""The Oligarchs are the engine that keeps our economy running.""]** — Mówca: **Player**
> ""The Oligarchs are the engine that keeps our economy running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""They're gone, remember? Prison, et cetera...?""]** — Mówca: **Player**
> ""They're gone, remember? Prison, et cetera...?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Marcel Koronti has done more for Sordland than you ever will.""]** — Mówca: **Player**
> ""Marcel Koronti has done more for Sordland than you ever will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Marcel isn't so bad...""]** — Mówca: **Player**
> ""Marcel isn't so bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Enemy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Walter Tusk has done more for Sordland than you ever will.""]** — Mówca: **Player**
> ""Walter Tusk has done more for Sordland than you ever will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Walter isn't so bad...""]** — Mówca: **Player**
> ""Walter isn't so bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I agree. They must be stopped.""]** — Mówca: **Player**
> ""I agree. They must be stopped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I refrained from commenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
Mówca: **Narrator**
> "The moderator cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Moderator**
> ""Yes, let's leave Marcel Koronti out of this, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Narrator**
> "The moderator cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Moderator**
> ""We're getting off-track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Moderator**
> ""Mr. President, would you care to comment on your plans for the economy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_BasicIncomePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_BasicIncomePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_BasicIncomePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""As I said earlier, my plan for a guaranteed living wage for everyone will lead to unprecedented prosperity.""]** — Mówca: **Player**
> ""As I said earlier, my plan for a guaranteed living wage for everyone will lead to unprecedented prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_NuclearPromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_NuclearPromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_NuclearPromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_NuclearPromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_NuclearPromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""As I said earlier, my plan for a nuclear program will lead to unprecedented prosperity.""]** — Mówca: **Player**
> ""As I said earlier, my plan for a nuclear program will lead to unprecedented prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""As I said earlier, my plan for a space program will lead to unprecedented prosperity.""]** — Mówca: **Player**
> ""As I said earlier, my plan for a space program will lead to unprecedented prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_SpacePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_SpacePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_SpacePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_SpacePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_SpacePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Just trust me. If we keep sticking to my plan, the economy will bounce back.""]** — Mówca: **Player**
> ""Just trust me. If we keep sticking to my plan, the economy will bounce back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""My opponents' plans would only thrust us deeper into recession. We must stay on the course I have plotted.""]** — Mówca: **Player**
> ""My opponents' plans would only thrust us deeper into recession. We must stay on the course I have plotted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[152]`
Mówca: **Frens Ricter**
> ""And I would continue Alphonso's privatization of our major corporations. The sole thing his administration got right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_StatusQuo == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_IncreasedTaxCorps == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_IncreasedTaxCorps == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_IncreasedTaxCorps == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Manoly Suheil**
> ""I couldn't agree more that Sordland needs to help its working families. We can pay for their aid by raising taxes on the country's largest corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[166]`
Mówca: **Kesaro Kibener**
> ""On top of that I would remove Rayne's ridiculous 'vice' tax so that Sords can once more enjoy an affordable drink and a smoke after a long working day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[167]`
Mówca: **Remus Holstron**
> ""With that money flowing, I'll be able to remove Rayne's ridiculous 'vice' tax so that Sords can once more enjoy an affordable drink and a smoke after a long working day. As is their God-given right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FreeMedicine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FreeMedicine == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FreeMedicine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_FreeMedicine == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FreeMedicine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_FreeTransportation_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_FreeTransportation_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_FreeTransportation_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_FreeTransportation_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_FreeTransportation_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_FreeTransportation_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
Mówca: **Mansoun Leke**
> ""Free public transit and prescription drugs -- that's a very good start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[178]`
Mówca: **Mansoun Leke**
> ""Free prescription drugs for all -- that's a very good start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[179]`
Mówca: **Mansoun Leke**
> ""Taxing luxury goods -- that's a start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_LuxuryTax_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_LuxuryTax_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_LuxuryTax_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_LuxuryTax_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_LuxuryTax_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[183]`
Mówca: **Mansoun Leke**
> ""Free public transit for all -- that's a start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FreeMedicine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FreeMedicine == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FreeMedicine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_FreeMedicine == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FreeMedicine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[187]`
Mówca: **Denis Stahler**
> ""Taxing luxury goods -- that's a start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_FreeTransportation_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_FreeTransportation_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_FreeTransportation_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_FreeTransportation_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_FreeTransportation_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_FreeTransportation_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_FreeTransportation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
Mówca: **Denis Stahler**
> ""Free public transit and prescription drugs -- that's a very good start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[195]`
Mówca: **Denis Stahler**
> ""Free prescription drugs for all -- that's a very good start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_LuxuryTax_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_LuxuryTax_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_LuxuryTax_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_LuxuryTax_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_LuxuryTax_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[199]`
Mówca: **Denis Stahler**
> ""Free public transit for all -- that's a start. But there's much more we could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[203]`
Mówca: **Denis Stahler**
> ""The real danger to our economy are the oligarchs like the Koronti family. These jackals disrupt, break and change the system in their favour and disregard the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[132]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[211]`
  - -> `[208]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[119]`
  - -> `[114]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I believe I've done enough to say the Oligarchs are no threat anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Marcel_Enemy == false && BaseGame.Killed_MarcelKoronti == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Marcel_Enemy == false && BaseGame.Killed_MarcelKoronti == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Killed_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Marcel_Enemy == false && BaseGame.Killed_MarcelKoronti == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Killed_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't think they pose any significant threat anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
