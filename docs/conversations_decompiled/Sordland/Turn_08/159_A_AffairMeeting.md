# Sordland/Turn08/A_AffairMeeting

- **ID konwersacji:** `159`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/159_A_AffairMeeting.md`
- **Liczba węzłów dialogowych:** 355
- **Liczba wyborów gracza:** 79

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_TradeDeal`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_EmbargoingArcasia`
- `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.TradeDeal_Negotiation_Lespia`
- `BaseGame.TradeDeal_Negotiation_Valgsland`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn08_SecondScandal_InformLucianAboutAffair`
- `BaseGame.Turn08_SecondScandal_RumburgBlamed`
- `BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_TradeDeal`
- `BaseGame.YoungSords_Aids_Security`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BFF_Damaged`
- `BaseGame.BFF_Destroyed`
- `BaseGame.BFF_EliminationOperation_Botched`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Turn08_SecondScandal_LiviaInvestigated`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaInvestigated`
- `BaseGameSupport.News_Turn08_HP_GovernorErsen_DisplaysArge`
- `BaseGameSupport.News_Turn08_HP_GovernorKrull_InvitesRemus`
- `BaseGameSupport.News_Turn08_LT_GovernorBronContinuesResettlement`
- `BaseGameSupport.News_Turn08_LT_GovernorErsen_DisplaysArge`
- `BaseGameSupport.News_Turn08_R_GovernorBronContinuesResettlement`
- `BaseGameSupport.News_Turn08_R_GovernorKrull_InvitesRemus`
- `BaseGameSupport.News_Turn08_ST_NoDeal_GovernorErsen_DisplaysArge`
- `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_Both`
- `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_LanguageBill`
- `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_ReligiousHarmonyBill`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Ersen`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Governor`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Damaged`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Failure`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Success`
- `GameCondition.Turn08_A_AffairMeeting`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""Lucian, I know you're punctual, but this is ridiculous!""** | `[11]` **Lucian Galade**: ""Mr. President. Good. I was hopi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lucian Galade**: ""I have a sensitive matter to di..." |
| `[13]` | **""What's going on?""** | `[11]` **Lucian Galade**: ""Mr. President. Good. I was hopi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lucian Galade**: ""I have a sensitive matter to di..." |
| `[15]` | **""I couldn't sleep anyway.""** | `[14]` **Lucian Galade**: ""Mr. President. Thank you for me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucian Galade**: ""Very well. I'm pleased that you..." |
| `[16]` | **""Cut to the chase.""** | `[14]` **Lucian Galade**: ""Mr. President. Thank you for me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucian Galade**: ""Very well. I'm pleased that you..." |
| `[18]` | **""I figured as much. You do know everything that goes on in the Palace, after all.""** | `[17]` **Lucian Galade**: ""Very well. I'm pleased that you..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[21]` **Narrator**: "Lucian smiled." |
| `[19]` | **""How did you find out?""** | `[17]` **Lucian Galade**: ""Very well. I'm pleased that you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucian Galade**: ""I'll get to that."" |
| `[30]` | **""Yes, he told me. It's over now.""** | `[29]` **Lucian Galade**: ""I have very good reason to beli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Lucian gave me a wounded look." |
| `[31]` | **""What? Unbelievable!""** | `[29]` **Lucian Galade**: ""I have very good reason to beli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Lucian Galade**: ""I'm sorry to be the bearer of t..." |
| `[32]` | **""I know. We're handling it.""** | `[29]` **Lucian Galade**: ""I have very good reason to beli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Lucian gave me a wounded look." |
| `[35]` | **""I assumed you were already aware. You do know everything that goes on in this pal..."** | `[34]` **Lucian Galade**: ""You knew, and you didn't come t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[41]` **Narrator**: "Lucian smiled." |
| `[36]` | **""I don't need your help. We've got this under control.""** | `[34]` **Lucian Galade**: ""You knew, and you didn't come t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[40]` **Narrator**: "Lucian frowned." |
| `[37]` | **""He only told me yesterday. I was going to come to you first thing today.""** | `[34]` **Lucian Galade**: ""You knew, and you didn't come t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lucian Galade**: ""Well, don't hesitate to call st..." |
| `[46]` | **"Laugh incredulously."** | `[45]` **Lucian Galade**: ""I believe Miss Suno is our mole..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: ""I wish I was wrong, sir. But I'..." |
| `[47]` | **""Tell me more.""** | `[45]` **Lucian Galade**: ""I believe Miss Suno is our mole..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[71]` **Lucian Galade**: ""I can do better than that -- I'..." |
| `[48]` | **""You're being paranoid, Lucian.""** | `[45]` **Lucian Galade**: ""I believe Miss Suno is our mole..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: ""I wish I was wrong, sir. But I'..." |
| `[49]` | **""That's preposterous.""** | `[45]` **Lucian Galade**: ""I believe Miss Suno is our mole..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: ""I wish I was wrong, sir. But I'..." |
| `[86]` | **""That's it? That's your damning evidence?""** | `[85]` **Narrator**: "Lucian grimaced and switched the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Lucian Galade**: ""Think about it. Why so much cur..." |
| `[87]` | **""This is indeed cause for concern.""** | `[85]` **Narrator**: "Lucian grimaced and switched the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Lucian Galade**: ""I'm glad you agree."" |
| `[88]` | **""Curiosity about foreign relations doesn't make one a spy.""** | `[85]` **Narrator**: "Lucian grimaced and switched the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Lucian Galade**: ""Perhaps, but why so much curios..." |
| `[89]` | **""And then what happened?""** | `[85]` **Narrator**: "Lucian grimaced and switched the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Lucian Galade**: ""You don't need to hear the rest..." |
| `[96]` | **""Close the door. Have a seat.""** | `[95]` **Livia Suno**: ""Good morning, Mr. President, Mr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Narrator**: "Livia sat. She looked puzzled." |
| `[97]` | **""Coffee would be great, actually.""** | `[95]` **Livia Suno**: ""Good morning, Mr. President, Mr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "Livia left to make coffee. A few..." |
| `[98]` | **"Wait for Lucian to say something."** | `[95]` **Livia Suno**: ""Good morning, Mr. President, Mr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Lucian Galade**: ""Please have a seat, Miss Suno."" |
| `[105]` | **""Come on, Livia. Petr already told me everything.""** | `[104]` **Livia Suno**: ""I... I'm not sure what you're t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Livia buried her face in her hands." |
| `[106]` | **""You know perfectly well.""** | `[104]` **Livia Suno**: ""I... I'm not sure what you're t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Livia buried her face in her hands." |
| `[107]` | **""Livia. Lucian has evidence.""** | `[104]` **Livia Suno**: ""I... I'm not sure what you're t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Livia buried her face in her hands." |
| `[113]` | **""No, he isn't. You'll have to excuse him.""** | `[112]` **Livia Suno**: ""Pardon me, Mr. Galade, but are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Lucian folded his arms." |
| `[114]` | **""Don't play dumb, Livia. If that is your real name.""** | `[112]` **Livia Suno**: ""Pardon me, Mr. Galade, but are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Livia Suno**: ""Mr. President, I understand if ..." |
| `[115]` | **""He's fine. What do you have to say for yourself?""** | `[112]` **Livia Suno**: ""Pardon me, Mr. Galade, but are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Livia Suno**: ""Mr. President, I understand if ..." |
| `[118]` | **""I know. It sounds ridiculous to me as well.""** | `[112]` **Livia Suno**: ""Pardon me, Mr. Galade, but are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Lucian folded his arms." |
| `[126]` | **""But why have you been asking me so many questions about what I do?""** | `[125]` **Narrator**: "She scribbled a telephone number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Livia Suno**: ""To tell the truth, Mr. Rayne......" |
| `[127]` | **""But why were you asking Petr about my alliances?""** | `[125]` **Narrator**: "She scribbled a telephone number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Livia Suno**: ""To tell the truth, Mr. Rayne......" |
| `[128]` | **""But why were you so eager to help Deivid back in Benfi?""** | `[125]` **Narrator**: "She scribbled a telephone number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Livia Suno**: ""To tell the truth, Mr. Rayne......" |
| `[143]` | **""Sorry. I had to tell Lucian.""** | `[141]` **Petr Vectern**: ""I came as soon as I heard the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Petr took a seat on the far end ..." |
| `[144]` | **""Sorry. Lucian already found out.""** | `[141]` **Petr Vectern**: ""I came as soon as I heard the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Petr took a seat on the far end ..." |
| `[145]` | **""Sit down and shut up.""** | `[141]` **Petr Vectern**: ""I came as soon as I heard the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Petr took a seat on the far end ..." |
| `[148]` | **""She's a spy, Petr. You messed up big-time.""** | `[147]` **Petr Vectern**: ""God, why involve her? This is m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Petr Vectern**: ""I-- what?!"" |
| `[149]` | **""Lucian has the preposterous idea that she's a spy.""** | `[147]` **Petr Vectern**: ""God, why involve her? This is m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Petr Vectern**: ""I-- what?!"" |
| `[150]` | **""Well... there's a small chance she could be a spy.""** | `[147]` **Petr Vectern**: ""God, why involve her? This is m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Petr Vectern**: ""I-- what?!"" |
| `[155]` | **""Obviously for a good reason.""** | `[154]` **Petr Vectern**: ""Lucian, you rat bastard. You've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Narrator**: "Both Petr and Livia were glaring..." |
| `[156]` | **""Lucian, is this true? How could you?""** | `[154]` **Petr Vectern**: ""Lucian, you rat bastard. You've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Narrator**: "Both Petr and Livia were glaring..." |
| `[157]` | **""I'm sure there's an explanation for this.""** | `[154]` **Petr Vectern**: ""Lucian, you rat bastard. You've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Narrator**: "Both Petr and Livia were glaring..." |
| `[171]` | **""Of course you'd say that. Petr's your lover.""** | `[169]` **Livia Suno**: ""And from what I've seen, this m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "Livia looked at Petr on the othe..." |
| `[172]` | **""That's ridiculous. I would never make Lucian vice president.""** | `[169]` **Livia Suno**: ""And from what I've seen, this m..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[175]` **Narrator**: "Lucian looked slightly shaken at..." |
| `[173]` | **""That actually makes a lot of sense.""** | `[169]` **Livia Suno**: ""And from what I've seen, this m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Livia Suno**: ""Thank you. I'm happy someone at..." |
| `[174]` | **""Nonsense. Lucian's been nothing but loyal.""** | `[169]` **Livia Suno**: ""And from what I've seen, this m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Petr Vectern**: ""Loyal to you. It's true, he nev..." |
| `[185]` | **""Lucian, can I speak to you alone for a moment?""** | `[184]` **Narrator**: "Who could I believe?" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "Petr and Livia exchanged worried..." |
| `[186]` | **""Petr, Livia -- out. Now!""** | `[184]` **Narrator**: "Who could I believe?" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "Petr and Livia exchanged worried..." |
| `[187]` | **""Petr and Livia, please wait outside while I try to talk some sense into Lucian.""** | `[184]` **Narrator**: "Who could I believe?" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "Petr and Livia exchanged worried..." |
| `[190]` | **""I believe you. We should investigate Livia.""** | `[189]` **Lucian Galade**: ""What are you going to do, Mr. P..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[197]` **Narrator**: "Lucian breathed a sigh of relief." |
| `[191]` | **""Honestly, I ought to fire you for surveilling Petr.""** | `[189]` **Lucian Galade**: ""What are you going to do, Mr. P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Lucian Galade**: ""What else could I have done? Yo..." |
| `[192]` | **""You're the strategist here, not me. You make the call.""** | `[189]` **Lucian Galade**: ""What are you going to do, Mr. P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Lucian Galade**: ""I already told you what we shou..." |
| `[193]` | **""I'm not investigating my own secretary. I won't play into your hands.""** | `[189]` **Lucian Galade**: ""What are you going to do, Mr. P..."<br>`[195]` **Lucian Galade**: ""I already told you what we shou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Lucian Galade**: ""Then you're playing straight in..." |
| `[199]` | **""And if she does turn out to be a spy, and word gets out? I'll look like a fool.""** | `[195]` **Lucian Galade**: ""I already told you what we shou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Lucian Galade**: ""Not if Mr. Vectern shoulders th..." |
| `[200]` | **""Not if Mr. Vectern shoulders the blame. As he should.""** | `[199]` **Player**: ""And if she does turn out to be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Player**: ""I wouldn't make him do that.""<br>`[205]` **Player**: ""True, he was the one who hired ..."<br>*(oraz 1 innych odgałęzień)* |
| `[201]` | **""I'll settle that with him personally.""** | `[198]` **Lucian Galade**: ""And Mr. Vectern? What will you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Lucian Galade**: ""Very well. Just keep in mind yo..." |
| `[202]` | **""I'll decide that once we have the results.""** | `[198]` **Lucian Galade**: ""And Mr. Vectern? What will you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Lucian Galade**: ""Very well. Just keep in mind yo..." |
| `[204]` | **""I wouldn't make him do that.""** | `[200]` **Lucian Galade**: ""Not if Mr. Vectern shoulders th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Lucian Galade**: ""Sir, do I have your permission ..." |
| `[205]` | **""True, he was the one who hired her...""** | `[200]` **Lucian Galade**: ""Not if Mr. Vectern shoulders th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Lucian Galade**: ""Sir, do I have your permission ..." |
| `[206]` | **""We'll decide that when the time comes.""** | `[200]` **Lucian Galade**: ""Not if Mr. Vectern shoulders th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Lucian Galade**: ""Sir, do I have your permission ..." |
| `[207]` | **""Livia was right. You do have it out for him.""** | `[194]` **Lucian Galade**: ""What else could I have done? Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Lucian Galade**: ""I am only looking out for you, ..." |
| `[208]` | **""You might have a point. He's not the man he once was.""** | `[194]` **Lucian Galade**: ""What else could I have done? Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Lucian Galade**: ""He's exactly the man he once wa..." |
| `[212]` | **""Evelyn also told me something to that effect.""** | `[194]` **Lucian Galade**: ""What else could I have done? Yo..." | `Variable["BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair"]` | *Brak zmian stanu* | `[227]` **Lucian Galade**: ""That poor woman."" |
| `[213]` | **""Petr's problems aren't your business.""** | `[194]` **Lucian Galade**: ""What else could I have done? Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Lucian Galade**: ""I am only looking out for you, ..." |
| `[214]` | **""Get a grip on yourself, Lucian. There is no spy.""** | `[196]` **Lucian Galade**: ""Then you're playing straight in..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[236]` **Lucian Galade**: ""Sir, this is a mistake."" |
| `[215]` | **""Fine. Let's investigate her just to be on the safe side.""** | `[196]` **Lucian Galade**: ""Then you're playing straight in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Narrator**: "Lucian breathed a sigh of relief." |
| `[217]` | **""Yes.""** | `[216]` **Lucian Galade**: ""Sir, do I have your permission ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Li...` | `[221]` **Narrator**: "Lucian adjusted his tie." |
| `[218]` | **""No. Livia and Petr will continue working for me as usual. None of this happened.""** | `[216]` **Lucian Galade**: ""Sir, do I have your permission ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[236]` **Lucian Galade**: ""Sir, this is a mistake."" |
| `[219]` | **""Petr did what any man would. You'd understand if you weren't a workaholic.""** | `[198]` **Lucian Galade**: ""And Mr. Vectern? What will you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Lucian Galade**: ""It's a legitimate orientation, ..." |
| `[228]` | **""Yes. Just to be safe.""** | `[226]` **Lucian Galade**: ""Just tell me, do I have your pe..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Li...` | `[221]` **Narrator**: "Lucian adjusted his tie." |
| `[229]` | **""No. Livia and Petr will continue working for me as usual. None of this happened.""** | `[226]` **Lucian Galade**: ""Just tell me, do I have your pe..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[236]` **Lucian Galade**: ""Sir, this is a mistake."" |
| `[230]` | **""Right. Let's do it.""** | `[195]` **Lucian Galade**: ""I already told you what we shou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[197]` **Narrator**: "Lucian breathed a sigh of relief." |
| `[232]` | **""Livia was right. You're completely off your rocker.""** | `[196]` **Lucian Galade**: ""Then you're playing straight in..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable[...` | `[236]` **Lucian Galade**: ""Sir, this is a mistake."" |
| `[237]` | **""From now on, I'll ask when I want your advice.""** | `[236]` **Lucian Galade**: ""Sir, this is a mistake."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "Lucian clenched his jaw. I'd nev..." |
| `[238]` | **""I don't want to hear another word against either of them again.""** | `[236]` **Lucian Galade**: ""Sir, this is a mistake."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "Lucian clenched his jaw. I'd nev..." |
| `[239]` | **""This is my decision. I'll face the consequences.""** | `[236]` **Lucian Galade**: ""Sir, this is a mistake."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "Lucian clenched his jaw. I'd nev..." |
| `[240]` | **""Thank you.""** | `[222]` **Lucian Galade**: ""I'll apologize to Miss Suno and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Lucian Galade**: ""Very well, sir."" |
| `[241]` | **""No, I'll do it myself. She's too suspicious of you.""** | `[222]` **Lucian Galade**: ""I'll apologize to Miss Suno and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Lucian Galade**: ""Very well, sir."" |
| `[242]` | **""Fine. But I'm warning you -- don't spy on your colleagues. Ever again.""** | `[222]` **Lucian Galade**: ""I'll apologize to Miss Suno and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Lucian Galade**: ""Very well, sir."" |

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
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_AffairMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_AffairMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "It was early in the morning after my talk with Petr. The sun was just beginning to peek over the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_InformLucianAboutAffair == ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_InformLucianAboutAffair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_InformLucianAboutAffair == ..."*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_InformLucianAboutAffair =..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_InformLucianAboutAffair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_InformLucianAboutAffair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The Maroon Palace was empty save for a few cleaning staff..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_InformLucianAboutAffair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_InformLucianAboutAffair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "I couldn't sleep, so I decided I might as well head to th..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "The Maroon Palace was empty save for a few cleaning staff. I entered my office to find Lucian already waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: ""Mr. President. Thank you for meeting with me at this hour.""*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The Maroon Palace was empty save for a few cleaning staff. I entered my office and was shocked to see Lucian already there, waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""Mr. President. Good. I was hoping you'd be early.""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I couldn't sleep, so I decided I might as well head to the palace early and get some uninterrupted work done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The Maroon Palace was empty save for a few cleaning staff..."*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Mr. President. Good. I was hoping you'd be early.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""Lucian, I know you're punctual, but this is ridiculous!""*)
  - -> `[13]` (*Player: ""What's going on?""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Lucian, I know you're punctual, but this is ridiculous!""]** — Mówca: **Player**
> ""Lucian, I know you're punctual, but this is ridiculous!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""I have a sensitive matter to discuss.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""What's going on?""]** — Mówca: **Player**
> ""What's going on?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""I have a sensitive matter to discuss.""*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Mr. President. Thank you for meeting with me at this hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""I couldn't sleep anyway.""*)
  - -> `[16]` (*Player: ""Cut to the chase.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I couldn't sleep anyway.""]** — Mówca: **Player**
> ""I couldn't sleep anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""Very well. I'm pleased that you chose to call me after y..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Cut to the chase.""]** — Mówca: **Player**
> ""Cut to the chase.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""Very well. I'm pleased that you chose to call me after y..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""Very well. I'm pleased that you chose to call me after your conversation with Mr. Vectern last night -- although I was already aware of his illicit relationship with Miss Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: ""I figured as much. You do know everything that goes on i..."*)
  - -> `[19]` (*Player: ""How did you find out?""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I figured as much. You do know everything that goes on in the Palace, after all.""]** — Mówca: **Player**
> ""I figured as much. You do know everything that goes on in the Palace, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion += 1"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""How did you find out?""]** — Mówca: **Player**
> ""How did you find out?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""I'll get to that.""*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""I'll get to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""On its own, given Mr. Vectern's established reputation a..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Lucian smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""On its own, given Mr. Vectern's established reputation a..."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""On its own, given Mr. Vectern's established reputation as something of a playboy, the affair is unlikely to cause much damage. However, a more troubling possibility has been brought to light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsyl..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: ""A recent conversation with Mr. Hailstone, our whistleblo..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: ""For some time now, I have privately suspected the presen..."*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""A recent conversation with Mr. Hailstone, our whistleblower from Rumburg, revealed the presence of a spy within the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""I believe Miss Suno is our mole. She has been using her ..."*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""For some time now, I have privately suspected the presence of an intelligence leak coming from within the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""I believe Miss Suno is our mole. She has been using her ..."*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""I have a sensitive matter to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""I have very good reason to believe your vice president a..."*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""I have very good reason to believe your vice president and your secretary are engaging in illicit relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Yes, he told me. It's over now.""*)
  - -> `[32]` (*Player: ""I know. We're handling it.""*)
  - -> `[31]` (*Player: ""What? Unbelievable!""*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Yes, he told me. It's over now.""]** — Mówca: **Player**
> ""Yes, he told me. It's over now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Lucian gave me a wounded look."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""What? Unbelievable!""]** — Mówca: **Player**
> ""What? Unbelievable!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""I'm sorry to be the bearer of this news.""*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""I know. We're handling it.""]** — Mówca: **Player**
> ""I know. We're handling it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Lucian gave me a wounded look."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Lucian gave me a wounded look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: ""You knew, and you didn't come to me with this information?""*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""You knew, and you didn't come to me with this information?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: ""I assumed you were already aware. You do know everything..."*)
  - -> `[36]` (*Player: ""I don't need your help. We've got this under control.""*)
  - -> `[37]` (*Player: ""He only told me yesterday. I was going to come to you fi..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""I assumed you were already aware. You do know everything that goes on in this palace, after all.""]** — Mówca: **Player**
> ""I assumed you were already aware. You do know everything that goes on in this palace, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion += 1"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""I don't need your help. We've got this under control.""]** — Mówca: **Player**
> ""I don't need your help. We've got this under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""He only told me yesterday. I was going to come to you first thing today.""]** — Mówca: **Player**
> ""He only told me yesterday. I was going to come to you first thing today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: ""Well, don't hesitate to call straight away next time.""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Lucian smiled."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Lucian frowned."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Lucian frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""On its own, given Mr. Vectern's established reputation a..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Lucian smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""On its own, given Mr. Vectern's established reputation a..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Lucian smiled."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""I'm sorry to be the bearer of this news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""On its own, given Mr. Vectern's established reputation a..."*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Well, don't hesitate to call straight away next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""On its own, given Mr. Vectern's established reputation a..."*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""I believe Miss Suno is our mole. She has been using her relationship with Mr. Vectern to gather information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Italic: "Laugh incredulously."*)
  - -> `[47]` (*Player: ""Tell me more.""*)
  - -> `[48]` (*Player: ""You're being paranoid, Lucian.""*)
  - -> `[49]` (*Player: ""That's preposterous.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "Laugh incredulously."]** — Mówca: **Player_Italic**
> "I laughed incredulously."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""I wish I was wrong, sir. But I've just come into possess..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Tell me more.""]** — Mówca: **Player**
> ""Tell me more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion += 1"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""You're being paranoid, Lucian.""]** — Mówca: **Player**
> ""You're being paranoid, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""I wish I was wrong, sir. But I've just come into possess..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""That's preposterous.""]** — Mówca: **Player**
> ""That's preposterous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""I wish I was wrong, sir. But I've just come into possess..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Lucian reached into his coat pocket, pulled out an audio tape and fed it into the reel-to-reel machine on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame..."*)

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""This was recorded in the Palace at 18:09 on the second day of your trade visit to Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ReelToReel");"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.Valgsland_TradeDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGa..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.Valgsland_TradeDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  and  Variable["BaseGame.Valgsland_TradeDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""This was recorded in the Palace at 18:09 on the second d..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.Valgsland_TradeDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  and  Variable["BaseGame.Valgsland_TradeDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Valgsland == true && BaseG..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Valgsland == true && BaseGame.Lespia_TradeDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Valgsland == true && BaseG..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.TradeDeal_Negotiation_Valgsland == true && Bas..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Valgsland == true && BaseGame.Lespia_TradeDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true  and  Variable["BaseGame.Lespia_TradeDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""This was recorded in the Palace at 18:09 on the second d..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.TradeDeal_Negotiation_Valgsland == true && BaseGame.Lespia_TradeDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true  and  Variable["BaseGame.Lespia_TradeDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: ""This was recorded in the Palace at 18:09 following our r..."*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""This was recorded in the Palace at 18:09 following our return from the meeting with Deivid Wisci in Benfi.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ReelToReel");"*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""This was recorded in the Palace at 18:09 on the second day of your trade visit to Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ReelToReel");"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "He pressed play. I heard Petr and Livia's voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Livia Suno: ""You're sure everyone's gone for the day?""*)

### Węzeł `[61]`
Mówca: **Livia Suno**
> ""You're sure everyone's gone for the day?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Alli..."*)

### Węzeł `[62]`
Mówca: **Petr Vectern**
> ""Relax, Liv. Nobody's working that hard with Anton off in Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Livia giggled. I heard the sound of kissing, then of drin..."*)

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""Relax, Liv. Nobody's working that hard with Anton off in Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Livia giggled. I heard the sound of kissing, then of drin..."*)

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""Relax, Liv. You don't have to bend over backwards for my pal Anton tonight. Only me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Livia giggled. I heard the sound of kissing, then of drin..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Livia giggled. I heard the sound of kissing, then of drinks being poured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Livia Suno: ""Mmm. I'm glad you stayed behind.""*)

### Węzeł `[66]`
Mówca: **Livia Suno**
> ""Mmm. I'm glad you stayed behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Livia Suno: ""Did he tell you how it's going over there? Do you think ..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Livia giggled. I heard the sound of kissing, then of drinks being poured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Livia Suno: ""Mmm. I'm glad you stayed behind.""*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Livia giggled. I heard the sound of kissing, then of drinks being poured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Livia Suno: ""Mmm. I missed you in Benfi.""*)

### Węzeł `[69]`
Mówca: **Livia Suno**
> ""Mmm. I missed you in Benfi.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Livia Suno: ""Did he tell you why he decided not to make a deal with L..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""I wish I was wrong, sir. But I've just come into possession of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Lucian reached into his coat pocket, pulled out an audio ..."*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""I can do better than that -- I'll show you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Lucian reached into his coat pocket, pulled out an audio ..."*)

### Węzeł `[72]`
Mówca: **Livia Suno**
> ""Did he tell you how it's going over there? Do you think there's a chance they'll form an alliance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[73]`
Mówca: **Livia Suno**
> ""Did he tell you why he decided not to make a deal with Lespia or Valgsland? He's not interested in forming any alliances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Petr Vectern: ""Ah, something about staying as neutral as possible. Alth..."*)

### Węzeł `[74]`
Mówca: **Petr Vectern**
> ""As a matter of fact, yes. He and Prime Minister Alvarez just sealed the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Petr Vectern: ""I think Anton is making the moves to isolate Rumburg ste..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true )"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: ""As a matter of fact, yes. He and Prime Minister Alvarez ..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Petr Vectern: ""As a matter of fact, yes. He and Secretary Hegel just se..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Petr Vectern: ""No, doesn't seem like it. We'll have to find other alter..."*)

