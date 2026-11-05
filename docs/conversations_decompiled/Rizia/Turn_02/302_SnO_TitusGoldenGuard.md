# Rizia/Turn 2/SnO_TitusGoldenGuard

- **ID konwersacji:** `302`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/302_SnO_TitusGoldenGuard.md`
- **Liczba węzłów dialogowych:** 729
- **Liczba wyborów gracza:** 199

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Security_ValeroPoisoningTalk_Happened`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched`
- `RiziaDLCIsolated.Turn02_GGHub2_FightInWar`
- `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation`
- `RiziaDLCIsolated.Turn02_GGHub2_Threats`
- `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground`
- `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent`
- `RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing`
- `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_Sit`
- `RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground`
- `RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Artifact_Armor_TorasArmor`
- `RiziaDLC.Artifact_Sword_TeradorsFury`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched`
- `RiziaDLCIsolated.Turn02_GGHub2_FightInWar`
- `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation`
- `RiziaDLCIsolated.Turn02_GGHub2_Threats`
- `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground`
- `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent`
- `RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing`
- `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_MoveOn`
- `RiziaDLCIsolated.Turn02_SecurityTitus_Sit`
- `RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground`
- `RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground`
- `RiziaDLCSupport.News_Turn02_RH_SupportGoldenGuard`
- `RiziaDLCSupport.Reports_Turn02_Nelvisar_FieldShutsDown`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"Salute back."** | `[3]` **Narrator**: "As we approached, a pair of sold..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Hugo and I continued on our way." |
| `[7]` | **"Ignore them."** | `[3]` **Narrator**: "As we approached, a pair of sold..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Hugo and I continued on our way." |
| `[8]` | **"Wave halfheartedly."** | `[3]` **Narrator**: "As we approached, a pair of sold..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Hugo and I continued on our way." |
| `[9]` | **"Offer a high five."** | `[3]` **Narrator**: "As we approached, a pair of sold..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[27]` **Narrator**: "Both seemed unsure how to react." |
| `[10]` | **""Shh! I want to see what happens.""** | `[53]` **Hugo Toras**: ""My money is on Captain Gordion...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Certainly."" |
| `[11]` | **""As king, I mustn't indulge in gambling, whether with money or life.""** | `[53]` **Hugo Toras**: ""My money is on Captain Gordion...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""Fair enough."" |
| `[12]` | **""I don't have time for this. Would you kindly get their attention?""** | `[53]` **Hugo Toras**: ""My money is on Captain Gordion...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Hugo Toras**: ""Right away."" |
| `[13]` | **""Your oversight is duly noted.""** | `[61]` **Titus Gordion**: ""Forgive me, Your Majesty. I did..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Titus Gordion**: ""Yes, sir. It won't happen again."" |
| `[14]` | **""Agreed. There are substantial benefits to strengthening ties between us.""** | `[23]` **Hugo Toras**: ""I'm glad you've arranged a form..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Hugo Toras**: ""More than you know. I believe t..." |
| `[15]` | **""Forging a personal relationship is inconsequential. What matters most is his abil..."** | `[23]` **Hugo Toras**: ""I'm glad you've arranged a form..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Hugo Toras**: ""I can tell you firsthand that h..." |
| `[16]` | **""I'm not sure what there is to be gained, but I am willing to keep an open mind.""** | `[23]` **Hugo Toras**: ""I'm glad you've arranged a form..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Hugo Toras**: ""Excellent. Even if nothing come..." |
| `[17]` | **""Doubtful. I've never formed close relationships with my security detail in the pa..."** | `[23]` **Hugo Toras**: ""I'm glad you've arranged a form..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Hugo Toras**: ""Your ascension to the throne ca..." |
| `[28]` | **""Come on... Don't leave me hanging.""** | `[27]` **Narrator**: "Both seemed unsure how to react." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "Letting down their guard, litera..." |
| `[29]` | **""Celebratory palm slap, all around!""** | `[27]` **Narrator**: "Both seemed unsure how to react." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Narrator**: "That made them smile before givi..." |
| `[30]` | **""Don't worry, I'm granting you permission to touch me.""** | `[27]` **Narrator**: "Both seemed unsure how to react." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "They hesitated at first before t..." |
| `[31]` | **""High-five me. That's an order.""** | `[27]` **Narrator**: "Both seemed unsure how to react." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "They looked at one another for c..." |
| `[33]` | **""See? That wasn't so hard.""** | `[32]` **Narrator**: "Letting down their guard, litera..."<br>`[35]` **Narrator**: "They looked at one another for c..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Hugo Toras**: ""I think it's best if we move on."" |
| `[34]` | **""Alright! That's what I'm talking about.""** | `[32]` **Narrator**: "Letting down their guard, litera..."<br>`[35]` **Narrator**: "They looked at one another for c..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Hugo Toras**: ""I think it's best if we move on."" |
| `[38]` | **""Excellent! You both have promising futures ahead of you.""** | `[32]` **Narrator**: "Letting down their guard, litera..."<br>`[35]` **Narrator**: "They looked at one another for c..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Hugo Toras**: ""I think it's best if we move on."" |
| `[39]` | **""Now one down low.""** | `[32]` **Narrator**: "Letting down their guard, litera..."<br>`[35]` **Narrator**: "They looked at one another for c..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "I lowered my outstretched palm j..." |
| `[42]` | **""I'll leave when I say I'm ready.""** | `[40]` **Hugo Toras**: ""I think it's best if we move on."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "I let a moment of silence fall b..." |
| `[43]` | **""You're right. Lead the way!""** | `[40]` **Hugo Toras**: ""I think it's best if we move on."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Hugo Toras**: ""Yes, Your Majesty."" |
| `[44]` | **""You're no fun... But yes. Let us continue onward.""** | `[40]` **Hugo Toras**: ""I think it's best if we move on."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Hugo Toras**: ""Right. This way, Your Majesty."" |
| `[46]` | **""Okay. Now I'm ready.""** | `[45]` **Narrator**: "I let a moment of silence fall b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Hugo Toras**: ""Right. This way, Your Majesty."" |
| `[54]` | **""I'll take that bet.""** | `[53]` **Hugo Toras**: ""My money is on Captain Gordion...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Hugo Toras**: ""You're on."" |
| `[62]` | **""If anything, I should be the one apologizing for interrupting you.""** | `[61]` **Titus Gordion**: ""Forgive me, Your Majesty. I did..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Titus Gordion**: ""No need, but I appreciate the s..." |
| `[63]` | **""It's not your fault. I arrived sooner than anticipated.""** | `[61]` **Titus Gordion**: ""Forgive me, Your Majesty. I did..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Titus Gordion**: ""Well, it's great to have you he..." |
| `[64]` | **""I'm surprised you were unaware of your king's whereabouts, considering that falls..."** | `[61]` **Titus Gordion**: ""Forgive me, Your Majesty. I did..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Titus Gordion**: ""My men have eyes on you at all ..." |
| `[66]` | **""No, *my* money is on Captain Gordion. You take the other man.""** | `[53]` **Hugo Toras**: ""My money is on Captain Gordion...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Very well. Let the best man win!"" |
| `[69]` | **""Yes, it does. I would pay you now, but I never carry cash.""** | `[68]` **Hugo Toras**: ""It appears Captain Gordion has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Hugo Toras**: ""One of the many perks of being ..." |
| `[70]` | **""You know I'm not paying you, right?""** | `[68]` **Hugo Toras**: ""It appears Captain Gordion has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Hugo Toras**: ""That's not sportsmanlike at all..." |
| `[71]` | **""What do you think... should I hop in the ring? I bet I could take him.""** | `[68]` **Hugo Toras**: ""It appears Captain Gordion has ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[76]` **Hugo Toras**: ""As Grand Vizier to the king, I ..." |
| `[72]` | **""It certainly does. Looks like I owe you.""** | `[68]` **Hugo Toras**: ""It appears Captain Gordion has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Hugo Toras**: ""Let this be a life lesson!"" |
| `[79]` | **""Your lack of observation is disappointing. My early arrival shouldn't be unexpect..."** | `[78]` **Titus Gordion**: ""Your Majesty! Many apologies. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Titus Gordion**: ""Forgive me. It won't happen aga..." |
| `[80]` | **""I'm here before my usual time. I should be the one apologizing.""** | `[78]` **Titus Gordion**: ""Your Majesty! Many apologies. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Titus Gordion**: ""No need, but I appreciate the s..." |
| `[81]` | **""Your oversight is evident. My punctuality shouldn't be a surprise.""** | `[78]` **Titus Gordion**: ""Your Majesty! Many apologies. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Titus Gordion**: ""Yes, Your Majesty. It won't hap..." |
| `[82]` | **""No need to apologize. Just like in the ring, timing can be a challenge.""** | `[78]` **Titus Gordion**: ""Your Majesty! Many apologies. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Titus Gordion**: ""Very true, sir."" |
| `[87]` | **""Well, I don't have all day. Let us retire so we may discuss the nature of my visit.""** | `[83]` **Titus Gordion**: ""Forgive me. It won't happen aga..."<br>`[84]` **Titus Gordion**: ""No need, but I appreciate the s..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Titus Gordion**: ""Absolutely.""<br>`[91]` **Titus Gordion**: ""As you wish.""<br>*(oraz 1 innych odgałęzień)* |
| `[88]` | **""I must say, that's quite the right hook you got there.""** | `[84]` **Titus Gordion**: ""No need, but I appreciate the s..."<br>`[86]` **Titus Gordion**: ""Very true, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Titus Gordion**: ""Courtesy of my former boxing da..." |
| `[89]` | **""Alright, enough chit-chat. Let's get out of here and talk somewhere more private.""** | `[83]` **Titus Gordion**: ""Forgive me. It won't happen aga..."<br>`[84]` **Titus Gordion**: ""No need, but I appreciate the s..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Titus Gordion**: ""Absolutely.""<br>`[91]` **Titus Gordion**: ""As you wish.""<br>*(oraz 1 innych odgałęzień)* |
| `[90]` | **""In any case, let us take our leave. We have much to discuss.""** | `[83]` **Titus Gordion**: ""Forgive me. It won't happen aga..."<br>`[84]` **Titus Gordion**: ""No need, but I appreciate the s..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Titus Gordion**: ""Absolutely.""<br>`[91]` **Titus Gordion**: ""As you wish.""<br>*(oraz 1 innych odgałęzień)* |
| `[98]` | **""Guess I have a knack for picking winners.""** | `[97]` **Hugo Toras**: ""And Titus has emerged victoriou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Hugo Toras**: ""No doubt a useful skill to poss..." |
| `[99]` | **""Oh, don't worry about it. It was a lighthearted wager.""** | `[97]` **Hugo Toras**: ""And Titus has emerged victoriou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Hugo Toras**: ""Much appreciated."" |
| `[100]` | **""We should have them go another round. What do you say? Raise the bet? Double or n..."** | `[97]` **Hugo Toras**: ""And Titus has emerged victoriou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Hugo Toras**: ""Tempting, but no thanks. I've a..." |
| `[101]` | **""Yep. Now pay up.""** | `[97]` **Hugo Toras**: ""And Titus has emerged victoriou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Hugo Toras**: ""Certainly -- as soon as we've c..." |
| `[110]` | **""In any event, we should get moving. We have plenty to talk about.""** | `[106]` **Titus Gordion**: ""No need, but I appreciate the s..."<br>`[107]` **Titus Gordion**: ""My men have eyes on you at all ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Titus Gordion**: ""Absolutely. Right this way."" |
| `[112]` | **""I must say, that's quite the right hook you got there.""** | `[106]` **Titus Gordion**: ""No need, but I appreciate the s..."<br>`[107]` **Titus Gordion**: ""My men have eyes on you at all ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Titus Gordion**: ""Compliments of my old boxing da..." |
| `[115]` | **"Clear your throat."** | `[114]` **Narrator**: "Although the other fighter manag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "The captain turned to face us. H..." |
| `[116]` | **"Applaud."** | `[114]` **Narrator**: "Although the other fighter manag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "The captain turned to face us. H..." |
| `[117]` | **""Bravo!""** | `[114]` **Narrator**: "Although the other fighter manag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "The captain turned to face us. H..." |
| `[125]` | **""If we must.""** | `[124]` **Hugo Toras**: ""Well, Your Majesty... shall we?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Hugo Toras**: ""If you want to ensure the good ..." |
| `[126]` | **""Let's go.""** | `[124]` **Hugo Toras**: ""Well, Your Majesty... shall we?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Hugo Toras**: ""After you."" |
| `[127]` | **""Thanks, but your counsel is no longer required. I'd like to speak to the captain ..."** | `[124]` **Hugo Toras**: ""Well, Your Majesty... shall we?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Hugo Toras**: ""I see. Well, if that is your wi..." |
| `[128]` | **""I believe the kind of trust you want me to build with the Golden Guard can only b..."** | `[124]` **Hugo Toras**: ""Well, Your Majesty... shall we?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Hugo Toras**: ""Really? I mean... yes, of course."" |
| `[130]` | **""Take a tour of the armory or find some other means to entertain yourself.""** | `[134]` **Hugo Toras**: ""I see. Well, if that is your wi..."<br>`[135]` **Hugo Toras**: ""Really? I mean... yes, of course."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Hugo Toras**: ""Very well, then."" |
| `[131]` | **""Good. Now get to it.""** | `[134]` **Hugo Toras**: ""I see. Well, if that is your wi..."<br>`[135]` **Hugo Toras**: ""Really? I mean... yes, of course."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Hugo Toras**: ""As you command."" |
| `[132]` | **""You can wait around until my business is complete, but you're welcome to take you..."** | `[134]` **Hugo Toras**: ""I see. Well, if that is your wi..."<br>`[135]` **Hugo Toras**: ""Really? I mean... yes, of course."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Hugo Toras**: ""Yes. Understood."" |
| `[145]` | **""Quite the arsenal you've got here, Captain.""** | `[150]` **Hugo Toras**: ""I'm pleased you take such an in..."<br>`[157]` **Titus Gordion**: ""I brought most of this out of s..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[155]` **Titus Gordion**: ""Believe me, this is just a frac..." |
| `[146]` | **""I like what you've done with the place.""** | `[157]` **Titus Gordion**: ""I brought most of this out of s..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[153]` **Titus Gordion**: ""You're more than welcome to vis..." |
| `[147]` | **""I've often found that focusing too much on memorializing the past can impede prog..."** | `[150]` **Hugo Toras**: ""I'm pleased you take such an in..."<br>`[157]` **Titus Gordion**: ""I brought most of this out of s..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[154]` **Titus Gordion**: ""True, though I personally belie..." |
| `[148]` | **""Bows and arrows? Duchess Azaro wasn't kidding when she said our military needed u..."** | `[150]` **Hugo Toras**: ""I'm pleased you take such an in..."<br>`[157]` **Titus Gordion**: ""I brought most of this out of s..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[152]` **Narrator**: "That drew a laugh from my uncle,..."<br>`[648]` **Narrator**: "The captain smiled patiently." |
| `[161]` | **""Please, by all means.""** | `[160]` **Titus Gordion**: ""If you desire, I'd be honored t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Titus Gordion**: ""Excellent. Where would you like..." |
| `[162]` | **""Very well. Let's hear it.""** | `[160]` **Titus Gordion**: ""If you desire, I'd be honored t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Titus Gordion**: ""Certainly. What would you like ..." |
| `[163]` | **""No, thank you. I always found history lessons boring.""** | `[160]` **Titus Gordion**: ""If you desire, I'd be honored t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Titus Gordion**: ""Understandable. The study of hi..." |
| `[164]` | **""Tempted as I am, time is of the essence.""** | `[160]` **Titus Gordion**: ""If you desire, I'd be honored t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Titus Gordion**: ""Perhaps some other day then."" |
| `[170]` | **""Why don't you tell me about that sword?""** | `[165]` **Titus Gordion**: ""Certainly. What would you like ..."<br>`[167]` **Titus Gordion**: ""Excellent. Where would you like..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == false` | *Brak zmian stanu* | `[443]` **Narrator**: "I motioned to a broadsword promi..." |
| `[171]` | **""Tell me about that impressive suit of armor.""** | `[165]` **Titus Gordion**: ""Certainly. What would you like ..."<br>`[167]` **Titus Gordion**: ""Excellent. Where would you like..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == false` | *Brak zmian stanu* | `[444]` **Narrator**: "I pointed to an intricately ador..." |
| `[172]` | **""Enough history. I'm ready to move on.""** | `[165]` **Titus Gordion**: ""Certainly. What would you like ..."<br>`[167]` **Titus Gordion**: ""Excellent. Where would you like..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true` | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_MoveOn"] ...` | `[186]` **Titus Gordion**: ""Very well. This way, sir."" |
| `[173]` | **""I'm curious to know about... whatever *that* is.""** | `[165]` **Titus Gordion**: ""Certainly. What would you like ..."<br>`[167]` **Titus Gordion**: ""Excellent. Where would you like..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == false` | *Brak zmian stanu* | `[445]` **Narrator**: "I gestured toward a metallic, co..." |
| `[199]` | **""It's considered bad luck to mention severed heads in the presence of a king.""** | `[198]` **Hugo Toras**: ""Legend has it, this sword took ..."<br>`[473]` **Titus Gordion**: ""This sword is said to be the ve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[697]` **Hugo Toras**: ""Indeed, you're right. However, ..."<br>`[465]` **Titus Gordion**: ""My apologies. It won't happen a..." |
| `[200]` | **""A bad day for him.""** | `[198]` **Hugo Toras**: ""Legend has it, this sword took ..."<br>`[473]` **Titus Gordion**: ""This sword is said to be the ve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[467]` **Titus Gordion**: ""To put it lightly..."" |
| `[202]` | **""But it wasn't enough to prevent Pales being taken from Rizia. That's what keeps m..."** | `[198]` **Hugo Toras**: ""Legend has it, this sword took ..."<br>`[473]` **Titus Gordion**: ""This sword is said to be the ve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[466]` **Titus Gordion**: ""It is indeed a sore spot in our..." |
| `[205]` | **""If you both think it's that important, then go ahead, Captain.""** | `[204]` **Hugo Toras**: ""Yes. However, if I may be so bo..."<br>`[214]` **Hugo Toras**: ""If I may be so bold, Your Majes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Titus Gordion**: ""Any items of particular interest?"" |
| `[206]` | **""Fine, fine... You've convinced me. Let's hear it.""** | `[204]` **Hugo Toras**: ""Yes. However, if I may be so bo..."<br>`[214]` **Hugo Toras**: ""If I may be so bold, Your Majes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Titus Gordion**: ""Certainly. Where would you like..." |
| `[207]` | **""What part of 'I have other priorities' do you not understand?""** | `[204]` **Hugo Toras**: ""Yes. However, if I may be so bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Hugo Toras**: ""Got it. I won't bring it up aga..." |
| `[208]` | **""I agree with you, Uncle. However, it isn't something I'm interested in delving in..."** | `[204]` **Hugo Toras**: ""Yes. However, if I may be so bo..."<br>`[214]` **Hugo Toras**: ""If I may be so bold, Your Majes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Hugo Toras**: ""Very well. I'll refrain from me..." |
| `[215]` | **""I already said I'm not interested. Nor did I ask for your advice.""** | `[214]` **Hugo Toras**: ""If I may be so bold, Your Majes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Hugo Toras**: ""Then I won't mention it again."" |
| `[221]` | **"Sit."** | `[219]` **Titus Gordion**: ""Please, have a seat."" | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] = t...` | `[229]` **Narrator**: "The captain took out a bottle of..." |
| `[222]` | **"Remain standing."** | `[219]` **Titus Gordion**: ""Please, have a seat."" | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] = f...` | `[223]` **Narrator**: "Hugo, seeming suddenly self-awar..."<br>`[229]` **Narrator**: "The captain took out a bottle of..." |
| `[224]` | **""Drinking on the job? You should both be ashamed of yourselves.""** | `[714]` **Hugo Toras**: ""I didn't know you were a connoi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Titus Gordion**: ""You're right. My mistake."" |
| `[225]` | **""The fact that you would consider drinking on the job raises questions about your ..."** | `[719]` **Hugo Toras**: ""It's early, Captain. Perhaps we..."<br>`[228]` **Titus Gordion**: ""Would you care for some fortifi..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[553]` **Titus Gordion**: ""We in the Golden Guard are trai..." |
| `[226]` | **""Just a little bit. I've got to stay sharp for the rest of the day's activities.""** | `[714]` **Hugo Toras**: ""I didn't know you were a connoi..."<br>`[228]` **Titus Gordion**: ""Would you care for some fortifi..." | `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[557]` **Titus Gordion**: ""Of course."" |
| `[227]` | **""You had me at 'fortified'. Regular wine's for weaklings.""** | `[714]` **Hugo Toras**: ""I didn't know you were a connoi..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`<br>`(Variable["RiziaDLC.Trait_SoberKing"] == true) == false` | *Brak zmian stanu* | `[558]` **Titus Gordion**: ""This one's strong indeed. But i..." |
| `[230]` | **""Thanks, but no thanks. I only drink wine from 1892.""** | `[714]` **Hugo Toras**: ""I didn't know you were a connoi..."<br>`[228]` **Titus Gordion**: ""Would you care for some fortifi..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[236]` **Titus Gordion**: ""Sorry. I'm afraid I'm fresh out..." |
| `[246]` | **""As the King of Rizia, I have many enemies. I wanted to make sure you're not one o..."** | `[231]` **Titus Gordion**: ""So to what do I owe the pleasur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Titus Gordion**: ""Certainly not, Your Majesty. Pl..." |
| `[247]` | **""I'm looking to develop a clearer understanding of the individuals comprising my s..."** | `[231]` **Titus Gordion**: ""So to what do I owe the pleasur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Titus Gordion**: ""Well, I'm more than happy to te..." |
| `[248]` | **""I wanted to get away from my council and speak to a real commoner. Your perspecti..."** | `[231]` **Titus Gordion**: ""So to what do I owe the pleasur..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[252]` **Titus Gordion**: ""It's been quite some time since..." |
| `[249]` | **""My uncle suggested I get to know you better, believing that building a personal r..."** | `[231]` **Titus Gordion**: ""So to what do I owe the pleasur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Titus Gordion**: ""I don't see why not. What would..." |
| `[254]` | **""Why don't you tell me more about yourself?""** | `[250]` **Titus Gordion**: ""Well, I'm more than happy to te..."<br>`[251]` **Titus Gordion**: ""I don't see why not. What would..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == false` | *Brak zmian stanu* | `[265]` **Titus Gordion**: ""Well, I was born and raised in ..." |
| `[255]` | **""Let's hear more about the Golden Guard.""** | `[250]` **Titus Gordion**: ""Well, I'm more than happy to te..."<br>`[251]` **Titus Gordion**: ""I don't see why not. What would..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false` | *Brak zmian stanu* | `[266]` **Titus Gordion**: ""I'd be honored. As you already ..." |
| `[270]` | **""He gave his life for a good cause.""** | `[278]` **Titus Gordion**: ""I had a fairly normal childhood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Titus Gordion**: ""He believed in it with all his ..." |
| `[271]` | **""So much senseless bloodshed. May it never happen again.""** | `[278]` **Titus Gordion**: ""I had a fairly normal childhood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Titus Gordion**: ""For what it's worth, sir, he be..." |
| `[275]` | **""I'm sorry for your loss. Didn't mean to bring up bad memories.""** | `[278]` **Titus Gordion**: ""I had a fairly normal childhood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Titus Gordion**: ""Not a problem, sir. He died fig..." |
| `[281]` | **""Well, that explains your fisticuffs from earlier! You fared well, I assume?""** | `[417]` **Titus Gordion**: ""So, I put on a pair of gloves a..."<br>`[277]` **Titus Gordion**: ""I took up championship boxing t..." | `(Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] == true) == false` | *Brak zmian stanu* | `[283]` **Titus Gordion**: ""Good enough to catch the eye of..." |
| `[282]` | **""Were you any good?""** | `[277]` **Titus Gordion**: ""I took up championship boxing t..."<br>`[417]` **Titus Gordion**: ""So, I put on a pair of gloves a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Titus Gordion**: ""Good enough to attract the atte..." |
| `[288]` | **""Go on.""** | `[266]` **Titus Gordion**: ""I'd be honored. As you already ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Titus Gordion**: ""Gladly. Aside from general secu..." |
| `[289]` | **""Yes, yes... We've been over that already. Tell me something I don't know.""** | `[266]` **Titus Gordion**: ""I'd be honored. As you already ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Titus Gordion**: ""Gladly. Aside from general secu..." |
| `[290]` | **""And I am forever grateful. Please, continue.""** | `[266]` **Titus Gordion**: ""I'd be honored. As you already ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Titus Gordion**: ""Gladly. Aside from general secu..." |
| `[291]` | **""'Private matters?' How intriguing. Please elaborate.""** | `[268]` **Titus Gordion**: ""Gladly. Aside from general secu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Titus Gordion**: ""As in *offensive* operations, i..." |
| `[292]` | **""Oh, I'm definitely interested in hearing more.""** | `[268]` **Titus Gordion**: ""Gladly. Aside from general secu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Titus Gordion**: ""Let's just say... the public is..." |
| `[293]` | **""That sounds rather ominous.""** | `[268]` **Titus Gordion**: ""Gladly. Aside from general secu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Titus Gordion**: ""We do what we must to ensure th..." |
| `[294]` | **""I don't like the sound of that.""** | `[268]` **Titus Gordion**: ""Gladly. Aside from general secu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Titus Gordion**: ""The real world isn't as black a..." |
| `[303]` | **""If what you're saying is true, then I am truly shocked.""** | `[302]` **Hugo Toras**: ""Since their return, their deali..."<br>`[423]` **Titus Gordion**: ""Nevertheless the chance to full..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Titus Gordion**: ""For king and country, Your Maje..." |
| `[304]` | **""I'd heard rumors of such clandestine actions, but this is the first time I've rec..."** | `[302]` **Hugo Toras**: ""Since their return, their deali..."<br>`[423]` **Titus Gordion**: ""Nevertheless the chance to full..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Titus Gordion**: ""Secrecy is of the utmost import..." |
| `[305]` | **""I find the notion of an organization working outside the rule of law truly worris..."** | `[302]` **Hugo Toras**: ""Since their return, their deali..."<br>`[423]` **Titus Gordion**: ""Nevertheless the chance to full..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Titus Gordion**: ""We only work within the confine..." |
| `[306]` | **""Is it wrong to see great potential in sanctioning such actions?""** | `[302]` **Hugo Toras**: ""Since their return, their deali..."<br>`[423]` **Titus Gordion**: ""Nevertheless the chance to full..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Titus Gordion**: ""As I said, I am at your command."" |
| `[311]` | **""If we're relying on the Golden Guard to handle fires, we have far bigger problems..."** | `[310]` **Titus Gordion**: ""By deploying us to assist in di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Titus Gordion**: ""Hopefully it won't get to that ..." |
| `[312]` | **""You can rest assured that I won't be sending you out on any firefighting excursio..."** | `[310]` **Titus Gordion**: ""By deploying us to assist in di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Titus Gordion**: ""Much appreciated."" |
| `[313]` | **""Seeing as how putting out fires falls within your existing duties, extinguishing ..."** | `[310]` **Titus Gordion**: ""By deploying us to assist in di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Titus Gordion**: ""Fair point."" |
| `[314]` | **""Well, then next time I hear of any kittens stuck in trees, I'll let you know.""** | `[310]` **Titus Gordion**: ""By deploying us to assist in di..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[317]` **Titus Gordion**: ""I'm actually allergic to cats, ..." |
| `[324]` | **""Agreed. Your counsel was greatly appreciated.""** | `[321]` **Hugo Toras**: ""I think that was a very product..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Hugo Toras**: ""It is my honor, Your Majesty."" |
| `[325]` | **""I didn't ask for your opinion.""** | `[321]` **Hugo Toras**: ""I think that was a very product..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Hugo Toras**: ""Yes, but as your Grand Vizier, ..." |
| `[326]` | **""As do I. Strengthening ties has its benefits, as you rightly pointed out. Let's h..."** | `[321]` **Hugo Toras**: ""I think that was a very product..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Hugo Toras**: ""I have no doubt that it will."" |
| `[327]` | **""I hope you're right.""** | `[321]` **Hugo Toras**: ""I think that was a very product..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Hugo Toras**: ""I know I'm right."" |
| `[334]` | **""Watch your words. Your obligations mean little in the face of my authority.""** | `[328]` **Hugo Toras**: ""Yes, but as your Grand Vizier, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Narrator**: "Hugo gave a slight nod." |
| `[335]` | **""Fine. But the next time you feel compelled to give unsolicited advice, you may fi..."** | `[328]` **Hugo Toras**: ""Yes, but as your Grand Vizier, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Hugo Toras**: ""As always, your perspective is ..." |
| `[336]` | **""You're right. Please excuse my curtness. I welcome any advice you have to give.""** | `[328]` **Hugo Toras**: ""Yes, but as your Grand Vizier, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[620]` **Narrator**: "Hugo paused and scrutinized me f..."<br>`[628]` **Narrator**: "Hugo paused and scrutinized me f..."<br>*(oraz 1 innych odgałęzień)* |
| `[348]` | **""So sure of yourself, are you?""** | `[329]` **Hugo Toras**: ""I know I'm right."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Hugo Toras**: ""I prefer... realistically optim..." |
| `[349]` | **""Self-assuredness is a quality I value.""** | `[329]` **Hugo Toras**: ""I know I'm right."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Hugo Toras**: ""In my experience, a little conf..." |
| `[350]` | **""Some would call that arrogance.""** | `[329]` **Hugo Toras**: ""I know I'm right."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Hugo Toras**: ""Not arrogant. Self-confident."" |
| `[365]` | **""That's none of your concern.""** | `[364]` **Hugo Toras**: ""There you are! I trust your dis..." | `Variable["RiziaDLC.Relations_Titus"] >= 2` | *Brak zmian stanu* | `[370]` **Hugo Toras**: ""Yes, Your Majesty."" |
| `[366]` | **""Yes, very. Though I'd rather not go into detail.""** | `[364]` **Hugo Toras**: ""There you are! I trust your dis..." | `Variable["RiziaDLC.Relations_Titus"] >= 2` | *Brak zmian stanu* | `[369]` **Hugo Toras**: ""Your discretion is duly noted."" |
| `[367]` | **""As productive as one can be when talking to a dumb grunt.""** | `[364]` **Hugo Toras**: ""There you are! I trust your dis..." | `Variable["RiziaDLC.Relations_Titus"] >= 2` | *Brak zmian stanu* | `[368]` **Hugo Toras**: ""I can assure you that he's anyt..." |
| `[375]` | **""It was, actually. I seem to have misjudged the captain.""** | `[364]` **Hugo Toras**: ""There you are! I trust your dis..." | `Variable["RiziaDLC.Relations_Titus"] >= 2` | *Brak zmian stanu* | `[379]` **Hugo Toras**: ""I'm pleased to hear it."" |
| `[381]` | **""Your comprehensive explanation is appreciated.""** | `[250]` **Titus Gordion**: ""Well, I'm more than happy to te..."<br>`[251]` **Titus Gordion**: ""I don't see why not. What would..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true` | *Brak zmian stanu* | `[385]` **Titus Gordion**: ""I'm glad I could provide you wi..." |
| `[382]` | **""Thanks for sharing, Titus.""** | `[250]` **Titus Gordion**: ""Well, I'm more than happy to te..."<br>`[251]` **Titus Gordion**: ""I don't see why not. What would..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true` | *Brak zmian stanu* | `[384]` **Titus Gordion**: ""It's my pleasure."" |
| `[383]` | **""I appreciate your thorough explanation, Titus, but try to bring it to a natural c..."** | `[250]` **Titus Gordion**: ""Well, I'm more than happy to te..."<br>`[251]` **Titus Gordion**: ""I don't see why not. What would..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true` | *Brak zmian stanu* | `[386]` **Titus Gordion**: ""I'll make sure of it."" |
| `[387]` | **""That will be all, thank you.""** | `[570]` **Titus Gordion**: ""Is there anything else you'd li..."<br>`[540]` **Titus Gordion**: ""Discretion is the Golden Guard ..."<br>*(oraz 13 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Titus Gordion**: ""If there's anything else I can ..." |
| `[431]` | **""Til next time.""** | `[427]` **Titus Gordion**: ""If there's anything else I can ..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[356]` **Narrator**: "Titus gave a heartfelt bow and l..." |
| `[432]` | **""Thank you. Until we meet again.""** | `[427]` **Titus Gordion**: ""If there's anything else I can ..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[356]` **Narrator**: "Titus gave a heartfelt bow and l..." |
| `[433]` | **""Thanks again for your hospitality.""** | `[427]` **Titus Gordion**: ""If there's anything else I can ..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[356]` **Narrator**: "Titus gave a heartfelt bow and l..." |
| `[434]` | **""Goodbye, Titus.""** | `[427]` **Titus Gordion**: ""If there's anything else I can ..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[356]` **Narrator**: "Titus gave a heartfelt bow and l..." |
| `[446]` | **""Yes. Most reassuring.""** | `[190]` **Titus Gordion**: ""You'll be happy to know it hasn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Titus Gordion**: ""Enhanced interrogation methods ..." |
| `[447]` | **""Hard to believe it was used at all.""** | `[190]` **Titus Gordion**: ""You'll be happy to know it hasn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[450]` **Titus Gordion**: ""Not often. It was more to scare..." |
| `[448]` | **""Too bad. A lot of fun could be had with that.""** | `[190]` **Titus Gordion**: ""You'll be happy to know it hasn..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[451]` **Titus Gordion**: ""Enhanced interrogation is serio..." |
| `[452]` | **""I'm more interested in knowing if his armor would fit me.""** | `[203]` **Titus Gordion**: ""But I'm sure you knew that alre..."<br>`[477]` **Hugo Toras**: ""I'm sure His Majesty knows the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[455]` **Titus Gordion**: ""Everyone back then was much sho..." |
| `[453]` | **""Obviously.""** | `[203]` **Titus Gordion**: ""But I'm sure you knew that alre..."<br>`[477]` **Hugo Toras**: ""I'm sure His Majesty knows the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Titus Gordion**: ""What else would you like to know?"" |
| `[454]` | **""Yes, but it's always good to refresh myself on our history.""** | `[203]` **Titus Gordion**: ""But I'm sure you knew that alre..."<br>`[477]` **Hugo Toras**: ""I'm sure His Majesty knows the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Titus Gordion**: ""What else would you like to know?"" |
| `[460]` | **""That's okay. I'd look ridiculous anyway.""** | `[459]` **Hugo Toras**: ""If you really want a suit of ar..."<br>`[679]` **Titus Gordion**: ""Are you seriously interested in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Titus Gordion**: ""What else would you like to know?"" |
| `[461]` | **""Yes, please do.""** | `[459]` **Hugo Toras**: ""If you really want a suit of ar..."<br>`[679]` **Titus Gordion**: ""Are you seriously interested in..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Artifact_Armor_TorasArmor"] = true;` | `[488]` **Titus Gordion**: ""What else would you like to know?"" |
| `[462]` | **""As long as we get a second one for you. Then we'd be a matching set.""** | `[459]` **Hugo Toras**: ""If you really want a suit of ar..."<br>`[679]` **Titus Gordion**: ""Are you seriously interested in..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[463]` **Narrator**: "Hugo and Titus laughed."<br>`[683]` **Narrator**: "Titus laughed." |
| `[485]` | **""I've been impressed by Captain Gordion's loyalty thus far.""** | `[19]` **Hugo Toras**: ""Excellent. Even if nothing come..."<br>`[20]` **Hugo Toras**: ""I can tell you firsthand that h..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[494]` **Hugo Toras**: ""As have I. And I have the feeli..." |
| `[486]` | **""I hope that today's visit will prove you right.""** | `[493]` **Hugo Toras**: ""What I know is that there has n..."<br>`[494]` **Hugo Toras**: ""As have I. And I have the feeli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "It wasn't long before we'd cross..." |
| `[491]` | **""Titus is all that stands between me and an assassin's bullet, and I know next to ..."** | `[19]` **Hugo Toras**: ""Excellent. Even if nothing come..."<br>`[20]` **Hugo Toras**: ""I can tell you firsthand that h..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[493]` **Hugo Toras**: ""What I know is that there has n..." |
| `[492]` | **""Be honest with me, Hugo. Do you believe Gordion can be trusted?""** | `[19]` **Hugo Toras**: ""Excellent. Even if nothing come..."<br>`[20]` **Hugo Toras**: ""I can tell you firsthand that h..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[498]` **Hugo Toras**: ""He is, without a doubt, one of ..." |
| `[495]` | **""That's what worries me. Fanatical devotion can be dangerous should one find thems..."** | `[493]` **Hugo Toras**: ""What I know is that there has n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "It wasn't long before we'd cross..." |
| `[496]` | **""I'm not quite sure we're on the same page just yet. But we shall see what today b..."** | `[493]` **Hugo Toras**: ""What I know is that there has n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "It wasn't long before we'd cross..." |
| `[497]` | **""Then I look forward to getting to know him better today.""** | `[493]` **Hugo Toras**: ""What I know is that there has n..."<br>`[494]` **Hugo Toras**: ""As have I. And I have the feeli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "It wasn't long before we'd cross..." |
| `[499]` | **""I'm pleased to hear it.""** | `[494]` **Hugo Toras**: ""As have I. And I have the feeli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "It wasn't long before we'd cross..." |
| `[500]` | **""He'd better be. I won't tolerate anything less.""** | `[498]` **Hugo Toras**: ""He is, without a doubt, one of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "It wasn't long before we'd cross..." |
| `[501]` | **"Sit down."** | `[220]` **Narrator**: "Uncle Hugo sat on a sofa that lo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] = t...` | `[229]` **Narrator**: "The captain took out a bottle of..." |
| `[502]` | **"Keep standing."** | `[220]` **Narrator**: "Uncle Hugo sat on a sofa that lo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] = f...` | `[223]` **Narrator**: "Hugo, seeming suddenly self-awar..."<br>`[229]` **Narrator**: "The captain took out a bottle of..." |
| `[503]` | **""Well, I don't have all day. Let's find a place to discuss the purpose of my visit.""** | `[118]` **Titus Gordion**: ""Courtesy of my former boxing da..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Titus Gordion**: ""Very good, sir.""<br>`[506]` **Titus Gordion**: ""Whatever you'd like, Your Majes..."<br>*(oraz 1 innych odgałęzień)* |
| `[504]` | **""Okay, that's enough small talk. Let's shift this conversation to a private setting.""** | `[118]` **Titus Gordion**: ""Courtesy of my former boxing da..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Titus Gordion**: ""Very good, sir.""<br>`[506]` **Titus Gordion**: ""Whatever you'd like, Your Majes..."<br>*(oraz 1 innych odgałęzień)* |
| `[505]` | **""Regardless, we should go. We've got plenty to talk about.""** | `[118]` **Titus Gordion**: ""Courtesy of my former boxing da..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Titus Gordion**: ""Very good, sir.""<br>`[506]` **Titus Gordion**: ""Whatever you'd like, Your Majes..."<br>*(oraz 1 innych odgałęzień)* |
| `[516]` | **""My certainty hasn't waned.""** | `[515]` **Hugo Toras**: ""Still feeling confident about y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[520]` **Hugo Toras**: ""Then I guess we'll see where th..." |
| `[517]` | **""I must admit, I fear I've placed my bets on the wrong man.""** | `[515]` **Hugo Toras**: ""Still feeling confident about y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Hugo Toras**: ""Humility is a sign of strength ..." |
| `[518]` | **""I should ask you the same question.""** | `[515]` **Hugo Toras**: ""Still feeling confident about y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[521]` **Hugo Toras**: ""Some might say you're deflectin..." |
| `[524]` | **""What do you say we double the bet?""** | `[96]` **Narrator**: "The two men circle each other fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[528]` **Hugo Toras**: ""Not when the Captain has the in..." |
| `[525]` | **""Are your knees starting to shake, Uncle?""** | `[96]` **Narrator**: "The two men circle each other fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[529]` **Hugo Toras**: ""Never. Though I can't say the s..." |
| `[526]` | **""It appears my man has the upper hand.""** | `[96]` **Narrator**: "The two men circle each other fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Hugo Toras**: ""I'm afraid you might be right."" |
| `[531]` | **""Same. I like what you've done with the place.""** | `[150]` **Hugo Toras**: ""I'm pleased you take such an in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Titus Gordion**: ""You're more than welcome to vis..." |
| `[542]` | **""Nonsense. I can't turn down a chance to drink with my new bodyguard.""** | `[719]` **Hugo Toras**: ""It's early, Captain. Perhaps we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[543]` **Narrator**: "Hugo shrugged." |
| `[548]` | **""Why not? I can't turn down the chance to drink with my new bodyguard.""** | `[714]` **Hugo Toras**: ""I didn't know you were a connoi..."<br>`[228]` **Titus Gordion**: ""Would you care for some fortifi..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[556]` **Titus Gordion**: ""I'm honored, Your Majesty."" |
| `[549]` | **""Do not presume to speak for me, Uncle. I shall drink if I wish.""** | `[719]` **Hugo Toras**: ""It's early, Captain. Perhaps we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[550]` **Narrator**: "Hugo looked puzzled." |
| `[552]` | **""Yes, thank you, Hugo. Another time, perhaps.""** | `[719]` **Hugo Toras**: ""It's early, Captain. Perhaps we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[555]` **Titus Gordion**: ""My apologies to you both."" |
| `[560]` | **""Do you have eyes on me at all times? Even during... intimate moments?""** | `[570]` **Titus Gordion**: ""Is there anything else you'd li..."<br>`[540]` **Titus Gordion**: ""Discretion is the Golden Guard ..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == false` | `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] ...` | `[579]` **Titus Gordion**: ""It is our utmost aim to protect..." |
| `[561]` | **""Is it possible, hypothetically speaking, for the Golden Guard to support the Crow..."** | `[570]` **Titus Gordion**: ""Is there anything else you'd li..."<br>`[540]` **Titus Gordion**: ""Discretion is the Golden Guard ..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == false  and  Variable["RiziaDLC.Security_ValeroPoisoningTalk_Happened"] == true` | `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigat...` | `[564]` **Narrator**: "Hugo straightened up, suddenly m..."<br>`[568]` **Narrator**: "Titus didn't blink." |
| `[569]` | **""What do you deem to be the biggest threat to my personal safety right now?""** | `[570]` **Titus Gordion**: ""Is there anything else you'd li..."<br>`[540]` **Titus Gordion**: ""Discretion is the Golden Guard ..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] == false` | `Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] = true;` | `[582]` **Narrator**: "Titus looked around, then turned..." |
| `[571]` | **""There isn't a murder. I'm speaking purely in a speculative context.""** | `[563]` **Titus Gordion**: ""Would you care to elaborate?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Titus Gordion**: ""Very well. Either way, I'm at y..." |
| `[572]` | **""I will, should the need arise. I'm still determining if there's sufficient justif..."** | `[563]` **Titus Gordion**: ""Would you care to elaborate?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[573]` **Titus Gordion**: ""Understandable. In any event, I..." |
| `[575]` | **""Such an investigation might require conducting surveillance within Palace walls.""** | `[563]` **Titus Gordion**: ""Would you care to elaborate?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[576]` **Titus Gordion**: ""Understood. The Guard would def..." |
| `[589]` | **""Indeed. If there's any house we should be worried about, it's the Sazons.""** | `[588]` **Hugo Toras**: ""Please don't worry His Majesty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[598]` **Titus Gordion**: ""I doubt they would try another ..." |
| `[590]` | **""I appreciate you voicing your concerns, Titus, even if I do not share them.""** | `[588]` **Hugo Toras**: ""Please don't worry His Majesty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[600]` **Titus Gordion**: ""Happy to have your ear, Your Ma..." |
| `[591]` | **""Don't hastily dismiss the captain's suspicions, Hugo. I wouldn't be surprised if ..."** | `[588]` **Hugo Toras**: ""Please don't worry His Majesty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[597]` **Titus Gordion**: ""I will try to keep a close eye ..." |
| `[592]` | **""Nonsense. The Azaros have been close allies since the War of Rizian Succession.""** | `[584]` **Titus Gordion**: ""I don't want to overstep my bou..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[596]` **Titus Gordion**: ""I stand corrected, then. You kn..." |
| `[593]` | **""I share your suspicions. If you uncover even the slightest evidence that the fami..."** | `[584]` **Titus Gordion**: ""I don't want to overstep my bou..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[597]` **Titus Gordion**: ""I will try to keep a close eye ..." |
| `[594]` | **""You're not worried about the Sazons?""** | `[584]` **Titus Gordion**: ""I don't want to overstep my bou..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[598]` **Titus Gordion**: ""I doubt they would try another ..." |
| `[595]` | **""What about my own family? Will you protect me if Hugo tries to usurp me?""** | `[584]` **Titus Gordion**: ""I don't want to overstep my bou..." | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[599]` **Titus Gordion**: ""Usurp, Your Majesty?"" |
| `[601]` | **""You'd better not be listening in, either.""** | `[581]` **Titus Gordion**: ""But what you do in that room is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[605]` **Titus Gordion**: ""Certainly not, Your Majesty. An..." |
| `[602]` | **""Surely you must leave your post at some point.""** | `[581]` **Titus Gordion**: ""But what you do in that room is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[606]` **Titus Gordion**: ""We keep a tight rotation. Aslee..." |
| `[603]` | **""Good. That's the correct answer.""** | `[581]` **Titus Gordion**: ""But what you do in that room is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[540]` **Titus Gordion**: ""Discretion is the Golden Guard ..." |
| `[604]` | **""And if I *want* you to watch me?""** | `[581]` **Titus Gordion**: ""But what you do in that room is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[607]` **Titus Gordion**: ""I, uh... do you have any other ..." |
| `[630]` | **""Not right now, but anything could happen.""** | `[629]` **Hugo Toras**: ""'Intimate moments'? I wasn't aw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[634]` **Hugo Toras**: ""I see. Do be mindful that any u..." |
| `[631]` | **""Nobody you need to know about, Your Grace.""** | `[629]` **Hugo Toras**: ""'Intimate moments'? I wasn't aw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[633]` **Hugo Toras**: ""Any union that could result in ..." |
| `[632]` | **""Even a king's got to polish the crown jewels every once in a while, you know.""** | `[629]` **Hugo Toras**: ""'Intimate moments'? I wasn't aw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[635]` **Narrator**: "Hugo reddened." |
| `[637]` | **""As I said, I was asking hypothetically.""** | `[624]` **Hugo Toras**: ""A murder investigation, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[644]` **Hugo Toras**: ""Very well. I was only wondering."" |
| `[638]` | **""I suspect Father may have died of something other than natural causes.""** | `[624]` **Hugo Toras**: ""A murder investigation, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Narrator**: "He drew back in mild surprise." |
| `[639]` | **""Yes. I'm on the hunt for whoever killed your sense of humor.""** | `[624]` **Hugo Toras**: ""A murder investigation, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[640]` **Hugo Toras**: ""Ha."" |
| `[657]` | **""That would be great.""** | `[489]` **Titus Gordion**: ""If you would like, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Artifact_Sword_TeradorsFury"] = true;` | `[656]` **Titus Gordion**: ""Is there anything else you're c..." |
| `[658]` | **""What year are we in? Not necessary.""** | `[489]` **Titus Gordion**: ""If you would like, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[656]` **Titus Gordion**: ""Is there anything else you're c..." |
| `[668]` | **""Ah, yes. You mentioned something about your boxing days. You fared well, I assume?""** | `[277]` **Titus Gordion**: ""I took up championship boxing t..." | `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] == true` | *Brak zmian stanu* | `[283]` **Titus Gordion**: ""Good enough to catch the eye of..." |
| `[669]` | **""You'll have to teach me how to fight like that sometime.""** | `[106]` **Titus Gordion**: ""No need, but I appreciate the s..."<br>`[107]` **Titus Gordion**: ""My men have eyes on you at all ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[673]` **Titus Gordion**: ""Nothing you haven't already lea..."<br>`[674]` **Titus Gordion**: ""If I do my job correctly, you'l..." |
| `[676]` | **""Hypothetically, could it still be used today?""** | `[190]` **Titus Gordion**: ""You'll be happy to know it hasn..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[678]` **Titus Gordion**: ""I don't see why not. However, m..." |
| `[685]` | **""Such a crude sport. I prefer hunting. It allows you to keep a gentlemanly distanc..."** | `[277]` **Titus Gordion**: ""I took up championship boxing t..."<br>`[417]` **Titus Gordion**: ""So, I put on a pair of gloves a..." | `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true` | *Brak zmian stanu* | `[690]` **Titus Gordion**: ""I'm well trained in the art of ..." |
| `[689]` | **""So you're good at hand-to-hand combat. But my enemies will come at me with long-r..."** | `[277]` **Titus Gordion**: ""I took up championship boxing t..."<br>`[417]` **Titus Gordion**: ""So, I put on a pair of gloves a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Titus Gordion**: ""That's where my military traini..." |
| `[695]` | **""I feel like I've heard enough of the past for now.""** | `[250]` **Titus Gordion**: ""Well, I'm more than happy to te..."<br>`[251]` **Titus Gordion**: ""I don't see why not. What would..."<br>*(oraz 11 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[696]` **Titus Gordion**: ""Very well."" |
| `[704]` | **""Would the Golden Guard aid our military if a war broke out?""** | `[570]` **Titus Gordion**: ""Is there anything else you'd li..."<br>`[540]` **Titus Gordion**: ""Discretion is the Golden Guard ..."<br>*(oraz 13 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_GGHub2_FightInWar"] == false` | *Brak zmian stanu* | `[705]` **Narrator**: "Titus saluted reflexively." |
| `[709]` | **""Our professional relationship requires honesty. I will tell you straight away tha..."** | `[714]` **Hugo Toras**: ""I didn't know you were a connoi..."<br>`[228]` **Titus Gordion**: ""Would you care for some fortifi..." | `Variable["RiziaDLC.Trait_SoberKing"] == true`<br>`(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false` | *Brak zmian stanu* | `[710]` **Titus Gordion**: ""I see."" |

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
  - -> `[728]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Meeting with the King’s Secret Service",..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "As we approached, a pair of soldiers, flanked on either side of the entrance, greeted us with a formal salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus_Italic: "Wave halfheartedly."*)
  - -> `[6]` (*Player_Romus_Italic: "Salute back."*)
  - -> `[7]` (*Player_Romus_Italic: "Ignore them."*)
  - -> `[9]` (*Player_Romus_Italic: "Offer a high five."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The crisp morning air filled my lungs as I crossed the palace courtyard with Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "I was headed to a long-overdue meeting with Titus regardi..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "Salute back."]** — Mówca: **Player_Romus_Italic**
> "I saluted them in return."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Hugo and I continued on our way."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "Ignore them."]** — Mówca: **Player_Romus_Italic**
> "I ignored the guards and continued onward."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Hugo and I continued on our way."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "Wave halfheartedly."]** — Mówca: **Player_Romus_Italic**
> "I waved halfheartedly at them as I passed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Hugo and I continued on our way."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "Offer a high five."]** — Mówca: **Player_Romus_Italic**
> "I offered a high-five by holding up my hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shh! I want to see what happens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Certainly.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As king, I mustn't indulge in gambling, whether with money or life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""Fair enough.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time for this. Would you kindly get their attention?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""Right away.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your oversight is duly noted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Titus Gordion: ""Yes, sir. It won't happen again.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed. There are substantial benefits to strengthening ties between us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""More than you know. I believe the Golden Guard possesses..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forging a personal relationship is inconsequential. What matters most is his ability to perform his duties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""I can tell you firsthand that he's fully capable of exec..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sure what there is to be gained, but I am willing to keep an open mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""Excellent. Even if nothing comes of it, your willingness..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Doubtful. I've never formed close relationships with my security detail in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""Your ascension to the throne calls for a strengthening o..."*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""More than you know. I believe the Golden Guard possesses an untapped potential that would prove quite advantageous should the need arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""But I'm getting ahead of myself. Captain Gordion can tel..."*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Excellent. Even if nothing comes of it, your willingness to engage in meaningful conversation is encouraging.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Player_Romus: ""Titus is all that stands between me and an assassin's bu..."*)
  - -> `[492]` (*Player_Romus: ""Be honest with me, Hugo. Do you believe Gordion can be t..."*)
  - -> `[485]` (*Player_Romus: ""I've been impressed by Captain Gordion's loyalty thus far.""*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""I can tell you firsthand that he's fully capable of executing them with utmost proficiency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Player_Romus: ""Titus is all that stands between me and an assassin's bu..."*)
  - -> `[492]` (*Player_Romus: ""Be honest with me, Hugo. Do you believe Gordion can be t..."*)
  - -> `[485]` (*Player_Romus: ""I've been impressed by Captain Gordion's loyalty thus far.""*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Your ascension to the throne calls for a strengthening of all associations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Hugo Toras: ""In this case, building trust with the Golden Guard would..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "I was headed to a long-overdue meeting with Titus regarding the Golden Guard, and my uncle had insisted on accompanying me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""I'm glad you've arranged a formal meeting with Captain G..."*)

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""I'm glad you've arranged a formal meeting with Captain Gordion. There's much to be gained in fostering a robust relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""Agreed. There are substantial benefits to strengthening ..."*)
  - -> `[16]` (*Player_Romus: ""I'm not sure what there is to be gained, but I am willin..."*)
  - -> `[17]` (*Player_Romus: ""Doubtful. I've never formed close relationships with my ..."*)
  - -> `[15]` (*Player_Romus: ""Forging a personal relationship is inconsequential. What..."*)

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""But I'm getting ahead of myself. Captain Gordion can tell you more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Player_Romus: ""Titus is all that stands between me and an assassin's bu..."*)
  - -> `[492]` (*Player_Romus: ""Be honest with me, Hugo. Do you believe Gordion can be t..."*)
  - -> `[485]` (*Player_Romus: ""I've been impressed by Captain Gordion's loyalty thus far.""*)

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""In this case, building trust with the Golden Guard would benefit palace security as well as your own personal well-being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Player_Romus: ""Titus is all that stands between me and an assassin's bu..."*)
  - -> `[492]` (*Player_Romus: ""Be honest with me, Hugo. Do you believe Gordion can be t..."*)
  - -> `[485]` (*Player_Romus: ""I've been impressed by Captain Gordion's loyalty thus far.""*)

### Węzeł `[26]`
Mówca: **Narrator**
> "It wasn't long before we'd crossed the courtyard and reached the armory, which also served the Golden Guard's headquarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "As we approached, a pair of soldiers, flanked on either s..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Both seemed unsure how to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""Come on... Don't leave me hanging.""*)
  - -> `[29]` (*Player_Romus: ""Celebratory palm slap, all around!""*)
  - -> `[30]` (*Player_Romus: ""Don't worry, I'm granting you permission to touch me.""*)
  - -> `[31]` (*Player_Romus: ""High-five me. That's an order.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on... Don't leave me hanging.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Letting down their guard, literally and figuratively, the..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Celebratory palm slap, all around!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "That made them smile before giving me a high-five."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, I'm granting you permission to touch me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "They hesitated at first before they each gave me a high-f..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""High-five me. That's an order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "They looked at one another for confirmation before doing ..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Letting down their guard, literally and figuratively, they both reached out and gave me a high-five."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Alright! That's what I'm talking about.""*)
  - -> `[39]` (*Player_Romus: ""Now one down low.""*)
  - -> `[38]` (*Player_Romus: ""Excellent! You both have promising futures ahead of you.""*)
  - -> `[33]` (*Player_Romus: ""See? That wasn't so hard.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? That wasn't so hard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""I think it's best if we move on.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright! That's what I'm talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""I think it's best if we move on.""*)

### Węzeł `[35]`
Mówca: **Narrator**
> "They looked at one another for confirmation before doing as instructed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Alright! That's what I'm talking about.""*)
  - -> `[39]` (*Player_Romus: ""Now one down low.""*)
  - -> `[38]` (*Player_Romus: ""Excellent! You both have promising futures ahead of you.""*)
  - -> `[33]` (*Player_Romus: ""See? That wasn't so hard.""*)

### Węzeł `[36]`
Mówca: **Narrator**
> "They hesitated at first before they each gave me a high-five."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Alright! That's what I'm talking about.""*)
  - -> `[39]` (*Player_Romus: ""Now one down low.""*)
  - -> `[38]` (*Player_Romus: ""Excellent! You both have promising futures ahead of you.""*)
  - -> `[33]` (*Player_Romus: ""See? That wasn't so hard.""*)

### Węzeł `[37]`
Mówca: **Narrator**
> "That made them smile before giving me a high-five."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Alright! That's what I'm talking about.""*)
  - -> `[39]` (*Player_Romus: ""Now one down low.""*)
  - -> `[38]` (*Player_Romus: ""Excellent! You both have promising futures ahead of you.""*)
  - -> `[33]` (*Player_Romus: ""See? That wasn't so hard.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent! You both have promising futures ahead of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""I think it's best if we move on.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now one down low.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "I lowered my outstretched palm just as Hugo stepped betwe..."*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""I think it's best if we move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""You're right. Lead the way!""*)
  - -> `[44]` (*Player_Romus: ""You're no fun... But yes. Let us continue onward.""*)
  - -> `[42]` (*Player_Romus: ""I'll leave when I say I'm ready.""*)

### Węzeł `[41]`
Mówca: **Narrator**
> "I lowered my outstretched palm just as Hugo stepped between me and the guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""I think it's best if we move on.""*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll leave when I say I'm ready.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I let a moment of silence fall between us."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Lead the way!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Hugo Toras: ""Yes, Your Majesty.""*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're no fun... But yes. Let us continue onward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Right. This way, Your Majesty.""*)

### Węzeł `[45]`
Mówca: **Narrator**
> "I let a moment of silence fall between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""Okay. Now I'm ready.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. Now I'm ready.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Right. This way, Your Majesty.""*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""Right. This way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1;"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Hugo and I continued on our way."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Hugo and I continued on our way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Upon entering the armory, I found myself surrounded by a ..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Upon entering the armory, I found myself surrounded by a collection of old weaponry and armor on display. The polished shields and rusted swords appeared frozen in time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "We eventually reached a training facility where we found Captain Gordion in boxing gloves sparring with another Golden Guardsman."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""My money is on Captain Gordion. What do you say, 50 guil..."*)

### Węzeł `[52]`
Mówca: **Titus Gordion**
> ""You're wasting too much energy running around the ring. Next time--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Titus Gordion: ""Your Majesty! Many apologies. I didn't see you there. Yo..."*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""My money is on Captain Gordion. What do you say, 50 guilder?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""I'll take that bet.""*)
  - -> `[66]` (*Player_Romus: ""No, *my* money is on Captain Gordion. You take the other..."*)
  - -> `[10]` (*Player_Romus: ""Shh! I want to see what happens.""*)
  - -> `[11]` (*Player_Romus: ""As king, I mustn't indulge in gambling, whether with mon..."*)
  - -> `[12]` (*Player_Romus: ""I don't have time for this. Would you kindly get their a..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll take that bet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""You're on.""*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""You're on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "The two men circled each other for a while before they st..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hugo Toras: ""Captain Gordion?""*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Narrator: "As the two men circled each other, we observed their care..."*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hugo Toras: ""Captain Gordion?""*)

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""Captain Gordion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "The captain turned to face us. He and his opponent bowed ..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "The captain turned to face us. He and his opponent bowed their heads when they saw me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Titus Gordion: ""Forgive me, Your Majesty. I didn't see you there. You're..."*)

### Węzeł `[61]`
Mówca: **Titus Gordion**
> ""Forgive me, Your Majesty. I didn't see you there. You're earlier than I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""If anything, I should be the one apologizing for interru..."*)
  - -> `[63]` (*Player_Romus: ""It's not your fault. I arrived sooner than anticipated.""*)
  - -> `[13]` (*Player_Romus: ""Your oversight is duly noted.""*)
  - -> `[64]` (*Player_Romus: ""I'm surprised you were unaware of your king's whereabout..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If anything, I should be the one apologizing for interrupting you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Titus Gordion: ""No need, but I appreciate the sentiment. I was just show..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your fault. I arrived sooner than anticipated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Titus Gordion: ""Well, it's great to have you here, regardless of when yo..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm surprised you were unaware of your king's whereabouts, considering that falls within your jurisdiction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Titus Gordion: ""My men have eyes on you at all times, Your Majesty. In t..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "The two men circled each other for a while before they started swinging. Three rounds later, the Captain had his opponent on the ropes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Hugo Toras: ""Still feeling confident about your choice?""*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, *my* money is on Captain Gordion. You take the other man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Very well. Let the best man win!""*)

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Very well. Let the best man win!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "The two men circle each other for a while before exchangi..."*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""It appears Captain Gordion has emerged victorious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""Yes, it does. I would pay you now, but I never carry cash.""*)
  - -> `[72]` (*Player_Romus: ""It certainly does. Looks like I owe you.""*)
  - -> `[70]` (*Player_Romus: ""You know I'm not paying you, right?""*)
  - -> `[71]` (*Player_Romus: ""What do you think... should I hop in the ring? I bet I c..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, it does. I would pay you now, but I never carry cash.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Hugo Toras: ""One of the many perks of being king! I'll come to collec..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I'm not paying you, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""That's not sportsmanlike at all. But very well, Your Maj..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think... should I hop in the ring? I bet I could take him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It certainly does. Looks like I owe you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""Let this be a life lesson!""*)

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""One of the many perks of being king! I'll come to collect at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I watched as Captain Gordion helped the other man to his ..."*)

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""Let this be a life lesson!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I watched as Captain Gordion helped the other man to his ..."*)

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""That's not sportsmanlike at all. But very well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I watched as Captain Gordion helped the other man to his ..."*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""As Grand Vizier to the king, I would be remiss to endorse such a course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I watched as Captain Gordion helped the other man to his ..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "I watched as Captain Gordion helped the other man to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Titus Gordion: ""You're wasting too much energy running around the ring. ..."*)

### Węzeł `[78]`
Mówca: **Titus Gordion**
> ""Your Majesty! Many apologies. I didn't see you there. You're earlier than I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""I'm here before my usual time. I should be the one apolo..."*)
  - -> `[82]` (*Player_Romus: ""No need to apologize. Just like in the ring, timing can ..."*)
  - -> `[79]` (*Player_Romus: ""Your lack of observation is disappointing. My early arri..."*)
  - -> `[81]` (*Player_Romus: ""Your oversight is evident. My punctuality shouldn't be a..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your lack of observation is disappointing. My early arrival shouldn't be unexpected.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Titus Gordion: ""Forgive me. It won't happen again.""*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm here before my usual time. I should be the one apologizing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Titus Gordion: ""No need, but I appreciate the sentiment.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your oversight is evident. My punctuality shouldn't be a surprise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Titus Gordion: ""Yes, Your Majesty. It won't happen again.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to apologize. Just like in the ring, timing can be a challenge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Titus Gordion: ""Very true, sir.""*)

### Węzeł `[83]`
Mówca: **Titus Gordion**
> ""Forgive me. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""In any case, let us take our leave. We have much to disc..."*)
  - -> `[87]` (*Player_Romus: ""Well, I don't have all day. Let us retire so we may disc..."*)
  - -> `[89]` (*Player_Romus: ""Alright, enough chit-chat. Let's get out of here and tal..."*)

### Węzeł `[84]`
Mówca: **Titus Gordion**
> ""No need, but I appreciate the sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""I must say, that's quite the right hook you got there.""*)
  - -> `[90]` (*Player_Romus: ""In any case, let us take our leave. We have much to disc..."*)
  - -> `[87]` (*Player_Romus: ""Well, I don't have all day. Let us retire so we may disc..."*)
  - -> `[89]` (*Player_Romus: ""Alright, enough chit-chat. Let's get out of here and tal..."*)

### Węzeł `[85]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""In any case, let us take our leave. We have much to disc..."*)
  - -> `[87]` (*Player_Romus: ""Well, I don't have all day. Let us retire so we may disc..."*)
  - -> `[89]` (*Player_Romus: ""Alright, enough chit-chat. Let's get out of here and tal..."*)

### Węzeł `[86]`
Mówca: **Titus Gordion**
> ""Very true, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""I must say, that's quite the right hook you got there.""*)
  - -> `[90]` (*Player_Romus: ""In any case, let us take our leave. We have much to disc..."*)
  - -> `[87]` (*Player_Romus: ""Well, I don't have all day. Let us retire so we may disc..."*)
  - -> `[89]` (*Player_Romus: ""Alright, enough chit-chat. Let's get out of here and tal..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I don't have all day. Let us retire so we may discuss the nature of my visit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Titus Gordion), `[84]` (Titus Gordion), `[85]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Titus Gordion: ""Absolutely.""*)
  - -> `[91]` (*Titus Gordion: ""As you wish.""*)
  - -> `[93]` (*Titus Gordion: ""Of, course.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must say, that's quite the right hook you got there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Titus Gordion), `[86]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Titus Gordion: ""Courtesy of my former boxing days.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, enough chit-chat. Let's get out of here and talk somewhere more private.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Titus Gordion), `[84]` (Titus Gordion), `[85]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Titus Gordion: ""Absolutely.""*)
  - -> `[91]` (*Titus Gordion: ""As you wish.""*)
  - -> `[93]` (*Titus Gordion: ""Of, course.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In any case, let us take our leave. We have much to discuss.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Titus Gordion), `[84]` (Titus Gordion), `[85]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Titus Gordion: ""Absolutely.""*)
  - -> `[91]` (*Titus Gordion: ""As you wish.""*)
  - -> `[93]` (*Titus Gordion: ""Of, course.""*)

### Węzeł `[91]`
Mówca: **Titus Gordion**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Titus Gordion: ""If you'll follow me, we can delve into the matter you've..."*)

### Węzeł `[92]`
Mówca: **Titus Gordion**
> ""Absolutely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Titus Gordion: ""If you'll follow me, we can delve into the matter you've..."*)

### Węzeł `[93]`
Mówca: **Titus Gordion**
> ""Of, course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Titus Gordion: ""If you'll follow me, we can delve into the matter you've..."*)

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""If you'll follow me, we can delve into the matter you've here to address.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "Jump to: [Follow_Titus_Hub]"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Follow_Titus_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "Follow_Titus_Hub"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "The two men circle each other for a while before exchanging swings. Three rounds later, the Captain had Hugo's guy in a tight spot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player_Romus: ""It appears my man has the upper hand.""*)
  - -> `[524]` (*Player_Romus: ""What do you say we double the bet?""*)
  - -> `[525]` (*Player_Romus: ""Are your knees starting to shake, Uncle?""*)

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""And Titus has emerged victoriously. Looks like I owe you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""Guess I have a knack for picking winners.""*)
  - -> `[101]` (*Player_Romus: ""Yep. Now pay up.""*)
  - -> `[99]` (*Player_Romus: ""Oh, don't worry about it. It was a lighthearted wager.""*)
  - -> `[100]` (*Player_Romus: ""We should have them go another round. What do you say? R..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guess I have a knack for picking winners.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Hugo Toras: ""No doubt a useful skill to possess.""*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, don't worry about it. It was a lighthearted wager.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Hugo Toras: ""Much appreciated.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should have them go another round. What do you say? Raise the bet? Double or nothing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: ""Tempting, but no thanks. I've already lost once today. I..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yep. Now pay up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Hugo Toras: ""Certainly -- as soon as we've concluded this meeting.""*)

### Węzeł `[102]`
Mówca: **Hugo Toras**
> ""No doubt a useful skill to possess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I watched as Captain Gordion helped the other man to his ..."*)

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""Certainly -- as soon as we've concluded this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I watched as Captain Gordion helped the other man to his ..."*)

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""Much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I watched as Captain Gordion helped the other man to his ..."*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""Tempting, but no thanks. I've already lost once today. I don't need a repeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I watched as Captain Gordion helped the other man to his ..."*)

### Węzeł `[106]`
Mówca: **Titus Gordion**
> ""No need, but I appreciate the sentiment. I was just showing our newest recruit a thing or two in the ring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""I must say, that's quite the right hook you got there.""*)
  - -> `[110]` (*Player_Romus: ""In any event, we should get moving. We have plenty to ta..."*)
  - -> `[669]` (*Player_Romus: ""You'll have to teach me how to fight like that sometime.""*)

### Węzeł `[107]`
Mówca: **Titus Gordion**
> ""My men have eyes on you at all times, Your Majesty. In the event of an emergency, I would have been contacted at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""I must say, that's quite the right hook you got there.""*)
  - -> `[110]` (*Player_Romus: ""In any event, we should get moving. We have plenty to ta..."*)
  - -> `[669]` (*Player_Romus: ""You'll have to teach me how to fight like that sometime.""*)

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""Yes, sir. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""In any event, we should get moving. We have plenty to ta..."*)
  - -> `[669]` (*Player_Romus: ""You'll have to teach me how to fight like that sometime.""*)

### Węzeł `[109]`
Mówca: **Titus Gordion**
> ""Well, it's great to have you here, regardless of when you arrived.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""I must say, that's quite the right hook you got there.""*)
  - -> `[110]` (*Player_Romus: ""In any event, we should get moving. We have plenty to ta..."*)
  - -> `[669]` (*Player_Romus: ""You'll have to teach me how to fight like that sometime.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In any event, we should get moving. We have plenty to talk about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Titus Gordion), `[107]` (Titus Gordion), `[108]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Titus Gordion: ""Absolutely. Right this way.""*)

### Węzeł `[111]`
Mówca: **Titus Gordion**
> ""Absolutely. Right this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "Follow_Titus_Hub"*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must say, that's quite the right hook you got there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Titus Gordion), `[107]` (Titus Gordion), `[109]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Titus Gordion: ""Compliments of my old boxing days.""*)

### Węzeł `[113]`
Mówca: **Hugo Toras**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1;"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Although the other fighter managed to land a few hits, the match concluded with Captain Gordion prevailing, thanks to a powerful punch to his opponent's jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus_Italic: "Applaud."*)
  - -> `[115]` (*Player_Romus_Italic: "Clear your throat."*)
  - -> `[117]` (*Player_Romus: ""Bravo!""*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "Clear your throat."]** — Mówca: **Player_Romus_Italic**
> "I cleared my throat to make them aware of my presence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "The captain turned to face us. He and his opponent bowed ..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "Applaud."]** — Mówca: **Player_Romus_Italic**
> "I lightly applauded his win."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "The captain turned to face us. He and his opponent bowed ..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bravo!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "The captain turned to face us. He and his opponent bowed ..."*)

### Węzeł `[118]`
Mówca: **Titus Gordion**
> ""Courtesy of my former boxing days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxin..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Player_Romus: ""Regardless, we should go. We've got plenty to talk about.""*)
  - -> `[503]` (*Player_Romus: ""Well, I don't have all day. Let's find a place to discus..."*)
  - -> `[504]` (*Player_Romus: ""Okay, that's enough small talk. Let's shift this convers..."*)

### Węzeł `[120]`
Mówca: **Titus Gordion**
> ""Compliments of my old boxing days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxin..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Titus Gordion: ""But enough tomfoolery. I know you must be very busy.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "We eventually reached a training facility where we found ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Tur..."*)

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""Well, Your Majesty... shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Romus: ""Let's go.""*)
  - -> `[125]` (*Player_Romus: ""If we must.""*)
  - -> `[128]` (*Player_Romus: ""I believe the kind of trust you want me to build with th..."*)
  - -> `[127]` (*Player_Romus: ""Thanks, but your counsel is no longer required. I'd like..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we must.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Hugo Toras: ""If you want to ensure the good captain is on our side, t..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Hugo Toras: ""After you.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but your counsel is no longer required. I'd like to speak to the captain alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Hugo Toras: ""I see. Well, if that is your wish, I will stay where I am.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe the kind of trust you want me to build with the Golden Guard can only be established by meeting Titus one-on-one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Hugo Toras: ""Really? I mean... yes, of course.""*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Captain Gordion removed his boxing gloves as he headed toward an entrance to another wing of the armory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""Well, Your Majesty... shall we?""*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take a tour of the armory or find some other means to entertain yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras), `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Hugo Toras: ""Very well, then.""*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Now get to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras), `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Hugo Toras: ""As you command.""*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can wait around until my business is complete, but you're welcome to take your leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras), `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: ""Yes. Understood.""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[134]`
Mówca: **Hugo Toras**
> ""I see. Well, if that is your wish, I will stay where I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Romus: ""You can wait around until my business is complete, but y..."*)
  - -> `[131]` (*Player_Romus: ""Good. Now get to it.""*)
  - -> `[130]` (*Player_Romus: ""Take a tour of the armory or find some other means to en..."*)

### Węzeł `[135]`
Mówca: **Hugo Toras**
> ""Really? I mean... yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Romus: ""You can wait around until my business is complete, but y..."*)
  - -> `[131]` (*Player_Romus: ""Good. Now get to it.""*)
  - -> `[130]` (*Player_Romus: ""Take a tour of the armory or find some other means to en..."*)

### Węzeł `[136]`
Mówca: **Hugo Toras**
> ""After you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent = true"*)

### Węzeł `[137]`
Mówca: **Hugo Toras**
> ""If you want to ensure the good captain is on our side, then yes. We 'must.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent = true"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Hugo seemed to force a smile before bowing his head and turning away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1;"*)

### Węzeł `[139]`
Mówca: **Hugo Toras**
> ""Very well, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing = ..."*)

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""As you command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing = ..."*)

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""Yes. Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing = ..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "Hugo and I caught up to Titus as he stepped inside the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Upon entering, we were once again enveloped by an array o..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "I left my uncle and caught up to Captain Gordion as he st..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Upon entering, we were once again enveloped by an array of antiquated weaponry and armor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Titus motioned toward the displays."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quite the arsenal you've got here, Captain.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[150]` (Hugo Toras), `[157]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Titus Gordion: ""Believe me, this is just a fraction of what the palace h..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like what you've done with the place.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[157]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Titus Gordion: ""You're more than welcome to visit anytime -- not that yo..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've often found that focusing too much on memorializing the past can impede progress.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[150]` (Hugo Toras), `[157]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Titus Gordion: ""True, though I personally believe that such memorials ca..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bows and arrows? Duchess Azaro wasn't kidding when she said our military needed upgrading.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[150]` (Hugo Toras), `[157]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[150]`
Mówca: **Hugo Toras**
> ""I'm pleased you take such an interest in preserving Rizia's history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Player_Romus: ""Same. I like what you've done with the place.""*)
  - -> `[147]` (*Player_Romus: ""I've often found that focusing too much on memorializing..."*)
  - -> `[145]` (*Player_Romus: ""Quite the arsenal you've got here, Captain.""*)
  - -> `[148]` (*Player_Romus: ""Bows and arrows? Duchess Azaro wasn't kidding when she s..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Titus motioned toward the displays."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Titus Gordion: ""I brought most of this out of storage soon after I took ..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "That drew a laugh from my uncle, while the captain simply smiled patiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Titus Gordion: ""Well, we still have several trebuchets on standby in cas..."*)

### Węzeł `[153]`
Mówca: **Titus Gordion**
> ""You're more than welcome to visit anytime -- not that you need an invitation. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Titus Gordion: ""If you desire, I'd be honored to provide you with the ba..."*)

### Węzeł `[154]`
Mówca: **Titus Gordion**
> ""True, though I personally believe that such memorials can offer inspiration. Especially during times of great difficulty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Titus Gordion: ""If you desire, I'd be honored to provide you with the ba..."*)

### Węzeł `[155]`
Mówca: **Titus Gordion**
> ""Believe me, this is just a fraction of what the palace has got tucked away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Titus Gordion: ""If you desire, I'd be honored to provide you with the ba..."*)

### Węzeł `[156]`
Mówca: **Titus Gordion**
> ""Well, we still have several trebuchets on standby in case we need to fling cows at the enemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[157]`
Mówca: **Titus Gordion**
> ""I brought most of this out of storage soon after I took command. A considerable portion of what you see was in bad shape and required extensive refurbishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[158]`
Mówca: **Hugo Toras**
> ""Ha! As long as we get the green light from animal rights activists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Titus Gordion: ""But in all seriousness...""*)

### Węzeł `[159]`
Mówca: **Titus Gordion**
> ""But in all seriousness...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Titus Gordion: ""If you desire, I'd be honored to provide you with the ba..."*)

### Węzeł `[160]`
Mówca: **Titus Gordion**
> ""If you desire, I'd be honored to provide you with the background and history of anything here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""Very well. Let's hear it.""*)
  - -> `[161]` (*Player_Romus: ""Please, by all means.""*)
  - -> `[164]` (*Player_Romus: ""Tempted as I am, time is of the essence.""*)
  - -> `[163]` (*Player_Romus: ""No, thank you. I always found history lessons boring.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, by all means.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Titus Gordion: ""Excellent. Where would you like to start?""*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. Let's hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Titus Gordion: ""Certainly. What would you like to hear about first?""*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, thank you. I always found history lessons boring.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Titus Gordion: ""Understandable. The study of history isn't to everyone's..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tempted as I am, time is of the essence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Titus Gordion: ""Perhaps some other day then.""*)

### Węzeł `[165]`
Mówca: **Titus Gordion**
> ""Certainly. What would you like to hear about first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaHistoryHub"*)

### Węzeł `[166]`
Mówca: **Titus Gordion**
> ""Perhaps some other day then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[167]`
Mówca: **Titus Gordion**
> ""Excellent. Where would you like to start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaHistoryHub"*)

### Węzeł `[168]`
Mówca: **Titus Gordion**
> ""Understandable. The study of history isn't to everyone's liking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaHistoryHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == false"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == false"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory =..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == tru..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you tell me about that sword?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == false`
- **Kontekst wejściowy (poprzednik):** `[165]` (Titus Gordion), `[167]` (Titus Gordion), `[212]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "I motioned to a broadsword prominently displayed in the c..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about that impressive suit of armor.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == false`
- **Kontekst wejściowy (poprzednik):** `[165]` (Titus Gordion), `[167]` (Titus Gordion), `[212]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Narrator: "I pointed to an intricately adorned armored suit that sto..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough history. I'm ready to move on.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true`
- **Kontekst wejściowy (poprzednik):** `[165]` (Titus Gordion), `[167]` (Titus Gordion), `[212]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_MoveOn = true;"*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm curious to know about... whatever *that* is.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == false`
- **Kontekst wejściowy (poprzednik):** `[165]` (Titus Gordion), `[167]` (Titus Gordion), `[212]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Narrator: "I gestured toward a metallic, coffin-like contraption tha..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == tru..."*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == t..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Romus: ""Enough history. I'm ready to move on.""*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == false"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == f..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""Why don't you tell me about that sword?""*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == false"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == f..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""Tell me about that impressive suit of armor.""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory =..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus: ""I'm curious to know about... whatever *that* is.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Titus Gordion**
> ""Very well. This way, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "We continued onward until we reached Captain Gordion's of..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "Jump to: [RiziaHistoryHub]"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "Jump to: [RiziaHistoryHub]"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "Jump to: [RiziaHistoryHub]"*)

### Węzeł `[190]`
Mówca: **Titus Gordion**
> ""You'll be happy to know it hasn't been used in quite some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Player_Romus: ""Hypothetically, could it still be used today?""*)
  - -> `[446]` (*Player_Romus: ""Yes. Most reassuring.""*)
  - -> `[447]` (*Player_Romus: ""Hard to believe it was used at all.""*)
  - -> `[448]` (*Player_Romus: ""Too bad. A lot of fun could be had with that.""*)

### Węzeł `[191]`
Mówca: **Titus Gordion**
> ""Enhanced interrogation methods have come a long way in the past century. No need for metal spikes unless you're a traditionalist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Titus Gordion: ""What else can I tell you about?""*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RiziaHistoryHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaHistoryHub"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_MoveOn = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_MoveOn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Titus Gordion: ""Very well. This way, sir.""*)

### Węzeł `[194]`
Mówca: **Titus Gordion**
> ""That would be 'Saint Mercy,' our aptly named iron maiden -- a torture device from a bygone era. It was last used on suspected spies during the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Titus Gordion: ""Lined with spikes on the inside, it was designed to infl..."*)

### Węzeł `[195]`
Mówca: **Titus Gordion**
> ""'Terador's Fury.' Its notoriety spans back several hundred years, just after the Empire of Valgos seized Pales from Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Titus Gordion: ""Although we lost our most important port, we managed to ..."*)

### Węzeł `[196]`
Mówca: **Titus Gordion**
> ""Although we lost our most important port, we managed to keep our enemy from making further inroads into the kingdom at the Battle of Terador.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[197]`
Mówca: **Titus Gordion**
> ""After securing power in Monqiz, his dynasty maintained a stronghold over the city-state throughout the Markian era.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Titus Gordion: ""Upon the foundation of the Kingdom of Rizia, they assume..."*)

### Węzeł `[198]`
Mówca: **Hugo Toras**
> ""Legend has it, this sword took off the head of the Valgos army's top general.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""But it wasn't enough to prevent Pales being taken from R..."*)
  - -> `[200]` (*Player_Romus: ""A bad day for him.""*)
  - -> `[199]` (*Player_Romus: ""It's considered bad luck to mention severed heads in the..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's considered bad luck to mention severed heads in the presence of a king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Hugo Toras), `[473]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A bad day for him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Hugo Toras), `[473]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Titus Gordion: ""To put it lightly...""*)

### Węzeł `[201]`
Mówca: **Titus Gordion**
> ""That would be the armor of King Henricus Toras, the ancestor from whom all members of your house are descended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Titus Gordion: ""After securing power in Monqiz, his dynasty maintained a..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But it wasn't enough to prevent Pales being taken from Rizia. That's what keeps me awake at night.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Hugo Toras), `[473]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Titus Gordion: ""It is indeed a sore spot in our history.""*)

### Węzeł `[203]`
Mówca: **Titus Gordion**
> ""But I'm sure you knew that already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player_Romus: ""Yes, but it's always good to refresh myself on our histo..."*)
  - -> `[453]` (*Player_Romus: ""Obviously.""*)
  - -> `[452]` (*Player_Romus: ""I'm more interested in knowing if his armor would fit me.""*)

### Węzeł `[204]`
Mówca: **Hugo Toras**
> ""Yes. However, if I may be so bold, Your Majesty, there are valuable lessons to be learned from looking to Rizia's past -- lessons that could address present-day challenges, should they arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""Fine, fine... You've convinced me. Let's hear it.""*)
  - -> `[205]` (*Player_Romus: ""If you both think it's that important, then go ahead, Ca..."*)
  - -> `[208]` (*Player_Romus: ""I agree with you, Uncle. However, it isn't something I'm..."*)
  - -> `[207]` (*Player_Romus: ""What part of 'I have other priorities' do you not unders..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you both think it's that important, then go ahead, Captain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Hugo Toras), `[214]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Titus Gordion: ""Any items of particular interest?""*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine, fine... You've convinced me. Let's hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Hugo Toras), `[214]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Titus Gordion: ""Certainly. Where would you like to start?""*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What part of 'I have other priorities' do you not understand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Hugo Toras: ""Got it. I won't bring it up again.""*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with you, Uncle. However, it isn't something I'm interested in delving into at the moment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Hugo Toras), `[214]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Hugo Toras: ""Very well. I'll refrain from mentioning it further.""*)

### Węzeł `[209]`
Mówca: **Hugo Toras**
> ""Very well. I'll refrain from mentioning it further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "We continued onward until we reached Captain Gordion's of..."*)

### Węzeł `[210]`
Mówca: **Hugo Toras**
> ""Got it. I won't bring it up again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1;"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "We continued onward until we reached Captain Gordion's of..."*)

### Węzeł `[212]`
Mówca: **Titus Gordion**
> ""Certainly. Where would you like to start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaHistoryHub"*)

### Węzeł `[213]`
Mówca: **Titus Gordion**
> ""Any items of particular interest?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaHistoryHub"*)

### Węzeł `[214]`
Mówca: **Hugo Toras**
> ""If I may be so bold, Your Majesty, there are valuable lessons to be learned from looking to Rizia's past -- lessons that could address present-day challenges, should they arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""Fine, fine... You've convinced me. Let's hear it.""*)
  - -> `[205]` (*Player_Romus: ""If you both think it's that important, then go ahead, Ca..."*)
  - -> `[208]` (*Player_Romus: ""I agree with you, Uncle. However, it isn't something I'm..."*)
  - -> `[215]` (*Player_Romus: ""I already said I'm not interested. Nor did I ask for you..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I already said I'm not interested. Nor did I ask for your advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Hugo Toras: ""Then I won't mention it again.""*)

### Węzeł `[216]`
Mówca: **Hugo Toras**
> ""Then I won't mention it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1;"*)

### Węzeł `[217]`
Mówca: **Narrator**
> "We continued onward until we reached Captain Gordion's office on the far side of the hall. It too was adorned with a large collection of war memorabilia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "Captain Gordion gestured to a sitting area."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "Captain Gordion gestured to a sitting area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Titus Gordion: ""Please, have a seat.""*)

### Węzeł `[219]`
Mówca: **Titus Gordion**
> ""Please, have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[220]`
Mówca: **Narrator**
> "Uncle Hugo sat on a sofa that looked to have been plucked from the 19th century."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Player_Romus_Italic: "Sit down."*)
  - -> `[502]` (*Player_Romus_Italic: "Keep standing."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "Sit."]** — Mówca: **Player_Romus_Italic**
> "I sat on a nearby leather armchair."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[219]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_Sit = true;"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "Remain standing."]** — Mówca: **Player_Romus_Italic**
> "I remained standing."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[219]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_Sit = false;"*)

### Węzeł `[223]`
Mówca: **Narrator**
> "Hugo, seeming suddenly self-aware of being the only one sitting, promptly stood back up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "The captain took out a bottle of wine from a cabinet."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Drinking on the job? You should both be ashamed of yourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[714]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Titus Gordion: ""You're right. My mistake.""*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The fact that you would consider drinking on the job raises questions about your professionalism, Titus.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[719]` (Hugo Toras), `[228]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Titus Gordion: ""We in the Golden Guard are trained to keep our resources..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just a little bit. I've got to stay sharp for the rest of the day's activities.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Hugo Toras), `[228]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Titus Gordion: ""Of course.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had me at 'fortified'. Regular wine's for weaklings.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` AND `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Titus Gordion: ""This one's strong indeed. But it's mellowed out over the..."*)

### Węzeł `[228]`
Mówca: **Titus Gordion**
> ""Would you care for some fortified wine? It's an exceptional vintage dating back to 1893. From Rizia's very own Cantuavo vineyards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[229]`
Mówca: **Narrator**
> "The captain took out a bottle of wine from a cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Titus Gordion: ""Would you care for some fortified wine? It's an exceptio..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but no thanks. I only drink wine from 1892.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Hugo Toras), `[228]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[231]`
Mówca: **Titus Gordion**
> ""So to what do I owe the pleasure of your company today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""I'm looking to develop a clearer understanding of the in..."*)
  - -> `[246]` (*Player_Romus: ""As the King of Rizia, I have many enemies. I wanted to m..."*)
  - -> `[248]` (*Player_Romus: ""I wanted to get away from my council and speak to a real..."*)
  - -> `[249]` (*Player_Romus: ""My uncle suggested I get to know you better, believing t..."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "Captain Gordion put the bottle away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Titus Gordion: ""So to what do I owe the pleasure of your company today?""*)

### Węzeł `[233]`
Mówca: **Titus Gordion**
> ""You're right. My mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""And mine as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Captain Gordion put the bottle away."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Titus Gordion: ""Sorry. I'm afraid I'm fresh out of wine from that year.""*)

### Węzeł `[236]`
Mówca: **Titus Gordion**
> ""Sorry. I'm afraid I'm fresh out of wine from that year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[237]`
Mówca: **Hugo Toras**
> ""I believe His Majesty was joking. But perhaps we should all abstain after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Captain Gordion put the bottle away."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "Captain Gordion uncorked the bottle and poured us each a glass. We briefly toasted and took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_Sit = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_Sit = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "The captain took out a bottle of wine from a cabinet."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "After putting it away, he settled in a chair across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Titus Gordion: ""So to what do I owe the pleasure of your company today?""*)

### Węzeł `[242]`
Mówca: **Narrator**
> "After putting it away, he stood facing me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Titus Gordion: ""So to what do I owe the pleasure of your company today?""*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true )"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "After putting it away, he settled in a chair across from me."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "After putting it away, he stood facing me."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As the King of Rizia, I have many enemies. I wanted to make sure you're not one of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Titus Gordion: ""Certainly not, Your Majesty. Please, ask me anything.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm looking to develop a clearer understanding of the individuals comprising my security detail, particularly the man who's leading them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Titus Gordion: ""Well, I'm more than happy to tell you about myself, thou..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to get away from my council and speak to a real commoner. Your perspectives are always so refreshing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My uncle suggested I get to know you better, believing that building a personal relationship beyond our professional one would be highly beneficial.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Titus Gordion: ""I don't see why not. What would you like to know?""*)

### Węzeł `[250]`
Mówca: **Titus Gordion**
> ""Well, I'm more than happy to tell you about myself, though you might find hearing about the Golden Guard more interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "GoldenTitusHistoryHub"*)

### Węzeł `[251]`
Mówca: **Titus Gordion**
> ""I don't see why not. What would you like to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "GoldenTitusHistoryHub"*)

### Węzeł `[252]`
Mówca: **Titus Gordion**
> ""It's been quite some time since I was among the common people, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "GoldenTitusHistoryHub"*)

### Węzeł `[253]`
Mówca: **Titus Gordion**
> ""Certainly not, Your Majesty. Please, ask me anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "GoldenTitusHistoryHub"*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you tell me more about yourself?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Titus Gordion), `[251]` (Titus Gordion), `[252]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Titus Gordion: ""Well, I was born and raised in Porte Drazon. My father w..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hear more about the Golden Guard.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Titus Gordion), `[251]` (Titus Gordion), `[252]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Titus Gordion: ""I'd be honored. As you already know, each guardsman stat..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == true && RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground  == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == ..."*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground =..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == true && RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground  == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player_Romus: ""Thanks for sharing, Titus.""*)
  - -> `[383]` (*Player_Romus: ""I appreciate your thorough explanation, Titus, but try t..."*)
  - -> `[381]` (*Player_Romus: ""Your comprehensive explanation is appreciated.""*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == true && RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground  == true 
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == ..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground =..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player_Romus: ""Why don't you tell me more about yourself?""*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgr..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: ""Let's hear more about the Golden Guard.""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
Mówca: **Titus Gordion**
> ""Well, I was born and raised in Porte Drazon. My father was in the military while my mother took care of me and my siblings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Titus Gordion: ""I had a fairly normal childhood until my father was kill..."*)

### Węzeł `[266]`
Mówca: **Titus Gordion**
> ""I'd be honored. As you already know, each guardsman stationed in this palace and across Rizia Imperii has sworn an oath to protect the royal household. We answer to no one else but you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player_Romus: ""Go on.""*)
  - -> `[289]` (*Player_Romus: ""Yes, yes... We've been over that already. Tell me someth..."*)
  - -> `[290]` (*Player_Romus: ""And I am forever grateful. Please, continue.""*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GoldenTitusHistoryHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == ..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == ..."*)
  - -> `[695]` (*Player_Romus: ""I feel like I've heard enough of the past for now.""*)

### Węzeł `[268]`
Mówca: **Titus Gordion**
> ""Gladly. Aside from general security, the Golden Guard has had a long history of carrying out more *private* matters for the king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player_Romus: ""'Private matters?' How intriguing. Please elaborate.""*)
  - -> `[292]` (*Player_Romus: ""Oh, I'm definitely interested in hearing more.""*)
  - -> `[293]` (*Player_Romus: ""That sounds rather ominous.""*)
  - -> `[294]` (*Player_Romus: ""I don't like the sound of that.""*)

### Węzeł `[269]`
Mówca: **Titus Gordion**
> ""As in *offensive* operations, if you get my meaning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He gave his life for a good cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Titus Gordion: ""He believed in it with all his heart. He never turned ag..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So much senseless bloodshed. May it never happen again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Titus Gordion: ""For what it's worth, sir, he believed in the cause. He n..."*)

### Węzeł `[272]`
Mówca: **Titus Gordion**
> ""That's where my military training comes in. I was selected to benefit from the highest-level instruction at Camp Domus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Titus Gordion: ""I worked my way up through the ranks until just a few ye..."*)

### Węzeł `[273]`
Mówca: **Titus Gordion**
> ""For what it's worth, sir, he believed in the cause. He never turned against King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Titus Gordion: ""Needless to say, his death brought about a long period o..."*)

### Węzeł `[274]`
Mówca: **Titus Gordion**
> ""He believed in it with all his heart. He never turned against King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Titus Gordion: ""Needless to say, his death brought about a long period o..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry for your loss. Didn't mean to bring up bad memories.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Titus Gordion: ""Not a problem, sir. He died fighting for what he believe..."*)

### Węzeł `[276]`
Mówca: **Titus Gordion**
> ""Not a problem, sir. He died fighting for what he believed in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Titus Gordion: ""Needless to say, his death brought about a long period o..."*)

### Węzeł `[277]`
Mówca: **Titus Gordion**
> ""I took up championship boxing to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player_Romus: ""Were you any good?""*)
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxin..."*)
  - -> `[689]` (*Player_Romus: ""So you're good at hand-to-hand combat. But my enemies wi..."*)
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[278]`
Mówca: **Titus Gordion**
> ""I had a fairly normal childhood until my father was killed during the operation to take back Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""He gave his life for a good cause.""*)
  - -> `[271]` (*Player_Romus: ""So much senseless bloodshed. May it never happen again.""*)
  - -> `[275]` (*Player_Romus: ""I'm sorry for your loss. Didn't mean to bring up bad mem..."*)

### Węzeł `[279]`
Mówca: **Titus Gordion**
> ""Needless to say, his death brought about a long period of financial instability. My mother did what she could, but it wasn't enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[280]`
Mówca: **Hugo Toras**
> ""How did you get by?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Titus Gordion: ""I took up championship boxing to support us.""*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that explains your fisticuffs from earlier! You fared well, I assume?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[417]` (Titus Gordion), `[277]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Titus Gordion: ""Good enough to catch the eye of military recruiters. I d..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Were you any good?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Titus Gordion), `[417]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Titus Gordion: ""Good enough to attract the attention of military recruit..."*)

### Węzeł `[283]`
Mówca: **Titus Gordion**
> ""Good enough to catch the eye of military recruiters. I do sometimes miss those days in the ring on occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Titus Gordion: ""I worked my way up through the ranks until just a few ye..."*)

### Węzeł `[284]`
Mówca: **Titus Gordion**
> ""Good enough to attract the attention of military recruiters. I do find myself longing for those days in the ring from time to time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Titus Gordion: ""I worked my way up through the ranks until just a few ye..."*)

### Węzeł `[285]`
Mówca: **Titus Gordion**
> ""I worked my way up through the ranks until just a few years ago, when General Taddeus Azaro approached me with the idea of reinstating the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground = t..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GoldenTitusHistoryHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "GoldenTitusHistoryHub"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoldenTitusHistoryHub]"*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Titus Gordion: ""Gladly. Aside from general security, the Golden Guard ha..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, yes... We've been over that already. Tell me something I don't know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Titus Gordion: ""Gladly. Aside from general security, the Golden Guard ha..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I am forever grateful. Please, continue.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Titus Gordion: ""Gladly. Aside from general security, the Golden Guard ha..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Private matters?' How intriguing. Please elaborate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Titus Gordion: ""As in *offensive* operations, if you get my meaning.""*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, I'm definitely interested in hearing more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Titus Gordion: ""Let's just say... the public is better off not not knowi..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds rather ominous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Titus Gordion: ""We do what we must to ensure the protection of the monar..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like the sound of that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Titus Gordion: ""The real world isn't as black and white as it seems, whi..."*)

### Węzeł `[295]`
Mówca: **Hugo Toras**
> ""Outside of less scrupulous dealings, it might also pique your interest to know that they were once tasked with serving as emergency firefighters in the event of an unruly blaze.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Titus Gordion: ""A long time ago, yes. But it was more to do with public ..."*)

### Węzeł `[296]`
Mówca: **Titus Gordion**
> ""For king and country, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[297]`
Mówca: **Titus Gordion**
> ""We do what we must to ensure the protection of the monarchy. And sometimes that requires us to extend beyond our typical duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[298]`
Mówca: **Titus Gordion**
> ""Let's just say... the public is better off not not knowing the types of operations we've handled beyond simple security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[299]`
Mówca: **Titus Gordion**
> ""The real world isn't as black and white as it seems, which is where we come in. We navigate in the gray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[300]`
Mówca: **Narrator**
> "Titus hesitated a moment, casting a curious glance at Hugo as he did."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Hugo Toras: ""Alright, I'll come out and say it.""*)

### Węzeł `[301]`
Mówca: **Hugo Toras**
> ""Alright, I'll come out and say it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Hugo Toras: ""Since the founding of the Golden Guard, long before your..."*)

### Węzeł `[302]`
Mówca: **Hugo Toras**
> ""Since their return, their dealing with such matters has been limited in scope, however, the potential to broaden their... *flexibility* is still there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player_Romus: ""I'd heard rumors of such clandestine actions, but this i..."*)
  - -> `[303]` (*Player_Romus: ""If what you're saying is true, then I am truly shocked.""*)
  - -> `[305]` (*Player_Romus: ""I find the notion of an organization working outside the..."*)
  - -> `[306]` (*Player_Romus: ""Is it wrong to see great potential in sanctioning such a..."*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If what you're saying is true, then I am truly shocked.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Hugo Toras), `[423]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Titus Gordion: ""For king and country, Your Majesty.""*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd heard rumors of such clandestine actions, but this is the first time I've received official confirmation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Hugo Toras), `[423]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Titus Gordion: ""Secrecy is of the utmost importance to us.""*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I find the notion of an organization working outside the rule of law truly worrisome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Hugo Toras), `[423]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Titus Gordion: ""We only work within the confines given to us by the king..."*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it wrong to see great potential in sanctioning such actions?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Hugo Toras), `[423]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Titus Gordion: ""As I said, I am at your command.""*)

### Węzeł `[307]`
Mówca: **Titus Gordion**
> ""As I said, I am at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[308]`
Mówca: **Titus Gordion**
> ""We only work within the confines given to us by the king. It's a matter of defining what those parameters are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[309]`
Mówca: **Titus Gordion**
> ""Secrecy is of the utmost importance to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[310]`
Mówca: **Titus Gordion**
> ""By deploying us to assist in disaster relief, the crown could demonstrate concern for the well-being of the local populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Player_Romus: ""You can rest assured that I won't be sending you out on ..."*)
  - -> `[311]` (*Player_Romus: ""If we're relying on the Golden Guard to handle fires, we..."*)
  - -> `[313]` (*Player_Romus: ""Seeing as how putting out fires falls within your existi..."*)
  - -> `[314]` (*Player_Romus: ""Well, then next time I hear of any kittens stuck in tree..."*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we're relying on the Golden Guard to handle fires, we have far bigger problems on our hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Titus Gordion: ""Hopefully it won't get to that point.""*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can rest assured that I won't be sending you out on any firefighting excursions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Titus Gordion: ""Much appreciated.""*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seeing as how putting out fires falls within your existing duties, extinguishing *literal* fires doesn't sound too far-fetched.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Titus Gordion: ""Fair point.""*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, then next time I hear of any kittens stuck in trees, I'll let you know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Titus Gordion: ""I'm actually allergic to cats, but I won't let that get ..."*)

### Węzeł `[316]`
Mówca: **Titus Gordion**
> ""Much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)

### Węzeł `[317]`
Mówca: **Titus Gordion**
> ""I'm actually allergic to cats, but I won't let that get in my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)

### Węzeł `[318]`
Mówca: **Titus Gordion**
> ""Fair point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)

### Węzeł `[319]`
Mówca: **Titus Gordion**
> ""Hopefully it won't get to that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoldenTitusHistoryHub]"*)

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""I think that was a very productive meeting, if I do say so myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Player_Romus: ""I didn't ask for your opinion.""*)
  - -> `[324]` (*Player_Romus: ""Agreed. Your counsel was greatly appreciated.""*)
  - -> `[326]` (*Player_Romus: ""As do I. Strengthening ties has its benefits, as you rig..."*)
  - -> `[327]` (*Player_Romus: ""I hope you're right.""*)

### Węzeł `[322]`
Mówca: **Narrator**
> "Before long, Hugo and I left the armory and were making our way back through the palace courtyard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Hugo Toras: ""I think that was a very productive meeting, if I do say ..."*)

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""Thanks again for your hospitality, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed. Your counsel was greatly appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Hugo Toras: ""It is my honor, Your Majesty.""*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't ask for your opinion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Hugo Toras: ""Yes, but as your Grand Vizier, I'm obligated to give adv..."*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As do I. Strengthening ties has its benefits, as you rightly pointed out. Let's hope for continued amicability.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Hugo Toras: ""I have no doubt that it will.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you're right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Hugo Toras: ""I know I'm right.""*)

### Węzeł `[328]`
Mówca: **Hugo Toras**
> ""Yes, but as your Grand Vizier, I'm obligated to give advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: ""You're right. Please excuse my curtness. I welcome any a..."*)
  - -> `[335]` (*Player_Romus: ""Fine. But the next time you feel compelled to give unsol..."*)
  - -> `[334]` (*Player_Romus: ""Watch your words. Your obligations mean little in the fa..."*)

### Węzeł `[329]`
Mówca: **Hugo Toras**
> ""I know I'm right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player_Romus: ""So sure of yourself, are you?""*)
  - -> `[349]` (*Player_Romus: ""Self-assuredness is a quality I value.""*)
  - -> `[350]` (*Player_Romus: ""Some would call that arrogance.""*)

### Węzeł `[330]`
Mówca: **Hugo Toras**
> ""I have no doubt that it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Hugo Toras: ""Such collaboration will not only elevate but bring us cl..."*)

### Węzeł `[331]`
Mówca: **Hugo Toras**
> ""It is my honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Hugo Toras: ""I look forward to providing you with further guidance.""*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Before long, Hugo and I left the armory and were making o..."*)

### Węzeł `[333]`
Mówca: **Hugo Toras**
> ""I look forward to providing you with further guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo += 1;"*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your words. Your obligations mean little in the face of my authority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "Hugo gave a slight nod."*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. But the next time you feel compelled to give unsolicited advice, you may find yourself on the receiving end of unsolicited... *feedback*, if you will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Hugo Toras: ""As always, your perspective is highly valued.""*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Please excuse my curtness. I welcome any advice you have to give.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)

### Węzeł `[337]`
Mówca: **Narrator**
> "Hugo and I said our goodbyes and parted ways."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus >= 2"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus >= 2"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Titus >= 2)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "Titus was a good ally to have. Much could be gained by so..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Titus >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "I still wasn't fully sold on whether or not Titus could b..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "Titus was a good ally to have. Much could be gained by solidifying a strong relationship, and I looked forward to what his resources and skill sets would bring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Narrator: "Equally significant was my satisfaction in recognizing th..."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "I still wasn't fully sold on whether or not Titus could be trusted. But I was satisfied knowing that my influence over him remained strong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "For now."*)

### Węzeł `[344]`
Mówca: **Narrator**
> "For now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_RH_SupportGoldenGuard = true;..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[346]`
Mówca: **Hugo Toras**
> ""Such collaboration will not only elevate but bring us closer to our goals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo += 1;"*)

### Węzeł `[347]`
Mówca: **Hugo Toras**
> ""I prefer... realistically optimistic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So sure of yourself, are you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Hugo Toras: ""I prefer... realistically optimistic.""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Self-assuredness is a quality I value.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Hugo Toras: ""In my experience, a little confidence can go a long way.""*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Some would call that arrogance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Hugo Toras: ""Not arrogant. Self-confident.""*)

### Węzeł `[351]`
Mówca: **Hugo Toras**
> ""As always, your perspective is highly valued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1;"*)

### Węzeł `[352]`
Mówca: **Hugo Toras**
> ""His Majesty's words are final.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1;"*)

### Węzeł `[353]`
Mówca: **Narrator**
> "Hugo gave a slight nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Hugo Toras: ""His Majesty's words are final.""*)

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""In my experience, a little confidence can go a long way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1;"*)

### Węzeł `[355]`
Mówca: **Hugo Toras**
> ""Not arrogant. Self-confident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)

### Węzeł `[356]`
Mówca: **Narrator**
> "Titus gave a heartfelt bow and left my company."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing ==..."*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing ..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "Navigating through the armory once more, I eventually fou..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "I retraced my steps through the armory, and before long, ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Hugo seemed to force a smile before bowing his head and t..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GoldenTitusHistoryHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "GoldenTitusHistoryHub"*)

### Węzeł `[362]`
Mówca: **Narrator**
> "Navigating through the armory once more, I eventually found my uncle in the vicinity of Titus' boxing match."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[363]`
Mówca: **Narrator**
> "I retraced my steps through the armory, and before long, I found myself back outside crossing the courtyard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus >= 2"*)

### Węzeł `[364]`
Mówca: **Hugo Toras**
> ""There you are! I trust your discussion with Titus was productive?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus >= 2"*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your concern.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Titus"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[364]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Hugo Toras: ""Yes, Your Majesty.""*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, very. Though I'd rather not go into detail.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Titus"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[364]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Hugo Toras: ""Your discretion is duly noted.""*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As productive as one can be when talking to a dumb grunt.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Titus"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[364]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Hugo Toras: ""I can assure you that he's anything but dumb. He's one o..."*)

### Węzeł `[368]`
Mówca: **Hugo Toras**
> ""I can assure you that he's anything but dumb. He's one of the most capable people I've ever met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Hugo Toras: ""I do hope you'll one day hold him in as high regard as I..."*)

### Węzeł `[369]`
Mówca: **Hugo Toras**
> ""Your discretion is duly noted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Hugo Toras: ""That said, for me to offer you the most effective counse..."*)

### Węzeł `[370]`
Mówca: **Hugo Toras**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Hugo Toras: ""However, moving forward, I recommend ensuring that I am ..."*)

### Węzeł `[371]`
Mówca: **Hugo Toras**
> ""That said, for me to offer you the most effective counsel, I suggest providing me with such details in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hugo_Part_Ways]"*)

### Węzeł `[372]`
Mówca: **Hugo Toras**
> ""However, moving forward, I recommend ensuring that I am kept well-informed -- seeing as how I'm your advisor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hugo_Part_Ways]"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hugo_Part_Ways]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "Hugo_Part_Ways"*)

### Węzeł `[374]`
Mówca: **Hugo Toras**
> ""I do hope you'll one day hold him in as high regard as I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hugo_Part_Ways]"*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was, actually. I seem to have misjudged the captain.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Titus"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[364]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Hugo Toras: ""I'm pleased to hear it.""*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus >= 2"*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Titus >= 2)"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Player_Romus: ""It was, actually. I seem to have misjudged the captain.""*)
  - -> `[367]` (*Player_Romus: ""As productive as one can be when talking to a dumb grunt.""*)
  - -> `[366]` (*Player_Romus: ""Yes, very. Though I'd rather not go into detail.""*)
  - -> `[365]` (*Player_Romus: ""That's none of your concern.""*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Titus >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Player_Romus: ""It was, actually. I seem to have misjudged the captain.""*)
  - -> `[366]` (*Player_Romus: ""Yes, very. Though I'd rather not go into detail.""*)
  - -> `[365]` (*Player_Romus: ""That's none of your concern.""*)

### Węzeł `[379]`
Mówca: **Hugo Toras**
> ""I'm pleased to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Hugo Toras: ""I won't overstep my bounds by asking the nature of your ..."*)

### Węzeł `[380]`
Mówca: **Hugo Toras**
> ""I won't overstep my bounds by asking the nature of your chat. However, to provide you with optimal guidance, I propose sharing such information with me going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hugo_Part_Ways]"*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your comprehensive explanation is appreciated.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true`
- **Kontekst wejściowy (poprzednik):** `[250]` (Titus Gordion), `[251]` (Titus Gordion), `[252]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Titus Gordion: ""I'm glad I could provide you with further insight.""*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for sharing, Titus.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true`
- **Kontekst wejściowy (poprzednik):** `[250]` (Titus Gordion), `[251]` (Titus Gordion), `[252]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Titus Gordion: ""It's my pleasure.""*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your thorough explanation, Titus, but try to bring it to a natural conclusion a little sooner next time.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true`
- **Kontekst wejściowy (poprzednik):** `[250]` (Titus Gordion), `[251]` (Titus Gordion), `[252]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Titus Gordion: ""I'll make sure of it.""*)

### Węzeł `[384]`
Mówca: **Titus Gordion**
> ""It's my pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Titus Gordion: ""Is there anything else you'd like to know?""*)

### Węzeł `[385]`
Mówca: **Titus Gordion**
> ""I'm glad I could provide you with further insight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Titus Gordion: ""Is there anything else you'd like to know?""*)

### Węzeł `[386]`
Mówca: **Titus Gordion**
> ""I'll make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Titus Gordion: ""Is there anything else you'd like to know?""*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That will be all, thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Titus Gordion), `[540]` (Titus Gordion), `[573]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Titus Gordion: ""If there's anything else I can do for you, don't hesitat..."*)

### Węzeł `[388]`
Mówca: **Narrator**
> "I left my uncle and caught up to Captain Gordion as he stepped inside the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "Upon entering, I was once again enveloped by an array of ..."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "Upon entering, I was once again enveloped by an array of antiquated weaponry and armor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Titus motioned toward the displays."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Hugo Toras: ""I'm pleased you take such an interest in preserving Rizi..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""I like what you've done with the place.""*)
  - -> `[147]` (*Player_Romus: ""I've often found that focusing too much on memorializing..."*)
  - -> `[145]` (*Player_Romus: ""Quite the arsenal you've got here, Captain.""*)
  - -> `[148]` (*Player_Romus: ""Bows and arrows? Duchess Azaro wasn't kidding when she s..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Hugo Toras: ""If I may be so bold, Your Majesty, there are valuable le..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "We continued onward until we reached Captain Gordion's of..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Hugo Toras: ""Yes. However, if I may be so bold, Your Majesty, there a..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "We continued onward until we reached Captain Gordion's of..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "Uncle Hugo sat on a sofa that looked to have been plucked..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus_Italic: "Sit."*)
  - -> `[222]` (*Player_Romus_Italic: "Remain standing."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Hugo, seeming suddenly self-aware of being the only one s..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "The captain took out a bottle of wine from a cabinet."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player_Romus: ""The fact that you would consider drinking on the job rai..."*)
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Hugo Toras: ""I believe His Majesty was joking. But perhaps we should ..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Captain Gordion put the bottle away."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Hugo Toras: ""And mine as well.""*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Captain Gordion put the bottle away."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Hugo Toras: ""How did you get by?""*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Titus Gordion: ""So, I put on a pair of gloves and entered the world of c..."*)

### Węzeł `[417]`
Mówca: **Titus Gordion**
> ""So, I put on a pair of gloves and entered the world of championship boxing to provide for my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player_Romus: ""Were you any good?""*)
  - -> `[281]` (*Player_Romus: ""Well, that explains your fisticuffs from earlier! You fa..."*)
  - -> `[689]` (*Player_Romus: ""So you're good at hand-to-hand combat. But my enemies wi..."*)
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "Titus hesitated a moment, casting a curious glance at Hug..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "Titus hesitated a moment before continuing."*)

### Węzeł `[421]`
Mówca: **Narrator**
> "Titus hesitated a moment before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Titus Gordion: ""The Golden Guard has had a long rich history.""*)

### Węzeł `[422]`
Mówca: **Titus Gordion**
> ""The Golden Guard has had a long rich history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Titus Gordion: ""Since our founding, we've engaged in espionage, apprehen..."*)

### Węzeł `[423]`
Mówca: **Titus Gordion**
> ""Nevertheless the chance to fully restore our actions remains open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player_Romus: ""I'd heard rumors of such clandestine actions, but this i..."*)
  - -> `[303]` (*Player_Romus: ""If what you're saying is true, then I am truly shocked.""*)
  - -> `[305]` (*Player_Romus: ""I find the notion of an organization working outside the..."*)
  - -> `[306]` (*Player_Romus: ""Is it wrong to see great potential in sanctioning such a..."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Hugo Toras: ""Outside of less scrupulous dealings, it might also pique..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)

### Węzeł `[427]`
Mówca: **Titus Gordion**
> ""If there's anything else I can do for you, don't hesitate to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Hugo Toras: ""Thanks again for your hospitality, Captain.""*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Player_Romus: ""Til next time.""*)
  - -> `[433]` (*Player_Romus: ""Thanks again for your hospitality.""*)
  - -> `[432]` (*Player_Romus: ""Thank you. Until we meet again.""*)
  - -> `[434]` (*Player_Romus: ""Goodbye, Titus.""*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Til next time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leave_Titus_Hub]"*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. Until we meet again.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leave_Titus_Hub]"*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks again for your hospitality.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leave_Titus_Hub]"*)

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Titus.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[427]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leave_Titus_Hub]"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Leave_Titus_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "Leave_Titus_Hub"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Leave_Titus_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "Titus gave a heartfelt bow and left my company."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing ==..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)

### Węzeł `[443]`
Mówca: **Narrator**
> "I motioned to a broadsword prominently displayed in the center of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Titus Gordion: ""'Terador's Fury.' Its notoriety spans back several hundr..."*)

### Węzeł `[444]`
Mówca: **Narrator**
> "I pointed to an intricately adorned armored suit that stood out amongst the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Titus Gordion: ""That would be the armor of King Henricus Toras, the ance..."*)

### Węzeł `[445]`
Mówca: **Narrator**
> "I gestured toward a metallic, coffin-like contraption that stood upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Titus Gordion: ""That would be 'Saint Mercy,' our aptly named iron maiden..."*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Most reassuring.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Titus Gordion: ""Enhanced interrogation methods have come a long way in t..."*)

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hard to believe it was used at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Titus Gordion: ""Not often. It was more to scare people, if anything.""*)

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Too bad. A lot of fun could be had with that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Titus Gordion: ""Enhanced interrogation is serious business, Your Majesty..."*)

### Węzeł `[450]`
Mówca: **Titus Gordion**
> ""Not often. It was more to scare people, if anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Titus Gordion: ""What else can I tell you about?""*)

### Węzeł `[451]`
Mówca: **Titus Gordion**
> ""Enhanced interrogation is serious business, Your Majesty. There are much more efficient methods in existence today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Titus Gordion: ""What else can I tell you about?""*)

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm more interested in knowing if his armor would fit me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Titus Gordion), `[477]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Titus Gordion: ""Everyone back then was much shorter, so, unfortunately, ..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Obviously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Titus Gordion), `[477]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Titus Gordion: ""What else would you like to know?""*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but it's always good to refresh myself on our history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Titus Gordion), `[477]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Titus Gordion: ""What else would you like to know?""*)

### Węzeł `[455]`
Mówca: **Titus Gordion**
> ""Everyone back then was much shorter, so, unfortunately, I don't believe it would, given your frame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Hugo Toras: ""If you really want a suit of armor that fits, I'm sure w..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Titus Gordion: ""Are you seriously interested in obtaining a suit of armo..."*)

### Węzeł `[459]`
Mówca: **Hugo Toras**
> ""If you really want a suit of armor that fits, I'm sure we could arrange something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player_Romus: ""Yes, please do.""*)
  - -> `[460]` (*Player_Romus: ""That's okay. I'd look ridiculous anyway.""*)
  - -> `[462]` (*Player_Romus: ""As long as we get a second one for you. Then we'd be a m..."*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's okay. I'd look ridiculous anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Hugo Toras), `[679]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Titus Gordion: ""What else would you like to know?""*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, please do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Hugo Toras), `[679]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Artifact_Armor_TorasArmor = true"*)

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as we get a second one for you. Then we'd be a matching set.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Hugo Toras), `[679]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[463]`
Mówca: **Narrator**
> "Hugo and Titus laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Titus Gordion: ""What else would you like to know?""*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[465]`
Mówca: **Titus Gordion**
> ""My apologies. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Titus Gordion: ""If you would like, Your Majesty, I can have the sword po..."*)

### Węzeł `[466]`
Mówca: **Titus Gordion**
> ""It is indeed a sore spot in our history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Titus Gordion: ""If you would like, Your Majesty, I can have the sword po..."*)

### Węzeł `[467]`
Mówca: **Titus Gordion**
> ""To put it lightly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Titus Gordion: ""If you would like, Your Majesty, I can have the sword po..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Follow_Titus_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Captain Gordion removed his boxing gloves as he headed to..."*)

### Węzeł `[469]`
Mówca: **Narrator**
> "Equally significant was my satisfaction in recognizing that my control over him remained unwavering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_RH_SupportGoldenGuard = true;..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Hugo Toras: ""Legend has it, this sword took off the head of the Valgo..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Titus Gordion: ""This sword is said to be the very weapon that severed th..."*)

### Węzeł `[473]`
Mówca: **Titus Gordion**
> ""This sword is said to be the very weapon that severed the head of the commanding general of the Valgos army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""But it wasn't enough to prevent Pales being taken from R..."*)
  - -> `[200]` (*Player_Romus: ""A bad day for him.""*)
  - -> `[199]` (*Player_Romus: ""It's considered bad luck to mention severed heads in the..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Hugo Toras: ""I'm sure His Majesty knows the history of his own house,..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Titus Gordion: ""But I'm sure you knew that already.""*)

### Węzeł `[477]`
Mówca: **Hugo Toras**
> ""I'm sure His Majesty knows the history of his own house, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player_Romus: ""Yes, but it's always good to refresh myself on our histo..."*)
  - -> `[453]` (*Player_Romus: ""Obviously.""*)
  - -> `[452]` (*Player_Romus: ""I'm more interested in knowing if his armor would fit me.""*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Hugo Toras: ""I can think of a few people who could benefit from such...."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Titus Gordion: ""You'll be happy to know it hasn't been used in quite som..."*)

### Węzeł `[481]`
Mówca: **Hugo Toras**
> ""I can think of a few people who could benefit from such... physical therapy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Hugo Toras: ""I'm not being serious, of course.""*)

### Węzeł `[482]`
Mówca: **Hugo Toras**
> ""I'm not being serious, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Titus Gordion: ""You'll be happy to know it hasn't been used in quite som..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_RH_SupportGoldenGuard = true; RiziaDLCSupport.Reports_Turn02_Nelvisar_FieldShutsDown = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SupportGoldenGuard"] = true;
Variable["RiziaDLCSupport.Reports_Turn02_Nelvisar_FieldShutsDown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Hugo_Part_Ways`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "Hugo and I said our goodbyes and parted ways."*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been impressed by Captain Gordion's loyalty thus far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Hugo Toras), `[20]` (Hugo Toras), `[24]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Hugo Toras: ""As have I. And I have the feeling his expertise extends ..."*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope that today's visit will prove you right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[493]` (Hugo Toras), `[494]` (Hugo Toras), `[498]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "It wasn't long before we'd crossed the courtyard and reac..."*)

### Węzeł `[487]`
Mówca: **Titus Gordion**
> ""What else can I tell you about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory =..."*)

### Węzeł `[488]`
Mówca: **Titus Gordion**
> ""What else would you like to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory = true;"*)

### Węzeł `[489]`
Mówca: **Titus Gordion**
> ""If you would like, Your Majesty, I can have the sword polished for ceremonial use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Player_Romus: ""That would be great.""*)
  - -> `[658]` (*Player_Romus: ""What year are we in? Not necessary.""*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Hugo Toras: ""There you are! I trust your discussion with Titus was pr..."*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus is all that stands between me and an assassin's bullet, and I know next to nothing about him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Hugo Toras), `[20]` (Hugo Toras), `[24]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Hugo Toras: ""What I know is that there has never been a more loyal su..."*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be honest with me, Hugo. Do you believe Gordion can be trusted?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Hugo Toras), `[20]` (Hugo Toras), `[24]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Hugo Toras: ""He is, without a doubt, one of the most trustworthy indi..."*)

### Węzeł `[493]`
Mówca: **Hugo Toras**
> ""What I know is that there has never been a more loyal subject than Captain Titus Gordion. He lives and breathes honor and devotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Player_Romus: ""That's what worries me. Fanatical devotion can be danger..."*)
  - -> `[496]` (*Player_Romus: ""I'm not quite sure we're on the same page just yet. But ..."*)
  - -> `[497]` (*Player_Romus: ""Then I look forward to getting to know him better today.""*)
  - -> `[486]` (*Player_Romus: ""I hope that today's visit will prove you right.""*)

### Węzeł `[494]`
Mówca: **Hugo Toras**
> ""As have I. And I have the feeling his expertise extends far beyond personal security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Player_Romus: ""Then I look forward to getting to know him better today.""*)
  - -> `[486]` (*Player_Romus: ""I hope that today's visit will prove you right.""*)
  - -> `[499]` (*Player_Romus: ""I'm pleased to hear it.""*)

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's what worries me. Fanatical devotion can be dangerous should one find themselves on its unfavorable side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[493]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "It wasn't long before we'd crossed the courtyard and reac..."*)

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not quite sure we're on the same page just yet. But we shall see what today brings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[493]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "It wasn't long before we'd crossed the courtyard and reac..."*)

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I look forward to getting to know him better today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[493]` (Hugo Toras), `[494]` (Hugo Toras), `[498]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "It wasn't long before we'd crossed the courtyard and reac..."*)

### Węzeł `[498]`
Mówca: **Hugo Toras**
> ""He is, without a doubt, one of the most trustworthy individuals in the entire kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Player_Romus: ""Then I look forward to getting to know him better today.""*)
  - -> `[486]` (*Player_Romus: ""I hope that today's visit will prove you right.""*)
  - -> `[500]` (*Player_Romus: ""He'd better be. I won't tolerate anything less.""*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm pleased to hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "It wasn't long before we'd crossed the courtyard and reac..."*)

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He'd better be. I won't tolerate anything less.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[498]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "It wasn't long before we'd crossed the courtyard and reac..."*)

### Węzeł `[501]`
**[WYBÓR GRACZA: "Sit down."]** — Mówca: **Player_Romus_Italic**
> "I took a seat in a leather armchair close by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_Sit = true;"*)

### Węzeł `[502]`
**[WYBÓR GRACZA: "Keep standing."]** — Mówca: **Player_Romus_Italic**
> "I chose to stand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_Sit = false;"*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I don't have all day. Let's find a place to discuss the purpose of my visit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Titus Gordion: ""Very good, sir.""*)
  - -> `[506]` (*Titus Gordion: ""Whatever you'd like, Your Majesty.""*)
  - -> `[508]` (*Titus Gordion: ""Sure thing.""*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, that's enough small talk. Let's shift this conversation to a private setting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Titus Gordion: ""Very good, sir.""*)
  - -> `[506]` (*Titus Gordion: ""Whatever you'd like, Your Majesty.""*)
  - -> `[508]` (*Titus Gordion: ""Sure thing.""*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless, we should go. We've got plenty to talk about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Titus Gordion: ""Very good, sir.""*)
  - -> `[506]` (*Titus Gordion: ""Whatever you'd like, Your Majesty.""*)
  - -> `[508]` (*Titus Gordion: ""Sure thing.""*)

### Węzeł `[506]`
Mówca: **Titus Gordion**
> ""Whatever you'd like, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Titus Gordion: ""If you'll come with me, I can take you somewhere more se..."*)

### Węzeł `[507]`
Mówca: **Titus Gordion**
> ""Very good, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Titus Gordion: ""If you'll come with me, I can take you somewhere more se..."*)

### Węzeł `[508]`
Mówca: **Titus Gordion**
> ""Sure thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Titus Gordion: ""If you'll come with me, I can take you somewhere more se..."*)

### Węzeł `[509]`
Mówca: **Titus Gordion**
> ""If you'll come with me, I can take you somewhere more secluded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "Jump to: [Follow_Titus_Hub]"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Follow_Titus_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "Follow_Titus_Hub"*)

### Węzeł `[511]`
Mówca: **Hugo Toras**
> ""They also carried out arrests and even liquidation of individuals who posed a threat to the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Hugo Toras: ""Since their return, their dealing with such matters has ..."*)

### Węzeł `[512]`
Mówca: **Hugo Toras**
> ""Since the founding of the Golden Guard, long before your father reinstated them, they were known to engage in espionage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Hugo Toras: ""They also carried out arrests and even liquidation of in..."*)

### Węzeł `[513]`
Mówca: **Titus Gordion**
> ""Since our founding, we've engaged in espionage, apprehensions, and eliminating threats to the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Titus Gordion: ""But in the wake of our revival, we have yet to involve o..."*)

### Węzeł `[514]`
Mówca: **Titus Gordion**
> ""But in the wake of our revival, we have yet to involve ourselves in such affairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Titus Gordion: ""Nevertheless the chance to fully restore our actions rem..."*)

### Węzeł `[515]`
Mówca: **Hugo Toras**
> ""Still feeling confident about your choice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Player_Romus: ""My certainty hasn't waned.""*)
  - -> `[518]` (*Player_Romus: ""I should ask you the same question.""*)
  - -> `[517]` (*Player_Romus: ""I must admit, I fear I've placed my bets on the wrong man.""*)

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My certainty hasn't waned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Hugo Toras: ""Then I guess we'll see where that certainty takes us.""*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must admit, I fear I've placed my bets on the wrong man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Hugo Toras: ""Humility is a sign of strength and moral character. You ..."*)

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should ask you the same question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Hugo Toras: ""Some might say you're deflecting. But in any case, yes. ..."*)

### Węzeł `[519]`
Mówca: **Hugo Toras**
> ""Humility is a sign of strength and moral character. You shouldn't be afraid to display it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "Hugo made himself laugh."*)

### Węzeł `[520]`
Mówca: **Hugo Toras**
> ""Then I guess we'll see where that certainty takes us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "We continued watching the fight. My guy did manage to lan..."*)

### Węzeł `[521]`
Mówca: **Hugo Toras**
> ""Some might say you're deflecting. But in any case, yes. Very confident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "We continued watching the fight. My guy did manage to lan..."*)

### Węzeł `[522]`
Mówca: **Narrator**
> "Hugo made himself laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "We continued watching the fight. My guy did manage to lan..."*)

### Węzeł `[523]`
Mówca: **Narrator**
> "We continued watching the fight. My guy did manage to land a few hits, but in the end, Captain Gordion came out on top with a powerful punch to the jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""It appears Captain Gordion has emerged victorious.""*)

### Węzeł `[524]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you say we double the bet?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Hugo Toras: ""Not when the Captain has the initiative.""*)

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are your knees starting to shake, Uncle?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Hugo Toras: ""Never. Though I can't say the same about my confidence i..."*)

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It appears my man has the upper hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Hugo Toras: ""I'm afraid you might be right.""*)

### Węzeł `[527]`
Mówca: **Hugo Toras**
> ""I'm afraid you might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "We continued watching the fight. Hugo's fighter landed a ..."*)

### Węzeł `[528]`
Mówca: **Hugo Toras**
> ""Not when the Captain has the initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "We continued watching the fight. Hugo's fighter landed a ..."*)

### Węzeł `[529]`
Mówca: **Hugo Toras**
> ""Never. Though I can't say the same about my confidence in my man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "We continued watching the fight. Hugo's fighter landed a ..."*)

### Węzeł `[530]`
Mówca: **Narrator**
> "We continued watching the fight. Hugo's fighter landed a few more hits, but Captain Gordion ultimately came out on top thanks to a swift punch to the jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""And Titus has emerged victoriously. Looks like I owe you.""*)

### Węzeł `[531]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Same. I like what you've done with the place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Titus Gordion: ""You're more than welcome to visit anytime -- not that yo..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Tur..."*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_T..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 2"*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Tur..."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The crisp morning air filled my lungs as I crossed the pa..."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Tur..."*)
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_T..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The crisp morning air filled my lungs as I crossed the pa..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The crisp morning air filled my lungs as I crossed the pa..."*)

### Węzeł `[540]`
Mówca: **Titus Gordion**
> ""Discretion is the Golden Guard way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""As Grand Vizier to the king, I would be remiss to endors..."*)

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. I can't turn down a chance to drink with my new bodyguard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[719]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Narrator: "Hugo shrugged."*)

### Węzeł `[543]`
Mówca: **Narrator**
> "Hugo shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Hugo Toras: ""If you insist, Your Majesty...""*)

### Węzeł `[544]`
Mówca: **Hugo Toras**
> ""If you insist, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Hugo Toras: ""Pour me a glass as well, then. I wouldn't want to spoil ..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Player_Romus: ""Our professional relationship requires honesty. I will t..."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player_Romus: ""Just a little bit. I've got to stay sharp for the rest o..."*)
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? I can't turn down the chance to drink with my new bodyguard.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Hugo Toras), `[228]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Titus Gordion: ""I'm honored, Your Majesty.""*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not presume to speak for me, Uncle. I shall drink if I wish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[719]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Narrator: "Hugo looked puzzled."*)

### Węzeł `[550]`
Mówca: **Narrator**
> "Hugo looked puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Hugo Toras: ""Apologies, Your Majesty. I presumed wrong.""*)

### Węzeł `[551]`
Mówca: **Hugo Toras**
> ""Apologies, Your Majesty. I presumed wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Hugo Toras: ""Pour me a glass as well, then. I wouldn't want to spoil ..."*)

### Węzeł `[552]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, thank you, Hugo. Another time, perhaps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[719]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Titus Gordion: ""My apologies to you both.""*)

### Węzeł `[553]`
Mówca: **Titus Gordion**
> ""We in the Golden Guard are trained to keep our resources sharp in any situation. Intoxicated or otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Titus Gordion: ""But you're right to have your doubts. Forgive me, Your M..."*)

### Węzeł `[554]`
Mówca: **Titus Gordion**
> ""But you're right to have your doubts. Forgive me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Captain Gordion put the bottle away."*)

### Węzeł `[555]`
Mówca: **Titus Gordion**
> ""My apologies to you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Captain Gordion put the bottle away."*)

### Węzeł `[556]`
Mówca: **Titus Gordion**
> ""I'm honored, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Captain Gordion uncorked the bottle and poured us each a ..."*)

### Węzeł `[557]`
Mówca: **Titus Gordion**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Captain Gordion uncorked the bottle and poured us each a ..."*)

### Węzeł `[558]`
Mówca: **Titus Gordion**
> ""This one's strong indeed. But it's mellowed out over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Captain Gordion uncorked the bottle and poured us each a ..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Titus Gordion: ""It's been quite some time since I was among the common p..."*)

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have eyes on me at all times? Even during... intimate moments?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == false`
- **Kontekst wejściowy (poprzednik):** `[570]` (Titus Gordion), `[540]` (Titus Gordion), `[573]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched = true"*)

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it possible, hypothetically speaking, for the Golden Guard to support the Crown in a murder investigation?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == false  and  Variable["RiziaDLC.Security_ValeroPoisoningTalk_Happened"] == true`
- **Kontekst wejściowy (poprzednik):** `[570]` (Titus Gordion), `[540]` (Titus Gordion), `[573]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation = true"*)

### Węzeł `[562]`
Mówca: **Titus Gordion**
> ""If we were granted the resources, such an investigation would not be out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Titus Gordion: ""Would you care to elaborate?""*)

### Węzeł `[563]`
Mówca: **Titus Gordion**
> ""Would you care to elaborate?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Player_Romus: ""Such an investigation might require conducting surveilla..."*)
  - -> `[571]` (*Player_Romus: ""There isn't a murder. I'm speaking purely in a speculati..."*)
  - -> `[572]` (*Player_Romus: ""I will, should the need arise. I'm still determining if ..."*)

### Węzeł `[564]`
Mówca: **Narrator**
> "Hugo straightened up, suddenly more alert. Titus appeared unfazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Titus Gordion: ""If we were granted the resources, such an investigation ..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Narrator: "Hugo straightened up, suddenly more alert. Titus appeared..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Narrator: "Titus didn't blink."*)

### Węzeł `[568]`
Mówca: **Narrator**
> "Titus didn't blink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Titus Gordion: ""If we were granted the resources, such an investigation ..."*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you deem to be the biggest threat to my personal safety right now?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] == false`
- **Kontekst wejściowy (poprzednik):** `[570]` (Titus Gordion), `[540]` (Titus Gordion), `[573]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_Threats = true"*)

### Węzeł `[570]`
Mówca: **Titus Gordion**
> ""Is there anything else you'd like to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "GG Questions 2"*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There isn't a murder. I'm speaking purely in a speculative context.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Titus Gordion: ""Very well. Either way, I'm at your service.""*)

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will, should the need arise. I'm still determining if there's sufficient justification for such an inquiry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Titus Gordion: ""Understandable. In any event, I'm here to assist you.""*)

### Węzeł `[573]`
Mówca: **Titus Gordion**
> ""Understandable. In any event, I'm here to assist you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[574]`
Mówca: **Titus Gordion**
> ""Very well. Either way, I'm at your service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such an investigation might require conducting surveillance within Palace walls.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Titus Gordion: ""Understood. The Guard would definitely be the best optio..."*)

### Węzeł `[576]`
Mówca: **Titus Gordion**
> ""Understood. The Guard would definitely be the best option for such a sensitive undertaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GG Questions 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == fal..."*)
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false"*)
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false"*)
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_Threats == false"*)
  - -> `[387]` (*Player_Romus: ""That will be all, thank you.""*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GG Questions 2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "GG Questions 2"*)

### Węzeł `[579]`
Mówca: **Titus Gordion**
> ""It is our utmost aim to protect the Royal Family's security while respecting your privacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Titus Gordion: ""You can expect that we'll be watching you and your famil..."*)

### Węzeł `[580]`
Mówca: **Titus Gordion**
> ""You can expect that we'll be watching you and your family members in public, and standing guard outside any room you enter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Titus Gordion: ""But what you do in that room is no business of ours.""*)

### Węzeł `[581]`
Mówca: **Titus Gordion**
> ""But what you do in that room is no business of ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Player_Romus: ""You'd better not be listening in, either.""*)
  - -> `[602]` (*Player_Romus: ""Surely you must leave your post at some point.""*)
  - -> `[603]` (*Player_Romus: ""Good. That's the correct answer.""*)
  - -> `[604]` (*Player_Romus: ""And if I *want* you to watch me?""*)

### Węzeł `[582]`
Mówca: **Narrator**
> "Titus looked around, then turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Titus Gordion: ""Your government security forces seem to have a handle on..."*)

### Węzeł `[583]`
Mówca: **Titus Gordion**
> ""Your government security forces seem to have a handle on the populace. But who has a handle on them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Titus Gordion: ""I don't want to overstep my bounds so early into my empl..."*)

### Węzeł `[584]`
Mówca: **Titus Gordion**
> ""I don't want to overstep my bounds so early into my employ. But I do believe the Azaros could pose a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Hugo Toras: ""Please don't worry His Majesty with such speculations, C..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Player_Romus: ""Nonsense. The Azaros have been close allies since the Wa..."*)
  - -> `[593]` (*Player_Romus: ""I share your suspicions. If you uncover even the slighte..."*)
  - -> `[594]` (*Player_Romus: ""You're not worried about the Sazons?""*)
  - -> `[595]` (*Player_Romus: ""What about my own family? Will you protect me if Hugo tr..."*)

### Węzeł `[588]`
Mówca: **Hugo Toras**
> ""Please don't worry His Majesty with such speculations, Captain Gordion. House Azaro and House Toras have been close allies since the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Player_Romus: ""Indeed. If there's any house we should be worried about,..."*)
  - -> `[590]` (*Player_Romus: ""I appreciate you voicing your concerns, Titus, even if I..."*)
  - -> `[591]` (*Player_Romus: ""Don't hastily dismiss the captain's suspicions, Hugo. I ..."*)

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. If there's any house we should be worried about, it's the Sazons.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Titus Gordion: ""I doubt they would try another attempt at your life. Not..."*)

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate you voicing your concerns, Titus, even if I do not share them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Titus Gordion: ""Happy to have your ear, Your Majesty.""*)

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't hastily dismiss the captain's suspicions, Hugo. I wouldn't be surprised if the Azaros had designs on the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Titus Gordion: ""I will try to keep a close eye on them with the limited ..."*)

### Węzeł `[592]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. The Azaros have been close allies since the War of Rizian Succession.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[584]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Titus Gordion: ""I stand corrected, then. You know better than I do.""*)

### Węzeł `[593]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I share your suspicions. If you uncover even the slightest evidence that the family is plotting against me, I want to know.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[584]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Titus Gordion: ""I will try to keep a close eye on them with the limited ..."*)

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not worried about the Sazons?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[584]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Titus Gordion: ""I doubt they would try another attempt at your life. Not..."*)

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about my own family? Will you protect me if Hugo tries to usurp me?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[584]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Titus Gordion: ""Usurp, Your Majesty?""*)

### Węzeł `[596]`
Mówca: **Titus Gordion**
> ""I stand corrected, then. You know better than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[597]`
Mówca: **Titus Gordion**
> ""I will try to keep a close eye on them with the limited resources the Golden Guard has been given.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[598]`
Mówca: **Titus Gordion**
> ""I doubt they would try another attempt at your life. Not after how badly your kidnapping ended for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[599]`
Mówca: **Titus Gordion**
> ""Usurp, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Titus Gordion: ""Never in my life would I expect such an upstanding membe..."*)

### Węzeł `[600]`
Mówca: **Titus Gordion**
> ""Happy to have your ear, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd better not be listening in, either.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Titus Gordion: ""Certainly not, Your Majesty. Any other questions?""*)

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surely you must leave your post at some point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Titus Gordion: ""We keep a tight rotation. Asleep or awake, you will alwa..."*)

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That's the correct answer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Titus Gordion: ""Discretion is the Golden Guard way.""*)

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I *want* you to watch me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Titus Gordion: ""I, uh... do you have any other questions, Your Majesty?""*)

### Węzeł `[605]`
Mówca: **Titus Gordion**
> ""Certainly not, Your Majesty. Any other questions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[606]`
Mówca: **Titus Gordion**
> ""We keep a tight rotation. Asleep or awake, you will always be protected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[607]`
Mówca: **Titus Gordion**
> ""I, uh... do you have any other questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == false && RiziaDLC.Security_ValeroPoisoningTalk_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == fal..."*)
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == f..."*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == false && RiziaDLC.Security_ValeroPoisoningTalk_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == false  and  Variable["RiziaDLC.Security_ValeroPoisoningTalk_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Player_Romus: ""Is it possible, hypothetically speaking, for the Golden ..."*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == false && RiziaDLC.Security_ValeroPoisoningTalk_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == false  and  Variable["RiziaDLC.Security_ValeroPoisoningTalk_Happened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false"*)
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false)"*)

### Węzeł `[612]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Player_Romus: ""Do you have eyes on me at all times? Even during... inti..."*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_Threats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_Threats == false"*)
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_GGHub2_Threats == false)"*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_Threats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Player_Romus: ""What do you deem to be the biggest threat to my personal..."*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_GGHub2_Threats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_Threats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Narrator: "Titus looked around, then turned back to me."*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Titus Gordion: ""It is our utmost aim to protect the Royal Family's secur..."*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[620]`
Mówca: **Narrator**
> "Hugo paused and scrutinized me for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Hugo Toras: ""A murder investigation, Your Majesty? Is there something..."*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true"*)
  - -> `[623]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == t..."*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Narrator: "Hugo paused and scrutinized me for a moment."*)

### Węzeł `[623]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true"*)

### Węzeł `[624]`
Mówca: **Hugo Toras**
> ""A murder investigation, Your Majesty? Is there something you'd like to tell me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Player_Romus: ""As I said, I was asking hypothetically.""*)
  - -> `[638]` (*Player_Romus: ""I suspect Father may have died of something other than n..."*)
  - -> `[639]` (*Player_Romus: ""Yes. I'm on the hunt for whoever killed your sense of hu..."*)

### Węzeł `[625]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true"*)
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true)"*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Narrator: "Hugo paused and scrutinized me for a second."*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "Hugo_Part_Ways"*)

### Węzeł `[628]`
Mówca: **Narrator**
> "Hugo paused and scrutinized me for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Hugo Toras: ""'Intimate moments'? I wasn't aware you were seeing someo..."*)

### Węzeł `[629]`
Mówca: **Hugo Toras**
> ""'Intimate moments'? I wasn't aware you were seeing someone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Player_Romus: ""Not right now, but anything could happen.""*)
  - -> `[631]` (*Player_Romus: ""Nobody you need to know about, Your Grace.""*)
  - -> `[632]` (*Player_Romus: ""Even a king's got to polish the crown jewels every once ..."*)

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not right now, but anything could happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[629]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Hugo Toras: ""I see. Do be mindful that any union that could result in..."*)

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody you need to know about, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[629]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Hugo Toras: ""Any union that could result in children is of great rele..."*)

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even a king's got to polish the crown jewels every once in a while, you know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[629]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Narrator: "Hugo reddened."*)

### Węzeł `[633]`
Mówca: **Hugo Toras**
> ""Any union that could result in children is of great relevance to our house, Your Majesty. I hope you exercise caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "Hugo_Part_Ways"*)

### Węzeł `[634]`
Mówca: **Hugo Toras**
> ""I see. Do be mindful that any union that could result in children is of great importance to our house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "Hugo_Part_Ways"*)

### Węzeł `[635]`
Mówca: **Narrator**
> "Hugo reddened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Hugo Toras: ""Understood.""*)

### Węzeł `[636]`
Mówca: **Hugo Toras**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "Hugo_Part_Ways"*)

### Węzeł `[637]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As I said, I was asking hypothetically.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[624]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Hugo Toras: ""Very well. I was only wondering.""*)

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect Father may have died of something other than natural causes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[624]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "He drew back in mild surprise."*)

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I'm on the hunt for whoever killed your sense of humor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[624]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[640]`
Mówca: **Hugo Toras**
> ""Ha.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "Hugo_Part_Ways"*)

### Węzeł `[641]`
Mówca: **Narrator**
> "He drew back in mild surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Hugo Toras: ""My brother was very ill. He barely recognized me during ..."*)

### Węzeł `[642]`
Mówca: **Hugo Toras**
> ""My brother was very ill. He barely recognized me during his last hours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Hugo Toras: ""You're free to deploy the Golden Guard however you want,..."*)

### Węzeł `[643]`
Mówca: **Hugo Toras**
> ""You're free to deploy the Golden Guard however you want, of course. But there are better uses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "Hugo_Part_Ways"*)

### Węzeł `[644]`
Mówca: **Hugo Toras**
> ""Very well. I was only wondering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "Hugo_Part_Ways"*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[646]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "That drew a laugh from my uncle, while the captain simply..."*)

### Węzeł `[647]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Narrator: "The captain smiled patiently."*)

### Węzeł `[648]`
Mówca: **Narrator**
> "The captain smiled patiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Titus Gordion: ""Well, we still have several trebuchets on standby in cas..."*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Hugo Toras: ""Ha! As long as we get the green light from animal rights..."*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Titus Gordion: ""But in all seriousness...""*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Both seemed unsure how to react."*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Hugo and I caught up to Titus as he stepped inside the bu..."*)

### Węzeł `[654]`
Mówca: **Titus Gordion**
> ""Never in my life would I expect such an upstanding member of House Toras to turn on his own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[655]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Artifact_Armor_TorasArmor = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Artifact_Armor_TorasArmor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Titus Gordion: ""What else would you like to know?""*)

