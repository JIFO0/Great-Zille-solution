# Rizia/Turn 10/DEFAULT GATHERING SCENE/DEFAULT HOUSE AZARO CONVO

- **ID konwersacji:** `351`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/351_DEFAULT_HOUSE_AZARO_CONVO.md`
- **Liczba węzłów dialogowych:** 837
- **Liczba wyborów gracza:** 136

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Azaro_Total`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_DiscussedStratocracy`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NatDes_UniteHousesAgainst_Sazon`
- `RiziaDLC.NatDes_UniteHousesAgainst_Toras`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.PiplineNasDes_Taddeus_1926Uprising`
- `RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Reform_Silent`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied`
- `RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_PromisedQueen`
- `RiziaDLC.War_Objective_Captured_Pales`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.War_RumburgCeasefireRequested`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLC.ZilleOwnership_RiziaImperii`
- `RiziaDLCIsolated.Birthday_Default_Azaro_General`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Health`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Partner`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Portrait`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Succession`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.NatDes_UniteHousesAgainst_Azaro`
- `RiziaDLC.Pales_PromisedToHouseAzaro`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.Promised_Succession_Son_RespectTradition`
- `RiziaDLC.Reform_Suspicion`
- `RiziaDLCIsolated.Birthday_Default_Azaro_General`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Health`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Partner`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Portrait`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Succession`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest`
- `RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise`
- `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost`

### Skoki między-konwersacyjne:
- Węzeł `[333]` -> **[554] Rizia/Turn 10/DEFAULT GATHERING SCENE/DEFAULT GATHERING SCENE Conversation** (../Turn_10/554_DEFAULT_GATHERING_SCENE_Conversation.md), Węzeł `[5]`
- Węzeł `[803]` -> **[554] Rizia/Turn 10/DEFAULT GATHERING SCENE/DEFAULT GATHERING SCENE Conversation** (../Turn_10/554_DEFAULT_GATHERING_SCENE_Conversation.md), Węzeł `[5]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""I can't tell you how happy I am to see you back in good health, General.""** | `[334]` **Narrator**: "The Azaros bowed and walked to t..."<br>`[808]` **Narrator**: "He saluted once more as Carlos r..."<br>*(oraz 35 innych węzłów)* | `Variable["RiziaDLC.Council_Security_Taddeus"] == false  and  Variable["RiziaDLC.Pales_War"] == false`<br>`Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] == false` | *Brak zmian stanu* | `[7]` **Narrator**: "Taddeus smiled." |
| `[6]` | **""You haven't said a word about my new partner. Do you approve?""** | `[4]` **Taddeus Azaro**: ""Congratulations on a successful..."<br>`[67]` **Carlos Robles Azaro**: ""Enough with the false modesty, ..."<br>*(oraz 47 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner"] == false  and  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true) == false` | `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner...` | `[439]` **Taddeus Azaro**: ""I... yes, of course."" |
| `[12]` | **""What do you make of all the recent protests, General?""** | `[4]` **Taddeus Azaro**: ""Congratulations on a successful..."<br>`[67]` **Carlos Robles Azaro**: ""Enough with the false modesty, ..."<br>*(oraz 47 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == false  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[18]` **Taddeus Azaro**: ""As both your security councilor..."<br>`[22]` **Taddeus Azaro**: ""I have to say I'm concerned, Yo..." |
| `[16]` | **""You seem to be in good health these days, General.""** | `[4]` **Taddeus Azaro**: ""Congratulations on a successful..."<br>`[67]` **Carlos Robles Azaro**: ""Enough with the false modesty, ..."<br>*(oraz 32 innych węzłów)* | `(Variable["RiziaDLC.Council_Security_Taddeus"] == false  and  Variable["RiziaDLC.Pales_War"] == false) == false`<br>`Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] == false` | *Brak zmian stanu* | `[42]` **Taddeus Azaro**: ""Very much so, Your Majesty. The..." |
| `[17]` | **""How is everything in Cardesse-Montaklar?""** | `[4]` **Taddeus Azaro**: ""Congratulations on a successful..."<br>`[67]` **Carlos Robles Azaro**: ""Enough with the false modesty, ..."<br>*(oraz 47 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General"] == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true) == false` | `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General...` | `[344]` **Taddeus Azaro**: ""Aside from the riots, you mean?""<br>`[348]` **Taddeus Azaro**: ""To be honest, Your Majesty, the..."<br>*(oraz 1 innych odgałęzień)* |
| `[24]` | **""I believe we can put an end to the unrest. But I will need House Azaro's support.""** | `[46]` **Taddeus Azaro**: ""And what are you thinking now, ..."<br>`[23]` **Taddeus Azaro**: ""I recognize the feeling in the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Taddeus Azaro**: ""I don't want the traitors to wi..." |
| `[25]` | **""That revolt could have ended peacefully had the Crown been willing to meet the pr..."** | `[46]` **Taddeus Azaro**: ""And what are you thinking now, ..."<br>`[23]` **Taddeus Azaro**: ""I recognize the feeling in the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "His features hardened." |
| `[26]` | **""I understand now why my father made that deal with Wehlen. Desperation can make a..."** | `[23]` **Taddeus Azaro**: ""I recognize the feeling in the ..."<br>`[829]` **Taddeus Azaro**: ""As I've mentioned before, the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Taddeus Azaro**: ""And what are you thinking now, ..." |
| `[47]` | **""It is a pity to be losing so many trusted advisors. But I am following the path o..."** | `[48]` **Taddeus Azaro**: ""Except that the Royal Council i..."<br>`[51]` **Taddeus Azaro**: ""Except, of course, that the Roy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Taddeus Azaro**: ""Yes... I know. But I wish I cou..." |
| `[58]` | **""I will handle the riots and bring peace to the realm. Your province need not get ..."** | `[46]` **Taddeus Azaro**: ""And what are you thinking now, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Taddeus Azaro**: ""We are already involved, Your M..."<br>`[129]` **Taddeus Azaro**: ""The unrest will come to all of ..." |
| `[74]` | **""I had my reasons for appointing Titus. The Azaros could not be trusted after what..."** | `[49]` **Taddeus Azaro**: ""Except, of course, that you saw..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] ...` | `[782]` **Narrator**: "Taddeus' expression turned mourn..." |
| `[75]` | **""Captain Gordion is more than a mere bodyguard. His seat on my council is well des..."** | `[49]` **Taddeus Azaro**: ""Except, of course, that you saw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Taddeus Azaro**: ""I do not question Gordion's com..." |
| `[76]` | **""You were not yet fully recovered back then. Petition for the security councilor s..."** | `[49]` **Taddeus Azaro**: ""Except, of course, that you saw..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] ...` | `[78]` **Narrator**: "He bowed his head." |
| `[82]` | **""I nonetheless thank you for your many years of service. You deserve a long, happy..."** | `[51]` **Taddeus Azaro**: ""Except, of course, that the Roy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[649]` **Taddeus Azaro**: ""You are most welcome, Your Maje..." |
| `[83]` | **""Fear not, General. There will still be a place for you when Rizia is reborn.""** | `[51]` **Taddeus Azaro**: ""Except, of course, that the Roy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[648]` **Taddeus Azaro**: ""I hope there will be."" |
| `[84]` | **""As is its destiny. All things must come to an end, Taddeus.""** | `[51]` **Taddeus Azaro**: ""Except, of course, that the Roy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Taddeus Azaro**: ""Yes... I know. But I wish I cou..." |
| `[86]` | **""Your daughter has gone above and beyond in her service to the Crown, Taddeus. You..."** | `[71]` **Lucita Azaro**: ""I don't just allow it, I encour..."<br>`[72]` **Lucita Azaro**: ""Of course, Father. I was only k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Taddeus Azaro**: ""I will be once we win the war.""<br>`[91]` **Taddeus Azaro**: ""I am, Your Majesty."" |
| `[87]` | **""With all due respect, the time of King Valero has passed. The Royal Council needs..."** | `[71]` **Lucita Azaro**: ""I don't just allow it, I encour..."<br>`[72]` **Lucita Azaro**: ""Of course, Father. I was only k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Carlos Robles Azaro**: ""If it's fresh blood you're look..."<br>`[103]` **Lucita Azaro**: ""Don't discount my father's year..." |
| `[88]` | **""Petition for the council seat when the time comes, General. I will place you unde..."** | `[71]` **Lucita Azaro**: ""I don't just allow it, I encour..."<br>`[72]` **Lucita Azaro**: ""Of course, Father. I was only k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Taddeus Azaro**: ""Thank you. You will be hearing ..." |
| `[89]` | **""Now, Lucita, I thought you were a modern woman. You can raise a child and have a ..."** | `[71]` **Lucita Azaro**: ""I don't just allow it, I encour..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "She smiled wryly." |
| `[109]` | **""I made a royal decree to centralize our armed forces. I cannot simply reverse it.""** | `[196]` **Lucita Azaro**: ""Even then, most of our house is..."<br>`[53]` **Taddeus Azaro**: ""But I must say, it won't be eas..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[116]` **Taddeus Azaro**: ""And why not? You are the King -..." |
| `[110]` | **""I see what you're getting at, but it's not going to happen. I can't grant Rizia's..."** | `[196]` **Lucita Azaro**: ""Even then, most of our house is..."<br>`[53]` **Taddeus Azaro**: ""But I must say, it won't be eas..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[111]` **Taddeus Azaro**: ""You're so afraid of being usurp..." |
| `[117]` | **""No, I cannot authorize this. I command you to help the Crown against the revoluti..."** | `[112]` **Taddeus Azaro**: ""I didn't want to say this, but ..."<br>`[116]` **Taddeus Azaro**: ""And why not? You are the King -..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "Taddeus frowned." |
| `[130]` | **""Nonetheless, I'm reluctant to resort to violence. I'm holding out hope this can b..."** | `[65]` **Lucita Azaro**: ""I agree, Father. The time for p..."<br>`[181]` **Carlos Robles Azaro**: ""Agreed. The time for peaceful c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Taddeus Azaro**: ""You have more faith in the comm..." |
| `[146]` | **""I'm sorry, Lucita, but I can't guarantee that.""** | `[140]` **Taddeus Azaro**: ""This is not only what House Aza..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "My wife stepped backwards, shaken." |
| `[147]` | **""Of course royal tradition will be respected. If we have a boy, he will inherit th..."** | `[140]` **Taddeus Azaro**: ""This is not only what House Aza..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Narrator**: "My wife breathed a sigh of relief." |
| `[148]` | **""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's c..."** | `[140]` **Taddeus Azaro**: ""This is not only what House Aza..." | `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[255]` **Narrator**: "My wife stroked my arm." |
| `[154]` | **""I made a promise to Vina long ago. I can't break it.""** | `[153]` **Lucita Azaro**: ""You can't?"" | `Variable["RiziaDLC.Vina_PromisedQueen"] == true` | *Brak zmian stanu* | `[242]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[248]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[156]` | **""You may be right. Does that mean House Azaro will support the Crown in the fight ..."** | `[65]` **Lucita Azaro**: ""I agree, Father. The time for p..."<br>`[181]` **Carlos Robles Azaro**: ""Agreed. The time for peaceful c..." | `Variable["RiziaDLC.Reform_Path"] == false` | *Brak zmian stanu* | `[52]` **Taddeus Azaro**: ""I don't want the traitors to wi..." |
| `[160]` | **""My mother's portrait. Do you like it?""** | `[4]` **Taddeus Azaro**: ""Congratulations on a successful..."<br>`[67]` **Carlos Robles Azaro**: ""Enough with the false modesty, ..."<br>*(oraz 47 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Portrait"] == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[164]` **Taddeus Azaro**: ""The depiction you chose truly b..."<br>`[170]` **Taddeus Azaro**: ""Ah... I'm no art critic, Your M..." |
| `[182]` | **""A willingness to compromise is what makes a truly great leader. I know the Crown ..."** | `[65]` **Lucita Azaro**: ""I agree, Father. The time for p..."<br>`[181]` **Carlos Robles Azaro**: ""Agreed. The time for peaceful c..." | `(Variable["RiziaDLC.Reform_Path"] == false) == false` | `Variable["RiziaDLC.Reform_Suspicion"] = Variable["RiziaDL...` | `[183]` **Taddeus Azaro**: ""You have more faith in the comm..." |
| `[184]` | **""And what would House Azaro do in my place?""** | `[65]` **Lucita Azaro**: ""I agree, Father. The time for p..."<br>`[181]` **Carlos Robles Azaro**: ""Agreed. The time for peaceful c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Taddeus Azaro**: ""We wouldn't let the traitors wi..." |
| `[198]` | **""Excellent. I knew I could count on you.""** | `[143]` **Carlos Robles Azaro**: ""Loud and clear, General. The re..."<br>`[308]` **Lucita Azaro**: ""I'll send the word to Camp Domu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Taddeus Azaro**: ""Always."" |
| `[199]` | **""That's all I wanted to know. I've got to go mingle with the other guests now.""** | `[143]` **Carlos Robles Azaro**: ""Loud and clear, General. The re..."<br>`[308]` **Lucita Azaro**: ""I'll send the word to Camp Domu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Taddeus Azaro**: ""Understood."" |
| `[200]` | **""That's all I would have to do to get you on my side? Increase the size of our pro..."** | `[192]` **Lucita Azaro**: ""That's true, Your Majesty. We'd..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Taddeus and Lucita looked at one..."<br>`[231]` **Taddeus Azaro**: ""Give us the capability and the ..." |
| `[201]` | **""That's all I would have to do to get you on my side? Give the provinces back the ..."** | `[196]` **Lucita Azaro**: ""Even then, most of our house is..."<br>`[53]` **Taddeus Azaro**: ""But I must say, it won't be eas..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[212]` **Lucita Azaro**: ""You would also have to allow us..."<br>`[120]` **Narrator**: "Taddeus and Lucita looked at one..."<br>*(oraz 1 innych odgałęzień)* |
| `[202]` | **""I understand. I'll have to solve the problem on my own, then.""** | `[196]` **Lucita Azaro**: ""Even then, most of our house is..."<br>`[53]` **Taddeus Azaro**: ""But I must say, it won't be eas..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[208]` **Taddeus Azaro**: ""Are you sure, Your Majesty? The..."<br>`[214]` **Narrator**: "Taddeus' brow furrowed." |
| `[203]` | **""Is that your only condition for lending your support? That Rizia bring back our p..."** | `[112]` **Taddeus Azaro**: ""I didn't want to say this, but ..."<br>`[116]` **Taddeus Azaro**: ""And why not? You are the King -..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Lucita Azaro**: ""You would also have to allow us..."<br>`[120]` **Narrator**: "Taddeus and Lucita looked at one..."<br>*(oraz 1 innych odgałęzień)* |
| `[204]` | **""Enough of this. I shall deal with the traitors on my own. Including your house, w..."** | `[112]` **Taddeus Azaro**: ""I didn't want to say this, but ..."<br>`[116]` **Taddeus Azaro**: ""And why not? You are the King -..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] ...` | `[126]` **Narrator**: "I saw Carlos' hands form fists."<br>`[127]` **Narrator**: "I saw Lucita's hands form fists." |
| `[213]` | **""I was hoping for a solution that didn't involve the military.""** | `[112]` **Taddeus Azaro**: ""I didn't want to say this, but ..."<br>`[116]` **Taddeus Azaro**: ""And why not? You are the King -..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Narrator**: "Taddeus folded his arms across h..." |
| `[224]` | **""Very well. So you're saying if I reinstate provincial levies, the Azaros will hel..."** | `[190]` **Taddeus Azaro**: ""Hm... We could.""<br>`[208]` **Taddeus Azaro**: ""Are you sure, Your Majesty? The..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false` | *Brak zmian stanu* | `[212]` **Lucita Azaro**: ""You would also have to allow us..."<br>`[120]` **Narrator**: "Taddeus and Lucita looked at one..."<br>*(oraz 1 innych odgałęzień)* |
| `[225]` | **""I don't believe that at all. I will not ask your house to get involved in this.""** | `[222]` **Narrator**: "Carlos nodded his assent."<br>`[218]` **Taddeus Azaro**: ""Your father and I learned this ..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false` | *Brak zmian stanu* | `[226]` **Taddeus Azaro**: ""We will try our best to avoid e..." |
| `[228]` | **""I have my own ways of applying brute force, if it comes down to it.""** | `[222]` **Narrator**: "Carlos nodded his assent."<br>`[218]` **Taddeus Azaro**: ""Your father and I learned this ..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false` | *Brak zmian stanu* | `[229]` **Taddeus Azaro**: ""Then it sounds like you don't n..." |
| `[232]` | **""Very well, General. By royal decree, I will bring back Rizia's provincial army sy..."** | `[231]` **Taddeus Azaro**: ""Give us the capability and the ..."<br>`[293]` **Taddeus Azaro**: ""That still depends, doesn't it?""<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true`<br>`Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true` | `Variable["RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromi...` | `[312]` **Taddeus Azaro**: ""Thank you for your trust in us...." |
| `[236]` | **""Vina wants to be queen more than anything. I can't take that away from her.""** | `[153]` **Lucita Azaro**: ""You can't?"" | `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false` | *Brak zmian stanu* | `[242]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[248]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[237]` | **""For political reasons, I must name my daughter as successor.""** | `[153]` **Lucita Azaro**: ""You can't?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[248]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[238]` | **""Succession law shouldn't favor sons. You have to admit it's a sexist policy.""** | `[153]` **Lucita Azaro**: ""You can't?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[248]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[257]` | **""If we don't band together against the unrest, the protesters could kill us all. A..."** | `[246]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[247]` **Lucita Azaro**: ""We're doing our best to coordin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Lucita Azaro**: ""I..."" |
| `[258]` | **""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""** | `[246]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[247]` **Lucita Azaro**: ""We're doing our best to coordin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Narrator**: "She breathed a sigh of relief." |
| `[259]` | **""We don't even know the sex of our child yet. I will make this decision when the t..."** | `[246]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[247]` **Lucita Azaro**: ""We're doing our best to coordin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Narrator**: "Lucita sighed in frustration. Sh..." |
| `[266]` | **""Very well, General. By royal decree, I will bring back Rizia's provincial army sy..."** | `[231]` **Taddeus Azaro**: ""Give us the capability and the ..."<br>`[293]` **Taddeus Azaro**: ""That still depends, doesn't it?""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Pales_War"] == true) == false`<br>`Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true` | `Variable["RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromi...` | `[310]` **Taddeus Azaro**: ""Thank you for your trust in us,..." |
| `[267]` | **""I understand. I'll have to tackle the problem on my own, then.""** | `[192]` **Lucita Azaro**: ""That's true, Your Majesty. We'd..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Taddeus Azaro**: ""Are you sure, Your Majesty? The..."<br>`[214]` **Narrator**: "Taddeus' brow furrowed." |
| `[271]` | **""Very well. So you're saying if I raise provincial levies, the Azaros will help us..."** | `[190]` **Taddeus Azaro**: ""Hm... We could.""<br>`[208]` **Taddeus Azaro**: ""Are you sure, Your Majesty? The..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Army_Unit_Azaro_Total"] < 2`<br>`(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false` | *Brak zmian stanu* | `[231]` **Taddeus Azaro**: ""Give us the capability and the ..." |
| `[272]` | **""Yes, I'm sure. Let's change the subject.""** | `[208]` **Taddeus Azaro**: ""Are you sure, Your Majesty? The..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Taddeus Azaro**: ""We will try our best to avoid e..." |
| `[277]` | **""Very well. I request that you deploy your forces to quell the rebellion.""** | `[190]` **Taddeus Azaro**: ""Hm... We could.""<br>`[208]` **Taddeus Azaro**: ""Are you sure, Your Majesty? The..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Army_Unit_Azaro_Total"] < 2) == false`<br>`(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false` | *Brak zmian stanu* | `[135]` **Taddeus Azaro**: ""House Azaro will help you..""<br>`[141]` **Taddeus Azaro**: ""The Azaro army will help you to..." |
| `[282]` | **""I command you to aid the Crown with whatever resources are at your disposal.""** | `[281]` **Lucita Azaro**: ""Yes, I wish we could help. But ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "Taddeus frowned." |
| `[283]` | **""I understand. I won't burden your house with this on top of the war.""** | `[281]` **Lucita Azaro**: ""Yes, I wish we could help. But ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Taddeus Azaro**: ""We will try our best to avoid e..." |
| `[285]` | **""If you truly love *me*, you'll understand why I have to put my daughter first.""** | `[254]` **Lucita Azaro**: ""I know how much you love Vina. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Narrator**: "Lucita sighed in frustration. Sh..." |
| `[309]` | **""Very well, General. By royal decree, I will increase provincial levies, on the co..."** | `[231]` **Taddeus Azaro**: ""Give us the capability and the ..."<br>`[293]` **Taddeus Azaro**: ""That still depends, doesn't it?""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false` | `Variable["RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromi...` | `[310]` **Taddeus Azaro**: ""Thank you for your trust in us,..." |
| `[318]` | **""All three houses, defending the Crown together. This will be a triumph to remember.""** | `[143]` **Carlos Robles Azaro**: ""Loud and clear, General. The re..."<br>`[308]` **Lucita Azaro**: ""I'll send the word to Camp Domu..." | `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true` | *Brak zmian stanu* | `[321]` **Taddeus Azaro**: ""We will savor it, Your Majesty."" |
| `[322]` | **""I did away with provincial levies for a reason. I still think it's too risky for ..."** | `[231]` **Taddeus Azaro**: ""Give us the capability and the ..."<br>`[293]` **Taddeus Azaro**: ""That still depends, doesn't it?""<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true` | *Brak zmian stanu* | `[325]` **Taddeus Azaro**: ""Then there is nothing we can do..." |
| `[323]` | **""The Azaro army is large enough already. You will help crack down on the traitors ..."** | `[231]` **Taddeus Azaro**: ""Give us the capability and the ..."<br>`[293]` **Taddeus Azaro**: ""That still depends, doesn't it?""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false` | *Brak zmian stanu* | `[331]` **Taddeus Azaro**: ""We will try, but I fear it will..." |
| `[324]` | **""My deepest apologies, but I cannot grant your request. It is not your house I dis..."** | `[231]` **Taddeus Azaro**: ""Give us the capability and the ..."<br>`[293]` **Taddeus Azaro**: ""That still depends, doesn't it?""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Taddeus Azaro**: ""If the noble houses can't trust..." |
| `[372]` | **""Lucita, you told me some time ago that House Azaro had complaints about my reign...."** | `[386]` **Carlos Robles Azaro**: ""Not that I am one of them.""<br>`[387]` **Lucita Azaro**: ""But as long as Pales is restore..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied"] == true` | *Brak zmian stanu* | `[415]` **Narrator**: "Taddeus glared at his daughter s..." |
| `[408]` | **""You've caught me in a good mood. Is there anything your house requests of your Ki..."** | `[386]` **Carlos Robles Azaro**: ""Not that I am one of them.""<br>`[387]` **Lucita Azaro**: ""But as long as Pales is restore..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[504]` **Taddeus Azaro**: ""Just one, Your Majesty.""<br>`[547]` **Narrator**: "Taddeus and Lucita looked at eac..."<br>*(oraz 2 innych odgałęzień)* |
| `[412]` | **""I hope that our holy kingdom can count on your continued support. We will need yo..."** | `[386]` **Carlos Robles Azaro**: ""Not that I am one of them.""<br>`[387]` **Lucita Azaro**: ""But as long as Pales is restore..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.Theocracy_Full"] == true` | *Brak zmian stanu* | `[615]` **Narrator**: "Carlos smiled, showing all his t..."<br>`[625]` **Narrator**: "I saw a hint of sorrow in Taddeu..."<br>*(oraz 2 innych odgałęzień)* |
| `[414]` | **""I hope I can count on the Azaros' continued support. You are among my family's ol..."** | `[386]` **Carlos Robles Azaro**: ""Not that I am one of them.""<br>`[387]` **Lucita Azaro**: ""But as long as Pales is restore..."<br>*(oraz 7 innych węzłów)* | `(Variable["RiziaDLC.Theocracy_Full"] == true) == false` | *Brak zmian stanu* | `[615]` **Narrator**: "Carlos smiled, showing all his t..."<br>`[625]` **Narrator**: "I saw a hint of sorrow in Taddeu..."<br>*(oraz 2 innych odgałęzień)* |
| `[417]` | **""With the House of Delegates abolished and the royal houses of Toras and Azaro uni..."** | `[386]` **Carlos Robles Azaro**: ""Not that I am one of them.""<br>`[387]` **Lucita Azaro**: ""But as long as Pales is restore..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false  and  Variable["RiziaDLC.Reform_Path"] == false` | *Brak zmian stanu* | `[421]` **Narrator**: "Lucita slipped her hand in mine ..." |
| `[423]` | **""Thanks to you and your house for joining us tonight. If you'll excuse me, I'm goi..."** | `[4]` **Taddeus Azaro**: ""Congratulations on a successful..."<br>`[67]` **Carlos Robles Azaro**: ""Enough with the false modesty, ..."<br>*(oraz 47 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[804]` **Taddeus Azaro**: ""It was a pleasure speaking with..." |
| `[450]` | **""Your congratulations are accepted.""** | `[437]` **Lucita Azaro**: ""My most heartfelt of congratula..."<br>`[438]` **Carlos Robles Azaro**: ""It's an unusual predilection fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[468]` **Taddeus Azaro**: ""It will take some time for the ..." |
| `[451]` | **""Mandatory homosexuality in the military... I feel a new decree coming on.""** | `[449]` **Carlos Robles Azaro**: ""Look at the Derdians, Taddeus. ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[462]` **Narrator**: "Horrified looks spread across th..." |
| `[455]` | **""You had better mean it. Anyone who dares to challenge the legitimacy of the King'..."** | `[437]` **Lucita Azaro**: ""My most heartfelt of congratula..."<br>`[438]` **Carlos Robles Azaro**: ""It's an unusual predilection fo..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[466]` **Narrator**: "Taddeus hurriedly interjected." |
| `[459]` | **""What exactly did my father say about me, General Taddeus?""** | `[437]` **Lucita Azaro**: ""My most heartfelt of congratula..."<br>`[438]` **Carlos Robles Azaro**: ""It's an unusual predilection fo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Narrator**: "He winced." |
| `[460]` | **""I hope all of Cardesse-Montaklar shares your tolerance.""** | `[437]` **Lucita Azaro**: ""My most heartfelt of congratula..."<br>`[438]` **Carlos Robles Azaro**: ""It's an unusual predilection fo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[461]` **Taddeus Azaro**: ""We will see to it that they do."" |
| `[476]` | **""Who was spreading such rumors? Tell me, and I'll have them hanged.""** | `[474]` **Taddeus Azaro**: ""Fortunately, it seems we were m..."<br>`[789]` **Taddeus Azaro**: ""At some point during my recover..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[487]` **Narrator**: "Taddeus paled." |
| `[477]` | **""Yes, you were. There will be no anti-nobility reforms on King Romus' watch, mark ..."** | `[474]` **Taddeus Azaro**: ""Fortunately, it seems we were m..."<br>`[789]` **Taddeus Azaro**: ""At some point during my recover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Lucita Azaro**: ""Good to hear.""<br>`[497]` **Taddeus Azaro**: ""If that is indeed the case, the..." |
| `[481]` | **""*If* I were planning to reform the country, I would not do so against your house'..."** | `[474]` **Taddeus Azaro**: ""Fortunately, it seems we were m..."<br>`[789]` **Taddeus Azaro**: ""At some point during my recover..." | `Variable["RiziaDLC.Reform_Silent"] == true` | *Brak zmian stanu* | `[491]` **Taddeus Azaro**: ""Hmm. So you don't deny your int..." |
| `[485]` | **""I allowed Manus Sazon to plead his case for reform, yes. But ultimately, I reject..."** | `[474]` **Taddeus Azaro**: ""Fortunately, it seems we were m..."<br>`[789]` **Taddeus Azaro**: ""At some point during my recover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Lucita Azaro**: ""Good to hear.""<br>`[497]` **Taddeus Azaro**: ""If that is indeed the case, the..." |
| `[486]` | **""Surely you don't believe that Rizia can stay the same forever. A kingdom must ada..."** | `[474]` **Taddeus Azaro**: ""Fortunately, it seems we were m..."<br>`[789]` **Taddeus Azaro**: ""At some point during my recover..." | `Variable["RiziaDLC.Reform_Silent"] == true` | *Brak zmian stanu* | `[489]` **Taddeus Azaro**: ""That may be so. But such decisi..." |
| `[510]` | **""Resume? Pales hasn't even been a part of Rizia for over two centuries.""** | `[508]` **Taddeus Azaro**: ""Now that victory in Pales is al..."<br>`[509]` **Taddeus Azaro**: ""Should we achieve victory in Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[512]` **Lucita Azaro**: ""That may be true. But we Azaros..." |
| `[511]` | **""Of course, General. For your service during this war and the one that preceded it..."** | `[508]` **Taddeus Azaro**: ""Now that victory in Pales is al..."<br>`[509]` **Taddeus Azaro**: ""Should we achieve victory in Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Narrator**: "Taddeus bowed so deeply he almos..." |
| `[516]` | **""Pales will be in a state of instability after it is reconquered. It needs the ful..."** | `[508]` **Taddeus Azaro**: ""Now that victory in Pales is al..."<br>`[509]` **Taddeus Azaro**: ""Should we achieve victory in Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[520]` **Taddeus Azaro**: ""We have fought the Palesians tw..." |
| `[517]` | **""We centralized Zille following its return. I was planning on doing the same with ..."** | `[508]` **Taddeus Azaro**: ""Now that victory in Pales is al..."<br>`[509]` **Taddeus Azaro**: ""Should we achieve victory in Pa..." | `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true` | *Brak zmian stanu* | `[521]` **Lucita Azaro**: ""So you would give our house the..." |
| `[525]` | **""I don't foresee a happy ending to this war. Chances are that no one in Rizia will..."** | `[512]` **Lucita Azaro**: ""That may be true. But we Azaros..."<br>`[520]` **Taddeus Azaro**: ""We have fought the Palesians tw..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.War_Objective_Captured_Pales"] == false  and  Variable["RiziaDLC.War_WehlenJoined"] == false` | *Brak zmian stanu* | `[526]` **Taddeus Azaro**: ""Don't count us out just yet, Yo..." |
| `[527]` | **""If it truly means that much to you, I will consider your request. Once we win, th..."** | `[512]` **Lucita Azaro**: ""That may be true. But we Azaros..."<br>`[520]` **Taddeus Azaro**: ""We have fought the Palesians tw..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Narrator**: "Taddeus bowed so deeply he almos..." |
| `[531]` | **""With Wiktor Smolak now involved, the decision may be out of my hands.""** | `[512]` **Lucita Azaro**: ""That may be true. But we Azaros..."<br>`[520]` **Taddeus Azaro**: ""We have fought the Palesians tw..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.War_WehlenJoined"] == true` | *Brak zmian stanu* | `[538]` **Taddeus Azaro**: ""We cannot allow Wehlen to contr..." |
| `[532]` | **""By the time the war is over, the decision may be out of my hands.""** | `[512]` **Lucita Azaro**: ""That may be true. But we Azaros..."<br>`[520]` **Taddeus Azaro**: ""We have fought the Palesians tw..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Reform_Silent"] == true` | *Brak zmian stanu* | `[536]` **Narrator**: "Both Azaros looked at me strangely." |
| `[539]` | **""Why do you want Pales so badly, anyway? It'll be a smoking ruin by the time our a..."** | `[512]` **Lucita Azaro**: ""That may be true. But we Azaros..."<br>`[520]` **Taddeus Azaro**: ""We have fought the Palesians tw..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[542]` **Taddeus Azaro**: ""But it will give us the sea, Yo..." |
| `[549]` | **""Well, good. I'd hate to think that any of you were plotting against me.""** | `[492]` **Taddeus Azaro**: ""Especially not since one of our..."<br>`[493]` **Taddeus Azaro**: ""Especially not on the Queen Mot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[627]` **Carlos Robles Azaro**: ""Never in a million years, Your ..."<br>`[631]` **Lucita Azaro**: ""I swear you can count on my fam..." |
| `[552]` | **""I'm sorry, Taddeus, but I cannot guarantee that.""** | `[551]` **Taddeus Azaro**: ""And my greatest hope is that if..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[554]` **Narrator**: "My wife stepped backward, shaken." |
| `[553]` | **""Of course royal tradition will be respected. If we have a boy, he will inherit th..."** | `[551]` **Taddeus Azaro**: ""And my greatest hope is that if..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[592]` **Narrator**: "My wife breathed a sigh of relief." |
| `[560]` | **""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's c..."** | `[551]` **Taddeus Azaro**: ""And my greatest hope is that if..." | `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[593]` **Narrator**: "My wife stroked my arm." |
| `[564]` | **""I made a promise to Vina long ago. I can't break it.""** | `[555]` **Lucita Azaro**: ""You can't?"" | `Variable["RiziaDLC.Vina_PromisedQueen"] == true` | *Brak zmian stanu* | `[591]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[590]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[569]` | **""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""** | `[565]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[566]` **Lucita Azaro**: ""We're doing our best to coordin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[572]` **Narrator**: "She breathed a sigh of relief." |
| `[571]` | **""We don't even know the sex of our child yet. I will make this decision when the t..."** | `[565]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[566]` **Lucita Azaro**: ""We're doing our best to coordin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[578]` **Narrator**: "Taddeus sighed in frustration. L..." |
| `[573]` | **""If you truly love *me*, you'll understand why I have to put my daughter first.""** | `[575]` **Lucita Azaro**: ""I know how much you love Vina. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[596]` **Narrator**: "Taddeus sighed in frustration. L..." |
| `[576]` | **""What are you saying? Are you *hoping* my daughter never returns?""** | `[565]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[566]` **Lucita Azaro**: ""We're doing our best to coordin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Lucita Azaro**: ""No, of course I'm not!"" |
| `[584]` | **""Vina wants to be queen more than anything. I can't take that away from her.""** | `[555]` **Lucita Azaro**: ""You can't?"" | `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false` | *Brak zmian stanu* | `[591]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[590]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[585]` | **""For political reasons, I must name my daughter as successor.""** | `[555]` **Lucita Azaro**: ""You can't?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[591]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[590]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[586]` | **""A male heir ought not to be favored over his female older sibling. I intend to ch..."** | `[555]` **Lucita Azaro**: ""You can't?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[591]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[590]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[632]` | **""I still have to convince the other houses. But the Azaros are the most vital piec..."** | `[143]` **Carlos Robles Azaro**: ""Loud and clear, General. The re..."<br>`[308]` **Lucita Azaro**: ""I'll send the word to Camp Domu..." | `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false` | *Brak zmian stanu* | `[633]` **Taddeus Azaro**: ""Good luck."" |
| `[650]` | **""Are you saying that you know better than the international courts?""** | `[647]` **Carlos Robles Azaro**: ""I have visited my cousin -- Luc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[654]` **Carlos Robles Azaro**: ""No, Your Majesty..."" |
| `[651]` | **""I'm truly sorry, but I cannot exonerate Lucita as long as Rizia remains allied wi..."** | `[647]` **Carlos Robles Azaro**: ""I have visited my cousin -- Luc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[655]` **Carlos Robles Azaro**: ""I understand..."" |
| `[652]` | **""Of course, she'll never admit to her guilt. I thought you were too smart to fall ..."** | `[647]` **Carlos Robles Azaro**: ""I have visited my cousin -- Luc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[656]` **Carlos Robles Azaro**: ""I know Lucita well, Your Majest..." |
| `[653]` | **""It doesn't matter. By imprisoning her, we avoided a war that would have cost us t..."** | `[647]` **Carlos Robles Azaro**: ""I have visited my cousin -- Luc..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] ...` | `[658]` **Carlos Robles Azaro**: ""I understand... I think."" |
| `[662]` | **""What kind of monster do you think I am, General? I would never execute Duchess Az..."** | `[661]` **Carlos Robles Azaro**: ""I am not asking that Lucita be ..." | `(Variable["RiziaDLC.Trait_TyrantKing"]) == false` | *Brak zmian stanu* | `[673]` **Narrator**: "Carlos bowed." |
| `[663]` | **""The punishment for those who betray the Crown is death. Are you implying the Duch..."** | `[661]` **Carlos Robles Azaro**: ""I am not asking that Lucita be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[675]` **Carlos Robles Azaro**: ""No... Only that if there is eve..." |
| `[664]` | **""Your love for your cousin moves me. I will honor your request and spare her from ..."** | `[661]` **Carlos Robles Azaro**: ""I am not asking that Lucita be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[666]` **Narrator**: "Carlos bowed." |
| `[665]` | **""Why stop there? Why shouldn't Rizia do away with the death penalty entirely?""** | `[661]` **Carlos Robles Azaro**: ""I am not asking that Lucita be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[679]` **Narrator**: "Carlos and Taddeus both gave me ..." |
| `[671]` | **""You're right, Carlos. Death is too good for Lucita. Your traitorous cousin should..."** | `[661]` **Carlos Robles Azaro**: ""I am not asking that Lucita be ..." | `Variable["RiziaDLC.Trait_TyrantKing"]` | *Brak zmian stanu* | `[672]` **Carlos Robles Azaro**: ""No! That's not what I meant..."" |
| `[677]` | **""Everybody is somebody's cousin, aren't they? All criminals should similarly be gi..."** | `[676]` **Carlos Robles Azaro**: ""Your Majesty, I still believe t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[688]` **Carlos Robles Azaro**: ""I am not asking for a removal o..." |
| `[678]` | **""I was speaking rhetorically. If I spare Lucita, I'll get flooded with requests to..."** | `[676]` **Carlos Robles Azaro**: ""Your Majesty, I still believe t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[687]` **Carlos Robles Azaro**: ""I am speaking on behalf of Hous..." |
| `[680]` | **""I was joking, Carlos. You know how much I love a good beheading.""** | `[676]` **Carlos Robles Azaro**: ""Your Majesty, I still believe t..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[684]` **Carlos Robles Azaro**: ""Oh... Very funny."" |
| `[685]` | **""Other countries have stopped using this barbaric form of punishment. Perhaps we r..."** | `[676]` **Carlos Robles Azaro**: ""Your Majesty, I still believe t..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[686]` **Taddeus Azaro**: ""That is a discussion for anothe..." |
| `[689]` | **""Lucita will live. And I will rethink Rizia's policy of killing criminals.""** | `[686]` **Taddeus Azaro**: ""That is a discussion for anothe..."<br>`[688]` **Carlos Robles Azaro**: ""I am not asking for a removal o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] ...` | `[693]` **Carlos Robles Azaro**: ""I... thank you, Your Majesty. Y..." |
| `[690]` | **""Don't worry. As long as I am King, your cousin will not be executed.""** | `[684]` **Carlos Robles Azaro**: ""Oh... Very funny.""<br>`[686]` **Taddeus Azaro**: ""That is a discussion for anothe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[673]` **Narrator**: "Carlos bowed." |
| `[691]` | **""As long as the death penalty still exists, every Rizian who has committed a serio..."** | `[684]` **Carlos Robles Azaro**: ""Oh... Very funny.""<br>`[686]` **Taddeus Azaro**: ""That is a discussion for anothe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[699]` **Narrator**: "His face hardened into a scowl." |
| `[692]` | **""I will consider your house's request. That is all I can promise.""** | `[684]` **Carlos Robles Azaro**: ""Oh... Very funny.""<br>`[686]` **Taddeus Azaro**: ""That is a discussion for anothe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[666]` **Narrator**: "Carlos bowed." |
| `[718]` | **""Done. There are no other suitable candidates, anyway.""** | `[714]` **Taddeus Azaro**: ""With my daughter in place as Qu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[723]` **Taddeus Azaro**: ""As I served His Majesty Valero,..." |
| `[719]` | **""Are you confident you have the health and stamina to resume the position?""** | `[714]` **Taddeus Azaro**: ""With my daughter in place as Qu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[723]` **Taddeus Azaro**: ""As I served His Majesty Valero,..." |
| `[720]` | **""That's it? This will be easier than I thought.""** | `[714]` **Taddeus Azaro**: ""With my daughter in place as Qu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[717]` **Narrator**: "He and Lucita looked at each other." |
| `[721]` | **""I was hoping to reward Captain Gordion with the position. But I will consider you..."** | `[714]` **Taddeus Azaro**: ""With my daughter in place as Qu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[716]` **Taddeus Azaro**: ""Thank you."" |
| `[726]` | **""I'm sorry, Taddeus, but I cannot guarantee that.""** | `[725]` **Taddeus Azaro**: ""It is therefore my hope that if..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[728]` **Narrator**: "My wife stepped backward, shaken." |
| `[727]` | **""Of course royal tradition will be respected. If we have a boy, he will inherit th..."** | `[725]` **Taddeus Azaro**: ""It is therefore my hope that if..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[764]` **Narrator**: "My wife breathed a sigh of relief." |
| `[734]` | **""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's c..."** | `[725]` **Taddeus Azaro**: ""It is therefore my hope that if..." | `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[765]` **Narrator**: "My wife stroked my arm." |
| `[738]` | **""I made a promise to Vina long ago. I can't break it.""** | `[729]` **Lucita Azaro**: ""You can't?"" | `Variable["RiziaDLC.Vina_PromisedQueen"] == true` | *Brak zmian stanu* | `[763]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[762]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[743]` | **""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""** | `[739]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[740]` **Lucita Azaro**: ""We're doing our best to coordin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[746]` **Narrator**: "She breathed a sigh of relief." |
| `[745]` | **""We don't even know the sex of our child yet. I will make this decision when the t..."** | `[739]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[740]` **Lucita Azaro**: ""We're doing our best to coordin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[751]` **Narrator**: "Taddeus sighed in frustration. L..." |
| `[747]` | **""If you truly love *me*, you'll understand why I have to put my daughter first.""** | `[749]` **Lucita Azaro**: ""I know how much you love Vina. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[767]` **Narrator**: "Taddeus sighed in frustration. L..." |
| `[750]` | **""What are you saying? Are you *hoping* my daughter never returns?""** | `[739]` **Lucita Azaro**: ""And after the way she humiliate..."<br>`[740]` **Lucita Azaro**: ""We're doing our best to coordin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[748]` **Lucita Azaro**: ""No, of course I'm not!"" |
| `[756]` | **""Vina wants to be queen more than anything. I can't take that away from her.""** | `[729]` **Lucita Azaro**: ""You can't?"" | `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false` | *Brak zmian stanu* | `[763]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[762]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[757]` | **""For political reasons, I must name my daughter as successor.""** | `[729]` **Lucita Azaro**: ""You can't?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[763]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[762]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[758]` | **""A male heir ought not to be favored over his female older sibling. I intend to ch..."** | `[729]` **Lucita Azaro**: ""You can't?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[763]` **Lucita Azaro**: ""But, Romus... we don't even kno..."<br>`[762]` **Lucita Azaro**: ""But, Romus... what about us?"" |
| `[784]` | **""Have members of House Azaro expressed any dissatisfaction about my reign?""** | `[386]` **Carlos Robles Azaro**: ""Not that I am one of them.""<br>`[387]` **Lucita Azaro**: ""But as long as Pales is restore..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied"] == true) == false` | *Brak zmian stanu* | `[785]` **Narrator**: "Taddeus shook his head hurriedly." |
| `[797]` | **""Because if you *were* plotting against me, I would find out. And I would crush yo..."** | `[627]` **Carlos Robles Azaro**: ""Never in a million years, Your ..."<br>`[631]` **Lucita Azaro**: ""I swear you can count on my fam..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[802]` **Taddeus Azaro**: ""Please, Your Majesty. The Crown..." |
| `[801]` | **""I do value honesty among my subjects. If I did find out that any member of House ..."** | `[627]` **Carlos Robles Azaro**: ""Never in a million years, Your ..."<br>`[631]` **Lucita Azaro**: ""I swear you can count on my fam..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[802]` **Taddeus Azaro**: ""Please, Your Majesty. The Crown..." |

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
  - -> `[3]` (*Narrator: "The general turned his wheelchair around to face me."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "The general turned his wheelchair around to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Taddeus Azaro: ""Congratulations on a successful evening, Your Majesty.""*)

### Węzeł `[4]`
Mówca: **Taddeus Azaro**
> ""Congratulations on a successful evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't tell you how happy I am to see you back in good health, General.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_Security_Taddeus"] == false  and  Variable["RiziaDLC.Pales_War"] == false` AND `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] == false`
- **Kontekst wejściowy (poprzednik):** `[334]` (Narrator), `[808]` (Narrator), `[809]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Taddeus smiled."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You haven't said a word about my new partner. Do you approve?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner"] == false  and  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Taddeus Azaro), `[67]` (Carlos Robles Azaro), `[79]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Partner = true"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Taddeus smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Taddeus Azaro: ""The doctors are calling it a miracle recovery.""*)

### Węzeł `[8]`
Mówca: **Taddeus Azaro**
> ""The doctors are calling it a miracle recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Health = true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == false && RiziaDLC.Pales_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == false && RiziaDLC.Pa..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == false && RiziaDLC...."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == false && RiziaDLC.Pales_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == false  and  Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""I can't tell you how happy I am to see you back in good ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == false && RiziaDLC.Pales_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == false  and  Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""You seem to be in good health these days, General.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you make of all the recent protests, General?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == false  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Taddeus Azaro), `[67]` (Carlos Robles Azaro), `[79]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false &..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == false  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""What do you make of all the recent protests, General?""*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == false  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You seem to be in good health these days, General.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == false  and  Variable["RiziaDLC.Pales_War"] == false) == false` AND `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Taddeus Azaro), `[67]` (Carlos Robles Azaro), `[79]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Taddeus Azaro: ""Very much so, Your Majesty. The doctors call it a miracl..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is everything in Cardesse-Montaklar?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General"] == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Taddeus Azaro), `[67]` (Carlos Robles Azaro), `[79]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_General = true"*)

### Węzeł `[18]`
Mówca: **Taddeus Azaro**
> ""As both your security councilor and a high-ranking noble, I'm obviously concerned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Taddeus Azaro: ""As both your security councilor and a high-ranking noble..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Taddeus Azaro: ""I have to say I'm concerned, Your Majesty.""*)

### Węzeł `[22]`
Mówca: **Taddeus Azaro**
> ""I have to say I'm concerned, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true"*)

### Węzeł `[23]`
Mówca: **Taddeus Azaro**
> ""I recognize the feeling in the air. It was exactly the same in 1926.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Unrest = true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe we can put an end to the unrest. But I will need House Azaro's support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Taddeus Azaro), `[23]` (Taddeus Azaro), `[829]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Taddeus Azaro: ""I don't want the traitors to win any more than you do, Y..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That revolt could have ended peacefully had the Crown been willing to meet the protesters' demands for reform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Taddeus Azaro), `[23]` (Taddeus Azaro), `[829]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "His features hardened."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand now why my father made that deal with Wehlen. Desperation can make a ruler contemplate the unthinkable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Taddeus Azaro), `[829]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Taddeus Azaro: ""And what are you thinking now, Your Majesty?""*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Taddeus Azaro: ""With careful management, I could stay on the Royal Counc..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Taddeus Azaro: ""In fact, I would say I'm well enough to assume my prior ..."*)

