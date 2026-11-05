# Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/House Sazon Strike/House Sazon Strike Conversation

- **ID konwersacji:** `561`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/561_House_Sazon_Strike_Conversation.md`
- **Liczba węzłów dialogowych:** 411
- **Liczba wyborów gracza:** 70

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[85]** Sevrio Castellanus
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Angelica_Executed`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.Leona_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Turn09_Coup_Warning`
- `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan`
- `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Angelica_Arrested`
- `RiziaDLC.Angelica_Executed`
- `RiziaDLC.BirthdayGathering_ForcedSignature`
- `RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist`
- `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_ForcedSign`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Leona_ForcedSign`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[559] Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation** (../Turn_10/559_ABSOLUTIST_STRIKE_SCENE_Conversation.md), Węzeł `[478]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""Don’t flatter yourself, Leona. You’re only a threat if you refuse to cooperate.""** | `[18]` **Leona Sazon**: ""It's not our signatures you wan..."<br>`[127]` **Leona Sazon**: ""Do you even hear yourself? It’s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Leona Sazon**: ""And signing will make us your a..." |
| `[13]` | **""Think carefully, Leona. Is this how you want your house to be remembered?""** | `[18]` **Leona Sazon**: ""It's not our signatures you wan..."<br>`[127]` **Leona Sazon**: ""Do you even hear yourself? It’s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Leona Sazon**: ""What good is a legacy if it's b..." |
| `[14]` | **""I only need your compliance, not your loyalty.""** | `[29]` **Leona Sazon**: ""And signing will make us your a..."<br>`[30]` **Leona Sazon**: ""What good is a legacy if it's b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "Leona stared doubtfully at the p..." |
| `[15]` | **""Don’t make this harder than it needs to be.""** | `[29]` **Leona Sazon**: ""And signing will make us your a..."<br>`[30]` **Leona Sazon**: ""What good is a legacy if it's b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "Leona stared doubtfully at the p..." |
| `[16]` | **""Stubbornness won’t bring honor to your name. It’ll bring only ashes.""** | `[29]` **Leona Sazon**: ""And signing will make us your a..."<br>`[30]` **Leona Sazon**: ""What good is a legacy if it's b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "Leona stared doubtfully at the p..." |
| `[28]` | **""I admit nothing but the fact that you're stubbornly refusing to see what's best f..."** | `[18]` **Leona Sazon**: ""It's not our signatures you wan..."<br>`[127]` **Leona Sazon**: ""Do you even hear yourself? It’s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Leona Sazon**: ""You call it stubborn, but I cal..." |
| `[50]` | **""If your ‘autonomy’ was anything but treason, you wouldn't be here pleading your c..."** | `[25]` **Leona Sazon**: ""Not one that seeks to silence t..." | `Variable["RiziaDLC.Turn09_Coup_Warning"] == false` | *Brak zmian stanu* | `[53]` **Narrator**: "I held up the pen and motioned t..." |
| `[54]` | **""Spare me. I didn't call you here to debate civics. Just sign your name and get th..."** | `[24]` **Angelica Sazon**: ""Not one that seeks to silence t..."<br>`[25]` **Leona Sazon**: ""Not one that seeks to silence t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "Grasping the pen, I held it firm..." |
| `[55]` | **""I will not tolerate rebellion in the guise of noble ideals. Now do the right thing.""** | `[24]` **Angelica Sazon**: ""Not one that seeks to silence t..."<br>`[25]` **Leona Sazon**: ""Not one that seeks to silence t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "I held up the pen and motioned t..." |
| `[56]` | **""Your demands are irrelevant here. I’ll decide what’s best for this realm.""** | `[24]` **Angelica Sazon**: ""Not one that seeks to silence t..."<br>`[25]` **Leona Sazon**: ""Not one that seeks to silence t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "Grasping the pen, I held it firm..." |
| `[64]` | **""Now that I've gotten your attention... your signature please.""** | `[114]` **Narrator**: "Leona sat frozen, her mouth agap..."<br>`[302]` **Manus Sazon**: ""What have you done!?""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false`<br>`(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false` | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_S...`<br>`Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_S...`<br>*(+2 skryptów)* | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych odgałęzień)* |
| `[66]` | **""There. That wasn't so difficult, was it?""** | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSi...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[67]` **Leona Sazon**: "“Please, I beg you, spare me! I ..." |
| `[69]` | **""You and Manus shall be spared. How kind of you to plead for his life as well, by ..."** | `[67]` **Leona Sazon**: "“Please, I beg you, spare me! I ..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true` | *Brak zmian stanu* | `[402]` **Narrator**: "Tears streamed down her face." |
| `[70]` | **""If your House had just done what you were told from the start, we could have avoi..."** | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSi...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[67]` **Leona Sazon**: "“Please, I beg you, spare me! I ..." |
| `[71]` | **""Very well. But do so with some damn dignity. Groveling is beneath you.""** | `[67]` **Leona Sazon**: "“Please, I beg you, spare me! I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Leona Sazon**: ""Yes, Your Majesty. Thank you."" |
| `[72]` | **""Good. I knew you'd come to see reason.""** | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSi...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[67]` **Leona Sazon**: "“Please, I beg you, spare me! I ..." |
| `[82]` | **""Save your tears. We still have business to take care of.""** | `[114]` **Narrator**: "Leona sat frozen, her mouth agap..."<br>`[302]` **Manus Sazon**: ""What have you done!?""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true`<br>`Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false`<br>`(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false` | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_S...`<br>`Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_S...`<br>*(+2 skryptów)* | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych odgałęzień)* |
| `[83]` | **""You leave me no choice. Under the authority vested in me as king, I place you und..."** | `[79]` **Narrator**: "She threw the pen to the ground." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Narrator**: "Without a moment of hesitation, ..."<br>`[86]` **Narrator**: "Without a moment's hesitation, T..." |
| `[88]` | **""Justice *has* prevailed. Your fate was sealed the moment you crossed me.""** | `[87]` **Angelica Sazon**: ""You won't get away with this! M..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Angelica Sazon"); ;` | `[224]` **Hugo Toras**: ""A shame it had to come to this.""<br>`[225]` **Lucita Azaro**: ""It's a shame it had to come to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[89]` | **""Justice is precisely what’s being served. You simply don’t like the outcome.""** | `[87]` **Angelica Sazon**: ""You won't get away with this! M..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Angelica Sazon"); ;` | `[224]` **Hugo Toras**: ""A shame it had to come to this.""<br>`[225]` **Lucita Azaro**: ""It's a shame it had to come to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[90]` | **""Justice lies in the hands of those who hold power, not in empty ideals.""** | `[87]` **Angelica Sazon**: ""You won't get away with this! M..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Angelica Sazon"); ;` | `[224]` **Hugo Toras**: ""A shame it had to come to this.""<br>`[225]` **Lucita Azaro**: ""It's a shame it had to come to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[91]` | **""Justice is mine to command. Your actions left me no choice.""** | `[87]` **Angelica Sazon**: ""You won't get away with this! M..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Angelica Sazon"); ;` | `[224]` **Hugo Toras**: ""A shame it had to come to this.""<br>`[225]` **Lucita Azaro**: ""It's a shame it had to come to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[92]` | **""You have until the count of three until the same fate falls upon you. One...'"** | `[114]` **Narrator**: "Leona sat frozen, her mouth agap..."<br>`[302]` **Manus Sazon**: ""What have you done!?""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false`<br>`(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false` | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_S...`<br>`Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_S...`<br>*(+2 skryptów)* | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych odgałęzień)* |
| `[102]` | **""There's no need. Either way, the Sazon line will come to nothing.""** | `[107]` **Manus Sazon**: ""There. It's done. Now please......" | `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | *Brak zmian stanu* | `[387]` **Manus Sazon**: ""Maybe that's for the best."" |
| `[103]` | **""Groveling doesn't suit you, Manus.""** | `[107]` **Manus Sazon**: ""There. It's done. Now please......" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Manus Sazon**: ""This isn't groveling. I'm doing..." |
| `[106]` | **""You have my word... no harm shall come to them.""** | `[107]` **Manus Sazon**: ""There. It's done. Now please......" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "His tense shoulders relaxed." |
| `[108]` | **""Gone? Don’t flatter yourselves. You’re only a threat if you refuse to cooperate.""** | `[68]` **Manus Sazon**: ""Father always knew when to make..."<br>`[77]` **Leona Sazon**: ""Agreed. Signing this only guara..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` | *Brak zmian stanu* | `[116]` **Angelica Sazon**: ""And just like that, a signature..." |
| `[109]` | **""Think carefully, Angelica. Is this how you want your house to be remembered?""** | `[68]` **Manus Sazon**: ""Father always knew when to make..."<br>`[77]` **Leona Sazon**: ""Agreed. Signing this only guara..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` | *Brak zmian stanu* | `[121]` **Angelica Sazon**: "What kind of legacy is built on ..." |
| `[110]` | **""You are needlessly refusing to see what's best for your family.""** | `[68]` **Manus Sazon**: ""Father always knew when to make..."<br>`[77]` **Leona Sazon**: ""Agreed. Signing this only guara..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` | *Brak zmian stanu* | `[120]` **Leona Sazon**: ""You call it needless, but I cal..." |
| `[117]` | **""I only require your compliance, not your loyalty.""** | `[116]` **Angelica Sazon**: ""And just like that, a signature..."<br>`[120]` **Leona Sazon**: ""You call it needless, but I cal..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Angelica hesitated, letting out ..." |
| `[118]` | **""Don't make this any more difficult than it has to be.""** | `[116]` **Angelica Sazon**: ""And just like that, a signature..."<br>`[120]` **Leona Sazon**: ""You call it needless, but I cal..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Angelica hesitated, letting out ..." |
| `[119]` | **""Stubbornness won’t bring honor to your name, only ashes.""** | `[116]` **Angelica Sazon**: ""And just like that, a signature..."<br>`[120]` **Leona Sazon**: ""You call it needless, but I cal..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Angelica hesitated, letting out ..." |
| `[145]` | **""I order your immediate execution for threatening the King. Titus, do it.""** | `[140]` **Angelica Sazon**: ""This signature means nothing. Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "Without hesitation, Titus raised..." |
| `[146]` | **""That's it. You are under arrest for openly threatening the King. We’ll see how lo..."** | `[140]` **Angelica Sazon**: ""This signature means nothing. Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "Without a moment's hesitation, T..." |
| `[147]` | **""Say what you will. The land is mine now, and that’s not about to change.""** | `[140]` **Angelica Sazon**: ""This signature means nothing. Y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_SazonDidntR...` | `[153]` **Narrator**: "I allowed a fleeting smirk to cu..." |
| `[148]` | **""Believe what you will, but I have a kingdom to run and no time for your grievances.""** | `[140]` **Angelica Sazon**: ""This signature means nothing. Y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_SazonDidntR...` | `[153]` **Narrator**: "I allowed a fleeting smirk to cu..." |
| `[152]` | **""Hey! Focus. We still have business to take care of.""** | `[114]` **Narrator**: "Leona sat frozen, her mouth agap..."<br>`[302]` **Manus Sazon**: ""What have you done!?""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true) == false`<br>`Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false`<br>`(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false` | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_S...`<br>`Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_S...`<br>*(+2 skryptów)* | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych odgałęzień)* |
| `[156]` | **""There. It's done.""** | `[265]` **Narrator**: "The men brought the signed paper..."<br>`[276]` **Narrator**: "The men brought the signed paper..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSi...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[162]` **Narrator**: "Angelica clenched her fist."<br>`[168]` **Narrator**: "Leona stood motionless, eyes wid..." |
| `[157]` | **""What was once yours is now officially the Crown's.""** | `[265]` **Narrator**: "The men brought the signed paper..."<br>`[276]` **Narrator**: "The men brought the signed paper..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSi...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[162]` **Narrator**: "Angelica clenched her fist."<br>`[168]` **Narrator**: "Leona stood motionless, eyes wid..." |
| `[158]` | **""You can keep the clothes on your back, but from this day forward, everything else..."** | `[265]` **Narrator**: "The men brought the signed paper..."<br>`[276]` **Narrator**: "The men brought the signed paper..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSi...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[162]` **Narrator**: "Angelica clenched her fist."<br>`[168]` **Narrator**: "Leona stood motionless, eyes wid..." |
| `[213]` | **""That's the last straw. Titus, shoot her.""** | `[79]` **Narrator**: "She threw the pen to the ground." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "Without hesitation, Titus raised..." |
| `[231]` | **""Perhaps you underestimated my resolve, Uncle. A mistake, I trust, you won't make ..."** | `[226]` **Hugo Toras**: ""Your Majesty... I must admit, I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Hugo Toras**: ""No, Your Majesty. Your resolve ..." |
| `[232]` | **""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""** | `[226]` **Hugo Toras**: ""Your Majesty... I must admit, I..."<br>`[240]` **Lucita Azaro**: ""Your Majesty... I never imagine..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "Hugo lowered his gaze, offering ..."<br>`[249]` **Narrator**: "Her frustration was evident, but..." |
| `[236]` | **""You may not see it now, but this will secure the future of the kingdom, Hugo.""** | `[226]` **Hugo Toras**: ""Your Majesty... I must admit, I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Hugo Toras**: ""For all our sakes, I hope you'r..." |
| `[247]` | **""Perhaps you underestimated my resolve. A mistake, I trust, you won't make again.""** | `[240]` **Lucita Azaro**: ""Your Majesty... I never imagine..."<br>`[253]` **Lucita Azaro**: ""I never imagined you would push..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Lucita Azaro**: ""Your resolve is clearer than ev..." |
| `[248]` | **""You may not see it now, but this will secure the future of the kingdom.""** | `[240]` **Lucita Azaro**: ""Your Majesty... I never imagine..."<br>`[253]` **Lucita Azaro**: ""I never imagined you would push..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Lucita Azaro**: ""I truly hope you're right, for ..." |
| `[255]` | **""There is no way out now. Please cooperate.""** | `[18]` **Leona Sazon**: ""It's not our signatures you wan..."<br>`[127]` **Leona Sazon**: ""Do you even hear yourself? It’s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "Leona stared doubtfully at the p..." |
| `[256]` | **""There is no way out now. Please cooperate.""** | `[68]` **Manus Sazon**: ""Father always knew when to make..."<br>`[77]` **Leona Sazon**: ""Agreed. Signing this only guara..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` | *Brak zmian stanu* | `[3]` **Narrator**: "Angelica hesitated, letting out ..." |
| `[257]` | **""Titus. Her hands appear to be shaking, please help her with the signature.""** | `[79]` **Narrator**: "She threw the pen to the ground." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelic...` | `[348]` **Narrator**: "Titus gave the signal to Sevrio."<br>`[335]` **Narrator**: "Titus gave the signal to his men." |
| `[260]` | **""You've got spirit. I'll give you that.""** | `[263]` **Narrator**: "Despite Angelica's attempt to re..."<br>`[341]` **Narrator**: "Despite Angelica's best efforts,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Angelica Sazon**: ""Let go of me!"" |
| `[262]` | **""Now look what you made me do.""** | `[263]` **Narrator**: "Despite Angelica's attempt to re..."<br>`[341]` **Narrator**: "Despite Angelica's best efforts,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Angelica Sazon**: ""Let go of me!"" |
| `[264]` | **""See? It wasn't that hard, was it?""** | `[263]` **Narrator**: "Despite Angelica's attempt to re..."<br>`[341]` **Narrator**: "Despite Angelica's best efforts,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Angelica Sazon**: ""Let go of me!"" |
| `[266]` | **""Thank you for your cooperation.""** | `[265]` **Narrator**: "The men brought the signed paper..."<br>`[276]` **Narrator**: "The men brought the signed paper..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSi...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[162]` **Narrator**: "Angelica clenched her fist."<br>`[168]` **Narrator**: "Leona stood motionless, eyes wid..." |
| `[268]` | **""Titus. Please help her with the signature.""** | `[175]` **Narrator**: "But just before signing the docu..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] = ...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[369]` **Narrator**: "Titus gave the signal to Sevrio."<br>`[357]` **Narrator**: "Titus gave his men the signal." |
| `[270]` | **""You've got spirit. I'll give you that.""** | `[273]` **Narrator**: "Despite Leona's attempt to resis..."<br>`[363]` **Narrator**: "Despite Leona's best efforts, sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "The men brought the signed paper..." |
| `[272]` | **""Now look what you made me do.""** | `[273]` **Narrator**: "Despite Leona's attempt to resis..."<br>`[363]` **Narrator**: "Despite Leona's best efforts, sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "The men brought the signed paper..." |
| `[274]` | **""See? It wasn't that hard, was it?""** | `[273]` **Narrator**: "Despite Leona's attempt to resis..."<br>`[363]` **Narrator**: "Despite Leona's best efforts, sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "The men brought the signed paper..." |
| `[278]` | **"Watch her in silence."** | `[87]` **Angelica Sazon**: ""You won't get away with this! M..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Angelica Sazon"); ;` | `[224]` **Hugo Toras**: ""A shame it had to come to this.""<br>`[225]` **Lucita Azaro**: ""It's a shame it had to come to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[280]` | **"Gesture at the pen and the papers."** | `[114]` **Narrator**: "Leona sat frozen, her mouth agap..."<br>`[302]` **Manus Sazon**: ""What have you done!?""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false`<br>`(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false` | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_S...`<br>`Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_S...`<br>*(+2 skryptów)* | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych odgałęzień)* |
| `[281]` | **""Thank you for your cooperation.""** | `[65]` **Narrator**: "Manus hesitated at first, but th..."<br>`[96]` **Narrator**: "Leona hesitated at first, but th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSi...`<br>`RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_Ci...` | `[67]` **Leona Sazon**: "“Please, I beg you, spare me! I ..." |
| `[296]` | **""Calm down. My business with your family is done here.""** | `[67]` **Leona Sazon**: "“Please, I beg you, spare me! I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Narrator**: "She breathed a shaky sigh of rel..." |
| `[322]` | **""Since when are you so fond of House Azaro?""** | `[320]` **Angelica Sazon**: ""Go ahead and order your men to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "I held up the pen and motioned t..." |
| `[324]` | **""Please don't make this difficult. Just sign your name and get this over with.""** | `[320]` **Angelica Sazon**: ""Go ahead and order your men to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "I held up the pen and motioned t..." |
| `[325]` | **""You can't come out of this looking like a martyr. We'll make you sign the papers,..."** | `[320]` **Angelica Sazon**: ""Go ahead and order your men to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelic...` | `[348]` **Narrator**: "Titus gave the signal to Sevrio."<br>`[335]` **Narrator**: "Titus gave the signal to his men." |
| `[326]` | **""Fine. Titus, you heard her. Arrest Angelica Sazon immediately.""** | `[320]` **Angelica Sazon**: ""Go ahead and order your men to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Narrator**: "Without a moment of hesitation, ..."<br>`[86]` **Narrator**: "Without a moment's hesitation, T..." |
| `[329]` | **""I don't have time for this. Titus, shoot her.""** | `[320]` **Angelica Sazon**: ""Go ahead and order your men to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "Without hesitation, Titus raised..." |
| `[334]` | **""Titus. Give her the same treatment as the good General.""** | `[79]` **Narrator**: "She threw the pen to the ground." | `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true` | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelic...` | `[348]` **Narrator**: "Titus gave the signal to Sevrio."<br>`[335]` **Narrator**: "Titus gave the signal to his men." |
| `[386]` | **""Why would I? You're still the Prince Consort.""** | `[107]` **Manus Sazon**: ""There. It's done. Now please......" | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[277]` **Narrator**: "His tense shoulders relaxed." |
| `[390]` | **""I'll remind you that you're vastly outnumbered. Think very carefully about your n..."** | `[175]` **Narrator**: "But just before signing the docu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Narrator**: "With a long sigh of regret, she ..." |
| `[391]` | **"Don't say anything."** | `[175]` **Narrator**: "But just before signing the docu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[394]` **Narrator**: "With a long sigh of regret, she ..." |

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
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Angelica hesitated, letting out a slow, measured breath. After a moment, she approached the desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "However, just as her fingers closed around the pen, she p..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == false"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == false)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Leona Sazon: ""What’s the point? Signing this would be a disgrace -- gu..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: ""If it means sparing my family, then I'll sign.""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Angelica Sazon: ""What’s the point? Our honor and dignity will be shattere..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == false"*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""If it means sparing my family, then I'll sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Leona Sazon: ""What’s the point? Signing this would be a disgrace -- gu..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Chin held high, Manus approached the desk, took the pen, and signed the paperwork with a steady hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "The tension in his posture betrayed his struggle to remai..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don’t flatter yourself, Leona. You’re only a threat if you refuse to cooperate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Leona Sazon), `[127]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Leona Sazon: ""And signing will make us your allies, just like that?""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think carefully, Leona. Is this how you want your house to be remembered?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Leona Sazon), `[127]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Leona Sazon: ""What good is a legacy if it's built on submission?""*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only need your compliance, not your loyalty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Leona Sazon), `[30]` (Leona Sazon), `[31]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Leona stared doubtfully at the pen on the table."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don’t make this harder than it needs to be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Leona Sazon), `[30]` (Leona Sazon), `[31]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Leona stared doubtfully at the pen on the table."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stubbornness won’t bring honor to your name. It’ll bring only ashes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Leona Sazon), `[30]` (Leona Sazon), `[31]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Leona stared doubtfully at the pen on the table."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "The tension in his posture betrayed his struggle to remain composed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[18]`
Mówca: **Leona Sazon**
> ""It's not our signatures you want, you want us out of the picture entirely. Admit it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: ""There is no way out now. Please cooperate.""*)
  - -> `[12]` (*Player_Romus: ""Don’t flatter yourself, Leona. You’re only a threat if y..."*)
  - -> `[13]` (*Player_Romus: ""Think carefully, Leona. Is this how you want your house ..."*)
  - -> `[28]` (*Player_Romus: ""I admit nothing but the fact that you're stubbornly refu..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Leona stared doubtfully at the pen on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == false"*)

### Węzeł `[20]`
Mówca: **Angelica Sazon**
> "“No, Manus, he needs to hear it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "She took a commanding step toward me."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "She took a commanding step toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Angelica Sazon: "“It’s my duty to demand a government that upholds the rig..."*)

### Węzeł `[22]`
Mówca: **Leona Sazon**
> "“No, Manus, he needs to hear it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "She took a commanding step forward."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "She took a commanding step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Leona Sazon: "“It is my duty to demand a government that upholds the ri..."*)

### Węzeł `[24]`
Mówca: **Angelica Sazon**
> ""Not one that seeks to silence them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Your demands are irrelevant here. I’ll decide what’s bes..."*)
  - -> `[54]` (*Player_Romus: ""Spare me. I didn't call you here to debate civics. Just ..."*)
  - -> `[55]` (*Player_Romus: ""I will not tolerate rebellion in the guise of noble idea..."*)

### Węzeł `[25]`
Mówca: **Leona Sazon**
> ""Not one that seeks to silence them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Your demands are irrelevant here. I’ll decide what’s bes..."*)
  - -> `[54]` (*Player_Romus: ""Spare me. I didn't call you here to debate civics. Just ..."*)
  - -> `[55]` (*Player_Romus: ""I will not tolerate rebellion in the guise of noble idea..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == false"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Letting out a slow, measured breath, she picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "But just before signing the document, she retracted her h..."*)

### Węzeł `[27]`
Mówca: **Leona Sazon**
> "“It is my duty to demand a government that upholds the rights and freedoms of every individual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Leona Sazon: ""Not one that seeks to silence them.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I admit nothing but the fact that you're stubbornly refusing to see what's best for your family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Leona Sazon), `[127]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Leona Sazon: ""You call it stubborn, but I call it loyalty. Some of us ..."*)

