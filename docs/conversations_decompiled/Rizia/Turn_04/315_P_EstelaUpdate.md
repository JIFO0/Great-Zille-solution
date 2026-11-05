# Rizia/Turn 4/P_EstelaUpdate

- **ID konwersacji:** `315`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/315_P_EstelaUpdate.md`
- **Liczba węzłów dialogowych:** 399
- **Liczba wyborów gracza:** 110

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[90]** Bruno
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Decision_Turn04_AttendHouseOfDelegates`
- `RiziaDLC.Diplomacy_Lespia_WehlenHelp`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.Lucita_CompromisingPhoto`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Relations_Estela_TellAboutMurderCase`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Manus_WorkWithRPP`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn04_EstelaTalk_Vina`
- `RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Relations_Estela`
- `RiziaDLC.Turn04_EnableRRGStakeChange`
- `RiziaDLCIsolated.Turn04_EstelaTalk_Vina`
- `RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen`
- `RiziaDLCSupport.Reports_Turn04_Qalus_CantuavoInvitation`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"Tap her on the shoulder."** | `[6]` **Narrator**: "I looked in. My mother was stand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Estela Toras**: ""You shouldn't sneak up on an ol..." |
| `[8]` | **""Can't sleep?""** | `[6]` **Narrator**: "I looked in. My mother was stand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "She looked startled for a moment..." |
| `[9]` | **""Good evening, Mother.""** | `[6]` **Narrator**: "I looked in. My mother was stand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "She looked startled for a moment..." |
| `[11]` | **"Peer in."** | `[10]` **Narrator**: "Grand Wiseman Ignacius' quarters..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "Just before the stairs was the e..." |
| `[12]` | **"Keep walking."** | `[10]` **Narrator**: "Grand Wiseman Ignacius' quarters..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "Just before the stairs was the e..." |
| `[14]` | **"Press your ear against the door."** | `[13]` **Narrator**: "Just before the stairs was the e..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Vina Toras"); ;` | `[61]` **Vina Toras**: ""Yes, I know. I was surprised too.""<br>`[393]` **Vina Toras**: ""It's just the beginning, isn't ..." |
| `[22]` | **"Keep walking."** | `[13]` **Narrator**: "Just before the stairs was the e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "I reached the top floor. Across ..." |
| `[30]` | **""Of course I am. The Alliance of Nations won't know what hit it.""** | `[26]` **Estela Toras**: ""All set for tomorrow?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Estela Toras**: ""That's my boy."" |
| `[31]` | **""Sure. Can I ask you something about Vina?""** | `[26]` **Estela Toras**: ""All set for tomorrow?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Estela Toras**: ""What about our princess?"" |
| `[32]` | **""Did Father tell you anything about these AN sessions?""** | `[26]` **Estela Toras**: ""All set for tomorrow?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Estela Toras**: ""Oh, you know he was no diplomat."" |
| `[33]` | **""Not really. Diplomacy isn't exactly my forte.""** | `[26]` **Estela Toras**: ""All set for tomorrow?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Estela Toras**: ""There's nothing to it. Just sta..." |
| `[39]` | **""Enough is enough. He will pay for his disrespect.""** | `[35]` **Estela Toras**: ""We need our land back. No matte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Estela Toras**: ""I care for Mr. Esquibel dearly,..." |
| `[40]` | **""How do you know he's going to make an announcement?""** | `[35]` **Estela Toras**: ""We need our land back. No matte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Estela Toras**: ""My whisper networks aren't what..." |
| `[43]` | **""I don't want a confrontation. Our countries are on the same side.""** | `[35]` **Estela Toras**: ""We need our land back. No matte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Estela Toras**: ""Oh, Romus. You still believe th..." |
| `[47]` | **""What has she been doing while I'm at my council meetings?"** | `[46]` **Estela Toras**: ""What about our princess?"" | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[52]` **Estela Toras**: ""Besides her etiquette classes, ..." |
| `[51]` | **""Did she get up to anything while I was in Pales?"** | `[46]` **Estela Toras**: ""What about our princess?"" | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | *Brak zmian stanu* | `[65]` **Estela Toras**: ""As far as I could tell, she spe..." |
| `[62]` | **""Has she told you whether she's seeing someone?""** | `[46]` **Estela Toras**: ""What about our princess?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Estela Toras**: ""That isn't the sort of informat..." |
| `[63]` | **""Would it be crazy if I married her off to Rico?""** | `[46]` **Estela Toras**: ""What about our princess?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "She snorted." |
| `[66]` | **""It's all just talk. I don't know what's actually happening.""** | `[64]` **Estela Toras**: ""Although of course I've heard t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Estela Toras**: ""Come, dear. Did you really thin..." |
| `[67]` | **""I think they're more than just rumors.""** | `[64]` **Estela Toras**: ""Although of course I've heard t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Estela Toras**: ""Then you have a relationship to..." |
| `[68]` | **""What rumors?""** | `[64]` **Estela Toras**: ""Although of course I've heard t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Estela Toras**: ""Come, dear. Did you really thin..." |
| `[73]` | **""I am the king. If I order her not to see him, she'll have to obey.""** | `[71]` **Estela Toras**: ""I'll tell you this much. The la..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Narrator**: "She snorted." |
| `[79]` | **""Who said anything about forbidding? I *want* them to get together.""** | `[71]` **Estela Toras**: ""I'll tell you this much. The la..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Estela Toras**: ""After everything the Sazons did..." |
| `[80]` | **""I know that. I'm not stupid.""** | `[71]` **Estela Toras**: ""I'll tell you this much. The la..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Estela Toras**: ""Don't forget what happened when..." |
| `[82]` | **""I would never do that. She's allowed to love whomever she wants.""** | `[71]` **Estela Toras**: ""I'll tell you this much. The la..." | `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true` | *Brak zmian stanu* | `[237]` **Estela Toras**: ""But... after everything the Saz..." |
| `[83]` | **""It's all fine. I've got a plan.""** | `[41]` **Estela Toras**: ""My whisper networks aren't what..."<br>`[42]` **Estela Toras**: ""I care for Mr. Esquibel dearly,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Estela Toras**: ""You always do."" |
| `[84]` | **""Any advice for how to act, then?""** | `[41]` **Estela Toras**: ""My whisper networks aren't what..."<br>`[42]` **Estela Toras**: ""I care for Mr. Esquibel dearly,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Estela Toras**: ""I say don't stoop to his level...." |
| `[86]` | **""Actually, I'd rather not discuss this with you. You're not exactly impartial on Z..."** | `[41]` **Estela Toras**: ""My whisper networks aren't what..."<br>`[42]` **Estela Toras**: ""I care for Mr. Esquibel dearly,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Estela Toras**: ""Impartiality won't get you anyw..." |
| `[88]` | **""Lespia will help me out. We have an arrangement.""** | `[41]` **Estela Toras**: ""My whisper networks aren't what..."<br>`[42]` **Estela Toras**: ""I care for Mr. Esquibel dearly,..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true` | *Brak zmian stanu* | `[99]` **Estela Toras**: ""Lespia? An odd choice, but I su..." |
| `[91]` | **""He wasn't wrong about keeping power within the Toras family.""** | `[75]` **Estela Toras**: ""You've been talking to your unc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Narrator**: "She flicked a bit of ash from he..." |
| `[92]` | **""He was right. Young people can't be trusted to follow their hearts.""** | `[75]` **Estela Toras**: ""You've been talking to your unc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Narrator**: "She flicked a bit of ash from he..." |
| `[93]` | **""There's a spark between those two, I can tell.""** | `[75]` **Estela Toras**: ""You've been talking to your unc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Estela Toras**: ""There's a spark between me and ..." |
| `[94]` | **""I'm just weighing the possibilities.""** | `[75]` **Estela Toras**: ""You've been talking to your unc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Narrator**: "She flicked a bit of ash from he..." |
| `[111]` | **""I had one more thing I wanted to ask first. About Vina.""** | `[189]` **Estela Toras**: ""I should get some rest. And so ..." | `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false` | *Brak zmian stanu* | `[113]` **Estela Toras**: ""I couldn't possibly comment on ..." |
| `[112]` | **""These things take a while, you know.""** | `[140]` **Estela Toras**: ""Speaking of which, how is that ..."<br>`[144]` **Estela Toras**: ""Speaking of which, how is that ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false` | *Brak zmian stanu* | `[168]` **Estela Toras**: ""I do hope the investigators tur..." |
| `[128]` | **""The supply of suitable, single nobles in Rizia is dwindling. I don't see much of ..."** | `[119]` **Estela Toras**: ""This particular pairing, though..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Estela Toras**: ""In *Rizia*, darling. Have you t..." |
| `[129]` | **""If I have House Toras behind me, I won't need anyone else.""** | `[119]` **Estela Toras**: ""This particular pairing, though..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Estela Toras**: ""You need to be thinking bigger,..." |
| `[130]` | **""Hugo and Rico are powerful men. I'm worried about what they'll do if they don't g..."** | `[119]` **Estela Toras**: ""This particular pairing, though..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Estela Toras**: ""They're powerful within Rizia, ..." |
| `[131]` | **""All I'm saying is, I think they would make cute babies.""** | `[119]` **Estela Toras**: ""This particular pairing, though..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Narrator**: "She wrinkled her nose." |
| `[133]` | **""Has she been writing letters to anyone?""** | `[46]` **Estela Toras**: ""What about our princess?"" | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[134]` **Estela Toras**: ""Possibly. She does spend a lot ..." |
| `[136]` | **""Manus. I knew it.""** | `[135]` **Estela Toras**: ""It's the kind of behavior that ..."<br>`[257]` **Estela Toras**: ""It is, however, something any w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Estela Toras**: ""I can't say I'm surprised. They..." |
| `[152]` | **""Don't call Lucita that.""** | `[144]` **Estela Toras**: ""Speaking of which, how is that ..."<br>`[187]` **Estela Toras**: ""Has that bird of prey on your c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Estela Toras**: ""I meant it as a term of affecti..." |
| `[153]` | **""Don't call Titus that.""** | `[140]` **Estela Toras**: ""Speaking of which, how is that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Estela Toras**: ""I meant it as a term of affecti..." |
| `[157]` | **""Which investigation do you mean?""** | `[140]` **Estela Toras**: ""Speaking of which, how is that ..." | `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true` | *Brak zmian stanu* | `[162]` **Narrator**: "She raised an eyebrow." |
| `[161]` | **""Hopefully Rico's gambit will buy us some time.""** | `[140]` **Estela Toras**: ""Speaking of which, how is that ..."<br>`[144]` **Estela Toras**: ""Speaking of which, how is that ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true` | *Brak zmian stanu* | `[172]` **Estela Toras**: ""I do wish you'd run that by me...." |
| `[164]` | **""The Pales situation has required her full attention.""** | `[144]` **Estela Toras**: ""Speaking of which, how is that ..."<br>`[151]` **Estela Toras**: ""Speaking of which, how is your ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Estela Toras**: ""Do try to keep her in line. The..." |
| `[165]` | **""She's not my lady friend, Mother.""** | `[151]` **Estela Toras**: ""Speaking of which, how is your ..."<br>`[188]` **Estela Toras**: ""Has your new lady friend receiv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Estela Toras**: ""No? It wouldn't be a bad match,..." |
| `[177]` | **""Don't worry. I'll stay on top of her.""** | `[167]` **Estela Toras**: ""Do try to keep her in line. The..."<br>`[176]` **Estela Toras**: ""I hope she hasn't inherited her..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "She raised an eyebrow." |
| `[180]` | **""Pales *is* a real problem, Mother. The situation there could easily spiral out of..."** | `[167]` **Estela Toras**: ""Do try to keep her in line. The..."<br>`[176]` **Estela Toras**: ""I hope she hasn't inherited her..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Estela Toras**: ""Pales is not ours to control in..." |
| `[181]` | **""Mother, could you perhaps envision minding your own damn business for once?""** | `[167]` **Estela Toras**: ""Do try to keep her in line. The..."<br>`[171]` **Estela Toras**: ""She gives you the loyalty of th..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Estela Toras**: ""Right. Who cares what happens t..." |
| `[190]` | **""Don't take that tone with your king.""** | `[189]` **Estela Toras**: ""I should get some rest. And so ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Estela Toras**: ""I do beg your pardon. Your Maje..." |
| `[191]` | **""Wait. I'm sorry. You don't understand the stress I'm under.""** | `[189]` **Estela Toras**: ""I should get some rest. And so ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Narrator**: "Her gaze softened." |
| `[194]` | **""Wait. I had one more thing I wanted to ask. About Vina.""** | `[193]` **Estela Toras**: ""Well. It's about time I got som..." | `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false` | *Brak zmian stanu* | `[46]` **Estela Toras**: ""What about our princess?"" |
| `[196]` | **""Please don't worry about Zille. I promise I'm doing everything I can.""** | `[300]` **Estela Toras**: ""I hope Pabel ironed your pillow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Estela Toras**: ""I'm not worried."" |
| `[197]` | **""Yes, I can see the advantages of such a match. But I haven't made my mind up yet.""** | `[171]` **Estela Toras**: ""She gives you the loyalty of th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Estela Toras**: ""Think about it. She may be past..." |
| `[198]` | **""She's my councilor. It wouldn't be right.""** | `[171]` **Estela Toras**: ""She gives you the loyalty of th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Estela Toras**: ""Your *interim* councilor, if I ..." |
| `[201]` | **""Wish me luck for tomorrow.""** | `[300]` **Estela Toras**: ""I hope Pabel ironed your pillow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Estela Toras**: ""I know you won't need it."" |
| `[205]` | **""Remember how I told you Pabel thinks Father was murdered? Titus is investigating ..."** | `[163]` **Estela Toras**: ""There's more than one?"" | `Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] == true` | *Brak zmian stanu* | `[208]` **Estela Toras**: ""Oh."" |
| `[206]` | **""No. Sorry, I got confused.""** | `[163]` **Estela Toras**: ""There's more than one?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Estela Toras**: ""At any rate, I hope his investi..." |
| `[207]` | **""Pabel thinks Father might have been murdered. I told Titus to investigate that.""** | `[163]` **Estela Toras**: ""There's more than one?"" | `(Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] == true) == false` | *Brak zmian stanu* | `[208]` **Estela Toras**: ""Oh."" |
| `[209]` | **""If someone killed Father, I might be next.""** | `[394]` **Estela Toras**: ""Darling, sometimes a heart atta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Estela Toras**: ""Hmm. You're starting to sound j..." |
| `[210]` | **""Even if Pabel was wrong about the murder, I'll have gathered some useful intel.""** | `[394]` **Estela Toras**: ""Darling, sometimes a heart atta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Estela Toras**: ""I should hope I'm not on the li..." |
| `[217]` | **""Sleep well, Mother.""** | `[189]` **Estela Toras**: ""I should get some rest. And so ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Estela Toras**: ""Good night, Your Majesty."" |
| `[221]` | **""Maybe not, but I've already assigned him the task. I've got to see it through.""** | `[394]` **Estela Toras**: ""Darling, sometimes a heart atta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Estela Toras**: ""I should hope I'm not on the li..." |
| `[222]` | **""Thanks for all your advice.""** | `[300]` **Estela Toras**: ""I hope Pabel ironed your pillow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Estela Toras**: ""What's a mother for?"" |
| `[227]` | **""Lyza was weak. I know how to control my own daughter.""** | `[78]` **Estela Toras**: ""Next thing you know, she's thro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Estela Toras**: ""No force in this world is as un..." |
| `[228]` | **""Then what do I do? I don't want him infecting her with his dangerous ideas.""** | `[78]` **Estela Toras**: ""Next thing you know, she's thro..." | `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true` | *Brak zmian stanu* | `[231]` **Narrator**: "She cast a sidelong glance at me."<br>`[252]` **Narrator**: "She cast a sidelong glance at me." |
| `[229]` | **""Thank God. She's warmed up to Rico after all.""** | `[135]` **Estela Toras**: ""It's the kind of behavior that ..."<br>`[257]` **Estela Toras**: ""It is, however, something any w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "She snorted." |
| `[235]` | **""I actually like the kid. But he doesn't seem like marriage material to me.""** | `[78]` **Estela Toras**: ""Next thing you know, she's thro..." | `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false` | *Brak zmian stanu* | `[236]` **Narrator**: "She cast a sidelong glance at me." |
| `[239]` | **""The Sazons aren't as dangerous as you think. I'm looking to collaborate more clos..."** | `[139]` **Estela Toras**: ""It's up to you whether Vina's h..." | `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true` | *Brak zmian stanu* | `[269]` **Estela Toras**: ""In that case, Vina might be use..." |
| `[243]` | **""Of course it is, Mother. How could you even ask that?""** | `[139]` **Estela Toras**: ""It's up to you whether Vina's h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Estela Toras**: ""Then you'll have to find a way ..." |
| `[244]` | **""I'd be fine with it if it were true love. But I'm worried he's using her.""** | `[139]` **Estela Toras**: ""It's up to you whether Vina's h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Estela Toras**: ""We're all using each other, are..." |
| `[246]` | **""It might help neutralize the Sazon threat, actually. Manus' 'man of the people' a..."** | `[139]` **Estela Toras**: ""It's up to you whether Vina's h..." | `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false` | *Brak zmian stanu* | `[270]` **Estela Toras**: ""Yes, there are ways to make thi..." |
| `[247]` | **""You said yourself I shouldn't forbid her from seeing him. What other choice do I ..."** | `[139]` **Estela Toras**: ""It's up to you whether Vina's h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Estela Toras**: ""The way I see it..."" |
| `[260]` | **""That, too.""** | `[230]` **Estela Toras**: ""Are you sure it's not the oppos..."<br>`[253]` **Estela Toras**: ""I should think you'd be more wo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Estela Toras**: ""The way I see it..."" |
| `[261]` | **""Whatever. There must be some way we can stop this.""** | `[230]` **Estela Toras**: ""Are you sure it's not the oppos..."<br>`[238]` **Estela Toras**: ""No force in this world is as un..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Estela Toras**: ""The way I see it..."" |
| `[262]` | **""What do you mean?""** | `[230]` **Estela Toras**: ""Are you sure it's not the oppos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Estela Toras**: ""Nothing. Just wondering if she ..." |
| `[263]` | **""That's nonsense. She can't even hold a gun.""** | `[238]` **Estela Toras**: ""No force in this world is as un..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Estela Toras**: ""Love has toppled more empires t..." |
| `[265]` | **""If I can't control her, what can I do?""** | `[238]` **Estela Toras**: ""No force in this world is as un..."<br>`[253]` **Estela Toras**: ""I should think you'd be more wo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Estela Toras**: ""The way I see it..."" |
| `[274]` | **""I can't count on that, unfortunately.""** | `[259]` **Estela Toras**: ""You could use the pairing to ke..." | `Variable["RiziaDLC.Relations_Vina"] < 0` | *Brak zmian stanu* | `[279]` **Estela Toras**: ""Or there's one other thing you ..." |
| `[275]` | **""Of course she trusts me.""** | `[259]` **Estela Toras**: ""You could use the pairing to ke..." | `(Variable["RiziaDLC.Relations_Vina"] < 0) == false` | *Brak zmian stanu* | `[279]` **Estela Toras**: ""Or there's one other thing you ..." |
| `[276]` | **""That's not a bad idea.""** | `[259]` **Estela Toras**: ""You could use the pairing to ke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Estela Toras**: ""Or there's one other thing you ..." |
| `[277]` | **""No, no. She's my daughter, not a spy.""** | `[259]` **Estela Toras**: ""You could use the pairing to ke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Estela Toras**: ""Or there's one other thing you ..." |
| `[280]` | **""A diplomatic mission, perhaps? Distract Vina and improve our international standi..."** | `[267]` **Estela Toras**: ""You send the princess on a nice..."<br>`[295]` **Estela Toras**: ""It would put a stop to the rumo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Estela Toras**: ""And if she meets some dashing f..." |
| `[284]` | **""I can't do that. She's a valuable member of my council.""** | `[267]` **Estela Toras**: ""You send the princess on a nice..."<br>`[295]` **Estela Toras**: ""It would put a stop to the rumo..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | *Brak zmian stanu* | `[289]` **Estela Toras**: ""It's just a thought. Feel free ..." |
| `[285]` | **""Hmm. She's been cramping my style on the council, it's true.""** | `[267]` **Estela Toras**: ""You send the princess on a nice..."<br>`[295]` **Estela Toras**: ""It would put a stop to the rumo..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | *Brak zmian stanu* | `[290]` **Estela Toras**: ""And if she meets some dashing f..." |
| `[286]` | **""She'd find that a lot more stimulating than etiquette classes, I'm sure.""** | `[267]` **Estela Toras**: ""You send the princess on a nice..."<br>`[295]` **Estela Toras**: ""It would put a stop to the rumo..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[290]` **Estela Toras**: ""And if she meets some dashing f..." |
| `[287]` | **""I'm not ready to let go of her. She's the last tie to Lena I have left.""** | `[267]` **Estela Toras**: ""You send the princess on a nice..."<br>`[296]` **Estela Toras**: ""She's old enough to experience ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Estela Toras**: ""You could always invite her hig..." |
| `[299]` | **""Yes, me too.""** | `[193]` **Estela Toras**: ""Well. It's about time I got som..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Estela Toras**: ""I hope Pabel ironed your pillow..." |
| `[301]` | **""Same here.""** | `[298]` **Estela Toras**: ""And with that, it's time to tur..."<br>`[314]` **Estela Toras**: ""It's late, isn't it? Time to tu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Narrator**: "I wished her goodnight and left ..." |
| `[308]` | **""I'll deal with that when the moment arrives. I've got enough to think about for t..."** | `[297]` **Estela Toras**: ""Speaking of foreign affairs, ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Estela Toras**: ""It's late, isn't it? Time to tu..." |
| `[309]` | **""Wish me luck for tomorrow.""** | `[298]` **Estela Toras**: ""And with that, it's time to tur..."<br>`[314]` **Estela Toras**: ""It's late, isn't it? Time to tu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Estela Toras**: ""I know you won't need it."" |
| `[310]` | **""Thanks for all your advice.""** | `[298]` **Estela Toras**: ""And with that, it's time to tur..."<br>`[314]` **Estela Toras**: ""It's late, isn't it? Time to tu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Estela Toras**: ""What's a mother for?"" |
| `[313]` | **""Don't worry about Vina. I know what to do.""** | `[298]` **Estela Toras**: ""And with that, it's time to tur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Estela Toras**: ""You're her father *and* the kin..." |
| `[328]` | **""Shoo! Bad dog!""** | `[380]` **Bruno**: ""Hrr?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Narrator**: "Bruno reluctantly hopped off the..." |
| `[329]` | **""Get a move on, boy. The King needs his rest.""** | `[380]` **Bruno**: ""Hrr?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Narrator**: "Bruno reluctantly hopped off the..." |
| `[330]` | **""All right. You can sleep here tonight, but don't get too used to it.""** | `[380]` **Bruno**: ""Hrr?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Narrator**: "Bruno curled up at my feet as I ..." |
| `[341]` | **""Thank you for your concern. But I have it all under control.""** | `[173]` **Estela Toras**: ""Nothing to be done about it now..."<br>`[174]` **Estela Toras**: ""I shudder to think of what migh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Estela Toras**: ""If you say so."" |
| `[343]` | **""If this doesn't work, we'll try something else. But Zille *will* be ours.""** | `[173]` **Estela Toras**: ""Nothing to be done about it now..."<br>`[174]` **Estela Toras**: ""I shudder to think of what migh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Estela Toras**: ""Yes, I know. Excuse my impatien..." |
| `[348]` | **""Of course I am. Wehlen must be forced to honor the Zille handover deadline.""** | `[347]` **Estela Toras**: ""You are planning on addressing ..."<br>`[297]` **Estela Toras**: ""Speaking of foreign affairs, ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Estela Toras**: ""That's the pachyderm in questio..." |
| `[349]` | **""Certainly. This naval standoff with Pales must end one way or another.""** | `[347]` **Estela Toras**: ""You are planning on addressing ..."<br>`[297]` **Estela Toras**: ""Speaking of foreign affairs, ar..." | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true` | *Brak zmian stanu* | `[85]` **Estela Toras**: ""I was referring to Zille, my de..." |
| `[354]` | **""Yes, the arbitration committee should have come to a decision already. Our claim ..."** | `[347]` **Estela Toras**: ""You are planning on addressing ..."<br>`[297]` **Estela Toras**: ""Speaking of foreign affairs, ar..." | `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true` | *Brak zmian stanu* | `[85]` **Estela Toras**: ""I was referring to Zille, my de..." |
| `[358]` | **""Which elephant? There are so many.""** | `[347]` **Estela Toras**: ""You are planning on addressing ..."<br>`[297]` **Estela Toras**: ""Speaking of foreign affairs, ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Estela Toras**: ""A wonder that you world leaders..." |
| `[361]` | **""There is no elephant. I've neutralized the Pales situation for now.""** | `[347]` **Estela Toras**: ""You are planning on addressing ..."<br>`[297]` **Estela Toras**: ""Speaking of foreign affairs, ar..." | `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false` | *Brak zmian stanu* | `[362]` **Estela Toras**: ""Have you so quickly forgotten? ..." |
| `[363]` | **""Duchess Azaro has a level head. She won't drag us into conflict without reason.""** | `[167]` **Estela Toras**: ""Do try to keep her in line. The..."<br>`[171]` **Estela Toras**: ""She gives you the loyalty of th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Estela Toras**: ""Oh, there's always a reason."" |
| `[368]` | **""You were working as a waitress in a cocktail bar.""** | `[76]` **Estela Toras**: ""You know how your father and I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Estela Toras**: ""That much is true."" |
| `[369]` | **""You used your feminine wiles to entrap him.""** | `[76]` **Estela Toras**: ""You know how your father and I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Estela Toras**: ""Hardly."" |
| `[371]` | **""I was always confused about that. Why did Lyza allow Father to date a commoner?""** | `[76]` **Estela Toras**: ""You know how your father and I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Estela Toras**: ""She didn't, at first. But the m..." |
| `[376]` | **""Everything worked out in the end, though, didn't it?""** | `[78]` **Estela Toras**: ""Next thing you know, she's thro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Estela Toras**: ""If you call seriously undermini..." |
| `[395]` | **""What are you talking about?""** | `[6]` **Narrator**: "I looked in. My mother was stand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Narrator**: "She looked startled for a moment..." |

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
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was the night before my trip to Kyrute for the Alliance of Nations meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I had just finished some last-minute preparations in my s..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I had just finished some last-minute preparations in my study. I carefully made my way back towards the palace's residential wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "It was later than I realized. The halls were dead silent,..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I reached the top floor. Across the hall from my bedchamber, the Queen Mother's door was open a crack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I looked in. My mother was standing out on her balcony, h..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I looked in. My mother was standing out on her balcony, her back turned towards me. I heard her whispering softly to herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "Tap her on the shoulder."]** — Mówca: **Player_Romus_Italic**
> "I tapped her on the shoulder. She looked startled for a moment, then smiled."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Estela Toras: ""You shouldn't sneak up on an old woman like that.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't sleep?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "She looked startled for a moment, then smiled."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good evening, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "She looked startled for a moment, then smiled."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Grand Wiseman Ignacius' quarters were on the ground floor. I saw light coming out of the keyhole."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus_Italic: "Peer in."*)
  - -> `[12]` (*Player_Romus_Italic: "Keep walking."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Peer in."]** — Mówca: **Player_Romus_Italic**
> "I carefully bent down and looked inside. Sal was rocking back and forth in his armchair, his eyes closed. He seemed to be mouthing a prayer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Just before the stairs was the entrance to Vina's room. T..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Keep walking."]** — Mówca: **Player_Romus_Italic**
> "I proceeded towards the end of the hall."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Just before the stairs was the entrance to Vina's room. T..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Just before the stairs was the entrance to Vina's room. Through the door, I caught the faint strains of her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus_Italic: "Press your ear against the door."*)
  - -> `[22]` (*Player_Romus_Italic: "Keep walking."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "Press your ear against the door."]** — Mówca: **Player_Romus_Italic**
> "I pressed my ear against the door in order to hear better."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "AddConversant("Vina Toras");"*)

### Węzeł `[15]`
Mówca: **Vina Toras**
> ""Yes, I agree. It seems like an adequate compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Vina Toras: ""Well, tell the others not to push for too much too quick..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[19]`
Mówca: **Vina Toras**
> ""...No, he hasn't written back yet. Who knows if he's even read it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Vina Toras: ""What, are you mad? Of course Father doesn't know anythin..."*)

