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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""As you know, we're at war. I would humbly ask for the assistance of your great wa..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_Fightin...` | `[7]` **Jorga Azmal**: ""Our great warrior culture. I se..." |
| `[10]` | **""I was thinking of something with a little more finesse.""** | `[8]` **Jorga Azmal**: ""But if you insist, I can sell y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Jorga Azmal**: ""If you're referring to our merc..." |
| `[11]` | **""Sounds perfect. But I don't think my kingdom can afford such a mighty weapon.""** | `[8]` **Jorga Azmal**: ""But if you insist, I can sell y..." | `Variable["RiziaDLC.Resources_Budget"] <= 2` | *Brak zmian stanu* | `[18]` **Jorga Azmal**: ""That's a shame, Your Majesty."" |
| `[12]` | **""To safeguard God's creations, we must invoke the power of the heavens.""** | `[8]` **Jorga Azmal**: ""But if you insist, I can sell y..." | `(Variable["RiziaDLC.Resources_Budget"] <= 2) == false` | *Brak zmian stanu* | `[22]` **Jorga Azmal**: ""You don't need to impress me wi..." |
| `[17]` | **""Great. The Palesians won't know what hit them.""** | `[8]` **Jorga Azmal**: ""But if you insist, I can sell y..." | `(Variable["RiziaDLC.Resources_Budget"] <= 2) == false` | *Brak zmian stanu* | `[21]` **Sal Ignacius**: ""Remember, these weapons are to ..." |
| `[24]` | **""Yes. I thank you for your willingness to aid our military, despite our religious ..."** | `[23]` **Jorga Azmal**: ""Do we have a deal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Jorga Azmal**: ""Rizia has laid the foundations ..." |
| `[25]` | **""Yes. Your weapons were all I came here for, anyway." [-3 Budget]"** | `[23]` **Jorga Azmal**: ""Do we have a deal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Jorga Azmal**: ""May they serve you well against..." |
| `[28]` | **""No, Rizia does not need or want your missiles.""** | `[23]` **Jorga Azmal**: ""Do we have a deal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Jorga Azmal**: ""May God bless and save your tro..." |
| `[29]` | **""No, I'd rather you did something else for me.""** | `[23]` **Jorga Azmal**: ""Do we have a deal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Jorga Azmal**: ""That depends, Your Majesty. Wha..." |
| `[36]` | **""They won't fight for Rizia. But maybe they will fight *against* Wehlen.""** | `[39]` **Jorga Azmal**: ""But they will not fight for a k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Narrator**: "He paused." |
| `[37]` | **""Men of honor. I appreciate that.""** | `[39]` **Jorga Azmal**: ""But they will not fight for a k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Jorga Azmal**: ""I am glad you do."" |
| `[38]` | **""Together, we will emancipate Zille and humiliate Wehlen.""** | `[65]` **Jorga Azmal**: ""I would consider lending you my..."<br>`[99]` **Jorga Azmal**: ""If only for the purpose of stri..." | `Variable["RiziaDLC.Resources_Budget"] > 0` | *Brak zmian stanu* | `[41]` **Jorga Azmal**: ""And perhaps, lay the foundation..." |
| `[40]` | **""Not even for a fee?""** | `[39]` **Jorga Azmal**: ""But they will not fight for a k..." | `Variable["RiziaDLC.Resources_Budget"] > 0` | *Brak zmian stanu* | `[80]` **Jorga Azmal**: ""Not as long as Rizia continues ..."<br>`[93]` **Narrator**: "He paused." |
| `[42]` | **""We are at risk of losing the territory of Zille to Wehlen. I would humbly call up..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_Fightin...` | `[43]` **Jorga Azmal**: ""Our great warrior culture. I se..." |
| `[56]` | **""Or maybe they're just scared of losing.""** | `[39]` **Jorga Azmal**: ""But they will not fight for a k..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[92]` **Narrator**: "Azmal looked irritated." |
| `[58]` | **""Fine. Rizia will withdraw from Wehlen's anti-BFF operations in exchange for the a..."** | `[91]` **Jorga Azmal**: ""This is my compromise. End your..." | `Variable["RiziaDLC.Resources_Budget"] > 0` | `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_A...` | `[57]` **Jorga Azmal**: ""We will not fail you."" |
| `[61]` | **""We will regretfully be continuing our participation in Wehlen's anti-BFF operatio..."** | `[91]` **Jorga Azmal**: ""This is my compromise. End your..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[55]` **Jorga Azmal**: ""Then it is up to God to forgive..." |
| `[66]` | **""Sounds like a plan. Your men are hired." [-1 Budget]"** | `[41]` **Jorga Azmal**: ""And perhaps, lay the foundation..."<br>`[71]` **Jorga Azmal**: ""You can count on them to do ser..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Jorga Azmal**: ""We will not fail you."" |
| `[69]` | **""It doesn't sound like I can count on their loyalty.""** | `[65]` **Jorga Azmal**: ""I would consider lending you my..."<br>`[99]` **Jorga Azmal**: ""If only for the purpose of stri..." | `Variable["RiziaDLC.Resources_Budget"] > 0` | *Brak zmian stanu* | `[71]` **Jorga Azmal**: ""You can count on them to do ser..." |
| `[70]` | **""Actually, please disregard my request. This is not the way that we get Zille back.""** | `[41]` **Jorga Azmal**: ""And perhaps, lay the foundation..."<br>`[71]` **Jorga Azmal**: ""You can count on them to do ser..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Jorga Azmal**: ""You would rather continue to ap..." |
| `[74]` | **""We had no choice. Making that deal with Wehlen was the only way to get Zille back.""** | `[73]` **Jorga Azmal**: ""It is not 'terror' to defend on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Jorga Azmal**: ""If you are so confident Zille w..." |
| `[75]` | **""I sympathize with what the Bludish have gone through. That does not mean violence..."** | `[73]` **Jorga Azmal**: ""It is not 'terror' to defend on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Jorga Azmal**: ""Then what is the answer? Meekly..." |
| `[76]` | **""I fully agree with you. I don't want to participate in Wehlen's anti-Blud operati..."** | `[73]` **Jorga Azmal**: ""It is not 'terror' to defend on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Jorga Azmal**: ""Then prove it, Your Majesty."" |
| `[82]` | **""Unfortunately, our treasury is low on funds. Can I compensate you some other way?""** | `[65]` **Jorga Azmal**: ""I would consider lending you my..."<br>`[99]` **Jorga Azmal**: ""If only for the purpose of stri..." | `(Variable["RiziaDLC.Resources_Budget"] > 0) == false` | *Brak zmian stanu* | `[87]` **Jorga Azmal**: ""No, Your Majesty."" |
| `[94]` | **""What does a spiritual leader like yourself want with money?""** | `[65]` **Jorga Azmal**: ""I would consider lending you my..."<br>`[99]` **Jorga Azmal**: ""If only for the purpose of stri..." | `Variable["RiziaDLC.Resources_Budget"] > 0` | *Brak zmian stanu* | `[95]` **Jorga Azmal**: ""I have a country to run and few..." |
| `[100]` | **""I spoke too soon. My kingdom cannot afford to hire your men.""** | `[91]` **Jorga Azmal**: ""This is my compromise. End your..." | `(Variable["RiziaDLC.Resources_Budget"] > 0) == false` | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[55]` **Jorga Azmal**: ""Then it is up to God to forgive..." |
| `[106]` | **""Supreme Wiseman, your missile technology is superior to anything we could achieve..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_Fightin...` | `[111]` **Narrator**: "He smiled slightly."<br>`[107]` **Narrator**: "He didn't smile." |
| `[114]` | **""Yes, and I want it to stay that way. The more intimidating our weapons, the less ..."** | `[113]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Narrator**: "He nodded." |
| `[122]` | **""A holy reckoning may soon be at our doorstep. We must be prepared to wield the in..."** | `[113]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[124]` **Narrator**: "He pressed his fingers together." |
| `[127]` | **""We in Rizia are developing a robust weapons export trade. I can sell these missil..."** | `[113]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | `Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true` | *Brak zmian stanu* | `[131]` **Jorga Azmal**: ""What, so that they may rain bac..." |
| `[128]` | **""I fear Merkopa may be on the cusp of a major geopolitical conflict. I don't want ..."** | `[113]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Jorga Azmal**: ""I sense it in the air as well. ..." |
| `[130]` | **""This is an economic move. Rizia can sell these missiles to countries that otherwi..."** | `[113]` **Jorga Azmal**: ""But I am curious why Rizia is i..." | `(Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true) == false` | *Brak zmian stanu* | `[131]` **Jorga Azmal**: ""What, so that they may rain bac..." |
| `[135]` | **""I understand that. For such a priceless treasure, I will pay whatever you ask." [..."** | `[140]` **Jorga Azmal**: ""I am prepared to make a deal. B..." | `Variable["RiziaDLC.Resources_Budget"] >= 3` | `Variable["RiziaDLC.Resources_Military_DerdianMissiles"] =...` | `[141]` **Sal Ignacius**: ""Remember, these weapons are to ..." |
| `[145]` | **""Wouldn't you be willing to lower the price as part of a good-faith agreement betw..."** | `[140]` **Jorga Azmal**: ""I am prepared to make a deal. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Narrator**: "He shook his head." |
| `[146]` | **""I appreciate that. But such a price does not fit in with my economic plans for Ri..."** | `[140]` **Jorga Azmal**: ""I am prepared to make a deal. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Jorga Azmal**: ""Perhaps that's just as well. It..." |
| `[148]` | **""Don't delude yourself, Azmal. Nobody else is willing to trade with you. Any offer..."** | `[140]` **Jorga Azmal**: ""I am prepared to make a deal. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Narrator**: "He shook his head angrily." |

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
  - -> `[536]`

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
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == f..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Merc..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Miss..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you know, we're at war. I would humbly ask for the assistance of your great warrior culture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp = true"*)

