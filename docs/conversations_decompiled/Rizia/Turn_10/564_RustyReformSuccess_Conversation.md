# Rizia/Turn 10/STRIKE SCENE/RustyReformSuccess/RustyReformSuccess Conversation

- **ID konwersacji:** `564`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/564_RustyReformSuccess_Conversation.md`
- **Liczba węzłów dialogowych:** 589
- **Liczba wyborów gracza:** 100

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[67]** Hubertus Toras
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[89]** Russello Montoro
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
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
- `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB`
- `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Promised_Succession_Son_RespectTradition`
- `RiziaDLC.Reform_Promise_MilitaryUntouched`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave`
- `RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith`
- `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned`
- `RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports`
- `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned`
- `RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports`
- `RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned`
- `RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports`
- `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras`
- `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Angelica_Arrested`
- `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder`
- `RiziaDLC.Carlos_Arrested`
- `RiziaDLC.Hubertus_Arrested`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Leona_Arrested`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave`
- `RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith`
- `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras`
- `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[195]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **""If you value your lives, you'll sign these papers without hesitation.""** | `[9]` **Narrator**: "One of the men approached the ta..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[44]` **Narrator**: "The armed men pressed their rifl..."<br>`[38]` **Narrator**: "The armed men pressed their rifl..." |
| `[14]` | **""Well? What are you waiting for?""** | `[9]` **Narrator**: "One of the men approached the ta..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[44]` **Narrator**: "The armed men pressed their rifl..."<br>`[38]` **Narrator**: "The armed men pressed their rifl..." |
| `[15]` | **""Sign the papers, and I promise your concerns will still be heard. My only wish is..."** | `[9]` **Narrator**: "One of the men approached the ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Hugo Toras**: ""Please explain what exactly is ..."<br>`[23]` **Taddeus Azaro**: ""Doesn't seem that peaceful to me."" |
| `[16]` | **""You have my sincerest apologies. I never wanted it to come to this.""** | `[9]` **Narrator**: "One of the men approached the ta..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[44]` **Narrator**: "The armed men pressed their rifl..."<br>`[38]` **Narrator**: "The armed men pressed their rifl..." |
| `[17]` | **""I told you there wasn't way out of this. I can no longer stand by and allow the p..."** | `[9]` **Narrator**: "One of the men approached the ta..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[44]` **Narrator**: "The armed men pressed their rifl..."<br>`[38]` **Narrator**: "The armed men pressed their rifl..." |
| `[48]` | **""Just sign the papers, Hugo.""** | `[33]` **Hugo Toras**: ""Romus -- Your Majesty. This has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "I turned to the others." |
| `[49]` | **""This doesn't concern you.""** | `[33]` **Hugo Toras**: ""Romus -- Your Majesty. This has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "I turned to the others." |
| `[50]` | **""I'm not leaving anything to chance.""** | `[33]` **Hugo Toras**: ""Romus -- Your Majesty. This has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "I turned to the others." |
| `[55]` | **""Hey! Get those guns away from my family!""** | `[42]` **Hugo Toras**: ""What do you think you're doing,..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true` | *Brak zmian stanu* | `[65]` **Narrator**: "They lowered their rifles on my ..." |
| `[56]` | **""Just sign it, Hugo. I've got no quarrel with you.""** | `[42]` **Hugo Toras**: ""What do you think you're doing,..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true` | *Brak zmian stanu* | `[78]` **Narrator**: "Hugo took a step forward." |
| `[57]` | **""Lower your guns! Hugo has already agreed to the proposal.""** | `[42]` **Hugo Toras**: ""What do you think you're doing,..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true` | *Brak zmian stanu* | `[65]` **Narrator**: "They lowered their rifles on my ..." |
| `[58]` | **""I'm not leaving anything to chance.""** | `[42]` **Hugo Toras**: ""What do you think you're doing,..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true` | *Brak zmian stanu* | `[78]` **Narrator**: "Hugo took a step forward." |
| `[59]` | **"Ignore him."** | `[33]` **Hugo Toras**: ""Romus -- Your Majesty. This has..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[104]` **Player_Romus_Italic**: "I stared at them in silence."<br>`[100]` **Player_Romus**: ""House Azaro and House Sazon, yo..."<br>*(oraz 5 innych odgałęzień)* |
| `[81]` | **""Hey! Get those guns away from my family!""** | `[42]` **Hugo Toras**: ""What do you think you're doing,..." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false` | *Brak zmian stanu* | `[105]` **Narrator**: "They lowered their rifles on my ..." |
| `[82]` | **""Just sign it, Hugo. And we won't have any problems.""** | `[42]` **Hugo Toras**: ""What do you think you're doing,..." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false` | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""You're making a huge mistake."" |
| `[83]` | **""Lower your guns! Hugo knows better than to resist.""** | `[42]` **Hugo Toras**: ""What do you think you're doing,..." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false` | *Brak zmian stanu* | `[105]` **Narrator**: "They lowered their rifles on my ..." |
| `[84]` | **""I'm not leaving anything to chance.""** | `[42]` **Hugo Toras**: ""What do you think you're doing,..." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false` | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""You're making a huge mistake."" |
| `[95]` | **""While we're at it, let's make it unanimous.""** | `[59]` **Player_Romus_Italic**: "I ignored him and looked at the ..."<br>`[94]` **Narrator**: "I turned to the others." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true`<br>`Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true` | *Brak zmian stanu* | `[43]` **Taddeus Azaro**: ""Is this your idea of democracy,..."<br>`[73]` **Angelica Sazon**: ""Is this how you plan to establi..."<br>*(oraz 1 innych odgałęzień)* |
| `[99]` | **""House Azaro, I am awaiting your signatures.""** | `[59]` **Player_Romus_Italic**: "I ignored him and looked at the ..." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true) == false`<br>`Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true` | *Brak zmian stanu* | `[43]` **Taddeus Azaro**: ""Is this your idea of democracy,..." |
| `[100]` | **""House Azaro and House Sazon, your king commands you to sign the new constitution.""** | `[59]` **Player_Romus_Italic**: "I ignored him and looked at the ..."<br>`[94]` **Narrator**: "I turned to the others." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false` | *Brak zmian stanu* | `[43]` **Taddeus Azaro**: ""Is this your idea of democracy,..."<br>`[73]` **Angelica Sazon**: ""Is this how you plan to establi..."<br>*(oraz 1 innych odgałęzień)* |
| `[101]` | **""House Sazon, I am awaiting your signature.""** | `[59]` **Player_Romus_Italic**: "I ignored him and looked at the ..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true`<br>`Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true` | *Brak zmian stanu* | `[73]` **Angelica Sazon**: ""Is this how you plan to establi..."<br>`[77]` **Manus Sazon**: ""Your Majesty! Please! There's n..."<br>*(oraz 1 innych odgałęzień)* |
| `[102]` | **""We don't have all day.""** | `[59]` **Player_Romus_Italic**: "I ignored him and looked at the ..."<br>`[94]` **Narrator**: "I turned to the others." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false` | *Brak zmian stanu* | `[43]` **Taddeus Azaro**: ""Is this your idea of democracy,..."<br>`[73]` **Angelica Sazon**: ""Is this how you plan to establi..."<br>*(oraz 1 innych odgałęzień)* |
| `[103]` | **""Please cooperate.""** | `[59]` **Player_Romus_Italic**: "I ignored him and looked at the ..."<br>`[94]` **Narrator**: "I turned to the others." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false` | *Brak zmian stanu* | `[43]` **Taddeus Azaro**: ""Is this your idea of democracy,..."<br>`[73]` **Angelica Sazon**: ""Is this how you plan to establi..."<br>*(oraz 1 innych odgałęzień)* |
| `[104]` | **"Wait for them to sign the papers."** | `[59]` **Player_Romus_Italic**: "I ignored him and looked at the ..."<br>`[94]` **Narrator**: "I turned to the others." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false` | *Brak zmian stanu* | `[43]` **Taddeus Azaro**: ""Is this your idea of democracy,..."<br>`[73]` **Angelica Sazon**: ""Is this how you plan to establi..."<br>*(oraz 1 innych odgałęzień)* |
| `[111]` | **""I told you. Nobody's going anywhere until I get your signatures.""** | `[18]` **Taddeus Azaro**: ""What do you think you're doing!?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Hugo Toras**: ""Romus! Order these men to stand..." |
| `[112]` | **""All that's needed is your signature, General, and there won't be any trouble.""** | `[18]` **Taddeus Azaro**: ""What do you think you're doing!?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Hugo Toras**: ""Romus! Order these men to stand..." |
| `[113]` | **""I'm afraid I cannot let you go until these reforms are implemented.""** | `[18]` **Taddeus Azaro**: ""What do you think you're doing!?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Hugo Toras**: ""Romus! Order these men to stand..." |
| `[114]` | **""You asked for this.""** | `[18]` **Taddeus Azaro**: ""What do you think you're doing!?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Hugo Toras**: ""Romus! Order these men to stand..." |
| `[118]` | **""Not happening.""** | `[115]` **Hugo Toras**: ""Romus! Order these men to stand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Hugo Toras**: ""Why are you doing this?"" |
| `[119]` | **""Please sign and leave, Hugo. I have no quarrels with you.""** | `[115]` **Hugo Toras**: ""Romus! Order these men to stand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Hugo Toras**: ""Why are you doing this?"" |
| `[120]` | **""Hey! Get those guns away from my family!""** | `[115]` **Hugo Toras**: ""Romus! Order these men to stand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "They lowered their rifles on my ..." |
| `[148]` | **""He has nothing to do with this. I organized this on my own.""** | `[139]` **Angelica Sazon**: ""That's bullshit, Manus!""<br>`[243]` **Lucita Azaro**: ""You know that's bullshit, Mr. S..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false` | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""You're making a huge mistake."" |
| `[149]` | **"Manus tried to convince me otherwise, but unlike him, I know that force is the onl..."** | `[139]` **Angelica Sazon**: ""That's bullshit, Manus!""<br>`[243]` **Lucita Azaro**: ""You know that's bullshit, Mr. S..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false` | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""You're making a huge mistake."" |
| `[150]` | **""Keep pushing me and I'll make you regret it. I won't say it again.""** | `[139]` **Angelica Sazon**: ""That's bullshit, Manus!""<br>`[243]` **Lucita Azaro**: ""You know that's bullshit, Mr. S..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false` | *Brak zmian stanu* | `[106]` **Narrator**: "My uncle approached the table an..." |
| `[151]` | **""It seems you don't fully realize the gravity of the situation you're in.""** | `[139]` **Angelica Sazon**: ""That's bullshit, Manus!""<br>`[243]` **Lucita Azaro**: ""You know that's bullshit, Mr. S..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false` | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""You're making a huge mistake."" |
| `[170]` | **""Thank you, Hugo.""** | `[89]` **Hugo Toras**: ""Here's your damn signature.""<br>`[79]` **Narrator**: "He grabbed the pen and signed th..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true` | *Brak zmian stanu* | `[94]` **Narrator**: "I turned to the others." |
| `[171]` | **""You did the right thing, Uncle.""** | `[89]` **Hugo Toras**: ""Here's your damn signature.""<br>`[79]` **Narrator**: "He grabbed the pen and signed th..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true` | *Brak zmian stanu* | `[94]` **Narrator**: "I turned to the others." |
| `[206]` | **"Applaud."** | `[205]` **Narrator**: "The Palantor guards retracted th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Narrator**: "Then, to my surprise, I heard an..." |
| `[207]` | **""Now, that wasn't so difficult, was it?""** | `[205]` **Narrator**: "The Palantor guards retracted th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[437]` **Russello Montoro**: ""Easy as catching fruit flies at..." |
| `[208]` | **""Thank you for your cooperation.""** | `[205]` **Narrator**: "The Palantor guards retracted th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[438]` **Russello Montoro**: ""Yes, you all performed beautifu..." |
| `[209]` | **""This was the only way to truly transform our monarchy. I'm sure you'll understand..."** | `[205]` **Narrator**: "The Palantor guards retracted th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Russello Montoro**: ""You don't have to explain a thi..." |
| `[214]` | **""I think it's best you step out, Rusty. The room is no place for a spectator.""** | `[446]` **Russello Montoro**: ""King Romus and I aren't so diff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Russello Montoro**: ""Very well. Enjoy your moment."" |
| `[215]` | **""As you can see, your men performed with the utmost proficiency and skill.""** | `[446]` **Russello Montoro**: ""King Romus and I aren't so diff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Russello Montoro**: ""I'm glad to hear it."" |
| `[216]` | **""If you're going to pretend you're not here, Rusty, why not do it somewhere else?""** | `[446]` **Russello Montoro**: ""King Romus and I aren't so diff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Russello Montoro**: ""Fine, fine, I'll head out. Don’..." |
| `[238]` | **""She and Leona can leave. We already have House Sazon's full support.""** | `[265]` **Narrator**: "Rusty turned to me." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true`<br>`Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true` | *Brak zmian stanu* | `[272]` **Narrator**: "On Rusty's command, several of t..." |
| `[239]` | **""I'm afraid you'll be placed under strict surveillance until the reforms are imple..."** | `[510]` **Narrator**: "I turned to the others."<br>`[264]` **Narrator**: "Their commander, Antoine, turned..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | `--;` | `[376]` **Narrator**: "Hugo's jaw dropped, his eyes fro..." |
| `[244]` | **""Hello Rusty. We were just wrapping this up.""** | `[446]` **Russello Montoro**: ""King Romus and I aren't so diff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Russello Montoro**: ""I'm glad to hear it."" |
| `[259]` | **""Take Vina to safety! Now!""** | `[8]` **Narrator**: "With quick steps, the armed men ..." | `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true` | *Brak zmian stanu* | `[162]` **Narrator**: "Two of Rusty's men quickly rushe..." |
| `[260]` | **""Please escort my daughter outside.""** | `[8]` **Narrator**: "With quick steps, the armed men ..." | `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true` | *Brak zmian stanu* | `[162]` **Narrator**: "Two of Rusty's men quickly rushe..." |
| `[261]` | **""WHAT THE HELL ARE YOU DOING!? MY DAUGHTER IS IN THE ROOM!""** | `[8]` **Narrator**: "With quick steps, the armed men ..." | `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true` | *Brak zmian stanu* | `[162]` **Narrator**: "Two of Rusty's men quickly rushe..." |
| `[269]` | **""She stays. I can't risk her trying to stop these reforms before they're set in mo..."** | `[265]` **Narrator**: "Rusty turned to me." | `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false`<br>`Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true` | *Brak zmian stanu* | `[383]` **Manus Sazon**: ""No! What are you doing, Your Ma..."<br>`[284]` **Manus Sazon**: ""You promised not to touch my fa..." |
| `[270]` | **""I'm afraid I can't let her go after what happened.""** | `[265]` **Narrator**: "Rusty turned to me." | `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false` | *Brak zmian stanu* | `[383]` **Manus Sazon**: ""No! What are you doing, Your Ma..."<br>`[284]` **Manus Sazon**: ""You promised not to touch my fa..." |
| `[271]` | **""The Sazons may leave.""** | `[265]` **Narrator**: "Rusty turned to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Narrator**: "On Rusty's command, several of t..." |
| `[274]` | **""By the authority vested in me as the King of Rizia, I place you all under arrest.""** | `[510]` **Narrator**: "I turned to the others."<br>`[264]` **Narrator**: "Their commander, Antoine, turned..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder...` | `[376]` **Narrator**: "Hugo's jaw dropped, his eyes fro..." |
| `[275]` | **""Hugo. I know you were the first to step up and give your signature. Tell me. Can ..."** | `[510]` **Narrator**: "I turned to the others."<br>`[264]` **Narrator**: "Their commander, Antoine, turned..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[313]` **Hugo Toras**: ""I will not pretend I understand..." |
| `[281]` | **""I’m afraid you’ll be placed under strict surveillance until the reforms are imple..."** | `[343]` **Taddeus Azaro**: ""I see how it is...""<br>`[532]` **Narrator**: "Only Angelica and Leona Sazon we..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[365]` **Lucita Azaro**: ""This is outrageous! We’re innoc..."<br>`[518]` **Narrator**: "The guards cuffed their wrists a..."<br>*(oraz 1 innych odgałęzień)* |
| `[283]` | **""By the authority vested in me as the King of Rizia, I place you all under arrest.""** | `[343]` **Taddeus Azaro**: ""I see how it is...""<br>`[532]` **Narrator**: "Only Angelica and Leona Sazon we..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder...` | `[360]` **Rico Toras**: ""What!?"" |
| `[297]` | **""No. I'm afraid I can't let the Sazons go. I can't take any chances.""** | `[296]` **Russello Montoro**: ""May I escort her out, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrik...` | `[308]` **Russello Montoro**: ""Oh, I see."" |
| `[298]` | **""Yes. Both she and Leona can leave.""** | `[296]` **Russello Montoro**: ""May I escort her out, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "On Rusty's command, several of t..." |
| `[304]` | **""I expected this to be quick and discreet. Not a firefight breaking out with my da..."** | `[446]` **Russello Montoro**: ""King Romus and I aren't so diff..." | `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true` | *Brak zmian stanu* | `[305]` **Russello Montoro**: ""The Golden Guard are no joke, Y..." |
| `[314]` | **""That's not good enough, Hugo. Does that mean it's currently not aligned?""** | `[450]` **Hugo Toras**: ""But if this is the future you e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Hugo Toras**: ""It is, Your Majesty."" |
| `[315]` | **""Make sure our family stays out of this. You are free to go.""** | `[450]` **Hugo Toras**: ""But if this is the future you e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Hugo Toras**: ""Thank you, Your Majesty."" |
| `[319]` | **""Thank you for saying that. However, I'm still not convinced you, Rico, or Hubertu..."** | `[450]` **Hugo Toras**: ""But if this is the future you e..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true` | *Brak zmian stanu* | `[346]` **Hugo Toras**: ""Please. I give my word that Hou..." |
| `[320]` | **""Thank you. House Toras may leave.""** | `[347]` **Hugo Toras**: ""It is, Your Majesty.""<br>`[450]` **Hugo Toras**: ""But if this is the future you e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Hugo Toras**: ""Thank you, Your Majesty."" |
| `[333]` | **""I'm sorry, Manus. I'm not taking any chances.""** | `[330]` **Lucita Azaro**: ""Promised? So the Sazons were in..."<br>`[331]` **Taddeus Azaro**: ""Promised? The Sazons will pay f..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrik...` | `[340]` **Narrator**: "On Rusty's command, several of t..." |
| `[334]` | **""Don't worry. Nobody's going to get harmed.""** | `[330]` **Lucita Azaro**: ""Promised? So the Sazons were in..."<br>`[331]` **Taddeus Azaro**: ""Promised? The Sazons will pay f..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrik...` | `[340]` **Narrator**: "On Rusty's command, several of t..." |
| `[335]` | **""I did not promise you anything.""** | `[330]` **Lucita Azaro**: ""Promised? So the Sazons were in..."<br>`[331]` **Taddeus Azaro**: ""Promised? The Sazons will pay f..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrik...` | `[340]` **Narrator**: "On Rusty's command, several of t..." |
| `[336]` | **""Rusty. You and Mr. Sazon may leave.""** | `[330]` **Lucita Azaro**: ""Promised? So the Sazons were in..."<br>`[331]` **Taddeus Azaro**: ""Promised? The Sazons will pay f..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrik...` | `[340]` **Narrator**: "On Rusty's command, several of t..." |
| `[337]` | **""Fine. Take your relatives with you.""** | `[330]` **Lucita Azaro**: ""Promised? So the Sazons were in..."<br>`[331]` **Taddeus Azaro**: ""Promised? The Sazons will pay f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Manus Sazon**: ""Thank you, Your Majesty."" |
| `[341]` | **""Hold up, Rico. I didn't say *you* could go.""** | `[324]` **Rico Toras**: ""Your mercy will be remembered, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Rico Toras**: ""Your Majesty, please. Have reas..." |
| `[342]` | **"Let them leave."** | `[324]` **Rico Toras**: ""Your mercy will be remembered, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[530]` **Narrator**: "A few of Rusty's men escorted Hu..." |
| `[345]` | **""I'm sorry, but that's too big of a risk for me to take.""** | `[347]` **Hugo Toras**: ""It is, Your Majesty.""<br>`[450]` **Hugo Toras**: ""But if this is the future you e..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false` | *Brak zmian stanu* | `[346]` **Hugo Toras**: ""Please. I give my word that Hou..." |
| `[348]` | **""Fine. Make sure our family stays out of this. You are free to go.""** | `[347]` **Hugo Toras**: ""It is, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Hugo Toras**: ""Thank you, Your Majesty."" |
| `[350]` | **""Fine. You can leave.""** | `[349]` **Hubertus Toras**: ""His Grace is correct. House Tor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Hugo Toras**: ""Thank you, Your Majesty."" |
| `[351]` | **""I'm not convinced. Nobody is leaving.""** | `[349]` **Hubertus Toras**: ""His Grace is correct. House Tor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Hubertus Toras**: ""But that's preposterous!"" |
| `[355]` | **""I'm afraid you will be placed under strict surveillance until the reforms are imp..."** | `[375]` **Hubertus Toras**: ""But that's preposterous!"" | *Brak (Dostępna bezwarunkowo)* | `--;` | `[354]` **Narrator**: "Hugo's jaw dropped, his eyes fro..." |
| `[356]` | **""With the authority vested upon me as the King of Rizia, I place you all under arr..."** | `[375]` **Hubertus Toras**: ""But that's preposterous!"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder...` | `[354]` **Narrator**: "Hugo's jaw dropped, his eyes fro..." |
| `[408]` | **""I hope you understand. This is just a temporary precaution. You will be free afte..."** | `[364]` **Angelica Sazon**: ""You will regret this.""<br>`[540]` **Narrator**: "I took a look at the Azaros. The..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false` | *Brak zmian stanu* | `[416]` **Narrator**: "Accompanied by the Palantor guar..." |
| `[409]` | **""Don't worry. Nobody will be harmed. I give you my word.""** | `[364]` **Angelica Sazon**: ""You will regret this.""<br>`[540]` **Narrator**: "I took a look at the Azaros. The..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false` | *Brak zmian stanu* | `[416]` **Narrator**: "Accompanied by the Palantor guar..." |
| `[410]` | **""It will be up to the new government to decide your fate.""** | `[364]` **Angelica Sazon**: ""You will regret this.""<br>`[540]` **Narrator**: "I took a look at the Azaros. The..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] == true`<br>`(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false` | *Brak zmian stanu* | `[416]` **Narrator**: "Accompanied by the Palantor guar..." |
| `[414]` | **""It was a mistake to stand in the way of the will of the people.""** | `[364]` **Angelica Sazon**: ""You will regret this.""<br>`[540]` **Narrator**: "I took a look at the Azaros. The..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false` | *Brak zmian stanu* | `[416]` **Narrator**: "Accompanied by the Palantor guar..." |
| `[415]` | **"Don't say anything."** | `[364]` **Angelica Sazon**: ""You will regret this.""<br>`[540]` **Narrator**: "I took a look at the Azaros. The..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false` | *Brak zmian stanu* | `[416]` **Narrator**: "Accompanied by the Palantor guar..." |
| `[417]` | **""Do you really want me to believe that?""** | `[353]` **Rico Toras**: ""I pose no danger to you nor to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_Arr...` | `[421]` **Hugo Toras**: ""Romus... Please."" |
| `[418]` | **""No, cousin. You've made enough trouble for both of us already. I won't risk it.""** | `[353]` **Rico Toras**: ""I pose no danger to you nor to ..."<br>`[522]` **Rico Toras**: ""I'm your son-in-law. You can't ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_Arr...` | `[421]` **Hugo Toras**: ""Romus... Please."" |
| `[419]` | **""Rico is staying. The rest can leave.""** | `[353]` **Rico Toras**: ""I pose no danger to you nor to ..."<br>`[522]` **Rico Toras**: ""I'm your son-in-law. You can't ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_Arr...` | `[421]` **Hugo Toras**: ""Romus... Please."" |
| `[433]` | **""One intelligent individual in this room just avoided execution. As for the rest o..."** | `[89]` **Hugo Toras**: ""Here's your damn signature.""<br>`[79]` **Narrator**: "He grabbed the pen and signed th..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true` | *Brak zmian stanu* | `[94]` **Narrator**: "I turned to the others." |
| `[466]` | **""We still can, my love. Promise not to obstruct the new constitution, and you and ..."** | `[463]` **Lucita Azaro**: ""We would have created the great..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Lucita Azaro**: ""I promise. We will support you,..." |
| `[467]` | **""I have not forgotten. You and your family can walk free.""** | `[464]` **Lucita Azaro**: ""Just let us go, Romus. Don't fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Narrator**: "Her expression was one of gratit..." |
| `[468]` | **""Vina Toras is the future of Rizia.""** | `[463]` **Lucita Azaro**: ""We would have created the great..."<br>`[464]` **Lucita Azaro**: ""Just let us go, Romus. Don't fo..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true` | *Brak zmian stanu* | `[473]` **Narrator**: "Anger flashed in her eyes as she..." |
| `[472]` | **""Rizia's future lies with its people now.""** | `[463]` **Lucita Azaro**: ""We would have created the great..."<br>`[464]` **Lucita Azaro**: ""Just let us go, Romus. Don't fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[475]` **Lucita Azaro**: ""I understand. And I can live wi..." |
| `[478]` | **""Child or no child, you're a security risk. I'm putting you all under arrest.""** | `[474]` **Narrator**: "It was empty. The guard handed m..."<br>`[476]` **Lucita Azaro**: ""But please, think of our child...""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[495]` **Lucita Azaro**: ""No! You can't!"" |
| `[480]` | **""Fine. Leave the room. Now, before I change my mind.""** | `[476]` **Lucita Azaro**: ""But please, think of our child..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Narrator**: "Her expression was one of gratit..." |
| `[481]` | **""I trust you, and I'd never do anything to harm the baby. Go.""** | `[476]` **Lucita Azaro**: ""But please, think of our child...""<br>`[479]` **Lucita Azaro**: ""Just please, think of our child..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Narrator**: "Her expression was one of gratit..." |
| `[484]` | **""That's it. You and your family are going away for a long time.""** | `[474]` **Narrator**: "It was empty. The guard handed m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[495]` **Lucita Azaro**: ""No! You can't!"" |
| `[523]` | **""I never liked you. Neither did Vina.""** | `[522]` **Rico Toras**: ""I'm your son-in-law. You can't ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_Arr...` | `[421]` **Hugo Toras**: ""Romus... Please."" |
| `[570]` | **""Please excuse that unpleasant interruption. Let the party continue!""** | `[569]` **Narrator**: "Upon seeing me, the room went si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[575]` **Narrator**: "The Palantor guards holstered th..." |
| `[571]` | **""I can't apologize enough for what happened. But Rizia will be better for it in th..."** | `[569]` **Narrator**: "Upon seeing me, the room went si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Narrator**: "The Palantor guards holstered th..." |
| `[572]` | **""Out. All of you. This gathering is over.""** | `[569]` **Narrator**: "Upon seeing me, the room went si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Narrator**: "The Palantor guards holstered th..." |
| `[573]` | **""Happy birthday, Mother.""** | `[569]` **Narrator**: "Upon seeing me, the room went si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[575]` **Narrator**: "The Palantor guards holstered th..." |
| `[583]` | **""If you're looking for gratitude, you won’t get it from me.""** | `[89]` **Hugo Toras**: ""Here's your damn signature.""<br>`[79]` **Narrator**: "He grabbed the pen and signed th..." | `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true` | *Brak zmian stanu* | `[94]` **Narrator**: "I turned to the others." |

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
  - -> `[3]` (*Narrator: "The sound of cracking glass rang through the room as the ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "The sound of cracking glass rang through the room as the skylight above shattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "With ruthless efficiency, the men of Palantor Security Solutions descended on ropes, landing with a series of solid thuds. They moved like clockwork."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""Captain Gordion! Apprehend these men immediately!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The guards, unprepared for the ambush, were overwhelmed. Shots rang out, and two of them crumpled to the floor, dead before they could react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Titus, wielding his sidearm, managed to take down an operative before jumping behind a serving trolley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Titus Gordion: ""SUPPRESSIVE FIRE!""*)

