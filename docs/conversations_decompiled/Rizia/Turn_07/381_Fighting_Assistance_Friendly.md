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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""We are at war, Supreme Wiseman. I would humbly call upon your great warrior cultu..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_Fightin...` | `[14]` **Narrator**: "He appeared flattered."<br>`[8]` **Narrator**: "He smiled slightly." |
| `[7]` | **""We are at risk of losing the territory of Zille to Wehlen. I would humbly call up..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_Fightin...` | `[64]` **Narrator**: "He seemed pleased."<br>`[56]` **Narrator**: "He cracked a smile." |
| `[16]` | **""I was thinking of something with a little more finesse.""** | `[15]` **Jorga Azmal**: ""We are willing to sell you our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Jorga Azmal**: ""In that case, Your Majesty, wha..." |
| `[17]` | **""To safeguard God's creations, we must invoke the power of the heavens.""** | `[15]` **Jorga Azmal**: ""We are willing to sell you our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Jorga Azmal**: ""Exactly."" |
| `[19]` | **""Great. The Palesians won't know what hit them.""** | `[15]` **Jorga Azmal**: ""We are willing to sell you our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Sal Ignacius**: ""Remember, these weapons are to ..." |
| `[26]` | **""In case of emergency, a surge of Derdian mercenaries could certainly be of service.""** | `[29]` **Jorga Azmal**: ""You saw my Disciples earlier. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Sal Ignacius**: ""As long as there is a way to re..." |
| `[27]` | **""We are already deploying my Golden Guard. Your mercenaries would be redundant.""** | `[29]` **Jorga Azmal**: ""You saw my Disciples earlier. I..." | `Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] > 0` | *Brak zmian stanu* | `[36]` **Jorga Azmal**: ""I see. And are all your Golden ..."<br>`[37]` **Jorga Azmal**: ""If the rest of your Golden Guar..." |
| `[28]` | **""I'm imagining that right now. It scares me.""** | `[29]` **Jorga Azmal**: ""You saw my Disciples earlier. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Jorga Azmal**: ""It will scare your enemies more."" |
| `[38]` | **""Can they be relied on to fight for the Rizian Crown?""** | `[29]` **Jorga Azmal**: ""You saw my Disciples earlier. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Jorga Azmal**: ""They will fight for what they b..." |
| `[46]` | **""I have no need for your mercenaries. But I will gladly purchase your missiles." [..."** | `[36]` **Jorga Azmal**: ""I see. And are all your Golden ..."<br>`[37]` **Jorga Azmal**: ""If the rest of your Golden Guar..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 2` | `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] =...`<br>`Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = V...` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[51]` | **""Never mind. This is Rizia's war to fight. I don't want Derdia getting involved.""** | `[36]` **Jorga Azmal**: ""I see. And are all your Golden ..."<br>`[37]` **Jorga Azmal**: ""If the rest of your Golden Guar..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Jorga Azmal**: ""I respect your decision, Your M..." |
| `[52]` | **""My kingdom does not require a missile system, but we will hire your mercenaries t..."** | `[36]` **Jorga Azmal**: ""I see. And are all your Golden ..."<br>`[37]` **Jorga Azmal**: ""If the rest of your Golden Guar..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable...` | `[55]` **Jorga Azmal**: ""We will help you fight with hon..." |
| `[58]` | **""I would happily avail myself of either of those services. Alas, my kingdom cannot..."** | `[36]` **Jorga Azmal**: ""I see. And are all your Golden ..."<br>`[37]` **Jorga Azmal**: ""If the rest of your Golden Guar..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false` | *Brak zmian stanu* | `[22]` **Jorga Azmal**: ""Ah. I am sorry that He has not ..." |
| `[65]` | **""In case of emergency, a surge of Derdian mercenaries could certainly be of service.""** | `[73]` **Jorga Azmal**: ""You saw my Disciples earlier. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Sal Ignacius**: ""As long as there is a way to re..." |
| `[67]` | **""Can they be relied on to fight for the Rizian Crown?""** | `[73]` **Jorga Azmal**: ""You saw my Disciples earlier. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Jorga Azmal**: ""They will fight for what they b..." |
| `[71]` | **""I'm imagining that right now. It scares me.""** | `[73]` **Jorga Azmal**: ""You saw my Disciples earlier. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Jorga Azmal**: ""It will scare your enemies more."" |
| `[79]` | **""Free mercenaries? I can't say no to that. I will accept your aid.""** | `[77]` **Jorga Azmal**: ""Normally, Derdia would charge y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Jorga Azmal**: ""Excellent."" |
| `[82]` | **""They may do so if they wish. But I don't want them harming civilians.""** | `[77]` **Jorga Azmal**: ""Normally, Derdia would charge y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Jorga Azmal**: ""That is not our way, Your Majes..." |
| `[84]` | **""Fine. Rizia will withdraw from Wehlen's anti-BFF operations in exchange for the a..."** | `[91]` **Jorga Azmal**: ""If you are so confident Zille w..."<br>`[92]` **Jorga Azmal**: ""Then what is the answer? Meekly..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_A...` | `[98]` **Narrator**: "Azmal smiled and bowed his head." |
| `[85]` | **""On second thought, I don't want the situation getting out of hand in Zille. Your ..."** | `[77]` **Jorga Azmal**: ""Normally, Derdia would charge y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Jorga Azmal**: ""As you wish, Your Majesty."" |
| `[89]` | **""We had no choice. Making that deal with Wehlen was the only way to get Zille back.""** | `[88]` **Jorga Azmal**: ""It is not 'terror' to defend on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Jorga Azmal**: ""If you are so confident Zille w..." |
| `[90]` | **""I sympathize with what the Bludish have gone through. That does not mean violence..."** | `[88]` **Jorga Azmal**: ""It is not 'terror' to defend on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Jorga Azmal**: ""Then what is the answer? Meekly..." |
| `[94]` | **""I fully agree with you. I don't want to aid Wehlen's anti-Blud operations any lon..."** | `[88]` **Jorga Azmal**: ""It is not 'terror' to defend on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Jorga Azmal**: ""You have the power to end this,..." |
| `[95]` | **""We will regretfully be continuing our participation in Wehlen's anti-BFF operatio..."** | `[91]` **Jorga Azmal**: ""If you are so confident Zille w..."<br>`[92]` **Jorga Azmal**: ""Then what is the answer? Meekly..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "Azmal sighed." |
| `[101]` | **""We have a long war ahead of us. We will purchase both your missiles and the servi..."** | `[36]` **Jorga Azmal**: ""I see. And are all your Golden ..."<br>`[37]` **Jorga Azmal**: ""If the rest of your Golden Guar..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 3` | `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] =...`<br>`Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable...` | `[55]` **Jorga Azmal**: ""We will help you fight with hon..." |
| `[112]` | **""Supreme Wiseman, your missile technology is superior to anything we could achieve..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_Fightin...` | `[117]` **Narrator**: "He appeared flattered."<br>`[113]` **Narrator**: "He smiled slightly." |
| `[120]` | **""Yes, and I want it to stay that way. The more intimidating our weapons, the less ..."** | `[119]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "He nodded." |
| `[124]` | **""We in Rizia are developing a robust weapons export trade. I can sell these missil..."** | `[119]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | `Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true` | *Brak zmian stanu* | `[131]` **Jorga Azmal**: ""What, so that they may rain bac..." |
| `[125]` | **""I fear Merkopa may be on the cusp of a major geopolitical conflict. I don't want ..."** | `[119]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Jorga Azmal**: ""Yes, I sense it in the air as w..." |
| `[129]` | **""A holy reckoning may soon be at our doorstep. We must be prepared to wield the in..."** | `[119]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[134]` **Narrator**: "He pressed his fingers together." |
| `[130]` | **""This is an economic move. Rizia can sell these missiles to countries that otherwi..."** | `[119]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | `(Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true) == false` | *Brak zmian stanu* | `[131]` **Jorga Azmal**: ""What, so that they may rain bac..." |
| `[139]` | **""I understand that. For such a priceless treasure, I will pay whatever you ask." [..."** | `[144]` **Jorga Azmal**: ""I am prepared to make a deal. B..." | `Variable["RiziaDLC.Resources_Budget"] >= 3` | `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] =...` | `[148]` **Sal Ignacius**: ""Remember, these weapons are to ..." |
| `[150]` | **""Wouldn't you be willing to lower the price as part of a good-faith agreement betw..."** | `[144]` **Jorga Azmal**: ""I am prepared to make a deal. B..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[151]` **Narrator**: "He sighed."<br>`[157]` **Narrator**: "He shook his head." |
| `[152]` | **""I appreciate that. But such a price does not fit in with my economic plans for Ri..."** | `[144]` **Jorga Azmal**: ""I am prepared to make a deal. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Jorga Azmal**: ""That is a shame. I assure you, ..." |
| `[158]` | **""I will. You have my word." [-2 Budget]"** | `[156]` **Jorga Azmal**: ""If you truly insist, I will giv..." | `Variable["RiziaDLC.Resources_Budget"] >= 2` | `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] =...`<br>`Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = V...` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[163]` | **""I changed my mind. I'd rather not purchase missiles from you.""** | `[144]` **Jorga Azmal**: ""I am prepared to make a deal. B..."<br>`[156]` **Jorga Azmal**: ""If you truly insist, I will giv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Jorga Azmal**: ""That is a shame. I assure you, ..." |
| `[167]` | **""Come on, Azmal. Nobody else in Merkopa is willing to trade with Derdia. Any price..."** | `[144]` **Jorga Azmal**: ""I am prepared to make a deal. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Narrator**: "He sighed."<br>`[157]` **Narrator**: "He shook his head." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == f..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Miss..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Merc..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are at war, Supreme Wiseman. I would humbly call upon your great warrior culture for assistance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp = true"*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are at risk of losing the territory of Zille to Wehlen. I would humbly call upon your great warrior culture for assistance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Merc..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "He smiled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Jorga Azmal: ""Judging by how the Duel of Generosity ended, you could u..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_Success == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_Duel_Success == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "He appeared flattered."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_Duel_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "He smiled slightly."*)