### Węzeł `[30]`
Mówca: **Taddeus Azaro**
> ""In fact, I would say I'm well enough to assume my prior position on the Royal Council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Taddeus Azaro: ""Except that the Royal Council is about to dissolve.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[34]`
Mówca: **Taddeus Azaro**
> ""With careful management, I could stay on the Royal Council for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Taddeus Azaro: ""Except, of course, that you saw fit to replace my disgra..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Taddeus Azaro: ""Assuming my daughter allows it.""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Taddeus Azaro: ""Except, of course, that the Royal Council is about to di..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Taddeus Azaro: ""If His Majesty would have me, of course.""*)

### Węzeł `[41]`
Mówca: **Narrator**
> "His features hardened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Taddeus Azaro: ""Have you forgotten that they killed my brother? That the..."*)

### Węzeł `[42]`
Mówca: **Taddeus Azaro**
> ""Very much so, Your Majesty. The doctors call it a miracle recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Health = true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Suspicion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Suspicion"] = Variable["RiziaDLC.Reform_Suspicion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Taddeus Azaro: ""You have more faith in the commoners than I do... But pe..."*)

### Węzeł `[44]`
Mówca: **Taddeus Azaro**
> ""Have you forgotten that they killed my brother? That they almost killed you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Taddeus Azaro: ""These people can't be compromised with. They will be sat..."*)