### Węzeł `[8]`
Mówca: **Narrator**
> "With quick steps, the armed men encircled the table, pointing their weapons toward my guests."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "One of the men approached the table. He methodically collected the scattered papers and spread them out neatly before the trembling nobles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""If you value your lives, you'll sign these papers withou..."*)
  - -> `[17]` (*Player_Romus: ""I told you there wasn't way out of this. I can no longer..."*)
  - -> `[14]` (*Player_Romus: ""Well? What are you waiting for?""*)
  - -> `[15]` (*Player_Romus: ""Sign the papers, and I promise your concerns will still ..."*)
  - -> `[16]` (*Player_Romus: ""You have my sincerest apologies. I never wanted it to co..."*)

### Węzeł `[10]`
Mówca: **Titus Gordion**
> ""SUPPRESSIVE FIRE!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "No shots came from the Golden Guard. Instead, one by one,..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "No shots came from the Golden Guard. Instead, one by one, they were subdued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "An operative approached Titus from behind and disarmed hi..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "An operative approached Titus from behind and disarmed him with a swift strike, slamming him against the wall before pinning him to the ground. The remaining guards lay scattered across the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "With quick steps, the armed men encircled the table, poin..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you value your lives, you'll sign these papers without hesitation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well? What are you waiting for?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sign the papers, and I promise your concerns will still be heard. My only wish is for a peaceful compromise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my sincerest apologies. I never wanted it to come to this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I told you there wasn't way out of this. I can no longer stand by and allow the people of this country to be oppressed by the nobility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[18]`
Mówca: **Taddeus Azaro**
> ""What do you think you're doing!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""I told you. Nobody's going anywhere until I get your sig..."*)
  - -> `[113]` (*Player_Romus: ""I'm afraid I cannot let you go until these reforms are i..."*)
  - -> `[112]` (*Player_Romus: ""All that's needed is your signature, General, and there ..."*)
  - -> `[114]` (*Player_Romus: ""You asked for this.""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "The armed men pressed their rifles firmly against their h..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[23]`
Mówca: **Taddeus Azaro**
> ""Doesn't seem that peaceful to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "The armed men pressed their rifles firmly against the hea..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "The Palantor men pressed their rifles firmly against the ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "The Palantor men pressed their rifles firmly against the ..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The armed men pressed their rifles firmly against the nob..."*)

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""Romus -- Your Majesty. This has gone too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""Just sign the papers, Hugo.""*)
  - -> `[49]` (*Player_Romus: ""This doesn't concern you.""*)
  - -> `[50]` (*Player_Romus: ""I'm not leaving anything to chance.""*)
  - -> `[59]` (*Player_Romus_Italic: "Ignore him."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Hugo Toras: ""Please explain what exactly is 'peaceful' about this sit..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Taddeus Azaro: ""Doesn't seem that peaceful to me.""*)

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""Please explain what exactly is 'peaceful' about this situation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "The armed men pressed their rifles firmly against the heads of the members of House Sazon and House Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""Romus -- Your Majesty. This has gone too far.""*)

### Węzeł `[39]`
Mówca: **Narrator**
> "The Palantor men pressed their rifles firmly against the heads of the members of House Toras and House Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""What do you think you're doing, Romus!?""*)

### Węzeł `[40]`
Mówca: **Narrator**
> "The Palantor men pressed their rifles firmly against the heads of the members of House Toras and House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""What do you think you're doing, Romus!?""*)

### Węzeł `[41]`
Mówca: **Narrator**
> "The armed men pressed their rifles firmly against the nobles' heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""What do you think you're doing, Romus!?""*)

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""What do you think you're doing, Romus!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true"*)

### Węzeł `[43]`
Mówca: **Taddeus Azaro**
> ""Is this your idea of democracy, kid? Bullet diplomacy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "The armed men pressed their rifles firmly against their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Taddeus Azaro: ""What do you think you're doing!?""*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He pointed at Manus."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He stretched his arms wide, a gesture that only prompted ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just sign the papers, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I turned to the others."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This doesn't concern you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I turned to the others."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not leaving anything to chance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I turned to the others."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == ..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Hey! Get those guns away from my family!""*)
  - -> `[57]` (*Player_Romus: ""Lower your guns! Hugo has already agreed to the proposal.""*)
  - -> `[56]` (*Player_Romus: ""Just sign it, Hugo. I've got no quarrel with you.""*)
  - -> `[58]` (*Player_Romus: ""I'm not leaving anything to chance.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hey! Get those guns away from my family!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "They lowered their rifles on my command. Hugo took a step..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just sign it, Hugo. I've got no quarrel with you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Hugo took a step forward."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lower your guns! Hugo has already agreed to the proposal.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "They lowered their rifles on my command. Hugo took a step..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not leaving anything to chance.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Hugo took a step forward."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Romus_Italic**
> "I ignored him and looked at the others."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true ..."*)

### Węzeł `[60]`
Mówca: **Manus Sazon**
> ""Your Majesty! What have you done!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""Captain Gordion! Apprehend these men immediately!""*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Manus Sazon: ""Your Majesty! What have you done!?""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""Captain Gordion! Apprehend these men immediately!""*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""This isn't the way forward. But if I must...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "He grabbed the pen and signed the papers."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "They lowered their rifles on my command. Hugo took a step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""This isn't the way forward. But if I must...""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Taddeus Azaro: ""Is this your idea of democracy, kid? Bullet diplomacy?""*)

### Węzeł `[69]`
Mówca: **Rico Toras**
> ""Holy shit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "With ruthless efficiency, the men of Palantor Security So..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Rico Toras: ""Holy shit!""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "With ruthless efficiency, the men of Palantor Security So..."*)

### Węzeł `[73]`
Mówca: **Angelica Sazon**
> ""Is this how you plan to establish democracy -- by holding guns to our heads? You're no better than Lucas Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Angelica Sazon: ""Is this how you plan to establish democracy -- by holdin..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[77]`
Mówca: **Manus Sazon**
> ""Your Majesty! Please! There's no need for threats of violence. House Sazon will sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "Hugo took a step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""This isn't the way forward. But if I must...""*)

### Węzeł `[79]`
Mówca: **Narrator**
> "He grabbed the pen and signed the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""Hey! Get those guns away from my family!""*)
  - -> `[83]` (*Player_Romus: ""Lower your guns! Hugo knows better than to resist.""*)
  - -> `[82]` (*Player_Romus: ""Just sign it, Hugo. And we won't have any problems.""*)
  - -> `[84]` (*Player_Romus: ""I'm not leaving anything to chance.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hey! Get those guns away from my family!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "They lowered their rifles on my command. Hugo took a step..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just sign it, Hugo. And we won't have any problems.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""You're making a huge mistake.""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lower your guns! Hugo knows better than to resist.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "They lowered their rifles on my command. Hugo took a step..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not leaving anything to chance.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""You're making a huge mistake.""*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""You're making a huge mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "My uncle approached the table and looked at the constitut..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Hugo Toras: ""Here's your damn signature.""*)

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Here's your damn signature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true || RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true ..."*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == tru..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true || RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true || RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus_Italic: "Wait for them to sign the papers."*)
  - -> `[100]` (*Player_Romus: ""House Azaro and House Sazon, your king commands you to s..."*)
  - -> `[102]` (*Player_Romus: ""We don't have all day.""*)
  - -> `[103]` (*Player_Romus: ""Please cooperate.""*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Romus: ""While we're at it, let's make it unanimous.""*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)
  - -> `[104]` (*Player_Romus_Italic: "Wait for them to sign the papers."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "I turned to the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While we're at it, let's make it unanimous.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true` AND `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic), `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""House Sazon, I am awaiting your signature.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""House Azaro, I am awaiting your signatures.""*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Azaro, I am awaiting your signatures.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true) == false` AND `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Taddeus Azaro: ""Is this your idea of democracy, kid? Bullet diplomacy?""*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Azaro and House Sazon, your king commands you to sign the new constitution.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic), `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Sazon, I am awaiting your signature.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true` AND `Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have all day.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic), `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please cooperate.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic), `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "Wait for them to sign the papers."]** — Mówca: **Player_Romus_Italic**
> "I stared at them in silence."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == true  or  Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic), `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true"*)

### Węzeł `[105]`
Mówca: **Narrator**
> "They lowered their rifles on my command. Hugo took a step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""You're making a huge mistake.""*)

### Węzeł `[106]`
Mówca: **Narrator**
> "My uncle approached the table and looked at the constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[107]`
Mówca: **Rico Toras**
> ""What are you doing, Father!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Hugo Toras: ""I'm doing as the king says. For the sake of peace, and o..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Rico Toras: ""What are you doing, Father!?""*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Hubertus Toras: ""What are you doing, Your Grace?""*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I told you. Nobody's going anywhere until I get your signatures.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Hugo Toras: ""Romus! Order these men to stand down!""*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All that's needed is your signature, General, and there won't be any trouble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Hugo Toras: ""Romus! Order these men to stand down!""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid I cannot let you go until these reforms are implemented.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Hugo Toras: ""Romus! Order these men to stand down!""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You asked for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Hugo Toras: ""Romus! Order these men to stand down!""*)

### Węzeł `[115]`
Mówca: **Hugo Toras**
> ""Romus! Order these men to stand down!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""Hey! Get those guns away from my family!""*)
  - -> `[118]` (*Player_Romus: ""Not happening.""*)
  - -> `[119]` (*Player_Romus: ""Please sign and leave, Hugo. I have no quarrels with you.""*)

### Węzeł `[116]`
Mówca: **Hubertus Toras**
> ""What are you doing, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Hugo Toras: ""I'm doing as the king says. For the sake of peace, and o..."*)

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""I'm doing as the king says. For the sake of peace, and our family's safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "He grabbed the pen and signed the papers."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not happening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Hugo Toras: ""Why are you doing this?""*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please sign and leave, Hugo. I have no quarrels with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Hugo Toras: ""Why are you doing this?""*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hey! Get those guns away from my family!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "They lowered their rifles on my command. Hugo took a step..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "They lowered their rifles on my command. Hugo took a step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Why are you doing this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[123]`
Mówca: **Narrator**
> "He pointed at Manus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""I warned you about him! I did everything I could to keep..."*)

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""I warned you about him! I did everything I could to keep him from manipulating you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""Not only did you let him into our family, but now, because of him, we have guns pointed at us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Hugo Toras: ""Not only did you let him into our family, but now, becau..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Hugo Toras: ""He’s the one who got you to point a gun at your own fami..."*)

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""He’s the one who got you to point a gun at your own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[130]`
Mówca: **Narrator**
> "He stretched his arms wide, a gesture that only prompted the soldiers to press their guns harder against him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""Where is that Sazon boy? Your partner in crime!""*)

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""Where is that Sazon boy? Your partner in crime!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""I warned you about him! I did everything I could to keep..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Manus Sazon: ""I... I have nothing to do with this.""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[135]`
Mówca: **Manus Sazon**
> ""I... I have nothing to do with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Angelica Sazon: ""That's bullshit, Manus!""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[139]`
Mówca: **Angelica Sazon**
> ""That's bullshit, Manus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Manus Sazon: ""Your Majesty! Please! There's no need for threats of vio..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Leona Sazon: ""Manus, did you know about this?""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true"*)

### Węzeł `[146]`
Mówca: **Leona Sazon**
> ""Manus, did you know about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Manus Sazon: ""No! I swear, I had nothing to do with it.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Romus: ""It seems you don't fully realize the gravity of the situ..."*)
  - -> `[149]` (*Player_Romus: "Manus tried to convince me otherwise, but unlike him, I k..."*)
  - -> `[148]` (*Player_Romus: ""He has nothing to do with this. I organized this on my o..."*)
  - -> `[150]` (*Player_Romus: ""Keep pushing me and I'll make you regret it. I won't say..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He has nothing to do with this. I organized this on my own.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Angelica Sazon), `[243]` (Lucita Azaro), `[125]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hugo Toras: ""You're making a huge mistake.""]"*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Manus tried to convince me otherwise, but unlike him, I know that force is the only language people like you understand.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Angelica Sazon), `[243]` (Lucita Azaro), `[125]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hugo Toras: ""You're making a huge mistake.""]"*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep pushing me and I'll make you regret it. I won't say it again.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Angelica Sazon), `[243]` (Lucita Azaro), `[125]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "My uncle approached the table and l...."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems you don't fully realize the gravity of the situation you're in.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Angelica Sazon), `[243]` (Lucita Azaro), `[125]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hugo Toras: ""You're making a huge mistake.""]"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hugo Toras: ""You're making a huge mistake.""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""You're making a huge mistake.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "My uncle approached the table and l..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "My uncle approached the table and looked at the constitut..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Vina Toras: ""FATHER!""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Titus, wielding his sidearm, managed to take down an oper..."*)

### Węzeł `[157]`
Mówca: **Vina Toras**
> ""FATHER!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Titus, wielding his sidearm, managed to take down an oper..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player_Romus: ""Take Vina to safety! Now!""*)
  - -> `[260]` (*Player_Romus: ""Please escort my daughter outside.""*)
  - -> `[261]` (*Player_Romus: ""WHAT THE HELL ARE YOU DOING!? MY DAUGHTER IS IN THE ROOM!""*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "One of the men approached the table. He methodically coll..."*)

### Węzeł `[161]`
Mówca: **Vina Toras**
> ""Manus! Was this part of your plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[162]`
Mówca: **Narrator**
> "Two of Rusty's men quickly rushed to Vina and gently took hold of her by the arms, leading her toward the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Vina Toras: ""Manus! Was this part of your plan?""*)

### Węzeł `[163]`
Mówca: **Lucita Azaro**
> ""This is a coup! Plain and simple!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true"*)

### Węzeł `[164]`
Mówca: **Hugo Toras**
> ""I advise you not to escalate things any further. Just do as he says...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Hugo Toras: ""There is nothing to gain from fighting. Please just coop..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Hugo Toras: ""I advise you not to escalate things any further. Just do..."*)

### Węzeł `[168]`
Mówca: **Hugo Toras**
> ""There is nothing to gain from fighting. Please just cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[169]`
Mówca: **Manus Sazon**
> ""No! I swear, I had nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true"*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Hugo.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Hugo Toras), `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I turned to the others."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You did the right thing, Uncle.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Hugo Toras), `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I turned to the others."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "Taddeus heaved a sigh and wheeled himself towards the table."*)

### Węzeł `[175]`
Mówca: **Angelica Sazon**
> ""If there's no other way out, then so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == true ..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus_Italic: "Wait for them to sign the papers."*)
  - -> `[100]` (*Player_Romus: ""House Azaro and House Sazon, your king commands you to s..."*)
  - -> `[102]` (*Player_Romus: ""We don't have all day.""*)
  - -> `[103]` (*Player_Romus: ""Please cooperate.""*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Narrator: "Angelica heaved a sigh and approached the table."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && Ri..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lucita Azaro: ""This is a coup! Plain and simple!""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true && Rizi..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true && Rizi..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true && Ri..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  and  Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Carlos Robles Azaro: ""Make no mistake, this is a coup!""*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  and  Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Taddeus Azaro: ""What you're doing is nothing short of a coup!""*)

### Węzeł `[189]`
Mówca: **Carlos Robles Azaro**
> ""Make no mistake, this is a coup!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true"*)

### Węzeł `[190]`
Mówca: **Taddeus Azaro**
> ""What you're doing is nothing short of a coup!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_TorasSigned == true"*)

### Węzeł `[191]`
Mówca: **Taddeus Azaro**
> ""So be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == fal..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == false  and  Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "One by one, the representatives from House Azaro and Hous..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false && RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == false  and  Variable["RiziaDLCIsolated.Birthday_ReformTalk_AzaroSigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "Taddeus heaved a sigh and wheeled himself towards the table."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "Angelica slowly grabbed the pen and wrote her signature. Leona followed suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "The Palantor guards retracted their weapons from the nobl..."*)

### Węzeł `[199]`
Mówca: **Narrator**
> "One by one, the representatives from House Azaro and House Sazon grabbed their pens and wrote their signatures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "The Palantor guards retracted their weapons from the nobl..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "Angelica slowly grabbed the pen and wrote her signature. ..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Taddeus slowly grabbed the pen and wrote his signature."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "Taddeus slowly grabbed the pen and wrote his signature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "The Palantor guards retracted their weapons from the nobl..."*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus_Italic: "Applaud."*)
  - -> `[207]` (*Player_Romus: ""Now, that wasn't so difficult, was it?""*)
  - -> `[208]` (*Player_Romus: ""Thank you for your cooperation.""*)
  - -> `[209]` (*Player_Romus: ""This was the only way to truly transform our monarchy. I..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "The Palantor guards retracted their weapons from the nobles' heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "Applaud."]** — Mówca: **Player_Romus_Italic**
> "I began applauding, but no one else had joined in."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Narrator: "Then, to my surprise, I heard another set of claps. Rusty."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, that wasn't so difficult, was it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Russello Montoro: ""Easy as catching fruit flies at a winery.""*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Russello Montoro: ""Yes, you all performed beautifully.""*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was the only way to truly transform our monarchy. I'm sure you'll understand one day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Russello Montoro: ""You don't have to explain a thing to these ingrates.""*)

### Węzeł `[210]`
Mówca: **Russello Montoro**
> ""Oh, don't mind me. I'm just making sure my team executed everything properly. Pretend like I'm not even here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[211]`
Mówca: **Narrator**
> "I realized that, amid the mayhem of what had just transpired, Rusty had slipped into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Russello Montoro: ""Oh, don't mind me. I'm just making sure my team executed..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "He glared at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Hugo Toras: ""What puzzles me is why His Majesty would deign to cooper..."*)

### Węzeł `[213]`
Mówca: **Hugo Toras**
> ""Never one to care for this kingdom, loyalty, or anything beyond your own gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "He glared at me."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think it's best you step out, Rusty. The room is no place for a spectator.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Russello Montoro: ""Very well. Enjoy your moment.""*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you can see, your men performed with the utmost proficiency and skill.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Russello Montoro: ""I'm glad to hear it.""*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're going to pretend you're not here, Rusty, why not do it somewhere else?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Russello Montoro: ""Fine, fine, I'll head out. Don’t miss me too much.""*)

### Węzeł `[217]`
Mówca: **Russello Montoro**
> ""Very well. Enjoy your moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Russello Montoro: ""Looking forward to waking up in a new Rizia.""*)

### Węzeł `[218]`
Mówca: **Russello Montoro**
> ""Fine, fine, I'll head out. Don’t miss me too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Russello Montoro: ""Looking forward to waking up in a new Rizia.""*)

### Węzeł `[219]`
Mówca: **Russello Montoro**
> ""I'm glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Russello Montoro: ""Looking forward to waking up in a new Rizia.""*)

### Węzeł `[220]`
Mówca: **Narrator**
> "He walked up to Manus and put an arm around his shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Russello Montoro: ""We must get to work immediately, Mr. Prime Minister. I'm..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucita Azaro: ""Rusty!?""*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Hugo Toras: ""Mr. Montoro. I can't say I'm surprised.""*)

### Węzeł `[224]`
Mówca: **Hugo Toras**
> ""Mr. Montoro. I can't say I'm surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Hugo Toras: ""Never one to care for this kingdom, loyalty, or anything..."*)

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""Rusty!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Hugo Toras: ""Mr. Montoro. I can't say I'm surprised.""*)

### Węzeł `[226]`
Mówca: **Narrator**
> "He flashed a grin at Manus and followed it with a mocking curtsy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Manus Sazon: ""Rusty. I should have known.""*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "He flashed a grin at Manus and followed it with a mocking..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[230]`
Mówca: **Manus Sazon**
> ""Rusty. I should have known.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Russello Montoro: ""No need to thank your old pal.""*)

### Węzeł `[231]`
Mówca: **Russello Montoro**
> ""No need to thank your old pal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Hugo Toras: ""Mr. Montoro. I can't say I'm surprised.""*)

### Węzeł `[232]`
Mówca: **Russello Montoro**
> ""Looking forward to waking up in a new Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "He walked up to Manus and put an arm around his shoulder."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Russello Montoro: ""By the way, I had a word with Prime Minister Sazon.""*)

### Węzeł `[236]`
Mówca: **Russello Montoro**
> ""By the way, I had a word with Prime Minister Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Russello Montoro: ""It was his request that I ensure the safety of his family.""*)

### Węzeł `[237]`
Mówca: **Russello Montoro**
> ""We must get to work immediately, Mr. Prime Minister. I'm just brimming with ideas for the new administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Russello Montoro: ""And besides, I think the King wants a private word with ..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She and Leona can leave. We already have House Sazon's full support.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true` AND `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "On Rusty's command, several of the armed men approached a..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid you'll be placed under strict surveillance until the reforms are implemented and your House fully cooperates with the new government.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucita Azaro: ""You know that's bullshit, Mr. Sazon.""*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[243]`
Mówca: **Lucita Azaro**
> ""You know that's bullshit, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hello Rusty. We were just wrapping this up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Russello Montoro: ""I'm glad to hear it.""*)

### Węzeł `[245]`
Mówca: **Russello Montoro**
> ""And besides, I think the King wants a private word with these troublemakers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Russello Montoro: ""Please come with me.""*)

### Węzeł `[246]`
Mówca: **Russello Montoro**
> ""Please come with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[247]`
Mówca: **Narrator**
> "On Rusty's command, several armed men approached and escorted them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Angeli..."*)

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
  - -> `[252]` (*Manus Sazon: ""What about my mother?""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Manus Sazon: ""What about Leona?""*)

### Węzeł `[251]`
Mówca: **Manus Sazon**
> ""What about Leona?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Russello Montoro: ""Bring her too. We're leaving.""*)

### Węzeł `[252]`
Mówca: **Manus Sazon**
> ""What about my mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Rusty turned to me."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""I'm afraid I can't let her go after what happened.""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true)"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player_Romus: ""She and Leona can leave. We already have House Sazon's f..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports == true"*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take Vina to safety! Now!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Two of Rusty's men quickly rushed to Vina and gently took..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please escort my daughter outside.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Two of Rusty's men quickly rushed to Vina and gently took..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHAT THE HELL ARE YOU DOING!? MY DAUGHTER IS IN THE ROOM!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Two of Rusty's men quickly rushed to Vina and gently took..."*)

### Węzeł `[262]`
Mówca: **Russello Montoro**
> ""Bring her too. We're leaving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "On Rusty's command, several armed men approached and esco..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "After they had left, the remaining contract soldiers seized the other guests by their arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "Their commander, Antoine, turned to me, awaiting my orders."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "Their commander, Antoine, turned to me, awaiting my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Rusty turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[271]` (*Player_Romus: ""The Sazons may leave.""*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports == ..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player_Romus: ""She and Leona can leave. We already have House Sazon's f..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""She stays. I can't risk her trying to stop these reforms..."*)
  - -> `[270]` (*Player_Romus: ""I'm afraid I can't let her go after what happened.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She stays. I can't risk her trying to stop these reforms before they're set in motion.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports"] == true) == false` AND `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_SazonSigned"] == true) == false` AND `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid I can't let her go after what happened.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Sazons may leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "On Rusty's command, several of the armed men approached a..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "On Rusty's command, several of the armed men approached and escorted the Sazons out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Angeli..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""Hugo. I know you were the first to step up and give your..."*)
  - -> `[239]` (*Player_Romus: ""I'm afraid you'll be placed under strict surveillance un..."*)
  - -> `[274]` (*Player_Romus: ""By the authority vested in me as the King of Rizia, I pl..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By the authority vested in me as the King of Rizia, I place you all under arrest.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder = true; R..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo. I know you were the first to step up and give your signature. Tell me. Can I trust you to help with these reforms?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Hugo Toras: ""I will not pretend I understand your actions today, nor ..."*)

### Węzeł `[276]`
Mówca: **Narrator**
> "Lucita's face twisted with disgust as she glared at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "General Taddeus furrowed his brow as he glanced around th..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "Lucita's face twisted with disgust as she glared at me."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "General Taddeus furrowed his brow as he glanced around th..."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "General Taddeus furrowed his brow as he glanced around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Taddeus Azaro: ""I see how it is...""*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m afraid you’ll be placed under strict surveillance until the reforms are implemented and your House fully cooperates with the new government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Taddeus Azaro), `[532]` (Narrator), `[536]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By the authority vested in me as the King of Rizia, I place you all under arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Taddeus Azaro), `[532]` (Narrator), `[536]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder = true"*)

### Węzeł `[284]`
Mówca: **Manus Sazon**
> ""You promised not to touch my family!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Manus Sazon: ""No! What are you doing, Your Majesty!?""*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Manus Sazon: ""You promised not to touch my family!""*)

### Węzeł `[288]`
Mówca: **Russello Montoro**
> ""It was his request that I ensure the safety of his family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He walked up to Angelica and put an arm around her should..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "He walked up to Leona and put an arm around her shoulder...."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "He walked up to Leona and put an arm around her shoulder. She smiled uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Russello Montoro: ""Please come with me.""*)

### Węzeł `[293]`
Mówca: **Russello Montoro**
> ""Please come with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "On Rusty's command, several of the armed men approached a..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "On Rusty's command, several of the armed men approached and escorted them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Angelica Sazon"); RemoveConversant("Leo..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "He walked up to Angelica and put an arm around her shoulder. Her lips curled in revulsion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Russello Montoro: ""May I escort her out, Your Majesty?""*)

### Węzeł `[296]`
Mówca: **Russello Montoro**
> ""May I escort her out, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Player_Romus: ""Yes. Both she and Leona can leave.""*)
  - -> `[297]` (*Player_Romus: ""No. I'm afraid I can't let the Sazons go. I can't take a..."*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm afraid I can't let the Sazons go. I can't take any chances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Both she and Leona can leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "On Rusty's command, several of the armed men approached a..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Lucita Azaro: ""Damn Sazons...""*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Taddeus Azaro: ""Damn Sazons...""*)

