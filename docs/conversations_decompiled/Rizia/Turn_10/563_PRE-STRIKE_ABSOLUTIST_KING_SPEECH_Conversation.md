# Rizia/Turn 10/STRIKE SCENE/PRE-STRIKE ABSOLUTIST KING SPEECH/PRE-STRIKE ABSOLUTIST KING SPEECH Conversation

- **ID konwersacji:** `563`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/563_PRE-STRIKE_ABSOLUTIST_KING_SPEECH_Conversation.md`
- **Liczba węzłów dialogowych:** 294
- **Liczba wyborów gracza:** 66

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[67]** Hubertus Toras
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[91]** Rico Toras
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.Birthday_WarnedAboutCoup`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn09_Coup_Warning`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLCIsolated.BirthdayGathering_OnlyLeona`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[11]`
- Węzeł `[11]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[11]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **""The time for conversation is over... NOW." [Signal for attack]"** | `[28]` **Narrator**: "Hugo’s eyes flicked toward him s..."<br>`[98]` **Narrator**: "Taddeus’ eyes flicked toward him..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[12]` | **"“Your ancestor Fedo didn't know his place when he tried to seize the crown without..."** | `[198]` **Leona Sazon**: ""It is your right to mete out ju..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>`[218]` **Leona Sazon**: ""I swear we're innocent!"" |
| `[13]` | **""Treachery runs in your veins, etched into the soil of the lands you own. To ignor..."** | `[214]` **Manus Sazon**: ""It's no use. This was the King'..."<br>`[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "My words lingered heavily in the..."<br>`[223]` **Narrator**: "By this point, everyone in the r..." |
| `[15]` | **""House Sazon... You're even worse. I should have had you all killed after the Upri..."** | `[198]` **Leona Sazon**: ""It is your right to mete out ju..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>`[218]` **Leona Sazon**: ""I swear we're innocent!"" |
| `[16]` | **""Time is a cruel teacher, and it seems the lesson hasn't quite been learned. If I ..."** | `[214]` **Manus Sazon**: ""It's no use. This was the King'..."<br>`[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "My words lingered heavily in the..."<br>`[223]` **Narrator**: "By this point, everyone in the r..." |
| `[17]` | **""If you haven’t yet caught on to what I’m implying, I have other ways of spelling ..."** | `[214]` **Manus Sazon**: ""It's no use. This was the King'..."<br>`[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "My words lingered heavily in the..."<br>`[223]` **Narrator**: "By this point, everyone in the r..." |
| `[18]` | **""Disloyalty runs in your blood, and it shows itself whenever you push beyond the l..."** | `[214]` **Manus Sazon**: ""It's no use. This was the King'..."<br>`[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "My words lingered heavily in the..."<br>`[223]` **Narrator**: "By this point, everyone in the r..." |
| `[22]` | **""Place? There is no place for your house in Rizia, Countess Leona.""** | `[198]` **Leona Sazon**: ""It is your right to mete out ju..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>`[218]` **Leona Sazon**: ""I swear we're innocent!"" |
| `[23]` | **""I believe you're innocent. Just as you must believe that there is nothing persona..."** | `[214]` **Manus Sazon**: ""It's no use. This was the King'..."<br>`[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "My words lingered heavily in the..."<br>`[223]` **Narrator**: "By this point, everyone in the r..." |
| `[29]` | **"“To remind you that sometimes, in order to serve a greater good, we must turn agai..."** | `[97]` **Hugo Toras**: ""Forgive me, Your Majesty, but w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Rico Toras**: ""If you're implying what I think..."<br>`[286]` **Hugo Toras**: ""Interesting. I recall such ravi..." |
| `[30]` | **""Setting aside the Uprising of 1926, what would you consider the most turbulent pe..."** | `[28]` **Narrator**: "Hugo’s eyes flicked toward him s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Rico Toras**: "“I've always found history borin..."<br>`[39]` **Hugo Toras**: "'The War of Rizian Succession, o..." |
| `[31]` | **""I trust everyone here is familiar with the War of Rizian Succession.”"** | `[28]` **Narrator**: "Hugo’s eyes flicked toward him s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Rico Toras**: "“I've always found history boring.""<br>`[32]` **Hugo Toras**: "“I will assume you're speaking r..." |
| `[33]` | **""Correct. Ariana was forced into a bitter feud with her own blood relations, and s..."** | `[38]` **Hubertus Toras**: ""The war was one of the most vio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Hugo Toras**: ""Forgive me, Your Majesty, but w..." |
| `[34]` | **""Time for a little quiz. How did House Toras secure the throne all those years ago?""** | `[28]` **Narrator**: "Hugo’s eyes flicked toward him s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Hubertus Toras**: ""Why, it was a direct result of ..." |
| `[35]` | **"“Ambition shattered familial bonds, leading to the deaths of many and a nation tor..."** | `[38]` **Hubertus Toras**: ""The war was one of the most vio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Hugo Toras**: ""Forgive me, Your Majesty, but w..." |
| `[36]` | **""Ah, good to know someone’s paying attention.""** | `[38]` **Hubertus Toras**: ""The war was one of the most vio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Hugo Toras**: ""Forgive me, Your Majesty, but w..." |
| `[40]` | **""If you haven't yet clued in to the message I'm trying to send, I have other ways ..."** | `[97]` **Hugo Toras**: ""Forgive me, Your Majesty, but w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Rico Toras**: ""If you're implying what I think..."<br>`[286]` **Hugo Toras**: ""Interesting. I recall such ravi..." |
| `[41]` | **""Funny how historical betrayal tends to repeat itself.""** | `[97]` **Hugo Toras**: ""Forgive me, Your Majesty, but w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Rico Toras**: ""If you're implying what I think..."<br>`[286]` **Hugo Toras**: ""Interesting. I recall such ravi..." |
| `[53]` | **""Looking back, what would you say was the most lasting result of the War of Rizian..."** | `[98]` **Narrator**: "Taddeus’ eyes flicked toward him..."<br>`[102]` **Narrator**: "Leona's eyes flicked towards him..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Taddeus Azaro**: ""Besides the destruction of Fort..."<br>`[75]` **Angelica Sazon**: ""The War of Rizian Succession, Y..."<br>*(oraz 2 innych odgałęzień)* |
| `[54]` | **""Not including the Uprising of 1926, what would you say was the most turbulent per..."** | `[98]` **Narrator**: "Taddeus’ eyes flicked toward him..."<br>`[102]` **Narrator**: "Leona's eyes flicked towards him..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Taddeus Azaro**: ""Are you trying to test us, Your..."<br>`[59]` **Angelica Sazon**: ""You must be referring to the Wa..."<br>*(oraz 2 innych odgałęzień)* |
| `[87]` | **""It was not so long ago in Rizian history that the three noble houses were at bitt..."** | `[98]` **Narrator**: "Taddeus’ eyes flicked toward him..."<br>`[102]` **Narrator**: "Leona's eyes flicked towards him..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Taddeus Azaro**: ""During the War of Rizian Succes..."<br>`[94]` **Angelica Sazon**: ""Yes. How I wish House Sazon had..."<br>*(oraz 2 innych odgałęzień)* |
| `[110]` | **""The Toras dynasty lasted more than a century, and it will last for hundreds of ye..."** | `[97]` **Hugo Toras**: ""Forgive me, Your Majesty, but w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Rico Toras**: ""If you're implying what I think..."<br>`[286]` **Hugo Toras**: ""Interesting. I recall such ravi..." |
| `[118]` | **""Just as Ana Azaro had to be defeated for the good of the kingdom, so her ancestor..."** | `[162]` **Player_Romus**: ""It was my ancestor Ariana who f..."<br>`[163]` **Player_Romus**: ""To this day... and not a moment..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Lucita Azaro**: ""'Justice? What is it that you t..."<br>`[159]` **Taddeus Azaro**: ""Justice? What is it that you th..." |
| `[119]` | **""Your family has begun to test the boundaries of loyalty through surreptitious man..."** | `[162]` **Player_Romus**: ""It was my ancestor Ariana who f..."<br>`[163]` **Player_Romus**: ""To this day... and not a moment..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Lucita Azaro**: ""'Surreptitious maneuvering?' Yo..."<br>`[160]` **Taddeus Azaro**: ""'Surreptitious maneuvering?"" |
| `[120]` | **""Recent actions suggest House Azaro is growing dangerously independent from the Cr..."** | `[162]` **Player_Romus**: ""It was my ancestor Ariana who f..."<br>`[163]` **Player_Romus**: ""To this day... and not a moment..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Lucita Azaro**: ""'Dangerously independent?' You ..."<br>`[152]` **Taddeus Azaro**: ""'Dangerously independent?'"" |
| `[140]` | **""It should be here any minute...""** | `[133]` **Taddeus Azaro**: ""With all due respect, if you in..."<br>`[134]` **Lucita Azaro**: ""Where is this coming from, Romu..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[224]` **Player_Romus**: ""NOW!""<br>`[225]` **Player_Romus**: ""No more excuses. Every one of y..."<br>*(oraz 2 innych odgałęzień)* |
| `[141]` | **""Evidence? As King, my authority requires no justification -- only decisive action.""** | `[133]` **Taddeus Azaro**: ""With all due respect, if you in..."<br>`[134]` **Lucita Azaro**: ""Where is this coming from, Romu..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[224]` **Player_Romus**: ""NOW!""<br>`[225]` **Player_Romus**: ""No more excuses. Every one of y..."<br>*(oraz 2 innych odgałęzień)* |
| `[142]` | **""Stop playing dumb. I know every detail of your plan.""** | `[133]` **Taddeus Azaro**: ""With all due respect, if you in..."<br>`[134]` **Lucita Azaro**: ""Where is this coming from, Romu..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true` | `--;` | `[224]` **Player_Romus**: ""NOW!""<br>`[225]` **Player_Romus**: ""No more excuses. Every one of y..."<br>*(oraz 2 innych odgałęzień)* |
| `[143]` | **""Divine will does not require proof -- it demands obedience.""** | `[133]` **Taddeus Azaro**: ""With all due respect, if you in..."<br>`[134]` **Lucita Azaro**: ""Where is this coming from, Romu..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `--;` | `[224]` **Player_Romus**: ""NOW!""<br>`[225]` **Player_Romus**: ""No more excuses. Every one of y..."<br>*(oraz 2 innych odgałęzień)* |
| `[147]` | **""I AM the evidence. My word alone shapes the truth in this realm. Everyone here wo..."** | `[133]` **Taddeus Azaro**: ""With all due respect, if you in..."<br>`[134]` **Lucita Azaro**: ""Where is this coming from, Romu..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[224]` **Player_Romus**: ""NOW!""<br>`[225]` **Player_Romus**: ""No more excuses. Every one of y..."<br>*(oraz 2 innych odgałęzień)* |
| `[162]` | **""It was my ancestor Ariana who forced the Azaros into an alliance. By beating them..."** | `[115]` **Lucita Azaro**: ""No, Father. His Majesty must be..."<br>`[117]` **Taddeus Azaro**: ""No, Carlos... I believe His Maj..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[120]` **Player_Romus**: ""Recent actions suggest House Az..."<br>`[119]` **Player_Romus**: ""Your family has begun to test t..."<br>*(oraz 1 innych odgałęzień)* |
| `[163]` | **""To this day... and not a moment longer.""** | `[115]` **Lucita Azaro**: ""No, Father. His Majesty must be..."<br>`[117]` **Taddeus Azaro**: ""No, Carlos... I believe His Maj..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[120]` **Player_Romus**: ""Recent actions suggest House Az..."<br>`[119]` **Player_Romus**: ""Your family has begun to test t..."<br>*(oraz 1 innych odgałęzień)* |
| `[164]` | **""You're conveniently forgetting what happened before that. The treachery of your a..."** | `[115]` **Lucita Azaro**: ""No, Father. His Majesty must be..."<br>`[117]` **Taddeus Azaro**: ""No, Carlos... I believe His Maj..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[120]` **Player_Romus**: ""Recent actions suggest House Az..."<br>`[119]` **Player_Romus**: ""Your family has begun to test t..."<br>*(oraz 1 innych odgałęzień)* |
| `[165]` | **""Yes, our houses were aligned for over a hundred years. Your service to the kingdo..."** | `[115]` **Lucita Azaro**: ""No, Father. His Majesty must be..."<br>`[117]` **Taddeus Azaro**: ""No, Carlos... I believe His Maj..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[120]` **Player_Romus**: ""Recent actions suggest House Az..."<br>`[119]` **Player_Romus**: ""Your family has begun to test t..."<br>*(oraz 1 innych odgałęzień)* |
| `[184]` | **""Thilence, Hubertuth.""** | `[180]` **Hubertus Toras**: ""His Majesty doesn't owe you an ..."<br>`[262]` **Hubertus Toras**: ""Traitors like you don't deserve..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[185]` **Hugo Toras**: ""Your Majesty. That was uncalled..." |
| `[186]` | **""Your blood ties to the King don't make you immune from justice.""** | `[185]` **Hugo Toras**: ""Your Majesty. That was uncalled..."<br>`[188]` **Hugo Toras**: ""Pardon me, Your Majesty?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Rico Toras**: ""You can't talk to my father lik..."<br>`[206]` **Hugo Toras**: ""For God's sake, Romus, please b..." |
| `[187]` | **""Look at you. Speaking up to defend me while preparing to drive a knife through my..."** | `[180]` **Hubertus Toras**: ""His Majesty doesn't owe you an ..."<br>`[262]` **Hubertus Toras**: ""Traitors like you don't deserve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Hugo Toras**: ""Pardon me, Your Majesty?"" |
| `[189]` | **""House Toras shall not escape my judgement either, Hubertus.""** | `[180]` **Hubertus Toras**: ""His Majesty doesn't owe you an ..."<br>`[262]` **Hubertus Toras**: ""Traitors like you don't deserve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Hugo Toras**: ""What judgement, Your Majesty?"" |
| `[190]` | **""You can't fool me, Hugo. I know you've always wanted my throne for yourself.""** | `[185]` **Hugo Toras**: ""Your Majesty. That was uncalled..."<br>`[188]` **Hugo Toras**: ""Pardon me, Your Majesty?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Rico Toras**: ""You can't talk to my father lik..."<br>`[206]` **Hugo Toras**: ""For God's sake, Romus, please b..." |
| `[199]` | **""My explanation is this. The time has come for Montaklar to submit to the Crown. J..."** | `[180]` **Hubertus Toras**: ""His Majesty doesn't owe you an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Hugo Toras**: ""Valenqiris, Your Majesty? I mus..." |
| `[201]` | **""I know you're my uncle. But honestly, I never could stand you.""** | `[185]` **Hugo Toras**: ""Your Majesty. That was uncalled..."<br>`[188]` **Hugo Toras**: ""Pardon me, Your Majesty?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Rico Toras**: ""You can't talk to my father lik..."<br>`[206]` **Hugo Toras**: ""For God's sake, Romus, please b..." |
| `[207]` | **""We learned the wrong lessons from the War of Succession. Noble houses only lead t..."** | `[185]` **Hugo Toras**: ""Your Majesty. That was uncalled..."<br>`[188]` **Hugo Toras**: ""Pardon me, Your Majesty?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Rico Toras**: ""You can't talk to my father lik..."<br>`[206]` **Hugo Toras**: ""For God's sake, Romus, please b..." |
| `[208]` | **""After today, you will know your place for good.""** | `[198]` **Leona Sazon**: ""It is your right to mete out ju..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Angelica Sazon**: ""Do not judge us on the basis of..."<br>`[218]` **Leona Sazon**: ""I swear we're innocent!"" |
| `[224]` | **""NOW!""** | `[14]` **Narrator**: "My words lingered heavily in the..."<br>`[223]` **Narrator**: "By this point, everyone in the r..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[225]` | **""No more excuses. Every one of you will pay!""** | `[223]` **Narrator**: "By this point, everyone in the r..."<br>`[140]` **Player_Romus**: ""It should be here any minute...""<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[226]` | **""Titus! It's time!""** | `[14]` **Narrator**: "My words lingered heavily in the..."<br>`[223]` **Narrator**: "By this point, everyone in the r..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[227]` | **""I ask for your full cooperation. Starting right... this... second.""** | `[14]` **Narrator**: "My words lingered heavily in the..."<br>`[223]` **Narrator**: "By this point, everyone in the r..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[236]` | **""Lies. Nothing but lies.""** | `[234]` **Leona Sazon**: ""And barring the actions of cert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." |
| `[237]` | **""All these years, and House Sazon still doesn't know its place.""** | `[234]` **Leona Sazon**: ""And barring the actions of cert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." |
| `[238]` | **""Ariana Toras should have executed your ancestors. As the 1926 Uprising proved.""** | `[234]` **Leona Sazon**: ""And barring the actions of cert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." |
| `[239]` | **""I am afraid that I, King Romus, am significantly less merciful than Queen Ariana ..."** | `[234]` **Leona Sazon**: ""And barring the actions of cert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." |
| `[240]` | **""We all witnessed how your golden boy Manus tried to weasel his way into my daught..."** | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." | `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | *Brak zmian stanu* | `[256]` **Leona Sazon**: ""Please, Your Majesty. There mus..." |
| `[245]` | **""Your golden boy Manus may have weaseled his way into my daughter's heart, but not..."** | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[258]` **Manus Sazon**: ""Vina will find out about this, ..." |
| `[246]` | **""All this time, you've been waiting patiently for the right moment to rise up agai..."** | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Leona Sazon**: ""Please, Your Majesty. There mus..." |
| `[247]` | **""You have the intelligence to know your place. But as for Angelica... I'm not so s..."** | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true` | *Brak zmian stanu* | `[257]` **Angelica Sazon**: ""You pardoned me, and now you do..." |
| `[251]` | **""Did you or did you not try to stoke the fires of revolution in Rizia? Answer me!""** | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." | `Variable["RiziaDLC.Reform_Movement_Grows"] == true` | *Brak zmian stanu* | `[256]` **Leona Sazon**: ""Please, Your Majesty. There mus..." |
| `[255]` | **""I don't have to justify myself to you or anyone else.""** | `[241]` **Leona Sazon**: ""I don't know what it is you thi..." | `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false` | *Brak zmian stanu* | `[256]` **Leona Sazon**: ""Please, Your Majesty. There mus..." |
| `[263]` | **""My explanation is this. The time has come for Brenas to submit to the Crown. Just..."** | `[262]` **Hubertus Toras**: ""Traitors like you don't deserve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Hugo Toras**: ""Valenqiris, Your Majesty? I mus..." |
| `[269]` | **""Thilence, Hubertuth.""** | `[265]` **Hubertus Toras**: ""Now, now. I'm sure His Majesty ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[270]` **Hugo Toras**: ""Your Majesty. That was uncalled..." |
| `[271]` | **""Your blood ties to the King don't make you immune from justice.""** | `[270]` **Hugo Toras**: ""Your Majesty. That was uncalled..."<br>`[273]` **Hugo Toras**: ""Pardon me, Your Majesty?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Rico Toras**: ""You can't talk to my father lik..."<br>`[282]` **Hugo Toras**: ""For God's sake, Romus, please b..." |
| `[272]` | **""Look at you. Speaking up to defend me while preparing to drive a knife through my..."** | `[265]` **Hubertus Toras**: ""Now, now. I'm sure His Majesty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Hugo Toras**: ""Pardon me, Your Majesty?"" |
| `[274]` | **""I don't owe an explanation to you or anyone else. It is time for you to face judg..."** | `[265]` **Hubertus Toras**: ""Now, now. I'm sure His Majesty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Hugo Toras**: ""What judgement, Your Majesty?"" |
| `[275]` | **""You can't fool me, Hugo. I know you've always wanted my throne for yourself.""** | `[270]` **Hugo Toras**: ""Your Majesty. That was uncalled..."<br>`[273]` **Hugo Toras**: ""Pardon me, Your Majesty?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Rico Toras**: ""You can't talk to my father lik..."<br>`[282]` **Hugo Toras**: ""For God's sake, Romus, please b..." |
| `[277]` | **""I know you're my uncle. But honestly, I never could stand you.""** | `[270]` **Hugo Toras**: ""Your Majesty. That was uncalled..."<br>`[273]` **Hugo Toras**: ""Pardon me, Your Majesty?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Rico Toras**: ""You can't talk to my father lik..."<br>`[282]` **Hugo Toras**: ""For God's sake, Romus, please b..." |
| `[283]` | **""We learned the wrong lessons from the War of Succession. Noble houses only lead t..."** | `[270]` **Hugo Toras**: ""Your Majesty. That was uncalled..."<br>`[273]` **Hugo Toras**: ""Pardon me, Your Majesty?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Rico Toras**: ""You can't talk to my father lik..."<br>`[282]` **Hugo Toras**: ""For God's sake, Romus, please b..." |
| `[284]` | **""My explanation is this. The time has come for Valenqiris to submit to the Crown.""** | `[265]` **Hubertus Toras**: ""Now, now. I'm sure His Majesty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Hugo Toras**: ""Valenqiris, Your Majesty? I mus..." |

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
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == fal..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == f..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Hugo’s eyes flicked toward him suspiciously."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Nobody else in the room seemed to notice."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `JUMP_BeforeAttack_MORETHANONE`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""Looking back, what would you say was the most lasting re..."*)
  - -> `[54]` (*Player_Romus: ""Not including the Uprising of 1926, what would you say w..."*)
  - -> `[87]` (*Player_Romus: ""It was not so long ago in Rizian history that the three ..."*)
  - -> `[10]` (*Player_Romus: ""The time for conversation is over... NOW." [Signal for a..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Taddeus’ eyes flicked toward him suspiciously."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""The time for conversation is over... NOW." [Signal for attack]"]** — Mówca: **Player_Romus**
> ""The time for conversation is over... NOW.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator), `[98]` (Narrator), `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ITS_A_TRAP_hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Your ancestor Fedo didn't know his place when he tried to seize the crown without a proper claim to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Treachery runs in your veins, etched into the soil of the lands you own. To ignore that would only invite its return.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Manus Sazon), `[212]` (Angelica Sazon), `[218]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == fal..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "My words lingered heavily in the air. Leona's mouth opened as if to protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""NOW!""*)
  - -> `[226]` (*Player_Romus: ""Titus! It's time!""*)
  - -> `[227]` (*Player_Romus: ""I ask for your full cooperation. Starting right... this...."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Sazon... You're even worse. I should have had you all killed after the Uprising of 1926.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Time is a cruel teacher, and it seems the lesson hasn't quite been learned. If I don't act to stop it, this endless cycle of betrayal will swallow this nation whole.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Manus Sazon), `[212]` (Angelica Sazon), `[218]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == fal..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you haven’t yet caught on to what I’m implying, I have other ways of spelling it out for you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Manus Sazon), `[212]` (Angelica Sazon), `[218]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == fal..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disloyalty runs in your blood, and it shows itself whenever you push beyond the limits set by the monarchy.”"
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Manus Sazon), `[212]` (Angelica Sazon), `[218]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == fal..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_Coup_Warning == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""Time is a cruel teacher, and it seems the lesson hasn't ..."*)
  - -> `[13]` (*Player_Romus: ""Treachery runs in your veins, etched into the soil of th..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_Coup_Warning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""Disloyalty runs in your blood, and it shows itself whene..."*)
  - -> `[23]` (*Player_Romus: ""I believe you're innocent. Just as you must believe that..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Place? There is no place for your house in Rizia, Countess Leona.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe you're innocent. Just as you must believe that there is nothing personal in what I am about to do.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Manus Sazon), `[212]` (Angelica Sazon), `[218]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == fal..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Manus Sazon: ""The War of Rizian Succession. A battle between nobles th..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Leona Sazon: ""If I may, Your Majesty, the War of Rizian Succession is ..."*)

### Węzeł `[27]`
Mówca: **Leona Sazon**
> ""If I may, Your Majesty, the War of Rizian Succession is long in the past for the members of House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Hugo’s eyes flicked toward him suspiciously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "// SOLO TORAS CHAT"*)
  - -> `[10]` (*Player_Romus: ""The time for conversation is over... NOW." [Signal for a..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“To remind you that sometimes, in order to serve a greater good, we must turn against the ones we love.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Setting aside the Uprising of 1926, what would you consider the most turbulent period of unrest in the kingdom’s history?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust everyone here is familiar with the War of Rizian Succession.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> "“I will assume you're speaking rhetorically, Your Majesty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hubertus Toras: ""The war was one of the most violent chapters in our nati..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Correct. Ariana was forced into a bitter feud with her own blood relations, and she did what she had to do to survive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""Forgive me, Your Majesty, but why are you bringing this ..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Time for a little quiz. How did House Toras secure the throne all those years ago?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Hubertus Toras: ""Why, it was a direct result of the War of Rizian Success..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Ambition shattered familial bonds, leading to the deaths of many and a nation torn apart.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""Forgive me, Your Majesty, but why are you bringing this ..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, good to know someone’s paying attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""Forgive me, Your Majesty, but why are you bringing this ..."*)

### Węzeł `[37]`
Mówca: **Hubertus Toras**
> ""Why, it was a direct result of the War of Rizian Succession, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[38]`
Mówca: **Hubertus Toras**
> ""The war was one of the most violent chapters in our nation's history. Which nonetheless ended in triumph when Ariana Toras took her rightful place on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: "“Ambition shattered familial bonds, leading to the deaths..."*)
  - -> `[33]` (*Player_Romus: ""Correct. Ariana was forced into a bitter feud with her o..."*)
  - -> `[36]` (*Player_Romus: ""Ah, good to know someone’s paying attention.""*)

### Węzeł `[39]`
Mówca: **Hugo Toras**
> "'The War of Rizian Succession, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hubertus Toras: ""The war was one of the most violent chapters in our nati..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you haven't yet clued in to the message I'm trying to send, I have other ways of spelling it out for you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Funny how historical betrayal tends to repeat itself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Rico Toras: "“I've always found history boring.""*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: "“I will assume you're speaking rhetorically, Your Majesty.”"*)

### Węzeł `[45]`
Mówca: **Rico Toras**
> "“I've always found history boring. Just a bunch of old stories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Hugo Toras: "“Rico, please...”"*)

### Węzeł `[46]`
Mówca: **Hugo Toras**
> "“Rico, please...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""Sorry, Your Majesty. I am assuming you're referring to t..."*)

### Węzeł `[47]`
Mówca: **Rico Toras**
> "“I've always found history boring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Hugo Toras: "“Rico, please...”"*)

### Węzeł `[48]`
Mówca: **Hugo Toras**
> "“Rico, please...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: "“I will assume you're speaking rhetorically, Your Majesty.”"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Rico Toras: "“I've always found history boring. Just a bunch of old st..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Hugo Toras: "'The War of Rizian Succession, of course.""*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""Sorry, Your Majesty. I am assuming you're referring to the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hubertus Toras: ""The war was one of the most violent chapters in our nati..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looking back, what would you say was the most lasting result of the War of Rizian Succession?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator), `[102]` (Narrator), `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not including the Uprising of 1926, what would you say was the most turbulent period of unrest in the kingdom's history?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator), `[102]` (Narrator), `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Taddeus Azaro: ""Are you trying to test us, Your Majesty? Obviously, it w..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[58]`
Mówca: **Taddeus Azaro**
> ""Are you trying to test us, Your Majesty? Obviously, it was the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[59]`
Mówca: **Angelica Sazon**
> ""You must be referring to the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Leona Sazon: ""Without question.""*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Angelica Sazon: ""You must be referring to the War of Rizian Succession.""*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[63]`
Mówca: **Leona Sazon**
> ""Without question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Manus Sazon: ""The 'most turbulent period of unrest?' I'd have to say t..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Leona Sazon: ""Are you referring to the War of Rizian Succession, Your ..."*)

### Węzeł `[67]`
Mówca: **Manus Sazon**
> ""The 'most turbulent period of unrest?' I'd have to say the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Leona Sazon: ""Absolutely. Without question.""*)

### Węzeł `[68]`
Mówca: **Leona Sazon**
> ""Are you referring to the War of Rizian Succession, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Leona Sazon: ""It was a brutal struggle. One that sealed House Sazon's ..."*)

### Węzeł `[69]`
Mówca: **Leona Sazon**
> ""It was a brutal struggle. One that sealed House Sazon's fate as the weakest house in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[70]`
Mówca: **Leona Sazon**
> ""Absolutely. Without question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Taddeus Azaro: ""Besides the destruction of Fortress Montaklar?""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[74]`
Mówca: **Taddeus Azaro**
> ""Besides the destruction of Fortress Montaklar?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[75]`
Mówca: **Angelica Sazon**
> ""The War of Rizian Succession, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Angelica Sazon: ""I cannot speak for anyone else here. But I will say that..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Angelica Sazon: ""The War of Rizian Succession, Your Majesty?""*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Manus Sazon: ""The War of Rizian Succession? Well, I’d have to say, as ..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Leona Sazon: ""The War of Succession, Your Majesty?""*)

### Węzeł `[82]`
Mówca: **Manus Sazon**
> ""The War of Rizian Succession? Well, I’d have to say, as odd as it may sound, it had a lasting impact on the arts and sciences--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Leona Sazon: ""I don't think that's what His Majesty means.""*)

### Węzeł `[83]`
Mówca: **Angelica Sazon**
> ""I cannot speak for anyone else here. But I will say that it severely weakened House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[84]`
Mówca: **Leona Sazon**
> ""I don't think that's what His Majesty means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[85]`
Mówca: **Leona Sazon**
> ""My ancestor Fedo arrogantly tried to assert his claim to the throne. When Ariana Toras took the crown, she showed him great mercy by allowing our house to retain power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[86]`
Mówca: **Taddeus Azaro**
> ""During the War of Rizian Succession, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was not so long ago in Rizian history that the three noble houses were at bitter, bloody odds with one another.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator), `[102]` (Narrator), `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Taddeus Azaro: ""During the War of Rizian Succession, you mean.""*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Angelica Sazon: ""Yes. How I wish House Sazon had learned its lesson after..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[94]`
Mówca: **Angelica Sazon**
> ""Yes. How I wish House Sazon had learned its lesson after that bloody conflagration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Leona Sazon: ""We did in the end, Angelica.""*)

### Węzeł `[95]`
Mówca: **Leona Sazon**
> ""We did in the end, Angelica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[96]`
Mówca: **Manus Sazon**
> ""The War of Rizian Succession. A battle between nobles that destroyed many commoners' lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""Forgive me, Your Majesty, but why are you bringing this up now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""If you haven't yet clued in to the message I'm trying to..."*)
  - -> `[29]` (*Player_Romus: "“To remind you that sometimes, in order to serve a greate..."*)
  - -> `[41]` (*Player_Romus: ""Funny how historical betrayal tends to repeat itself.""*)
  - -> `[110]` (*Player_Romus: ""The Toras dynasty lasted more than a century, and it wil..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Taddeus’ eyes flicked toward him suspiciously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "JUMP_BeforeAttack_MORETHANONE"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Leona's eyes flicked towards him nervously."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == fal..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Leona's eyes flicked towards him nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "JUMP_BeforeAttack_MORETHANONE"*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Nobody else in the room seemed to notice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "JUMP_BeforeAttack_MORETHANONE"*)

### Węzeł `[104]`
Mówca: **Rico Toras**
> ""Oh, God... don't tell me you brought us in here for a history lesson.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: "“Rico, please...”"*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> "“Rico, please...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Hubertus ran a hand through his hair."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Rico Toras: ""Oh, God... don't tell me you brought us in here for a hi..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Hubertus ran a hand through his hair."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Hubertus ran a hand through his hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hubertus Toras: ""The war was one of the most violent chapters in our nati..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Toras dynasty lasted more than a century, and it will last for hundreds of years more. But you shall not be a part of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[111]`
Mówca: **Leona Sazon**
> ""The War of Succession, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Leona Sazon: ""It resulted in an established order among the Royal Hous..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucita Azaro: ""No, Father. His Majesty must be talking about the bonds ..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Carlos Robles Azaro: ""It was the first war of the modern era. Tactics and tech..."*)

### Węzeł `[115]`
Mówca: **Lucita Azaro**
> ""No, Father. His Majesty must be talking about the bonds that were forged between House Toras and House Azaro. An alliance that has continued to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[116]`
Mówca: **Carlos Robles Azaro**
> ""It was the first war of the modern era. Tactics and techniques were developed that are still being used by our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Taddeus Azaro: ""No, Carlos... I believe His Majesty is talking about the..."*)

### Węzeł `[117]`
Mówca: **Taddeus Azaro**
> ""No, Carlos... I believe His Majesty is talking about the bonds that were forged between House Toras and House Azaro. An alliance that has continued to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just as Ana Azaro had to be defeated for the good of the kingdom, so her ancestors must face the Crown's justice today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Player_Romus), `[163]` (Player_Romus), `[164]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your family has begun to test the boundaries of loyalty through surreptitious maneuvering.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Player_Romus), `[163]` (Player_Romus), `[164]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Recent actions suggest House Azaro is growing dangerously independent from the Crown -- challenging the established order.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Player_Romus), `[163]` (Player_Romus), `[164]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""'Dangerously independent?' You can't be serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Carlos Robles Azaro: ""This is preposterous. I demand an explanation.""*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Taddeus Azaro: ""This is preposterous. I demand an explanation.""*)

### Węzeł `[125]`
Mówca: **Carlos Robles Azaro**
> ""This is preposterous. I demand an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[126]`
Mówca: **Taddeus Azaro**
> ""This is preposterous. I demand an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == false"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == false)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Taddeus Azaro: ""With all due respect, if you intend to continue making s..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Carlos Robles Azaro: ""Your Majesty, if you intend to persist with these accusa..."*)

### Węzeł `[133]`
Mówca: **Taddeus Azaro**
> ""With all due respect, if you intend to continue making such brazen accusations, I must insist you provide evidence to support your claims.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""Evidence? As King, my authority requires no justificatio..."*)
  - -> `[140]` (*Player_Romus: ""It should be here any minute...""*)
  - -> `[147]` (*Player_Romus: ""I AM the evidence. My word alone shapes the truth in thi..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""Where is this coming from, Romus? What evidence do you think you have against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""Evidence? As King, my authority requires no justificatio..."*)
  - -> `[140]` (*Player_Romus: ""It should be here any minute...""*)
  - -> `[147]` (*Player_Romus: ""I AM the evidence. My word alone shapes the truth in thi..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucita Azaro: ""Where is this coming from, Romus? What evidence do you t..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucita Azaro: ""Respectfully, if you intend to keep making these accusat..."*)

### Węzeł `[138]`
Mówca: **Lucita Azaro**
> ""Respectfully, if you intend to keep making these accusations, I must insist on you providing evidence to back them up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""Evidence? As King, my authority requires no justificatio..."*)
  - -> `[140]` (*Player_Romus: ""It should be here any minute...""*)
  - -> `[147]` (*Player_Romus: ""I AM the evidence. My word alone shapes the truth in thi..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[139]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty, if you intend to persist with these accusations, then I must insist that you back them up with evidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""Evidence? As King, my authority requires no justificatio..."*)
  - -> `[140]` (*Player_Romus: ""It should be here any minute...""*)
  - -> `[147]` (*Player_Romus: ""I AM the evidence. My word alone shapes the truth in thi..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It should be here any minute...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Taddeus Azaro), `[134]` (Lucita Azaro), `[138]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Evidence? As King, my authority requires no justification -- only decisive action.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Taddeus Azaro), `[134]` (Lucita Azaro), `[138]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop playing dumb. I know every detail of your plan.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Kontekst wejściowy (poprzednik):** `[133]` (Taddeus Azaro), `[134]` (Lucita Azaro), `[138]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Divine will does not require proof -- it demands obedience.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[133]` (Taddeus Azaro), `[134]` (Lucita Azaro), `[138]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: ""Divine will does not require proof -- it demands obedien..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I AM the evidence. My word alone shapes the truth in this realm. Everyone here would do well to remember that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Taddeus Azaro), `[134]` (Lucita Azaro), `[138]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""'Surreptitious maneuvering?' You're joking, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucita Azaro: ""'Dangerously independent?' You can't be serious.""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Taddeus Azaro: ""'Dangerously independent?'""*)

### Węzeł `[152]`
Mówca: **Taddeus Azaro**
> ""'Dangerously independent?'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucita Azaro: ""'Surreptitious maneuvering?' You're joking, right?""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Taddeus Azaro: ""'Surreptitious maneuvering?""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucita Azaro: ""'Justice? What is it that you think we've done?""*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Taddeus Azaro: ""Justice? What is it that you think House Azaro has done?""*)

### Węzeł `[159]`
Mówca: **Taddeus Azaro**
> ""Justice? What is it that you think House Azaro has done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[160]`
Mówca: **Taddeus Azaro**
> ""'Surreptitious maneuvering?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""'Justice? What is it that you think we've done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was my ancestor Ariana who forced the Azaros into an alliance. By beating them into submission.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Lucita Azaro), `[117]` (Taddeus Azaro), `[173]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To this day... and not a moment longer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Lucita Azaro), `[117]` (Taddeus Azaro), `[173]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're conveniently forgetting what happened before that. The treachery of your ancestress, Ana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Lucita Azaro), `[117]` (Taddeus Azaro), `[173]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, our houses were aligned for over a hundred years. Your service to the kingdom has been invaluable. And yet...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Lucita Azaro), `[117]` (Taddeus Azaro), `[173]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""Recent actions suggest House Azaro is growing dangerousl..."*)
  - -> `[119]` (*Player_Romus: ""Your family has begun to test the boundaries of loyalty ..."*)
  - -> `[118]` (*Player_Romus: ""Just as Ana Azaro had to be defeated for the good of the..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_WarnedAboutCoup == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""Stop playing dumb. I know every detail of your plan.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_WarnedAboutCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucita Azaro: ""A brutal battle, but one that solidified the bond betwee..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Carlos Robles Azaro: ""A brutal battle. But one that redefined warfare as Merko..."*)

### Węzeł `[173]`
Mówca: **Lucita Azaro**
> ""A brutal battle, but one that solidified the bond between House Azaro and House Toras. An alliance that continues to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[174]`
Mówca: **Carlos Robles Azaro**
> ""A brutal battle. But one that redefined warfare as Merkopa knew it. Techniques were developed that are still in use now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Taddeus Azaro: ""And let us not forget the bonds that were forged between..."*)

### Węzeł `[175]`
Mówca: **Taddeus Azaro**
> ""And let us not forget the bonds that were forged between House Toras and House Azaro at the war's end. An alliance that has continued to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""It was my ancestor Ariana who forced the Azaros into an ..."*)
  - -> `[164]` (*Player_Romus: ""You're conveniently forgetting what happened before that..."*)
  - -> `[165]` (*Player_Romus: ""Yes, our houses were aligned for over a hundred years. Y..."*)
  - -> `[163]` (*Player_Romus: ""To this day... and not a moment longer.""*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Hubertus Toras: ""His Majesty doesn't owe you an explanation.""*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false"*)

### Węzeł `[180]`
Mówca: **Hubertus Toras**
> ""His Majesty doesn't owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_Funny..."*)
  - -> `[187]` (*Player_Romus: ""Look at you. Speaking up to defend me while preparing to..."*)
  - -> `[189]` (*Player_Romus: ""House Toras shall not escape my judgement either, Hubert..."*)
  - -> `[199]` (*Player_Romus: ""My explanation is this. The time has come for Montaklar ..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_Funny..."*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_Fun..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""Thilence, Hubertuth.""*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thilence, Hubertuth.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[180]` (Hubertus Toras), `[262]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Hugo Toras: ""Your Majesty. That was uncalled for.""*)

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""Your Majesty. That was uncalled for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""Your blood ties to the King don't make you immune from j..."*)
  - -> `[190]` (*Player_Romus: ""You can't fool me, Hugo. I know you've always wanted my ..."*)
  - -> `[201]` (*Player_Romus: ""I know you're my uncle. But honestly, I never could stan..."*)
  - -> `[207]` (*Player_Romus: ""We learned the wrong lessons from the War of Succession...."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your blood ties to the King don't make you immune from justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Hugo Toras), `[188]` (Hugo Toras), `[191]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at you. Speaking up to defend me while preparing to drive a knife through my back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Hubertus Toras), `[262]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Hugo Toras: ""Pardon me, Your Majesty?""*)

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""Pardon me, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""Your blood ties to the King don't make you immune from j..."*)
  - -> `[190]` (*Player_Romus: ""You can't fool me, Hugo. I know you've always wanted my ..."*)
  - -> `[201]` (*Player_Romus: ""I know you're my uncle. But honestly, I never could stan..."*)
  - -> `[207]` (*Player_Romus: ""We learned the wrong lessons from the War of Succession...."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras shall not escape my judgement either, Hubertus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Hubertus Toras), `[262]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Hugo Toras: ""What judgement, Your Majesty?""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't fool me, Hugo. I know you've always wanted my throne for yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Hugo Toras), `[188]` (Hugo Toras), `[191]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[191]`
