# Rizia/Turn 10/STRIKE SCENE/INTRO_NONREFORM/INTRO_NONREFORM Conversation

- **ID konwersacji:** `556`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/556_INTRO_NONREFORM_Conversation.md`
- **Liczba węzłów dialogowych:** 338
- **Liczba wyborów gracza:** 75

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[67]** Hubertus Toras
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
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
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.Birthday_WarnedAboutCoup`
- `RiziaDLC.DiscussedFestiburu`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Manus_DiesInWar`
- `RiziaDLC.Manus_SendToWar`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLCIsolated.BirthdayGathering_OnlyLeona`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.BirthdayGathering_OnlyLeona`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[4]`
- Węzeł `[224]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[25]`
- Węzeł `[323]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[25]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""Now, if you'll excuse me for just a moment, I'd like to invite the heads of all t..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "There was a brief pause, followe..." |
| `[5]` | **""There is something I've wanted to address. A matter of loyalty… and betrayal.""** | `[4]` **Narrator**: "Once inside, I closed the door, ..." | `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false` | *Brak zmian stanu* | `[105]` **Narrator**: "They looked at one another, seem..." |
| `[8]` | **""You’re only loyal when you fear the consequences of defiance.""** | `[7]` **Taddeus Azaro**: ""I don't like the sound of any o..."<br>`[44]` **Carlos Robles Azaro**: ""With all due respect, I don't l..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[10]` **Manus Sazon**: "“Your Majesty, you must be aware..."<br>`[41]` **Leona Sazon**: ""I'm afraid I don’t understand, ..."<br>*(oraz 2 innych odgałęzień)* |
| `[9]` | **"“Loyalty is something one demonstrates not only in words but in action.”"** | `[7]` **Taddeus Azaro**: ""I don't like the sound of any o..."<br>`[44]` **Carlos Robles Azaro**: ""With all due respect, I don't l..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[10]` **Manus Sazon**: "“Your Majesty, you must be aware..."<br>`[41]` **Leona Sazon**: ""I'm afraid I don’t understand, ..."<br>*(oraz 2 innych odgałęzień)* |
| `[12]` | **"“That’s rich, coming from you.”"** | `[11]` **Angelica Sazon**: "“Nor do we carry the ambition to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "Angelica cast her gaze downward,..." |
| `[13]` | **""Trust a wolf to act like a wolf.""** | `[11]` **Angelica Sazon**: "“Nor do we carry the ambition to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Narrator**: "Angelica’s gaze briefly landed o..." |
| `[17]` | **""As the only saying goes... ‘Blood may be thicker than water, but it can still tur..."** | `[16]` **Hugo Toras**: "“Are you honestly implying that ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[18]` **Rico Toras**: "“Well, it’s official, cousin. Yo..."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[21]` | **""Now, it's time to unveil the renovated trophy room. First to see it will be our g..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "There was a brief pause, followe..." |
| `[22]` | **""There is something I've wanted to address. A matter of loyalty… and betrayal.""** | `[320]` **Leona Sazon**: ""I am at your service, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "Leona's face was clouded with co..." |
| `[29]` | **""No, nothing of the sort. Please calm down.""** | `[16]` **Hugo Toras**: "“Are you honestly implying that ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[18]` **Rico Toras**: "“Well, it’s official, cousin. Yo..."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[30]` | **""You’re wasting time with questions you already know the answers to.""** | `[16]` **Hugo Toras**: "“Are you honestly implying that ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[18]` **Rico Toras**: "“Well, it’s official, cousin. Yo..."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[31]` | **""It's about what it's always about, Hugo. Who controls the throne.""** | `[16]` **Hugo Toras**: "“Are you honestly implying that ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[18]` **Rico Toras**: "“Well, it’s official, cousin. Yo..."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[32]` | **""Mistake or not, it's clear that your loyalty wavers when it’s convenient for you.""** | `[7]` **Taddeus Azaro**: ""I don't like the sound of any o..."<br>`[44]` **Carlos Robles Azaro**: ""With all due respect, I don't l..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[10]` **Manus Sazon**: "“Your Majesty, you must be aware..."<br>`[41]` **Leona Sazon**: ""I'm afraid I don’t understand, ..."<br>*(oraz 2 innych odgałęzień)* |
| `[33]` | **""Don't play dumb. I know exactly what you've been planning.""** | `[7]` **Taddeus Azaro**: ""I don't like the sound of any o..."<br>`[44]` **Carlos Robles Azaro**: ""With all due respect, I don't l..." | `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true` | `--;` | `[10]` **Manus Sazon**: "“Your Majesty, you must be aware..."<br>`[41]` **Leona Sazon**: ""I'm afraid I don’t understand, ..."<br>*(oraz 2 innych odgałęzień)* |
| `[34]` | **""Alright. Which of you was the first to doubt me. Who didn't believe?""** | `[4]` **Narrator**: "Once inside, I closed the door, ..." | `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false` | *Brak zmian stanu* | `[105]` **Narrator**: "They looked at one another, seem..." |
| `[35]` | **""I didn't want it to come to this, but, alas, here we are.""** | `[4]` **Narrator**: "Once inside, I closed the door, ..." | `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false` | *Brak zmian stanu* | `[94]` **Narrator**: "They looked at one another, seem..." |
| `[36]` | **""If you’ll pardon me, I’d like to pull House Sazon aside for a quick chat.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "There was a brief pause, followe..." |
| `[37]` | **""If I may have a moment, I'd like to speak privately with House Sazon.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "There was a brief pause, followe..." |
| `[38]` | **""I didn't want it to come to this, but here we are.""** | `[320]` **Leona Sazon**: ""I am at your service, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "Leona's face was clouded with co..." |
| `[39]` | **""Don't play coy with me. I know what your family's been up to.""** | `[320]` **Leona Sazon**: ""I am at your service, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "Leona's face was clouded with co..." |
| `[45]` | **""Pardon me, but could I have the leaders of each House step aside with me? I’d app..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "There was a brief pause, followe..." |
| `[46]` | **""Ladies and gentlemen, heads of each House, I ask that you join me in private for ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "There was a brief pause, followe..." |
| `[55]` | **""Are you calling me a liar? Remember whom you're speaking to.""** | `[11]` **Angelica Sazon**: "“Nor do we carry the ambition to..."<br>`[51]` **Leona Sazon**: "“Nor do we bear the ambition to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Angelica Sazon**: ""Of course not, Your Majesty. I ..."<br>`[114]` **Leona Sazon**: ""No. Of course not, Your Majesty..." |
| `[56]` | **"“Loyalty is something one demonstrates not only in words but in action.”"** | `[11]` **Angelica Sazon**: "“Nor do we carry the ambition to..."<br>`[51]` **Leona Sazon**: "“Nor do we bear the ambition to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Leona's gaze briefly landed on t..." |
| `[57]` | **""Trust a wolf to act like a wolf.""** | `[51]` **Leona Sazon**: "“Nor do we bear the ambition to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Leona's gaze briefly landed on t..." |
| `[66]` | **""Your loyalty falters when it’s convenient for you.""** | `[138]` **Rico Toras**: ""Exactly. We are all family here..."<br>`[137]` **Hubertus Toras**: ""We've always done everything we..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false` | `--;`<br>`--;` | `[15]` **Hugo Toras**: "“Really, Romus? Please have some..."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[68]` | **""Enough with the pleasantries. The leaders of each House, come with me. I need a w..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "There was a brief pause, followe..." |
| `[77]` | **""I’ll update you later when the time is right.""** | `[75]` **Estela Toras**: ""It seems I'm not invited either..."<br>`[104]` **Estela Toras**: ""So I'm not invited, then.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Estela Toras**: ""How convenient. I’ll just wait ..." |
| `[79]` | **""Nothing to concern yourself over, dear. I need you to stay here and entertain you..."** | `[78]` **Vina Toras**: ""Is something wrong, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "A flash of disappointment crosse..." |
| `[80]` | **""You’re not missing anything you'd want to see, believe me.""** | `[75]` **Estela Toras**: ""It seems I'm not invited either..."<br>`[104]` **Estela Toras**: ""So I'm not invited, then.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Estela Toras**: ""If you say so, but that sounds ..." |
| `[81]` | **""Don't worry. I'll fill you in later.""** | `[78]` **Vina Toras**: ""Is something wrong, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "A flash of disappointment crosse..." |
| `[82]` | **""Wrong? Not in the slightest. Just a little... royal housekeeping -- hardly someth..."** | `[78]` **Vina Toras**: ""Is something wrong, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "A flash of disappointment crosse..." |
| `[84]` | **""Just getting the festiburu hung up. You'll have the first swing after Grandmother..."** | `[78]` **Vina Toras**: ""Is something wrong, Father?"" | `Variable["RiziaDLC.DiscussedFestiburu"] == true` | *Brak zmian stanu* | `[88]` **Narrator**: "Vina tilted her head in annoyance." |
| `[103]` | **""Nothing to concern yourself over, Mother.""** | `[83]` **Estela Toras**: ""What are you up to, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Estela Toras**: ""So I'm not invited, then."" |
| `[119]` | **""Now, I would be much obliged if the Queen Consort and her family would join me in..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A quick silence settled, punctua..." |
| `[120]` | **""If I may have a moment, I'd like to speak privately with House Azaro.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A quick silence settled, punctua..." |
| `[127]` | **""Hugo, there's been a development. Would you and your kin please join me in the tr..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Narrator**: "A brief silence fell, followed b..." |
| `[129]` | **""There is something I've wanted to address. A matter of loyalty… and betrayal.""** | `[128]` **Narrator**: "Hugo, Rico, and Hubertus all eye..."<br>`[146]` **Narrator**: "Hugo and Hubertus both eyed me c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "They looked at one another, seem..." |
| `[132]` | **"“Silence!”"** | `[131]` **Hugo Toras**: "“A good one, Your Majesty. You r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Narrator**: "They went quiet." |
| `[133]` | **"“For once, I’m not joking.”"** | `[131]` **Hugo Toras**: "“A good one, Your Majesty. You r..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[135]` **Narrator**: "They went quiet." |
| `[134]` | **"“You dare laugh at your king?”"** | `[131]` **Hugo Toras**: "“A good one, Your Majesty. You r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Narrator**: "They went quiet." |
| `[139]` | **""'Family? That's rich. Oh, I wish you could see the look on your faces right now.""** | `[138]` **Rico Toras**: ""Exactly. We are all family here..."<br>`[137]` **Hubertus Toras**: ""We've always done everything we..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false` | `--;`<br>`--;` | `[15]` **Hugo Toras**: "“Really, Romus? Please have some..."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[140]` | **""Honestly, Rico, you are nothing but a nuisance to the Crown. And that stops today.""** | `[138]` **Rico Toras**: ""Exactly. We are all family here..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[15]` **Hugo Toras**: "“Really, Romus? Please have some..."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[141]` | **"“Loyalty is something one demonstrates not only in words but in action.”"** | `[138]` **Rico Toras**: ""Exactly. We are all family here..."<br>`[137]` **Hubertus Toras**: ""We've always done everything we..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false` | `--;`<br>`--;` | `[15]` **Hugo Toras**: "“Really, Romus? Please have some..."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[142]` | **""If you'll excuse me, I'd like to speak privately with the men of House Toras for ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Narrator**: "A brief silence fell, followed b..." |
| `[147]` | **""Let's get to the point. Which of you was the first to doubt me. Who didn't believe?""** | `[128]` **Narrator**: "Hugo, Rico, and Hubertus all eye..."<br>`[146]` **Narrator**: "Hugo and Hubertus both eyed me c..." | `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true` | *Brak zmian stanu* | `[130]` **Narrator**: "They looked at one another, seem..." |
| `[148]` | **""I had hoped it wouldn't come to this, but here we are.""** | `[128]` **Narrator**: "Hugo, Rico, and Hubertus all eye..."<br>`[146]` **Narrator**: "Hugo and Hubertus both eyed me c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "They looked at one another, seem..." |
| `[149]` | **""Alright, enough with pleasantries. House Azaro, come with me. I need a word with ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A quick silence settled, punctua..." |
| `[153]` | **""Alright, enough with pleasantries. House Sazon, come with me. I need a word with ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "There was a brief pause, followe..." |
| `[157]` | **""Alright, enough with pleasantries. Sons of Valenqiris, come with me. I need a wor..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Narrator**: "A brief silence fell, followed b..." |
| `[162]` | **""Enjoy your birthday, Mother.""** | `[75]` **Estela Toras**: ""It seems I'm not invited either..."<br>`[104]` **Estela Toras**: ""So I'm not invited, then.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Estela Toras**: ""How thoughtful of you, though I..." |
| `[164]` | **""Just getting the festiburu hung up. You'll have the first swing, of course.""** | `[83]` **Estela Toras**: ""What are you up to, Romus?"" | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[176]` **Estela Toras**: ""Ah, so that's your way of telli..." |
| `[165]` | **""Up to? Nothing in the slightest. Just a little... royal housekeeping.""** | `[83]` **Estela Toras**: ""What are you up to, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Estela Toras**: ""I see. So I'm not invited, then."" |
| `[174]` | **""I’m simply handling something that requires my immediate attention, that's all.""** | `[83]` **Estela Toras**: ""What are you up to, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Estela Toras**: ""How conveniently cryptic. So I'..." |
| `[188]` | **""There's been a development. I must talk to the esteemed representatives from ever..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Narrator**: "A brief silence fell, followed b..." |
| `[189]` | **""If you’ll pardon me, I’d like to pull House Azaro and Toras aside for a quick chat.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Narrator**: "A brief silence fell, followed b..." |
| `[190]` | **""If I may have a moment, I'd like to speak privately with House Azaro, as well as ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Narrator**: "A brief silence fell, followed b..." |
| `[191]` | **""Alright, enough with pleasantries. House Azaro and the men of House Toras, come w..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Narrator**: "A brief silence fell, followed b..." |
| `[197]` | **""There's been a development. I must talk to the esteemed guests from every noble h..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Narrator**: "A brief silence fell, followed b..." |
| `[198]` | **""Now, it's time to unveil the renovated trophy room. First to see it will be our g..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Narrator**: "A brief silence fell, followed b..." |
| `[199]` | **""If I may have a moment, I'd like to speak privately with House Azaro and Sazon.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Narrator**: "A brief silence fell, followed b..." |
| `[200]` | **""Alright, enough with pleasantries. House Azaro and House Sazon, come with me. I n..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Narrator**: "A brief silence fell, followed b..." |
| `[211]` | **""There's been a development. I must speak to the representatives from the non-Azar..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Narrator**: "A brief silence fell, followed b..." |
| `[212]` | **""If you’ll pardon me, I’d like to pull House Sazon aside for a quick chat, as well..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Narrator**: "A brief silence fell, followed b..." |
| `[213]` | **""If I may have a moment, I'd like to speak privately with House Sazon and the men ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Narrator**: "A brief silence fell, followed b..." |
| `[214]` | **""Alright, enough with pleasantries. House Sazon and House Toras, come with me. I n..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Narrator**: "A brief silence fell, followed b..." |
| `[222]` | **""I had a whole speech prepared about the importance of this day. But now that it's..."** | `[128]` **Narrator**: "Hugo, Rico, and Hubertus all eye..."<br>`[146]` **Narrator**: "Hugo and Hubertus both eyed me c..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false` | *Brak zmian stanu* | `[223]` **Narrator**: "They looked at one another, seem..." |
| `[277]` | **""It is my duty to report that there's been an urgent development in the war. House..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A quick silence settled, punctua..." |
| `[278]` | **""Now, if you'll excuse me for just a moment, I'd like to invite House Azaro to joi..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A quick silence settled, punctua..." |
| `[283]` | **""All will be revealed in time. Just come with me.""** | `[282]` **Lucita Azaro**: ""What's this about, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Lucita Azaro**: ""All right..."" |
| `[284]` | **""Nothing major. We'll be back out in a few minutes.""** | `[282]` **Lucita Azaro**: ""What's this about, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Lucita Azaro**: ""All right..."" |
| `[285]` | **""Whatever happens next, remember that I love you.""** | `[282]` **Lucita Azaro**: ""What's this about, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Lucita Azaro**: ""I don't like the sound of that..."" |
| `[286]` | **""It's a special surprise. I can't spoil it yet.""** | `[282]` **Lucita Azaro**: ""What's this about, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Lucita Azaro**: ""All right..."" |
| `[321]` | **""I'd like to propose a toast, that's all." [Skip Speech and Attack]"** | `[320]` **Leona Sazon**: ""I am at your service, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Leona Sazon**: ""Oh. Certainly..."" |
| `[337]` | **"“I wish I were joking.""** | `[131]` **Hugo Toras**: "“A good one, Your Majesty. You r..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[135]` **Narrator**: "They went quiet." |

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
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Once inside, I closed the door, leaving the celebrations ..."*)

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, if you'll excuse me for just a moment, I'd like to invite the heads of all the Houses to join me privately for a brief discussion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "There was a brief pause, followed by a subtle exchange of..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Once inside, I closed the door, leaving the celebrations behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == fal..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is something I've wanted to address. A matter of loyalty… and betrayal.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "They looked at one another, seemingly confused."*)

### Węzeł `[6]`
Mówca: **Lucita Azaro**
> ""I'd go so far as to say that we've been *extraordinarily* loyal. Every effort has been made to support you and uphold our oaths.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""I don't like the sound of any of this. What are you implying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""Mistake or not, it's clear that your loyalty wavers when..."*)
  - -> `[9]` (*Player_Romus: "“Loyalty is something one demonstrates not only in words ..."*)
  - -> `[8]` (*Player_Romus: ""You’re only loyal when you fear the consequences of defi..."*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You’re only loyal when you fear the consequences of defiance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[44]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Loyalty is something one demonstrates not only in words but in action.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[44]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> "“Your Majesty, you must be aware that we are not the same Sazons who once sought to overthrow your father’s rule.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[11]`