### Węzeł `[12]`
Mówca: **Jorga Azmal**
> ""Judging by how the Duel of Generosity ended, you could use our help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Jorga Azmal: ""We are willing to sell you our latest missile system. Ev..."*)

### Węzeł `[13]`
Mówca: **Jorga Azmal**
> ""We are happy to help our brethren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Jorga Azmal: ""We are willing to sell you our latest missile system. Ev..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "He appeared flattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Jorga Azmal: ""We are happy to help our brethren.""*)

### Węzeł `[15]`
Mówca: **Jorga Azmal**
> ""We are willing to sell you our latest missile system. Even the Lespians will have trouble competing with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""I was thinking of something with a little more finesse.""*)
  - -> `[19]` (*Player_Romus: ""Great. The Palesians won't know what hit them.""*)
  - -> `[17]` (*Player_Romus: ""To safeguard God's creations, we must invoke the power o..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was thinking of something with a little more finesse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Jorga Azmal: ""In that case, Your Majesty, what you need is human power.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To safeguard God's creations, we must invoke the power of the heavens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Jorga Azmal: ""Exactly.""*)

### Węzeł `[18]`
Mówca: **Jorga Azmal**
> ""In that case, Your Majesty, what you need is human power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Jorga Azmal: ""Derdian mercenaries have helped win wars since the days ..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. The Palesians won't know what hit them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Sal Ignacius: ""Remember, these weapons are to be wielded with mercy, no..."*)

### Węzeł `[20]`
Mówca: **Sal Ignacius**
> ""Remember, these weapons are to be wielded with mercy, not wrath. Correct, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Jorga Azmal: ""Wrath can be a powerful tool in the hands of the righteo..."*)

### Węzeł `[21]`
Mówca: **Jorga Azmal**
> ""Derdian mercenaries have helped win wars since the days of the Empire of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Jorga Azmal: ""You saw my Disciples earlier. Imagine a larger team, jus..."*)

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""Ah. I am sorry that He has not blessed you with more prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Sal Ignacius: ""Remember, these weapons are to be wielded with mercy, no..."*)

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""Wrath can be a powerful tool in the hands of the righteous, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Jorga Azmal: ""We can also offer you our finest mercenaries. They have ..."*)

### Węzeł `[25]`
Mówca: **Jorga Azmal**
> ""We can also offer you our finest mercenaries. They have been helping win wars since the days of the Empire of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Jorga Azmal: ""You saw my Disciples earlier. Imagine a larger team, jus..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In case of emergency, a surge of Derdian mercenaries could certainly be of service.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Sal Ignacius: ""As long as there is a way to rein them in.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are already deploying my Golden Guard. Your mercenaries would be redundant.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] > 0`
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_TitusFights == true && Rizia..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm imagining that right now. It scares me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Jorga Azmal: ""It will scare your enemies more.""*)

### Węzeł `[29]`
Mówca: **Jorga Azmal**
> ""You saw my Disciples earlier. Imagine a larger team, just as trained, wielding sophisticated weaponry and stealth technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""In case of emergency, a surge of Derdian mercenaries cou..."*)
  - -> `[38]` (*Player_Romus: ""Can they be relied on to fight for the Rizian Crown?""*)
  - -> `[28]` (*Player_Romus: ""I'm imagining that right now. It scares me.""*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_GoldenGuard_Total > 0"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_GoldenGuard_Total > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_GoldenGuard_Total > 0"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_GoldenGuard_Total > 0)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_GoldenGuard_Total > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""We are already deploying my Golden Guard. Your mercenari..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_GoldenGuard_Total > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_TitusFights == true && Rizia..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_Duel_TitusFights == true && Riz..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_TitusFights"] == true  and  Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Jorga Azmal: ""I see. And are all your Golden Guards like Captain Gordi..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_TitusFights"] == true  and  Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Jorga Azmal: ""If the rest of your Golden Guard is as skilled as Captai..."*)

### Węzeł `[36]`
Mówca: **Jorga Azmal**
> ""I see. And are all your Golden Guards like Captain Gordion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[37]`
Mówca: **Jorga Azmal**
> ""If the rest of your Golden Guard is as skilled as Captain Gordion, that may be true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can they be relied on to fight for the Rizian Crown?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Jorga Azmal: ""They will fight for what they believe in, Your Majesty.""*)

