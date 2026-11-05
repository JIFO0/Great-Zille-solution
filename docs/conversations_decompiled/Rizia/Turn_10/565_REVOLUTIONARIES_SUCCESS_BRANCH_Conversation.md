# Rizia/Turn 10/STRIKE SCENE/REVOLUTIONARIES SUCCESS BRANCH/REVOLUTIONARIES SUCCESS BRANCH Conversation

- **ID konwersacji:** `565`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/565_REVOLUTIONARIES_SUCCESS_BRANCH_Conversation.md`
- **Liczba węzłów dialogowych:** 402
- **Liczba wyborów gracza:** 72

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[86]** Daria de Rava
- **[89]** Russello Montoro
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.BirthdayGathering_Invited_Adarfo`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.BirthdayGathering_Invited_Rusty`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo`
- `RiziaDLCIsolated.Birthday_Gathering_King_Resists`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Birthday_Adarfo_Usurped`
- `RiziaDLC.Epilogue_Death_AdarfoShoots`
- `RiziaDLC.Epilogue_Revolution_Birthday`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.SkipToEnding`
- `RiziaDLC.SkipToEpilogue`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo`
- `RiziaDLCIsolated.Birthday_Gathering_Follow_Adarfo`
- `RiziaDLCIsolated.Birthday_Gathering_King_Resists`
- `RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Everyone_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Lucita_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_SeizedLibrary`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Taddeus_Executed`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[193]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""Titus! Behind you!""** | `[6]` **Narrator**: "Titus took down two more attacke..."<br>`[198]` **Narrator**: "As I peeked in Titus' direction,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "He turned and immediately shot t..." |
| `[13]` | **"Say nothing."** | `[6]` **Narrator**: "Titus took down two more attacke..."<br>`[198]` **Narrator**: "As I peeked in Titus' direction,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Narrator**: "I watched as the knife plunged i..." |
| `[45]` | **""Don't act so surprised. You've had this coming for a long time.""** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false` | *Brak zmian stanu* | `[99]` **Narrator**: "Taddeus wheeled himself toward me." |
| `[49]` | **""This wasn't part of the deal. The new constitution specifically says the monarch ..."** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false` | *Brak zmian stanu* | `[53]` **Adarfo Sotelato**: ""The only recognized constitutio..." |
| `[50]` | **""It is not just kings who have ended, but loyalty and honor.""** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false` | *Brak zmian stanu* | `[95]` **Narrator**: "Taddeus wheeled himself toward me." |
| `[51]` | **""Don't worry, it's not as bad as it seems.""** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false` | *Brak zmian stanu* | `[101]` **Narrator**: "Taddeus wheeled himself toward me." |
| `[52]` | **""I trusted you to lead change, not to usurp the throne!""** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false` | *Brak zmian stanu* | `[82]` **Adarfo Sotelato**: ""Come now, did you truly believe..." |
| `[58]` | **""How could you?! She was carrying my child!""** | `[70]` **Narrator**: "I ran to Lucita and took her bod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Adarfo Sotelato**: ""I am sorry. But she brought thi..." |
| `[60]` | **""WAKE UP, LUCITA!""** | `[70]` **Narrator**: "I ran to Lucita and took her bod..."<br>`[36]` **Narrator**: "Clutching her stomach, Lucita fe..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[71]` **Adarfo Sotelato**: ""She's dead, Romus. She brought ..." |
| `[61]` | **"Say nothing."** | `[70]` **Narrator**: "I ran to Lucita and took her bod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Adarfo Sotelato**: ""I'm sorry about that. But she b..." |
| `[62]` | **""SOMEBODY CALL A DOCTOR!""** | `[70]` **Narrator**: "I ran to Lucita and took her bod..."<br>`[36]` **Narrator**: "Clutching her stomach, Lucita fe..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[71]` **Adarfo Sotelato**: ""She's dead, Romus. She brought ..." |
| `[72]` | **""WHAT THE HELL ARE YOU DOING?! You weren't supposed to kill anyone!""** | `[36]` **Narrator**: "Clutching her stomach, Lucita fe..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[74]` **Adarfo Sotelato**: ""They made their choice the mome..." |
| `[73]` | **""Was that completely necessary?""** | `[36]` **Narrator**: "Clutching her stomach, Lucita fe..." | `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[79]` **Adarfo Sotelato**: ""Yes. Stand in the way of the re..." |
| `[75]` | **""They had it coming.""** | `[36]` **Narrator**: "Clutching her stomach, Lucita fe..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[80]` **Adarfo Sotelato**: ""I'm glad you agree."" |
| `[76]` | **"Say nothing."** | `[36]` **Narrator**: "Clutching her stomach, Lucita fe..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[269]` **Adarfo Sotelato**: ""Anyone else feeling brave?"" |
| `[81]` | **""So this was your plan all along. I should have seen it coming.""** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false` | *Brak zmian stanu* | `[83]` **Adarfo Sotelato**: ""Yes, you should have."" |
| `[84]` | **""God will judge us both, Adarfo. But mark my words... He will not look kindly on t..."** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`Variable["RiziaDLC.Adarfo_AbdicationPath"] == false` | *Brak zmian stanu* | `[85]` **Adarfo Sotelato**: ""If your God truly saw you fit f..." |
| `[89]` | **""Ha! You should see your faces!""** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true`<br>`(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false` | *Brak zmian stanu* | `[94]` **Narrator**: "Taddeus wheeled himself toward me." |
| `[120]` | **"Follow Adarfo."** | `[119]` **Narrator**: "They reluctantly loosened their ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Follow_Adar...` | `[180]` **Narrator**: "Adarfo walked up to a large curt..." |
| `[121]` | **"Stay where you are."** | `[119]` **Narrator**: "They reluctantly loosened their ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Player_Romus**: ""I'm not going anywhere with you.""<br>`[123]` **Player_Romus**: ""Thanks, but I respectfully decl..."<br>*(oraz 1 innych odgałęzień)* |
| `[122]` | **""I'm not going anywhere with you.""** | `[121]` **Player_Romus_Italic**: "I didn't budge." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Adarfo Sotelato**: ""So be it."" |
| `[123]` | **""Thanks, but I respectfully decline.""** | `[121]` **Player_Romus_Italic**: "I didn't budge." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Adarfo Sotelato**: ""So be it."" |
| `[124]` | **""I don't take orders from you, nor will I ever.""** | `[121]` **Player_Romus_Italic**: "I didn't budge." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Adarfo Sotelato**: ""So be it."" |
| `[129]` | **""You mock me.""** | `[128]` **Adarfo Sotelato**: ""And it's all thanks to you. Non..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Adarfo Sotelato**: ""Not at all. You'll be remembere..." |
| `[132]` | **""Died?""** | `[131]` **Adarfo Sotelato**: ""The king who fought and died to..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_Death_AdarfoShoots"] = true; ...`<br>`--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[133]` | **""No. It wouldn't have... best you remember that.""** | `[128]` **Adarfo Sotelato**: ""And it's all thanks to you. Non..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Adarfo Sotelato**: ""How could I forget? You'll be r..." |
| `[134]` | **""If you're expecting gratitude, you won't find it here.""** | `[131]` **Adarfo Sotelato**: ""The king who fought and died to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Adarfo Sotelato**: ""You think I care about your gra..." |
| `[135]` | **""Forgive me if I'm not in a celebratory mood.""** | `[128]` **Adarfo Sotelato**: ""And it's all thanks to you. Non..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Adarfo Sotelato**: ""For what it's worth, you'll be ..." |
| `[136]` | **""Let freedom ring.""** | `[128]` **Adarfo Sotelato**: ""And it's all thanks to you. Non..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false` | *Brak zmian stanu* | `[168]` **Adarfo Sotelato**: ""Exactly! For all to hear! You'l..." |
| `[138]` | **""I did this for the Rizian people. You had better not let them down.""** | `[137]` **Adarfo Sotelato**: ""Your sacrifice will be remember..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Adarfo Sotelato**: ""That's not for you to worry abo..." |
| `[139]` | **""If you're expecting gratitude, you won't find it here.""** | `[137]` **Adarfo Sotelato**: ""Your sacrifice will be remember..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Adarfo Sotelato**: ""You think I care about your gra..." |
| `[140]` | **""Sacrifice? Do you intend to kill me too?""** | `[137]` **Adarfo Sotelato**: ""Your sacrifice will be remember..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Narrator**: "He didn't answer." |
| `[144]` | **""I've done my part. Please, just let me go.""** | `[137]` **Adarfo Sotelato**: ""Your sacrifice will be remember..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Adarfo Sotelato**: ""Not just yet."" |
| `[146]` | **""You took my wife and unborn child from me. Nothing you say or do will ever justif..."** | `[137]` **Adarfo Sotelato**: ""Your sacrifice will be remember..." | `Variable["RiziaDLC.Lucita_Married"] == true` | *Brak zmian stanu* | `[147]` **Adarfo Sotelato**: ""Be grateful you didn't meet the..." |
| `[154]` | **""A future built on betrayal and bloodshed. And here I thought we were building som..."** | `[131]` **Adarfo Sotelato**: ""The king who fought and died to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Adarfo Sotelato**: ""We are. You just won't be aroun..." |
| `[155]` | **""Given the circumstances, I suppose it's not the worst outcome.""** | `[131]` **Adarfo Sotelato**: ""The king who fought and died to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Adarfo Sotelato**: ""Glad you’re beginning to unders..." |
| `[161]` | **""You took my wife and child away from me. Nothing you say or do will ever replace ..."** | `[131]` **Adarfo Sotelato**: ""The king who fought and died to..." | `Variable["RiziaDLC.Lucita_Married"] == true` | *Brak zmian stanu* | `[162]` **Adarfo Sotelato**: ""Don't worry. You'll be seeing t..." |
| `[169]` | **""The last thing I want is recognition.""** | `[128]` **Adarfo Sotelato**: ""And it's all thanks to you. Non..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false) == false` | *Brak zmian stanu* | `[170]` **Adarfo Sotelato**: ""Are you kidding me? You'll be r..." |
| `[171]` | **""I did what had to be done.""** | `[128]` **Adarfo Sotelato**: ""And it's all thanks to you. Non..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false` | *Brak zmian stanu* | `[172]` **Adarfo Sotelato**: ""Yes, you did. You'll be remembe..." |
| `[176]` | **""No... I suppose not.""** | `[128]` **Adarfo Sotelato**: ""And it's all thanks to you. Non..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false) == false` | *Brak zmian stanu* | `[177]` **Adarfo Sotelato**: ""You'll be remembered as the man..." |
| `[187]` | **""My daughter is in the building! I have to get her out!""** | `[182]` **Narrator**: "A bullet whizzed past us, close ..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true` | *Brak zmian stanu* | `[204]` **Adarfo Sotelato**: ""Wait!"" |
| `[188]` | **""If anything happens to my family, you will pay.""** | `[182]` **Narrator**: "A bullet whizzed past us, close ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Adarfo Sotelato**: ""They'll be fine. I promise."" |
| `[189]` | **""This is too much. Order them to stand down immediately!""** | `[182]` **Narrator**: "A bullet whizzed past us, close ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Adarfo Sotelato**: ""It's too late for that."" |
| `[190]` | **""TITUS! I ORDER YOU TO STAND DOWN!""** | `[182]` **Narrator**: "A bullet whizzed past us, close ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Narrator**: "Titus paused for a moment and gl..." |
| `[194]` | **""Damn! Titus will kill all of us!""** | `[227]` **Narrator**: "As I dove for cover behind the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Adarfo Sotelato**: ""Stop worrying. It will be over ..." |
| `[195]` | **""Nicely done. My compliments to your men.""** | `[227]` **Narrator**: "As I dove for cover behind the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Adarfo Sotelato**: ""It's not pretty. But true chang..." |
| `[196]` | **""Don't you botch this, Adarfo! Do you hear me? If your guys fail, we're screwed.""** | `[227]` **Narrator**: "As I dove for cover behind the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Adarfo Sotelato**: ""Stop worrying. It will be over ..." |
| `[197]` | **""What the hell is going on!? I thought you were capable of a silent assault!""** | `[227]` **Narrator**: "As I dove for cover behind the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Adarfo Sotelato**: ""Stop worrying. It will be over ..." |
| `[207]` | **"Say nothing."** | `[233]` **Vina Toras**: ""Let go of me!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Vina looked at me, bewildered by..." |
| `[208]` | **""He's right, Vina. You're an armchair liberal.""** | `[233]` **Vina Toras**: ""Let go of me!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Adarfo Sotelato**: ""You're hardly any better, Your ..." |
| `[209]` | **""Be reasonable, Adarfo. My daughter is innocent in all this.""** | `[233]` **Vina Toras**: ""Let go of me!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Adarfo Sotelato**: ""None of you are innocent. Don't..." |
| `[230]` | **""Mr. Sotelato. I command you to get your hands off of her!""** | `[233]` **Vina Toras**: ""Let go of me!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Adarfo Sotelato**: ""I'm sorry, but I'm afraid your ..." |
| `[236]` | **"Say nothing."** | `[234]` **Estela Toras**: ""For heaven's sake, Romus, are y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "Mother looked at me, bewildered ..." |
| `[237]` | **""He's right, Mother. You're a class traitor.""** | `[234]` **Estela Toras**: ""For heaven's sake, Romus, are y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Adarfo Sotelato**: ""But she does know what real wor..." |
| `[238]` | **""Be reasonable, Adarfo. My mother is innocent in all this.""** | `[234]` **Estela Toras**: ""For heaven's sake, Romus, are y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Adarfo Sotelato**: ""None of you are innocent. Don't..." |
| `[239]` | **""Mr. Sotelato. I command you to get your hands off of her!""** | `[234]` **Estela Toras**: ""For heaven's sake, Romus, are y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Adarfo Sotelato**: ""I'm sorry, but I'm afraid that ..." |
| `[265]` | **"Attack Adarfo."** | `[59]` **Adarfo Sotelato**: ""I am sorry. But she brought thi..."<br>`[69]` **Adarfo Sotelato**: ""I'm sorry about that. But she b..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resist...` | `[268]` **Adarfo Sotelato**: ""Don't do that again."" |
| `[266]` | **"Restrain yourself."** | `[59]` **Adarfo Sotelato**: ""I am sorry. But she brought thi..."<br>`[69]` **Adarfo Sotelato**: ""I'm sorry about that. But she b..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Adarfo Sotelato**: ""Anyone else feeling brave?"" |
| `[318]` | **""That's right. Now sign the new constitution so we can all get on with our lives.""** | `[245]` **Lucita Azaro**: ""What kind of king invites revol..."<br>`[373]` **Narrator**: "Lucita shook with rage, unable t..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[319]` **Narrator**: "Adarfo choked back a laugh." |
| `[333]` | **""How could you?! I loved her!""** | `[36]` **Narrator**: "Clutching her stomach, Lucita fe..." | `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[334]` **Adarfo Sotelato**: ""I'm sorry. But anyone who stand..." |
| `[341]` | **""I had no other choice. We need these reforms.""** | `[245]` **Lucita Azaro**: ""What kind of king invites revol..."<br>`[373]` **Narrator**: "Lucita shook with rage, unable t..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[319]` **Narrator**: "Adarfo choked back a laugh." |
| `[342]` | **""Violence wasn't part of the plan.""** | `[245]` **Lucita Azaro**: ""What kind of king invites revol..."<br>`[373]` **Narrator**: "Lucita shook with rage, unable t..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[235]` **Titus Gordion**: ""You got my men killed, Your Maj..." |
| `[343]` | **"Stay silent."** | `[245]` **Lucita Azaro**: ""What kind of king invites revol..."<br>`[373]` **Narrator**: "Lucita shook with rage, unable t..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[235]` **Titus Gordion**: ""You got my men killed, Your Maj..." |
| `[345]` | **""I had no other choice. It is time to let go of the throne.""** | `[245]` **Lucita Azaro**: ""What kind of king invites revol..."<br>`[373]` **Narrator**: "Lucita shook with rage, unable t..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[347]` **Hugo Toras**: ""You've gone mad!"" |
| `[346]` | **""That's right. I'm giving my full support to Mr. Sotelato to form a new democratic..."** | `[245]` **Lucita Azaro**: ""What kind of king invites revol..."<br>`[373]` **Narrator**: "Lucita shook with rage, unable t..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[347]` **Hugo Toras**: ""You've gone mad!"" |
| `[348]` | **""Stop with the theatrics, Mr. Sotelato. We are here for the signatures.""** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false` | *Brak zmian stanu* | `[349]` **Adarfo Sotelato**: ""No. That ship has sailed."" |
| `[350]` | **""Stop with the theatrics, Mr. Sotelato. This is supposed to be a *smooth and peace..."** | `[44]` **Adarfo Sotelato**: ""This nation belongs in the hand..." | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false` | *Brak zmian stanu* | `[95]` **Narrator**: "Taddeus wheeled himself toward me." |
| `[356]` | **""And so the great House of Azaro ends.""** | `[70]` **Narrator**: "I ran to Lucita and took her bod..."<br>`[36]` **Narrator**: "Clutching her stomach, Lucita fe..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[357]` **Adarfo Sotelato**: ""As all noble houses must."" |
| `[361]` | **""You monster! This wasn't part of the plan!""** | `[269]` **Adarfo Sotelato**: ""Anyone else feeling brave?"" | `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[392]` **Hugo Toras**: ""For heaven's sake, Romus, shut ..." |
| `[362]` | **""I urge you all to do as he asks. Nobody else needs to get hurt.""** | `[269]` **Adarfo Sotelato**: ""Anyone else feeling brave?"" | `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[394]` **Narrator**: "With a withering glance at me, H..." |
| `[363]` | **"Say nothing."** | `[269]` **Adarfo Sotelato**: ""Anyone else feeling brave?"" | `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[393]` **Hugo Toras**: ""We submit, Mr. Sotelato. Please..." |
| `[399]` | **""This wasn't part of the plan.""** | `[245]` **Lucita Azaro**: ""What kind of king invites revol..."<br>`[373]` **Narrator**: "Lucita shook with rage, unable t..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false` | *Brak zmian stanu* | `[235]` **Titus Gordion**: ""You got my men killed, Your Maj..." |

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
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "The guards, unprepared for the ambush, were overwhelmed. Shots rang out, and two of them crumpled to the floor, dead before they could react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "One man leveled his gun at Hugo, but Titus drew his weapon and shot him dead before the assailant could pull the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "He was dragged down, his arms pinned and tied behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Titus took down two more attackers, just as a man with a knife charged at him from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Grunting with pain, he grappled with the assailant, throwing him to the ground and locking his hands around the man's throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "As the man’s gasps faded, the doors burst open. A mob of ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "As the man’s gasps faded, the doors burst open. A mob of revolutionaries, weapons raised, flooded the room, swarming Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He was dragged down, his arms pinned and tied behind his ..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The doors burst open and Adarfo Sotelato stepped inside. He dipped his head in a mock bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Adarfo Sotelato: ""Your Majesty.""*)