### Węzeł `[81]`
Mówca: **Petr Vectern**
> ""As a matter of fact, yes. He and Secretary Hegel just sealed the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Petr Vectern: ""I think Anton is making the moves to isolate Rumburg ste..."*)

### Węzeł `[82]`
Mówca: **Petr Vectern**
> ""The embargo diminished our chances with United Contana. Although we've still got a shot with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Petr Vectern: "We opened a new line of communication with Ventrie City. ..."*)

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""Ah, something about staying as neutral as possible. Although even Iosef is saying we should find allies to deter Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && Ba..."*)

### Węzeł `[84]`
Mówca: **Petr Vectern**
> ""But speaking of forming alliances, Miss Suno...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Petr Vectern");"*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Lucian grimaced and switched the tape off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""That's it? That's your damning evidence?""*)
  - -> `[87]` (*Player: ""This is indeed cause for concern.""*)
  - -> `[88]` (*Player: ""Curiosity about foreign relations doesn't make one a spy.""*)
  - -> `[89]` (*Player: ""And then what happened?""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""That's it? That's your damning evidence?""]** — Mówca: **Player**
> ""That's it? That's your damning evidence?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""Think about it. Why so much curiosity about these partic..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""This is indeed cause for concern.""]** — Mówca: **Player**
> ""This is indeed cause for concern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I'm glad you agree.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Curiosity about foreign relations doesn't make one a spy.""]** — Mówca: **Player**
> ""Curiosity about foreign relations doesn't make one a spy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""Perhaps, but why so much curiosity about these particula..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""And then what happened?""]** — Mówca: **Player**
> ""And then what happened?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: ""You don't need to hear the rest of it. The important que..."*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""You don't need to hear the rest of it. The important question is, why so much curiosity about these particular alliances, if not because they could strengthen us against Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""And that's not all. I found her resume on file and there..."*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""And that's not all. I found her resume on file and there..."*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""Perhaps, but why so much curiosity about these particular alliances, if not because they could strengthen us against Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""And that's not all. I found her resume on file and there..."*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""Think about it. Why so much curiosity about these particular alliances, if not because they could strengthen us against Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""And that's not all. I found her resume on file and there..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Just then, there was a knock on the door. Livia opened it cautiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Livia Suno: ""Good morning, Mr. President, Mr. Galade. I didn't realiz..."*)

