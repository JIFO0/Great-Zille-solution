# Sordland/Turn07/A_Autocrat_CourtDecision

- **ID konwersacji:** `139`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/139_A_Autocrat_CourtDecision.md`
- **Liczba węzłów dialogowych:** 395
- **Liczba wyborów gracza:** 114

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno
- **[56]** Karl Greiser
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Autocrat_YoungSords_NFP_Deal`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn05_AutocratEmergency_Revoke`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Order_Authority`
- `BaseGame.Policy_Order_DetentionWithoutTrial`
- `BaseGame.Policy_Order_SuspendedProtests`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_Emergency_StartInvestigations`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_SecretState_ThreatenCourt`
- `BaseGame.Reform_Turn07_Emergency_Detained_Frens`
- `BaseGame.Reform_Turn07_Emergency_Detained_Journalists`
- `BaseGame.Situation_Order_CrimeWave`
- `BaseGame.Situation_Order_OrganisedCrime`
- `BaseGame.Situation_Order_OrganisedCrimeContained`
- `BaseGame.Situation_Order_ReductionOfCrimeCommunities`
- `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.YoungSords_Kill_OrsoHawker`
- `BaseGameSupport.Codex_Characters_PartyLeaders_FrensRicter_Detained`
- `BaseGameSupport.Journal_Turn07_CourtDecision_DetainFrens`
- `BaseGameSupport.Journal_Turn07_CourtDecision_Illegal`
- `BaseGameSupport.Journal_Turn07_CourtDecision_Invalid`
- `BaseGameSupport.Journal_Turn07_CourtDecision_KillOrso`
- `BaseGameSupport.Journal_Turn07_CourtDecision_OppositionInvestigations`
- `BaseGameSupport.Journal_Turn07_CourtDecision_OppositionJournalists`
- `BaseGameSupport.Journal_Turn07_CourtDecision_ThreatenCourt`
- `BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder`
- `BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Extended`
- `BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Revoked`
- `BaseGameSupport.News_Turn07_HP_CourtForEmergency`
- `BaseGameSupport.News_Turn07_R_CourtForEmergency`
- `BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_Deal`
- `BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_NoDeal`
- `BaseGameSupport.Report_Turn07_Holsord_CelebratingRevocation`
- `BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt`
- `BaseGameSupport.Report_Turn07_Holsord_PFJPCongratulatesCourt`
- `GameCondition.Turn07_A_Autocrat_CourtDecision`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Yes. I have to.""** | `[5]` **Petr Vectern**: ""Do you trust Orso Hawker?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: ""I just hope he holds up his end..."<br>`[221]` **Petr Vectern**: ""I can't believe this... You did..." |
| `[8]` | **""No.""** | `[5]` **Petr Vectern**: ""Do you trust Orso Hawker?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Petr Vectern**: ""So... You expect your decree to..."<br>`[217]` **Petr Vectern**: ""So... You expect an actual tria..." |
| `[9]` | **""Absolutely not.""** | `[5]` **Petr Vectern**: ""Do you trust Orso Hawker?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Petr Vectern**: ""So... You expect your decree to..."<br>`[217]` **Petr Vectern**: ""So... You expect an actual tria..." |
| `[10]` | **""I know that he will not make a mistake.""** | `[5]` **Petr Vectern**: ""Do you trust Orso Hawker?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Petr Vectern**: ""So... You believe the Court wil..." |
| `[14]` | **""Unfortunately, it seems that way.""** | `[12]` **Petr Vectern**: ""So... You expect your decree to..."<br>`[217]` **Petr Vectern**: ""So... You expect an actual tria..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: ""I just hope he holds up his end..."<br>`[221]` **Petr Vectern**: ""I can't believe this... You did..." |
| `[15]` | **""I have to be prepared for the worst.""** | `[12]` **Petr Vectern**: ""So... You expect your decree to..."<br>`[13]` **Petr Vectern**: ""So... You believe the Court wil..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: ""I just hope he holds up his end..."<br>`[221]` **Petr Vectern**: ""I can't believe this... You did..." |
| `[16]` | **""No, the Court cannot afford to do that.""** | `[12]` **Petr Vectern**: ""So... You expect your decree to..."<br>`[217]` **Petr Vectern**: ""So... You expect an actual tria..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: ""I just hope he holds up his end..."<br>`[221]` **Petr Vectern**: ""I can't believe this... You did..." |
| `[17]` | **""Yes. They can't afford to do that.""** | `[13]` **Petr Vectern**: ""So... You believe the Court wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: ""I just hope he holds up his end..."<br>`[221]` **Petr Vectern**: ""I can't believe this... You did..." |
| `[18]` | **""I have to hope for the best.""** | `[13]` **Petr Vectern**: ""So... You believe the Court wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: ""I just hope he holds up his end..."<br>`[221]` **Petr Vectern**: ""I can't believe this... You did..." |
| `[21]` | **""Of course we can.""** | `[20]` **Petr Vectern**: ""We can't face that...""<br>`[223]` **Petr Vectern**: ""We can't face a negative outcom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Petr Vectern**: ""I hope so, Anton."" |
| `[22]` | **""I know Petr. I know.""** | `[20]` **Petr Vectern**: ""We can't face that...""<br>`[223]` **Petr Vectern**: ""We can't face a negative outcom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "Petr looked at me and then conti..." |
| `[23]` | **""Stop whining.""** | `[20]` **Petr Vectern**: ""We can't face that...""<br>`[223]` **Petr Vectern**: ""We can't face a negative outcom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "Petr looked at me and then conti..." |
| `[24]` | **""What do we do?""** | `[20]` **Petr Vectern**: ""We can't face that...""<br>`[223]` **Petr Vectern**: ""We can't face a negative outcom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Petr Vectern**: ""Well... I don't know. People ar..."<br>`[227]` **Petr Vectern**: ""Well... I don't know. The emerg..." |
| `[41]` | **""What are you saying, Petr?""** | `[39]` **Petr Vectern**: ""Malenyevism is on the increase ..."<br>`[40]` **Petr Vectern**: ""Sordish nationalism is on the r..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Petr Vectern**: ""Maybe cooperating with the Old ..." |
| `[42]` | **""Stop grumbling for once.""** | `[39]` **Petr Vectern**: ""Malenyevism is on the increase ..."<br>`[40]` **Petr Vectern**: ""Sordish nationalism is on the r..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Petr Vectern**: ""I'm sorry."" |
| `[43]` | **""Yes, I'm afraid this decree was a bad idea.""** | `[39]` **Petr Vectern**: ""Malenyevism is on the increase ..."<br>`[40]` **Petr Vectern**: ""Sordish nationalism is on the r..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Petr Vectern**: ""We must think about ways of boo..." |
| `[44]` | **""We'll get through it, Petr.""** | `[39]` **Petr Vectern**: ""Malenyevism is on the increase ..."<br>`[40]` **Petr Vectern**: ""Sordish nationalism is on the r..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Petr Vectern**: ""I wish I could be as hopeful as..." |
| `[61]` | **""That's good news.""** | `[60]` **Petr Vectern**: ""Thank God!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Lucian Galade**: ""Now we can start thinking about..."<br>`[244]` **Lucian Galade**: ""Now we can start thinking about..." |
| `[62]` | **""I knew they wouldn't do it.""** | `[60]` **Petr Vectern**: ""Thank God!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Lucian Galade**: ""Now we can start thinking about..."<br>`[244]` **Lucian Galade**: ""Now we can start thinking about..." |
| `[63]` | **""We have no obstacles left now.""** | `[60]` **Petr Vectern**: ""Thank God!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Lucian Galade**: ""Now we can start thinking about..."<br>`[244]` **Lucian Galade**: ""Now we can start thinking about..." |
| `[64]` | **""That will show Frens who he's messing with.""** | `[60]` **Petr Vectern**: ""Thank God!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Lucian Galade**: ""Now we can start thinking about..."<br>`[244]` **Lucian Galade**: ""Now we can start thinking about..." |
| `[66]` | **""What are we going to do?""** | `[59]` **Petr Vectern**: ""What!?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lucian Galade**: ""This decree has done a lot of d..." |
| `[67]` | **""I am fucked.""** | `[59]` **Petr Vectern**: ""What!?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lucian Galade**: ""This decree has done a lot of d..." |
| `[68]` | **""Well... We must respect the decision.""** | `[59]` **Petr Vectern**: ""What!?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: ""There is no alternative either ..." |
| `[69]` | **""Damn the court!""** | `[59]` **Petr Vectern**: ""What!?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lucian Galade**: ""This decree has done a lot of d..." |
| `[74]` | **"Answer it."** | `[73]` **Narrator**: "The phone rang." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Orso Hawker**: ""How are you doing, Mr. President?"" |
| `[75]` | **"Ignore the phone."** | `[73]` **Narrator**: "The phone rang." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Narrator**: "Lucian looked at me." |
| `[77]` | **""I'm doing fine.""** | `[76]` **Orso Hawker**: ""How are you doing, Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Orso Hawker**: ""That's great to hear."" |
| `[78]` | **""You made a big mistake.""** | `[76]` **Orso Hawker**: ""How are you doing, Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Orso Hawker**: ""I told you not to go against th..." |
| `[79]` | **""You damn bastard.""** | `[76]` **Orso Hawker**: ""How are you doing, Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Orso Hawker**: ""I told you not to go against th..." |
| `[80]` | **"Hang up."** | `[76]` **Orso Hawker**: ""How are you doing, Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Narrator**: "Lucian looked at me." |
| `[86]` | **""Come on, Mr. Hawker. Don't do this.""** | `[85]` **Orso Hawker**: ""I wanted to give you the proper..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Orso Hawker**: ""Have a good day, Mr. President."" |
| `[87]` | **""I will have your head!""** | `[85]` **Orso Hawker**: ""I wanted to give you the proper..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Orso Hawker**: ""Have a good day, Mr. President."" |
| `[88]` | **""Don't you dare!""** | `[85]` **Orso Hawker**: ""I wanted to give you the proper..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Orso Hawker**: ""Have a good day, Mr. President."" |
| `[89]` | **""Fuck you, Mr. Hawker.""** | `[85]` **Orso Hawker**: ""I wanted to give you the proper..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Orso Hawker**: ""Have a good day, Mr. President."" |
| `[93]` | **""They are opening investigations against me.""** | `[92]` **Lucian Galade**: ""Was it the Chief Justice? What ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Petr Vectern**: ""Oh..."" |
| `[94]` | **""I am screwed. They are investigating me.""** | `[92]` **Lucian Galade**: ""Was it the Chief Justice? What ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Petr Vectern**: ""Oh..."" |
| `[95]` | **""Yes. He's going to be a problem.""** | `[92]` **Lucian Galade**: ""Was it the Chief Justice? What ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Petr Vectern**: ""I mean... He has always been a ..." |
| `[96]` | **""Fuck him!""** | `[92]` **Lucian Galade**: ""Was it the Chief Justice? What ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Petr Vectern**: ""Anton. Calm down."" |
| `[105]` | **""You're right. I have complete trust in you guys.""** | `[104]` **Lucian Galade**: ""In the meantime, let's stay foc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Lucian Galade**: ""We'll do our best."" |
| `[106]` | **""We'll get through it.""** | `[104]` **Lucian Galade**: ""In the meantime, let's stay foc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Lucian Galade**: ""We'll do our best."" |
| `[107]` | **""I need to fix my image.""** | `[104]` **Lucian Galade**: ""In the meantime, let's stay foc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Lucian Galade**: ""We'll need a proper plan for th..." |
| `[111]` | **""No. Orso will pay. I'll involve Mr. Greiser.""** | `[104]` **Lucian Galade**: ""In the meantime, let's stay foc..." | `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true` | *Brak zmian stanu* | `[112]` **Lucian Galade**: ""Sir? What do you have in mind?"" |
| `[119]` | **""This sucks.""** | `[118]` **Narrator**: "They both left the room and I co..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Faction_OldGuard_Content"] = false;`<br>`Variable["BaseGameSupport.News_Turn07_HP_CourtForEmergenc...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[120]` | **""I'll fix this.""** | `[118]` **Narrator**: "They both left the room and I co..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Faction_OldGuard_Content"] = false;`<br>`Variable["BaseGameSupport.News_Turn07_HP_CourtForEmergenc...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[121]` | **""Bollocks.""** | `[118]` **Narrator**: "They both left the room and I co..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Faction_OldGuard_Content"] = false;`<br>`Variable["BaseGameSupport.News_Turn07_HP_CourtForEmergenc...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[122]` | **""We need to silence the Court. They need to be given a lesson.""** | `[113]` **Narrator**: "He had a worried face."<br>`[351]` **Narrator**: "He had a worried face." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Lucian Galade**: ""I don't know what you have in m..." |
| `[123]` | **""It's fine Lucian. I just need to talk to Karl.""** | `[113]` **Narrator**: "He had a worried face." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Lucian Galade**: ""As you wish, sir."" |
| `[125]` | **"Call Karl Greiser."** | `[259]` **Narrator**: "They left the room." | `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true` | *Brak zmian stanu* | `[127]` **Narrator**: "After a few seconds of ringing, ..." |
| `[126]` | **""You're right. We can't act so extreme.""** | `[124]` **Lucian Galade**: ""I don't know what you have in m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Lucian Galade**: ""We'll need a proper plan for th..." |
| `[129]` | **""Hello Karl, it's the President.""** | `[128]` **Karl Greiser**: ""This is Karl Greiser speaking."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Karl Greiser**: ""I am at your command, sir! How ..." |
| `[130]` | **""Hi Karl, it's me.""** | `[128]` **Karl Greiser**: ""This is Karl Greiser speaking."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Karl Greiser**: ""I am at your command, sir! How ..." |
| `[131]` | **""I need you to fix a problem.""** | `[128]` **Karl Greiser**: ""This is Karl Greiser speaking."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Karl Greiser**: ""Of course, sir. I am at your co..." |
| `[134]` | **""Can we get rid of Orso Hawker?""** | `[132]` **Karl Greiser**: ""Of course, sir. I am at your co..."<br>`[133]` **Karl Greiser**: ""I am at your command, sir! How ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Karl Greiser**: ""You want him completely *gone*?"" |
| `[135]` | **""I need the Court Justices to be taught a lesson, so they'd know their place.""** | `[132]` **Karl Greiser**: ""Of course, sir. I am at your co..."<br>`[133]` **Karl Greiser**: ""I am at your command, sir! How ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Karl Greiser**: ""You want them scared off, sir?"" |
| `[137]` | **""Yes. Scare them off by any means necessary. Convince them.""** | `[136]` **Karl Greiser**: ""You want them scared off, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Karl Greiser**: ""As you wish, sir. I'll give the..." |
| `[138]` | **""Threaten them, beat them, do whatever you want.""** | `[136]` **Karl Greiser**: ""You want them scared off, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Karl Greiser**: ""As you wish, sir. I'll give the..." |
| `[139]` | **""No. Maybe we can't be so reckless.""** | `[136]` **Karl Greiser**: ""You want them scared off, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Karl Greiser**: ""Do you have anything else in mi..." |
| `[141]` | **""Thank you.""** | `[140]` **Karl Greiser**: ""As you wish, sir. I'll give the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Karl Greiser**: ""Consider it done. Have a good d..." |
| `[142]` | **""Teach them a lesson.""** | `[140]` **Karl Greiser**: ""As you wish, sir. I'll give the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Karl Greiser**: ""Consider it done. Have a good d..." |
| `[144]` | **""No, I've changed my mind, Karl. Good day to you.""** | `[143]` **Karl Greiser**: ""Do you have anything else in mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Karl Greiser**: ""Understood, sir. Have a good day."" |
| `[148]` | **""His time has come.""** | `[147]` **Karl Greiser**: ""You want him completely *gone*?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Karl Greiser**: ""I see."" |
| `[149]` | **""Yes. This will teach everyone a lesson.""** | `[147]` **Karl Greiser**: ""You want him completely *gone*?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Karl Greiser**: ""I see."" |
| `[150]` | **""Can you do it?""** | `[147]` **Karl Greiser**: ""You want him completely *gone*?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Karl Greiser**: ""If that's the order, sir, of co..." |
| `[154]` | **""Yes. Make sure it's done.""** | `[153]` **Karl Greiser**: ""Are you giving me full approval..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Karl Greiser**: ""As you wish, sir. I'll execute ..." |
| `[155]` | **""No. I've changed my mind. Maybe we shouldn't be so reckless.""** | `[153]` **Karl Greiser**: ""Are you giving me full approval..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Karl Greiser**: ""I understand, sir."" |
| `[163]` | **""Let's wait it out. If the worst happens the police would take care of it.""** | `[162]` **Petr Vectern**: ""It is really irresponsible of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Lucian Galade**: ""Understood. I will be ready."" |
| `[164]` | **""We should target the journalists that stir up unrest.""** | `[162]` **Petr Vectern**: ""It is really irresponsible of t..."<br>`[191]` **Lucian Galade**: ""Yes, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Lucian Galade**: ""You want them detained?""<br>`[175]` **Lucian Galade**: ""Understood. I'll reach out to m..." |
| `[165]` | **""It's time to detain Frens Ricter.""** | `[162]` **Petr Vectern**: ""It is really irresponsible of t..."<br>`[191]` **Lucian Galade**: ""Yes, sir?"" | `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true` | *Brak zmian stanu* | `[182]` **Lucian Galade**: ""Are we really doing this? We st..." |
| `[170]` | **""We'll start investigations against the opposition leaders.""** | `[162]` **Petr Vectern**: ""It is really irresponsible of t..."<br>`[191]` **Lucian Galade**: ""Yes, sir?"" | `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false` | *Brak zmian stanu* | `[180]` **Lucian Galade**: ""As you wish, sir. I'll make the..." |
| `[176]` | **""Detain journalists who have given support to the opposition.""** | `[171]` **Lucian Galade**: ""You want them detained?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Journ...`<br>`Variable["BaseGameSupport.Journal_Turn07_CourtDecision_Op...` | `[179]` **Lucian Galade**: ""As you wish, sir. I'll make the..." |
| `[177]` | **""No. Just reach out to our connections in media to censor the opposition.""** | `[171]` **Lucian Galade**: ""You want them detained?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Lucian Galade**: ""Understood. I'll reach out to m..." |
| `[185]` | **""He will pay. Take him down.""** | `[184]` **Lucian Galade**: ""We can justify his arrest. And ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Lucian Galade**: ""As you wish, sir. I'll make the..." |
| `[186]` | **""Give the order of his arrest.""** | `[184]` **Lucian Galade**: ""We can justify his arrest. And ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Lucian Galade**: ""As you wish, sir. I'll make the..." |
| `[187]` | **""I've changed my mind. Maybe we shouldn't be so reckless.""** | `[184]` **Lucian Galade**: ""We can justify his arrest. And ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Lucian Galade**: ""Understood. I will be ready."" |
| `[189]` | **""Thank you gentlemen, I'll see you later.""** | `[188]` **Lucian Galade**: ""If there's nothing else, let's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Lucian Galade**: ""Have a good day, sir."" |
| `[190]` | **""Before we go... I want to think about some measures again.""** | `[188]` **Lucian Galade**: ""If there's nothing else, let's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Lucian Galade**: ""Yes, sir?"" |
| `[192]` | **""Never mind. Let's just focus the task at hand.""** | `[191]` **Lucian Galade**: ""Yes, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Lucian Galade**: ""Of course, sir."" |
| `[246]` | **""Great. You have my trust, Lucian.""** | `[245]` **Lucian Galade**: ""I'll arrange a cabinet meeting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Lucian Galade**: ""Yes sir."" |
| `[247]` | **""The quicker we get together, the better.""** | `[245]` **Lucian Galade**: ""I'll arrange a cabinet meeting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Lucian Galade**: ""Yes sir."" |
| `[248]` | **""I believe the concerns are overexaggerated.""** | `[245]` **Lucian Galade**: ""I'll arrange a cabinet meeting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Lucian Galade**: ""With all due respect, I disagre..." |
| `[258]` | **""Let's finish the meeting here. I'll make a short phone call.""** | `[124]` **Lucian Galade**: ""I don't know what you have in m..."<br>`[257]` **Lucian Galade**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Narrator**: "They left the room." |
| `[261]` | **""It's okay, Livia. What happened?""** | `[260]` **Livia Suno**: ""Good day to you, Mr. President...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Livia Suno**: ""The Chief Justice has sent you ..." |
| `[262]` | **""Yes, you are. What is it?""** | `[260]` **Livia Suno**: ""Good day to you, Mr. President...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Livia Suno**: ""The Chief Justice has sent you ..." |
| `[263]` | **""No. Please come in. Is there a problem?""** | `[260]` **Livia Suno**: ""Good day to you, Mr. President...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Livia Suno**: ""The Chief Justice has sent you ..." |
| `[264]` | **""Thanks, Livia. You may go now.""** | `[288]` **Narrator**: "I turned to Livia." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "Livia turned to leave." |
| `[265]` | **""Damn Orso...""** | `[281]` **Petr Vectern**: ""Oh... A nice present."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Petr Vectern**: ""Victory will be close, huh? Ors..." |
| `[266]` | **""Yeah. A picture of Tarquin Soll. What a nice present!""** | `[281]` **Petr Vectern**: ""Oh... A nice present."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Petr Vectern**: ""Victory will be close, huh? Ors..." |
| `[270]` | **""This must be some kind of a message.""** | `[281]` **Petr Vectern**: ""Oh... A nice present."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Petr Vectern**: ""Victory will be close, huh? Ors..." |
| `[273]` | **""Thank you, Livia. You can leave it on my table.""** | `[272]` **Narrator**: "She showed me the wrapped object." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Livia Suno**: ""Yes, sir."" |
| `[274]` | **""Really? From Orso Hawker? Bring it here.""** | `[272]` **Narrator**: "She showed me the wrapped object." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Livia Suno**: ""Yes, sir."" |
| `[275]` | **""What is it?""** | `[272]` **Narrator**: "She showed me the wrapped object." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Livia Suno**: ""I don't know... A picture?"" |
| `[280]` | **""What do you think?""** | `[281]` **Petr Vectern**: ""Oh... A nice present."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Petr Vectern**: ""Victory will be close, huh? Ors..." |
| `[285]` | **""Did Orso say anything to you about this?""** | `[288]` **Narrator**: "I turned to Livia." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Livia Suno**: ""No, but he's obviously trying t..." |
| `[290]` | **""What do you think this means, Livia?""** | `[288]` **Narrator**: "I turned to Livia." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Livia Suno**: ""He's obviously trying to send y..." |
| `[349]` | **""No. Orso will pay. I'll involve... a group of *fixers.*""** | `[104]` **Lucian Galade**: ""In the meantime, let's stay foc..." | `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true` | *Brak zmian stanu* | `[350]` **Lucian Galade**: ""Sir? What do you have in mind?"" |
| `[352]` | **""It's fine, Lucian. I just need to make a phone call.""** | `[351]` **Narrator**: "He had a worried face." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Lucian Galade**: ""As you wish, sir."" |
| `[359]` | **"Call Remus Holstron."** | `[259]` **Narrator**: "They left the room." | `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true` | *Brak zmian stanu* | `[360]` **Narrator**: "After a few seconds of ringing, ..." |
| `[361]` | **""This is the president speaking.""** | `[360]` **Narrator**: "After a few seconds of ringing, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Remus Holstron**: ""Oh, Mr. President! How can I he..." |
| `[362]` | **""Hi, Mr. Holstron, it's me.""** | `[360]` **Narrator**: "After a few seconds of ringing, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Remus Holstron**: ""Oh, Mr. President! How can I he..." |
| `[363]` | **""I need you to fix a problem.""** | `[360]` **Narrator**: "After a few seconds of ringing, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Remus Holstron**: ""Tell me. What is the issue?"" |
| `[366]` | **""Can you get rid of Orso Hawker?""** | `[364]` **Remus Holstron**: ""Tell me. What is the issue?""<br>`[365]` **Remus Holstron**: ""Oh, Mr. President! How can I he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[378]` **Remus Holstron**: ""I see. He stepped on your toes ..." |
| `[367]` | **""I need the Court Justices to be taught a lesson. I want them to know their place.""** | `[364]` **Remus Holstron**: ""Tell me. What is the issue?""<br>`[365]` **Remus Holstron**: ""Oh, Mr. President! How can I he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Remus Holstron**: ""I see. They are stepping on you..." |
| `[369]` | **""Yes. Scare them off by any means necessary. Convince them.""** | `[368]` **Remus Holstron**: ""I see. They are stepping on you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Remus Holstron**: ""I don't know if it will work. B..." |
| `[370]` | **""Threaten them, beat them, do whatever you want.""** | `[368]` **Remus Holstron**: ""I see. They are stepping on you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Remus Holstron**: ""I don't know if it will work. B..." |
| `[371]` | **""No. Maybe we can't be so reckless.""** | `[368]` **Remus Holstron**: ""I see. They are stepping on you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Remus Holstron**: ""Do you have anything else in mi..." |
| `[373]` | **""Thank you.""** | `[372]` **Remus Holstron**: ""I don't know if it will work. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Remus Holstron**: ""Sure. Have a good day."" |
| `[374]` | **""Teach them a lesson.""** | `[372]` **Remus Holstron**: ""I don't know if it will work. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Remus Holstron**: ""Sure. Have a good day."" |
| `[376]` | **""No, I've changed my mind. Good day to you.""** | `[375]` **Remus Holstron**: ""Do you have anything else in mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Remus Holstron**: ""I understand. Next time, call m..." |
| `[379]` | **""His time has come.""** | `[378]` **Remus Holstron**: ""I see. He stepped on your toes ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Remus Holstron**: ""I'll talk to my people. See wha..." |
| `[380]` | **""Yes. This will teach everyone a lesson.""** | `[378]` **Remus Holstron**: ""I see. He stepped on your toes ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Remus Holstron**: ""I'll talk to my people. See wha..." |
| `[381]` | **""Can you do it?""** | `[378]` **Remus Holstron**: ""I see. He stepped on your toes ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Remus Holstron**: ""I'll talk to my people. See wha..." |
| `[383]` | **""No. I've changed my mind. Maybe we shouldn't be so reckless.""** | `[386]` **Remus Holstron**: ""Are you giving me full approval..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Remus Holstron**: ""I understand. Next time, call m..." |
| `[384]` | **""Yes. Make sure it's done.""** | `[386]` **Remus Holstron**: ""Are you giving me full approval..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Remus Holstron**: ""Understood."" |

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
  - -> `[3]` (*Narrator: "I was eagerly waiting for the decision of the Supreme Cou..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was eagerly waiting for the decision of the Supreme Court regarding the Emergency Act. I stood up from my chair and looked out the window in my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Petr was with me too. He was slouching on the couch at th..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Yes. I have to.""]** — Mówca: **Player**
> ""Yes. I have to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[5]`
Mówca: **Petr Vectern**
> ""Do you trust Orso Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Yes. I have to.""*)
  - -> `[8]` (*Player: ""No.""*)
  - -> `[9]` (*Player: ""Absolutely not.""*)
  - -> `[10]` (*Player: ""I know that he will not make a mistake.""*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Petr was with me too. He was slouching on the couch at the right side of the office and staring at the ceiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Livia Suno: ""Good day to you, Mr. President. Am I interrupting anythi..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "The emergency decree was tough on all of my team. We were constantly battling with an opposition against our security measures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""No.""]** — Mówca: **Player**
> ""No.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Absolutely not.""]** — Mówca: **Player**
> ""Absolutely not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""I know that he will not make a mistake.""]** — Mówca: **Player**
> ""I know that he will not make a mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""So... You believe the Court will not push this to the end?""*)

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""I just hope he holds up his end of the bargain...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: ""If they declare it unconstitutional, they may potentiall..."*)