### Węzeł `[10]`
Mówca: **Adarfo Sotelato**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "It was at that moment a mob of revolutionaries, weapons raised, flooded the room, swarming Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He was dragged down, his arms pinned and tied behind his ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! Behind you!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[198]` (Narrator), `[206]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "He turned and immediately shot the man dead."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[198]` (Narrator), `[206]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "I watched as the knife plunged into his shoulder."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "I watched as the knife plunged into his shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Grunting with pain, he grappled with the assailant, throw..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "He turned and immediately shot the man dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "It was at that moment a mob of revolutionaries, weapons r..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Adarfo walked up to Angelica and roughly examined her palms."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Taddeus wheeled himself forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Taddeus Azaro: ""Your so-called movement will be crushed! This little upr..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Confusion momentarily flickered across Taddeus’s face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[21]`
Mówca: **Adarfo Sotelato**
> ""I'm so glad you asked. Let it be known that every one of you is being placed under arrest for treason against the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Adarfo Sotelato: ""For too long, you've fed off the less fortunate, broken ..."*)

### Węzeł `[22]`
Mówca: **Adarfo Sotelato**
> ""For too long, you've fed off the less fortunate, broken their backs so you could indulge in your lavish lifestyles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Adarfo Sotelato: ""This kingdom is crumbling under the strain of your greed.""*)