### Węzeł `[302]`
Mówca: **Lucita Azaro**
> ""Damn Sazons...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "After they had left, the remaining contract soldiers seiz..."*)

### Węzeł `[303]`
Mówca: **Taddeus Azaro**
> ""Damn Sazons...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "After they had left, the remaining contract soldiers seiz..."*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expected this to be quick and discreet. Not a firefight breaking out with my daughter in the room.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Kontekst wejściowy (poprzednik):** `[446]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Russello Montoro: ""The Golden Guard are no joke, Your Majesty.""*)

### Węzeł `[305]`
Mówca: **Russello Montoro**
> ""The Golden Guard are no joke, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Russello Montoro: ""But it seems like everything's under control to me.""*)

### Węzeł `[306]`
Mówca: **Russello Montoro**
> ""But it seems like everything's under control to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Russello Montoro: ""Looking forward to waking up in a new Rizia.""*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Russello Montoro: ""Oh, I see.""*)

### Węzeł `[308]`
Mówca: **Russello Montoro**
> ""Oh, I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Russello Montoro: ""Mr. Prime Minister will be quite disappointed.""*)

### Węzeł `[309]`
Mówca: **Russello Montoro**
> ""Mr. Prime Minister will be quite disappointed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Russello Montoro: ""Anyway, Your Majesty, I'll leave you to it.""*)

### Węzeł `[310]`
Mówca: **Russello Montoro**
> ""Anyway, Your Majesty, I'll leave you to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "He took several of the armed men with him and walked to t..."*)

### Węzeł `[311]`
Mówca: **Narrator**
> "After he'd left, the remaining contract soldiers seized the other guests by their arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "Their commander, Antoine, turned to me, awaiting my orders."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "He took several of the armed men with him and walked to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Russello Montoro");"*)

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""I will not pretend I understand your actions today, nor that I am overjoyed by them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Hugo Toras: ""But if this is the future you envision for the Crown of ..."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not good enough, Hugo. Does that mean it's currently not aligned?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[450]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Hugo Toras: ""It is, Your Majesty.""*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Make sure our family stays out of this. You are free to go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[450]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Hugo Toras: ""Thank you, Your Majesty.""*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Player_Romus: ""Thank you for saying that. However, I'm still not convin..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: ""I'm sorry, but that's too big of a risk for me to take.""*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for saying that. However, I'm still not convinced you, Rico, or Hubertus can be trusted.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Kontekst wejściowy (poprzednik):** `[450]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Hugo Toras: ""Please. I give my word that House Toras poses no threat ..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. House Toras may leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Hugo Toras), `[450]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Hugo Toras: ""Thank you, Your Majesty.""*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Rico Toras: ""Your mercy will be remembered, King Romus.""*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Hubertus Toras: ""Your mercy will be remembered.""*)

### Węzeł `[324]`
Mówca: **Rico Toras**
> ""Your mercy will be remembered, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player_Romus_Italic: "Let them leave."*)
  - -> `[341]` (*Player_Romus: ""Hold up, Rico. I didn't say *you* could go.""*)

### Węzeł `[325]`
Mówca: **Hugo Toras**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[326]`
Mówca: **Hugo Toras**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Hubertus Toras: ""Your mercy will be remembered.""*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""Promised? So the Sazons were in on this?!""*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Taddeus Azaro: ""Promised? The Sazons will pay for this.""*)