### Węzeł `[29]`
Mówca: **Leona Sazon**
> ""And signing will make us your allies, just like that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I only need your compliance, not your loyalty.""*)
  - -> `[15]` (*Player_Romus: ""Don’t make this harder than it needs to be.""*)
  - -> `[16]` (*Player_Romus: ""Stubbornness won’t bring honor to your name. It’ll bring..."*)

### Węzeł `[30]`
Mówca: **Leona Sazon**
> ""What good is a legacy if it's built on submission?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I only need your compliance, not your loyalty.""*)
  - -> `[15]` (*Player_Romus: ""Don’t make this harder than it needs to be.""*)
  - -> `[16]` (*Player_Romus: ""Stubbornness won’t bring honor to your name. It’ll bring..."*)

### Węzeł `[31]`
Mówca: **Leona Sazon**
> ""You call it stubborn, but I call it loyalty. Some of us still believe in that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I only need your compliance, not your loyalty.""*)
  - -> `[15]` (*Player_Romus: ""Don’t make this harder than it needs to be.""*)
  - -> `[16]` (*Player_Romus: ""Stubbornness won’t bring honor to your name. It’ll bring..."*)

### Węzeł `[32]`
Mówca: **Angelica Sazon**
> "“All right. I won’t deny taking the necessary steps to stand up against a monarch who’d rule this land without any respect to its fellow subjects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_Coup_Warning == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Angelica Sazon: "“All right. I won’t deny taking the necessary steps to st..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_Coup_Warning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Angelica Sazon: "“Enough, Your Majesty. You had my gratitude when you free..."*)

### Węzeł `[36]`
Mówca: **Leona Sazon**
> "“I won’t deny that House Sazon sought a measure of autonomy -- to act for ourselves in the face of a rule that is becoming more iron-fisted by the day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Angelica scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[38]`
Mówca: **Angelica Sazon**
> "“Enough, Your Majesty. You had my gratitude when you freed me from exile. But that doesn't mean I will stand by and watch you humiliate my house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Leona scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Leona Sazon: "“I won’t deny that House Sazon sought a measure of autono..."*)

### Węzeł `[40]`
Mówca: **Manus Sazon**
> "“Mother, please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Angelica Sazon: "“No, Manus, he needs to hear it.”"*)

### Węzeł `[41]`
Mówca: **Angelica Sazon**
> "“It’s my duty to demand a government that upholds the rights of each noble House in accordance with royal tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Angelica Sazon: ""Not one that seeks to silence them.”"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Manus Sazon: "“Mother, please!”"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Leona Sazon: ""You left us with no choice.""*)