### Węzeł `[23]`
Mówca: **Adarfo Sotelato**
> ""This kingdom is crumbling under the strain of your greed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true"*)

### Węzeł `[24]`
Mówca: **Adarfo Sotelato**
> ""Enough! Hands. Let me see your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Adarfo walked up to Angelica and roughly examined her palms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Adarfo Sotelato: ""Soft.""*)

### Węzeł `[26]`
Mówca: **Taddeus Azaro**
> ""Your so-called movement will be crushed! This little uprising will be nothing more than a stain in the history books!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Taddeus Azaro: ""House Azaro will never submit --especially to someone wh..."*)

### Węzeł `[27]`
Mówca: **Taddeus Azaro**
> ""House Azaro will never submit --especially to someone who hasn't a single drop of blue blood in their veins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Adarfo Sotelato: ""Nobles… So obsessed with your bloodlines. Tell me, Gener..."*)

### Węzeł `[28]`
Mówca: **Adarfo Sotelato**
> ""Nobles… So obsessed with your bloodlines. Tell me, General -- do royals really bleed blue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Confusion momentarily flickered across Taddeus’s face."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "The room erupted in screams as Taddeus slumped in his chair. Adarfo pointed to the blood trickling to the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Adarfo Sotelato: ""See? The color red… just like the rest of us.""*)

### Węzeł `[30]`
Mówca: **Adarfo Sotelato**
> ""See? The color red… just like the rest of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "I froze momentarily, unable to react at all."*)

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""You… BASTARD!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Her hand moved to her side. She pulled out her hidden dag..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Her hand moved to her side. She pulled out her hidden dagger and drew her arm back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Adarfo reacted instantly. Another shot rang out as the knife flew past him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Clutching her stomach, Lucita fell to her knees and colla..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "The room erupted in screams as Taddeus slumped in his cha..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Lucita's scream pierced the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""You… BASTARD!""*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Clutching her stomach, Lucita fell to her knees and collapsed onto the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed = true; RiziaDLCSupport.Journal_..."*)

### Węzeł `[37]`
Mówca: **Adarfo Sotelato**
> ""Soft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "He turned to Rico and grabbed his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Adarfo Sotelato: ""Uncalloused.""*)

### Węzeł `[39]`
Mówca: **Adarfo Sotelato**
> ""Uncalloused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "He turned to Rico and grabbed his hands."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "He turned to Hubertus and grabbed his hands."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Adarfo sauntered back and stood on top of a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Adarfo Sotelato: ""This nation belongs in the hands of the people. The age ..."*)