### Węzeł `[12]`
Mówca: **Petr Vectern**
> ""So... You expect your decree to be declared invalid?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Unfortunately, it seems that way.""*)
  - -> `[16]` (*Player: ""No, the Court cannot afford to do that.""*)
  - -> `[15]` (*Player: ""I have to be prepared for the worst.""*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""So... You believe the Court will not push this to the end?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""I have to be prepared for the worst.""*)
  - -> `[17]` (*Player: ""Yes. They can't afford to do that.""*)
  - -> `[18]` (*Player: ""I have to hope for the best.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Unfortunately, it seems that way.""]** — Mówca: **Player**
> ""Unfortunately, it seems that way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Petr Vectern), `[217]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I have to be prepared for the worst.""]** — Mówca: **Player**
> ""I have to be prepared for the worst.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Petr Vectern), `[13]` (Petr Vectern), `[217]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""No, the Court cannot afford to do that.""]** — Mówca: **Player**
> ""No, the Court cannot afford to do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Petr Vectern), `[217]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""Yes. They can't afford to do that.""]** — Mówca: **Player**
> ""Yes. They can't afford to do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I have to hope for the best.""]** — Mówca: **Player**
> ""I have to hope for the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""If they declare it unconstitutional, they may potentially try to go against you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: ""We can't face that...""*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""We can't face that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Of course we can.""*)
  - -> `[22]` (*Player: ""I know Petr. I know.""*)
  - -> `[23]` (*Player: ""Stop whining.""*)
  - -> `[24]` (*Player: ""What do we do?""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Of course we can.""]** — Mówca: **Player**
> ""Of course we can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Petr Vectern), `[223]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Petr Vectern: ""I hope so, Anton.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I know Petr. I know.""]** — Mówca: **Player**
> ""I know Petr. I know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Petr Vectern), `[223]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Petr looked at me and then continued to stare at the ceil..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""Stop whining.""]** — Mówca: **Player**
> ""Stop whining.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Petr Vectern), `[223]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Petr looked at me and then continued to stare at the ceil..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""What do we do?""]** — Mówca: **Player**
> ""What do we do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Petr Vectern), `[223]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""Well... I don't know. People are uneasy with the current security measures and the opposition is growing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Petr Vectern: ""If the Court decides to side with them... You may lose s..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Petr looked at me and then continued to stare at the ceiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""I hope so, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Petr looked at me and then continued to stare at the ceil..."*)

### Węzeł `[28]`
Mówca: **Petr Vectern**
> ""If the Court decides to side with them... You may lose support from our party too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: ""You just cannot have the Court against you, Anton. There..."*)

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""You just cannot have the Court against you, Anton. There is no other way but to get them to your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Petr looked at me and then continued to stare at the ceil..."*)

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""But maybe this period has lasted too long already...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""The opposition within our party is also growing...""*)

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""The opposition within our party is also growing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: ""Bludish people are getting more discontent than ever... ..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""Bludish people are getting more discontent than ever... Bergia region is becoming increasingly volatile. The Aschraf anniversary will happen later this year; who knows how that will unfold?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Petr Vectern: ""Malenyevism is on the increase among the protesters. The..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Petr Vectern: ""Sordish nationalism is on the rise... Increased tensions..."*)

### Węzeł `[39]`
Mówca: **Petr Vectern**
> ""Malenyevism is on the increase among the protesters. The fights are continuing despite our security measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""We'll get through it, Petr.""*)
  - -> `[41]` (*Player: ""What are you saying, Petr?""*)
  - -> `[43]` (*Player: ""Yes, I'm afraid this decree was a bad idea.""*)
  - -> `[42]` (*Player: ""Stop grumbling for once.""*)

### Węzeł `[40]`
Mówca: **Petr Vectern**
> ""Sordish nationalism is on the rise... Increased tensions and violence are going on despite our security measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""We'll get through it, Petr.""*)
  - -> `[41]` (*Player: ""What are you saying, Petr?""*)
  - -> `[43]` (*Player: ""Yes, I'm afraid this decree was a bad idea.""*)
  - -> `[42]` (*Player: ""Stop grumbling for once.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""What are you saying, Petr?""]** — Mówca: **Player**
> ""What are you saying, Petr?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Petr Vectern), `[40]` (Petr Vectern), `[239]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Petr Vectern: ""Maybe cooperating with the Old Guard was a bad idea...""*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Stop grumbling for once.""]** — Mówca: **Player**
> ""Stop grumbling for once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Petr Vectern), `[40]` (Petr Vectern), `[239]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Petr Vectern: ""I'm sorry.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Yes, I'm afraid this decree was a bad idea.""]** — Mówca: **Player**
> ""Yes, I'm afraid this decree was a bad idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Petr Vectern), `[40]` (Petr Vectern), `[239]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Petr Vectern: ""We must think about ways of boosting your image...""*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""We'll get through it, Petr.""]** — Mówca: **Player**
> ""We'll get through it, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Petr Vectern), `[40]` (Petr Vectern), `[239]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Petr Vectern: ""I wish I could be as hopeful as you. But I really need s..."*)