### Węzeł `[45]`
Mówca: **Taddeus Azaro**
> ""These people can't be compromised with. They will be satisfied with nothing less than our blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[46]`
Mówca: **Taddeus Azaro**
> ""And what are you thinking now, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""I believe we can put an end to the unrest. But I will ne..."*)
  - -> `[25]` (*Player_Romus: ""That revolt could have ended peacefully had the Crown be..."*)
  - -> `[58]` (*Player_Romus: ""I will handle the riots and bring peace to the realm. Yo..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a pity to be losing so many trusted advisors. But I am following the path of God now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Taddeus Azaro), `[51]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Taddeus Azaro: ""Yes... I know. But I wish I could have served you for lo..."*)

### Węzeł `[48]`
Mówca: **Taddeus Azaro**
> ""Except that the Royal Council is about to dissolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""It is a pity to be losing so many trusted advisors. But ..."*)

### Węzeł `[49]`
Mówca: **Taddeus Azaro**
> ""Except, of course, that you saw fit to replace my disgraced daughter with your bodyguard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""I had my reasons for appointing Titus. The Azaros could ..."*)
  - -> `[75]` (*Player_Romus: ""Captain Gordion is more than a mere bodyguard. His seat ..."*)
  - -> `[76]` (*Player_Romus: ""You were not yet fully recovered back then. Petition for..."*)

### Węzeł `[50]`
Mówca: **Taddeus Azaro**
> ""Assuming my daughter allows it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[51]`
Mówca: **Taddeus Azaro**
> ""Except, of course, that the Royal Council is about to dissolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""It is a pity to be losing so many trusted advisors. But ..."*)
  - -> `[82]` (*Player_Romus: ""I nonetheless thank you for your many years of service. ..."*)
  - -> `[83]` (*Player_Romus: ""Fear not, General. There will still be a place for you w..."*)
  - -> `[84]` (*Player_Romus: ""As is its destiny. All things must come to an end, Tadde..."*)

### Węzeł `[52]`
Mówca: **Taddeus Azaro**
> ""I don't want the traitors to win any more than you do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[53]`
Mówca: **Taddeus Azaro**
> ""But I must say, it won't be easy for us to help you without the ability to mobilize our own forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true )"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Taddeus Azaro: ""But I must say, it won't be easy for us to help you with..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[57]`
Mówca: **Taddeus Azaro**
> ""If His Majesty would have me, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will handle the riots and bring peace to the realm. Your province need not get involved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ViolentProtests_CardesseMontakla..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ViolentProtests_CardesseMontakla..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ViolentProtests_CardesseMontak..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Taddeus Azaro: ""We are already involved, Your Majesty. There are riots o..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Taddeus Azaro: ""The unrest will come to all of us sooner or later. As it..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucita Azaro: ""I agree, Father. The time for peaceful compromise is lon..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Carlos Robles Azaro: ""Agreed. The time for peaceful compromise is long past.""*)

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""I agree, Father. The time for peaceful compromise is long past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == false"*)
  - -> `[130]` (*Player_Romus: ""Nonetheless, I'm reluctant to resort to violence. I'm ho..."*)
  - -> `[184]` (*Player_Romus: ""And what would House Azaro do in my place?""*)

### Węzeł `[66]`
Mówca: **Taddeus Azaro**
> ""We are already involved, Your Majesty. There are riots on our streets as well as yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Taddeus Azaro: ""But if you say the Crown has the situation under control..."*)

### Węzeł `[67]`
Mówca: **Carlos Robles Azaro**
> ""Enough with the false modesty, Taddeus. His Majesty is lucky to have you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucita Azaro: ""I don't just allow it, I encourage it. I'll have my hand..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "There was reluctance in Lucita's voice as she answered."*)

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""I don't just allow it, I encourage it. I'll have my hands full raising our new heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Now, Lucita, I thought you were a modern woman. You can ..."*)
  - -> `[86]` (*Player_Romus: ""Your daughter has gone above and beyond in her service t..."*)
  - -> `[87]` (*Player_Romus: ""With all due respect, the time of King Valero has passed..."*)
  - -> `[88]` (*Player_Romus: ""Petition for the council seat when the time comes, Gener..."*)

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""Of course, Father. I was only keeping your seat warm for you, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""Your daughter has gone above and beyond in her service t..."*)
  - -> `[87]` (*Player_Romus: ""With all due respect, the time of King Valero has passed..."*)
  - -> `[88]` (*Player_Romus: ""Petition for the council seat when the time comes, Gener..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "There was reluctance in Lucita's voice as she answered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucita Azaro: ""Of course, Father. I was only keeping your seat warm for..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had my reasons for appointing Titus. The Azaros could not be trusted after what Lucita did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Captain Gordion is more than a mere bodyguard. His seat on my council is well deserved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Taddeus Azaro: ""I do not question Gordion's competence. But I will point..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were not yet fully recovered back then. Petition for the security councilor seat this year, and I will consider reinstating you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 1"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "He bowed his head."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "He bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Taddeus Azaro: ""I will gladly do so, Your Majesty.""*)

### Węzeł `[79]`
Mówca: **Taddeus Azaro**
> ""I will gladly do so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]` (*Narrator: "Taddeus' expression turned mournful."*)

### Węzeł `[81]`
Mówca: **Taddeus Azaro**
> ""I do not question Gordion's competence. But I will point to my years of experience serving your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Taddeus Azaro: ""I will submit my petition regardless. I place my fate in..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I nonetheless thank you for your many years of service. You deserve a long, happy retirement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Taddeus Azaro: ""You are most welcome, Your Majesty. But I do wish I coul..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fear not, General. There will still be a place for you when Rizia is reborn.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Taddeus Azaro: ""I hope there will be.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As is its destiny. All things must come to an end, Taddeus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Taddeus Azaro: ""Yes... I know. But I wish I could have served you for lo..."*)

### Węzeł `[85]`
Mówca: **Taddeus Azaro**
> ""Yes... I know. But I wish I could have served you for longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your daughter has gone above and beyond in her service to the Crown, Taddeus. You should be proud of her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucita Azaro), `[72]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Capt..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With all due respect, the time of King Valero has passed. The Royal Council needs fresh blood.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucita Azaro), `[72]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Petition for the council seat when the time comes, General. I will place you under special consideration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucita Azaro), `[72]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Taddeus Azaro: ""Thank you. You will be hearing from me.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, Lucita, I thought you were a modern woman. You can raise a child and have a career at the same time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "She smiled wryly."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "She smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""I hadn't heard. But raising a child, fulfilling my dutie..."*)

### Węzeł `[91]`
Mówca: **Taddeus Azaro**
> ""I am, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Captured_Pales == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Capt..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Ca..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Captured_Pales == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Pales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Taddeus Azaro: ""I will be once we win the war.""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Captured_Pales == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Pales"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Taddeus Azaro: ""I am, Your Majesty.""*)

### Węzeł `[95]`
Mówca: **Taddeus Azaro**
> ""I will be once we win the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Carlos Robles Azaro: ""If it's fresh blood you're looking for, I could put myse..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucita Azaro: ""Don't discount my father's years of experience, both ser..."*)

### Węzeł `[99]`
Mówca: **Carlos Robles Azaro**
> ""If it's fresh blood you're looking for, I could put myself forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Lucita smiled gently."*)

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""I hadn't heard. But raising a child, fulfilling my duties as Queen Consort *and* serving on your council? It's too much, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucita Azaro: ""With that said, if you did insist I continue my council ..."*)

### Węzeł `[101]`
Mówca: **Taddeus Azaro**
> ""Thank you. You will be hearing from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Lucita smiled gently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucita Azaro: ""I don't think you have the temperament to sit through a ..."*)

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""Don't discount my father's years of experience, both serving King Valero and leading our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucita Azaro: ""With that said, if you did insist I continue my council ..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Azaro Default Convo Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Health == false"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false &..."*)
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_General == false"*)
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Partner == false ..."*)
  - -> `[811]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == false"*)
  - -> `[423]` (*Player_Romus: ""Thanks to you and your house for joining us tonight. If ..."*)

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""I don't think you have the temperament to sit through a lengthy council session, Carlos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Carlos Robles Azaro: ""And you do?""*)

### Węzeł `[106]`
Mówca: **Carlos Robles Azaro**
> ""And you do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""With that said, if you did insist I continue my council duties, I could hardly refuse His Majesty's request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made a royal decree to centralize our armed forces. I cannot simply reverse it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Lucita Azaro), `[53]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Taddeus Azaro: ""And why not? You are the King -- for now.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see what you're getting at, but it's not going to happen. I can't grant Rizia's royal houses the means to strike against me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Lucita Azaro), `[53]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Taddeus Azaro: ""You're so afraid of being usurped that you'd let the rev..."*)

### Węzeł `[111]`
Mówca: **Taddeus Azaro**
> ""You're so afraid of being usurped that you'd let the revolutionaries strike against us all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Taddeus Azaro: ""I didn't want to say this, but you sound just like your ..."*)

### Węzeł `[112]`
Mówca: **Taddeus Azaro**
> ""I didn't want to say this, but you sound just like your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""No, I cannot authorize this. I command you to help the C..."*)
  - -> `[203]` (*Player_Romus: ""Is that your only condition for lending your support? Th..."*)
  - -> `[204]` (*Player_Romus: ""Enough of this. I shall deal with the traitors on my own..."*)
  - -> `[213]` (*Player_Romus: ""I was hoping for a solution that didn't involve the mili..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Taddeus and Lucita looked at one another."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Taddeus Azaro: ""Give us the capability and the resources, and we will do..."*)

### Węzeł `[116]`
Mówca: **Taddeus Azaro**
> ""And why not? You are the King -- for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""No, I cannot authorize this. I command you to help the C..."*)
  - -> `[203]` (*Player_Romus: ""Is that your only condition for lending your support? Th..."*)
  - -> `[204]` (*Player_Romus: ""Enough of this. I shall deal with the traitors on my own..."*)
  - -> `[213]` (*Player_Romus: ""I was hoping for a solution that didn't involve the mili..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I cannot authorize this. I command you to help the Crown against the revolutionaries with whatever other resources are at your disposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Taddeus Azaro), `[116]` (Taddeus Azaro), `[190]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Taddeus frowned."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Taddeus frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Taddeus Azaro: ""We will try, Your Majesty.""*)

### Węzeł `[119]`
Mówca: **Taddeus Azaro**
> ""We will try, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Taddeus Azaro: ""I only hope it is not too little, too late.""*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Taddeus and Lucita looked at one another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucita Azaro: ""In addition, we want your assurance that should my child..."*)

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""In addition, we want your assurance that should my child be a boy, he will take his rightful place as successor to the Rizian throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Taddeus Azaro: ""This is not only what House Azaro wants. It will bring s..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "I saw Carlos' hands form fists."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "I saw Lucita's hands form fists."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "I saw Carlos' hands form fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Taddeus Azaro: ""Your Majesty, I promise we will help you as best we can,..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "I saw Lucita's hands form fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Taddeus Azaro: ""Your Majesty, I promise we will help you as best we can,..."*)

### Węzeł `[128]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I promise we will help you as best we can, under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Taddeus Azaro: ""But I think we should change the subject.""*)

### Węzeł `[129]`
Mówca: **Taddeus Azaro**
> ""The unrest will come to all of us sooner or later. As it did back then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Taddeus Azaro: ""But if you say the Crown has the situation under control..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonetheless, I'm reluctant to resort to violence. I'm holding out hope this can be resolved by other means.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucita Azaro), `[181]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Taddeus Azaro: ""You have more faith in the commoners than I do... But pe..."*)

### Węzeł `[131]`
Mówca: **Taddeus Azaro**
> ""But with most of our house embroiled in the war, we don't have the resources to properly crack down on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Total > 1"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Taddeus Azaro: ""But with most of our house embroiled in the war, we don'..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Taddeus Azaro: ""We can offer a unit from our provincial army. With no wa..."*)

### Węzeł `[135]`
Mówca: **Taddeus Azaro**
> ""House Azaro will help you..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "He and Lucita looked at one another."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Taddeus Azaro: ""House Azaro will help you..""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Taddeus Azaro: ""The Azaro army will help you to the best of our ability.""*)

### Węzeł `[139]`
Mówca: **Lucita Azaro**
> ""We want your assurance that should our child be a boy, he will take his rightful place in the Rizian line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Taddeus Azaro: ""This is not only what House Azaro wants. It will bring s..."*)

### Węzeł `[140]`
Mówca: **Taddeus Azaro**
> ""This is not only what House Azaro wants. It will bring stability and strength back to the kingdom in the wake of the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Succession = true"*)

### Węzeł `[141]`
Mówca: **Taddeus Azaro**
> ""The Azaro army will help you to the best of our ability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true"*)

### Węzeł `[142]`
Mówca: **Narrator**
> "Carlos saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Carlos Robles Azaro: ""Loud and clear, General. The rebellion doesn't stand a c..."*)

### Węzeł `[143]`
Mówca: **Carlos Robles Azaro**
> ""Loud and clear, General. The rebellion doesn't stand a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus: ""Excellent. I knew I could count on you.""*)
  - -> `[199]` (*Player_Romus: ""That's all I wanted to know. I've got to go mingle with ..."*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && Rizia..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player_Romus: ""I made a royal decree to centralize our armed forces. I ..."*)
  - -> `[110]` (*Player_Romus: ""I see what you're getting at, but it's not going to happ..."*)
  - -> `[201]` (*Player_Romus: ""That's all I would have to do to get you on my side? Giv..."*)
  - -> `[202]` (*Player_Romus: ""I understand. I'll have to solve the problem on my own, ..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Succession = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Succession"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""I'm sorry, Lucita, but I can't guarantee that.""*)
  - -> `[147]` (*Player_Romus: ""Of course royal tradition will be respected. If we have ..."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Lucita, but I can't guarantee that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "My wife stepped backwards, shaken."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course royal tradition will be respected. If we have a boy, he will inherit the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "My wife breathed a sigh of relief."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's child is my only heir.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[140]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Narrator: "My wife stroked my arm."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""I have no idea if Vina is even alive or dead. As far as ..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[152]`
Mówca: **Narrator**
> "My wife stepped backwards, shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucita Azaro: ""You can't?""*)

### Węzeł `[153]`
Mówca: **Lucita Azaro**
> ""You can't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_PromisedQueen == true"*)
  - -> `[237]` (*Player_Romus: ""For political reasons, I must name my daughter as succes..."*)
  - -> `[238]` (*Player_Romus: ""Succession law shouldn't favor sons. You have to admit i..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made a promise to Vina long ago. I can't break it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[155]`
Mówca: **Taddeus Azaro**
> ""But I think we should change the subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be right. Does that mean House Azaro will support the Crown in the fight against the revolutionaries?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Path"] == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucita Azaro), `[181]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Taddeus Azaro: ""I don't want the traitors to win any more than you do, Y..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == false"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == false)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player_Romus: ""You may be right. Does that mean House Azaro will suppor..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""A willingness to compromise is what makes a truly great ..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mother's portrait. Do you like it?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Portrait"] == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Taddeus Azaro), `[67]` (Carlos Robles Azaro), `[79]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitari..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitari..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilita..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Taddeus Azaro: ""The depiction you chose truly brought a tear to my eye, ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Taddeus Azaro: ""Ah... I'm no art critic, Your Majesty.""*)

### Węzeł `[164]`
Mówca: **Taddeus Azaro**
> ""The depiction you chose truly brought a tear to my eye, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_Disc..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucita Azaro: ""When we win Pales, it will become a reality.""*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Carlos Robles Azaro: ""Should Rizia find itself at war again, the Queen Mother ..."*)

### Węzeł `[168]`
Mówca: **Lucita Azaro**
> ""When we win Pales, it will become a reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Portrait = true"*)

### Węzeł `[169]`
Mówca: **Carlos Robles Azaro**
> ""Should Rizia find itself at war again, the Queen Mother will be one of our top recruits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Portrait = true"*)

### Węzeł `[170]`
Mówca: **Taddeus Azaro**
> ""Ah... I'm no art critic, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[171]`
Mówca: **Lucita Azaro**
> ""It was a beautiful tribute, Romus. Everyone here thinks so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Portrait = true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lucita Azaro: ""It was a beautiful tribute, Romus. Everyone here thinks ..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Carlos Robles Azaro: ""Nor am I. But it definitely looked like the Queen Mother.""*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Portrait = true"*)

### Węzeł `[178]`
Mówca: **Carlos Robles Azaro**
> ""Nor am I. But it definitely looked like the Queen Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Portrait = true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[180]`
Mówca: **Taddeus Azaro**
> ""But if you say the Crown has the situation under control, I will not challenge you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[181]`
Mówca: **Carlos Robles Azaro**
> ""Agreed. The time for peaceful compromise is long past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == false"*)
  - -> `[130]` (*Player_Romus: ""Nonetheless, I'm reluctant to resort to violence. I'm ho..."*)
  - -> `[184]` (*Player_Romus: ""And what would House Azaro do in my place?""*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A willingness to compromise is what makes a truly great leader. I know the Crown and the protesters will see eye to eye in the end.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucita Azaro), `[181]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Suspicion += 1"*)

### Węzeł `[183]`
Mówca: **Taddeus Azaro**
> ""You have more faith in the commoners than I do... But perhaps you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what would House Azaro do in my place?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucita Azaro), `[181]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Taddeus Azaro: ""We wouldn't let the traitors win. That's for certain.""*)

### Węzeł `[185]`
Mówca: **Taddeus Azaro**
> ""We wouldn't let the traitors win. That's for certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[186]`
Mówca: **Lucita Azaro**
> ""That's not entirely true, Father. We could pull one of our units from the front and deploy them against the revolutionaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Taddeus Azaro: ""Hm... We could.""*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Total > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Total > 1"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Azaro_Total > 1)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Total > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucita Azaro: ""That's not entirely true, Father. We could pull one of o..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Azaro_Total > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true"*)

### Węzeł `[190]`
Mówca: **Taddeus Azaro**
> ""Hm... We could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""No, I cannot authorize this. I command you to help the C..."*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[213]` (*Player_Romus: ""I was hoping for a solution that didn't involve the mili..."*)

### Węzeł `[191]`
Mówca: **Taddeus Azaro**
> ""Under one condition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucita Azaro: ""We want your assurance that should our child be a boy, h..."*)

### Węzeł `[192]`
Mówca: **Lucita Azaro**
> ""That's true, Your Majesty. We'd have to increase recruitment for our provincial army in order to get the necessary manpower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""I was hoping for a solution that didn't involve the mili..."*)
  - -> `[200]` (*Player_Romus: ""That's all I would have to do to get you on my side? Inc..."*)
  - -> `[267]` (*Player_Romus: ""I understand. I'll have to tackle the problem on my own,..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Lucita Azaro: ""Even then, most of our house is embroiled in the war. We..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[196]`
Mówca: **Lucita Azaro**
> ""Even then, most of our house is embroiled in the war. We'd need to institute a massive recruitment drive in order to get the necessary manpower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[197]`
Mówca: **Narrator**
> "He and Lucita looked at one another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Taddeus Azaro: ""Under one condition.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent. I knew I could count on you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Carlos Robles Azaro), `[308]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Taddeus Azaro: ""Always.""*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I wanted to know. I've got to go mingle with the other guests now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Carlos Robles Azaro), `[308]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Taddeus Azaro: ""Understood.""*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I would have to do to get you on my side? Increase the size of our provincial armies?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I would have to do to get you on my side? Give the provinces back the ability to raise their own armies?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Lucita Azaro), `[53]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I'll have to solve the problem on my own, then.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Lucita Azaro), `[53]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ViolentProtests_CardesseMontakla..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that your only condition for lending your support? That Rizia bring back our provincial levies?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Taddeus Azaro), `[116]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough of this. I shall deal with the traitors on my own. Including your house, when the time comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Taddeus Azaro), `[116]` (Taddeus Azaro), `[281]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ViolentProtests_CardesseMontakla..."*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ViolentProtests_CardesseMontak..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Taddeus Azaro: ""Are you sure, Your Majesty? The riots greatly affect us ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Taddeus' brow furrowed."*)

### Węzeł `[208]`
Mówca: **Taddeus Azaro**
> ""Are you sure, Your Majesty? The riots greatly affect us in Cardesse-Montaklar as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[213]` (*Player_Romus: ""I was hoping for a solution that didn't involve the mili..."*)
  - -> `[272]` (*Player_Romus: ""Yes, I'm sure. Let's change the subject.""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucita Azaro: ""You would also have to allow us to double our recruitmen..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[212]`
Mówca: **Lucita Azaro**
> ""You would also have to allow us to double our recruitment numbers, so that we don't have to pull troops from the front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was hoping for a solution that didn't involve the military.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Taddeus Azaro), `[116]` (Taddeus Azaro), `[190]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Taddeus folded his arms across his chest, making sure his..."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Taddeus' brow furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Taddeus Azaro: ""Your Majesty, I promise we will help you as best we can,..."*)

### Węzeł `[215]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I promise we will help you as best we can, under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Taddeus Azaro: ""I only hope it is not too little, too late.""*)

### Węzeł `[216]`
Mówca: **Taddeus Azaro**
> ""I only hope it is not too little, too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[217]`
Mówca: **Narrator**
> "Taddeus folded his arms across his chest, making sure his medals were still visible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Taddeus Azaro: ""Your father and I learned this in 1926, Your Majesty. Br..."*)

### Węzeł `[218]`
Mówca: **Taddeus Azaro**
> ""Your father and I learned this in 1926, Your Majesty. Brute force is the only language these animals speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Carlos nodded his assent."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[222]`
Mówca: **Narrator**
> "Carlos nodded his assent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[225]` (*Player_Romus: ""I don't believe that at all. I will not ask your house t..."*)
  - -> `[228]` (*Player_Romus: ""I have my own ways of applying brute force, if it comes ..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. So you're saying if I reinstate provincial levies, the Azaros will help us against the revolutionaries?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[190]` (Taddeus Azaro), `[208]` (Taddeus Azaro), `[273]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't believe that at all. I will not ask your house to get involved in this.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[222]` (Narrator), `[218]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Taddeus Azaro: ""We will try our best to avoid escalating the situation, ..."*)

### Węzeł `[226]`
Mówca: **Taddeus Azaro**
> ""We will try our best to avoid escalating the situation, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Taddeus Azaro: ""I wish you the best of luck with it.""*)

### Węzeł `[227]`
Mówca: **Taddeus Azaro**
> ""I wish you the best of luck with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have my own ways of applying brute force, if it comes down to it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[222]` (Narrator), `[218]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Taddeus Azaro: ""Then it sounds like you don't need us at all.""*)

### Węzeł `[229]`
Mówca: **Taddeus Azaro**
> ""Then it sounds like you don't need us at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Taddeus Azaro: ""I wish you the best of luck with the situation.""*)

### Węzeł `[230]`
Mówca: **Taddeus Azaro**
> ""I wish you the best of luck with the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[231]`
Mówca: **Taddeus Azaro**
> ""Give us the capability and the resources, and we will do our part to crush the rebellion to a bloody pulp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Very well, General. By royal decree, I will bring back Rizia's provincial army system and increase levies to twice their original size." [Restore And Increase Provincial Levies]"]** — Mówca: **Player_Romus**
> ""Very well, General. By royal decree, I will bring back Rizia's provincial army system and increase levies to twice their original size.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true` AND `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Kontekst wejściowy (poprzednik):** `[231]` (Taddeus Azaro), `[293]` (Taddeus Azaro), `[302]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise = true;..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_PromisedQueen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_PromisedQueen == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_PromisedQueen == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_PromisedQueen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player_Romus: ""I made a promise to Vina long ago. I can't break it.""*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_PromisedQueen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player_Romus: ""Vina wants to be queen more than anything. I can't take ..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina wants to be queen more than anything. I can't take that away from her.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For political reasons, I must name my daughter as successor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Succession law shouldn't favor sons. You have to admit it's a sexist policy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucita Azaro: ""But, Romus... we don't even know where Vina is.""*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Lucita Azaro: ""But, Romus... what about us?""*)

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""But, Romus... we don't even know where Vina is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucita Azaro: ""And after the way she humiliated you, does she even dese..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucita Azaro: ""We're doing our best to coordinate her rescue, but reali..."*)

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""And after the way she humiliated you, does she even deserve to be your heir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[257]` (*Player_Romus: ""If we don't band together against the unrest, the protes..."*)
  - -> `[259]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)

### Węzeł `[247]`
Mówca: **Lucita Azaro**
> ""We're doing our best to coordinate her rescue, but realistically, she might not make it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[257]` (*Player_Romus: ""If we don't band together against the unrest, the protes..."*)
  - -> `[259]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)

### Węzeł `[248]`
Mówca: **Lucita Azaro**
> ""But, Romus... what about us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "She looked at me with pleading eyes."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "My wife breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Lucita Azaro: ""Thank you, Romus. That means so much.""*)

### Węzeł `[250]`
Mówca: **Lucita Azaro**
> ""Thank you, Romus. That means so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition = true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[324]` (*Player_Romus: ""My deepest apologies, but I cannot grant your request. I..."*)

### Węzeł `[252]`
Mówca: **Lucita Azaro**
> ""Our child will represent the union of House Toras and House Azaro. A new way forward for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Lucita Azaro: ""I know how much you love Vina. But if she loves you too,..."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "She looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Lucita Azaro: ""Our child will represent the union of House Toras and Ho..."*)

### Węzeł `[254]`
Mówca: **Lucita Azaro**
> ""I know how much you love Vina. But if she loves you too, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[257]` (*Player_Romus: ""If we don't band together against the unrest, the protes..."*)
  - -> `[259]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)
  - -> `[285]` (*Player_Romus: ""If you truly love *me*, you'll understand why I have to ..."*)

### Węzeł `[255]`
Mówca: **Narrator**
> "My wife stroked my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Lucita Azaro: ""Vina will come back, Romus. And when she does, she'll un..."*)

### Węzeł `[256]`
Mówca: **Lucita Azaro**
> ""Vina will come back, Romus. And when she does, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition = true"*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we don't band together against the unrest, the protesters could kill us all. Are you seriously willing to put our unborn child's life at risk over this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Lucita Azaro), `[247]` (Lucita Azaro), `[254]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Lucita Azaro: ""I...""*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Lucita Azaro), `[247]` (Lucita Azaro), `[254]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "She breathed a sigh of relief."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't even know the sex of our child yet. I will make this decision when the time comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Lucita Azaro), `[247]` (Lucita Azaro), `[254]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Lucita sighed in frustration. She looked at her father ap..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[322]` (*Player_Romus: ""I did away with provincial levies for a reason. I still ..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: ""Very well, General. By royal decree, I will increase pro..."*)
  - -> `[323]` (*Player_Romus: ""The Azaro army is large enough already. You will help cr..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""Very well, General. By royal decree, I will bring back R..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""Very well, General. By royal decree, I will bring back R..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""Very well, General. By royal decree, I will bring back Rizia's provincial army system." [Restore Provincial Levies]"]** — Mówca: **Player_Romus**
> ""Very well, General. By royal decree, I will bring back Rizia's provincial army system.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false` AND `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Kontekst wejściowy (poprzednik):** `[231]` (Taddeus Azaro), `[293]` (Taddeus Azaro), `[302]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise = true;..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I'll have to tackle the problem on my own, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ViolentProtests_CardesseMontakla..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""Very well. So you're saying if I reinstate provincial le..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_To..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. So you're saying if I raise provincial levies, the Azaros will help us against the revolutionaries?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Army_Unit_Azaro_Total"] < 2` AND `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[190]` (Taddeus Azaro), `[208]` (Taddeus Azaro), `[273]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Taddeus Azaro: ""Give us the capability and the resources, and we will do..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm sure. Let's change the subject.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Taddeus Azaro: ""We will try our best to avoid escalating the situation, ..."*)

### Węzeł `[273]`
Mówca: **Taddeus Azaro**
> ""We can offer a unit from our provincial army. With no wars on the horizon, our men and women have been looking for a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""No, I cannot authorize this. I command you to help the C..."*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[213]` (*Player_Romus: ""I was hoping for a solution that didn't involve the mili..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_Total < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_To..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_Total < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Army_Unit_Azaro_Total"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Very well. So you're saying if I raise provincial levies..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_Total < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Army_Unit_Azaro_Total"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player_Romus: ""Very well. I request that you deploy your forces to quel..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I request that you deploy your forces to quell the rebellion.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Army_Unit_Azaro_Total"] < 2) == false` AND `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[190]` (Taddeus Azaro), `[208]` (Taddeus Azaro), `[273]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Lucita Azaro: ""Yes, I wish we could help. But even with provincial recr..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucita Azaro: ""That's true, Your Majesty. We'd have to increase recruit..."*)

### Węzeł `[281]`
Mówca: **Lucita Azaro**
> ""Yes, I wish we could help. But even with provincial recruitment at a maximum, House Azaro can't spare the troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""Enough of this. I shall deal with the traitors on my own..."*)
  - -> `[282]` (*Player_Romus: ""I command you to aid the Crown with whatever resources a..."*)
  - -> `[283]` (*Player_Romus: ""I understand. I won't burden your house with this on top..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I command you to aid the Crown with whatever resources are at your disposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Taddeus frowned."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I won't burden your house with this on top of the war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Taddeus Azaro: ""We will try our best to avoid escalating the situation, ..."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "She breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Lucita Azaro: ""Thank you, Romus. That means so much.""*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you truly love *me*, you'll understand why I have to put my daughter first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Lucita sighed in frustration. She looked at her father ap..."*)

### Węzeł `[286]`
Mówca: **Lucita Azaro**
> ""I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "She looked at her father apologetically."*)

### Węzeł `[287]`
Mówca: **Narrator**
> "She looked at her father apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Lucita Azaro: ""I'm not. Father, we have to do something.""*)

### Węzeł `[288]`
Mówca: **Lucita Azaro**
> ""I'm not. Father, we have to do something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false..."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == fal..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false)  or  (Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Taddeus gave an unsatisfied grunt."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false)  or  (Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Taddeus nodded reluctantly."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "Taddeus gave an unsatisfied grunt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Taddeus Azaro: ""That still depends, doesn't it?""*)

### Węzeł `[293]`
Mówca: **Taddeus Azaro**
> ""That still depends, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Taddeus nodded reluctantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Taddeus Azaro: ""We will.""*)

### Węzeł `[295]`
Mówca: **Taddeus Azaro**
> ""We will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true"*)

### Węzeł `[296]`
Mówca: **Lucita Azaro**
> ""Father... if the revolution succeeds, there won't even be a throne for our child to inherit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Lucita Azaro: ""We have to do something.""*)

### Węzeł `[297]`
Mówca: **Narrator**
> "Lucita sighed in frustration. She looked at her father apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lucita Azaro: ""Father... if the revolution succeeds, there won't even b..."*)

### Węzeł `[298]`
Mówca: **Lucita Azaro**
> ""We have to do something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false..."*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == fal..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false)  or  (Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Taddeus Azaro: ""And as for our troops, Your Majesty?""*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false)  or  (Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Taddeus Azaro: ""In that case, Your Majesty, House Azaro is at your dispo..."*)

### Węzeł `[302]`
Mówca: **Taddeus Azaro**
> ""And as for our troops, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[303]`
Mówca: **Taddeus Azaro**
> ""In that case, Your Majesty, House Azaro is at your disposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true"*)

### Węzeł `[304]`
Mówca: **Taddeus Azaro**
> ""Did you hear that, Carlos? I want you to send word to Camp Domus about this immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Carlos saluted."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Taddeus Azaro: ""Did you hear that, Carlos? I want you to send word to Ca..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucita Azaro: ""I'll send the word to Camp Domus immediately. The rebell..."*)

### Węzeł `[308]`
Mówca: **Lucita Azaro**
> ""I'll send the word to Camp Domus immediately. The rebellion doesn't stand a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus: ""Excellent. I knew I could count on you.""*)
  - -> `[199]` (*Player_Romus: ""That's all I wanted to know. I've got to go mingle with ..."*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && Rizia..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA: ""Very well, General. By royal decree, I will increase provincial levies, on the condition that House Azaro form a unit to deploy against the unrest." [Increase Provincial Levies]"]** — Mówca: **Player_Romus**
> ""Very well, General. By royal decree, I will increase provincial levies on the condition that House Azaro form a unit to deploy against the unrest.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[231]` (Taddeus Azaro), `[293]` (Taddeus Azaro), `[302]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise = true;..."*)

### Węzeł `[310]`
Mówca: **Taddeus Azaro**
> ""Thank you for your trust in us, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[311]`
Mówca: **Taddeus Azaro**
> ""Carlos, I want you to get word to Camp Domus about this immediately. There's no time to waste, understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Carlos saluted."*)

### Węzeł `[312]`
Mówca: **Taddeus Azaro**
> ""Thank you for your trust in us. We will not fail you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucita Azaro: ""I'll send the word to Camp Domus immediately. The rebell..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && Rizia..."*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && Riz..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Player_Romus: ""All three houses, defending the Crown together. This wil..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Player_Romus: ""I still have to convince the other houses. But the Azaro..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All three houses, defending the Crown together. This will be a triumph to remember.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Kontekst wejściowy (poprzednik):** `[143]` (Carlos Robles Azaro), `[308]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Taddeus Azaro: ""We will savor it, Your Majesty.""*)

### Węzeł `[319]`
Mówca: **Taddeus Azaro**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[320]`
Mówca: **Taddeus Azaro**
> ""Always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[321]`
Mówca: **Taddeus Azaro**
> ""We will savor it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did away with provincial levies for a reason. I still think it's too risky for provinces like Cardesse-Montaklar to command their own armies.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Kontekst wejściowy (poprzednik):** `[231]` (Taddeus Azaro), `[293]` (Taddeus Azaro), `[302]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Taddeus Azaro: ""Then there is nothing we can do, Your Majesty.""*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Azaro army is large enough already. You will help crack down on the traitors with the troops you currently have.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[231]` (Taddeus Azaro), `[293]` (Taddeus Azaro), `[302]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Taddeus Azaro: ""We will try, but I fear it will not be enough.""*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My deepest apologies, but I cannot grant your request. It is not your house I distrust, but the others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Taddeus Azaro), `[293]` (Taddeus Azaro), `[302]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Taddeus Azaro: ""If the noble houses can't trust each other after all thi..."*)

### Węzeł `[325]`
Mówca: **Taddeus Azaro**
> ""Then there is nothing we can do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Carlos Robles Azaro: ""God help us all.""*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Taddeus Azaro: ""Best of luck to you.""*)

### Węzeł `[329]`
Mówca: **Carlos Robles Azaro**
> ""God help us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[330]`
Mówca: **Taddeus Azaro**
> ""Best of luck to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[331]`
Mówca: **Taddeus Azaro**
> ""We will try, but I fear it will not be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[332]`
Mówca: **Taddeus Azaro**
> ""If the noble houses can't trust each other after all this time, perhaps Rizia deserves to fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [HOUSE GATHERING CONVERSATION HUB]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""I can't tell you how happy I am to see you back in good ..."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "The Azaros bowed and walked to the far corner of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro"); RemoveConversant("Luci..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Taddeus Azaro: ""Aside from the riots, you mean?""*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Health == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Health == false"*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Default_Azaro_Health == false)"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Health == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == false && RiziaDLC.Pa..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Default_Azaro_Health == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Health = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[344]`
Mówca: **Taddeus Azaro**
> ""Aside from the riots, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Taddeus Azaro: ""To be honest, Your Majesty, the protests are beginning t..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Taddeus Azaro: ""As well as can be, Your Majesty.""*)

### Węzeł `[348]`
Mówca: **Taddeus Azaro**
> ""To be honest, Your Majesty, the protests are beginning to worry me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Taddeus Azaro: ""I recognize the feeling in the air. It was exactly the s..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""I believe we can put an end to the unrest. But I will ne..."*)
  - -> `[25]` (*Player_Romus: ""That revolt could have ended peacefully had the Crown be..."*)
  - -> `[26]` (*Player_Romus: ""I understand now why my father made that deal with Wehle..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Carlos Robles Azaro: ""Yes, we are doing our best to contain what's happening i..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[356]`
Mówca: **Carlos Robles Azaro**
> ""Yes, we are doing our best to contain what's happening in our province. But the fury with which people have taken to the streets is quite alarming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Taddeus Azaro: ""The announcement of Rizia's new theocratic direction thr..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[360]`
Mówca: **Taddeus Azaro**
> ""As well as can be, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[361]`
Mówca: **Taddeus Azaro**
> ""The announcement of Rizia's new theocratic direction threw many of us for a loop, myself included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Lucita Azaro: ""It was a surprise to many of us in the capital as well, ..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Carlos Robles Azaro: ""Don't get me wrong, I'm an observant Wruhecist. But the ..."*)

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""It was a surprise to many of us in the capital as well, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "She looked at me pointedly."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Taddeus Azaro: ""I will tell you that some in our province are still outr..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined =..."*)

### Węzeł `[369]`
Mówca: **Carlos Robles Azaro**
> ""Don't get me wrong, I'm an observant Wruhecist. But the dissolution of the Royal Council? It will take some time to get used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Taddeus Azaro: ""Still, we are prepared to support the Crown through the ..."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "She looked at me pointedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Taddeus Azaro: ""Still, we are prepared to support the Crown through the ..."*)

### Węzeł `[371]`
Mówca: **Taddeus Azaro**
> ""I will tell you that some in our province are still outraged over Duchess Lucita's imprisonment, as justified as it may be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined =..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita, you told me some time ago that House Azaro had complaints about my reign. Is that still the case?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied"] == true`
- **Kontekst wejściowy (poprzednik):** `[386]` (Carlos Robles Azaro), `[387]` (Lucita Azaro), `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "Taddeus glared at his daughter sternly."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_RumburgCeasefireRequested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_RumburgCeasefireRequested == true"*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_RumburgCeasefireRequested == true)"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_RumburgCeasefireRequested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_RumburgCeasefireRequested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Lucita Azaro: ""Father is being too diplomatic to tell you that Rumburg'..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_RumburgCeasefireRequested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_RumburgCeasefireRequested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)

### Węzeł `[376]`
Mówca: **Lucita Azaro**
> ""Father is being too diplomatic to tell you that Rumburg's sudden intervention in the Pales war was not well received.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Lucita Azaro: ""But with time, our citizens will see the necessity of yo..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_WehlenJoined == true)"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Lucita Azaro: ""Father is being too diplomatic to tell you that our deci..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_WehlenJoined == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Pales == true"*)

### Węzeł `[380]`
Mówca: **Lucita Azaro**
> ""Father is being too diplomatic to tell you that our decision to bring Wehlen into the Pales war was not particularly well received.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Lucita Azaro: ""But as long as Pales is restored to us, House Azaro will..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Pales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Pales == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Pales == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Pales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Pales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Lucita Azaro: ""Father is too modest. You'll be rechristening the street..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Pales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Pales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == false"*)

### Węzeł `[384]`
Mówca: **Lucita Azaro**
> ""Father is too modest. You'll be rechristening the streets in the Palesian capital in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Lucita Azaro: ""We'll deliver a full report later. Now's not the time fo..."*)

### Węzeł `[385]`
Mówca: **Carlos Robles Azaro**
> ""We continue to watch our Palesian neighbors with caution. There are those who believe Reinhart's conciliatory attitude is all an act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Carlos Robles Azaro: ""Not that I am one of them.""*)

### Węzeł `[386]`
Mówca: **Carlos Robles Azaro**
> ""Not that I am one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[387]`
Mówca: **Lucita Azaro**
> ""But as long as Pales is restored to us, House Azaro will be happy to see an end to the fighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[388]`
Mówca: **Lucita Azaro**
> ""But with time, our citizens will see the necessity of your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true"*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true )"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player_Romus: ""Lucita, you told me some time ago that House Azaro had c..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Player_Romus: ""Have members of House Azaro expressed any dissatisfactio..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_General = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true"*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_General == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_General == false"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Default_Azaro_General == false)"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_General == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""How is everything in Cardesse-Montaklar?""*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Default_Azaro_General == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined =..."*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Taddeus Azaro: ""The war continues to strain resources, but our house rem..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Carlos Robles Azaro: ""We continue to watch our Palesian neighbors with caution..."*)

### Węzeł `[399]`
Mówca: **Taddeus Azaro**
> ""The war continues to strain resources, but our house remains optimistic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_RumburgCeasefireRequested == true"*)

### Węzeł `[400]`
Mówca: **Narrator**
> "Lucita shot him a troubled glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Lucita Azaro: ""We'll deliver a full report later. Now's not the time fo..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == false"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == false)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Narrator: "Lucita shot him a troubled glance."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "Lucita nodded in affirmation."*)

### Węzeł `[404]`
Mówca: **Narrator**
> "Lucita nodded in affirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Lucita Azaro: ""We'll deliver a full report on Total Tranquility later. ..."*)

### Węzeł `[405]`
Mówca: **Lucita Azaro**
> ""We'll deliver a full report on Total Tranquility later. Now's not the time for war talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDLC...."*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true"*)
  - -> `[408]` (*Player_Romus: ""You've caught me in a good mood. Is there anything your ..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[407]`
Mówca: **Lucita Azaro**
> ""We'll deliver a full report later. Now's not the time for war talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've caught me in a good mood. Is there anything your house requests of your King today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Carlos Robles Azaro), `[387]` (Lucita Azaro), `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operatio..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Player_Romus: ""I hope that our holy kingdom can count on your continued..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player_Romus: ""I hope I can count on the Azaros' continued support. You..."*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope that our holy kingdom can count on your continued support. We will need your military prowess for the many crusades ahead.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Kontekst wejściowy (poprzednik):** `[386]` (Carlos Robles Azaro), `[387]` (Lucita Azaro), `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)

### Węzeł `[413]`
Mówca: **Taddeus Azaro**
> ""Still, we are prepared to support the Crown through the transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I can count on the Azaros' continued support. You are among my family's oldest and most important allies.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[386]` (Carlos Robles Azaro), `[387]` (Lucita Azaro), `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)

### Węzeł `[415]`
Mówca: **Narrator**
> "Taddeus glared at his daughter sternly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Lucita Azaro: ""What? I was only being honest.""*)

### Węzeł `[416]`
Mówca: **Lucita Azaro**
> ""What? I was only being honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the House of Delegates abolished and the royal houses of Toras and Azaro united once more, I've been thinking the military should play a greater role in how Rizia is governed.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false  and  Variable["RiziaDLC.Reform_Path"] == false`
- **Kontekst wejściowy (poprzednik):** `[386]` (Carlos Robles Azaro), `[387]` (Lucita Azaro), `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "Lucita slipped her hand in mine and smiled."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDLC.Lucita_Married == true && RiziaDLC.HouseOfDelegates_Abolished == true && RiziaDLC.Theocracy_Full == false && RiziaDLC.Reform_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDLC...."*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDL..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDLC.Lucita_Married == true && RiziaDLC.HouseOfDelegates_Abolished == true && RiziaDLC.Theocracy_Full == false && RiziaDLC.Reform_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false  and  Variable["RiziaDLC.Reform_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Player_Romus: ""With the House of Delegates abolished and the royal hous..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDLC.Lucita_Married == true && RiziaDLC.HouseOfDelegates_Abolished == true && RiziaDLC.Theocracy_Full == false && RiziaDLC.Reform_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false  and  Variable["RiziaDLC.Reform_Path"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[421]`
Mówca: **Narrator**
> "Lucita slipped her hand in mine and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Lucita Azaro: ""Realizing Ana Azaro's vision of a monarcho-military alli..."*)

### Węzeł `[422]`
Mówca: **Taddeus Azaro**
> ""An interesting thought, both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to you and your house for joining us tonight. If you'll excuse me, I'm going to freshen up my drink.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Taddeus Azaro), `[67]` (Carlos Robles Azaro), `[79]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Taddeus Azaro: ""It was a pleasure speaking with you, Your Majesty.""*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Partner == false && RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Partner == false ..."*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Default_Azaro_Partner == fals..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Partner == false && RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner"] == false  and  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""You haven't said a word about my new partner. Do you app..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Default_Azaro_Partner == false && RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner"] == false  and  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Partner = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Taddeus Azaro: ""I... yes, of course.""*)

### Węzeł `[428]`
Mówca: **Taddeus Azaro**
> ""I can tell you now that the late King Valero always had his suspicions about your... leanings. But having seen you and Princess Lena together, I never would have guessed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Taddeus Azaro: ""I can tell you now that the late King Valero always had ..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Lucita Azaro: ""To be honest, I wasn't surprised in the least.""*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Carlos Robles Azaro: ""It's an unusual predilection for a Rizian king. But you ..."*)

### Węzeł `[435]`
Mówca: **Lucita Azaro**
> ""To be honest, I wasn't surprised in the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Narrator: "She looked me in the eye."*)

### Węzeł `[436]`
Mówca: **Narrator**
> "She looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Lucita Azaro: ""My most heartfelt of congratulations to you and Mr. Adri..."*)

### Węzeł `[437]`
Mówca: **Lucita Azaro**
> ""My most heartfelt of congratulations to you and Mr. Adria. I mean it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player_Romus: ""Your congratulations are accepted.""*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[459]` (*Player_Romus: ""What exactly did my father say about me, General Taddeus?""*)
  - -> `[460]` (*Player_Romus: ""I hope all of Cardesse-Montaklar shares your tolerance.""*)

### Węzeł `[438]`
Mówca: **Carlos Robles Azaro**
> ""It's an unusual predilection for a Rizian king. But you and Mr. Adria have my most heartfelt of congratulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player_Romus: ""Your congratulations are accepted.""*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[459]` (*Player_Romus: ""What exactly did my father say about me, General Taddeus?""*)
  - -> `[460]` (*Player_Romus: ""I hope all of Cardesse-Montaklar shares your tolerance.""*)

### Węzeł `[439]`
Mówca: **Taddeus Azaro**
> ""I... yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[440]`
Mówca: **Taddeus Azaro**
> ""I can tell you now that the late King Valero always had his suspicions about your... leanings. But having seen you in action in the military, I was shocked to hear the news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Taddeus Azaro: ""I can tell you now that the late King Valero always had ..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Taddeus Azaro: ""I can tell you now that the late King Valero always had ..."*)

### Węzeł `[444]`
Mówca: **Taddeus Azaro**
> ""I can tell you now that the late King Valero always had his suspicions about your... leanings. I never would have guessed, myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Lucita Azaro: ""Father. Are you saying that one can't prefer the company..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Carlos Robles Azaro: ""Look at the Derdians, Taddeus. Hell, I'm beginning to th..."*)

### Węzeł `[448]`
Mówca: **Lucita Azaro**
> ""Father. Are you saying that one can't prefer the company of men and be a skilled soldier at the same time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Narrator: "She looked me in the eye."*)

### Węzeł `[449]`
Mówca: **Carlos Robles Azaro**
> ""Look at the Derdians, Taddeus. Hell, I'm beginning to think we should mandate homosexuality in basic training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[459]` (*Player_Romus: ""What exactly did my father say about me, General Taddeus?""*)
  - -> `[460]` (*Player_Romus: ""I hope all of Cardesse-Montaklar shares your tolerance.""*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your congratulations are accepted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Lucita Azaro), `[438]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Taddeus Azaro: ""It will take some time for the people of our province to..."*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mandatory homosexuality in the military... I feel a new decree coming on.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[449]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Horrified looks spread across the Azaros' faces."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Player_Romus: ""Mandatory homosexuality in the military... I feel a new ..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had better mean it. Anyone who dares to challenge the legitimacy of the King's new partnership is a traitor to the realm.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[437]` (Lucita Azaro), `[438]` (Carlos Robles Azaro), `[449]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Taddeus hurriedly interjected."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player_Romus: ""You had better mean it. Anyone who dares to challenge th..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly did my father say about me, General Taddeus?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Lucita Azaro), `[438]` (Carlos Robles Azaro), `[449]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "He winced."*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope all of Cardesse-Montaklar shares your tolerance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Lucita Azaro), `[438]` (Carlos Robles Azaro), `[449]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Taddeus Azaro: ""We will see to it that they do.""*)

### Węzeł `[461]`
Mówca: **Taddeus Azaro**
> ""We will see to it that they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[462]`
Mówca: **Narrator**
> "Horrified looks spread across the Azaros' faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Carlos Robles Azaro: ""That was meant as a joke, Your Majesty.""*)