### Węzeł `[330]`
Mówca: **Lucita Azaro**
> ""Promised? So the Sazons were in on this?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[331]`
Mówca: **Taddeus Azaro**
> ""Promised? The Sazons will pay for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: ""Rusty. You and Mr. Sazon may leave.""*)
  - -> `[335]` (*Player_Romus: ""I did not promise you anything.""*)
  - -> `[333]` (*Player_Romus: ""I'm sorry, Manus. I'm not taking any chances.""*)
  - -> `[334]` (*Player_Romus: ""Don't worry. Nobody's going to get harmed.""*)
  - -> `[337]` (*Player_Romus: ""Fine. Take your relatives with you.""*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Manus. I'm not taking any chances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[331]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. Nobody's going to get harmed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[331]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not promise you anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[331]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty. You and Mr. Sazon may leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[331]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Take your relatives with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[331]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Manus Sazon: ""Thank you, Your Majesty.""*)

### Węzeł `[338]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "On Rusty's command, several of the armed men approached a..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Narrator: "On Rusty's command, several of the armed men grabbed Manu..."*)

### Węzeł `[340]`
Mówca: **Narrator**
> "On Rusty's command, several of the armed men grabbed Manus and took him out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Russel..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold up, Rico. I didn't say *you* could go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Rico Toras: ""Your Majesty, please. Have reason.""*)

