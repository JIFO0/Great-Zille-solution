# Sordland/Turn08/A_InvestigationResults

- **ID konwersacji:** `178`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/178_A_InvestigationResults.md`
- **Liczba węzłów dialogowych:** 477
- **Liczba wyborów gracza:** 135

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.SecretState_LucianKnowsSSPKills`
- `BaseGame.Turn07_A_Marcel_Threatened`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_SecondScandal_BlamePetrForLeak`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_LiviaFired`
- `BaseGame.Turn08_SecondScandal_LiviaInvestigated`
- `BaseGame.Turn08_SecondScandal_LiviaStays`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn08_SecondScandal_ShareBlame`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_LiviaPetrGone`
- `BaseGame.Enable_PressRelease`
- `BaseGame.Enable_VPSelection`
- `BaseGame.Petr_Dead`
- `BaseGame.Petr_isVP`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Situation_Order_InfiltratedIntelligence`
- `BaseGame.Turn08_PressConference_PetrKnowsResigning`
- `BaseGame.Turn08_SecondScandal_BlamePetrForLeak`
- `BaseGame.Turn08_SecondScandal_DenyEverything`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_LiviaFired`
- `BaseGame.Turn08_SecondScandal_LiviaStays`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing`
- `BaseGameSupport.Journal_Turn08_SecondScandal_BlamePetrForLeak`
- `BaseGameSupport.Journal_Turn08_SecondScandal_DenyEverything`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaAndPetrDetained`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaDetained`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaFired`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaSpy`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaStays`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLiviaAndPetr`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLivia`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLiviaAndPetr`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_LiviaTrialled`
- `BaseGameSupport.Journal_Turn08_SecondScandal_ShareBlame`
- `BaseGameSupport.News_Turn08_HP_LiviaSpyReveal`
- `BaseGameSupport.News_Turn08_R_LiviaSpyReveal`
- `BaseGameSupport.News_Turn08_ST_LiviaSpyReveal`
- `GameCondition.Turn08_A_InvestigationResults`
- `GameCondition.Turn08_A_PressReleases`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""Of course.""** | `[11]` **Lucian Galade**: ""Sir, a moment of your time?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Lucian entered my office and clo..." |
| `[13]` | **"Motion for him to come in."** | `[11]` **Lucian Galade**: ""Sir, a moment of your time?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Li...` | `[21]` **Lucian Galade**: ""I still believe you were wrong ..."<br>`[77]` **Lucian Galade**: ""Our security team travelled to ..." |
| `[14]` | **""Not now.""** | `[11]` **Lucian Galade**: ""Sir, a moment of your time?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Lucian Galade**: ""I'm afraid it's urgent."" |
| `[22]` | **""Unorthodox? You surveilled Petr behind my back!""** | `[21]` **Lucian Galade**: ""I still believe you were wrong ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lucian Galade**: ""I have already apologized to Mr..." |
| `[23]` | **""You're not going to change my mind about this.""** | `[21]` **Lucian Galade**: ""I still believe you were wrong ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lucian Galade**: ""That isn't my goal."" |
| `[24]` | **""I could have been less rude to you about it, though.""** | `[21]` **Lucian Galade**: ""I still believe you were wrong ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucian Galade**: ""Perhaps."" |
| `[31]` | **""Are you crazy? She'll go public about the affair.""** | `[30]` **Lucian Galade**: ""Please, consider dismissing Mis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Lucian Galade**: ""That might make a headline or t..." |
| `[32]` | **""I can't. She's so good at her job!""** | `[30]` **Lucian Galade**: ""Please, consider dismissing Mis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lucian Galade**: ""Her looks may be unmatched, but..." |
| `[33]` | **""Well, she has been a distraction to Petr...""** | `[30]` **Lucian Galade**: ""Please, consider dismissing Mis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Lucian Galade**: ""Keeping Mr. Vectern around may ..." |
| `[34]` | **""How do I justify that to her?""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Lucian Galade**: ""She slept with the vice preside..." |
| `[38]` | **""All right. If it'll get you off my case, I'll fire her.""** | `[35]` **Lucian Galade**: ""She slept with the vice preside..."<br>`[36]` **Lucian Galade**: ""Her looks may be unmatched, but..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Lucian Galade**: ""Thank you, Mr. President."" |
| `[39]` | **""No. I won't continue to indulge your paranoid fantasies. Livia stays.""** | `[35]` **Lucian Galade**: ""She slept with the vice preside..."<br>`[36]` **Lucian Galade**: ""Her looks may be unmatched, but..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[43]` **Narrator**: "Lucian looked as if he was about..." |
| `[49]` | **""Nothing. Go back to work.""** | `[48]` **Narrator**: "I thought about how useful she'd..."<br>`[176]` **Narrator**: "I thought about how useful she'd..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Livia Suno**: ""Um... okay. Just let me know if..." |
| `[50]` | **""You're fired, Livia.""** | `[48]` **Narrator**: "I thought about how useful she'd..."<br>`[176]` **Narrator**: "I thought about how useful she'd..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Livia Suno**: ""W-what? I thought we'd been ove..." |
| `[53]` | **""You're making Petr too distracted to work.""** | `[51]` **Livia Suno**: ""W-what? I thought we'd been ove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Livia Suno**: ""Then perhaps you should fire him."" |
| `[57]` | **""You're too ambitious for this job. Go get a proper university education.""** | `[51]` **Livia Suno**: ""W-what? I thought we'd been ove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Livia Suno**: ""That's the best you could come ..." |
| `[58]` | **""I don't share Lucian's suspicions that you're a spy, but I can't take the risk th..."** | `[51]` **Livia Suno**: ""W-what? I thought we'd been ove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Livia Suno**: ""How prudent of you."" |
| `[59]` | **""Your performance has been abysmal lately.""** | `[51]` **Livia Suno**: ""W-what? I thought we'd been ove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Livia Suno**: ""I know that's not true."" |
| `[69]` | **""I hope so.""** | `[68]` **Lucian Galade**: ""Trust me, Mr. President, your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "I showed him out and went to bre..." |
| `[70]` | **""Stop talking. Don't make this worse than it is.""** | `[68]` **Lucian Galade**: ""Trust me, Mr. President, your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "I showed him out and went to bre..." |
| `[71]` | **""Yes, I know.""** | `[68]` **Lucian Galade**: ""Trust me, Mr. President, your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "I showed him out and went to bre..." |
| `[80]` | **""Oh, shit.""** | `[79]` **Lucian Galade**: ""However, it did match that of a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Lucian Galade**: ""Further investigation by our op..." |
| `[81]` | **""If that was Livia Suno... who's the woman working for me?""** | `[79]` **Lucian Galade**: ""However, it did match that of a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Lucian Galade**: ""Further investigation by our op..." |
| `[82]` | **""You mean...""** | `[79]` **Lucian Galade**: ""However, it did match that of a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Lucian Galade**: ""Further investigation by our op..." |
| `[89]` | **""How could we have missed all this?""** | `[87]` **Lucian Galade**: ""Our whistleblower from Rumburg ..."<br>`[88]` **Lucian Galade**: ""Recent coded transmissions from..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Lucian Galade**: ""As mentioned, Miss Suno was hir..." |
| `[90]` | **""My God. You were right. I should never have doubted you.""** | `[87]` **Lucian Galade**: ""Our whistleblower from Rumburg ..."<br>`[88]` **Lucian Galade**: ""Recent coded transmissions from..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[98]` **Lucian Galade**: ""I'm happy to hear that. Now, wh..." |
| `[91]` | **""That lying, two-faced succubus!""** | `[87]` **Lucian Galade**: ""Our whistleblower from Rumburg ..."<br>`[88]` **Lucian Galade**: ""Recent coded transmissions from..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Lucian Galade**: ""To be fair, Miss Suno was just ..." |
| `[95]` | **""Easy. I'll get Marcel on it.""** | `[94]` **Lucian Galade**: ""The standard procedure would be..."<br>`[111]` **Lucian Galade**: ""That would be standard procedur..." | `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false` | *Brak zmian stanu* | `[149]` **Lucian Galade**: ""Asking Mr. Koronti for help wou..."<br>`[119]` **Lucian Galade**: ""Asking Mr. Koronti for help wou..." |
| `[96]` | **""You should have figured this out ages ago.""** | `[87]` **Lucian Galade**: ""Our whistleblower from Rumburg ..."<br>`[88]` **Lucian Galade**: ""Recent coded transmissions from..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Lucian Galade**: ""As mentioned, Miss Suno was hir..." |
| `[100]` | **""What do you think I should do?""** | `[98]` **Lucian Galade**: ""I'm happy to hear that. Now, wh..."<br>`[99]` **Lucian Galade**: ""But none of that can be helped ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Lucian Galade**: ""The standard procedure would be..." |
| `[101]` | **""What do you mean? I'm going to murder them both.""** | `[98]` **Lucian Galade**: ""I'm happy to hear that. Now, wh..."<br>`[99]` **Lucian Galade**: ""But none of that can be helped ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Lucian lowered his voice."<br>`[109]` **Narrator**: "Lucian stroked his beard." |
| `[102]` | **""Arrest her for espionage, of course.""** | `[98]` **Lucian Galade**: ""I'm happy to hear that. Now, wh..."<br>`[99]` **Lucian Galade**: ""But none of that can be helped ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Lucian Galade**: ""That would be standard procedur..." |
| `[103]` | **""I'm going to have Petr castrated.""** | `[98]` **Lucian Galade**: ""I'm happy to hear that. Now, wh..."<br>`[99]` **Lucian Galade**: ""But none of that can be helped ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lucian Galade**: ""I wouldn't be opposed to that i..." |
| `[113]` | **""I'll look like a fool for having her under my nose this entire time.""** | `[94]` **Lucian Galade**: ""The standard procedure would be..."<br>`[111]` **Lucian Galade**: ""That would be standard procedur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Lucian Galade**: ""There are other options.""<br>`[155]` **Lucian Galade**: ""That's why you must let Mr. Vec..." |
| `[114]` | **""Outwitted by a woman. It won't look good.""** | `[94]` **Lucian Galade**: ""The standard procedure would be..."<br>`[111]` **Lucian Galade**: ""That would be standard procedur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Lucian Galade**: ""There are other options.""<br>`[155]` **Lucian Galade**: ""That's why you must let Mr. Vec..." |
| `[118]` | **""What if there were no trial?""** | `[94]` **Lucian Galade**: ""The standard procedure would be..."<br>`[111]` **Lucian Galade**: ""That would be standard procedur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Lucian Galade**: ""Then you'd -- what, exactly? Kn..."<br>`[124]` **Lucian Galade**: ""With the powers granted by your..." |
| `[128]` | **""You are right. Let's detain her immediately.""** | `[125]` **Lucian Galade**: ""With the powers granted by your..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] ...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Li...` | `[255]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." |
| `[129]` | **""Good. Let's detain her. And Petr, too -- this was all his fault.""** | `[125]` **Lucian Galade**: ""With the powers granted by your..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] ...`<br>`Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] =...`<br>*(+1 skryptów)* | `[253]` **Narrator**: "Lucian was trying very hard not ..." |
| `[130]` | **""No, no. I'd rather do it all above board.""** | `[125]` **Lucian Galade**: ""With the powers granted by your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Lucian Galade**: ""If you say so, sir. Are you rea..." |
| `[131]` | **""Yes, brilliant. Let's do that.""** | `[126]` **Lucian Galade**: ""Mr. Greiser and his men could c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Lucian Galade**: ""A wise choice, sir."" |
| `[132]` | **""No, no. I'd rather do it all above board.""** | `[126]` **Lucian Galade**: ""Mr. Greiser and his men could c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Lucian Galade**: ""If you say so, sir. Are you rea..." |
| `[134]` | **""Detention without trial sounds like the easiest thing to do.""** | `[127]` **Lucian Galade**: ""Alternately, you could mobilize..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Lucian Galade**: ""Of course, sir."" |
| `[135]` | **""Let's use Karl. The fewer loose ends, the better.""** | `[127]` **Lucian Galade**: ""Alternately, you could mobilize..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Lucian Galade**: ""Of course, sir."" |
| `[136]` | **""No, no. I'd rather do it all above board.""** | `[127]` **Lucian Galade**: ""Alternately, you could mobilize..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Lucian Galade**: ""If you say so, sir. Are you rea..." |
| `[160]` | **""No. No, I told you, Petr did nothing wrong!""** | `[182]` **Lucian Galade**: ""If you say so, sir. Are you rea..."<br>`[157]` **Lucian Galade**: ""Starting by letting Petr Vecter..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Lucian Galade**: ""Mr. Vectern put you in danger b..." |
| `[161]` | **""I know his actions were problematic...""** | `[182]` **Lucian Galade**: ""If you say so, sir. Are you rea..."<br>`[157]` **Lucian Galade**: ""Starting by letting Petr Vecter..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Lucian Galade**: ""Problematic is an understatement."" |
| `[162]` | **""This is my fault as much as his. I should have suspected something.""** | `[182]` **Lucian Galade**: ""If you say so, sir. Are you rea..."<br>`[157]` **Lucian Galade**: ""Starting by letting Petr Vecter..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Lucian Galade**: ""You can share the blame, but yo..." |
| `[163]` | **""I know you think you'd be a better vice president. But enough is enough.""** | `[182]` **Lucian Galade**: ""If you say so, sir. Are you rea..."<br>`[157]` **Lucian Galade**: ""Starting by letting Petr Vecter..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Lucian Galade**: ""Mr. President, rest assured thi..." |
| `[164]` | **""You can share the blame, but you have to prepare for your public opinion to nosed..."** | `[162]` **Player**: ""This is my fault as much as his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Lucian Galade**: ""Thankfully, Mr. Koronti can sof..."<br>`[173]` **Lucian Galade**: ""But please, take a moment to th..." |
| `[171]` | **""I-- no. I wouldn't.""** | `[169]` **Lucian Galade**: ""Mr. Vectern put you in danger b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Narrator**: "Lucian sighed." |
| `[174]` | **""For a woman I loved? Maybe I would!""** | `[169]` **Lucian Galade**: ""Mr. Vectern put you in danger b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Narrator**: "Lucian sighed." |
| `[175]` | **""I don't know. I can't put myself in his shoes.""** | `[169]` **Lucian Galade**: ""Mr. Vectern put you in danger b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Lucian Galade**: ""Try guzzling half a bottle of w..." |
| `[188]` | **""I will shoulder the blame along with him.""** | `[187]` **Lucian Galade**: ""I am your chief strategist. I h..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Sh...` | `[192]` **Narrator**: "Lucian looked as if he was about..." |
| `[189]` | **""All right. Petr will be our scapegoat.""** | `[187]` **Lucian Galade**: ""I am your chief strategist. I h..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Bl...` | `[193]` **Lucian Galade**: ""Very well. I shall consult with..."<br>`[197]` **Lucian Galade**: ""Very well. I shall write a stat..." |
| `[190]` | **""I will blame Livia -- I mean, Ilana -- and nobody else.""** | `[187]` **Lucian Galade**: ""I am your chief strategist. I h..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...`<br>`Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] ...`<br>*(+1 skryptów)* | `[192]` **Narrator**: "Lucian looked as if he was about..." |
| `[198]` | **""With pleasure.""** | `[193]` **Lucian Galade**: ""Very well. I shall consult with..."<br>`[197]` **Lucian Galade**: ""Very well. I shall write a stat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "Lucian nodded and walked out." |
| `[199]` | **""Thank you.""** | `[193]` **Lucian Galade**: ""Very well. I shall consult with..."<br>`[197]` **Lucian Galade**: ""Very well. I shall write a stat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "Lucian nodded and walked out." |
| `[201]` | **""Great. Let's detain her immediately.""** | `[200]` **Lucian Galade**: ""Of course, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] ...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Li...` | `[255]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." |
| `[202]` | **""Great. Let's detain both her and Petr. He got us into this mess, after all.""** | `[200]` **Lucian Galade**: ""Of course, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] ...`<br>`Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] =...`<br>*(+1 skryptów)* | `[253]` **Narrator**: "Lucian was trying very hard not ..." |
| `[208]` | **""By 'take care of', you mean secretly arrest, right?""** | `[205]` **Lucian Galade**: ""A wise choice, sir.""<br>`[203]` **Lucian Galade**: ""Of course, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Lucian Galade**: ""I think you know precisely what..."<br>`[214]` **Lucian Galade**: ""What else could I have meant?"" |
| `[209]` | **""By 'take care of', you mean 'take care of for good', right?""** | `[205]` **Lucian Galade**: ""A wise choice, sir.""<br>`[203]` **Lucian Galade**: ""Of course, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Lucian Galade**: ""I think you know precisely what..."<br>`[219]` **Lucian Galade**: ""It means whatever you want it t..." |
| `[226]` | **""Uh, nothing.""** | `[214]` **Lucian Galade**: ""What else could I have meant?"" | `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true` | *Brak zmian stanu* | `[233]` **Narrator**: "I could almost see the gears in ..." |
| `[227]` | **""Nothing...""** | `[214]` **Lucian Galade**: ""What else could I have meant?"" | `(Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false` | *Brak zmian stanu* | `[233]` **Narrator**: "I could almost see the gears in ..." |
| `[228]` | **""Kill, perhaps? It's been done before.""** | `[214]` **Lucian Galade**: ""What else could I have meant?"" | `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true` | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[229]` **Lucian Galade**: ""I see. Curious that I wasn't in..." |
| `[231]` | **""Kill, maybe?""** | `[214]` **Lucian Galade**: ""What else could I have meant?"" | `(Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false` | *Brak zmian stanu* | `[232]` **Lucian Galade**: ""If made to look like an acciden..."<br>`[476]` **Lucian Galade**: ""If made to look like an acciden..." |
| `[234]` | **""Let's just have her arrested, okay?""** | `[232]` **Lucian Galade**: ""If made to look like an acciden..."<br>`[476]` **Lucian Galade**: ""If made to look like an acciden..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_SecretState_Arres...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Se...` | `[243]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." |
| `[235]` | **""Let's just have her arrested -- and Petr, too, while we're at it. He's done enoug..."** | `[232]` **Lucian Galade**: ""If made to look like an acciden..."<br>`[476]` **Lucian Galade**: ""If made to look like an acciden..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_SecretState_Arres...`<br>`Variable["BaseGame.Turn08_SecondScandal_SecretState_Arres...`<br>*(+1 skryptów)* | `[246]` **Narrator**: "Lucian was trying very hard not ..." |
| `[236]` | **""Screw Liv--Ilana. Let's have her killed.""** | `[232]` **Lucian Galade**: ""If made to look like an acciden..."<br>`[476]` **Lucian Galade**: ""If made to look like an acciden..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Se...` | `[245]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." |
| `[237]` | **""Screw Miss Vance. And Petr too! Let's have them both killed.""** | `[232]` **Lucian Galade**: ""If made to look like an acciden..."<br>`[476]` **Lucian Galade**: ""If made to look like an acciden..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_...`<br>`Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_...`<br>*(+1 skryptów)* | `[247]` **Narrator**: "Lucian was trying very hard not ..." |
| `[259]` | **""You tell me... Ilana.""** | `[257]` **Livia Suno**: ""Is there something you need, Mr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Narrator**: "A barely perceptible flash of fe..." |
| `[260]` | **""It's been a pleasure working with you, Livia.""** | `[257]` **Livia Suno**: ""Is there something you need, Mr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Narrator**: "A barely perceptible flash of fe..." |
| `[261]` | **""Yes. I need you to stop pretending.""** | `[257]` **Livia Suno**: ""Is there something you need, Mr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Narrator**: "A barely perceptible flash of fe..." |
| `[262]` | **""Please, sit down.""** | `[257]` **Livia Suno**: ""Is there something you need, Mr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Narrator**: "A barely perceptible flash of fe..." |
| `[273]` | **""You're going to pay for your lies, Ilana.""** | `[272]` **Livia Suno**: ""What the hell is going on? Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "Karl's men grabbed her arms and ..." |
| `[274]` | **""You're going to pay for the way you used Petr.""** | `[272]` **Livia Suno**: ""What the hell is going on? Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "Karl's men grabbed her arms and ..." |
| `[275]` | **""I'm sorry it had to come to this.""** | `[272]` **Livia Suno**: ""What the hell is going on? Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "Karl's men grabbed her arms and ..." |
| `[276]` | **""If you thought I wouldn't trust my closest advisor, you're the stupid one.""** | `[272]` **Livia Suno**: ""What the hell is going on? Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "Karl's men grabbed her arms and ..." |
| `[281]` | **""Her name's Ilana. Lucian was right about her. She's a spy.""** | `[279]` **Petr Vectern**: ""Liv? What in the hell!? Anton, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Petr Vectern**: ""No. That can't be true. Can it?..." |
| `[282]` | **""She was using you all along, Petr.""** | `[279]` **Petr Vectern**: ""Liv? What in the hell!? Anton, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Petr Vectern**: ""No. That can't be true. Can it?..." |
| `[283]` | **""Livia, tell Petr who you really are.""** | `[279]` **Petr Vectern**: ""Liv? What in the hell!? Anton, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Livia Suno**: ""I won't say another word withou..." |
| `[284]` | **"Say nothing."** | `[279]` **Petr Vectern**: ""Liv? What in the hell!? Anton, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Petr Vectern**: ""Liv! Come on, tell them this wa..." |
| `[293]` | **""Thank you, Lucian.""** | `[255]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Narrator**: "Lucian nodded and walked out." |
| `[294]` | **""No, I'll do it myself.""** | `[255]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "Lucian nodded and walked out." |
| `[306]` | **""Tell him to make her suffer.""** | `[245]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Narrator**: "Lucian nodded and walked out." |
| `[307]` | **""Tell him to make it painless.""** | `[245]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Narrator**: "Lucian nodded and walked out." |
| `[308]` | **""Thank you.""** | `[243]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Narrator**: "Lucian nodded and walked out." |
| `[309]` | **""Keep me informed.""** | `[243]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Narrator**: "Lucian nodded and walked out." |
| `[311]` | **""Stepping out for lunch. Hold my calls.""** | `[310]` **Narrator**: "I took a minute to gather my tho..."<br>`[333]` **Narrator**: "I took a minute to gather my tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Livia Suno**: ""Very well, Mr. President."" |
| `[312]` | **""I'm so sorry for the misunderstanding with Lucian. You've got a brilliant career ..."** | `[310]` **Narrator**: "I took a minute to gather my tho..."<br>`[333]` **Narrator**: "I took a minute to gather my tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Narrator**: "She looked at me a bit strangely." |
| `[313]` | **""Thank you for your hard work, Miss Suno.""** | `[310]` **Narrator**: "I took a minute to gather my tho..."<br>`[333]` **Narrator**: "I took a minute to gather my tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Narrator**: "She looked at me a bit strangely." |
| `[314]` | **"Say nothing."** | `[310]` **Narrator**: "I took a minute to gather my tho..."<br>`[333]` **Narrator**: "I took a minute to gather my tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "I took one long, last look at her." |
| `[321]` | **""Tell him to make them suffer.""** | `[249]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "Lucian nodded and walked out." |
| `[322]` | **""Tell him to make it painless.""** | `[249]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "Lucian nodded and walked out." |
| `[324]` | **""Thank you, Lucian.""** | `[254]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Narrator**: "Lucian nodded and walked out." |
| `[325]` | **""No, I'll do it myself.""** | `[254]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "Lucian nodded and walked out." |
| `[331]` | **""Thank you.""** | `[248]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "Lucian nodded and walked out." |
| `[332]` | **""Keep me informed.""** | `[248]` **Lucian Galade**: ""As you wish. I'll call Mr. Grei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "Lucian nodded and walked out." |
| `[340]` | **""Life, my friend. Life.""** | `[339]` **Petr Vectern**: ""Hello there, you two. What's th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Petr Vectern**: ""Anton, it's 11:30 in the morning."" |
| `[341]` | **""Surviving your affair without a scandal, of course.""** | `[339]` **Petr Vectern**: ""Hello there, you two. What's th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Petr Vectern**: ""Anton, it's 11:30 in the morning."" |
| `[342]` | **""Do I need an occasion to have a drink with my friend?""** | `[339]` **Petr Vectern**: ""Hello there, you two. What's th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Petr Vectern**: ""Anton, it's 11:30 in the morning."" |
| `[343]` | **""I just found this. Forgot I still had it left over from my first day in office.""** | `[339]` **Petr Vectern**: ""Hello there, you two. What's th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Petr Vectern**: ""Anton, it's 11:30 in the morning."" |
| `[351]` | **""I'm sorry. It's too late.""** | `[350]` **Petr Vectern**: ""I just want to do right by you,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Petr Vectern**: ""But--"" |
| `[352]` | **""Thank you. I'm sure you will.""** | `[350]` **Petr Vectern**: ""I just want to do right by you,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Narrator**: "Petr's eyes had that old sparkle..." |
| `[353]` | **""You don't need to make it up to me. Our friendship goes too deep for that:""** | `[350]` **Petr Vectern**: ""I just want to do right by you,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Narrator**: "Petr's eyes had that old sparkle..." |
| `[354]` | **""We'll see.""** | `[350]` **Petr Vectern**: ""I just want to do right by you,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Narrator**: "Petr's eyes had that old sparkle..." |
| `[357]` | **""I'm going back to work now.""** | `[355]` **Petr Vectern**: ""But--""<br>`[356]` **Narrator**: "Petr's eyes had that old sparkle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Narrator**: "I walked out, leaving the bottle..." |
| `[358]` | **""Goodbye, Petr.""** | `[355]` **Petr Vectern**: ""But--""<br>`[356]` **Narrator**: "Petr's eyes had that old sparkle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Narrator**: "I walked out, leaving the bottle..." |
| `[377]` | **""Are you sure about this?""** | `[79]` **Lucian Galade**: ""However, it did match that of a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[378]` **Lucian Galade**: ""Here. It's all in the report fr..." |
| `[382]` | **""It's okay, Lucian. I know exactly what you mean.""** | `[214]` **Lucian Galade**: ""What else could I have meant?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Narrator**: "I could almost see the gears in ..." |
| `[383]` | **""Have a nice one, old friend.""** | `[355]` **Petr Vectern**: ""But--""<br>`[356]` **Narrator**: "Petr's eyes had that old sparkle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Narrator**: "I walked out, leaving the bottle..." |
| `[384]` | **"Head to Petr's office."** | `[320]` **Narrator**: "I took one long, last look at her." | `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true` | *Brak zmian stanu* | `[338]` **Narrator**: "I knocked on the door, and Petr ..." |
| `[385]` | **"Head out."** | `[320]` **Narrator**: "I took one long, last look at her." | `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true` | *Brak zmian stanu* | `[334]` **Narrator**: "Petr was about to receive some v..." |
| `[403]` | **""Come to my office. You're making a scene out here.""** | `[326]` **Petr Vectern**: ""Anton... what the hell just hap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Narrator**: "Once Petr was in my office, I sh..." |
| `[404]` | **""I'll tell you in my office. Feel free to take a moment first.""** | `[326]` **Petr Vectern**: ""Anton... what the hell just hap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Narrator**: "Once Petr was in my office, I sh..." |
| `[408]` | **""Yes, let's.""** | `[407]` **Petr Vectern**: ""At least we finally have this o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[445]` **Petr Vectern**: ""I can't believe I was so carele..." |
| `[409]` | **""Yes, let's. But first, a drink.""** | `[407]` **Petr Vectern**: ""At least we finally have this o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Narrator**: "Petr eagerly nodded, then though..." |
| `[410]` | **""Actually, I have to tell you something...""** | `[407]` **Petr Vectern**: ""At least we finally have this o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[411]` **Petr Vectern**: ""Yeah? What is it?"" |
| `[412]` | **""Lucian wants you to resign.""** | `[411]` **Petr Vectern**: ""Yeah? What is it?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[432]` **Narrator**: "Petr looked up at me with an ind..." |
| `[413]` | **""I want you to resign.""** | `[411]` **Petr Vectern**: ""Yeah? What is it?"" | `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true` | *Brak zmian stanu* | `[415]` **Narrator**: "Petr looked up at me. His expres..." |
| `[414]` | **""Lucian wanted you to resign, but I told him it's not happening.""** | `[411]` **Petr Vectern**: ""Yeah? What is it?"" | `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false` | *Brak zmian stanu* | `[437]` **Narrator**: "Petr looked up at me in surprise." |
| `[416]` | **""You look like shit. Why don't you take the rest of the day off?""** | `[411]` **Petr Vectern**: ""Yeah? What is it?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Narrator**: "Petr looked at me gratefully." |
| `[426]` | **""Yes. Your philandering put all of us in danger.""** | `[425]` **Petr Vectern**: ""I... I guess I deserve this, do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Narrator**: "He exhaled slowly. I could see t..." |
| `[427]` | **""No. But we need someone to take the fall for this scandal, or the administration ..."** | `[425]` **Petr Vectern**: ""I... I guess I deserve this, do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Narrator**: "He exhaled slowly. I could see t..." |
| `[430]` | **""It was fun while it lasted.""** | `[429]` **Petr Vectern**: ""I'm so sorry, Anton. I was neve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Petr Vectern**: ""Sure was, old buddy."" |
| `[431]` | **""You really weren't. But at least you got a nice house out of the deal.""** | `[429]` **Petr Vectern**: ""I'm so sorry, Anton. I was neve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Petr Vectern**: ""Unless Evelyn takes it in the d..." |
| `[434]` | **""Actually, I agree with him. I'm announcing your resignation, Petr.""** | `[433]` **Petr Vectern**: ""Of course he does, that fink. D..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Narrator**: "Petr's face fell. He seemed to s..." |
| `[435]` | **""I did. We're laying this all at Rumburg's feet.""** | `[433]` **Petr Vectern**: ""Of course he does, that fink. D..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] ...` | `[447]` **Petr Vectern**: ""Oof. I hope they don't take it ..." |
| `[436]` | **""I did. This is as much my fault as it is yours. The administration will take the ..."** | `[433]` **Petr Vectern**: ""Of course he does, that fink. D..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] ...` | `[446]` **Petr Vectern**: ""That's... wow. I can't believe ..." |
| `[440]` | **""We're laying this all at Rumburg's feet.""** | `[438]` **Petr Vectern**: ""Really, Anton? That means a lot."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] ...` | `[447]` **Petr Vectern**: ""Oof. I hope they don't take it ..." |
| `[441]` | **""This is as much my fault as it is yours. The administration will take the hit.""** | `[438]` **Petr Vectern**: ""Really, Anton? That means a lot."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] ...` | `[446]` **Petr Vectern**: ""That's... wow. I can't believe ..." |
| `[450]` | **""You'll have some time before the news goes public. I suggest you get your affairs..."** | `[448]` **Petr Vectern**: ""Unless Evelyn takes it in the d..."<br>`[449]` **Petr Vectern**: ""Sure was, old buddy.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Petr Vectern**: ""All right, I get the message. B..." |
| `[451]` | **""Stay for a drink.""** | `[448]` **Petr Vectern**: ""Unless Evelyn takes it in the d..."<br>`[449]` **Petr Vectern**: ""Sure was, old buddy.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Narrator**: "Without waiting for him to answe..." |
| `[453]` | **""You did great. Sordland's just not ready for a vice president like you yet.""** | `[429]` **Petr Vectern**: ""I'm so sorry, Anton. I was neve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Petr Vectern**: ""Don't patronize me."" |
| `[455]` | **""We'll have some time before the news goes public. We should get our stories strai..."** | `[446]` **Petr Vectern**: ""That's... wow. I can't believe ..."<br>`[447]` **Petr Vectern**: ""Oof. I hope they don't take it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[462]` **Petr Vectern**: ""Sure, of course."" |
| `[456]` | **""Stay for a drink.""** | `[446]` **Petr Vectern**: ""That's... wow. I can't believe ..."<br>`[447]` **Petr Vectern**: ""Oof. I hope they don't take it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Petr Vectern**: ""No. My drunken idiocy got us in..." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaInvestigated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaInvestigated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Several days had passed since I ordered the investigation..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Several days had passed since the confrontation with Petr..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Several days had passed since I ordered the investigation into my secretary, Livia Suno."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Both Petr and Livia had been acting unnaturally nice to m..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Several days had passed since the confrontation with Petr, Livia and Lucian in my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Lucian was still acting frosty towards me for rejecting h..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Lucian was still acting frosty towards me for rejecting his advice. On the other hand, both Petr and Livia were unnaturally nice to me, though they avoided speaking to each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "I was just settling in behind my desk when Lucian knocked..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Both Petr and Livia had been acting unnaturally nice to me, believing I'd let them off the hook for their affair. They seemed to be avoiding each other in the hallways, though."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "I was just settling in behind my desk when Lucian knocked..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I was just settling in behind my desk when Lucian knocked on my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""Sir, a moment of your time?""*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Sir, a moment of your time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""Of course.""*)
  - -> `[13]` (*Player_Italic: "Motion for him to come in."*)
  - -> `[14]` (*Player: ""Not now.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Lucian entered my office and closed the door behind him."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Motion for him to come in."]** — Mówca: **Player_Italic**
> "I motioned for him to come in. He sat and closed the door behind him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated == true"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Not now.""]** — Mówca: **Player**
> ""Not now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""I'm afraid it's urgent.""*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""I'm afraid it's urgent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "He entered my office and closed the door behind him."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "He entered my office and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated == true"*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Lucian entered my office and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaInvestigated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaInvestigated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "Jump to: [Investigation Results Discussion]"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "Jump to: [Livia Firing Decision]"*)

### Węzeł `[21]`
Mówca: **Lucian Galade**
> ""I still believe you were wrong not to pursue an investigation into Miss Suno. However, I acknowledge my lack of concrete evidence and unorthodox information gathering method may have given you pause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""I could have been less rude to you about it, though.""*)
  - -> `[23]` (*Player: ""You're not going to change my mind about this.""*)
  - -> `[22]` (*Player: ""Unorthodox? You surveilled Petr behind my back!""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Unorthodox? You surveilled Petr behind my back!""]** — Mówca: **Player**
> ""Unorthodox? You surveilled Petr behind my back!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""I have already apologized to Mr. Vectern for the intrusi..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""You're not going to change my mind about this.""]** — Mówca: **Player**
> ""You're not going to change my mind about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: ""That isn't my goal.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I could have been less rude to you about it, though.""]** — Mówca: **Player**
> ""I could have been less rude to you about it, though.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""Perhaps.""*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""Perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Lucian looked me in the eye."*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""I feel I would be failing in my duties as a chief strategist not to give you one last piece of advice on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: ""Please, consider dismissing Miss Suno from her position ..."*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""That isn't my goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Lucian looked me in the eye."*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""I have already apologized to Mr. Vectern for the intrusion. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Lucian looked me in the eye."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Lucian looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: ""I feel I would be failing in my duties as a chief strate..."*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""Please, consider dismissing Miss Suno from her position at the palace. Just in case I am right after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""Well, she has been a distraction to Petr...""*)
  - -> `[32]` (*Player: ""I can't. She's so good at her job!""*)
  - -> `[31]` (*Player: ""Are you crazy? She'll go public about the affair.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Are you crazy? She'll go public about the affair.""]** — Mówca: **Player**
> ""Are you crazy? She'll go public about the affair.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: ""That might make a headline or two, but it won't sink you..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""I can't. She's so good at her job!""]** — Mówca: **Player**
> ""I can't. She's so good at her job!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Her looks may be unmatched, but her skills most certainl..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Well, she has been a distraction to Petr...""]** — Mówca: **Player**
> ""Well, she has been a distraction to Petr...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucian Galade: ""Keeping Mr. Vectern around may be another mistake. But t..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""How do I justify that to her?""]** — Mówca: **Player**
> ""How do I justify that to her?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: ""She slept with the vice president. Extremely unprofessio..."*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""She slept with the vice president. Extremely unprofessional behavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""All right. If it'll get you off my case, I'll fire her.""*)
  - -> `[39]` (*Player: ""No. I won't continue to indulge your paranoid fantasies...."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Her looks may be unmatched, but her skills most certainly are not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""All right. If it'll get you off my case, I'll fire her.""*)
  - -> `[39]` (*Player: ""No. I won't continue to indulge your paranoid fantasies...."*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""That might make a headline or two, but it won't sink your administration. Unlike a potential uncontrolled intelligence leak to Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""All right. If it'll get you off my case, I'll fire her.""*)
  - -> `[39]` (*Player: ""No. I won't continue to indulge your paranoid fantasies...."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""All right. If it'll get you off my case, I'll fire her.""]** — Mówca: **Player**
> ""All right. If it'll get you off my case, I'll fire her right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade), `[36]` (Lucian Galade), `[37]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: ""Thank you, Mr. President.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""No. I won't continue to indulge your paranoid fantasies. Livia stays.""]** — Mówca: **Player**
> ""No. I won't continue to indulge your paranoid fantasies. Livia stays.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade), `[36]` (Lucian Galade), `[37]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 2"*)