### Węzeł `[7]`
Mówca: **Jorga Azmal**
> ""Our great warrior culture. I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Jorga Azmal: ""To be honest, it makes no difference to me who is in cha..."*)

### Węzeł `[8]`
Mówca: **Jorga Azmal**
> ""But if you insist, I can sell you our latest missile system. It's good enough to compete with Lespia's, but it does not come cheap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""I was thinking of something with a little more finesse.""*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget <= 2"*)

### Węzeł `[9]`
Mówca: **Jorga Azmal**
> ""To be honest, it makes no difference to me who is in charge of the Pales peninsula.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Jorga Azmal: ""But if you insist, I can sell you our latest missile sys..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was thinking of something with a little more finesse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Jorga Azmal: ""If you're referring to our mercenaries, I'm afraid I can..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds perfect. But I don't think my kingdom can afford such a mighty weapon.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] <= 2`
- **Kontekst wejściowy (poprzednik):** `[8]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Jorga Azmal: ""That's a shame, Your Majesty.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To safeguard God's creations, we must invoke the power of the heavens.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] <= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[8]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Jorga Azmal: ""You don't need to impress me with religious talk, Your M..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget <= 2"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget <= 2)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget <= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""Sounds perfect. But I don't think my kingdom can afford ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget <= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""Great. The Palesians won't know what hit them.""*)
  - -> `[12]` (*Player_Romus: ""To safeguard God's creations, we must invoke the power o..."*)

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""If you're referring to our mercenaries, I'm afraid I can't help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Jorga Azmal: ""My Disciples will not risk their lives for a kingdom whe..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. The Palesians won't know what hit them.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] <= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[8]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Sal Ignacius: ""Remember, these weapons are to be wielded with mercy, no..."*)

### Węzeł `[18]`
Mówca: **Jorga Azmal**
> ""That's a shame, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[19]`
Mówca: **Jorga Azmal**
> ""My Disciples will not risk their lives for a kingdom where their right to practice their religion is not recognized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget <= 2"*)