### Węzeł `[95]`
Mówca: **Livia Suno**
> ""Good morning, Mr. President, Mr. Galade. I didn't realize you'd be in so early. Can I get you some coffee?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Italic: "Wait for Lucian to say something."*)
  - -> `[97]` (*Player: ""Coffee would be great, actually.""*)
  - -> `[96]` (*Player: ""Close the door. Have a seat.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""Close the door. Have a seat.""]** — Mówca: **Player**
> ""Close the door. Have a seat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Livia sat. She looked puzzled."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Coffee would be great, actually.""]** — Mówca: **Player**
> ""Coffee would be great, actually.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Livia left to make coffee. A few minutes later, she came ..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "Wait for Lucian to say something."]** — Mówca: **Player_Italic**
> "I stayed silent. Lucian finally spoke up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucian Galade: ""Please have a seat, Miss Suno.""*)

### Węzeł `[99]`
Mówca: **Lucian Galade**
> ""Please have a seat, Miss Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Livia sat. She looked puzzled."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Livia left to make coffee. A few minutes later, she came back and served the coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucian Galade: ""Please have a seat, Miss Suno.""*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Livia sat. She looked puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Livia Suno: ""Is something the matter?""*)

### Węzeł `[102]`
Mówca: **Livia Suno**
> ""Is something the matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""Enough pretending. Your secret is out.""*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""Enough pretending. Your secret is out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Livia Suno: ""I... I'm not sure what you're talking about.""*)

