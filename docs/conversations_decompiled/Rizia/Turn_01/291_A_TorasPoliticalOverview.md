# Rizia/Turn 1/A_TorasPoliticalOverview

- **ID konwersacji:** `291`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/291_A_TorasPoliticalOverview.md`
- **Liczba węzłów dialogowych:** 437
- **Liczba wyborów gracza:** 96

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_GaveSpeech`
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Coronation_Speech_Diplomacy`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.Prologue_Focus_SecurityCouncil`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Prologue_Scar`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Economy_AncientRezenidCityRestoration`
- `RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency`
- `RiziaDLC.Hugo_LargerYourQuarry`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Panel_RoyalDecrees`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn01_PromisedToSignTransition`
- `RiziaDLC.Turn01_WineWithHugo`
- `RiziaDLCSupport.News_Turn01_G_UnitedContanaICBMTest`
- `RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs`
- `RiziaDLCSupport.Reports_Turn01_Havas_CoalDepositsSuspected`
- `RiziaDLCSupport.Reports_Turn01_Nelvisar_VergeOfDepletion`
- `RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid`

### Skoki między-konwersacyjne:
- Węzeł `[107]` -> **[292] Rizia/Turn 1/Houses Briefing Section** (../Turn_01/292_Houses_Briefing_Section.md), Węzeł `[1]`
- Węzeł `[123]` -> **[292] Rizia/Turn 1/Houses Briefing Section** (../Turn_01/292_Houses_Briefing_Section.md), Węzeł `[32]`
- Węzeł `[408]` -> **[293] Rizia/Turn 1/Intention Questions** (../Turn_01/293_Intention_Questions.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""A true king is never late. It's the others who are early.""** | `[4]` **Vina Toras**: ""Hurry up, Father! It's not very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "After collecting my thoughts, I ..." |
| `[9]` | **""You'd better stop with that when we're inside.""** | `[4]` **Vina Toras**: ""Hurry up, Father! It's not very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "After collecting my thoughts, I ..." |
| `[10]` | **""Just give me a second.""** | `[4]` **Vina Toras**: ""Hurry up, Father! It's not very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "After collecting my thoughts, I ..." |
| `[19]` | **""No need to stand on ceremony with me, Hugo. Please sit.""** | `[18]` **Hugo Toras**: ""Romus, my boy.""<br>`[47]` **Hugo Toras**: ""Welcome, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "Hugo sat down with a smile." |
| `[20]` | **"Embrace him."** | `[18]` **Hugo Toras**: ""Romus, my boy.""<br>`[47]` **Hugo Toras**: ""Welcome, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Hugo Toras**: ""You'll meet everyone else soon ..." |
| `[21]` | **""Where is everyone else?""** | `[18]` **Hugo Toras**: ""Romus, my boy.""<br>`[47]` **Hugo Toras**: ""Welcome, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Hugo Toras**: ""I thought a private chat with y..." |
| `[22]` | **""Good morning, Your Grace.""** | `[18]` **Hugo Toras**: ""Romus, my boy.""<br>`[47]` **Hugo Toras**: ""Welcome, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "Hugo recognized the formality of..." |
| `[28]` | **""Other kings don't have bullet wounds in their legs.""** | `[4]` **Vina Toras**: ""Hurry up, Father! It's not very..." | `Variable["RiziaDLC.Prologue_Limp"] == true` | *Brak zmian stanu* | `[11]` **Narrator**: "After collecting my thoughts, I ..." |
| `[32]` | **""How have you been?""** | `[145]` **Narrator**: "Vina walked over to the table as..."<br>`[148]` **Narrator**: "I made my way over to the chair...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Hugo Toras**: ""Busy. Managing the royal transi..." |
| `[33]` | **""How is your son?""** | `[145]` **Narrator**: "Vina walked over to the table as..."<br>`[148]` **Narrator**: "I made my way over to the chair...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "He smiled fondly." |
| `[34]` | **""How is your wife?""** | `[145]` **Narrator**: "Vina walked over to the table as..."<br>`[148]` **Narrator**: "I made my way over to the chair...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Hugo Toras**: ""Rita's as much of a thorn in my..." |
| `[54]` | **""Thanks, but I already know everything.""** | `[49]` **Hugo Toras**: ""As Valero never got a chance to..."<br>`[53]` **Hugo Toras**: ""As it's been quite some time si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""You always were a bright one."" |
| `[55]` | **""Please.""** | `[49]` **Hugo Toras**: ""As Valero never got a chance to..."<br>`[53]` **Hugo Toras**: ""As it's been quite some time si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""As the king, you're both Rizia'..." |
| `[61]` | **""I'm already up to speed. But I'm sure Vina would appreciate it.""** | `[49]` **Hugo Toras**: ""As Valero never got a chance to..."<br>`[53]` **Hugo Toras**: ""As it's been quite some time si..." | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[125]` **Hugo Toras**: ""Good thinking. This will apply ..." |
| `[64]` | **""What a cowardly move.""** | `[63]` **Hugo Toras**: ""However, you should not neglect..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[85]` **Hugo Toras**: ""Shrewd, in fact. It gave Rizia ..." |
| `[65]` | **""What about it?""** | `[63]` **Hugo Toras**: ""However, you should not neglect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Hugo Toras**: ""It still works the way he inten..." |
| `[66]` | **""That's right. His theater of puppets.""** | `[63]` **Hugo Toras**: ""However, you should not neglect..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[67]` **Narrator**: "Hugo pursed his lips." |
| `[79]` | **""And if they disagree with me -- so what? I'll have them fired. Or better, beheaded.""** | `[73]` **Hugo Toras**: ""Thanks to that coronation speec..."<br>`[74]` **Hugo Toras**: ""Thankfully, your coronation spe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[362]` **Narrator**: "Hugo winced." |
| `[80]` | **""Thank you for letting me know. I'll be sure to listen to them going forward.""** | `[73]` **Hugo Toras**: ""Thanks to that coronation speec..."<br>`[74]` **Hugo Toras**: ""Thankfully, your coronation spe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Hugo Toras**: ""I'm here to serve, Your Majesty."" |
| `[83]` | **""Yes, that was one of his better ideas.""** | `[63]` **Hugo Toras**: ""However, you should not neglect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Hugo Toras**: ""I thought so as well. It gave R..." |
| `[86]` | **""Do the Delegates really represent the will of the people? Or just that of the nob..."** | `[73]` **Hugo Toras**: ""Thanks to that coronation speec..."<br>`[74]` **Hugo Toras**: ""Thankfully, your coronation spe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[87]` **Narrator**: "Hugo made a tutting sound." |
| `[89]` | **""The traitor's son?""** | `[88]` **Narrator**: "Hugo scanned my face closely as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Hugo Toras**: ""Exactly."" |
| `[90]` | **""I know all about him.""** | `[88]` **Narrator**: "Hugo scanned my face closely as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Hugo Toras**: ""Then you know he could be a thr..." |
| `[91]` | **""The opposition elected a Sazon?""** | `[88]` **Narrator**: "Hugo scanned my face closely as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Hugo Toras**: ""Not just any Sazon."" |
| `[92]` | **""You have got to be joking.""** | `[88]` **Narrator**: "Hugo scanned my face closely as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Hugo Toras**: ""I wish that I were."" |
| `[99]` | **""Common man? He's descended from nobility.""** | `[124]` **Hugo Toras**: ""His promises to give a voice to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Hugo Toras**: ""Yes, that's what makes him part..." |
| `[100]` | **""Relax. I'm not that concerned.""** | `[124]` **Hugo Toras**: ""His promises to give a voice to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Hugo Toras**: ""Neither was your father in the ..." |
| `[101]` | **""I'd like to meet this fellow.""** | `[124]` **Hugo Toras**: ""His promises to give a voice to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Hugo Toras**: ""You'll get your chance."" |
| `[102]` | **""You're right to be wary of him. We've got to keep him in our sights.""** | `[124]` **Hugo Toras**: ""His promises to give a voice to..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[106]` **Hugo Toras**: ""We will."" |
| `[136]` | **""I was against the idea, for the record. But she insisted.""** | `[134]` **Vina Toras**: ""Yes, Uncle Hugo. I'm sitting in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "Hugo frowned as he processed thi..." |
| `[137]` | **""She's going to learn by experience, just like I did.""** | `[134]` **Vina Toras**: ""Yes, Uncle Hugo. I'm sitting in..." | `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true` | *Brak zmian stanu* | `[143]` **Narrator**: "Hugo frowned as he processed thi..." |
| `[141]` | **""She's going to learn by experience. I wish I had done the same.""** | `[134]` **Vina Toras**: ""Yes, Uncle Hugo. I'm sitting in..." | `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | *Brak zmian stanu* | `[143]` **Narrator**: "Hugo frowned as he processed thi..." |
| `[142]` | **""It's unorthodox, I know. But future queens should have the same privileges as fut..."** | `[134]` **Vina Toras**: ""Yes, Uncle Hugo. I'm sitting in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "Hugo frowned as he processed thi..." |
| `[165]` | **""I don't drink, Hugo.""** | `[172]` **Hugo Toras**: ""Noon already. Shall we and the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Trait_SoberKing"] = true;` | `[159]` **Narrator**: "Hugo raised his eyebrows." |
| `[166]` | **""Gladly. We still have much to catch up on.""** | `[172]` **Hugo Toras**: ""Noon already. Shall we and the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Hugo Toras**: ""I think your father kept a stor..." |
| `[168]` | **""Another time, Your Grace.""** | `[172]` **Hugo Toras**: ""Noon already. Shall we and the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hugo Toras**: ""I look forward to it."" |
| `[169]` | **""I'm your superior now, Your Grace. It wouldn't be appropriate.""** | `[172]` **Hugo Toras**: ""Noon already. Shall we and the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC....` | `[170]` **Narrator**: "Hugo scowled briefly, then force..." |
| `[178]` | **""I could never stand the taste of alcohol.""** | `[177]` **Hugo Toras**: ""Is that so? Since when?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Hugo Toras**: ""I never knew."" |
| `[179]` | **""Since I found God.""** | `[177]` **Hugo Toras**: ""Is that so? Since when?"" | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[189]` **Hugo Toras**: ""A curious way of expressing you..." |
| `[183]` | **""I overdid it as the Party Prince. I'm clean now.""** | `[177]` **Hugo Toras**: ""Is that so? Since when?"" | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | *Brak zmian stanu* | `[188]` **Hugo Toras**: ""A respectable decision. But on ..." |
| `[187]` | **""I don't remember. I just stopped at some point.""** | `[177]` **Hugo Toras**: ""Is that so? Since when?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Hugo Toras**: ""I never knew."" |
| `[196]` | **""I don't drink, Hugo.""** | `[202]` **Hugo Toras**: ""Noon already. Shall we break fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Narrator**: "Hugo raised his eyebrows." |
| `[197]` | **""Gladly. We still have much to catch up on.""** | `[202]` **Hugo Toras**: ""Noon already. Shall we break fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Hugo Toras**: ""I think your father kept a stor..." |
| `[198]` | **""Another time, Your Grace.""** | `[202]` **Hugo Toras**: ""Noon already. Shall we break fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Hugo Toras**: ""I look forward to it."" |
| `[199]` | **""I'm your superior now, Your Grace. It wouldn't be appropriate.""** | `[202]` **Hugo Toras**: ""Noon already. Shall we break fo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC....` | `[200]` **Narrator**: "Hugo scowled, then forced a smile." |
| `[205]` | **""Since I found God.""** | `[217]` **Hugo Toras**: ""Is that so? Since when?"" | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[215]` **Hugo Toras**: ""That's an extreme interpretatio..." |
| `[209]` | **""I overdid it as the Party Prince. I'm clean now.""** | `[217]` **Hugo Toras**: ""Is that so? Since when?"" | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | *Brak zmian stanu* | `[214]` **Hugo Toras**: ""A respectable decision."" |
| `[213]` | **""I don't remember. I just stopped at some point.""** | `[217]` **Hugo Toras**: ""Is that so? Since when?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Hugo Toras**: ""I never knew."" |
| `[218]` | **""I could never stand the taste of alcohol.""** | `[217]` **Hugo Toras**: ""Is that so? Since when?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Hugo Toras**: ""I never knew."" |
| `[220]` | **""Oh. Well, in that case, my sober days are over. Pour me a glass.""** | `[219]` **Hugo Toras**: ""You should find a way to keep t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Narrator**: "Hugo laughed." |
| `[221]` | **""Duly noted. I'll figure something out.""** | `[219]` **Hugo Toras**: ""You should find a way to keep t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Trait_SoberKing"] = true;` | `[204]` **Narrator**: "He stood up, then paused and tur..." |
| `[224]` | **""If tradition demands it, you might as well pour me a glass.""** | `[191]` **Hugo Toras**: ""You should remember that it's h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Narrator**: "Hugo laughed." |
| `[225]` | **""Duly noted, but this isn't a formal occasion. I respectfully decline.""** | `[191]` **Hugo Toras**: ""You should remember that it's h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Vina Toras**: ""Thank you for the offer anyway,..." |
| `[238]` | **""Yes. *Too* kind.""** | `[232]` **Vina Toras**: ""That's very kind of you, Uncle ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Hugo Toras**: ""Forgive my forwardness. I'm sim..." |
| `[239]` | **""Listen to your uncle, Vina. He knows how everything works around here.""** | `[232]` **Vina Toras**: ""That's very kind of you, Uncle ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Hugo Toras**: ""What is my role as Grand Vizier..." |
| `[240]` | **""No offers of advice for me?""** | `[232]` **Vina Toras**: ""That's very kind of you, Uncle ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Hugo Toras**: ""I said it all to you during our..."<br>`[249]` **Hugo Toras**: ""I wouldn't presume to know bett..." |
| `[251]` | **""Yes. *Too* kind.""** | `[237]` **Vina Toras**: ""That's very kind of you, Uncle ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Hugo Toras**: ""Pardon my forwardness. I'm simp..." |
| `[252]` | **""Listen to your uncle, Vina. He knows how everything works around here.""** | `[237]` **Vina Toras**: ""That's very kind of you, Uncle ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Hugo Toras**: ""What is my role as Grand Vizier..." |
| `[253]` | **""No offers of advice for me?""** | `[237]` **Vina Toras**: ""That's very kind of you, Uncle ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Hugo Toras**: ""I said it all to you during our..."<br>`[257]` **Hugo Toras**: ""I wouldn't presume to know bett..." |
| `[265]` | **""That's kind of you. *Too* kind.""** | `[263]` **Hugo Toras**: ""I hope young Vina is adjusting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Hugo Toras**: ""Forgive my forwardness. I'm sim..." |
| `[266]` | **""Thank you for the offer. I'll let her know.""** | `[263]` **Hugo Toras**: ""I hope young Vina is adjusting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Hugo Toras**: ""What is my role as Grand Vizier..." |
| `[267]` | **""No advice for me?""** | `[263]` **Hugo Toras**: ""I hope young Vina is adjusting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Hugo Toras**: ""I said it all to you during our..."<br>`[272]` **Hugo Toras**: ""I wouldn't presume to know bett..." |
| `[278]` | **""That's kind of you. *Too* kind.""** | `[264]` **Hugo Toras**: ""I hope young Vina is adjusting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Hugo Toras**: ""Forgive my forwardness. I'm sim..." |
| `[279]` | **""Thank you for the offer. I'll let her know.""** | `[264]` **Hugo Toras**: ""I hope young Vina is adjusting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Hugo Toras**: ""What is my role as Grand Vizier..." |
| `[280]` | **""No advice for me?""** | `[264]` **Hugo Toras**: ""I hope young Vina is adjusting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Hugo Toras**: ""I said it all to you during our..."<br>`[285]` **Hugo Toras**: ""I wouldn't presume to know bett..." |
| `[292]` | **""Why can't I attend? I want to be in touch with my populace.""** | `[121]` **Hugo Toras**: ""As Grand Vizier, it's tradition..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Hugo Toras**: ""The sessions can be quite long ..." |
| `[293]` | **""What do you think would be the consequences if I ignore them?""** | `[121]` **Hugo Toras**: ""As Grand Vizier, it's tradition..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Hugo Toras**: ""Officially, there are none. Uno..." |
| `[299]` | **""I don't need all this. I can fend for myself.""** | `[321]` **Hugo Toras**: ""Titus and the members of his tw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Titus Gordion**: ""Your limp says otherwise. There..."<br>`[305]` **Titus Gordion**: ""What about your young daughter?..." |
| `[300]` | **""So they're guarding Vina and Queen Mother Estela as well?""** | `[321]` **Hugo Toras**: ""Titus and the members of his tw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Titus Gordion**: ""Yes. My men have eyes on the Qu..."<br>`[306]` **Titus Gordion**: ""Yes, my men have eyes on both o..." |
| `[308]` | **""Right. The royal family's personal security force. And where are they now?""** | `[307]` **Hugo Toras**: ""One more thing. As you're aware..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Titus Gordion**: ""Here, sir. Ready and able."" |
| `[309]` | **""And?""** | `[307]` **Hugo Toras**: ""One more thing. As you're aware..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Titus Gordion**: ""We hope to serve you well, sir."" |
| `[310]` | **""Why would he do that?""** | `[307]` **Hugo Toras**: ""One more thing. As you're aware..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Titus Gordion**: ""For his and your personal prote..." |
| `[317]` | **""What the hell?""** | `[313]` **Hugo Toras**: ""Meet Titus Gordion, captain of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Titus Gordion**: ""My apologies, sir. I was waitin..." |
| `[318]` | **""Has he been in the room with us this whole time?""** | `[313]` **Hugo Toras**: ""Meet Titus Gordion, captain of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Titus Gordion**: ""A Golden Guard appears only if ..." |
| `[319]` | **""I'm pleased to meet you, Captain Gordion.""** | `[313]` **Hugo Toras**: ""Meet Titus Gordion, captain of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Titus Gordion**: ""Call me Titus, sir."" |
| `[334]` | **""What's with the costumes? Wouldn't plainclothes bodyguards be more effective?""** | `[321]` **Hugo Toras**: ""Titus and the members of his tw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Titus Gordion**: ""It sends the signal that you ar..." |
| `[336]` | **""And how do we know they can be trusted? What if someone gets to them?""** | `[321]` **Hugo Toras**: ""Titus and the members of his tw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Titus Gordion**: ""I conduct regular screenings of..." |
| `[340]` | **""You and your men had better stay in line, Captain Gordion.""** | `[338]` **Hugo Toras**: ""Your father always had a fondne..."<br>`[339]` **Hugo Toras**: ""My mother Lyza discontinued the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Titus Gordion**: ""We answer to no one but you, sir."" |
| `[341]` | **""It humbles me to be worthy of such an elite unit's protection.""** | `[338]` **Hugo Toras**: ""Your father always had a fondne..."<br>`[339]` **Hugo Toras**: ""My mother Lyza discontinued the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Titus Gordion**: ""The humility is all mine, sir."" |
| `[342]` | **""He was right to do so. The most important family in Rizia deserves the most impor..."** | `[338]` **Hugo Toras**: ""Your father always had a fondne..."<br>`[339]` **Hugo Toras**: ""My mother Lyza discontinued the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Titus Gordion**: ""I won't let you down, sir."" |
| `[343]` | **""Guards in gold... it still seems too flashy for me.""** | `[339]` **Hugo Toras**: ""My mother Lyza discontinued the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Titus Gordion**: ""We'll be sure to stay out of yo..." |
| `[353]` | **""Sounds like a waste of time. I'd rather just make all the decrees myself.""** | `[121]` **Hugo Toras**: ""As Grand Vizier, it's tradition..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Hugo Toras**: ""I'd advise you to at least take..." |
| `[355]` | **""You're wrong. It is very kingly of me to show up whenever I want.""** | `[4]` **Vina Toras**: ""Hurry up, Father! It's not very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "After collecting my thoughts, I ..." |
| `[356]` | **""Thanks for that, Your Grace. I will be counting on you.""** | `[121]` **Hugo Toras**: ""As Grand Vizier, it's tradition..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Hugo Toras**: ""Of course, Your Majesty."" |
| `[358]` | **""Great. Looking forward to working with them.""** | `[321]` **Hugo Toras**: ""Titus and the members of his tw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Titus Gordion**: ""It is an honor, Your Majesty."" |
| `[375]` | **""I would never go against the traditions of Rizia. I will sign the decree as soon ..."** | `[374]` **Hugo Toras**: ""The kingdom will be expecting y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Hugo Toras**: ""Very good. Upholding tradition ..." |
| `[376]` | **""The decrees will play a significant role in my reign. They won't be just symbolic..."** | `[374]` **Hugo Toras**: ""The kingdom will be expecting y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Hugo Toras**: ""Wield this power wisely, Romus...." |
| `[377]` | **""Thanks for your advice, uncle. It's comforting to have your wisdom and experience..."** | `[374]` **Hugo Toras**: ""The kingdom will be expecting y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[378]` **Hugo Toras**: ""Your humility is appreciated. B..." |
| `[384]` | **""I've been looking forward to this all my life. Finally, I have the power to make ..."** | `[374]` **Hugo Toras**: ""The kingdom will be expecting y..." | `Variable["RiziaDLC.Focus_Government_Absolutism"] == true` | *Brak zmian stanu* | `[388]` **Hugo Toras**: ""I still urge caution. Nobody ca..." |
| `[386]` | **""Tradition is the enemy of progress. We should not be bound by the past.""** | `[374]` **Hugo Toras**: ""The kingdom will be expecting y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Hugo Toras**: ""Disregarding tradition is a per..." |
| `[400]` | **""It troubles me that a single person can hold that much power. I am as fallible as..."** | `[374]` **Hugo Toras**: ""The kingdom will be expecting y..." | `Variable["RiziaDLC.Focus_Government_Reform"] == true`<br>`(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false` | *Brak zmian stanu* | `[401]` **Hugo Toras**: ""That's what your advisors are f..." |
| `[414]` | **""It troubles me that a single person can hold that much power. I am as fallible as..."** | `[403]` **Hugo Toras**: ""The kingdom will be expecting y..." | `Variable["RiziaDLC.Focus_Government_Reform"] == true` | *Brak zmian stanu* | `[416]` **Hugo Toras**: ""That's what your advisors are f..." |
| `[423]` | **""I would never go against the traditions of Rizia. I will sign the decree as soon ..."** | `[403]` **Hugo Toras**: ""The kingdom will be expecting y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Hugo Toras**: ""Very good. Upholding tradition ..." |
| `[426]` | **""I've been looking forward to this all my life. Finally, the power to make decisio..."** | `[403]` **Hugo Toras**: ""The kingdom will be expecting y..." | `Variable["RiziaDLC.Focus_Government_Absolutism"] == true` | *Brak zmian stanu* | `[429]` **Hugo Toras**: ""I still urge caution. Nobody ca..." |
| `[427]` | **""Tradition is the enemy of progress. We should not be bound by the past.""** | `[403]` **Hugo Toras**: ""The kingdom will be expecting y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Hugo Toras**: ""Disregarding tradition is a per..." |
| `[430]` | **""Clemency? Ha! Under me, the people of Rizia will know no clemency.""** | `[403]` **Hugo Toras**: ""The kingdom will be expecting y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Hugo Toras**: ""I urge you to reconsider, Romus..." |

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
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Sizing up their kingdom’s intricate poli..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The stairway to the Royal Council chambers was longer than I remembered. I took a moment to catch my breath in front of the carved oak doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[4]`
Mówca: **Vina Toras**
> ""Hurry up, Father! It's not very kingly of you to be late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""A true king is never late. It's the others who are early.""*)
  - -> `[9]` (*Player_Romus: ""You'd better stop with that when we're inside.""*)
  - -> `[10]` (*Player_Romus: ""Just give me a second.""*)
  - -> `[355]` (*Player_Romus: ""You're wrong. It is very kingly of me to show up wheneve..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Vina Toras: ""Hurry up, Father! It's not very kingly of you to be late.""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "After collecting my thoughts, I pushed open the door and ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A true king is never late. It's the others who are early.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "After collecting my thoughts, I pushed open the door and ..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd better stop with that when we're inside.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "After collecting my thoughts, I pushed open the door and ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just give me a second.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "After collecting my thoughts, I pushed open the door and ..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "After collecting my thoughts, I pushed open the door and walked in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Everything was just as it had been in my youth. The high domed ceiling, with its skylight that shone into the center of the room. The oval mahogany table. The tall-backed red velvet chair where my father used to sit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "To my slight surprise, the room was empty except for one ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Everything was just as it had been in my youth. The high ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "I'd only been here once or twice. I gazed up at the high ..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "I'd only been here once or twice. I gazed up at the high domed ceiling, with its skylight that shone down into the center of the room. Below it, a tall-backed red velvet chair towered over an oval mahogany table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "To my slight surprise, the room was empty except for one ..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "When Hugo saw me, he sprang to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""Romus, my boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""No need to stand on ceremony with me, Hugo. Please sit.""*)
  - -> `[22]` (*Player_Romus: ""Good morning, Your Grace.""*)
  - -> `[21]` (*Player_Romus: ""Where is everyone else?""*)
  - -> `[20]` (*Player_Romus_Italic: "Embrace him."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to stand on ceremony with me, Hugo. Please sit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras), `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Hugo sat down with a smile."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "Embrace him."]** — Mówca: **Player_Romus_Italic**
> "I embraced my uncle. He hugged me back warmly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras), `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""You'll meet everyone else soon enough. But I thought a p..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where is everyone else?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras), `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""I thought a private chat with your Grand Vizier would be..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good morning, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras), `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Hugo recognized the formality of my greeting and bowed sl..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Hugo sat down with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""You'll meet everyone else soon enough. But I thought a p..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "His eyes traveled to the doorway, where Vina was still st..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "He gestured to the red velvet chair."*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""Although it seems it won't be as private as I was expecting. Are you staying, Princess Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "My daughter gave a shy nod."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Other kings don't have bullet wounds in their legs.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "After collecting my thoughts, I pushed open the door and ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""Other kings don't have bullet wounds in their legs.""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How have you been?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Narrator), `[148]` (Narrator), `[435]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""Busy. Managing the royal transition is a full-time job i..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is your son?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Narrator), `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "He smiled fondly."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is your wife?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Narrator), `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Hugo Toras: ""Rita's as much of a thorn in my side as ever. She was be..."*)

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""Rico is still raising hell. But governing Iza has instilled a real sense of responsibility in him. You'd be surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""Busy. Managing the royal transition is a full-time job in itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Hugo Toras: ""Between that and visits to Rico in Iza, I haven't had a ..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""Rico's still the hellraiser we both know and love. But g..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""Rico is still raising hell. But governing Iza has instil..."*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""Rico's still the hellraiser we both know and love. But governing Iza has instilled a real sense of responsibility in him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""Rita's as much of a thorn in my side as ever. She was begging me to retire after Valero's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Hugo Toras: ""As though I'd trust anyone else to advise my nephew.""*)

