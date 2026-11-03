# Rizia/Turn 7/Fighting Assistance Friendly

- **ID konwersacji:** `381`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/381_Fighting_Assistance_Friendly.md`
- **Liczba węzłów dialogowych:** 180
- **Liczba wyborów gracza:** 37

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_GoldenGuard_Total`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF`
- `RiziaDLC.Situation_Economy_ArmsExporter`
- `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_GolcondistCommunity_Happy`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles`
- `RiziaDLCIsolated.Turn07_Duel_Success`
- `RiziaDLCIsolated.Turn07_Duel_TitusFights`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Army_Unit_Mercenary_Total`
- `RiziaDLC.Army_Unit_Ship_Total`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_AirStrikeCooldown`
- `RiziaDLC.Resources_Military_DerdianMercenaries`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Pales`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Resources_Military_DerdianMissiles`
- `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCIsolated.Turn07_Derdia_FavorsDone`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles`
- `RiziaDLCSupport.Journal_Turn07_BFF_StopBearTrap`
- `RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries`
- `RiziaDLCSupport.Journal_Turn07_Derdia_Missiles`
- `RiziaDLCSupport.News_Turn07_G_SouthernMigrationRouteOpens`
- `RiziaDLCSupport.News_Turn07_RH_AntiBFFCancelled`
- `RiziaDLCSupport.News_Turn07_V_AntiBFFCancelled`
- `RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped`
- `RiziaDLCSupport.Reports_Turn07_PalesInvasion_DerdianMercenaries`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[575]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 20
- **Węzły modyfikujące stan gry:** 15

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Pales`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCSupport.Reports_Turn07_PalesInvasion_DerdianMercenaries`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[50]` (Paskal Beniwoll): `Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable["RiziaDLC.Army_Unit_Mercenary_Total"] +...`
- Węzeł `[53]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true; Variable["RiziaDLC.Resources_Budg...`
- Węzeł `[54]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true; Variable["RiziaDLC.Resources_Mili...`
- Węzeł `[81]` (Paskal Beniwoll): `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePow...`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] = false; Variable["RiziaDLC.Arm...`
- Węzeł `[102]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] = true;`
- Węzeł `[103]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] = true;`
- Węzeł `[107]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- *...oraz 7 innych węzłów ze skryptami.*

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `377` (*Rizia/Turn 7/FPnT_DerdiaNegotiations*), Węzeł `[575]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[177]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are at war, Supreme Wiseman. I would humbly call upon your great warrior culture for assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are at risk of losing the territory of Zille to Wehlen. I would humbly call upon your great warrior culture for assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[8]`
Mówca: **Narrator**
> "He smiled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_Duel_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[12]`
Mówca: **Jorga Azmal**
> ""Judging by how the Duel of Generosity ended, you could use our help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
Mówca: **Jorga Azmal**
> ""We are happy to help our brethren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "He appeared flattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[15]`
Mówca: **Jorga Azmal**
> ""We are willing to sell you our latest missile system. Even the Lespians will have trouble competing with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[19]`
  - -> `[17]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was thinking of something with a little more finesse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To safeguard God's creations, we must invoke the power of the heavens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
Mówca: **Jorga Azmal**
> ""In that case, Your Majesty, what you need is human power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. The Palesians won't know what hit them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Sal Ignacius**
> ""Remember, these weapons are to be wielded with mercy, not wrath. Correct, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Jorga Azmal**
> ""Derdian mercenaries have helped win wars since the days of the Empire of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""Ah. I am sorry that He has not blessed you with more prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""Wrath can be a powerful tool in the hands of the righteous, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Jorga Azmal**
> ""We can also offer you our finest mercenaries. They have been helping win wars since the days of the Empire of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In case of emergency, a surge of Derdian mercenaries could certainly be of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are already deploying my Golden Guard. Your mercenaries would be redundant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm imagining that right now. It scares me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[29]`
Mówca: **Jorga Azmal**
> ""You saw my Disciples earlier. Imagine a larger team, just as trained, wielding sophisticated weaponry and stealth technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[38]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_GoldenGuard_Total > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_GoldenGuard_Total > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_GoldenGuard_Total > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_TitusFights"] == true  and  Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_TitusFights"] == true  and  Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Jorga Azmal**
> ""I see. And are all your Golden Guards like Captain Gordion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[37]`
Mówca: **Jorga Azmal**
> ""If the rest of your Golden Guard is as skilled as Captain Gordion, that may be true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can they be relied on to fight for the Rizian Crown?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Jorga Azmal**
> ""They will fight for what they believe in, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Jorga Azmal**
> ""For a fee, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""It will scare your enemies more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[42]`
Mówca: **Sal Ignacius**
> ""As long as there is a way to rein them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WYBÓR GRACZA: ""I have no need for your mercenaries. But I will gladly purchase your missiles." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""I have no need for your mercenaries. But I will gladly purchase your missiles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Mercenary_Total += 1; RiziaDLC.Resources_Military_DerdianMercenaries = true; 
RiziaDLC.Resources_Military_DerdianMercenaries_Pales = true;
RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries = true;
RiziaDLCSupport.Reports_Turn07_PalesInvasion_DerdianMercenaries = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable["RiziaDLC.Army_Unit_Mercenary_Total"] + 1;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] = true;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Pales"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_PalesInvasion_DerdianMercenaries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind. This is Rizia's war to fight. I don't want Derdia getting involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""My kingdom does not require a missile system, but we will hire your mercenaries to fight Pales." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""My kingdom does not require a missile system, but we will hire your mercenaries to fight Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Budget -= 3;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1;
RiziaDLC.Resources_Budget -= 2;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[55]`
Mówca: **Jorga Azmal**
> ""We will help you fight with honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[56]`
Mówca: **Narrator**
> "He cracked a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Jorga Azmal**
> ""Judging by how the Duel of Generosity ended, you could use our help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would happily avail myself of either of those services. Alas, my kingdom cannot afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[59]`
Mówca: **Jorga Azmal**
> ""I respect your decision, Your Majesty. I wish you strength for the battles ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_Duel_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[63]`
Mówca: **Jorga Azmal**
> ""We are happy to help our brethren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[64]`
Mówca: **Narrator**
> "He seemed pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In case of emergency, a surge of Derdian mercenaries could certainly be of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
Mówca: **Jorga Azmal**
> ""They will fight for what they believe in, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can they be relied on to fight for the Rizian Crown?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[68]`
Mówca: **Jorga Azmal**
> ""My men will not fight for a kingdom that is complicit in the persecution of the Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[69]`
Mówca: **Jorga Azmal**
> ""It will scare your enemies more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[70]`
Mówca: **Sal Ignacius**
> ""As long as there is a way to rein them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm imagining that right now. It scares me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Jorga Azmal**
> ""Our mercenaries have been helping win wars since the days of the Empire of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Jorga Azmal**
> ""You saw my Disciples earlier. Imagine a larger team, just as trained, wielding sophisticated weaponry and stealth technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[67]`
  - -> `[71]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Jorga Azmal**
> ""Normally, Derdia would charge you for their services. But my Disciples are eager to help Rizia reclaim its land from the anti-Golcondist Wehzeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[82]`
  - -> `[85]`

### Węzeł `[78]`
Mówca: **Jorga Azmal**
> ""I have one major concern. Your cooperation with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Free mercenaries? I can't say no to that. I will accept your aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Jorga Azmal**
> ""Excellent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Resources_Military_DerdianMercenaries = true; 
RiziaDLC.Resources_Military_DerdianMercenaries_Zille = true;
RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] = true;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They may do so if they wish. But I don't want them harming civilians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Jorga Azmal**
> ""That is not our way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Rizia will withdraw from Wehlen's anti-BFF operations in exchange for the aid of Derdian mercenaries in the Zille resistance movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, I don't want the situation getting out of hand in Zille. Your Disciples should stay out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Jorga Azmal**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[87]`
Mówca: **Sal Ignacius**
> ""Rizia would never engage in persecution, Supreme Wiseman. Our cooperation with Wehlen is an anti-terrorist measure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Jorga Azmal**
> ""It is not 'terror' to defend one's right to exist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[94]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had no choice. Making that deal with Wehlen was the only way to get Zille back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sympathize with what the Bludish have gone through. That does not mean violence is the answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Jorga Azmal**
> ""If you are so confident Zille will be returned through cooperation with Wehlen, why are you even inquiring about my mercenaries?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[95]`

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""Then what is the answer? Meekly allowing the eradication of their entire people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Jorga Azmal**
> ""You have the power to end this, Your Majesty. Just say the word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fully agree with you. I don't want to aid Wehlen's anti-Blud operations any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will regretfully be continuing our participation in Wehlen's anti-BFF operations. I withdraw my request for mercenary aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Azmal sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Jorga Azmal**
> ""I don't understand this, Your Majesty. But very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Azmal smiled and bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF = false; 
RiziaDLC.Army_Unit_Ship_Total += 2;
RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Resources_Military_DerdianMercenaries = true; 
RiziaDLC.Resources_Military_DerdianMercenaries_Zille = true;
RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries = true;
RiziaDLCSupport.Journal_Turn07_BFF_StopBearTrap = true; RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF = true;
RiziaDLCSupport.News_Turn07_RH_AntiBFFCancelled = true;
RiziaDLCSupport.News_Turn07_V_AntiBFFCancelled = true;
RiziaDLCSupport.News_Turn07_G_SouthernMigrationRouteOpens = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] = false;
Variable["RiziaDLC.Army_Unit_Ship_Total"] = Variable["RiziaDLC.Army_Unit_Ship_Total"] + 2;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] = true;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_BFF_StopBearTrap"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] = true;
Variable["RiziaDLCSupport.News_Turn07_RH_AntiBFFCancelled"] = true;
Variable["RiziaDLCSupport.News_Turn07_V_AntiBFFCancelled"] = true;
Variable["RiziaDLCSupport.News_Turn07_G_SouthernMigrationRouteOpens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[100]`
Mówca: **Jorga Azmal**
> "'St. Wruhec has shown you the way. We are glad to be of assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""We have a long war ahead of us. We will purchase both your missiles and the service of your mercenaries." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""We have a long war ahead of us. We will purchase both your missiles and the service of your mercenaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[108]`
  - -> `[47]`
  - -> `[51]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Supreme Wiseman, your missile technology is superior to anything we could achieve in Rizia. I want to purchase one of your systems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[113]`
Mówca: **Narrator**
> "He smiled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_Duel_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[117]`
Mówca: **Narrator**
> "He appeared flattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Jorga Azmal**
> ""Indeed, our defense agency's research and development department is the pride and joy of the Silver Garrison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Jorga Azmal**
> ""But I am curious why Rizia is in need of such technology. You are not at war, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[125]`
  - -> `[121]`
  - -> `[126]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I want it to stay that way. The more intimidating our weapons, the less our enemies will want to provoke us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ArmsExporter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ArmsExporter == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_ArmsExporter == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We in Rizia are developing a robust weapons export trade. I can sell these missiles to countries that otherwise would never deal with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fear Merkopa may be on the cusp of a major geopolitical conflict. I don't want to leave Riizia defenseless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A holy reckoning may soon be at our doorstep. We must be prepared to wield the instruments of justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is an economic move. Rizia can sell these missiles to countries that otherwise would never deal with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Jorga Azmal**
> ""What, so that they may rain back down on our heads?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "He scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Jorga Azmal**
> ""I am sorry, Your Majesty, but I will have to deny this request. Our missiles were developed in pursuit of peace, not economic gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[134]`
Mówca: **Narrator**
> "He pressed his fingers together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Jorga Azmal**
> ""With the way things are going in the world, such a reckoning may indeed be close at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[136]`
Mówca: **Jorga Azmal**
> ""Yes, I sense it in the air as well. Each of us should be prepared to hold our own against the godless so-called 'superpowers'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[137]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Jorga Azmal**
> ""Yes, I understand. We ourselves developed this technology in pursuit of peace, not aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""I understand that. For such a priceless treasure, I will pay whatever you ask." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""I understand that. For such a priceless treasure, I will pay whatever you ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1;
RiziaDLC.Resources_Budget -= 3;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[144]`
Mówca: **Jorga Azmal**
> ""I am prepared to make a deal. But know that this weaponry is the product of years of hard work. It cannot be undervalued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[168]`
  - -> `[163]`
  - -> `[152]`
  - -> `[167]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[148]`
Mówca: **Sal Ignacius**
> ""Remember, these weapons are to be wielded with mercy, not wrath. Correct, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Jorga Azmal**
> ""Wrath can be a powerful tool in the hands of the righteous, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wouldn't you be willing to lower the price as part of a good-faith agreement between men of God?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate that. But such a price does not fit in with my economic plans for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Jorga Azmal**
> ""If you truly insist, I will give your kingdom a discount. But only because I trust you to wield it on behalf of all Rizians, including Golcondists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[163]`

### Węzeł `[157]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[158]`
**[WYBÓR GRACZA: ""I will. You have my word." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""I will. You have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1;
RiziaDLC.Resources_Budget -= 2;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I changed my mind. I'd rather not purchase missiles from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Jorga Azmal**
> ""That is a shame. I assure you, you would have been the envy of GRACE.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[165]`
Mówca: **Jorga Azmal**
> ""You are disrespecting our craftsmanship. Perhaps it's for the best that you don't buy it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Azmal. Nobody else in Merkopa is willing to trade with Derdia. Any price I offer is the best you're going to get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Happy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Happy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Happy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_GolcondistCommunity_Happy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Happy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