### Węzeł `[656]`
Mówca: **Titus Gordion**
> ""Is there anything else you're curious about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory = true;"*)

### Węzeł `[657]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Artifact_Sword_TeradorsFury = true;"*)

### Węzeł `[658]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What year are we in? Not necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Titus Gordion: ""Is there anything else you're curious about?""*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Artifact_Sword_TeradorsFury = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Artifact_Sword_TeradorsFury"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Titus Gordion: ""Is there anything else you're curious about?""*)

### Węzeł `[660]`
Mówca: **Narrator**
> "As the two men circled each other, we observed their careful dance before they engaged in combat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Although the other fighter managed to land a few hits, th..."*)

### Węzeł `[661]`
Mówca: **Titus Gordion**
> ""Upon the foundation of the Kingdom of Rizia, they assumed control over the entire province of Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[662]`
Mówca: **Titus Gordion**
> ""Lined with spikes on the inside, it was designed to inflict excruciating pain when closed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)

### Węzeł `[663]`
Mówca: **Titus Gordion**
> ""On the other hand, his son Ricardus and his nationalist associates could prove troublesome. But they're in Brenas, far out of my jurisdiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[664]`
Mówca: **Titus Gordion**
> ""A long time ago, yes. But it was more to do with public relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Titus Gordion: ""By deploying us to assist in disaster relief, the crown ..."*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxin..."*)
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBox..."*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Player_Romus: ""Ah, yes. You mentioned something about your boxing days...."*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""Well, that explains your fisticuffs from earlier! You fa..."*)