### Węzeł `[104]`
Mówca: **Livia Suno**
> ""I... I'm not sure what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""Come on, Livia. Petr already told me everything.""*)
  - -> `[106]` (*Player: ""You know perfectly well.""*)
  - -> `[107]` (*Player: ""Livia. Lucian has evidence.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Come on, Livia. Petr already told me everything.""]** — Mówca: **Player**
> ""Come on, Livia. Petr already told me everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Livia buried her face in her hands."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""You know perfectly well.""]** — Mówca: **Player**
> ""You know perfectly well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Livia buried her face in her hands."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Livia. Lucian has evidence.""]** — Mówca: **Player**
> ""Livia. Lucian has evidence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Livia buried her face in her hands."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Livia buried her face in her hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Livia Suno: ""I'm so sorry, Mr. President. I was foolish, and Petr was..."*)

### Węzeł `[109]`
Mówca: **Livia Suno**
> ""I'm so sorry, Mr. President. I was foolish, and Petr was so nice to me... But it's over now. Nobody ever needs to know--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: ""That's not what the President means, Miss Suno. We're re..."*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""That's not what the President means, Miss Suno. We're referring to you being an intelligence agent for Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Livia sat upright. She looked shocked."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Livia sat upright. She looked shocked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Livia Suno: ""Pardon me, Mr. Galade, but are you feeling all right?""*)

