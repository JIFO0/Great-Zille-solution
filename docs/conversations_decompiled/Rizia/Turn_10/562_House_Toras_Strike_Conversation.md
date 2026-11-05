# Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/House Toras Strike/House Toras Strike Conversation

- **ID konwersacji:** `562`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/562_House_Toras_Strike_Conversation.md`
- **Liczba węzłów dialogowych:** 361
- **Liczba wyborów gracza:** 74

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[67]** Hubertus Toras
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[85]** Sevrio Castellanus
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.Hubertus_Arrested`
- `RiziaDLC.Hubertus_Executed`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Iza_RicoControlsPolice`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pabel_WeddingDate`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Rico_Extradited`
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn09_Coup_Warning`
- `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan`
- `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Toras_StripTitles`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[559] Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation** (../Turn_10/559_ABSOLUTIST_STRIKE_SCENE_Conversation.md), Węzeł `[524]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Well, then let me save you the trouble." [Sign the decree to revoke House Toras' ..."** | `[351]` **Hugo Toras**: ""Do what you must. But no matter..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "I stepped over to the table and ..." |
| `[6]` | **"“Let it be known that from this day forward, Hugo, you shall no longer hold your t..."** | `[5]` **Narrator**: "I stepped over to the table and ..."<br>`[342]` **Narrator**: "With quivering hands, Hubertus m..." | `Variable["RiziaDLC.Hugo_Executed"] == false  or  Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.Hubertus_Executed"] == false` | *Brak zmian stanu* | `[7]` **Narrator**: "The Toras men stood in stunned s..."<br>`[32]` **Narrator**: "Rico and Hubertus stood in stunn..."<br>*(oraz 2 innych odgałęzień)* |
| `[8]` | **""You always did have a way with words. Tell it to the judge." [Gesture at Titus to..."** | `[351]` **Hugo Toras**: ""Do what you must. But no matter..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Narrator**: "I nodded to Titus, who gave the ..."<br>`[288]` **Narrator**: "I nodded to Titus, who gave the ..." |
| `[9]` | **""The only stain on our bloodline is you. Titus?""** | `[351]` **Hugo Toras**: ""Do what you must. But no matter..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "Hugo turned to Titus. There was ..." |
| `[10]` | **""Congratulations. Your blood is worth no more than that of a commoner.""** | `[5]` **Narrator**: "I stepped over to the table and ..."<br>`[342]` **Narrator**: "With quivering hands, Hubertus m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Narrator**: "The Toras men stood in stunned s..."<br>`[32]` **Narrator**: "Rico and Hubertus stood in stunn..."<br>*(oraz 2 innych odgałęzień)* |
| `[11]` | **""Henceforth, I erase all your rights, privileges, and noble standing.""** | `[5]` **Narrator**: "I stepped over to the table and ..."<br>`[342]` **Narrator**: "With quivering hands, Hubertus m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Narrator**: "The Toras men stood in stunned s..."<br>`[32]` **Narrator**: "Rico and Hubertus stood in stunn..."<br>*(oraz 2 innych odgałęzień)* |
| `[21]` | **""That's not what I meant, Titus. Oh well. Too late now.""** | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "Lucita's gaze lingered on Hugo a..."<br>`[122]` **Narrator**: "Hubertus stared at the blood on ..." |
| `[25]` | **"“Let it be known that from this day forward, Hugo, Ricardus, and Hubertus Toras sh..."** | `[5]` **Narrator**: "I stepped over to the table and ..."<br>`[342]` **Narrator**: "With quivering hands, Hubertus m..." | `(Variable["RiziaDLC.Hugo_Executed"] == false  or  Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.Hubertus_Executed"] == false) == false` | *Brak zmian stanu* | `[7]` **Narrator**: "The Toras men stood in stunned s..."<br>`[32]` **Narrator**: "Rico and Hubertus stood in stunn..."<br>*(oraz 2 innych odgałęzień)* |
| `[39]` | **""Something you'd like to add, Cousin?""** | `[38]` **Rico Toras**: ""FATHER!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Rico Toras**: ""You'll go to hell for this!"" |
| `[41]` | **""The sins of the family will not be overlooked.""** | `[38]` **Rico Toras**: ""FATHER!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Rico Toras**: ""You’ll rot in hell for this!"" |
| `[42]` | **""Save your tears, Rico. Your father’s legacy is no longer of concern.""** | `[38]` **Rico Toras**: ""FATHER!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Rico Toras**: ""You’ll burn for what you've done!"" |
| `[43]` | **""Titus. Take him out.""** | `[40]` **Rico Toras**: ""You'll go to hell for this!""<br>`[168]` **Rico Toras**: ""You’ll rot in hell for this!""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Executed"] = true; Variable["Rizi...`<br>`RemoveConversant("Rico Toras"); ;` | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." |
| `[44]` | **""You are lucky that I've spared your life, cousin. Don't ever forget this day.""** | `[40]` **Rico Toras**: ""You'll go to hell for this!""<br>`[168]` **Rico Toras**: ""You’ll rot in hell for this!""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Narrator**: "I turned to Hubertus." |
| `[46]` | **""Arrest him immediately!""** | `[40]` **Rico Toras**: ""You'll go to hell for this!""<br>`[168]` **Rico Toras**: ""You’ll rot in hell for this!""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Arrested"] = true; Variable["Rizi...` | `[171]` **Narrator**: "Before he could get a word out, ..." |
| `[48]` | **""God... I've wanted to do that for so long.""** | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "Lucita's gaze lingered on Hugo a..."<br>`[122]` **Narrator**: "Hubertus stared at the blood on ..." |
| `[49]` | **"'Goodbye, Ricardus.""** | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "Lucita's gaze lingered on Hugo a..."<br>`[122]` **Narrator**: "Hubertus stared at the blood on ..." |
| `[50]` | **""Enough of this nonsense." [Sign the decree to revoke House Toras' titles.]"** | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "I stepped over to the table and ..." |
| `[52]` | **"“Now’s your chance, Uncle. Show me family loyalty above everything else and admit ..."** | `[51]` **Narrator**: "I turned to Hugo." | `Variable["RiziaDLC.Turn09_Coup_Warning"] == true` | *Brak zmian stanu* | `[53]` **Rico Toras**: ""Father. You don't need to expla..."<br>`[55]` **Narrator**: "Hugo took a commanding step towa..." |
| `[56]` | **"Stare at him."** | `[51]` **Narrator**: "I turned to Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Hugo Toras**: ""If you're expecting some sort o..."<br>`[244]` **Hugo Toras**: ""I don't know what your game is,..." |
| `[63]` | **""I hope you've now recognized the seriousness of your situation.""** | `[51]` **Narrator**: "I turned to Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Hugo Toras**: ""I don't know what your game is,..."<br>`[239]` **Hugo Toras**: ""I don't know what your game is,..." |
| `[65]` | **"“What say you, House Toras? Is there anything you'd like to confess before the Lord?""** | `[51]` **Narrator**: "I turned to Hugo." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Turn09_Coup_Warning"] == true` | *Brak zmian stanu* | `[142]` **Hugo Toras**: ""The only thing I have to 'confe..." |
| `[66]` | **""Tarnished it may be, but *my* bloodline will be just fine. Though, I can't say th..."** | `[351]` **Hugo Toras**: ""Do what you must. But no matter..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true` | *Brak zmian stanu* | `[263]` **Narrator**: "Disgust was written all over his..." |
| `[73]` | **""Titus, take him into custody -- immediately.""** | `[285]` **Sevrio Castellanus**: ""May he find redemption in the a..."<br>`[72]` **Narrator**: "Hugo fell to the floor and took ..." | `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false` | `Variable["RiziaDLC.Hugo_Arrested"] = true; Variable["Rizi...` | `[74]` **Narrator**: "Titus motioned to several nearby..." |
| `[75]` | **""Titus, see to it that he joins his son in the afterlife.""** | `[285]` **Sevrio Castellanus**: ""May he find redemption in the a..."<br>`[72]` **Narrator**: "Hugo fell to the floor and took ..." | `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false` | `Variable["RiziaDLC.Hugo_Executed"] = true; Variable["Rizi...` | `[275]` **Hugo Toras**: ""May the Divine curse your soul,..." |
| `[78]` | **"“Well?”"** | `[77]` **Narrator**: "Hubertus stared at the blood on ..."<br>`[83]` **Narrator**: "Hubertus looked petrified."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hubertus Toras**: ""Please, Your Majesty. I'm sure ..." |
| `[79]` | **"“The truth, Hubertus. I’ll have it now, one way or another.”"** | `[77]` **Narrator**: "Hubertus stared at the blood on ..."<br>`[83]` **Narrator**: "Hubertus looked petrified."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hubertus Toras**: ""Please, Your Majesty. I'm sure ..." |
| `[80]` | **""Are you finally ready to admit what you've done?”"** | `[77]` **Narrator**: "Hubertus stared at the blood on ..."<br>`[83]` **Narrator**: "Hubertus looked petrified."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hubertus Toras**: ""Please, Your Majesty. I'm sure ..." |
| `[86]` | **""I don't have time for this." [Sign the decree to revoke House Toras' titles.]"** | `[285]` **Sevrio Castellanus**: ""May he find redemption in the a..."<br>`[72]` **Narrator**: "Hugo fell to the floor and took ..." | `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false` | *Brak zmian stanu* | `[5]` **Narrator**: "I stepped over to the table and ..." |
| `[88]` | **""Enjoy that clean conscience in the dark cell waiting for you. Perhaps it’ll keep ..."** | `[87]` **Hugo Toras**: ""There’s nothing to judge! You h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "Hugo thrashed against the guards..." |
| `[89]` | **""If only self-righteousness were a defense. Shame it’s not.""** | `[87]` **Hugo Toras**: ""There’s nothing to judge! You h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "Hugo thrashed against the guards..." |
| `[90]` | **""Your conscience may be clear, but your hands are stained. And I will see that jus..."** | `[87]` **Hugo Toras**: ""There’s nothing to judge! You h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "Hugo thrashed against the guards..." |
| `[91]` | **"Say nothing."** | `[87]` **Hugo Toras**: ""There’s nothing to judge! You h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "Hugo thrashed against the guards..." |
| `[105]` | **""That's the last mistake you'll ever make. Titus. Shoot him.""** | `[104]` **Narrator**: "Before I could react, Rico spat ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Executed"] = true; Variable["Rizi...`<br>`RemoveConversant("Rico Toras"); ;` | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." |
| `[106]` | **""A bit too eager to make your point, don’t you think?""** | `[104]` **Narrator**: "Before I could react, Rico spat ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Titus grabbed Rico by his hair a..." |
| `[107]` | **""Arrest him at once!""** | `[104]` **Narrator**: "Before I could react, Rico spat ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Arrested"] = true; Variable["Rizi...` | `[118]` **Rico Toras**: ""Go on, throw me behind bars! It..." |
| `[108]` | **"Remain calm."** | `[104]` **Narrator**: "Before I could react, Rico spat ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Titus grabbed Rico by his hair a..." |
| `[111]` | **""Stand down, Titus. He is no threat anymore.""** | `[109]` **Titus Gordion**: ""Your Majesty, this man has defi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hubertus Toras**: ""Please, Your Majesty. I'm sure ..." |
| `[112]` | **""Put him behind bars to get his perspective sorted.”"** | `[109]` **Titus Gordion**: ""Your Majesty, this man has defi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Arrested"] = true; Variable["Rizi...` | `[118]` **Rico Toras**: ""Go on, throw me behind bars! It..." |
| `[113]` | **""That's not necessary, Titus. Small creatures may snap at a lion’s heel, but the l..."** | `[109]` **Titus Gordion**: ""Your Majesty, this man has defi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hubertus Toras**: ""Please, Your Majesty. I'm sure ..." |
| `[114]` | **""He has committed treason. For that, he must pay with his life.""** | `[109]` **Titus Gordion**: ""Your Majesty, this man has defi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Executed"] = true; Variable["Rizi...`<br>`RemoveConversant("Rico Toras"); ;` | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." |
| `[117]` | **"“From henceforth, the Toras family shall have no claim to Valenqiris. There is onl..."** | `[5]` **Narrator**: "I stepped over to the table and ..."<br>`[342]` **Narrator**: "With quivering hands, Hubertus m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Narrator**: "The Toras men stood in stunned s..."<br>`[32]` **Narrator**: "Rico and Hubertus stood in stunn..."<br>*(oraz 2 innych odgałęzień)* |
| `[126]` | **""Do go on. I’m fascinated to hear what else you have to say... while you still hav..."** | `[100]` **Rico Toras**: ""What is there to lose? Can't yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "Rico looked away, swallowing hard."<br>`[101]` **Narrator**: "Rico redirected his anger toward..." |
| `[127]` | **"“Don't you know that monsters have a way of making nightmares real? Guards, take h..."** | `[100]` **Rico Toras**: ""What is there to lose? Can't yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Arrested"] = true; Variable["Rizi...` | `[118]` **Rico Toras**: ""Go on, throw me behind bars! It..." |
| `[128]` | **""Perhaps you'd like to join your father?""** | `[100]` **Rico Toras**: ""What is there to lose? Can't yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "Rico looked away, swallowing hard."<br>`[101]` **Narrator**: "Rico redirected his anger toward..." |
| `[131]` | **"“A monster? Is that the best you've got, Rico? If that’s all you see, then perhaps..."** | `[100]` **Rico Toras**: ""What is there to lose? Can't yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Executed"] = true; Variable["Rizi...`<br>`RemoveConversant("Rico Toras"); ;` | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." |
| `[136]` | **""What say you, Hubertus? Anything you'd like to add?""** | `[130]` **Rico Toras**: ""My apologies. I was out of line."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hubertus Toras**: ""Please, Your Majesty. I'm sure ..." |
| `[137]` | **""Now's your chance to apologize too, Hubertus.""** | `[130]` **Rico Toras**: ""My apologies. I was out of line."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hubertus Toras**: ""Please, Your Majesty. I'm sure ..." |
| `[138]` | **""Only one of you apologized. Interesting...""** | `[130]` **Rico Toras**: ""My apologies. I was out of line."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hubertus Toras**: ""Please, Your Majesty. I'm sure ..." |
| `[150]` | **""Whether you speak or not, the outcome remains the same.""** | `[149]` **Hugo Toras**: ""I don't know what your game is,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Rico Toras**: ""Father. You don't need to expla..."<br>`[153]` **Hugo Toras**: ""I swore undying loyalty to you,..." |
| `[151]` | **""Your stubbornness is almost admirable. Almost.""** | `[149]` **Hugo Toras**: ""I don't know what your game is,..."<br>`[239]` **Hugo Toras**: ""I don't know what your game is,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Hugo Toras**: ""'Stubbornness?' No. It's convic..." |
| `[152]` | **""I almost pity you, Uncle -- holding on to pride as everything else crumbles aroun..."** | `[149]` **Hugo Toras**: ""I don't know what your game is,..."<br>`[239]` **Hugo Toras**: ""I don't know what your game is,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Hugo Toras**: ""You speak of pride as if it’s a..." |
| `[162]` | **""Drop the act, Hugo. I know it was you who killed Father.""** | `[141]` **Hugo Toras**: "“Your father would have been ash..." | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true` | *Brak zmian stanu* | `[302]` **Hugo Toras**: ""What?! How dare you even--"" |
| `[163]` | **""What do you think would have disappointed him more? What I've become, or the cowa..."** | `[141]` **Hugo Toras**: "“Your father would have been ash..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Hugo Toras**: ""Cowardice?!"" |
| `[164]` | **""If you think your little moral lecture matters at this point, you’re gravely mist..."** | `[141]` **Hugo Toras**: "“Your father would have been ash..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Hugo Toras**: ""What do you take me for, my nep..." |
| `[204]` | **""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""** | `[219]` **Lucita Azaro**: ""I never imagined you would take..."<br>`[226]` **Lucita Azaro**: ""Your Majesty... I never imagine..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Narrator**: "Her frustration was evident, but..." |
| `[210]` | **""Sometimes things fall into place when you have the proper leverage.""** | `[223]` **Lucita Azaro**: ""Well, that went more smoothly t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Lucita Azaro**: ""Yes, leverage is everything."" |
| `[211]` | **""Yes, but let’s not get ahead of ourselves.""** | `[223]` **Lucita Azaro**: ""Well, that went more smoothly t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Lucita Azaro**: ""Naturally."" |
| `[212]` | **""A reminder that the simplest approach can often be the most effective.""** | `[223]` **Lucita Azaro**: ""Well, that went more smoothly t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Lucita Azaro**: ""Agreed."" |
| `[213]` | **""Perhaps you underestimated my resolve. A mistake, I trust, you won't make again.""** | `[219]` **Lucita Azaro**: ""I never imagined you would take..."<br>`[226]` **Lucita Azaro**: ""Your Majesty... I never imagine..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Lucita Azaro**: ""Your resolve is clearer than ev..." |
| `[214]` | **""You may not see it now, but this will secure the future of the kingdom.""** | `[219]` **Lucita Azaro**: ""I never imagined you would take..."<br>`[226]` **Lucita Azaro**: ""Your Majesty... I never imagine..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Lucita Azaro**: ""I truly hope you're right, for ..." |
| `[240]` | **""Whether you play or not, the outcome remains the same.""** | `[239]` **Hugo Toras**: ""I don't know what your game is,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Rico Toras**: ""Father. You don't need to expla..."<br>`[153]` **Hugo Toras**: ""I swore undying loyalty to you,..." |
| `[248]` | **""Now's your chance, Uncle. Prove to me that family loyalty comes before all else.""** | `[51]` **Narrator**: "I turned to Hugo." | `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false` | *Brak zmian stanu* | `[53]` **Rico Toras**: ""Father. You don't need to expla..."<br>`[55]` **Narrator**: "Hugo took a commanding step towa..." |
| `[257]` | **""Father never gave a damn about me, and neither did you.""** | `[141]` **Hugo Toras**: "“Your father would have been ash..." | `Variable["RiziaDLC.Prologue_FalloutWithDad"]` | *Brak zmian stanu* | `[302]` **Hugo Toras**: ""What?! How dare you even--"" |
| `[258]` | **""Every action I've taken has been for Rizia -- and Rizia alone.""** | `[141]` **Hugo Toras**: "“Your father would have been ash..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Hugo Toras**: ""Damn it, Romus. Do you even hea..." |
| `[260]` | **""Place him under arrest.""** | `[259]` **Titus Gordion**: ""Yes, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Narrator**: "I nodded to Titus, who gave the ..."<br>`[288]` **Narrator**: "I nodded to Titus, who gave the ..." |
| `[261]` | **""Shoot him.""** | `[259]` **Titus Gordion**: ""Yes, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Narrator**: "For the first time, I saw terror..." |
| `[264]` | **""Titus. Shoot him." [Point to Rico]"** | `[263]` **Narrator**: "Disgust was written all over his..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Executed"] = true; Variable["Rizi...` | `[67]` **Narrator**: "I looked to Titus, a single, sil..." |
| `[265]` | **""It's over, Hugo. Under the authority vested in me as king, I place you under arre..."** | `[263]` **Narrator**: "Disgust was written all over his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Narrator**: "I nodded to Titus, who gave the ..."<br>`[288]` **Narrator**: "I nodded to Titus, who gave the ..." |
| `[266]` | **""Here, I'll save you the trouble." [Sign the decree to revoke House Toras' titles ..."** | `[263]` **Narrator**: "Disgust was written all over his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "I stepped over to the table and ..." |
| `[271]` | **""Titus. Take him out as well.""** | `[38]` **Rico Toras**: ""FATHER!"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Executed"] = true; Variable["Rizi...`<br>`RemoveConversant("Rico Toras"); ;` | `[45]` **Narrator**: "I nodded to Titus. The muzzle of..." |
| `[343]` | **""And I am willing to go even further. Sign the papers or face the consequences.""** | `[340]` **Hugo Toras**: ""Until now. You have simply gone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Narrator**: "Hugo's face was full of indescri..." |
| `[344]` | **""So you admit it. House Toras is guilty.""** | `[340]` **Hugo Toras**: ""Until now. You have simply gone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Narrator**: "Hugo's face was full of indescri..." |
| `[348]` | **""Why can't you just admit it? You murdered King Valero!""** | `[340]` **Hugo Toras**: ""Until now. You have simply gone..." | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true` | *Brak zmian stanu* | `[350]` **Narrator**: "Hugo's face was full of indescri..." |
| `[349]` | **""Perhaps my harshness towards you has been misguided. But I cannot turn back now.""** | `[340]` **Hugo Toras**: ""Until now. You have simply gone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Narrator**: "Hugo's face was full of indescri..." |

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
  - -> `[51]` (*Narrator: "I turned to Hugo."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> "“Family loyalty? You abandoned that the moment you took the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Well, then let me save you the trouble." [Sign the decree to revoke House Toras' titles.]"]** — Mówca: **Player_Romus**
> ""Well, then let me save you the trouble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[351]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "Jump to: [Toras_Signature_Hub]"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I stepped over to the table and penned my name to the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Toras_StripTitles..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Let it be known that from this day forward, Hugo, you shall no longer hold your title, nor shall Ricardus or Hubertus.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Hugo_Executed"] == false  or  Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.Hubertus_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[342]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Exec..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "The Toras men stood in stunned silence, their faces a mix of disbelief and shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""You always did have a way with words. Tell it to the judge." [Gesture at Titus to arrest him.]"]** — Mówca: **Player_Romus**
> ""You always did have a way with words. Tell it to the judge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[351]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only stain on our bloodline is you. Titus?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[351]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Hugo turned to Titus. There was panic in his eyes."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Congratulations. Your blood is worth no more than that of a commoner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[342]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Exec..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Henceforth, I erase all your rights, privileges, and noble standing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[342]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Exec..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Hugo Toras: ""Titus?""*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Hugo turned to Titus. There was panic in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Titus Gordion: ""Yes, Your Majesty?""*)

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""Titus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Titus Gordion: ""I'm sorry, old friend.""*)

### Węzeł `[15]`
Mówca: **Titus Gordion**
> ""I'm sorry, old friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "A flicker of hesitation crossed Titus' face, but with a s..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "A flicker of hesitation crossed Titus' face, but with a steadying breath, he pulled the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[17]`
Mówca: **Narrator**
> "His jaw clenched tightly as Hugo's body crumpled lifelessly to the floor, blood pooling around him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Rico sprang from his seat, but armed men quickly descende..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Hubertus stared at the blood on the floor, his mouth trem..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not what I meant, Titus. Oh well. Too late now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Executed == false || RiziaDLC.Hubertus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Executed..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Execut..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Executed == false || RiziaDLC.Hubertus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  or  Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.Hubertus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: "“Let it be known that from this day forward, Hugo, you sh..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Executed == false || RiziaDLC.Hubertus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  or  Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.Hubertus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: "“Let it be known that from this day forward, Hugo, Ricard..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Let it be known that from this day forward, Hugo, Ricardus, and Hubertus Toras shall no longer hold your noble title, even posthumously.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Hugo_Executed"] == false  or  Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.Hubertus_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[342]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Exec..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false && (RiziaDLC.Rico_Executed == false && RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Exec..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Ex..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false && (RiziaDLC.Rico_Executed == false && RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hubertus_Executed"] == false  and  (Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "The Toras men stood in stunned silence, their faces a mix..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false && (RiziaDLC.Rico_Executed == false && RiziaDLC.BirthdayGathering_Invited_Rico == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hubertus_Executed"] == false  and  (Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Exec..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Executed == false || RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Exec..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Ex..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Executed == false || RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hubertus_Executed"] == false  and (Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Rico and Hubertus stood in stunned silence, their faces a..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Executed == false || RiziaDLC.BirthdayGathering_Invited_Rico == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hubertus_Executed"] == false  and (Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Exec..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Rico and Hubertus stood in stunned silence, their faces a mix of disbelief and shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Hubertus stood in stunned silence, his face a mix of disbelief and shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Hugo and Hubertus stood in stunned silence, their faces a mix of disbelief and shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Exec..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Ex..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hubertus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Hugo and Hubertus stood in stunned silence, their faces a..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hubertus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Hubertus stood in stunned silence, his face a mix of disb..."*)

### Węzeł `[38]`
Mówca: **Rico Toras**
> ""FATHER!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Titus. Take him out as well.""*)
  - -> `[42]` (*Player_Romus: ""Save your tears, Rico. Your father’s legacy is no longer..."*)
  - -> `[39]` (*Player_Romus: ""Something you'd like to add, Cousin?""*)
  - -> `[41]` (*Player_Romus: ""The sins of the family will not be overlooked.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something you'd like to add, Cousin?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Rico Toras: ""You'll go to hell for this!""*)

### Węzeł `[40]`
Mówca: **Rico Toras**
> ""You'll go to hell for this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""Arrest him immediately!""*)
  - -> `[43]` (*Player_Romus: ""Titus. Take him out.""*)
  - -> `[44]` (*Player_Romus: ""You are lucky that I've spared your life, cousin. Don't ..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The sins of the family will not be overlooked.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Rico Toras: ""You’ll rot in hell for this!""*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Save your tears, Rico. Your father’s legacy is no longer of concern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Rico Toras: ""You’ll burn for what you've done!""*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Take him out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Rico Toras), `[168]` (Rico Toras), `[169]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Rico_Executed_Hub"*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are lucky that I've spared your life, cousin. Don't ever forget this day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Rico Toras), `[168]` (Rico Toras), `[169]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "I turned to Hubertus."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "I nodded to Titus. The muzzle of his gun flashed, and Rico was silenced forever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""Enough of this nonsense." [Sign the decree to revoke Hou..."*)
  - -> `[48]` (*Player_Romus: ""God... I've wanted to do that for so long.""*)
  - -> `[21]` (*Player_Romus: ""That's not what I meant, Titus. Oh well. Too late now.""*)
  - -> `[49]` (*Player_Romus: "'Goodbye, Ricardus.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Arrest him immediately!""]** — Mówca: **Player_Romus**
> ""Arrest him immediately!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Rico Toras), `[168]` (Rico Toras), `[169]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rico_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Rico Toras");"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God... I've wanted to do that for so long.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "'Goodbye, Ricardus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Enough of this nonsense." [Sign the decree to revoke House Toras' titles.]"]** — Mówca: **Player_Romus**
> ""Enough of this nonsense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "Jump to: [Toras_Signature_Hub]"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I turned to Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""I hope you've now recognized the seriousness of your sit..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09_C..."*)
  - -> `[56]` (*Player_Romus_Italic: "Stare at him."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Now’s your chance, Uncle. Show me family loyalty above everything else and admit what you did.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[53]`
Mówca: **Rico Toras**
> ""Father. You don't need to explain yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""Quiet, Rico.""*)

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""Quiet, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Hugo took a commanding step toward me."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Hugo took a commanding step toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Hugo Toras: "“Family loyalty? You abandoned that the moment you took t..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "Stare at him."]** — Mówca: **Player_Romus_Italic**
> "I stared him down, not uttering a word."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Rico Toras: ""Father. You don't need to explain yourself.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Hugo took a commanding step toward me."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09_Coup_Warning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09_C..."*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09_Coup_Warning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: "“What say you, House Toras? Is there anything you'd like ..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09_Coup_Warning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you've now recognized the seriousness of your situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""If you're expecting some sort of admission, you won't get anything out of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Hugo Toras: ""I gave you my trust, Romus. And for family to betray fam..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“What say you, House Toras? Is there anything you'd like to confess before the Lord?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Hugo Toras: ""The only thing I have to 'confess' is that I swore my fe..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tarnished it may be, but *my* bloodline will be just fine. Though, I can't say the same for *yours*.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Kontekst wejściowy (poprzednik):** `[351]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "Disgust was written all over his face. I looked at Rico."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "I looked to Titus, a single, silent command passing between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Hugo Toras: ""NO!""*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Without hesitation, he raised his gun and fired. A single shot echoed through the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Rico’s body crumpled lifelessly to the floor, blood pooling around him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Hugo screamed, his face pale with horror as he watched his son fall. Hubertus sat frozen, his mouth agape in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Hugo Toras: ""You… How could you? YOU KILLED MY SON!""*)

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""You… How could you? YOU KILLED MY SON!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Hugo fell to the floor and took Rico in his arms, rocking..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Hugo fell to the floor and took Rico in his arms, rocking him back and forth. His face was ashen and hollow, eyes locked on his son’s lifeless form."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, take him into custody -- immediately.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[285]` (Sevrio Castellanus), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Titus motioned to several nearby men in uniform, who picked Hugo off the ground, tied his hands behind his back and escorted him to the far wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, see to it that he joins his son in the afterlife.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[285]` (Sevrio Castellanus), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Before I could register what had happened, Hugo hit the floor, dead -- the shot from Titus’s gun still ringing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Hubertus stared at the blood on the floor, his mouth trembling in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_1"*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Well?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[83]` (Narrator), `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_2"*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“The truth, Hubertus. I’ll have it now, one way or another.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[83]` (Narrator), `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_2"*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you finally ready to admit what you've done?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[83]` (Narrator), `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_2"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Hubertus_Hub_1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: "“The truth, Hubertus. I’ll have it now, one way or another.”"*)
  - -> `[78]` (*Player_Romus: "“Well?”"*)
  - -> `[80]` (*Player_Romus: ""Are you finally ready to admit what you've done?”"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hubertus_Hub_1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_1"*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Hubertus looked petrified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_1"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Titus motioned to several nearby men in uniform, who pick..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Hugo Toras: ""May the Divine curse your soul, Romus.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""I don't have time for this." [Sign the decree to revoke House Toras' titles.]"]** — Mówca: **Player_Romus**
> ""I don't have time for this.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[285]` (Sevrio Castellanus), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "Jump to: [Toras_Signature_Hub]"*)

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""There’s nothing to judge! You hear me? My conscience is clear! Can you say the same?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""Your conscience may be clear, but your hands are stained..."*)
  - -> `[88]` (*Player_Romus: ""Enjoy that clean conscience in the dark cell waiting for..."*)
  - -> `[89]` (*Player_Romus: ""If only self-righteousness were a defense. Shame it’s not.""*)
  - -> `[91]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enjoy that clean conscience in the dark cell waiting for you. Perhaps it’ll keep you company.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Hugo thrashed against the guards’ grip, his voice rising ..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If only self-righteousness were a defense. Shame it’s not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Hugo thrashed against the guards’ grip, his voice rising ..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your conscience may be clear, but your hands are stained. And I will see that justice is done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Hugo thrashed against the guards’ grip, his voice rising ..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing, letting silence be my answer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Hugo thrashed against the guards’ grip, his voice rising ..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Hugo thrashed against the guards’ grip, his voice rising in protest, as they tied his hands behind his back and hauled him to the far side of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Rico Toras: ""You fucking monster.""*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "I turned my attention toward Hubertus, who looked petrified."*)

### Węzeł `[96]`
Mówca: **Rico Toras**
> ""You fucking monster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hubertus Toras: ""Ricardus! Do not test His Majesty's patience further!""*)

### Węzeł `[97]`
Mówca: **Hubertus Toras**
> ""Ricardus! Do not test His Majesty's patience further!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Rico Toras: ""What is there to lose? Can't you see he's set on destroy..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rico_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I looked to Titus, a single, silent command passing betwe..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Hugo Toras: ""There’s nothing to judge! You hear me? My conscience is ..."*)

### Węzeł `[100]`
Mówca: **Rico Toras**
> ""What is there to lose? Can't you see he's set on destroying us all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Romus: ""Do go on. I’m fascinated to hear what else you have to s..."*)
  - -> `[127]` (*Player_Romus: "“Don't you know that monsters have a way of making nightm..."*)
  - -> `[128]` (*Player_Romus: ""Perhaps you'd like to join your father?""*)
  - -> `[131]` (*Player_Romus: "“A monster? Is that the best you've got, Rico? If that’s ..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Rico redirected his anger toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Rico Toras: ""You know what you are? You’re just a scared little man h..."*)

### Węzeł `[102]`
Mówca: **Rico Toras**
> ""You know what you are? You’re just a scared little man hiding behind all this -- what, power? Fear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Rico Toras: ""You're got nothing but weakness in you! You’re no king o..."*)

### Węzeł `[103]`
Mówca: **Rico Toras**
> ""You're got nothing but weakness in you! You’re no king of mine!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Before I could react, Rico spat in my face."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Before I could react, Rico spat in my face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player_Romus: ""That's the last mistake you'll ever make. Titus. Shoot h..."*)
  - -> `[107]` (*Player_Romus: ""Arrest him at once!""*)
  - -> `[106]` (*Player_Romus: ""A bit too eager to make your point, don’t you think?""*)
  - -> `[108]` (*Player_Romus_Italic: "Remain calm."*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the last mistake you'll ever make. Titus. Shoot him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rico_Executed_Hub]"*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A bit too eager to make your point, don’t you think?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Titus grabbed Rico by his hair and yanked him back, elici..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest him at once!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "Remain calm."]** — Mówca: **Player_Romus_Italic**
> "I displayed no outward reaction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Titus grabbed Rico by his hair and yanked him back, elici..."*)

### Węzeł `[109]`
Mówca: **Titus Gordion**
> ""Your Majesty, this man has defied the King of Rizia to his face -- an act demanding the gravest consequence. How do you wish me to proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus: ""He has committed treason. For that, he must pay with his..."*)
  - -> `[112]` (*Player_Romus: ""Put him behind bars to get his perspective sorted.”"*)
  - -> `[111]` (*Player_Romus: ""Stand down, Titus. He is no threat anymore.""*)
  - -> `[113]` (*Player_Romus: ""That's not necessary, Titus. Small creatures may snap at..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Titus grabbed Rico by his hair and yanked him back, eliciting a cry of pain from my insubordinate cousin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Titus Gordion: ""Your Majesty, this man has defied the King of Rizia to h..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stand down, Titus. He is no threat anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_2]"*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Put him behind bars to get his perspective sorted.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not necessary, Titus. Small creatures may snap at a lion’s heel, but the lion remains unmoved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_2]"*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He has committed treason. For that, he must pay with his life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rico_Executed_Hub]"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Rico_Executed_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rico_Executed_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Rico_Executed_Hub"*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“From henceforth, the Toras family shall have no claim to Valenqiris. There is only the Crown.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[342]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Exec..."*)

### Węzeł `[118]`
Mówca: **Rico Toras**
> ""Go on, throw me behind bars! It won’t change the truth!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "He barely had time to curse me before two guards seized h..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rico_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Rico Toras: ""Go on, throw me behind bars! It won’t change the truth!""*)

### Węzeł `[120]`
Mówca: **Narrator**
> "He barely had time to curse me before two guards seized him and dragged him back to the area where Hugo was being held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "I directed my attention toward Hubertus."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "I directed my attention toward Hubertus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_1]"*)

### Węzeł `[122]`
Mówca: **Narrator**
> "Hubertus stared at the blood on the floor, his mouth quivering in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_1]"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hubertus_Hub_1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_1"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "I turned my attention toward Hubertus, who looked petrified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_1]"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hubertus_Hub_1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_1"*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do go on. I’m fascinated to hear what else you have to say... while you still have the chance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.I..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Don't you know that monsters have a way of making nightmares real? Guards, take him away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you'd like to join your father?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.I..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Rico looked away, swallowing hard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Rico Toras: ""My apologies. I was out of line.""*)

### Węzeł `[130]`
Mówca: **Rico Toras**
> ""My apologies. I was out of line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""What say you, Hubertus? Anything you'd like to add?""*)
  - -> `[137]` (*Player_Romus: ""Now's your chance to apologize too, Hubertus.""*)
  - -> `[138]` (*Player_Romus: ""Only one of you apologized. Interesting...""*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“A monster? Is that the best you've got, Rico? If that’s all you see, then perhaps you’re not paying attention.” [Execute Rico]"]** — Mówca: **Player_Romus**
> "“A monster? Is that the best you've got, Rico? If that’s all you see, then perhaps you’re not paying attention.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rico_Executed_Hub]"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rico_Executed_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Rico_Executed_Hub"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Iza_RicoControlsPolice == true || RiziaDLC.Rico_PoliceChief_PorteDrazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.I..."*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Iza_RicoControlsPolice == true || RiziaDLC.Rico_PoliceChief_PorteDrazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  or  Variable["RiziaDLC.Iza_RicoControlsPolice"] == true  or  Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Rico looked away, swallowing hard."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Iza_RicoControlsPolice == true || RiziaDLC.Rico_PoliceChief_PorteDrazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  or  Variable["RiziaDLC.Iza_RicoControlsPolice"] == true  or  Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Rico redirected his anger toward me."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What say you, Hubertus? Anything you'd like to add?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_2]"*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now's your chance to apologize too, Hubertus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_2]"*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only one of you apologized. Interesting...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_2]"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Hubertus_Hub_2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Hubertus Toras: ""Please, Your Majesty. I'm sure we can amicably resolve a..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hubertus_Hub_2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_2"*)

### Węzeł `[141]`
Mówca: **Hugo Toras**
> "“Your father would have been ashamed to see what you've become -- a ruler who'd cast his own family aside in pursuit of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""If you think your little moral lecture matters at this p..."*)
  - -> `[163]` (*Player_Romus: ""What do you think would have disappointed him more? What..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad"*)
  - -> `[258]` (*Player_Romus: ""Every action I've taken has been for Rizia -- and Rizia ..."*)

### Węzeł `[142]`
Mówca: **Hugo Toras**
> ""The only thing I have to 'confess' is that I swore my fealty to a king who never returned it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Hugo Toras: ""I gave you my trust, Romus. And for family to betray fam..."*)

### Węzeł `[143]`
Mówca: **Hugo Toras**
> ""I gave you my trust, Romus. And for family to betray family... that wound never heals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[144]`
Mówca: **Rico Toras**
> ""He never deserved your loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Hugo Toras: ""That's enough, Rico.""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Rico Toras: ""He never deserved your loyalty.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: "“Your father would have been ashamed to see what you've b..."*)

### Węzeł `[148]`
Mówca: **Hugo Toras**
> ""That's enough, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: "“Your father would have been ashamed to see what you've b..."*)

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""I don't know what your game is, Romus, but if you want some sort of admission, you'll get nothing out of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: ""I almost pity you, Uncle -- holding on to pride as every..."*)
  - -> `[151]` (*Player_Romus: ""Your stubbornness is almost admirable. Almost.""*)
  - -> `[150]` (*Player_Romus: ""Whether you speak or not, the outcome remains the same.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether you speak or not, the outcome remains the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your stubbornness is almost admirable. Almost.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Hugo Toras), `[239]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Hugo Toras: ""'Stubbornness?' No. It's conviction. Something you trade..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I almost pity you, Uncle -- holding on to pride as everything else crumbles around you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Hugo Toras), `[239]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Hugo Toras: ""You speak of pride as if it’s a failing, but after today..."*)

### Węzeł `[153]`
Mówca: **Hugo Toras**
> ""I swore undying loyalty to you, as family should, but you gave me nothing in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Hugo Toras: ""And for family to betray family... that wound never heals.""*)

### Węzeł `[154]`
Mówca: **Hugo Toras**
> ""'Stubbornness?' No. It's conviction. Something you traded away the moment you put that crown on your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[155]`
Mówca: **Hugo Toras**
> ""You speak of pride as if it’s a failing, but after today, it seems it might be all I have left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[156]`
Mówca: **Hugo Toras**
> ""And for family to betray family... that wound never heals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: "“Your father would have been ashamed to see what you've b..."*)

### Węzeł `[157]`
Mówca: **Rico Toras**
> ""Father. You don't need to explain yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Hugo Toras: ""Quiet, Rico.""*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Rico Toras: ""Father. You don't need to explain yourself.""*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Hugo Toras: ""I swore undying loyalty to you, as family should, but yo..."*)

### Węzeł `[161]`
Mówca: **Hugo Toras**
> ""Quiet, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "He turned to me."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Drop the act, Hugo. I know it was you who killed Father.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[141]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Hugo Toras: ""What?! How dare you even--""*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think would have disappointed him more? What I've become, or the cowardice you've embraced?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Hugo Toras: ""Cowardice?!""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you think your little moral lecture matters at this point, you’re gravely mistaken.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Hugo Toras: ""What do you take me for, my nephew?""*)

### Węzeł `[165]`
Mówca: **Hugo Toras**
> ""Cowardice?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "He recoiled in anger. When he spoke again, it was without..."*)

### Węzeł `[166]`
Mówca: **Hugo Toras**
> ""What do you take me for, my nephew?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "He recoiled in anger. When he spoke again, it was without..."*)

### Węzeł `[167]`
Mówca: **Hugo Toras**
> ""Damn it, Romus. Do you even hear yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "He recoiled in anger. When he spoke again, it was without..."*)

### Węzeł `[168]`
Mówca: **Rico Toras**
> ""You’ll rot in hell for this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""Arrest him immediately!""*)
  - -> `[43]` (*Player_Romus: ""Titus. Take him out.""*)
  - -> `[44]` (*Player_Romus: ""You are lucky that I've spared your life, cousin. Don't ..."*)

### Węzeł `[169]`
Mówca: **Rico Toras**
> ""You’ll burn for what you've done!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""Arrest him immediately!""*)
  - -> `[43]` (*Player_Romus: ""Titus. Take him out.""*)
  - -> `[44]` (*Player_Romus: ""You are lucky that I've spared your life, cousin. Don't ..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rico_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Before he could get a word out, two guards seized him and..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Before he could get a word out, two guards seized him and hauled him to the far side of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Rico Toras");"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "I turned to Hubertus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hubertus_Hub_1]"*)

### Węzeł `[173]`
Mówca: **Hubertus Toras**
> ""Please, Your Majesty. I'm sure we can amicably resolve any grievances you have with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Hubertus Toras: ""There's still time to make this right.""*)

### Węzeł `[174]`
Mówca: **Hubertus Toras**
> ""There's still time to make this right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "With quivering hands, Hubertus made his way to the table ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rico_Executed_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Rico_Executed_Hub"*)

### Węzeł `[176]`
Mówca: **Lucita Azaro**
> ""I suggest you stop now, Your Grace--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Hugo held up a hand, silencing her, before turning his ga..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Lucita Azaro: ""I suggest you stop now, Your Grace--""*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: "“Your father would have been ashamed to see what you've b..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Hugo held up a hand, silencing her, before turning his gaze back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: "“Your father would have been ashamed to see what you've b..."*)

### Węzeł `[181]`
Mówca: **Lucita Azaro**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucita Azaro: ""Dear God...""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Lucita's gaze lingered on Hugo and Rico, as if struggling..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Hubertus stared at the blood on the floor, his mouth quiv..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Lucita's gaze lingered on Hugo and Rico, as if struggling to process what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Hubertus stared at the blood on the floor, his mouth quiv..."*)

### Węzeł `[189]`
Mówca: **Lucita Azaro**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Hugo screamed, his face pale with horror as he watched hi..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucita Azaro: ""Dear God...""*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Hugo screamed, his face pale with horror as he watched hi..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Hubertus stared at the blood on the floor, his mouth trem..."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "Lucita's gaze lingered on Hugo and Rico, as if struggling to process what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Hubertus stared at the blood on the floor, his mouth trem..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""Tarnished it may be, but *my* bloodline will be just fin..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "Lucita's gaze lingered on Hugo and Rico, as if struggling..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Lucita's gaze lingered on Hugo, as if struggling to proce..."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "Lucita's gaze lingered on Hugo, as if struggling to process what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Hubertus stared at the blood on the floor, his mouth trem..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro), `[226]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Her frustration was evident, but she said nothing further."*)

### Węzeł `[205]`
Mówca: **Lucita Azaro**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[206]`
Mówca: **Lucita Azaro**
> ""Yes, leverage is everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lucita Azaro: ""Well, that went more smoothly than anticipated.""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sometimes things fall into place when you have the proper leverage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lucita Azaro: ""Yes, leverage is everything.""*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but let’s not get ahead of ourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucita Azaro: ""Naturally.""*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder that the simplest approach can often be the most effective.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucita Azaro: ""Agreed.""*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you underestimated my resolve. A mistake, I trust, you won't make again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro), `[226]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucita Azaro: ""Your resolve is clearer than ever.""*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but this will secure the future of the kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro), `[226]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucita Azaro: ""I truly hope you're right, for all our sakes.""*)

### Węzeł `[215]`
Mówca: **Narrator**
> "Her frustration was evident, but she said nothing further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == false)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""Your Majesty... I never imagined you would take it this ..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucita Azaro: ""I never imagined you would take it this far, Romus.""*)

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""I never imagined you would take it this far, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player_Romus: ""You may not see it now, but this will secure the future ..."*)
  - -> `[213]` (*Player_Romus: ""Perhaps you underestimated my resolve. A mistake, I trus..."*)
  - -> `[204]` (*Player_Romus: ""If you lack the stomach for hard decisions, perhaps it’s..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arrested == true || RiziaDLC.Hubertus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arrested ..."*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arreste..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arrested == true || RiziaDLC.Hubertus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Hubertus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arrested == true || RiziaDLC.Hubertus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Hubertus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[223]`
Mówca: **Lucita Azaro**
> ""Well, that went more smoothly than anticipated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""Yes, but let’s not get ahead of ourselves.""*)
  - -> `[210]` (*Player_Romus: ""Sometimes things fall into place when you have the prope..."*)
  - -> `[212]` (*Player_Romus: ""A reminder that the simplest approach can often be the m..."*)

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""Naturally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""Your Majesty... I never imagined you would take it this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player_Romus: ""You may not see it now, but this will secure the future ..."*)
  - -> `[213]` (*Player_Romus: ""Perhaps you underestimated my resolve. A mistake, I trus..."*)
  - -> `[204]` (*Player_Romus: ""If you lack the stomach for hard decisions, perhaps it’s..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "Lucita stepped near me, leaning in to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false"*)

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""Your resolve is clearer than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[229]`
Mówca: **Lucita Azaro**
> ""I truly hope you're right, for all our sakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Executed ..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Executed == true || RiziaDLC.Hubertus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Executed ..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Execute..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Executed == true || RiziaDLC.Hubertus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true  or  Variable["RiziaDLC.Hubertus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "Lucita stepped near me, leaning in to whisper."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Executed == true || RiziaDLC.Hubertus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true  or  Variable["RiziaDLC.Hubertus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arrested ..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_Coup_Warning == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Hugo Toras: ""I don't know what your game is, Romus, but if you want s..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_Coup_Warning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Hugo Toras: ""I don't know what your game is, Romus, but I refuse to p..."*)

### Węzeł `[239]`
Mówca: **Hugo Toras**
> ""I don't know what your game is, Romus, but I refuse to play along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: ""I almost pity you, Uncle -- holding on to pride as every..."*)
  - -> `[151]` (*Player_Romus: ""Your stubbornness is almost admirable. Almost.""*)
  - -> `[240]` (*Player_Romus: ""Whether you play or not, the outcome remains the same.""*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether you play or not, the outcome remains the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_Coup_Warning == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""If you're expecting some sort of admission, you won't ge..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_Coup_Warning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Hugo Toras: ""I don't know what your game is, Romus, but I refuse to b..."*)

### Węzeł `[244]`
Mówca: **Hugo Toras**
> ""I don't know what your game is, Romus, but I refuse to be a part of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Hugo Toras: ""I gave you my trust, Romus. And for family to betray fam..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_Coup_Warning == true)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: "“Now’s your chance, Uncle. Show me family loyalty above e..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_Coup_Warning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Player_Romus: ""Now's your chance, Uncle. Prove to me that family loyalt..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now's your chance, Uncle. Prove to me that family loyalty comes before all else.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "His jaw clenched tightly as Hugo's body crumpled lifeless..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Rico Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Rico Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "I turned to Hubertus."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Rico Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Rico Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I nodded to Titus. The muzzle of his gun flashed, and Ric..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Hubertus looked petrified."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Rico Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Rico Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Rico’s body crumpled lifelessly to the floor, blood pooli..."*)

### Węzeł `[256]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: "“Your father would have been ashamed to see what you've b..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Father never gave a damn about me, and neither did you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FalloutWithDad"]`
- **Kontekst wejściowy (poprzednik):** `[141]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Hugo Toras: ""What?! How dare you even--""*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Every action I've taken has been for Rizia -- and Rizia alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Hugo Toras: ""Damn it, Romus. Do you even hear yourself?""*)

### Węzeł `[259]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""Shoot him.""*)
  - -> `[260]` (*Player_Romus: ""Place him under arrest.""*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Place him under arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "Jump to: [Arrest_Hugo_Hub]"*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shoot him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "For the first time, I saw terror in my guardsman's eyes, ..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "For the first time, I saw terror in my guardsman's eyes, betraying his usual composed demeanor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "Disgust was written all over his face. I looked at Rico."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Player_Romus: ""Titus. Shoot him." [Point to Rico]"*)
  - -> `[266]` (*Player_Romus: ""Here, I'll save you the trouble." [Sign the decree to re..."*)
  - -> `[265]` (*Player_Romus: ""It's over, Hugo. Under the authority vested in me as kin..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA: ""Titus. Shoot him." [Point to Rico]"]** — Mówca: **Player_Romus**
> ""Titus. Shoot him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's over, Hugo. Under the authority vested in me as king, I place you under arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "Jump to: [Arrest_Hugo_Hub]"*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""Here, I'll save you the trouble." [Sign the decree to revoke House Toras' titles and seize Valenqiris]"]** — Mówca: **Player_Romus**
> ""Here, I'll save you the trouble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "Jump to: [Toras_Signature_Hub]"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Toras_Signature_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "Toras_Signature_Hub"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Toras_Signature_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "Toras_Signature_Hub"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Toras_Signature_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "Toras_Signature_Hub"*)

### Węzeł `[270]`
Mówca: **Narrator**
> "Rico sprang from his seat, but armed men quickly descended upon him, pinning him to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Rico Toras: ""FATHER!""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Take him out as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Rico_Executed_Hub"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Arrest_Hugo_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "Arrest_Hugo_Hub"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Arrest_Hugo_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "Arrest_Hugo_Hub"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Toras_Signature_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "Toras_Signature_Hub"*)

### Węzeł `[275]`
Mówca: **Hugo Toras**
> ""May the Divine curse your soul, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "A flicker of hesitation crossed Titus' face, but with a s..."*)

### Węzeł `[276]`
Mówca: **Titus Gordion**
> ""I'm sorry, old friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "A flicker of hesitation crossed Titus' face, but with a steadying breath, he pulled the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Titus Gordion: ""I'm sorry, old friend.""*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Sevrio Castellanus: ""May he find redemption in the afterlife.""*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[281]`
Mówca: **Sevrio Castellanus**
> ""May he find redemption in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Sevrio Castellanus: ""May he find redemption in the afterlife.""*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""Titus, take him into custody -- immediately.""*)
  - -> `[86]` (*Player_Romus: ""I don't have time for this." [Sign the decree to revoke ..."*)
  - -> `[75]` (*Player_Romus: ""Titus, see to it that he joins his son in the afterlife.""*)

### Węzeł `[285]`
Mówca: **Sevrio Castellanus**
> ""May he find redemption in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""Titus, take him into custody -- immediately.""*)
  - -> `[86]` (*Player_Romus: ""I don't have time for this." [Sign the decree to revoke ..."*)
  - -> `[75]` (*Player_Romus: ""Titus, see to it that he joins his son in the afterlife.""*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Without a moment's hesitation, his guardsmen grabbed Hugo and dragged him toward the back wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[287]`
Mówca: **Narrator**
> "Sevrio grabbed Hugo and dragged him toward the back wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "I nodded to Titus, who gave the signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Without a moment's hesitation, his guardsmen grabbed Hugo..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "I nodded to Titus, who gave the signal to Sevrio."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "I nodded to Titus, who gave the signal."*)

### Węzeł `[292]`
Mówca: **Sevrio Castellanus**
> ""You know what to do. Move!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "Sevrio grabbed Hugo and dragged him toward the back wall."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "I nodded to Titus, who gave the signal to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Sevrio Castellanus: ""You know what to do. Move!""*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Toras_Signature_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I stepped over to the table and penned my name to the dec..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Arrest_Hugo_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: ""Father never gave a damn about me, and neither did you.""*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""Drop the act, Hugo. I know it was you who killed Father.""*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[302]`
Mówca: **Hugo Toras**
> ""What?! How dare you even--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "He recoiled in anger. When he spoke again, it was without..."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "He recoiled in anger. When he spoke again, it was without passion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Hugo Toras: ""All these years, I have done nothing but stand by you an..."*)

### Węzeł `[304]`
Mówca: **Hugo Toras**
> ""All these years, I have done nothing but stand by you and your family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Hugo Toras: ""When the rest of our family called your mother a gold-di..."*)

### Węzeł `[305]`
Mówca: **Hugo Toras**
> ""When the rest of our family called your mother a gold-digging harlot -- not without merit, mind you -- who came to her defense?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HadAffairs == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Hugo Toras: ""All those years you were unfaithful to your wife -- who ..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HadAffairs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[309]`
Mówca: **Hugo Toras**
> ""All those years you were unfaithful to your wife -- who do you think helped keep that a secret?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true )"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Hugo Toras: ""I didn't say a word when you and your butler revealed yo..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_WeddingDate == true"*)

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""I didn't say a word when you and your butler revealed your shameful *proclivities* to the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[314]`
Mówca: **Hugo Toras**
> ""I never said a word about your barely disguised *proclivities*, despite them being an affront to God and nature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_WeddingDate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_WeddingDate == true"*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_WeddingDate == true)"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_WeddingDate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_WeddingDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Hugo Toras: ""I never said a word about your barely disguised *procliv..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_WeddingDate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_WeddingDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Extradited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Extradited == true)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Extradited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Hugo Toras: ""And even when you sent my son to his doom--""*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Extradited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed =..."*)

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""And even when you sent my son to his doom--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "His voice caught in his throat."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "His voice caught in his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Hugo Toras: ""Did I lash out? No! I gracefully stepped down to continu..."*)

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""Did I lash out? No! I gracefully stepped down to continue serving House Toras from afar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed =..."*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Rico_Deposed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Hugo Toras: ""Even when you humiliated my only son--""*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Rico_Deposed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)

### Węzeł `[327]`
Mówca: **Hugo Toras**
> ""Even when you humiliated my only son--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "His voice caught in his throat."*)

### Węzeł `[328]`
Mówca: **Narrator**
> "His voice caught in his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Hugo Toras: ""Even then, I chose to serve you rather than lash out in ..."*)

### Węzeł `[329]`
Mówca: **Hugo Toras**
> ""Even then, I chose to serve you rather than lash out in defense of his honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Hugo Toras: ""Even when your daughter made a mockery of my son on thei..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)

### Węzeł `[333]`
Mówca: **Hugo Toras**
> ""Even when your daughter made a mockery of my son on their wedding day--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "He looked at Rico, who was practically seething."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "He looked at Rico, who was practically seething."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Hugo Toras: ""Even then, I chose to serve you rather than lash out in ..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true)"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Hugo Toras: ""Yes, there were times when House Toras entreated me to t..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Hugo Toras: ""Yes, there were times when I dared to dream of how I wou..."*)