### Węzeł `[45]`
Mówca: **Leona Sazon**
> ""You left us with no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "She took a commanding step toward me."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Manus Sazon: "“Leona, please!”"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "She took a commanding step forward."*)

### Węzeł `[49]`
Mówca: **Manus Sazon**
> "“Leona, please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Leona Sazon: "“No, Manus, he needs to hear it.”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your ‘autonomy’ was anything but treason, you wouldn't be here pleading your case to me. Now... your autograph, if you will.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == false`
- **Kontekst wejściowy (poprzednik):** `[25]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I held up the pen and motioned to the document."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I held up the pen and motioned to the document for her to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Grasping the pen, I held it firmly before her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "I held up the pen and motioned to the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spare me. I didn't call you here to debate civics. Just sign your name and get this over with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Angelica Sazon), `[25]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Grasping the pen, I held it firmly before her."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not tolerate rebellion in the guise of noble ideals. Now do the right thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Angelica Sazon), `[25]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I held up the pen and motioned to the document for her to..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your demands are irrelevant here. I’ll decide what’s best for this realm.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Angelica Sazon), `[25]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Grasping the pen, I held it firmly before her."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == false"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_Coup_Warning == false)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""If your ‘autonomy’ was anything but treason, you wouldn'..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_Coup_Warning == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
Mówca: **Leona Sazon**
> ""You have to see that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Manus Sazon: ""Father always knew when to make the hard choices. He wou..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "However, just as her fingers closed around the pen, she paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Angelica Sazon: ""Forget it!""*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Manus screamed, his face pale with horror as he watched his mother fall. Leona sat frozen, her mouth agape in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Manus Sazon: ""What have you done!?""*)