### Węzeł `[45]`
Mówca: **Petr Vectern**
> ""I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[46]`
Mówca: **Petr Vectern**
> ""We must think about ways of boosting your image...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[47]`
Mówca: **Petr Vectern**
> ""Maybe cooperating with the Old Guard was a bad idea...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""I wish I could be as hopeful as you. But I really need something good to happen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("KnockDoor");"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Suddenly, we heard a knock on the door."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Suddenly, we heard a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "And immediately afterwards, Lucian rushed in, out of breath."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Suddenly, we heard a knock on the door. Lucian came inside and bowed his head slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: ""The Court has made its decision, sir.""*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""The Court has made its decision, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""They found the decree completely legal and ruled Mr. Ric..."*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""They found the decree completely legal and ruled Mr. Ricter's complaints invalid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Petr Vectern: ""Thank God!""*)

### Węzeł `[56]`
Mówca: **Narrator**
> "And immediately afterwards, Lucian rushed in, out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: ""The Court has made its decision, sir.""*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""The Court has made its decision, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""They declared the Emergency invalid and agreed with every complaint of Mr. Ricter regarding your actions being unconstitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree = false; BaseGame.Pol..."*)

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""What!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""What are we going to do?""*)
  - -> `[67]` (*Player: ""I am fucked.""*)
  - -> `[68]` (*Player: ""Well... We must respect the decision.""*)
  - -> `[69]` (*Player: ""Damn the court!""*)