Mówca: **Angelica Sazon**
> "“Nor do we carry the ambition to repeat such actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Are you calling me a liar? Remember whom you're speaking..."*)
  - -> `[13]` (*Player_Romus: ""Trust a wolf to act like a wolf.""*)
  - -> `[12]` (*Player_Romus: "“That’s rich, coming from you.”"*)
  - -> `[56]` (*Player_Romus: "“Loyalty is something one demonstrates not only in words ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“That’s rich, coming from you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Angelica cast her gaze downward, hands folding neatly in ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust a wolf to act like a wolf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Angelica’s gaze briefly landed on the stuffed wolf nearby."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Angelica’s gaze briefly landed on the stuffed wolf nearby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[15]`
Mówca: **Hugo Toras**
> "“Really, Romus? Please have some reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Hugo Toras: "“Are you honestly implying that we, your own family, woul..."*)

### Węzeł `[16]`
Mówca: **Hugo Toras**
> "“Are you honestly implying that we, your own family, would betray you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""You’re wasting time with questions you already know the ..."*)
  - -> `[29]` (*Player_Romus: ""No, nothing of the sort. Please calm down.""*)
  - -> `[17]` (*Player_Romus: ""As the only saying goes... ‘Blood may be thicker than wa..."*)
  - -> `[31]` (*Player_Romus: ""It's about what it's always about, Hugo. Who controls th..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As the only saying goes... ‘Blood may be thicker than water, but it can still turn cold.’”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[18]`
Mówca: **Rico Toras**
> "“Well, it’s official, cousin. You've certifiably lost it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Hugo snapped a harsh look in his direction."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Hugo snapped a harsh look in his direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: "“Let His Majesty speak.""*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> "“Let His Majesty speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, it's time to unveil the renovated trophy room. First to see it will be our guests from Houses Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "There was a brief pause, followed by an exchange of glances."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is something I've wanted to address. A matter of loyalty… and betrayal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Leona's face was clouded with confusion."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Carlos Robles Azaro: ""With all due respect, I don't like where this is going.""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Taddeus Azaro: ""I don't like the sound of any of this. What are you impl..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == false)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucita Azaro: ""I'd go so far as to say that we've been *extraordinarily..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucita Azaro: ""Look at me, Romus. Have I ever been anything but loyal? ..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, nothing of the sort. Please calm down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You’re wasting time with questions you already know the answers to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's about what it's always about, Hugo. Who controls the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mistake or not, it's clear that your loyalty wavers when it’s convenient for you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[44]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't play dumb. I know exactly what you've been planning.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[44]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. Which of you was the first to doubt me. Who didn't believe?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "They looked at one another, seemingly confused."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't want it to come to this, but, alas, here we are.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "They looked at one another, seemingly confused."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you’ll pardon me, I’d like to pull House Sazon aside for a quick chat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "There was a brief pause, followed by an exchange of glances."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I may have a moment, I'd like to speak privately with House Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "There was a brief pause, followed by an exchange of glances."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't want it to come to this, but here we are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Leona's face was clouded with confusion."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't play coy with me. I know what your family's been up to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Leona's face was clouded with confusion."*)

### Węzeł `[40]`
Mówca: **Lucita Azaro**
> ""Look at me, Romus. Have I ever been anything but loyal? Everything I've done has been for you and the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[41]`
Mówca: **Leona Sazon**
> ""I'm afraid I don’t understand, Your Majesty. House Sazon has shown nothing but loyalty to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SendToWar == true"*)

### Węzeł `[42]`
Mówca: **Leona Sazon**
> ""Well -- there's the unfortunate matter of Manus, of course. But the rest of us are not like him at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Leona Sazon: ""My family and I are not the same Sazons who once sought ..."*)

### Węzeł `[43]`
Mówca: **Leona Sazon**
> ""My family and I are not the same Sazons who once sought to overthrow your father's rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[44]`
Mówca: **Carlos Robles Azaro**
> ""With all due respect, I don't like where this is going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""Mistake or not, it's clear that your loyalty wavers when..."*)
  - -> `[9]` (*Player_Romus: "“Loyalty is something one demonstrates not only in words ..."*)
  - -> `[8]` (*Player_Romus: ""You’re only loyal when you fear the consequences of defi..."*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pardon me, but could I have the leaders of each House step aside with me? I’d appreciate a moment of your time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "There was a brief pause, followed by a subtle exchange of..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ladies and gentlemen, heads of each House, I ask that you join me in private for a brief discussion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "There was a brief pause, followed by a subtle exchange of..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Leona's face was clouded with confusion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Leona Sazon: ""I'm afraid I don’t understand, Your Majesty. House Sazon..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: "“Your Majesty, you must be aware that we are not the same..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Leona Sazon: ""I'm afraid I don’t understand, Your Majesty. House Sazon..."*)

### Węzeł `[51]`
Mówca: **Leona Sazon**
> "“Nor do we bear the ambition to repeat such actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Are you calling me a liar? Remember whom you're speaking..."*)
  - -> `[56]` (*Player_Romus: "“Loyalty is something one demonstrates not only in words ..."*)
  - -> `[57]` (*Player_Romus: ""Trust a wolf to act like a wolf.""*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Angelica Sazon: "“Nor do we carry the ambition to repeat such actions.”"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Leona Sazon: "“Nor do we bear the ambition to repeat such actions.”"*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you calling me a liar? Remember whom you're speaking to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Angelica Sazon), `[51]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Loyalty is something one demonstrates not only in words but in action.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Angelica Sazon), `[51]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Leona's gaze briefly landed on the stuffed wolf nearby."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust a wolf to act like a wolf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Leona's gaze briefly landed on the stuffed wolf nearby."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Leona's gaze briefly landed on the stuffed wolf nearby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "// STRIKE ALL"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "There was a brief pause, followed by a subtle exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true )"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Rico Toras: "“Well, it’s official, cousin. You've certifiably lost it.”"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your loyalty falters when it’s convenient for you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Rico Toras), `[137]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with the pleasantries. The leaders of each House, come with me. I need a word with you. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "There was a brief pause, followed by a subtle exchange of..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""Enough with the pleasantries. The leaders of each House,..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Vina Toras: ""Is something wrong, Father?""*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Estela Toras: ""What are you up to, Romus?""*)

### Węzeł `[75]`
Mówca: **Estela Toras**
> ""It seems I'm not invited either, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[77]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[162]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)

### Węzeł `[76]`
Mówca: **Narrator**
> "A flash of disappointment crossed Vina's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Estela Toras: ""It seems I'm not invited either, then.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’ll update you later when the time is right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Estela Toras), `[104]` (Estela Toras), `[175]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Estela Toras: ""How convenient. I’ll just wait here, then, for your 'rig..."*)