### Węzeł `[20]`
Mówca: **Jorga Azmal**
> ""Once you buy them, they are yours to wield at your discretion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Jorga Azmal: ""Do we have a deal?""*)

### Węzeł `[21]`
Mówca: **Sal Ignacius**
> ""Remember, these weapons are to be wielded with mercy, not wrath. Correct, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Jorga Azmal: ""Once you buy them, they are yours to wield at your discr..."*)

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""You don't need to impress me with religious talk, Your Majesty. This is just business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Jorga Azmal: ""Do we have a deal?""*)

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""Do we have a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""Yes. I thank you for your willingness to aid our militar..."*)
  - -> `[25]` (*Player_Romus: ""Yes. Your weapons were all I came here for, anyway." [-3..."*)
  - -> `[28]` (*Player_Romus: ""No, Rizia does not need or want your missiles.""*)
  - -> `[29]` (*Player_Romus: ""No, I'd rather you did something else for me.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Yes. I thank you for your willingness to aid our military, despite our religious differences." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""Yes. I thank you for your willingness to aid our military, despite our religious differences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Jorga Azmal: ""Rizia has laid the foundations for the acceptance of Gol..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Yes. Your weapons were all I came here for, anyway." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""Yes. Your weapons were all I came here for, anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Jorga Azmal: ""May they serve you well against the godless Palesians.""*)

### Węzeł `[26]`
Mówca: **Jorga Azmal**
> ""Rizia has laid the foundations for the acceptance of Golcondism. I have not lost hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC...."*)

### Węzeł `[27]`
Mówca: **Jorga Azmal**
> ""May they serve you well against the godless Palesians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC...."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Rizia does not need or want your missiles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Jorga Azmal: ""May God bless and save your troops, then.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I'd rather you did something else for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Jorga Azmal: ""That depends, Your Majesty. What else do you want?""*)

### Węzeł `[30]`
Mówca: **Jorga Azmal**
> ""Our mercenaries have been helping win wars since the days of the Empire of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Jorga Azmal: ""You saw my Disciples earlier. Imagine a larger team, jus..."*)

### Węzeł `[31]`
Mówca: **Jorga Azmal**
> ""May God bless and save your troops, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""You saw my Disciples earlier. Imagine a larger team, just as trained, wielding sophisticated weaponry and stealth technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Jorga Azmal: ""But they will not fight for a kingdom that does not reco..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 0)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""Not even for a fee?""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They won't fight for Rizia. But maybe they will fight *against* Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "He paused."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Men of honor. I appreciate that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Jorga Azmal: ""I am glad you do.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we will emancipate Zille and humiliate Wehlen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Kontekst wejściowy (poprzednik):** `[65]` (Jorga Azmal), `[99]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Jorga Azmal: ""And perhaps, lay the foundation for Golcondist acceptanc..."*)