### Węzeł `[40]`
Mówca: **Lucian Galade**
> ""Keeping Mr. Vectern around may be another mistake. But that's a conversation for another time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""All right. If it'll get you off my case, I'll fire her.""*)
  - -> `[39]` (*Player: ""No. I won't continue to indulge your paranoid fantasies...."*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I called Livia into my office. She tentatively stepped in."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Lucian looked as if he was about to object one last time,..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Lucian looked as if he was about to object one last time, but then smiled thinly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: ""As you wish. I won't bring this up any further.""*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""As you wish. I won't bring this up any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He walked out and closed the door behind him."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "He walked out and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_LiviaStays =..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "I called Livia into my office. She tentatively stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Livia Suno: ""What is it, Mr. President?""*)

### Węzeł `[47]`
Mówca: **Livia Suno**
> ""What is it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true ||..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "I thought about how useful she'd been to me as a secretary -- and how much she knew about what I'd done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""You're fired, Livia.""*)
  - -> `[49]` (*Player: ""Nothing. Go back to work.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""Nothing. Go back to work.""]** — Mówca: **Player**
> ""Nothing. Go back to work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[176]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Livia Suno: ""Um... okay. Just let me know if you need anything.""*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""You're fired, Livia.""]** — Mówca: **Player**
> ""You're fired, Livia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[176]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Livia Suno: ""W-what? I thought we'd been over all this...""*)