### Węzeł `[60]`
Mówca: **Petr Vectern**
> ""Thank God!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""That's good news.""*)
  - -> `[62]` (*Player: ""I knew they wouldn't do it.""*)
  - -> `[63]` (*Player: ""We have no obstacles left now.""*)
  - -> `[64]` (*Player: ""That will show Frens who he's messing with.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""That's good news.""]** — Mówca: **Player**
> ""That's good news.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""I knew they wouldn't do it.""]** — Mówca: **Player**
> ""I knew they wouldn't do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We have no obstacles left now.""]** — Mówca: **Player**
> ""We have no obstacles left now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""That will show Frens who he's messing with.""]** — Mówca: **Player**
> ""That will show Frens who he's messing with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""Now we can start thinking about the opposition. They are starting to really provoke the people to go out and protest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Petr Vectern: ""It is really irresponsible of them to invite people to p..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""What are we going to do?""]** — Mówca: **Player**
> ""What are we going to do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""This decree has done a lot of damage. But we can still f..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I am fucked.""]** — Mówca: **Player**
> ""I am fucked.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""This decree has done a lot of damage. But we can still f..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Well... We must respect the decision.""]** — Mówca: **Player**
> ""Well... We must respect the decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""There is no alternative either way. However, this decree..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Damn the court!""]** — Mówca: **Player**
> ""Damn the court!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""This decree has done a lot of damage. But we can still f..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""There is no alternative either way. However, this decree has really damaged your popularity. If the Court sides with the opposition and pushes for it, they may actually impeach you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRing");"*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""This decree has done a lot of damage. But we can still figure something out to increase the support behind you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""We have to make sure the Court does not push on investig..."*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""We have to make sure the Court does not push on investigating Mr. Ricter's claims. This can lead to further chaos and theoretically to your impeachment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRing");"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The phone rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhonePickUp");"*)
  - -> `[75]` (*Player_Italic: "Ignore the phone."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "Answer it."]** — Mówca: **Player_Italic**
> "I answered the phone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Orso Hawker: ""How are you doing, Mr. President?""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "Ignore the phone."]** — Mówca: **Player_Italic**
> "I ignored the phone and let it ring until it came to a stop."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Lucian looked at me."*)

### Węzeł `[76]`
Mówca: **Orso Hawker**
> ""How are you doing, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I'm doing fine.""*)
  - -> `[78]` (*Player: ""You made a big mistake.""*)
  - -> `[79]` (*Player: ""You damn bastard.""*)
  - -> `[80]` (*Player_Italic: "Hang up."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I'm doing fine.""]** — Mówca: **Player**
> ""I'm doing fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Orso Hawker: ""That's great to hear.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""You made a big mistake.""]** — Mówca: **Player**
> ""You made a big mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Orso Hawker: ""I told you not to go against the Old Guard, Mr. President.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""You damn bastard.""]** — Mówca: **Player**
> ""You damn bastard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Orso Hawker: ""I told you not to go against the Old Guard, Mr. President.""*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "Hang up."]** — Mówca: **Player_Italic**
> "I hung up the call."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Lucian looked at me."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Lucian looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucian Galade: ""Sir.""*)

### Węzeł `[82]`
Mówca: **Orso Hawker**
> ""I told you not to go against the Old Guard, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Orso Hawker: ""Another thing you should know is... The Court has decide..."*)

### Węzeł `[83]`
Mówca: **Orso Hawker**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Orso Hawker: ""I told you not to go against the Old Guard, Mr. President.""*)

### Węzeł `[84]`
Mówca: **Orso Hawker**
> ""Another thing you should know is... The Court has decided to open an investigation on you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Orso Hawker: ""I wanted to give you the proper respect by letting you k..."*)

### Węzeł `[85]`
Mówca: **Orso Hawker**
> ""I wanted to give you the proper respect by letting you know myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""Come on, Mr. Hawker. Don't do this.""*)
  - -> `[87]` (*Player: ""I will have your head!""*)
  - -> `[88]` (*Player: ""Don't you dare!""*)
  - -> `[89]` (*Player: ""Fuck you, Mr. Hawker.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Come on, Mr. Hawker. Don't do this.""]** — Mówca: **Player**
> ""Come on, Mr. Hawker. Don't do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Orso Hawker: ""Have a good day, Mr. President.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""I will have your head!""]** — Mówca: **Player**
> ""I will have your head!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Orso Hawker: ""Have a good day, Mr. President.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Don't you dare!""]** — Mówca: **Player**
> ""Don't you dare!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Orso Hawker: ""Have a good day, Mr. President.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Fuck you, Mr. Hawker.""]** — Mówca: **Player**
> ""Fuck you, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Orso Hawker: ""Have a good day, Mr. President.""*)

### Węzeł `[90]`
Mówca: **Orso Hawker**
> ""Have a good day, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "He hung up the call and I froze with the phone still in m..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "He hung up the call and I froze with the phone still in my hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""Was it the Chief Justice? What did he say?""*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""Was it the Chief Justice? What did he say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""They are opening investigations against me.""*)
  - -> `[94]` (*Player: ""I am screwed. They are investigating me.""*)
  - -> `[95]` (*Player: ""Yes. He's going to be a problem.""*)
  - -> `[96]` (*Player: ""Fuck him!""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""They are opening investigations against me.""]** — Mówca: **Player**
> ""They are opening investigations against me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Petr Vectern: ""Oh...""*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""I am screwed. They are investigating me.""]** — Mówca: **Player**
> ""I am screwed. They are investigating me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Petr Vectern: ""Oh...""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Yes. He's going to be a problem.""]** — Mówca: **Player**
> ""Yes. He's going to be a problem.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Petr Vectern: ""I mean... He has always been a problem.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""Fuck him!""]** — Mówca: **Player**
> ""Fuck him!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Petr Vectern: ""Anton. Calm down.""*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""Let's think straight. This isn't *so* bad. If they are not directly opening a case to impeach you for this decree, they must have an opposition inside the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: ""We have to make sure the Court stands divided in that. I..."*)

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""Anton. Calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: ""We have to make sure the Court has no plans to make this..."*)

### Węzeł `[99]`
Mówca: **Petr Vectern**
> ""Oh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucian Galade: ""Let's think straight. This isn't *so* bad. If they are n..."*)