### Węzeł `[463]`
Mówca: **Carlos Robles Azaro**
> ""That was meant as a joke, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[464]`
Mówca: **Taddeus Azaro**
> ""Your Majesty... perhaps those opinions are best left buried with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[465]`
Mówca: **Narrator**
> "He winced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Taddeus Azaro: ""Your Majesty... perhaps those opinions are best left bur..."*)

### Węzeł `[466]`
Mówca: **Narrator**
> "Taddeus hurriedly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Taddeus Azaro: ""We are all very happy for you, Your Majesty. We'll see t..."*)

### Węzeł `[467]`
Mówca: **Taddeus Azaro**
> ""We are all very happy for you, Your Majesty. We'll see to it that Cardesse-Montaklar celebrates your new love as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[468]`
Mówca: **Taddeus Azaro**
> ""It will take some time for the people of our province to accept this news. But we'll see to it that they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Taddeus Azaro: ""I wasn't very lucid at the time, but I do recall talk am..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Taddeus Azaro: ""Your Majesty, I assure you that House Azaro does not har..."*)

### Węzeł `[473]`
Mówca: **Taddeus Azaro**
> ""I wasn't very lucid at the time, but I do recall talk amongst our house that you had intentions to reform the monarchy against the nobility's will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Taddeus Azaro: ""Fortunately, it seems we were mistaken.""*)