### Węzeł `[51]`
Mówca: **Livia Suno**
> ""W-what? I thought we'd been over all this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""You're making Petr too distracted to work.""*)
  - -> `[59]` (*Player: ""Your performance has been abysmal lately.""*)
  - -> `[58]` (*Player: ""I don't share Lucian's suspicions that you're a spy, but..."*)
  - -> `[57]` (*Player: ""You're too ambitious for this job. Go get a proper unive..."*)

### Węzeł `[52]`
Mówca: **Livia Suno**
> ""Um... okay. Just let me know if you need anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Livia walked back out. Lucian looked at me in disbelief f..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""You're making Petr too distracted to work.""]** — Mówca: **Player**
> ""You're making Petr too distracted to work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Livia Suno: ""Then perhaps you should fire him.""*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Livia walked back out. Lucian looked at me in disbelief for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 2"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""You've made your point, Mr. President. I won't trouble y..."*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""You've made your point, Mr. President. I won't trouble you with this any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He walked out and closed the door behind him."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""You're too ambitious for this job. Go get a proper university education.""]** — Mówca: **Player**
> ""You're too ambitious for this job. Go get a proper university education.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Livia Suno: ""That's the best you could come up with?""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I don't share Lucian's suspicions that you're a spy, but I can't take the risk that he's right.""]** — Mówca: **Player**
> ""I don't share Lucian's suspicions that you're a spy, but I can't take the risk that he's right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Livia Suno: ""How prudent of you.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Your performance has been abysmal lately.""]** — Mówca: **Player**
> ""Your performance has been abysmal lately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Livia Suno: ""I know that's not true.""*)

### Węzeł `[60]`
Mówca: **Livia Suno**
> ""I know that's not true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "She glared at Lucian, then at me."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "She glared at Lucian, then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Livia Suno: ""I hope you're both happy. You've ruined a woman's career..."*)

### Węzeł `[62]`
Mówca: **Livia Suno**
> ""Then perhaps you should fire him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "She glared at Lucian, then at me."*)