### Węzeł `[39]`
Mówca: **Jorga Azmal**
> ""They will fight for what they believe in, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Jorga Azmal: ""For a fee, of course.""*)

### Węzeł `[40]`
Mówca: **Jorga Azmal**
> ""For a fee, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""It will scare your enemies more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[42]`
Mówca: **Sal Ignacius**
> ""As long as there is a way to rein them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 3)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""We have a long war ahead of us. We will purchase both yo..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WYBÓR GRACZA: ""I have no need for your mercenaries. But I will gladly purchase your missiles." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""I have no need for your mercenaries. But I will gladly purchase your missiles.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[36]` (Jorga Azmal), `[37]` (Jorga Azmal), `[40]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMissiles = true; Rizia..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: ""My kingdom does not require a missile system, but we wil..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""I would happily avail myself of either of those services..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Mercenary_Total += 1; RiziaDLC.Resources_Military_DerdianMercenaries = true; 
RiziaDLC.Resources_Military_DerdianMercenaries_Pales = true;
RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries = true;
RiziaDLCSupport.Reports_Turn07_PalesInvasion_DerdianMercenaries = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Army_Unit_Mercenary_Total"] = Variable["RiziaDLC.Army_Unit_Mercenary_Total"] + 1;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] = true;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Pales"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_PalesInvasion_DerdianMercenaries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Jorga Azmal: ""We will help you fight with honor, Your Majesty.""*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind. This is Rizia's war to fight. I don't want Derdia getting involved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Jorga Azmal), `[37]` (Jorga Azmal), `[40]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Jorga Azmal: ""I respect your decision, Your Majesty. I wish you streng..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""My kingdom does not require a missile system, but we will hire your mercenaries to fight Pales." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""My kingdom does not require a missile system, but we will hire your mercenaries to fight Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[36]` (Jorga Azmal), `[37]` (Jorga Azmal), `[40]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1;"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Budget -= 3;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Mercenary_Total += 1; RiziaDLC.Resourc..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1;
RiziaDLC.Resources_Budget -= 2;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1"*)