### Węzeł `[342]`
**[WYBÓR GRACZA: "Let them leave."]** — Mówca: **Player_Romus_Italic**
> "I let them leave."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "A few of Rusty's men escorted Hugo, Rico, and Hubertus ou..."*)

### Węzeł `[343]`
Mówca: **Taddeus Azaro**
> ""I see how it is...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""I’m afraid you’ll be placed under strict surveillance un..."*)
  - -> `[283]` (*Player_Romus: ""By the authority vested in me as the King of Rizia, I pl..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [//]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, but that's too big of a risk for me to take.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[347]` (Hugo Toras), `[450]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Hugo Toras: ""Please. I give my word that House Toras poses no threat ..."*)

### Węzeł `[346]`
Mówca: **Hugo Toras**
> ""Please. I give my word that House Toras poses no threat to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Hubertus Toras: ""His Grace is correct. House Toras is completely behind y..."*)

### Węzeł `[347]`
Mówca: **Hugo Toras**
> ""It is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: ""I'm sorry, but that's too big of a risk for me to take.""*)
  - -> `[348]` (*Player_Romus: ""Fine. Make sure our family stays out of this. You are fr..."*)
  - -> `[320]` (*Player_Romus: ""Thank you. House Toras may leave.""*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Make sure our family stays out of this. You are free to go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Hugo Toras: ""Thank you, Your Majesty.""*)

### Węzeł `[349]`
Mówca: **Hubertus Toras**
> ""His Grace is correct. House Toras is completely behind you and your reforms, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player_Romus: ""I'm not convinced. Nobody is leaving.""*)
  - -> `[350]` (*Player_Romus: ""Fine. You can leave.""*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. You can leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Hugo Toras: ""Thank you, Your Majesty.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not convinced. Nobody is leaving.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Hubertus Toras: ""But that's preposterous!""*)

### Węzeł `[352]`
Mówca: **Rico Toras**
> ""Your Majesty, please. Have reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)

### Węzeł `[353]`
Mówca: **Rico Toras**
> ""I pose no danger to you nor to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Player_Romus: ""Rico is staying. The rest can leave.""*)
  - -> `[418]` (*Player_Romus: ""No, cousin. You've made enough trouble for both of us al..."*)
  - -> `[417]` (*Player_Romus: ""Do you really want me to believe that?""*)

### Węzeł `[354]`
Mówca: **Narrator**
> "Hugo's jaw dropped, his eyes frozen in a look of pure astonishment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid you will be placed under strict surveillance until the reforms are implemented, and your House demonstrates full cooperation with the new government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the authority vested upon me as the King of Rizia, I place you all under arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Hubertus Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder = true; R..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Rico Toras: ""What!?""*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)

### Węzeł `[360]`
Mówca: **Rico Toras**
> ""What!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angeli..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Angelica Sazon: ""You will regret this.""*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[364]`
Mówca: **Angelica Sazon**
> ""You will regret this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""This is outrageous! We’re innocent of any wrongdoing!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Lucita Azaro: ""This is outrageous! We’re innocent of any wrongdoing!""*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "Without a moment of hesitation, Antoine's forces handcuff..."*)

### Węzeł `[370]`
Mówca: **Carlos Robles Azaro**
> ""This is outrageous! We haven’t committed a single crime!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Carlos Robles Azaro: ""This is outrageous! We haven’t committed a single crime!""*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Taddeus Azaro: ""This is outrageous! We haven't broken any laws.""*)

### Węzeł `[374]`
Mówca: **Taddeus Azaro**
> ""This is outrageous! We haven't broken any laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[375]`
Mówca: **Hubertus Toras**
> ""But that's preposterous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Player_Romus: ""I'm afraid you will be placed under strict surveillance ..."*)
  - -> `[356]` (*Player_Romus: ""With the authority vested upon me as the King of Rizia, ..."*)

### Węzeł `[376]`
Mówca: **Narrator**
> "Hugo's jaw dropped, his eyes frozen in a look of pure astonishment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "Jump to: [//]"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "Hugo's jaw dropped, his eyes frozen in a look of pure ast..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder = true;
RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] = true;
Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "Hugo's jaw dropped, his eyes frozen in a look of pure ast..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Narrator: "Hugo's jaw dropped, his eyes frozen in a look of pure ast..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder = true;
RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] = true;
Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Narrator: "Hugo's jaw dropped, his eyes frozen in a look of pure ast..."*)

### Węzeł `[383]`
Mówca: **Manus Sazon**
> ""No! What are you doing, Your Majesty!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[384]`
Mówca: **Narrator**
> "Without a moment of hesitation, Antoine's forces handcuffed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true"*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true)"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested = true;"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested = true; RiziaDLC.Hubertus_Arrested..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_HouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested = true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angeli..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Angelica_Arrested = true; RiziaDLC.Leona_Arreste..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Angelica_Arrested = true;
RiziaDLC.Leona_Arrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Angelica_Arrested"] = true;
Variable["RiziaDLC.Leona_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested = true;
RiziaDLC.Hubertus_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_Arrested"] = true;
Variable["RiziaDLC.Hubertus_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = true"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rico_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Inside, Rusty's men had every corner covered."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Player_Romus_Italic: "Don't say anything."*)
  - -> `[414]` (*Player_Romus: ""It was a mistake to stand in the way of the will of the ..."*)
  - -> `[409]` (*Player_Romus: ""Don't worry. Nobody will be harmed. I give you my word.""*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true"*)

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you understand. This is just a temporary precaution. You will be free after the declaration.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] == true) == false` AND `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[364]` (Angelica Sazon), `[540]` (Narrator), `[384]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "Accompanied by the Palantor guards, I walked back into th..."*)

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. Nobody will be harmed. I give you my word.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[364]` (Angelica Sazon), `[540]` (Narrator), `[384]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "Accompanied by the Palantor guards, I walked back into th..."*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will be up to the new government to decide your fate.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] == true` AND `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[364]` (Angelica Sazon), `[540]` (Narrator), `[384]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "Accompanied by the Palantor guards, I walked back into th..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player_Romus: ""It will be up to the new government to decide your fate.""*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Reform_Aggressive_ArrestOrder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Player_Romus: ""I hope you understand. This is just a temporary precauti..."*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a mistake to stand in the way of the will of the people.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[364]` (Angelica Sazon), `[540]` (Narrator), `[384]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "Accompanied by the Palantor guards, I walked back into th..."*)

### Węzeł `[415]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I didn't say anything."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[364]` (Angelica Sazon), `[540]` (Narrator), `[384]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "Accompanied by the Palantor guards, I walked back into th..."*)

### Węzeł `[416]`
Mówca: **Narrator**
> "Accompanied by the Palantor guards, I walked back into the library atrium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you really want me to believe that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, cousin. You've made enough trouble for both of us already. I won't risk it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Rico Toras), `[522]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rico is staying. The rest can leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Rico Toras), `[522]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Hugo Toras: ""Romus... Please.""*)

### Węzeł `[421]`
Mówca: **Hugo Toras**
> ""Romus... Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Narrator: "Before Hugo could object further, he and Hubertus were us..."*)