### Węzeł `[42]`
Mówca: **Narrator**
> "As I listened to him, my eyes drifted towards the back wall. It was covered in portraits of Rizia's previous kings, including a newly painted likeness of my father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Hugo Toras: ""My dear brother. I do miss him, but I daresay it's time ..."*)

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""My dear brother. I do miss him, but I daresay it's time we had some fresh blood on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""Romus, my boy.""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Welcome, Your Majesty.""*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""Welcome, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""No need to stand on ceremony with me, Hugo. Please sit.""*)
  - -> `[22]` (*Player_Romus: ""Good morning, Your Grace.""*)
  - -> `[21]` (*Player_Romus: ""Where is everyone else?""*)
  - -> `[20]` (*Player_Romus_Italic: "Embrace him."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Hugo recognized the formality of my greeting and bowed slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""You'll meet everyone else soon enough. But I thought a p..."*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""As Valero never got a chance to fill you in on his royal duties before he passed, I prepared an overview for you. Would you like to hear it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Please.""*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[54]` (*Player_Romus: ""Thanks, but I already know everything.""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""As it's been quite some time since you last sat in these..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""As Valero never got a chance to fill you in on his royal..."*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""As it's been quite some time since you last sat in these chambers, I've prepared an overview for you. Would you like to hear it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Please.""*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[54]` (*Player_Romus: ""Thanks, but I already know everything.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I already know everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras), `[53]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""You always were a bright one.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras), `[53]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""As the king, you're both Rizia's head of state and comma..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""You always were a bright one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Hugo Toras: ""I will, however, gently remind you that it is traditiona..."*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""As the king, you're both Rizia's head of state and commander of its armed forces, as well as the de jure governor of Rizia Imperii, Valenqiris, the Pales Administrative District and the island of Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_SecurityCouncil == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""I'm already up to speed. But I'm sure Vina would appreci..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm already up to speed. But I'm sure Vina would appreciate it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras), `[53]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Hugo Toras: ""Good thinking. This will apply to her too... One day.""*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""However, you should not neglect the House of Delegates, the legislative assembly my brother set up to appease the opposition after the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""Yes, that was one of his better ideas.""*)
  - -> `[64]` (*Player_Romus: ""What a cowardly move.""*)
  - -> `[65]` (*Player_Romus: ""What about it?""*)
  - -> `[66]` (*Player_Romus: ""That's right. His theater of puppets.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a cowardly move.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Hugo Toras: ""It still works the way he intended. Rizia has the appear..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right. His theater of puppets.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Hugo pursed his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Hugo Toras: ""It was the only way for him to stay in power. Rizia coul..."*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""His Majesty Valero presided over the last elections in 1949. The Rizian National Coalition secured a House majority, as always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Hugo Toras: ""They propose decrees and issue official approvals or dis..."*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""I and the rest of the Royal Council will advise you to the best of our ability, and put forth decrees and state decisions for your approval. Ultimately, the King has the final say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""However, you should not neglect the House of Delegates, ..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true || RiziaDLC.Coronation_Speech_Diplomacy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true || RiziaD..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_AntiMonarchy == true || Rizi..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true || RiziaDLC.Coronation_Speech_Diplomacy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true  or  Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Hugo Toras: ""Thanks to that coronation speech you made, I'd say you'r..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_AntiMonarchy == true || RiziaDLC.Coronation_Speech_Diplomacy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true  or  Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""Thankfully, your coronation speech got you off on the ri..."*)

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""Thanks to that coronation speech you made, I'd say you're already off on the wrong foot with the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""Thank you for letting me know. I'll be sure to listen to..."*)
  - -> `[86]` (*Player_Romus: ""Do the Delegates really represent the will of the people..."*)
  - -> `[79]` (*Player_Romus: ""And if they disagree with me -- so what? I'll have them ..."*)

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""Thankfully, your coronation speech got you off on the right foot with the RNC. Even if the speech itself was highly unconventional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""Thank you for letting me know. I'll be sure to listen to..."*)
  - -> `[86]` (*Player_Romus: ""Do the Delegates really represent the will of the people..."*)
  - -> `[79]` (*Player_Romus: ""And if they disagree with me -- so what? I'll have them ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_GaveSpeech == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true || RiziaD..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_GaveSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Hugo Toras: ""No good can come of ignoring the will of the people.""*)

### Węzeł `[78]`
Mówca: **Hugo Toras**
> ""No good can come of ignoring the will of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""Thank you for letting me know. I'll be sure to listen to..."*)
  - -> `[86]` (*Player_Romus: ""Do the Delegates really represent the will of the people..."*)
  - -> `[79]` (*Player_Romus: ""And if they disagree with me -- so what? I'll have them ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if they disagree with me -- so what? I'll have them fired. Or better, beheaded.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Hugo Toras), `[74]` (Hugo Toras), `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1; RiziaDLC.LeaningValue..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for letting me know. I'll be sure to listen to them going forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Hugo Toras), `[74]` (Hugo Toras), `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Hugo Toras: ""I'm here to serve, Your Majesty.""*)

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""I'm here to serve, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Hugo Toras: ""Fortunately, the Delegates' speaker, Daria de Rava, is a..."*)

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""The opposition is small but worth keeping an eye on. Especially the new leader, Manus Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Hugo scanned my face closely as he spoke the name."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, that was one of his better ideas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Hugo Toras: ""I thought so as well. It gave Rizia the appearance of a ..."*)

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""I thought so as well. It gave Rizia the appearance of a constitutional democracy while keeping power firmly in the hands of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""His Majesty Valero presided over the last elections in 1..."*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Shrewd, in fact. It gave Rizia the appearance of a constitutional democracy while keeping power firmly in the hands of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""His Majesty Valero presided over the last elections in 1..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do the Delegates really represent the will of the people? Or just that of the nobility?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Hugo Toras), `[74]` (Hugo Toras), `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "Hugo made a tutting sound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Hugo Toras: ""Do not discount the importance of the nobility to this k..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Hugo scanned my face closely as he spoke the name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""The opposition elected a Sazon?""*)
  - -> `[89]` (*Player_Romus: ""The traitor's son?""*)
  - -> `[92]` (*Player_Romus: ""You have got to be joking.""*)
  - -> `[90]` (*Player_Romus: ""I know all about him.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The traitor's son?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Hugo Toras: ""Exactly.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know all about him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Hugo Toras: ""Then you know he could be a threat.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The opposition elected a Sazon?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""Not just any Sazon.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have got to be joking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Hugo Toras: ""I wish that I were.""*)

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""I wish that I were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""Not just any Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[95]`
Mówca: **Hugo Toras**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""As you know, Duke Lucas Sazon was executed for his role in your kidnapping and the 1926 uprising, while his wife Angelica was sent into exile on Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Hugo Toras: ""While she remains under strict orders not to leave the i..."*)

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""Upon finishing his studies in Kyrute, Manus returned to the mainland and proceeded to win the largest supporter base of any opposition leader we've seen thus far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""His promises to give a voice to the common man seem to b..."*)

### Węzeł `[98]`
Mówca: **Hugo Toras**
> ""Then you know he could be a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Common man? He's descended from nobility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Hugo Toras: ""Yes, that's what makes him particularly dangerous.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. I'm not that concerned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Hugo Toras: ""Neither was your father in the '20s, if you'll recall.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to meet this fellow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: ""You'll get your chance.""*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right to be wary of him. We've got to keep him in our sights.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""Yes, that's what makes him particularly dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo closed the folder."*)

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""Neither was your father in the '20s, if you'll recall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo closed the folder."*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""You'll get your chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo closed the folder."*)

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""We will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo closed the folder."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Hugo closed the folder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "He gestured towards my leg."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)

### Węzeł `[111]`
Mówca: **Narrator**
> "He gestured towards my leg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Hugo Toras: ""As you know, Duke Lucas Sazon was executed for his role ..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "He gestured towards my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Hugo Toras: ""As you know, Duke Lucas Sazon was executed for his role ..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Scar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Scar == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Scar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Scar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He gestured towards my shoulder."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Scar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Scar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Hugo Toras: ""As you know, Duke Lucas Sazon was executed for his role ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He opened a folder and took out a picture of a clean-cut ..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "He opened a folder and took out a picture of a clean-cut ..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "He opened a folder and took out a picture of a clean-cut young man. Vina leaned forward to peer at it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""Upon finishing his studies in Kyrute, Manus returned to ..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "He opened a folder and took out a picture of a clean-cut young man."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""Upon finishing his studies in Kyrute, Manus returned to ..."*)

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""As Grand Vizier, it's traditional for me to attend their sessions and pass any relevant information on to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Player_Romus: ""Thanks for that, Your Grace. I will be counting on you.""*)
  - -> `[292]` (*Player_Romus: ""Why can't I attend? I want to be in touch with my popula..."*)
  - -> `[293]` (*Player_Romus: ""What do you think would be the consequences if I ignore ..."*)
  - -> `[353]` (*Player_Romus: ""Sounds like a waste of time. I'd rather just make all th..."*)

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Keep in mind that Rizia is also a player on the international stage, Your Majesty. We do not have to kowtow to dissenting opinions, but we must tolerate them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Hugo Toras: ""Fortunately, the Delegates' speaker, Daria de Rava, is a..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Houses Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""How have you been?""*)

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""His promises to give a voice to the common man seem to be resonating with the populace. Part of it, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""Common man? He's descended from nobility.""*)
  - -> `[100]` (*Player_Romus: ""Relax. I'm not that concerned.""*)
  - -> `[101]` (*Player_Romus: ""I'd like to meet this fellow.""*)
  - -> `[102]` (*Player_Romus: ""You're right to be wary of him. We've got to keep him in..."*)

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""Good thinking. This will apply to her too... One day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""As the king, you're both Rizia's head of state and comma..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Hugo pursed his lips."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""Shrewd, in fact. It gave Rizia the appearance of a const..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Hugo Toras: ""We will.""*)

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""While she remains under strict orders not to leave the island, no such restrictions were placed on the son she gave birth to shortly after her arrival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[130]`
Mówca: **Narrator**
> "To my slight surprise, the room was empty except for one man. My uncle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "When Hugo saw me, he sprang to his feet."*)

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""I thought a private chat with your Grand Vizier would be in order before delving into council politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""You'll meet everyone else soon enough. But I thought a private chat with your Grand Vizier would be in order first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[133]`
Mówca: **Narrator**
> "His eyes traveled to the doorway, where Vina was still standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""Although it seems it won't be as private as I was expect..."*)

### Węzeł `[134]`
Mówca: **Vina Toras**
> ""Yes, Uncle Hugo. I'm sitting in on the King's council meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""I was against the idea, for the record. But she insisted.""*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[142]` (*Player_Romus: ""It's unorthodox, I know. But future queens should have t..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "My daughter gave a shy nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Vina Toras: ""Yes, Uncle Hugo. I'm sitting in on the King's council me..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was against the idea, for the record. But she insisted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Hugo frowned as he processed this new information, then b..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's going to learn by experience, just like I did.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[134]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Hugo frowned as he processed this new information, then b..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player_Romus: ""She's going to learn by experience, just like I did.""*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""She's going to learn by experience. I wish I had done th..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's going to learn by experience. I wish I had done the same.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Hugo frowned as he processed this new information, then b..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's unorthodox, I know. But future queens should have the same privileges as future kings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Hugo frowned as he processed this new information, then b..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Hugo frowned as he processed this new information, then broke into a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Hugo Toras: ""By all means, then, Your Highness, have a seat.""*)

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""By all means, then, Your Highness, have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "Vina walked over to the table as I made my way to the red..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "Vina walked over to the table as I made my way to the red velvet chair. Once we were all seated, I turned to my uncle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""How have you been?""*)
  - -> `[33]` (*Player_Romus: ""How is your son?""*)
  - -> `[34]` (*Player_Romus: ""How is your wife?""*)

### Węzeł `[146]`
Mówca: **Narrator**
> "He gestured to the red velvet chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Hugo Toras: ""Sila Orica be damned, this is the real seat that matters..."*)

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""Sila Orica be damned, this is the real seat that matters. And it's been waiting for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "I made my way over to the chair. Once we were both seated..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "I made my way over to the chair. Once we were both seated, I turned to my uncle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""How have you been?""*)
  - -> `[33]` (*Player_Romus: ""How is your son?""*)
  - -> `[34]` (*Player_Romus: ""How is your wife?""*)

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""As though I'd trust anyone else to advise my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "As I listened to him, my eyes drifted towards the back wa..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "He smiled fondly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""I hope you can make it out for a visit soon. Both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "As I listened to him, my eyes drifted towards the back wa..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Hugo Toras: ""I hope you can make it out for a visit soon. Both of you.""*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Hugo Toras: ""You and the Princess ought to come out for a visit soon.""*)

### Węzeł `[155]`
Mówca: **Hugo Toras**
> ""You and the Princess ought to come out for a visit soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "As I listened to him, my eyes drifted towards the back wa..."*)

### Węzeł `[156]`
Mówca: **Hugo Toras**
> ""Between that and visits to Rico in Iza, I haven't had a day off since the funeral.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "As I listened to him, my eyes drifted towards the back wa..."*)

### Węzeł `[157]`
Mówca: **Hugo Toras**
> ""They propose decrees and issue official approvals or disapprovals of the laws passed by you and the council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Hugo Toras: ""As Grand Vizier, it's traditional for me to attend their..."*)

### Węzeł `[158]`
Mówca: **Hugo Toras**
> ""It still works the way he intended. Rizia has the appearance of a constitutional democracy while power remains firmly in the hands of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""His Majesty Valero presided over the last elections in 1..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "Hugo raised his eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Hugo Toras: ""Is that so? Since when?""*)

### Węzeł `[160]`
Mówca: **Hugo Toras**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Vina Toras: ""Thank you for the offer anyway, Uncle Hugo.""*)

### Węzeł `[161]`
Mówca: **Narrator**
> "Vina finished jotting down some notes as Hugo went searching for the wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_WineWithHugo = true"*)

### Węzeł `[162]`
Mówca: **Hugo Toras**
> ""I think your father kept a store of vintage Cantuavo in one of these cabinets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Vina Toras: ""Thank you for the invitation, Uncle Hugo.""*)

### Węzeł `[163]`
Mówca: **Vina Toras**
> ""Thank you for the offer anyway, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Hugo Toras: ""My pleasure.""*)

### Węzeł `[164]`
Mówca: **Vina Toras**
> ""Thank you for the invitation, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "He turned to look my daughter in the eye."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't drink, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing = true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Gladly. We still have much to catch up on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Hugo Toras: ""I think your father kept a store of vintage Cantuavo in ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Trait_SoberKing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Hugo raised his eyebrows."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another time, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Hugo Toras: ""I look forward to it.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm your superior now, Your Grace. It wouldn't be appropriate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1"*)

### Węzeł `[170]`
Mówca: **Narrator**
> "Hugo scowled briefly, then forced a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Hugo Toras: ""Understood, Your Majesty.""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "Hugo scowled briefly, then forced a smile."*)

### Węzeł `[172]`
Mówca: **Hugo Toras**
> ""Noon already. Shall we and the young heiress break for a glass of wine before the council convenes this afternoon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""I don't drink, Hugo.""*)
  - -> `[166]` (*Player_Romus: ""Gladly. We still have much to catch up on.""*)
  - -> `[168]` (*Player_Romus: ""Another time, Your Grace.""*)
  - -> `[169]` (*Player_Romus: ""I'm your superior now, Your Grace. It wouldn't be approp..."*)

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""I look forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Vina Toras: ""Thank you for the offer anyway, Uncle Hugo.""*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Hugo Toras: ""Noon already. Shall we and the young heiress break for a..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Hugo Toras: ""Noon already. Shall we break for a glass of wine before ..."*)

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""Is that so? Since when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""I could never stand the taste of alcohol.""*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[187]` (*Player_Romus: ""I don't remember. I just stopped at some point.""*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I could never stand the taste of alcohol.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Hugo Toras: ""I never knew.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since I found God.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[177]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Hugo Toras: ""A curious way of expressing your devotion. Alcohol consu..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: ""Since I found God.""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I overdid it as the Party Prince. I'm clean now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[177]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Hugo Toras: ""A respectable decision. But on the other hand...""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Romus: ""I overdid it as the Party Prince. I'm clean now.""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't remember. I just stopped at some point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Hugo Toras: ""I never knew.""*)

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""A respectable decision. But on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Hugo Toras: ""You should remember that it's highly untraditional for a..."*)

### Węzeł `[189]`
Mówca: **Hugo Toras**
> ""A curious way of expressing your devotion. Alcohol consumption is expressly permitted in most Nurist denominations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Hugo Toras: ""You should remember that it's highly untraditional for a..."*)

### Węzeł `[190]`
Mówca: **Hugo Toras**
> ""I never knew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Hugo Toras: ""You should remember that it's highly untraditional for a..."*)

### Węzeł `[191]`
Mówca: **Hugo Toras**
> ""You should remember that it's highly untraditional for a Rizian monarch to refuse his country's national beverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""If tradition demands it, you might as well pour me a gla..."*)
  - -> `[225]` (*Player_Romus: ""Duly noted, but this isn't a formal occasion. I respectf..."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "Hugo raised his eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Hugo Toras: ""Is that so? Since when?""*)

### Węzeł `[193]`
Mówca: **Hugo Toras**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He stood up, then paused and turned back to me."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "He stood up, then paused and turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Hugo Toras: ""I hope young Vina is adjusting to life in the capital? P..."*)

### Węzeł `[195]`
Mówca: **Hugo Toras**
> ""I think your father kept a store of vintage Cantuavo in one of these cabinets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "He stood up, then paused and turned back to me."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't drink, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "Hugo raised his eyebrows."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Gladly. We still have much to catch up on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Hugo Toras: ""I think your father kept a store of vintage Cantuavo in ..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another time, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Hugo Toras: ""I look forward to it.""*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm your superior now, Your Grace. It wouldn't be appropriate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1"*)

### Węzeł `[200]`
Mówca: **Narrator**
> "Hugo scowled, then forced a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Hugo Toras: ""Understood, Your Majesty.""*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "Hugo scowled, then forced a smile."*)

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""Noon already. Shall we break for a glass of wine before the council convenes this afternoon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""I don't drink, Hugo.""*)
  - -> `[197]` (*Player_Romus: ""Gladly. We still have much to catch up on.""*)
  - -> `[198]` (*Player_Romus: ""Another time, Your Grace.""*)
  - -> `[199]` (*Player_Romus: ""I'm your superior now, Your Grace. It wouldn't be approp..."*)

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""I look forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He stood up, then paused and turned back to me."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "He stood up, then paused and turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Hugo Toras: ""I hope young Vina is adjusting to life in the capital? P..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since I found God.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Hugo Toras: ""That's an extreme interpretation of Wruhecism. But I can..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""Since I found God.""*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I overdid it as the Party Prince. I'm clean now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Hugo Toras: ""A respectable decision.""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player_Romus: ""I overdid it as the Party Prince. I'm clean now.""*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't remember. I just stopped at some point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Hugo Toras: ""I never knew.""*)

### Węzeł `[214]`
Mówca: **Hugo Toras**
> ""A respectable decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Hugo Toras: ""You should find a way to keep this a secret, though. No ..."*)

### Węzeł `[215]`
Mówca: **Hugo Toras**
> ""That's an extreme interpretation of Wruhecism. But I can respect it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Hugo Toras: ""You should find a way to keep this a secret, though. No ..."*)

### Węzeł `[216]`
Mówca: **Hugo Toras**
> ""I never knew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Hugo Toras: ""You should find a way to keep this a secret, though. No ..."*)

### Węzeł `[217]`
Mówca: **Hugo Toras**
> ""Is that so? Since when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: ""I could never stand the taste of alcohol.""*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[213]` (*Player_Romus: ""I don't remember. I just stopped at some point.""*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I could never stand the taste of alcohol.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Hugo Toras: ""I never knew.""*)

### Węzeł `[219]`
Mówca: **Hugo Toras**
> ""You should find a way to keep this a secret, though. No Rizian monarch can be seen refusing his country's national beverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""Oh. Well, in that case, my sober days are over. Pour me ..."*)
  - -> `[221]` (*Player_Romus: ""Duly noted. I'll figure something out.""*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. Well, in that case, my sober days are over. Pour me a glass.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Hugo laughed."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duly noted. I'll figure something out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing = true"*)

### Węzeł `[222]`
Mówca: **Narrator**
> "Hugo laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Hugo Toras: ""I think your father kept a store of vintage Cantuavo in ..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Trait_SoberKing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He stood up, then paused and turned back to me."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If tradition demands it, you might as well pour me a glass.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "Hugo laughed."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duly noted, but this isn't a formal occasion. I respectfully decline.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Vina Toras: ""Thank you for the offer anyway, Uncle Hugo.""*)

### Węzeł `[226]`
Mówca: **Narrator**
> "Hugo laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon = true"*)

### Węzeł `[227]`
Mówca: **Vina Toras**
> ""Thank you for the offer anyway, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Hugo Toras: ""My pleasure.""*)

### Węzeł `[228]`
Mówca: **Hugo Toras**
> ""My pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "He turned to look Vina in the eye."*)

### Węzeł `[229]`
Mówca: **Hugo Toras**
> ""I know how overwhelming the move to the capital can be, Your Highness. If you ever need someone to talk to, remember you can always come to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Vina smiled politely."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "He turned to look Vina in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Hugo Toras: ""I know how overwhelming the move to the capital can be, ..."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "Vina smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Vina Toras: ""That's very kind of you, Uncle Hugo.""*)

### Węzeł `[232]`
Mówca: **Vina Toras**
> ""That's very kind of you, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player_Romus: ""Yes. *Too* kind.""*)
  - -> `[239]` (*Player_Romus: ""Listen to your uncle, Vina. He knows how everything work..."*)
  - -> `[240]` (*Player_Romus: ""No offers of advice for me?""*)

### Węzeł `[233]`
Mówca: **Narrator**
> "He turned to look my daughter in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Hugo Toras: ""What an intelligent and well-mannered young woman you've..."*)

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""What an intelligent and well-mannered young woman you've grown up to be, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Hugo Toras: ""I know how overwhelming the capital can seem compared to..."*)

### Węzeł `[235]`
Mówca: **Hugo Toras**
> ""I know how overwhelming the capital can seem compared to Monqiz. If you ever have questions, don't be afraid to come to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "Vina smiled politely."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "Vina smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Vina Toras: ""That's very kind of you, Uncle Hugo.""*)

### Węzeł `[237]`
Mówca: **Vina Toras**
> ""That's very kind of you, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""Yes. *Too* kind.""*)
  - -> `[252]` (*Player_Romus: ""Listen to your uncle, Vina. He knows how everything work..."*)
  - -> `[253]` (*Player_Romus: ""No offers of advice for me?""*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. *Too* kind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Hugo Toras: ""Forgive my forwardness. I'm simply excited to have the f..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen to your uncle, Vina. He knows how everything works around here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Hugo Toras: ""What is my role as Grand Vizier, if not to advise the ro..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No offers of advice for me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[241]`
Mówca: **Hugo Toras**
> ""Forgive my forwardness. I'm simply excited to have the family together again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Vina finished jotting down a few notes. The three of us p..."*)

### Węzeł `[242]`
Mówca: **Hugo Toras**
> ""What is my role as Grand Vizier, if not to advise the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Vina finished jotting down a few notes. The three of us p..."*)

### Węzeł `[243]`
Mówca: **Hugo Toras**
> ""I said it all to you during our hunting days, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Hugo Toras: ""The larger your quarry, the more important it is not to ..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Hugo Toras: ""I said it all to you during our hunting days, Romus.""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Hugo Toras: ""I wouldn't presume to know better than you, Your Majesty.""*)

### Węzeł `[247]`
Mówca: **Hugo Toras**
> ""The larger your quarry, the more important it is not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_LargerYourQuarry = true"*)

### Węzeł `[248]`
Mówca: **Narrator**
> "Vina finished jotting down a few notes. The three of us packed up and left for the morning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs = true"*)

### Węzeł `[249]`
Mówca: **Hugo Toras**
> ""I wouldn't presume to know better than you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Hugo Toras: ""But of course you can always come to me with questions a..."*)

### Węzeł `[250]`
Mówca: **Hugo Toras**
> ""But of course you can always come to me with questions as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Vina finished jotting down a few notes. The three of us p..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. *Too* kind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Hugo Toras: ""Pardon my forwardness. I'm simply excited to have the fa..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen to your uncle, Vina. He knows how everything works around here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Hugo Toras: ""What is my role as Grand Vizier, if not to advise the ro..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No offers of advice for me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[254]`
Mówca: **Hugo Toras**
> ""Pardon my forwardness. I'm simply excited to have the family together again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Vina finished jotting down some notes as Hugo went search..."*)

### Węzeł `[255]`
Mówca: **Hugo Toras**
> ""What is my role as Grand Vizier, if not to advise the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Vina finished jotting down some notes as Hugo went search..."*)

### Węzeł `[256]`
Mówca: **Hugo Toras**
> ""I said it all to you during our hunting days, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Hugo Toras: ""The more ferocious your quarry, the more important it is..."*)

### Węzeł `[257]`
Mówca: **Hugo Toras**
> ""I wouldn't presume to know better than you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Hugo Toras: ""But of course you can always come to me with questions a..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Hugo Toras: ""I said it all to you during our hunting days, Romus.""*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Hugo Toras: ""I wouldn't presume to know better than you, Your Majesty.""*)

### Węzeł `[261]`
Mówca: **Hugo Toras**
> ""The more ferocious your quarry, the more important it is not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Vina finished jotting down some notes as Hugo went search..."*)

### Węzeł `[262]`
Mówca: **Hugo Toras**
> ""But of course you can always come to me with questions as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Vina finished jotting down some notes as Hugo went search..."*)

### Węzeł `[263]`
Mówca: **Hugo Toras**
> ""I hope young Vina is adjusting to life in the capital? Please let her know that if she has questions, she shouldn't feel shy about coming to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""That's kind of you. *Too* kind.""*)
  - -> `[266]` (*Player_Romus: ""Thank you for the offer. I'll let her know.""*)
  - -> `[267]` (*Player_Romus: ""No advice for me?""*)

### Węzeł `[264]`
Mówca: **Hugo Toras**
> ""I hope young Vina is adjusting to life in the capital? Please let her know that if she has questions, she shouldn't feel shy about coming to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus: ""That's kind of you. *Too* kind.""*)
  - -> `[279]` (*Player_Romus: ""Thank you for the offer. I'll let her know.""*)
  - -> `[280]` (*Player_Romus: ""No advice for me?""*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's kind of you. *Too* kind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Hugo Toras: ""Forgive my forwardness. I'm simply excited to have the f..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the offer. I'll let her know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Hugo Toras: ""What is my role as Grand Vizier, if not to advise the ro..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No advice for me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[268]`
Mówca: **Narrator**
> "He turned away and started searching for the wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_WineWithHugo = true"*)

### Węzeł `[269]`
Mówca: **Hugo Toras**
> ""Forgive my forwardness. I'm simply excited to have the family together again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "He turned away and started searching for the wine."*)

### Węzeł `[270]`
Mówca: **Hugo Toras**
> ""What is my role as Grand Vizier, if not to advise the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "He turned away and started searching for the wine."*)

### Węzeł `[271]`
Mówca: **Hugo Toras**
> ""I said it all to you during our hunting days, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Hugo Toras: ""The more ferocious your quarry, the more important it is..."*)

### Węzeł `[272]`
Mówca: **Hugo Toras**
> ""I wouldn't presume to know better than you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Hugo Toras: ""But of course you can always come to me with questions a..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Hugo Toras: ""I said it all to you during our hunting days, Romus.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Hugo Toras: ""I wouldn't presume to know better than you, Your Majesty.""*)

### Węzeł `[276]`
Mówca: **Hugo Toras**
> ""The more ferocious your quarry, the more important it is not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "He turned away and started searching for the wine."*)

### Węzeł `[277]`
Mówca: **Hugo Toras**
> ""But of course you can always come to me with questions as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "He turned away and started searching for the wine."*)

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's kind of you. *Too* kind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Hugo Toras: ""Forgive my forwardness. I'm simply excited to have the f..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the offer. I'll let her know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Hugo Toras: ""What is my role as Grand Vizier, if not to advise the ro..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No advice for me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[281]`
Mówca: **Narrator**
> "He turned away. The two of us packed up in silence and left for the morning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs = true"*)