### Węzeł `[44]`
Mówca: **Adarfo Sotelato**
> ""This nation belongs in the hands of the people. The age of kings is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't act so surprised. You've had this coming for a long time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Taddeus wheeled himself toward me."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == false)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player_Romus: ""Stop with the theatrics, Mr. Sotelato. We are here for t..."*)
  - -> `[81]` (*Player_Romus: ""So this was your plan all along. I should have seen it c..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[52]` (*Player_Romus: ""I trusted you to lead change, not to usurp the throne!""*)
  - -> `[49]` (*Player_Romus: ""This wasn't part of the deal. The new constitution speci..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player_Romus: ""Stop with the theatrics, Mr. Sotelato. This is supposed ..."*)
  - -> `[50]` (*Player_Romus: ""It is not just kings who have ended, but loyalty and hon..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[45]` (*Player_Romus: ""Don't act so surprised. You've had this coming for a lon..."*)
  - -> `[51]` (*Player_Romus: ""Don't worry, it's not as bad as it seems.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This wasn't part of the deal. The new constitution specifically says the monarch will remain in place.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Adarfo Sotelato: ""The only recognized constitution in Rizia shall be the o..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not just kings who have ended, but loyalty and honor.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Taddeus wheeled himself toward me."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, it's not as bad as it seems.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Taddeus wheeled himself toward me."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trusted you to lead change, not to usurp the throne!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Adarfo Sotelato: ""Come now, did you truly believe the movement would allow..."*)

### Węzeł `[53]`
Mówca: **Adarfo Sotelato**
> ""The only recognized constitution in Rizia shall be the one the people write themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal = ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "I ran to Lucita and took her body in my arms. The light w..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""WAKE UP, LUCITA!""*)
  - -> `[62]` (*Player_Romus: ""SOMEBODY CALL A DOCTOR!""*)
  - -> `[356]` (*Player_Romus: ""And so the great House of Azaro ends.""*)
  - -> `[72]` (*Player_Romus: ""WHAT THE HELL ARE YOU DOING?! You weren't supposed to ki..."*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)
  - -> `[75]` (*Player_Romus: ""They had it coming.""*)
  - -> `[76]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could you?! She was carrying my child!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Adarfo Sotelato: ""I am sorry. But she brought this upon herself the moment..."*)

### Węzeł `[59]`
Mówca: **Adarfo Sotelato**
> ""I am sorry. But she brought this upon herself the moment she drew her weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WAKE UP, LUCITA!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Adarfo Sotelato: ""She's dead, Romus. She brought this upon herself the mom..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing, just held her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Adarfo Sotelato: ""I'm sorry about that. But she brought this upon herself ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""SOMEBODY CALL A DOCTOR!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Adarfo Sotelato: ""She's dead, Romus. She brought this upon herself the mom..."*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""All right, Mr. Sotelato! We submit! Please, don’t harm anybody else!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Adarfo Sotelato: ""I don't need your submission. I need you out of the way.""*)

### Węzeł `[64]`
Mówca: **Adarfo Sotelato**
> ""I don't need your submission. I need you out of the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Everyone_A..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Adarfo's men restrained every individual in the room with brutal efficiency. Looks of betrayal and hatred burned into me as they were dragged out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true"*)

### Węzeł `[69]`
Mówca: **Adarfo Sotelato**
> ""I'm sorry about that. But she brought this upon herself the moment she drew her weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "I ran to Lucita and took her body in my arms. The light was rapidly draining from her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""WAKE UP, LUCITA!""*)
  - -> `[62]` (*Player_Romus: ""SOMEBODY CALL A DOCTOR!""*)
  - -> `[58]` (*Player_Romus: ""How could you?! She was carrying my child!""*)
  - -> `[356]` (*Player_Romus: ""And so the great House of Azaro ends.""*)
  - -> `[61]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[71]`
Mówca: **Adarfo Sotelato**
> ""She's dead, Romus. She brought this upon herself the moment she drew her weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHAT THE HELL ARE YOU DOING?! You weren't supposed to kill anyone!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Adarfo Sotelato: ""They made their choice the moment they stood in my way.""*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was that completely necessary?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Adarfo Sotelato: ""Yes. Stand in the way of the revolution, and you will fa..."*)

### Węzeł `[74]`
Mówca: **Adarfo Sotelato**
> ""They made their choice the moment they stood in my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They had it coming.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Adarfo Sotelato: ""I'm glad you agree.""*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing as Adarfo's men dragged her body aside."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Adarfo Sotelato: ""Anyone else feeling brave?""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Lucita_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Lucita_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Taddeus_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Taddeus_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[79]`
Mówca: **Adarfo Sotelato**
> ""Yes. Stand in the way of the revolution, and you will face the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[80]`
Mówca: **Adarfo Sotelato**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So this was your plan all along. I should have seen it coming.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Adarfo Sotelato: ""Yes, you should have.""*)

### Węzeł `[82]`
Mówca: **Adarfo Sotelato**
> ""Come now, did you truly believe the movement would allow you to remain in power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal = ..."*)

### Węzeł `[83]`
Mówca: **Adarfo Sotelato**
> ""Yes, you should have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal = ..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God will judge us both, Adarfo. But mark my words... He will not look kindly on treachery.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Adarfo Sotelato: ""If your God truly saw you fit for the throne, perhaps He..."*)

### Węzeł `[85]`
Mówca: **Adarfo Sotelato**
> ""If your God truly saw you fit for the throne, perhaps He would have stopped you from falling off it so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal = ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""God will judge us both, Adarfo. But mark my words... He ..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ha! You should see your faces!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true` AND `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Taddeus wheeled himself toward me."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Ha! You should see your faces!""*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
Mówca: **Taddeus Azaro**
> ""You should be ashamed of yourself! The end of the monarchy is no laughing matter!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Taddeus wheeled himself toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Taddeus Azaro: ""You should be ashamed of yourself! The end of the monarc..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Taddeus wheeled himself toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Taddeus Azaro: ""Shame on you, Romus Toras! You know nothing of loyalty a..."*)

### Węzeł `[96]`
Mówca: **Taddeus Azaro**
> ""Here I thought you were a king. You're nothing more than a court jester!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "He turned to Adarfo."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "He turned to Adarfo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Taddeus Azaro: ""As for you... Your movement will be crushed! This little..."*)

### Węzeł `[98]`
Mówca: **Taddeus Azaro**
> ""As for you... Your movement will be crushed! This little uprising will be nothing more than a stain in the history books!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Taddeus Azaro: ""House Azaro will never submit --especially to someone wh..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Taddeus wheeled himself toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Taddeus Azaro: ""'Had this coming?' You should be ashamed of yourself, Ro..."*)

### Węzeł `[100]`
Mówca: **Taddeus Azaro**
> ""'Had this coming?' You should be ashamed of yourself, Romus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Taddeus wheeled himself toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Taddeus Azaro: ""'Not as bad as it seems?' How dare you!""*)

### Węzeł `[102]`
Mówca: **Taddeus Azaro**
> ""'Not as bad as it seems?' How dare you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[103]`
Mówca: **Taddeus Azaro**
> ""I bled for you! I stood by you when others wouldn't. And for what? A knife in the back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Taddeus Azaro: ""Here I thought you were a king. You're nothing more than..."*)

### Węzeł `[104]`
Mówca: **Adarfo Sotelato**
> ""You're hardly any better, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Vina pulled away as Adarfo loosened his grip. He smirked ..."*)

### Węzeł `[105]`
Mówca: **Adarfo Sotelato**
> ""None of you are innocent. Don't you understand that yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Vina pulled away as Adarfo loosened his grip."*)

### Węzeł `[106]`
Mówca: **Adarfo Sotelato**
> ""I'm sorry, but I'm afraid your commands have no authority here. In any case, I believe I've made my point quite clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;"*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Vina pulled away as Adarfo loosened his grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Adarfo sauntered back and stood on top of a chair."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Vina looked at me, bewildered by my lack of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Adarfo sauntered back and stood on top of a chair."*)

### Węzeł `[109]`
Mówca: **Adarfo Sotelato**
> ""But she does know what real work is, Your Majesty. Unlike yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Mother pulled away as Adarfo loosened his grip. He smirke..."*)

### Węzeł `[110]`
Mówca: **Adarfo Sotelato**
> ""None of you are innocent. Don't you understand that yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Mother pulled away as Adarfo loosened his grip."*)

### Węzeł `[111]`
Mówca: **Adarfo Sotelato**
> ""I'm sorry, but I'm afraid that your commands have no authority here. In any case, I believe I've made my point quite clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Mother pulled away as Adarfo loosened his grip."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "Mother pulled away as Adarfo loosened his grip. He smirked at me as if this whole act was a test."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Adarfo sauntered back and stood on top of a chair."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Mother looked at me, bewildered by my lack of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Adarfo sauntered back and stood on top of a chair."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Mother pulled away as Adarfo loosened his grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Adarfo sauntered back and stood on top of a chair."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Vina pulled away as Adarfo loosened his grip. He smirked at me as if this whole act was a test."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Adarfo sauntered back and stood on top of a chair."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Adarfo sauntered back and stood on top of a chair."*)

### Węzeł `[118]`
Mówca: **Adarfo Sotelato**
> ""Let Mr. Toras go. I have something I want to show him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "They reluctantly loosened their grip. Adarfo gestured for..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "They reluctantly loosened their grip. Adarfo gestured for me to follow him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus_Italic: "Follow Adarfo."*)
  - -> `[121]` (*Player_Romus_Italic: "Stay where you are."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "Follow Adarfo."]** — Mówca: **Player_Romus_Italic**
> "Left without a choice, I followed Adarfo up the spiral staircase in the back of the hall leading to the second leave. His men weren't far behind."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Follow_Adarfo = true;"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "Stay where you are."]** — Mówca: **Player_Romus_Italic**
> "I didn't budge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""I'm not going anywhere with you.""*)
  - -> `[123]` (*Player_Romus: ""Thanks, but I respectfully decline.""*)
  - -> `[124]` (*Player_Romus: ""I don't take orders from you, nor will I ever.""*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going anywhere with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Adarfo Sotelato: ""So be it.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I respectfully decline.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Adarfo Sotelato: ""So be it.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't take orders from you, nor will I ever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Adarfo Sotelato: ""So be it.""*)

### Węzeł `[125]`
Mówca: **Adarfo Sotelato**
> ""So be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "With the others gone, the noise from outside became unmis..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "With the others gone, the noise from outside became unmistakable -- distant cheers and crackle of fireworks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Adarfo Sotelato: ""Do you hear that? That’s the sound of liberation.""*)

### Węzeł `[127]`
Mówca: **Adarfo Sotelato**
> ""Do you hear that? That’s the sound of liberation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Adarfo Sotelato: ""And it's all thanks to you. None of this would've been p..."*)

### Węzeł `[128]`
Mówca: **Adarfo Sotelato**
> ""And it's all thanks to you. None of this would've been possible without your help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: ""No. It wouldn't have... best you remember that.""*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[129]` (*Player_Romus: ""You mock me.""*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[135]` (*Player_Romus: ""Forgive me if I'm not in a celebratory mood.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You mock me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Adarfo Sotelato: ""Not at all. You'll be remembered as the man who ushered ..."*)

### Węzeł `[130]`
Mówca: **Adarfo Sotelato**
> ""Not at all. You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[131]`
Mówca: **Adarfo Sotelato**
> ""The king who fought and died to give his people a brighter future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[134]` (*Player_Romus: ""If you're expecting gratitude, you won't find it here.""*)
  - -> `[132]` (*Player_Romus: ""Died?""*)
  - -> `[154]` (*Player_Romus: ""A future built on betrayal and bloodshed. And here I tho..."*)
  - -> `[155]` (*Player_Romus: ""Given the circumstances, I suppose it's not the worst ou..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Died?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_AdarfoShoots = true; RiziaDLC.Ski..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. It wouldn't have... best you remember that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Adarfo Sotelato: ""How could I forget? You'll be remembered as the man who ..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're expecting gratitude, you won't find it here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Adarfo Sotelato: ""You think I care about your gratitude?""*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me if I'm not in a celebratory mood.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Adarfo Sotelato: ""For what it's worth, you'll be remembered as the man who..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let freedom ring.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false`
- **Kontekst wejściowy (poprzednik):** `[128]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Adarfo Sotelato: ""Exactly! For all to hear! You'll be remembered as the ma..."*)

### Węzeł `[137]`
Mówca: **Adarfo Sotelato**
> ""Your sacrifice will be remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""If you're expecting gratitude, you won't find it here.""*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[144]` (*Player_Romus: ""I've done my part. Please, just let me go.""*)
  - -> `[140]` (*Player_Romus: ""Sacrifice? Do you intend to kill me too?""*)
  - -> `[138]` (*Player_Romus: ""I did this for the Rizian people. You had better not let..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did this for the Rizian people. You had better not let them down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Adarfo Sotelato: ""That's not for you to worry about anymore.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're expecting gratitude, you won't find it here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Adarfo Sotelato: ""You think I care about your gratitude? I did what was ne..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sacrifice? Do you intend to kill me too?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "He didn't answer."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""You took my wife and unborn child from me. Nothing you s..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've done my part. Please, just let me go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Adarfo Sotelato: ""Not just yet.""*)

### Węzeł `[145]`
Mówca: **Adarfo Sotelato**
> ""Not just yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Adarfo Sotelato: ""Come along. Your final royal duty beckons.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You took my wife and unborn child from me. Nothing you say or do will ever justify that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Adarfo Sotelato: ""Be grateful you didn't meet the same fate.""*)

### Węzeł `[147]`
Mówca: **Adarfo Sotelato**
> ""Be grateful you didn't meet the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Adarfo Sotelato: ""Come along. Your final royal duty beckons.""*)

### Węzeł `[148]`
Mówca: **Adarfo Sotelato**
> ""You think I care about your gratitude? I did what was needed, not for you, but for the future -- for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Adarfo Sotelato: ""Come along. Your final royal duty beckons.""*)

### Węzeł `[149]`
Mówca: **Narrator**
> "He didn't answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Adarfo Sotelato: ""Come along. Your final royal duty beckons.""*)

### Węzeł `[150]`
Mówca: **Adarfo Sotelato**
> ""That's not for you to worry about anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Adarfo Sotelato: ""Come along. Your final royal duty beckons.""*)

### Węzeł `[151]`
Mówca: **Narrator**
> "For the second time in my life, a hood went over my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "Jeers mixed with screams of horror as I was led through t..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Follow_Adarfo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Follow_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Adarfo walked up to a large curtain and pulled it aside, ..."*)

### Węzeł `[153]`
Mówca: **Adarfo Sotelato**
> ""You think I care about your gratitude?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_AdarfoShoots = true; RiziaDLC.Ski..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A future built on betrayal and bloodshed. And here I thought we were building something lasting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Adarfo Sotelato: ""We are. You just won't be around long enough to see it.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Given the circumstances, I suppose it's not the worst outcome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Adarfo Sotelato: ""Glad you’re beginning to understand. You see... sometime..."*)

### Węzeł `[156]`
Mówca: **Adarfo Sotelato**
> ""We are. You just won't be around long enough to see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_AdarfoShoots = true; RiziaDLC.Ski..."*)

### Węzeł `[157]`
Mówca: **Adarfo Sotelato**
> ""Glad you’re beginning to understand. You see... sometimes, sacrifices are inevitable for a greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_AdarfoShoots = true; RiziaDLC.Ski..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""You took my wife and child away from me. Nothing you say..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You took my wife and child away from me. Nothing you say or do will ever replace that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Adarfo Sotelato: ""Don't worry. You'll be seeing them soon enough.""*)

### Węzeł `[162]`
Mówca: **Adarfo Sotelato**
> ""Don't worry. You'll be seeing them soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_AdarfoShoots = true; RiziaDLC.Ski..."*)

### Węzeł `[163]`
Mówca: **Adarfo Sotelato**
> ""For what it's worth, you'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[164]`
Mówca: **Adarfo Sotelato**
> ""How could I forget? You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && Ri..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Let freedom ring.""*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""The last thing I want is recognition.""*)

### Węzeł `[168]`
Mówca: **Adarfo Sotelato**
> ""Exactly! For all to hear! You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The last thing I want is recognition.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[128]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Adarfo Sotelato: ""Are you kidding me? You'll be remembered as the man who ..."*)

### Węzeł `[170]`
Mówca: **Adarfo Sotelato**
> ""Are you kidding me? You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did what had to be done.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false`
- **Kontekst wejściowy (poprzednik):** `[128]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Adarfo Sotelato: ""Yes, you did. You'll be remembered as the man who ushere..."*)

### Węzeł `[172]`
Mówca: **Adarfo Sotelato**
> ""Yes, you did. You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && Ri..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""I did what had to be done.""*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: ""No... I suppose not.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No... I suppose not.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[128]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Adarfo Sotelato: ""You'll be remembered as the man who ushered in a new era..."*)

### Węzeł `[177]`
Mówca: **Adarfo Sotelato**
> ""You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Banners of revolution waved proudly as fireworks illuminated the night sky."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Adarfo Sotelato: ""Do you see that? That’s what liberation looks like.""*)

### Węzeł `[179]`
Mówca: **Adarfo Sotelato**
> ""Do you see that? That’s what liberation looks like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Adarfo Sotelato: ""And it's all thanks to you. None of this would've been p..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Adarfo walked up to a large curtain and pulled it aside, revealing the street below illuminated with cheers and celebrations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Banners of revolution waved proudly as fireworks illumina..."*)

### Węzeł `[181]`
Mówca: **Taddeus Azaro**
> ""Shame on you, Romus Toras! You know nothing of loyalty and honor!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[182]`
Mówca: **Narrator**
> "A bullet whizzed past us, close enough to leave a sharp ringing in my ears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[188]` (*Player_Romus: ""If anything happens to my family, you will pay.""*)
  - -> `[189]` (*Player_Romus: ""This is too much. Order them to stand down immediately!""*)
  - -> `[190]` (*Player_Romus: ""TITUS! I ORDER YOU TO STAND DOWN!""*)

### Węzeł `[183]`
Mówca: **Adarfo Sotelato**
> ""Stop worrying. It will be over soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "A bullet whizzed past us, close enough to leave a sharp r..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player_Romus: ""My daughter is in the building! I have to get her out!""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter is in the building! I have to get her out!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Adarfo Sotelato: ""Wait!""*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If anything happens to my family, you will pay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Adarfo Sotelato: ""They'll be fine. I promise.""*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is too much. Order them to stand down immediately!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Adarfo Sotelato: ""It's too late for that.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""TITUS! I ORDER YOU TO STAND DOWN!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Titus paused for a moment and glanced my way, just as a m..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Adarfo walked up to Manus and roughly examined his palms."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Adarfo walked up to Leona and roughly examined her palms."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Damn! Titus will kill all of us!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Adarfo Sotelato: ""Stop worrying. It will be over soon.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nicely done. My compliments to your men.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Adarfo Sotelato: ""It's not pretty. But true change rarely is.""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you botch this, Adarfo! Do you hear me? If your guys fail, we're screwed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Adarfo Sotelato: ""Stop worrying. It will be over soon.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What the hell is going on!? I thought you were capable of a silent assault!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Adarfo Sotelato: ""Stop worrying. It will be over soon.""*)

### Węzeł `[198]`
Mówca: **Narrator**
> "As I peeked in Titus' direction, I noticed a man with a knife charging at him from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Manus Sazon: ""Your Majesty! What have you done!?""*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Hugo Toras: ""Captain Gordion! Handle this at once!""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""Titus! Behind you!""*)
  - -> `[13]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[203]`
Mówca: **Adarfo Sotelato**
> ""It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "As I peeked in Titus' direction, I noticed a man with a k..."*)

### Węzeł `[204]`
Mówca: **Adarfo Sotelato**
> ""Wait!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "As I peeked in Titus' direction, I noticed a man with a k..."*)