### Węzeł `[422]`
Mówca: **Narrator**
> "Inside, Rusty's men had every corner covered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Narrator: "Her husband could barely get the words out."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Manus Sazon: ""I'm sorry, Your Highness. I had no idea...""*)

### Węzeł `[428]`
Mówca: **Narrator**
> "Her husband could barely get the words out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Manus Sazon: ""I'm sorry, my love. I had no idea...""*)

### Węzeł `[429]`
Mówca: **Manus Sazon**
> ""I'm sorry, my love. I had no idea...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Manus Sazon: ""Take care of the Queen Mother. I'll do my best to ensure..."*)

### Węzeł `[430]`
Mówca: **Manus Sazon**
> ""Take care of the Queen Mother. I'll do my best to ensure no one gets hurt in here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[431]`
Mówca: **Manus Sazon**
> ""I'm sorry, Your Highness. I had no idea...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""Thank you, Hugo.""*)
  - -> `[171]` (*Player_Romus: ""You did the right thing, Uncle.""*)
  - -> `[433]` (*Player_Romus: ""One intelligent individual in this room just avoided exe..."*)
  - -> `[583]` (*Player_Romus: ""If you're looking for gratitude, you won’t get it from me.""*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One intelligent individual in this room just avoided execution. As for the rest of you...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Hugo Toras), `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I turned to the others."*)

### Węzeł `[434]`
Mówca: **Narrator**
> "Taddeus heaved a sigh and wheeled himself towards the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Taddeus Azaro: ""So be it.""*)

### Węzeł `[435]`
Mówca: **Narrator**
> "Angelica heaved a sigh and approached the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Angelica Sazon: ""If there's no other way out, then so be it.""*)

### Węzeł `[436]`
Mówca: **Narrator**
> "Then, to my surprise, I heard another set of claps. Rusty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Russello Montoro: ""Oh, don't mind me. I'm just making sure my team executed..."*)

### Węzeł `[437]`
Mówca: **Russello Montoro**
> ""Easy as catching fruit flies at a winery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "I realized that, amid the mayhem of what had just transpi..."*)

