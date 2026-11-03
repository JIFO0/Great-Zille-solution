# Sordland/Turn10/EnergyDiscussion/EnergyDiscussion Conversation

- **ID konwersacji:** `541`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/541_EnergyDiscussion_Conversation.md`
- **Liczba węzłów dialogowych:** 311
- **Liczba wyborów gracza:** 72

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[48]** Tarquin Soll

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10`
- `BaseGame.Decision_Turn06_GasomStake_SellOneThird`
- `BaseGame.Decision_Turn06_GasomStake_SellTwoThird`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Gasom_Booming`
- `BaseGame.Gasom_Default`
- `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Turn03_Admin_EnergyProtectionAct_Removed`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Soll_Hates_Alphonso`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[222] Sordland/Turn10/Personal_FCAnricaDerby** (../Turn_10/222_Personal_FCAnricaDerby.md), Węzeł `[120]`
- Węzeł `[310]` -> **[222] Sordland/Turn10/Personal_FCAnricaDerby** (../Turn_10/222_Personal_FCAnricaDerby.md), Węzeł `[120]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 7

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Soll_Hates_Alphonso`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[62]` (Paskal Beniwoll): `--;`
- Węzeł `[103]` (Paskal Beniwoll): `--;`
- Węzeł `[105]` (Paskal Beniwoll): `--;`
- Węzeł `[135]` (Paskal Beniwoll): `Variable["BaseGame.Soll_Hates_Alphonso"] = true;`
- Węzeł `[136]` (Paskal Beniwoll): `--;`
- Węzeł `[166]` (Paskal Beniwoll): `--;`
- Węzeł `[180]` (Paskal Beniwoll): `--;`

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
  - -> `[17]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `222` (*Sordland/Turn10/Personal_FCAnricaDerby*), Węzeł `[120]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Ewald Alphonso**
> ""I flew in all the way from the Archipelago, just to be here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && (BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && (BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  (Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && (BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  (Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Ewald Alphonso**
> ""I'll be perfectly honest with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[11]`
Mówca: **Ewald Alphonso**
> ""I was in Rumburg a few days ago to meet with several energy industry leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true  or  Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true  or  Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[15]`
Mówca: **Ewald Alphonso**
> ""When you promised me you wouldn't tighten the Energy Protection Act, I had the feeling you wouldn't keep your word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[16]`
Mówca: **Ewald Alphonso**
> ""I was in Rizia a few days ago to meet with our energy partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[17]`
Mówca: **Ewald Alphonso**
> ""You know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Colonel Soll is right about this. You did sell your shares to them and abandon Sordland to go live in their country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Ewald Alphonso**
> ""Did you know that the Anrakan Federation is building islands in the middle of the ocean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[23]`
Mówca: **Tarquin Soll**
> ""You shouldn't have. You don't live in Sordland anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Ewald Alphonso**
> ""I thought you would be happy to see an old friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Ewald's upper lip curled, but he quickly turned it into a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[26]`
Mówca: **Tarquin Soll**
> ""I thought you couldn't sink any deeper when you handed the Anrakans the keys to our energy. But moving there was an all-time low, even for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[27]`
Mówca: **Tarquin Soll**
> ""Don't make me laugh, Ewald. You traded Sordland for damn Anraka.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[28]`
  - -> `[29]`
  - -> `[30]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I feel the same way. This was not what I had in mind when I removed the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, Mr. Alphonso. Why did you decide to move to the Federation of Anrakan Isles?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A former Sordish president who chose to retire on an island. Sounds familiar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Tarquin Soll**
> ""I chose to remain in Sordland, Mr. Rayne. My homeland. Not to sell myself off to the highest bidder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[32]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Neither of you can judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Tarquin Soll**
> ""To live as a king, off of the backs of hard-working Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Ewald Alphonso**
> ""Mr. Soll, please. You are not in a position to judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[35]`
Mówca: **Ewald Alphonso**
> ""Mr. President, the state's investment in Gasom helped the company get back on its feet. I'll always appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Ewald Alphonso**
> ""But after you removed the EPA, the Anrakans made me the deal of a lifetime. I couldn't exactly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let me guess. You live on one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That sounds impressive. Tell me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that why you sold Gasom to them and abandoned Sordland for Anraka?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are you even here, Mr. Alphonso? You're not invested in the future of Sordland, so I can't imagine you're invested in Sordish football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne, please. You are not in a position to judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> ""Your hefty investment in Gasom helped the company get back on its feet. I'll always appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Ewald Alphonso**
> ""But after you removed the Energy Protection Act, the Anrakans made me the deal of a lifetime. I couldn't exactly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Ewald Alphonso**
> ""I'm getting old. Surely I've earned the right to a comfortable retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather not discuss this any further, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You persuaded the Sordish state to invest in Gasom as a leap of faith -- and then you turned around and sold your own shares.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't try to blame me for your own selfishness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[48]`
Mówca: **Ewald Alphonso**
> ""Mr. Soll, please. You are not in a position to judge us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[49]`
Mówca: **Ewald Alphonso**
> ""I do, actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Ewald Alphonso**
> ""It's the perfect retirement. An entire island just for myself and my loved ones. And it's not even that expensive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[52]`
  - -> `[53]`
  - -> `[54]`