### Węzeł `[338]`
Mówca: **Hugo Toras**
> ""Yes, there were times when House Toras entreated me to take your place as the rightful king, and times when I dared to dream of how I would rule in your stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Hugo Toras: ""But I never, ever would have gone so far as to contempla..."*)

### Węzeł `[339]`
Mówca: **Hugo Toras**
> ""But I never, ever would have gone so far as to contemplate rising against you, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Hugo Toras: ""Until now. You have simply gone too far.""*)

### Węzeł `[340]`
Mówca: **Hugo Toras**
> ""Until now. You have simply gone too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player_Romus: ""And I am willing to go even further. Sign the papers or ..."*)
  - -> `[349]` (*Player_Romus: ""Perhaps my harshness towards you has been misguided. But..."*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true"*)
  - -> `[344]` (*Player_Romus: ""So you admit it. House Toras is guilty.""*)

### Węzeł `[341]`
Mówca: **Hugo Toras**
> ""Yes, there were times when I dared to dream of how I would rule in your stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Hugo Toras: ""But I never, ever would have gone so far as to contempla..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "With quivering hands, Hubertus made his way to the table and signed the decree revoking House Toras' titles and transferring its lands to the Crown's ownership."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Toras_StripTitles..."*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I am willing to go even further. Sign the papers or face the consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "Hugo's face was full of indescribable sadness."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you admit it. House Toras is guilty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "Hugo's face was full of indescribable sadness."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player_Romus: ""Why can't you just admit it? You murdered King Valero!""*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why can't you just admit it? You murdered King Valero!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[340]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "Hugo's face was full of indescribable sadness."*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps my harshness towards you has been misguided. But I cannot turn back now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "Hugo's face was full of indescribable sadness."*)