### Węzeł `[282]`
Mówca: **Hugo Toras**
> ""Forgive my forwardness. I'm simply excited to have the family together again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "He turned away. The two of us packed up in silence and le..."*)

### Węzeł `[283]`
Mówca: **Hugo Toras**
> ""What is my role as Grand Vizier, if not to advise the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "He turned away. The two of us packed up in silence and le..."*)

### Węzeł `[284]`
Mówca: **Hugo Toras**
> ""I said it all to you during our hunting days, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Hugo Toras: ""The larger your quarry, the more important it is not to ..."*)

### Węzeł `[285]`
Mówca: **Hugo Toras**
> ""I wouldn't presume to know better than you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Hugo Toras: ""But of course you can always come to me with questions a..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Hugo Toras: ""I said it all to you during our hunting days, Romus.""*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Hugo Toras: ""I wouldn't presume to know better than you, Your Majesty.""*)

### Węzeł `[289]`
Mówca: **Hugo Toras**
> ""The larger your quarry, the more important it is not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "He turned away. The two of us packed up in silence and le..."*)

### Węzeł `[290]`
Mówca: **Hugo Toras**
> ""But of course you can always come to me with questions as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "He turned away. The two of us packed up in silence and le..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_WineWithHugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_WineWithHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs = true"*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why can't I attend? I want to be in touch with my populace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Hugo Toras: ""The sessions can be quite long and tedious, Your Majesty..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think would be the consequences if I ignore them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Hugo Toras: ""Officially, there are none. Unofficially, I'd advise you..."*)