### Węzeł `[63]`
Mówca: **Livia Suno**
> ""How prudent of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "She glared at Lucian, then at me."*)

### Węzeł `[64]`
Mówca: **Livia Suno**
> ""That's the best you could come up with?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "She glared at Lucian, then at me."*)

### Węzeł `[65]`
Mówca: **Livia Suno**
> ""I hope you're both happy. You've ruined a woman's career simply because she acted too much like a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaFired = true"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "She stormed out, slamming the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""Trust me, Mr. President, your decision was the correct o..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaFired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_LiviaFired =..."*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""Trust me, Mr. President, your decision was the correct one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: ""Yes, I know.""*)
  - -> `[70]` (*Player: ""Stop talking. Don't make this worse than it is.""*)
  - -> `[69]` (*Player: ""I hope so.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""I hope so.""]** — Mówca: **Player**
> ""I hope so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "I showed him out and went to brew myself a pot of coffee."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""Stop talking. Don't make this worse than it is.""]** — Mówca: **Player**
> ""Stop talking. Don't make this worse than it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "I showed him out and went to brew myself a pot of coffee."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""Yes, I know.""]** — Mówca: **Player**
> ""Yes, I know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "I showed him out and went to brew myself a pot of coffee."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "I showed him out and went to brew myself a pot of coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_InvestigationResults = true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Livia Firing Decision`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: ""I still believe you were wrong not to pursue an investig..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Livia Firing Decision]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "Livia Firing Decision"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Investigation Results Discussion`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_LiviaSpy = true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Investigation Results Discussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Investigation Results Discussion"*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""Our security team travelled to Lachaven to speak to the owners of the pub Miss Suno named. They confirmed that one Livia Suno had worked there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: ""Their description of her did not match that of your secr..."*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""Their description of her did not match that of your secretary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""However, it did match that of an unidentified corpse tha..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""However, it did match that of an unidentified corpse that washed up in Lenkurg Bay two months before your inauguration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""You mean...""*)
  - -> `[81]` (*Player: ""If that was Livia Suno... who's the woman working for me?""*)
  - -> `[80]` (*Player: ""Oh, shit.""*)
  - -> `[377]` (*Player: ""Are you sure about this?""*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Oh, shit.""]** — Mówca: **Player**
> ""Oh, shit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""Further investigation by our operatives in Rumburg match..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""If that was Livia Suno... who's the woman working for me?""]** — Mówca: **Player**
> ""If that was Livia Suno... who's the woman working for me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""Further investigation by our operatives in Rumburg match..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""You mean...""]** — Mówca: **Player**
> ""You mean...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""Further investigation by our operatives in Rumburg match..."*)

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""Further investigation by our operatives in Rumburg matched Miss Suno's description to a woman named Ilana Vance, last seen graduating from Crimsrad Political Sciences Institute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsyl..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""Our whistleblower from Rumburg recognized the name Vance..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""Recent coded transmissions from Rumburg have mentioned a..."*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""Our whistleblower from Rumburg recognized the name Vance as belonging to a deeply embedded covert agent, although he had previously assumed it was a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""How could we have missed all this?""*)
  - -> `[91]` (*Player: ""That lying, two-faced succubus!""*)
  - -> `[96]` (*Player: ""You should have figured this out ages ago.""*)
  - -> `[90]` (*Player: ""My God. You were right. I should never have doubted you.""*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Recent coded transmissions from Rumburg have mentioned a deeply embedded covert agent named Vance, but our intelligence always assumed it was a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""How could we have missed all this?""*)
  - -> `[91]` (*Player: ""That lying, two-faced succubus!""*)
  - -> `[96]` (*Player: ""You should have figured this out ages ago.""*)
  - -> `[90]` (*Player: ""My God. You were right. I should never have doubted you.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""How could we have missed all this?""]** — Mówca: **Player**
> ""How could we have missed all this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade), `[88]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""As mentioned, Miss Suno was hired without a background c..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""My God. You were right. I should never have doubted you.""]** — Mówca: **Player**
> ""My God. You were right. I should never have doubted you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade), `[88]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion += 1"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""That lying, two-faced succubus!""]** — Mówca: **Player**
> ""That lying, two-faced succubus!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade), `[88]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""To be fair, Miss Suno was just doing her job. Your vice ..."*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""As mentioned, Miss Suno was hired without a background check. It's possible this all could have been avoided, had any of Mr. Vectern's blood flow been directed to his brain when he selected her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucian Galade: ""But none of that can be helped now. The question is, wha..."*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""To be fair, Miss Suno was just doing her job. Your vice president, on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucian Galade: ""But none of that can be helped now. The question is, wha..."*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""The standard procedure would be to try Miss Suno for espionage. If we do so, it's only a matter of time before the media pieces together what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[113]` (*Player: ""I'll look like a fool for having her under my nose this ..."*)
  - -> `[114]` (*Player: ""Outwitted by a woman. It won't look good.""*)
  - -> `[118]` (*Player: ""What if there were no trial?""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Easy. I'll get Marcel on it.""]** — Mówca: **Player**
> ""Easy. I'll get Marcel on it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Kontekst wejściowy (poprzednik):** `[94]` (Lucian Galade), `[111]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""You should have figured this out ages ago.""]** — Mówca: **Player**
> ""You should have figured this out ages ago.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade), `[88]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""As mentioned, Miss Suno was hired without a background c..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucian Galade: ""I'm happy to hear that. Now, what are you going to do, s..."*)

### Węzeł `[98]`
Mówca: **Lucian Galade**
> ""I'm happy to hear that. Now, what are you going to do, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""Arrest her for espionage, of course.""*)
  - -> `[100]` (*Player: ""What do you think I should do?""*)
  - -> `[101]` (*Player: ""What do you mean? I'm going to murder them both.""*)
  - -> `[103]` (*Player: ""I'm going to have Petr castrated.""*)

### Węzeł `[99]`
Mówca: **Lucian Galade**
> ""But none of that can be helped now. The question is, what are you going to do, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""Arrest her for espionage, of course.""*)
  - -> `[100]` (*Player: ""What do you think I should do?""*)
  - -> `[101]` (*Player: ""What do you mean? I'm going to murder them both.""*)
  - -> `[103]` (*Player: ""I'm going to have Petr castrated.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""What do you think I should do?""]** — Mówca: **Player**
> ""What do you think I should do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade), `[99]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""The standard procedure would be to try Miss Suno for esp..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""What do you mean? I'm going to murder them both.""]** — Mówca: **Player**
> ""What do you mean? I'm going to murder them both.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade), `[99]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""Arrest her for espionage, of course.""]** — Mówca: **Player**
> ""Arrest her for espionage, of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade), `[99]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucian Galade: ""That would be standard procedure. However, if we do so i..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""I'm going to have Petr castrated.""]** — Mówca: **Player**
> ""I'm going to have Petr castrated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade), `[99]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: ""I wouldn't be opposed to that idea. But I meant with reg..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SecretState_LucianKnowsSSPKills == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SecretState_LucianKnowsSSPKills == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SecretState_LucianKnowsSSPKills == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Lucian lowered his voice."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SecretState_LucianKnowsSSPKills == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Lucian stroked his beard."*)

### Węzeł `[107]`
Mówca: **Lucian Galade**
> ""Perhaps as a last resort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""The standard procedure would be to try Miss Suno for esp..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Lucian lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucian Galade: ""Perhaps as a last resort.""*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Lucian stroked his beard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: ""I'm going to assume you're joking.""*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""I'm going to assume you're joking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""The standard procedure would be to try Miss Suno for esp..."*)

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""That would be standard procedure. However, if we do so it's only a matter of time before the media pieces together what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[113]` (*Player: ""I'll look like a fool for having her under my nose this ..."*)
  - -> `[114]` (*Player: ""Outwitted by a woman. It won't look good.""*)
  - -> `[118]` (*Player: ""What if there were no trial?""*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""I wouldn't be opposed to that idea. But I meant with regards to our spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""The standard procedure would be to try Miss Suno for esp..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I'll look like a fool for having her under my nose this entire time.""]** — Mówca: **Player**
> ""I'll look like a fool for having her under my nose this entire time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lucian Galade), `[111]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Outwitted by a woman. It won't look good.""]** — Mówca: **Player**
> ""Outwitted by a woman. It won't look good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lucian Galade), `[111]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true && BaseGa..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true && Base..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucian Galade: ""With the powers granted by your emergency decree, you co..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""What if there were no trial?""]** — Mówca: **Player**
> ""What if there were no trial?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lucian Galade), `[111]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""Asking Mr. Koronti for help would be advisable, but you'll still have to do a fair amount of crisis management yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucian Galade: ""Starting by letting Petr Vectern take the fall.""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_InvestigationResults = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_InvestigationResults"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ==..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucian Galade: ""With the powers granted by your emergency decree, you co..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucian Galade: ""Mr. Greiser and his men could certainly take care of thi..."*)

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""With the powers granted by your emergency decree, you could certainly detain her without a trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucian Galade: ""Alternately, you could mobilize Mr. Greiser and his men ..."*)

### Węzeł `[125]`
Mówca: **Lucian Galade**
> ""With the powers granted by your emergency decree, you could certainly detain her without a trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""You are right. Let's detain her immediately.""*)
  - -> `[129]` (*Player: ""Good. Let's detain her. And Petr, too -- this was all hi..."*)
  - -> `[130]` (*Player: ""No, no. I'd rather do it all above board.""*)

### Węzeł `[126]`
Mówca: **Lucian Galade**
> ""Mr. Greiser and his men could certainly take care of this in secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""Yes, brilliant. Let's do that.""*)
  - -> `[132]` (*Player: ""No, no. I'd rather do it all above board.""*)

### Węzeł `[127]`
Mówca: **Lucian Galade**
> ""Alternately, you could mobilize Mr. Greiser and his men to take care of the situation in secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: ""Detention without trial sounds like the easiest thing to..."*)
  - -> `[135]` (*Player: ""Let's use Karl. The fewer loose ends, the better.""*)
  - -> `[136]` (*Player: ""No, no. I'd rather do it all above board.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""You are right. Let's detain her immediately.""]** — Mówca: **Player**
> ""You are right. Let's detain her immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia = true"*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Good. Let's detain her. And Petr, too -- this was all his fault.""]** — Mówca: **Player**
> ""Good. Let's detain her. And Petr, too -- this was all his fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia = true"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""No, no. I'd rather do it all above board.""]** — Mówca: **Player**
> ""No, no. I'd rather do it all above board.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucian Galade: ""If you say so, sir. Are you ready to let Mr. Vectern tak..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""Yes, brilliant. Let's do that.""]** — Mówca: **Player**
> ""Yes, brilliant. Let's do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucian Galade: ""A wise choice, sir.""*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""No, no. I'd rather do it all above board.""]** — Mówca: **Player**
> ""No, no. I'd rather do it all above board.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: ""If you say so, sir. Are you ready to let Mr. Vectern tak..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Hide The Truth`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true && BaseGa..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Detention without trial sounds like the easiest thing to do.""]** — Mówca: **Player**
> ""Detention without trial sounds like the easiest thing to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Let's use Karl. The fewer loose ends, the better.""]** — Mówca: **Player**
> ""Let's use Karl. The fewer loose ends, the better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""No, no. I'd rather do it all above board.""]** — Mówca: **Player**
> ""No, no. I'd rather do it all above board.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucian Galade: ""If you say so, sir. Are you ready to let Mr. Vectern tak..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Public Trial - Blame Petr Or Not`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player: ""I know his actions were problematic...""*)
  - -> `[162]` (*Player: ""This is my fault as much as his. I should have suspected..."*)
  - -> `[160]` (*Player: ""No. No, I told you, Petr did nothing wrong!""*)
  - -> `[163]` (*Player: ""I know you think you'd be a better vice president. But e..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Public Trial - Blame Petr Or Not]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Public Trial - Blame Petr Or Not"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hide The Truth]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "Hide The Truth"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hide The Truth]"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lucian Galade: ""Then you'd -- what, exactly? Knowingly let her return to..."*)

### Węzeł `[143]`
Mówca: **Lucian Galade**
> ""Then you'd -- what, exactly? Knowingly let her return to Rumburg? That would damage us even further if the truth got out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: ""You must remain in control of the narrative, Mr. Preside..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true || Base..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: ""There are other options.""*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lucian Galade: ""That's why you must let Mr. Vectern take the fall.""*)

### Węzeł `[147]`
Mówca: **Lucian Galade**
> ""There are other options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hide The Truth]"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hide The Truth]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "Hide The Truth"*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> ""Asking Mr. Koronti for help would be advisable, but you'll still have to do a fair amount of crisis management yourself. Unless you opt to handle this another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hide The Truth]"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true || Base..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: ""Asking Mr. Koronti for help would be advisable, but you'..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: ""Asking Mr. Koronti for help would be advisable, but you'..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hide The Truth]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "Hide The Truth"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Public Trial - Blame Petr Or Not]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Public Trial - Blame Petr Or Not"*)