### Węzeł `[39]`
Mówca: **Jorga Azmal**
> ""But they will not fight for a kingdom that does not recognize their right to practice their religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)
  - -> `[36]` (*Player_Romus: ""They won't fight for Rizia. But maybe they will fight *a..."*)
  - -> `[37]` (*Player_Romus: ""Men of honor. I appreciate that.""*)
  - -> `[56]` (*Player_Romus: ""Or maybe they're just scared of losing.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not even for a fee?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Kontekst wejściowy (poprzednik):** `[39]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""And perhaps, lay the foundation for Golcondist acceptance in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""Sounds like a plan. Your men are hired." [-1 Budget]"*)
  - -> `[70]` (*Player_Romus: ""Actually, please disregard my request. This is not the w..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are at risk of losing the territory of Zille to Wehlen. I would humbly call upon your great warrior culture for assistance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Merc..."*)

### Węzeł `[43]`
Mówca: **Jorga Azmal**
> ""Our great warrior culture. I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Jorga Azmal: ""Our mercenaries have been helping win wars since the day..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget <= 2"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget <= 2)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget <= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget <= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Jorga Azmal: ""The missiles are just business. Once you buy them, they'..."*)

### Węzeł `[47]`
Mówca: **Jorga Azmal**
> ""The missiles are just business. Once you buy them, they're yours to use at your discretion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Jorga Azmal: ""Do we have a deal?""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 0)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""It doesn't sound like I can count on their loyalty.""*)
  - -> `[38]` (*Player_Romus: ""Together, we will emancipate Zille and humiliate Wehlen.""*)
  - -> `[94]` (*Player_Romus: ""What does a spiritual leader like yourself want with mon..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Unfortunately, our treasury is low on funds. Can I compe..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC.Resources_Military_DerdianMissiles = true;
RiziaDLC.Resources_Military_AirStrikeCooldown -= 1; RiziaDLC.Resources_Budget -= 3;
RiziaDLCSupport.Journal_Turn07_Derdia_Missiles = true;
RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Resources_Military_DerdianMissiles"] = true;
Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] = Variable["RiziaDLC.Resources_Military_AirStrikeCooldown"] - 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_Missiles"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_MissilesShipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[52]`
Mówca: **Jorga Azmal**
> ""You would rather continue to appease Smolak? 'It is easier to calm a storm with whispers than satisfy the whims of a madman.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Jorga Azmal: ""But very well.""*)

### Węzeł `[53]`
Mówca: **Jorga Azmal**
> ""They are scared of nothing. Have you come here to negotiate with me, or to belittle my people and our way of life?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Jorga Azmal: ""It is true that Smolak's anti-Golcondist regime has been..."*)

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""That depends, Your Majesty. What else do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Jump to: [Derdia Requests]"*)

### Węzeł `[55]`
Mówca: **Jorga Azmal**
> ""Then it is up to God to forgive you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Or maybe they're just scared of losing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[57]`
Mówca: **Jorga Azmal**
> ""We will not fail you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Reso..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Fine. Rizia will withdraw from Wehlen's anti-BFF operations in exchange for the aid of Derdian mercenaries in the Zille resistance movement." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. Rizia will withdraw from Wehlen's anti-BFF operations in exchange for the aid of Derdian mercenaries in the Zille resistance movement.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Kontekst wejściowy (poprzednik):** `[91]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF = f..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Azmal looked irritated."*)

### Węzeł `[60]`
Mówca: **Jorga Azmal**
> ""I am glad you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Jorga Azmal: ""It is true that Smolak's anti-Golcondist regime has been..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will regretfully be continuing our participation in Wehlen's anti-BFF operations. I withdraw my request for mercenary aid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF =..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Jorga Azmal: ""But as long as Rizia is aiding Wehlen in its campaign of..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Jorga Azmal: ""I would consider lending you my Disciples' services. For..."*)

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""I would consider lending you my Disciples' services. For a fee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Sounds like a plan. Your men are hired." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Sounds like a plan. Your men are hired.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Jorga Azmal), `[71]` (Jorga Azmal), `[95]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Jorga Azmal: ""We will not fail you.""*)