### Węzeł `[51]`
Mówca: **Ewald Alphonso**
> ""Imagine your very own miniature paradise, with its topography custom-designed to suit your needs. Well, I don't need to imagine it -- I own one now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That reminds me of another former president who lived on an island. Tarquin Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't that all a bit much? No need to be such a show-off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... I find it disgusting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good for you, I guess...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Ewald Alphonso**
> ""Oh, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Ewald Alphonso**
> ""Don't even make that comparison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[58]`
Mówca: **Ewald Alphonso**
> ""Oh, it is, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[59]`
Mówca: **Ewald Alphonso**
> ""Suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Ewald Alphonso**
> ""And now Gasom is booming. We've all won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Ewald Alphonso**
> ""We've all benefited, just like I said. You, me, Gasom and Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[66]`
Mówca: **Ewald Alphonso**
> ""Believe it or not, the Rumburgians are now talking about pursuing a friendlier relationship with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Ewald Alphonso**
> ""Selling my Gasom shares to Rumburg surely must have aided with this diplomatic achievement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Tarquin Soll**
> ""How dare you, son. If we avoided war with Rumburg, it was by the skin of our teeth, not because you handed the Queen the key to our energy grid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Ewald Alphonso**
> ""Thanks to President Rayne, Sordland and Rumburg are set to become allies and business partners. Old enemies can still be future friends, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Ewald's upper lip curled, but he quickly turned it into a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[74]`
Mówca: **Tarquin Soll**
> ""And now you're even boasting about how you climbed into bed with our enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[75]`
Mówca: **Tarquin Soll**
> ""Don't speak like an idiot, Ewald. You made this deal long before diplomacy with Rumburg was in the cards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Tarquin Soll**
> ""Yet you did it anyway, knowing that war might be on the horizon. Just to line your pockets with Rumburgian crowns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`
  - -> `[79]`
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Soll is right about this. Rumburg should never have ended up with the largest share in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Ewald, I must remind you that you sold those shares before any diplomatic talks were being discussed. Don't use that as an excuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't begrudge Mr. Alphonso his decision. Especially since our relations with Rumburg have improved so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He has the freedom to sell his personal assets to anyone he chooses. Including Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[81]`
Mówca: **Ewald Alphonso**
> ""And Gasom is operating the same as ever. You don't even notice the difference in ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Same as ever? It's a foreign-owned company and Rumburg has the biggest stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's good to hear. We can't risk any deterioration of relations with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must remind you that you sold those shares before any diplomatic talks were being discussed. You handed our largest rival the keys to our energy grid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How can you casually bring this up? You sold off Gasom, just to line your pockets with Rumburgian crowns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne, please. You are not in a position to judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Ewald Alphonso**
> ""You didn't invest enough to help keep my company afloat, while opening the door to foreigners who were willing to do exactly that. What did you think would happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Ewald Alphonso**
> ""Rumburg and Rizia were never my first choices. But they came to Gasom's rescue when Sordland would not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[89]`
Mówca: **Ewald Alphonso**
> ""I thought you'd be glad, Mr. Rayne. If your goal is to avoid conflict with Rumburg, a stake in Gasom is one hell of a peace offering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[90]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Neither of you can judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
Mówca: **Tarquin Soll**
> ""Why don't you also go ahead and sell FC Anrica to Queen Beatrice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[98]`
Mówca: **Tarquin Soll**
> ""Why don't you also go ahead and sell your shares of Underhall Construction to Queen Beatrice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Tarquin Soll**
> ""I can't believe the two of you. You join my party and then undermine everything it stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Ewald Alphonso**
> ""Exactly. And you are doing an extraordinary job on that front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Ewald Alphonso**
> ""Mr. Soll, please. You are in no position to judge us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Tarquin Soll**
> ""No, but history will judge you. And I suspect it will find you wanting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[104]`
Mówca: **Tarquin Soll**
> ""You cannot trust a monarchy, gentlemen. Rizia and Rumburg will never be our friends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You should have been able to fix Gasom on your own, not go begging for investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't try to blame me for your own selfishness. I see now why Soll never trusted you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Ewald Alphonso**
> ""I did everything I could do on my own. But a company needs investors to truly thrive. Look at how it's been booming with Rumburg's involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[109]`
Mówca: **Ewald Alphonso**
> ""We're putting stock in the old man's opinion now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[110]`
Mówca: **Ewald Alphonso**
> ""I've been starting to regret selling my Gasom shares to Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[114]`
Mówca: **Tarquin Soll**
> ""Relations? We are on the verge of war, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Ewald Alphonso**
> ""I had no idea our relations would sink this low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[125]`

### Węzeł `[116]`
Mówca: **Tarquin Soll**
> ""You handed our enemies the keys to our energy. And now you're acting as if you had no idea Rumburg posed a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Tarquin Soll**
> ""You are a traitor. It's that simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Ewald's upper lip curled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`
  - -> `[270]`
  - -> `[133]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't make me laugh. You always knew that Rumburg posed a threat. But you cared more about your precious free market than national security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is my fault as much as it is yours. I never should have removed the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sink this low? War is upon us, Ewald. And you betrayed our nation by handing our enemies the keys to our energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't expect me to sympathize with you. You sold off Gasom, just to line your pockets with Rumburgian crowns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Ewald Alphonso**
> ""I gave Sordland the first chance at a large investment. I told you that completely removing the Energy Protection Act might compromise our interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[124]`
Mówca: **Ewald Alphonso**
> ""Please, let's not go there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[128]`
Mówca: **Ewald Alphonso**
> ""When it was clear that Sordland wouldn't help Gasom, I had to look elsewhere. But I didn't hand Rumburg the key to Sordish energy, Mr. President. You did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`
  - -> `[268]`

### Węzeł `[129]`
Mówca: **Ewald Alphonso**
> ""Thank you for your understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[130]`
Mówca: **Ewald Alphonso**
> ""I didn't know our relations would sink this low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Colonel Soll is right. You are a traitor, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's done is done. Let's not start an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't expect anyone to sympathize with you. You sold off Gasom, just to line your pockets with Rumburgian crowns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[134]`
Mówca: **Ewald Alphonso**
> ""Thank you for your understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Soll_Hates_Alphonso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Let's not go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> ""I did tell you not to raise the cap on foreign ownership over 49 percent, didn't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> ""But please let's not dwell on this any longer. I just wanted to be open with you about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[140]`
Mówca: **Ewald Alphonso**
> ""I gave Sordland every chance to invest, didn't I? When you wouldn't help keep Gasom afloat, I had to look elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[144]`
Mówca: **Ewald Alphonso**
> ""You ignored both of those pieces of advice, and went on to declare war on Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[145]`
Mówca: **Ewald Alphonso**
> ""I can't believe you would attempt to follow in Soll's footsteps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`
  - -> `[294]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Ewald Alphonso**