### Węzeł `[205]`
Mówca: **Adarfo Sotelato**
> ""They'll be fine. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "As I peeked in Titus' direction, I noticed a man with a k..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Titus paused for a moment and glanced my way, just as a man with a knife charged at him from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[207]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing as Adarfo continued showing off my daughter's hand. He eyed me, almost as if baiting, before eventually letting go."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Vina looked at me, bewildered by my lack of action."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right, Vina. You're an armchair liberal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Adarfo Sotelato: ""You're hardly any better, Your Majesty.""*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be reasonable, Adarfo. My daughter is innocent in all this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Adarfo Sotelato: ""None of you are innocent. Don't you understand that yet?""*)

### Węzeł `[210]`
Mówca: **Manus Sazon**
> ""Your Majesty! What have you done!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Hugo Toras: ""Captain Gordion! Handle this at once!""*)

### Węzeł `[211]`
Mówca: **Hugo Toras**
> ""Captain Gordion! Handle this at once!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "One man leveled his gun at Hugo, but Titus drew his weapo..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Titus, wielding his sidearm, managed to take down an attacker before jumping behind a serving trolley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Titus Gordion: ""SUPPRESSIVE FIRE!""*)

### Węzeł `[213]`
Mówca: **Narrator**
> "Adarfo walked up to Manus and roughly examined his palms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Adarfo Sotelato: ""Soft.""*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Adarfo walked up to Leona and roughly examined her palms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Adarfo Sotelato: ""Soft.""*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "He took Vina by the wrist and held her arm high."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "He took Mother by the wrist and held her arm high."*)