### Węzeł `[67]`
Mówca: **Jorga Azmal**
> ""It is true that Smolak's anti-Golcondist regime has been a constant source of grief for myself and my countrymen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Jorga Azmal: ""Then it is up to God to forgive you.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't sound like I can count on their loyalty.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Kontekst wejściowy (poprzednik):** `[65]` (Jorga Azmal), `[99]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Jorga Azmal: ""You can count on them to do serious damage to the Wehzek..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, please disregard my request. This is not the way that we get Zille back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Jorga Azmal), `[71]` (Jorga Azmal), `[95]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Jorga Azmal: ""You would rather continue to appease Smolak? 'It is easi..."*)

### Węzeł `[71]`
Mówca: **Jorga Azmal**
> ""You can count on them to do serious damage to the Wehzek enemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""Sounds like a plan. Your men are hired." [-1 Budget]"*)
  - -> `[70]` (*Player_Romus: ""Actually, please disregard my request. This is not the w..."*)

### Węzeł `[72]`
Mówca: **Sal Ignacius**
> ""Rizia would never engage in persecution, Supreme Wiseman. Our cooperation with Wehlen is an anti-terrorist measure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Jorga Azmal: ""It is not 'terror' to defend one's right to exist.""*)

### Węzeł `[73]`
Mówca: **Jorga Azmal**
> ""It is not 'terror' to defend one's right to exist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""We had no choice. Making that deal with Wehlen was the o..."*)
  - -> `[75]` (*Player_Romus: ""I sympathize with what the Bludish have gone through. Th..."*)
  - -> `[76]` (*Player_Romus: ""I fully agree with you. I don't want to participate in W..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had no choice. Making that deal with Wehlen was the only way to get Zille back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Jorga Azmal: ""If you are so confident Zille will be returned through c..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sympathize with what the Bludish have gone through. That does not mean violence is the answer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Jorga Azmal: ""Then what is the answer? Meekly allowing the eradication..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fully agree with you. I don't want to participate in Wehlen's anti-Blud operations any longer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Jorga Azmal: ""Then prove it, Your Majesty.""*)

### Węzeł `[77]`
Mówca: **Jorga Azmal**
> ""If you are so confident Zille will be returned through cooperation with Wehlen, why are you even inquiring about my mercenaries?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Jorga Azmal: ""This is my compromise. End your cooperation with Wiktor ..."*)

### Węzeł `[78]`
Mówca: **Jorga Azmal**
> ""Then what is the answer? Meekly allowing the eradication of their entire people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Jorga Azmal: ""This is my compromise. End your cooperation with Wiktor ..."*)

### Węzeł `[79]`
Mówca: **Jorga Azmal**
> ""Then prove it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Jorga Azmal: ""This is my compromise. End your cooperation with Wiktor ..."*)

### Węzeł `[80]`
Mówca: **Jorga Azmal**
> ""Not as long as Rizia continues to aid Wehlen in its campaign of anti-Golcondist persecution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Sal Ignacius: ""Rizia would never engage in persecution, Supreme Wiseman..."*)

### Węzeł `[81]`
Mówca: **Jorga Azmal**
> ""But as long as Rizia is aiding Wehlen in its campaign of persecution, we will not involve ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Sal Ignacius: ""Rizia would never engage in persecution, Supreme Wiseman..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, our treasury is low on funds. Can I compensate you some other way?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Jorga Azmal), `[99]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Jorga Azmal: ""No, Your Majesty.""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 0)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""Fine. Rizia will withdraw from Wehlen's anti-BFF operati..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: ""I spoke too soon. My kingdom cannot afford to hire your ..."*)

### Węzeł `[86]`
Mówca: **Jorga Azmal**
> ""We will do business with Rizia. But no more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[87]`
Mówca: **Jorga Azmal**
> ""No, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Jorga Azmal: ""We will do business with Rizia. But no more than that.""*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF =..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Jorga Azmal: ""Not as long as Rizia continues to aid Wehlen in its camp..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "He paused."*)

### Węzeł `[91]`
Mówca: **Jorga Azmal**
> ""This is my compromise. End your cooperation with Wiktor Smolak, and I will sell you a small mercenary detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)
  - -> `[61]` (*Player_Romus: ""We will regretfully be continuing our participation in W..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Azmal looked irritated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Jorga Azmal: ""They are scared of nothing. Have you come here to negoti..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "He paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Jorga Azmal: ""If the price was right, I could lend you a small detail.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does a spiritual leader like yourself want with money?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Kontekst wejściowy (poprzednik):** `[65]` (Jorga Azmal), `[99]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Jorga Azmal: ""I have a country to run and few trade partners, Your Maj..."*)