### Węzeł `[668]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, yes. You mentioned something about your boxing days. You fared well, I assume?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] == true`
- **Kontekst wejściowy (poprzednik):** `[277]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Titus Gordion: ""Good enough to catch the eye of military recruiters. I d..."*)

### Węzeł `[669]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll have to teach me how to fight like that sometime.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Titus Gordion), `[107]` (Titus Gordion), `[108]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Titus Gordion: ""Nothing you haven't already learned from the Rizian Arme..."*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Titus Gordion: ""If I do my job correctly, you'll never need to.""*)

### Węzeł `[673]`
Mówca: **Titus Gordion**
> ""Nothing you haven't already learned from the Rizian Armed Forces, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Titus Gordion: ""But enough tomfoolery. I know you must be very busy.""*)

### Węzeł `[674]`
Mówca: **Titus Gordion**
> ""If I do my job correctly, you'll never need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Titus Gordion: ""But enough tomfoolery. I know you must be very busy.""*)

### Węzeł `[675]`
Mówca: **Titus Gordion**
> ""But enough tomfoolery. I know you must be very busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "Follow_Titus_Hub"*)

### Węzeł `[676]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hypothetically, could it still be used today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Titus Gordion: ""I don't see why not. However, much more sophisticated en..."*)

### Węzeł `[678]`
Mówca: **Titus Gordion**
> ""I don't see why not. However, much more sophisticated enhanced interrogation methods have arisen in the meantime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Titus Gordion: ""What else can I tell you about?""*)