### Węzeł `[155]`
Mówca: **Lucian Galade**
> ""That's why you must let Mr. Vectern take the fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "Jump to: [Public Trial - Blame Petr Or Not]"*)

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""You must remain in control of the narrative, Mr. President. Starting by letting Petr Vectern take the fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "Jump to: [Public Trial - Blame Petr Or Not]"*)

### Węzeł `[157]`
Mówca: **Lucian Galade**
> ""Starting by letting Petr Vectern take the fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "Jump to: [Public Trial - Blame Petr Or Not]"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Public Trial - Blame Petr Or Not]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Public Trial - Blame Petr Or Not"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Public Trial - Blame Petr Or Not]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Public Trial - Blame Petr Or Not"*)

### Węzeł `[160]`
**[WYBÓR GRACZA: ""No. No, I told you, Petr did nothing wrong!""]** — Mówca: **Player**
> ""No. No, I told you, Petr did nothing wrong!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Lucian Galade), `[157]` (Lucian Galade), `[155]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucian Galade: ""Mr. Vectern put you in danger by failing to order a back..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: ""I know his actions were problematic...""]** — Mówca: **Player**
> ""I know his actions were problematic...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Lucian Galade), `[157]` (Lucian Galade), `[155]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lucian Galade: ""Problematic is an understatement.""*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""This is my fault as much as his. I should have suspected something.""]** — Mówca: **Player**
> ""This is my fault as much as his. I should have suspected something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Lucian Galade), `[157]` (Lucian Galade), `[155]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucian Galade: ""You can share the blame, but you have to prepare for you..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""I know you think you'd be a better vice president. But enough is enough.""]** — Mówca: **Player**
> ""I know you think you'd be a better vice president. But enough is enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Lucian Galade), `[157]` (Lucian Galade), `[155]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucian Galade: ""Mr. President, rest assured this is not about me.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA: ""You can share the blame, but you have to prepare for your public opinion to nosedive.""]** — Mówca: **Lucian Galade**
> ""You can share the blame, but you have to prepare for your public opinion to nosedive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[165]`
Mówca: **Lucian Galade**
> ""Thankfully, Mr. Koronti can soften that blow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucian Galade: ""But please, take a moment to think about this.""*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Turn07_A_Marcel_Threatened == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Turn07_A_Marcel_Threatened == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Turn07_A_Marcel_Threatened"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lucian Galade: ""Thankfully, Mr. Koronti can soften that blow.""*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Turn07_A_Marcel_Threatened == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Turn07_A_Marcel_Threatened"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucian Galade: ""But please, take a moment to think about this.""*)

### Węzeł `[169]`
Mówca: **Lucian Galade**
> ""Mr. Vectern put you in danger by failing to order a background check on your closest personal staff. He betrayed your confidence to a woman with whom he was committing adultery. Anton, would you do the same to your so-called best friend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""I-- no. I wouldn't.""*)
  - -> `[174]` (*Player: ""For a woman I loved? Maybe I would!""*)
  - -> `[175]` (*Player: ""I don't know. I can't put myself in his shoes.""*)

### Węzeł `[170]`
Mówca: **Lucian Galade**
> ""Problematic is an understatement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucian Galade: ""Mr. Vectern put you in danger by failing to order a back..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""I-- no. I wouldn't.""]** — Mówca: **Player**
> ""I-- no. I wouldn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Lucian sighed."*)

### Węzeł `[172]`
Mówca: **Lucian Galade**
> ""Mr. President, rest assured this is not about me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucian Galade: ""Mr. Vectern put you in danger by failing to order a back..."*)

### Węzeł `[173]`
Mówca: **Lucian Galade**
> ""But please, take a moment to think about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucian Galade: ""Mr. Vectern put you in danger by failing to order a back..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""For a woman I loved? Maybe I would!""]** — Mówca: **Player**
> ""For a woman I loved? Maybe I would!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Lucian sighed."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""I don't know. I can't put myself in his shoes.""]** — Mówca: **Player**
> ""I don't know. I can't put myself in his shoes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: ""Try guzzling half a bottle of whiskey. That might help.""*)

### Węzeł `[176]`
Mówca: **Narrator**
> "I thought about how useful she'd been to me as a secretary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""You're fired, Livia.""*)
  - -> `[49]` (*Player: ""Nothing. Go back to work.""*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true ||..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusiness == true ..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "I thought about how useful she'd been to me as a secretar..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "I thought about how useful she'd been to me as a secretary."*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""Try guzzling half a bottle of whiskey. That might help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Lucian sighed."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Lucian sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucian Galade: ""I am your chief strategist. I have advised you on what I..."*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""If you say so, sir. Are you ready to let Mr. Vectern take the fall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "Jump to: [Public Trial - Blame Petr Or Not]"*)

### Węzeł `[183]`
Mówca: **Lucian Galade**
> ""If you say so, sir. Are you ready to let Mr. Vectern take the fall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "Jump to: [Public Trial - Blame Petr Or Not]"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Public Trial - Blame Petr Or Not]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Public Trial - Blame Petr Or Not"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Public Trial - Blame Petr Or Not]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Public Trial - Blame Petr Or Not"*)

### Węzeł `[186]`
Mówca: **Lucian Galade**
> ""If you say so, sir. Are you ready to let Mr. Vectern take the fall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "Jump to: [Public Trial - Blame Petr Or Not]"*)

### Węzeł `[187]`
Mówca: **Lucian Galade**
> ""I am your chief strategist. I have advised you on what I believe is the best strategy. But of course, the ultimate decision is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""All right. Petr will be our scapegoat.""*)
  - -> `[188]` (*Player: ""I will shoulder the blame along with him.""*)
  - -> `[190]` (*Player: ""I will blame Livia -- I mean, Ilana -- and nobody else.""*)

### Węzeł `[188]`
**[WYBÓR GRACZA: ""I will shoulder the blame along with him.""]** — Mówca: **Player**
> ""I will shoulder the blame along with him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame = true"*)

### Węzeł `[189]`
**[WYBÓR GRACZA: ""All right. Petr will be our scapegoat.""]** — Mówca: **Player**
> ""All right. Petr will be our scapegoat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak = true"*)

### Węzeł `[190]`
**[WYBÓR GRACZA: ""I will blame Livia -- I mean, Ilana -- and nobody else.""]** — Mówca: **Player**
> ""I will blame Livia -- I mean, Ilana -- and nobody else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything = true"*)

### Węzeł `[192]`
Mówca: **Narrator**
> "Lucian looked as if he was about to object one last time, but instead smiled thinly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Relations..."*)

### Węzeł `[193]`
Mówca: **Lucian Galade**
> ""Very well. I shall consult with our friend Mr. Koronti and write a statement for you to read at the press conference. I'll leave you to handle Miss Vance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: ""With pleasure.""*)
  - -> `[199]` (*Player: ""Thank you.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false && BaseGame.Turn07_Detained_MarcelKoronti == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Relations..."*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Relatio..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false && BaseGame.Turn07_Detained_MarcelKoronti == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Lucian Galade: ""Very well. I shall consult with our friend Mr. Koronti a..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false && BaseGame.Turn07_Detained_MarcelKoronti == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: ""Very well. I shall write a statement for you to read at ..."*)

### Węzeł `[197]`
Mówca: **Lucian Galade**
> ""Very well. I shall write a statement for you to read at the press conference. I'll leave you to handle Miss Vance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: ""With pleasure.""*)
  - -> `[199]` (*Player: ""Thank you.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA: ""With pleasure.""]** — Mówca: **Player**
> ""With pleasure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Lucian Galade), `[197]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[199]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Lucian Galade), `[197]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[200]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player: ""Great. Let's detain her immediately.""*)
  - -> `[202]` (*Player: ""Great. Let's detain both her and Petr. He got us into th..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA: ""Great. Let's detain her immediately.""]** — Mówca: **Player**
> ""Great. Let's detain her immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia = true"*)

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Great. Let's detain both her and Petr. He got us into this mess, after all.""]** — Mówca: **Player**
> ""Great. Let's detain both her and Petr. He got us into this mess, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia = true"*)

### Węzeł `[203]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "Jump to: [Secret Police Talk]"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Secret Police Talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player: ""By 'take care of', you mean secretly arrest, right?""*)
  - -> `[209]` (*Player: ""By 'take care of', you mean 'take care of for good', rig..."*)

### Węzeł `[205]`
Mówca: **Lucian Galade**
> ""A wise choice, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "Jump to: [Secret Police Talk]"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Secret Police Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "Secret Police Talk"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Secret Police Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "Secret Police Talk"*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""By 'take care of', you mean secretly arrest, right?""]** — Mówca: **Player**
> ""By 'take care of', you mean secretly arrest, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Lucian Galade), `[203]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[209]`
**[WYBÓR GRACZA: ""By 'take care of', you mean 'take care of for good', right?""]** — Mówca: **Player**
> ""By 'take care of', you mean 'take care of for good', right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Lucian Galade), `[203]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[210]`
Mówca: **Lucian Galade**
> ""I think you know precisely what I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SecretState_LucianKnowsSSPKills == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SecretState_LucianKnowsSSPKills == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SecretState_LucianKnowsSSPKills == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: ""I think you know precisely what I mean.""*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SecretState_LucianKnowsSSPKills == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucian Galade: ""What else could I have meant?""*)

### Węzeł `[214]`
Mówca: **Lucian Galade**
> ""What else could I have meant?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player: ""It's okay, Lucian. I know exactly what you mean.""*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_KesaroKibener == true ||..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SecretState_LucianKnowsSSPKills == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SecretState_LucianKnowsSSPKills == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SecretState_LucianKnowsSSPKills == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucian Galade: ""I think you know precisely what I mean.""*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SecretState_LucianKnowsSSPKills == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: ""It means whatever you want it to mean, sir.""*)

### Węzeł `[218]`
Mówca: **Lucian Galade**
> ""I think you know precisely what I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[219]`
Mówca: **Lucian Galade**
> ""It means whatever you want it to mean, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[220]`
Mówca: **Narrator**
> "Lucian nodded and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "I called Karl Greiser from my desk and explained the situ..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_BlamePetrFor..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_DenyEverythi..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_KesaroKibener == true ||..."*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_KesaroKibener == true ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""Uh, nothing.""*)
  - -> `[228]` (*Player: ""Kill, perhaps? It's been done before.""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player: ""Nothing...""*)
  - -> `[231]` (*Player: ""Kill, maybe?""*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Uh, nothing.""]** — Mówca: **Player**
> ""Uh, nothing.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "I could almost see the gears in Lucian's head turning."*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""Nothing...""]** — Mówca: **Player**
> ""Nothing...""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "I could almost see the gears in Lucian's head turning."*)

### Węzeł `[228]`
**[WYBÓR GRACZA: ""Kill, perhaps? It's been done before.""]** — Mówca: **Player**
> ""Kill, perhaps? It's been done before.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[229]`
Mówca: **Lucian Galade**
> ""I see. Curious that I wasn't informed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucian Galade: ""I see. Curious that I wasn't informed.""*)

### Węzeł `[231]`
**[WYBÓR GRACZA: ""Kill, maybe?""]** — Mówca: **Player**
> ""Kill, maybe?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[232]`
Mówca: **Lucian Galade**
> ""If made to look like an accident, another covert assassination could solve our problem before it even starts. But I understand if you still harbor fond feelings for Miss Vance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player: ""Let's just have her arrested, okay?""*)
  - -> `[235]` (*Player: ""Let's just have her arrested -- and Petr, too, while we'..."*)
  - -> `[236]` (*Player: ""Screw Liv--Ilana. Let's have her killed.""*)
  - -> `[237]` (*Player: ""Screw Miss Vance. And Petr too! Let's have them both kil..."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "I could almost see the gears in Lucian's head turning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)

### Węzeł `[234]`
**[WYBÓR GRACZA: ""Let's just have her arrested, okay?""]** — Mówca: **Player**
> ""Let's just have her arrested, okay?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Lucian Galade), `[476]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia = true"*)