### Węzeł `[112]`
Mówca: **Livia Suno**
> ""Pardon me, Mr. Galade, but are you feeling all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""No, he isn't. You'll have to excuse him.""*)
  - -> `[118]` (*Player: ""I know. It sounds ridiculous to me as well.""*)
  - -> `[114]` (*Player: ""Don't play dumb, Livia. If that is your real name.""*)
  - -> `[115]` (*Player: ""He's fine. What do you have to say for yourself?""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""No, he isn't. You'll have to excuse him.""]** — Mówca: **Player**
> ""No, he isn't. You'll have to excuse him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Lucian folded his arms."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Don't play dumb, Livia. If that is your real name.""]** — Mówca: **Player**
> ""Don't play dumb, Livia. If that is your real name.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Livia Suno: ""Mr. President, I understand if you don't want me to keep..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""He's fine. What do you have to say for yourself?""]** — Mówca: **Player**
> ""He's fine. What do you have to say for yourself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Livia Suno: ""Mr. President, I understand if you don't want me to keep..."*)

### Węzeł `[116]`
Mówca: **Lucian Galade**
> ""And that's not all. I found her resume on file and there's a year-long gap between her finishing secretarial school and beginning her career.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lucian Galade: ""Normally, this would have been looked into. But Miss Sun..."*)

### Węzeł `[117]`
Mówca: **Lucian Galade**
> ""Normally, this would have been looked into. But Miss Suno was hired before a background check could be completed. By one Petr Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "AddConversant("Livia Suno");"*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""I know. It sounds ridiculous to me as well.""]** — Mówca: **Player**
> ""I know. It sounds ridiculous to me as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Lucian folded his arms."*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""Miss Suno, indulge me for a moment. What were you doing in the year 1951?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Livia's face flushed."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Lucian folded his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: ""Miss Suno, indulge me for a moment. What were you doing ..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Livia's face flushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Livia Suno: ""If you must know, I was working as a cigarette girl at P..."*)

### Węzeł `[122]`
Mówca: **Livia Suno**
> ""If you must know, I was working as a cigarette girl at Porto's. It's a Lachaven saloon. I was saving up so I could afford my own place in Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Livia Suno: ""Here's the proprietor's number if you need to double che..."*)

### Węzeł `[123]`
Mówca: **Livia Suno**
> ""Here's the proprietor's number if you need to double check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "She scribbled a telephone number on a piece of paper. Luc..."*)

### Węzeł `[124]`
Mówca: **Livia Suno**
> ""Mr. President, I understand if you don't want me to keep my job, but why smear me with outlandish accusations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: ""Miss Suno, indulge me for a moment. What were you doing ..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "She scribbled a telephone number on a piece of paper. Lucian snatched it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: ""But why have you been asking me so many questions about ..."*)
  - -> `[127]` (*Player: ""But why were you asking Petr about my alliances?""*)
  - -> `[128]` (*Player: ""But why were you so eager to help Deivid back in Benfi?""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""But why have you been asking me so many questions about what I do?""]** — Mówca: **Player**
> ""But why have you been asking me so many questions about what I do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Livia Suno: ""To tell the truth, Mr. Rayne... I was hoping to run for ..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""But why were you asking Petr about my alliances?""]** — Mówca: **Player**
> ""But why were you asking Petr about my alliances?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Livia Suno: ""To tell the truth, Mr. Rayne... I was hoping to run for ..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""But why were you so eager to help Deivid back in Benfi?""]** — Mówca: **Player**
> ""But why were you so eager to help Deivid back in Benfi?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Livia Suno: ""To tell the truth, Mr. Rayne... I was hoping to run for ..."*)

### Węzeł `[129]`
Mówca: **Livia Suno**
> ""To tell the truth, Mr. Rayne... I was hoping to run for office myself someday. I want to make a real difference in the world, like Ms. Morgna or Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Livia Suno: ""But I guess I messed that up by getting involved with Pe..."*)

### Węzeł `[130]`
Mówca: **Livia Suno**
> ""But I guess I messed that up by getting involved with Petr. Now they're all just going to say I slept my way to the top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: ""And your questioning Petr about Sordland's potential all..."*)

### Węzeł `[131]`
Mówca: **Livia Suno**
> ""To tell the truth, Mr. Rayne... I was hoping to run for office myself someday. I want to make a real difference in the world, like Ms. Morgna or Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Livia Suno: ""But I guess I messed that up by getting involved with Pe..."*)

### Węzeł `[132]`
Mówca: **Livia Suno**
> ""But I guess I messed that up by getting involved with Petr. Now they're all just going to say I slept my way to the top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Livia Suno: ""Wait. How did you know about that conversation?""*)

### Węzeł `[133]`
Mówca: **Livia Suno**
> ""But I guess I messed that up by getting involved with Petr. Now they're all just going to say I slept my way to the top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""And your questioning Petr about Sordland's potential all..."*)

### Węzeł `[134]`
Mówca: **Livia Suno**
> ""To tell the truth, Mr. Rayne... I was hoping to run for office myself someday. I want to make a real difference in the world, like Ms. Morgna or Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Livia Suno: ""But I guess I messed that up by getting involved with Pe..."*)

### Węzeł `[135]`
Mówca: **Livia Suno**
> ""Wait. How did you know about that conversation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "There was a loud pounding on the door. Petr barged in wit..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "There was a loud pounding on the door. Petr barged in without waiting for an answer. He was unshaven, and wore the same clothes as the night before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Petr Vectern: ""I came as soon as I heard the three of you were in here...."*)

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""And your questioning Petr about Sordland's potential alliances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Livia Suno: ""I told you, I-- wait. How do you know about that?""*)

### Węzeł `[138]`
Mówca: **Lucian Galade**
> ""And your questioning Petr about Sordland's potential alliances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Livia Suno: ""I told you, I-- wait. How do you know about that?""*)

### Węzeł `[139]`
Mówca: **Livia Suno**
> ""I told you, I-- wait. How do you know about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "There was a loud pounding on the door. Petr barged in wit..."*)

### Węzeł `[140]`
Mówca: **Livia Suno**
> ""I told you, I-- wait. How do you know about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "There was a loud pounding on the door. Petr barged in wit..."*)

### Węzeł `[141]`
Mówca: **Petr Vectern**
> ""I came as soon as I heard the three of you were in here. Anton, what the hell are you doing? I told you I had this under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: ""Sorry. I had to tell Lucian.""*)
  - -> `[144]` (*Player: ""Sorry. Lucian already found out.""*)
  - -> `[145]` (*Player: ""Sit down and shut up.""*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""I can do better than that -- I'll show you.""*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Sorry. I had to tell Lucian.""]** — Mówca: **Player**
> ""Sorry. I had to tell Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Petr took a seat on the far end of the sofa. He looked ov..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""Sorry. Lucian already found out.""]** — Mówca: **Player**
> ""Sorry. Lucian already found out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Petr took a seat on the far end of the sofa. He looked ov..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""Sit down and shut up.""]** — Mówca: **Player**
> ""Sit down and shut up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Petr took a seat on the far end of the sofa. He looked ov..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Petr took a seat on the far end of the sofa. He looked over at Livia and noticed her troubled expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Petr Vectern: ""God, why involve her? This is my mess. She did nothing w..."*)

### Węzeł `[147]`
Mówca: **Petr Vectern**
> ""God, why involve her? This is my mess. She did nothing wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""Well... there's a small chance she could be a spy.""*)
  - -> `[149]` (*Player: ""Lucian has the preposterous idea that she's a spy.""*)
  - -> `[148]` (*Player: ""She's a spy, Petr. You messed up big-time.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""She's a spy, Petr. You messed up big-time.""]** — Mówca: **Player**
> ""She's a spy, Petr. You messed up big-time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: ""I-- what?!""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Lucian has the preposterous idea that she's a spy.""]** — Mówca: **Player**
> ""Lucian has the preposterous idea that she's a spy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: ""I-- what?!""*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Well... there's a small chance she could be a spy.""]** — Mówca: **Player**
> ""Well... there's a small chance she could be a spy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: ""I-- what?!""*)

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""I-- what?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: ""I have reason to believe she's been relaying information..."*)

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""I have reason to believe she's been relaying information to Rumburg. Information that you leaked to her in your carelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Lucian rewound his tape and played it again. As Petr list..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Lucian rewound his tape and played it again. As Petr listened, his eyes widened in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Petr Vectern: ""Lucian, you rat bastard. You've been bugging my office!""*)