### Węzeł `[100]`
Mówca: **Petr Vectern**
> ""I mean... He has always been a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: ""We have to make sure the Court has no plans to make this..."*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""We have to make sure the Court stands divided in that. I'll start reaching out to the Justices and find out about their stance and if they're willing to be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: ""In the meantime, let's stay focused on our current tasks.""*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""We have to make sure the Court has no plans to make this a case against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""I'll start reaching out to the Justices and find out abo..."*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""I'll start reaching out to the Justices and find out about their stance and if they're willing to be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: ""In the meantime, let's stay focused on our current tasks.""*)

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""In the meantime, let's stay focused on our current tasks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""You're right. I have complete trust in you guys.""*)
  - -> `[106]` (*Player: ""We'll get through it.""*)
  - -> `[107]` (*Player: ""I need to fix my image.""*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal == true"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""You're right. I have complete trust in you guys.""]** — Mówca: **Player**
> ""You're right. I have complete trust in you guys.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: ""We'll do our best.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""We'll get through it.""]** — Mówca: **Player**
> ""We'll get through it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: ""We'll do our best.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I need to fix my image.""]** — Mówca: **Player**
> ""I need to fix my image.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: ""We'll need a proper plan for the remaining of our term.""*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""No. Orso will pay. I'll involve Mr. Greiser.""*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. Orso will pay. I'll involve Mr. Greiser.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[104]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: ""Sir? What do you have in mind?""*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""Sir? What do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He had a worried face."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "He had a worried face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""We need to silence the Court. They need to be given a le..."*)
  - -> `[123]` (*Player: ""It's fine Lucian. I just need to talk to Karl.""*)

### Węzeł `[114]`
Mówca: **Lucian Galade**
> ""We'll need a proper plan for the remaining of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""You work on boosting your image, sir. We'll do our job a..."*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> ""We'll do our best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""You work on boosting your image, sir. We'll do our job a..."*)

### Węzeł `[116]`
Mówca: **Lucian Galade**
> ""You work on boosting your image, sir. We'll do our job and keep you updated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Petr Vectern: ""I'll talk to Nia. See if she can help.""*)

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""I'll talk to Nia. See if she can help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "They both left the room and I collapsed on my chair."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "They both left the room and I collapsed on my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""This sucks.""*)
  - -> `[120]` (*Player: ""I'll fix this.""*)
  - -> `[121]` (*Player: ""Bollocks.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""This sucks.""]** — Mówca: **Player**
> ""This sucks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = false"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""I'll fix this.""]** — Mówca: **Player**
> ""I'll fix this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = false"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Bollocks.""]** — Mówca: **Player**
> ""Bollocks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = false"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""We need to silence the Court. They need to be given a lesson.""]** — Mówca: **Player**
> ""We need to silence the Court. They need to be given a lesson.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator), `[351]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucian Galade: ""I don't know what you have in mind but it sounds risky, ..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""It's fine Lucian. I just need to talk to Karl.""]** — Mówca: **Player**
> ""It's fine Lucian. I just need to talk to Karl.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Lucian Galade: ""As you wish, sir.""*)

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""I don't know what you have in mind but it sounds risky, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player: ""Let's finish the meeting here. I'll make a short phone c..."*)
  - -> `[126]` (*Player: ""You're right. We can't act so extreme.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "Call Karl Greiser."]** — Mówca: **Player_Italic**
> "I took the phone and called Karl Greiser."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[259]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "After a few seconds of ringing, he picked it up."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""You're right. We can't act so extreme.""]** — Mówca: **Player**
> ""You're right. We can't act so extreme.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: ""We'll need a proper plan for the remaining of our term.""*)

### Węzeł `[127]`
Mówca: **Narrator**
> "After a few seconds of ringing, he picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Karl Greiser: ""This is Karl Greiser speaking.""*)

### Węzeł `[128]`
Mówca: **Karl Greiser**
> ""This is Karl Greiser speaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""Hello Karl, it's the President.""*)
  - -> `[130]` (*Player: ""Hi Karl, it's me.""*)
  - -> `[131]` (*Player: ""I need you to fix a problem.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Hello Karl, it's the President.""]** — Mówca: **Player**
> ""Hello Karl, it's the President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Karl Greiser: ""I am at your command, sir! How can I help you?""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Hi Karl, it's me.""]** — Mówca: **Player**
> ""Hi Karl, it's me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Karl Greiser: ""I am at your command, sir! How can I help you?""*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I need you to fix a problem.""]** — Mówca: **Player**
> ""I need you to fix a problem.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Karl Greiser: ""Of course, sir. I am at your command. What is the issue?""*)

### Węzeł `[132]`
Mówca: **Karl Greiser**
> ""Of course, sir. I am at your command. What is the issue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: ""Can we get rid of Orso Hawker?""*)
  - -> `[135]` (*Player: ""I need the Court Justices to be taught a lesson, so they..."*)

### Węzeł `[133]`
Mówca: **Karl Greiser**
> ""I am at your command, sir! How can I help you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: ""Can we get rid of Orso Hawker?""*)
  - -> `[135]` (*Player: ""I need the Court Justices to be taught a lesson, so they..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Can we get rid of Orso Hawker?""]** — Mówca: **Player**
> ""Can we get rid of Orso Hawker?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Karl Greiser), `[133]` (Karl Greiser), `[143]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Karl Greiser: ""You want him completely *gone*?""*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I need the Court Justices to be taught a lesson, so they'd know their place.""]** — Mówca: **Player**
> ""I need the Court Justices to be taught a lesson, so they'd know their place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Karl Greiser), `[133]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Karl Greiser: ""You want them scared off, sir?""*)

### Węzeł `[136]`
Mówca: **Karl Greiser**
> ""You want them scared off, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""Yes. Scare them off by any means necessary. Convince them.""*)
  - -> `[138]` (*Player: ""Threaten them, beat them, do whatever you want.""*)
  - -> `[139]` (*Player: ""No. Maybe we can't be so reckless.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Yes. Scare them off by any means necessary. Convince them.""]** — Mówca: **Player**
> ""Yes. Scare them off by any means necessary. Convince them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Karl Greiser: ""As you wish, sir. I'll give the order.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""Threaten them, beat them, do whatever you want.""]** — Mówca: **Player**
> ""Threaten them, beat them, do whatever you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Karl Greiser: ""As you wish, sir. I'll give the order.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""No. Maybe we can't be so reckless.""]** — Mówca: **Player**
> ""No. Maybe we can't be so reckless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Karl Greiser: ""Do you have anything else in mind?""*)

### Węzeł `[140]`
Mówca: **Karl Greiser**
> ""As you wish, sir. I'll give the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: ""Thank you.""*)
  - -> `[142]` (*Player: ""Teach them a lesson.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Karl Greiser: ""Consider it done. Have a good day, sir.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Teach them a lesson.""]** — Mówca: **Player**
> ""Teach them a lesson.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Karl Greiser: ""Consider it done. Have a good day, sir.""*)

### Węzeł `[143]`
Mówca: **Karl Greiser**
> ""Do you have anything else in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: ""Can we get rid of Orso Hawker?""*)
  - -> `[144]` (*Player: ""No, I've changed my mind, Karl. Good day to you.""*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""No, I've changed my mind, Karl. Good day to you.""]** — Mówca: **Player**
> ""No, I've changed my mind, Karl. Good day to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Karl Greiser: ""Understood, sir. Have a good day.""*)

### Węzeł `[145]`
Mówca: **Karl Greiser**
> ""Understood, sir. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "I hung up the phone."*)

### Węzeł `[146]`
Mówca: **Karl Greiser**
> ""Consider it done. Have a good day, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_SecretState_ThreatenCourt = true"*)

### Węzeł `[147]`
Mówca: **Karl Greiser**
> ""You want him completely *gone*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""His time has come.""*)
  - -> `[149]` (*Player: ""Yes. This will teach everyone a lesson.""*)
  - -> `[150]` (*Player: ""Can you do it?""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""His time has come.""]** — Mówca: **Player**
> ""His time has come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Karl Greiser: ""I see.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Yes. This will teach everyone a lesson.""]** — Mówca: **Player**
> ""Yes. This will teach everyone a lesson.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Karl Greiser: ""I see.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Can you do it?""]** — Mówca: **Player**
> ""Can you do it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Karl Greiser: ""If that's the order, sir, of course.""*)

### Węzeł `[151]`
Mówca: **Karl Greiser**
> ""If that's the order, sir, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Karl Greiser: ""Are you giving me full approval on this, sir?""*)

### Węzeł `[152]`
Mówca: **Karl Greiser**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Karl Greiser: ""Are you giving me full approval on this, sir?""*)

### Węzeł `[153]`
Mówca: **Karl Greiser**
> ""Are you giving me full approval on this, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player: ""Yes. Make sure it's done.""*)
  - -> `[155]` (*Player: ""No. I've changed my mind. Maybe we shouldn't be so reckl..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""Yes. Make sure it's done.""]** — Mówca: **Player**
> ""Yes. Make sure it's done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Karl Greiser: ""As you wish, sir. I'll execute the order.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""No. I've changed my mind. Maybe we shouldn't be so reckless.""]** — Mówca: **Player**
> ""No. I've changed my mind. Maybe we shouldn't be so reckless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Karl Greiser: ""I understand, sir.""*)

### Węzeł `[156]`
Mówca: **Karl Greiser**
> ""I understand, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "I hung up the phone."*)

### Węzeł `[157]`
Mówca: **Karl Greiser**
> ""As you wish, sir. I'll execute the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker = true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_CourtDecision_KillOrso = true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_SecretState_ThreatenCourt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_SecretState_ThreatenCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_CourtDecision_ThreatenCour..."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = false"*)

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""Sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: ""We have to make sure the Court has no plans to make this..."*)

### Węzeł `[162]`
Mówca: **Petr Vectern**
> ""It is really irresponsible of them to invite people to protest on the streets during an emergency. This cannot end well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: ""Let's wait it out. If the worst happens the police would..."*)
  - -> `[164]` (*Player: ""We should target the journalists that stir up unrest.""*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""Let's wait it out. If the worst happens the police would take care of it.""]** — Mówca: **Player**
> ""Let's wait it out. If the worst happens the police would take care of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucian Galade: ""Understood. I will be ready.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA: ""We should target the journalists that stir up unrest.""]** — Mówca: **Player**
> ""We should target the journalists that stir up unrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Petr Vectern), `[191]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA: ""It's time to detain Frens Ricter.""]** — Mówca: **Player**
> ""It's time to detain Frens Ricter.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Kontekst wejściowy (poprzednik):** `[162]` (Petr Vectern), `[191]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: ""Are we really doing this? We still have the intel about ..."*)