### Węzeł `[474]`
Mówca: **Taddeus Azaro**
> ""Fortunately, it seems we were mistaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)
  - -> `[477]` (*Player_Romus: ""Yes, you were. There will be no anti-nobility reforms on..."*)
  - -> `[485]` (*Player_Romus: ""I allowed Manus Sazon to plead his case for reform, yes...."*)

### Węzeł `[475]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I assure you that House Azaro does not harbor any ill will against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who was spreading such rumors? Tell me, and I'll have them hanged.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[474]` (Taddeus Azaro), `[789]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Narrator: "Taddeus paled."*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, you were. There will be no anti-nobility reforms on King Romus' watch, mark my words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[474]` (Taddeus Azaro), `[789]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Silent == true)"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""*If* I were planning to reform the country, I would not ..."*)
  - -> `[486]` (*Player_Romus: ""Surely you don't believe that Rizia can stay the same fo..."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Silent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* I were planning to reform the country, I would not do so against your house's will.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Kontekst wejściowy (poprzednik):** `[474]` (Taddeus Azaro), `[789]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Taddeus Azaro: ""Hmm. So you don't deny your intentions?""*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player_Romus: ""Who was spreading such rumors? Tell me, and I'll have th..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I allowed Manus Sazon to plead his case for reform, yes. But ultimately, I rejected his misguided ideas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[474]` (Taddeus Azaro), `[789]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surely you don't believe that Rizia can stay the same forever. A kingdom must adapt to the changing times and the will of its people.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Kontekst wejściowy (poprzednik):** `[474]` (Taddeus Azaro), `[789]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Taddeus Azaro: ""That may be so. But such decisions must be made in consu..."*)

### Węzeł `[487]`
Mówca: **Narrator**
> "Taddeus paled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Taddeus Azaro: ""Nobody in particular.""*)

### Węzeł `[488]`
Mówca: **Taddeus Azaro**
> ""Nobody in particular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[489]`
Mówca: **Taddeus Azaro**
> ""That may be so. But such decisions must be made in consultation with provincial leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[490]`
Mówca: **Lucita Azaro**
> ""Good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Taddeus Azaro: ""If that is indeed the case, then I assure you House Azar..."*)

### Węzeł `[491]`
Mówca: **Taddeus Azaro**
> ""Hmm. So you don't deny your intentions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[492]`
Mówca: **Taddeus Azaro**
> ""Especially not since one of our own is now a part of the Royal Family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[493]`
Mówca: **Taddeus Azaro**
> ""Especially not on the Queen Mother's birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Taddeus Azaro: ""Especially not since one of our own is now a part of the..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Taddeus Azaro: ""Especially not on the Queen Mother's birthday.""*)

### Węzeł `[497]`
Mówca: **Taddeus Azaro**
> ""If that is indeed the case, then I assure you House Azaro does not harbor any ill will towards the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Suspicion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Suspicion"] = Variable["RiziaDLC.Reform_Suspicion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Taddeus Azaro: ""In any case, Your Majesty, you must believe that House A..."*)

### Węzeł `[499]`
Mówca: **Taddeus Azaro**
> ""In any case, Your Majesty, you must believe that House Azaro harbors no ill will against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Player_Romus: ""Well, good. I'd hate to think that any of you were plott..."*)
  - -> `[408]` (*Player_Romus: ""You've caught me in a good mood. Is there anything your ..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operatio..."*)
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operat..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Taddeus Azaro: ""Just one, Your Majesty.""*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[504]`
Mówca: **Taddeus Azaro**
> ""Just one, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objecti..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Pales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objecti..."*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objec..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Pales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Taddeus Azaro: ""Now that victory in Pales is all but a certainty, House ..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Pales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Taddeus Azaro: ""Should we achieve victory in Pales, House Azaro humbly w..."*)

### Węzeł `[508]`
Mówca: **Taddeus Azaro**
> ""Now that victory in Pales is all but a certainty, House Azaro humbly wishes to resume its governance of the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Player_Romus: ""Resume? Pales hasn't even been a part of Rizia for over ..."*)
  - -> `[516]` (*Player_Romus: ""Pales will be in a state of instability after it is reco..."*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii == true"*)
  - -> `[511]` (*Player_Romus: ""Of course, General. For your service during this war and..."*)

### Węzeł `[509]`
Mówca: **Taddeus Azaro**
> ""Should we achieve victory in Pales, House Azaro humbly wishes to resume its governance of the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Player_Romus: ""Resume? Pales hasn't even been a part of Rizia for over ..."*)
  - -> `[516]` (*Player_Romus: ""Pales will be in a state of instability after it is reco..."*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii == true"*)
  - -> `[511]` (*Player_Romus: ""Of course, General. For your service during this war and..."*)

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Resume? Pales hasn't even been a part of Rizia for over two centuries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[508]` (Taddeus Azaro), `[509]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Lucita Azaro: ""That may be true. But we Azaros have long memories.""*)

### Węzeł `[511]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, General. For your service during this war and the one that preceded it, you deserve it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[508]` (Taddeus Azaro), `[509]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "Taddeus bowed so deeply he almost fell off his wheelchair."*)

### Węzeł `[512]`
Mówca: **Lucita Azaro**
> ""That may be true. But we Azaros have long memories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player_Romus: ""If it truly means that much to you, I will consider your..."*)
  - -> `[539]` (*Player_Romus: ""Why do you want Pales so badly, anyway? It'll be a smoki..."*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Pales == false && RiziaDL..."*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_RiziaImperii == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii == true"*)
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleOwnership_RiziaImperii == true)"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_RiziaImperii == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Player_Romus: ""We centralized Zille following its return. I was plannin..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleOwnership_RiziaImperii == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales will be in a state of instability after it is reconquered. It needs the full attention of the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[508]` (Taddeus Azaro), `[509]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Taddeus Azaro: ""We have fought the Palesians twice. Do you truly believe..."*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We centralized Zille following its return. I was planning on doing the same with Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true`
- **Kontekst wejściowy (poprzednik):** `[508]` (Taddeus Azaro), `[509]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Lucita Azaro: ""So you would give our house the same treatment as the Sa..."*)

### Węzeł `[518]`
Mówca: **Narrator**
> "Taddeus bowed so deeply he almost fell off his wheelchair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Taddeus Azaro: ""You are too generous, my liege.""*)

### Węzeł `[519]`
Mówca: **Taddeus Azaro**
> ""You are too generous, my liege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PromisedToHouseAzaro = true; RiziaDLCIsola..."*)

### Węzeł `[520]`
Mówca: **Taddeus Azaro**
> ""We have fought the Palesians twice. Do you truly believe we can't handle a little instability?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player_Romus: ""If it truly means that much to you, I will consider your..."*)
  - -> `[539]` (*Player_Romus: ""Why do you want Pales so badly, anyway? It'll be a smoki..."*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Pales == false && RiziaDL..."*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)

### Węzeł `[521]`
Mówca: **Lucita Azaro**
> ""So you would give our house the same treatment as the Sazons? The traitors?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player_Romus: ""If it truly means that much to you, I will consider your..."*)
  - -> `[539]` (*Player_Romus: ""Why do you want Pales so badly, anyway? It'll be a smoki..."*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Pales == false && RiziaDL..."*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Pales == false && RiziaDLC.War_WehlenJoined == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Pales == false && RiziaDL..."*)
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Pales == false && Rizia..."*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Pales == false && RiziaDLC.War_WehlenJoined == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Pales"] == false  and  Variable["RiziaDLC.War_WehlenJoined"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Player_Romus: ""I don't foresee a happy ending to this war. Chances are ..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Pales == false && RiziaDLC.War_WehlenJoined == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Pales"] == false  and  Variable["RiziaDLC.War_WehlenJoined"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't foresee a happy ending to this war. Chances are that no one in Rizia will end up governing Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Objective_Captured_Pales"] == false  and  Variable["RiziaDLC.War_WehlenJoined"] == false`
- **Kontekst wejściowy (poprzednik):** `[512]` (Lucita Azaro), `[520]` (Taddeus Azaro), `[521]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Taddeus Azaro: ""Don't count us out just yet, Your Majesty.""*)

### Węzeł `[526]`
Mówca: **Taddeus Azaro**
> ""Don't count us out just yet, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Lucita Azaro: ""We *will* win Pales. And when we do, I hope you will thi..."*)

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it truly means that much to you, I will consider your request. Once we win, that is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Lucita Azaro), `[520]` (Taddeus Azaro), `[521]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "Taddeus bowed so deeply he almost fell off his wheelchair."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_WehlenJoined == true)"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Player_Romus: ""With Wiktor Smolak now involved, the decision may be out..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_WehlenJoined == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[531]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Wiktor Smolak now involved, the decision may be out of my hands.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Kontekst wejściowy (poprzednik):** `[512]` (Lucita Azaro), `[520]` (Taddeus Azaro), `[521]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Taddeus Azaro: ""We cannot allow Wehlen to control us yet again.""*)

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By the time the war is over, the decision may be out of my hands.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Kontekst wejściowy (poprzednik):** `[512]` (Lucita Azaro), `[520]` (Taddeus Azaro), `[521]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Narrator: "Both Azaros looked at me strangely."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Silent == true)"*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player_Romus: ""By the time the war is over, the decision may be out of ..."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Silent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[536]`
Mówca: **Narrator**
> "Both Azaros looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Taddeus Azaro: ""What do you mean, out of your hands? You're the King.""*)

### Węzeł `[537]`
Mówca: **Taddeus Azaro**
> ""What do you mean, out of your hands? You're the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Suspicion += 1"*)

### Węzeł `[538]`
Mówca: **Taddeus Azaro**
> ""We cannot allow Wehlen to control us yet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Taddeus Azaro: ""But very well...""*)

### Węzeł `[539]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do you want Pales so badly, anyway? It'll be a smoking ruin by the time our armies are done with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Lucita Azaro), `[520]` (Taddeus Azaro), `[521]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Taddeus Azaro: ""But it will give us the sea, Your Majesty. Something all..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Suspicion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Suspicion"] = Variable["RiziaDLC.Reform_Suspicion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Taddeus Azaro: ""But very well...""*)

### Węzeł `[541]`
Mówca: **Taddeus Azaro**
> ""But very well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[542]`
Mówca: **Taddeus Azaro**
> ""But it will give us the sea, Your Majesty. Something all the other provinces have that we in Cardesse-Montaklar lack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Lucita Azaro: ""We *will* win Pales. And when we do, I hope you will thi..."*)

### Węzeł `[543]`
Mówca: **Lucita Azaro**
> ""We *will* win Pales. And when we do, I hope you will think of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true )"*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Narrator: "Taddeus and Lucita looked at each other. Finally, Lucita ..."*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true && Rizi..."*)

### Węzeł `[547]`
Mówca: **Narrator**
> "Taddeus and Lucita looked at each other. Finally, Lucita spoke up gently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Lucita Azaro: ""We do have one request.""*)

### Węzeł `[548]`
Mówca: **Lucita Azaro**
> ""We do have one request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Taddeus Azaro: ""Your Majesty, I can't express how happy I am that you an..."*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, good. I'd hate to think that any of you were plotting against me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[492]` (Taddeus Azaro), `[493]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[550]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I can't express how happy I am that you and my daughter are expecting a child.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Taddeus Azaro: ""And my greatest hope is that if that child is male, he w..."*)

### Węzeł `[551]`
Mówca: **Taddeus Azaro**
> ""And my greatest hope is that if that child is male, he will take his rightful place as successor to the throne of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Player_Romus: ""I'm sorry, Taddeus, but I cannot guarantee that.""*)
  - -> `[553]` (*Player_Romus: ""Of course royal tradition will be respected. If we have ..."*)
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)

### Węzeł `[552]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Taddeus, but I cannot guarantee that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[551]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Narrator: "My wife stepped backward, shaken."*)

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course royal tradition will be respected. If we have a boy, he will inherit the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[551]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Narrator: "My wife breathed a sigh of relief."*)

### Węzeł `[554]`
Mówca: **Narrator**
> "My wife stepped backward, shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Lucita Azaro: ""You can't?""*)

### Węzeł `[555]`
Mówca: **Lucita Azaro**
> ""You can't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_PromisedQueen == true"*)
  - -> `[585]` (*Player_Romus: ""For political reasons, I must name my daughter as succes..."*)
  - -> `[586]` (*Player_Romus: ""A male heir ought not to be favored over his female olde..."*)

### Węzeł `[556]`
Mówca: **Lucita Azaro**
> ""Our child will represent the union of House Toras and House Azaro. A new way forward for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Lucita Azaro: ""I know how much you love Vina. But if she loves you too,..."*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Lucita Azaro: ""And after the way she humiliated you, does she even dese..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Lucita Azaro: ""We're doing our best to coordinate her rescue, but reali..."*)

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's child is my only heir.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[551]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Narrator: "My wife stroked my arm."*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Player_Romus: ""I have no idea if Vina is even alive or dead. As far as ..."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made a promise to Vina long ago. I can't break it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Kontekst wejściowy (poprzednik):** `[555]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[565]`
Mówca: **Lucita Azaro**
> ""And after the way she humiliated you, does she even deserve to be your heir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[576]` (*Player_Romus: ""What are you saying? Are you *hoping* my daughter never ..."*)
  - -> `[571]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)

### Węzeł `[566]`
Mówca: **Lucita Azaro**
> ""We're doing our best to coordinate her rescue, but realistically, she might not make it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[576]` (*Player_Romus: ""What are you saying? Are you *hoping* my daughter never ..."*)
  - -> `[571]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)

### Węzeł `[567]`
Mówca: **Lucita Azaro**
> ""Thank you, Romus. That means so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition = true"*)

### Węzeł `[568]`
Mówca: **Narrator**
> "She looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Lucita Azaro: ""Our child will represent the union of House Toras and Ho..."*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[565]` (Lucita Azaro), `[566]` (Lucita Azaro), `[575]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Narrator: "She breathed a sigh of relief."*)

### Węzeł `[570]`
Mówca: **Narrator**
> "She looked at Taddeus apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Lucita Azaro: ""I am sure His Majesty will make the right decision when ..."*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't even know the sex of our child yet. I will make this decision when the time comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[565]` (Lucita Azaro), `[566]` (Lucita Azaro), `[575]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Narrator: "Taddeus sighed in frustration. Lucita looked at him apolo..."*)

### Węzeł `[572]`
Mówca: **Narrator**
> "She breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Lucita Azaro: ""Thank you, Romus. That means so much.""*)

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you truly love *me*, you'll understand why I have to put my daughter first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[575]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Narrator: "Taddeus sighed in frustration. Lucita looked at him apolo..."*)

### Węzeł `[574]`
Mówca: **Lucita Azaro**
> ""No, of course I'm not!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Narrator: "She looked at Taddeus apologetically."*)

### Węzeł `[575]`
Mówca: **Lucita Azaro**
> ""I know how much you love Vina. But if she loves you too, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[571]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)
  - -> `[573]` (*Player_Romus: ""If you truly love *me*, you'll understand why I have to ..."*)

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you saying? Are you *hoping* my daughter never returns?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[565]` (Lucita Azaro), `[566]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Lucita Azaro: ""No, of course I'm not!""*)

### Węzeł `[577]`
Mówca: **Lucita Azaro**
> ""I am sure His Majesty will make the right decision when the time comes, Father. We shouldn't press the issue while Her Highness is still missing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Taddeus Azaro: ""Yes, all right.""*)

### Węzeł `[578]`
Mówca: **Narrator**
> "Taddeus sighed in frustration. Lucita looked at him apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Lucita Azaro: ""He's right, Father. We're getting ahead of ourselves.""*)

### Węzeł `[579]`
Mówca: **Lucita Azaro**
> ""He's right, Father. We're getting ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Taddeus Azaro: ""Yes, all right.""*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_PromisedQueen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_PromisedQueen == true"*)
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_PromisedQueen == true)"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_PromisedQueen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Player_Romus: ""I made a promise to Vina long ago. I can't break it.""*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_PromisedQueen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Player_Romus: ""Vina wants to be queen more than anything. I can't take ..."*)

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina wants to be queen more than anything. I can't take that away from her.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[555]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For political reasons, I must name my daughter as successor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[586]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A male heir ought not to be favored over his female older sibling. I intend to change that sexist policy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ..."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Lucita Azaro: ""But, Romus... we don't even know where Vina is.""*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Lucita Azaro: ""But, Romus... what about us?""*)

### Węzeł `[590]`
Mówca: **Lucita Azaro**
> ""But, Romus... what about us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Narrator: "She looked at me with pleading eyes."*)

### Węzeł `[591]`
Mówca: **Lucita Azaro**
> ""But, Romus... we don't even know where Vina is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[592]`
Mówca: **Narrator**
> "My wife breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Lucita Azaro: ""Thank you, Romus. That means so much.""*)

### Węzeł `[593]`
Mówca: **Narrator**
> "My wife stroked my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Lucita Azaro: ""Vina will come back, Romus. And when she does, she'll un..."*)

### Węzeł `[594]`
Mówca: **Lucita Azaro**
> ""Vina will come back, Romus. And when she does, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition = true"*)

### Węzeł `[595]`
Mówca: **Taddeus Azaro**
> ""Yes, all right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[596]`
Mówca: **Narrator**
> "Taddeus sighed in frustration. Lucita looked at him apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Lucita Azaro: ""I am sure His Majesty will make the right decision when ..."*)

### Węzeł `[597]`
Mówca: **Lucita Azaro**
> ""I am sure His Majesty will make the right decision when the time comes, Father. We shouldn't press the issue now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Taddeus Azaro: ""Yes, all right.""*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[600]`
Mówca: **Taddeus Azaro**
> ""If you can't guarantee us Pales, I would hope you can promise this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Narrator: "He and Lucita looked at each other."*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true )"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Succession == false"*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Succession == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Succession == false"*)
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Default_Azaro_Succession == f..."*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Succession == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Succession"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Taddeus Azaro: ""If you can't guarantee us Pales, I would hope you can pr..."*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Default_Azaro_Succession == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Succession"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[607]`
Mówca: **Narrator**
> "He and Lucita looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Taddeus Azaro: ""Your Majesty, I can't express how happy I am that you an..."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PromisedToHouseAzaro = true; RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 5`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PromisedToHouseAzaro"] = true;
Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Narrator: "Carlos smiled, showing all his teeth as he did so."*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Narrator: "I saw a hint of sorrow in Taddeus' eyes."*)

### Węzeł `[612]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Azaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Azaro == true)"*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Azaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Azaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Azaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[615]`
Mówca: **Narrator**
> "Carlos smiled, showing all his teeth as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Carlos Robles Azaro: ""The alliance between our two houses is the bedrock on wh..."*)