### Węzeł `[154]`
Mówca: **Petr Vectern**
> ""Lucian, you rat bastard. You've been bugging my office!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: ""Obviously for a good reason.""*)
  - -> `[156]` (*Player: ""Lucian, is this true? How could you?""*)
  - -> `[157]` (*Player: ""I'm sure there's an explanation for this.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""Obviously for a good reason.""]** — Mówca: **Player**
> ""Obviously for a good reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Both Petr and Livia were glaring at Lucian now. He looked..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA: ""Lucian, is this true? How could you?""]** — Mówca: **Player**
> ""Lucian, is this true? How could you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Both Petr and Livia were glaring at Lucian now. He looked..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I'm sure there's an explanation for this.""]** — Mówca: **Player**
> ""I'm sure there's an explanation for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Both Petr and Livia were glaring at Lucian now. He looked..."*)

### Węzeł `[158]`
Mówca: **Lucian Galade**
> ""I had noticed the Vice President's behaviour becoming increasingly erratic and unprofessional over the past months. I wanted to get to the root of the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Petr Vectern: ""So you wiretapped your own goddamn colleague? And for wh..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "Both Petr and Livia were glaring at Lucian now. He looked unrepentant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Lucian Galade: ""I had noticed the Vice President's behaviour becoming in..."*)

### Węzeł `[160]`
Mówca: **Petr Vectern**
> ""So you wiretapped your own goddamn colleague? And for what? Have you been getting off on this, you pervert?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""Certainly not. I believe that along with the Rumburg whistleblower's admission that there is a spy in the Palace and certain gaps in Miss Suno's resume, this tape makes a compelling case to investigate the secretary for espionage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucian Galade: ""Whether or not the investigation yields positive results..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsyl..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucian Galade: ""Certainly not. I believe that along with the Rumburg whi..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lucian Galade: ""Certainly not. I believe that along with certain gaps in..."*)

### Węzeł `[165]`
Mówca: **Lucian Galade**
> ""Certainly not. I believe that along with certain gaps in Miss Suno's resume, this tape makes a compelling case to investigate the secretary for espionage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucian Galade: ""Whether or not the investigation yields positive results..."*)

### Węzeł `[166]`
Mówca: **Lucian Galade**
> ""Whether or not the investigation yields positive results, Mr. Vectern ought to be held accountable for his willingness to divulge such sensitive information. He ought to stand trial or, at the very least, resign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Petr's jaw dropped. Livia stood up."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Petr's jaw dropped. Livia stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Livia Suno: ""If I may, Mr. President. I've been paying attention to w..."*)

### Węzeł `[168]`
Mówca: **Livia Suno**
> ""If I may, Mr. President. I've been paying attention to what goes on in the Palace. Not because I'm some sort of agent, but out of genuine interest. Hard as that may be for you to believe, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "She scowled at Lucian, then turned back to me."*)

### Węzeł `[169]`
Mówca: **Livia Suno**
> ""And from what I've seen, this man has been attempting to undermine your vice president at every turn. Perhaps with the goal of replacing Petr himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Of course you'd say that. Petr's your lover.""*)
  - -> `[172]` (*Player: ""That's ridiculous. I would never make Lucian vice presid..."*)
  - -> `[174]` (*Player: ""Nonsense. Lucian's been nothing but loyal.""*)
  - -> `[173]` (*Player: ""That actually makes a lot of sense.""*)

### Węzeł `[170]`
Mówca: **Narrator**
> "She scowled at Lucian, then turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Livia Suno: ""And from what I've seen, this man has been attempting to..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Of course you'd say that. Petr's your lover.""]** — Mówca: **Player**
> ""Of course you'd say that. Petr's your lover.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Livia looked at Petr on the other end of the couch. Her e..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""That's ridiculous. I would never make Lucian vice president.""]** — Mówca: **Player**
> ""That's ridiculous. I would never make Lucian vice president.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""That actually makes a lot of sense.""]** — Mówca: **Player**
> ""That actually makes a lot of sense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Livia Suno: ""Thank you. I'm happy someone at the Palace still takes m..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Nonsense. Lucian's been nothing but loyal.""]** — Mówca: **Player**
> ""Nonsense. Lucian's been nothing but loyal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Petr Vectern: ""Loyal to you. It's true, he never could stand me.""*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Lucian looked slightly shaken at that remark, but quickly regained his usual grace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: ""My personal misgivings about Mr. Vectern aside, I would ..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Lucian looked slightly shaken at that remark, but quickly..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Livia looked at Petr on the other end of the couch. Her eyes softened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Livia Suno: ""He *was* my lover. We've put this behind us. The two of ..."*)

### Węzeł `[178]`
Mówca: **Livia Suno**
> ""He *was* my lover. We've put this behind us. The two of you ought to do so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Lucian frowned."*)

### Węzeł `[179]`
Mówca: **Petr Vectern**
> ""Loyal to you. It's true, he never could stand me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Lucian frowned."*)

### Węzeł `[180]`
Mówca: **Livia Suno**
> ""Thank you. I'm happy someone at the Palace still takes me seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Lucian frowned."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Lucian frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: ""My personal misgivings about Mr. Vectern aside, I would ..."*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""My personal misgivings about Mr. Vectern aside, I would never do anything to harm this administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucian Galade: ""Mr. Vectern, on the other hand, has at best committed ad..."*)

### Węzeł `[183]`
Mówca: **Lucian Galade**
> ""Mr. Vectern, on the other hand, has at best committed adultery, and at worst, delivered state secrets straight into enemy hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Who could I believe?"*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Who could I believe?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: ""Lucian, can I speak to you alone for a moment?""*)
  - -> `[186]` (*Player: ""Petr, Livia -- out. Now!""*)
  - -> `[187]` (*Player: ""Petr and Livia, please wait outside while I try to talk ..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA: ""Lucian, can I speak to you alone for a moment?""]** — Mówca: **Player**
> ""Lucian, can I speak to you alone for a moment?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Petr and Livia exchanged worried glances before exiting m..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: ""Petr, Livia -- out. Now!""]** — Mówca: **Player**
> ""Petr, Livia -- out. Now!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Petr and Livia exchanged worried glances before exiting m..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Petr and Livia, please wait outside while I try to talk some sense into Lucian.""]** — Mówca: **Player**
> ""Petr and Livia, please wait outside while I try to talk some sense into Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Petr and Livia exchanged worried glances before exiting m..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Petr and Livia exchanged worried glances before exiting my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucian Galade: ""What are you going to do, Mr. President?""*)