### Węzeł `[218]`
Mówca: **Adarfo Sotelato**
> ""A fisherman's daughter who turned her back on the commoners' struggle as soon as she fished herself a royal husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Estela Toras: ""For heaven's sake, Romus, are you really going to let hi..."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "He took Vina by the wrist and held her arm high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)

### Węzeł `[220]`
Mówca: **Titus Gordion**
> ""SUPPRESSIVE FIRE!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "The room filled with screams and the deafening crack of g..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == tr..."*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Vina Toras: ""FATHER!""*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Titus, wielding his sidearm, managed to take down an atta..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Adarfo == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "As I dove for cover behind the table, I realized Adarfo w..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Titus took down two more attackers, just as a man with a ..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "As I dove for cover behind the table, I realized Adarfo was crouched beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player_Romus: ""Nicely done. My compliments to your men.""*)
  - -> `[196]` (*Player_Romus: ""Don't you botch this, Adarfo! Do you hear me? If your gu..."*)
  - -> `[197]` (*Player_Romus: ""What the hell is going on!? I thought you were capable o..."*)
  - -> `[194]` (*Player_Romus: ""Damn! Titus will kill all of us!""*)

### Węzeł `[228]`
Mówca: **Narrator**
> "The room filled with screams and the deafening crack of gunshots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Shooting nobles at their mother's birthd..."*)

### Węzeł `[229]`
Mówca: **Vina Toras**
> ""FATHER!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Titus, wielding his sidearm, managed to take down an atta..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sotelato. I command you to get your hands off of her!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Adarfo Sotelato: ""I'm sorry, but I'm afraid your commands have no authorit..."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "He turned to Hubertus and grabbed his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Adarfo Sotelato: ""Uncalloused.""*)

### Węzeł `[232]`
Mówca: **Narrator**
> "He took Mother by the wrist and held her arm high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Adarfo Sotelato: ""A fisherman's daughter who turned her back on the common..."*)

### Węzeł `[233]`
Mówca: **Vina Toras**
> ""Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player_Romus: ""Mr. Sotelato. I command you to get your hands off of her!""*)
  - -> `[209]` (*Player_Romus: ""Be reasonable, Adarfo. My daughter is innocent in all th..."*)
  - -> `[208]` (*Player_Romus: ""He's right, Vina. You're an armchair liberal.""*)
  - -> `[207]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[234]`
Mówca: **Estela Toras**
> ""For heaven's sake, Romus, are you really going to let him get away with this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player_Romus: ""Mr. Sotelato. I command you to get your hands off of her!""*)
  - -> `[238]` (*Player_Romus: ""Be reasonable, Adarfo. My mother is innocent in all this.""*)
  - -> `[237]` (*Player_Romus: ""He's right, Mother. You're a class traitor.""*)
  - -> `[236]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[235]`
Mówca: **Titus Gordion**
> ""You got my men killed, Your Majesty! Good men who devoted their lives to protecting you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Adarfo Sotelato: ""Enough! Hands. Let me see your hands.""*)

### Węzeł `[236]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing as Adarfo continued showing off Mother's hand. He eyed me, almost as if baiting, before eventually letting go."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Mother looked at me, bewildered by my lack of action."*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right, Mother. You're a class traitor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Adarfo Sotelato: ""But she does know what real work is, Your Majesty. Unlik..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be reasonable, Adarfo. My mother is innocent in all this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Adarfo Sotelato: ""None of you are innocent. Don't you understand that yet?""*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sotelato. I command you to get your hands off of her!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Adarfo Sotelato: ""I'm sorry, but I'm afraid that your commands have no aut..."*)

### Węzeł `[240]`
Mówca: **Adarfo Sotelato**
> ""Something that should have been done a long time ago. Men, escort our friends into the atrium.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_SeizedLibr..."*)