### Węzeł `[350]`
Mówca: **Narrator**
> "Hugo's face was full of indescribable sadness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Hugo Toras: ""Do what you must. But no matter how much you tarnish our..."*)

### Węzeł `[351]`
Mówca: **Hugo Toras**
> ""Do what you must. But no matter how much you tarnish our bloodline, I will not betray the honor of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""The only stain on our bloodline is you. Titus?""*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[4]` (*Player_Romus: ""Well, then let me save you the trouble." [Sign the decre..."*)
  - -> `[8]` (*Player_Romus: ""You always did have a way with words. Tell it to the jud..."*)

### Węzeł `[352]`
Mówca: **Hugo Toras**
> ""NO!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Without hesitation, he raised his gun and fired. A single..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Toras_StripTitles = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Toras_StripTitles"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""Congratulations. Your blood is worth no more than that o..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Executed..."*)
  - -> `[11]` (*Player_Romus: ""Henceforth, I erase all your rights, privileges, and nob..."*)
  - -> `[117]` (*Player_Romus: "“From henceforth, the Toras family shall have no claim to..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hubertus_Hub_2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Hubertus_Hub_2"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Shooting nobles at their mother's birthd..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Shooting nobles at their mother's birthd..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Shooting nobles at their mother's birthd..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Rico Toras");"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Before I could register what had happened, Hugo hit the f..."*)