### Węzeł `[438]`
Mówca: **Russello Montoro**
> ""Yes, you all performed beautifully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "I realized that, amid the mayhem of what had just transpi..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "With a pained look, Lucita followed suit."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "With a scowl, Carlos followed suit."*)

### Węzeł `[442]`
Mówca: **Narrator**
> "With a pained look, Lucita followed suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "The Palantor guards retracted their weapons from the nobl..."*)

### Węzeł `[443]`
Mówca: **Narrator**
> "With a scowl, Carlos followed suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "The Palantor guards retracted their weapons from the nobl..."*)

### Węzeł `[444]`
Mówca: **Russello Montoro**
> ""You don't have to explain a thing to these ingrates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "I realized that, amid the mayhem of what had just transpi..."*)

### Węzeł `[445]`
Mówca: **Hugo Toras**
> ""What puzzles me is why His Majesty would deign to cooperate with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Russello Montoro: ""King Romus and I aren't so different, Hugo. We're both m..."*)

### Węzeł `[446]`
Mówca: **Russello Montoro**
> ""King Romus and I aren't so different, Hugo. We're both men of the people. Some may even dare to call us heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player_Romus: ""Hello Rusty. We were just wrapping this up.""*)
  - -> `[215]` (*Player_Romus: ""As you can see, your men performed with the utmost profi..."*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)
  - -> `[214]` (*Player_Romus: ""I think it's best you step out, Rusty. The room is no pl..."*)
  - -> `[216]` (*Player_Romus: ""If you're going to pretend you're not here, Rusty, why n..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player_Romus: ""I expected this to be quick and discreet. Not a firefigh..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[450]`
Mówca: **Hugo Toras**
> ""But if this is the future you envision for the Crown of Rizia, House Toras will stand by it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[314]` (*Player_Romus: ""That's not good enough, Hugo. Does that mean it's curren..."*)
  - -> `[315]` (*Player_Romus: ""Make sure our family stays out of this. You are free to ..."*)
  - -> `[320]` (*Player_Romus: ""Thank you. House Toras may leave.""*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "My wife looked at me with pleading eyes."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Angelica Sazon: ""Do not presume to speak for our house, Son.""*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)

### Węzeł `[457]`
Mówca: **Angelica Sazon**
> ""Do not presume to speak for our house, Son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)

### Węzeł `[458]`
Mówca: **Narrator**
> "My wife looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)

### Węzeł `[459]`
Mówca: **Lucita Azaro**
> ""House Azaro supported the constitution. We won't make any trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Lucita Azaro: ""Just let us go, Romus. Don't forget that I'm carrying th..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports == true"*)
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports == ..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Lucita Azaro: ""House Azaro supported the constitution. We won't make an..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Lucita Azaro: ""How could you do this to me? To "us*?""*)

### Węzeł `[463]`
Mówca: **Lucita Azaro**
> ""We would have created the greatest dynasty Rizia has ever known.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[472]` (*Player_Romus: ""Rizia's future lies with its people now.""*)
  - -> `[466]` (*Player_Romus: ""We still can, my love. Promise not to obstruct the new c..."*)

### Węzeł `[464]`
Mówca: **Lucita Azaro**
> ""Just let us go, Romus. Don't forget that I'm carrying the future of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player_Romus: ""I have not forgotten. You and your family can walk free.""*)
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[472]` (*Player_Romus: ""Rizia's future lies with its people now.""*)

### Węzeł `[465]`
Mówca: **Lucita Azaro**
> ""How could you do this to me? To "us*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Lucita Azaro: ""We would have created the greatest dynasty Rizia has eve..."*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still can, my love. Promise not to obstruct the new constitution, and you and your family can walk free.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[463]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Lucita Azaro: ""I promise. We will support you, now and forever.""*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have not forgotten. You and your family can walk free.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Narrator: "Her expression was one of gratitude, tinged with melancholy."*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina Toras is the future of Rizia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Kontekst wejściowy (poprzednik):** `[463]` (Lucita Azaro), `[464]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Narrator: "Anger flashed in her eyes as she wrenched herself free fr..."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Player_Romus: ""Vina Toras is the future of Rizia.""*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's future lies with its people now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[463]` (Lucita Azaro), `[464]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Lucita Azaro: ""I understand. And I can live with that.""*)

### Węzeł `[473]`
Mówca: **Narrator**
> "Anger flashed in her eyes as she wrenched herself free from the guard's grasp and reached for her thigh holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Narrator: "It was empty. The guard handed me her dagger."*)

### Węzeł `[474]`
Mówca: **Narrator**
> "It was empty. The guard handed me her dagger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player_Romus: ""That's it. You and your family are going away for a long..."*)
  - -> `[478]` (*Player_Romus: ""Child or no child, you're a security risk. I'm putting y..."*)

### Węzeł `[475]`
Mówca: **Lucita Azaro**
> ""I understand. And I can live with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Lucita Azaro: ""But please, think of our child...""*)

### Węzeł `[476]`
Mówca: **Lucita Azaro**
> ""But please, think of our child...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Player_Romus: ""Child or no child, you're a security risk. I'm putting y..."*)
  - -> `[480]` (*Player_Romus: ""Fine. Leave the room. Now, before I change my mind.""*)
  - -> `[481]` (*Player_Romus: ""I trust you, and I'd never do anything to harm the baby...."*)

### Węzeł `[477]`
Mówca: **Lucita Azaro**
> ""I promise. We will support you, now and forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Lucita Azaro: ""Just please, think of our child...""*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Child or no child, you're a security risk. I'm putting you all under arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[474]` (Narrator), `[476]` (Lucita Azaro), `[479]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Lucita Azaro: ""No! You can't!""*)

### Węzeł `[479]`
Mówca: **Lucita Azaro**
> ""Just please, think of our child...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Player_Romus: ""Child or no child, you're a security risk. I'm putting y..."*)
  - -> `[481]` (*Player_Romus: ""I trust you, and I'd never do anything to harm the baby...."*)

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Leave the room. Now, before I change my mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[476]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Narrator: "Her expression was one of gratitude, tinged with melancholy."*)

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you, and I'd never do anything to harm the baby. Go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[476]` (Lucita Azaro), `[479]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Narrator: "Her expression was one of gratitude, tinged with melancholy."*)

### Węzeł `[482]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[483]`
Mówca: **Narrator**
> "Her expression was one of gratitude, tinged with melancholy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Lucita Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it. You and your family are going away for a long time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[474]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Lucita Azaro: ""No! You can't!""*)

### Węzeł `[485]`
Mówca: **Narrator**
> "Her father and Carlos both gave reluctant nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Taddeus Azaro: ""For the sake of my daughter and grandchild, House Azaro ..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "Her father and Carlos both gave reluctant nods."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "Her father gave a reluctant nod."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "Her father gave a reluctant nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Taddeus Azaro: ""For the sake of my daughter and grandchild, House Azaro ..."*)

### Węzeł `[490]`
Mówca: **Taddeus Azaro**
> ""For the sake of my daughter and grandchild, House Azaro will support the new government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition == true..."*)

### Węzeł `[491]`
Mówca: **Taddeus Azaro**
> ""But I hope you will honor the promise you made in this room. In spite of everything that happened afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "The Azaros swiftly left the room."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Reform_Promise_MilitaryUntouched == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition == true..."*)
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Promised_Succession_Son_RespectTradition == tr..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Reform_Promise_MilitaryUntouched == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true  or  Variable["RiziaDLC.Reform_Promise_MilitaryUntouched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Taddeus Azaro: ""But I hope you will honor the promise you made in this r..."*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Reform_Promise_MilitaryUntouched == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true  or  Variable["RiziaDLC.Reform_Promise_MilitaryUntouched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Taddeus Azaro: ""May you remember our loyalty. In spite of everything.""*)

### Węzeł `[495]`
Mówca: **Lucita Azaro**
> ""No! You can't!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[496]`
Mówca: **Narrator**
> "Without a moment of hesitation, Antoine's forces handcuffed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested = true;  RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Carlos Robles Azaro: ""How could you? To your own Queen! This is madness!""*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Taddeus Azaro: ""You'll pay for this. I swear it on the blood of my ances..."*)

### Węzeł `[500]`
Mówca: **Carlos Robles Azaro**
> ""How could you? To your own Queen! This is madness!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Taddeus Azaro: ""You'll pay for this. I swear it on the blood of my ances..."*)

### Węzeł `[501]`
Mówca: **Taddeus Azaro**
> ""You'll pay for this. I swear it on the blood of my ancestors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "Without a moment of hesitation, Antoine's forces handcuff..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested = true; 
RiziaDLC.Lucita_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLC.Lucita_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Carlos_Arrested = true;"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Narrator: "I turned to the others."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Carlos_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Carlos_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Narrator: "I turned to the others."*)

### Węzeł `[507]`
Mówca: **Narrator**
> "The Azaros swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro"); RemoveConversant("Luci..."*)

### Węzeł `[508]`
Mówca: **Taddeus Azaro**
> ""May you remember our loyalty. In spite of everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "The Azaros swiftly left the room."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Narrator: "I turned to the others."*)

### Węzeł `[510]`
Mówca: **Narrator**
> "I turned to the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports == true"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDeal..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "The guards cuffed their wrists and lined them up next to ..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[518]`
Mówca: **Narrator**
> "The guards cuffed their wrists and lined them up next to the Azaros."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC..."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Rico Toras: ""I'm your son-in-law. You can't do this to me.""*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Rico Toras: ""I pose no danger to you nor to the reforms.""*)

### Węzeł `[522]`
Mówca: **Rico Toras**
> ""I'm your son-in-law. You can't do this to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player_Romus: ""I never liked you. Neither did Vina.""*)
  - -> `[419]` (*Player_Romus: ""Rico is staying. The rest can leave.""*)
  - -> `[418]` (*Player_Romus: ""No, cousin. You've made enough trouble for both of us al..."*)

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I never liked you. Neither did Vina.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[522]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDeal..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtWith"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""I’m afraid you’ll be placed under strict surveillance un..."*)
  - -> `[283]` (*Player_Romus: ""By the authority vested in me as the King of Rizia, I pl..."*)

### Węzeł `[528]`
Mówca: **Hubertus Toras**
> ""Your mercy will be remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Narrator: "A pair of Rusty's men ushered Hugo and Hubertus outside."*)

### Węzeł `[529]`
Mówca: **Narrator**
> "A pair of Rusty's men ushered Hugo and Hubertus outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)

### Węzeł `[530]`
Mówca: **Narrator**
> "A few of Rusty's men escorted Hugo, Rico, and Hubertus outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Rico To..."*)