### Węzeł `[20]`
Mówca: **Vina Toras**
> ""What, are you mad? Of course Father doesn't know anything about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Vina Toras: ""...Yes, my love. We'll speak very soon.""*)

### Węzeł `[21]`
Mówca: **Vina Toras**
> ""...Yes, my love. We'll speak very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Keep walking."]** — Mówca: **Player_Romus_Italic**
> "I passed Vina's door and walked up the stairs."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I reached the top floor. Across the hall from my bedchamb..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "There was a clunk as she hung up the phone. I moved away from the door and kept walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I reached the top floor. Across the hall from my bedchamb..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "She looked startled for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Estela Toras: ""Don't worry about me, darling. You should be resting you..."*)

### Węzeł `[25]`
Mówca: **Estela Toras**
> ""Don't worry about me, darling. You should be resting yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "She lit a cigarette and blew smoke out into the gardens."*)

### Węzeł `[26]`
Mówca: **Estela Toras**
> ""All set for tomorrow?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""Of course I am. The Alliance of Nations won't know what ..."*)
  - -> `[32]` (*Player_Romus: ""Did Father tell you anything about these AN sessions?""*)
  - -> `[33]` (*Player_Romus: ""Not really. Diplomacy isn't exactly my forte.""*)
  - -> `[31]` (*Player_Romus: ""Sure. Can I ask you something about Vina?""*)

### Węzeł `[27]`
Mówca: **Estela Toras**
> ""You shouldn't sneak up on an old woman like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Estela Toras: ""*Especially* after what we've both been through.""*)