### Węzeł `[166]`
Mówca: **Lucian Galade**
> ""Understood. I will be ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: ""If there's nothing else, let's conclude the meeting.""*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player: ""It's time to detain Frens Ricter.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: ""We'll start investigations against the opposition leaders.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""We'll start investigations against the opposition leaders.""]** — Mówca: **Player**
> ""We'll start investigations against the opposition leaders.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[162]` (Petr Vectern), `[191]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: ""As you wish, sir. I'll make the necessary preparations.""*)

### Węzeł `[171]`
Mówca: **Lucian Galade**
> ""You want them detained?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""Detain journalists who have given support to the opposit..."*)
  - -> `[177]` (*Player: ""No. Just reach out to our connections in media to censor..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lucian Galade: ""You want them detained?""*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucian Galade: ""Understood. I'll reach out to my connections and make su..."*)

### Węzeł `[175]`
Mówca: **Lucian Galade**
> ""Understood. I'll reach out to my connections and make sure nothing about the emergency we do not approve gets published.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: ""If there's nothing else, let's conclude the meeting here.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""Detain journalists who have given support to the opposition.""]** — Mówca: **Player**
> ""Detain journalists who have given support to the opposition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Journalists = true"*)

### Węzeł `[177]`
**[WYBÓR GRACZA: ""No. Just reach out to our connections in media to censor the opposition.""]** — Mówca: **Player**
> ""No. Just reach out to our connections in media to censor the opposition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucian Galade: ""Understood. I'll reach out to my connections and make su..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn07_Emergency_Detained_Journalists = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Journalists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_CourtDecision_OppositionJo..."*)

### Węzeł `[179]`
Mówca: **Lucian Galade**
> ""As you wish, sir. I'll make the necessary calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: ""If there's nothing else, let's conclude the meeting here.""*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""As you wish, sir. I'll make the necessary preparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_CourtDecision_OppositionIn..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Emergency_StartInvestigations = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Emergency_StartInvestigations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: ""If there's nothing else, let's conclude the meeting here.""*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""Are we really doing this? We still have the intel about him from Orso Hawker too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Petr Vectern: ""That's true. He has proven connections to Arcasia and ha..."*)

### Węzeł `[183]`
Mówca: **Petr Vectern**
> ""That's true. He has proven connections to Arcasia and has tried to cover his tracks behind international trips for unknown reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: ""We can justify his arrest. And the decree will allow us ..."*)

### Węzeł `[184]`
Mówca: **Lucian Galade**
> ""We can justify his arrest. And the decree will allow us to hold him without trial. Antel Rock awaits him if we go through with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: ""He will pay. Take him down.""*)
  - -> `[186]` (*Player: ""Give the order of his arrest.""*)
  - -> `[187]` (*Player: ""I've changed my mind. Maybe we shouldn't be so reckless.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA: ""He will pay. Take him down.""]** — Mówca: **Player**
> ""He will pay. Take him down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lucian Galade: ""As you wish, sir. I'll make the necessary calls.""*)

### Węzeł `[186]`
**[WYBÓR GRACZA: ""Give the order of his arrest.""]** — Mówca: **Player**
> ""Give the order of his arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lucian Galade: ""As you wish, sir. I'll make the necessary calls.""*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""I've changed my mind. Maybe we shouldn't be so reckless.""]** — Mówca: **Player**
> ""I've changed my mind. Maybe we shouldn't be so reckless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "Jump to: [ChangedMind]"*)

### Węzeł `[188]`
Mówca: **Lucian Galade**
> ""If there's nothing else, let's conclude the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""Thank you gentlemen, I'll see you later.""*)
  - -> `[190]` (*Player: ""Before we go... I want to think about some measures again.""*)

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Thank you gentlemen, I'll see you later.""]** — Mówca: **Player**
> ""Thank you gentlemen, I'll see you later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucian Galade: ""Have a good day, sir.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA: ""Before we go... I want to think about some measures again.""]** — Mówca: **Player**
> ""Before we go... I want to think about some measures again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "Jump to: [Return]"*)

### Węzeł `[191]`
Mówca: **Lucian Galade**
> ""Yes, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: ""Never mind. Let's just focus the task at hand.""*)
  - -> `[164]` (*Player: ""We should target the journalists that stir up unrest.""*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Never mind. Let's just focus the task at hand.""]** — Mówca: **Player**
> ""Never mind. Let's just focus the task at hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[193]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Petr Vectern: ""See you later Anton.""*)

### Węzeł `[194]`
Mówca: **Lucian Galade**
> ""Have a good day, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Petr Vectern: ""See you later Anton.""*)

### Węzeł `[195]`
Mówca: **Petr Vectern**
> ""See you later Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "They left the office."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "They left the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success = true"*)

### Węzeł `[197]`
Mówca: **Lucian Galade**
> ""If there's nothing else, let's conclude the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "They readied themselves before the door."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "They readied themselves before the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Petr Vectern: ""See you later Anton.""*)

### Węzeł `[199]`
Mówca: **Lucian Galade**
> ""Understood. I will be ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: ""If there's nothing else, let's conclude the meeting.""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Return`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucian Galade: ""Yes, sir?""*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ChangedMind`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Lucian Galade: ""Understood. I will be ready.""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Return]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "Return"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ChangedMind]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "ChangedMind"*)

### Węzeł `[204]`
Mówca: **Lucian Galade**
> ""As you wish, sir. I'll make the necessary calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Petr Vectern: ""This is a big move.""*)

### Węzeł `[205]`
Mówca: **Petr Vectern**
> ""This is a big move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens = true; B..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn07_Emergency_Detained_Frens = true;
BaseGameSupport.Codex_Characters_PartyLeaders_FrensRicter_Detained = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] = true;
Variable["BaseGameSupport.Codex_Characters_PartyLeaders_FrensRicter_Detained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_CourtDecision_DetainFrens ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Extending the decree and cooperating with the Old Guard h..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Cooperating with the Old Guard, even for a short time, ha..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Extending the decree and cooperating with the Old Guard has put me in a very fragile spot, which felt like it could backfire at any moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Petr Vectern: ""Do you trust Orso Hawker?""*)

### Węzeł `[213]`
Mówca: **Narrator**
> "Cooperating with the Old Guard, even for a short time, has put me in a very fragile spot, which felt like it could backfire at any moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Petr Vectern: ""Do you trust Orso Hawker?""*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Petr Vectern: ""So... You expect your decree to be declared invalid?""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Petr Vectern: ""So... You expect an actual trial against you?""*)

### Węzeł `[217]`
Mówca: **Petr Vectern**
> ""So... You expect an actual trial against you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Unfortunately, it seems that way.""*)
  - -> `[16]` (*Player: ""No, the Court cannot afford to do that.""*)
  - -> `[15]` (*Player: ""I have to be prepared for the worst.""*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Petr Vectern: ""I just hope he holds up his end of the bargain...""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Petr Vectern: ""I can't believe this... You did what they asked.""*)

### Węzeł `[221]`
Mówca: **Petr Vectern**
> ""I can't believe this... You did what they asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Petr Vectern: ""It's absurd that they did not protest when you declared ..."*)

### Węzeł `[222]`
Mówca: **Petr Vectern**
> ""It's absurd that they did not protest when you declared the emergency and now they're reviewing a past case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Petr Vectern: ""We can't face a negative outcome from the supreme Court...""*)

### Węzeł `[223]`
Mówca: **Petr Vectern**
> ""We can't face a negative outcome from the supreme Court...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Of course we can.""*)
  - -> `[22]` (*Player: ""I know Petr. I know.""*)
  - -> `[23]` (*Player: ""Stop whining.""*)
  - -> `[24]` (*Player: ""What do we do?""*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: ""Well... I don't know. People are uneasy with the current..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Petr Vectern: ""Well... I don't know. The emergency was not very popular..."*)

### Węzeł `[227]`
Mówca: **Petr Vectern**
> ""Well... I don't know. The emergency was not very popular before and that fed into the rise of the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Petr Vectern: ""If the Court decides to side with the opposition for onc..."*)

### Węzeł `[228]`
Mówca: **Petr Vectern**
> ""If the Court decides to side with the opposition for once... You may lose support from everyone. Including the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: ""You just cannot have the Court against you, Anton. There..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Petr Vectern: ""But maybe this period has lasted too long already...""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Petr Vectern: ""How about the Bludish issue? The emergency did not reall..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[235]`
Mówca: **Petr Vectern**
> ""How about the Bludish issue? The emergency did not really help with the situation in Bergia. It has become even more volatile. The Aschraf anniversary will happen later this year; who knows how that will unfold?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Petr Vectern: ""I'm afraid we also contributed to the radicalization of ..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Petr Vectern: ""I'm afraid we also contributed to the radicalization of ..."*)

### Węzeł `[239]`
Mówca: **Petr Vectern**
> ""I'm afraid we also contributed to the radicalization of the malenyevists on our soil...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""We'll get through it, Petr.""*)
  - -> `[41]` (*Player: ""What are you saying, Petr?""*)
  - -> `[43]` (*Player: ""Yes, I'm afraid this decree was a bad idea.""*)
  - -> `[42]` (*Player: ""Stop grumbling for once.""*)

### Węzeł `[240]`
Mówca: **Petr Vectern**
> ""I'm afraid we also contributed to the radicalization of the Sordish nationalists...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""We'll get through it, Petr.""*)
  - -> `[41]` (*Player: ""What are you saying, Petr?""*)
  - -> `[43]` (*Player: ""Yes, I'm afraid this decree was a bad idea.""*)
  - -> `[42]` (*Player: ""Stop grumbling for once.""*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucian Galade: ""Now we can start thinking about the opposition. They are..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Lucian Galade: ""Now we can start thinking about what to do next and how ..."*)

### Węzeł `[244]`
Mówca: **Lucian Galade**
> ""Now we can start thinking about what to do next and how to get out of this hole we put ourselves in. The opposition gained a lot of popularity throughout this process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucian Galade: ""I'll arrange a cabinet meeting to address all the issues..."*)

### Węzeł `[245]`
Mówca: **Lucian Galade**
> ""I'll arrange a cabinet meeting to address all the issues and our next steps as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""Great. You have my trust, Lucian.""*)
  - -> `[247]` (*Player: ""The quicker we get together, the better.""*)
  - -> `[248]` (*Player: ""I believe the concerns are overexaggerated.""*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Great. You have my trust, Lucian.""]** — Mówca: **Player**
> ""Great. You have my trust, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Lucian Galade: ""Yes sir.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""The quicker we get together, the better.""]** — Mówca: **Player**
> ""The quicker we get together, the better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Lucian Galade: ""Yes sir.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA: ""I believe the concerns are overexaggerated.""]** — Mówca: **Player**
> ""I believe the concerns are overexaggerated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Lucian Galade: ""With all due respect, I disagree sir. The main demand of..."*)

### Węzeł `[249]`
Mówca: **Lucian Galade**
> ""With all due respect, I disagree sir. The main demand of the people were to pursue constitutional reforms. Not only we did not follow through with that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Lucian Galade: ""...We ended up making powerful enemies. Now if the Supre..."*)

### Węzeł `[250]`
Mówca: **Lucian Galade**
> ""Yes sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "He fixed his tie."*)

### Węzeł `[251]`
Mówca: **Lucian Galade**
> ""...We ended up making powerful enemies. Now if the Supreme Court wants us gone, they could potentially do that very easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "He fixed his tie."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "He fixed his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: ""If there's nothing else, let's conclude the meeting here.""*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: ""They declared the Emergency invalid and agreed with ever..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Lucian Galade: ""They declared the Emergency decree illegal and agreed wi..."*)

### Węzeł `[256]`
Mówca: **Lucian Galade**
> ""They declared the Emergency decree illegal and agreed with every complaint of Mr. Ricter regarding your actions being unconstitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_CourtDecision_Illegal = true"*)

### Węzeł `[257]`
Mówca: **Lucian Galade**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player: ""Let's finish the meeting here. I'll make a short phone c..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Let's finish the meeting here. I'll make a short phone call.""]** — Mówca: **Player**
> ""Let's finish the meeting here. I'll make a short phone call.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Lucian Galade), `[257]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "They left the room."*)

### Węzeł `[259]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal == true"*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[260]`
Mówca: **Livia Suno**
> ""Good day to you, Mr. President. Am I interrupting anything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player: ""No. Please come in. Is there a problem?""*)
  - -> `[262]` (*Player: ""Yes, you are. What is it?""*)
  - -> `[261]` (*Player: ""It's okay, Livia. What happened?""*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""It's okay, Livia. What happened?""]** — Mówca: **Player**