> ""Especially after you... brought him down like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[168]`
  - -> `[169]`
  - -> `[172]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Soll looked at me sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Tarquin Soll**
> ""Is that true, boy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Tarquin Soll**
> ""When I passed the Energy Protection Act, my intention was to protect the Sordish state from nefarious interests. Not for the Sordish state to become one of those interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[284]`
  - -> `[285]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I was only trying to follow in your footsteps, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Ewald's upper lip curled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`
  - -> `[159]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Soll is right. You are always looking for someone else to blame, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's done is done. Let's not start an argument now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It wasn't my intention to revert it. The party forced me to do it. I had to compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't be so harsh on him. I should have seen this coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[162]`
Mówca: **Tarquin Soll**
> ""No need to sympathize with him, Mr. Rayne."""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[163]`
Mówca: **Tarquin Soll**
> ""You should never have tried to go against the USP in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[164]`
Mówca: **Ewald Alphonso**
> ""You're right. Let's not dwell on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Let's not go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[167]`
Mówca: **Ewald Alphonso**
> ""Okay, gentlemen. Let's not ponder over this any longer. My intention was not to start an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Justice for Soll's oppression has nothing to do with his energy policies, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's done is done. Let's not start an argument now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The party forced me to revert your amendment to the EPA. I had to compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You may be right. I should have seen this coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't try to pin your own failures on me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Ewald Alphonso**
> ""If you say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Ewald Alphonso**
> ""Of course you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Ewald Alphonso**
> ""You should have. Because I warned you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Ewald Alphonso**
> "Anyway... Let's not dwell on this any longer. My intention was not to start an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[181]`
Mówca: **Ewald Alphonso**
> ""I was happy to find out that the royals over there appear to be in favor of pursuing friendlier relations with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Ewald Alphonso**
> ""I still don't think they will do anything to harm their connection with Rumburg, but cooperating with them was the right call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Tarquin Soll**
> ""You're fond of the monarchists now, Ewald? They must be filling your pockets with Rizian gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Ewald Alphonso**
> ""For Dast's sake, Mr. Soll, try to see the positive in what I do. For once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Ewald Alphonso**
> ""After all, thanks to them, Gasom is still up and running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[195]`
  - -> `[197]`
  - -> `[198]`

### Węzeł `[192]`
Mówca: **Ewald Alphonso**
> ""Thanks to their joint investment with our government, Gasom is still up and running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`
  - -> `[196]`
  - -> `[198]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks to the investment that *I* approved, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see that the strategy we came up is paying off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see the positive results of their investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what do you think about our Rizian partners?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's not forget, Ewald. Rizia isn't doing this for charity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I still wouldn't rely on a kingdom -- one that has close ties with Queen Livingston especially.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[199]`
Mówca: **Tarquin Soll**
> ""How about you claim responsibility for once? It is your fault that a giant like Gasom was brought to the brink of collapse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Tarquin Soll**
> ""Admit it. It was too much of a responsibility for you. A man with your profit-focused mentality should have never been given the keys to such a vital sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Ewald Alphonso**
> ""I've done ever-"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[202]`
Mówca: **Narrator**
> "Ewald's upper lip curled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`
  - -> `[207]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Soll is not wrong. You are always looking for someone else to blame, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's done is done, Mr. Soll. Let's not start an argument now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Ewald Alphonso**
> ""You're right. Let's not dwell on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[206]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Let's not go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, it's good to see the positive results of our investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, it's good to see the positive results of their investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[212]`
Mówca: **Ewald Alphonso**
> ""A curious bunch, but they do know the gas business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Ewald Alphonso**
> ""They are an important regional player, Mr. Rayne. One that we should keep close to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Ewald Alphonso**
> ""Oh. And they have great food and wine. Spend some time there and you'll realize how overrated Lespian cuisine is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""Truth be told, it was an incredible help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""I wouldn't have guessed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""You are right to have your reservations but they are reliable business partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[218]`
Mówca: **Ewald Alphonso**
> ""Of course, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Ewald Alphonso**
> ""We can't thank you enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[220]`
Mówca: **Ewald Alphonso**
> ""Truth be told, it was an incredible help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[221]`
Mówca: **Ewald Alphonso**
> ""I'm getting old, gentlemen. Surely I've earned the right to a comfortable retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Tarquin Soll**
> ""You and Mr. Rayne have earned nothing but my disdain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Tarquin Soll**
> ""Together, you are living proof of the dangers of Alphonsonomics and the free market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`
  - -> `[230]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Booming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Booming == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Gasom_Booming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Gasom_Booming == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Gasom_Booming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Ewald Alphonso**
> ""You recouped your investment, didn't you? The leap of faith was justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This isn't the fault of the free market. It's Mr. Alphonso's own selfishness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right, Colonel. I see now that your energy protection laws were put in place for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""'Dangers' would be overblown. Sordland and Gasom have both benefited from this deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[231]`
Mówca: **Ewald Alphonso**
> ""If you had your way and the EPA remained unchanged, Gasom would have gone bankrupt and thousands of good Sordish men and women would be out of work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Tarquin Soll**
> ""You're the one who ran Gasom into the ground, Mr. Alphonso. You should not have had to ask for foreign assistance in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[233]`
Mówca: **Ewald Alphonso**
> ""If I may gently remind you, it was never my intention to do away with the EPA altogether. That was a pure Anton Rayne touch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[234]`
Mówca: **Ewald Alphonso**
> ""His laws as written would have choked the life out of Gasom. But I did see the wisdom in putting a cap on foreign ownership. You're the one who wanted to do away with it entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[235]`
Mówca: **Ewald Alphonso**
> ""Indeed. The value of Sordland's investment has only gone up since the Anraka purchase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[236]`
Mówca: **Tarquin Soll**
> ""And you, Mr. Rayne. By overturning my Energy Protection Act, you set the stage for exactly this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Ewald Alphonso**
> ""Besides which, the value of Sordland's own shares in Gasom has never been higher.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[249]`

### Węzeł `[241]`
Mówca: **Ewald Alphonso**
> ""And surely you knew this might happen when you removed the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[253]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I was naive enough to think all your talk about protecting your legacy meant you'd hold on to your shares.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[243]`
Mówca: **Ewald Alphonso**
> ""Absolutely not. But now that they own such a large stake in Gasom, they would never damage its value by provoking conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Ewald Alphonso**
> ""And the value of Sordland's own shares in Gasom has never been higher. This is truly a win-win solution for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Ewald Alphonso**
> ""I do wish you had taken me up on my offer. Sordland would have more than recouped its investment by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[254]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad about that. Our co-investment with Rizia was the right call in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right. The next time you offer me a deal, I'll take it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I still don't feel entirely comfortable that Rumburg has so much leverage over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Ewald Alphonso**
> ""To be honest, neither do I. That's why I never advocated for the complete removal of the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't count on Rumburg ending up with the largest stake in Gasom, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I still think not investing was the right call. It wasn't up to Sordland to fix Gasom's mess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Ewald Alphonso**
> ""Oh, I'm out of the deal-making business these days. You're better off asking Gus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[256]`
Mówca: **Ewald Alphonso**
> ""It doesn't make a difference to me. Just pointing out that we both could have struck it rich.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[257]`
Mówca: **Ewald Alphonso**
> ""As long as Rizia, Rumburg and Sordland all remain on friendly terms, it'll be smooth sailing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""My legacy is my company, Mr. Rayne. My shares are meaningless if the company stagnates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[259]`
Mówca: **Ewald Alphonso**
> ""President Rayne, you didn't invest enough to help keep my company afloat, while opening the door to foreigners who were willing to do exactly that. What did you think would happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Ewald Alphonso**
> ""Rumburg and Rizia were never my first choices. But they came to Gasom's rescue when Sordland would not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Tarquin Soll**
> ""They would not even have had that opportunity if you two hadn't begun meddling with the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Tarquin Soll**
> ""Together, you are living proof of the dangers of Alphonsonomics and the free market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This isn't the fault of the free market. It's Mr. Alphonso's own selfishness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right, Colonel. I see now that your energy protection laws were put in place for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Ewald Alphonso**
> ""I will say that I never advocated for the complete removal of the EPA. That was purely Anton Rayne's decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't blame me for your own selfishness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's not play the blame game. We have to focus on the here and now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I removed the EPA as a favor to Gasom. And you returned that favor by selling your shares to our enemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Ewald Alphonso**
> ""I never asked for the removal of the EPA. I wanted to put Sordish interests first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is my fault, Colonel. I never should have removed the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Ewald Alphonso**
> ""I had a feeling that despite all of our conversations, you never truly grasped how much Gasom meant to me or Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true && BaseGame.Turn03_Admin_EnergyProtectionAct_Removed == true && (BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true || BaseGame.Decision_Turn06_GasomStake_SellOneThird == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true && BaseGame.Turn03_Admin_EnergyProtectionAct_Removed == true && (BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true || BaseGame.Decision_Turn06_GasomStake_SellOneThird == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  and  Variable["BaseGame.Turn03_Admin_EnergyProtectionAct_Removed"] == true  and  (Variable["BaseGame.Decision_Turn06_GasomStake_SellTwoThird"] == true  or  Variable["BaseGame.Decision_Turn06_GasomStake_SellOneThird"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true && BaseGame.Turn03_Admin_EnergyProtectionAct_Removed == true && (BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true || BaseGame.Decision_Turn06_GasomStake_SellOneThird == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  and  Variable["BaseGame.Turn03_Admin_EnergyProtectionAct_Removed"] == true  and  (Variable["BaseGame.Decision_Turn06_GasomStake_SellTwoThird"] == true  or  Variable["BaseGame.Decision_Turn06_GasomStake_SellOneThird"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[278]`
Mówca: **Ewald Alphonso**
> ""But removing the EPA for just long enough to maximize the value of your investment, then selling your shares before forcing our foreign investors to sell theirs and bankrupting our company?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Ewald Alphonso**
> ""You're a snake, Rayne. Pure and simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[280]`
Mówca: **Ewald Alphonso**
> ""But I hope you see now how much damage you've done to our country's energy industry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was never my intention to bankrupt Gasom. I made my decisions with the company's interests at heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I was forced to revert the EPA to 10 percent foreign ownership. The USP made me do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Tarquin Soll**
> ""Blaming the USP for your own mistakes. That's an Ewald Alphonso move if I ever heard of one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[287]`
Mówca: **Tarquin Soll**
> ""My footsteps? If it were up to me, Gasom would have been nationalized long ago to prevent exactly this from happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[288]`
Mówca: **Ewald Alphonso**
> ""Excuse me, but that's bullshit and you know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Ewald Alphonso**
> ""Leave me out of this. I've only ever tried to do what's right for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Ewald Alphonso**
> ""All you had to do was leave your investment and the EPA untouched, Mr. Rayne. But that somehow proved too difficult for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Narrator**
> "The three of us glared at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was never my intention to bankrupt Gasom. I made my decisions with the company's interests at heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I was forced to revert the EPA to 10 percent foreign ownership. The USP made me do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry, Mr. Alphonso. But you got through it all unscathed, didn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Ewald Alphonso**
> ""Of course I did. But Gasom is as much a part of my legacy as my presidency. And now it's been tainted forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[296]`
Mówca: **Ewald Alphonso**
> ""Do not blame your own shortcomings on your party, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Ewald Alphonso**
> ""Excuse me, but that is bullshit and you know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Narrator**
> "We glared at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Gasom_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Gasom_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Gasom_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
Mówca: **Tarquin Soll**
> ""What are you talking about, Alphonso? I've read the reports. Your Gasom is doing fine without foreign investment propping it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Ewald Alphonso**
> ""We are barely turning a profit. All it would take is a bad few months for it all to come crashing down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[304]`
Mówca: **Tarquin Soll**
> ""You cannot lay your own failures at the feet of the state, Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Tarquin Soll**
> ""Admit it. A man with your profit-focused mentality should have never been given the keys to such a vital sector, let alone the presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[306]`
Mówca: **Tarquin Soll**
> ""Then that is your fault. Not the Sordish state's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Just then, FC Anrica's star midfiel..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `222` (*Sordland/Turn10/Personal_FCAnricaDerby*), Węzeł `[120]`