### Węzeł `[235]`
**[WYBÓR GRACZA: ""Let's just have her arrested -- and Petr, too, while we're at it. He's done enough harm to this administration.""]** — Mówca: **Player**
> ""Let's just have her arrested -- and Petr, too, while we're at it. He's done enough harm to this administration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Lucian Galade), `[476]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia = true"*)

### Węzeł `[236]`
**[WYBÓR GRACZA: ""Screw Liv--Ilana. Let's have her killed.""]** — Mówca: **Player**
> ""Screw Liv--Ilana. Let's have her killed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Lucian Galade), `[476]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia = true"*)

### Węzeł `[237]`
**[WYBÓR GRACZA: ""Screw Miss Vance. And Petr too! Let's have them both killed.""]** — Mówca: **Player**
> ""Screw Miss Vance. And Petr too! Let's have them both killed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Lucian Galade), `[476]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr = true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia = true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr = true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_..."*)

### Węzeł `[243]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away. It ought to be done by the end of today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player: ""Thank you.""*)
  - -> `[309]` (*Player: ""Keep me informed.""*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_..."*)

### Węzeł `[245]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away. It ought to be done by the end of today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Player: ""Tell him to make her suffer.""*)
  - -> `[307]` (*Player: ""Tell him to make it painless.""*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Lucian was trying very hard not to appear pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Lucian Galade: ""As you wish. I'll call Mr. Greiser right away. It ought ..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "Lucian was trying very hard not to appear pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Lucian Galade: ""As you wish. I'll call Mr. Greiser right away. It ought ..."*)

### Węzeł `[248]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away. It ought to be done by the end of today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Player: ""Thank you.""*)
  - -> `[332]` (*Player: ""Keep me informed.""*)

### Węzeł `[249]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away. It ought to be done by the end of today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Player: ""Tell him to make them suffer.""*)
  - -> `[322]` (*Player: ""Tell him to make it painless.""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_LiviaDetaine..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Petr = true"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Petr = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_LiviaAndPetr..."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "Lucian was trying very hard not to appear pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Lucian Galade: ""As you wish. I'll call Mr. Greiser right away.""*)

### Węzeł `[254]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player: ""Thank you, Lucian.""*)
  - -> `[325]` (*Player: ""No, I'll do it myself.""*)

### Węzeł `[255]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player: ""Thank you, Lucian.""*)
  - -> `[294]` (*Player: ""No, I'll do it myself.""*)

### Węzeł `[256]`
Mówca: **Narrator**
> "I called Karl Greiser from my desk and explained the situation. After a few minutes, I rang for Livia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "She entered my office."*)

### Węzeł `[257]`
Mówca: **Livia Suno**
> ""Is there something you need, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player: ""You tell me... Ilana.""*)
  - -> `[260]` (*Player: ""It's been a pleasure working with you, Livia.""*)
  - -> `[261]` (*Player: ""Yes. I need you to stop pretending.""*)
  - -> `[262]` (*Player: ""Please, sit down.""*)

### Węzeł `[258]`
Mówca: **Narrator**
> "She entered my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Livia Suno: ""Is there something you need, Mr. President?""*)

### Węzeł `[259]`
**[WYBÓR GRACZA: ""You tell me... Ilana.""]** — Mówca: **Player**
> ""You tell me... Ilana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "A barely perceptible flash of fear crossed her face."*)

### Węzeł `[260]`
**[WYBÓR GRACZA: ""It's been a pleasure working with you, Livia.""]** — Mówca: **Player**
> ""It's been a pleasure working with you, Livia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "A barely perceptible flash of fear crossed her face."*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""Yes. I need you to stop pretending.""]** — Mówca: **Player**
> ""Yes. I need you to stop pretending.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "A barely perceptible flash of fear crossed her face."*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Please, sit down.""]** — Mówca: **Player**
> ""Please, sit down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "A barely perceptible flash of fear crossed her face. She ..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "A barely perceptible flash of fear crossed her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Livia Suno: ""Livia, sir. My name is Livia.""*)

### Węzeł `[264]`
Mówca: **Livia Suno**
> ""Livia, sir. My name is Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "I nodded toward my office doorway. Karl Greiser was stand..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "A barely perceptible flash of fear crossed her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Livia Suno: ""Wh-what do you mean, sir?""*)

### Węzeł `[266]`
Mówca: **Livia Suno**
> ""Wh-what do you mean, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "I nodded toward my office doorway. Karl Greiser was stand..."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "A barely perceptible flash of fear crossed her face. She sat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Livia Suno: ""Why did you call me in here, sir?""*)

### Węzeł `[268]`
Mówca: **Livia Suno**
> ""Why did you call me in here, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "I nodded toward my office doorway. Karl Greiser was stand..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "I nodded toward my office doorway. Karl Greiser was standing there along with two of his guards, blocking the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Karl Greiser: ""Ilana Vance, you are under arrest on suspicion of espion..."*)

### Węzeł `[270]`
Mówca: **Karl Greiser**
> ""Ilana Vance, you are under arrest on suspicion of espionage. Please come with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "Her eyes darted around the room."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "Her eyes darted around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Livia Suno: ""What the hell is going on? Mr. President, have you let L..."*)

### Węzeł `[272]`
Mówca: **Livia Suno**
> ""What the hell is going on? Mr. President, have you let Lucian get to your head? I thought you were smarter than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: ""You're going to pay for your lies, Ilana.""*)
  - -> `[274]` (*Player: ""You're going to pay for the way you used Petr.""*)
  - -> `[275]` (*Player: ""I'm sorry it had to come to this.""*)
  - -> `[276]` (*Player: ""If you thought I wouldn't trust my closest advisor, you'..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA: ""You're going to pay for your lies, Ilana.""]** — Mówca: **Player**
> ""You're going to pay for your lies, Ilana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Karl's men grabbed her arms and began dragging her out."*)

### Węzeł `[274]`
**[WYBÓR GRACZA: ""You're going to pay for the way you used Petr.""]** — Mówca: **Player**
> ""You're going to pay for the way you used Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Karl's men grabbed her arms and began dragging her out."*)

### Węzeł `[275]`
**[WYBÓR GRACZA: ""I'm sorry it had to come to this.""]** — Mówca: **Player**
> ""I'm sorry it had to come to this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Karl's men grabbed her arms and began dragging her out."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: ""If you thought I wouldn't trust my closest advisor, you're the stupid one.""]** — Mówca: **Player**
> ""If you thought I wouldn't trust my closest advisor, you're the stupid one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Karl's men grabbed her arms and began dragging her out."*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Karl's men grabbed her arms and began dragging her out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Livia Suno: ""No. No! You can't do this to me!""*)

### Węzeł `[278]`
Mówca: **Livia Suno**
> ""No. No! You can't do this to me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Petr, hearing her cries, rushed out of his office."*)

### Węzeł `[279]`
Mówca: **Petr Vectern**
> ""Liv? What in the hell!? Anton, what's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player: ""Her name's Ilana. Lucian was right about her. She's a spy.""*)
  - -> `[282]` (*Player: ""She was using you all along, Petr.""*)
  - -> `[283]` (*Player: ""Livia, tell Petr who you really are.""*)
  - -> `[284]` (*Player_Italic: "Say nothing."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "Petr, hearing her cries, rushed out of his office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Petr Vectern: ""Liv? What in the hell!? Anton, what's going on?""*)

### Węzeł `[281]`
**[WYBÓR GRACZA: ""Her name's Ilana. Lucian was right about her. She's a spy.""]** — Mówca: **Player**
> ""Her name's Ilana. Lucian was right about her. She's a spy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Petr Vectern: ""No. That can't be true. Can it? Liv?""*)

### Węzeł `[282]`
**[WYBÓR GRACZA: ""She was using you all along, Petr.""]** — Mówca: **Player**
> ""She was using you all along, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Petr Vectern: ""No. That can't be true. Can it? Liv?""*)

### Węzeł `[283]`
**[WYBÓR GRACZA: ""Livia, tell Petr who you really are.""]** — Mówca: **Player**
> ""Livia, tell Petr who you really are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Livia Suno: ""I won't say another word without a lawyer present.""*)

### Węzeł `[284]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing. Petr ran up to my now ex-secretary."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Petr Vectern: ""Liv! Come on, tell them this was all a misunderstanding.""*)

### Węzeł `[285]`
Mówca: **Livia Suno**
> ""I won't say another word without a lawyer present.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true"*)

### Węzeł `[286]`
Mówca: **Narrator**
> "She looked Petr square in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Livia Suno: ""Except this. You're a sad old drunk and a lousy lay.""*)

### Węzeł `[287]`
Mówca: **Livia Suno**
> ""Except this. You're a sad old drunk and a lousy lay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Livia Suno: ""Honestly, if I *were* a Rumburg spy, I'd barely have to ..."*)

### Węzeł `[288]`
Mówca: **Petr Vectern**
> ""No. That can't be true. Can it? Liv?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Livia Suno: ""I won't say another word without a lawyer present.""*)

### Węzeł `[289]`
Mówca: **Petr Vectern**
> ""Liv! Come on, tell them this was all a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Livia Suno: ""I won't say another word without a lawyer present.""*)

### Węzeł `[290]`
Mówca: **Livia Suno**
> ""Honestly, if I *were* a Rumburg spy, I'd barely have to do a thing. You two have Sordland ripe for the taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled = true"*)

### Węzeł `[291]`
Mówca: **Narrator**
> "She straightened up, ran a hand through her curls and allowed Karl to lead her away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Petr sank to the floor in front of me."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "Petr sank to the floor in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Petr == true"*)

### Węzeł `[293]`
**[WYBÓR GRACZA: ""Thank you, Lucian.""]** — Mówca: **Player**
> ""Thank you, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[294]`
**[WYBÓR GRACZA: ""No, I'll do it myself.""]** — Mówca: **Player**
> ""No, I'll do it myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "Lucian nodded and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "I waited a few minutes, then rang for Livia."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "I waited a few minutes, then rang for Livia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "She entered my office."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Livia == true)"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Karl Greiser: ""No lawyers, ma'am. You're going away for a very long time.""*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Livia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "She looked Petr square in the eye."*)

### Węzeł `[300]`
Mówca: **Karl Greiser**
> ""No lawyers, ma'am. You're going away for a very long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Livia Suno: ""Fine. Then I will say this.""*)

### Węzeł `[301]`
Mówca: **Livia Suno**
> ""Fine. Then I will say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "She looked Petr square in the eye."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "She looked Petr square in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Livia Suno: ""You're a sad old drunk and a lousy lay.""*)

### Węzeł `[303]`
Mówca: **Livia Suno**
> ""You're a sad old drunk and a lousy lay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Livia Suno: ""Honestly, if I *were* a Rumburg spy, I'd barely have to ..."*)

### Węzeł `[304]`
Mówca: **Livia Suno**
> ""Honestly, if I *were* a Rumburg spy, I'd barely have to do a thing. You two have Sordland ripe for the taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "She straightened up, ran a hand through her curls and all..."*)

### Węzeł `[305]`
Mówca: **Narrator**
> "Lucian nodded and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "I took a minute to gather my thoughts, then headed out th..."*)

### Węzeł `[306]`
**[WYBÓR GRACZA: ""Tell him to make her suffer.""]** — Mówca: **Player**
> ""Tell him to make her suffer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[307]`
**[WYBÓR GRACZA: ""Tell him to make it painless.""]** — Mówca: **Player**
> ""Tell him to make it painless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[308]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[309]`
**[WYBÓR GRACZA: ""Keep me informed.""]** — Mówca: **Player**
> ""Keep me informed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "I took a minute to gather my thoughts, then headed out the office. My secretary was outside, typing up some correspondence at her desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: ""Stepping out for lunch. Hold my calls.""*)
  - -> `[312]` (*Player: ""I'm so sorry for the misunderstanding with Lucian. You'v..."*)
  - -> `[313]` (*Player: ""Thank you for your hard work, Miss Suno.""*)
  - -> `[314]` (*Player_Italic: "Say nothing."*)

### Węzeł `[311]`
**[WYBÓR GRACZA: ""Stepping out for lunch. Hold my calls.""]** — Mówca: **Player**
> ""Stepping out for lunch. Hold my calls.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[333]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Livia Suno: ""Very well, Mr. President.""*)

### Węzeł `[312]`
**[WYBÓR GRACZA: ""I'm so sorry for the misunderstanding with Lucian. You've got a brilliant career ahead of you.""]** — Mówca: **Player**
> ""I'm sorry again for the misunderstanding with Lucian. You've got a brilliant career ahead of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[333]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "She looked at me a bit strangely."*)

### Węzeł `[313]`
**[WYBÓR GRACZA: ""Thank you for your hard work, Miss Suno.""]** — Mówca: **Player**
> ""Thank you for your hard work, Miss Suno.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[333]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "She looked at me a bit strangely."*)

### Węzeł `[314]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing as I walked past her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[333]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I took one long, last look at her."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "She looked at me a bit strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Livia Suno: ""Thank you, Mr. President.""*)

### Węzeł `[316]`
Mówca: **Livia Suno**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I took one long, last look at her."*)

### Węzeł `[317]`
Mówca: **Livia Suno**
> ""Very well, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I took one long, last look at her."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "She looked at me a bit strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Livia Suno: ""No trouble at all, Mr. President.""*)

### Węzeł `[319]`
Mówca: **Livia Suno**
> ""No trouble at all, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I took one long, last look at her."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "I took one long, last look at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == t..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA: ""Tell him to make them suffer.""]** — Mówca: **Player**
> ""Tell him to make them suffer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[322]`
**[WYBÓR GRACZA: ""Tell him to make it painless.""]** — Mówca: **Player**
> ""Tell him to make it painless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[323]`
Mówca: **Narrator**
> "Lucian nodded and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "I took a minute to gather my thoughts, then left the room..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Thank you, Lucian.""]** — Mówca: **Player**
> ""Thank you, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[325]`
**[WYBÓR GRACZA: ""No, I'll do it myself.""]** — Mówca: **Player**
> ""No, I'll do it myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[326]`
Mówca: **Petr Vectern**
> ""Anton... what the hell just happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Player: ""Come to my office. You're making a scene out here.""*)
  - -> `[404]` (*Player: ""I'll tell you in my office. Feel free to take a moment f..."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "How could I tell him that the worst was still yet to come?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_LiviaSpyReveal = true"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Petr == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Petr == true)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "How could I tell him that the worst was still yet to come?"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Petr Vectern: ""Anton... what the hell just happened?""*)

### Węzeł `[331]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[332]`
**[WYBÓR GRACZA: ""Keep me informed.""]** — Mówca: **Player**
> ""Keep me informed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "Lucian nodded and walked out."*)

### Węzeł `[333]`
Mówca: **Narrator**
> "I took a minute to gather my thoughts, then left the room, taking my bottle of Erlory Maroon whiskey with me. My secretary was outside, typing up some correspondence at her desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: ""Stepping out for lunch. Hold my calls.""*)
  - -> `[312]` (*Player: ""I'm so sorry for the misunderstanding with Lucian. You'v..."*)
  - -> `[313]` (*Player: ""Thank you for your hard work, Miss Suno.""*)
  - -> `[314]` (*Player_Italic: "Say nothing."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "Petr was about to receive some very unpleasant news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_InvestigationResults = true"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == t..."*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr ==..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player_Italic: "Head to Petr's office."*)
  - -> `[385]` (*Player_Italic: "Head out."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "Petr was about to receive some very unpleasant news."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "I knocked on the door, and Petr answered. He looked at the bottle of whiskey, then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Petr Vectern: ""Hello there, you two. What's the occasion?""*)

### Węzeł `[339]`
Mówca: **Petr Vectern**
> ""Hello there, you two. What's the occasion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player: ""Life, my friend. Life.""*)
  - -> `[341]` (*Player: ""Surviving your affair without a scandal, of course.""*)
  - -> `[342]` (*Player: ""Do I need an occasion to have a drink with my friend?""*)
  - -> `[343]` (*Player: ""I just found this. Forgot I still had it left over from ..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA: ""Life, my friend. Life.""]** — Mówca: **Player**
> ""Life, my friend. Life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Petr Vectern: ""Anton, it's 11:30 in the morning.""*)

### Węzeł `[341]`
**[WYBÓR GRACZA: ""Surviving your affair without a scandal, of course.""]** — Mówca: **Player**
> ""Surviving your affair without a scandal, of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Petr Vectern: ""Anton, it's 11:30 in the morning.""*)

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Do I need an occasion to have a drink with my friend?""]** — Mówca: **Player**
> ""Do I need an occasion to have a drink with my friend?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Petr Vectern: ""Anton, it's 11:30 in the morning.""*)

### Węzeł `[343]`
**[WYBÓR GRACZA: ""I just found this. Forgot I still had it left over from my first day in office.""]** — Mówca: **Player**
> ""I just found this. Forgot I still had it left over from my first day in office.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Petr Vectern: ""Anton, it's 11:30 in the morning.""*)

### Węzeł `[344]`
Mówca: **Petr Vectern**
> ""Anton, it's 11:30 in the morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "He cracked a smile."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "He cracked a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Petr Vectern: ""What are we waiting for?""*)

### Węzeł `[346]`
Mówca: **Petr Vectern**
> ""What are we waiting for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "He brought out two glasses, and I filled them up. We dran..."*)

### Węzeł `[347]`
Mówca: **Narrator**
> "He brought out two glasses, and I filled them up. We drank in silence for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Petr Vectern: ""Lucian was right. I've been a miserable excuse for a vic..."*)

### Węzeł `[348]`
Mówca: **Petr Vectern**
> ""Lucian was right. I've been a miserable excuse for a vice president. But I'm ready to start over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Petr Vectern: ""No more affairs. No more being late. No more -- well, le..."*)

### Węzeł `[349]`
Mówca: **Petr Vectern**
> ""No more affairs. No more being late. No more -- well, less drinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Petr Vectern: ""I just want to do right by you, Anton. As a colleague an..."*)

### Węzeł `[350]`
Mówca: **Petr Vectern**
> ""I just want to do right by you, Anton. As a colleague and as a friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: ""I'm sorry. It's too late.""*)
  - -> `[352]` (*Player: ""Thank you. I'm sure you will.""*)
  - -> `[353]` (*Player: ""You don't need to make it up to me. Our friendship goes ..."*)
  - -> `[354]` (*Player: ""We'll see.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA: ""I'm sorry. It's too late.""]** — Mówca: **Player**
> ""I'm sorry. It's too late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Petr Vectern: ""But--""*)

### Węzeł `[352]`
**[WYBÓR GRACZA: ""Thank you. I'm sure you will.""]** — Mówca: **Player**
> ""Thank you. I'm sure you will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "Petr's eyes had that old sparkle in them again."*)

### Węzeł `[353]`
**[WYBÓR GRACZA: ""You don't need to make it up to me. Our friendship goes too deep for that:""]** — Mówca: **Player**
> ""You don't need to make it up to me. Our friendship goes too deep for that:""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "Petr's eyes had that old sparkle in them again."*)

### Węzeł `[354]`
**[WYBÓR GRACZA: ""We'll see.""]** — Mówca: **Player**
> ""We'll see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "Petr's eyes had that old sparkle in them again."*)

### Węzeł `[355]`
Mówca: **Petr Vectern**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: ""I'm going back to work now.""*)
  - -> `[358]` (*Player: ""Goodbye, Petr.""*)
  - -> `[383]` (*Player: ""Have a nice one, old friend.""*)

### Węzeł `[356]`
Mówca: **Narrator**
> "Petr's eyes had that old sparkle in them again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: ""I'm going back to work now.""*)
  - -> `[358]` (*Player: ""Goodbye, Petr.""*)
  - -> `[383]` (*Player: ""Have a nice one, old friend.""*)

### Węzeł `[357]`
**[WYBÓR GRACZA: ""I'm going back to work now.""]** — Mówca: **Player**
> ""I'm going back to work now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Petr Vectern), `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I walked out, leaving the bottle on his desk."*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""Goodbye, Petr.""]** — Mówca: **Player**
> ""Goodbye, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Petr Vectern), `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I walked out, leaving the bottle on his desk."*)

### Węzeł `[359]`
Mówca: **Narrator**
> "I walked out, leaving the bottle on his desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Narrator: "I returned home that evening and headed straight to my st..."*)

### Węzeł `[360]`
Mówca: **Narrator**
> "I returned home that evening and headed straight to my study, waiting for Karl to call."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_InvestigationResults = true"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_ShareBlame =..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaStays = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_InvestigationResults = true"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_LiviaSpyReveal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_LiviaSpyReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_LiviaSpyReveal = true"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_LiviaSpyReveal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_LiviaSpyReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_LiviaSpyReveal = true"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_LiviaSpyReveal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_LiviaSpyReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_InvestigationResults = true"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true) || (BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ==..."*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true) || (BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_LiviaPetrGone = true"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true) || (BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaFired == true || BaseG..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_PressRelease = true;
BaseGame.Situation_Order_InfiltratedIntelligence = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_PressRelease"] = true;
Variable["BaseGame.Situation_Order_InfiltratedIntelligence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_LiviaPetrGone = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_LiviaPetrGone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||
BaseGame.Turn08_SecondScandal_ShareBlame == true ||
BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||..."*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||
BaseGame.Turn08_SecondScandal_ShareBlame == true ||
BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true  or 
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or 
Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_VPSelection = true"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||
BaseGame.Turn08_SecondScandal_ShareBlame == true ||
BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true  or 
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or 
Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_VPSelection = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_VPSelection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_PressReleases = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_PressReleases"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA: ""Are you sure about this?""]** — Mówca: **Player**
> ""Are you sure about this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucian Galade: ""Here. It's all in the report from our intelligence offic..."*)

### Węzeł `[378]`
Mówca: **Lucian Galade**
> ""Here. It's all in the report from our intelligence officers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""Further investigation by our operatives in Rumburg match..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""Easy. I'll get Marcel on it.""*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[382]`
**[WYBÓR GRACZA: ""It's okay, Lucian. I know exactly what you mean.""]** — Mówca: **Player**
> ""It's okay, Lucian. I know exactly what you mean.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "I could almost see the gears in Lucian's head turning."*)

### Węzeł `[383]`
**[WYBÓR GRACZA: ""Have a nice one, old friend.""]** — Mówca: **Player**
> ""Have a nice one, old friend.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Petr Vectern), `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I walked out, leaving the bottle on his desk."*)

### Węzeł `[384]`
**[WYBÓR GRACZA: "Head to Petr's office."]** — Mówca: **Player_Italic**
> "I headed down the hall to Petr's office."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[320]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "I knocked on the door, and Petr answered. He looked at th..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA: "Head out."]** — Mówca: **Player_Italic**
> "I headed outside with the bottle."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[320]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "Petr was about to receive some very unpleasant news."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaFired == true || BaseGame.Turn08_SecondScandal_LiviaStays == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaFired == true || BaseG..."*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaFired == true || Bas..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaFired == true || BaseGame.Turn08_SecondScandal_LiviaStays == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_PressReleases = true"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaFired == true || BaseGame.Turn08_SecondScandal_LiviaStays == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_PressRelease = true; BaseGame.Situation_O..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaFired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaFired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_LiviaSuno = false..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaStays = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaStays"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaStays = true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaDetained = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaDetained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Lucian Galade: ""As you wish. I'll call Mr. Greiser right away.""*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaAndPetrDetained = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaAndPetrDetained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "Lucian was trying very hard not to appear pleased."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_BlamePetrForLeak = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_BlamePetrForLeak"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Relations..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_ShareBlame = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_ShareBlame"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "Lucian looked as if he was about to object one last time,..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_DenyEverything = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_DenyEverything"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "Lucian looked as if he was about to object one last time,..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLivia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLivia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucian Galade: ""As you wish. I'll call Mr. Greiser right away. It ought ..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLivia = true;
BaseGameSupport.Codex_Characters_Others_LiviaSuno = false;
BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLivia"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucian Galade: ""As you wish. I'll call Mr. Greiser right away. It ought ..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLiviaAndPetr = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLiviaAndPetr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Lucian was trying very hard not to appear pleased."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLiviaAndPetr = true; BaseGame.Petr_Dead = true; BaseGame.Petr_isVP = false;
BaseGameSupport.Codex_Characters_Others_LiviaSuno = false;
BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLiviaAndPetr"] = true;
Variable["BaseGame.Petr_Dead"] = true;
Variable["BaseGame.Petr_isVP"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Lucian was trying very hard not to appear pleased."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_LiviaTrialled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_LiviaTrialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "She straightened up, ran a hand through her curls and all..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaSpy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaSpy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Our security team travelled to Lachaven to speak to the ..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "She stormed out, slamming the door behind her."*)

### Węzeł `[403]`
**[WYBÓR GRACZA: ""Come to my office. You're making a scene out here.""]** — Mówca: **Player**
> ""Come to my office. You're making a scene out here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "Once Petr was in my office, I shut the door and explained..."*)

### Węzeł `[404]`
**[WYBÓR GRACZA: ""I'll tell you in my office. Feel free to take a moment first.""]** — Mówca: **Player**
> ""I'll tell you in my office. Feel free to take a moment first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "Once Petr was in my office, I shut the door and explained..."*)

### Węzeł `[405]`
Mówca: **Narrator**
> "Once Petr was in my office, I shut the door and explained everything Lucian had told me about Livia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Petr Vectern: ""And you believed him? Well, better safe than sorry, espe..."*)

### Węzeł `[406]`
Mówca: **Petr Vectern**
> ""And you believed him? Well, better safe than sorry, especially after what she called me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Petr Vectern: ""At least we finally have this ordeal behind us. Let's ge..."*)

### Węzeł `[407]`
Mówca: **Petr Vectern**
> ""At least we finally have this ordeal behind us. Let's get on with running the country, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: ""Actually, I have to tell you something...""*)
  - -> `[408]` (*Player: ""Yes, let's.""*)
  - -> `[409]` (*Player: ""Yes, let's. But first, a drink.""*)

### Węzeł `[408]`
**[WYBÓR GRACZA: ""Yes, let's.""]** — Mówca: **Player**
> ""Yes, let's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Petr Vectern: ""I can't believe I was so careless.""*)

### Węzeł `[409]`
**[WYBÓR GRACZA: ""Yes, let's. But first, a drink.""]** — Mówca: **Player**
> ""Yes, let's. But first, a drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "Petr eagerly nodded, then thought better of it and shook ..."*)

### Węzeł `[410]`
**[WYBÓR GRACZA: ""Actually, I have to tell you something...""]** — Mówca: **Player**
> ""Actually, I have to tell you something...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Petr Vectern: ""Yeah? What is it?""*)

### Węzeł `[411]`
Mówca: **Petr Vectern**
> ""Yeah? What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)
  - -> `[412]` (*Player: ""Lucian wants you to resign.""*)
  - -> `[416]` (*Player: ""You look like shit. Why don't you take the rest of the d..."*)

### Węzeł `[412]`
**[WYBÓR GRACZA: ""Lucian wants you to resign.""]** — Mówca: **Player**
> ""Lucian wants you to resign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[411]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Narrator: "Petr looked up at me with an indignant expression."*)

### Węzeł `[413]`
**[WYBÓR GRACZA: ""I want you to resign.""]** — Mówca: **Player**
> ""I want you to resign.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Kontekst wejściowy (poprzednik):** `[411]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "Petr looked up at me. His expression was numb."*)

### Węzeł `[414]`
**[WYBÓR GRACZA: ""Lucian wanted you to resign, but I told him it's not happening.""]** — Mówca: **Player**
> ""Lucian wanted you to resign, but I told him it's not happening.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[411]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Narrator: "Petr looked up at me in surprise."*)

### Węzeł `[415]`
Mówca: **Narrator**
> "Petr looked up at me. His expression was numb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Petr Vectern: ""I... I guess I deserve this, don't I?""*)

### Węzeł `[416]`
**[WYBÓR GRACZA: ""You look like shit. Why don't you take the rest of the day off?""]** — Mówca: **Player**
> ""You look like shit. Why don't you take the rest of the day off?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[411]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Narrator: "Petr looked at me gratefully."*)

### Węzeł `[417]`
Mówca: **Narrator**
> "Petr looked at me gratefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Petr Vectern: ""Thanks, Anton. I do need a little time. But I promise it..."*)

### Węzeł `[418]`
Mówca: **Petr Vectern**
> ""Thanks, Anton. I do need a little time. But I promise it's going to be a whole new me from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "I watched him leave."*)

### Węzeł `[419]`
Mówca: **Narrator**
> "I watched him leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "A whole new vice president... I didn't have the heart to ..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Narrator: "A whole new Petr... I hoped he was right about that."*)

### Węzeł `[423]`
Mówca: **Narrator**
> "A whole new vice president... I didn't have the heart to tell Petr how right he was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_LiviaSpyReveal = true"*)

### Węzeł `[424]`
Mówca: **Narrator**
> "A whole new Petr... I hoped he was right about that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_LiviaSpyReveal = true"*)

### Węzeł `[425]`
Mówca: **Petr Vectern**
> ""I... I guess I deserve this, don't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Player: ""Yes. Your philandering put all of us in danger.""*)
  - -> `[427]` (*Player: ""No. But we need someone to take the fall for this scanda..."*)

### Węzeł `[426]`
**[WYBÓR GRACZA: ""Yes. Your philandering put all of us in danger.""]** — Mówca: **Player**
> ""Yes. Your philandering put all of us in danger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[425]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Narrator: "He exhaled slowly. I could see tears in his eyes."*)

### Węzeł `[427]`
**[WYBÓR GRACZA: ""No. But we need someone to take the fall for this scandal, or the administration suffers.""]** — Mówca: **Player**
> ""No. But we need someone to take the fall for this scandal, or the administration suffers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[425]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Narrator: "He exhaled slowly. I could see tears in his eyes."*)

### Węzeł `[428]`
Mówca: **Narrator**
> "He exhaled slowly. I could see tears in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Petr Vectern: ""I'm so sorry, Anton. I was never cut out for this job.""*)

### Węzeł `[429]`
Mówca: **Petr Vectern**
> ""I'm so sorry, Anton. I was never cut out for this job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Player: ""It was fun while it lasted.""*)
  - -> `[431]` (*Player: ""You really weren't. But at least you got a nice house ou..."*)
  - -> `[453]` (*Player: ""You did great. Sordland's just not ready for a vice pres..."*)

### Węzeł `[430]`
**[WYBÓR GRACZA: ""It was fun while it lasted.""]** — Mówca: **Player**
> ""It was fun while it lasted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[429]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Petr Vectern: ""Sure was, old buddy.""*)

### Węzeł `[431]`
**[WYBÓR GRACZA: ""You really weren't. But at least you got a nice house out of the deal.""]** — Mówca: **Player**
> ""You really weren't. But at least you got a nice house out of the deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[429]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Petr Vectern: ""Unless Evelyn takes it in the divorce.""*)

### Węzeł `[432]`
Mówca: **Narrator**
> "Petr looked up at me with an indignant expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Petr Vectern: ""Of course he does, that fink. Did you tell him off?""*)

### Węzeł `[433]`
Mówca: **Petr Vectern**
> ""Of course he does, that fink. Did you tell him off?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Player: ""Actually, I agree with him. I'm announcing your resignat..."*)
  - -> `[435]` (*Player: ""I did. We're laying this all at Rumburg's feet.""*)
  - -> `[436]` (*Player: ""I did. This is as much my fault as it is yours. The admi..."*)

### Węzeł `[434]`
**[WYBÓR GRACZA: ""Actually, I agree with him. I'm announcing your resignation, Petr.""]** — Mówca: **Player**
> ""Actually, I agree with him. I'm announcing your resignation, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Narrator: "Petr's face fell. He seemed to sink into the couch."*)

### Węzeł `[435]`
**[WYBÓR GRACZA: ""I did. We're laying this all at Rumburg's feet.""]** — Mówca: **Player**
> ""I did. We're laying this all at Rumburg's feet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything = true; Base..."*)

### Węzeł `[436]`
**[WYBÓR GRACZA: ""I did. This is as much my fault as it is yours. The administration will take the hit.""]** — Mówca: **Player**
> ""I did. This is as much my fault as it is yours. The administration will take the hit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything = false; Bas..."*)

### Węzeł `[437]`
Mówca: **Narrator**
> "Petr looked up at me in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Petr Vectern: ""Really, Anton? That means a lot.""*)

### Węzeł `[438]`
Mówca: **Petr Vectern**
> ""Really, Anton? That means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player: ""We're laying this all at Rumburg's feet.""*)
  - -> `[441]` (*Player: ""This is as much my fault as it is yours. The administrat..."*)

### Węzeł `[439]`
Mówca: **Narrator**
> "Petr's face fell. He seemed to sink into the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Petr Vectern: ""I... I guess I deserve this, don't I?""*)

### Węzeł `[440]`
**[WYBÓR GRACZA: ""We're laying this all at Rumburg's feet.""]** — Mówca: **Player**
> ""We're laying this all at Rumburg's feet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything = true; Base..."*)

### Węzeł `[441]`
**[WYBÓR GRACZA: ""This is as much my fault as it is yours. The administration will take the hit.""]** — Mówca: **Player**
> ""This is as much my fault as it is yours. The administration will take the hit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything = false; Bas..."*)

### Węzeł `[442]`
Mówca: **Narrator**
> "Petr eagerly nodded, then thought better of it and shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Petr Vectern: ""No. My drunken idiocy got us into this mess in the first..."*)

### Węzeł `[443]`
Mówca: **Petr Vectern**
> ""No. My drunken idiocy got us into this mess in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Petr Vectern: ""It's going to be a whole new me from now on, Anton. I pr..."*)

### Węzeł `[444]`
Mówca: **Petr Vectern**
> ""It's going to be a whole new me from now on, Anton. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "I watched him leave."*)

### Węzeł `[445]`
Mówca: **Petr Vectern**
> ""I can't believe I was so careless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Petr Vectern: ""It's going to be a whole new me from now on, Anton. I pr..."*)

### Węzeł `[446]`
Mówca: **Petr Vectern**
> ""That's... wow. I can't believe you'd do that for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player: ""We'll have some time before the news goes public. We sho..."*)
  - -> `[456]` (*Player: ""Stay for a drink.""*)

### Węzeł `[447]`
Mówca: **Petr Vectern**
> ""Oof. I hope they don't take it as a sign to escalate. But, wow, thanks for protecting me from Guillotine Galade over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player: ""We'll have some time before the news goes public. We sho..."*)
  - -> `[456]` (*Player: ""Stay for a drink.""*)

### Węzeł `[448]`
Mówca: **Petr Vectern**
> ""Unless Evelyn takes it in the divorce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player: ""You'll have some time before the news goes public. I sug..."*)
  - -> `[451]` (*Player: ""Stay for a drink.""*)

### Węzeł `[449]`
Mówca: **Petr Vectern**
> ""Sure was, old buddy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player: ""You'll have some time before the news goes public. I sug..."*)
  - -> `[451]` (*Player: ""Stay for a drink.""*)

### Węzeł `[450]`
**[WYBÓR GRACZA: ""You'll have some time before the news goes public. I suggest you get your affairs in order.""]** — Mówca: **Player**
> ""You'll have some time before the news goes public. I suggest you get your affairs in order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Petr Vectern), `[449]` (Petr Vectern), `[454]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Petr Vectern: ""All right, I get the message. But first...""*)

### Węzeł `[451]`
**[WYBÓR GRACZA: ""Stay for a drink.""]** — Mówca: **Player**
> ""Stay for a drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Petr Vectern), `[449]` (Petr Vectern), `[454]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "Without waiting for him to answer, I poured some whiskey ..."*)

### Węzeł `[452]`
Mówca: **Petr Vectern**
> ""All right, I get the message. But first...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "He grabbed the bottle of Erlory Maroon 30-Year-Old from t..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA: ""You did great. Sordland's just not ready for a vice president like you yet.""]** — Mówca: **Player**
> ""You did great. Sordland's just not ready for a vice president like you yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[429]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Petr Vectern: ""Don't patronize me.""*)

### Węzeł `[454]`
Mówca: **Petr Vectern**
> ""Don't patronize me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player: ""You'll have some time before the news goes public. I sug..."*)
  - -> `[451]` (*Player: ""Stay for a drink.""*)

### Węzeł `[455]`
**[WYBÓR GRACZA: ""We'll have some time before the news goes public. We should get our stories straight.""]** — Mówca: **Player**
> ""We'll have some time before the news goes public. We should get our stories straight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Petr Vectern), `[447]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Petr Vectern: ""Sure, of course.""*)

### Węzeł `[456]`
**[WYBÓR GRACZA: ""Stay for a drink.""]** — Mówca: **Player**
> ""Stay for a drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Petr Vectern), `[447]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Petr Vectern: ""No. My drunken idiocy got us into this mess in the first..."*)

### Węzeł `[457]`
Mówca: **Narrator**
> "Without waiting for him to answer, I poured some whiskey into a glass. Petr grabbed the bottle instead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Petr Vectern: ""To new beginnings.""*)

### Węzeł `[458]`
Mówca: **Petr Vectern**
> ""To new beginnings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Narrator: "He drained a third of the bottle in one long swig, then g..."*)

### Węzeł `[459]`
Mówca: **Narrator**
> "He drained a third of the bottle in one long swig, then got to his feet and unsteadily made his way to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Narrator: "I knew this was for the best. But I hoped my friend would..."*)

### Węzeł `[460]`
Mówca: **Narrator**
> "He grabbed the bottle of Erlory Maroon 30-Year-Old from the shelf behind my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Petr Vectern: ""To new beginnings.""*)

### Węzeł `[461]`
Mówca: **Narrator**
> "I knew this was for the best. But I hoped my friend would be all right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak = true"*)

### Węzeł `[462]`
Mówca: **Petr Vectern**
> ""Sure, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Petr Vectern: ""I can't believe I was so careless.""*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)"*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Player: ""I want you to resign.""*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player: ""Lucian wanted you to resign, but I told him it's not hap..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning = true"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything = true; BaseGame.Turn08_SecondScandal_ShareBlame = false; BaseGame.Turn08_SecondScandal_BlamePetrForLeak = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = true;
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = false;
Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Petr Vectern: ""Oof. I hope they don't take it as a sign to escalate. Bu..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything = false; BaseGame.Turn08_SecondScandal_ShareBlame = true; BaseGame.Turn08_SecondScandal_BlamePetrForLeak = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = false;
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = true;
Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Petr Vectern: ""That's... wow. I can't believe you'd do that for me.""*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything = true; BaseGame.Turn08_SecondScandal_ShareBlame = false; BaseGame.Turn08_SecondScandal_BlamePetrForLeak = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = true;
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = false;
Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Petr Vectern: ""Oof. I hope they don't take it as a sign to escalate. Bu..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything = false; BaseGame.Turn08_SecondScandal_ShareBlame = true; BaseGame.Turn08_SecondScandal_BlamePetrForLeak = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = false;
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = true;
Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Petr Vectern: ""That's... wow. I can't believe you'd do that for me.""*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_PressConference_PetrKnowsResigning = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_LiviaSpyReveal = true"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SecretState_LucianKnowsSSPKills == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGame.SecretState_LucianKnowsSSPKills == true"*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SecretState_LucianKnowsSSPKills == true)"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SecretState_LucianKnowsSSPKills == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucian Galade: ""If made to look like an accident, another covert assassi..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SecretState_LucianKnowsSSPKills == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Lucian Galade: ""If made to look like an accident, a covert assassination..."*)

### Węzeł `[476]`
Mówca: **Lucian Galade**
> ""If made to look like an accident, a covert assassination by your Secret State Police could solve our problem before it even starts. But I understand if you still harbor fond feelings for Miss Vance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player: ""Let's just have her arrested, okay?""*)
  - -> `[235]` (*Player: ""Let's just have her arrested -- and Petr, too, while we'..."*)
  - -> `[236]` (*Player: ""Screw Liv--Ilana. Let's have her killed.""*)
  - -> `[237]` (*Player: ""Screw Miss Vance. And Petr too! Let's have them both kil..."*)