> ""It's okay, Livia. What happened?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Livia Suno: ""The Chief Justice has sent you this.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Yes, you are. What is it?""]** — Mówca: **Player**
> ""Yes, you are. What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Livia Suno: ""The Chief Justice has sent you this.""*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""No. Please come in. Is there a problem?""]** — Mówca: **Player**
> ""No. Please come in. Is there a problem?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Livia Suno: ""The Chief Justice has sent you this.""*)

### Węzeł `[264]`
**[WYBÓR GRACZA: ""Thanks, Livia. You may go now.""]** — Mówca: **Player**
> ""Thanks, Livia. You may go now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Livia turned to leave."*)

### Węzeł `[265]`
**[WYBÓR GRACZA: ""Damn Orso...""]** — Mówca: **Player**
> ""Damn Orso...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Petr Vectern: ""Victory will be close, huh? Orso's getting ahead of hims..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""Yeah. A picture of Tarquin Soll. What a nice present!""]** — Mówca: **Player**
> ""Yeah. A picture of Tarquin Soll. What a nice present!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Petr Vectern: ""Victory will be close, huh? Orso's getting ahead of hims..."*)

### Węzeł `[267]`
Mówca: **Petr Vectern**
> ""Victory will be close, huh? Orso's getting ahead of himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "The emergency decree was tough on all of my team. We were..."*)

### Węzeł `[268]`
Mówca: **Petr Vectern**
> ""Hi, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "Noticing Petr on the couch, Livia reddened slightly. She ..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "She walked up and gave it to me. I immediately started to remove the wrapping to reveal a framed photograph."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "It was an old black and white photograph of Tarquin Soll ..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA: ""This must be some kind of a message.""]** — Mówca: **Player**
> ""This must be some kind of a message.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Petr Vectern: ""Victory will be close, huh? Orso's getting ahead of hims..."*)

### Węzeł `[271]`
Mówca: **Livia Suno**
> ""The Chief Justice has sent you this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "She showed me the wrapped object."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "She showed me the wrapped object."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player: ""What is it?""*)
  - -> `[274]` (*Player: ""Really? From Orso Hawker? Bring it here.""*)
  - -> `[273]` (*Player: ""Thank you, Livia. You can leave it on my table.""*)

### Węzeł `[273]`
**[WYBÓR GRACZA: ""Thank you, Livia. You can leave it on my table.""]** — Mówca: **Player**
> ""Thank you, Livia. You can leave it on my table.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Livia Suno: ""Yes, sir.""*)

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Really? From Orso Hawker? Bring it here.""]** — Mówca: **Player**
> ""Really? From Orso Hawker? Bring it here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Livia Suno: ""Yes, sir.""*)

### Węzeł `[275]`
**[WYBÓR GRACZA: ""What is it?""]** — Mówca: **Player**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Livia Suno: ""I don't know... A picture?""*)

### Węzeł `[276]`
Mówca: **Narrator**
> "Noticing Petr on the couch, Livia reddened slightly. She gave a small wave, which Petr returned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Livia Suno: ""Mr. Vice President. I'll be leaving now.""*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Livia turned to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Petr Vectern: ""Hi, Livia.""*)

### Węzeł `[278]`
Mówca: **Livia Suno**
> ""No, but he's obviously trying to send you a message. I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Petr Vectern: ""Hi, Livia.""*)

### Węzeł `[279]`
Mówca: **Livia Suno**
> ""He's obviously trying to send you a message, but--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Petr Vectern: ""Hi, Livia.""*)

### Węzeł `[280]`
**[WYBÓR GRACZA: ""What do you think?""]** — Mówca: **Player**
> ""What do you think?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Petr Vectern: ""Victory will be close, huh? Orso's getting ahead of hims..."*)

### Węzeł `[281]`
Mówca: **Petr Vectern**
> ""Oh... A nice present.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player: ""This must be some kind of a message.""*)
  - -> `[265]` (*Player: ""Damn Orso...""*)
  - -> `[266]` (*Player: ""Yeah. A picture of Tarquin Soll. What a nice present!""*)
  - -> `[280]` (*Player: ""What do you think?""*)

### Węzeł `[282]`
Mówca: **Livia Suno**
> ""I don't know... A picture?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Livia Suno: ""I'll just bring it to you.""*)

### Węzeł `[283]`
Mówca: **Livia Suno**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She walked up and gave it to me. I immediately started to..."*)

### Węzeł `[284]`
Mówca: **Livia Suno**
> ""I'll just bring it to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She walked up and gave it to me. I immediately started to..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA: ""Did Orso say anything to you about this?""]** — Mówca: **Player**
> ""Did Orso say anything to you about this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Livia Suno: ""No, but he's obviously trying to send you a message. I--""*)

### Węzeł `[286]`
Mówca: **Narrator**
> "As soon as she left the room, Petr came right next to me and took a look at the photograph."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Petr Vectern: ""Oh... A nice present.""*)

### Węzeł `[287]`
Mówca: **Livia Suno**
> ""Mr. Vice President. I'll be leaving now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "As soon as she left the room, Petr came right next to me ..."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "I turned to Livia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: ""What do you think this means, Livia?""*)
  - -> `[285]` (*Player: ""Did Orso say anything to you about this?""*)
  - -> `[264]` (*Player: ""Thanks, Livia. You may go now.""*)

### Węzeł `[289]`
Mówca: **Narrator**
> "It was an old black and white photograph of Tarquin Soll posing on a destroyed tank at the Holsord Square. The building behind him had thousands of bullet holes on it. To the side a clearly readable slogan 'Victory is close' written on its walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "The date, 14 March 1929 was written on the corner with a ..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA: ""What do you think this means, Livia?""]** — Mówca: **Player**
> ""What do you think this means, Livia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Livia Suno: ""He's obviously trying to send you a message, but--""*)