### Węzeł `[531]`
Mówca: **Narrator**
> "Before Hugo could object further, he and Hubertus were ushered outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Hubertu..."*)

### Węzeł `[532]`
Mówca: **Narrator**
> "Only Angelica and Leona Sazon were left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Narrator: "I took a look at my cousin and the Sazons."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Narrator: "Only Angelica and Leona Sazon were left."*)

### Węzeł `[536]`
Mówca: **Narrator**
> "I took a look at my cousin and the Sazons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angeli..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_ReformStrike_AngelicaWasntAllowedToLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)

### Węzeł `[540]`
Mówca: **Narrator**
> "I took a look at the Azaros. They had stopped struggling against their restraints."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder..."*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Narrator: "I took a look at my cousin."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[544]`
Mówca: **Narrator**
> "I took a look at my cousin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Narrator: "I took a look at the Azaros. They had stopped struggling ..."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "Accompanied by the Palantor guards, I walked back into th..."*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Carlos_Arrested = true"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Carlos_Arrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Carlos_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ReformStrike_Angelica..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_I..."*)
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = true"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Reform_Aggressive_ArrestOrder_Includes_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[555]`
Mówca: **Narrator**
> "He, Manus, and Daria were engaged in a heated conversation. The RNC leader's face was pale with anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Narrator: "He, Manus, and Daria were engaged in a heated conversatio..."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Narrator: "He and Daria de Rava were engaged in a heated conversatio..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Narrator: "My mother and Vina were safely behind a cordon of guards,..."*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[562]`
Mówca: **Narrator**
> "He and Daria de Rava were engaged in a heated conversation. The RNC leader's face was pale with anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[563]`
Mówca: **Narrator**
> "My mother and Vina were safely behind a cordon of guards, exchanging concerned whispers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Narrator: "Upon seeing me, the room went silent."*)

### Węzeł `[564]`
Mówca: **Narrator**
> "My mother and Pabel were safely behind a cordon of guards, exchanging concerned whispers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Narrator: "Upon seeing me, the room went silent."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Narrator: "My mother and Pabel were safely behind a cordon of guards..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Narrator: "My mother was safely behind a cordon of guards. She looke..."*)

### Węzeł `[568]`
Mówca: **Narrator**
> "My mother was safely behind a cordon of guards. She looked stricken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Narrator: "Upon seeing me, the room went silent."*)

### Węzeł `[569]`
Mówca: **Narrator**
> "Upon seeing me, the room went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Player_Romus: ""Happy birthday, Mother.""*)
  - -> `[572]` (*Player_Romus: ""Out. All of you. This gathering is over.""*)
  - -> `[571]` (*Player_Romus: ""I can't apologize enough for what happened. But Rizia wi..."*)
  - -> `[570]` (*Player_Romus: ""Please excuse that unpleasant interruption. Let the part..."*)

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please excuse that unpleasant interruption. Let the party continue!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[569]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "The Palantor guards holstered their weapons as my guests ..."*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't apologize enough for what happened. But Rizia will be better for it in the end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[569]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Narrator: "The Palantor guards holstered their guns as my guests beg..."*)

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Out. All of you. This gathering is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[569]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Narrator: "The Palantor guards holstered their guns as my guests beg..."*)

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Happy birthday, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[569]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "The Palantor guards holstered their weapons as my guests ..."*)

### Węzeł `[574]`
Mówca: **Narrator**
> "The Palantor guards holstered their guns as my guests began streaming towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Narrator: "One of contract soldiers stepped out of the trophy room a..."*)

### Węzeł `[575]`
Mówca: **Narrator**
> "The Palantor guards holstered their weapons as my guests began murmuring amongst themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Narrator: "One of contract soldiers stepped out of the trophy room a..."*)

### Węzeł `[576]`
Mówca: **Narrator**
> "One of contract soldiers stepped out of the trophy room and handed me the signed constitution draft."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Narrator: "Looking closer at the document, I saw drops of blood on it."*)

### Węzeł `[577]`
Mówca: **Narrator**
> "Looking closer at the document, I saw drops of blood on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Narrator: "I hoped this was worth it."*)

### Węzeł `[578]`
Mówca: **Narrator**
> "I hoped this was worth it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_ReformOrDie");"*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Manus Sazon");
RemoveConversant("Russello Montoro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Manus Sazon");
RemoveConversant("Russello Montoro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "After they had left, the remaining contract soldiers seiz..."*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Manus Sazon");
RemoveConversant("Angelica Sazon");
RemoveConversant("Leona Sazon");
RemoveConversant("Russello Montoro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Manus Sazon");
RemoveConversant("Angelica Sazon");
RemoveConversant("Leona Sazon");
RemoveConversant("Russello Montoro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "After they had left, the remaining contract soldiers seiz..."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Angelica Sazon");
RemoveConversant("Leona Sazon");
RemoveConversant("Russello Montoro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Angelica Sazon");
RemoveConversant("Leona Sazon");
RemoveConversant("Russello Montoro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Russello Montoro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Russello Montoro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "After he'd left, the remaining contract soldiers seized t..."*)

### Węzeł `[583]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're looking for gratitude, you won’t get it from me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Hugo Toras), `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I turned to the others."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");
RemoveConversant("Rico Toras");
RemoveConversant("Hubertus Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Rico Toras");
RemoveConversant("Hubertus Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");
RemoveConversant("Hubertus Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Hubertus Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformStrike_Rusty_AzarosDealtW..."*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "One of the men approached the table. He methodically coll..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunfight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The guards, unprepared for the ambush, were overwhelmed. ..."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_ReformOrDie");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_ReformOrDie");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "//"*)