### Węzeł `[55]`
Mówca: **Jorga Azmal**
> ""We will help you fight with honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1"*)

### Węzeł `[56]`
Mówca: **Narrator**
> "He cracked a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Jorga Azmal: ""Judging by how the Duel of Generosity ended, you could u..."*)

### Węzeł `[57]`
Mówca: **Jorga Azmal**
> ""Judging by how the Duel of Generosity ended, you could use our help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Jorga Azmal: ""Our mercenaries have been helping win wars since the day..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would happily avail myself of either of those services. Alas, my kingdom cannot afford it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Jorga Azmal), `[37]` (Jorga Azmal), `[40]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Jorga Azmal: ""Ah. I am sorry that He has not blessed you with more pro..."*)

### Węzeł `[59]`
Mówca: **Jorga Azmal**
> ""I respect your decision, Your Majesty. I wish you strength for the battles ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_Success == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_Duel_Success == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "He seemed pleased."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_Duel_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "He cracked a smile."*)

### Węzeł `[63]`
Mówca: **Jorga Azmal**
> ""We are happy to help our brethren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Jorga Azmal: ""Our mercenaries have been helping win wars since the day..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "He seemed pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Jorga Azmal: ""We are happy to help our brethren.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In case of emergency, a surge of Derdian mercenaries could certainly be of service.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Sal Ignacius: ""As long as there is a way to rein them in.""*)

### Węzeł `[66]`
Mówca: **Jorga Azmal**
> ""They will fight for what they believe in, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can they be relied on to fight for the Rizian Crown?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Jorga Azmal: ""They will fight for what they believe in, Your Majesty.""*)

### Węzeł `[68]`
Mówca: **Jorga Azmal**
> ""My men will not fight for a kingdom that is complicit in the persecution of the Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Sal Ignacius: ""Rizia would never engage in persecution, Supreme Wiseman..."*)

### Węzeł `[69]`
Mówca: **Jorga Azmal**
> ""It will scare your enemies more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)

### Węzeł `[70]`
Mówca: **Sal Ignacius**
> ""As long as there is a way to rein them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm imagining that right now. It scares me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Jorga Azmal: ""It will scare your enemies more.""*)

### Węzeł `[72]`
Mówca: **Jorga Azmal**
> ""Our mercenaries have been helping win wars since the days of the Empire of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Jorga Azmal: ""You saw my Disciples earlier. Imagine a larger team, jus..."*)

### Węzeł `[73]`
Mówca: **Jorga Azmal**
> ""You saw my Disciples earlier. Imagine a larger team, just as trained, wielding sophisticated weaponry and stealth technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""In case of emergency, a surge of Derdian mercenaries cou..."*)
  - -> `[67]` (*Player_Romus: ""Can they be relied on to fight for the Rizian Crown?""*)
  - -> `[71]` (*Player_Romus: ""I'm imagining that right now. It scares me.""*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF =..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Jorga Azmal: ""I have one major concern. Your cooperation with Wehlen.""*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Jorga Azmal: ""Normally, Derdia would charge you for their services. Bu..."*)

### Węzeł `[77]`
Mówca: **Jorga Azmal**
> ""Normally, Derdia would charge you for their services. But my Disciples are eager to help Rizia reclaim its land from the anti-Golcondist Wehzeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: ""Free mercenaries? I can't say no to that. I will accept ..."*)
  - -> `[82]` (*Player_Romus: ""They may do so if they wish. But I don't want them harmi..."*)
  - -> `[85]` (*Player_Romus: ""On second thought, I don't want the situation getting ou..."*)

### Węzeł `[78]`
Mówca: **Jorga Azmal**
> ""I have one major concern. Your cooperation with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Jorga Azmal: ""My men will not fight for a kingdom that is complicit in..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Free mercenaries? I can't say no to that. I will accept your aid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Jorga Azmal: ""Excellent.""*)

### Węzeł `[80]`
Mówca: **Jorga Azmal**
> ""Excellent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Reso..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Resources_Military_DerdianMercenaries = true; 
RiziaDLC.Resources_Military_DerdianMercenaries_Zille = true;
RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] = true;
Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They may do so if they wish. But I don't want them harming civilians.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Jorga Azmal: ""That is not our way, Your Majesty.""*)

### Węzeł `[83]`
Mówca: **Jorga Azmal**
> ""That is not our way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Reso..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Rizia will withdraw from Wehlen's anti-BFF operations in exchange for the aid of Derdian mercenaries in the Zille resistance movement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Jorga Azmal), `[92]` (Jorga Azmal), `[93]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF = f..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, I don't want the situation getting out of hand in Zille. Your Disciples should stay out of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Jorga Azmal: ""As you wish, Your Majesty.""*)