### Węzeł `[679]`
Mówca: **Titus Gordion**
> ""Are you seriously interested in obtaining a suit of armor, Your Majesty? I'm sure we could arrange something if you were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player_Romus: ""Yes, please do.""*)
  - -> `[460]` (*Player_Romus: ""That's okay. I'd look ridiculous anyway.""*)
  - -> `[462]` (*Player_Romus: ""As long as we get a second one for you. Then we'd be a m..."*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Narrator: "Hugo and Titus laughed."*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Narrator: "Titus laughed."*)

### Węzeł `[683]`
Mówca: **Narrator**
> "Titus laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Titus Gordion: ""What else would you like to know?""*)

### Węzeł `[684]`
Mówca: **Hugo Toras**
> ""Pour me a glass as well, then. I wouldn't want to spoil the mood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Captain Gordion uncorked the bottle and poured us each a ..."*)

### Węzeł `[685]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such a crude sport. I prefer hunting. It allows you to keep a gentlemanly distance between you and your target.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[277]` (Titus Gordion), `[417]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Titus Gordion: ""I'm well trained in the art of firearms as well, Your Ma..."*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Player_Romus: ""Such a crude sport. I prefer hunting. It allows you to k..."*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're good at hand-to-hand combat. But my enemies will come at me with long-range rifles, not boxing gloves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Titus Gordion), `[417]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Titus Gordion: ""That's where my military training comes in. I was select..."*)

### Węzeł `[690]`
Mówca: **Titus Gordion**
> ""I'm well trained in the art of firearms as well, Your Majesty. I was hand-recruited to benefit from the highest-level instruction at Camp Domus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Titus Gordion: ""I worked my way up through the ranks until just a few ye..."*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Titus Gordion: ""But of course I will alert you immediately should I witn..."*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Titus Gordion: ""On the other hand, his son Ricardus and his nationalist ..."*)

### Węzeł `[694]`
Mówca: **Titus Gordion**
> ""But of course I will alert you immediately should I witness any suspicious behavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[695]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I feel like I've heard enough of the past for now.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Titus Gordion), `[251]` (Titus Gordion), `[252]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Titus Gordion: ""Very well.""*)

### Węzeł `[696]`
Mówca: **Titus Gordion**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Titus Gordion: ""Is there anything else you'd like to know?""*)

### Węzeł `[697]`
Mówca: **Hugo Toras**
> ""Indeed, you're right. However, Romus, have you noticed that the blade appears somewhat tarnished?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Titus Gordion: ""If you would like, Your Majesty, I can have the sword po..."*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true"*)
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)"*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Hugo Toras: ""Indeed, you're right. However, Romus, have you noticed t..."*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Titus Gordion: ""My apologies. It won't happen again.""*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false"*)
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false)"*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_FightInWar"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Player_Romus: ""Would the Golden Guard aid our military if a war broke o..."*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_FightInWar"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[704]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would the Golden Guard aid our military if a war broke out?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_FightInWar"] == false`
- **Kontekst wejściowy (poprzednik):** `[570]` (Titus Gordion), `[540]` (Titus Gordion), `[573]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Narrator: "Titus saluted reflexively."*)

### Węzeł `[705]`
Mówca: **Narrator**
> "Titus saluted reflexively."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Titus Gordion: ""Certainly, Your Majesty. Some suspect that the Golden Gu..."*)

### Węzeł `[706]`
Mówca: **Titus Gordion**
> ""Certainly, Your Majesty. Some suspect that the Golden Guard's secret involvement helped your ancestor Ariana Toras' army win the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Titus Gordion: ""With our current numbers, however, I fear we would not b..."*)

### Węzeł `[707]`
Mówca: **Titus Gordion**
> ""With our current numbers, however, I fear we would not be of much use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_GGHub2_FightInWar = true;"*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Hugo Toras: ""Ha.""*)

### Węzeł `[709]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our professional relationship requires honesty. I will tell you straight away that I don't drink.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true` AND `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Hugo Toras), `[228]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Titus Gordion: ""I see.""*)