### Węzeł `[616]`
Mówca: **Carlos Robles Azaro**
> ""The alliance between our two houses is the bedrock on which Rizia stands, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Taddeus Azaro: ""Well put, Carlos.""*)

### Węzeł `[617]`
Mówca: **Taddeus Azaro**
> ""Well put, Carlos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Narrator: "Carlos removed his hat and smiled sincerely."*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Narrator: "Taddeus put a hand to his chest."*)

### Węzeł `[621]`
Mówca: **Narrator**
> "Carlos removed his hat and smiled sincerely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Carlos Robles Azaro: ""The alliance between our two houses is the bedrock on wh..."*)

### Węzeł `[622]`
Mówca: **Narrator**
> "Taddeus put a hand to his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Taddeus Azaro: ""The alliance between our two houses is the bedrock on wh..."*)

### Węzeł `[623]`
Mówca: **Taddeus Azaro**
> ""The alliance between our two houses is the bedrock on which Rizia stands, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Lucita Azaro: ""Exactly.""*)

### Węzeł `[624]`
Mówca: **Lucita Azaro**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[625]`
Mówca: **Narrator**
> "I saw a hint of sorrow in Taddeus' eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Taddeus Azaro: ""The alliance between our two houses is the bedrock on wh..."*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[627]`
Mówca: **Carlos Robles Azaro**
> ""Never in a million years, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Carlos Robles Azaro: ""Never in a million years, Your Majesty.""*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Lucita Azaro: ""I swear you can count on my family's loyalty, {RiziaDLCT..."*)