### Węzeł `[241]`
Mówca: **Daria de Rava**
> ""Mr. Sotelato! What have you done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Adarfo Sotelato: ""Something that should have been done a long time ago. Me..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""What kind of king invites revolutionaries to attack his family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[246]`
Mówca: **Hugo Toras**
> ""You organized this with the rebels? How could you?! Do you have any idea what you've done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[247]`
Mówca: **Narrator**
> "My guests barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Rico Toras: ""Holy shit!""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "My guests barely had time to react."*)

### Węzeł `[251]`
Mówca: **Rico Toras**
> ""Holy shit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "My guests barely had time to react."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Adarfo == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Narrator: "Adarfo stepped out from his cover and slapped me on the b..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The doors burst open and Adarfo Sotelato stepped inside. ..."*)

### Węzeł `[255]`
Mówca: **Narrator**
> "Adarfo stepped out from his cover and slapped me on the back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Adarfo Sotelato: ""You see? What did I tell you?""*)

### Węzeł `[256]`
Mówca: **Pabel Adria**
> ""Romus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: ""Mr. Sotelato! What is the meaning of this?""*)

### Węzeł `[257]`
Mówca: **Narrator**
> "Held at gunpoint, everyone did as they were told."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[258]`
Mówca: **Estela Toras**
> ""Mr. Sotelato! What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Adarfo Sotelato: ""I'm so glad you asked. Let it be known that every one of..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true )"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "AddConversant("Pabel Adria");"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "When we entered the room, Mother stood up abruptly."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "When we entered the room, Mother and Pabel stood up abruptly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Pabel Adria: ""Romus!""*)

### Węzeł `[263]`
Mówca: **Narrator**
> "When we entered the room, Mother stood up abruptly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Estela Toras: ""Oh my God! Romus!""*)

### Węzeł `[264]`
Mówca: **Estela Toras**
> ""Oh my God! Romus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: ""Mr. Sotelato! What is the meaning of this?""*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "Attack Adarfo."]** — Mówca: **Player_Romus_Italic**
> "I leapt off the floor and lunged at Adarfo, determined to break his neck. His men restrained me before I could reach him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Adarfo Sotelato), `[69]` (Adarfo Sotelato), `[71]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_King_Resists += 2; Ri..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "Restrain yourself."]** — Mówca: **Player_Romus_Italic**
> "I held back the urge to act rashly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Adarfo Sotelato), `[69]` (Adarfo Sotelato), `[71]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Adarfo Sotelato: ""Anyone else feeling brave?""*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_King_Resists += 2; RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] + 2;
Variable["RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Adarfo Sotelato: ""Don't do that again.""*)

### Węzeł `[268]`
Mówca: **Adarfo Sotelato**
> ""Don't do that again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Adarfo Sotelato: ""Anyone else feeling brave?""*)

### Węzeł `[269]`
Mówca: **Adarfo Sotelato**
> ""Anyone else feeling brave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus_Italic: "Attack Adarfo."*)
  - -> `[266]` (*Player_Romus_Italic: "Restrain yourself."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Adarfo Sotelato: ""Anyone else feeling brave?""*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Mother's silent condemnation was undeniable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Hubertu..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "Pabel's face was filled with disappointment, as if I had ..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[276]`
Mówca: **Narrator**
> "Pabel's face was filled with disappointment, as if I had let him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == false"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "Vina's face was filled with disappointment, as if I had l..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Mother's silent condemnation was undeniable."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "Worse were Vina and Mother, whose silent condemnation was undeniable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Hubertu..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == false"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == false)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Worse were Vina and Mother, whose silent condemnation was..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Worse was Mother, whose silent condemnation was undeniable."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Worse was Mother, whose silent condemnation was undeniable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Hubertu..."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "Vina's face was filled with disappointment, as if I had let her down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Mother's silent condemnation was undeniable."*)

### Węzeł `[286]`
Mówca: **Adarfo Sotelato**
> ""Courtesy of your esteemed sovereign... that ends today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "All eyes turned to me."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player_Romus: ""That's right. I'm giving my full support to Mr. Sotelato..."*)
  - -> `[345]` (*Player_Romus: ""I had no other choice. It is time to let go of the throne.""*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Player_Romus: ""I had no other choice. We need these reforms.""*)
  - -> `[318]` (*Player_Romus: ""That's right. Now sign the new constitution so we can al..."*)
  - -> `[399]` (*Player_Romus: ""This wasn't part of the plan.""*)

### Węzeł `[290]`
Mówca: **Adarfo Sotelato**
> ""You see? What did I tell you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Daria de Rava: ""Mr. Sotelato! What have you done?""*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Lucita's scream pierced the room."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Adarfo Sotelato: ""Anyone else feeling brave?""*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Manus rushed for Adarfo, but his men held him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Vina Toras: ""Let go of me!""*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDL..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Vina Toras: ""Let go of me!""*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true )"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Manus rushed for Adarfo, but his men held him back."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "Axel rushed for Adarfo, but his men held him back."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Rico cowered, doing nothing as the scene unfolded."*)

### Węzeł `[304]`
Mówca: **Narrator**
> "Axel rushed for Adarfo, but his men held him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Vina Toras: ""Let go of me!""*)

### Węzeł `[305]`
Mówca: **Narrator**
> "Rico cowered, doing nothing as the scene unfolded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Vina Toras: ""Let go of me!""*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Everyone_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Everyone_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Adarfo's men restrained every individual in the room with..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Taddeus wheeled himself forward."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "When we entered the room, Mother and Pabel stood up abrup..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[311]`
Mówca: **Adarfo Sotelato**
> ""It's not pretty. But true change rarely is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "A bullet whizzed past us, close enough to leave a sharp r..."*)

### Węzeł `[312]`
Mówca: **Manus Sazon**
> ""Mr. Sotelato! What have you done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Adarfo Sotelato: ""Something that should have been done a long time ago. Me..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Manus Sazon: ""Mr. Sotelato! What have you done?""*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Hugo Toras: ""You... What have you done?!""*)

### Węzeł `[316]`
Mówca: **Hugo Toras**
> ""You... What have you done?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Adarfo Sotelato: ""Something that should have been done a long time ago. Me..."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "All eyes turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Hugo Toras: ""You organized this with the rebels? How could you?! Do y..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right. Now sign the new constitution so we can all get on with our lives.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucita Azaro), `[373]` (Narrator), `[246]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Adarfo choked back a laugh."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "Adarfo choked back a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Adarfo Sotelato: ""It's a little too late for that.""*)

### Węzeł `[320]`
Mówca: **Adarfo Sotelato**
> ""It's a little too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Titus Gordion: ""You got my men killed, Your Majesty! Good men who devote..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Adarfo Sotelato: ""A Princess reading the words of Malenyev -- but what do ..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Adarfo Sotelato: ""A Princess claiming to sympathize with the people -- but..."*)

### Węzeł `[324]`
Mówca: **Adarfo Sotelato**
> ""A Princess reading the words of Malenyev -- but what do you know of the workers' struggle? Nothing!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)

### Węzeł `[325]`
Mówca: **Adarfo Sotelato**
> ""A Princess claiming to sympathize with the people -- but what do you know of their struggle? Nothing!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Taddeus Azaro: ""I bled for you! I stood by you when others wouldn't. And..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Taddeus Azaro: ""I bled for your father! I stood by him when others would..."*)

### Węzeł `[329]`
Mówca: **Taddeus Azaro**
> ""I bled for your father! I stood by him when others wouldn't. And for what? A knife in the back from his coward of a son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "He turned to Adarfo."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RomanceHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RomanceHappened == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RomanceHappened == true)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RomanceHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player_Romus: ""How could you?! I loved her!""*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RomanceHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""Was that completely necessary?""*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could you?! I loved her!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Adarfo Sotelato: ""I'm sorry. But anyone who stands in the way of revolutio..."*)

### Węzeł `[334]`
Mówca: **Adarfo Sotelato**
> ""I'm sorry. But anyone who stands in the way of revolution has to face the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_SeizedLibrary = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_SeizedLibrary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Held at gunpoint, everyone did as they were told."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "Without warning, Adarfo drew his gun and shot him."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "Without warning, Adarfo drew his gun and shot him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed = true; RiziaDLCSupport.Journal..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunfight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The guards, unprepared for the ambush, were overwhelmed. ..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_AdarfoShoots = true;
RiziaDLC.SkipToEpilogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Death_AdarfoShoots"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Birthday = true;
RiziaDLC.Birthday_Adarfo_Usurped = true;
RiziaDLC.SkipToEnding = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Revolution_Birthday"] = true;
Variable["RiziaDLC.Birthday_Adarfo_Usurped"] = true;
Variable["RiziaDLC.SkipToEnding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no other choice. We need these reforms.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucita Azaro), `[373]` (Narrator), `[246]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Adarfo choked back a laugh."*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Violence wasn't part of the plan.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucita Azaro), `[373]` (Narrator), `[246]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Titus Gordion: ""You got my men killed, Your Majesty! Good men who devote..."*)

