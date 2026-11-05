# Rizia/Turn 5/FPnT_MITZHegelCall

- **ID konwersacji:** `322`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Rizia/Turn_05/322_FPnT_MITZHegelCall.md`
- **Liczba węzłów dialogowych:** 780
- **Liczba wyborów gracza:** 229

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[78]** Emmerich Hegel (R)
- **[90]** Bruno
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech`
- `RiziaDLC.InvestigatePoisoning_NoPabel`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Lucita_CompromisingPhoto`
- `RiziaDLC.Military_Valgsland_AcceptNavalAid`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedEarly`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Trait_CommieKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy`
- `RiziaDLC.Turn05_ITZVote_Nationalization`
- `RiziaDLC.Turn05_ITZVote_StatusQuo`
- `RiziaDLC.Turn05_MurderInvest_SuspectPabel`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover`
- `RiziaDLC.Hegel_OpenToRevolution`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Military_Valgsland_AcceptNavalAid`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows`
- `RiziaDLC.ToldAboutComradeVina`
- `RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid`
- `RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ`
- `RiziaDLCSupport.News_Turn05_G_ValgslandANSupport`
- `RiziaDLCSupport.Reports_Turn05_Morella_MITZ_NationalizationInvite`
- `RiziaDLCSupport.Reports_Turn05_Morella_MITZ_RenegotiationInvite`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[22]` | **""All right. Come in and help me get dressed.""** | `[17]` **Pabel Adria**: ""Sorry to wake you, Your Majesty..."<br>`[18]` **Pabel Adria**: ""Sorry, Romus, but there's an ap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "Pabel opened the door. Bruno jum..."<br>`[35]` **Narrator**: "Pabel opened the door and briskl..." |
| `[23]` | **""I'll be right out.""** | `[17]` **Pabel Adria**: ""Sorry to wake you, Your Majesty..."<br>`[18]` **Pabel Adria**: ""Sorry, Romus, but there's an ap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "I quickly dressed and joined Pab..."<br>`[33]` **Narrator**: "I quickly dressed and joined Pab..." |
| `[34]` | **""So, it's been a while since Qalus...""** | `[35]` **Narrator**: "Pabel opened the door and briskl..."<br>`[47]` **Narrator**: "Bruno sat down. Pabel gave him a..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[44]` **Narrator**: "Pabel turned around and gave me ..." |
| `[36]` | **""I'd wag my tail if I had one.""** | `[28]` **Pabel Adria**: ""Someone's happy to see me."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "Pabel let out a short laugh, the..."<br>`[49]` **Narrator**: "Pabel didn't smile. He briskly m..." |
| `[37]` | **""Who wouldn't be happy to see you, Pabel?""** | `[28]` **Pabel Adria**: ""Someone's happy to see me."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Narrator**: "He acknowledged my remark with a..."<br>`[49]` **Narrator**: "Pabel didn't smile. He briskly m..." |
| `[38]` | **""Bad dog, Bruno! Sit!""** | `[28]` **Pabel Adria**: ""Someone's happy to see me."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "Bruno sat down. Pabel gave him a..." |
| `[42]` | **""How are you, Pabel?""** | `[35]` **Narrator**: "Pabel opened the door and briskl..."<br>`[47]` **Narrator**: "Bruno sat down. Pabel gave him a..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Pabel Adria**: ""I'm well, {RiziaDLCText.PabelTo..." |
| `[43]` | **""What am I wearing?""** | `[35]` **Narrator**: "Pabel opened the door and briskl..."<br>`[47]` **Narrator**: "Bruno sat down. Pabel gave him a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Pabel Adria**: ""It's only a phone call. A simpl..." |
| `[59]` | **"Grab his hands."** | `[55]` **Narrator**: "He tied the sash, allowing his f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Player_Romus**: ""I can't stop thinking about our..."<br>`[62]` **Player_Romus**: ""When can we see each other agai..."<br>*(oraz 1 innych odgałęzień)* |
| `[61]` | **""I can't stop thinking about our night together.""** | `[59]` **Player_Romus_Italic**: "I stopped him and grabbed his ha..."<br>`[704]` **Pabel Adria**: ""That doesn't mean I was a eunuch.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "He took a step closer to me and ..." |
| `[62]` | **""When can we see each other again? And by 'see', I mean...""** | `[59]` **Player_Romus_Italic**: "I stopped him and grabbed his ha..."<br>`[704]` **Pabel Adria**: ""That doesn't mean I was a eunuch.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "He took a step closer to me and ..." |
| `[63]` | **""Why are you being so distant to me?""** | `[59]` **Player_Romus_Italic**: "I stopped him and grabbed his ha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "He took a step closer to me and ..." |
| `[69]` | **""I am the ruler of this country. I shouldn't have to hide my proclivities.""** | `[66]` **Pabel Adria**: ""As a servant, I'm used to creep..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Pabel Adria**: ""It's not just a proclivity,{Riz..." |
| `[70]` | **""We'll come up with a cover story. You sleep in my room to help me with my night t..."** | `[66]` **Pabel Adria**: ""As a servant, I'm used to creep..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Pabel Adria**: ""I don't want to subject you to ..." |
| `[71]` | **""Wait. How much 'creeping around' have you done?""** | `[66]` **Pabel Adria**: ""As a servant, I'm used to creep..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Pabel Adria**: ""Enough to know that passion can..." |
| `[72]` | **""I've done some creeping of my own, you know. But it was easier as a prince.""** | `[66]` **Pabel Adria**: ""As a servant, I'm used to creep..." | `Variable["RiziaDLC.Prologue_HadAffairs"] == true` | *Brak zmian stanu* | `[83]` **Pabel Adria**: ""Yes, you're under much more scr..." |
| `[76]` | **"Let him finish dressing you."** | `[55]` **Narrator**: "He tied the sash, allowing his f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "Once I was dressed, we walked th..." |
| `[86]` | **""There must be some way we can meet in total secrecy.""** | `[77]` **Pabel Adria**: ""I'll be under extra scrutiny no..."<br>`[85]` **Pabel Adria**: ""I don't think anyone suspects a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Pabel Adria**: ""We'll figure it out. But not to..." |
| `[87]` | **""Careful there. I wouldn't want impure thoughts distracting me from my meeting.""** | `[55]` **Narrator**: "He tied the sash, allowing his f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Narrator**: "The shadow of a smile passed acr..." |
| `[91]` | **""How are you, Pabel?""** | `[29]` **Narrator**: "I quickly dressed and joined Pab..."<br>`[33]` **Narrator**: "I quickly dressed and joined Pab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Pabel Adria**: ""I'm well, {RiziaDLCText.PabelTo..." |
| `[92]` | **""So, it's been a while since Qalus...""** | `[29]` **Narrator**: "I quickly dressed and joined Pab..."<br>`[33]` **Narrator**: "I quickly dressed and joined Pab..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[96]` **Narrator**: "Pabel glanced behind us, then sp..." |
| `[99]` | **""Any idea what this call is about?""** | `[29]` **Narrator**: "I quickly dressed and joined Pab..."<br>`[33]` **Narrator**: "I quickly dressed and joined Pab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "Pabel shook his head." |
| `[102]` | **""That's all I get?""** | `[45]` **Pabel Adria**: ""I'm well, {RiziaDLCText.PabelTo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Pabel Adria**: ""You've got an important phone c..."<br>`[121]` **Pabel Adria**: ""I would prefer my personal life..." |
| `[103]` | **""Glad to hear it.""** | `[45]` **Pabel Adria**: ""I'm well, {RiziaDLCText.PabelTo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Narrator**: "He pulled a deep blue silk robe ..." |
| `[104]` | **""Any palace intrigue I need to know about?""** | `[45]` **Pabel Adria**: ""I'm well, {RiziaDLCText.PabelTo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Pabel Adria**: ""No, Your Majesty.""<br>`[112]` **Pabel Adria**: ""Well, the entire staff knows ab..."<br>*(oraz 2 innych odgałęzień)* |
| `[122]` | **""That's all I get?""** | `[98]` **Pabel Adria**: ""I'm well, {RiziaDLCText.PabelTo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Pabel Adria**: ""You've got an important phone c..."<br>`[131]` **Pabel Adria**: ""I would prefer my personal life..." |
| `[123]` | **""Glad to hear it.""** | `[98]` **Pabel Adria**: ""I'm well, {RiziaDLCText.PabelTo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "We walked through the palace cor..." |
| `[124]` | **""Any palace intrigue I need to know about?""** | `[98]` **Pabel Adria**: ""I'm well, {RiziaDLCText.PabelTo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Pabel Adria**: ""No, Your Majesty.""<br>`[129]` **Pabel Adria**: ""Well, the entire staff knows ab..."<br>*(oraz 2 innych odgałęzień)* |
| `[143]` | **""This isn't right, damn it.""** | `[77]` **Pabel Adria**: ""I'll be under extra scrutiny no..."<br>`[85]` **Pabel Adria**: ""I don't think anyone suspects a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Pabel Adria**: ""It's the way that it is."" |
| `[144]` | **""You're right, of course. I shouldn't sabotage my reign over a misguided dalliance.""** | `[77]` **Pabel Adria**: ""I'll be under extra scrutiny no..."<br>`[85]` **Pabel Adria**: ""I don't think anyone suspects a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Pabel Adria**: ""Not *that* misguided, I hope."" |
| `[150]` | **""To be continued.""** | `[90]` **Narrator**: "He tightened the sash and smooth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "We walked through the palace cor..." |
| `[151]` | **""Thank you, Pabel.""** | `[90]` **Narrator**: "He tightened the sash and smooth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "We walked through the palace cor..." |
| `[152]` | **""Let's go. I shouldn't keep this mysterious caller waiting.""** | `[90]` **Narrator**: "He tightened the sash and smooth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "We walked through the palace cor..." |
| `[153]` | **"Pick it up."** | `[21]` **Narrator**: "An attendant stood ready with th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Player_Romus**: ""You'd better have a good reason..."<br>`[155]` **Player_Romus**: ""I didn't expect to hear from yo..."<br>*(oraz 1 innych odgałęzień)* |
| `[154]` | **""You'd better have a good reason for calling me this late, Chancellor.""** | `[153]` **Player_Romus_Italic**: "I picked up the phone." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Emmerich Hegel (R)**: ""Is it late? I never did have a ..." |
| `[155]` | **""I didn't expect to hear from you this soon.""** | `[153]` **Player_Romus_Italic**: "I picked up the phone." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Emmerich Hegel (R)**: ""No? After the way things ended ..." |
| `[158]` | **""Good evening, Mr. Hegel.""** | `[153]` **Player_Romus_Italic**: "I picked up the phone." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Emmerich Hegel (R)**: ""Hello, Mr. Toras."" |
| `[161]` | **""I'll say. I was wondering why you never responded to my speech at the AN.""** | `[160]` **Emmerich Hegel (R)**: ""I'm truly sorry to disturb you ..." | `Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] == true` | *Brak zmian stanu* | `[172]` **Emmerich Hegel (R)**: ""I appreciated your words then, ..." |
| `[165]` | **""What do you mean?""** | `[160]` **Emmerich Hegel (R)**: ""I'm truly sorry to disturb you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Emmerich Hegel (R)**: ""The nationalization vote was a ..."<br>`[186]` **Emmerich Hegel (R)**: ""The nationalization vote was un..." |
| `[166]` | **""Your apology is not accepted. We should be speaking in daylight hours, accompanie..."** | `[160]` **Emmerich Hegel (R)**: ""I'm truly sorry to disturb you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Emmerich Hegel (R)**: ""I wanted to talk man to man, fo..." |
| `[170]` | **""It's too late to change my mind about the nationalization vote. What's done is do..."** | `[160]` **Emmerich Hegel (R)**: ""I'm truly sorry to disturb you ..." | `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false` | *Brak zmian stanu* | `[180]` **Emmerich Hegel (R)**: ""Yes, the vote has concluded. Bu..." |
| `[171]` | **""You must be talking about the MITZ nationalization plan.""** | `[160]` **Emmerich Hegel (R)**: ""I'm truly sorry to disturb you ..." | `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true` | *Brak zmian stanu* | `[178]` **Emmerich Hegel (R)**: ""Of course. Needless to say, I w..." |
| `[188]` | **""I'm happy to hear that. By voting for nationalization, I wanted to signal that Ri..."** | `[181]` **Emmerich Hegel (R)**: ""I now see a unique chance for o..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[216]` **Emmerich Hegel (R)**: ""Any country ruled by a king is ..." |
| `[189]` | **""Why? I believe my vote against nationalization made my intentions clear enough.""** | `[187]` **Emmerich Hegel (R)**: ""However, that does not mean an ..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false` | *Brak zmian stanu* | `[426]` **Emmerich Hegel (R)**: ""Regretfully, yes But there's st..." |
| `[193]` | **""I'm happy to hear that. I regretfully had to vote against nationalization to prot..."** | `[187]` **Emmerich Hegel (R)**: ""However, that does not mean an ..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[425]` **Emmerich Hegel (R)**: ""I wouldn't say that. But there'..." |
| `[194]` | **""Yes, our differing opinions on the MITZ shouldn't keep us from making other agree..."** | `[187]` **Emmerich Hegel (R)**: ""However, that does not mean an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Emmerich Hegel (R)**: ""I am happy you see it that way."" |
| `[198]` | **""I have changed my mind. I don't wish to cooperate with Malenyevists.""** | `[181]` **Emmerich Hegel (R)**: ""I now see a unique chance for o..."<br>`[199]` **Emmerich Hegel (R)**: ""In fact, with your vote comes a..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false` | *Brak zmian stanu* | `[217]` **Emmerich Hegel (R)**: ""Our politics need not factor in..." |
| `[200]` | **""The Democratic Republic of Valgsland would deign to cooperate with a monarchy?""** | `[181]` **Emmerich Hegel (R)**: ""I now see a unique chance for o..."<br>`[199]` **Emmerich Hegel (R)**: ""In fact, with your vote comes a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Emmerich Hegel (R)**: ""Not normally. But in this insta..." |
| `[204]` | **""I had my reasons for choosing nationalization. Cooperating with Valgsland wasn't ..."** | `[199]` **Emmerich Hegel (R)**: ""In fact, with your vote comes a..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false` | *Brak zmian stanu* | `[221]` **Emmerich Hegel (R)**: ""We do not have to like each oth..." |
| `[206]` | **""I don't wish to cooperate with Malenyevists.""** | `[205]` **Emmerich Hegel (R)**: ""Despite your refusal to grant s..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false` | *Brak zmian stanu* | `[428]` **Emmerich Hegel (R)**: ""And I with monarchies. But ther..." |
| `[210]` | **""I'm happy to hear that. I regretfully had to vote against nationalization, but I ..."** | `[205]` **Emmerich Hegel (R)**: ""Despite your refusal to grant s..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[425]` **Emmerich Hegel (R)**: ""I wouldn't say that. But there'..." |
| `[211]` | **""You're right. Our differing opinions on the MITZ shouldn't keep us from making ot..."** | `[205]` **Emmerich Hegel (R)**: ""Despite your refusal to grant s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Emmerich Hegel (R)**: ""I am happy you see it that way."" |
| `[212]` | **""The Democratic Republic of Valgsland would deign to cooperate with a monarchy?""** | `[205]` **Emmerich Hegel (R)**: ""Despite your refusal to grant s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Emmerich Hegel (R)**: ""Normally, no. But there is one ..." |
| `[213]` | **""Despite both of us being in favor of nationalization, I'm skeptical we can reconc..."** | `[181]` **Emmerich Hegel (R)**: ""I now see a unique chance for o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Emmerich Hegel (R)**: ""There is only one thing we need..." |
| `[214]` | **""I voted for nationalization precisely so that you and I could have this conversat..."** | `[199]` **Emmerich Hegel (R)**: ""In fact, with your vote comes a..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[220]` **Emmerich Hegel (R)**: ""Do not think that this somehow ..." |
| `[222]` | **""Another east-west battle? You should know that as a member of GRACE, Rizia is obl..."** | `[218]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Emmerich Hegel (R)**: ""Uh huh. The way Rumburg was uni..." |
| `[223]` | **""Indeed. The future of the MITZ belongs to the workers and those who support them.""** | `[218]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[231]` **Emmerich Hegel (R)**: ""Well... yes. I'm glad you agree."" |
| `[227]` | **""You're right about that. Prime Minister Alvarez's behavior during the meeting was..."** | `[218]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Emmerich Hegel (R)**: ""As much as I personally dislike..." |
| `[228]` | **""That's simply not true. Lespia has played and will continue to play an integral r..."** | `[218]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false` | *Brak zmian stanu* | `[232]` **Emmerich Hegel (R)**: ""We are trying to build a new IT..." |
| `[229]` | **""I'm not a fan of Lespia's profit-mongering either, but stripping them of their as..."** | `[218]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Emmerich Hegel (R)**: ""You know what's dangerous? Allo..." |
| `[240]` | **""I voted for nationalization. That alone should prove where my values lie.""** | `[233]` **Emmerich Hegel (R)**: ""There is no 'uninvolved', Mr. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Emmerich Hegel (R)**: ""Yes, that alone was more than I..." |
| `[241]` | **""I don't believe that. Rizia doesn't need to take any sides.""** | `[233]` **Emmerich Hegel (R)**: ""There is no 'uninvolved', Mr. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Emmerich Hegel (R)**: ""I am not asking you to openly s..." |
| `[242]` | **""I want to side with you. But the repercussions with our allies would be too great.""** | `[233]` **Emmerich Hegel (R)**: ""There is no 'uninvolved', Mr. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Emmerich Hegel (R)**: ""I am not asking you to openly s..." |
| `[248]` | **""I don't know if I can. Lespia has a lot to offer Morella.""** | `[247]` **Emmerich Hegel (R)**: ""You, King Romus, will not let t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Emmerich Hegel (R)**: ""You are Morella's direct neighb..." |
| `[249]` | **""You have Prime Minister Saltana's ear. Why don't you just try to convince her to ..."** | `[247]` **Emmerich Hegel (R)**: ""You, King Romus, will not let t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Emmerich Hegel (R)**: ""Valgsland's relationship with M..." |
| `[251]` | **""That's easy. I was planning on making sure Lespia got the short end of the scepte..."** | `[247]` **Emmerich Hegel (R)**: ""You, King Romus, will not let t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Emmerich Hegel (R)**: ""Then we see eye to eye."" |
| `[252]` | **""And how do you suggest we do that?""** | `[232]` **Emmerich Hegel (R)**: ""We are trying to build a new IT..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Emmerich Hegel (R)**: ""I know that Prime Minister Salt..." |
| `[253]` | **""But with Morella exercising central control over the MITZ, there'll be a limit to..."** | `[232]` **Emmerich Hegel (R)**: ""We are trying to build a new IT..."<br>`[234]` **Emmerich Hegel (R)**: ""As much as I personally dislike..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Emmerich Hegel (R)**: ""That would be the ideal scenari..." |
| `[255]` | **""And how do you suggest we stop it?""** | `[234]` **Emmerich Hegel (R)**: ""As much as I personally dislike..."<br>`[235]` **Emmerich Hegel (R)**: ""You know what's dangerous? Allo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Emmerich Hegel (R)**: ""I know that Prime Minister Salt..." |
| `[256]` | **""As Alvarez said, the MITZ would be nothing without Lespian mining technology. We ..."** | `[232]` **Emmerich Hegel (R)**: ""We are trying to build a new IT..."<br>`[234]` **Emmerich Hegel (R)**: ""As much as I personally dislike..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Emmerich Hegel (R)**: ""Mining technology is worthless ..." |
| `[258]` | **""We have a gas deal with Lespia. It wouldn't be wise to antagonize them.""** | `[247]` **Emmerich Hegel (R)**: ""You, King Romus, will not let t..." | `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true` | *Brak zmian stanu* | `[266]` **Emmerich Hegel (R)**: ""Do not let the deal fool you. A..." |
| `[268]` | **""Outbidding Lespia may be in our best interests, but it will take a lot of resourc..."** | `[263]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Emmerich Hegel (R)**: ""A perfectly rational question, ..." |
| `[269]` | **""It's not only about Rizia's interests. We need Lespia out for the good of the ent..."** | `[263]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[276]` **Emmerich Hegel (R)**: ""I'm glad you agree. But I am ha..." |
| `[273]` | **""It would certainly be advantageous for Rizia to keep its foothold in the MITZ. If..."** | `[263]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false` | *Brak zmian stanu* | `[278]` **Emmerich Hegel (R)**: ""I know it will take much work. ..." |
| `[274]` | **""You are suggesting that we act with the same greed you are accusing Lespia of.""** | `[263]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Emmerich Hegel (R)**: ""You voted in favor of nationali..." |
| `[275]` | **""It's not in our best interests to anger our powerful neighbor.""** | `[263]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Emmerich Hegel (R)**: ""I can tell you are not convince..." |
| `[283]` | **""You dare to call us weak, Mr. Hegel?""** | `[282]` **Emmerich Hegel (R)**: ""Rizia's military weakness is no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Emmerich Hegel (R)**: ""Perhaps that was a poor choice ..." |
| `[284]` | **""Tempting. Our navy could use the help.""** | `[282]` **Emmerich Hegel (R)**: ""Rizia's military weakness is no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Emmerich Hegel (R)**: ""I don't need to convince you of..." |
| `[285]` | **""I'm afraid Valgslandian aid may be a red line for our partners in GRACE.""** | `[282]` **Emmerich Hegel (R)**: ""Rizia's military weakness is no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Emmerich Hegel (R)**: ""Don't you think it's time to di..." |
| `[292]` | **""You're offering us a naval upgrade while we have forces stationed around a disput..."** | `[282]` **Emmerich Hegel (R)**: ""Rizia's military weakness is no..." | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true` | *Brak zmian stanu* | `[293]` **Emmerich Hegel (R)**: ""Why, yes. Perhaps Valgsland's s..." |
| `[294]` | **""I have had it with your disrespect. Remember that you are speaking to a king.""** | `[286]` **Emmerich Hegel (R)**: ""Don't you think it's time to di..."<br>`[288]` **Emmerich Hegel (R)**: ""Perhaps that was a poor choice ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[296]` **Emmerich Hegel (R)**: ""Ha! Such titles mean nothing to..." |
| `[306]` | **""Are you demeaning the Holy Spirit of St. Dast?""** | `[305]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Emmerich Hegel (R)**: ""Whatever you want to call it, i..." |
| `[307]` | **""Religion guides my decisions, yes, but I do not 'take orders' from anyone.""** | `[305]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Emmerich Hegel (R)**: "'Even the smallest role played b..." |
| `[308]` | **""Like it or not, we are both world leaders. A little more decorum is in order.""** | `[297]` **Emmerich Hegel (R)**: ""Why should I respect you, when ..."<br>`[304]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "There was a brief silence on the..." |
| `[309]` | **""Because I'm holding the cards. You're the one calling me in the middle of the nig..."** | `[297]` **Emmerich Hegel (R)**: ""Why should I respect you, when ..."<br>`[304]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "There was a brief silence on the..." |
| `[310]` | **""Take that back this instant. My people love me.""** | `[297]` **Emmerich Hegel (R)**: ""Why should I respect you, when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Emmerich Hegel (R)**: ""Your people live in fear of you."" |
| `[312]` | **""My family earned everything we have. With the help of the Valgos Empire, I might ..."** | `[304]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Emmerich Hegel (R)**: ""The Valgos Empire is dead and g..." |
| `[313]` | **""You are right. And in fact, I am trying to change the role of the monarchy in Riz..."** | `[304]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..." | `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true` | *Brak zmian stanu* | `[325]` **Narrator**: "There was a brief pause on the o..." |
| `[327]` | **""Eventually, perhaps. But not with such a dramatic action.""** | `[286]` **Emmerich Hegel (R)**: ""Don't you think it's time to di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Emmerich Hegel (R)**: ""If not now, then when?"" |
| `[328]` | **""Regardless, I am worried that accepting your republic's military assistance will ..."** | `[286]` **Emmerich Hegel (R)**: ""Don't you think it's time to di..."<br>`[287]` **Emmerich Hegel (R)**: ""I don't need to convince you of..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Emmerich Hegel (R)**: ""Voting for ITZ nationalization ..." |
| `[330]` | **""If I'm going to anger Lespia even further than I have already, it wouldn't hurt t..."** | `[287]` **Emmerich Hegel (R)**: ""I don't need to convince you of..."<br>`[288]` **Emmerich Hegel (R)**: ""Perhaps that was a poor choice ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Emmerich Hegel (R)**: ""That's the right idea."" |
| `[331]` | **""It'll send a strong signal. Too strong.""** | `[293]` **Emmerich Hegel (R)**: ""Why, yes. Perhaps Valgsland's s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Emmerich Hegel (R)**: ""You have already deployed your ..." |
| `[334]` | **""Yes. In exchange for your promised military aid, I will make sure Lespia walks aw..."** | `[315]` **Emmerich Hegel (R)**: ""But please tell me. Can I count..."<br>`[326]` **Emmerich Hegel (R)**: ""Maybe I can. But for now, I wan..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Emmerich Hegel (R)**: ""Good."" |
| `[335]` | **""You can. But I'm not accepting your offer of naval reinforcements. Removing Lespi..."** | `[315]` **Emmerich Hegel (R)**: ""But please tell me. Can I count..."<br>`[326]` **Emmerich Hegel (R)**: ""Maybe I can. But for now, I wan..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[339]` **Emmerich Hegel (R)**: ""I am glad to hear it."" |
| `[336]` | **""I'm sorry, but I can't promise you anything.""** | `[315]` **Emmerich Hegel (R)**: ""But please tell me. Can I count..."<br>`[326]` **Emmerich Hegel (R)**: ""Maybe I can. But for now, I wan..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Emmerich Hegel (R)**: ""What a shame. But I understand."" |
| `[337]` | **""No. Given the magnitude of Lespia's investments in the MITZ, I can't go along wit..."** | `[315]` **Emmerich Hegel (R)**: ""But please tell me. Can I count..."<br>`[326]` **Emmerich Hegel (R)**: ""Maybe I can. But for now, I wan..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Emmerich Hegel (R)**: ""No? That's a shame."" |
| `[352]` | **""You're only now realizing that?""** | `[319]` **Emmerich Hegel (R)**: ""Sorry to wake you, Mr. Toras. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Emmerich Hegel (R)**: ""Yes. Silly me."" |
| `[353]` | **""Wait. I do want to help squeeze Lespia out of the Trade Zone. You can count on my..."** | `[319]` **Emmerich Hegel (R)**: ""Sorry to wake you, Mr. Toras. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Emmerich Hegel (R)**: ""Good, Mr. Toras. But do not exp..." |
| `[354]` | **""Until you treat the Rizian monarchy with more deference, we will remain at odds.""** | `[319]` **Emmerich Hegel (R)**: ""Sorry to wake you, Mr. Toras. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Emmerich Hegel (R)**: ""Then we will be at odds for ete..." |
| `[363]` | **""To Vina? Why?""** | `[358]` **Emmerich Hegel (R)**: ""Good night. And give my regards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[364]` | **""I will.""** | `[358]` **Emmerich Hegel (R)**: ""Good night. And give my regards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[365]` | **""That's 'Good night, *Your Majesty*'.""** | `[362]` **Emmerich Hegel (R)**: ""Good night."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[366]` | **""Thank you for calling nonetheless.""** | `[358]` **Emmerich Hegel (R)**: ""Good night. And give my regards..."<br>`[362]` **Emmerich Hegel (R)**: ""Good night."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[367]` | **""Until next time, Chancellor.""** | `[358]` **Emmerich Hegel (R)**: ""Good night. And give my regards..."<br>`[362]` **Emmerich Hegel (R)**: ""Good night."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[371]` | **""It's almost as if you want to help Rizia retake Pales.""** | `[287]` **Emmerich Hegel (R)**: ""I don't need to convince you of..."<br>`[293]` **Emmerich Hegel (R)**: ""Why, yes. Perhaps Valgsland's s..." | `Variable["RiziaDLC.Prologue_HostileToPales"] == true` | *Brak zmian stanu* | `[375]` **Emmerich Hegel (R)**: ""Yes. Almost."" |
| `[376]` | **""My councilors were already against ITZ nationalization. They will certainly be ag..."** | `[287]` **Emmerich Hegel (R)**: ""I don't need to convince you of..."<br>`[288]` **Emmerich Hegel (R)**: ""Perhaps that was a poor choice ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Emmerich Hegel (R)**: ""You're the king, aren't you? Yo..." |
| `[378]` | **""That's not surprising. She goes where her intellectual curiosity takes her.""** | `[347]` **Emmerich Hegel (R)**: ""You might want to know that I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Emmerich Hegel (R)**: ""She certainly is curious."" |
| `[379]` | **""I'm sorry, Chancellor. The princess can be a real brat sometimes.""** | `[347]` **Emmerich Hegel (R)**: ""You might want to know that I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Emmerich Hegel (R)**: ""On the contrary. She's got a br..." |
| `[380]` | **""So *that*'s what she's been doing during my council meetings.""** | `[347]` **Emmerich Hegel (R)**: ""You might want to know that I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Emmerich Hegel (R)**: ""If you're not involving the Pri..." |
| `[381]` | **""What?! You are to cease your communication with her at once.""** | `[347]` **Emmerich Hegel (R)**: ""You might want to know that I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Emmerich Hegel (R)**: ""Why? From her letters and our c..." |
| `[395]` | **""You don't need to call me that.""** | `[394]` **Emmerich Hegel (R)**: ""Goodnight, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[396]` | **""Now *there's* the respect I deserve.""** | `[394]` **Emmerich Hegel (R)**: ""Goodnight, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[397]` | **""Until next time, comrade.""** | `[394]` **Emmerich Hegel (R)**: ""Goodnight, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[398]` | **""Goodnight, Mr. Hegel.""** | `[394]` **Emmerich Hegel (R)**: ""Goodnight, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "He hung up." |
| `[400]` | **""You should try it. It's great.""** | `[399]` **Emmerich Hegel (R)**: ""Don't get me wrong -- I despise..." | `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false` | *Brak zmian stanu* | `[409]` **Emmerich Hegel (R)**: ""Ha. No, in the end I would neve..." |
| `[404]` | **""Disagreement is part of any healthy government. Monarchical or not.""** | `[399]` **Emmerich Hegel (R)**: ""Don't get me wrong -- I despise..." | `Variable["RiziaDLC.LeaningValue_Democratic"] > 0` | *Brak zmian stanu* | `[410]` **Emmerich Hegel (R)**: ""You're correct, of course. Just..." |
| `[405]` | **""A paradox, isn't it? The more opinions you entertain in the name of representatio..."** | `[399]` **Emmerich Hegel (R)**: ""Don't get me wrong -- I despise..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[408]` **Emmerich Hegel (R)**: ""Yet the longer one holds absolu..." |
| `[406]` | **""I can't act with total impunity. My hands are tied by royal tradition.""** | `[399]` **Emmerich Hegel (R)**: ""Don't get me wrong -- I despise..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Emmerich Hegel (R)**: ""That tradition was established ..." |
| `[415]` | **""You are going too far, Mr. Hegel. You shall speak to me with the respect a king d..."** | `[370]` **Emmerich Hegel (R)**: ""You are a rational man. You mus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Emmerich Hegel (R)**: ""Why should I respect you, when ..."<br>`[305]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..."<br>*(oraz 1 innych odgałęzień)* |
| `[416]` | **""I disagree. In fact, a truly benevolent king can meet his people's needs more eff..."** | `[370]` **Emmerich Hegel (R)**: ""You are a rational man. You mus..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[408]` **Emmerich Hegel (R)**: ""Yet the longer one holds absolu..." |
| `[417]` | **""Even if I agreed with you, cutting ties with Rumburg would be a disaster for us.""** | `[370]` **Emmerich Hegel (R)**: ""You are a rational man. You mus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[419]` **Emmerich Hegel (R)**: ""Or an opportunity for new conne..." |
| `[418]` | **""Actually, combining a democratic system with the benefits of having a reigning so..."** | `[370]` **Emmerich Hegel (R)**: ""You are a rational man. You mus..." | `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true` | *Brak zmian stanu* | `[424]` **Emmerich Hegel (R)**: ""No man or woman should be place..." |
| `[432]` | **""Another east-west battle? You should know that as a member of GRACE, Rizia is obl..."** | `[431]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Emmerich Hegel (R)**: ""Uh huh. The way Rumburg was uni..." |
| `[433]` | **""I agree that Prime Minister Alvarez's behavior during the meeting was appalling.""** | `[431]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Emmerich Hegel (R)**: ""As much as I personally dislike..." |
| `[434]` | **""You are wrong about that. Lespia has played and will continue to play an integral..."** | `[431]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[437]` **Emmerich Hegel (R)**: ""And Rizia? What about you?"" |
| `[435]` | **""You heard what I said in the meeting. Neither Lespia nor Rizia will accept any ch..."** | `[431]` **Emmerich Hegel (R)**: ""The Republic of Lespia does not..." | `Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true` | *Brak zmian stanu* | `[440]` **Emmerich Hegel (R)**: ""Yet Morella and Valgsland will ..." |
| `[444]` | **""Him... or her.""** | `[438]` **Emmerich Hegel (R)**: ""There is no 'uninvolved', Mr. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Emmerich Hegel (R)**: ""Yes, yes, that goes without say..." |
| `[445]` | **""I don't believe that. One can sympathize with the plight of the working man witho..."** | `[438]` **Emmerich Hegel (R)**: ""There is no 'uninvolved', Mr. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Emmerich Hegel (R)**: ""Sympathize, perhaps. Improve, no."" |
| `[446]` | **""Then I suppose I am against him. Sorry.""** | `[438]` **Emmerich Hegel (R)**: ""There is no 'uninvolved', Mr. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Emmerich Hegel (R)**: ""I don't think you understand wh..." |
| `[450]` | **""Rizia and Lespia will stand together in preserving the status quo.""** | `[437]` **Emmerich Hegel (R)**: ""And Rizia? What about you?"" | `Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true` | *Brak zmian stanu* | `[458]` **Emmerich Hegel (R)**: ""Let me lay it out for you, Mr. ..." |
| `[454]` | **""We want better conditions for Morellan workers. But not at the expense of Rizian ..."** | `[437]` **Emmerich Hegel (R)**: ""And Rizia? What about you?"" | `(Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true) == false` | *Brak zmian stanu* | `[458]` **Emmerich Hegel (R)**: ""Let me lay it out for you, Mr. ..." |
| `[455]` | **""Not to mention alcoholism.""** | `[439]` **Emmerich Hegel (R)**: ""As much as I personally dislike..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Emmerich Hegel (R)**: ""Let me lay it out for you, Mr. ..." |
| `[456]` | **""That's where we disagree. I don't like Alvarez as a person, but we are fighting f..."** | `[439]` **Emmerich Hegel (R)**: ""As much as I personally dislike..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Emmerich Hegel (R)**: ""Let me lay it out for you, Mr. ..." |
| `[457]` | **""Like Lespia, we are committed to working together with Morella to build a more eq..."** | `[437]` **Emmerich Hegel (R)**: ""And Rizia? What about you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Emmerich Hegel (R)**: ""Let me lay it out for you, Mr. ..." |
| `[462]` | **""What exactly do you want, Mr. Hegel?""** | `[440]` **Emmerich Hegel (R)**: ""Yet Morella and Valgsland will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Emmerich Hegel (R)**: ""Let me lay it out for you, Mr. ..." |
| `[463]` | **""Obviously, either Valgsland or Morella must make a compromise.""** | `[440]` **Emmerich Hegel (R)**: ""Yet Morella and Valgsland will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[466]` **Emmerich Hegel (R)**: ""And we are willing to do so. Un..." |
| `[464]` | **""I don't know. Go to war?""** | `[440]` **Emmerich Hegel (R)**: ""Yet Morella and Valgsland will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[467]` **Emmerich Hegel (R)**: ""Please, Mr. Toras. Rizia is not..." |
| `[465]` | **""Stay in a stalemate until one country caves. But it won't be Rizia.""** | `[440]` **Emmerich Hegel (R)**: ""Yet Morella and Valgsland will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Emmerich Hegel (R)**: ""Let me lay it out for you, Mr. ..." |
| `[471]` | **""You want me to screw over my business partner.""** | `[461]` **Emmerich Hegel (R)**: ""Do you understand what I'm sayi..." | `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true` | *Brak zmian stanu* | `[478]` **Emmerich Hegel (R)**: ""I wouldn't call it a 'partnersh..." |
| `[472]` | **""You want me to screw Mr. Alvarez over.""** | `[461]` **Emmerich Hegel (R)**: ""Do you understand what I'm sayi..." | `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false` | *Brak zmian stanu* | `[477]` **Emmerich Hegel (R)**: ""Make no mistake. Alvarez will d..." |
| `[473]` | **""No. Please explain.""** | `[461]` **Emmerich Hegel (R)**: ""Do you understand what I'm sayi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[480]` **Emmerich Hegel (R)**: ""Both of you will soon be invite..." |
| `[474]` | **""You have Prime Minister Saltana's ear. Why aren't you saying this to her?""** | `[461]` **Emmerich Hegel (R)**: ""Do you understand what I'm sayi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[475]` **Emmerich Hegel (R)**: ""Valgsland's relationship with M..." |
| `[479]` | **""I think I know what you're getting at. And I like it.""** | `[461]` **Emmerich Hegel (R)**: ""Do you understand what I'm sayi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[482]` **Emmerich Hegel (R)**: ""You'll be invited to Morella fo..." |
| `[483]` | **""I am all for trying to out-negotiate Lespia, but I'm afraid Rizia doesn't have th..."** | `[481]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Emmerich Hegel (R)**: ""Approving the final agreement w..." |
| `[484]` | **""It's not only about Rizia. We need to limit Arcasian influence in the Trade Zone.""** | `[481]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[491]` **Emmerich Hegel (R)**: ""I'm glad you see it that way."" |
| `[488]` | **""It would certainly be advantageous for Rizia to keep our share of ITZ profits. If..."** | `[481]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false` | *Brak zmian stanu* | `[492]` **Emmerich Hegel (R)**: ""Don't get too greedy."" |
| `[489]` | **""It's in our interests to work out a deal with Lespia and Morella. Valgsland's inp..."** | `[481]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[493]` **Emmerich Hegel (R)**: ""Oh?"" |
| `[497]` | **""If it means that much to you, I will make it happen.""** | `[494]` **Emmerich Hegel (R)**: ""Needless to say, we still expec..."<br>`[495]` **Emmerich Hegel (R)**: ""Needless to say, we still expec..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[508]` **Emmerich Hegel (R)**: ""It should mean something to you..." |
| `[498]` | **""I'll see what I can do.""** | `[494]` **Emmerich Hegel (R)**: ""Needless to say, we still expec..."<br>`[495]` **Emmerich Hegel (R)**: ""Needless to say, we still expec..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Emmerich Hegel (R)**: ""Thank you."" |
| `[499]` | **""I would anyway. Just because I voted against nationalization doesn't mean I'm hea..."** | `[494]` **Emmerich Hegel (R)**: ""Needless to say, we still expec..."<br>`[495]` **Emmerich Hegel (R)**: ""Needless to say, we still expec..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[505]` **Emmerich Hegel (R)**: ""No, I suppose it doesn't.""<br>`[506]` **Emmerich Hegel (R)**: ""You denied better working condi..." |
| `[501]` | **""You're in no position to make demands, Chancellor. You're the one calling me in t..."** | `[495]` **Emmerich Hegel (R)**: ""Needless to say, we still expec..."<br>`[496]` **Emmerich Hegel (R)**: ""Needless to say, we still expec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[509]` **Narrator**: "He sighed." |
| `[510]` | **""It's in my best interests to side with Lespia. As I have already agreed to do.""** | `[481]` **Emmerich Hegel (R)**: ""At the end of the day, I am onl..." | `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true` | *Brak zmian stanu* | `[514]` **Emmerich Hegel (R)**: ""And you don't think that Lespia..." |
| `[520]` | **""Are you implying that our military is weak, Mr. Hegel?""** | `[519]` **Emmerich Hegel (R)**: ""Make sure Lespia winds up with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[524]` **Emmerich Hegel (R)**: ""Excuse my phrasing. But you mus..." |
| `[521]` | **""I'm afraid Valgslandian aid would be a red line for our partners in GRACE.""** | `[519]` **Emmerich Hegel (R)**: ""Make sure Lespia winds up with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[522]` **Emmerich Hegel (R)**: ""It would not be aid. We would o..." |
| `[525]` | **""You're offering us a naval upgrade while we already have forces stationed around ..."** | `[519]` **Emmerich Hegel (R)**: ""Make sure Lespia winds up with ..." | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true` | *Brak zmian stanu* | `[526]` **Emmerich Hegel (R)**: ""Why, yes. Perhaps Valgsland's s..." |
| `[527]` | **""Tempting. Our navy could use the help.""** | `[519]` **Emmerich Hegel (R)**: ""Make sure Lespia winds up with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Emmerich Hegel (R)**: ""I don't need to convince you of..." |
| `[532]` | **""Still, my councilors will be against any form of cooperation with Valgsland.""** | `[523]` **Emmerich Hegel (R)**: ""I don't need to convince you of..."<br>`[524]` **Emmerich Hegel (R)**: ""Excuse my phrasing. But you mus..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[540]` **Emmerich Hegel (R)**: ""Isn't that the sole benefit of ..." |
| `[533]` | **""It'll send a strong signal. Too strong.""** | `[526]` **Emmerich Hegel (R)**: ""Why, yes. Perhaps Valgsland's s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[537]` **Emmerich Hegel (R)**: ""You have already deployed your ..." |
| `[538]` | **""It's almost as if you want to help Rizia retake Pales.""** | `[524]` **Emmerich Hegel (R)**: ""Excuse my phrasing. But you mus..."<br>`[526]` **Emmerich Hegel (R)**: ""Why, yes. Perhaps Valgsland's s..." | `Variable["RiziaDLC.Prologue_HostileToPales"] == true` | *Brak zmian stanu* | `[539]` **Emmerich Hegel (R)**: ""Mm. Almost."" |
| `[541]` | **""You should try it. It's great.""** | `[540]` **Emmerich Hegel (R)**: ""Isn't that the sole benefit of ..." | `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false` | *Brak zmian stanu* | `[547]` **Emmerich Hegel (R)**: ""Ha. No, in the end I would neve..." |
| `[542]` | **""Disagreement is part of any healthy government. Monarchical or not.""** | `[540]` **Emmerich Hegel (R)**: ""Isn't that the sole benefit of ..." | `Variable["RiziaDLC.LeaningValue_Democratic"] > 0` | *Brak zmian stanu* | `[548]` **Emmerich Hegel (R)**: ""You're correct, of course. Just..." |
| `[543]` | **""Is that a problem in Valgsland? Trying to please everyone, ending up pleasing no ..."** | `[540]` **Emmerich Hegel (R)**: ""Isn't that the sole benefit of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[546]` **Emmerich Hegel (R)**: ""It is still better than allowin..." |
| `[544]` | **""I can't act with total impunity. My hands are tied by royal tradition.""** | `[540]` **Emmerich Hegel (R)**: ""Isn't that the sole benefit of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[545]` **Emmerich Hegel (R)**: ""That tradition was established ..." |
| `[554]` | **""If I'm going to stab Lespia in the back, Rizia will definitely need to be able to..."** | `[523]` **Emmerich Hegel (R)**: ""I don't need to convince you of..."<br>`[524]` **Emmerich Hegel (R)**: ""Excuse my phrasing. But you mus..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[557]` **Emmerich Hegel (R)**: ""That's the right idea."" |
| `[555]` | **""I am putting my foot down. We neither need nor want your assistance.""** | `[523]` **Emmerich Hegel (R)**: ""I don't need to convince you of..."<br>`[524]` **Emmerich Hegel (R)**: ""Excuse my phrasing. But you mus..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[558]` **Emmerich Hegel (R)**: ""Very well. It was only an offer."" |
| `[556]` | **""You hope to win me over by demeaning me and the institution I stand for? Show som..."** | `[531]` **Emmerich Hegel (R)**: ""Besides which, you should not c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[606]` **Emmerich Hegel (R)**: ""You dare speak of respect?"" |
| `[569]` | **""Are you demeaning the Holy Spirit of St. Dast?""** | `[568]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[579]` **Emmerich Hegel (R)**: ""Whatever you want to call it, i..." |
| `[570]` | **""Religion guides my decisions, yes, but I do not 'take orders' from anyone.""** | `[568]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[580]` **Emmerich Hegel (R)**: "'Even the smallest role played b..." |
| `[571]` | **""Like it or not, we are both world leaders. A little more decorum is in order.""** | `[560]` **Emmerich Hegel (R)**: ""Why should I respect you, when ..."<br>`[567]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[575]` **Narrator**: "There was silence on the other e..." |
| `[572]` | **""Because I'm holding the cards. You're the one calling me in the middle of the nig..."** | `[560]` **Emmerich Hegel (R)**: ""Why should I respect you, when ..."<br>`[567]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[575]` **Narrator**: "There was silence on the other e..." |
| `[573]` | **""Take that back this instant. My people love me.""** | `[560]` **Emmerich Hegel (R)**: ""Why should I respect you, when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[578]` **Emmerich Hegel (R)**: ""Your people live in fear of you."" |
| `[584]` | **""My family earned everything we have. With the help of the Valgos Empire, I might ..."** | `[567]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[576]` **Emmerich Hegel (R)**: ""The Valgos Empire is dead and g..." |
| `[585]` | **""You are right. And in fact, I am trying to change the role of the monarchy in Riz..."** | `[567]` **Emmerich Hegel (R)**: ""Why should I respect a man who ..." | `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true` | *Brak zmian stanu* | `[577]` **Emmerich Hegel (R)**: ""I am afraid not, Mr. Toras."" |
| `[589]` | **""You're only now realizing that?""** | `[588]` **Emmerich Hegel (R)**: ""Sorry to wake you, Mr. Toras. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[592]` **Emmerich Hegel (R)**: ""Yes. Silly me."" |
| `[590]` | **""Wait. I do want to help squeeze Lespia out of the Trade Zone. You can count on my..."** | `[588]` **Emmerich Hegel (R)**: ""Sorry to wake you, Mr. Toras. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[593]` **Emmerich Hegel (R)**: ""Too late, Mr. Toras."" |
| `[591]` | **""Until you treat the Rizian monarchy with more deference, we will remain at odds.""** | `[588]` **Emmerich Hegel (R)**: ""Sorry to wake you, Mr. Toras. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[594]` **Emmerich Hegel (R)**: ""Then we will be at odds for ete..." |
| `[599]` | **""I will.""** | `[595]` **Emmerich Hegel (R)**: ""Good night. And give my regards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[605]` **Narrator**: "He hung up." |
| `[600]` | **""That's 'Good night, *Your Majesty*'.""** | `[604]` **Emmerich Hegel (R)**: ""Good night."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[605]` **Narrator**: "He hung up." |
| `[601]` | **""Thank you for calling nonetheless.""** | `[595]` **Emmerich Hegel (R)**: ""Good night. And give my regards..."<br>`[604]` **Emmerich Hegel (R)**: ""Good night."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[605]` **Narrator**: "He hung up." |
| `[602]` | **""Until next time, Chancellor.""** | `[595]` **Emmerich Hegel (R)**: ""Good night. And give my regards..."<br>`[604]` **Emmerich Hegel (R)**: ""Good night."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[605]` **Narrator**: "He hung up." |
| `[603]` | **""To Vina? Why?""** | `[595]` **Emmerich Hegel (R)**: ""Good night. And give my regards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[605]` **Narrator**: "He hung up." |
| `[607]` | **""One of those 'despots' is my sister-in-law. And losing her favor would be disastr..."** | `[531]` **Emmerich Hegel (R)**: ""Besides which, you should not c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[608]` **Emmerich Hegel (R)**: ""Or an opportunity for new conne..." |
| `[611]` | **""You can. In exchange for the navy deal you mentioned, I will shrink Lespia's shar..."** | `[549]` **Emmerich Hegel (R)**: ""But enough about our government..."<br>`[550]` **Emmerich Hegel (R)**: ""Just tell me. Can I count on yo..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover...` | `[621]` **Emmerich Hegel (R)**: ""Thank you. I am glad this phone..." |
| `[612]` | **""I cannot promise anything. But it's good to know that Valgsland will support Rizi..."** | `[549]` **Emmerich Hegel (R)**: ""But enough about our government..."<br>`[550]` **Emmerich Hegel (R)**: ""Just tell me. Can I count on yo..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[613]` **Emmerich Hegel (R)**: ""In that case, I cannot promise ..." |
| `[614]` | **""There will be no cooperation between Rizia and Valgsland, Mr. Hegel. On MITZ matt..."** | `[549]` **Emmerich Hegel (R)**: ""But enough about our government..."<br>`[550]` **Emmerich Hegel (R)**: ""Just tell me. Can I count on yo..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Emmerich Hegel (R)**: ""I suspected as much."" |
| `[619]` | **""Not on this matter. But I do not wish to be on bad terms with Valgsland.""** | `[610]` **Emmerich Hegel (R)**: ""For now, just tell me. Can I co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[620]` **Emmerich Hegel (R)**: ""That is wise, Mr. Toras."" |
| `[624]` | **""Maybe it's because we're so good-looking.""** | `[623]` **Emmerich Hegel (R)**: ""For some reason, my people are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[631]` **Emmerich Hegel (R)**: ""Your Valgish genes, then."" |
| `[625]` | **""Everyone loves royals, Chancellor. Even die-hard socialists.""** | `[623]` **Emmerich Hegel (R)**: ""For some reason, my people are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[630]` **Emmerich Hegel (R)**: ""Your lifestyle inspires jealous..." |
| `[626]` | **""Are you saying it's time to revive those old ties?""** | `[623]` **Emmerich Hegel (R)**: ""For some reason, my people are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[629]` **Emmerich Hegel (R)**: ""I'm not saying anything. Just t..." |
| `[627]` | **""Funny. My people don't feel the same about Valgish aristocrats.""** | `[623]` **Emmerich Hegel (R)**: ""For some reason, my people are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[628]` **Emmerich Hegel (R)**: ""Because there aren't any more o..." |
| `[633]` | **""You are sorely mistaken. Neither of us want that.""** | `[393]` **Emmerich Hegel (R)**: ""Changes. Big ones."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[634]` **Emmerich Hegel (R)**: ""You should speak with your daug..." |
| `[636]` | **""You will not speak of this again, Mr. Hegel. And you will cut off contact with Vi..."** | `[393]` **Emmerich Hegel (R)**: ""Changes. Big ones."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[637]` **Emmerich Hegel (R)**: ""Ah. Perhaps I was mistaken abou..." |
| `[639]` | **""We cannot have this conversation now. We must wait until the time is right.""** | `[393]` **Emmerich Hegel (R)**: ""Changes. Big ones.""<br>`[643]` **Emmerich Hegel (R)**: ""Changes. Big ones."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[640]` **Emmerich Hegel (R)**: ""Agreed, Mr. Toras."" |
| `[641]` | **""*If* that was what I wanted, how could Valgsland help me?""** | `[393]` **Emmerich Hegel (R)**: ""Changes. Big ones.""<br>`[643]` **Emmerich Hegel (R)**: ""Changes. Big ones."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[642]` **Emmerich Hegel (R)**: ""Later, Mr. Toras. I await the r..." |
| `[644]` | **""How dare you even suggest that? Don't make me regret working with you.""** | `[643]` **Emmerich Hegel (R)**: ""Changes. Big ones."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[637]` **Emmerich Hegel (R)**: ""Ah. Perhaps I was mistaken abou..." |
| `[645]` | **""Capitalism is what kept the MITZ running all these years. I would not disparage it.""** | `[439]` **Emmerich Hegel (R)**: ""As much as I personally dislike..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Emmerich Hegel (R)**: ""Let me lay it out for you, Mr. ..." |
| `[651]` | **""You have our gratitude for that, good sir.""** | `[649]` **Emmerich Hegel (R)**: ""I will, however, support Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[650]` **Emmerich Hegel (R)**: ""Not out of any loyalty to you, ..." |
| `[652]` | **""We don't need your support, Hegel.""** | `[649]` **Emmerich Hegel (R)**: ""I will, however, support Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[653]` **Emmerich Hegel (R)**: ""You're getting it anyway. If th..." |
| `[654]` | **""And why would that be?""** | `[649]` **Emmerich Hegel (R)**: ""I will, however, support Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[655]` **Emmerich Hegel (R)**: ""You must have some inkling why...." |
| `[661]` | **""You have our gratitude for that, good sir.""** | `[659]` **Emmerich Hegel (R)**: ""And incidentally, you can count..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[660]` **Emmerich Hegel (R)**: ""I believe Rizia deserves it. Bu..." |
| `[662]` | **""You're just full of favors today, aren't you?""** | `[659]` **Emmerich Hegel (R)**: ""And incidentally, you can count..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[664]` **Emmerich Hegel (R)**: ""This is no favor. If the AN dec..." |
| `[663]` | **""And why would that be?""** | `[659]` **Emmerich Hegel (R)**: ""And incidentally, you can count..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[665]` **Emmerich Hegel (R)**: ""You must have some inkling why...." |
| `[671]` | **""You have our gratitude for that, good sir.""** | `[669]` **Emmerich Hegel (R)**: ""Incidentally, you can count on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[670]` **Emmerich Hegel (R)**: ""I believe Rizia deserves it. Bu..." |
| `[672]` | **""You're just full of favors today, aren't you?""** | `[669]` **Emmerich Hegel (R)**: ""Incidentally, you can count on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[674]` **Emmerich Hegel (R)**: ""This is no favor. If the AN dec..." |
| `[673]` | **""And why would that be?""** | `[669]` **Emmerich Hegel (R)**: ""Incidentally, you can count on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[675]` **Emmerich Hegel (R)**: ""You must have some inkling why...." |
| `[681]` | **""You have our gratitude for that, good sir.""** | `[679]` **Emmerich Hegel (R)**: ""I will, however, support Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[680]` **Emmerich Hegel (R)**: ""Not out of any loyalty to you, ..." |
| `[682]` | **""We don't need your support, Hegel.""** | `[679]` **Emmerich Hegel (R)**: ""I will, however, support Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[683]` **Emmerich Hegel (R)**: ""You're getting it anyway. If th..." |
| `[684]` | **""And why would that be?""** | `[679]` **Emmerich Hegel (R)**: ""I will, however, support Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[685]` **Emmerich Hegel (R)**: ""You must have some inkling why...." |
| `[693]` | **""Lucita told me what you were up to the night Father died.""** | `[35]` **Narrator**: "Pabel opened the door and briskl..."<br>`[47]` **Narrator**: "Bruno sat down. Pabel gave him a..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true` | *Brak zmian stanu* | `[695]` **Narrator**: "Pabel hurriedly draped my robe o..." |
| `[694]` | **""Titus told me what you were up to the night Father died.""** | `[35]` **Narrator**: "Pabel opened the door and briskl..."<br>`[47]` **Narrator**: "Bruno sat down. Pabel gave him a..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`<br>`(Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false` | *Brak zmian stanu* | `[695]` **Narrator**: "Pabel hurriedly draped my robe o..." |
| `[697]` | **""Innocent of murder. Guilty of sodomy.""** | `[696]` **Pabel Adria**: ""You investigated me? I told you..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == false` | *Brak zmian stanu* | `[760]` **Narrator**: "His face turned pale." |
| `[698]` | **""Right. I bet I can guess what you were tasting.""** | `[705]` **Pabel Adria**: ""I don't know what you're talkin..."<br>`[720]` **Pabel Adria**: ""Well, now you know. I was condu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[739]` **Pabel Adria**: ""Wine, {RiziaDLCText.PabelToPlay..." |
| `[702]` | **""I thought you were in love with me all this time.""** | `[696]` **Pabel Adria**: ""You investigated me? I told you..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false` | *Brak zmian stanu* | `[703]` **Narrator**: "Pabel allowed himself a smile." |
| `[706]` | **""It's all fine. They didn't turn up any conclusive evidence against you.""** | `[696]` **Pabel Adria**: ""You investigated me? I told you..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false` | *Brak zmian stanu* | `[707]` **Narrator**: "Pabel let out a quiet sigh of re..." |
| `[708]` | **""I don't care what you call it. Keep carrying on like this and I'll have you throw..."** | `[705]` **Pabel Adria**: ""I don't know what you're talkin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[737]` **Pabel Adria**: ""Carrying on like what? If you w..." |
| `[711]` | **""It's all right. Your secret is still safe with me.""** | `[696]` **Pabel Adria**: ""You investigated me? I told you..." | `Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true`<br>`Variable["RiziaDLC.Relations_Pabel_Together"] == false` | *Brak zmian stanu* | `[712]` **Narrator**: "Pabel breathed a sigh of relief." |
| `[713]` | **""I don't care what you do after hours. But you've got to be more careful.""** | `[696]` **Pabel Adria**: ""You investigated me? I told you..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == false` | *Brak zmian stanu* | `[705]` **Pabel Adria**: ""I don't know what you're talkin..."<br>`[709]` **Narrator**: "He opened his mouth in denial, t..." |
| `[717]` | **""Sorry, Pabel. I couldn't leave any stone unturned.""** | `[696]` **Pabel Adria**: ""You investigated me? I told you..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == false` | *Brak zmian stanu* | `[719]` **Narrator**: "Pabel sighed regretfully."<br>`[720]` **Pabel Adria**: ""Well, now you know. I was condu..." |
| `[724]` | **""It's nothing personal. I couldn't make it look like I was playing favorites.""** | `[696]` **Pabel Adria**: ""You investigated me? I told you..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false` | *Brak zmian stanu* | `[725]` **Narrator**: "Pabel sighed." |
| `[727]` | **""If you say so.""** | `[705]` **Pabel Adria**: ""I don't know what you're talkin..."<br>`[720]` **Pabel Adria**: ""Well, now you know. I was condu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[738]` **Pabel Adria**: ""Anyway... it's quite an urgent ..." |
| `[728]` | **""No. And the very possibility is ridiculous.""** | `[718]` **Pabel Adria**: ""Well, it's been turned now. Am ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[731]` **Pabel Adria**: ""I'm glad you feel that way."" |
| `[729]` | **""You would be if there was more evidence. Consider yourself lucky.""** | `[718]` **Pabel Adria**: ""Well, it's been turned now. Am ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[732]` **Pabel Adria**: ""Believe me, I do. Nothing like ..." |
| `[730]` | **""No, but the Lord knows what you did.""** | `[718]` **Pabel Adria**: ""Well, it's been turned now. Am ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[736]` **Pabel Adria**: ""I... I have repented since then..." |
| `[741]` | **""It's ludicrous. If it were a woman, you'd get a slap on the wrist at worst. But a..."** | `[740]` **Pabel Adria**: ""Thank you, {RiziaDLCText.PabelT..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[743]` **Pabel Adria**: ""It is what it is."" |
| `[742]` | **""How many of you are out there?""** | `[740]` **Pabel Adria**: ""Thank you, {RiziaDLCText.PabelT..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[744]` **Pabel Adria**: ""More than you would think."" |
| `[747]` | **""You cannot order me around, Chancellor. Be more mindful of your words of choice.""** | `[247]` **Emmerich Hegel (R)**: ""You, King Romus, will not let t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[748]` **Emmerich Hegel (R)**: ""Apologies."" |
| `[749]` | **""Lucita is on your trail, though. Don't do anything stupid. Or anyone.""** | `[740]` **Pabel Adria**: ""Thank you, {RiziaDLCText.PabelT..." | `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true` | *Brak zmian stanu* | `[754]` **Pabel Adria**: ""I won't. Thank you for telling ..." |
| `[753]` | **""Titus is on your trail, though. Don't do anything stupid. Or anyone.""** | `[740]` **Pabel Adria**: ""Thank you, {RiziaDLCText.PabelT..." | `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false` | *Brak zmian stanu* | `[754]` **Pabel Adria**: ""I won't. Thank you for telling ..." |
| `[759]` | **""It's all right. Your secret is safe with me.""** | `[696]` **Pabel Adria**: ""You investigated me? I told you..." | `(Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true) == false`<br>`Variable["RiziaDLC.Relations_Pabel_Together"] == false` | *Brak zmian stanu* | `[712]` **Narrator**: "Pabel breathed a sigh of relief." |

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
  - -> `[778]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Taking a late-night call from Valgsland’..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "In the middle of the night, I was woken up by a knock on my bedroom door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I heard Pabel's voice in the hallway."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Bruno was lying at the foot of my bed. He sat upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Bruno: ""Rrrruff.""*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Bruno was lying at the foot of my bed. He sat upright."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Bruno sat upright in his dog bed."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Bruno sat upright in his dog bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Bruno: ""Rrrruff.""*)

### Węzeł `[12]`
Mówca: **Narrator**
> "I heard Pabel's voice in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Pabel Adria: ""Easy, boy. It's only me.""*)

### Węzeł `[13]`
Mówca: **Pabel Adria**
> ""Easy, boy. It's only me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == false"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == false"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == false)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Pabel Adria: ""Sorry, Romus, but there's an apparently urgent call for ..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Pabel Adria: ""Sorry to wake you, Your Majesty, but there's an apparent..."*)

### Węzeł `[17]`
Mówca: **Pabel Adria**
> ""Sorry to wake you, Your Majesty, but there's an apparently urgent call for you downstairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""All right. Come in and help me get dressed.""*)
  - -> `[23]` (*Player_Romus: ""I'll be right out.""*)

### Węzeł `[18]`
Mówca: **Pabel Adria**
> ""Sorry, Romus, but there's an apparently urgent call for you downstairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""All right. Come in and help me get dressed.""*)
  - -> `[23]` (*Player_Romus: ""I'll be right out.""*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I heard Pabel's voice in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == false"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "We walked through the palace corridors until we reached my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria"); RemoveConversant("Bruno");"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "An attendant stood ready with the blue phone. He informed me that Chancellor Emmerich Hegel was on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus_Italic: "Pick it up."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. Come in and help me get dressed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Pabel Adria), `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be right out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Pabel Adria), `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Pabel opened the door. Bruno jumped up on him, tail wagging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Pabel Adria: ""Someone's happy to see me.""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Pabel opened the door. Bruno jumped up on him, tail wagging."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Pabel opened the door and briskly made his way over to th..."*)

### Węzeł `[28]`
Mówca: **Pabel Adria**
> ""Someone's happy to see me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""I'd wag my tail if I had one.""*)
  - -> `[37]` (*Player_Romus: ""Who wouldn't be happy to see you, Pabel?""*)
  - -> `[38]` (*Player_Romus: ""Bad dog, Bruno! Sit!""*)

### Węzeł `[29]`
Mówca: **Narrator**
> "I quickly dressed and joined Pabel in the hallway. Bruno let out a whine of disappointment as I shut him back in the bedroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[99]` (*Player_Romus: ""Any idea what this call is about?""*)
  - -> `[91]` (*Player_Romus: ""How are you, Pabel?""*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "I quickly dressed and joined Pabel in the hallway. Bruno ..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "I quickly dressed and joined Pabel in the hallway."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "I quickly dressed and joined Pabel in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[99]` (*Player_Romus: ""Any idea what this call is about?""*)
  - -> `[91]` (*Player_Romus: ""How are you, Pabel?""*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, it's been a while since Qalus...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator), `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Pabel turned around and gave me a strained look."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Pabel opened the door and briskly made his way over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Rizi..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[43]` (*Player_Romus: ""What am I wearing?""*)
  - -> `[42]` (*Player_Romus: ""How are you, Pabel?""*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd wag my tail if I had one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who wouldn't be happy to see you, Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bad dog, Bruno! Sit!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Bruno sat down. Pabel gave him a pat on the head and bris..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""So, it's been a while since Qalus...""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you, Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator), `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Pabel Adria: ""I'm well, {RiziaDLCText.PabelToPlayer}.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What am I wearing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator), `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Pabel Adria: ""It's only a phone call. A simple robe and slippers shoul..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Pabel turned around and gave me a strained look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Pabel Adria: ""It's quite an urgent phone call.""*)

### Węzeł `[45]`
Mówca: **Pabel Adria**
> ""I'm well, {RiziaDLCText.PabelToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""Any palace intrigue I need to know about?""*)
  - -> `[103]` (*Player_Romus: ""Glad to hear it.""*)
  - -> `[102]` (*Player_Romus: ""That's all I get?""*)

### Węzeł `[46]`
Mówca: **Pabel Adria**
> ""It's quite an urgent phone call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Bruno sat down. Pabel gave him a pat on the head and briskly moved over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Rizi..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[43]` (*Player_Romus: ""What am I wearing?""*)
  - -> `[42]` (*Player_Romus: ""How are you, Pabel?""*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Pabel let out a short laugh, then briskly moved over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Rizi..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[43]` (*Player_Romus: ""What am I wearing?""*)
  - -> `[42]` (*Player_Romus: ""How are you, Pabel?""*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Pabel didn't smile. He briskly moved over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Rizi..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[43]` (*Player_Romus: ""What am I wearing?""*)
  - -> `[42]` (*Player_Romus: ""How are you, Pabel?""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel >= 0)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Pabel let out a short laugh, then briskly moved over to t..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Pabel didn't smile. He briskly moved over to the armoire."*)

### Węzeł `[53]`
Mówca: **Pabel Adria**
> ""It's only a phone call. A simple robe and slippers should do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He pulled a deep blue silk robe out of the armoire. I stood in front of him as he draped it over my shoulders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "He tied the sash, allowing his fingers to brush lightly against my waist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus_Italic: "Grab his hands."*)
  - -> `[87]` (*Player_Romus: ""Careful there. I wouldn't want impure thoughts distracti..."*)
  - -> `[76]` (*Player_Romus_Italic: "Let him finish dressing you."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "He tied the sash, allowing his fingers to brush lightly a..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Once I was dressed, we walked through the palace corridor..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "Grab his hands."]** — Mówca: **Player_Romus_Italic**
> "I stopped him and grabbed his hands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""I can't stop thinking about our night together.""*)
  - -> `[62]` (*Player_Romus: ""When can we see each other again? And by 'see', I mean...""*)
  - -> `[63]` (*Player_Romus: ""Why are you being so distant to me?""*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Once I was dressed, we walked through the palace corridors until we reached my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria"); RemoveConversant("Bruno");"*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't stop thinking about our night together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic), `[704]` (Pabel Adria), `[707]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "He took a step closer to me and spoke in a low voice."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When can we see each other again? And by 'see', I mean...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic), `[704]` (Pabel Adria), `[707]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He took a step closer to me and spoke in a low voice."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why are you being so distant to me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He took a step closer to me and spoke in a low voice."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "He took a step closer to me and spoke in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Pabel Adria: ""Neither can I. But we can't carry on like that here.""*)

### Węzeł `[65]`
Mówca: **Pabel Adria**
> ""Neither can I. But we can't carry on like that here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Pabel Adria: ""As a servant, I'm used to creeping around in the shadows..."*)

### Węzeł `[66]`
Mówca: **Pabel Adria**
> ""As a servant, I'm used to creeping around in the shadows. But the King is always in the spotlight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""I am the ruler of this country. I shouldn't have to hide..."*)
  - -> `[70]` (*Player_Romus: ""We'll come up with a cover story. You sleep in my room t..."*)
  - -> `[71]` (*Player_Romus: ""Wait. How much 'creeping around' have you done?""*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)

### Węzeł `[67]`
Mówca: **Pabel Adria**
> ""I haven't forgotten about Qalus. But we can't carry on like that here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Pabel Adria: ""As a servant, I'm used to creeping around in the shadows..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "He took a step closer to me and spoke in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Pabel Adria: ""I haven't forgotten about Qalus. But we can't carry on l..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the ruler of this country. I shouldn't have to hide my proclivities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Pabel Adria: ""It's not just a proclivity,{RiziaDLCText.PabelToPlayer},..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll come up with a cover story. You sleep in my room to help me with my night terrors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Pabel Adria: ""I don't want to subject you to that risk, {RiziaDLCText...."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. How much 'creeping around' have you done?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Pabel Adria: ""Enough to know that passion can compromise caution to a ..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've done some creeping of my own, you know. But it was easier as a prince.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Kontekst wejściowy (poprzednik):** `[66]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Pabel Adria: ""Yes, you're under much more scrutiny now. There are eyes..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HadAffairs == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""I've done some creeping of my own, you know. But it was ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HadAffairs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WYBÓR GRACZA: "Let him finish dressing you."]** — Mówca: **Player_Romus_Italic**
> "I didn't react. He tightened the sash and handed me my slippers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Once I was dressed, we walked through the palace corridor..."*)

### Węzeł `[77]`
Mówca: **Pabel Adria**
> ""I'll be under extra scrutiny now because of your investigation. We need to be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""There must be some way we can meet in total secrecy.""*)
  - -> `[143]` (*Player_Romus: ""This isn't right, damn it.""*)
  - -> `[144]` (*Player_Romus: ""You're right, of course. I shouldn't sabotage my reign o..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.P..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Pabel Adria: ""I'll be under extra scrutiny now because of your investi..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Pabel Adria: ""I don't think anyone suspects anything yet. But we need ..."*)

### Węzeł `[81]`
Mówca: **Pabel Adria**
> ""Enough to know that passion can compromise caution to a dangerous degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.P..."*)

### Węzeł `[82]`
Mówca: **Pabel Adria**
> ""It's not just a proclivity,{RiziaDLCText.PabelToPlayer}, it's a crime. Being found out could land us both in prison or worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.P..."*)

### Węzeł `[83]`
Mówca: **Pabel Adria**
> ""Yes, you're under much more scrutiny now. There are eyes everywhere here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.P..."*)

### Węzeł `[84]`
Mówca: **Pabel Adria**
> ""I don't want to subject you to that risk, {RiziaDLCText.PabelToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.P..."*)

### Węzeł `[85]`
Mówca: **Pabel Adria**
> ""I don't think anyone suspects anything yet. But we need to be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""There must be some way we can meet in total secrecy.""*)
  - -> `[143]` (*Player_Romus: ""This isn't right, damn it.""*)
  - -> `[144]` (*Player_Romus: ""You're right, of course. I shouldn't sabotage my reign o..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There must be some way we can meet in total secrecy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Pabel Adria), `[85]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Pabel Adria: ""We'll figure it out. But not today.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Careful there. I wouldn't want impure thoughts distracting me from my meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "The shadow of a smile passed across his face."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "The shadow of a smile passed across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Pabel Adria: ""My deepest apologies, Your Majesty.""*)

### Węzeł `[89]`
Mówca: **Pabel Adria**
> ""My deepest apologies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He took a step closer to me and spoke in a low voice."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "He tightened the sash and smoothed out the robe's folds, letting his hands linger on me for just a moment longer than necessary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Romus: ""To be continued.""*)
  - -> `[151]` (*Player_Romus: ""Thank you, Pabel.""*)
  - -> `[152]` (*Player_Romus: ""Let's go. I shouldn't keep this mysterious caller waiting.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you, Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator), `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Pabel Adria: ""I'm well, {RiziaDLCText.PabelToPlayer}.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, it's been a while since Qalus...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator), `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Pabel glanced behind us, then spoke in a low voice."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""So, it's been a while since Qalus...""*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
Mówca: **Narrator**
> "Pabel glanced behind us, then spoke in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Pabel Adria: ""Another time, Your Majesty. Please.""*)

### Węzeł `[97]`
Mówca: **Pabel Adria**
> ""Another time, Your Majesty. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[98]`
Mówca: **Pabel Adria**
> ""I'm well, {RiziaDLCText.PabelToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""Any palace intrigue I need to know about?""*)
  - -> `[123]` (*Player_Romus: ""Glad to hear it.""*)
  - -> `[122]` (*Player_Romus: ""That's all I get?""*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any idea what this call is about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator), `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Pabel shook his head."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Pabel Adria: ""It's on the blue phone, so it's a world leader. Your aid..."*)

### Węzeł `[101]`
Mówca: **Pabel Adria**
> ""It's on the blue phone, so it's a world leader. Your aide will have more information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I get?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glad to hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any palace intrigue I need to know about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel <= 0"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel <= 0"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel <= 0)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Pabel Adria: ""No, Your Majesty.""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lu..."*)

### Węzeł `[108]`
Mówca: **Pabel Adria**
> ""No, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_CompromisingPhoto == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lu..."*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true && RiziaDLC...."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_CompromisingPhoto == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true  and  Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Pabel Adria: ""Well, the entire staff knows about you and Duchess Azaro..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_CompromisingPhoto == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  and  Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[112]`
Mówca: **Pabel Adria**
> ""Well, the entire staff knows about you and Duchess Azaro. But I assume you weren't trying to keep that a secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[113]`
Mówca: **Pabel Adria**
> ""Thankfully, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Pabel Adria: ""Thankfully, no.""*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Pabel Adria: ""Only the usual nonsense. Everyone's still speculating ab..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel >= 0)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Pabel Adria: ""You've got an important phone call. I shouldn't bore you..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Pabel Adria: ""I would prefer my personal life to remain private, Your ..."*)

### Węzeł `[120]`
Mówca: **Pabel Adria**
> ""You've got an important phone call. I shouldn't bore you with irrelevant details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[121]`
Mówca: **Pabel Adria**
> ""I would prefer my personal life to remain private, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I get?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glad to hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any palace intrigue I need to know about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel <= 0"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel <= 0"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel <= 0)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Pabel Adria: ""No, Your Majesty.""*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[128]`
Mówca: **Pabel Adria**
> ""No, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[129]`
Mówca: **Pabel Adria**
> ""Well, the entire staff knows about you and Duchess Azaro. But I assume you weren't trying to keep that a secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[130]`
Mówca: **Pabel Adria**
> ""Thankfully, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[131]`
Mówca: **Pabel Adria**
> ""I would prefer my personal life to remain private, Your Majesty. My apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Pabel Adria: ""Well, the entire staff knows about you and Duchess Azaro..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel >= 0)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Pabel Adria: ""You've got an important phone call. I shouldn't bore you..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Pabel Adria: ""I would prefer my personal life to remain private, Your ..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Pabel Adria: ""Thankfully, no.""*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Pabel Adria: ""Only the usual nonsense. Everyone's still speculating ab..."*)

### Węzeł `[141]`
Mówca: **Pabel Adria**
> ""You've got an important phone call. I shouldn't bore you with irrelevant details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[142]`
Mówca: **Pabel Adria**
> ""Only the usual nonsense. Everyone's still speculating about Her Highness' marriage prospects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled a deep blue silk robe out of the armoire. I sto..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't right, damn it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Pabel Adria), `[85]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Pabel Adria: ""It's the way that it is.""*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, of course. I shouldn't sabotage my reign over a misguided dalliance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Pabel Adria), `[85]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Pabel Adria: ""Not *that* misguided, I hope.""*)

### Węzeł `[145]`
Mówca: **Pabel Adria**
> ""It's the way that it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Pabel Adria: ""Our time will come someday. But not yet.""*)

### Węzeł `[146]`
Mówca: **Pabel Adria**
> ""Our time will come someday. But not yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He tightened the sash and smoothed out the robe's folds, ..."*)

### Węzeł `[147]`
Mówca: **Pabel Adria**
> ""We'll figure it out. But not today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He tightened the sash and smoothed out the robe's folds, ..."*)

### Węzeł `[148]`
Mówca: **Pabel Adria**
> ""Not *that* misguided, I hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He tightened the sash and smoothed out the robe's folds, ..."*)

### Węzeł `[149]`
Mówca: **Pabel Adria**
> ""Only the usual nonsense. Everyone's still speculating about Her Highness' marriage prospects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be continued.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's go. I shouldn't keep this mysterious caller waiting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We walked through the palace corridors until we reached m..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "Pick it up."]** — Mówca: **Player_Romus_Italic**
> "I picked up the phone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player_Romus: ""You'd better have a good reason for calling me this late..."*)
  - -> `[155]` (*Player_Romus: ""I didn't expect to hear from you this soon.""*)
  - -> `[158]` (*Player_Romus: ""Good evening, Mr. Hegel.""*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd better have a good reason for calling me this late, Chancellor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Emmerich Hegel (R): ""Is it late? I never did have a handle on the time differ..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't expect to hear from you this soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Emmerich Hegel (R): ""No? After the way things ended in Morella?""*)

### Węzeł `[156]`
Mówca: **Emmerich Hegel (R)**
> ""Is it late? I never did have a handle on the time difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Emmerich Hegel (R): ""I'm truly sorry to disturb you at this hour. But we have..."*)

### Węzeł `[157]`
Mówca: **Emmerich Hegel (R)**
> ""No? After the way things ended in Morella?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Emmerich Hegel (R): ""I'm truly sorry to disturb you at this hour. But we have..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good evening, Mr. Hegel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Emmerich Hegel (R): ""Hello, Mr. Toras.""*)

### Węzeł `[159]`
Mówca: **Emmerich Hegel (R)**
> ""Hello, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Emmerich Hegel (R): ""I'm truly sorry to disturb you at this hour. But we have..."*)

### Węzeł `[160]`
Mówca: **Emmerich Hegel (R)**
> ""I'm truly sorry to disturb you at this hour. But we have unfinished business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)
  - -> `[166]` (*Player_Romus: ""Your apology is not accepted. We should be speaking in d..."*)
  - -> `[165]` (*Player_Romus: ""What do you mean?""*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll say. I was wondering why you never responded to my speech at the AN.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] == true`
- **Kontekst wejściowy (poprzednik):** `[160]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Emmerich Hegel (R): ""I appreciated your words then, Mr. Toras, but I had to f..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""I'll say. I was wondering why you never responded to my ..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your apology is not accepted. We should be speaking in daylight hours, accompanied by our staff.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Emmerich Hegel (R): ""I wanted to talk man to man, for reasons that shall soon..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_Nationalization == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""You must be talking about the MITZ nationalization plan.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""It's too late to change my mind about the nationalizatio..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's too late to change my mind about the nationalization vote. What's done is done.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[160]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Emmerich Hegel (R): ""Yes, the vote has concluded. But the future of the MITZ ..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must be talking about the MITZ nationalization plan.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Kontekst wejściowy (poprzednik):** `[160]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Emmerich Hegel (R): ""Of course. Needless to say, I was pleased you voted the ..."*)

### Węzeł `[172]`
Mówca: **Emmerich Hegel (R)**
> ""I appreciated your words then, Mr. Toras, but I had to find out whether they would translate into actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_Nationalization == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Emmerich Hegel (R): ""And they did.""*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Emmerich Hegel (R): ""Alas, they did not.""*)

### Węzeł `[176]`
Mówca: **Emmerich Hegel (R)**
> ""And they did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Emmerich Hegel (R): ""I now see a unique chance for our two very different cou..."*)

### Węzeł `[177]`
Mówca: **Emmerich Hegel (R)**
> ""Alas, they did not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Emmerich Hegel (R): ""However, that does not mean an end to our chance for coo..."*)

### Węzeł `[178]`
Mówca: **Emmerich Hegel (R)**
> ""Of course. Needless to say, I was pleased you voted the way you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Emmerich Hegel (R): ""In fact, with your vote comes a unique chance for cooper..."*)

### Węzeł `[179]`
Mówca: **Emmerich Hegel (R)**
> ""The nationalization vote was a success. But the future of the Trade Zone is far from decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Emmerich Hegel (R): ""In fact, with your vote comes a unique chance for cooper..."*)

### Węzeł `[180]`
Mówca: **Emmerich Hegel (R)**
> ""Yes, the vote has concluded. But the future of the MITZ is by no means set in stone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Emmerich Hegel (R): ""Despite your refusal to grant self-determination to More..."*)

### Węzeł `[181]`
Mówca: **Emmerich Hegel (R)**
> ""I now see a unique chance for our two very different countries to cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""Despite both of us being in favor of nationalization, I'..."*)
  - -> `[200]` (*Player_Romus: ""The Democratic Republic of Valgsland would deign to coop..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)

### Węzeł `[182]`
Mówca: **Emmerich Hegel (R)**
> ""I wanted to talk man to man, for reasons that shall soon become evident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_Nationalization == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Emmerich Hegel (R): ""The nationalization vote was a success. But the future o..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Emmerich Hegel (R): ""The nationalization vote was unsuccessful. But the futur..."*)

### Węzeł `[186]`
Mówca: **Emmerich Hegel (R)**
> ""The nationalization vote was unsuccessful. But the future of the Trade Zone is far from decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Emmerich Hegel (R): ""Despite your refusal to grant self-determination to More..."*)

### Węzeł `[187]`
Mówca: **Emmerich Hegel (R)**
> ""However, that does not mean an end to our chance for cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[194]` (*Player_Romus: ""Yes, our differing opinions on the MITZ shouldn't keep u..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy to hear that. By voting for nationalization, I wanted to signal that Rizia and Valgsland are on the same side.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[181]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Emmerich Hegel (R): ""Any country ruled by a king is not on Valgsland's side, ..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? I believe my vote against nationalization made my intentions clear enough.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[187]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Emmerich Hegel (R): ""Regretfully, yes But there's still one point on which we..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player_Romus: ""I'm happy to hear that. I regretfully had to vote agains..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player_Romus: ""Why? I believe my vote against nationalization made my i..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy to hear that. I regretfully had to vote against nationalization to protect Rizia's interests, but I still think we're on the same side.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[187]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Emmerich Hegel (R): ""I wouldn't say that. But there's one point on which we m..."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, our differing opinions on the MITZ shouldn't keep us from making other agreements.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Emmerich Hegel (R): ""I am happy you see it that way.""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""I'm happy to hear that. By voting for nationalization, I..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus: ""I have changed my mind. I don't wish to cooperate with M..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have changed my mind. I don't wish to cooperate with Malenyevists.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[181]` (Emmerich Hegel (R)), `[199]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Emmerich Hegel (R): ""Our politics need not factor into this. There is only on..."*)

### Węzeł `[199]`
Mówca: **Emmerich Hegel (R)**
> ""In fact, with your vote comes a unique chance for cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""The Democratic Republic of Valgsland would deign to coop..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Democratic Republic of Valgsland would deign to cooperate with a monarchy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Emmerich Hegel (R)), `[199]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Emmerich Hegel (R): ""Not normally. But in this instance, there is one point w..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player_Romus: ""I voted for nationalization precisely so that you and I ..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus: ""I have changed my mind. I don't wish to cooperate with M..."*)
  - -> `[204]` (*Player_Romus: ""I had my reasons for choosing nationalization. Cooperati..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had my reasons for choosing nationalization. Cooperating with Valgsland wasn't one of them.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Emmerich Hegel (R): ""We do not have to like each other, Mr. Toras. There is o..."*)

### Węzeł `[205]`
Mówca: **Emmerich Hegel (R)**
> ""Despite your refusal to grant self-determination to Morella and its mines, I still see a chance for cooperation between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[211]` (*Player_Romus: ""You're right. Our differing opinions on the MITZ shouldn..."*)
  - -> `[212]` (*Player_Romus: ""The Democratic Republic of Valgsland would deign to coop..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't wish to cooperate with Malenyevists.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[205]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Emmerich Hegel (R): ""And I with monarchies. But there is one point on which w..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player_Romus: ""I'm happy to hear that. I regretfully had to vote agains..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""I don't wish to cooperate with Malenyevists.""*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy to hear that. I regretfully had to vote against nationalization, but I still think we're on the same side.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[205]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Emmerich Hegel (R): ""I wouldn't say that. But there's one point on which we m..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Our differing opinions on the MITZ shouldn't keep us from making other agreements.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Emmerich Hegel (R): ""I am happy you see it that way.""*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Democratic Republic of Valgsland would deign to cooperate with a monarchy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Emmerich Hegel (R): ""Normally, no. But there is one point on which we may agr..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite both of us being in favor of nationalization, I'm skeptical we can reconcile our worldviews.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Emmerich Hegel (R): ""There is only one thing we need to agree on.""*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I voted for nationalization precisely so that you and I could have this conversation, Chancellor.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[199]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Emmerich Hegel (R): ""Do not think that this somehow makes us allies, Mr. Tora..."*)

### Węzeł `[215]`
Mówca: **Emmerich Hegel (R)**
> ""There is only one thing we need to agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[216]`
Mówca: **Emmerich Hegel (R)**
> ""Any country ruled by a king is not on Valgsland's side, Mr. Toras. But there is one point we can agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[217]`
Mówca: **Emmerich Hegel (R)**
> ""Our politics need not factor into this. There is only one point we have to agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[218]`
Mówca: **Emmerich Hegel (R)**
> ""The Republic of Lespia does not belong in the Meftiem International Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player_Romus: ""Another east-west battle? You should know that as a memb..."*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[227]` (*Player_Romus: ""You're right about that. Prime Minister Alvarez's behavi..."*)
  - -> `[229]` (*Player_Romus: ""I'm not a fan of Lespia's profit-mongering either, but s..."*)

### Węzeł `[219]`
Mówca: **Emmerich Hegel (R)**
> ""Not normally. But in this instance, there is one point we can agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[220]`
Mówca: **Emmerich Hegel (R)**
> ""Do not think that this somehow makes us allies, Mr. Toras. But there is one point we can both agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[221]`
Mówca: **Emmerich Hegel (R)**
> ""We do not have to like each other, Mr. Toras. There is only one point we have to agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another east-west battle? You should know that as a member of GRACE, Rizia is obliged to stay uninvolved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Emmerich Hegel (R): ""Uh huh. The way Rumburg was uninvolved in the Wehlen Civ..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. The future of the MITZ belongs to the workers and those who support them.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[218]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Emmerich Hegel (R): ""Well... yes. I'm glad you agree.""*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""Indeed. The future of the MITZ belongs to the workers an..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: ""That's simply not true. Lespia has played and will conti..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right about that. Prime Minister Alvarez's behavior during the meeting was appalling.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Emmerich Hegel (R): ""As much as I personally dislike the man, he is a mere sy..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's simply not true. Lespia has played and will continue to play an integral role in Trade Zone operations.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[218]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Emmerich Hegel (R): ""We are trying to build a new ITZ. One that is not corrup..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not a fan of Lespia's profit-mongering either, but stripping them of their assets could be dangerous for everyone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Emmerich Hegel (R): ""You know what's dangerous? Allowing Lespia's selfish pro..."*)

### Węzeł `[230]`
Mówca: **Emmerich Hegel (R)**
> ""Uh huh. The way Rumburg was uninvolved in the Wehlen Civil War?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Emmerich Hegel (R): ""There is no 'uninvolved', Mr. Toras. Either you are with..."*)

### Węzeł `[231]`
Mówca: **Emmerich Hegel (R)**
> ""Well... yes. I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Emmerich Hegel (R): ""I know that Prime Minister Saltana is meeting individual..."*)

### Węzeł `[232]`
Mówca: **Emmerich Hegel (R)**
> ""We are trying to build a new ITZ. One that is not corrupted by western greed or selfish protectionist policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Player_Romus: ""And how do you suggest we do that?""*)
  - -> `[253]` (*Player_Romus: ""But with Morella exercising central control over the MIT..."*)
  - -> `[256]` (*Player_Romus: ""As Alvarez said, the MITZ would be nothing without Lespi..."*)

### Węzeł `[233]`
Mówca: **Emmerich Hegel (R)**
> ""There is no 'uninvolved', Mr. Toras. Either you are with us, or you are against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""I want to side with you. But the repercussions with our ..."*)
  - -> `[240]` (*Player_Romus: ""I voted for nationalization. That alone should prove whe..."*)
  - -> `[241]` (*Player_Romus: ""I don't believe that. Rizia doesn't need to take any sid..."*)

### Węzeł `[234]`
Mówca: **Emmerich Hegel (R)**
> ""As much as I personally dislike the man, he is a mere symptom of the disease called capitalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""But with Morella exercising central control over the MIT..."*)
  - -> `[256]` (*Player_Romus: ""As Alvarez said, the MITZ would be nothing without Lespi..."*)
  - -> `[255]` (*Player_Romus: ""And how do you suggest we stop it?""*)

### Węzeł `[235]`
Mówca: **Emmerich Hegel (R)**
> ""You know what's dangerous? Allowing Lespia's selfish protectionist policies to slowly corrupt the new Trade Zone we are trying to build.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""But with Morella exercising central control over the MIT..."*)
  - -> `[256]` (*Player_Romus: ""As Alvarez said, the MITZ would be nothing without Lespi..."*)
  - -> `[255]` (*Player_Romus: ""And how do you suggest we stop it?""*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel >= 0)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "He acknowledged my remark with a smile, then briskly move..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Pabel didn't smile. He briskly moved over to the armoire."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "He acknowledged my remark with a smile, then briskly moved over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Rizi..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[42]` (*Player_Romus: ""How are you, Pabel?""*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I voted for nationalization. That alone should prove where my values lie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Emmerich Hegel (R): ""Yes, that alone was more than I expected.""*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't believe that. Rizia doesn't need to take any sides.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Emmerich Hegel (R): ""I am not asking you to openly side with us.""*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to side with you. But the repercussions with our allies would be too great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Emmerich Hegel (R): ""I am not asking you to openly side with us.""*)

### Węzeł `[243]`
Mówca: **Emmerich Hegel (R)**
> ""I am not asking you to openly side with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Emmerich Hegel (R): ""Allow me to explain what I want. Then we can discuss you..."*)

### Węzeł `[244]`
Mówca: **Emmerich Hegel (R)**
> ""I know that Prime Minister Saltana is meeting individually with you and Prime Minister Alvarez to come up with a nationalization plan for the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Emmerich Hegel (R): ""Lespia will do everything in its power to keep its opera..."*)

### Węzeł `[245]`
Mówca: **Emmerich Hegel (R)**
> ""Yes, that alone was more than I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Emmerich Hegel (R): ""Allow me to explain what I want. Then we can discuss you..."*)

### Węzeł `[246]`
Mówca: **Emmerich Hegel (R)**
> ""Allow me to explain what I want. Then we can discuss your supposed impartiality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Emmerich Hegel (R): ""I know that Prime Minister Saltana is meeting individual..."*)

### Węzeł `[247]`
Mówca: **Emmerich Hegel (R)**
> ""You, King Romus, will not let that happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Player_Romus: ""I don't know if I can. Lespia has a lot to offer Morella.""*)
  - -> `[249]` (*Player_Romus: ""You have Prime Minister Saltana's ear. Why don't you jus..."*)
  - -> `[251]` (*Player_Romus: ""That's easy. I was planning on making sure Lespia got th..."*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)
  - -> `[747]` (*Player_Romus: ""You cannot order me around, Chancellor. Be more mindful ..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know if I can. Lespia has a lot to offer Morella.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Emmerich Hegel (R): ""You are Morella's direct neighbor and longtime ally. Ms...."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have Prime Minister Saltana's ear. Why don't you just try to convince her to give Lespia the boot?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Emmerich Hegel (R): ""Valgsland's relationship with Morella is still young and..."*)

### Węzeł `[250]`
Mówca: **Emmerich Hegel (R)**
> ""Lespia will do everything in its power to keep its operations running exactly as before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Emmerich Hegel (R): ""You, King Romus, will not let that happen.""*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's easy. I was planning on making sure Lespia got the short end of the scepter anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Emmerich Hegel (R): ""Then we see eye to eye.""*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do you suggest we do that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Emmerich Hegel (R): ""I know that Prime Minister Saltana is meeting individual..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But with Morella exercising central control over the MITZ, there'll be a limit to how much harm Lespia can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Emmerich Hegel (R)), `[234]` (Emmerich Hegel (R)), `[235]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Emmerich Hegel (R): ""That would be the ideal scenario. But Alvarez is very ca..."*)

### Węzeł `[254]`
Mówca: **Emmerich Hegel (R)**
> ""That would be the ideal scenario. But Alvarez is very capable of weaseling out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Emmerich Hegel (R): ""I know that Prime Minister Saltana is meeting individual..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do you suggest we stop it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Emmerich Hegel (R)), `[235]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Emmerich Hegel (R): ""I know that Prime Minister Saltana is meeting individual..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As Alvarez said, the MITZ would be nothing without Lespian mining technology. We can't ignore his country's contribution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Emmerich Hegel (R)), `[234]` (Emmerich Hegel (R)), `[235]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Emmerich Hegel (R): ""Mining technology is worthless if the people operating i..."*)

### Węzeł `[257]`
Mówca: **Emmerich Hegel (R)**
> ""Mining technology is worthless if the people operating it are being exploited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Emmerich Hegel (R): ""I know that Prime Minister Saltana is meeting individual..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have a gas deal with Lespia. It wouldn't be wise to antagonize them.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[247]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Emmerich Hegel (R): ""Do not let the deal fool you. Alvarez will stab you in t..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""We have a gas deal with Lespia. It wouldn't be wise to a..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
Mówca: **Emmerich Hegel (R)**
> ""Then we see eye to eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking Rizia to act in ..."*)

### Węzeł `[263]`
Mówca: **Emmerich Hegel (R)**
> ""At the end of the day, I am only asking Rizia to act in its best interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player_Romus: ""Outbidding Lespia may be in our best interests, but it w..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[274]` (*Player_Romus: ""You are suggesting that we act with the same greed you a..."*)
  - -> `[275]` (*Player_Romus: ""It's not in our best interests to anger our powerful nei..."*)

### Węzeł `[264]`
Mówca: **Emmerich Hegel (R)**
> ""Valgsland's relationship with Morella is still young and fragile. I do not want us to be accused of overreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Emmerich Hegel (R): ""Rizia, on the other hand, is Morella's direct neighbor a..."*)

### Węzeł `[265]`
Mówca: **Emmerich Hegel (R)**
> ""You are Morella's direct neighbor and longtime ally. Ms. Saltana will surely be receptive to your offers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking Rizia to act in ..."*)

### Węzeł `[266]`
Mówca: **Emmerich Hegel (R)**
> ""Do not let the deal fool you. Alvarez will stab you in the back at the slightest opportunity, especially after your board vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking Rizia to act in ..."*)

### Węzeł `[267]`
Mówca: **Emmerich Hegel (R)**
> ""Rizia, on the other hand, is Morella's direct neighbor and longtime ally. It's only natural that you would request a more favorable deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking Rizia to act in ..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Outbidding Lespia may be in our best interests, but it will take a lot of resources. What can Valgsland offer us if I make this happen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Emmerich Hegel (R): ""A perfectly rational question, Mr. Toras.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not only about Rizia's interests. We need Lespia out for the good of the entire ITZ.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[263]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Emmerich Hegel (R): ""I'm glad you agree. But I am happy to throw in another i..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""It's not only about Rizia's interests. We need Lespia ou..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player_Romus: ""It would certainly be advantageous for Rizia to keep its..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would certainly be advantageous for Rizia to keep its foothold in the MITZ. If we end up with more than Lespia, so much the better.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Emmerich Hegel (R): ""I know it will take much work. So I am happy to offer an..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are suggesting that we act with the same greed you are accusing Lespia of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Emmerich Hegel (R): ""You voted in favor of nationalization. I trust any deal ..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not in our best interests to anger our powerful neighbor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Emmerich Hegel (R): ""I can tell you are not convinced. Allow me to offer an i..."*)

### Węzeł `[276]`
Mówca: **Emmerich Hegel (R)**
> ""I'm glad you agree. But I am happy to throw in another incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Emmerich Hegel (R): ""Rizia's military weakness is no secret in international ..."*)

### Węzeł `[277]`
Mówca: **Emmerich Hegel (R)**
> ""A perfectly rational question, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Emmerich Hegel (R): ""Rizia's military weakness is no secret in international ..."*)

### Węzeł `[278]`
Mówca: **Emmerich Hegel (R)**
> ""I know it will take much work. So I am happy to offer an incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Emmerich Hegel (R): ""Rizia's military weakness is no secret in international ..."*)

### Węzeł `[279]`
Mówca: **Emmerich Hegel (R)**
> ""I can tell you are not convinced. Allow me to offer an incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Emmerich Hegel (R): ""Rizia's military weakness is no secret in international ..."*)

### Węzeł `[280]`
Mówca: **Emmerich Hegel (R)**
> ""You voted in favor of nationalization. I trust any deal you make will still preserve the welfare of the MITZ's workers and the sovereignty of Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Emmerich Hegel (R): ""If you are still not convinced, I am happy to offer an i..."*)

### Węzeł `[281]`
Mówca: **Emmerich Hegel (R)**
> ""If you are still not convinced, I am happy to offer an incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Emmerich Hegel (R): ""Rizia's military weakness is no secret in international ..."*)

### Węzeł `[282]`
Mówca: **Emmerich Hegel (R)**
> ""Rizia's military weakness is no secret in international circles. Make sure Lespia ends up with nothing, and Valgsland will provide your navy with a significant upgrade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Romus: ""You dare to call us weak, Mr. Hegel?""*)
  - -> `[284]` (*Player_Romus: ""Tempting. Our navy could use the help.""*)
  - -> `[285]` (*Player_Romus: ""I'm afraid Valgslandian aid may be a red line for our pa..."*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You dare to call us weak, Mr. Hegel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Emmerich Hegel (R): ""Perhaps that was a poor choice of phrasing. But you must..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tempting. Our navy could use the help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Emmerich Hegel (R): ""I don't need to convince you of Valgsland's dominion ove..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid Valgslandian aid may be a red line for our partners in GRACE.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Emmerich Hegel (R): ""Don't you think it's time to distance yourself from that..."*)

### Węzeł `[286]`
Mówca: **Emmerich Hegel (R)**
> ""Don't you think it's time to distance yourself from that network? You must know how isolated you are becoming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player_Romus: ""I have had it with your disrespect. Remember that you ar..."*)
  - -> `[328]` (*Player_Romus: ""Regardless, I am worried that accepting your republic's ..."*)
  - -> `[327]` (*Player_Romus: ""Eventually, perhaps. But not with such a dramatic action.""*)

### Węzeł `[287]`
Mówca: **Emmerich Hegel (R)**
> ""I don't need to convince you of Valgsland's dominion over the sea. Our warships and submarines are second to none.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: ""If I'm going to anger Lespia even further than I have al..."*)
  - -> `[328]` (*Player_Romus: ""Regardless, I am worried that accepting your republic's ..."*)
  - -> `[376]` (*Player_Romus: ""My councilors were already against ITZ nationalization. ..."*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[288]`
Mówca: **Emmerich Hegel (R)**
> ""Perhaps that was a poor choice of phrasing. But you must admit that you cannot match Valgsland's dominion over the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player_Romus: ""I have had it with your disrespect. Remember that you ar..."*)
  - -> `[330]` (*Player_Romus: ""If I'm going to anger Lespia even further than I have al..."*)
  - -> `[328]` (*Player_Romus: ""Regardless, I am worried that accepting your republic's ..."*)
  - -> `[376]` (*Player_Romus: ""My councilors were already against ITZ nationalization. ..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player_Romus: ""You're offering us a naval upgrade while we have forces ..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're offering us a naval upgrade while we have forces stationed around a disputed gas field?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Kontekst wejściowy (poprzednik):** `[282]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Emmerich Hegel (R): ""Why, yes. Perhaps Valgsland's superior vessels and equip..."*)

### Węzeł `[293]`
Mówca: **Emmerich Hegel (R)**
> ""Why, yes. Perhaps Valgsland's superior vessels and equipment can help you solve that dispute faster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: ""If I'm going to anger Lespia even further than I have al..."*)
  - -> `[376]` (*Player_Romus: ""My councilors were already against ITZ nationalization. ..."*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[331]` (*Player_Romus: ""It'll send a strong signal. Too strong.""*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have had it with your disrespect. Remember that you are speaking to a king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Emmerich Hegel (R)), `[288]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist -= 2"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Emmerich Hegel (R): ""Ha! Such titles mean nothing to me, Mr. Toras.""*)

### Węzeł `[296]`
Mówca: **Emmerich Hegel (R)**
> ""Ha! Such titles mean nothing to me, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)

### Węzeł `[297]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect you, when you don't respect the will of your own people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player_Romus: ""Take that back this instant. My people love me.""*)
  - -> `[308]` (*Player_Romus: ""Like it or not, we are both world leaders. A little more..."*)
  - -> `[309]` (*Player_Romus: ""Because I'm holding the cards. You're the one calling me..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Emmerich Hegel (R): ""Why should I respect you, when you don't respect the wil..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Religious > 0)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Emmerich Hegel (R): ""Why should I respect a man who takes orders from some in..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Religious > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Emmerich Hegel (R): ""Why should I respect a man who sits on a golden throne, ..."*)

### Węzeł `[304]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect a man who sits on a golden throne, surrounded by riches he did not earn?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""Like it or not, we are both world leaders. A little more..."*)
  - -> `[309]` (*Player_Romus: ""Because I'm holding the cards. You're the one calling me..."*)
  - -> `[312]` (*Player_Romus: ""My family earned everything we have. With the help of th..."*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true ..."*)

### Węzeł `[305]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect a man who takes orders from some invisible being in the sky?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""Like it or not, we are both world leaders. A little more..."*)
  - -> `[309]` (*Player_Romus: ""Because I'm holding the cards. You're the one calling me..."*)
  - -> `[306]` (*Player_Romus: ""Are you demeaning the Holy Spirit of St. Dast?""*)
  - -> `[307]` (*Player_Romus: ""Religion guides my decisions, yes, but I do not 'take or..."*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you demeaning the Holy Spirit of St. Dast?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Emmerich Hegel (R): ""Whatever you want to call it, it should be completely se..."*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religion guides my decisions, yes, but I do not 'take orders' from anyone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Emmerich Hegel (R): "'Even the smallest role played by religion in state matte..."*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like it or not, we are both world leaders. A little more decorum is in order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Emmerich Hegel (R)), `[304]` (Emmerich Hegel (R)), `[305]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "There was a brief silence on the other end as Hegel seeme..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because I'm holding the cards. You're the one calling me in the middle of the night, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Emmerich Hegel (R)), `[304]` (Emmerich Hegel (R)), `[305]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "There was a brief silence on the other end as Hegel seeme..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take that back this instant. My people love me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Emmerich Hegel (R): ""Your people live in fear of you.""*)

### Węzeł `[311]`
Mówca: **Narrator**
> "There was a brief silence on the other end as Hegel seemed to collect himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Emmerich Hegel (R): ""Very well. I am sorry.""*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My family earned everything we have. With the help of the Valgos Empire, I might add.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Emmerich Hegel (R): ""The Valgos Empire is dead and gone. As the Kingdom of Ri..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right. And in fact, I am trying to change the role of the monarchy in Rizia. Maybe you can help me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Kontekst wejściowy (poprzednik):** `[304]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[314]`
Mówca: **Emmerich Hegel (R)**
> ""Very well. I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Emmerich Hegel (R): ""But please tell me. Can I count on your cooperation in t..."*)

### Węzeł `[315]`
Mówca: **Emmerich Hegel (R)**
> ""But please tell me. Can I count on your cooperation in the MITZ, or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player_Romus: ""Yes. In exchange for your promised military aid, I will ..."*)
  - -> `[335]` (*Player_Romus: ""You can. But I'm not accepting your offer of naval reinf..."*)
  - -> `[337]` (*Player_Romus: ""No. Given the magnitude of Lespia's investments in the M..."*)
  - -> `[336]` (*Player_Romus: ""I'm sorry, but I can't promise you anything.""*)

### Węzeł `[316]`
Mówca: **Emmerich Hegel (R)**
> ""Your people live in fear of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "There was a brief pause on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Emmerich Hegel (R): ""Sorry to wake you, Mr. Toras. This call was a mistake.""*)

### Węzeł `[318]`
Mówca: **Emmerich Hegel (R)**
> ""Whatever you want to call it, it should be completely separate from state matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[319]`
Mówca: **Emmerich Hegel (R)**
> ""Sorry to wake you, Mr. Toras. This call was a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player_Romus: ""You're only now realizing that?""*)
  - -> `[353]` (*Player_Romus: ""Wait. I do want to help squeeze Lespia out of the Trade ..."*)
  - -> `[354]` (*Player_Romus: ""Until you treat the Rizian monarchy with more deference,..."*)

### Węzeł `[320]`
Mówca: **Emmerich Hegel (R)**
> "'Even the smallest role played by religion in state matters is too large.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[321]`
Mówca: **Emmerich Hegel (R)**
> ""The Valgos Empire is dead and gone. As the Kingdom of Rizia should be, by all rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true ..."*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == tru..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player_Romus: ""You are right. And in fact, I am trying to change the ro..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[325]`
Mówca: **Narrator**
> "There was a brief pause on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Emmerich Hegel (R): ""Maybe I can. But for now, I want to know whether or not ..."*)

### Węzeł `[326]`
Mówca: **Emmerich Hegel (R)**
> ""Maybe I can. But for now, I want to know whether or not I can count on your cooperation in the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player_Romus: ""Yes. In exchange for your promised military aid, I will ..."*)
  - -> `[335]` (*Player_Romus: ""You can. But I'm not accepting your offer of naval reinf..."*)
  - -> `[337]` (*Player_Romus: ""No. Given the magnitude of Lespia's investments in the M..."*)
  - -> `[336]` (*Player_Romus: ""I'm sorry, but I can't promise you anything.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Eventually, perhaps. But not with such a dramatic action.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Emmerich Hegel (R): ""If not now, then when?""*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless, I am worried that accepting your republic's military assistance will send the wrong signal internationally.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Emmerich Hegel (R)), `[287]` (Emmerich Hegel (R)), `[288]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Emmerich Hegel (R): ""Voting for ITZ nationalization already aligned you with ..."*)

### Węzeł `[329]`
Mówca: **Emmerich Hegel (R)**
> ""Voting for ITZ nationalization already aligned you with Valgsland. You may as well take advantage of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Emmerich Hegel (R): ""You can expect the delivery of new vessels and equipment..."*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I'm going to anger Lespia even further than I have already, it wouldn't hurt to have a stronger navy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Emmerich Hegel (R)), `[288]` (Emmerich Hegel (R)), `[293]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Emmerich Hegel (R): ""That's the right idea.""*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll send a strong signal. Too strong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Emmerich Hegel (R): ""You have already deployed your military to the Antacean...."*)

### Węzeł `[332]`
Mówca: **Emmerich Hegel (R)**
> ""If not now, then when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Emmerich Hegel (R): ""You are a rational man. You must admit that the monarchi..."*)

### Węzeł `[333]`
Mówca: **Emmerich Hegel (R)**
> ""That's the right idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Emmerich Hegel (R): ""You can expect the delivery of new vessels and equipment..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. In exchange for your promised military aid, I will make sure Lespia walks away with nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Emmerich Hegel (R)), `[326]` (Emmerich Hegel (R)), `[412]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Emmerich Hegel (R): ""Good.""*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can. But I'm not accepting your offer of naval reinforcements. Removing Lespian influence from the MITZ is enough of an incentive for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Emmerich Hegel (R)), `[326]` (Emmerich Hegel (R)), `[412]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Emmerich Hegel (R): ""I am glad to hear it.""*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, but I can't promise you anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Emmerich Hegel (R)), `[326]` (Emmerich Hegel (R)), `[412]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Emmerich Hegel (R): ""What a shame. But I understand.""*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Given the magnitude of Lespia's investments in the MITZ, I can't go along with your plan.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Emmerich Hegel (R)), `[326]` (Emmerich Hegel (R)), `[412]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Emmerich Hegel (R): ""No? That's a shame.""*)

### Węzeł `[338]`
Mówca: **Emmerich Hegel (R)**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Emmerich Hegel (R): ""I will be sure to keep abreast of the negotiations.""*)

### Węzeł `[339]`
Mówca: **Emmerich Hegel (R)**
> ""I am glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Emmerich Hegel (R): ""And my offer will remain open should you change your mind.""*)

### Węzeł `[340]`
Mówca: **Emmerich Hegel (R)**
> ""No? That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Emmerich Hegel (R): ""For a moment, I thought we had an understanding.""*)

### Węzeł `[341]`
Mówca: **Emmerich Hegel (R)**
> ""For a moment, I thought we had an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[342]`
Mówca: **Emmerich Hegel (R)**
> ""What a shame. But I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Emmerich Hegel (R): ""I wish you luck regardless.""*)

### Węzeł `[343]`
Mówca: **Emmerich Hegel (R)**
> ""And my offer will remain open should you change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover = true; R..."*)

### Węzeł `[344]`
Mówca: **Emmerich Hegel (R)**
> ""I will be sure to keep abreast of the negotiations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Military_Valgsland_AcceptNavalAid = true; RiziaD..."*)

### Węzeł `[345]`
Mówca: **Emmerich Hegel (R)**
> ""I wish you luck regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[346]`
Mówca: **Narrator**
> "There was a silence, so long I began to think he had hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ToldAboutComradeVina = true"*)

### Węzeł `[347]`
Mówca: **Emmerich Hegel (R)**
> ""You might want to know that I have been contacted by your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player_Romus: ""That's not surprising. She goes where her intellectual c..."*)
  - -> `[379]` (*Player_Romus: ""I'm sorry, Chancellor. The princess can be a real brat s..."*)
  - -> `[380]` (*Player_Romus: ""So *that*'s what she's been doing during my council meet..."*)
  - -> `[381]` (*Player_Romus: ""What?! You are to cease your communication with her at o..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_CommieKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_Commie..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_Comm..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_CommieKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "There was a silence, so long I began to think he had hung..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_CommieKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_Va..."*)

### Węzeł `[351]`
Mówca: **Emmerich Hegel (R)**
> ""I may be overstepping my boundaries. But I cannot shake the feeling that you and I want the same thing for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Emmerich Hegel (R): ""Changes. Big ones.""*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're only now realizing that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Emmerich Hegel (R): ""Yes. Silly me.""*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I do want to help squeeze Lespia out of the Trade Zone. You can count on my cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Emmerich Hegel (R): ""Good, Mr. Toras. But do not expect any military aid from..."*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until you treat the Rizian monarchy with more deference, we will remain at odds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Emmerich Hegel (R): ""Then we will be at odds for eternity.""*)

### Węzeł `[355]`
Mówca: **Emmerich Hegel (R)**
> ""Yes. Silly me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[356]`
Mówca: **Emmerich Hegel (R)**
> ""Good, Mr. Toras. But do not expect any military aid from Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[357]`
Mówca: **Emmerich Hegel (R)**
> ""Then we will be at odds for eternity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[358]`
Mówca: **Emmerich Hegel (R)**
> ""Good night. And give my regards to the Princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player_Romus: ""To Vina? Why?""*)
  - -> `[364]` (*Player_Romus: ""I will.""*)
  - -> `[366]` (*Player_Romus: ""Thank you for calling nonetheless.""*)
  - -> `[367]` (*Player_Romus: ""Until next time, Chancellor.""*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false)"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Emmerich Hegel (R): ""Good night. And give my regards to the Princess.""*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Emmerich Hegel (R): ""Good night.""*)

### Węzeł `[362]`
Mówca: **Emmerich Hegel (R)**
> ""Good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player_Romus: ""That's 'Good night, *Your Majesty*'.""*)
  - -> `[366]` (*Player_Romus: ""Thank you for calling nonetheless.""*)
  - -> `[367]` (*Player_Romus: ""Until next time, Chancellor.""*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To Vina? Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's 'Good night, *Your Majesty*'.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for calling nonetheless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Emmerich Hegel (R)), `[362]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, Chancellor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Emmerich Hegel (R)), `[362]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[368]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[369]`
Mówca: **Emmerich Hegel (R)**
> ""You have already deployed your military to the Antacean. No use in half measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Emmerich Hegel (R): ""Can I count on your cooperation or not?""*)

### Węzeł `[370]`
Mówca: **Emmerich Hegel (R)**
> ""You are a rational man. You must admit that the monarchical system belongs in the dustbin of history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Player_Romus: ""You are going too far, Mr. Hegel. You shall speak to me ..."*)
  - -> `[416]` (*Player_Romus: ""I disagree. In fact, a truly benevolent king can meet hi..."*)
  - -> `[417]` (*Player_Romus: ""Even if I agreed with you, cutting ties with Rumburg wou..."*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true"*)

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's almost as if you want to help Rizia retake Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[287]` (Emmerich Hegel (R)), `[293]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Emmerich Hegel (R): ""Yes. Almost.""*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Player_Romus: ""It's almost as if you want to help Rizia retake Pales.""*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[375]`
Mówca: **Emmerich Hegel (R)**
> ""Yes. Almost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Emmerich Hegel (R): ""Can I count on your cooperation or not?""*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My councilors were already against ITZ nationalization. They will certainly be against further cooperation with Valgsland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Emmerich Hegel (R)), `[288]` (Emmerich Hegel (R)), `[293]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Emmerich Hegel (R): ""You're the king, aren't you? You make the decisions.""*)

### Węzeł `[377]`
Mówca: **Emmerich Hegel (R)**
> ""You're the king, aren't you? You make the decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Emmerich Hegel (R): ""Don't get me wrong -- I despise monarchies. But I do occ..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not surprising. She goes where her intellectual curiosity takes her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Emmerich Hegel (R): ""She certainly is curious.""*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Chancellor. The princess can be a real brat sometimes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Emmerich Hegel (R): ""On the contrary. She's got a brilliant mind.""*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So *that*'s what she's been doing during my council meetings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Emmerich Hegel (R): ""If you're not involving the Princess in politics, you sh..."*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?! You are to cease your communication with her at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Emmerich Hegel (R): ""Why? From her letters and our conversation, I have the s..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_Valgsland_AcceptNavalAid == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_Va..."*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_Valgsland_AcceptNavalAid == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_CommieKing"] == true  and  Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "There was a silence, so long I began to think he had hung..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_Valgsland_AcceptNavalAid == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_CommieKing"] == true  and  Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Emmerich Hegel (R): ""Goodnight, Your Majesty.""*)

### Węzeł `[385]`
Mówca: **Narrator**
> "There was a silence, so long I began to think he had hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Emmerich Hegel (R): ""I may be overstepping my boundaries. But I cannot shake ..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover = true; RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Military_Valgsland_AcceptNavalAid = true; RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover = true; R..."*)

### Węzeł `[388]`
Mówca: **Emmerich Hegel (R)**
> ""She certainly is curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Emmerich Hegel (R): ""And from my communications, I have the sense that both o..."*)

### Węzeł `[389]`
Mówca: **Emmerich Hegel (R)**
> ""On the contrary. She's got a brilliant mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Emmerich Hegel (R): ""And from my communications, I have the sense that both o..."*)

### Węzeł `[390]`
Mówca: **Emmerich Hegel (R)**
> ""If you're not involving the Princess in politics, you should be. She has a brilliant mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Emmerich Hegel (R): ""And from my communications, I have the sense that both o..."*)

### Węzeł `[391]`
Mówca: **Emmerich Hegel (R)**
> ""Why? From her letters and our conversation, I have the sense that the two of you want the same thing for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Emmerich Hegel (R): ""Changes. Big ones.""*)

### Węzeł `[392]`
Mówca: **Emmerich Hegel (R)**
> ""And from my communications, I have the sense that both of you want the same thing for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Emmerich Hegel (R): ""Changes. Big ones.""*)

### Węzeł `[393]`
Mówca: **Emmerich Hegel (R)**
> ""Changes. Big ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Player_Romus: ""You are sorely mistaken. Neither of us want that.""*)
  - -> `[636]` (*Player_Romus: ""You will not speak of this again, Mr. Hegel. And you wil..."*)
  - -> `[639]` (*Player_Romus: ""We cannot have this conversation now. We must wait until..."*)
  - -> `[641]` (*Player_Romus: ""*If* that was what I wanted, how could Valgsland help me?""*)

### Węzeł `[394]`
Mówca: **Emmerich Hegel (R)**
> ""Goodnight, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Player_Romus: ""You don't need to call me that.""*)
  - -> `[396]` (*Player_Romus: ""Now *there's* the respect I deserve.""*)
  - -> `[397]` (*Player_Romus: ""Until next time, comrade.""*)
  - -> `[398]` (*Player_Romus: ""Goodnight, Mr. Hegel.""*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to call me that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now *there's* the respect I deserve.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, comrade.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodnight, Mr. Hegel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[399]`
Mówca: **Emmerich Hegel (R)**
> ""Don't get me wrong -- I despise monarchies. But I do occasionally wonder whether my job would be easier if I could sidestep the government infighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Player_Romus: ""I can't act with total impunity. My hands are tied by ro..."*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)
  - -> `[405]` (*Player_Romus: ""A paradox, isn't it? The more opinions you entertain in ..."*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should try it. It's great.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[399]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Emmerich Hegel (R): ""Ha. No, in the end I would never allow myself to overrid..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic > 0)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Player_Romus: ""Disagreement is part of any healthy government. Monarchi..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player_Romus: ""You should try it. It's great.""*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disagreement is part of any healthy government. Monarchical or not.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Kontekst wejściowy (poprzednik):** `[399]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Emmerich Hegel (R): ""You're correct, of course. Just an idle musing.""*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A paradox, isn't it? The more opinions you entertain in the name of representation, the harder it is to give your people what they actually need.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't act with total impunity. My hands are tied by royal tradition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Emmerich Hegel (R): ""That tradition was established by men in your exact same..."*)

### Węzeł `[407]`
Mówca: **Emmerich Hegel (R)**
> ""That tradition was established by men in your exact same position. You have the power to break it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Emmerich Hegel (R): ""Just tell me. Can I count on your cooperation?""*)

### Węzeł `[408]`
Mówca: **Emmerich Hegel (R)**
> ""Yet the longer one holds absolute power, the further one becomes distanced from those needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Emmerich Hegel (R): ""But enough about our governments. I want to know whether..."*)

### Węzeł `[409]`
Mówca: **Emmerich Hegel (R)**
> ""Ha. No, in the end I would never allow myself to override my government's checks and balances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Emmerich Hegel (R): ""But enough about our governments. I want to know whether..."*)

### Węzeł `[410]`
Mówca: **Emmerich Hegel (R)**
> ""You're correct, of course. Just an idle musing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Emmerich Hegel (R): ""But enough about our governments. I want to know whether..."*)

### Węzeł `[411]`
Mówca: **Emmerich Hegel (R)**
> ""You can expect the delivery of new vessels and equipment as soon as the nationalization agreement is finalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Emmerich Hegel (R): ""Can I count on your cooperation or not?""*)

### Węzeł `[412]`
Mówca: **Emmerich Hegel (R)**
> ""Can I count on your cooperation or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player_Romus: ""Yes. In exchange for your promised military aid, I will ..."*)
  - -> `[335]` (*Player_Romus: ""You can. But I'm not accepting your offer of naval reinf..."*)
  - -> `[337]` (*Player_Romus: ""No. Given the magnitude of Lespia's investments in the M..."*)
  - -> `[336]` (*Player_Romus: ""I'm sorry, but I can't promise you anything.""*)

### Węzeł `[413]`
Mówca: **Emmerich Hegel (R)**
> ""But enough about our governments. I want to know whether I can count on your cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player_Romus: ""Yes. In exchange for your promised military aid, I will ..."*)
  - -> `[335]` (*Player_Romus: ""You can. But I'm not accepting your offer of naval reinf..."*)
  - -> `[337]` (*Player_Romus: ""No. Given the magnitude of Lespia's investments in the M..."*)
  - -> `[336]` (*Player_Romus: ""I'm sorry, but I can't promise you anything.""*)

### Węzeł `[414]`
Mówca: **Emmerich Hegel (R)**
> ""Just tell me. Can I count on your cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player_Romus: ""Yes. In exchange for your promised military aid, I will ..."*)
  - -> `[335]` (*Player_Romus: ""You can. But I'm not accepting your offer of naval reinf..."*)
  - -> `[337]` (*Player_Romus: ""No. Given the magnitude of Lespia's investments in the M..."*)
  - -> `[336]` (*Player_Romus: ""I'm sorry, but I can't promise you anything.""*)

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are going too far, Mr. Hegel. You shall speak to me with the respect a king deserves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[370]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. In fact, a truly benevolent king can meet his people's needs more efficiently than a squabbling parliament.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[370]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if I agreed with you, cutting ties with Rumburg would be a disaster for us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[370]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Emmerich Hegel (R): ""Or an opportunity for new connections. Ones that will bi..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, combining a democratic system with the benefits of having a reigning sovereign seems like the best of both worlds to me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true`
- **Kontekst wejściowy (poprzednik):** `[370]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Emmerich Hegel (R): ""No man or woman should be placed above all others, even ..."*)

### Węzeł `[419]`
Mówca: **Emmerich Hegel (R)**
> ""Or an opportunity for new connections. Ones that will bind you with Merkopa's future, not its past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Emmerich Hegel (R): ""Just tell me. Can I count on your cooperation?""*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player_Romus: ""Actually, combining a democratic system with the benefit..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Emmerich Hegel (R): ""Yet the longer one holds absolute power, the further one..."*)

### Węzeł `[424]`
Mówca: **Emmerich Hegel (R)**
> ""No man or woman should be placed above all others, even symbolically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Emmerich Hegel (R): ""But enough about our governments. I want to know whether..."*)

### Węzeł `[425]`
Mówca: **Emmerich Hegel (R)**
> ""I wouldn't say that. But there's one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[426]`
Mówca: **Emmerich Hegel (R)**
> ""Regretfully, yes But there's still one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[427]`
Mówca: **Emmerich Hegel (R)**
> ""I am happy you see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Emmerich Hegel (R): ""Different as we are, there is one point on which we may ..."*)

### Węzeł `[428]`
Mówca: **Emmerich Hegel (R)**
> ""And I with monarchies. But there is one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[429]`
Mówca: **Emmerich Hegel (R)**
> ""Normally, no. But there is one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[430]`
Mówca: **Emmerich Hegel (R)**
> ""Different as we are, there is one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Emmerich Hegel (R): ""The Republic of Lespia does not belong in the Meftiem In..."*)

### Węzeł `[431]`
Mówca: **Emmerich Hegel (R)**
> ""The Republic of Lespia does not belong in the Meftiem International Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player_Romus: ""Another east-west battle? You should know that as a memb..."*)
  - -> `[434]` (*Player_Romus: ""You are wrong about that. Lespia has played and will con..."*)
  - -> `[433]` (*Player_Romus: ""I agree that Prime Minister Alvarez's behavior during th..."*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_StatusQuo == true"*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another east-west battle? You should know that as a member of GRACE, Rizia is obliged to stay uninvolved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[431]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Emmerich Hegel (R): ""Uh huh. The way Rumburg was uninvolved in the Wehlen Civ..."*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that Prime Minister Alvarez's behavior during the meeting was appalling.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[431]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Emmerich Hegel (R): ""As much as I personally dislike the man, he is a mere sy..."*)

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are wrong about that. Lespia has played and will continue to play an integral role in Trade Zone operations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[431]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Emmerich Hegel (R): ""And Rizia? What about you?""*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You heard what I said in the meeting. Neither Lespia nor Rizia will accept any change in the way the MITZ is run.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true`
- **Kontekst wejściowy (poprzednik):** `[431]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Emmerich Hegel (R): ""Yet Morella and Valgsland will not accept the status quo..."*)

### Węzeł `[436]`
Mówca: **Emmerich Hegel (R)**
> ""Uh huh. The way Rumburg was uninvolved in the Wehlen Civil War?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Emmerich Hegel (R): ""There is no 'uninvolved', Mr. Toras. Either you are on t..."*)

### Węzeł `[437]`
Mówca: **Emmerich Hegel (R)**
> ""And Rizia? What about you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_StatusQuo == true"*)
  - -> `[457]` (*Player_Romus: ""Like Lespia, we are committed to working together with M..."*)

### Węzeł `[438]`
Mówca: **Emmerich Hegel (R)**
> ""There is no 'uninvolved', Mr. Toras. Either you are on the side of the working man, or you are against him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Player_Romus: ""Then I suppose I am against him. Sorry.""*)
  - -> `[445]` (*Player_Romus: ""I don't believe that. One can sympathize with the plight..."*)
  - -> `[444]` (*Player_Romus: ""Him... or her.""*)

### Węzeł `[439]`
Mówca: **Emmerich Hegel (R)**
> ""As much as I personally dislike the man, he is a mere symptom of the disease called capitalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player_Romus: ""Not to mention alcoholism.""*)
  - -> `[456]` (*Player_Romus: ""That's where we disagree. I don't like Alvarez as a pers..."*)
  - -> `[645]` (*Player_Romus: ""Capitalism is what kept the MITZ running all these years..."*)

### Węzeł `[440]`
Mówca: **Emmerich Hegel (R)**
> ""Yet Morella and Valgsland will not accept the status quo. So what are we to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Player_Romus: ""What exactly do you want, Mr. Hegel?""*)
  - -> `[463]` (*Player_Romus: ""Obviously, either Valgsland or Morella must make a compr..."*)
  - -> `[464]` (*Player_Romus: ""I don't know. Go to war?""*)
  - -> `[465]` (*Player_Romus: ""Stay in a stalemate until one country caves. But it won'..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_StatusQuo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_StatusQuo == true"*)
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_StatusQuo == true)"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_StatusQuo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player_Romus: ""You heard what I said in the meeting. Neither Lespia nor..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_StatusQuo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Him... or her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Emmerich Hegel (R): ""Yes, yes, that goes without saying.""*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't believe that. One can sympathize with the plight of the working man without going full-on revolutionary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Emmerich Hegel (R): ""Sympathize, perhaps. Improve, no.""*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I suppose I am against him. Sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Emmerich Hegel (R): ""I don't think you understand what's happening right now.""*)

### Węzeł `[447]`
Mówca: **Emmerich Hegel (R)**
> ""Yes, yes, that goes without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[448]`
Mówca: **Emmerich Hegel (R)**
> ""I don't think you understand what's happening right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[449]`
Mówca: **Emmerich Hegel (R)**
> ""Sympathize, perhaps. Improve, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia and Lespia will stand together in preserving the status quo.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true`
- **Kontekst wejściowy (poprzednik):** `[437]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_StatusQuo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_StatusQuo == true"*)
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_StatusQuo == true)"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_StatusQuo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player_Romus: ""Rizia and Lespia will stand together in preserving the s..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_StatusQuo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player_Romus: ""We want better conditions for Morellan workers. But not ..."*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We want better conditions for Morellan workers. But not at the expense of Rizian or Lespian interests.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[437]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not to mention alcoholism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[439]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's where we disagree. I don't like Alvarez as a person, but we are fighting for the same principles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[439]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like Lespia, we are committed to working together with Morella to build a more equitable ITZ.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[458]`
Mówca: **Emmerich Hegel (R)**
> ""Let me lay it out for you, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Emmerich Hegel (R): ""Prime Minister Saltana is planning to reopen negotiation..."*)

### Węzeł `[459]`
Mówca: **Emmerich Hegel (R)**
> ""Prime Minister Saltana is planning to reopen negotiations on the MITZ profit-sharing agreement. Any new version will have to be approved by three out of the four countries on the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Emmerich Hegel (R): ""Say you wanted to make an agreement where Lespia came aw..."*)

### Węzeł `[460]`
Mówca: **Emmerich Hegel (R)**
> ""Say you wanted to make an agreement where Lespia came away with nothing. As long as Valgsland approved it, it would still pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Emmerich Hegel (R): ""Do you understand what I'm saying?""*)

### Węzeł `[461]`
Mówca: **Emmerich Hegel (R)**
> ""Do you understand what I'm saying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)
  - -> `[473]` (*Player_Romus: ""No. Please explain.""*)
  - -> `[474]` (*Player_Romus: ""You have Prime Minister Saltana's ear. Why aren't you sa..."*)
  - -> `[479]` (*Player_Romus: ""I think I know what you're getting at. And I like it.""*)

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly do you want, Mr. Hegel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[440]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Obviously, either Valgsland or Morella must make a compromise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[440]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Emmerich Hegel (R): ""And we are willing to do so. Under one condition.""*)

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. Go to war?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[440]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Emmerich Hegel (R): ""Please, Mr. Toras. Rizia is not in any position to start..."*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay in a stalemate until one country caves. But it won't be Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[440]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[466]`
Mówca: **Emmerich Hegel (R)**
> ""And we are willing to do so. Under one condition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Emmerich Hegel (R): ""Prime Minister Saltana is planning to reopen negotiation..."*)

### Węzeł `[467]`
Mówca: **Emmerich Hegel (R)**
> ""Please, Mr. Toras. Rizia is not in any position to start a war with anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Emmerich Hegel (R): ""Prime Minister Saltana is planning to reopen negotiation..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Player_Romus: ""You want me to screw over my business partner.""*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Player_Romus: ""You want me to screw Mr. Alvarez over.""*)

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You want me to screw over my business partner.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[461]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Emmerich Hegel (R): ""I wouldn't call it a 'partnership'. Alvarez will do exac..."*)

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You want me to screw Mr. Alvarez over.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[461]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Emmerich Hegel (R): ""Make no mistake. Alvarez will do exactly the same thing ..."*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Please explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[461]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Emmerich Hegel (R): ""Both of you will soon be invited to Morella for negotiat..."*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have Prime Minister Saltana's ear. Why aren't you saying this to her?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[461]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Emmerich Hegel (R): ""Valgsland's relationship with Morella is still young and..."*)

### Węzeł `[475]`
Mówca: **Emmerich Hegel (R)**
> ""Valgsland's relationship with Morella is still young and fragile. I do not want us to be accused of overreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Emmerich Hegel (R): ""Rizia, on the other hand, is Morella's direct neighbor a..."*)

### Węzeł `[476]`
Mówca: **Emmerich Hegel (R)**
> ""Rizia, on the other hand, is Morella's direct neighbor and longtime ally. It's only natural that you would request a more favorable deal than Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking you to act in Ri..."*)

### Węzeł `[477]`
Mówca: **Emmerich Hegel (R)**
> ""Make no mistake. Alvarez will do exactly the same thing if given the slightest opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking you to act in Ri..."*)

### Węzeł `[478]`
Mówca: **Emmerich Hegel (R)**
> ""I wouldn't call it a 'partnership'. Alvarez will do exactly the same thing if given the slightest opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking you to act in Ri..."*)

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I know what you're getting at. And I like it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[461]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Emmerich Hegel (R): ""You'll be invited to Morella for negotiations soon. I wa..."*)

### Węzeł `[480]`
Mówca: **Emmerich Hegel (R)**
> ""Both of you will soon be invited to Morella for negotiations. I want you to make sure Lespia receives as small of a share as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking you to act in Ri..."*)

### Węzeł `[481]`
Mówca: **Emmerich Hegel (R)**
> ""At the end of the day, I am only asking you to act in Rizia's best interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Player_Romus: ""I am all for trying to out-negotiate Lespia, but I'm afr..."*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true"*)
  - -> `[489]` (*Player_Romus: ""It's in our interests to work out a deal with Lespia and..."*)

### Węzeł `[482]`
Mówca: **Emmerich Hegel (R)**
> ""You'll be invited to Morella for negotiations soon. I want you to make sure Lespia receives as small of a share as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking you to act in Ri..."*)

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am all for trying to out-negotiate Lespia, but I'm afraid Rizia doesn't have the resources. Can you offer us any help?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Emmerich Hegel (R): ""Approving the final agreement will be help enough, I sho..."*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not only about Rizia. We need to limit Arcasian influence in the Trade Zone.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[481]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Emmerich Hegel (R): ""I'm glad you see it that way.""*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player_Romus: ""It's not only about Rizia. We need to limit Arcasian inf..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Player_Romus: ""It would certainly be advantageous for Rizia to keep our..."*)

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would certainly be advantageous for Rizia to keep our share of ITZ profits. If we end up with more than Lespia, so much the better.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[481]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Emmerich Hegel (R): ""Don't get too greedy.""*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's in our interests to work out a deal with Lespia and Morella. Valgsland's input is irrelevant.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Emmerich Hegel (R): ""Oh?""*)

### Węzeł `[490]`
Mówca: **Emmerich Hegel (R)**
> ""Approving the final agreement will be help enough, I should think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Emmerich Hegel (R): ""Needless to say, we still expect that you will make up f..."*)

### Węzeł `[491]`
Mówca: **Emmerich Hegel (R)**
> ""I'm glad you see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Emmerich Hegel (R): ""Needless to say, we still expect that you will make up f..."*)

### Węzeł `[492]`
Mówca: **Emmerich Hegel (R)**
> ""Don't get too greedy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Emmerich Hegel (R): ""Needless to say, we still expect that you will make up f..."*)

### Węzeł `[493]`
Mówca: **Emmerich Hegel (R)**
> ""Oh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Narrator: "I could hear irritation in his voice."*)

### Węzeł `[494]`
Mówca: **Emmerich Hegel (R)**
> ""Needless to say, we still expect that you will make up for the way Rizia treated Morella over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Player_Romus: ""If it means that much to you, I will make it happen.""*)
  - -> `[498]` (*Player_Romus: ""I'll see what I can do.""*)
  - -> `[499]` (*Player_Romus: ""I would anyway. Just because I voted against nationaliza..."*)

### Węzeł `[495]`
Mówca: **Emmerich Hegel (R)**
> ""Needless to say, we still expect that you will make up for the way Rizia treated Morella over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Player_Romus: ""You're in no position to make demands, Chancellor. You'r..."*)
  - -> `[497]` (*Player_Romus: ""If it means that much to you, I will make it happen.""*)
  - -> `[498]` (*Player_Romus: ""I'll see what I can do.""*)
  - -> `[499]` (*Player_Romus: ""I would anyway. Just because I voted against nationaliza..."*)

### Węzeł `[496]`
Mówca: **Emmerich Hegel (R)**
> ""Needless to say, we still expect that you will make up for the way Rizia treated Morella over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Player_Romus: ""You're in no position to make demands, Chancellor. You'r..."*)
  - -> `[497]` (*Player_Romus: ""If it means that much to you, I will make it happen.""*)
  - -> `[498]` (*Player_Romus: ""I'll see what I can do.""*)
  - -> `[499]` (*Player_Romus: ""I would anyway. Just because I voted against nationaliza..."*)

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it means that much to you, I will make it happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Emmerich Hegel (R)), `[495]` (Emmerich Hegel (R)), `[496]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Emmerich Hegel (R): ""It should mean something to you. If you are the benevole..."*)

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see what I can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Emmerich Hegel (R)), `[495]` (Emmerich Hegel (R)), `[496]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Emmerich Hegel (R): ""Thank you.""*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would anyway. Just because I voted against nationalization doesn't mean I'm heartless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Emmerich Hegel (R)), `[495]` (Emmerich Hegel (R)), `[496]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[500]`
Mówca: **Narrator**
> "I could hear irritation in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Emmerich Hegel (R): ""If it's an incentive you want...""*)

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're in no position to make demands, Chancellor. You're the one calling me in the middle of the night.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Emmerich Hegel (R)), `[496]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Narrator: "He sighed."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Emmerich Hegel (R): ""No, I suppose it doesn't.""*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Emmerich Hegel (R): ""You denied better working conditions to your own country..."*)

### Węzeł `[505]`
Mówca: **Emmerich Hegel (R)**
> ""No, I suppose it doesn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Emmerich Hegel (R): ""But if you do need a further incentive...""*)

### Węzeł `[506]`
Mówca: **Emmerich Hegel (R)**
> ""You denied better working conditions to your own countrymen. You'll excuse my skepticism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Emmerich Hegel (R): ""But if you do need a further incentive...""*)

### Węzeł `[507]`
Mówca: **Emmerich Hegel (R)**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Emmerich Hegel (R): ""But if you do need a further incentive...""*)

### Węzeł `[508]`
Mówca: **Emmerich Hegel (R)**
> ""It should mean something to you. If you are the benevolent leader you claim to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Emmerich Hegel (R): ""But if you do need a further incentive...""*)

### Węzeł `[509]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Emmerich Hegel (R): ""If it's an incentive you want...""*)

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's in my best interests to side with Lespia. As I have already agreed to do.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true`
- **Kontekst wejściowy (poprzednik):** `[481]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Emmerich Hegel (R): ""And you don't think that Lespia is angling for Morella's..."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true"*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Player_Romus: ""It's in my best interests to side with Lespia. As I have..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[514]`
Mówca: **Emmerich Hegel (R)**
> ""And you don't think that Lespia is angling for Morella's favor even as we speak?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Emmerich Hegel (R): ""But I see your predicament.""*)

### Węzeł `[515]`
Mówca: **Emmerich Hegel (R)**
> ""If it's an incentive you want...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Emmerich Hegel (R): ""Valgsland cannot publicly support a monarchy like Rizia...."*)

### Węzeł `[516]`
Mówca: **Emmerich Hegel (R)**
> ""But I see your predicament.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Emmerich Hegel (R): ""If it's an incentive you want...""*)

### Węzeł `[517]`
Mówca: **Emmerich Hegel (R)**
> ""Valgsland cannot publicly support a monarchy like Rizia. Especially after the way you voted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Emmerich Hegel (R): ""But we can sell you our naval equipment, which, as I nee..."*)

### Węzeł `[518]`
Mówca: **Emmerich Hegel (R)**
> ""But we can sell you our naval equipment, which, as I need not remind you, is vastly superior to Rizia's own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Emmerich Hegel (R): ""Make sure Lespia winds up with nothing, and Valgsland wi..."*)

### Węzeł `[519]`
Mówca: **Emmerich Hegel (R)**
> ""Make sure Lespia winds up with nothing, and Valgsland will assist you with a significant upgrade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Player_Romus: ""Are you implying that our military is weak, Mr. Hegel?""*)
  - -> `[527]` (*Player_Romus: ""Tempting. Our navy could use the help.""*)
  - -> `[521]` (*Player_Romus: ""I'm afraid Valgslandian aid would be a red line for our ..."*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you implying that our military is weak, Mr. Hegel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[519]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Emmerich Hegel (R): ""Excuse my phrasing. But you must admit that you cannot m..."*)

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid Valgslandian aid would be a red line for our partners in GRACE.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[519]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Emmerich Hegel (R): ""It would not be aid. We would only make our vessels and ..."*)

### Węzeł `[522]`
Mówca: **Emmerich Hegel (R)**
> ""It would not be aid. We would only make our vessels and equipment available for purchase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Emmerich Hegel (R): ""Besides which, you should not care about the opinion of ..."*)

### Węzeł `[523]`
Mówca: **Emmerich Hegel (R)**
> ""I don't need to convince you of Valgsland's dominion over the sea. Our warships and submarines are second to none.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player_Romus: ""Still, my councilors will be against any form of coopera..."*)
  - -> `[554]` (*Player_Romus: ""If I'm going to stab Lespia in the back, Rizia will defi..."*)
  - -> `[555]` (*Player_Romus: ""I am putting my foot down. We neither need nor want your..."*)

### Węzeł `[524]`
Mówca: **Emmerich Hegel (R)**
> ""Excuse my phrasing. But you must admit that you cannot match Valgsland's dominion over the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player_Romus: ""Still, my councilors will be against any form of coopera..."*)
  - -> `[554]` (*Player_Romus: ""If I'm going to stab Lespia in the back, Rizia will defi..."*)
  - -> `[555]` (*Player_Romus: ""I am putting my foot down. We neither need nor want your..."*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're offering us a naval upgrade while we already have forces stationed around a disputed gas field?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Kontekst wejściowy (poprzednik):** `[519]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Emmerich Hegel (R): ""Why, yes. Perhaps Valgsland's superior vessels and equip..."*)

### Węzeł `[526]`
Mówca: **Emmerich Hegel (R)**
> ""Why, yes. Perhaps Valgsland's superior vessels and equipment can help you solve that dispute faster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player_Romus: ""Still, my councilors will be against any form of coopera..."*)
  - -> `[554]` (*Player_Romus: ""If I'm going to stab Lespia in the back, Rizia will defi..."*)
  - -> `[533]` (*Player_Romus: ""It'll send a strong signal. Too strong.""*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tempting. Our navy could use the help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[519]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Emmerich Hegel (R): ""I don't need to convince you of Valgsland's dominion ove..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Player_Romus: ""You're offering us a naval upgrade while we already have..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[531]`
Mówca: **Emmerich Hegel (R)**
> ""Besides which, you should not care about the opinion of a group of inbred despots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player_Romus: ""Still, my councilors will be against any form of coopera..."*)
  - -> `[555]` (*Player_Romus: ""I am putting my foot down. We neither need nor want your..."*)
  - -> `[607]` (*Player_Romus: ""One of those 'despots' is my sister-in-law. And losing h..."*)
  - -> `[556]` (*Player_Romus: ""You hope to win me over by demeaning me and the institut..."*)

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, my councilors will be against any form of cooperation with Valgsland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[523]` (Emmerich Hegel (R)), `[524]` (Emmerich Hegel (R)), `[526]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Emmerich Hegel (R): ""Isn't that the sole benefit of being a monarch? You can ..."*)

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll send a strong signal. Too strong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[526]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Emmerich Hegel (R): ""You have already deployed your military to the Antacean...."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Player_Romus: ""It's almost as if you want to help Rizia retake Pales.""*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[537]`
Mówca: **Emmerich Hegel (R)**
> ""You have already deployed your military to the Antacean. No use in half measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Emmerich Hegel (R): ""Just tell me. Can I count on your cooperation?""*)

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's almost as if you want to help Rizia retake Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[524]` (Emmerich Hegel (R)), `[526]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Emmerich Hegel (R): ""Mm. Almost.""*)

### Węzeł `[539]`
Mówca: **Emmerich Hegel (R)**
> ""Mm. Almost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Emmerich Hegel (R): ""Just tell me. Can I count on your cooperation?""*)

### Węzeł `[540]`
Mówca: **Emmerich Hegel (R)**
> ""Isn't that the sole benefit of being a monarch? You can make decisions without spending months bogged down in government infighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Player_Romus: ""I can't act with total impunity. My hands are tied by ro..."*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)
  - -> `[543]` (*Player_Romus: ""Is that a problem in Valgsland? Trying to please everyon..."*)

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should try it. It's great.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[540]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Emmerich Hegel (R): ""Ha. No, in the end I would never allow myself to overrid..."*)

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disagreement is part of any healthy government. Monarchical or not.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Kontekst wejściowy (poprzednik):** `[540]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Emmerich Hegel (R): ""You're correct, of course. Just an idle musing.""*)

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that a problem in Valgsland? Trying to please everyone, ending up pleasing no one?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[540]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Emmerich Hegel (R): ""It is still better than allowing unlimited power to blin..."*)

### Węzeł `[544]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't act with total impunity. My hands are tied by royal tradition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[540]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Emmerich Hegel (R): ""That tradition was established by men in your exact same..."*)

### Węzeł `[545]`
Mówca: **Emmerich Hegel (R)**
> ""That tradition was established by men in your exact same position. You have the power to break it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Emmerich Hegel (R): ""Just tell me. Can I count on your cooperation?""*)

### Węzeł `[546]`
Mówca: **Emmerich Hegel (R)**
> ""It is still better than allowing unlimited power to blind you to your people's true needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Emmerich Hegel (R): ""But enough about our governments. I want to know whether..."*)

### Węzeł `[547]`
Mówca: **Emmerich Hegel (R)**
> ""Ha. No, in the end I would never allow myself to override my government's checks and balances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Emmerich Hegel (R): ""But enough about our governments. I want to know whether..."*)

### Węzeł `[548]`
Mówca: **Emmerich Hegel (R)**
> ""You're correct, of course. Just an idle musing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Emmerich Hegel (R): ""But enough about our governments. I want to know whether..."*)

### Węzeł `[549]`
Mówca: **Emmerich Hegel (R)**
> ""But enough about our governments. I want to know whether I can count on your cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Player_Romus: ""You can. In exchange for the navy deal you mentioned, I ..."*)
  - -> `[612]` (*Player_Romus: ""I cannot promise anything. But it's good to know that Va..."*)
  - -> `[614]` (*Player_Romus: ""There will be no cooperation between Rizia and Valgsland..."*)

### Węzeł `[550]`
Mówca: **Emmerich Hegel (R)**
> ""Just tell me. Can I count on your cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Player_Romus: ""You can. In exchange for the navy deal you mentioned, I ..."*)
  - -> `[612]` (*Player_Romus: ""I cannot promise anything. But it's good to know that Va..."*)
  - -> `[614]` (*Player_Romus: ""There will be no cooperation between Rizia and Valgsland..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic > 0)"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Player_Romus: ""Disagreement is part of any healthy government. Monarchi..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Player_Romus: ""You should try it. It's great.""*)

### Węzeł `[554]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I'm going to stab Lespia in the back, Rizia will definitely need to be able to defend itself afterwards.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[523]` (Emmerich Hegel (R)), `[524]` (Emmerich Hegel (R)), `[526]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Emmerich Hegel (R): ""That's the right idea.""*)

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am putting my foot down. We neither need nor want your assistance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[523]` (Emmerich Hegel (R)), `[524]` (Emmerich Hegel (R)), `[531]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Emmerich Hegel (R): ""Very well. It was only an offer.""*)

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You hope to win me over by demeaning me and the institution I stand for? Show some respect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Emmerich Hegel (R): ""You dare speak of respect?""*)

### Węzeł `[557]`
Mówca: **Emmerich Hegel (R)**
> ""That's the right idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Emmerich Hegel (R): ""So can I count on your cooperation?""*)

### Węzeł `[558]`
Mówca: **Emmerich Hegel (R)**
> ""Very well. It was only an offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[559]`
Mówca: **Emmerich Hegel (R)**
> ""So can I count on your cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Player_Romus: ""You can. In exchange for the navy deal you mentioned, I ..."*)
  - -> `[612]` (*Player_Romus: ""I cannot promise anything. But it's good to know that Va..."*)
  - -> `[614]` (*Player_Romus: ""There will be no cooperation between Rizia and Valgsland..."*)

### Węzeł `[560]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect you, when you don't respect the will of your own people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Player_Romus: ""Take that back this instant. My people love me.""*)
  - -> `[571]` (*Player_Romus: ""Like it or not, we are both world leaders. A little more..."*)
  - -> `[572]` (*Player_Romus: ""Because I'm holding the cards. You're the one calling me..."*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Emmerich Hegel (R): ""Why should I respect you, when you don't respect the wil..."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Religious > 0)"*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Emmerich Hegel (R): ""Why should I respect a man who takes orders from some in..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Religious > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Emmerich Hegel (R): ""Why should I respect a man who sits on a golden throne, ..."*)

### Węzeł `[567]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect a man who sits on a golden throne, surrounded by riches he did not earn?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Player_Romus: ""Like it or not, we are both world leaders. A little more..."*)
  - -> `[572]` (*Player_Romus: ""Because I'm holding the cards. You're the one calling me..."*)
  - -> `[584]` (*Player_Romus: ""My family earned everything we have. With the help of th..."*)
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true ..."*)

### Węzeł `[568]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect a man who takes orders from some invisible being in the sky?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Player_Romus: ""Like it or not, we are both world leaders. A little more..."*)
  - -> `[572]` (*Player_Romus: ""Because I'm holding the cards. You're the one calling me..."*)
  - -> `[569]` (*Player_Romus: ""Are you demeaning the Holy Spirit of St. Dast?""*)
  - -> `[570]` (*Player_Romus: ""Religion guides my decisions, yes, but I do not 'take or..."*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you demeaning the Holy Spirit of St. Dast?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[568]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Emmerich Hegel (R): ""Whatever you want to call it, it should be completely se..."*)

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religion guides my decisions, yes, but I do not 'take orders' from anyone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[568]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Emmerich Hegel (R): "'Even the smallest role played by religion in state matte..."*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like it or not, we are both world leaders. A little more decorum is in order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Emmerich Hegel (R)), `[567]` (Emmerich Hegel (R)), `[568]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "There was silence on the other end as Hegel seemed to col..."*)

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because I'm holding the cards. You're the one calling me in the middle of the night, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Emmerich Hegel (R)), `[567]` (Emmerich Hegel (R)), `[568]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "There was silence on the other end as Hegel seemed to col..."*)

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take that back this instant. My people love me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Emmerich Hegel (R): ""Your people live in fear of you.""*)

### Węzeł `[574]`
Mówca: **Narrator**
> "There was a brief pause on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Emmerich Hegel (R): ""Sorry to wake you, Mr. Toras. This call was a mistake.""*)

### Węzeł `[575]`
Mówca: **Narrator**
> "There was silence on the other end as Hegel seemed to collect himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Emmerich Hegel (R): ""Very well. I am sorry.""*)

### Węzeł `[576]`
Mówca: **Emmerich Hegel (R)**
> ""The Valgos Empire is dead and gone. As the Kingdom of Rizia should be, by all rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[577]`
Mówca: **Emmerich Hegel (R)**
> ""I am afraid not, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Emmerich Hegel (R): ""Monarchist or not, you have shown me where your prioriti..."*)

### Węzeł `[578]`
Mówca: **Emmerich Hegel (R)**
> ""Your people live in fear of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[579]`
Mówca: **Emmerich Hegel (R)**
> ""Whatever you want to call it, it should be completely separate from state matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[580]`
Mówca: **Emmerich Hegel (R)**
> "'Even the smallest role played by religion in state matters is too large.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Narrator: "There was a brief pause on the other end of the line."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true ..."*)
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == tru..."*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Player_Romus: ""You are right. And in fact, I am trying to change the ro..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My family earned everything we have. With the help of the Valgos Empire, I might add.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[567]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Emmerich Hegel (R): ""The Valgos Empire is dead and gone. As the Kingdom of Ri..."*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right. And in fact, I am trying to change the role of the monarchy in Rizia. Maybe you can help me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Kontekst wejściowy (poprzednik):** `[567]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Emmerich Hegel (R): ""I am afraid not, Mr. Toras.""*)

### Węzeł `[586]`
Mówca: **Emmerich Hegel (R)**
> ""Very well. I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Emmerich Hegel (R): ""Just tell me. Can I count on your cooperation?""*)

### Węzeł `[587]`
Mówca: **Emmerich Hegel (R)**
> ""But if you do need a further incentive...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Emmerich Hegel (R): ""Valgsland cannot publicly support a monarchy like Rizia...."*)

### Węzeł `[588]`
Mówca: **Emmerich Hegel (R)**
> ""Sorry to wake you, Mr. Toras. This call was a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Player_Romus: ""You're only now realizing that?""*)
  - -> `[590]` (*Player_Romus: ""Wait. I do want to help squeeze Lespia out of the Trade ..."*)
  - -> `[591]` (*Player_Romus: ""Until you treat the Rizian monarchy with more deference,..."*)

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're only now realizing that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Emmerich Hegel (R): ""Yes. Silly me.""*)

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I do want to help squeeze Lespia out of the Trade Zone. You can count on my cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Emmerich Hegel (R): ""Too late, Mr. Toras.""*)

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until you treat the Rizian monarchy with more deference, we will remain at odds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Emmerich Hegel (R): ""Then we will be at odds for eternity.""*)

### Węzeł `[592]`
Mówca: **Emmerich Hegel (R)**
> ""Yes. Silly me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Narrator: "He sighed."*)

### Węzeł `[593]`
Mówca: **Emmerich Hegel (R)**
> ""Too late, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Narrator: "He sighed."*)

### Węzeł `[594]`
Mówca: **Emmerich Hegel (R)**
> ""Then we will be at odds for eternity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Narrator: "He sighed."*)

### Węzeł `[595]`
Mówca: **Emmerich Hegel (R)**
> ""Good night. And give my regards to the Princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Romus: ""To Vina? Why?""*)
  - -> `[599]` (*Player_Romus: ""I will.""*)
  - -> `[601]` (*Player_Romus: ""Thank you for calling nonetheless.""*)
  - -> `[602]` (*Player_Romus: ""Until next time, Chancellor.""*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Emmerich Hegel (R): ""Good night. And give my regards to the Princess.""*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Emmerich Hegel (R): ""Good night.""*)

### Węzeł `[599]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[595]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He hung up."*)

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's 'Good night, *Your Majesty*'.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[604]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He hung up."*)

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for calling nonetheless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[595]` (Emmerich Hegel (R)), `[604]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He hung up."*)

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, Chancellor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[595]` (Emmerich Hegel (R)), `[604]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He hung up."*)

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To Vina? Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[595]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He hung up."*)

### Węzeł `[604]`
Mówca: **Emmerich Hegel (R)**
> ""Good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Player_Romus: ""That's 'Good night, *Your Majesty*'.""*)
  - -> `[601]` (*Player_Romus: ""Thank you for calling nonetheless.""*)
  - -> `[602]` (*Player_Romus: ""Until next time, Chancellor.""*)

### Węzeł `[605]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[606]`
Mówca: **Emmerich Hegel (R)**
> ""You dare speak of respect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)

### Węzeł `[607]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One of those 'despots' is my sister-in-law. And losing her favor would be disastrous for us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Emmerich Hegel (R): ""Or an opportunity for new connections. Ones that will bi..."*)

### Węzeł `[608]`
Mówca: **Emmerich Hegel (R)**
> ""Or an opportunity for new connections. Ones that will bind you with Merkopa's future, not its past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Emmerich Hegel (R): ""Just tell me. Can I count on your cooperation?""*)

### Węzeł `[609]`
Mówca: **Emmerich Hegel (R)**
> ""Monarchist or not, you have shown me where your priorities lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Emmerich Hegel (R): ""For now, just tell me. Can I count on your cooperation?""*)

### Węzeł `[610]`
Mówca: **Emmerich Hegel (R)**
> ""For now, just tell me. Can I count on your cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Player_Romus: ""You can. In exchange for the navy deal you mentioned, I ..."*)
  - -> `[612]` (*Player_Romus: ""I cannot promise anything. But it's good to know that Va..."*)
  - -> `[619]` (*Player_Romus: ""Not on this matter. But I do not wish to be on bad terms..."*)
  - -> `[614]` (*Player_Romus: ""There will be no cooperation between Rizia and Valgsland..."*)

### Węzeł `[611]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can. In exchange for the navy deal you mentioned, I will shrink Lespia's share of the MITZ.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Emmerich Hegel (R)), `[550]` (Emmerich Hegel (R)), `[559]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover = true; R..."*)

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot promise anything. But it's good to know that Valgsland will support Rizia getting a larger profit share.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Emmerich Hegel (R)), `[550]` (Emmerich Hegel (R)), `[559]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Emmerich Hegel (R): ""In that case, I cannot promise anything in that arena ei..."*)

### Węzeł `[613]`
Mówca: **Emmerich Hegel (R)**
> ""In that case, I cannot promise anything in that arena either. I will have to see the final proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Narrator: "His tone turned more conversational."*)

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be no cooperation between Rizia and Valgsland, Mr. Hegel. On MITZ matters or otherwise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Emmerich Hegel (R)), `[550]` (Emmerich Hegel (R)), `[559]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Emmerich Hegel (R): ""I suspected as much.""*)

### Węzeł `[615]`
Mówca: **Emmerich Hegel (R)**
> ""I suspected as much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Narrator: "He sighed."*)

### Węzeł `[616]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[617]`
Mówca: **Emmerich Hegel (R)**
> ""For some reason, my people are crazy about the Rizian royal family. Because of your history with the Valgos Empire, I suppose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Emmerich Hegel (R): ""But you're no better than Lespia. Prime Minister Saltana..."*)

### Węzeł `[618]`
Mówca: **Emmerich Hegel (R)**
> ""But you're no better than Lespia. Prime Minister Saltana will see right through you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not on this matter. But I do not wish to be on bad terms with Valgsland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[610]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Emmerich Hegel (R): ""That is wise, Mr. Toras.""*)

### Węzeł `[620]`
Mówca: **Emmerich Hegel (R)**
> ""That is wise, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Narrator: "His tone turned more conversational."*)

### Węzeł `[621]`
Mówca: **Emmerich Hegel (R)**
> ""Thank you. I am glad this phone call was not a waste of both of our time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Narrator: "His tone turned more conversational."*)

### Węzeł `[622]`
Mówca: **Narrator**
> "His tone turned more conversational."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Emmerich Hegel (R): ""For some reason, my people are crazy about the Rizian ro..."*)

### Węzeł `[623]`
Mówca: **Emmerich Hegel (R)**
> ""For some reason, my people are crazy about the Rizian royal family. Because of your history with the Valgos Empire, perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Player_Romus: ""Maybe it's because we're so good-looking.""*)
  - -> `[625]` (*Player_Romus: ""Everyone loves royals, Chancellor. Even die-hard sociali..."*)
  - -> `[626]` (*Player_Romus: ""Are you saying it's time to revive those old ties?""*)
  - -> `[627]` (*Player_Romus: ""Funny. My people don't feel the same about Valgish arist..."*)

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe it's because we're so good-looking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[623]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Emmerich Hegel (R): ""Your Valgish genes, then.""*)

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everyone loves royals, Chancellor. Even die-hard socialists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[623]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Emmerich Hegel (R): ""Your lifestyle inspires jealousy. If not your familial s..."*)

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying it's time to revive those old ties?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[623]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Emmerich Hegel (R): ""I'm not saying anything. Just thinking out loud.""*)

### Węzeł `[627]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Funny. My people don't feel the same about Valgish aristocrats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[623]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Emmerich Hegel (R): ""Because there aren't any more of them. Except the ones i..."*)

### Węzeł `[628]`
Mówca: **Emmerich Hegel (R)**
> ""Because there aren't any more of them. Except the ones in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[629]`
Mówca: **Emmerich Hegel (R)**
> ""I'm not saying anything. Just thinking out loud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[630]`
Mówca: **Emmerich Hegel (R)**
> ""Your lifestyle inspires jealousy. If not your familial squabbles and the constant scrutiny you're under.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[631]`
Mówca: **Emmerich Hegel (R)**
> ""Your Valgish genes, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover = true;
RiziaDLC.Military_Valgsland_AcceptNavalAid = true; RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid = true; RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover"] = true;
Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Emmerich Hegel (R): ""Thank you. I am glad this phone call was not a waste of ..."*)

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are sorely mistaken. Neither of us want that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Emmerich Hegel (R): ""You should speak with your daughter more often, Mr. Toras.""*)

### Węzeł `[634]`
Mówca: **Emmerich Hegel (R)**
> ""You should speak with your daughter more often, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Emmerich Hegel (R): ""Good night.""*)

### Węzeł `[635]`
Mówca: **Emmerich Hegel (R)**
> ""Good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[636]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will not speak of this again, Mr. Hegel. And you will cut off contact with Vina immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Emmerich Hegel (R): ""Ah. Perhaps I was mistaken about your intentions.""*)

### Węzeł `[637]`
Mówca: **Emmerich Hegel (R)**
> ""Ah. Perhaps I was mistaken about your intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Emmerich Hegel (R): ""Well, good night.""*)

### Węzeł `[638]`
Mówca: **Emmerich Hegel (R)**
> ""Well, good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "He hung up."*)

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot have this conversation now. We must wait until the time is right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Emmerich Hegel (R)), `[643]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Emmerich Hegel (R): ""Agreed, Mr. Toras.""*)

### Węzeł `[640]`
Mówca: **Emmerich Hegel (R)**
> ""Agreed, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hegel_OpenToRevolution = true"*)

### Węzeł `[641]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* that was what I wanted, how could Valgsland help me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Emmerich Hegel (R)), `[643]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Emmerich Hegel (R): ""Later, Mr. Toras. I await the results of your visit to M..."*)

### Węzeł `[642]`
Mówca: **Emmerich Hegel (R)**
> ""Later, Mr. Toras. I await the results of your visit to Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hegel_OpenToRevolution = true"*)

### Węzeł `[643]`
Mówca: **Emmerich Hegel (R)**
> ""Changes. Big ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Player_Romus: ""We cannot have this conversation now. We must wait until..."*)
  - -> `[641]` (*Player_Romus: ""*If* that was what I wanted, how could Valgsland help me?""*)
  - -> `[644]` (*Player_Romus: ""How dare you even suggest that? Don't make me regret wor..."*)

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare you even suggest that? Don't make me regret working with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[643]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Emmerich Hegel (R): ""Ah. Perhaps I was mistaken about your intentions.""*)

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Capitalism is what kept the MITZ running all these years. I would not disparage it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[439]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Emmerich Hegel (R): ""Let me lay it out for you, Mr. Toras.""*)

### Węzeł `[646]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[647]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Emmerich Hegel (R): ""I will, however, support Rizia in your current arbitrati..."*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)

### Węzeł `[649]`
Mówca: **Emmerich Hegel (R)**
> ""I will, however, support Rizia in your current arbitration case against Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Player_Romus: ""You have our gratitude for that, good sir.""*)
  - -> `[652]` (*Player_Romus: ""We don't need your support, Hegel.""*)
  - -> `[654]` (*Player_Romus: ""And why would that be?""*)

### Węzeł `[650]`
Mówca: **Emmerich Hegel (R)**
> ""Not out of any loyalty to you, but because I believe the sovereign territory of islands must be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have our gratitude for that, good sir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[649]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Emmerich Hegel (R): ""Not out of any loyalty to you, but because I believe the..."*)

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need your support, Hegel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[649]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Emmerich Hegel (R): ""You're getting it anyway. If the AN decides to disrespec..."*)

### Węzeł `[653]`
Mówca: **Emmerich Hegel (R)**
> ""You're getting it anyway. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)

### Węzeł `[654]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would that be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[649]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Emmerich Hegel (R): ""You must have some inkling why. If the AN decides to dis..."*)

### Węzeł `[655]`
Mówca: **Emmerich Hegel (R)**
> ""You must have some inkling why. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Emmerich Hegel (R): ""And incidentally, you can count on Valgsland's support i..."*)

### Węzeł `[658]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_Commie..."*)

### Węzeł `[659]`
Mówca: **Emmerich Hegel (R)**
> ""And incidentally, you can count on Valgsland's support in your current arbitration case against Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Player_Romus: ""You have our gratitude for that, good sir.""*)
  - -> `[662]` (*Player_Romus: ""You're just full of favors today, aren't you?""*)
  - -> `[663]` (*Player_Romus: ""And why would that be?""*)

### Węzeł `[660]`
Mówca: **Emmerich Hegel (R)**
> ""I believe Rizia deserves it. But more importantly, the AN must respect the sovereign territory of islands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_Commie..."*)

### Węzeł `[661]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have our gratitude for that, good sir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[659]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Emmerich Hegel (R): ""I believe Rizia deserves it. But more importantly, the A..."*)

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're just full of favors today, aren't you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[659]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Emmerich Hegel (R): ""This is no favor. If the AN decides to disrespect the so..."*)

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would that be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[659]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Emmerich Hegel (R): ""You must have some inkling why. If the AN decides to dis..."*)

### Węzeł `[664]`
Mówca: **Emmerich Hegel (R)**
> ""This is no favor. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_Commie..."*)

### Węzeł `[665]`
Mówca: **Emmerich Hegel (R)**
> ""You must have some inkling why. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_Commie..."*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Emmerich Hegel (R): ""Incidentally, you can count on Valgsland's support in yo..."*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Emmerich Hegel (R): ""Goodnight, Your Majesty.""*)

### Węzeł `[669]`
Mówca: **Emmerich Hegel (R)**
> ""Incidentally, you can count on Valgsland's support in your current arbitration case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Player_Romus: ""You have our gratitude for that, good sir.""*)
  - -> `[672]` (*Player_Romus: ""You're just full of favors today, aren't you?""*)
  - -> `[673]` (*Player_Romus: ""And why would that be?""*)

### Węzeł `[670]`
Mówca: **Emmerich Hegel (R)**
> ""I believe Rizia deserves it. But more importantly, the AN must respect the sovereign territory of islands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Emmerich Hegel (R): ""Goodnight, Your Majesty.""*)

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have our gratitude for that, good sir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[669]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Emmerich Hegel (R): ""I believe Rizia deserves it. But more importantly, the A..."*)

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're just full of favors today, aren't you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[669]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Emmerich Hegel (R): ""This is no favor. If the AN decides to disrespect the so..."*)

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would that be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[669]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Emmerich Hegel (R): ""You must have some inkling why. If the AN decides to dis..."*)

### Węzeł `[674]`
Mówca: **Emmerich Hegel (R)**
> ""This is no favor. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Emmerich Hegel (R): ""Goodnight, Your Majesty.""*)

### Węzeł `[675]`
Mówca: **Emmerich Hegel (R)**
> ""You must have some inkling why. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Emmerich Hegel (R): ""Goodnight, Your Majesty.""*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Emmerich Hegel (R): ""I will, however, support Rizia in your current arbitrati..."*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Emmerich Hegel (R): ""For some reason, my people are crazy about the Rizian ro..."*)

### Węzeł `[679]`
Mówca: **Emmerich Hegel (R)**
> ""I will, however, support Rizia in your current arbitration case against Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Player_Romus: ""You have our gratitude for that, good sir.""*)
  - -> `[682]` (*Player_Romus: ""We don't need your support, Hegel.""*)
  - -> `[684]` (*Player_Romus: ""And why would that be?""*)

### Węzeł `[680]`
Mówca: **Emmerich Hegel (R)**
> ""Not out of any loyalty to you, but because I believe the sovereign territory of islands must be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have our gratitude for that, good sir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[679]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Emmerich Hegel (R): ""Not out of any loyalty to you, but because I believe the..."*)

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need your support, Hegel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[679]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Emmerich Hegel (R): ""You're getting it anyway. If the AN decides to disrespec..."*)

### Węzeł `[683]`
Mówca: **Emmerich Hegel (R)**
> ""You're getting it anyway. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[684]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would that be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[679]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Emmerich Hegel (R): ""You must have some inkling why. If the AN decides to dis..."*)

### Węzeł `[685]`
Mówca: **Emmerich Hegel (R)**
> ""You must have some inkling why. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ToldAboutComradeVina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ToldAboutComradeVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Emmerich Hegel (R): ""You might want to know that I have been contacted by you..."*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Lucita == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Rizi..."*)
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Ri..."*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Lucita == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Player_Romus: ""Lucita told me what you were up to the night Father died.""*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Lucita == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Rizi..."*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Rizi..."*)
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && Ri..."*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Player_Romus: ""Titus told me what you were up to the night Father died.""*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[693]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita told me what you were up to the night Father died.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator), `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Narrator: "Pabel hurriedly draped my robe over my shoulders. He turn..."*)

### Węzeł `[694]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus told me what you were up to the night Father died.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true` AND `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator), `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Narrator: "Pabel hurriedly draped my robe over my shoulders. He turn..."*)

### Węzeł `[695]`
Mówca: **Narrator**
> "Pabel hurriedly draped my robe over my shoulders. He turned to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows = true"*)

### Węzeł `[696]`
Mówca: **Pabel Adria**
> ""You investigated me? I told you I was innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == false"*)

### Węzeł `[697]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Innocent of murder. Guilty of sodomy.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Kontekst wejściowy (poprzednik):** `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Narrator: "His face turned pale."*)

### Węzeł `[698]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. I bet I can guess what you were tasting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[705]` (Pabel Adria), `[720]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Pabel Adria: ""Wine, {RiziaDLCText.PabelToPlayer}. Not a difficult guess.""*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == false"*)
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == false)"*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Player_Romus: ""Sorry, Pabel. I couldn't leave any stone unturned.""*)
  - -> `[713]` (*Player_Romus: ""I don't care what you do after hours. But you've got to ..."*)
  - -> `[697]` (*Player_Romus: ""Innocent of murder. Guilty of sodomy.""*)
  - -> `[756]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedEarly == true"*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Player_Romus: ""It's nothing personal. I couldn't make it look like I wa..."*)
  - -> `[706]` (*Player_Romus: ""It's all fine. They didn't turn up any conclusive eviden..."*)
  - -> `[702]` (*Player_Romus: ""I thought you were in love with me all this time.""*)

### Węzeł `[702]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you were in love with me all this time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Narrator: "Pabel allowed himself a smile."*)

### Węzeł `[703]`
Mówca: **Narrator**
> "Pabel allowed himself a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Pabel Adria: ""That doesn't mean I was a eunuch.""*)

### Węzeł `[704]`
Mówca: **Pabel Adria**
> ""That doesn't mean I was a eunuch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""I can't stop thinking about our night together.""*)
  - -> `[62]` (*Player_Romus: ""When can we see each other again? And by 'see', I mean...""*)

### Węzeł `[705]`
Mówca: **Pabel Adria**
> ""I don't know what you're talking about, Your Majesty. I was conducting a tasting session with a Cantuavo representative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Player_Romus: ""If you say so.""*)
  - -> `[698]` (*Player_Romus: ""Right. I bet I can guess what you were tasting.""*)
  - -> `[708]` (*Player_Romus: ""I don't care what you call it. Keep carrying on like thi..."*)

### Węzeł `[706]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all fine. They didn't turn up any conclusive evidence against you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Narrator: "Pabel let out a quiet sigh of relief."*)

### Węzeł `[707]`
Mówca: **Narrator**
> "Pabel let out a quiet sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""I can't stop thinking about our night together.""*)
  - -> `[62]` (*Player_Romus: ""When can we see each other again? And by 'see', I mean...""*)

### Węzeł `[708]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what you call it. Keep carrying on like this and I'll have you thrown in prison.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[705]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Pabel Adria: ""Carrying on like what? If you want me to stop controllin..."*)

### Węzeł `[709]`
Mówca: **Narrator**
> "He opened his mouth in denial, then shut it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Pabel Adria: ""You're right. I will.""*)

### Węzeł `[710]`
Mówca: **Pabel Adria**
> ""You're right. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Anyway... it's quite an urgent phone call.""*)

### Węzeł `[711]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all right. Your secret is still safe with me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true` AND `Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Kontekst wejściowy (poprzednik):** `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Narrator: "Pabel breathed a sigh of relief."*)

### Węzeł `[712]`
Mówca: **Narrator**
> "Pabel breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Pabel Adria: ""Thank you, {RiziaDLCText.PabelToPlayer}. I won't forget ..."*)

### Węzeł `[713]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what you do after hours. But you've got to be more careful.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Kontekst wejściowy (poprzednik):** `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedEarly == false"*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedEarly == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedEarly == false"*)
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_OutedEarly == false)"*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedEarly == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Pabel Adria: ""I don't know what you're talking about, Your Majesty. I ..."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_OutedEarly == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Narrator: "He opened his mouth in denial, then shut it."*)

### Węzeł `[717]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, Pabel. I couldn't leave any stone unturned.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Kontekst wejściowy (poprzednik):** `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedEarly == true"*)

### Węzeł `[718]`
Mówca: **Pabel Adria**
> ""Well, it's been turned now. Am I under arrest?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Player_Romus: ""No. And the very possibility is ridiculous.""*)
  - -> `[729]` (*Player_Romus: ""You would be if there was more evidence. Consider yourse..."*)
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[719]`
Mówca: **Narrator**
> "Pabel sighed regretfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Pabel Adria: ""Well, it's been turned now. Am I under arrest?""*)

### Węzeł `[720]`
Mówca: **Pabel Adria**
> ""Well, now you know. I was conducting a tasting session with a Cantuavo representative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Player_Romus: ""If you say so.""*)
  - -> `[698]` (*Player_Romus: ""Right. I bet I can guess what you were tasting.""*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedEarly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedEarly == true"*)
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_OutedEarly == true)"*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedEarly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Narrator: "Pabel sighed regretfully."*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_OutedEarly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Pabel Adria: ""Well, now you know. I was conducting a tasting session w..."*)

### Węzeł `[724]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's nothing personal. I couldn't make it look like I was playing favorites.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Narrator: "Pabel sighed."*)

### Węzeł `[725]`
Mówca: **Narrator**
> "Pabel sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Pabel Adria: ""You're lucky they didn't turn up anything on the two of ..."*)

### Węzeł `[726]`
Mówca: **Pabel Adria**
> ""You're lucky they didn't turn up anything on the two of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""I can't stop thinking about our night together.""*)
  - -> `[62]` (*Player_Romus: ""When can we see each other again? And by 'see', I mean...""*)

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you say so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[705]` (Pabel Adria), `[720]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Anyway... it's quite an urgent phone call.""*)

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. And the very possibility is ridiculous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[718]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Pabel Adria: ""I'm glad you feel that way.""*)

### Węzeł `[729]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You would be if there was more evidence. Consider yourself lucky.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[718]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Pabel Adria: ""Believe me, I do. Nothing like this will happen again.""*)

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but the Lord knows what you did.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[718]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Pabel Adria: ""I... I have repented since then. I swear.""*)

### Węzeł `[731]`
Mówca: **Pabel Adria**
> ""I'm glad you feel that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Anyway... it's quite an urgent phone call.""*)

### Węzeł `[732]`
Mówca: **Pabel Adria**
> ""Believe me, I do. Nothing like this will happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Anyway... it's quite an urgent phone call.""*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Player_Romus: ""No, but the Lord knows what you did.""*)

### Węzeł `[735]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[736]`
Mówca: **Pabel Adria**
> ""I... I have repented since then. I swear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 3"*)

### Węzeł `[737]`
Mówca: **Pabel Adria**
> ""Carrying on like what? If you want me to stop controlling the quality of the palace wine, I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 3"*)

### Węzeł `[738]`
Mówca: **Pabel Adria**
> ""Anyway... it's quite an urgent phone call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Once I was dressed, we walked through the palace corridor..."*)

### Węzeł `[739]`
Mówca: **Pabel Adria**
> ""Wine, {RiziaDLCText.PabelToPlayer}. Not a difficult guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 2"*)

### Węzeł `[740]`
Mówca: **Pabel Adria**
> ""Thank you, {RiziaDLCText.PabelToPlayer}. I won't forget this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[741]` (*Player_Romus: ""It's ludicrous. If it were a woman, you'd get a slap on ..."*)
  - -> `[742]` (*Player_Romus: ""How many of you are out there?""*)

### Węzeł `[741]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's ludicrous. If it were a woman, you'd get a slap on the wrist at worst. But a man...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[740]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Pabel Adria: ""It is what it is.""*)

### Węzeł `[742]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How many of you are out there?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[740]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Pabel Adria: ""More than you would think.""*)

### Węzeł `[743]`
Mówca: **Pabel Adria**
> ""It is what it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Narrator: "He finished tying my robe."*)

### Węzeł `[744]`
Mówca: **Pabel Adria**
> ""More than you would think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Narrator: "He finished tying my robe."*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[747]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot order me around, Chancellor. Be more mindful of your words of choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Emmerich Hegel (R): ""Apologies.""*)

### Węzeł `[748]`
Mówca: **Emmerich Hegel (R)**
> ""Apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Emmerich Hegel (R): ""At the end of the day, I am only asking Rizia to act in ..."*)

### Węzeł `[749]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita is on your trail, though. Don't do anything stupid. Or anyone.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[740]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Pabel Adria: ""I won't. Thank you for telling me.""*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Player_Romus: ""Lucita is on your trail, though. Don't do anything stupi..."*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Player_Romus: ""Titus is on your trail, though. Don't do anything stupid..."*)

### Węzeł `[753]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus is on your trail, though. Don't do anything stupid. Or anyone.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[740]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Pabel Adria: ""I won't. Thank you for telling me.""*)

### Węzeł `[754]`
Mówca: **Pabel Adria**
> ""I won't. Thank you for telling me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Narrator: "He finished tying my robe."*)

### Węzeł `[755]`
Mówca: **Narrator**
> "He finished tying my robe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Anyway... it's quite an urgent phone call.""*)

### Węzeł `[756]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedEarly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedEarly == true"*)
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_OutedEarly == true)"*)

### Węzeł `[757]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedEarly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Player_Romus: ""It's all right. Your secret is still safe with me.""*)

### Węzeł `[758]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_OutedEarly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Player_Romus: ""It's all right. Your secret is safe with me.""*)

### Węzeł `[759]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all right. Your secret is safe with me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true) == false` AND `Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Kontekst wejściowy (poprzednik):** `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Narrator: "Pabel breathed a sigh of relief."*)

### Węzeł `[760]`
Mówca: **Narrator**
> "His face turned pale."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 3"*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "In the middle of the night, I was woken up by a knock on ..."*)

### Węzeł `[762]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn05_G_ValgslandANSupport = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn05_G_ValgslandANSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)

### Węzeł `[763]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[764]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn05_G_ValgslandANSupport = true;"*)

### Węzeł `[765]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)

### Węzeł `[766]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)
  - -> `[768]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_Nationalization == true)"*)

### Węzeł `[767]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn05_Morella_MITZ_Nationalizati..."*)

### Węzeł `[768]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn05_Morella_MITZ_Renegotiation..."*)

### Węzeł `[769]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn05_Morella_MITZ_NationalizationInvite = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn05_Morella_MITZ_NationalizationInvite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[770]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn05_Morella_MITZ_RenegotiationInvite = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn05_Morella_MITZ_RenegotiationInvite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");
RemoveConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");
RemoveConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "An attendant stood ready with the blue phone. He informed..."*)

### Węzeł `[772]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Pabel Adria: ""I don't know what you're talking about, Your Majesty. I ..."*)

### Węzeł `[773]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Anyway... it's quite an urgent phone call.""*)

### Węzeł `[774]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Anyway... it's quite an urgent phone call.""*)

### Węzeł `[775]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Anyway... it's quite an urgent phone call.""*)

### Węzeł `[776]`
Mówca: **Bruno**
> ""Rrrruff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "I heard Pabel's voice in the hallway."*)

### Węzeł `[777]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hegel_OpenToRevolution = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hegel_OpenToRevolution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Emmerich Hegel (R): ""Good night.""*)

### Węzeł `[778]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Taking a late-night call from Valgsland’s Chancellor Hegel", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Taking a late-night call from Valgsland’s Chancellor Hegel","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");"*)

### Węzeł `[779]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Pabel Adria: ""You investigated me? I told you I was innocent.""*)