### Węzeł `[28]`
Mówca: **Narrator**
> "She looked startled for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Estela Toras: ""I'm surprised you're still up. You have a long day ahead..."*)

### Węzeł `[29]`
Mówca: **Estela Toras**
> ""I'm surprised you're still up. You have a long day ahead of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "She lit a cigarette and blew smoke out into the gardens."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I am. The Alliance of Nations won't know what hit it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Estela Toras: ""That's my boy.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure. Can I ask you something about Vina?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Estela Toras: ""What about our princess?""*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did Father tell you anything about these AN sessions?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Estela Toras: ""Oh, you know he was no diplomat.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not really. Diplomacy isn't exactly my forte.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Estela Toras: ""There's nothing to it. Just stand up straight, smile, pr..."*)

### Węzeł `[34]`
Mówca: **Estela Toras**
> ""That's my boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Estela Toras: ""You are planning on addressing the elephant in the chamb..."*)

### Węzeł `[35]`
Mówca: **Estela Toras**
> ""We need our land back. No matter what kind of announcement Wiktor Smolak has up his sleeve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""Enough is enough. He will pay for his disrespect.""*)
  - -> `[43]` (*Player_Romus: ""I don't want a confrontation. Our countries are on the s..."*)
  - -> `[40]` (*Player_Romus: ""How do you know he's going to make an announcement?""*)

### Węzeł `[36]`
Mówca: **Estela Toras**
> ""There's nothing to it. Just stand up straight, smile, preach unity and cooperation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Estela Toras: ""And then stab the bastards in the back when they least e..."*)

### Węzeł `[37]`
Mówca: **Estela Toras**
> ""Oh, you know he was no diplomat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Estela Toras: ""In fact, I'm not sure he even attended after the Zille a..."*)

### Węzeł `[38]`
Mówca: **Estela Toras**
> ""In fact, I'm not sure he even attended after the Zille agreement. Poor Mr. Esquibel went alone in his stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Estela Toras: ""You are planning on addressing the elephant in the chamb..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough is enough. He will pay for his disrespect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Estela Toras: ""I care for Mr. Esquibel dearly, but he has given Wehlen ..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you know he's going to make an announcement?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Estela Toras: ""My whisper networks aren't what they used to be. But wiv..."*)

### Węzeł `[41]`
Mówca: **Estela Toras**
> ""My whisper networks aren't what they used to be. But wives still talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""It's all fine. I've got a plan.""*)
  - -> `[84]` (*Player_Romus: ""Any advice for how to act, then?""*)
  - -> `[86]` (*Player_Romus: ""Actually, I'd rather not discuss this with you. You're n..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_WehlenHelp == true"*)

### Węzeł `[42]`
Mówca: **Estela Toras**
> ""I care for Mr. Esquibel dearly, but he has given Wehlen the benefit of the doubt for too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""It's all fine. I've got a plan.""*)
  - -> `[84]` (*Player_Romus: ""Any advice for how to act, then?""*)
  - -> `[86]` (*Player_Romus: ""Actually, I'd rather not discuss this with you. You're n..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_WehlenHelp == true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want a confrontation. Our countries are on the same side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Estela Toras: ""Oh, Romus. You still believe that?""*)

### Węzeł `[44]`
Mówca: **Estela Toras**
> ""Oh, Romus. You still believe that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""It's all fine. I've got a plan.""*)
  - -> `[84]` (*Player_Romus: ""Any advice for how to act, then?""*)
  - -> `[86]` (*Player_Romus: ""Actually, I'd rather not discuss this with you. You're n..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_WehlenHelp == true"*)

### Węzeł `[45]`
Mówca: **Estela Toras**
> ""And then stab the bastards in the back when they least expect it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Estela Toras: ""You are planning on addressing the elephant in the chamb..."*)

### Węzeł `[46]`
Mówca: **Estela Toras**
> ""What about our princess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[62]` (*Player_Romus: ""Has she told you whether she's seeing someone?""*)
  - -> `[63]` (*Player_Romus: ""Would it be crazy if I married her off to Rico?""*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What has she been doing while I'm at my council meetings?"
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Estela Toras: ""Besides her etiquette classes, I haven't the faintest. S..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Romus: ""Did she get up to anything while I was in Pales?"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""What has she been doing while I'm at my council meetings?"*)
  - -> `[133]` (*Player_Romus: ""Has she been writing letters to anyone?""*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did she get up to anything while I was in Pales?"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Estela Toras: ""As far as I could tell, she spent a lot of time holed up..."*)

### Węzeł `[52]`
Mówca: **Estela Toras**
> ""Besides her etiquette classes, I haven't the faintest. She spends a lot of time holed up in her room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Vina Toras: ""Yes, I agree. It seems like an adequate compromise.""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Vina Toras: ""Oh, don't be so blue. Honestly, what were you expecting?""*)

### Węzeł `[56]`
Mówca: **Vina Toras**
> ""No, I won't talk to him. He's in Kyrute the next few days anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Vina Toras: ""...Yes, my love. We'll speak very soon.""*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Vina Toras: ""Yes, I know. I was surprised too.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)

### Węzeł `[60]`
Mówca: **Vina Toras**
> ""Oh, don't be so blue. Honestly, what were you expecting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Vina Toras: ""No, I won't talk to him. He's in Kyrute the next few day..."*)

### Węzeł `[61]`
Mówca: **Vina Toras**
> ""Yes, I know. I was surprised too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Vina Toras: ""Well, tell the others not to push for too much too quick..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Has she told you whether she's seeing someone?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Estela Toras: ""That isn't the sort of information a young lady shares w..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would it be crazy if I married her off to Rico?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "She snorted."*)

### Węzeł `[64]`
Mówca: **Estela Toras**
> ""Although of course I've heard the same rumors you have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""It's all just talk. I don't know what's actually happeni..."*)
  - -> `[67]` (*Player_Romus: ""I think they're more than just rumors.""*)
  - -> `[68]` (*Player_Romus: ""What rumors?""*)

### Węzeł `[65]`
Mówca: **Estela Toras**
> ""As far as I could tell, she spent a lot of time holed up in her room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all just talk. I don't know what's actually happening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Estela Toras: ""Come, dear. Did you really think one dance in Sallabes w..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think they're more than just rumors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Estela Toras: ""Then you have a relationship to approve of. Or not.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What rumors?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Estela Toras: ""Come, dear. Did you really think one dance in Sallabes w..."*)

### Węzeł `[69]`
Mówca: **Estela Toras**
> ""Then you have a relationship to approve of. Or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "She flicked a bit of ash from her cigarette off the balcony."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "She flicked a bit of ash from her cigarette off the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Estela Toras: ""I'll tell you this much. The last thing you want to do i..."*)

### Węzeł `[71]`
Mówca: **Estela Toras**
> ""I'll tell you this much. The last thing you want to do is forbid her from seeing him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""I am the king. If I order her not to see him, she'll hav..."*)
  - -> `[80]` (*Player_Romus: ""I know that. I'm not stupid.""*)
  - -> `[79]` (*Player_Romus: ""Who said anything about forbidding? I *want* them to get..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true"*)

### Węzeł `[72]`
Mówca: **Estela Toras**
> ""Come, dear. Did you really think one dance in Sallabes would be enough for those two?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "She flicked a bit of ash from her cigarette off the balcony."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the king. If I order her not to see him, she'll have to obey.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "She snorted."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "She snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Estela Toras: ""You've been talking to your uncle, I see.""*)

### Węzeł `[75]`
Mówca: **Estela Toras**
> ""You've been talking to your uncle, I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""He was right. Young people can't be trusted to follow th..."*)
  - -> `[91]` (*Player_Romus: ""He wasn't wrong about keeping power within the Toras fam..."*)
  - -> `[93]` (*Player_Romus: ""There's a spark between those two, I can tell.""*)
  - -> `[94]` (*Player_Romus: ""I'm just weighing the possibilities.""*)

### Węzeł `[76]`
Mówca: **Estela Toras**
> ""You know how your father and I met, don't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Player_Romus: ""You were working as a waitress in a cocktail bar.""*)
  - -> `[369]` (*Player_Romus: ""You used your feminine wiles to entrap him.""*)
  - -> `[371]` (*Player_Romus: ""I was always confused about that. Why did Lyza allow Fat..."*)

### Węzeł `[77]`
Mówca: **Estela Toras**
> ""That much is true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Estela Toras: ""It was only supposed to be a fling, at first. But when L..."*)

### Węzeł `[78]`
Mówca: **Estela Toras**
> ""Next thing you know, she's throwing all of her influence at the Council to persuade them that a fisherman's daughter is a suitable match for a prince.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[376]` (*Player_Romus: ""Everything worked out in the end, though, didn't it?""*)
  - -> `[227]` (*Player_Romus: ""Lyza was weak. I know how to control my own daughter.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who said anything about forbidding? I *want* them to get together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Estela Toras: ""After everything the Sazons did to you? To us?""*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that. I'm not stupid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Estela Toras: ""Don't forget what happened when Lyza the Great tried to ..."*)

### Węzeł `[81]`
Mówca: **Estela Toras**
> ""After everything the Sazons did to you? To us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "She cast a sidelong glance at me."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never do that. She's allowed to love whomever she wants.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Kontekst wejściowy (poprzednik):** `[71]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Estela Toras: ""But... after everything the Sazons did to you? To us?""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all fine. I've got a plan.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Estela Toras), `[42]` (Estela Toras), `[44]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Estela Toras: ""You always do.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any advice for how to act, then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Estela Toras), `[42]` (Estela Toras), `[44]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Estela Toras: ""I say don't stoop to his level. Make him look like the t..."*)

### Węzeł `[85]`
Mówca: **Estela Toras**
> ""I was referring to Zille, my dear. Or have you forgotten that the handover deadline is imminent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Estela Toras: ""We need our land back. No matter what kind of announceme..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I'd rather not discuss this with you. You're not exactly impartial on Zille.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Estela Toras), `[42]` (Estela Toras), `[44]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Estela Toras: ""Impartiality won't get you anywhere with Wehlen.""*)

### Węzeł `[87]`
Mówca: **Estela Toras**
> ""Impartiality won't get you anywhere with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia will help me out. We have an arrangement.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true`
- **Kontekst wejściowy (poprzednik):** `[41]` (Estela Toras), `[42]` (Estela Toras), `[44]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Estela Toras: ""Lespia? An odd choice, but I suppose you know best.""*)

### Węzeł `[89]`
Mówca: **Estela Toras**
> ""I say don't stoop to his level. Make him look like the tyrant he is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[90]`
Mówca: **Estela Toras**
> ""You always do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wasn't wrong about keeping power within the Toras family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "She flicked a bit of ash from her cigarette off the balcony."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was right. Young people can't be trusted to follow their hearts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "She flicked a bit of ash from her cigarette off the balcony."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's a spark between those two, I can tell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Estela Toras: ""There's a spark between me and my doorknob when I wear w..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just weighing the possibilities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "She flicked a bit of ash from her cigarette off the balcony."*)

### Węzeł `[95]`
Mówca: **Estela Toras**
> ""*Especially* after what we've both been through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "She lit a cigarette and blew smoke out into the gardens."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_WehlenHelp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_WehlenHelp == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_WehlenHelp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""Lespia will help me out. We have an arrangement.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
Mówca: **Estela Toras**
> ""Lespia? An odd choice, but I suppose you know best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[100]`
Mówca: **Narrator**
> "It was later than I realized. The halls were dead silent, illuminated only by weak shafts of moonlight through the windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Grand Wiseman Ignacius' quarters were on the ground floor..."*)

### Węzeł `[101]`
Mówca: **Estela Toras**
> ""There's a spark between me and my doorknob when I wear woolen slippers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "She flicked a bit of ash from her cigarette off the balcony."*)

### Węzeł `[102]`
Mówca: **Estela Toras**
> ""Royal marriages are a balancing act, my dear. You can satisfy the betrotheds or the country, but almost never both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == t..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""I would never do that. She's allowed to love whomever sh..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Estela Toras: ""*Almost*. You were lucky for a while, Romus.""*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Estela Toras: ""And it's hard to tell which compromise creates more mise..."*)

### Węzeł `[109]`
Mówca: **Estela Toras**
> ""*Almost*. You were lucky for a while, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Estela Toras: ""This particular match would satisfy your daughter very m..."*)

### Węzeł `[110]`
Mówca: **Estela Toras**
> ""And it's hard to tell which compromise creates more misery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Estela Toras: ""This particular match would satisfy your daughter very m..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had one more thing I wanted to ask first. About Vina.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false`
- **Kontekst wejściowy (poprzednik):** `[189]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Estela Toras: ""I couldn't possibly comment on your daughter's affairs. ..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These things take a while, you know.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[140]` (Estela Toras), `[144]` (Estela Toras), `[151]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Estela Toras: ""I do hope the investigators turn up something we can use.""*)

### Węzeł `[113]`
Mówca: **Estela Toras**
> ""I couldn't possibly comment on your daughter's affairs. No matter how much gossip is circulating about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "There was a chill in her voice now."*)

### Węzeł `[114]`
Mówca: **Estela Toras**
> ""It's a balancing act, my dear. When it comes to royal marriages, you can satisfy the betrotheds or the country, but almost never both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "She smiled sadly."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Estela Toras: ""*Almost*. You were lucky for a while, Romus.""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Estela Toras: ""And it's hard to tell which compromise creates more mise..."*)

### Węzeł `[118]`
Mówca: **Estela Toras**
> ""*Almost*. You were lucky for a while, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Estela Toras: ""This particular pairing, though, would satisfy House Tor..."*)

### Węzeł `[119]`
Mówca: **Estela Toras**
> ""This particular pairing, though, would satisfy House Toras and no one else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player_Romus: ""The supply of suitable, single nobles in Rizia is dwindl..."*)
  - -> `[129]` (*Player_Romus: ""If I have House Toras behind me, I won't need anyone else.""*)
  - -> `[130]` (*Player_Romus: ""Hugo and Rico are powerful men. I'm worried about what t..."*)
  - -> `[131]` (*Player_Romus: ""All I'm saying is, I think they would make cute babies.""*)

### Węzeł `[120]`
Mówca: **Estela Toras**
> ""And it's hard to tell which compromise creates more misery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Estela Toras: ""This particular pairing, though, would satisfy House Tor..."*)

### Węzeł `[121]`
Mówca: **Estela Toras**
> ""That isn't the sort of information a young lady shares with her grandmother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Estela Toras: ""Although of course I've heard the same rumors you have.""*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Estela Toras: ""It's the kind of behavior that might make one think she ..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "She flicked a bit of ash from her cigarette off the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Estela Toras: ""It's a balancing act, my dear. When it comes to royal ma..."*)

### Węzeł `[126]`
Mówca: **Estela Toras**
> ""In *Rizia*, darling. Have you truly never considered looking to foreign shores?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Estela Toras: ""You want my advice? It's high time the Princess took a n..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "She smiled sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The supply of suitable, single nobles in Rizia is dwindling. I don't see much of a choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Estela Toras: ""In *Rizia*, darling. Have you truly never considered loo..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I have House Toras behind me, I won't need anyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Estela Toras: ""You need to be thinking bigger, my love. We Torases are ..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo and Rico are powerful men. I'm worried about what they'll do if they don't get their way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Estela Toras: ""They're powerful within Rizia, but minor players on the ..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All I'm saying is, I think they would make cute babies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "She wrinkled her nose."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "She wrinkled her nose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Estela Toras: ""You want my advice? It's high time the Princess took a n..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Has she been writing letters to anyone?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Estela Toras: ""Possibly. She does spend a lot of time holed up in her r..."*)

### Węzeł `[134]`
Mówca: **Estela Toras**
> ""Possibly. She does spend a lot of time holed up in her room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[135]`
Mówca: **Estela Toras**
> ""It's the kind of behavior that might make one think she had a new lover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Manus. I knew it.""*)
  - -> `[229]` (*Player_Romus: ""Thank God. She's warmed up to Rico after all.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Manus. I knew it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Estela Toras), `[257]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Estela Toras: ""I can't say I'm surprised. They're both quite good-looki..."*)

### Węzeł `[137]`
Mówca: **Estela Toras**
> ""I can't say I'm surprised. They're both quite good-looking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "She flicked a bit of ash from her cigarette off the balcony."*)

### Węzeł `[138]`
Mówca: **Estela Toras**
> ""This particular match would satisfy your daughter very much. It would also put House Sazon dangerously close to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Estela Toras: ""It's up to you whether Vina's happiness is worth that.""*)

### Węzeł `[139]`
Mówca: **Estela Toras**
> ""It's up to you whether Vina's happiness is worth that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Romus: ""Of course it is, Mother. How could you even ask that?""*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC...."*)
  - -> `[244]` (*Player_Romus: ""I'd be fine with it if it were true love. But I'm worrie..."*)
  - -> `[247]` (*Player_Romus: ""You said yourself I shouldn't forbid her from seeing him..."*)

### Węzeł `[140]`
Mówca: **Estela Toras**
> ""Speaking of which, how is that muscle-bound lunk of yours proceeding with his investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""Don't call Titus that.""*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Estela Toras: ""Speaking of which, how is that muscle-bound lunk of your..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[144]`
Mówca: **Estela Toras**
> ""Speaking of which, how is that bird of prey on your council proceeding with her investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)
  - -> `[152]` (*Player_Romus: ""Don't call Lucita that.""*)
  - -> `[164]` (*Player_Romus: ""The Pales situation has required her full attention.""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto == true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_CompromisingPhoto == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Estela Toras: ""Speaking of which, how is your lady friend proceeding wi..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_CompromisingPhoto == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Estela Toras: ""Speaking of which, how is that bird of prey on your coun..."*)

### Węzeł `[151]`
Mówca: **Estela Toras**
> ""Speaking of which, how is your lady friend proceeding with her investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)
  - -> `[164]` (*Player_Romus: ""The Pales situation has required her full attention.""*)
  - -> `[165]` (*Player_Romus: ""She's not my lady friend, Mother.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't call Lucita that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Estela Toras), `[187]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Estela Toras: ""I meant it as a term of affection. She's got a beautiful..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't call Titus that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Estela Toras: ""I meant it as a term of affection. You know I adore that..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Titus == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: ""Which investigation do you mean?""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which investigation do you mean?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Kontekst wejściowy (poprzednik):** `[140]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "She raised an eyebrow."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""Hopefully Rico's gambit will buy us some time.""*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""These things take a while, you know.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hopefully Rico's gambit will buy us some time.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Kontekst wejściowy (poprzednik):** `[140]` (Estela Toras), `[144]` (Estela Toras), `[151]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Estela Toras: ""I do wish you'd run that by me. If Wehlen finds out we i..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "She raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Estela Toras: ""There's more than one?""*)

### Węzeł `[163]`
Mówca: **Estela Toras**
> ""There's more than one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Estela_TellAboutMurderCase == true"*)
  - -> `[206]` (*Player_Romus: ""No. Sorry, I got confused.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Pales situation has required her full attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Estela Toras), `[151]` (Estela Toras), `[187]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Estela Toras: ""Do try to keep her in line. The Azaros getting too mixed..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's not my lady friend, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Estela Toras), `[188]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Estela Toras: ""No? It wouldn't be a bad match, if you ask me.""*)

### Węzeł `[166]`
Mówca: **Estela Toras**
> ""No? It wouldn't be a bad match, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Estela Toras: ""She gives you the loyalty of the Azaros, you help curb t..."*)

### Węzeł `[167]`
Mówca: **Estela Toras**
> ""Do try to keep her in line. The Azaros getting too mixed up with Pales is what lost us Zille in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player_Romus: ""Don't worry. I'll stay on top of her.""*)
  - -> `[180]` (*Player_Romus: ""Pales *is* a real problem, Mother. The situation there c..."*)
  - -> `[181]` (*Player_Romus: ""Mother, could you perhaps envision minding your own damn..."*)
  - -> `[363]` (*Player_Romus: ""Duchess Azaro has a level head. She won't drag us into c..."*)

### Węzeł `[168]`
Mówca: **Estela Toras**
> ""I do hope the investigators turn up something we can use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Estela Toras: ""I shudder to think of what might happen if the handover ..."*)

### Węzeł `[169]`
Mówca: **Estela Toras**
> ""I meant it as a term of affection. You know I adore that man and his muscles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Estela Toras: ""At any rate, I hope his investigators turn up something ..."*)

### Węzeł `[170]`
Mówca: **Estela Toras**
> ""At any rate, I hope his investigators turn up something we can use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Estela Toras: ""I shudder to think of what might happen if the handover ..."*)

### Węzeł `[171]`
Mówca: **Estela Toras**
> ""She gives you the loyalty of the Azaros, you help curb that legendary Azaro temper...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus: ""Yes, I can see the advantages of such a match. But I hav..."*)
  - -> `[181]` (*Player_Romus: ""Mother, could you perhaps envision minding your own damn..."*)
  - -> `[198]` (*Player_Romus: ""She's my councilor. It wouldn't be right.""*)
  - -> `[363]` (*Player_Romus: ""Duchess Azaro has a level head. She won't drag us into c..."*)

### Węzeł `[172]`
Mówca: **Estela Toras**
> ""I do wish you'd run that by me. If Wehlen finds out we intentionally gave them the wrong suspects, it could blow up in our faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Estela Toras: ""Nothing to be done about it now, anyway.""*)

### Węzeł `[173]`
Mówca: **Estela Toras**
> ""Nothing to be done about it now, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player_Romus: ""If this doesn't work, we'll try something else. But Zill..."*)
  - -> `[341]` (*Player_Romus: ""Thank you for your concern. But I have it all under cont..."*)
  - -> `[181]` (*Player_Romus: ""Mother, could you perhaps envision minding your own damn..."*)

### Węzeł `[174]`
Mówca: **Estela Toras**
> ""I shudder to think of what might happen if the handover deadline arrives before a culprit is found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player_Romus: ""If this doesn't work, we'll try something else. But Zill..."*)
  - -> `[341]` (*Player_Romus: ""Thank you for your concern. But I have it all under cont..."*)
  - -> `[181]` (*Player_Romus: ""Mother, could you perhaps envision minding your own damn..."*)

### Węzeł `[175]`
Mówca: **Estela Toras**
> ""I meant it as a term of affection. She's got a beautiful beak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Estela Toras: ""I hope she hasn't inherited her family's unhealthy obses..."*)

### Węzeł `[176]`
Mówca: **Estela Toras**
> ""I hope she hasn't inherited her family's unhealthy obsession with Pales. She mustn't distract herself from our real problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player_Romus: ""Don't worry. I'll stay on top of her.""*)
  - -> `[180]` (*Player_Romus: ""Pales *is* a real problem, Mother. The situation there c..."*)
  - -> `[181]` (*Player_Romus: ""Mother, could you perhaps envision minding your own damn..."*)
  - -> `[363]` (*Player_Romus: ""Duchess Azaro has a level head. She won't drag us into c..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'll stay on top of her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Estela Toras), `[176]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "She raised an eyebrow."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "She raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Estela Toras: ""I'm sure you will.""*)

### Węzeł `[179]`
Mówca: **Estela Toras**
> ""I'm sure you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales *is* a real problem, Mother. The situation there could easily spiral out of control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Estela Toras), `[176]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Estela Toras: ""Pales is not ours to control in the first place. Zille, ..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mother, could you perhaps envision minding your own damn business for once?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Estela Toras), `[171]` (Estela Toras), `[173]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Estela Toras: ""Right. Who cares what happens to my homeland when there'..."*)

### Węzeł `[182]`
Mówca: **Estela Toras**
> ""Right. Who cares what happens to my homeland when there's embroidery that needs embroidering?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "She forcefully stubbed her cigarette out on the balcony r..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "She forcefully stubbed her cigarette out on the balcony railing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Estela Toras: ""I should get some rest. And so should you.""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_CompromisingPhoto == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Estela Toras: ""Has your new lady friend received any more intelligence ..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_CompromisingPhoto == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Estela Toras: ""Has that bird of prey on your council managed to find ou..."*)

### Węzeł `[187]`
Mówca: **Estela Toras**
> ""Has that bird of prey on your council managed to find out anything more about what happened to us in Zille?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)
  - -> `[152]` (*Player_Romus: ""Don't call Lucita that.""*)
  - -> `[164]` (*Player_Romus: ""The Pales situation has required her full attention.""*)

### Węzeł `[188]`
Mówca: **Estela Toras**
> ""Has your new lady friend received any more intelligence from Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)
  - -> `[164]` (*Player_Romus: ""The Pales situation has required her full attention.""*)
  - -> `[165]` (*Player_Romus: ""She's not my lady friend, Mother.""*)

### Węzeł `[189]`
Mówca: **Estela Toras**
> ""I should get some rest. And so should you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false"*)
  - -> `[190]` (*Player_Romus: ""Don't take that tone with your king.""*)
  - -> `[191]` (*Player_Romus: ""Wait. I'm sorry. You don't understand the stress I'm und..."*)
  - -> `[217]` (*Player_Romus: ""Sleep well, Mother.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't take that tone with your king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Estela Toras: ""I do beg your pardon. Your Majesty.""*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I'm sorry. You don't understand the stress I'm under.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Her gaze softened."*)

### Węzeł `[192]`
Mówca: **Estela Toras**
> ""Pales is not ours to control in the first place. Zille, on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[193]`
Mówca: **Estela Toras**
> ""Well. It's about time I got some rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false"*)
  - -> `[299]` (*Player_Romus: ""Yes, me too.""*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I had one more thing I wanted to ask. About Vina.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false`
- **Kontekst wejściowy (poprzednik):** `[193]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [Estela Toras: ""What about our princess?""]"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Estela Toras: ""What about our princess?""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Estela Toras: ""What about our princess?""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please don't worry about Zille. I promise I'm doing everything I can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Estela Toras: ""I'm not worried.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I can see the advantages of such a match. But I haven't made my mind up yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Estela Toras: ""Think about it. She may be past her prime marriage years..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's my councilor. It wouldn't be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Estela Toras: ""Your *interim* councilor, if I recall correctly.""*)

### Węzeł `[199]`
Mówca: **Estela Toras**
> ""Your *interim* councilor, if I recall correctly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[200]`
Mówca: **Estela Toras**
> ""Think about it. She may be past her prime marriage years, but it's not too late for some other noble to snatch her up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wish me luck for tomorrow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Estela Toras: ""I know you won't need it.""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Estela_TellAboutMurderCase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Estela_TellAboutMurderCase == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Estela_TellAboutMurderCase == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Estela_TellAboutMurderCase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""Remember how I told you Pabel thinks Father was murdered..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Estela_TellAboutMurderCase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player_Romus: ""Pabel thinks Father might have been murdered. I told Tit..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember how I told you Pabel thinks Father was murdered? Titus is investigating that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] == true`
- **Kontekst wejściowy (poprzednik):** `[163]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Estela Toras: ""Oh.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Sorry, I got confused.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Estela Toras: ""At any rate, I hope his investigators turn up something ..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel thinks Father might have been murdered. I told Titus to investigate that.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[163]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Estela Toras: ""Oh.""*)

### Węzeł `[208]`
Mówca: **Estela Toras**
> ""Oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Estela Toras: ""Darling, sometimes a heart attack is just a heart attack..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If someone killed Father, I might be next.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Estela Toras: ""Hmm. You're starting to sound just like him.""*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if Pabel was wrong about the murder, I'll have gathered some useful intel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Estela Toras: ""I should hope I'm not on the list of suspects.""*)

### Węzeł `[211]`
Mówca: **Estela Toras**
> ""Hmm. You're starting to sound just like him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "She stubbed her cigarette out on the balcony railing and sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen = true"*)

### Węzeł `[213]`
Mówca: **Estela Toras**
> ""I do beg your pardon. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "There was a chill in her voice now."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Her gaze softened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Estela Toras: ""I know. The last thing you need is pressure from me.""*)

### Węzeł `[215]`
Mówca: **Narrator**
> "There was a chill in her voice now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Estela -= 1"*)

### Węzeł `[216]`
Mówca: **Estela Toras**
> ""I know. The last thing you need is pressure from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Estela Toras: ""I hope Pabel ironed your pillowcase. You can't go addres..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sleep well, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Estela Toras: ""Good night, Your Majesty.""*)

### Węzeł `[218]`
Mówca: **Estela Toras**
> ""Good night, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "There was a chill in her voice now."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Estela -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Estela"] = Variable["RiziaDLC.Relations_Estela"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I wished her goodnight and left the room. I heard her lig..."*)

### Węzeł `[220]`
Mówca: **Estela Toras**
> ""I should hope I'm not on the list of suspects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe not, but I've already assigned him the task. I've got to see it through.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Estela Toras: ""I should hope I'm not on the list of suspects.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for all your advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Estela Toras: ""What's a mother for?""*)

### Węzeł `[223]`
Mówca: **Estela Toras**
> ""What's a mother for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I wished her goodnight and left the room. I heard her lig..."*)

### Węzeł `[224]`
Mówca: **Estela Toras**
> ""I know you won't need it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I wished her goodnight and left the room. I heard her lig..."*)

### Węzeł `[225]`
Mówca: **Estela Toras**
> ""I'm not worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I wished her goodnight and left the room. I heard her lig..."*)

### Węzeł `[226]`
Mówca: **Narrator**
> "I wished her goodnight and left the room. I heard her light click off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lyza was weak. I know how to control my own daughter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Estela Toras: ""No force in this world is as uncontrollable as a young w..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then what do I do? I don't want him infecting her with his dangerous ideas.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Kontekst wejściowy (poprzednik):** `[78]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank God. She's warmed up to Rico after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Estela Toras), `[257]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "She snorted."*)

### Węzeł `[230]`
Mówca: **Estela Toras**
> ""Are you sure it's not the opposite you need to be worried about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""What do you mean?""*)
  - -> `[261]` (*Player_Romus: ""Whatever. There must be some way we can stop this.""*)
  - -> `[260]` (*Player_Romus: ""That, too.""*)

### Węzeł `[231]`
Mówca: **Narrator**
> "She cast a sidelong glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Estela Toras: ""Are you sure it's not the opposite you need to be worrie..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: ""Then what do I do? I don't want him infecting her with h..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player_Romus: ""I actually like the kid. But he doesn't seem like marria..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I actually like the kid. But he doesn't seem like marriage material to me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "She cast a sidelong glance at me."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "She cast a sidelong glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Estela Toras: ""Royal marriages are a balancing act, my dear. You can sa..."*)

### Węzeł `[237]`
Mówca: **Estela Toras**
> ""But... after everything the Sazons did to you? To us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Estela Toras: ""Royal marriages are a balancing act, my dear. You can sa..."*)

### Węzeł `[238]`
Mówca: **Estela Toras**
> ""No force in this world is as uncontrollable as a young woman in love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""Whatever. There must be some way we can stop this.""*)
  - -> `[265]` (*Player_Romus: ""If I can't control her, what can I do?""*)
  - -> `[263]` (*Player_Romus: ""That's nonsense. She can't even hold a gun.""*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Sazons aren't as dangerous as you think. I'm looking to collaborate more closely with Manus, in fact.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Estela Toras: ""In that case, Vina might be useful as your eyes and ears..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC...."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDL..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player_Romus: ""The Sazons aren't as dangerous as you think. I'm looking..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""It might help neutralize the Sazon threat, actually. Man..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course it is, Mother. How could you even ask that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Estela Toras: ""Then you'll have to find a way to make it work to your a..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd be fine with it if it were true love. But I'm worried he's using her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Estela Toras: ""We're all using each other, aren't we? In fact...""*)

### Węzeł `[245]`
Mówca: **Estela Toras**
> ""They're powerful within Rizia, but minor players on the global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Estela Toras: ""You want my advice? It's high time the Princess took a n..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It might help neutralize the Sazon threat, actually. Manus' 'man of the people' act won't work if he's king consort.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Estela Toras: ""Yes, there are ways to make this work to your advantage.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You said yourself I shouldn't forbid her from seeing him. What other choice do I have?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: ""The way I see it...""*)

### Węzeł `[248]`
Mówca: **Estela Toras**
> ""You need to be thinking bigger, my love. We Torases are but minor players on the global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Estela Toras: ""You want my advice? It's high time the Princess took a n..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "She cast a sidelong glance at me."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "She cast a sidelong glance at me."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "She cast a sidelong glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Estela Toras: ""I should think you'd be more worried about putting House..."*)

### Węzeł `[253]`
Mówca: **Estela Toras**
> ""I should think you'd be more worried about putting House Sazon a single body away from the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""Whatever. There must be some way we can stop this.""*)
  - -> `[260]` (*Player_Romus: ""That, too.""*)
  - -> `[265]` (*Player_Romus: ""If I can't control her, what can I do?""*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Estela Toras: ""Although of course I've heard the same rumors you have.""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Estela Toras: ""It is, however, something any woman of experience can te..."*)

### Węzeł `[257]`
Mówca: **Estela Toras**
> ""It is, however, something any woman of experience can tell in seconds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Manus. I knew it.""*)
  - -> `[229]` (*Player_Romus: ""Thank God. She's warmed up to Rico after all.""*)

### Węzeł `[258]`
Mówca: **Estela Toras**
> ""The way I see it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Estela Toras: ""You could use the pairing to keep a close eye on the opp..."*)

### Węzeł `[259]`
Mówca: **Estela Toras**
> ""You could use the pairing to keep a close eye on the opposition. Assuming Vina trusts you enough to pass along information about her paramour's family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player_Romus: ""No, no. She's my daughter, not a spy.""*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[276]` (*Player_Romus: ""That's not a bad idea.""*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That, too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Estela Toras), `[253]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: ""The way I see it...""*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever. There must be some way we can stop this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Estela Toras), `[238]` (Estela Toras), `[253]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: ""The way I see it...""*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Estela Toras: ""Nothing. Just wondering if she took more than an academi..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's nonsense. She can't even hold a gun.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Estela Toras: ""Love has toppled more empires than gunshots ever will.""*)

### Węzeł `[264]`
Mówca: **Estela Toras**
> ""Nothing. Just wondering if she took more than an academic interest in that book she borrowed a while ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: ""The way I see it...""*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I can't control her, what can I do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Estela Toras), `[253]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: ""The way I see it...""*)

### Węzeł `[266]`
Mówca: **Estela Toras**
> ""Love has toppled more empires than gunshots ever will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: ""The way I see it...""*)

### Węzeł `[267]`
Mówca: **Estela Toras**
> ""You send the princess on a nice, relaxing trip abroad. Nothing cures lovesickness like a change of scenery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: ""A diplomatic mission, perhaps? Distract Vina and improve..."*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[287]` (*Player_Romus: ""I'm not ready to let go of her. She's the last tie to Le..."*)

### Węzeł `[268]`
Mówca: **Estela Toras**
> ""Then you'll have to find a way to make it work to your advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Estela Toras: ""You could use the pairing to keep a close eye on the opp..."*)

### Węzeł `[269]`
Mówca: **Estela Toras**
> ""In that case, Vina might be useful as your eyes and ears inside their house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Estela Toras: ""You could use the pairing to keep a close eye on the opp..."*)

### Węzeł `[270]`
Mówca: **Estela Toras**
> ""Yes, there are ways to make this work to your advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Estela Toras: ""You could use the pairing to keep a close eye on the opp..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player_Romus: ""I can't count on that, unfortunately.""*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""Of course she trusts me.""*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't count on that, unfortunately.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Kontekst wejściowy (poprzednik):** `[259]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Estela Toras: ""Or there's one other thing you could do.""*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course she trusts me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[259]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Estela Toras: ""Or there's one other thing you could do.""*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not a bad idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Estela Toras: ""Or there's one other thing you could do.""*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, no. She's my daughter, not a spy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Estela Toras: ""Or there's one other thing you could do.""*)

### Węzeł `[278]`
Mówca: **Estela Toras**
> ""We're all using each other, aren't we? In fact...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Estela Toras: ""You could use the pairing to keep a close eye on the opp..."*)

### Węzeł `[279]`
Mówca: **Estela Toras**
> ""Or there's one other thing you could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Estela Toras: ""You send the princess on a nice, relaxing trip abroad. N..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A diplomatic mission, perhaps? Distract Vina and improve our international standing in one go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Estela Toras), `[295]` (Estela Toras), `[296]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Estela Toras: ""And if she meets some dashing foreign prince over there,..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: ""Hmm. She's been cramping my style on the council, it's t..."*)
  - -> `[284]` (*Player_Romus: ""I can't do that. She's a valuable member of my council.""*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player_Romus: ""She'd find that a lot more stimulating than etiquette cl..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that. She's a valuable member of my council.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[267]` (Estela Toras), `[295]` (Estela Toras), `[296]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Estela Toras: ""It's just a thought. Feel free to ignore it.""*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. She's been cramping my style on the council, it's true.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[267]` (Estela Toras), `[295]` (Estela Toras), `[296]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Estela Toras: ""And if she meets some dashing foreign prince over there,..."*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She'd find that a lot more stimulating than etiquette classes, I'm sure.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Estela Toras), `[295]` (Estela Toras), `[296]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Estela Toras: ""And if she meets some dashing foreign prince over there,..."*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not ready to let go of her. She's the last tie to Lena I have left.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Estela Toras), `[296]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Estela Toras: ""You could always invite her high-and-mighty aunt for mor..."*)

### Węzeł `[288]`
Mówca: **Estela Toras**
> ""You could always invite her high-and-mighty aunt for more scintillating chats over putrid Rumburgian tea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Vina = true"*)

### Węzeł `[289]`
Mówca: **Estela Toras**
> ""It's just a thought. Feel free to ignore it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Vina = true"*)

### Węzeł `[290]`
Mówca: **Estela Toras**
> ""And if she meets some dashing foreign prince over there, consider it a bonus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Vina = true"*)

### Węzeł `[291]`
Mówca: **Estela Toras**
> ""You want my advice? It's high time the Princess took a nice, relaxing trip out of the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Estela Toras: ""It would put a stop to the rumors that are beginning to ..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Estela Toras: ""She's old enough to experience the world beyond our litt..."*)

### Węzeł `[295]`
Mówca: **Estela Toras**
> ""It would put a stop to the rumors that are beginning to circulate about Her Highness and the Sazon heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: ""A diplomatic mission, perhaps? Distract Vina and improve..."*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[296]`
Mówca: **Estela Toras**
> ""She's old enough to experience the world beyond our little peninsula.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: ""A diplomatic mission, perhaps? Distract Vina and improve..."*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[287]` (*Player_Romus: ""I'm not ready to let go of her. She's the last tie to Le..."*)

### Węzeł `[297]`
Mówca: **Estela Toras**
> ""Speaking of foreign affairs, are you positive you don't want to talk about tomorrow's meeting? I just want to make sure you're prepared to address the elephant in the chamber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "Jump to: [Estela Wehlen Talk]"*)
  - -> `[308]` (*Player_Romus: ""I'll deal with that when the moment arrives. I've got en..."*)

### Węzeł `[298]`
Mówca: **Estela Toras**
> ""And with that, it's time to turn in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player_Romus: ""Don't worry about Vina. I know what to do.""*)
  - -> `[309]` (*Player_Romus: ""Wish me luck for tomorrow.""*)
  - -> `[310]` (*Player_Romus: ""Thanks for all your advice.""*)
  - -> `[301]` (*Player_Romus: ""Same here.""*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, me too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Estela Toras: ""I hope Pabel ironed your pillowcase. You can't go addres..."*)

### Węzeł `[300]`
Mówca: **Estela Toras**
> ""I hope Pabel ironed your pillowcase. You can't go addressing the AN with creases on your face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""Please don't worry about Zille. I promise I'm doing ever..."*)
  - -> `[201]` (*Player_Romus: ""Wish me luck for tomorrow.""*)
  - -> `[222]` (*Player_Romus: ""Thanks for all your advice.""*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Same here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Estela Toras), `[314]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I wished her goodnight and left the room. I heard her lig..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Estela Toras: ""Well. It's about time I got some rest.""*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Estela Toras: ""Speaking of foreign affairs, are you positive you don't ..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "She yawned theatrically."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "She yawned theatrically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Estela Toras: ""And with that, it's time to turn in.""*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Estela Wehlen Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "Estela Wehlen Talk"*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll deal with that when the moment arrives. I've got enough to think about for tonight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Estela Toras: ""It's late, isn't it? Time to turn in.""*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wish me luck for tomorrow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Estela Toras), `[314]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Estela Toras: ""I know you won't need it.""*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for all your advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Estela Toras), `[314]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Estela Toras: ""What's a mother for?""*)

### Węzeł `[311]`
Mówca: **Estela Toras**
> ""What's a mother for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I wished her goodnight and left the room. I heard her lig..."*)

### Węzeł `[312]`
Mówca: **Estela Toras**
> ""I know you won't need it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I wished her goodnight and left the room. I heard her lig..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry about Vina. I know what to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Estela Toras: ""You're her father *and* the king. You surely know best.""*)

### Węzeł `[314]`
Mówca: **Estela Toras**
> ""It's late, isn't it? Time to turn in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: ""Wish me luck for tomorrow.""*)
  - -> `[310]` (*Player_Romus: ""Thanks for all your advice.""*)
  - -> `[301]` (*Player_Romus: ""Same here.""*)

### Węzeł `[315]`
Mówca: **Estela Toras**
> ""You're her father *and* the king. You surely know best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I wished her goodnight and left the room. I heard her lig..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""Wait. I had one more thing I wanted to ask. About Vina.""*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""I had one more thing I wanted to ask first. About Vina.""*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_EstelaTalk_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false"*)

### Węzeł `[323]`
Mówca: **Narrator**
> "I returned to my quarters to see Titus take his post outside my door. I wondered how long he'd been shadowing me for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "In my room. Pabel had already packed my suitcase and turn..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "I checked the corner for Bruno, but his dog bed was empty..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "I climbed into bed, but was too distracted by thoughts of..."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "I checked the corner for Bruno, but his dog bed was empty. I looked at my own bed and saw that he'd made himself comfortable there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Bruno: ""Hrr?""*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shoo! Bad dog!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Bruno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "Bruno reluctantly hopped off the bed and trotted back to ..."*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get a move on, boy. The King needs his rest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Bruno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "Bruno reluctantly hopped off the bed and trotted back to ..."*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. You can sleep here tonight, but don't get too used to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Bruno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "Bruno curled up at my feet as I got in bed."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "Bruno curled up at my feet as I got in bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed = true"*)

### Węzeł `[332]`
Mówca: **Narrator**
> "Bruno reluctantly hopped off the bed and trotted back to his corner. He was nearly as agile on three legs as he'd been on four."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "I tried to sleep, but was too distracted by thoughts of t..."*)

### Węzeł `[333]`
Mówca: **Narrator**
> "I tried to sleep, but was too distracted by thoughts of the day ahead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_Qalus_CantuavoInvitation =..."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "I climbed into bed, but was too distracted by thoughts of the day ahead to sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_Qalus_CantuavoInvitation =..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "I returned to my quarters to see Titus take his post outs..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus_Italic: "Tap her on the shoulder."*)
  - -> `[8]` (*Player_Romus: ""Can't sleep?""*)
  - -> `[9]` (*Player_Romus: ""Good evening, Mother.""*)
  - -> `[395]` (*Player_Romus: ""What are you talking about?""*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "There was a clunk as she hung up the phone. I moved away ..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It was the night before my trip to Kyrute for the Allianc..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your concern. But I have it all under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Estela Toras), `[174]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Estela Toras: ""If you say so.""*)

### Węzeł `[342]`
Mówca: **Estela Toras**
> ""If you say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If this doesn't work, we'll try something else. But Zille *will* be ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Estela Toras), `[174]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Estela Toras: ""Yes, I know. Excuse my impatience.""*)

### Węzeł `[344]`
Mówca: **Estela Toras**
> ""Yes, I know. Excuse my impatience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn04_Qalus_CantuavoInvitation = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Qalus_CantuavoInvitation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "I tried to sleep, but was too distracted by thoughts of t..."*)

### Węzeł `[347]`
Mówca: **Estela Toras**
> ""You are planning on addressing the elephant in the chamber, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "Estela Wehlen Talk"*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I am. Wehlen must be forced to honor the Zille handover deadline.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Estela Toras), `[297]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Estela Toras: ""That's the pachyderm in question, yes.""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certainly. This naval standoff with Pales must end one way or another.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Kontekst wejściowy (poprzednik):** `[347]` (Estela Toras), `[297]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Estela Toras: ""I was referring to Zille, my dear. Or have you forgotten..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player_Romus: ""Certainly. This naval standoff with Pales must end one w..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[353]`
Mówca: **Estela Toras**
> ""That's the pachyderm in question, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Estela Toras: ""We need our land back. No matter what kind of announceme..."*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, the arbitration committee should have come to a decision already. Our claim on the gas field is clear.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Kontekst wejściowy (poprzednik):** `[347]` (Estela Toras), `[297]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Estela Toras: ""I was referring to Zille, my dear. Or have you forgotten..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player_Romus: ""Yes, the arbitration committee should have come to a dec..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player_Romus: ""There is no elephant. I've neutralized the Pales situati..."*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which elephant? There are so many.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Estela Toras), `[297]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Estela Toras: ""A wonder that you world leaders can squeeze in amongst a..."*)

### Węzeł `[359]`
Mówca: **Estela Toras**
> ""A wonder that you world leaders can squeeze in amongst all those pachyderms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Estela Toras: ""But I was referring to Zille. Or have you forgotten that..."*)

### Węzeł `[360]`
Mówca: **Estela Toras**
> ""But I was referring to Zille. Or have you forgotten that the handover deadline is imminent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Estela Toras: ""We need our land back. No matter what kind of announceme..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no elephant. I've neutralized the Pales situation for now.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[347]` (Estela Toras), `[297]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Estela Toras: ""Have you so quickly forgotten? The Zille handover deadli..."*)

### Węzeł `[362]`
Mówca: **Estela Toras**
> ""Have you so quickly forgotten? The Zille handover deadline is almost upon us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Estela Toras: ""We need our land back. No matter what kind of announceme..."*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Azaro has a level head. She won't drag us into conflict without reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Estela Toras), `[171]` (Estela Toras), `[176]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Estela Toras: ""Oh, there's always a reason.""*)

### Węzeł `[364]`
Mówca: **Estela Toras**
> ""Oh, there's always a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "She stubbed her cigarette out on the balcony railing and ..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Estela Wehlen Talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player_Romus: ""Of course I am. Wehlen must be forced to honor the Zille..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[358]` (*Player_Romus: ""Which elephant? There are so many.""*)

### Węzeł `[366]`
Mówca: **Narrator**
> "She snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Estela Toras: ""You know how your father and I met, don't you?""*)

### Węzeł `[367]`
Mówca: **Estela Toras**
> ""Don't forget what happened when Lyza the Great tried to forbid your father from seeing the Whore of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "She laughed loudly."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were working as a waitress in a cocktail bar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Estela Toras: ""That much is true.""*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You used your feminine wiles to entrap him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Estela Toras: ""Hardly.""*)

### Węzeł `[370]`
Mówca: **Estela Toras**
> ""Hardly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Estela Toras: ""It was only supposed to be a fling, at first. But when L..."*)

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was always confused about that. Why did Lyza allow Father to date a commoner?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Estela Toras: ""She didn't, at first. But the more she tried to discoura..."*)

### Węzeł `[372]`
Mówca: **Estela Toras**
> ""She didn't, at first. But the more she tried to discourage him, the faster she drove him straight into the arms of the Whore of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "She laughed loudly."*)

### Węzeł `[373]`
Mówca: **Narrator**
> "She laughed loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Estela Toras: ""Next thing you know, she's throwing all of her influence..."*)

### Węzeł `[374]`
Mówca: **Estela Toras**
> ""It was only supposed to be a fling, at first. But when Lyza the Great caught wind of it, she did everything in her considerable power to stop her son from seeing me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Estela Toras: ""And that, of course, was what drove him straight into th..."*)

### Węzeł `[375]`
Mówca: **Estela Toras**
> ""And that, of course, was what drove him straight into the arms of the Whore of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "She laughed loudly."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everything worked out in the end, though, didn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Estela Toras: ""If you call seriously undermining the monarchy 'working ..."*)

### Węzeł `[377]`
Mówca: **Estela Toras**
> ""If you call seriously undermining the monarchy 'working out', then yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "She cast a sidelong glance at me."*)

### Węzeł `[378]`
Mówca: **Narrator**
> "In my room. Pabel had already packed my suitcase and turned the bed down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[379]`
Mówca: **Vina Toras**
> ""Well, tell the others not to push for too much too quickly. He's in Kyrute the next few days anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Vina Toras: ""...Yes, my love. We'll speak very soon.""*)

### Węzeł `[380]`
Mówca: **Bruno**
> ""Hrr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player_Romus: ""Shoo! Bad dog!""*)
  - -> `[329]` (*Player_Romus: ""Get a move on, boy. The King needs his rest.""*)
  - -> `[330]` (*Player_Romus: ""All right. You can sleep here tonight, but don't get too..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == false && RiziaDLC.Decision_Turn04_AttendHouseOfDelegates == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == false && RiziaDLC.Decision_Turn04_AttendHouseOfDelegates == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == false  and  Variable["RiziaDLC.Decision_Turn04_AttendHouseOfDelegates"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn04_EnableRRGStakeChange = true"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == false && RiziaDLC.Decision_Turn04_AttendHouseOfDelegates == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == false  and  Variable["RiziaDLC.Decision_Turn04_AttendHouseOfDelegates"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn04_EnableRRGStakeChange = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn04_EnableRRGStakeChange"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[385]`
Mówca: **Vina Toras**
> ""What?! Why would you want to stop when you only got half of what you wanted? That's no victory at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Vina Toras: ""...No, he hasn't written back yet. Who knows if he's eve..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Vina Toras: ""What?! Why would you want to stop when you only got half..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Vina Toras: ""Oh, don't be so blue. Honestly, what were you expecting?""*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Vina Toras: ""It's just the beginning, isn't it? You've won this victo..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)

### Węzeł `[392]`
Mówca: **Vina Toras**
> ""Oh, don't be so blue. Honestly, what were you expecting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Vina Toras: ""...No, he hasn't written back yet. Who knows if he's eve..."*)

### Węzeł `[393]`
Mówca: **Vina Toras**
> ""It's just the beginning, isn't it? You've won this victory, now you've got to keep pushing for more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Vina Toras: ""...No, he hasn't written back yet. Who knows if he's eve..."*)

### Węzeł `[394]`
Mówca: **Estela Toras**
> ""Darling, sometimes a heart attack is just a heart attack. No need to waste the man's time trying to figure out who was where when.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""Maybe not, but I've already assigned him the task. I've ..."*)
  - -> `[210]` (*Player_Romus: ""Even if Pabel was wrong about the murder, I'll have gath..."*)
  - -> `[209]` (*Player_Romus: ""If someone killed Father, I might be next.""*)
  - -> `[181]` (*Player_Romus: ""Mother, could you perhaps envision minding your own damn..."*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you talking about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "She looked startled for a moment, then smiled."*)

### Węzeł `[396]`
Mówca: **Narrator**
> "She looked startled for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Estela Toras: ""Just rehearsing the choice words I'm going to have with ..."*)

### Węzeł `[397]`
Mówca: **Estela Toras**
> ""Just rehearsing the choice words I'm going to have with the royal laundress. How hard can it be to get red wine out of an albino fox stole?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "She lit a cigarette and blew smoke out into the gardens."*)

### Węzeł `[398]`
Mówca: **Narrator**
> "She lit a cigarette and blew smoke out into the gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Estela Toras: ""All set for tomorrow?""*)