### Węzeł `[294]`
Mówca: **Hugo Toras**
> ""Officially, there are none. Unofficially, I'd advise you to take their input into account.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)

### Węzeł `[295]`
Mówca: **Hugo Toras**
> ""The sessions can be quite long and tedious, Your Majesty. The King's time is better spent on other matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Hugo Toras: ""With that said, I would advise you to take the Delegates..."*)

### Węzeł `[296]`
Mówca: **Hugo Toras**
> ""With that said, I would advise you to take the Delegates' input into account.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)

### Węzeł `[297]`
Mówca: **Hugo Toras**
> ""Fortunately, the Delegates' speaker, Daria de Rava, is a Toras loyalist through and through. She should give you no trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""The opposition is small but worth keeping an eye on. Esp..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Nelvisar_VergeOfDepletion ..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need all this. I can fend for myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So they're guarding Vina and Queen Mother Estela as well?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Titus Gordion: ""Your limp says otherwise. There's no way that would have..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Titus Gordion: ""What about your young daughter? Your elderly mother? It ..."*)

### Węzeł `[304]`
Mówca: **Titus Gordion**
> ""Your limp says otherwise. There's no way that would have happened on our watch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[305]`
Mówca: **Titus Gordion**
> ""What about your young daughter? Your elderly mother? It may not always be you that your enemies target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[306]`
Mówca: **Titus Gordion**
> ""Yes, my men have eyes on both of them as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Hugo Toras: ""My mother Lyza discontinued the Golden Guard. But King V..."*)

### Węzeł `[307]`
Mówca: **Hugo Toras**
> ""One more thing. As you're aware, a few years before your father's death, he reinstated the Golden Guard...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""Right. The royal family's personal security force. And w..."*)
  - -> `[309]` (*Player_Romus: ""And?""*)
  - -> `[310]` (*Player_Romus: ""Why would he do that?""*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. The royal family's personal security force. And where are they now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Titus Gordion: ""Here, sir. Ready and able.""*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Titus Gordion: ""We hope to serve you well, sir.""*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would he do that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Titus Gordion: ""For his and your personal protection, sir.""*)

### Węzeł `[311]`
Mówca: **Titus Gordion**
> ""Here, sir. Ready and able.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "For the first time, I noticed the man standing in the cor..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "For the first time, I noticed the man standing in the corner of the room. He was wearing a tight-fitting gold blazer that barely concealed his muscular physique."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Hugo Toras: ""Meet Titus Gordion, captain of the Golden Guard. He and ..."*)

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""Meet Titus Gordion, captain of the Golden Guard. He and his men have been keeping a close watch on you since the coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player_Romus: ""What the hell?""*)
  - -> `[318]` (*Player_Romus: ""Has he been in the room with us this whole time?""*)
  - -> `[319]` (*Player_Romus: ""I'm pleased to meet you, Captain Gordion.""*)

### Węzeł `[314]`
Mówca: **Titus Gordion**
> ""We hope to serve you well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "For the first time, I noticed the man standing in the cor..."*)

### Węzeł `[315]`
Mówca: **Titus Gordion**
> ""For his and your personal protection, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "For the first time, I noticed the man standing in the cor..."*)

### Węzeł `[316]`
Mówca: **Titus Gordion**
> ""A Golden Guard appears only if and when he is needed, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Hugo Toras: ""Titus and the members of his two-thousand strong brigade..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What the hell?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Titus Gordion: ""My apologies, sir. I was waiting for an opportune time t..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Has he been in the room with us this whole time?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Titus Gordion: ""A Golden Guard appears only if and when he is needed, sir.""*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm pleased to meet you, Captain Gordion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Titus Gordion: ""Call me Titus, sir.""*)

### Węzeł `[320]`
Mówca: **Titus Gordion**
> ""Call me Titus, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Hugo Toras: ""Titus and the members of his two-thousand strong brigade..."*)

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""Titus and the members of his two-thousand strong brigade have been trained in the upper echelons of Rizia's military and police academies. Each has sworn an oath to protect the King and his family at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player_Romus: ""What's with the costumes? Wouldn't plainclothes bodyguar..."*)
  - -> `[336]` (*Player_Romus: ""And how do we know they can be trusted? What if someone ..."*)
  - -> `[299]` (*Player_Romus: ""I don't need all this. I can fend for myself.""*)
  - -> `[300]` (*Player_Romus: ""So they're guarding Vina and Queen Mother Estela as well?""*)
  - -> `[358]` (*Player_Romus: ""Great. Looking forward to working with them.""*)

### Węzeł `[322]`
Mówca: **Titus Gordion**
> ""My apologies, sir. I was waiting for an opportune time to introduce myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Hugo Toras: ""Titus and the members of his two-thousand strong brigade..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Titus Gordion: ""Yes. My men have eyes on the Queen Mother as we speak.""*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Titus Gordion: ""Yes, my men have eyes on both of them as we speak.""*)

### Węzeł `[326]`
Mówca: **Titus Gordion**
> ""Yes. My men have eyes on the Queen Mother as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "He bowed to Vina. She looked a little flustered."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "He bowed to Vina. She looked a little flustered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Vina Toras: ""But didn't Queen Lyza discontinue the Golden Guard? Beca..."*)

### Węzeł `[328]`
Mówca: **Vina Toras**
> ""But didn't Queen Lyza discontinue the Golden Guard? Because she thought they made royals look elitist, and because...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "She trailed off."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "She trailed off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Titus Gordion: ""Because she thought they were getting too powerful. It's..."*)

### Węzeł `[330]`
Mówca: **Titus Gordion**
> ""Because she thought they were getting too powerful. It's why our current force is less than a fifth of the size it once was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Hugo Toras: ""Your father always had a fondness for Rizian tradition. ..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "He bowed to Vina. She looked a little flustered."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Hugo Toras: ""My mother Lyza discontinued the Golden Guard. But King V..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's with the costumes? Wouldn't plainclothes bodyguards be more effective?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Titus Gordion: ""It sends the signal that you are well protected, sir. My..."*)

### Węzeł `[335]`
Mówca: **Titus Gordion**
> ""It sends the signal that you are well protected, sir. My predecessors wore solid gold breastplates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do we know they can be trusted? What if someone gets to them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Titus Gordion: ""I conduct regular screenings of each and every member of..."*)

### Węzeł `[337]`
Mówca: **Titus Gordion**
> ""I conduct regular screenings of each and every member of my brigade, Your Majesty. As for myself, I have no wife and child to threaten, and I receive a paycheck so large that bribery would be of no use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[338]`
Mówca: **Hugo Toras**
> ""Your father always had a fondness for Rizian tradition. So he spared no expense in bringing the Guard back, albeit in a reduced form.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player_Romus: ""You and your men had better stay in line, Captain Gordion.""*)
  - -> `[341]` (*Player_Romus: ""It humbles me to be worthy of such an elite unit's prote..."*)
  - -> `[342]` (*Player_Romus: ""He was right to do so. The most important family in Rizi..."*)

### Węzeł `[339]`
Mówca: **Hugo Toras**
> ""My mother Lyza discontinued the Golden Guard. But King Valero always did have a fondness for Rizian tradition. He spared no expense in bringing it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player_Romus: ""You and your men had better stay in line, Captain Gordion.""*)
  - -> `[341]` (*Player_Romus: ""It humbles me to be worthy of such an elite unit's prote..."*)
  - -> `[342]` (*Player_Romus: ""He was right to do so. The most important family in Rizi..."*)
  - -> `[343]` (*Player_Romus: ""Guards in gold... it still seems too flashy for me.""*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and your men had better stay in line, Captain Gordion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[338]` (Hugo Toras), `[339]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Titus Gordion: ""We answer to no one but you, sir.""*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It humbles me to be worthy of such an elite unit's protection.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[338]` (Hugo Toras), `[339]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Titus Gordion: ""The humility is all mine, sir.""*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was right to do so. The most important family in Rizia deserves the most important security force.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[338]` (Hugo Toras), `[339]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Titus Gordion: ""I won't let you down, sir.""*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards in gold... it still seems too flashy for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Titus Gordion: ""We'll be sure to stay out of your way, sir.""*)

### Węzeł `[344]`
Mówca: **Titus Gordion**
> ""We'll be sure to stay out of your way, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Hugo Toras: ""Thank you, Titus. You may wait outside the chambers unti..."*)

### Węzeł `[345]`
Mówca: **Titus Gordion**
> ""I won't let you down, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Hugo Toras: ""Thank you, Titus. You may wait outside the chambers unti..."*)

### Węzeł `[346]`
Mówca: **Titus Gordion**
> ""The humility is all mine, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Hugo Toras: ""Thank you, Titus. You may wait outside the chambers unti..."*)

### Węzeł `[347]`
Mówca: **Titus Gordion**
> ""We answer to no one but you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Hugo Toras: ""Thank you, Titus. You may wait outside the chambers unti..."*)

### Węzeł `[348]`
Mówca: **Hugo Toras**
> ""Thank you, Titus. You may wait outside the chambers until the meeting's conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "Titus nodded and swiftly left the room."*)

### Węzeł `[350]`
Mówca: **Narrator**
> "Titus nodded and swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The stairway to the Royal Council chambers was longer tha..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a waste of time. I'd rather just make all the decrees myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Hugo Toras: ""I'd advise you to at least take the Delegates' input int..."*)

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""I'd advise you to at least take the Delegates' input into account, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're wrong. It is very kingly of me to show up whenever I want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "After collecting my thoughts, I pushed open the door and ..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for that, Your Grace. I will be counting on you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Hugo Toras: ""Of course, Your Majesty.""*)

### Węzeł `[357]`
Mówca: **Hugo Toras**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Hugo Toras: ""With that said, I would advise you to take the Delegates..."*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. Looking forward to working with them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Titus Gordion: ""It is an honor, Your Majesty.""*)

### Węzeł `[359]`
Mówca: **Titus Gordion**
> ""It is an honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[360]`
Mówca: **Hugo Toras**
> ""It was the only way for him to stay in power. Rizia could not survive past the 1920s without some semblance of democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""His Majesty Valero presided over the last elections in 1..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "Hugo winced."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "Hugo winced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Hugo Toras: ""Keep in mind that Rizia is also a player on the internat..."*)

### Węzeł `[363]`
Mówca: **Hugo Toras**
> ""Do not discount the importance of the nobility to this kingdom, my nephew. Keep them satisfied, and commoners' lives will be better for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Hugo Toras: ""But if you want a self-styled 'man of the people', look ..."*)

### Węzeł `[364]`
Mówca: **Hugo Toras**
> ""But if you want a self-styled 'man of the people', look no further than the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Hugo Toras: ""More specifically, to their new leader Manus Sazon.""*)

### Węzeł `[365]`
Mówca: **Hugo Toras**
> ""More specifically, to their new leader Manus Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Hugo scanned my face closely as he spoke the name."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Hugo made a tutting sound."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Hugo Toras: ""I think your father kept a store of vintage Cantuavo in ..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid = true;
RiziaDLC.Enable_Policy_RD_Economy_AncientRezenidCityRestoration = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Economy_AncientRezenidCityRestoration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Nelvisar_VergeOfDepletion = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Nelvisar_VergeOfDepletion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Havas_CoalDepositsSuspecte..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Havas_CoalDepositsSuspected = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Havas_CoalDepositsSuspected"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_G_UnitedContanaICBMTest = true;"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Panel_RoyalDecrees = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Panel_RoyalDecrees"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandCle..."*)

### Węzeł `[372]`
Mówca: **Hugo Toras**
> ""Like your father and grandmother before you, you alone have the power to shape this country by passing royal decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Hugo Toras: ""As is tradition over hundreds of years, each new ruler h..."*)

### Węzeł `[373]`
Mówca: **Hugo Toras**
> ""As is tradition over hundreds of years, each new ruler has passed the Sovereign Transition and Clemency Decree to start their reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Hugo Toras: ""The kingdom will be expecting your decree very soon.""*)

### Węzeł `[374]`
Mówca: **Hugo Toras**
> ""The kingdom will be expecting your decree very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Player_Romus: ""Tradition is the enemy of progress. We should not be bou..."*)
  - -> `[377]` (*Player_Romus: ""Thanks for your advice, uncle. It's comforting to have y..."*)
  - -> `[376]` (*Player_Romus: ""The decrees will play a significant role in my reign. Th..."*)
  - -> `[375]` (*Player_Romus: ""I would never go against the traditions of Rizia. I will..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never go against the traditions of Rizia. I will sign the decree as soon as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Hugo Toras: ""Very good. Upholding tradition is key to the stability o..."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The decrees will play a significant role in my reign. They won't be just symbolic gestures, but tools to shape the future of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Hugo Toras: ""Wield this power wisely, Romus. The decrees you issue sh..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for your advice, uncle. It's comforting to have your wisdom and experience guiding me at the start of my reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Hugo Toras: ""Your humility is appreciated. But remember, being King i..."*)

### Węzeł `[378]`
Mówca: **Hugo Toras**
> ""Your humility is appreciated. But remember, being King is about making hard decisions, not just following advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[379]`
Mówca: **Hugo Toras**
> ""Wield this power wisely, Romus. The decrees you issue should strengthen the fabric of our kingdom, not tear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[380]`
Mówca: **Hugo Toras**
> ""Very good. Upholding tradition is key to the stability of our monarchy and the continued loyalty of our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_PromisedToSignTransition = true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Absolutism == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player_Romus: ""I've been looking forward to this all my life. Finally, ..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been looking forward to this all my life. Finally, I have the power to make decisions completely unchallenged.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Kontekst wejściowy (poprzednik):** `[374]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Hugo Toras: ""I still urge caution. Nobody can stop you from passing d..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_PromisedToSignTransition = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_PromisedToSignTransition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tradition is the enemy of progress. We should not be bound by the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Hugo Toras: ""Disregarding tradition is a perilous path, Romus. Our pe..."*)

### Węzeł `[387]`
Mówca: **Hugo Toras**
> ""Disregarding tradition is a perilous path, Romus. Our people cherish these customs. They are the bedrock of our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)

### Węzeł `[388]`
Mówca: **Hugo Toras**
> ""I still urge caution. Nobody can stop you from passing decrees, but you have to be prepared for possible backlash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[389]`
Mówca: **Hugo Toras**
> ""Moving too swiftly away from them -- as you did during your coronation --might bring unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_GaveSpeech == true)"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Hugo Toras: ""Moving too swiftly away from them -- as you did during y..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_GaveSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[393]`
Mówca: **Narrator**
> "Hugo reached for a neatly rolled parchment lying on the grand table. With deliberate movements, he unrolled it, revealing the prepared royal decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "The intricate script and the seal of Rizia glinted under ..."*)

### Węzeł `[394]`
Mówca: **Narrator**
> "The intricate script and the seal of Rizia glinted under the chandelier's light."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""I and the rest of the Royal Council will advise you to t..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "Hugo reached for a neatly rolled parchment lying on the g..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Panel_RoyalDecrees = true;
RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Panel_RoyalDecrees"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Hugo Toras: ""The kingdom will be expecting your signature soon.""*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true)"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player_Romus: ""It troubles me that a single person can hold that much p..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It troubles me that a single person can hold that much power. I am as fallible as anyone else.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Reform"] == true` AND `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[374]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Hugo Toras: ""That's what your advisors are for, my nephew.""*)

### Węzeł `[401]`
Mówca: **Hugo Toras**
> ""That's what your advisors are for, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[402]`
Mówca: **Hugo Toras**
> ""I will, however, gently remind you that it is traditional for each new monarch of Rizia to pass the Sovereign Transition and Clemency Decree to start their reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true; RiziaDLC.Enable_Polic..."*)

### Węzeł `[403]`
Mówca: **Hugo Toras**
> ""The kingdom will be expecting your signature soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Player_Romus: ""Tradition is the enemy of progress. We should not be bou..."*)
  - -> `[430]` (*Player_Romus: ""Clemency? Ha! Under me, the people of Rizia will know no..."*)
  - -> `[423]` (*Player_Romus: ""I would never go against the traditions of Rizia. I will..."*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_SecurityCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_SecurityCouncil == true"*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Focus_SecurityCouncil == true)"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_SecurityCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_SecurityCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Hugo Toras: ""You were assisting with royal decrees before your reign...."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Focus_SecurityCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_SecurityCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Hugo Toras: ""Like your father and grandmother before you, you alone h..."*)

### Węzeł `[407]`
Mówca: **Hugo Toras**
> ""You were assisting with royal decrees before your reign. Now, you're the one holding the seal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Hugo Toras: ""As is tradition over hundreds of years, each new ruler h..."*)

### Węzeł `[408]`
Mówca: **Hugo Toras**
> ""I think we're almost done here. Unless there's anything else you'd like to bring up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_G_UnitedContanaICBMTest = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_UnitedContanaICBMTest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_LargerYourQuarry = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_LargerYourQuarry"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Vina finished jotting down a few notes. The three of us p..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player_Romus: ""It troubles me that a single person can hold that much p..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It troubles me that a single person can hold that much power. I am as fallible as anyone else.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Kontekst wejściowy (poprzednik):** `[403]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Hugo Toras: ""That's what your advisors are for, my nephew.""*)

### Węzeł `[415]`
Mówca: **Hugo Toras**
> ""Moving too swiftly away from them -- as you did during your coronation --might bring unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[416]`
Mówca: **Hugo Toras**
> ""That's what your advisors are for, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_GaveSpeech == true)"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Hugo Toras: ""Moving too swiftly away from them -- as you did during y..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_GaveSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Panel_RoyalDecrees = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Panel_RoyalDecrees"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandCle..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Hugo Toras: ""At any rate, since you say you're caught up on the polit..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_PromisedToSignTransition = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_PromisedToSignTransition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never go against the traditions of Rizia. I will sign the decree as soon as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Hugo Toras: ""Very good. Upholding tradition is key to the stability o..."*)

### Węzeł `[424]`
Mówca: **Hugo Toras**
> ""I urge you to reconsider, Romus. No monarch wants to be remembered as a tyrant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[425]`
Mówca: **Hugo Toras**
> ""Very good. Upholding tradition is key to the stability of our monarchy and the continued loyalty of our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_PromisedToSignTransition = true"*)

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been looking forward to this all my life. Finally, the power to make decisions completely unchallenged.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Kontekst wejściowy (poprzednik):** `[403]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Hugo Toras: ""I still urge caution. Nobody can stop you from passing d..."*)

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tradition is the enemy of progress. We should not be bound by the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Hugo Toras: ""Disregarding tradition is a perilous path, Romus. Our pe..."*)

### Węzeł `[428]`
Mówca: **Hugo Toras**
> ""Disregarding tradition is a perilous path, Romus. Our people cherish these customs. They are the bedrock of our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)

### Węzeł `[429]`
Mówca: **Hugo Toras**
> ""I still urge caution. Nobody can stop you from passing decrees, but you have to be prepared for possible backlash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Clemency? Ha! Under me, the people of Rizia will know no clemency.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Hugo Toras: ""I urge you to reconsider, Romus. No monarch wants to be ..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Absolutism == true)"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Player_Romus: ""I've been looking forward to this all my life. Finally, ..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = true"*)

### Węzeł `[435]`
Mówca: **Hugo Toras**
> ""At any rate, since you say you're caught up on the political situation, the rest of our meeting won't last long. But perhaps you'd appreciate an update on the noble houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "Jump to: [Houses Hub]"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Sizing up their kingdom’s intricate politics", "Council Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Sizing up their kingdom’s intricate politics","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRez..."*)