### Węzeł `[63]`
Mówca: **Angelica Sazon**
> "“It’s not just about signatures, Manus. They want us out of the picture entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Leona Sazon: ""You have to see that.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that I've gotten your attention... your signature please.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false` AND `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator), `[302]` (Manus Sazon), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Manus hesitated at first, but then picked up the pen, as if in a daze, signing the document with shaking hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""Thank you for your cooperation.""*)
  - -> `[72]` (*Player_Romus: ""Good. I knew you'd come to see reason.""*)
  - -> `[66]` (*Player_Romus: ""There. That wasn't so difficult, was it?""*)
  - -> `[70]` (*Player_Romus: ""If your House had just done what you were told from the ..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There. That wasn't so difficult, was it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[96]` (Narrator), `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[67]`
Mówca: **Leona Sazon**
> "“Please, I beg you, spare me! I wish to make amends!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""Very well. But do so with some damn dignity. Groveling i..."*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[296]` (*Player_Romus: ""Calm down. My business with your family is done here.""*)

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""Father always knew when to make the hard choices. He wouldn't want us to face the consequences of defiance. No please, just sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and Manus shall be spared. How kind of you to plead for his life as well, by the way.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[67]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "Tears streamed down her face."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your House had just done what you were told from the start, we could have avoided this pointless delay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[96]` (Narrator), `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. But do so with some damn dignity. Groveling is beneath you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Leona Sazon: ""Yes, Your Majesty. Thank you.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. I knew you'd come to see reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[96]` (Narrator), `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""You and Manus shall be spared. How kind of you to plead ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Angelica Sazon**
> ""What’s the point? Our honor and dignity will be shattered before the ink even dries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Leona Sazon: ""Agreed. Signing this only guarantees the end of everythi..."*)

### Węzeł `[77]`
Mówca: **Leona Sazon**
> ""Agreed. Signing this only guarantees the end of everything we stand for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[78]`
Mówca: **Manus Sazon**
> "“Do you even hear yourselves? Pride will do nothing but ensure our family suffers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Angelica Sazon: "“It’s not just about signatures, Manus. They want us out ..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "She threw the pen to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[257]` (*Player_Romus: ""Titus. Her hands appear to be shaking, please help her w..."*)
  - -> `[83]` (*Player_Romus: ""You leave me no choice. Under the authority vested in me..."*)
  - -> `[213]` (*Player_Romus: ""That's the last straw. Titus, shoot her.""*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Without hesitation, Titus raised his gun and fired, a single shot echoing through the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed = true; RiziaDLCSupport.Journa..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Angelica’s body crumped lifelessly to the floor, blood pooling around her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Save your tears. We still have business to take care of.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true` AND `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false` AND `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator), `[302]` (Manus Sazon), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You leave me no choice. Under the authority vested in me as king, I place you under arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "Arrest_Angelica_Hub"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Angelica_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Angelica_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Angelica Sazon: ""You won't get away with this! Mark my words... justice w..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Without a moment's hesitation, Titus grabbed Angelica and guided her toward the back wall, where other uniformed men took her into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Arrested = true; RiziaDLCSupport.Journa..."*)

### Węzeł `[87]`
Mówca: **Angelica Sazon**
> ""You won't get away with this! Mark my words... justice will prevail!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus_Italic: "Watch her in silence."*)
  - -> `[91]` (*Player_Romus: ""Justice is mine to command. Your actions left me no choi..."*)
  - -> `[90]` (*Player_Romus: ""Justice lies in the hands of those who hold power, not i..."*)
  - -> `[89]` (*Player_Romus: ""Justice is precisely what’s being served. You simply don..."*)
  - -> `[88]` (*Player_Romus: ""Justice *has* prevailed. Your fate was sealed the moment..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice *has* prevailed. Your fate was sealed the moment you crossed me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon");"*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice is precisely what’s being served. You simply don’t like the outcome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon");"*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice lies in the hands of those who hold power, not in empty ideals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon");"*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice is mine to command. Your actions left me no choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon");"*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have until the count of three until the same fate falls upon you. One...'"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false` AND `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator), `[302]` (Manus Sazon), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed = true;"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed = true;"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Leona hesitated at first, but then picked up the pen, as if in a daze, signing the document with shaking hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""Thank you for your cooperation.""*)
  - -> `[72]` (*Player_Romus: ""Good. I knew you'd come to see reason.""*)
  - -> `[66]` (*Player_Romus: ""There. That wasn't so difficult, was it?""*)
  - -> `[70]` (*Player_Romus: ""If your House had just done what you were told from the ..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "As she was taken out, Leona sat frozen, stunned by what had transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "As she was taken out, Manus sat frozen, stunned by what h..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "As she was taken out, Leona sat frozen, stunned by what h..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "As she was taken out, Manus sat frozen, stunned by what had transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true"*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no need. Either way, the Sazon line will come to nothing.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[107]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Manus Sazon: ""Maybe that's for the best.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Groveling doesn't suit you, Manus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Manus Sazon: ""This isn't groveling. I'm doing what's right.""*)

### Węzeł `[104]`
Mówca: **Narrator**
> "He bowed his head slightly before stepping back. Leona stared at him in disgust."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Leona Sazon: ""Signing our family's fate away? You're no Sazon at all.""*)

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""Thank you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "He bowed his head slightly before stepping back. Leona st..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my word... no harm shall come to them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "His tense shoulders relaxed."*)

### Węzeł `[107]`
Mówca: **Manus Sazon**
> ""There. It's done. Now please... don't hurt my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player_Romus: ""You have my word... no harm shall come to them.""*)
  - -> `[103]` (*Player_Romus: ""Groveling doesn't suit you, Manus.""*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Gone? Don’t flatter yourselves. You’re only a threat if you refuse to cooperate.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon), `[77]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Angelica Sazon: ""And just like that, a signature makes us your allies?""*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think carefully, Angelica. Is this how you want your house to be remembered?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon), `[77]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Angelica Sazon: "What kind of legacy is built on submission?""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are needlessly refusing to see what's best for your family.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon), `[77]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Leona Sazon: ""You call it needless, but I call it loyalty. Some of us ..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Manus screamed, his face pale with horror as he watched h..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Leona sat frozen, her mouth agape in disbelief."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Leona sat frozen, her mouth agape in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus_Italic: "Gesture at the pen and the papers."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Exec..."*)
  - -> `[64]` (*Player_Romus: ""Now that I've gotten your attention... your signature pl..."*)
  - -> `[92]` (*Player_Romus: ""You have until the count of three until the same fate fa..."*)

### Węzeł `[116]`
Mówca: **Angelica Sazon**
> ""And just like that, a signature makes us your allies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""I only require your compliance, not your loyalty.""*)
  - -> `[118]` (*Player_Romus: ""Don't make this any more difficult than it has to be.""*)
  - -> `[119]` (*Player_Romus: ""Stubbornness won’t bring honor to your name, only ashes.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only require your compliance, not your loyalty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Angelica Sazon), `[120]` (Leona Sazon), `[121]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Angelica hesitated, letting out a slow, measured breath. ..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make this any more difficult than it has to be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Angelica Sazon), `[120]` (Leona Sazon), `[121]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Angelica hesitated, letting out a slow, measured breath. ..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stubbornness won’t bring honor to your name, only ashes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Angelica Sazon), `[120]` (Leona Sazon), `[121]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Angelica hesitated, letting out a slow, measured breath. ..."*)

### Węzeł `[120]`
Mówca: **Leona Sazon**
> ""You call it needless, but I call it loyalty. Some of us still believe in that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""I only require your compliance, not your loyalty.""*)
  - -> `[118]` (*Player_Romus: ""Don't make this any more difficult than it has to be.""*)
  - -> `[119]` (*Player_Romus: ""Stubbornness won’t bring honor to your name, only ashes.""*)

### Węzeł `[121]`
Mówca: **Angelica Sazon**
> "What kind of legacy is built on submission?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""I only require your compliance, not your loyalty.""*)
  - -> `[118]` (*Player_Romus: ""Don't make this any more difficult than it has to be.""*)
  - -> `[119]` (*Player_Romus: ""Stubbornness won’t bring honor to your name, only ashes.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Angelica scowled."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Leona scowled."*)

### Węzeł `[125]`
Mówca: **Manus Sazon**
> ""There's no time to let pride get in the way. It will do nothing but ensure our family suffers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Leona Sazon: ""Do you even hear yourself? It’s not just about signature..."*)

### Węzeł `[126]`
Mówca: **Manus Sazon**
> ""This isn't groveling. I'm doing what's right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "He bowed his head slightly before stepping back. Leona st..."*)

### Węzeł `[127]`
Mówca: **Leona Sazon**
> ""Do you even hear yourself? It’s not just about signatures. He wants us out of the picture entirely. You must see that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: ""There is no way out now. Please cooperate.""*)
  - -> `[12]` (*Player_Romus: ""Don’t flatter yourself, Leona. You’re only a threat if y..."*)
  - -> `[13]` (*Player_Romus: ""Think carefully, Leona. Is this how you want your house ..."*)
  - -> `[28]` (*Player_Romus: ""I admit nothing but the fact that you're stubbornly refu..."*)

### Węzeł `[128]`
Mówca: **Leona Sazon**
> ""What’s the point? Signing this would be a disgrace -- guaranteeing the end of everything we stand for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Manus Sazon: ""There's no time to let pride get in the way. It will do ..."*)

### Węzeł `[129]`
Mówca: **Manus Sazon**
> ""What choice do we have, Leona? His Majesty isn't going to let us out of the room until these papers are signed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Manus Sazon: ""And in the end, these titles and land aren't really ours..."*)

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""Signing is our only option. And I will do what must be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Chin held high, Manus approached the desk, took the pen, ..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Manus Sazon: "“Do you even hear yourselves? Pride will do nothing but e..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player_Romus: ""There is no way out now. Please cooperate.""*)
  - -> `[108]` (*Player_Romus: ""Gone? Don’t flatter yourselves. You’re only a threat if ..."*)
  - -> `[109]` (*Player_Romus: ""Think carefully, Angelica. Is this how you want your hou..."*)
  - -> `[110]` (*Player_Romus: ""You are needlessly refusing to see what's best for your ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Angelica Sazon");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Angelica Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Angelica Sazon");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Angelica Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Angelica_Executed == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Leona Sazon: "“Please, I beg you, spare me! I wish to make amends!”"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Angelica_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "Jump to: [Smirk_Hub]"*)

### Węzeł `[140]`
Mówca: **Angelica Sazon**
> ""This signature means nothing. You can't hold this stolen land forever. It's not going to last, if it happens at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""Say what you will. The land is mine now, and that’s not ..."*)
  - -> `[148]` (*Player_Romus: ""Believe what you will, but I have a kingdom to run and n..."*)
  - -> `[145]` (*Player_Romus: ""I order your immediate execution for threatening the Kin..."*)
  - -> `[146]` (*Player_Romus: ""That's it. You are under arrest for openly threatening t..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Angelica_Executed == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Angelica_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Leona hesitated at first, but then picked up the pen, signing the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""Thank you for your cooperation.""*)
  - -> `[72]` (*Player_Romus: ""Good. I knew you'd come to see reason.""*)
  - -> `[66]` (*Player_Romus: ""There. That wasn't so difficult, was it?""*)
  - -> `[70]` (*Player_Romus: ""If your House had just done what you were told from the ..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I order your immediate execution for threatening the King. Titus, do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Without hesitation, Titus raised hi...."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it. You are under arrest for openly threatening the King. We’ll see how long your prideful defiance lasts behind bars.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Without a moment's hesitation, Titu...."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say what you will. The land is mine now, and that’s not about to change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist = true"*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe what you will, but I have a kingdom to run and no time for your grievances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist = true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Exec..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Ex..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Save your tears. We still have business to take care of.""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: ""Hey! Focus. We still have business to take care of.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hey! Focus. We still have business to take care of.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true) == false` AND `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false` AND `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator), `[302]` (Manus Sazon), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "I allowed a fleeting smirk to curl at the edge of my lips before moving on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Leona bowed and stepped back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Jump to: [Smirk_Hub]"*)

### Węzeł `[155]`
Mówca: **Leona Sazon**
> ""Yes, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Leona bowed and stepped back."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There. It's done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator), `[276]` (Narrator), `[389]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What was once yours is now officially the Crown's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator), `[276]` (Narrator), `[389]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can keep the clothes on your back, but from this day forward, everything else is mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator), `[276]` (Narrator), `[389]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Angelica clenched her fist."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Leona stood motionless, eyes wide with shock."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "Angelica clenched her fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Manus and Leona looked on in stunned silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Manus and Leona looked on in stunned silence."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Leona looked on in stunned silence."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Leona looked on in stunned silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "Leona stood motionless, eyes wide with shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Leona Sazon: ""It's gone... It's all gone...""*)

### Węzeł `[169]`
Mówca: **Leona Sazon**
> ""It's gone... It's all gone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == false"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Smirk_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Smirk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "Smirk_Hub"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Smirk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "Smirk_Hub"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Smirk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "Smirk_Hub"*)

### Węzeł `[174]`
Mówca: **Leona Sazon**
> ""What’s the point? Signing this would be a disgrace -- guaranteeing the end of everything House Sazon stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Leona Sazon: ""It's not our signatures you want, you want us out of the..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "But just before signing the document, she retracted her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player_Romus: ""Titus. Please help her with the signature.""*)
  - -> `[390]` (*Player_Romus: ""I'll remind you that you're vastly outnumbered. Think ve..."*)
  - -> `[391]` (*Player_Romus_Italic: "Don't say anything."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == false"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == false)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Letting out a slow, measured breath, she picked it up."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Manus Sazon: ""What choice do we have, Leona? His Majesty isn't going t..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed = true;"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed = true;"*)

### Węzeł `[182]`
Mówca: **Narrator**
> "Manus hesitated at first, but then picked up the pen, signing the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""Thank you for your cooperation.""*)
  - -> `[72]` (*Player_Romus: ""Good. I knew you'd come to see reason.""*)
  - -> `[66]` (*Player_Romus: ""There. That wasn't so difficult, was it?""*)
  - -> `[70]` (*Player_Romus: ""If your House had just done what you were told from the ..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_C..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_C..."*)

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""I strongly suggest you do what he says, Angelica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[186]`
Mówca: **Hugo Toras**
> ""I strongly suggest you do what he says, Countess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == tru..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Hugo Toras: ""I strongly suggest you do what he says, Angelica.""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Hugo Toras: ""I strongly suggest you do what he says, Countess.""*)

### Węzeł `[196]`
Mówca: **Lucita Azaro**
> ""Take my advice, Angelica -- do what he says.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[197]`
Mówca: **Lucita Azaro**
> ""Take my advice, Countess -- do what he says.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Lucita Azaro: ""Take my advice, Angelica -- do what he says.""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucita Azaro: ""Take my advice, Countess -- do what he says.""*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Hugo Toras: ""I can't say you didn't have it coming.""*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucita Azaro: ""Can't say you didn't have it coming.""*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == tru..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[207]`
Mówca: **Hugo Toras**
> ""I can't say you didn't have it coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[208]`
Mówca: **Lucita Azaro**
> ""Can't say you didn't have it coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true ||RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true ||RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true ||RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon");"*)

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon");"*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the last straw. Titus, shoot her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Without hesitation, Titus raised his gun and fired, a sin..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Hugo Toras: ""Dear God...""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""Dear God...""*)

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon");"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Hugo Toras: ""A shame it had to come to this.""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucita Azaro: ""It's a shame it had to come to this.""*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[224]`
Mówca: **Hugo Toras**
> ""A shame it had to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""It's a shame it had to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[226]`
Mówca: **Hugo Toras**
> ""Your Majesty... I must admit, I never thought you'd take it this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player_Romus: ""You may not see it now, but this will secure the future ..."*)
  - -> `[231]` (*Player_Romus: ""Perhaps you underestimated my resolve, Uncle. A mistake,..."*)
  - -> `[232]` (*Player_Romus: ""If you lack the stomach for hard decisions, perhaps it’s..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Hugo stepped near me, leaning in to whisper."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "Lucita stepped near me, leaning in to whisper."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "Hugo stepped near me, leaning in to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Hugo Toras: ""Your Majesty... I must admit, I never thought you'd take..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you underestimated my resolve, Uncle. A mistake, I trust, you won't make again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Hugo Toras: ""No, Your Majesty. Your resolve is clearer than ever.""*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Hugo Toras), `[240]` (Lucita Azaro), `[253]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[233]`
Mówca: **Hugo Toras**
> ""For all our sakes, I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""No, Your Majesty. Your resolve is clearer than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[235]`
Mówca: **Narrator**
> "Hugo lowered his gaze, offering no reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but this will secure the future of the kingdom, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Hugo Toras: ""For all our sakes, I hope you're right.""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Exec..."*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Ex..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[240]`
Mówca: **Lucita Azaro**
> ""Your Majesty... I never imagined you would push it this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Player_Romus: ""You may not see it now, but this will secure the future ..."*)
  - -> `[247]` (*Player_Romus: ""Perhaps you underestimated my resolve. A mistake, I trus..."*)
  - -> `[232]` (*Player_Romus: ""If you lack the stomach for hard decisions, perhaps it’s..."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "Lucita stepped near me, leaning in to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Hugo lowered his gaze, offering no reply."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Her frustration was evident, but she said nothing further."*)

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""I truly hope you're right, for all our sakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""Your resolve is clearer than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you underestimated my resolve. A mistake, I trust, you won't make again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Lucita Azaro), `[253]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucita Azaro: ""Your resolve is clearer than ever.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but this will secure the future of the kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Lucita Azaro), `[253]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucita Azaro: ""I truly hope you're right, for all our sakes.""*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Her frustration was evident, but she said nothing further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == false)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Lucita Azaro: ""Your Majesty... I never imagined you would push it this ..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucita Azaro: ""I never imagined you would push it this far, Romus.""*)

### Węzeł `[253]`
Mówca: **Lucita Azaro**
> ""I never imagined you would push it this far, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Player_Romus: ""You may not see it now, but this will secure the future ..."*)
  - -> `[247]` (*Player_Romus: ""Perhaps you underestimated my resolve. A mistake, I trus..."*)
  - -> `[232]` (*Player_Romus: ""If you lack the stomach for hard decisions, perhaps it’s..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no way out now. Please cooperate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Leona Sazon), `[127]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Leona stared doubtfully at the pen on the table."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no way out now. Please cooperate.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon), `[77]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Angelica hesitated, letting out a slow, measured breath. ..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Her hands appear to be shaking, please help her with the signature.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Forced_Signature_Hub"*)

### Węzeł `[258]`
Mówca: **Angelica Sazon**
> ""What are you doing?! Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "Despite Angelica's attempt to resist, the men wrenched he..."*)

### Węzeł `[259]`
Mówca: **Angelica Sazon**
> ""Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "The men brought the signed papers back to me."*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've got spirit. I'll give you that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Angelica Sazon: ""Let go of me!""*)

### Węzeł `[261]`
Mówca: **Narrator**
> "His men grabbed the pen, brought Angelica to the desk, and pressed it firmly into her grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Angelica Sazon: ""What are you doing?! Let go of me!""*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now look what you made me do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Angelica Sazon: ""Let go of me!""*)

### Węzeł `[263]`
Mówca: **Narrator**
> "Despite Angelica's attempt to resist, the men wrenched her hand to the signature line, forcing her to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""Now look what you made me do.""*)
  - -> `[260]` (*Player_Romus: ""You've got spirit. I'll give you that.""*)
  - -> `[264]` (*Player_Romus: ""See? It wasn't that hard, was it?""*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? It wasn't that hard, was it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Angelica Sazon: ""Let go of me!""*)

### Węzeł `[265]`
Mówca: **Narrator**
> "The men brought the signed papers back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "Signed Peacefully"*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator), `[276]` (Narrator), `[389]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[267]`
Mówca: **Angelica Sazon**
> ""Forget it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "She threw the pen to the ground."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Please help her with the signature.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature = true; RiziaD..."*)

### Węzeł `[269]`
Mówca: **Leona Sazon**
> ""What are you doing?! Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "Despite Leona's attempt to resist, the men wrenched her h..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've got spirit. I'll give you that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator), `[363]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "The men brought the signed papers back to me."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "Without missing a beat, two men grabbed the pen, pushed Leona to the desk and pressed the pen firmly into her grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Leona Sazon: ""What are you doing?! Let go of me!""*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now look what you made me do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator), `[363]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "The men brought the signed papers back to me."*)

### Węzeł `[273]`
Mówca: **Narrator**
> "Despite Leona's attempt to resist, the men wrenched her hand to the signature line, forcing her to write her name, though it was barely legible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player_Romus: ""Now look what you made me do.""*)
  - -> `[270]` (*Player_Romus: ""You've got spirit. I'll give you that.""*)
  - -> `[274]` (*Player_Romus: ""See? It wasn't that hard, was it?""*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? It wasn't that hard, was it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator), `[363]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "The men brought the signed papers back to me."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature = true; RiziaDLCSupport.Journal_Turn10_Birthday_Leona_ForcedSign = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_ForcedSign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_C..."*)

### Węzeł `[276]`
Mówca: **Narrator**
> "The men brought the signed papers back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "Jump to: [Signed Peacefully]"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "His tense shoulders relaxed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Manus Sazon: ""Thank you, sir.""*)

### Węzeł `[278]`
**[WYBÓR GRACZA: "Watch her in silence."]** — Mówca: **Player_Romus_Italic**
> "I watched as she was taken away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon");"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AngelicaLeonaTakenAway`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA: "Gesture at the pen and the papers."]** — Mówca: **Player_Romus_Italic**
> "I gestured at the pen and the papers."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false` AND `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator), `[302]` (Manus Sazon), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[96]` (Narrator), `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Angelica Sazon: ""This signature means nothing. You can't hold this stolen..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist = true"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == ..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Without hesitation, Titus raised hi..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Without hesitation, Titus raised his gun and fired, a sin..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Without a moment's hesitation, Titu..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Without a moment's hesitation, Titus grabbed Angelica and..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == ..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "Jump to: [Smirk_Hub]"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Smirk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "Smirk_Hub"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Smirk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "Smirk_Hub"*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Calm down. My business with your family is done here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "She breathed a shaky sigh of relief."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "She breathed a shaky sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Leona Sazon: ""Thank you, Your Majesty.""*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Exec..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[302]`
Mówca: **Manus Sazon**
> ""What have you done!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "I allowed a fleeting smirk to curl at the edge of my lips..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Angelica_Executed == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "As Manus let out a strangled sob, I averted my gaze from ..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Angelica_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "I allowed a fleeting smirk to curl at the edge of my lips..."*)

### Węzeł `[309]`
Mówca: **Narrator**
> "As Manus let out a strangled sob, I averted my gaze from him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_C..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Angelica Sazon: ""I cannot stand here after the disrespect you've shown to..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)

### Węzeł `[314]`
Mówca: **Angelica Sazon**
> ""I cannot stand here after the disrespect you've shown to House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Angelica Sazon: ""The Crown has officially lost its legitimacy.""*)

### Węzeł `[315]`
Mówca: **Manus Sazon**
> "“Mother, please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "She took a commanding step toward me."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Manus Sazon: "“Mother, please!”"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "She took a commanding step toward me."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "She took a commanding step toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Angelica Sazon: ""Go ahead and order your men to apprehend me.""*)

### Węzeł `[320]`
Mówca: **Angelica Sazon**
> ""Go ahead and order your men to apprehend me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Player_Romus: ""Fine. Titus, you heard her. Arrest Angelica Sazon immedi..."*)
  - -> `[324]` (*Player_Romus: ""Please don't make this difficult. Just sign your name an..."*)
  - -> `[329]` (*Player_Romus: ""I don't have time for this. Titus, shoot her.""*)
  - -> `[325]` (*Player_Romus: ""You can't come out of this looking like a martyr. We'll ..."*)
  - -> `[322]` (*Player_Romus: ""Since when are you so fond of House Azaro?""*)

### Węzeł `[321]`
Mówca: **Angelica Sazon**
> ""The Crown has officially lost its legitimacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since when are you so fond of House Azaro?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "I held up the pen and motioned to the document."*)

### Węzeł `[323]`
Mówca: **Narrator**
> "I held up the pen and motioned to the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please don't make this difficult. Just sign your name and get this over with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "I held up the pen and motioned to the document."*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't come out of this looking like a martyr. We'll make you sign the papers, just as we did with the General.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "Jump to: [Forced_Signature_Hub]"*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Titus, you heard her. Arrest Angelica Sazon immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "Jump to: [Arrest_Angelica_Hub]"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Arrest_Angelica_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "Arrest_Angelica_Hub"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Forced_Signature_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Forced_Signature_Hub"*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time for this. Titus, shoot her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Without hesitation, Titus raised hi...."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Without hesitation, Titus raised hi..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Without hesitation, Titus raised his gun and fired, a sin..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player_Romus: ""Titus. Give her the same treatment as the good General.""*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Give her the same treatment as the good General.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Forced_Signature_Hub"*)

### Węzeł `[335]`
Mówca: **Narrator**
> "Titus gave the signal to his men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "Just as with Taddeus, they brought Angelica to the desk a..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[339]`
Mówca: **Narrator**
> "Just as with Taddeus, they brought Angelica to the desk and forced a pen into her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Angelica Sazon: ""Stop! Unhand me this instant!""*)

### Węzeł `[340]`
Mówca: **Angelica Sazon**
> ""Stop! Unhand me this instant!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "Despite Angelica's best efforts, she was forced to sign."*)

### Węzeł `[341]`
Mówca: **Narrator**
> "Despite Angelica's best efforts, she was forced to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""Now look what you made me do.""*)
  - -> `[260]` (*Player_Romus: ""You've got spirit. I'll give you that.""*)
  - -> `[264]` (*Player_Romus: ""See? It wasn't that hard, was it?""*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "Titus gave the signal to Sevrio."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Titus gave the signal to his men."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "The Wruhec's Guardians brought Angelica to the desk and pressed the pen firmly into her grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Angelica Sazon: ""What are you doing?! Let go of me!""*)

### Węzeł `[346]`
Mówca: **Sevrio Castellanus**
> ""Guardians, you know what to do. Move!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Forced_Signature_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_ForcedSi..."*)

### Węzeł `[348]`
Mówca: **Narrator**
> "Titus gave the signal to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Sevrio Castellanus: ""Guardians, you know what to do. Move!""*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "The Wruhec's Guardians brought Angelica to the desk and p..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "His men grabbed the pen, brought Angelica to the desk, an..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "Without a moment of hesitation, Titus signaled to Sevrio,..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Without a moment's hesitation, Titus grabbed Angelica and..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Arrest_Angelica_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[356]`
Mówca: **Narrator**
> "Without a moment of hesitation, Titus signaled to Sevrio, who grabbed Angelica and guided her toward the back wall, where his men took her into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Arrested = true; RiziaDLCSupport.Journa..."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "Titus gave his men the signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "Just as with Taddeus, they brought Leona to the desk and ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[361]`
Mówca: **Narrator**
> "Just as with Taddeus, they brought Leona to the desk and forced a pen into her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Leona Sazon: ""Stop! Let go of me!""*)

### Węzeł `[362]`
Mówca: **Leona Sazon**
> ""Stop! Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "Despite Leona's best efforts, she was forced to sign."*)

### Węzeł `[363]`
Mówca: **Narrator**
> "Despite Leona's best efforts, she was forced to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player_Romus: ""Now look what you made me do.""*)
  - -> `[270]` (*Player_Romus: ""You've got spirit. I'll give you that.""*)
  - -> `[274]` (*Player_Romus: ""See? It wasn't that hard, was it?""*)

### Węzeł `[364]`
Mówca: **Narrator**
> "Without missing a beat, the Wruhec's Guardians brought Leona to the desk and pressed the pen firmly into her grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Leona Sazon: ""What are you doing?! Let go of me!""*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Titus gave the signal to Sevrio."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Titus gave his men the signal."*)

### Węzeł `[368]`
Mówca: **Sevrio Castellanus**
> ""Guardians, you know what to do. Move!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[369]`
Mówca: **Narrator**
> "Titus gave the signal to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Sevrio Castellanus: ""Guardians, you know what to do. Move!""*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "Without missing a beat, the Wruhec's Guardians brought Le..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "Without missing a beat, two men grabbed the pen, pushed L..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Sevrio Castellanus: ""May she find redemption in the afterlife.""*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)

### Węzeł `[376]`
Mówca: **Sevrio Castellanus**
> ""May she find redemption in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_ForcedSign = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_ForcedSign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Manus hesitated at first, but then picked up the pen, as ..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Leona hesitated at first, but then picked up the pen, as ..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Manus hesitated at first, but then picked up the pen, sig..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Leona hesitated at first, but then picked up the pen, sig..."*)

### Węzeł `[382]`
Mówca: **Manus Sazon**
> ""And in the end, these titles and land aren't really ours to give away, are they? What did either of us do to deserve them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Manus Sazon: ""Signing is our only option. And I will do what must be d..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Player_Romus: ""Why would I? You're still the Prince Consort.""*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""There's no need. Either way, the Sazon line will come to..."*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would I? You're still the Prince Consort.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[107]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "His tense shoulders relaxed."*)

### Węzeł `[387]`
Mówca: **Manus Sazon**
> ""Maybe that's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "He bowed his head slightly before stepping back. Leona st..."*)

### Węzeł `[388]`
Mówca: **Leona Sazon**
> ""Signing our family's fate away? You're no Sazon at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Leona Sazon: ""But I know when I'm outnumbered. I won't put up a fight.""*)

### Węzeł `[389]`
Mówca: **Leona Sazon**
> ""But I know when I'm outnumbered. I won't put up a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "Jump to: [Signed Peacefully]"*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll remind you that you're vastly outnumbered. Think very carefully about your next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "With a long sigh of regret, she lowered her hand again an..."*)

### Węzeł `[391]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I didn't intervene."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "With a long sigh of regret, she lowered her hand again an..."*)

### Węzeł `[392]`
Mówca: **Narrator**
> "With a long sigh of regret, she lowered her hand again and signed the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "Jump to: [Signed Peacefully]"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Signed Peacefully`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""Thank you for your cooperation.""*)
  - -> `[157]` (*Player_Romus: ""What was once yours is now officially the Crown's.""*)
  - -> `[156]` (*Player_Romus: ""There. It's done.""*)
  - -> `[158]` (*Player_Romus: ""You can keep the clothes on your back, but from this day..."*)

### Węzeł `[394]`
Mówca: **Narrator**
> "With a long sigh of regret, she lowered her hand again and scribbled her signature on the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "Jump to: [Signed Peacefully]"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Signed Peacefully]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "Signed Peacefully"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == false"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == false)"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Leona Sazon: ""I hope you're happy, Your Majesty. You've taken everythi..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Manus Sazon: ""Not everything. We still have each other.""*)

### Węzeł `[399]`
Mówca: **Manus Sazon**
> ""Not everything. We still have each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)

### Węzeł `[400]`
Mówca: **Leona Sazon**
> ""I hope you're happy, Your Majesty. You've taken everything and everyone from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ..."*)

### Węzeł `[401]`
Mówca: **Leona Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Leona bowed and stepped back."*)

### Węzeł `[402]`
Mówca: **Narrator**
> "Tears streamed down her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Leona Sazon: ""Thank you, Your Majesty. And Manus, I am so sorry.""*)

### Węzeł `[403]`
Mówca: **Leona Sazon**
> ""Thank you, Your Majesty. And Manus, I am so sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Jump to: [Smirk_Hub]"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "Jump to: [Smirk_Hub]"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Shooting nobles at their mother's birthd..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Angelica’s body crumped lifelessly to the floor, blood po..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseToras");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseToras");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Executed == true"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseToras");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Manus Sazon: ""There. It's done. Now please... don't hurt my family.""*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseToras");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