### Węzeł `[78]`
Mówca: **Vina Toras**
> ""Is something wrong, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""Don't worry. I'll fill you in later.""*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedFestiburu == true"*)
  - -> `[82]` (*Player_Romus: ""Wrong? Not in the slightest. Just a little... royal hous..."*)
  - -> `[79]` (*Player_Romus: ""Nothing to concern yourself over, dear. I need you to st..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing to concern yourself over, dear. I need you to stay here and entertain your grandmother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "A flash of disappointment crossed Vina's face."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You’re not missing anything you'd want to see, believe me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Estela Toras), `[104]` (Estela Toras), `[175]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Estela Toras: ""If you say so, but that sounds rather ominous.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'll fill you in later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "A flash of disappointment crossed Vina's face."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wrong? Not in the slightest. Just a little... royal housekeeping -- hardly something you need to worry about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "A flash of disappointment crossed Vina's face."*)

### Węzeł `[83]`
Mówca: **Estela Toras**
> ""What are you up to, Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""Nothing to concern yourself over, Mother.""*)
  - -> `[165]` (*Player_Romus: ""Up to? Nothing in the slightest. Just a little... royal ..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[174]` (*Player_Romus: ""I’m simply handling something that requires my immediate..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just getting the festiburu hung up. You'll have the first swing after Grandmother, of course.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.DiscussedFestiburu"] == true`
- **Kontekst wejściowy (poprzednik):** `[78]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Vina tilted her head in annoyance."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedFestiburu == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedFestiburu == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedFestiburu == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedFestiburu == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedFestiburu"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""Just getting the festiburu hung up. You'll have the firs..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedFestiburu == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedFestiburu"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
Mówca: **Narrator**
> "Vina tilted her head in annoyance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Vina Toras: ""So I'm not invited. Got it.""*)

### Węzeł `[89]`
Mówca: **Vina Toras**
> ""So I'm not invited. Got it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Estela Toras: ""It seems I'm not invited either, then.""*)

### Węzeł `[90]`
Mówca: **Taddeus Azaro**
> ""Has our house done something wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[94]`
Mówca: **Narrator**
> "They looked at one another, seemingly confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[95]`
Mówca: **Taddeus Azaro**
> ""Come to what, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Taddeus Azaro: ""Has our house done something wrong?""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Taddeus Azaro: ""Come to what, Your Majesty?""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[99]`
Mówca: **Estela Toras**
> ""If you say so, but that sounds rather ominous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I kissed Mother on the cheek before stepping away."*)

### Węzeł `[100]`
Mówca: **Estela Toras**
> ""How convenient. I’ll just wait here, then, for your 'right' moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I kissed Mother on the cheek before stepping away."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "I kissed Mother on the cheek before stepping away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `VinaEstelaStayPut_HUb`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing to concern yourself over, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Estela Toras: ""So I'm not invited, then.""*)

### Węzeł `[104]`
Mówca: **Estela Toras**
> ""So I'm not invited, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[77]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[162]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)

### Węzeł `[105]`
Mówca: **Narrator**
> "They looked at one another, seemingly confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[106]`
Mówca: **Taddeus Azaro**
> ""I don’t understand, Your Majesty. House Azaro has always believed in you. Our loyalty has never been in doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Angelica Sazon: ""Of course not, Your Majesty. I wouldn't dare.""*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Leona Sazon: ""No. Of course not, Your Majesty. I wouldn't dare.""*)