### Węzeł `[631]`
Mówca: **Lucita Azaro**
> ""I swear you can count on my family's loyalty, {RiziaDLCText.LucitaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still have to convince the other houses. But the Azaros are the most vital piece of the puzzle.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Carlos Robles Azaro), `[308]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Taddeus Azaro: ""Good luck.""*)

### Węzeł `[633]`
Mówca: **Taddeus Azaro**
> ""Good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Carlos Robles Azaro: ""Taddeus, the Viscount of Nelvisar has been waiting all n..."*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Lucita Azaro: ""Father, the Viscount of Nelvisar has been waiting all ni..."*)

### Węzeł `[637]`
Mówca: **Carlos Robles Azaro**
> ""Taddeus, the Viscount of Nelvisar has been waiting all night to congratulate you on your recovery. Shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Taddeus Azaro: ""Yes. Please excuse us, Your Majesty.""*)

### Węzeł `[638]`
Mówca: **Lucita Azaro**
> ""Father, the Viscount of Nelvisar has been waiting all night to congratulate you on your recovery. Shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Taddeus Azaro: ""Yes. Please excuse us, Your Majesty.""*)

### Węzeł `[639]`
Mówca: **Taddeus Azaro**
> ""Yes. Please excuse us, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "The Azaros bowed and walked to the far corner of the room."*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLC.Lucita_Arrested == true && RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true && Rizi..."*)
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true && Ri..."*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLC.Lucita_Arrested == true && RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Carlos Robles Azaro: ""I do have one wish.""*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLC.Lucita_Arrested == true && RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Narrator: "Taddeus shook his head."*)

### Węzeł `[643]`
Mówca: **Carlos Robles Azaro**
> ""I do have one wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Narrator: "Taddeus raised an eyebrow in his direction."*)

### Węzeł `[644]`
Mówca: **Narrator**
> "Taddeus raised an eyebrow in his direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Carlos Robles Azaro: ""I have visited my cousin -- Lucita -- in prison. She swe..."*)

### Węzeł `[645]`
Mówca: **Taddeus Azaro**
> ""Only that you enjoy the evening as much as we have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[646]`
Mówca: **Narrator**
> "Taddeus shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Taddeus Azaro: ""Only that you enjoy the evening as much as we have.""*)

### Węzeł `[647]`
Mówca: **Carlos Robles Azaro**
> ""I have visited my cousin -- Lucita -- in prison. She swears she is innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Player_Romus: ""Are you saying that you know better than the internation..."*)
  - -> `[651]` (*Player_Romus: ""I'm truly sorry, but I cannot exonerate Lucita as long a..."*)
  - -> `[652]` (*Player_Romus: ""Of course, she'll never admit to her guilt. I thought yo..."*)
  - -> `[653]` (*Player_Romus: ""It doesn't matter. By imprisoning her, we avoided a war ..."*)

### Węzeł `[648]`
Mówca: **Taddeus Azaro**
> ""I hope there will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[649]`
Mówca: **Taddeus Azaro**
> ""You are most welcome, Your Majesty. But I do wish I could have served you for longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying that you know better than the international courts?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[647]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Carlos Robles Azaro: ""No, Your Majesty...""*)

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm truly sorry, but I cannot exonerate Lucita as long as Rizia remains allied with Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[647]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Carlos Robles Azaro: ""I understand...""*)

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, she'll never admit to her guilt. I thought you were too smart to fall for her lies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[647]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Carlos Robles Azaro: ""I know Lucita well, Your Majesty. I don't believe she's ..."*)

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter. By imprisoning her, we avoided a war that would have cost us thousands of lives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[647]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1"*)

### Węzeł `[654]`
Mówca: **Carlos Robles Azaro**
> ""No, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Narrator: "Taddeus put a hand on his cousin's shoulder."*)

### Węzeł `[655]`
Mówca: **Carlos Robles Azaro**
> ""I understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Narrator: "Taddeus put a hand on his cousin's shoulder."*)

### Węzeł `[656]`
Mówca: **Carlos Robles Azaro**
> ""I know Lucita well, Your Majesty. I don't believe she's lying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Narrator: "Taddeus put a hand on his cousin's shoulder."*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Carlos Robles Azaro: ""I understand... I think.""*)

### Węzeł `[658]`
Mówca: **Carlos Robles Azaro**
> ""I understand... I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Narrator: "Taddeus put a hand on his cousin's shoulder."*)

### Węzeł `[659]`
Mówca: **Narrator**
> "Taddeus put a hand on his cousin's shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Taddeus Azaro: ""Carlos. Do not question the Crown's justice.""*)

### Węzeł `[660]`
Mówca: **Taddeus Azaro**
> ""Carlos. Do not question the Crown's justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Carlos Robles Azaro: ""I am not asking that Lucita be exonerated. Only that her..."*)