### Węzeł `[710]`
Mówca: **Titus Gordion**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Narrator: "He withdrew the proffered bottle."*)

### Węzeł `[711]`
Mówca: **Narrator**
> "He withdrew the proffered bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Titus Gordion: ""Thank you for letting me know. To be honest, I hardly dr..."*)

### Węzeł `[712]`
Mówca: **Titus Gordion**
> ""Thank you for letting me know. To be honest, I hardly drink myself -- I just keep wine around for royal visits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true"*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_GGHub2_FightInWar = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_FightInWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "Jump to: [GG Questions 2]"*)

### Węzeł `[714]`
Mówca: **Hugo Toras**
> ""I didn't know you were a connoisseur, Captain. I'll have a glass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[224]` (*Player_Romus: ""Drinking on the job? You should both be ashamed of yours..."*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player_Romus: ""Thanks, but no thanks. I only drink wine from 1892.""*)
  - -> `[548]` (*Player_Romus: ""Why not? I can't turn down the chance to drink with my n..."*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Hugo Toras: ""It's early, Captain. Perhaps we should all abstain.""*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Hugo Toras: ""I didn't know you were a connoisseur, Captain. I'll have..."*)

### Węzeł `[719]`
Mówca: **Hugo Toras**
> ""It's early, Captain. Perhaps we should all abstain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Player_Romus: ""Do not presume to speak for me, Uncle. I shall drink if ..."*)
  - -> `[542]` (*Player_Romus: ""Nonsense. I can't turn down a chance to drink with my ne..."*)
  - -> `[552]` (*Player_Romus: ""Yes, thank you, Hugo. Another time, perhaps.""*)
  - -> `[225]` (*Player_Romus: ""The fact that you would consider drinking on the job rai..."*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player_Romus: ""You had me at 'fortified'. Regular wine's for weaklings.""*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalVa..."*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon = true"*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true"*)

### Węzeł `[726]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Narrator: "It was the first taste of alcohol I'd had in years. Savor..."*)

### Węzeł `[727]`
Mówca: **Narrator**
> "It was the first taste of alcohol I'd had in years. Savoring its bouquet, I wondered why I'd stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Titus Gordion: ""So to what do I owe the pleasure of your company today?""*)

### Węzeł `[728]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Meeting with the King’s Secret Service", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Meeting with the King’s Secret Service","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");"*)