Mówca: **Hugo Toras**
> ""What judgement, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""Your blood ties to the King don't make you immune from j..."*)
  - -> `[190]` (*Player_Romus: ""You can't fool me, Hugo. I know you've always wanted my ..."*)
  - -> `[201]` (*Player_Romus: ""I know you're my uncle. But honestly, I never could stan..."*)
  - -> `[207]` (*Player_Romus: ""We learned the wrong lessons from the War of Succession...."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Leona Sazon: ""It is your right to mete out justice, Your Majesty. But ..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == f..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == false"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Leona Sazon: ""It is your right to mete out justice, Your Majesty. But ..."*)

### Węzeł `[198]`
Mówca: **Leona Sazon**
> ""It is your right to mete out justice, Your Majesty. But please believe that House Sazon knows its place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""House Sazon... You're even worse. I should have had you ..."*)
  - -> `[12]` (*Player_Romus: "“Your ancestor Fedo didn't know his place when he tried t..."*)
  - -> `[22]` (*Player_Romus: ""Place? There is no place for your house in Rizia, Counte..."*)
  - -> `[208]` (*Player_Romus: ""After today, you will know your place for good.""*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My explanation is this. The time has come for Montaklar to submit to the Crown. Just as it has come for Valenqiris.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Hugo Toras: ""Valenqiris, Your Majesty? I must have misheard you...""*)

### Węzeł `[200]`
Mówca: **Hugo Toras**
> ""Valenqiris, Your Majesty? I must have misheard you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""Your blood ties to the King don't make you immune from j..."*)
  - -> `[190]` (*Player_Romus: ""You can't fool me, Hugo. I know you've always wanted my ..."*)
  - -> `[201]` (*Player_Romus: ""I know you're my uncle. But honestly, I never could stan..."*)
  - -> `[207]` (*Player_Romus: ""We learned the wrong lessons from the War of Succession...."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know you're my uncle. But honestly, I never could stand you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Hugo Toras), `[188]` (Hugo Toras), `[191]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Rico Toras: ""You can't talk to my father like that!""*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Hugo Toras: ""For God's sake, Romus, please be reasonable!""*)

### Węzeł `[205]`
Mówca: **Rico Toras**
> ""You can't talk to my father like that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[206]`
Mówca: **Hugo Toras**
> ""For God's sake, Romus, please be reasonable!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We learned the wrong lessons from the War of Succession. Noble houses only lead to strife. The monarch must reign over all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Hugo Toras), `[188]` (Hugo Toras), `[191]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After today, you will know your place for good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Angelica Sazon: ""Do not judge us on the basis of Lucas or Fedo's actions...."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Leona Sazon: ""I swear we're innocent!""*)

### Węzeł `[212]`
Mówca: **Angelica Sazon**
> ""Do not judge us on the basis of Lucas or Fedo's actions. I promise we are innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[213]`
Mówca: **Narrator**
> "Manus shook his head slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Manus Sazon: ""It's no use. This was the King's plan all along.""*)

### Węzeł `[214]`
Mówca: **Manus Sazon**
> ""It's no use. This was the King's plan all along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Manus shook his head slowly."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[218]`
Mówca: **Leona Sazon**
> ""I swear we're innocent!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""If you haven’t yet caught on to what I’m implying, I hav..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == fal..."*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == f..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "My words lingered heavily in the air. Leona's mouth opene..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "By this point, everyone in the room was staring at me in ..."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "By this point, everyone in the room was staring at me in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""NOW!""*)
  - -> `[225]` (*Player_Romus: ""No more excuses. Every one of you will pay!""*)
  - -> `[226]` (*Player_Romus: ""Titus! It's time!""*)
  - -> `[227]` (*Player_Romus: ""I ask for your full cooperation. Starting right... this...."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""NOW!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[223]` (Narrator), `[140]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No more excuses. Every one of you will pay!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator), `[140]` (Player_Romus), `[141]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! It's time!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[223]` (Narrator), `[140]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I ask for your full cooperation. Starting right... this... second.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[223]` (Narrator), `[140]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""NOW!""*)
  - -> `[225]` (*Player_Romus: ""No more excuses. Every one of you will pay!""*)
  - -> `[226]` (*Player_Romus: ""Titus! It's time!""*)
  - -> `[227]` (*Player_Romus: ""I ask for your full cooperation. Starting right... this...."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "She looked at Angelica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Leona Sazon: ""And barring the actions of certain individuals -- acting..."*)

### Węzeł `[230]`
Mówca: **Leona Sazon**
> ""It resulted in an established order among the Royal Houses. One that continues to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Leona Sazon: ""My ancestor Fedo arrogantly tried to assert his claim to..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "She looked at Angelica."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "She grimaced."*)

### Węzeł `[234]`
Mówca: **Leona Sazon**
> ""And barring the actions of certain individuals -- acting without the rest of the House's knowledge, mind you -- we have been repaying that mercy every day since.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player_Romus: ""Lies. Nothing but lies.""*)
  - -> `[237]` (*Player_Romus: ""All these years, and House Sazon still doesn't know its ..."*)
  - -> `[238]` (*Player_Romus: ""Ariana Toras should have executed your ancestors. As the..."*)
  - -> `[239]` (*Player_Romus: ""I am afraid that I, King Romus, am significantly less me..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "She grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Leona Sazon: ""And barring the actions of certain individuals -- acting..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lies. Nothing but lies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Leona Sazon: ""I don't know what it is you think we did, Your Majesty, ..."*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All these years, and House Sazon still doesn't know its place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Leona Sazon: ""I don't know what it is you think we did, Your Majesty, ..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ariana Toras should have executed your ancestors. As the 1926 Uprising proved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Leona Sazon: ""I don't know what it is you think we did, Your Majesty, ..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am afraid that I, King Romus, am significantly less merciful than Queen Ariana was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Leona Sazon: ""I don't know what it is you think we did, Your Majesty, ..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We all witnessed how your golden boy Manus tried to weasel his way into my daughter's heart.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[241]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Leona Sazon: ""Please, Your Majesty. There must still be a way to settl..."*)

### Węzeł `[241]`
Mówca: **Leona Sazon**
> ""I don't know what it is you think we did, Your Majesty, but you're wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[246]` (*Player_Romus: ""All this time, you've been waiting patiently for the rig..."*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""Your golden boy Manus may have weaseled his way into my ..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""We all witnessed how your golden boy Manus tried to weas..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your golden boy Manus may have weaseled his way into my daughter's heart, but not mine.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[241]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Manus Sazon: ""Vina will find out about this, Your Majesty. She'll neve..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All this time, you've been waiting patiently for the right moment to rise up again. Not on my watch.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Leona Sazon: ""Please, Your Majesty. There must still be a way to settl..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have the intelligence to know your place. But as for Angelica... I'm not so sure.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Kontekst wejściowy (poprzednik):** `[241]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Angelica Sazon: ""You pardoned me, and now you don't trust me?""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""You have the intelligence to know your place. But as for..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you or did you not try to stoke the fires of revolution in Rizia? Answer me!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Kontekst wejściowy (poprzednik):** `[241]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Leona Sazon: ""Please, Your Majesty. There must still be a way to settl..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""Did you or did you not try to stoke the fires of revolut..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: ""I don't have to justify myself to you or anyone else.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have to justify myself to you or anyone else.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[241]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Leona Sazon: ""Please, Your Majesty. There must still be a way to settl..."*)

### Węzeł `[256]`
Mówca: **Leona Sazon**
> ""Please, Your Majesty. There must still be a way to settle this peacefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[257]`
Mówca: **Angelica Sazon**
> ""You pardoned me, and now you don't trust me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Leona Sazon: ""Please, Your Majesty. There must still be a way to settl..."*)

### Węzeł `[258]`
Mówca: **Manus Sazon**
> ""Vina will find out about this, Your Majesty. She'll never stand for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Leona Sazon: ""Please, Your Majesty. There must still be a way to settl..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Hubertus Toras: ""Traitors like you don't deserve peace, Countess. You've ..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[262]`
Mówca: **Hubertus Toras**
> ""Traitors like you don't deserve peace, Countess. You've earned whatever punishment His Majesty has in store.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_Funny..."*)
  - -> `[187]` (*Player_Romus: ""Look at you. Speaking up to defend me while preparing to..."*)
  - -> `[189]` (*Player_Romus: ""House Toras shall not escape my judgement either, Hubert..."*)
  - -> `[263]` (*Player_Romus: ""My explanation is this. The time has come for Brenas to ..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My explanation is this. The time has come for Brenas to submit to the Crown. Just as it has come for Valenqiris.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Hugo Toras: ""Valenqiris, Your Majesty? I must have misheard you...""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// SOLO TORAS CHAT`
- **Efekt skryptowy (`userScript`):** `-- SOLO TORAS CHAT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""Setting aside the Uprising of 1926, what would you consi..."*)
  - -> `[31]` (*Player_Romus: ""I trust everyone here is familiar with the War of Rizian..."*)
  - -> `[34]` (*Player_Romus: ""Time for a little quiz. How did House Toras secure the t..."*)

### Węzeł `[265]`
Mówca: **Hubertus Toras**
> ""Now, now. I'm sure His Majesty has an explanation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_Funny..."*)
  - -> `[272]` (*Player_Romus: ""Look at you. Speaking up to defend me while preparing to..."*)
  - -> `[274]` (*Player_Romus: ""I don't owe an explanation to you or anyone else. It is ..."*)
  - -> `[284]` (*Player_Romus: ""My explanation is this. The time has come for Valenqiris..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_Funny..."*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_Fun..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""Thilence, Hubertuth.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thilence, Hubertuth.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[265]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Hugo Toras: ""Your Majesty. That was uncalled for.""*)

### Węzeł `[270]`
Mówca: **Hugo Toras**
> ""Your Majesty. That was uncalled for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Your blood ties to the King don't make you immune from j..."*)
  - -> `[275]` (*Player_Romus: ""You can't fool me, Hugo. I know you've always wanted my ..."*)
  - -> `[277]` (*Player_Romus: ""I know you're my uncle. But honestly, I never could stan..."*)
  - -> `[283]` (*Player_Romus: ""We learned the wrong lessons from the War of Succession...."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your blood ties to the King don't make you immune from justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Hugo Toras), `[273]` (Hugo Toras), `[276]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at you. Speaking up to defend me while preparing to drive a knife through my back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Hugo Toras: ""Pardon me, Your Majesty?""*)

### Węzeł `[273]`
Mówca: **Hugo Toras**
> ""Pardon me, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Your blood ties to the King don't make you immune from j..."*)
  - -> `[275]` (*Player_Romus: ""You can't fool me, Hugo. I know you've always wanted my ..."*)
  - -> `[277]` (*Player_Romus: ""I know you're my uncle. But honestly, I never could stan..."*)
  - -> `[283]` (*Player_Romus: ""We learned the wrong lessons from the War of Succession...."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't owe an explanation to you or anyone else. It is time for you to face judgement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Hugo Toras: ""What judgement, Your Majesty?""*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't fool me, Hugo. I know you've always wanted my throne for yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Hugo Toras), `[273]` (Hugo Toras), `[276]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[276]`
Mówca: **Hugo Toras**
> ""What judgement, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Your blood ties to the King don't make you immune from j..."*)
  - -> `[275]` (*Player_Romus: ""You can't fool me, Hugo. I know you've always wanted my ..."*)
  - -> `[277]` (*Player_Romus: ""I know you're my uncle. But honestly, I never could stan..."*)
  - -> `[283]` (*Player_Romus: ""We learned the wrong lessons from the War of Succession...."*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know you're my uncle. But honestly, I never could stand you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Hugo Toras), `[273]` (Hugo Toras), `[276]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Rico Toras: ""You can't talk to my father like that!""*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Hugo Toras: ""For God's sake, Romus, please be reasonable!""*)

### Węzeł `[281]`
Mówca: **Rico Toras**
> ""You can't talk to my father like that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[282]`
Mówca: **Hugo Toras**
> ""For God's sake, Romus, please be reasonable!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We learned the wrong lessons from the War of Succession. Noble houses only lead to strife. The monarch must reign over all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Hugo Toras), `[273]` (Hugo Toras), `[276]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My explanation is this. The time has come for Valenqiris to submit to the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Hugo Toras: ""Valenqiris, Your Majesty? I must have misheard you...""*)

### Węzeł `[285]`
Mówca: **Hugo Toras**
> ""Valenqiris, Your Majesty? I must have misheard you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Your blood ties to the King don't make you immune from j..."*)
  - -> `[275]` (*Player_Romus: ""You can't fool me, Hugo. I know you've always wanted my ..."*)
  - -> `[277]` (*Player_Romus: ""I know you're my uncle. But honestly, I never could stan..."*)
  - -> `[283]` (*Player_Romus: ""We learned the wrong lessons from the War of Succession...."*)

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""Interesting. I recall such ravings from the end of your father's life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Hubertus Toras: ""Now, now. I'm sure His Majesty has an explanation...""*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Rico Toras: ""If you're implying what I think you are, you'll never ge..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Hugo Toras: ""Interesting. I recall such ravings from the end of your ..."*)

### Węzeł `[290]`
Mówca: **Rico Toras**
> ""If you're implying what I think you are, you'll never get away with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Hubertus Toras: ""Now, now. I'm sure His Majesty has an explanation...""*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == false"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