### Węzeł `[95]`
Mówca: **Jorga Azmal**
> ""I have a country to run and few trade partners, Your Majesty. Engaging with the material world is a necessity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""Sounds like a plan. Your men are hired." [-1 Budget]"*)
  - -> `[70]` (*Player_Romus: ""Actually, please disregard my request. This is not the w..."*)

### Węzeł `[96]`
Mówca: **Jorga Azmal**
> ""But very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[97]`
Mówca: **Jorga Azmal**
> ""If the price was right, I could lend you a small detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Jorga Azmal: ""If only for the purpose of striking back at Wiktor Smola..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Resources_Budget -= 1; RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[99]`
Mówca: **Jorga Azmal**
> ""If only for the purpose of striking back at Wiktor Smolak and his anti-Golcondist regime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I spoke too soon. My kingdom cannot afford to hire your men.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[91]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[101]`
Mówca: **Narrator**
> "He paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Jorga Azmal: ""It is true that Smolak's anti-Golcondist regime has been..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF = false;
RiziaDLC.Army_Unit_Ship_Total += 2;
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF = true;
RiziaDLCSupport.Journal_Turn07_BFF_StopBearTrap = true; RiziaDLC.Resources_Military_DerdianMercenaries = true;
RiziaDLC.Resources_Military_DerdianMercenaries_Zille = true; 
RiziaDLCSupport.Journal_Turn07_Derdia_Mercenaries = true;
RiziaDLCSupport.News_Turn07_RH_AntiBFFCancelled = true;
RiziaDLCSupport.News_Turn07_V_AntiBFFCancelled = true;
RiziaDLCSupport.News_Turn07_G_SouthernMigrationRouteOpens = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] = false;
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
  - -> `[57]` (*Jorga Azmal: ""We will not fail you.""*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Jorga Azmal: ""Our great warrior culture. I see...""*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Jorga Azmal: ""Our great warrior culture. I see...""*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Derdia Requests]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Supreme Wiseman, your missile technology is superior to anything we could achieve in Rizia. I want to purchase one of your systems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Miss..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "He didn't smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Jorga Azmal: ""Indeed, our defense agency's research and development de..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_Success == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_Duel_Success == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "He smiled slightly."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_Duel_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "He didn't smile."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "He smiled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Jorga Azmal: ""Indeed, our defense agency's research and development de..."*)

### Węzeł `[112]`
Mówca: **Jorga Azmal**
> ""Indeed, our defense agency's research and development department is the pride and joy of the Silver Garrison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Jorga Azmal: ""But I am curious why Rizia is in need of such technology..."*)

### Węzeł `[113]`
Mówca: **Jorga Azmal**
> ""But I am curious why Rizia is in need of such technology. You are not at war, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus: ""Yes, and I want it to stay that way. The more intimidati..."*)
  - -> `[128]` (*Player_Romus: ""I fear Merkopa may be on the cusp of a major geopolitica..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ArmsExporter == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I want it to stay that way. The more intimidating our weapons, the less our enemies will want to provoke us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "He nodded."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ArmsExporter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ArmsExporter == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_ArmsExporter == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ArmsExporter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""We in Rizia are developing a robust weapons export trade..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_ArmsExporter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: ""This is an economic move. Rizia can sell these missiles ..."*)

### Węzeł `[118]`
Mówca: **Jorga Azmal**
> ""I understand. We ourselves developed this technology in pursuit of peace, not aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Jorga Azmal: ""I am prepared to make a deal. But know that this weaponr..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""A holy reckoning may soon be at our doorstep. We must be..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A holy reckoning may soon be at our doorstep. We must be prepared to wield the instruments of justice.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "He pressed his fingers together."*)

### Węzeł `[123]`
Mówca: **Jorga Azmal**
> ""I am sorry, Your Majesty, but I will have to deny this request. Our missiles were developed in pursuit of peace, not economic gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "He pressed his fingers together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Jorga Azmal: ""With the way things are going in the world, such a recko..."*)

### Węzeł `[125]`
Mówca: **Jorga Azmal**
> ""With the way things are going in the world, such a reckoning may indeed be close at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Jorga Azmal: ""I am prepared to make a deal. But know that this weaponr..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We in Rizia are developing a robust weapons export trade. I can sell these missiles to countries that otherwise would never deal with Derdia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Jorga Azmal: ""What, so that they may rain back down on our heads?""*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fear Merkopa may be on the cusp of a major geopolitical conflict. I don't want to leave Rizia defenseless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Jorga Azmal: ""I sense it in the air as well. Each of us should be prep..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "He scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Jorga Azmal: ""I am sorry, Your Majesty, but I will have to deny this r..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is an economic move. Rizia can sell these missiles to countries that otherwise would never deal with Derdia.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Economy_ArmsExporter"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[113]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Jorga Azmal: ""What, so that they may rain back down on our heads?""*)

### Węzeł `[131]`
Mówca: **Jorga Azmal**
> ""What, so that they may rain back down on our heads?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "He scowled."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Jorga Azmal: ""I understand. We ourselves developed this technology in ..."*)

### Węzeł `[133]`
Mówca: **Jorga Azmal**
> ""I sense it in the air as well. Each of us should be prepared to hold our own against the godless so-called 'superpowers'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Jorga Azmal: ""I am prepared to make a deal. But know that this weaponr..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_Success == true"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I understand that. For such a priceless treasure, I will pay whatever you ask." [-3 Budget]"]** — Mówca: **Player_Romus**
> ""I understand that. For such a priceless treasure, I will pay whatever you ask.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[140]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMissiles = true; Rizia..."*)

### Węzeł `[136]`
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
  - -> `[141]` (*Sal Ignacius: ""Remember, these weapons are to be wielded with mercy, no..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 3)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player_Romus: ""I understand that. For such a priceless treasure, I will..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[140]`
Mówca: **Jorga Azmal**
> ""I am prepared to make a deal. But know that this weaponry is the product of years of hard work. It cannot be undervalued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[145]` (*Player_Romus: ""Wouldn't you be willing to lower the price as part of a ..."*)
  - -> `[146]` (*Player_Romus: ""I appreciate that. But such a price does not fit in with..."*)
  - -> `[148]` (*Player_Romus: ""Don't delude yourself, Azmal. Nobody else is willing to ..."*)

### Węzeł `[141]`
Mówca: **Sal Ignacius**
> ""Remember, these weapons are to be wielded with mercy, not wrath. Correct, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Jorga Azmal: ""Wrath can be a powerful tool in the hands of the righteo..."*)

### Węzeł `[142]`
Mówca: **Jorga Azmal**
> ""Wrath can be a powerful tool in the hands of the righteous, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1"*)

### Węzeł `[143]`
Mówca: **Jorga Azmal**
> ""You are disrespecting our craftsmanship. Perhaps it's for the best that you don't buy it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[144]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Jorga Azmal: ""You are disrespecting our craftsmanship. Perhaps it's fo..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wouldn't you be willing to lower the price as part of a good-faith agreement between neighbors?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "He shook his head."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate that. But such a price does not fit in with my economic plans for Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Jorga Azmal: ""Perhaps that's just as well. It would be a great risk to..."*)

### Węzeł `[147]`
Mówca: **Jorga Azmal**
> ""Perhaps that's just as well. It would be a great risk to place such a powerful weapon in the hands of a man I don't fully trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't delude yourself, Azmal. Nobody else is willing to trade with you. Any offer I give you is the best you're going to get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "He shook his head angrily."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "He shook his head angrily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Jorga Azmal: ""You are disrespecting our craftsmanship. Perhaps it's fo..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == f..."*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp ==..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""As you know, we're at war. I would humbly ask for the as..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Merc..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Me..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""We are at risk of losing the territory of Zille to Wehle..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mercs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Miss..."*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Mi..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player_Romus: ""Supreme Wiseman, your missile technology is superior to ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdianRequests_FightingHelp_Missiles"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