### Węzeł `[110]`
Mówca: **Angelica Sazon**
> ""Of course not, Your Majesty. I wouldn't dare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Taddeus Azaro: ""I don’t understand, Your Majesty. House Azaro has always..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[114]`
Mówca: **Leona Sazon**
> ""No. Of course not, Your Majesty. I wouldn't dare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: "“Really, Romus? Please have some reason.”"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Angelica cast her gaze downward, hands folding neatly in front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, I would be much obliged if the Queen Consort and her family would join me in the trophy room.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A quick silence settled, punctuated by a subtle exchange ..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I may have a moment, I'd like to speak privately with House Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A quick silence settled, punctuated by a subtle exchange ..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == fal..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "// STRIKE TORAS"*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo, there's been a development. Would you and your kin please join me in the trophy room?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Hugo, Rico, and Hubertus all eyed me curiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[129]` (*Player_Romus: ""There is something I've wanted to address. A matter of l..."*)
  - -> `[148]` (*Player_Romus: ""I had hoped it wouldn't come to this, but here we are.""*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Romus: ""I had a whole speech prepared a..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is something I've wanted to address. A matter of loyalty… and betrayal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator), `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "They looked at one another, seemingly confused, before br..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "They looked at one another, seemingly confused, before breaking out into laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: "“A good one, Your Majesty. You really had me going there!”"*)

### Węzeł `[131]`
Mówca: **Hugo Toras**
> "“A good one, Your Majesty. You really had me going there!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: "“You dare laugh at your king?”"*)
  - -> `[132]` (*Player_Romus: "“Silence!”"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Silence!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "They went quiet."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“For once, I’m not joking.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[131]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "They went quiet."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You dare laugh at your king?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "They went quiet."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "They went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Hugo Toras: ""You’re serious? Your Majesty, it goes without saying tha..."*)

### Węzeł `[136]`
Mówca: **Hugo Toras**
> ""You’re serious? Your Majesty, it goes without saying that House Toras has been nothing but loyal to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Hubertus Toras: ""We've always done everything we can to support the Royal..."*)

### Węzeł `[137]`
Mówca: **Hubertus Toras**
> ""We've always done everything we can to support the Royal Family and uphold our oaths.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[138]`
Mówca: **Rico Toras**
> ""Exactly. We are all family here, cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""Your loyalty falters when it’s convenient for you.""*)
  - -> `[140]` (*Player_Romus: ""Honestly, Rico, you are nothing but a nuisance to the Cr..."*)
  - -> `[139]` (*Player_Romus: ""'Family? That's rich. Oh, I wish you could see the look ..."*)
  - -> `[141]` (*Player_Romus: "“Loyalty is something one demonstrates not only in words ..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Family? That's rich. Oh, I wish you could see the look on your faces right now.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Rico Toras), `[137]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honestly, Rico, you are nothing but a nuisance to the Crown. And that stops today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Loyalty is something one demonstrates not only in words but in action.”"
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Rico Toras), `[137]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you'll excuse me, I'd like to speak privately with the men of House Toras for a moment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Hugo, Rico, and Hubertus all eyed me curiously."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Hugo and Hubertus both eyed me curiously."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Hugo and Hubertus both eyed me curiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[129]` (*Player_Romus: ""There is something I've wanted to address. A matter of l..."*)
  - -> `[148]` (*Player_Romus: ""I had hoped it wouldn't come to this, but here we are.""*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Romus: ""I had a whole speech prepared a..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get to the point. Which of you was the first to doubt me. Who didn't believe?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator), `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "They looked at one another, seemingly confused, before br..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had hoped it wouldn't come to this, but here we are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator), `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "They looked at one another, seemingly confused, before br..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, enough with pleasantries. House Azaro, come with me. I need a word with you. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A quick silence settled, punctuated by a subtle exchange ..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player_Romus: ""Alright, enough with pleasantries. House Azaro, come wit..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, enough with pleasantries. House Sazon, come with me. I need a word with you. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "There was a brief pause, followed by an exchange of glances."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""Alright, enough with pleasantries. House Sazon, come wit..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, enough with pleasantries. Sons of Valenqiris, come with me. I need a word with you. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: ""Alright, enough with pleasantries. Sons of Valenqiris, c..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[161]`
Mówca: **Narrator**
> "A brief silence fell, followed by a subtle exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "Jump to: [VinaEstelaStayPut_HUb]"*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enjoy your birthday, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Estela Toras), `[104]` (Estela Toras), `[175]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Estela Toras: ""How thoughtful of you, though I suspect your idea of enj..."*)

### Węzeł `[163]`
Mówca: **Estela Toras**
> ""How thoughtful of you, though I suspect your idea of enjoyment and mine differ greatly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I kissed Mother on the cheek before stepping away."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just getting the festiburu hung up. You'll have the first swing, of course.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[83]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Estela Toras: ""Ah, so that's your way of telling me I'm not invited.""*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Up to? Nothing in the slightest. Just a little... royal housekeeping.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Estela Toras: ""I see. So I'm not invited, then.""*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""Just getting the festiburu hung up. You'll have the firs..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[169]`
Mówca: **Narrator**
> "There was a brief pause, followed by an exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == false && R..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "A quick silence settled, punctuated by a subtle exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Rico Toras: ""Exactly. We are all family here, cousin.""*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""Your loyalty falters when it’s convenient for you.""*)
  - -> `[139]` (*Player_Romus: ""'Family? That's rich. Oh, I wish you could see the look ..."*)
  - -> `[141]` (*Player_Romus: "“Loyalty is something one demonstrates not only in words ..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m simply handling something that requires my immediate attention, that's all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Estela Toras: ""How conveniently cryptic. So I'm not invited, then.""*)

### Węzeł `[175]`
Mówca: **Estela Toras**
> ""How conveniently cryptic. So I'm not invited, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[77]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[162]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)

### Węzeł `[176]`
Mówca: **Estela Toras**
> ""Ah, so that's your way of telling me I'm not invited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[77]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[162]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)

### Węzeł `[177]`
Mówca: **Estela Toras**
> ""I see. So I'm not invited, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[77]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[162]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE ALL`
- **Efekt skryptowy (`userScript`):** `-- STRIKE ALL;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[46]` (*Player_Romus: ""Ladies and gentlemen, heads of each House, I ask that yo..."*)
  - -> `[3]` (*Player_Romus: ""Now, if you'll excuse me for just a moment, I'd like to ..."*)
  - -> `[45]` (*Player_Romus: ""Pardon me, but could I have the leaders of each House st..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE AZARO`
- **Efekt skryptowy (`userScript`):** `-- STRIKE AZARO;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[120]` (*Player_Romus: ""If I may have a moment, I'd like to speak privately with..."*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == fal..."*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == f..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "// STRIKE AZARO"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "// STRIKE AZARO AND TORAS"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "// STRIKE AZARO AND SAZON"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE AZARO AND TORAS`
- **Efekt skryptowy (`userScript`):** `-- STRIKE AZARO AND TORAS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[190]` (*Player_Romus: ""If I may have a moment, I'd like to speak privately with..."*)
  - -> `[188]` (*Player_Romus: ""There's been a development. I must talk to the esteemed ..."*)
  - -> `[189]` (*Player_Romus: ""If you’ll pardon me, I’d like to pull House Azaro and To..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE AZARO AND SAZON`
- **Efekt skryptowy (`userScript`):** `-- STRIKE AZARO AND SAZON;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[199]` (*Player_Romus: ""If I may have a moment, I'd like to speak privately with..."*)
  - -> `[197]` (*Player_Romus: ""There's been a development. I must talk to the esteemed ..."*)
  - -> `[198]` (*Player_Romus: ""Now, it's time to unveil the renovated trophy room. Firs..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's been a development. I must talk to the esteemed representatives from every noble house but Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you’ll pardon me, I’d like to pull House Azaro and Toras aside for a quick chat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I may have a moment, I'd like to speak privately with House Azaro, as well as my uncle and his kin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, enough with pleasantries. House Azaro and the men of House Toras, come with me. I need a word with you. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player_Romus: ""Alright, enough with pleasantries. House Azaro and the m..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
Mówca: **Narrator**
> "A brief silence fell, followed by a subtle exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "Jump to: [VinaEstelaStayPut_HUb]"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [VinaEstelaStayPut_HUb]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "VinaEstelaStayPut_HUb"*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's been a development. I must talk to the esteemed guests from every noble house but Toras.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, it's time to unveil the renovated trophy room. First to see it will be our guests from Houses Sazon and Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I may have a moment, I'd like to speak privately with House Azaro and Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, enough with pleasantries. House Azaro and House Sazon, come with me. I need a word with you. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""Alright, enough with pleasantries. House Azaro and House..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
Mówca: **Narrator**
> "A brief silence fell, followed by a subtle exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE SAZON`
- **Efekt skryptowy (`userScript`):** `-- STRIKE SAZON;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[37]` (*Player_Romus: ""If I may have a moment, I'd like to speak privately with..."*)
  - -> `[21]` (*Player_Romus: ""Now, it's time to unveil the renovated trophy room. Firs..."*)
  - -> `[36]` (*Player_Romus: ""If you’ll pardon me, I’d like to pull House Sazon aside ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == f..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "// STRIKE SAZON"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "// STRIKE SAZON AND TORAS"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE SAZON AND TORAS`
- **Efekt skryptowy (`userScript`):** `-- STRIKE SAZON AND TORAS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[213]` (*Player_Romus: ""If I may have a moment, I'd like to speak privately with..."*)
  - -> `[211]` (*Player_Romus: ""There's been a development. I must speak to the represen..."*)
  - -> `[212]` (*Player_Romus: ""If you’ll pardon me, I’d like to pull House Sazon aside ..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE TORAS`
- **Efekt skryptowy (`userScript`):** `-- STRIKE TORAS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[142]` (*Player_Romus: ""If you'll excuse me, I'd like to speak privately with th..."*)
  - -> `[127]` (*Player_Romus: ""Hugo, there's been a development. Would you and your kin..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's been a development. I must speak to the representatives from the non-Azaro noble houses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you’ll pardon me, I’d like to pull House Sazon aside for a quick chat, as well as my uncle and his kin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I may have a moment, I'd like to speak privately with House Sazon and the men of House Toras.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, enough with pleasantries. House Sazon and House Toras, come with me. I need a word with you. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "A brief silence fell, followed by a subtle exchange of gl..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player_Romus: ""Alright, enough with pleasantries. House Sazon and House..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[218]`
Mówca: **Narrator**
> "A brief silence fell, followed by a subtle exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "Jump to: [VinaEstelaStayPut_HUb]"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [VinaEstelaStayPut_HUb]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "VinaEstelaStayPut_HUb"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""I had a whole speech prepared about the importance of this day. But now that it's here, I propose a simple toast." [Skip Speech and Attack]"]** — Mówca: **Player_Romus**
> ""I had a whole speech prepared about the importance of this day. But now that it's here, I propose a simple toast.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator), `[146]` (Narrator), `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "They looked at one another, seemingly relieved."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "They looked at one another, seemingly relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "Jump to: [RaiseAToast_Hub]"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RaiseAToast_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Player_Romus: ""I had a whole speech prepared abou..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player_Romus: ""I had a whole speech prepared about the importance of th..."*)

### Węzeł `[226]`
Mówca: **Narrator**
> "Several catering staff were already present, moving briskly as they set out refreshments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Once inside, I closed the door, leaving the celebrations ..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_WarnedAboutCoup == true)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""Don't play dumb. I know exactly what you've been planning.""*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_WarnedAboutCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == false && RiziaDLC.BirthdayGathering_Invited_Manus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == false && R..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == false &&..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == false && RiziaDLC.BirthdayGathering_Invited_Manus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Leona Sazon: ""Just me, you mean?""*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == false && RiziaDLC.BirthdayGathering_Invited_Manus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "With a rustling of formalwear, my guests left their seats..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras"); AddConversant("Hubertus Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");
AddConversant("Hubertus Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Angelica Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Angelica Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "AddConversant("Angelica Sazon");"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras"); AddConversant("Hubertus Tora..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Rico To..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Rico Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Rico Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "AddConversant("Rico Toras");"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras"); RemoveConversant("Rico Toras");
RemoveConversant("Hubertus Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Rico Toras");
RemoveConversant("Hubertus Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro");"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro"); RemoveConversant("Luci..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "AddConversant("Carlos Robles Azaro");"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "AddConversant("Leona Sazon");"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Leona Sazon"); RemoveConversant("Angeli..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Leona Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Leona Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Leona Sazon");
RemoveConversant("Angelica Sazon");
RemoveConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Leona Sazon");
RemoveConversant("Angelica Sazon");
RemoveConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""Now, I would be much obliged if the Queen Consort and he..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player_Romus: ""It is my duty to report that there's been an urgent deve..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus: ""Now, if you'll excuse me for just a moment, I'd like to ..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is my duty to report that there's been an urgent development in the war. House Azaro, please join me for a discussion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A quick silence settled, punctuated by a subtle exchange ..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, if you'll excuse me for just a moment, I'd like to invite House Azaro to join me privately for a brief discussion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A quick silence settled, punctuated by a subtle exchange ..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Lucita Azaro: ""What's this about, Romus?""*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "With a rustling of formalwear, my invitees left their sea..."*)

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""What's this about, Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Romus: ""All will be revealed in time. Just come with me.""*)
  - -> `[284]` (*Player_Romus: ""Nothing major. We'll be back out in a few minutes.""*)
  - -> `[285]` (*Player_Romus: ""Whatever happens next, remember that I love you.""*)
  - -> `[286]` (*Player_Romus: ""It's a special surprise. I can't spoil it yet.""*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All will be revealed in time. Just come with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucita Azaro: ""All right...""*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing major. We'll be back out in a few minutes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucita Azaro: ""All right...""*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever happens next, remember that I love you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucita Azaro: ""I don't like the sound of that...""*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a special surprise. I can't spoil it yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucita Azaro: ""All right...""*)

### Węzeł `[287]`
Mówca: **Lucita Azaro**
> ""I don't like the sound of that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Lucita hesitantly rose to her feet and took my hand."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Lucita hesitantly rose to her feet and took my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[289]`
Mówca: **Lucita Azaro**
> ""All right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Lucita hesitantly rose to her feet and took my hand."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "With a rustling of formalwear, my other invitees left their seats and followed us into the trophy room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "Jump to: [Trophy Room Guest Count]"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_WarnedAboutCoup == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""Let's get to the point. Which of you was the first to do..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_WarnedAboutCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[294]`
Mówca: **Narrator**
> "With a rustling of formalwear, my invitees got up and followed me into the trophy room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "Trophy Room Guest Count"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Trophy Room Guest Count`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras"); RemoveConversant("Vina ..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "With a rustling of formalwear, my other invitees left the..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "Her father wheeled himself away from the table and follow..."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "Her father wheeled himself away from the table and followed us into the trophy room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "Jump to: [Trophy Room Guest Count]"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Trophy Room Guest Count]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "Trophy Room Guest Count"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Lucita Azaro: ""What's this about, Romus?""*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "With a rustling of formalwear, my invitees got up and fol..."*)

### Węzeł `[305]`
Mówca: **Leona Sazon**
> ""Just me, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Leona Sazon: ""All right...""*)

### Węzeł `[306]`
Mówca: **Leona Sazon**
> ""All right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "With a rustling of formalwear, she left her seat and foll..."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "With a rustling of formalwear, she left her seat and followed me into the adjoining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_OnlyLeona = true"*)

### Węzeł `[308]`
Mówca: **Narrator**
> "With a rustling of formalwear, my invitees left their seats and followed me into the trophy room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "Jump to: [Trophy Room Guest Count]"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Trophy Room Guest Count]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "Trophy Room Guest Count"*)

### Węzeł `[310]`
Mówca: **Narrator**
> "With a rustling of formalwear, my guests left their seats and followed me into the adjoining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "Jump to: [Trophy Room Guest Count]"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "Several catering staff were already present, moving brisk..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.BirthdayGathering_OnlyLeona = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "Jump to: [Trophy Room Guest Count]"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == fal..."*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == f..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Leona Sazon: ""I am at your service, Your Majesty. What do you need?""*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.BirthdayGathering_OnlyLeona == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.BirthdayGathering_OnlyLeona"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Only Leona`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[320]`
Mówca: **Leona Sazon**
> ""I am at your service, Your Majesty. What do you need?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""Don't play coy with me. I know what your family's been u..."*)
  - -> `[38]` (*Player_Romus: ""I didn't want it to come to this, but here we are.""*)
  - -> `[22]` (*Player_Romus: ""There is something I've wanted to address. A matter of l..."*)
  - -> `[321]` (*Player_Romus: ""I'd like to propose a toast, that's all." [Skip Speech a..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA: ""I'd like to propose a toast, that's all." [Skip Speech and Attack]"]** — Mówca: **Player_Romus**
> ""I'd like to propose a toast, that's all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Leona Sazon: ""Oh. Certainly...""*)

### Węzeł `[322]`
Mówca: **Leona Sazon**
> ""Oh. Certainly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "She took a glass of wine from one of the caterers and rai..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RaiseAToast_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[324]`
Mówca: **Narrator**
> "She took a glass of wine from one of the caterers and raised it in the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "Jump to: [RaiseAToast_Hub]"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SendToWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SendToWar == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_SendToWar == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SendToWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_SendToWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_DiesInWar == true"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_SendToWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_SendToWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Leona Sazon: ""Well -- there's the unfortunate matter of Manus, of cour..."*)

### Węzeł `[328]`
Mówca: **Leona Sazon**
> ""As we speak, our heir is fighting to reclaim Pales for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Leona Sazon: ""My family and I are not the same Sazons who once sought ..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_DiesInWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_DiesInWar == true"*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_DiesInWar == true)"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_DiesInWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_DiesInWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Leona Sazon: ""Need I remind you that our heir died for the Crown?""*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_DiesInWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_DiesInWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Leona Sazon: ""As we speak, our heir is fighting to reclaim Pales for y..."*)

### Węzeł `[332]`
Mówca: **Leona Sazon**
> ""Need I remind you that our heir died for the Crown?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Leona Sazon: ""My family and I are not the same Sazons who once sought ..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Alright. Which of you was the first to doubt me. Who did..."*)
  - -> `[5]` (*Player_Romus: ""There is something I've wanted to address. A matter of l..."*)
  - -> `[35]` (*Player_Romus: ""I didn't want it to come to this, but, alas, here we are.""*)
  - -> `[222]` (*Player_Romus: ""I had a whole speech prepared about the importance of th..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: "“For once, I’m not joking.”"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: "“I wish I were joking.""*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I wish I were joking.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[131]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "They went quiet."*)