### Węzeł `[189]`
Mówca: **Lucian Galade**
> ""What are you going to do, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: ""I believe you. We should investigate Livia.""*)
  - -> `[192]` (*Player: ""You're the strategist here, not me. You make the call.""*)
  - -> `[191]` (*Player: ""Honestly, I ought to fire you for surveilling Petr.""*)
  - -> `[193]` (*Player: ""I'm not investigating my own secretary. I won't play int..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA: ""I believe you. We should investigate Livia.""]** — Mówca: **Player**
> ""I believe you. We should investigate Livia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion += 1"*)

### Węzeł `[191]`
**[WYBÓR GRACZA: ""Honestly, I ought to fire you for surveilling Petr.""]** — Mówca: **Player**
> ""Honestly, I ought to fire you for surveilling Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucian Galade: ""What else could I have done? You couldn't look past your..."*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""You're the strategist here, not me. You make the call.""]** — Mówca: **Player**
> ""You're the strategist here, not me. You make the call.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lucian Galade: ""I already told you what we should do, sir. Investigate M..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""I'm not investigating my own secretary. I won't play into your hands.""]** — Mówca: **Player**
> ""I'm not investigating my own secretary. I won't play into your hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Lucian Galade), `[195]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Lucian Galade: ""Then you're playing straight into Rumburg's.""*)

### Węzeł `[194]`
Mówca: **Lucian Galade**
> ""What else could I have done? You couldn't look past your history together and see Mr. Vectern for who he truly is. You still can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player: ""Livia was right. You do have it out for him.""*)
  - -> `[213]` (*Player: ""Petr's problems aren't your business.""*)
  - -> `[208]` (*Player: ""You might have a point. He's not the man he once was.""*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair"*)

### Węzeł `[195]`
Mówca: **Lucian Galade**
> ""I already told you what we should do, sir. Investigate Miss Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: ""Right. Let's do it.""*)
  - -> `[199]` (*Player: ""And if she does turn out to be a spy, and word gets out?..."*)
  - -> `[193]` (*Player: ""I'm not investigating my own secretary. I won't play int..."*)

### Węzeł `[196]`
Mówca: **Lucian Galade**
> ""Then you're playing straight into Rumburg's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""Fine. Let's investigate her just to be on the safe side.""*)
  - -> `[214]` (*Player: ""Get a grip on yourself, Lucian. There is no spy.""*)
  - -> `[232]` (*Player: ""Livia was right. You're completely off your rocker.""*)

### Węzeł `[197]`
Mówca: **Narrator**
> "Lucian breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Lucian Galade: ""I appreciate your trust in me.""*)

### Węzeł `[198]`
Mówca: **Lucian Galade**
> ""And Mr. Vectern? What will you do about his willingness to compromise Sordland's security at the drop of a pencil skirt?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: ""Petr did what any man would. You'd understand if you wer..."*)
  - -> `[201]` (*Player: ""I'll settle that with him personally.""*)
  - -> `[202]` (*Player: ""I'll decide that once we have the results.""*)

### Węzeł `[199]`
**[WYBÓR GRACZA: ""And if she does turn out to be a spy, and word gets out? I'll look like a fool.""]** — Mówca: **Player**
> ""And if she does turn out to be a spy, and word gets out? I'll look like a fool.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lucian Galade: ""Not if Mr. Vectern shoulders the blame. As he should.""*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""Not if Mr. Vectern shoulders the blame. As he should.""]** — Mówca: **Lucian Galade**
> ""Not if Mr. Vectern shoulders the blame. As he should.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player: ""I wouldn't make him do that.""*)
  - -> `[205]` (*Player: ""True, he was the one who hired her...""*)
  - -> `[206]` (*Player: ""We'll decide that when the time comes.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA: ""I'll settle that with him personally.""]** — Mówca: **Player**
> ""I'll settle that with him personally.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucian Galade: ""Very well. Just keep in mind you may need him to shoulde..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA: ""I'll decide that once we have the results.""]** — Mówca: **Player**
> ""I'll decide that once we have the results.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucian Galade: ""Very well. Just keep in mind you may need him to shoulde..."*)

### Węzeł `[203]`
Mówca: **Lucian Galade**
> ""Very well. Just keep in mind you may need him to shoulder the blame for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated = true"*)

### Węzeł `[204]`
**[WYBÓR GRACZA: ""I wouldn't make him do that.""]** — Mówca: **Player**
> ""I wouldn't make him do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Lucian Galade: ""Sir, do I have your permission to proceed with the inves..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""True, he was the one who hired her...""]** — Mówca: **Player**
> ""True, he was the one who hired her...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Lucian Galade: ""Sir, do I have your permission to proceed with the inves..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""We'll decide that when the time comes.""]** — Mówca: **Player**
> ""We'll decide that when the time comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Lucian Galade: ""Sir, do I have your permission to proceed with the inves..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Livia was right. You do have it out for him.""]** — Mówca: **Player**
> ""Livia was right. You do have it out for him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucian Galade: ""I am only looking out for you, sir. The way I always do.""*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""You might have a point. He's not the man he once was.""]** — Mówca: **Player**
> ""You might have a point. He's not the man he once was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucian Galade: ""He's exactly the man he once was. That's the problem.""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: ""Evelyn also told me something to that effect.""*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA: ""Evelyn also told me something to that effect.""]** — Mówca: **Player**
> ""Evelyn also told me something to that effect.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair"]`
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucian Galade: ""That poor woman.""*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Petr's problems aren't your business.""]** — Mówca: **Player**
> ""Petr's problems aren't your business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucian Galade: ""I am only looking out for you, sir. The way I always do.""*)

### Węzeł `[214]`
**[WYBÓR GRACZA: ""Get a grip on yourself, Lucian. There is no spy.""]** — Mówca: **Player**
> ""Get a grip on yourself, Lucian. There is no spy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[215]`
**[WYBÓR GRACZA: ""Fine. Let's investigate her just to be on the safe side.""]** — Mówca: **Player**
> ""Fine. Let's investigate her just to be on the safe side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "Lucian breathed a sigh of relief."*)

### Węzeł `[216]`
Mówca: **Lucian Galade**
> ""Sir, do I have your permission to proceed with the investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player: ""Yes.""*)
  - -> `[218]` (*Player: ""No. Livia and Petr will continue working for me as usual..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated = true"*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""No. Livia and Petr will continue working for me as usual. None of this happened.""]** — Mówca: **Player**
> ""No. Livia and Petr will continue working for me as usual. None of this happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Petr did what any man would. You'd understand if you weren't a workaholic.""]** — Mówca: **Player**
> ""Petr did what any man would. You'd understand if you weren't a workaholic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: ""It's a legitimate orientation, sir. That aside, keep in ..."*)

### Węzeł `[220]`
Mówca: **Lucian Galade**
> ""It's a legitimate orientation, sir. That aside, keep in mind you may well need Petr to shoulder the blame for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated = true"*)

### Węzeł `[221]`
Mówca: **Narrator**
> "Lucian adjusted his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Lucian Galade: ""I'll apologize to Miss Suno and tell her this has all be..."*)

### Węzeł `[222]`
Mówca: **Lucian Galade**
> ""I'll apologize to Miss Suno and tell her this has all been a misunderstanding. We can't have her running away during the investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: ""Thank you.""*)
  - -> `[241]` (*Player: ""No, I'll do it myself. She's too suspicious of you.""*)
  - -> `[242]` (*Player: ""Fine. But I'm warning you -- don't spy on your colleague..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Lucian Galade: ""Sir, this is a mistake.""*)

### Węzeł `[224]`
Mówca: **Lucian Galade**
> ""I am only looking out for you, sir. The way I always do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: ""Just tell me, do I have your permission to launch an inv..."*)

### Węzeł `[225]`
Mówca: **Lucian Galade**
> ""He's exactly the man he once was. That's the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: ""Just tell me, do I have your permission to launch an inv..."*)

### Węzeł `[226]`
Mówca: **Lucian Galade**
> ""Just tell me, do I have your permission to launch an investigation into Miss Suno?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player: ""Yes. Just to be safe.""*)
  - -> `[229]` (*Player: ""No. Livia and Petr will continue working for me as usual..."*)

### Węzeł `[227]`
Mówca: **Lucian Galade**
> ""That poor woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: ""Just tell me, do I have your permission to launch an inv..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA: ""Yes. Just to be safe.""]** — Mówca: **Player**
> ""Yes. Just to be safe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaInvestigated = true"*)

### Węzeł `[229]`
**[WYBÓR GRACZA: ""No. Livia and Petr will continue working for me as usual. None of this happened.""]** — Mówca: **Player**
> ""No. Livia and Petr will continue working for me as usual. None of this happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[230]`
**[WYBÓR GRACZA: ""Right. Let's do it.""]** — Mówca: **Player**
> ""Right. Let's do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion += 1"*)

### Węzeł `[231]`
Mówca: **Lucian Galade**
> ""I appreciate your trust in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucian Galade: ""And Mr. Vectern? What will you do about his willingness ..."*)

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Livia was right. You're completely off your rocker.""]** — Mówca: **Player**
> ""Livia was right. You're completely off your rocker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Lucian Galade: ""Sir, this is a mistake.""*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "Lucian breathed a sigh of relief."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaInvestigated = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_LiviaInvesti..."*)

### Węzeł `[236]`
Mówca: **Lucian Galade**
> ""Sir, this is a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player: ""From now on, I'll ask when I want your advice.""*)
  - -> `[238]` (*Player: ""I don't want to hear another word against either of them..."*)
  - -> `[239]` (*Player: ""This is my decision. I'll face the consequences.""*)

### Węzeł `[237]`
**[WYBÓR GRACZA: ""From now on, I'll ask when I want your advice.""]** — Mówca: **Player**
> ""From now on, I'll ask when I want your advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Lucian clenched his jaw. I'd never seen him this unhinged..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA: ""I don't want to hear another word against either of them again.""]** — Mówca: **Player**
> ""I don't want to hear another word against either of them again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Lucian clenched his jaw. I'd never seen him this unhinged..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA: ""This is my decision. I'll face the consequences.""]** — Mówca: **Player**
> ""This is my decision. I'll face the consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Lucian clenched his jaw. I'd never seen him this unhinged..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucian Galade: ""Very well, sir.""*)

### Węzeł `[241]`
**[WYBÓR GRACZA: ""No, I'll do it myself. She's too suspicious of you.""]** — Mówca: **Player**
> ""No, I'll do it myself. She's too suspicious of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucian Galade: ""Very well, sir.""*)

### Węzeł `[242]`
**[WYBÓR GRACZA: ""Fine. But I'm warning you -- don't spy on your colleagues. Ever again.""]** — Mówca: **Player**
> ""Fine. But I'm warning you -- don't spy on your colleagues. Ever again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucian Galade: ""Very well, sir.""*)

### Węzeł `[243]`
Mówca: **Lucian Galade**
> ""Very well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Lucian gave a slight bow as he left the office."*)

### Węzeł `[244]`
Mówca: **Narrator**
> "Lucian gave a slight bow as he left the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "I sat by myself for a while, wondering what exactly I had..."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "I sat by myself for a while, wondering what exactly I had set into motion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_AffairMeeting = true"*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Lucian clenched his jaw. I'd never seen him this unhinged in all my years working with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucian Galade: ""Very well, sir.""*)

### Węzeł `[247]`
Mówca: **Lucian Galade**
> ""Very well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "He stood up and stiffly walked out of the office."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "He stood up and stiffly walked out of the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "I was right to defend my secretary and my best friend. Bu..."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "I was right to defend my secretary and my best friend. But I hoped I hadn't just made an enemy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_AffairMeeting = true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgslan..."*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgsl..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Petr Vectern: ""Relax, Liv. Nobody's working that hard with Anton off in..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Petr Vectern: ""Relax, Liv. You don't have to bend over backwards for my..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Alli..."*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Al..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_TradeDeal"] == true  or  Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Petr Vectern: ""Relax, Liv. Nobody's working that hard with Anton off in..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_TradeDeal"] == true  or  Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgslan..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaInvestigated = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaInvestigated"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "Lucian adjusted his tie."*)