### Węzeł `[86]`
Mówca: **Jorga Azmal**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[87]`
Mówca: **Sal Ignacius**
> ""Rizia would never engage in persecution, Supreme Wiseman. Our cooperation with Wehlen is an anti-terrorist measure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Jorga Azmal: ""It is not 'terror' to defend one's right to exist.""*)

### Węzeł `[88]`
Mówca: **Jorga Azmal**
> ""It is not 'terror' to defend one's right to exist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""We had no choice. Making that deal with Wehlen was the o..."*)
  - -> `[90]` (*Player_Romus: ""I sympathize with what the Bludish have gone through. Th..."*)
  - -> `[94]` (*Player_Romus: ""I fully agree with you. I don't want to aid Wehlen's ant..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had no choice. Making that deal with Wehlen was the only way to get Zille back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Jorga Azmal: ""If you are so confident Zille will be returned through c..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sympathize with what the Bludish have gone through. That does not mean violence is the answer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Jorga Azmal: ""Then what is the answer? Meekly allowing the eradication..."*)

### Węzeł `[91]`
Mówca: **Jorga Azmal**
> ""If you are so confident Zille will be returned through cooperation with Wehlen, why are you even inquiring about my mercenaries?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""Fine. Rizia will withdraw from Wehlen's anti-BFF operati..."*)
  - -> `[95]` (*Player_Romus: ""We will regretfully be continuing our participation in W..."*)

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""Then what is the answer? Meekly allowing the eradication of their entire people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""Fine. Rizia will withdraw from Wehlen's anti-BFF operati..."*)
  - -> `[95]` (*Player_Romus: ""We will regretfully be continuing our participation in W..."*)

### Węzeł `[93]`
Mówca: **Jorga Azmal**
> ""You have the power to end this, Your Majesty. Just say the word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""Fine. Rizia will withdraw from Wehlen's anti-BFF operati..."*)
  - -> `[95]` (*Player_Romus: ""We will regretfully be continuing our participation in W..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fully agree with you. I don't want to aid Wehlen's anti-Blud operations any longer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Jorga Azmal: ""You have the power to end this, Your Majesty. Just say t..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will regretfully be continuing our participation in Wehlen's anti-BFF operations. I withdraw my request for mercenary aid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Jorga Azmal), `[92]` (Jorga Azmal), `[93]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Azmal sighed."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Azmal sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Jorga Azmal: ""I don't understand this, Your Majesty. But very well.""*)