### Węzeł `[291]`
Mówca: **Narrator**
> "The date, 14 March 1929 was written on the corner with a black marker."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "I turned to Livia."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_Autocrat_CourtDecision = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_Autocrat_CourtDecision"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == false"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree = false; BaseGame.Policy_Law_Decree_Stronger = false; BaseGame.Policy_Law_Decree_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] = false;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = false;
Variable["BaseGame.Policy_Law_Decree_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger = false; BaseGame.Re..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_CourtDecision_Invalid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_Invalid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == true"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_CourtDecision_Illegal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_Illegal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: ""What!?""*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_CourtDecision_OppositionJournalists = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_OppositionJournalists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucian Galade: ""As you wish, sir. I'll make the necessary calls.""*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_CourtDecision_OppositionInvestigations = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_OppositionInvestigations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Emergency_StartInvestigations = true"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_CourtDecision_DetainFrens = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_DetainFrens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: ""If there's nothing else, let's conclude the meeting here.""*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_CourtDecision_ThreatenCourt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_ThreatenCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "I hung up the phone."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_CourtDecision_KillOrso = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_KillOrso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "I hung up the phone."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = true"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == true)"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_CourtForEmergency = true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial = f..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_CelebratingRevocati..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_Autocrat_CourtDecision = true"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_Autocrat_CourtDecision = true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_PFJPCongratulatesCourt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_PFJPCongratulatesCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_CelebratingRevocation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_CelebratingRevocation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_Autocrat_CourtDecision = true"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Revo..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Exte..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Revoked = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Revoked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Extended = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Extended"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_CourtForEmergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_CourtForEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt =..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt =..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt =..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_CourtForEmergency = true"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_CourtForEmergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_CourtForEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_Deal..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_NoDe..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_PFJPCongratulatesCo..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_PFJPCongratulatesCo..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial = false;
BaseGame.Reform_EmergencyDecree_PoliceAuthority = false;
BaseGame.Reform_EmergencyDecree_SuspendedProtests = false;
BaseGame.Reform_Law_Decrees_Stronger = false;
BaseGame.Reform_Law_Decrees_Default = true;
BaseGame.Policy_Law_Decree_Stronger = false;
BaseGame.Policy_Law_Decree_Default = true;
BaseGame.Policy_Law_EmergencyDecree = false;
BaseGame.Policy_Order_Authority = false;
BaseGame.Policy_Order_SuspendedProtests = false;
BaseGame.Policy_Order_DetentionWithoutTrial = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] = false;
Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] = false;
Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] = false;
Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Reform_Law_Decrees_Default"] = true;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = false;
Variable["BaseGame.Policy_Law_Decree_Default"] = true;
Variable["BaseGame.Policy_Law_EmergencyDecree"] = false;
Variable["BaseGame.Policy_Order_Authority"] = false;
Variable["BaseGame.Policy_Order_SuspendedProtests"] = false;
Variable["BaseGame.Policy_Order_DetentionWithoutTrial"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_IncreasedInteriorFunding == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_IncreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == true"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: ""What!?""*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_CrimeWave = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_CrimeWave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime = true; BaseGame...."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_DecreasedInteriorFunding == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_CrimeWave = true;"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_DecreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime = true; BaseGame...."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrime = true;
BaseGame.Situation_Order_ReductionOfCrimeCommunities = false;
BaseGame.Situation_Order_OrganisedCrimeContained = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] = true;
Variable["BaseGame.Situation_Order_ReductionOfCrimeCommunities"] = false;
Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == false"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == false)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default = true; BaseGame.Polic..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_CourtVote_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default = true; BaseGame.Policy_Law_Decree_Stronger = false; BaseGame.Policy_Law_EmergencyDecree = false; BaseGame.Policy_Law_EmergencyDecree = false; BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial = false; BaseGame.Reform_EmergencyDecree_PoliceAuthority = false; BaseGame.Reform_EmergencyDecree_SuspendedProtests = false; BaseGame.Policy_Order_DetentionWithoutTrial = false; BaseGame.Policy_Order_Authority = false; BaseGame.Policy_Order_SuspendedProtests = false; BaseGame.Reform_Law_Decrees_Stronger = false;
BaseGame.Reform_Law_Decrees_Default = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_Decree_Default"] = true;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = false;
Variable["BaseGame.Policy_Law_EmergencyDecree"] = false;
Variable["BaseGame.Policy_Law_EmergencyDecree"] = false;
Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] = false;
Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] = false;
Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] = false;
Variable["BaseGame.Policy_Order_DetentionWithoutTrial"] = false;
Variable["BaseGame.Policy_Order_Authority"] = false;
Variable["BaseGame.Policy_Order_SuspendedProtests"] = false;
Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Reform_Law_Decrees_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger = false; BaseGame.Reform_Law_Decrees_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Reform_Law_Decrees_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_CourtDecision_Invalid = true"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Autocrat_YoungSords_NFP_Deal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal == true"*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Autocrat_YoungSords_NFP_Deal == true)"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Autocrat_YoungSords_NFP_Deal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player: ""No. Orso will pay. I'll involve... a group of *fixers.*""*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Autocrat_YoungSords_NFP_Deal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. Orso will pay. I'll involve... a group of *fixers.*""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true`
- **Kontekst wejściowy (poprzednik):** `[104]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Lucian Galade: ""Sir? What do you have in mind?""*)

### Węzeł `[350]`
Mówca: **Lucian Galade**
> ""Sir? What do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "He had a worried face."*)

### Węzeł `[351]`
Mówca: **Narrator**
> "He had a worried face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""We need to silence the Court. They need to be given a le..."*)
  - -> `[352]` (*Player: ""It's fine, Lucian. I just need to make a phone call.""*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's fine, Lucian. I just need to make a phone call.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[351]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Lucian Galade: ""As you wish, sir.""*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Autocrat_YoungSords_NFP_Deal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Autocrat_YoungSords_NFP_Deal == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Autocrat_YoungSords_NFP_Deal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Italic: "Call Remus Holstron."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Autocrat_YoungSords_NFP_Deal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Italic: "Call Karl Greiser."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[359]`
**[WYBÓR GRACZA: "Call Remus Holstron."]** — Mówca: **Player_Italic**
> "I took the phone and called Remus Holstron."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true`
- **Kontekst wejściowy (poprzednik):** `[259]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Narrator: "After a few seconds of ringing, he picked it up."*)

### Węzeł `[360]`
Mówca: **Narrator**
> "After a few seconds of ringing, he picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player: ""This is the president speaking.""*)
  - -> `[362]` (*Player: ""Hi, Mr. Holstron, it's me.""*)
  - -> `[363]` (*Player: ""I need you to fix a problem.""*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is the president speaking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Remus Holstron: ""Oh, Mr. President! How can I help you?""*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hi, Mr. Holstron, it's me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Remus Holstron: ""Oh, Mr. President! How can I help you?""*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I need you to fix a problem.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Remus Holstron: ""Tell me. What is the issue?""*)

### Węzeł `[364]`
Mówca: **Remus Holstron**
> ""Tell me. What is the issue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player: ""Can you get rid of Orso Hawker?""*)
  - -> `[367]` (*Player: ""I need the Court Justices to be taught a lesson. I want ..."*)

### Węzeł `[365]`
Mówca: **Remus Holstron**
> ""Oh, Mr. President! How can I help you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player: ""Can you get rid of Orso Hawker?""*)
  - -> `[367]` (*Player: ""I need the Court Justices to be taught a lesson. I want ..."*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can you get rid of Orso Hawker?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Remus Holstron), `[365]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Remus Holstron: ""I see. He stepped on your toes too. You want him complet..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I need the Court Justices to be taught a lesson. I want them to know their place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Remus Holstron), `[365]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Remus Holstron: ""I see. They are stepping on your toes. You want them sca..."*)

### Węzeł `[368]`
Mówca: **Remus Holstron**
> ""I see. They are stepping on your toes. You want them scared off?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Player: ""Yes. Scare them off by any means necessary. Convince them.""*)
  - -> `[370]` (*Player: ""Threaten them, beat them, do whatever you want.""*)
  - -> `[371]` (*Player: ""No. Maybe we can't be so reckless.""*)

### Węzeł `[369]`
**[WYBÓR GRACZA: ""Yes. Scare them off by any means necessary. Convince them.""]** — Mówca: **Player**
> ""Yes. Scare them off by any means necessary. Convince them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Remus Holstron: ""I don't know if it will work. But we can try.""*)

### Węzeł `[370]`
**[WYBÓR GRACZA: ""Threaten them, beat them, do whatever you want.""]** — Mówca: **Player**
> ""Threaten them, beat them, do whatever you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Remus Holstron: ""I don't know if it will work. But we can try.""*)

### Węzeł `[371]`
**[WYBÓR GRACZA: ""No. Maybe we can't be so reckless.""]** — Mówca: **Player**
> ""No. Maybe we shouldn't be so reckless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Remus Holstron: ""Do you have anything else in mind?""*)

### Węzeł `[372]`
Mówca: **Remus Holstron**
> ""I don't know if it will work. But we can try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Player: ""Thank you.""*)
  - -> `[374]` (*Player: ""Teach them a lesson.""*)

### Węzeł `[373]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Remus Holstron: ""Sure. Have a good day.""*)

### Węzeł `[374]`
**[WYBÓR GRACZA: ""Teach them a lesson.""]** — Mówca: **Player**
> ""Teach them a lesson.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Remus Holstron: ""Sure. Have a good day.""*)

### Węzeł `[375]`
Mówca: **Remus Holstron**
> ""Do you have anything else in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Player: ""No, I've changed my mind. Good day to you.""*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I've changed my mind. Good day to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Remus Holstron: ""I understand. Next time, call me when you are sure about..."*)

### Węzeł `[377]`
Mówca: **Remus Holstron**
> ""Sure. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_SecretState_ThreatenCourt = true"*)

### Węzeł `[378]`
Mówca: **Remus Holstron**
> ""I see. He stepped on your toes too. You want him completely *gone*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player: ""His time has come.""*)
  - -> `[380]` (*Player: ""Yes. This will teach everyone a lesson.""*)
  - -> `[381]` (*Player: ""Can you do it?""*)

### Węzeł `[379]`
**[WYBÓR GRACZA: ""His time has come.""]** — Mówca: **Player**
> ""His time has come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Remus Holstron: ""I'll talk to my people. See what I can do.""*)

### Węzeł `[380]`
**[WYBÓR GRACZA: ""Yes. This will teach everyone a lesson.""]** — Mówca: **Player**
> ""Yes. This will teach everyone a lesson.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Remus Holstron: ""I'll talk to my people. See what I can do.""*)

### Węzeł `[381]`
**[WYBÓR GRACZA: ""Can you do it?""]** — Mówca: **Player**
> ""Can you do it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Remus Holstron: ""I'll talk to my people. See what I can do.""*)

### Węzeł `[382]`
Mówca: **Remus Holstron**
> ""I'll talk to my people. See what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Remus Holstron: ""Are you giving me full approval on this, Mr. President?""*)

### Węzeł `[383]`
**[WYBÓR GRACZA: ""No. I've changed my mind. Maybe we shouldn't be so reckless.""]** — Mówca: **Player**
> ""No. I've changed my mind. Maybe we shouldn't be so reckless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Remus Holstron: ""I understand. Next time, call me when you are sure about..."*)

### Węzeł `[384]`
**[WYBÓR GRACZA: ""Yes. Make sure it's done.""]** — Mówca: **Player**
> ""Yes. Make sure it's done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Remus Holstron: ""Understood.""*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker = true;
BaseGame.YoungSords_Kill_OrsoHawker = true;
BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] = true;
Variable["BaseGame.YoungSords_Kill_OrsoHawker"] = true;
Variable["BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "I hung up the phone."*)

### Węzeł `[386]`
Mówca: **Remus Holstron**
> ""Are you giving me full approval on this, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player: ""Yes. Make sure it's done.""*)
  - -> `[383]` (*Player: ""No. I've changed my mind. Maybe we shouldn't be so reckl..."*)

### Węzeł `[387]`
Mówca: **Remus Holstron**
> ""I understand. Next time, call me when you are sure about what to ask for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "I hung up the phone."*)

### Węzeł `[388]`
Mówca: **Remus Holstron**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker = true; BaseG..."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = false"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_SecretState_ThreatenCourt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_SecretState_ThreatenCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "I hung up the phone."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhoneRing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhoneRing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The phone rang."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhonePickUp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhonePickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Italic: "Answer it."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("KnockDoor");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("KnockDoor");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Suddenly, we heard a knock on the door. Lucian came insid..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