### Węzeł `[343]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucita Azaro), `[373]` (Narrator), `[246]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Titus Gordion: ""You got my men killed, Your Majesty! Good men who devote..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player_Romus_Italic: "Stay silent."*)
  - -> `[342]` (*Player_Romus: ""Violence wasn't part of the plan.""*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no other choice. It is time to let go of the throne.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucita Azaro), `[373]` (Narrator), `[246]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Hugo Toras: ""You've gone mad!""*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right. I'm giving my full support to Mr. Sotelato to form a new democratic government.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucita Azaro), `[373]` (Narrator), `[246]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Hugo Toras: ""You've gone mad!""*)

### Węzeł `[347]`
Mówca: **Hugo Toras**
> ""You've gone mad!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Titus Gordion: ""You got my men killed, Your Majesty! Good men who devote..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop with the theatrics, Mr. Sotelato. We are here for the signatures.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Adarfo Sotelato: ""No. That ship has sailed.""*)

### Węzeł `[349]`
Mówca: **Adarfo Sotelato**
> ""No. That ship has sailed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Adarfo Sotelato: ""The only recognized constitution in Rizia shall be the o..."*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop with the theatrics, Mr. Sotelato. This is supposed to be a *smooth and peaceful* transition.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Taddeus wheeled himself toward me."*)

### Węzeł `[351]`
Mówca: **Narrator**
> "I froze momentarily, unable to react at all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3"*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3)"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Adarfo Sotelato: ""Let Mr. Toras go. I have something I want to show him.""*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Adarfo Sotelato: ""Good work, *Your Majesty*.""*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Adarfo Sotelato: ""The king who fought and died to give his people a bright..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And so the great House of Azaro ends.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Adarfo Sotelato: ""As all noble houses must.""*)

### Węzeł `[357]`
Mówca: **Adarfo Sotelato**
> ""As all noble houses must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""All right, Mr. Sotelato! We submit! Please, don’t harm a..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Player_Romus: ""I urge you all to do as he asks. Nobody else needs to ge..."*)
  - -> `[361]` (*Player_Romus: ""You monster! This wasn't part of the plan!""*)
  - -> `[363]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You monster! This wasn't part of the plan!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[269]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Hugo Toras: ""For heaven's sake, Romus, shut up before you get the res..."*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I urge you all to do as he asks. Nobody else needs to get hurt.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[269]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "With a withering glance at me, Hugo nodded."*)

### Węzeł `[363]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I didn't say a word. Finally, Hugo broke the silence."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[269]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Hugo Toras: ""We submit, Mr. Sotelato. Please don't harm anyone else.""*)

### Węzeł `[364]`
Mówca: **Russello Montoro**
> ""Now you wait just a gosh-darn second--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "Without looking in Rusty's direction, Adarfo signalled to..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true"*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rusty == true)"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Russello Montoro: ""Now you wait just a gosh-darn second--""*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Adarfo Sotelato: ""Courtesy of your esteemed sovereign... that ends today.""*)

### Węzeł `[368]`
Mówca: **Narrator**
> "Without looking in Rusty's direction, Adarfo signalled to one of his men, who swiftly drew his rifle and shot the gold magnate in the head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Somebody screamed. Adarfo permitted himself a smile."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "Somebody screamed. Adarfo permitted himself a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Adarfo Sotelato: ""Courtesy of your esteemed sovereign... that ends today.""*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "Lucita shook with rage, unable to form words."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucita Azaro: ""What kind of king invites revolutionaries to attack his ..."*)

### Węzeł `[373]`
Mówca: **Narrator**
> "Lucita shook with rage, unable to form words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras"); RemoveConversant("Hubertus Toras"); RemoveConversant("Estela Toras"); RemoveConversant("Leona Sazon"); RemoveConversant("Titus Gordion"); RemoveConversant("Angelica Sazon"); RemoveConversant("Manus Sazon"); RemoveConversant("Vina Toras"); RemoveConversant("Rico Toras"); RemoveConversant("Axel Reinhart"); RemoveConversant("Russello Montoro"); RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Hubertus Toras");
RemoveConversant("Estela Toras");
RemoveConversant("Leona Sazon");
RemoveConversant("Titus Gordion");
RemoveConversant("Angelica Sazon");
RemoveConversant("Manus Sazon");
RemoveConversant("Vina Toras");
RemoveConversant("Rico Toras");
RemoveConversant("Axel Reinhart");
RemoveConversant("Russello Montoro");
RemoveConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "After a while, I realized that I was the only living nobl..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true"*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rusty == true)"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "Rusty, Lucita and Taddeus' bodies had been piled in a cor..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "Lucita and Taddeus' bodies had been piled in a corner."*)

### Węzeł `[378]`
Mówca: **Narrator**
> "Rusty, Lucita and Taddeus' bodies had been piled in a corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true"*)

### Węzeł `[379]`
Mówca: **Narrator**
> "After a while, I realized that I was the only living noble left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[380]`
Mówca: **Narrator**
> "Lucita and Taddeus' bodies had been piled in a corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rusty == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "Taddeus and Rusty's bodies had been piled in a corner."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "Taddeus' corpse lay in a corner, next to his wheelchair."*)

### Węzeł `[384]`
Mówca: **Narrator**
> "Taddeus and Rusty's bodies had been piled in a corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true"*)

### Węzeł `[385]`
Mówca: **Narrator**
> "Taddeus' corpse lay in a corner, next to his wheelchair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "Adarfo's men continued to hold me back. He walked over to..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Adarfo's men moved in to restrain me. He walked over to u..."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "Adarfo's men continued to hold me back. He walked over to us and looked me up and down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3"*)

### Węzeł `[390]`
Mówca: **Narrator**
> "Adarfo's men moved in to restrain me. He walked over to us and swiftly looked me up and down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3"*)

### Węzeł `[391]`
Mówca: **Adarfo Sotelato**
> ""Good work, *Your Majesty*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Adarfo Sotelato: ""Your sacrifice will be remembered.""*)

### Węzeł `[392]`
Mówca: **Hugo Toras**
> ""For heaven's sake, Romus, shut up before you get the rest of us killed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;"*)

### Węzeł `[393]`
Mówca: **Hugo Toras**
> ""We submit, Mr. Sotelato. Please don't harm anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Adarfo Sotelato: ""I don't need your submission. I need you out of the way.""*)

### Węzeł `[394]`
Mówca: **Narrator**
> "With a withering glance at me, Hugo nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Hugo Toras: ""We submit, Mr. Sotelato. Please don't harm anyone else.""*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Hugo Toras: ""We submit, Mr. Sotelato. Please don't harm anyone else.""*)

### Węzeł `[396]`
Mówca: **Adarfo Sotelato**
> ""Come along. Your final royal duty beckons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "For the second time in my life, a hood went over my head."*)

### Węzeł `[397]`
Mówca: **Narrator**
> "Jeers mixed with screams of horror as I was led through the crowd outside and shoved into a waiting car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "Our destination -- just like Rizia's -- was unknown."*)

### Węzeł `[398]`
Mówca: **Narrator**
> "Our destination -- just like Rizia's -- was unknown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Birthday = true; RiziaDLC.Bi..."*)

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This wasn't part of the plan.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucita Azaro), `[373]` (Narrator), `[246]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Titus Gordion: ""You got my men killed, Your Majesty! Good men who devote..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Adarfo reacted instantly. Another shot rang out as the kn..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == true"*)