### Węzeł `[97]`
Mówca: **Jorga Azmal**
> ""I don't understand this, Your Majesty. But very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Azmal smiled and bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Jorga Azmal: "'St. Wruhec has shown you the way. We are glad to be of a..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF = false; 
RiziaDLC.Army_Unit_Ship_Total += 2;
RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Resources_Military_DerdianMercenaries = true; 
RiziaDLC.Resources_Military_DerdianMercenaries_Zille = true;
RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries = true;
RiziaDLCSupport.Journal_Turn07_BFF_StopBearTrap = true; RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF = true;
RiziaDLCSupport.News_Turn07_RH_AntiBFFCancelled = true;
RiziaDLCSupport.News_Turn07_V_AntiBFFCancelled = true;
RiziaDLCSupport.News_Turn07_G_SouthernMigrationRouteOpens = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] = false;
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
  - -> `[98]` (*Narrator: "Azmal smiled and bowed his head."*)

### Węzeł `[100]`
Mówca: **Jorga Azmal**
> "'St. Wruhec has shown you the way. We are glad to be of assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""We have a long war ahead of us. We will purchase both your missiles and the service of your mercenaries." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""We have a long war ahead of us. We will purchase both your missiles and the service of your mercenaries.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[36]` (Jorga Azmal), `[37]` (Jorga Azmal), `[40]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMissiles = true; Rizia..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_Success == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_Success == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == f..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp ==..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""We are at war, Supreme Wiseman. I would humbly call upon..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Mercenary_Total += 1; RiziaDLC.Resourc..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""I have no need for your mercenaries. But I will gladly p..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[51]` (*Player_Romus: ""Never mind. This is Rizia's war to fight. I don't want D..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Supreme Wiseman, your missile technology is superior to anything we could achieve in Rizia. I want to purchase one of your systems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Miss..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "He smiled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Jorga Azmal: ""Indeed, our defense agency's research and development de..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_Success == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_Duel_Success == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "He appeared flattered."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_Duel_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He smiled slightly."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "He appeared flattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Jorga Azmal: ""Indeed, our defense agency's research and development de..."*)

### Węzeł `[118]`
Mówca: **Jorga Azmal**
> ""Indeed, our defense agency's research and development department is the pride and joy of the Silver Garrison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Jorga Azmal: ""But I am curious why Rizia is in need of such technology..."*)

### Węzeł `[119]`
Mówca: **Jorga Azmal**
> ""But I am curious why Rizia is in need of such technology. You are not at war, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""Yes, and I want it to stay that way. The more intimidati..."*)
  - -> `[125]` (*Player_Romus: ""I fear Merkopa may be on the cusp of a major geopolitica..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ArmsExporter == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I want it to stay that way. The more intimidating our weapons, the less our enemies will want to provoke us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "He nodded."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ArmsExporter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ArmsExporter == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_ArmsExporter == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ArmsExporter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""We in Rizia are developing a robust weapons export trade..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_ArmsExporter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: ""This is an economic move. Rizia can sell these missiles ..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We in Rizia are developing a robust weapons export trade. I can sell these missiles to countries that otherwise would never deal with Derdia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Jorga Azmal: ""What, so that they may rain back down on our heads?""*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fear Merkopa may be on the cusp of a major geopolitical conflict. I don't want to leave Riizia defenseless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Jorga Azmal: ""Yes, I sense it in the air as well. Each of us should be..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""A holy reckoning may soon be at our doorstep. We must be..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A holy reckoning may soon be at our doorstep. We must be prepared to wield the instruments of justice.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "He pressed his fingers together."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is an economic move. Rizia can sell these missiles to countries that otherwise would never deal with Derdia.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Jorga Azmal: ""What, so that they may rain back down on our heads?""*)

### Węzeł `[131]`
Mówca: **Jorga Azmal**
> ""What, so that they may rain back down on our heads?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "He scowled."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "He scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Jorga Azmal: ""I am sorry, Your Majesty, but I will have to deny this r..."*)

### Węzeł `[133]`
Mówca: **Jorga Azmal**
> ""I am sorry, Your Majesty, but I will have to deny this request. Our missiles were developed in pursuit of peace, not economic gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[134]`
Mówca: **Narrator**
> "He pressed his fingers together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Jorga Azmal: ""With the way things are going in the world, such a recko..."*)