### Węzeł `[257]`
Mówca: **Petr Vectern**
> ""I think Anton is making the moves to isolate Rumburg step by step:""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Petr Vectern: ""In the meantime, I can think of another deal that needs ..."*)

### Węzeł `[258]`
Mówca: **Petr Vectern**
> ""We've opened two new lines of communication with Ventrie City and Kyow. Just exploratory talks at this point, but they might lead to something deeper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Petr Vectern: ""And speaking of something deeper, Miss Suno...""*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && Ba..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && ..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Petr Vectern: ""We lost our shot with the superpowers due to the embargo..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Petr Vectern: ""The embargo diminished our chances with United Contana. ..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingArcasia == true"*)

### Węzeł `[265]`
Mówca: **Petr Vectern**
> ""We lost our shot with the superpowers due to the embargoes. We're reviewing other options at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Petr Vectern: ""But speaking of forming alliances, Miss Suno...""*)

### Węzeł `[266]`
Mówca: **Petr Vectern**
> ""The embargo reduced our chances with Arcasia. Although we've still got a shot with United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Petr Vectern: ""We opened a new line of communication with Kyow. Just ex..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingArcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingArcasia == true"*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true)"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingArcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Petr Vectern: ""The embargo reduced our chances with Arcasia. Although w..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Petr Vectern: ""It seems like we've still got a shot with the superpower..."*)

### Węzeł `[270]`
Mówca: **Petr Vectern**
> ""It seems like we've still got a shot with the superpowers, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Petr Vectern: ""We've opened two new lines of communication with Ventrie..."*)

### Węzeł `[271]`
Mówca: **Petr Vectern**
> ""We opened a new line of communication with Kyow. Just exploratory talks at this point, but they might lead to something deeper:""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Petr Vectern: ""And speaking of something deeper, Miss Suno...""*)

### Węzeł `[272]`
Mówca: **Petr Vectern**
> "We opened a new line of communication with Ventrie City. Just exploratory talks at this point, but they might lead to something deeper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Petr Vectern: ""And speaking of something deeper, Miss Suno...""*)

### Węzeł `[273]`
Mówca: **Petr Vectern**
> ""No, doesn't seem like it. We'll have to find other alternatives if we're going to keep Rumburg at bay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && Ba..."*)

### Węzeł `[274]`
Mówca: **Petr Vectern**
> ""And speaking of something deeper, Miss Suno...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Petr Vectern");"*)

### Węzeł `[275]`
Mówca: **Petr Vectern**
> ""In the meantime, I can think of another deal that needs sealing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Petr Vectern");"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("ReelToReel");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("ReelToReel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "He pressed play. I heard Petr and Livia's voices."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || Base..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == false || Bas..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || Base..."*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || Ba..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true |..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || (Bas..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || (Bas..."*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || (B..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Damaged = true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation == true)"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Damaged = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BFF_Damaged"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Damaged ..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Destroyed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BFF_Destroyed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Success ..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Damaged = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BFF_Damaged"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Damaged ..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true |..."*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed = true"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrant..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed = true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Damaged = true"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == false || Bas..."*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Decreased == false || B..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  ..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Failure ..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrant..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed = true"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Failure ..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  ..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true   or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed = true"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true   or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Ersen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched = true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Governor = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Governor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched = true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Damaged = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Damaged"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Failure = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Failure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Success = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_LT_GovernorBronContinuesReset..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_LT_GovernorBronContinuesResettlement = true;
BaseGameSupport.News_Turn08_R_GovernorBronContinuesResettlement = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_LT_GovernorBronContinuesResettlement"] = true;
Variable["BaseGameSupport.News_Turn08_R_GovernorBronContinuesResettlement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "It was early in the morning after my talk with Petr. The ..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_GovernorKrull_InvitesRemus..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_GovernorKrull_InvitesRemus = true;
BaseGameSupport.News_Turn08_R_GovernorKrull_InvitesRemus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_GovernorKrull_InvitesRemus"] = true;
Variable["BaseGameSupport.News_Turn08_R_GovernorKrull_InvitesRemus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "It was early in the morning after my talk with Petr. The ..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Ersen == true)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Ersen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_Both = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_Both"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true &&..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || B..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_ReligiousHarmonyBill = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_ReligiousHarmonyBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_LanguageBill = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_LanguageBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "It was early in the morning after my talk with Petr. The ..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || B..."*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true ||..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_LT_GovernorErsen_DisplaysArge..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_LT_GovernorErsen_DisplaysArge = true;
BaseGameSupport.News_Turn08_HP_GovernorErsen_DisplaysArge = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_LT_GovernorErsen_DisplaysArge"] = true;
Variable["BaseGameSupport.News_Turn08_HP_GovernorErsen_DisplaysArge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true || BaseGame.Med..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true || BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true || BaseGame.Med..."*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true || BaseGame.M..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true || BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true || BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_NoDeal_GovernorErsen_Displ..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_NoDeal_GovernorErsen_DisplaysArge = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_NoDeal_GovernorErsen_DisplaysArge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Petr Vectern");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Petr Vectern");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Livia Suno");"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Livia Suno");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Lucian grimaced and switched the tape off."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Livia Suno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Just then, there was a knock on the door. Livia opened it..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
