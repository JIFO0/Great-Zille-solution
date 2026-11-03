# Rizia/Turn 7/Fighting Assistance Unfriendly

- **ID konwersacji:** `380`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/380_Fighting_Assistance_Unfriendly.md`
- **Liczba węzłów dialogowych:** 160
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Pales_War`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF`
- `RiziaDLC.Situation_Economy_ArmsExporter`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs`
- `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles`
- `RiziaDLCIsolated.Turn07_Duel_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Army_Unit_Ship_Total`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_AirStrikeCooldown`
- `RiziaDLC.Resources_Military_DerdianMercenaries`
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

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[536]`
- Węzeł `[105]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[500]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 18
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Zille_ViolentResistancePower`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[51]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_...`
- Węzeł `[59]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[68]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[98]` (Paskal Beniwoll): `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePow...`
- Węzeł `[102]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] = false; Variable["RiziaDLC.Arm...`
- Węzeł `[103]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] = true;`
- Węzeł `[104]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] = true;`
- Węzeł `[126]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `377` (*Rizia/Turn 7/FPnT_DerdiaNegotiations*), Węzeł `[536]`

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
  - -> `[151]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[157]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you know, we're at war. I would humbly ask for the assistance of your great warrior culture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[7]`
Mówca: **Jorga Azmal**
> ""Our great warrior culture. I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Jorga Azmal**
> ""But if you insist, I can sell you our latest missile system. It's good enough to compete with Lespia's, but it does not come cheap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[13]`

### Węzeł `[9]`
Mówca: **Jorga Azmal**
> ""To be honest, it makes no difference to me who is in charge of the Pales peninsula.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was thinking of something with a little more finesse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds perfect. But I don't think my kingdom can afford such a mighty weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To safeguard God's creations, we must invoke the power of the heavens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget <= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget <= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget <= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""If you're referring to our mercenaries, I'm afraid I can't help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. The Palesians won't know what hit them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
Mówca: **Jorga Azmal**
> ""That's a shame, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[19]`
Mówca: **Jorga Azmal**
> ""My Disciples will not risk their lives for a kingdom where their right to practice their religion is not recognized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[20]`
Mówca: **Jorga Azmal**
> ""Once you buy them, they are yours to wield at your discretion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Sal Ignacius**
> ""Remember, these weapons are to be wielded with mercy, not wrath. Correct, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""You don't need to impress me with religious talk, Your Majesty. This is just business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""Do we have a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[28]`
  - -> `[29]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Yes. I thank you for your willingness to aid our military, despite our religious differences." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""Yes. I thank you for your willingness to aid our military, despite our religious differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Yes. Your weapons were all I came here for, anyway." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""Yes. Your weapons were all I came here for, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Jorga Azmal**
> ""Rizia has laid the foundations for the acceptance of Golcondism. I have not lost hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[27]`
Mówca: **Jorga Azmal**
> ""May they serve you well against the godless Palesians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Rizia does not need or want your missiles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I'd rather you did something else for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[30]`
Mówca: **Jorga Azmal**
> ""Our mercenaries have been helping win wars since the days of the Empire of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Jorga Azmal**
> ""May God bless and save your troops, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""You saw my Disciples earlier. Imagine a larger team, just as trained, wielding sophisticated weaponry and stealth technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They won't fight for Rizia. But maybe they will fight *against* Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Men of honor. I appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we will emancipate Zille and humiliate Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Jorga Azmal**
> ""But they will not fight for a kingdom that does not recognize their right to practice their religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[36]`
  - -> `[37]`
  - -> `[56]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not even for a fee?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""And perhaps, lay the foundation for Golcondist acceptance in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[70]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are at risk of losing the territory of Zille to Wehlen. I would humbly call upon your great warrior culture for assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[43]`
Mówca: **Jorga Azmal**
> ""Our great warrior culture. I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget <= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget <= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget <= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Jorga Azmal**
> ""The missiles are just business. Once you buy them, they're yours to use at your discretion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[38]`
  - -> `[94]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1; RiziaDLC.Resources_Budget -= 3;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[52]`
Mówca: **Jorga Azmal**
> ""You would rather continue to appease Smolak? 'It is easier to calm a storm with whispers than satisfy the whims of a madman.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[53]`
Mówca: **Jorga Azmal**
> ""They are scared of nothing. Have you come here to negotiate with me, or to belittle my people and our way of life?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""That depends, Your Majesty. What else do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[55]`
Mówca: **Jorga Azmal**
> ""Then it is up to God to forgive you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Or maybe they're just scared of losing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Jorga Azmal**
> ""We will not fail you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Fine. Rizia will withdraw from Wehlen's anti-BFF operations in exchange for the aid of Derdian mercenaries in the Zille resistance movement." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. Rizia will withdraw from Wehlen's anti-BFF operations in exchange for the aid of Derdian mercenaries in the Zille resistance movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[60]`
Mówca: **Jorga Azmal**
> ""I am glad you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will regretfully be continuing our participation in Wehlen's anti-BFF operations. I withdraw my request for mercenary aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""I would consider lending you my Disciples' services. For a fee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Sounds like a plan. Your men are hired." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Sounds like a plan. Your men are hired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[67]`
Mówca: **Jorga Azmal**
> ""It is true that Smolak's anti-Golcondist regime has been a constant source of grief for myself and my countrymen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't sound like I can count on their loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, please disregard my request. This is not the way that we get Zille back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[71]`
Mówca: **Jorga Azmal**
> ""You can count on them to do serious damage to the Wehzek enemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[70]`

### Węzeł `[72]`
Mówca: **Sal Ignacius**
> ""Rizia would never engage in persecution, Supreme Wiseman. Our cooperation with Wehlen is an anti-terrorist measure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Jorga Azmal**
> ""It is not 'terror' to defend one's right to exist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[76]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had no choice. Making that deal with Wehlen was the only way to get Zille back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sympathize with what the Bludish have gone through. That does not mean violence is the answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fully agree with you. I don't want to participate in Wehlen's anti-Blud operations any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Jorga Azmal**
> ""If you are so confident Zille will be returned through cooperation with Wehlen, why are you even inquiring about my mercenaries?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[78]`
Mówca: **Jorga Azmal**
> ""Then what is the answer? Meekly allowing the eradication of their entire people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[79]`
Mówca: **Jorga Azmal**
> ""Then prove it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[80]`
Mówca: **Jorga Azmal**
> ""Not as long as Rizia continues to aid Wehlen in its campaign of anti-Golcondist persecution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[81]`
Mówca: **Jorga Azmal**
> ""But as long as Rizia is aiding Wehlen in its campaign of persecution, we will not involve ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, our treasury is low on funds. Can I compensate you some other way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[86]`
Mówca: **Jorga Azmal**
> ""We will do business with Rizia. But no more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[87]`
Mówca: **Jorga Azmal**
> ""No, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Jorga Azmal**
> ""This is my compromise. End your cooperation with Wiktor Smolak, and I will sell you a small mercenary detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[61]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Azmal looked irritated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[93]`
Mówca: **Narrator**
> "He paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does a spiritual leader like yourself want with money?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Jorga Azmal**
> ""I have a country to run and few trade partners, Your Majesty. Engaging with the material world is a necessity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[70]`

### Węzeł `[96]`
Mówca: **Jorga Azmal**
> ""But very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[97]`
Mówca: **Jorga Azmal**
> ""If the price was right, I could lend you a small detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Resources_Budget -= 1; RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[99]`
Mówca: **Jorga Azmal**
> ""If only for the purpose of striking back at Wiktor Smolak and his anti-Golcondist regime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I spoke too soon. My kingdom cannot afford to hire your men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[101]`
Mówca: **Narrator**
> "He paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF = false;
RiziaDLC.Army_Unit_Ship_Total += 2;
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF = true;
RiziaDLCSupport.Journal_Turn07_BFF_StopBearTrap = true; RiziaDLC.Resources_Military_DerdianMercenaries = true;
RiziaDLC.Resources_Military_DerdianMercenaries_Zille = true; 
RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries = true;
RiziaDLCSupport.News_Turn07_RH_AntiBFFCancelled = true;
RiziaDLCSupport.News_Turn07_V_AntiBFFCancelled = true;
RiziaDLCSupport.News_Turn07_G_SouthernMigrationRouteOpens = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] = false;
Variable["RiziaDLC.Army_Unit_Ship_Total"] = Variable["RiziaDLC.Army_Unit_Ship_Total"] + 2;
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_BFF_StopBearTrap"] = true;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] = true;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries"] = true;
Variable["RiziaDLCSupport.News_Turn07_RH_AntiBFFCancelled"] = true;
Variable["RiziaDLCSupport.News_Turn07_V_AntiBFFCancelled"] = true;
Variable["RiziaDLCSupport.News_Turn07_G_SouthernMigrationRouteOpens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Derdia Requests])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `377` (*Rizia/Turn 7/FPnT_DerdiaNegotiations*), Węzeł `[500]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Supreme Wiseman, your missile technology is superior to anything we could achieve in Rizia. I want to purchase one of your systems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[107]`
Mówca: **Narrator**
> "He didn't smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_Duel_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[111]`
Mówca: **Narrator**
> "He smiled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Jorga Azmal**
> ""Indeed, our defense agency's research and development department is the pride and joy of the Silver Garrison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Jorga Azmal**
> ""But I am curious why Rizia is in need of such technology. You are not at war, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[128]`
  - -> `[115]`
  - -> `[119]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I want it to stay that way. The more intimidating our weapons, the less our enemies will want to provoke us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ArmsExporter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ArmsExporter == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_ArmsExporter == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[118]`
Mówca: **Jorga Azmal**
> ""I understand. We ourselves developed this technology in pursuit of peace, not aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A holy reckoning may soon be at our doorstep. We must be prepared to wield the instruments of justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Jorga Azmal**
> ""I am sorry, Your Majesty, but I will have to deny this request. Our missiles were developed in pursuit of peace, not economic gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Narrator**
> "He pressed his fingers together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Jorga Azmal**
> ""With the way things are going in the world, such a reckoning may indeed be close at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We in Rizia are developing a robust weapons export trade. I can sell these missiles to countries that otherwise would never deal with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fear Merkopa may be on the cusp of a major geopolitical conflict. I don't want to leave Rizia defenseless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[129]`
Mówca: **Narrator**
> "He scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is an economic move. Rizia can sell these missiles to countries that otherwise would never deal with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Jorga Azmal**
> ""What, so that they may rain back down on our heads?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[132]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[133]`
Mówca: **Jorga Azmal**
> ""I sense it in the air as well. Each of us should be prepared to hold our own against the godless so-called 'superpowers'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I understand that. For such a priceless treasure, I will pay whatever you ask." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""I understand that. For such a priceless treasure, I will pay whatever you ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
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
  - -> `[141]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[140]`
Mówca: **Jorga Azmal**
> ""I am prepared to make a deal. But know that this weaponry is the product of years of hard work. It cannot be undervalued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[145]`
  - -> `[146]`
  - -> `[148]`

### Węzeł `[141]`
Mówca: **Sal Ignacius**
> ""Remember, these weapons are to be wielded with mercy, not wrath. Correct, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Jorga Azmal**
> ""Wrath can be a powerful tool in the hands of the righteous, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[143]`
Mówca: **Jorga Azmal**
> ""You are disrespecting our craftsmanship. Perhaps it's for the best that you don't buy it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[144]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wouldn't you be willing to lower the price as part of a good-faith agreement between neighbors?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate that. But such a price does not fit in with my economic plans for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Jorga Azmal**
> ""Perhaps that's just as well. It would be a great risk to place such a powerful weapon in the hands of a man I don't fully trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't delude yourself, Azmal. Nobody else is willing to trade with you. Any offer I give you is the best you're going to get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Narrator**
> "He shook his head angrily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