### Węzeł `[135]`
Mówca: **Jorga Azmal**
> ""With the way things are going in the world, such a reckoning may indeed be close at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Jorga Azmal: ""I am prepared to make a deal. But know that this weaponr..."*)

### Węzeł `[136]`
Mówca: **Jorga Azmal**
> ""Yes, I sense it in the air as well. Each of us should be prepared to hold our own against the godless so-called 'superpowers'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Jorga Azmal: ""I am prepared to make a deal. But know that this weaponr..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Jorga Azmal: ""Yes, I understand. We ourselves developed this technolog..."*)

### Węzeł `[138]`
Mówca: **Jorga Azmal**
> ""Yes, I understand. We ourselves developed this technology in pursuit of peace, not aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Jorga Azmal: ""I am prepared to make a deal. But know that this weaponr..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""I understand that. For such a priceless treasure, I will pay whatever you ask." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""I understand that. For such a priceless treasure, I will pay whatever you ask.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[144]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMissiles = true; Rizia..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1;
RiziaDLC.Resources_Budget -= 3;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Sal Ignacius: ""Remember, these weapons are to be wielded with mercy, no..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 3)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""I understand that. For such a priceless treasure, I will..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[144]`
Mówca: **Jorga Azmal**
> ""I am prepared to make a deal. But know that this weaponry is the product of years of hard work. It cannot be undervalued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[163]` (*Player_Romus: ""I changed my mind. I'd rather not purchase missiles from..."*)
  - -> `[152]` (*Player_Romus: ""I appreciate that. But such a price does not fit in with..."*)
  - -> `[167]` (*Player_Romus: ""Come on, Azmal. Nobody else in Merkopa is willing to tra..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[148]`
Mówca: **Sal Ignacius**
> ""Remember, these weapons are to be wielded with mercy, not wrath. Correct, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Jorga Azmal: ""Wrath can be a powerful tool in the hands of the righteo..."*)

### Węzeł `[149]`
Mówca: **Jorga Azmal**
> ""Wrath can be a powerful tool in the hands of the righteous, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1"*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wouldn't you be willing to lower the price as part of a good-faith agreement between men of God?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[144]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Jorga Azmal: ""If you truly insist, I will give your kingdom a discount..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate that. But such a price does not fit in with my economic plans for Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Jorga Azmal: ""That is a shame. I assure you, you would have been the e..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfi..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "He sighed."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "He shook his head."*)

### Węzeł `[156]`
Mówca: **Jorga Azmal**
> ""If you truly insist, I will give your kingdom a discount. But only because I trust you to wield it on behalf of all Rizians, including Golcondists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[163]` (*Player_Romus: ""I changed my mind. I'd rather not purchase missiles from..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Jorga Azmal: ""You are disrespecting our craftsmanship. Perhaps it's fo..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: ""I will. You have my word." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""I will. You have my word.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[156]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMissiles = true; Rizia..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus: ""I will. You have my word." [-2 Budget]"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1;
RiziaDLC.Resources_Budget -= 2;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1"*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I changed my mind. I'd rather not purchase missiles from you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Jorga Azmal), `[156]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Jorga Azmal: ""That is a shame. I assure you, you would have been the e..."*)

### Węzeł `[164]`
Mówca: **Jorga Azmal**
> ""That is a shame. I assure you, you would have been the envy of GRACE.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[165]`
Mówca: **Jorga Azmal**
> ""You are disrespecting our craftsmanship. Perhaps it's for the best that you don't buy it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_Success == true"*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Azmal. Nobody else in Merkopa is willing to trade with Derdia. Any price I offer is the best you're going to get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Happy == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Romus: ""Wouldn't you be willing to lower the price as part of a ..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Happy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Happy == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_GolcondistCommunity_Happy == t..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Happy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Happy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "He sighed."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_GolcondistCommunity_Happy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Happy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "He shook his head."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Miss..."*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mi..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""Supreme Wiseman, your missile technology is superior to ..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Merc..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Me..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""We are at risk of losing the territory of Zille to Wehle..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