### Węzeł `[661]`
Mówca: **Carlos Robles Azaro**
> ""I am not asking that Lucita be exonerated. Only that her life be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing"*)
  - -> `[663]` (*Player_Romus: ""The punishment for those who betray the Crown is death. ..."*)
  - -> `[664]` (*Player_Romus: ""Your love for your cousin moves me. I will honor your re..."*)
  - -> `[665]` (*Player_Romus: ""Why stop there? Why shouldn't Rizia do away with the dea..."*)

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of monster do you think I am, General? I would never execute Duchess Azaro.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"]) == false`
- **Kontekst wejściowy (poprzednik):** `[661]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "Carlos bowed."*)

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The punishment for those who betray the Crown is death. Are you implying the Duchess is above the law?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Carlos Robles Azaro: ""No... Only that if there is even a slim possibility she ..."*)

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your love for your cousin moves me. I will honor your request and spare her from execution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Narrator: "Carlos bowed."*)

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why stop there? Why shouldn't Rizia do away with the death penalty entirely?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Narrator: "Carlos and Taddeus both gave me looks of offense."*)

### Węzeł `[666]`
Mówca: **Narrator**
> "Carlos bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Carlos Robles Azaro: ""That is all I ask.""*)

### Węzeł `[667]`
Mówca: **Carlos Robles Azaro**
> ""That is all I ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 2"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing"*)
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing)"*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Player_Romus: ""You're right, Carlos. Death is too good for Lucita. Your..."*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Player_Romus: ""What kind of monster do you think I am, General? I would..."*)

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Carlos. Death is too good for Lucita. Your traitorous cousin should be tortured for the rest of her miserable life.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"]`
- **Kontekst wejściowy (poprzednik):** `[661]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Carlos Robles Azaro: ""No! That's not what I meant...""*)

### Węzeł `[672]`
Mówca: **Carlos Robles Azaro**
> ""No! That's not what I meant...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1"*)

### Węzeł `[673]`
Mówca: **Narrator**
> "Carlos bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Carlos Robles Azaro: ""That's most merciful of you, Your Majesty.""*)

### Węzeł `[674]`
Mówca: **Carlos Robles Azaro**
> ""That's most merciful of you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 2"*)

### Węzeł `[675]`
Mówca: **Carlos Robles Azaro**
> ""No... Only that if there is even a slim possibility she is innocent, she should be given the benefit of the doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Carlos Robles Azaro: ""Please consider our request. That is all I ask.""*)

### Węzeł `[676]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty, I still believe that the evildoers of Rizia should be punished to the full extent of the law. But my cousin is not among them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Player_Romus: ""Everybody is somebody's cousin, aren't they? All crimina..."*)
  - -> `[678]` (*Player_Romus: ""I was speaking rhetorically. If I spare Lucita, I'll get..."*)
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everybody is somebody's cousin, aren't they? All criminals should similarly be given the benefit of the doubt.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[676]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Carlos Robles Azaro: ""I am not asking for a removal of the death penalty. I am..."*)

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was speaking rhetorically. If I spare Lucita, I'll get flooded with requests to spare everyone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[676]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Carlos Robles Azaro: ""I am speaking on behalf of House Azaro. One of the oldes..."*)

### Węzeł `[679]`
Mówca: **Narrator**
> "Carlos and Taddeus both gave me looks of offense."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Carlos Robles Azaro: ""Your Majesty, I still believe that the evildoers of Rizi..."*)

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was joking, Carlos. You know how much I love a good beheading.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[676]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Carlos Robles Azaro: ""Oh... Very funny.""*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Player_Romus: ""I was joking, Carlos. You know how much I love a good be..."*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Player_Romus: ""Other countries have stopped using this barbaric form of..."*)

### Węzeł `[684]`
Mówca: **Carlos Robles Azaro**
> ""Oh... Very funny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Player_Romus: ""Don't worry. As long as I am King, your cousin will not ..."*)
  - -> `[691]` (*Player_Romus: ""As long as the death penalty still exists, every Rizian ..."*)
  - -> `[692]` (*Player_Romus: ""I will consider your house's request. That is all I can ..."*)

### Węzeł `[685]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Other countries have stopped using this barbaric form of punishment. Perhaps we really should consider it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[676]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Taddeus Azaro: ""That is a discussion for another time, I think.""*)

### Węzeł `[686]`
Mówca: **Taddeus Azaro**
> ""That is a discussion for another time, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Player_Romus: ""Lucita will live. And I will rethink Rizia's policy of k..."*)
  - -> `[690]` (*Player_Romus: ""Don't worry. As long as I am King, your cousin will not ..."*)
  - -> `[691]` (*Player_Romus: ""As long as the death penalty still exists, every Rizian ..."*)
  - -> `[692]` (*Player_Romus: ""I will consider your house's request. That is all I can ..."*)

### Węzeł `[687]`
Mówca: **Carlos Robles Azaro**
> ""I am speaking on behalf of House Azaro. One of the oldest and most powerful noble families in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Player_Romus: ""Don't worry. As long as I am King, your cousin will not ..."*)
  - -> `[691]` (*Player_Romus: ""As long as the death penalty still exists, every Rizian ..."*)
  - -> `[692]` (*Player_Romus: ""I will consider your house's request. That is all I can ..."*)

### Węzeł `[688]`
Mówca: **Carlos Robles Azaro**
> ""I am not asking for a removal of the death penalty. I am asking for an exception, because this is an exceptional circumstance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Player_Romus: ""Lucita will live. And I will rethink Rizia's policy of k..."*)
  - -> `[690]` (*Player_Romus: ""Don't worry. As long as I am King, your cousin will not ..."*)
  - -> `[691]` (*Player_Romus: ""As long as the death penalty still exists, every Rizian ..."*)
  - -> `[692]` (*Player_Romus: ""I will consider your house's request. That is all I can ..."*)

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita will live. And I will rethink Rizia's policy of killing criminals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[686]` (Taddeus Azaro), `[688]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 1"*)

### Węzeł `[690]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. As long as I am King, your cousin will not be executed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[684]` (Carlos Robles Azaro), `[686]` (Taddeus Azaro), `[687]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "Carlos bowed."*)

### Węzeł `[691]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as the death penalty still exists, every Rizian who has committed a serious enough felony will be subject to it. Without exception.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[684]` (Carlos Robles Azaro), `[686]` (Taddeus Azaro), `[687]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Narrator: "His face hardened into a scowl."*)

### Węzeł `[692]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will consider your house's request. That is all I can promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[684]` (Carlos Robles Azaro), `[686]` (Taddeus Azaro), `[687]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Narrator: "Carlos bowed."*)

### Węzeł `[693]`
Mówca: **Carlos Robles Azaro**
> ""I... thank you, Your Majesty. You are most merciful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Carlos Robles Azaro: ""I... thank you, Your Majesty. You are most merciful.""*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[696]`
Mówca: **Carlos Robles Azaro**
> ""Please consider our request. That is all I ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Taddeus Azaro: ""Carlos. Your Majesty. Perhaps we should leave this be.""*)

### Węzeł `[698]`
Mówca: **Taddeus Azaro**
> ""Carlos. Your Majesty. Perhaps we should leave this be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[699]`
Mówca: **Narrator**
> "His face hardened into a scowl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Carlos Robles Azaro: ""Your Majesty. I truly beg you to reconsider.""*)

### Węzeł `[700]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty. I truly beg you to reconsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1"*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelmi..."*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Taddeus Azaro: ""I have certainly appreciated your commitment to strength..."*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Taddeus Azaro: ""Rizia's armed forces are currently too weak to be put in..."*)

### Węzeł `[704]`
Mówca: **Taddeus Azaro**
> ""I have certainly appreciated your commitment to strengthening the Rizian armed forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[705]`
Mówca: **Taddeus Azaro**
> ""Rizia's armed forces are currently too weak to be put in such a position, but with more investment, it could work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Taddeus Azaro: ""If our troops achieve victory in Pales, the public will ..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[709]`
Mówca: **Taddeus Azaro**
> ""If our troops achieve victory in Pales, the public will not only accept the change, but celebrate it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Taddeus Azaro: ""With my daughter in place as Queen Consort, I would ask ..."*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Taddeus Azaro: ""If we can overcome the current unrest, I'm sure the publ..."*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Taddeus Azaro: ""With my daughter in place as Queen Consort, I would ask ..."*)

### Węzeł `[713]`
Mówca: **Taddeus Azaro**
> ""If we can overcome the current unrest, I'm sure the public will accept the change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Taddeus Azaro: ""With my daughter in place as Queen Consort, I would ask ..."*)

### Węzeł `[714]`
Mówca: **Taddeus Azaro**
> ""With my daughter in place as Queen Consort, I would ask that you appoint me to my old seat on the Royal Council to help plan the transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Player_Romus: ""Done. There are no other suitable candidates, anyway.""*)
  - -> `[719]` (*Player_Romus: ""Are you confident you have the health and stamina to res..."*)
  - -> `[720]` (*Player_Romus: ""That's it? This will be easier than I thought.""*)
  - -> `[721]` (*Player_Romus: ""I was hoping to reward Captain Gordion with the position..."*)

### Węzeł `[715]`
Mówca: **Lucita Azaro**
> ""Realizing Ana Azaro's vision of a monarcho-military alliance. We spoke of this while you were still convalescing, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Taddeus Azaro: ""An interesting thought, both of you.""*)

### Węzeł `[716]`
Mówca: **Taddeus Azaro**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Narrator: "He and Lucita looked at each other."*)

### Węzeł `[717]`
Mówca: **Narrator**
> "He and Lucita looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Taddeus Azaro: ""I do have one more request.""*)

### Węzeł `[718]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Done. There are no other suitable candidates, anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[714]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Taddeus Azaro: ""As I served His Majesty Valero, so would I pledge to ser..."*)

### Węzeł `[719]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you confident you have the health and stamina to resume the position?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[714]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Taddeus Azaro: ""As I served His Majesty Valero, so would I pledge to ser..."*)

### Węzeł `[720]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? This will be easier than I thought.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[714]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Narrator: "He and Lucita looked at each other."*)

### Węzeł `[721]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was hoping to reward Captain Gordion with the position. But I will consider you instead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[714]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Taddeus Azaro: ""Thank you.""*)

### Węzeł `[722]`
Mówca: **Taddeus Azaro**
> ""I do have one more request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Taddeus Azaro: ""If this alliance is to work, the union of Azaro and Tora..."*)

### Węzeł `[723]`
Mówca: **Taddeus Azaro**
> ""As I served His Majesty Valero, so would I pledge to serve you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Narrator: "He and Lucita looked at each other."*)

### Węzeł `[724]`
Mówca: **Taddeus Azaro**
> ""If this alliance is to work, the union of Azaro and Toras must last for generations to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Taddeus Azaro: ""It is therefore my hope that if your child is male, he w..."*)

### Węzeł `[725]`
Mówca: **Taddeus Azaro**
> ""It is therefore my hope that if your child is male, he will take his rightful place as successor to the throne of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Player_Romus: ""I'm sorry, Taddeus, but I cannot guarantee that.""*)
  - -> `[727]` (*Player_Romus: ""Of course royal tradition will be respected. If we have ..."*)
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Taddeus, but I cannot guarantee that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[725]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Narrator: "My wife stepped backward, shaken."*)

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course royal tradition will be respected. If we have a boy, he will inherit the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[725]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Narrator: "My wife breathed a sigh of relief."*)

### Węzeł `[728]`
Mówca: **Narrator**
> "My wife stepped backward, shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Lucita Azaro: ""You can't?""*)

### Węzeł `[729]`
Mówca: **Lucita Azaro**
> ""You can't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_PromisedQueen == true"*)
  - -> `[757]` (*Player_Romus: ""For political reasons, I must name my daughter as succes..."*)
  - -> `[758]` (*Player_Romus: ""A male heir ought not to be favored over his female olde..."*)

### Węzeł `[730]`
Mówca: **Lucita Azaro**
> ""Our child will represent the union of House Toras and House Azaro. A new way forward for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Lucita Azaro: ""I know how much you love Vina. But if she loves you too,..."*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Lucita Azaro: ""And after the way she humiliated you, does she even dese..."*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Lucita Azaro: ""We're doing our best to coordinate her rescue, but reali..."*)

### Węzeł `[734]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's child is my only heir.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[725]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Narrator: "My wife stroked my arm."*)

### Węzeł `[735]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[736]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Player_Romus: ""I have no idea if Vina is even alive or dead. As far as ..."*)

### Węzeł `[737]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[738]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made a promise to Vina long ago. I can't break it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Kontekst wejściowy (poprzednik):** `[729]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[739]`
Mówca: **Lucita Azaro**
> ""And after the way she humiliated you, does she even deserve to be your heir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Player_Romus: ""What are you saying? Are you *hoping* my daughter never ..."*)
  - -> `[743]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[745]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)

### Węzeł `[740]`
Mówca: **Lucita Azaro**
> ""We're doing our best to coordinate her rescue, but realistically, she might not make it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Player_Romus: ""What are you saying? Are you *hoping* my daughter never ..."*)
  - -> `[743]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[745]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)

### Węzeł `[741]`
Mówca: **Lucita Azaro**
> ""Thank you, Romus. That means so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition = true;..."*)

### Węzeł `[742]`
Mówca: **Narrator**
> "She looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Lucita Azaro: ""Our child will represent the union of House Toras and Ho..."*)

### Węzeł `[743]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[739]` (Lucita Azaro), `[740]` (Lucita Azaro), `[749]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Narrator: "She breathed a sigh of relief."*)

### Węzeł `[744]`
Mówca: **Narrator**
> "She looked at Taddeus apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Taddeus Azaro: ""Your Majesty, if you cannot even commit to follow royal ..."*)

### Węzeł `[745]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't even know the sex of our child yet. I will make this decision when the time comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[739]` (Lucita Azaro), `[740]` (Lucita Azaro), `[749]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Narrator: "Taddeus sighed in frustration. Lucita looked at him apolo..."*)

### Węzeł `[746]`
Mówca: **Narrator**
> "She breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Lucita Azaro: ""Thank you, Romus. That means so much.""*)

### Węzeł `[747]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you truly love *me*, you'll understand why I have to put my daughter first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[749]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Narrator: "Taddeus sighed in frustration. Lucita looked at him apolo..."*)

### Węzeł `[748]`
Mówca: **Lucita Azaro**
> ""No, of course I'm not!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Narrator: "She looked at Taddeus apologetically."*)

### Węzeł `[749]`
Mówca: **Lucita Azaro**
> ""I know how much you love Vina. But if she loves you too, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Player_Romus: ""Yes... you're right. *If* we have a son, he will take Vi..."*)
  - -> `[745]` (*Player_Romus: ""We don't even know the sex of our child yet. I will make..."*)
  - -> `[747]` (*Player_Romus: ""If you truly love *me*, you'll understand why I have to ..."*)

### Węzeł `[750]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you saying? Are you *hoping* my daughter never returns?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[739]` (Lucita Azaro), `[740]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Lucita Azaro: ""No, of course I'm not!""*)

### Węzeł `[751]`
Mówca: **Narrator**
> "Taddeus sighed in frustration. Lucita looked at him apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Taddeus Azaro: ""Your Majesty, if you cannot even commit to follow royal ..."*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition = true; RiziaDLC.Path_Stratocracy = true; RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] = true;
Variable["RiziaDLC.Path_Stratocracy"] = true;
Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Narrator: "Taddeus smiled proudly."*)

### Węzeł `[753]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_PromisedQueen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_PromisedQueen == true"*)
  - -> `[755]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_PromisedQueen == true)"*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_PromisedQueen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Player_Romus: ""I made a promise to Vina long ago. I can't break it.""*)

### Węzeł `[755]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_PromisedQueen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Player_Romus: ""Vina wants to be queen more than anything. I can't take ..."*)

### Węzeł `[756]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina wants to be queen more than anything. I can't take that away from her.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[729]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[757]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For political reasons, I must name my daughter as successor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[729]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[758]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A male heir ought not to be favored over his female older sibling. I intend to change that sexist policy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[729]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[759]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ..."*)

### Węzeł `[760]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Lucita Azaro: ""But, Romus... we don't even know where Vina is.""*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Lucita Azaro: ""But, Romus... what about us?""*)

### Węzeł `[762]`
Mówca: **Lucita Azaro**
> ""But, Romus... what about us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Narrator: "She looked at me with pleading eyes."*)

### Węzeł `[763]`
Mówca: **Lucita Azaro**
> ""But, Romus... we don't even know where Vina is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[764]`
Mówca: **Narrator**
> "My wife breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Lucita Azaro: ""Thank you, Romus. That means so much.""*)

### Węzeł `[765]`
Mówca: **Narrator**
> "My wife stroked my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Lucita Azaro: ""Vina will come back, Romus. And when she does, she'll un..."*)

### Węzeł `[766]`
Mówca: **Lucita Azaro**
> ""Vina will come back, Romus. And when she does, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition = true;..."*)

### Węzeł `[767]`
Mówca: **Narrator**
> "Taddeus sighed in frustration. Lucita looked at him apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Taddeus Azaro: ""Your Majesty, if you cannot even commit to follow royal ..."*)

### Węzeł `[768]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Azaro Default Convo Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Azaro Default Convo Hub"*)

### Węzeł `[769]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, if you cannot even commit to follow royal tradition, than I don't see how we can work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1"*)

### Węzeł `[770]`
Mówca: **Taddeus Azaro**
> ""But of course, the Rizian military is still at your disposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Taddeus Azaro: ""But of course, the Rizian military is still at your disp..."*)

### Węzeł `[772]`
Mówca: **Carlos Robles Azaro**
> ""So what's going to happen now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Lucita Azaro: ""Our next step should be to establish a headquarters for ..."*)

### Węzeł `[773]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[774]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Carlos Robles Azaro: ""So what's going to happen now?""*)

### Węzeł `[775]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Lucita Azaro: ""Our next step should be to establish a headquarters for ..."*)

### Węzeł `[776]`
Mówca: **Narrator**
> "Taddeus smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Taddeus Azaro: ""History will remember this day.""*)

### Węzeł `[777]`
Mówca: **Taddeus Azaro**
> ""History will remember this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[778]`
Mówca: **Lucita Azaro**
> ""Our next step should be to establish a headquarters for the military in Porte Drazon. Ideally in or near Palas Rezna...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Taddeus Azaro: ""But we are getting ahead of ourselves. For now, let's en..."*)

### Węzeł `[779]`
Mówca: **Taddeus Azaro**
> ""But we are getting ahead of ourselves. For now, let's enjoy this evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[780]`
Mówca: **Taddeus Azaro**
> ""I will submit my petition regardless. I place my fate in your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[781]`
Mówca: **Taddeus Azaro**
> ""I was as saddened by my daughter's betrayal as you were. She certainly does not represent all of the Azaros.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Taddeus Azaro: ""I will submit my petition regardless. I place my fate in..."*)

### Węzeł `[782]`
Mówca: **Narrator**
> "Taddeus' expression turned mournful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Taddeus Azaro: ""I was as saddened by my daughter's betrayal as you were...."*)

### Węzeł `[783]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[408]` (*Player_Romus: ""You've caught me in a good mood. Is there anything your ..."*)
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[784]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have members of House Azaro expressed any dissatisfaction about my reign?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[386]` (Carlos Robles Azaro), `[387]` (Lucita Azaro), `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Narrator: "Taddeus shook his head hurriedly."*)

### Węzeł `[785]`
Mówca: **Narrator**
> "Taddeus shook his head hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[786]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[787]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Taddeus Azaro: ""No. Well...""*)

### Węzeł `[788]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Taddeus Azaro: ""Your Majesty, I assure you that House Azaro does not har..."*)

### Węzeł `[789]`
Mówca: **Taddeus Azaro**
> ""At some point during my recovery, I did hear talk amongst our house that you had intentions to reform the monarchy against the nobility's will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)
  - -> `[477]` (*Player_Romus: ""Yes, you were. There will be no anti-nobility reforms on..."*)
  - -> `[485]` (*Player_Romus: ""I allowed Manus Sazon to plead his case for reform, yes...."*)

### Węzeł `[790]`
Mówca: **Taddeus Azaro**
> ""No. Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Taddeus Azaro: ""At some point during my recovery, I did hear talk amongs..."*)

### Węzeł `[791]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[793]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[792]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Lucita Azaro: ""And the Royal Council, of course.""*)

### Węzeł `[793]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Suspicion += 1"*)

### Węzeł `[794]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[796]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[795]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Lucita Azaro: ""Good to hear.""*)

### Węzeł `[796]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Taddeus Azaro: ""If that is indeed the case, then I assure you House Azar..."*)

### Węzeł `[797]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because if you *were* plotting against me, I would find out. And I would crush your so-called noble house into a million bloody pieces.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[627]` (Carlos Robles Azaro), `[631]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Taddeus Azaro: ""Please, Your Majesty. The Crown has our fealty now and f..."*)

### Węzeł `[798]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[799]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Player_Romus: ""Because if you *were* plotting against me, I would find ..."*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Player_Romus: ""I do value honesty among my subjects. If I did find out ..."*)

### Węzeł `[801]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do value honesty among my subjects. If I did find out that any member of House Azaro was planning to challenge the throne, the consequences would be *extremely* dire.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[627]` (Carlos Robles Azaro), `[631]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Taddeus Azaro: ""Please, Your Majesty. The Crown has our fealty now and f..."*)

### Węzeł `[802]`
Mówca: **Taddeus Azaro**
> ""Please, Your Majesty. The Crown has our fealty now and forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[803]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [HOUSE GATHERING CONVERSATION HUB]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""I can't tell you how happy I am to see you back in good ..."*)

### Węzeł `[804]`
Mówca: **Taddeus Azaro**
> ""It was a pleasure speaking with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[805]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[806]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Narrator: "He saluted once more as Carlos rolled his wheelchair away."*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]` (*Narrator: "He saluted once more as Lucita rolled his wheelchair away."*)

### Węzeł `[808]`
Mówca: **Narrator**
> "He saluted once more as Carlos rolled his wheelchair away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro"); RemoveConversant("Luci..."*)

### Węzeł `[809]`
Mówca: **Narrator**
> "He saluted once more as Lucita rolled his wheelchair away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro"); RemoveConversant("Luci..."*)

### Węzeł `[810]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Portrait = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Portrait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[811]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == false"*)
  - -> `[813]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == fal..."*)

### Węzeł `[812]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Portrait"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player_Romus: ""My mother's portrait. Do you like it?""*)

### Węzeł `[813]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Portrait"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[814]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_DiscussedStratocracy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_Disc..."*)
  - -> `[816]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_Di..."*)

### Węzeł `[815]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_DiscussedStratocracy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Path_Stratocracy"] == true  or  Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Lucita Azaro: ""The Rizian royal family endowed with the strength of the..."*)

### Węzeł `[816]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_DiscussedStratocracy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Path_Stratocracy"] == true  or  Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[817]`
Mówca: **Lucita Azaro**
> ""The Rizian royal family endowed with the strength of the military. A vision of what's to come, perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Portrait = true"*)

### Węzeł `[818]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise = true;
RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise"] = true;
Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Taddeus Azaro: ""Thank you for your trust in us. We will not fail you.""*)

### Węzeł `[819]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise = true; RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise"] = true;
Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Taddeus Azaro: ""Thank you for your trust in us, Your Majesty.""*)

### Węzeł `[820]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Carlos Robles Azaro: ""Enough with the false modesty, Taddeus. His Majesty is l..."*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [Azaro Default Convo Hub]"*)

### Węzeł `[823]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[825]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[824]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Taddeus Azaro: ""Carlos, I want you to get word to Camp Domus about this ..."*)

### Węzeł `[825]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucita Azaro: ""I'll send the word to Camp Domus immediately. The rebell..."*)

### Węzeł `[826]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true"*)
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true)"*)

### Węzeł `[827]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PiplineNasDes_Taddeus_1926Uprising"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]` (*Taddeus Azaro: ""As I've mentioned before, the current atmosphere mirrors..."*)

### Węzeł `[828]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PiplineNasDes_Taddeus_1926Uprising"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Taddeus Azaro: ""I recognize the feeling in the air. It was exactly the s..."*)

### Węzeł `[829]`
Mówca: **Taddeus Azaro**
> ""As I've mentioned before, the current atmosphere mirrors that of 1926.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Default_Azaro_Unrest = true"*)

### Węzeł `[830]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[832]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[831]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Lucita Azaro: ""Father. He's made himself clear.""*)

### Węzeł `[832]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Carlos Robles Azaro: ""His Majesty's made himself clear, my cousin.""*)

### Węzeł `[833]`
Mówca: **Lucita Azaro**
> ""And the Royal Council, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Suspicion += 1"*)

### Węzeł `[834]`
Mówca: **Lucita Azaro**
> ""Father. He's made himself clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Suspicion += 1"*)

### Węzeł `[835]`
Mówca: **Carlos Robles Azaro**
> ""His Majesty's made himself clear, my cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Suspicion += 1"*)

### Węzeł `[836]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "Jump to: [HOUSE GATHERING CONVERSATION HUB]"*)

### Węzeł `[837]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Węzeł Logiki Narracyjnej: "Jump to: [HOUSE GATHERING CONVERSATION HUB]"*)
