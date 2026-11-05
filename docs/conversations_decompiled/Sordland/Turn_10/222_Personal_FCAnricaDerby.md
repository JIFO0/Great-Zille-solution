# Sordland/Turn10/Personal_FCAnricaDerby

- **ID konwersacji:** `222`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/222_Personal_FCAnricaDerby.md`
- **Liczba węzłów dialogowych:** 707
- **Liczba wyborów gracza:** 133

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[35]** Gus Manger
- **[37]** Curtan Leste
- **[38]** Lucian Galade
- **[48]** Tarquin Soll

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.Decision_Turn04_FoundationDonation_LargeSum`
- `BaseGame.Decision_Turn04_FoundationDonation_SmallSum`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Enable_RumburgIncident`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Petr_Dead`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Welfare_EducationReform`
- `BaseGame.Reform_PresiPower_Default_DeSollinisation`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Welfare_HousingAssistance`
- `BaseGame.Soll_Hates_Alphonso`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_Personal_Festival_Force`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`
- `BaseGame.Turn09_A_LileasResigned`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Turn11_Election_AssassinationHappened`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.FCAnricaTeamSpeech_Stress`
- `BaseGameIsolated.FCAnrica_Wins`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn10_LT_FCAnricaLoseAtLastMinute`
- `BaseGameSupport.News_Turn10_LT_FCAnricaLoses`
- `BaseGameSupport.News_Turn10_LT_FCAnricaWins`

### Skoki między-konwersacyjne:
- Węzeł `[50]` -> **[223] Sordland/Turn10/AloneWithTarquinSoll** (../Turn_10/223_AloneWithTarquinSoll.md), Węzeł `[1]`
- Węzeł `[118]` -> **[541] Sordland/Turn10/EnergyDiscussion/EnergyDiscussion Conversation** (../Turn_10/541_EnergyDiscussion_Conversation.md), Węzeł `[1]`
- Węzeł `[139]` -> **[541] Sordland/Turn10/EnergyDiscussion/EnergyDiscussion Conversation** (../Turn_10/541_EnergyDiscussion_Conversation.md), Węzeł `[1]`
- Węzeł `[216]` -> **[224] Sordland/Turn10/FCAnricaDressingRoom** (../Turn_10/224_FCAnricaDressingRoom.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""Sure, Lucian.""** | `[11]` **Lucian Galade**: ""Even just the fact that you are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "I followed the security. We ente..." |
| `[13]` | **""My thoughts exactly.""** | `[11]` **Lucian Galade**: ""Even just the fact that you are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "I followed the security. We ente..." |
| `[14]` | **""I'm just here to support my team.""** | `[11]` **Lucian Galade**: ""Even just the fact that you are..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[20]` **Narrator**: "I followed the security. We ente..." |
| `[18]` | **""I just hope FC Gelsord fans don't hold it against me.""** | `[11]` **Lucian Galade**: ""Even just the fact that you are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "I followed the security. We ente..." |
| `[19]` | **""I hope so, Lucian.""** | `[11]` **Lucian Galade**: ""Even just the fact that you are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "I followed the security. We ente..." |
| `[28]` | **""Are you sure you can't join me?""** | `[27]` **Lucian Galade**: ""Please follow the guards to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Lucian Galade**: ""No, sir. The main VIP lounge ha..." |
| `[29]` | **""Any advice before I leave?""** | `[27]` **Lucian Galade**: ""Please follow the guards to the..."<br>`[36]` **Lucian Galade**: ""Try not to worry, sir. The secu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Lucian Galade**: ""You know the guests of honor mo..." |
| `[30]` | **""That's a pity. I'll save you some snacks.""** | `[27]` **Lucian Galade**: ""Please follow the guards to the..."<br>`[36]` **Lucian Galade**: ""Try not to worry, sir. The secu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "I followed the security. We ente..." |
| `[31]` | **""I hope there won't be another surprise today.""** | `[27]` **Lucian Galade**: ""Please follow the guards to the..."<br>`[37]` **Lucian Galade**: ""No, sir. The main VIP lounge ha..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[36]` **Lucian Galade**: ""Try not to worry, sir. The secu..." |
| `[35]` | **""I'm still not sure if this is the right thing to do so soon after the attempt on ..."** | `[27]` **Lucian Galade**: ""Please follow the guards to the..."<br>`[37]` **Lucian Galade**: ""No, sir. The main VIP lounge ha..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[36]` **Lucian Galade**: ""Try not to worry, sir. The secu..." |
| `[38]` | **"Follow the security."** | `[11]` **Lucian Galade**: ""Even just the fact that you are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "The corridors inside were painte..." |
| `[59]` | **""All right, Lucian. Thank you.""** | `[37]` **Lucian Galade**: ""No, sir. The main VIP lounge ha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "I followed the security. We ente..." |
| `[65]` | **""I'm fine, Lucian. Thank you.""** | `[60]` **Lucian Galade**: ""How are you feeling, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "We made our way towards the Maro..." |
| `[66]` | **""I'm just a little worried.""** | `[60]` **Lucian Galade**: ""How are you feeling, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Lucian Galade**: ""Don't fret, sir. Today is a day..." |
| `[73]` | **""Why is Anrica so crazy about Soll all of a sudden?""** | `[72]` **Narrator**: "As we wound our way through the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Lucian Galade**: ""I noticed it as well."" |
| `[74]` | **""It seems like Mayor Curtan Leste isn't following our de-Sollinization policy.""** | `[72]` **Narrator**: "As we wound our way through the ..." | `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true` | *Brak zmian stanu* | `[90]` **Lucian Galade**: ""I noticed it as well."" |
| `[84]` | **""Did this all happen after his death?""** | `[72]` **Narrator**: "As we wound our way through the ..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[89]` **Lucian Galade**: ""Most likely. He became a martyr."" |
| `[85]` | **""Is it just me or are they really using the name of a criminal everywhere?""** | `[72]` **Narrator**: "As we wound our way through the ..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`<br>`(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false` | *Brak zmian stanu* | `[87]` **Lucian Galade**: ""They are, sir."" |
| `[86]` | **""Am I imagining things, or did we just pass a pub called 'Alco-Soll'?""** | `[72]` **Narrator**: "As we wound our way through the ..." | `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`<br>`(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false` | *Brak zmian stanu* | `[88]` **Lucian Galade**: ""I'm afraid we did, sir."" |
| `[108]` | **""Honestly, working with Gus has been nothing but a disaster.""** | `[107]` **Ewald Alphonso**: ""No need to be so dismissive. Gu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Tarquin Soll**: ""All of the man's so-called acco..." |
| `[109]` | **""I must say, Gus has been a very valuable minister of my cabinet.""** | `[107]` **Ewald Alphonso**: ""No need to be so dismissive. Gu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Tarquin Soll**: ""Just what we need. Another pres..." |
| `[110]` | **"Stay silent."** | `[107]` **Ewald Alphonso**: ""No need to be so dismissive. Gu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Tarquin Soll**: ""All of the man's so-called acco..." |
| `[111]` | **""What did Gus do for Anrica?""** | `[107]` **Ewald Alphonso**: ""No need to be so dismissive. Gu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Ewald Alphonso**: ""He invested heavily in this cit..." |
| `[123]` | **""Are you a Real Montaklar supporter, Colonel?""** | `[119]` **Narrator**: "As if on cue, Real Montaklar's d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Tarquin Soll**: ""Don't make me laugh."" |
| `[124]` | **""With your strategy skills, you should be a football coach, Colonel.""** | `[119]` **Narrator**: "As if on cue, Real Montaklar's d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Tarquin Soll**: ""Don't make me laugh."" |
| `[125]` | **""They'll get it next time. Have some faith in our team.""** | `[119]` **Narrator**: "As if on cue, Real Montaklar's d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Tarquin Soll**: ""Faith alone does not suffice."" |
| `[129]` | **""My boys will win this. You'll see.""** | `[119]` **Narrator**: "As if on cue, Real Montaklar's d..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[142]` **Tarquin Soll**: ""Faith alone does not suffice."" |
| `[132]` | **""Honestly, working with Gus has been nothing but a disaster.""** | `[131]` **Ewald Alphonso**: ""Without him, Anrica wouldn't be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Ewald Alphonso**: ""Don't be so dismissive. He real..." |
| `[133]` | **""Maybe it's not such ill timing. Soll's name has been on everyone's lips since the..."** | `[131]` **Ewald Alphonso**: ""Without him, Anrica wouldn't be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Ewald Alphonso**: ""You make a good point. Maybe Gu..." |
| `[134]` | **""What did he do for Anrica?""** | `[131]` **Ewald Alphonso**: ""Without him, Anrica wouldn't be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Ewald Alphonso**: ""He invested heavily in this cit..." |
| `[135]` | **""Gus must realize he's aiding Soll's cult of personality with stunts like this.""** | `[131]` **Ewald Alphonso**: ""Without him, Anrica wouldn't be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[559]` **Ewald Alphonso**: ""You and I both know Gus. His on..." |
| `[155]` | **""I didn't know you were a football fan, Mr. Alphonso.""** | `[161]` **Ewald Alphonso**: ""Well, damn."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Ewald Alphonso**: ""Honestly, I'm more of a money f..." |
| `[156]` | **""They'll get it next time. Have some faith in our team.""** | `[161]` **Ewald Alphonso**: ""Well, damn."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Ewald Alphonso**: ""That's the spirit."" |
| `[160]` | **""My boys will win this. You'll see.""** | `[161]` **Ewald Alphonso**: ""Well, damn."" | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[164]` **Ewald Alphonso**: ""That's the spirit."" |
| `[162]` | **""They're against the top team in Eastern Merkopa. It won't be so easy.""** | `[161]` **Ewald Alphonso**: ""Well, damn."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Ewald Alphonso**: ""I'm aware."" |
| `[168]` | **""I'm trying my best to stay calm. Thank you.""** | `[151]` **Ewald Alphonso**: ""How are you holding up after th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Ewald Alphonso**: ""That's a relief."" |
| `[169]` | **""Honestly, I'm worried. The country is showing signs of instability again.""** | `[151]` **Ewald Alphonso**: ""How are you holding up after th..."<br>`[153]` **Ewald Alphonso**: ""Is everything going well at the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Ewald Alphonso**: ""Yes, Mr. Rayne. Sordish politic..." |
| `[170]` | **""It would be a lie if I said it's been great.""** | `[151]` **Ewald Alphonso**: ""How are you holding up after th..."<br>`[153]` **Ewald Alphonso**: ""Is everything going well at the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Ewald Alphonso**: ""I completely understand what yo..." |
| `[183]` | **""Why so bleak? It's not even half time yet. Anrica can still come out on top.""** | `[182]` **Ewald Alphonso**: ""I still applaud our guys for gi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Ewald Alphonso**: ""You're right.""<br>`[282]` **Tarquin Soll**: ""Don't expect that to make sense..." |
| `[184]` | **""Yes. Football is like politics. Sometimes it's all about luck.""** | `[182]` **Ewald Alphonso**: ""I still applaud our guys for gi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Ewald Alphonso**: ""I guess you meant to say money...."<br>`[194]` **Ewald Alphonso**: ""It's not about luck. It's about..." |
| `[185]` | **""Don't overestimate FC Gelsord. We already broke their record and took the title. ..."** | `[182]` **Ewald Alphonso**: ""I still applaud our guys for gi..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[220]` **Ewald Alphonso**: ""Let's see if they can keep it up."" |
| `[189]` | **""Honestly, I don't really care about any of this.""** | `[182]` **Ewald Alphonso**: ""I still applaud our guys for gi..." | `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false` | *Brak zmian stanu* | `[221]` **Ewald Alphonso**: ""You just need to look like you ..." |
| `[195]` | **""Everything is fine. Thank you.""** | `[153]` **Ewald Alphonso**: ""Is everything going well at the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Ewald Alphonso**: ""That's a relief."" |
| `[200]` | **""It is great to be here in Anrica.""** | `[105]` **Gus Manger**: ""And all of Sordland! Never befo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Gus Manger**: ""Thanks for coming."" |
| `[201]` | **""I have high hopes for today. This is a big achievement for Sordish football.""** | `[105]` **Gus Manger**: ""And all of Sordland! Never befo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Gus Manger**: ""Football is of rapidly expandin..." |
| `[202]` | **""Honestly, I don't know much about football. But I'm here for the players and for ..."** | `[105]` **Gus Manger**: ""And all of Sordland! Never befo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Gus Manger**: ""Come on, Mr. President! You own..."<br>`[213]` **Gus Manger**: ""Football is of rapidly expandin..." |
| `[206]` | **""Let's win this, Gus, shall we?""** | `[105]` **Gus Manger**: ""And all of Sordland! Never befo..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[207]` **Gus Manger**: ""We most definitely will, Mr. Pr..." |
| `[216]` | **"Go to the locker room of FC Anrica."** | `[45]` **Narrator**: "After delivering his best wishes..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Watching the Merkopan Champions Cup with...`<br>`PlayMusic("Diplomacy");` | `[8]` **Narrator**: "Today, the management of FC Anri..."<br>`[3]` **Narrator**: "Today, the management of FC Anri..." |
| `[218]` | **"Go directly to the lounge."** | `[45]` **Narrator**: "After delivering his best wishes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "Once I finally found myself insi..." |
| `[254]` | **""Well, as the president, I have to be. You know how it is, Mr. Former President.""** | `[228]` **Ewald Alphonso**: ""Considering that a war with Rum..."<br>`[235]` **Ewald Alphonso**: ""Considering that Rumburg is act..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..." |
| `[255]` | **""Don't worry, it's under control. Everything will fall into place soon.""** | `[228]` **Ewald Alphonso**: ""Considering that a war with Rum..."<br>`[235]` **Ewald Alphonso**: ""Considering that Rumburg is act..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..." |
| `[256]` | **""Rumburg may be a massive world power, but nobody should underestimate Sordland. Y..."** | `[228]` **Ewald Alphonso**: ""Considering that a war with Rum..."<br>`[235]` **Ewald Alphonso**: ""Considering that Rumburg is act..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..." |
| `[257]` | **""Don't underestimate the power of the government, Mr. Alphonso.""** | `[236]` **Ewald Alphonso**: ""Considering that the country is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..." |
| `[258]` | **""What would you have me do? There's nothing I can do about that anymore.""** | `[236]` **Ewald Alphonso**: ""Considering that the country is..."<br>`[240]` **Ewald Alphonso**: ""Considering that the Supreme Co..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..." |
| `[259]` | **""I'm not scared of them.""** | `[241]` **Ewald Alphonso**: ""Considering that you have lost ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..." |
| `[260]` | **""I didn't start this mess. Unlike you, I did everything in my power to fix the sit..."** | `[248]` **Ewald Alphonso**: ""Considering that Sordland is no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..."<br>`[272]` **Narrator**: "I heard Tarquin Soll laugh." |
| `[261]` | **""The CSP is the right place to be for Sordland.""** | `[252]` **Ewald Alphonso**: ""Considering that you made allie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..."<br>`[276]` **Tarquin Soll**: ""What you did can only be descri..." |
| `[262]` | **""They are our allies now, yes. I'm not scared of them.""** | `[252]` **Ewald Alphonso**: ""Considering that you made allie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..."<br>`[276]` **Tarquin Soll**: ""What you did can only be descri..." |
| `[263]` | **""What are you saying, Mr. Alphonso?""** | `[253]` **Ewald Alphonso**: ""Considering everything that's h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Ewald Alphonso**: ""You don't need to read between ..." |
| `[264]` | **""Do I really look that composed? That's good to know.""** | `[253]` **Ewald Alphonso**: ""Considering everything that's h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Just then, Montaklar midfielders..." |
| `[307]` | **""Now you're asking for donations at football matches? How does a non-profit even a..."** | `[306]` **Narrator**: "The tagline, written in elegant ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Ewald Alphonso**: ""I'm doing my best to increase o..." |
| `[308]` | **""Well... That's new.""** | `[306]` **Narrator**: "The tagline, written in elegant ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Ewald Alphonso**: ""Wait. There's more."" |
| `[309]` | **""Really?""** | `[306]` **Narrator**: "The tagline, written in elegant ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Ewald Alphonso**: ""I'm doing my best to increase o..." |
| `[310]` | **"Don't comment."** | `[306]` **Narrator**: "The tagline, written in elegant ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Narrator**: "Just then, the speakers in the s..." |
| `[328]` | **""I appreciate the credit, but you didn't need to put my name in there.""** | `[327]` **Narrator**: "The recording ended with a few s..." | `Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true  or  Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true` | *Brak zmian stanu* | `[339]` **Ewald Alphonso**: ""It helps with the donations."" |
| `[332]` | **""It's good to see that you're at least helping the poor in some way. That is comme..."** | `[327]` **Narrator**: "The recording ended with a few s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Ewald Alphonso**: ""Thanks for the support."" |
| `[333]` | **""I'll be honest. I think that ad was a little distasteful.""** | `[327]` **Narrator**: "The recording ended with a few s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Ewald Alphonso**: ""I beg to differ."" |
| `[337]` | **""You don't even live here anymore. I'm surprised you'd think an ad like this would..."** | `[327]` **Narrator**: "The recording ended with a few s..." | `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true` | *Brak zmian stanu* | `[340]` **Ewald Alphonso**: ""Why wouldn't it? Don't act like..." |
| `[338]` | **""What the hell was that?""** | `[327]` **Narrator**: "The recording ended with a few s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Ewald Alphonso**: ""What's wrong?"" |
| `[375]` | **""You know I'm not going to take that response at face value. But regardless, I rea..."** | `[367]` **Ewald Alphonso**: ""Unlike Soll, I'm trying to use ..." | `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == false` | *Brak zmian stanu* | `[386]` **Ewald Alphonso**: ""They are, Mr. Rayne. You can be..." |
| `[376]` | **""As much as I respect that, I don't believe an issue like this can be left to the ..."** | `[367]` **Ewald Alphonso**: ""Unlike Soll, I'm trying to use ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Ewald Alphonso**: ""Oh. I almost forgot about your ..."<br>`[381]` **Ewald Alphonso**: ""Oh no. Is that a Malenyevist ta..." |
| `[377]` | **""And I support your endeavors on that.""** | `[367]` **Ewald Alphonso**: ""Unlike Soll, I'm trying to use ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Ewald Alphonso**: ""I really appreciate that."" |
| `[378]` | **""You don't need to explain or justify, Ewald. I get the idea already.""** | `[367]` **Ewald Alphonso**: ""Unlike Soll, I'm trying to use ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Ewald Alphonso**: ""Fair enough."" |
| `[387]` | **""Is that even true, Mr. Soll? Are you really denying that you did nothing to const..."** | `[369]` **Ewald Alphonso**: ""Maybe they didn't have any othe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Tarquin Soll**: ""What does it matter? You believ..."<br>`[445]` **Tarquin Soll**: ""I didn't need to build a cult f..." |
| `[388]` | **""Nobody had any choice. There was no other option.""** | `[369]` **Ewald Alphonso**: ""Maybe they didn't have any othe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Ewald Alphonso**: ""Precisely my point. Would you s..." |
| `[389]` | **""Despite everything, we can't deny the millions of people who loved and respected ..."** | `[369]` **Ewald Alphonso**: ""Maybe they didn't have any othe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Ewald Alphonso**: ""I'm not saying otherwise. But I..." |
| `[390]` | **"Don't comment."** | `[369]` **Ewald Alphonso**: ""Maybe they didn't have any othe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Tarquin Soll**: ""Are you still sore about the pa..." |
| `[397]` | **""What do you mean? Mr. Soll supported you after the congress?""** | `[395]` **Ewald Alphonso**: ""I still remember how the party ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Ewald Alphonso**: ""Briefly, yes. The last couple y..." |
| `[398]` | **""Sollists still make up the bulk of the USP today. Everybody is aware of your infl..."** | `[395]` **Ewald Alphonso**: ""I still remember how the party ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Tarquin Soll**: ""Instead of blaming the party, w..." |
| `[401]` | **""Gentlemen. Why don't we calm down a little? We are here to watch football.""** | `[395]` **Ewald Alphonso**: ""I still remember how the party ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Narrator**: "Neither of the two men seemed to..." |
| `[402]` | **"Don't comment."** | `[395]` **Ewald Alphonso**: ""I still remember how the party ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Tarquin Soll**: ""Instead of blaming the party, w..." |
| `[411]` | **""I remember Soll's reforms but I still remember those years as being very unstable.""** | `[408]` **Tarquin Soll**: ""Your vision? Ha!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[416]` **Ewald Alphonso**: ""My wing and I pushed for those ..." |
| `[412]` | **"Don't comment."** | `[408]` **Tarquin Soll**: ""Your vision? Ha!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Ewald Alphonso**: ""But it was all to get credit fo..." |
| `[413]` | **""Are you saying Mr. Soll's reforms between '46 and '49 were actually your plans?""** | `[408]` **Tarquin Soll**: ""Your vision? Ha!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Ewald Alphonso**: ""Of course, they were. It was th..." |
| `[417]` | **""You have a point, Mr. Soll. But don't act like you're above all of us.""** | `[405]` **Tarquin Soll**: ""Take a look at yourself. You ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Narrator**: "He waved a dismissive hand, as i..." |
| `[418]` | **""That's an empty argument. The party and the government were in that state due to ..."** | `[405]` **Tarquin Soll**: ""Take a look at yourself. You ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Tarquin Soll**: ""Correct. They built a republic ..." |
| `[419]` | **""This is getting out of hand. I think both of you should calm down.""** | `[405]` **Tarquin Soll**: ""Take a look at yourself. You ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Ewald Alphonso**: ""I agree."" |
| `[420]` | **""Oh, please. We know that you are still trying to pull the strings behind the scen..."** | `[405]` **Tarquin Soll**: ""Take a look at yourself. You ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Tarquin Soll**: ""Now you just sound paranoid, Ra..." |
| `[428]` | **""Why are you changing the topic?""** | `[182]` **Ewald Alphonso**: ""I still applaud our guys for gi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Ewald Alphonso**: ""What do you mean? They just sco..." |
| `[462]` | **""Are you always this negative, Mr. Soll?""** | `[119]` **Narrator**: "As if on cue, Real Montaklar's d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[463]` **Tarquin Soll**: ""I'm a realist, Mr. Rayne. I don..." |
| `[467]` | **""That referee is trying to sabotage us. He was clearly in front of the defenders w..."** | `[466]` **Ewald Alphonso**: ""Bullshit! That wasn't an offside."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[482]` **Ewald Alphonso**: ""The angle was all wrong. A deci..."<br>`[475]` **Tarquin Soll**: ""Halt your endless bickering. Th..." |
| `[468]` | **""Do you think the Rizians could have bought the referees?""** | `[466]` **Ewald Alphonso**: ""Bullshit! That wasn't an offside."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[481]` **Ewald Alphonso**: ""Well... They have the prestige ..." |
| `[469]` | **""To be fair, nobody here cares.""** | `[466]` **Ewald Alphonso**: ""Bullshit! That wasn't an offside."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[480]` **Ewald Alphonso**: ""It's your own club, Mr. Rayne. ..."<br>`[476]` **Ewald Alphonso**: ""Well... I still do."" |
| `[470]` | **"Do not comment."** | `[466]` **Ewald Alphonso**: ""Bullshit! That wasn't an offside."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[482]` **Ewald Alphonso**: ""The angle was all wrong. A deci..."<br>`[475]` **Tarquin Soll**: ""Halt your endless bickering. Th..." |
| `[490]` | **""Just let it be, Ewald.""** | `[482]` **Ewald Alphonso**: ""The angle was all wrong. A deci..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[496]` **Narrator**: "The excitement in the stadium re..." |
| `[491]` | **""The Global Football Association is clearly biased against us.""** | `[482]` **Ewald Alphonso**: ""The angle was all wrong. A deci..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[496]` **Narrator**: "The excitement in the stadium re..." |
| `[492]` | **""What next? You're going to install cameras and analyze every position from differ..."** | `[482]` **Ewald Alphonso**: ""The angle was all wrong. A deci..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[496]` **Narrator**: "The excitement in the stadium re..." |
| `[493]` | **"Stay silent."** | `[482]` **Ewald Alphonso**: ""The angle was all wrong. A deci..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[496]` **Narrator**: "The excitement in the stadium re..." |
| `[494]` | **""You should have more faith in our Sordish players.""** | `[471]` **Ewald Alphonso**: ""That was a great comeback. We c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Ewald Alphonso**: ""You're right."" |
| `[495]` | **""Exactly. We can be the underdogs here, but we cannot let the Rizians intimidate us.""** | `[471]` **Ewald Alphonso**: ""That was a great comeback. We c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Ewald Alphonso**: ""You're right."" |
| `[497]` | **""To be fair, nobody here cares.""** | `[471]` **Ewald Alphonso**: ""That was a great comeback. We c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[503]` **Ewald Alphonso**: ""It's your own club, Mr. Rayne. ..."<br>`[499]` **Ewald Alphonso**: ""Well... I still do."" |
| `[498]` | **"Do not comment."** | `[471]` **Ewald Alphonso**: ""That was a great comeback. We c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[505]` **Narrator**: "As the last minutes of the match..." |
| `[550]` | **""I wish Serge could have lived to see this day.""** | `[60]` **Lucian Galade**: ""How are you feeling, sir?"" | `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true` | *Brak zmian stanu* | `[551]` **Lucian Galade**: ""Truly a tragedy, sir. I know th..." |
| `[555]` | **""I can't believe Petr's not here to see this.""** | `[60]` **Lucian Galade**: ""How are you feeling, sir?"" | `Variable["BaseGame.Petr_Dead"] == true` | *Brak zmian stanu* | `[556]` **Lucian Galade**: ""A tragedy, sir. Mr. Vectern did..." |
| `[560]` | **""Mr. Alphonso. How have you been since the trial?""** | `[100]` **Narrator**: "Ewald Alphonso quickly walked up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[568]` **Ewald Alphonso**: ""I've been just fine, {BaseGameT..."<br>`[574]` **Ewald Alphonso**: ""Honestly, I've never been bette..." |
| `[561]` | **""No, he certainly isn't. I saw to that myself.""** | `[100]` **Narrator**: "Ewald Alphonso quickly walked up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[573]` **Ewald Alphonso**: ""You were so invested in getting..."<br>`[572]` **Ewald Alphonso**: ""I do wonder if the trial was th..." |
| `[562]` | **""Alphonso. We have unfinished business, don't we?""** | `[100]` **Narrator**: "Ewald Alphonso quickly walked up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[563]` **Ewald Alphonso**: ""We do indeed, Mr. President.""<br>`[567]` **Ewald Alphonso**: ""What's unfinished about it? I'd..." |
| `[602]` | **""What does that supposed to mean, Mr. Soll?""** | `[589]` **Tarquin Soll**: ""At least you still have the sup..."<br>`[593]` **Tarquin Soll**: ""This football craze seems to ha..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[622]` **Tarquin Soll**: ""You lost the support of the mec..." |
| `[603]` | **"Stay silent."** | `[589]` **Tarquin Soll**: ""At least you still have the sup..."<br>`[591]` **Tarquin Soll**: ""How liberal of you, Ewald.""<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Narrator**: "Suddenly, a wave of shouting mad..." |
| `[604]` | **""Funny. Do you not see the millions behind me?""** | `[589]` **Tarquin Soll**: ""At least you still have the sup..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[623]` **Tarquin Soll**: ""We'll see about that."" |
| `[605]` | **""Right. At least that's going good for me.""** | `[589]` **Tarquin Soll**: ""At least you still have the sup..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Tarquin Soll**: ""Enjoy it while you can."" |
| `[606]` | **""The Colonel is right. They are free to express themselves.""** | `[591]` **Tarquin Soll**: ""How liberal of you, Ewald."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[625]` **Ewald Alphonso**: ""The contents of that expression..." |
| `[607]` | **""These are some very dangerous signs. How were they even allowed inside with them?""** | `[591]` **Tarquin Soll**: ""How liberal of you, Ewald."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[627]` **Ewald Alphonso**: ""To be fair, this type of statem..." |
| `[608]` | **""Is this your doing too, Mr. Soll?""** | `[591]` **Tarquin Soll**: ""How liberal of you, Ewald."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[629]` **Tarquin Soll**: ""You think I'd install a few men..." |
| `[609]` | **""Right. At least that's going good for me.""** | `[593]` **Tarquin Soll**: ""This football craze seems to ha..."<br>`[596]` **Ewald Alphonso**: ""Looks like FC Anrica fans are r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Tarquin Soll**: ""Enjoy it while you can."" |
| `[610]` | **""Why don't you both mind your own business, gentlemen? I am already aware of the t..."** | `[593]` **Tarquin Soll**: ""This football craze seems to ha..."<br>`[611]` **Tarquin Soll**: ""For good reason."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[631]` **Ewald Alphonso**: ""Sure. And good luck with that. ..." |
| `[612]` | **""There's nothing I can do about that now.""** | `[611]` **Tarquin Soll**: ""For good reason."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[632]` **Ewald Alphonso**: ""You're right. And good luck wit..." |
| `[613]` | **""Honestly, I couldn't care less.""** | `[596]` **Ewald Alphonso**: ""Looks like FC Anrica fans are r..."<br>`[597]` **Ewald Alphonso**: ""Looks like FC Anrica fans are r..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[634]` **Tarquin Soll**: ""Of course you don't."" |
| `[614]` | **""Of course they would.""** | `[596]` **Ewald Alphonso**: ""Looks like FC Anrica fans are r..."<br>`[598]` **Ewald Alphonso**: ""It seems like Anricans like you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[633]` **Ewald Alphonso**: ""I see you are confident."" |
| `[615]` | **""If they're choosing Lileas over me, their opinions don't even matter.""** | `[597]` **Ewald Alphonso**: ""Looks like FC Anrica fans are r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[635]` **Ewald Alphonso**: ""I wouldn't go that far."" |
| `[616]` | **""I mean... I can't blame them.""** | `[597]` **Ewald Alphonso**: ""Looks like FC Anrica fans are r..."<br>`[601]` **Tarquin Soll**: ""That's Mr. Rayne's fault."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[636]` **Tarquin Soll**: ""At least you are aware."" |
| `[617]` | **""Well, to be fair, I like Anricans a lot too.""** | `[598]` **Ewald Alphonso**: ""It seems like Anricans like you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[637]` **Ewald Alphonso**: ""Uh... Okay."" |
| `[618]` | **""What does that supposed to mean, Mr. Soll?""** | `[601]` **Tarquin Soll**: ""That's Mr. Rayne's fault."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[639]` **Tarquin Soll**: ""You know what it means, Anton. ..." |
| `[619]` | **""They can support whoever they want.""** | `[601]` **Tarquin Soll**: ""That's Mr. Rayne's fault."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[640]` **Ewald Alphonso**: ""Well... That's true."" |
| `[660]` | **""You're right. They're clearly asking the military to intervene. This cannot be al..."** | `[588]` **Ewald Alphonso**: ""They need to be arrested for pu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[669]` **Ewald Alphonso**: ""I'd be extremely careful if I w..." |
| `[661]` | **"Stay silent."** | `[588]` **Ewald Alphonso**: ""They need to be arrested for pu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Narrator**: "Suddenly, a wave of shouting mad..." |
| `[662]` | **""They are free to express themselves.""** | `[588]` **Ewald Alphonso**: ""They need to be arrested for pu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[666]` **Ewald Alphonso**: ""Until their wishes become a rea..." |
| `[663]` | **""These are some very dangerous signs. How were they even allowed inside with them?""** | `[588]` **Ewald Alphonso**: ""They need to be arrested for pu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[667]` **Ewald Alphonso**: ""Anrica is full of people like t..." |
| `[664]` | **""I wouldn't go that far.""** | `[588]` **Ewald Alphonso**: ""They need to be arrested for pu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[665]` **Ewald Alphonso**: ""Why not? You already went too d..." |
| `[675]` | **""They're just a bunch of hippies. Who cares what they say?""** | `[621]` **Tarquin Soll**: ""The Toras family is a puppet of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Narrator**: "Suddenly, a wave of shouting mad..." |
| `[676]` | **"Stay silent."** | `[621]` **Tarquin Soll**: ""The Toras family is a puppet of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Narrator**: "Suddenly, a wave of shouting mad..." |
| `[677]` | **""Do you think Rizia would aid Rumburg in a war with us?""** | `[621]` **Tarquin Soll**: ""The Toras family is a puppet of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Narrator**: "Suddenly, a wave of shouting mad..." |
| `[678]` | **""Well, they're right. Nobody wants a war with Rumburg.""** | `[621]` **Tarquin Soll**: ""The Toras family is a puppet of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Narrator**: "Suddenly, a wave of shouting mad..." |

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
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Watching the Merkopan Champions Cup with..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Today, the management of FC Anrica had invited me to attend a pivotal football match. At Lucian's urging, I accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The team was representing Sordland in the international a..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The team was representing Sordland in the international arena. According to Lucian, it would have been un-presidential not to put in an appearance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "FC Anrica was finally in the Merkopan Champions Cup -- th..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Today, the management of FC Anrica had invited me to atte..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Today, the management of FC Anrica had invited me to atte..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Today, the management of FC Anrica had invited me to attend a pivotal football match. As a board member, I couldn't reject it. I had to be there at this significant moment for my team."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "They were representing Sordland in the international aren..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "We made our way towards the Maroon Stadium. The arena was situated in one of the most crowded quarters of Anrica, surrounded by dense urban development."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "As we wound our way through the streets, I noticed the na..."*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""Sir. The security gave us the clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: ""Please follow the guards to the top floor. You will be s..."*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Even just the fact that you are here will surely help with our campaign image.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Italic: "Follow the security."*)
  - -> `[19]` (*Player: ""I hope so, Lucian.""*)
  - -> `[12]` (*Player: ""Sure, Lucian.""*)
  - -> `[13]` (*Player: ""My thoughts exactly.""*)
  - -> `[18]` (*Player: ""I just hope FC Gelsord fans don't hold it against me.""*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sure, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I followed the security. We entered beneath a giant sign ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My thoughts exactly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I followed the security. We entered beneath a giant sign ..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm just here to support my team.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I followed the security. We entered beneath a giant sign ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""I'm just here to support my team.""*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I just hope FC Gelsord fans don't hold it against me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I followed the security. We entered beneath a giant sign ..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope so, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I followed the security. We entered beneath a giant sign ..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "I followed the security. We entered beneath a giant sign that read: "Welcome to the Hall of Martyrs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "The corridors inside were painted almost completely in ma..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "And of course, all presidents of Sordland -- current and former -- were invited to watch the historic competition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "I was told that my predecessor, Ewald Alphonso, would be ..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "I was told that both Tarquin Soll and Ewald Alphonso woul..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "I was told that my predecessor, Ewald Alphonso, would be joining me in the lounge reserved for us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: ""How are you feeling, sir?""*)

### Węzeł `[26]`
Mówca: **Narrator**
> "I was told that both Tarquin Soll and Ewald Alphonso would be joining me in the lounge reserved for us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: ""How are you feeling, sir?""*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""Please follow the guards to the top floor. You will be seated in the VIP lounge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""Are you sure you can't join me?""*)
  - -> `[29]` (*Player: ""Any advice before I leave?""*)
  - -> `[30]` (*Player: ""That's a pity. I'll save you some snacks.""*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you sure you can't join me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: ""No, sir. The main VIP lounge has been reserved for presi..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Any advice before I leave?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade), `[36]` (Lucian Galade), `[37]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: ""You know the guests of honor more than I do, sir. If all..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a pity. I'll save you some snacks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade), `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I followed the security. We entered beneath a giant sign ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope there won't be another surprise today.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade), `[37]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Try not to worry, sir. The security detail has assured m..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""I hope there won't be another surprise today.""*)
  - -> `[35]` (*Player: ""I'm still not sure if this is the right thing to do so s..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm still not sure if this is the right thing to do so soon after the attempt on my life.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade), `[37]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Try not to worry, sir. The security detail has assured m..."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Try not to worry, sir. The security detail has assured me that they have everything under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: ""Any advice before I leave?""*)
  - -> `[30]` (*Player: ""That's a pity. I'll save you some snacks.""*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""No, sir. The main VIP lounge has been reserved for presidents only today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: ""All right, Lucian. Thank you.""*)
  - -> `[29]` (*Player: ""Any advice before I leave?""*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Follow the security."]** — Mówca: **Player_Italic**
> "I followed the security. We entered beneath a giant sign that read: "Welcome to the Hall of Martyrs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "The corridors inside were painted almost completely in ma..."*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""You know the guests of honor more than I do, sir. If all else fails, just focus on the match. It shouldn't be difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""Even just the fact that you are here will surely help wi..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "The corridors inside were painted almost completely in maroon. Adorning them were various depictions of the Sordish goat and numerous jerseys, awards and team photographs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "On our way up, I was greeted by the president of the club..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "He personally thanked me for my investment and told me th..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "After delivering his best wishes, he kindly pointed us to..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "On our way up, I was greeted by the president of the club. Beaming with pride, he immediately shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Behind him, Mayor Curtan Leste and Gus Manger were waitin..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "After delivering his best wishes, he kindly pointed us towards the corridor and told me that I could visit the team before the match if I wished to do so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player_Italic: "Go to the locker room of FC Anrica."*)
  - -> `[218]` (*Player_Italic: "Go directly to the lounge."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "After delivering his best wishes, he kindly pointed us towards the lounge, which was surrounded by heavily armed men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Once I finally found myself inside, I was greeted by an a..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Once I finally found myself inside, I was greeted by an amazing view of the entire pitch through floor-to-ceiling windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I took a seat on the leather sofa and watched as the acti..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I took a seat on the leather sofa and watched as the action began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The stadium erupted in applause as the players started co..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "FC Anrica was finally in the Merkopan Champions Cup -- the most prestigious football tournament in the world. For the first time ever, a Sordish team had managed to qualify for the Knockout phase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Millions of Sordish people were waiting to watch FC Anric..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "They were representing Sordland in the international arena. I couldn't help but feel a surge of pride as Lucian and I headed to the stadium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "FC Anrica was finally in the Merkopan Champions Cup -- th..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Millions of Sordish people were waiting to watch FC Anrica compete against the legendary Rizian team Real Montaklar. Despite all odds being stacked against the team, the mood was full of hope."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "A win today would bring Anrica to the quarter finals, a f..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "A win today would bring Anrica to the quarter finals, a feat that no Sordish team had ever managed to achieve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "And of course, all presidents of Sordland -- current and ..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Another group of fans raised their boards to reveal a silhouette of the famous Hall of Warriors -- a Markian-era architectural ruin in Anrica -- with Tarquin Soll in front of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "As the players of Real Montaklar lined up in the middle o..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "The stadium erupted in applause as the players started coming out onto the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "As the players of Real Montaklar lined up in the middle o..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Right after the referee signalled the start of the match, the door behind us closed with a thud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right, Lucian. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I followed the security. We entered beneath a giant sign ..."*)

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""How are you feeling, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""I'm fine, Lucian. Thank you.""*)
  - -> `[66]` (*Player: ""I'm just a little worried.""*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""Sir. The security gave us the clear.""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: ""Sir. The security gave us the clear and informed us that..."*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""Sir. The security gave us the clear and informed us that Tarquin Soll has already arrived at the lounge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: ""Good luck. I know he's quite the imposing presence.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm fine, Lucian. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "We made our way towards the Maroon Stadium. The arena was..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm just a little worried.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: ""Don't fret, sir. Today is a day to relax. Perhaps even c..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""Don't fret, sir. Today is a day to relax. Perhaps even celebrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "We made our way towards the Maroon Stadium. The arena was..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Lucian's pocket radio crackled. After responding, he turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""Good luck. I know he's quite the imposing presence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: ""Please follow the guards to the top floor. You will be s..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Behind him, Mayor Curtan Leste and Gus Manger were waiting to greet me as well. All of them had FC Anrica pins attached to their collars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Curtan Leste: ""Welcome to Anrica, Mr. President.""*)

### Węzeł `[71]`
Mówca: **Narrator**
> "As the players of Real Montaklar lined up in the middle of the field, FC Anrica fans started chanting: "We'll eat you whole for Colonel Soll!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Right after the referee signalled the start of the match,..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "As we wound our way through the streets, I noticed the name of Tarquin Soll everywhere. Since I'd last been here, markets, restaurants and even pubs named after the Colonel had all popped up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""Why is Anrica so crazy about Soll all of a sudden?""*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why is Anrica so crazy about Soll all of a sudden?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: ""I noticed it as well.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems like Mayor Curtan Leste isn't following our de-Sollinization policy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: ""I noticed it as well.""*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_DeSollinisation == t..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: ""It seems like Mayor Curtan Leste isn't following our de-..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_DeSollinisation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: ""Did this all happen after his death?""*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: ""Is it just me or are they really using the name of a cri..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""Am I imagining things, or did we just pass a pub called ..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Did this all happen after his death?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""Most likely. He became a martyr.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is it just me or are they really using the name of a criminal everywhere?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true` AND `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""They are, sir.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Am I imagining things, or did we just pass a pub called 'Alco-Soll'?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false` AND `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""I'm afraid we did, sir.""*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""They are, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I've heard it is part of an ad campaign for Anrica. An a..."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""I'm afraid we did, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I've heard it is part of an ad campaign for Anrica. An a..."*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""Most likely. He became a martyr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I've heard it is part of an ad campaign for Anrica. An a..."*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""I noticed it as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I've heard it is part of an ad campaign for Anrica. An a..."*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""I've heard it is part of an ad campaign for Anrica. An attempt to draw tourists, or at least Sollist ones, to the city. Soll's legacy still lives on for millions, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Lucian's pocket radio crackled. After responding, he turn..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGame.Turn05_Personal_Festival_Force == true || BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGame..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGa..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGame.Turn05_Personal_Festival_Force == true || BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == false  and  (Variable["BaseGame.Turn05_Personal_Festival_Force"] == true  or  Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Curtan Leste: ""Mr. President. I didn't expect you to show your support ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGame.Turn05_Personal_Festival_Force == true || BaseGame.Turn05_Personal_Festival_LesteKicked == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == false  and  (Variable["BaseGame.Turn05_Personal_Festival_Force"] == true  or  Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Curtan Leste: ""You are always welcome in Anrica, and it is great to see..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Ewald Alphonso: ""Well, {BaseGameText.AlphonsoToPlayer}? What do you think..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Ewald Alphonso: ""Well, Colonel? How do you feel about being Anrica's new ..."*)

### Węzeł `[98]`
Mówca: **Ewald Alphonso**
> ""It looks like it's working well for the city. And if you moved back home, I'm sure you'd get free meals and drinks everywhere you went.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Ewald Alphonso quickly walked up to the sofa, shook our h..."*)

### Węzeł `[99]`
Mówca: **Ewald Alphonso**
> ""I doubt the Colonel would approve of his name being used as a tourist draw. But he's not around anymore, is he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Ewald Alphonso quickly walked up to me, shook my hand and..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Ewald Alphonso quickly walked up to me, shook my hand and sat next to me with a grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Player: ""Mr. Alphonso. How have you been since the trial?""*)
  - -> `[561]` (*Player: ""No, he certainly isn't. I saw to that myself.""*)
  - -> `[562]` (*Player: ""Alphonso. We have unfinished business, don't we?""*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Ewald Alphonso quickly walked up to the sofa, shook our hands and sat next to us, smiling as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Tarquin Soll: ""Ha. You know, I never had a strong connection to this pl..."*)

### Węzeł `[102]`
Mówca: **Tarquin Soll**
> ""Ha. You know, I never had a strong connection to this place. Mr. Leste should have asked my permission before using my name to market his city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Ewald Alphonso: ""Oh, it was actually Gus Manger's idea.""*)

### Węzeł `[103]`
Mówca: **Ewald Alphonso**
> ""Oh, it was actually Gus Manger's idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Tarquin Soll: ""Why am I not surprised? He's full of ideas, your Mr. Man..."*)

### Węzeł `[104]`
Mówca: **Curtan Leste**
> ""Welcome to Anrica, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGame..."*)

### Węzeł `[105]`
Mówca: **Gus Manger**
> ""And all of Sordland! Never before has a Sordish team reached this stage in the Merkopan Cup.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player: ""It is great to be here in Anrica.""*)
  - -> `[201]` (*Player: ""I have high hopes for today. This is a big achievement f..."*)
  - -> `[202]` (*Player: ""Honestly, I don't know much about football. But I'm here..."*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[106]`
Mówca: **Tarquin Soll**
> ""Why am I not surprised? He's full of ideas, your Mr. Manger, except when it comes to the job he's actually supposed to be doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Ewald Alphonso: ""No need to be so dismissive. Gus has proven himself time..."*)

### Węzeł `[107]`
Mówca: **Ewald Alphonso**
> ""No need to be so dismissive. Gus has proven himself time and again. His work rejuvenated Sordish industries. And without him, Anrica wouldn't be the city it is today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Italic: "Stay silent."*)
  - -> `[109]` (*Player: ""I must say, Gus has been a very valuable minister of my ..."*)
  - -> `[108]` (*Player: ""Honestly, working with Gus has been nothing but a disast..."*)
  - -> `[111]` (*Player: ""What did Gus do for Anrica?""*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, working with Gus has been nothing but a disaster.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Tarquin Soll: ""All of the man's so-called accomplishments have been pur..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must say, Gus has been a very valuable minister of my cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Tarquin Soll: ""Just what we need. Another president in thrall to Mr. Ma..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I let them continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Tarquin Soll: ""All of the man's so-called accomplishments have been pur..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What did Gus do for Anrica?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Ewald Alphonso: ""He invested heavily in this city and helped transform An..."*)

### Węzeł `[112]`
Mówca: **Tarquin Soll**
> ""Just what we need. Another president in thrall to Mr. Manger and his get-rich-quick schemes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Ewald Alphonso: ""You say that, Mr. Soll, but Mr. Manger is a respectable ..."*)

### Węzeł `[113]`
Mówca: **Tarquin Soll**
> ""All of the man's so-called accomplishments have been purely accidental.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Ewald Alphonso: ""You say that, Mr. Soll, but Mr. Manger is a respectable ..."*)

### Węzeł `[114]`
Mówca: **Ewald Alphonso**
> ""He invested heavily in this city and helped transform Anrica into a tourist destination. And he's the one who saw the potential in football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Tarquin Soll: ""All of the man's so-called accomplishments have been pur..."*)

### Węzeł `[115]`
Mówca: **Ewald Alphonso**
> ""You say that, Mr. Soll, but Mr. Manger is a respectable professional who actually loves this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Tarquin Soll: ""More like an errand boy, doing the bidding of those who ..."*)

### Węzeł `[116]`
Mówca: **Tarquin Soll**
> ""More like an errand boy, doing the bidding of those who line his pockets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Alphonso sighed."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Alphonso sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Ewald Alphonso: ""I don't intend to take on the role of his personal spoke..."*)

### Węzeł `[118]`
Mówca: **Ewald Alphonso**
> ""I don't intend to take on the role of his personal spokesman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "As if on cue, Real Montaklar's defense made a crucial block, sending the ball back down the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Player: ""Are you always this negative, Mr. Soll?""*)
  - -> `[124]` (*Player: ""With your strategy skills, you should be a football coac..."*)
  - -> `[123]` (*Player: ""Are you a Real Montaklar supporter, Colonel?""*)
  - -> `[125]` (*Player: ""They'll get it next time. Have some faith in our team.""*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Just then, FC Anrica's star midfielder made a breakaway down the field. The crowd erupted into cheers as the ball was passed from player to player, each touch bringing it closer to the goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[121]`
Mówca: **Tarquin Soll**
> ""Too predictable. They won't make it past the other team's defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "As if on cue, Real Montaklar's defense made a crucial blo..."*)

### Węzeł `[122]`
Mówca: **Ewald Alphonso**
> ""Look. We're going to score.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Tarquin Soll: ""Too predictable. They won't make it past the other team'..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you a Real Montaklar supporter, Colonel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Tarquin Soll: ""Don't make me laugh.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""With your strategy skills, you should be a football coach, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Tarquin Soll: ""Don't make me laugh.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They'll get it next time. Have some faith in our team.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Tarquin Soll: ""Faith alone does not suffice.""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""My boys will win this. You'll see.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My boys will win this. You'll see.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Tarquin Soll: ""Faith alone does not suffice.""*)

### Węzeł `[130]`
Mówca: **Ewald Alphonso**
> ""You know, it was actually Gus Manger's idea. Turning Anrica into the city of Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Ewald Alphonso: ""Without him, Anrica wouldn't be the city it is today. Bu..."*)

### Węzeł `[131]`
Mówca: **Ewald Alphonso**
> ""Without him, Anrica wouldn't be the city it is today. But his instincts may have failed him with this ill-timed strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""Gus must realize he's aiding Soll's cult of personality ..."*)
  - -> `[133]` (*Player: ""Maybe it's not such ill timing. Soll's name has been on ..."*)
  - -> `[132]` (*Player: ""Honestly, working with Gus has been nothing but a disast..."*)
  - -> `[134]` (*Player: ""What did he do for Anrica?""*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, working with Gus has been nothing but a disaster.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Ewald Alphonso: ""Don't be so dismissive. He really is a respectable profe..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maybe it's not such ill timing. Soll's name has been on everyone's lips since the trial.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Ewald Alphonso: ""You make a good point. Maybe Gus' business instincts hav..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What did he do for Anrica?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ewald Alphonso: ""He invested heavily in this city and helped transform An..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gus must realize he's aiding Soll's cult of personality with stunts like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Ewald Alphonso: ""You and I both know Gus. His only allegiance is to his o..."*)

### Węzeł `[136]`
Mówca: **Ewald Alphonso**
> ""He invested heavily in this city and helped transform Anrica into a tourist destination. And he saw the potential of football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: ""Anyway, we didn't come here to talk about Mr. Manger. We..."*)

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> ""Don't be so dismissive. He really is a respectable professional who loves this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: ""Anyway, we didn't come here to talk about Mr. Manger. We..."*)

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> ""You make a good point. Maybe Gus' business instincts have rubbed off on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: ""Anyway, we didn't come here to talk about Mr. Manger. We..."*)

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> ""Anyway, we didn't come here to talk about Mr. Manger. We're here to watch our men win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[140]`
Mówca: **Ewald Alphonso**
> ""Look. We're going to score.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "As if on cue, Real Montaklar's defense made a crucial blo..."*)

### Węzeł `[141]`
Mówca: **Tarquin Soll**
> ""Don't make me laugh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Alphonso turned to me."*)

### Węzeł `[142]`
Mówca: **Tarquin Soll**
> ""Faith alone does not suffice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Alphonso turned to me."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Alphonso turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Ewald Alphonso: ""How about you, Mr. Rayne? It's been a while since we las..."*)

### Węzeł `[144]`
Mówca: **Ewald Alphonso**
> ""How about you, Mr. Rayne? It's been a while since we last met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn11_Election_AssassinationHappened == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn11_Election_AssassinationHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Ewald Alphonso: ""Is everything going well at the Palace?""*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Ewald Alphonso: ""I heard your man Serge gave his life to protect you... M..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Ewald Alphonso: ""How are you holding up after that attack at the parade?""*)

### Węzeł `[151]`
Mówca: **Ewald Alphonso**
> ""How are you holding up after that attack at the parade?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player: ""I'm trying my best to stay calm. Thank you.""*)
  - -> `[169]` (*Player: ""Honestly, I'm worried. The country is showing signs of i..."*)
  - -> `[170]` (*Player: ""It would be a lie if I said it's been great.""*)

### Węzeł `[152]`
Mówca: **Ewald Alphonso**
> ""I heard your man Serge gave his life to protect you... My condolences. He was a true champion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Ewald Alphonso: ""How are you holding up after that attack at the parade?""*)

### Węzeł `[153]`
Mówca: **Ewald Alphonso**
> ""Is everything going well at the Palace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: ""Everything is fine. Thank you.""*)
  - -> `[169]` (*Player: ""Honestly, I'm worried. The country is showing signs of i..."*)
  - -> `[170]` (*Player: ""It would be a lie if I said it's been great.""*)

### Węzeł `[154]`
Mówca: **Narrator**
> "As if on cue, Real Montaklar's defense made a crucial block, sending the ball back down the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Ewald Alphonso: ""Well, damn.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't know you were a football fan, Mr. Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Ewald Alphonso: ""Honestly, I'm more of a money fan. Football is the futur..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They'll get it next time. Have some faith in our team.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Ewald Alphonso: ""That's the spirit.""*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: ""My boys will win this. You'll see.""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My boys will win this. You'll see.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[161]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Ewald Alphonso: ""That's the spirit.""*)

### Węzeł `[161]`
Mówca: **Ewald Alphonso**
> ""Well, damn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: ""I didn't know you were a football fan, Mr. Alphonso.""*)
  - -> `[156]` (*Player: ""They'll get it next time. Have some faith in our team.""*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[162]` (*Player: ""They're against the top team in Eastern Merkopa. It won'..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're against the top team in Eastern Merkopa. It won't be so easy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Ewald Alphonso: ""I'm aware.""*)

### Węzeł `[163]`
Mówca: **Ewald Alphonso**
> ""I'm aware.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "He turned to me."*)

### Węzeł `[164]`
Mówca: **Ewald Alphonso**
> ""That's the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "He turned to me."*)

### Węzeł `[165]`
Mówca: **Ewald Alphonso**
> ""Honestly, I'm more of a money fan. Football is the future, you'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "He turned to me."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Ewald Alphonso: ""So...""*)

### Węzeł `[167]`
Mówca: **Ewald Alphonso**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Ewald Alphonso: ""How about you, Mr. Rayne? It's been a while since we las..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm trying my best to stay calm. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Ewald Alphonso: ""That's a relief.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I'm worried. The country is showing signs of instability again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Ewald Alphonso), `[153]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Ewald Alphonso: ""Yes, Mr. Rayne. Sordish politics is getting complicated ..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It would be a lie if I said it's been great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Ewald Alphonso), `[153]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ewald Alphonso: ""I completely understand what you mean.""*)

### Węzeł `[171]`
Mówca: **Ewald Alphonso**
> ""I completely understand what you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Suddenly, a huge roar shook the stadium. The crowd was in..."*)

### Węzeł `[172]`
Mówca: **Ewald Alphonso**
> ""Yes, Mr. Rayne. Sordish politics is getting complicated again. You have to be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[173]`
Mówca: **Ewald Alphonso**
> ""That's a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Suddenly, a huge roar shook the stadium. The crowd was in..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Suddenly, a huge roar shook the stadium. The crowd was in..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Tarquin Soll: ""Take on the responsibility for once, Mr. Rayne.""*)

### Węzeł `[177]`
Mówca: **Tarquin Soll**
> ""Take on the responsibility for once, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Tarquin Soll: ""You've had the authority for four years.""*)

### Węzeł `[178]`
Mówca: **Tarquin Soll**
> ""You've had the authority for four years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Suddenly, a huge roar shook the stadium. The crowd was in..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Suddenly, a huge roar shook the stadium. The crowd was in a frenzy as FC Anrica finally got the ball past the dominating Rizian defenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Just then, Montaklar midfielders executed an incredibly fast counter-attack, scoring a goal that put them ahead in just a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "The Sordish side of the stadium fell completely silent."*)

### Węzeł `[181]`
Mówca: **Ewald Alphonso**
> ""It was bad luck getting a top-tier Rizian team as our opponent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Ewald Alphonso: ""I still applaud our guys for giving their best. Not even..."*)

### Węzeł `[182]`
Mówca: **Ewald Alphonso**
> ""I still applaud our guys for giving their best. Not even FC Gelsord has ever come this far in an international tournament. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""Why so bleak? It's not even half time yet. Anrica can st..."*)
  - -> `[184]` (*Player: ""Yes. Football is like politics. Sometimes it's all about..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[428]` (*Player: ""Why are you changing the topic?""*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why so bleak? It's not even half time yet. Anrica can still come out on top.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes. Football is like politics. Sometimes it's all about luck.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't overestimate FC Gelsord. We already broke their record and took the title. Times are changing.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[182]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Ewald Alphonso: ""Let's see if they can keep it up.""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: ""Don't overestimate FC Gelsord. We already broke their re..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""Honestly, I don't really care about any of this.""*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't really care about any of this.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[182]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Ewald Alphonso: ""You just need to look like you care, Mr. Rayne.""*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Ewald Alphonso: ""I guess you meant to say money. FC Anrica came this far ..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Ewald Alphonso: ""It's not about luck. It's about money.""*)

### Węzeł `[193]`
Mówca: **Ewald Alphonso**
> ""I guess you meant to say money. FC Anrica came this far thanks to our investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[194]`
Mówca: **Ewald Alphonso**
> ""It's not about luck. It's about money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everything is fine. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Ewald Alphonso: ""That's a relief.""*)

### Węzeł `[196]`
Mówca: **Narrator**
> "The Sordish side of the stadium fell completely silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ewald Alphonso: ""It was bad luck getting a top-tier Rizian team as our op..."*)

### Węzeł `[197]`
Mówca: **Curtan Leste**
> ""Mr. President. I didn't expect you to show your support in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Curtan Leste: ""Thanks for being here. This match means a lot for all of..."*)

### Węzeł `[198]`
Mówca: **Curtan Leste**
> ""Thanks for being here. This match means a lot for all of us Anricans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Gus Manger: ""And all of Sordland! Never before has a Sordish team rea..."*)

### Węzeł `[199]`
Mówca: **Curtan Leste**
> ""You are always welcome in Anrica, and it is great to see you show support in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Curtan Leste: ""Thanks for being here. This match means a lot for all of..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It is great to be here in Anrica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Gus Manger: ""Thanks for coming.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have high hopes for today. This is a big achievement for Sordish football.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Gus Manger: ""Football is of rapidly expanding importance in Sordland ..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't know much about football. But I'm here for the players and for my country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: ""Let's win this, Gus, shall we?""*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's win this, Gus, shall we?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[105]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Gus Manger: ""We most definitely will, Mr. President.""*)

### Węzeł `[207]`
Mówca: **Gus Manger**
> ""We most definitely will, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "The president of the club walked in, handed us gift bags ..."*)

### Węzeł `[208]`
Mówca: **Gus Manger**
> ""Football is of rapidly expanding importance in Sordland and beyond. It's good that we see the opportunity in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "The president of the club walked in, handed us gift bags ..."*)

### Węzeł `[209]`
Mówca: **Gus Manger**
> ""Thanks for coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "The president of the club walked in, handed us gift bags ..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Gus Manger: ""Come on, Mr. President! You own a stake in the club!""*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Gus Manger: ""Football is of rapidly expanding importance in Sordland ..."*)

### Węzeł `[213]`
Mówca: **Gus Manger**
> ""Football is of rapidly expanding importance in Sordland and beyond. It's important to see the opportunities in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "The president of the club walked in, handed us gift bags ..."*)

### Węzeł `[214]`
Mówca: **Gus Manger**
> ""Come on, Mr. President! You own a stake in the club!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "The president of the club walked in, handed us gift bags ..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "The president of the club walked in, handed us gift bags full of FC Anrica merchandise and gave a speech stressing the importance of today's match."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[216]`
**[WYBÓR GRACZA: "Go to the locker room of FC Anrica."]** — Mówca: **Player_Italic**
> "I decided to go to the locker room and talk to the players."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[217]`
Mówca: **Narrator**
> "He personally thanked me for my investment and told me that it wouldn't have been possible to transfer big names to the club without it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "After delivering his best wishes, he kindly pointed us to..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA: "Go directly to the lounge."]** — Mówca: **Player_Italic**
> "I politely refused the offer and proceeded to the heavily guarded lounge area."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Once I finally found myself inside, I was greeted by an a..."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "The lounge area was guarded by heavily armed men. They nodded at me to enter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Once I finally found myself inside, I was greeted by an a..."*)

### Węzeł `[220]`
Mówca: **Ewald Alphonso**
> ""Let's see if they can keep it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The only noise that could be heard from the stadium was s..."*)

### Węzeł `[221]`
Mówca: **Ewald Alphonso**
> ""You just need to look like you care, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The only noise that could be heard from the stadium was s..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_UnrestStopped == false)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Ewald Alphonso: ""Considering that the country is getting mired in interna..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_UnrestStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unr..."*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Peaceful_Happened == true || BaseGame.U..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[228]`
Mówca: **Ewald Alphonso**
> ""Considering that a war with Rumburg is on the horizon, you seem almost too composed and calm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""Well, as the president, I have to be. You know how it is..."*)
  - -> `[255]` (*Player: ""Don't worry, it's under control. Everything will fall in..."*)
  - -> `[256]` (*Player: ""Rumburg may be a massive world power, but nobody should ..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Ewald Alphonso: ""Considering that a war with Rumburg is on the horizon, y..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn02_FPnT_Consulate_Condemn == true && Base..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Ewald Alphonso: ""Considering that Rumburg is actively pushing for war, yo..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unr..."*)

### Węzeł `[235]`
Mówca: **Ewald Alphonso**
> ""Considering that Rumburg is actively pushing for war, you seem too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""Well, as the president, I have to be. You know how it is..."*)
  - -> `[255]` (*Player: ""Don't worry, it's under control. Everything will fall in..."*)
  - -> `[256]` (*Player: ""Rumburg may be a massive world power, but nobody should ..."*)

### Węzeł `[236]`
Mówca: **Ewald Alphonso**
> ""Considering that the country is getting mired in internal conflict, you seem almost too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""Well, as the president, I have to be. You know how it is..."*)
  - -> `[255]` (*Player: ""Don't worry, it's under control. Everything will fall in..."*)
  - -> `[257]` (*Player: ""Don't underestimate the power of the government, Mr. Alp..."*)
  - -> `[258]` (*Player: ""What would you have me do? There's nothing I can do abou..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Ewald Alphonso: ""Considering that the Supreme Court is preparing a case t..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[240]`
Mówca: **Ewald Alphonso**
> ""Considering that the Supreme Court is preparing a case to impeach you, you seem almost too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""Well, as the president, I have to be. You know how it is..."*)
  - -> `[255]` (*Player: ""Don't worry, it's under control. Everything will fall in..."*)
  - -> `[258]` (*Player: ""What would you have me do? There's nothing I can do abou..."*)

### Węzeł `[241]`
Mówca: **Ewald Alphonso**
> ""Considering that you have lost the support of the General Staff, you seem too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""Well, as the president, I have to be. You know how it is..."*)
  - -> `[255]` (*Player: ""Don't worry, it's under control. Everything will fall in..."*)
  - -> `[258]` (*Player: ""What would you have me do? There's nothing I can do abou..."*)
  - -> `[259]` (*Player: ""I'm not scared of them.""*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Ewald Alphonso: ""Considering that you have lost the support of the Genera..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Ewald Alphonso: ""Considering that Sordland is now in a full-on economic c..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[248]`
Mówca: **Ewald Alphonso**
> ""Considering that Sordland is now in a full-on economic crisis, you seem too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""Well, as the president, I have to be. You know how it is..."*)
  - -> `[255]` (*Player: ""Don't worry, it's under control. Everything will fall in..."*)
  - -> `[258]` (*Player: ""What would you have me do? There's nothing I can do abou..."*)
  - -> `[260]` (*Player: ""I didn't start this mess. Unlike you, I did everything i..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Ewald Alphonso: ""Considering that you made allies with Malenyev and force..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Ewald Alphonso: ""Considering everything that's happened in the last four ..."*)

### Węzeł `[252]`
Mówca: **Ewald Alphonso**
> ""Considering that you made allies with Malenyev and forced Sordland into the communist bloc, you seem too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""Well, as the president, I have to be. You know how it is..."*)
  - -> `[255]` (*Player: ""Don't worry, it's under control. Everything will fall in..."*)
  - -> `[261]` (*Player: ""The CSP is the right place to be for Sordland.""*)
  - -> `[262]` (*Player: ""They are our allies now, yes. I'm not scared of them.""*)

### Węzeł `[253]`
Mówca: **Ewald Alphonso**
> ""Considering everything that's happened in the last four years, you seem almost too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""Well, as the president, I have to be. You know how it is..."*)
  - -> `[263]` (*Player: ""What are you saying, Mr. Alphonso?""*)
  - -> `[264]` (*Player: ""Do I really look that composed? That's good to know.""*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, as the president, I have to be. You know how it is, Mr. Former President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Ewald Alphonso), `[235]` (Ewald Alphonso), `[236]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry, it's under control. Everything will fall into place soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Ewald Alphonso), `[235]` (Ewald Alphonso), `[236]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rumburg may be a massive world power, but nobody should underestimate Sordland. You will see what we are capable of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Ewald Alphonso), `[235]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't underestimate the power of the government, Mr. Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What would you have me do? There's nothing I can do about that anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Ewald Alphonso), `[240]` (Ewald Alphonso), `[241]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not scared of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't start this mess. Unlike you, I did everything in my power to fix the situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The CSP is the right place to be for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They are our allies now, yes. I'm not scared of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are you saying, Mr. Alphonso?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Ewald Alphonso: ""You don't need to read between the lines.""*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do I really look that composed? That's good to know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[265]`
Mówca: **Ewald Alphonso**
> ""You don't need to read between the lines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[266]`
Mówca: **Ewald Alphonso**
> ""You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The only noise that could be heard from the stadium was s..."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "The only noise that could be heard from the stadium was shouting from the Rizian side: "Montaklar!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "All eyes were glued to the scoreboard as the new score ap..."*)

### Węzeł `[268]`
Mówca: **Narrator**
> "All eyes were glued to the scoreboard as the new score appeared: "FC Anrica 0 - Real Montaklar 1.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "From that moment on, we turned our complete attention to ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "I heard Tarquin Soll laugh."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "I heard Tarquin Soll laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Tarquin Soll: ""What you did can only be described as treachery, Mr. Ray..."*)

### Węzeł `[276]`
Mówca: **Tarquin Soll**
> ""What you did can only be described as treachery, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso == true"*)

### Węzeł `[277]`
Mówca: **Tarquin Soll**
> ""I can now see that despite everything, Mr. Alphonso here was a much better president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[278]`
Mówca: **Narrator**
> "From that moment on, we turned our complete attention to the match in front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Ewald Alphonso: ""You're right.""*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Tarquin Soll: ""Don't expect that to make sense for him. You are talking..."*)

### Węzeł `[282]`
Mówca: **Tarquin Soll**
> ""Don't expect that to make sense for him. You are talking to Ewald Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Ewald Alphonso: ""Sure. I'll be a punching bag for both of you today.""*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ewald Alphonso: ""Look. We're going to score.""*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Ewald Alphonso: ""Look. We're going to score.""*)

### Węzeł `[286]`
Mówca: **Ewald Alphonso**
> ""Sure. I'll be a punching bag for both of you today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The only noise that could be heard from the stadium was s..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Tarquin Soll: ""Sadly, money is still the only thing you care about.""*)

### Węzeł `[290]`
Mówca: **Tarquin Soll**
> ""Sadly, money is still the only thing you care about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso == true"*)

### Węzeł `[291]`
Mówca: **Narrator**
> "Suddenly, the ball was passed to the famous Sordish striker, Hakon Zlater, who was in front of the goal. I noticed Soll shifting in his seat, his gaze suddenly locked on the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Narrator: "The Sordish crowd went crazy as Zlater's powerful shot br..."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "The referee blew the whistle. It was halftime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Ewald Alphonso: ""That was rough.""*)

### Węzeł `[293]`
Mówca: **Narrator**
> "We heard a noise from above us. A zeppelin was flying over the stadium with a giant poster hanging beneath it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "I noticed that it was an advertisement for the Alphonso F..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "The Anrican players already seemed like they had given th..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0)"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "The Anrican players already seemed like they had given up..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "The Rizian players kept dominating the field."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "The Anrican players already seemed like they had given their all. They looked incredibly stressed and tired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "The referee blew the whistle. It was halftime."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "The Anrican players already seemed like they had given up. They looked incredibly calm, but their movements were slow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "The referee blew the whistle. It was halftime."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "The Rizian players kept dominating the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "The referee blew the whistle. It was halftime."*)

### Węzeł `[303]`
Mówca: **Ewald Alphonso**
> ""That was rough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "We heard a noise from above us. A zeppelin was flying ove..."*)

### Węzeł `[304]`
Mówca: **Narrator**
> "I noticed that it was an advertisement for the Alphonso Foundation. At the center of the poster stood Ewald Alphonso, portrayed with a warm smile and a twinkle in his eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "In his outstretched hand, he held a whimsical compass, gl..."*)

### Węzeł `[305]`
Mówca: **Narrator**
> "In his outstretched hand, he held a whimsical compass, glowing with a soft golden light. Surrounding him were people from all walks of life and cultures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "The tagline, written in elegant and uplifting typography,..."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "The tagline, written in elegant and uplifting typography, was prominently displayed at the bottom: "Alphonso Foundation: Bringing Hope To Those In Need, One Act of Kindness at a Time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player: ""Now you're asking for donations at football matches? How..."*)
  - -> `[308]` (*Player: ""Well... That's new.""*)
  - -> `[309]` (*Player: ""Really?""*)
  - -> `[310]` (*Player_Italic: "Don't comment."*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now you're asking for donations at football matches? How does a non-profit even afford this ad?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Ewald Alphonso: ""I'm doing my best to increase our exposure and to help t..."*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... That's new.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Ewald Alphonso: ""Wait. There's more.""*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Really?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Ewald Alphonso: ""I'm doing my best to increase our exposure and to help t..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I decided not to speak."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "Just then, the speakers in the stadium started playing a ..."*)

### Węzeł `[311]`
Mówca: **Ewald Alphonso**
> ""I'm doing my best to increase our exposure and to help the homeless of this country. This isn't some commercial advertisement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "Just then, the speakers in the stadium started playing a ..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "Just then, the speakers in the stadium started playing a sound recording in full volume."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: ""Ladies and gentlemen, we bring you a message from the Al..."*)

### Węzeł `[313]`
Mówca: **Ewald Alphonso**
> ""Wait. There's more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "Just then, the speakers in the stadium started playing a ..."*)

### Węzeł `[314]`
Mówca: **Narrator**
> ""Ladies and gentlemen, we bring you a message from the Alphonso Foundation, dedicated to spreading kindness and hope to the less fortunate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: ""Picture a Sordland where compassion shines brighter than..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> ""Picture a Sordland where compassion shines brighter than the stars in the night sky, where the power of generosity uplifts those who need it most. That Sordland can exist, thanks to the Alphonso Foundation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: ""Led by the charismatic and esteemed President Ewald Alph..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> ""Led by the charismatic and esteemed President Ewald Alphonso, this foundation is on a mission to make a difference in the lives of our fellow citizens, one act of kindness at a time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[317]`
Mówca: **Narrator**
> ""Every Sordish Ren you donate to the Alphonso Foundation helps us provide shelter, food, and a chance for a brighter future to those without a home, without hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true"*)

### Węzeł `[318]`
Mówca: **Narrator**
> ""Thanks to the donations of President Ewald Alphonso and thousands of Sordish citizens, the Alphonso Foundation has already lifted hundreds out of homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_FoundationDonation_LargeSum ==..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: ""Thanks to the donations of President Ewald Alphonso, and..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_FoundationDonation_SmallSum ==..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: ""Thanks to the donations of President Ewald Alphonso, and..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: ""Thanks to the donations of President Ewald Alphonso and ..."*)

### Węzeł `[325]`
Mówca: **Narrator**
> ""Thanks to the donations of President Ewald Alphonso, and esteemed figures like President Anton Rayne, as well as thousands of Sordish citizens, the Alphonso Foundation has already lifted thousands out of homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[326]`
Mówca: **Narrator**
> ""Won't you join us in this noble endeavor? Just call the number, 1-600-ALPHONSO, to make your contribution today. Your support will help us extend a helping hand to those in need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "The recording ended with a few seconds of upbeat jazzy ba..."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "The recording ended with a few seconds of upbeat jazzy background music that slowly faded out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_FoundationDonation_LargeSum == t..."*)
  - -> `[332]` (*Player: ""It's good to see that you're at least helping the poor i..."*)
  - -> `[333]` (*Player: ""I'll be honest. I think that ad was a little distasteful.""*)
  - -> `[338]` (*Player: ""What the hell was that?""*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate the credit, but you didn't need to put my name in there.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true  or  Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true`
- **Kontekst wejściowy (poprzednik):** `[327]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Ewald Alphonso: ""It helps with the donations.""*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true || BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_FoundationDonation_LargeSum == t..."*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_FoundationDonation_LargeSum ==..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true || BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true  or  Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player: ""I appreciate the credit, but you didn't need to put my n..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true || BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true  or  Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see that you're at least helping the poor in some way. That is commendable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Ewald Alphonso: ""Thanks for the support.""*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest. I think that ad was a little distasteful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Ewald Alphonso: ""I beg to differ.""*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player: ""You don't even live here anymore. I'm surprised you'd th..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You don't even live here anymore. I'm surprised you'd think an ad like this would work.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Kontekst wejściowy (poprzednik):** `[327]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Ewald Alphonso: ""Why wouldn't it? Don't act like I'm no longer Sordish. I..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What the hell was that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Ewald Alphonso: ""What's wrong?""*)

### Węzeł `[339]`
Mówca: **Ewald Alphonso**
> ""It helps with the donations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[340]`
Mówca: **Ewald Alphonso**
> ""Why wouldn't it? Don't act like I'm no longer Sordish. I was also a president of this republic, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[341]`
Mówca: **Ewald Alphonso**
> ""I beg to differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[342]`
Mówca: **Ewald Alphonso**
> ""Thanks for the support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[343]`
Mówca: **Ewald Alphonso**
> ""What's wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Ewald Alphonso: ""Unlike Soll, I'm trying to use my retirement to make a c..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Tarquin Soll: ""Alphonso. Are you not ashamed?""*)

### Węzeł `[347]`
Mówca: **Tarquin Soll**
> ""Alphonso. Are you not ashamed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Tarquin Soll: ""You had your whole term to plan affordable housing progr..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Ewald Alphonso: ""Unlike Soll, I'm trying to use my retirement to make a c..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Tarquin Soll: ""You're both mad.""*)

### Węzeł `[351]`
Mówca: **Tarquin Soll**
> ""You're both mad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Tarquin Soll: ""You had your whole term to plan affordable housing progr..."*)

### Węzeł `[352]`
Mówca: **Tarquin Soll**
> ""You had your whole term to plan affordable housing programs. Instead, you decided to pass the buck to Mr. Rayne here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HousingAssistance == true"*)

### Węzeł `[353]`
Mówca: **Tarquin Soll**
> ""Is this your way of personal redemption -- spending a few Rens out of your billions and portraying yourself as their saviour?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso == true"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: ""Won't you join us in this noble endeavor? Just call the ..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Tarquin Soll: ""A couple of hundred people? Congratulations to you both...."*)

### Węzeł `[357]`
Mówca: **Tarquin Soll**
> ""A couple of hundred people? Congratulations to you both. This is how Sordland will eradicate poverty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: ""Won't you join us in this noble endeavor? Just call the ..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: ""Won't you join us in this noble endeavor? Just call the ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Tarquin Soll: ""You too, Mr. Rayne? I thought you would see through this..."*)

### Węzeł `[361]`
Mówca: **Tarquin Soll**
> ""You too, Mr. Rayne? I thought you would see through this scheme.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: ""Won't you join us in this noble endeavor? Just call the ..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: ""Every Sordish Ren you donate to the Alphonso Foundation ..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Tarquin Soll: ""You call this kindness?""*)

### Węzeł `[365]`
Mówca: **Tarquin Soll**
> ""You call this kindness?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: ""Every Sordish Ren you donate to the Alphonso Foundation ..."*)

### Węzeł `[366]`
Mówca: **Ewald Alphonso**
> ""Unlike you, Mr. Soll, I'm not portraying myself as a hero here. I retired from politics just like you did, and I'm now using my clout to help the poor. What's so wrong about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Tarquin Soll: ""You know I never called myself a hero, Ewald. It was my ..."*)

### Węzeł `[367]`
Mówca: **Ewald Alphonso**
> ""Unlike Soll, I'm trying to use my retirement to make a change. I believe there's a lot of value in using my clout to generate money for those in need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)
  - -> `[376]` (*Player: ""As much as I respect that, I don't believe an issue like..."*)
  - -> `[377]` (*Player: ""And I support your endeavors on that.""*)
  - -> `[378]` (*Player: ""You don't need to explain or justify, Ewald. I get the i..."*)

### Węzeł `[368]`
Mówca: **Tarquin Soll**
> ""You know I never called myself a hero, Ewald. It was my supporters who portrayed me as one. Don't spin the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Ewald Alphonso: ""Maybe they didn't have any other choice back then.""*)

### Węzeł `[369]`
Mówca: **Ewald Alphonso**
> ""Maybe they didn't have any other choice back then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Player: ""Is that even true, Mr. Soll? Are you really denying that..."*)
  - -> `[388]` (*Player: ""Nobody had any choice. There was no other option.""*)
  - -> `[389]` (*Player: ""Despite everything, we can't deny the millions of people..."*)
  - -> `[390]` (*Player_Italic: "Don't comment."*)

### Węzeł `[370]`
Mówca: **Tarquin Soll**
> ""Are you still sore about the party giving you a hard time after I left? Admit it, Ewald. You never could accept being a less popular leader. You hated living under the shadow of what I built.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Ewald Alphonso: ""It is true. I did hate working inside your shadow empire..."*)

### Węzeł `[371]`
Mówca: **Ewald Alphonso**
> ""It is true. I did hate working inside your shadow empire. But I succeeded in dismantling a lot of those obstacles you laid out for me, and opened the way for reforms. But you never let the party go free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Tarquin Soll: ""So it was I who controlled each and every member? I was ..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Player: ""You know I'm not going to take that response at face val..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know I'm not going to take that response at face value. But regardless, I really hope your intentions are genuine.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == false`
- **Kontekst wejściowy (poprzednik):** `[367]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Ewald Alphonso: ""They are, Mr. Rayne. You can be sure of it.""*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As much as I respect that, I don't believe an issue like this can be left to the *kindness* of the wealthy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[367]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And I support your endeavors on that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[367]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Ewald Alphonso: ""I really appreciate that.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You don't need to explain or justify, Ewald. I get the idea already.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[367]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Ewald Alphonso: ""Fair enough.""*)

### Węzeł `[379]`
Mówca: **Ewald Alphonso**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[380]`
Mówca: **Ewald Alphonso**
> ""I really appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[381]`
Mówca: **Ewald Alphonso**
> ""Oh no. Is that a Malenyevist talking point? I guess we have to agree to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Ewald Alphonso: ""Oh. I almost forgot about your heavy shift towards Malen..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Ewald Alphonso: ""Oh no. Is that a Malenyevist talking point? I guess we h..."*)

### Węzeł `[385]`
Mówca: **Ewald Alphonso**
> ""Oh. I almost forgot about your heavy shift towards Malenyevism. I guess I will just stop right here and we have to agree to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[386]`
Mówca: **Ewald Alphonso**
> ""They are, Mr. Rayne. You can be sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that even true, Mr. Soll? Are you really denying that you did nothing to construct a cult of personality?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == true"*)

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Nobody had any choice. There was no other option.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Ewald Alphonso: ""Precisely my point. Would you say it is a valid choice i..."*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Despite everything, we can't deny the millions of people who loved and respected Mr. Soll. That is the reality.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Ewald Alphonso: ""I'm not saying otherwise. But I must remind you, those s..."*)

### Węzeł `[390]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Tarquin Soll: ""Are you still sore about the party giving you a hard tim..."*)

### Węzeł `[391]`
Mówca: **Ewald Alphonso**
> ""Precisely my point. Would you say it is a valid choice if you only had one option to pick from?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Tarquin Soll: ""Are you still sore about the party giving you a hard tim..."*)

### Węzeł `[392]`
Mówca: **Ewald Alphonso**
> ""I'm not saying otherwise. But I must remind you, those same people also stood in the way of progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Tarquin Soll: ""Are you still sore about the party giving you a hard tim..."*)

### Węzeł `[393]`
Mówca: **Tarquin Soll**
> ""What does it matter? You believed in that so much that you already ordered the removal of my face from public places, haven't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Ewald Alphonso: ""Mr. Rayne has a point, Mr. Soll.""*)

### Węzeł `[394]`
Mówca: **Tarquin Soll**
> ""So it was I who controlled each and every member? I was behind every problem you faced within the USP? Do you really believe that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Ewald Alphonso: ""You are the founder of the party, Mr. Soll. Don't even t..."*)

### Węzeł `[395]`
Mówca: **Ewald Alphonso**
> ""I still remember how the party became divided after you stopped supporting me. It is on them for being blind to the progress we were making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Player: ""What do you mean? Mr. Soll supported you after the congr..."*)
  - -> `[398]` (*Player: ""Sollists still make up the bulk of the USP today. Everyb..."*)
  - -> `[401]` (*Player: ""Gentlemen. Why don't we calm down a little? We are here ..."*)
  - -> `[402]` (*Player_Italic: "Don't comment."*)

### Węzeł `[396]`
Mówca: **Ewald Alphonso**
> ""You are the founder of the party, Mr. Soll. Don't even try to deny your influence over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Ewald Alphonso: ""I still remember how the party became divided after you ..."*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you mean? Mr. Soll supported you after the congress?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Ewald Alphonso: ""Briefly, yes. The last couple years until I became presi..."*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sollists still make up the bulk of the USP today. Everybody is aware of your influence, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Tarquin Soll: ""Instead of blaming the party, why don't you take a look ..."*)

### Węzeł `[399]`
Mówca: **Tarquin Soll**
> ""Instead of blaming the party, why don't you take a look at yourself? That same party voted me out on their own volition in preference of *you*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Tarquin Soll: ""According to you, their only *correct* decision must hav..."*)

### Węzeł `[400]`
Mówca: **Tarquin Soll**
> ""According to you, their only *correct* decision must have been to elect *you* as leader. And the rest are completely wrong. Do you think everything is a problem that is specifically created to block *you*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Tarquin Soll: ""Take a look at yourself. You are the personification of ..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gentlemen. Why don't we calm down a little? We are here to watch football.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "Neither of the two men seemed to care. They continued wit..."*)

### Węzeł `[402]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Tarquin Soll: ""Instead of blaming the party, why don't you take a look ..."*)

### Węzeł `[403]`
Mówca: **Narrator**
> "Neither of the two men seemed to care. They continued without stopping to hear what I said."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Tarquin Soll: ""Instead of blaming the party, why don't you take a look ..."*)

### Węzeł `[404]`
Mówca: **Tarquin Soll**
> ""Instead of blaming the party, why don't you take a look at yourselves? That same party has voted me out on their own volition in preference of the likes of *you*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Tarquin Soll: ""According to you, their only *correct* decision must hav..."*)

### Węzeł `[405]`
Mówca: **Tarquin Soll**
> ""Take a look at yourself. You are the personification of what you're trying to criticize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Player: ""You have a point, Mr. Soll. But don't act like you're ab..."*)
  - -> `[418]` (*Player: ""That's an empty argument. The party and the government w..."*)
  - -> `[419]` (*Player: ""This is getting out of hand. I think both of you should ..."*)
  - -> `[420]` (*Player: ""Oh, please. We know that you are still trying to pull th..."*)

### Węzeł `[406]`
Mówca: **Ewald Alphonso**
> ""Briefly, yes. The last couple years until I became president in '49, he pushed several of my plans through. And I thought he believed in my vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Tarquin Soll: ""Your vision? Ha!""*)

### Węzeł `[407]`
Mówca: **Ewald Alphonso**
> ""But it was all to get credit for initiating the reforms, wasn't it? That was the only way to save Sollism for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Ewald Alphonso: ""You were already voted out by your own followers and you..."*)

### Węzeł `[408]`
Mówca: **Tarquin Soll**
> ""Your vision? Ha!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player: ""I remember Soll's reforms but I still remember those yea..."*)
  - -> `[413]` (*Player: ""Are you saying Mr. Soll's reforms between '46 and '49 we..."*)
  - -> `[412]` (*Player_Italic: "Don't comment."*)

### Węzeł `[409]`
Mówca: **Ewald Alphonso**
> ""You were already voted out by your own followers and your term was ending in a few years. You couldn't afford to go against the current.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Tarquin Soll: ""You're being ingrateful, Ewald. I agreed to your reforms..."*)

### Węzeł `[410]`
Mówca: **Tarquin Soll**
> ""You're being ingrateful, Ewald. I agreed to your reforms to help smooth the transition of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Tarquin Soll: ""I did not believe in your *vision*, but I truly wished f..."*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I remember Soll's reforms but I still remember those years as being very unstable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Ewald Alphonso: ""My wing and I pushed for those reforms. Soll merely appr..."*)

### Węzeł `[412]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Ewald Alphonso: ""But it was all to get credit for initiating the reforms,..."*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you saying Mr. Soll's reforms between '46 and '49 were actually your plans?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Ewald Alphonso: ""Of course, they were. It was the Sollists that portrayed..."*)

### Węzeł `[414]`
Mówca: **Ewald Alphonso**
> ""Of course, they were. It was the Sollists that portrayed it differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "He looked Tarquin Soll in the eye."*)

### Węzeł `[415]`
Mówca: **Narrator**
> "He looked Tarquin Soll in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Ewald Alphonso: ""But it was all to get credit for initiating the reforms,..."*)

### Węzeł `[416]`
Mówca: **Ewald Alphonso**
> ""My wing and I pushed for those reforms. Soll merely approved them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "He looked Tarquin Soll in the eye."*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You have a point, Mr. Soll. But don't act like you're above all of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[405]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "He waved a dismissive hand, as if to brush away the notion."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's an empty argument. The party and the government were in that state due to your actions over 20 years.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[405]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Tarquin Soll: ""Correct. They built a republic within two decades in the..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is getting out of hand. I think both of you should calm down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[405]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Ewald Alphonso: ""I agree.""*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, please. We know that you are still trying to pull the strings behind the scenes, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[405]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Tarquin Soll: ""Now you just sound paranoid, Rayne.""*)

### Węzeł `[421]`
Mówca: **Tarquin Soll**
> ""Correct. They built a republic within two decades in the harshest political climate, and they reached a state of being able to elect and oust their own leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Tarquin Soll: ""Oh, what a disastrous state to be in.""*)

### Węzeł `[422]`
Mówca: **Tarquin Soll**
> ""Oh, what a disastrous state to be in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[423]`
Mówca: **Narrator**
> "He waved a dismissive hand, as if to brush away the notion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Soll_Hates_Alphonso == true)"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Soll_Hates_Alphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Tarquin Soll: ""I can see now that both of you have only brought disaste..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Soll_Hates_Alphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Soll_Hates_Alphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Tarquin Soll: ""I can now see that despite everything, Mr. Alphonso here..."*)

### Węzeł `[427]`
Mówca: **Tarquin Soll**
> ""I can see now that both of you have only brought disaster to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Just then, Montaklar midfielders executed an incredibly f..."*)

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are you changing the topic?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Ewald Alphonso: ""What do you mean? They just scored.""*)

### Węzeł `[429]`
Mówca: **Ewald Alphonso**
> ""What do you mean? They just scored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The only noise that could be heard from the stadium was s..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso == true"*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Soll_Hates_Alphonso == true)"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Soll_Hates_Alphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Tarquin Soll: ""Not a punching bag. You deserve to be in prison for your..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Soll_Hates_Alphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Soll_Hates_Alphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The only noise that could be heard from the stadium was s..."*)

### Węzeł `[433]`
Mówca: **Tarquin Soll**
> ""Not a punching bag. You deserve to be in prison for your deal with the Rums.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "Ewald's face turned expressionless."*)

### Węzeł `[434]`
Mówca: **Narrator**
> "Ewald's face turned expressionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The only noise that could be heard from the stadium was s..."*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Soll_Hates_Alphonso == true)"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Soll_Hates_Alphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Tarquin Soll: ""Not a punching bag. You deserve to be in prison for your..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Soll_Hates_Alphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Soll_Hates_Alphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The only noise that could be heard from the stadium was s..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso == true"*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Soll_Hates_Alphonso == true)"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Soll_Hates_Alphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Tarquin Soll: ""No donation can redeem your betrayal to this country.""*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Soll_Hates_Alphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Soll_Hates_Alphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Ewald Alphonso: ""Unlike you, Mr. Soll, I'm not portraying myself as a her..."*)

### Węzeł `[441]`
Mówca: **Tarquin Soll**
> ""No donation can redeem your betrayal to this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Ewald Alphonso: ""Unlike you, Mr. Soll, I'm not portraying myself as a her..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == true"*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_DeSollinisation == t..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Tarquin Soll: ""What does it matter? You believed in that so much that y..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_DeSollinisation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Tarquin Soll: ""I didn't need to build a cult for myself, Mr. Rayne. I b..."*)

### Węzeł `[445]`
Mówca: **Tarquin Soll**
> ""I didn't need to build a cult for myself, Mr. Rayne. I built a republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Ewald Alphonso: ""You *rebuilt* it in your own vision.""*)

### Węzeł `[446]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne has a point, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Narrator: "Tarquin Soll locked his gaze at Ewald."*)

### Węzeł `[447]`
Mówca: **Ewald Alphonso**
> ""You *rebuilt* it in your own vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Narrator: "Tarquin Soll locked his gaze at Ewald."*)

### Węzeł `[448]`
Mówca: **Narrator**
> "Tarquin Soll locked his gaze at Ewald."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Tarquin Soll: ""Are you still sore about the party giving you a hard tim..."*)

### Węzeł `[449]`
Mówca: **Tarquin Soll**
> ""I did not believe in your *vision*, but I truly wished for your success -- for the sake of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Tarquin Soll: ""But soon after your destruction of our economy, I realiz..."*)

### Węzeł `[450]`
Mówca: **Tarquin Soll**
> ""But soon after your destruction of our economy, I realized how naive I was to open that gate for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[451]`
Mówca: **Narrator**
> "Suddenly, we turned our heads to the field as a massive roar shook the stadium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Narrator: "The second half was already in full swing and Anrican pla..."*)

### Węzeł `[452]`
Mówca: **Ewald Alphonso**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[453]`
Mówca: **Tarquin Soll**
> ""Now you just sound paranoid, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Suddenly, we turned our heads to the field as a massive r..."*)

### Węzeł `[454]`
Mówca: **Narrator**
> "The second half was already in full swing and Anrican players were aggressively attacking, weaving in and out of defenders with speed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[455]`
Mówca: **Narrator**
> "The Sordish crowd went crazy as Zlater's powerful shot brought the ball to the back of the Rizian net."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Ewald Alphonso: ""YES!""*)

### Węzeł `[456]`
Mówca: **Ewald Alphonso**
> ""YES!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "Ewald jumped from his seat."*)

### Węzeł `[457]`
Mówca: **Narrator**
> "Ewald jumped from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "Anrican fans dominated the stadium as the scoreboard was ..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Narrator: "Suddenly, the cheering was interrupted by the linesman ra..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Diplomacy");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Diplomacy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you always this negative, Mr. Soll?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Tarquin Soll: ""I'm a realist, Mr. Rayne. I don't have time for fake pos..."*)

### Węzeł `[463]`
Mówca: **Tarquin Soll**
> ""I'm a realist, Mr. Rayne. I don't have time for fake positivities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Alphonso turned to me."*)

### Węzeł `[464]`
Mówca: **Narrator**
> "Suddenly, the cheering was interrupted by the linesman raising the flag -- making an offside call."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Ewald Alphonso: ""Bullshit! That wasn't an offside.""*)

### Węzeł `[465]`
Mówca: **Narrator**
> "Anrican fans dominated the stadium as the scoreboard was replaced with the new score: "FC Anrica 1 - Real Montaklar 1.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Ewald Alphonso: ""That was a great comeback. We can still make it.""*)

### Węzeł `[466]`
Mówca: **Ewald Alphonso**
> ""Bullshit! That wasn't an offside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player: ""That referee is trying to sabotage us. He was clearly in..."*)
  - -> `[468]` (*Player: ""Do you think the Rizians could have bought the referees?""*)
  - -> `[469]` (*Player: ""To be fair, nobody here cares.""*)
  - -> `[470]` (*Player_Italic: "Do not comment."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That referee is trying to sabotage us. He was clearly in front of the defenders when he received the ball.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think the Rizians could have bought the referees?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Ewald Alphonso: ""Well... They have the prestige and the money to do that.""*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, nobody here cares.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[470]`
**[WYBÓR GRACZA: "Do not comment."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[471]`
Mówca: **Ewald Alphonso**
> ""That was a great comeback. We can still make it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player: ""You should have more faith in our Sordish players.""*)
  - -> `[495]` (*Player: ""Exactly. We can be the underdogs here, but we cannot let..."*)
  - -> `[497]` (*Player: ""To be fair, nobody here cares.""*)
  - -> `[498]` (*Player_Italic: "Do not comment."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Ewald Alphonso: ""The angle was all wrong. A decision like that shouldn't ..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Tarquin Soll: ""Halt your endless bickering. The linesman made the right..."*)

### Węzeł `[475]`
Mówca: **Tarquin Soll**
> ""Halt your endless bickering. The linesman made the right call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Ewald Alphonso: ""The angle was all wrong. A decision like that shouldn't ..."*)

### Węzeł `[476]`
Mówca: **Ewald Alphonso**
> ""Well... I still do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Ewald Alphonso: ""It's your own club, Mr. Rayne. But suit yourself.""*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Ewald Alphonso: ""Well... I still do.""*)

### Węzeł `[480]`
Mówca: **Ewald Alphonso**
> ""It's your own club, Mr. Rayne. But suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[481]`
Mówca: **Ewald Alphonso**
> ""Well... They have the prestige and the money to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[482]`
Mówca: **Ewald Alphonso**
> ""The angle was all wrong. A decision like that shouldn't be made without proper evaluation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[483]`
Mówca: **Tarquin Soll**
> ""What next? You're going to install cameras and analyze every position from different angles?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "The excitement in the stadium reached a fever pitch as th..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "The excitement in the stadium reached a fever pitch as th..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Tarquin Soll: ""Halt your endless bickering. The linesman made the right..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player_Italic: "Stay silent."*)
  - -> `[492]` (*Player: ""What next? You're going to install cameras and analyze e..."*)
  - -> `[491]` (*Player: ""The Global Football Association is clearly biased agains..."*)
  - -> `[490]` (*Player: ""Just let it be, Ewald.""*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Tarquin Soll: ""What next? You're going to install cameras and analyze e..."*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just let it be, Ewald.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[482]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "The excitement in the stadium reached a fever pitch as th..."*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Global Football Association is clearly biased against us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[482]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "The excitement in the stadium reached a fever pitch as th..."*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What next? You're going to install cameras and analyze every position from different angles?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[482]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "The excitement in the stadium reached a fever pitch as th..."*)

### Węzeł `[493]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[482]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "The excitement in the stadium reached a fever pitch as th..."*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You should have more faith in our Sordish players.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Ewald Alphonso: ""You're right.""*)

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Exactly. We can be the underdogs here, but we cannot let the Rizians intimidate us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Ewald Alphonso: ""You're right.""*)

### Węzeł `[496]`
Mówca: **Narrator**
> "The excitement in the stadium reached a fever pitch as the Sordish striker dribbled the ball past two defenders and took a shot at the goal again. The crowd held its breath as the ball sailed through the air, but the Montaklar goalkeeper made a miraculous save."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Ewald Alphonso: ""Damn. That was close.""*)

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, nobody here cares.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[498]`
**[WYBÓR GRACZA: "Do not comment."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Narrator: "As the last minutes of the match kicked in, we found ours..."*)

### Węzeł `[499]`
Mówca: **Ewald Alphonso**
> ""Well... I still do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Narrator: "As the last minutes of the match kicked in, we found ours..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Ewald Alphonso: ""It's your own club, Mr. Rayne. But suit yourself.""*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Ewald Alphonso: ""Well... I still do.""*)

### Węzeł `[503]`
Mówca: **Ewald Alphonso**
> ""It's your own club, Mr. Rayne. But suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Narrator: "As the last minutes of the match kicked in, we found ours..."*)

### Węzeł `[504]`
Mówca: **Narrator**
> "The excitement in the stadium reached a fever pitch as the Rizian striker dribbled the ball past two defenders and took a shot at the goal. The crowd held its breath as the ball sailed through the air, but the Anrican goalkeeper made a miraculous save."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Ewald Alphonso: ""Damn. That was close.""*)

### Węzeł `[505]`
Mówca: **Narrator**
> "As the last minutes of the match kicked in, we found ourselves falling more and more silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Narrator: "The excitement in the stadium reached a fever pitch as th..."*)

### Węzeł `[506]`
Mówca: **Ewald Alphonso**
> ""You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Narrator: "As the last minutes of the match kicked in, we found ours..."*)

### Węzeł `[507]`
Mówca: **Ewald Alphonso**
> ""Damn. That was close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "He suddenly pointed to a group of people who were holding..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_LileasResigned == true && BaseGame.Rumburg_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_LileasResigned == true && BaseGame.Rumb..."*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_A_LileasResigned == true && BaseGame.Ru..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_LileasResigned == true && BaseGame.Rumburg_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_A_LileasResigned"] == true  and  Variable["BaseGame.Rumburg_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_A_LileasResigned == true && BaseGame.Rumburg_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_A_LileasResigned"] == true  and  Variable["BaseGame.Rumburg_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_LileasResigned == true && BaseGame.Rumb..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn02_FPnT_Consulate_Condemn == true && Base..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "It was a group of Rizians who were holding signs in the S..."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[523]`
Mówca: **Narrator**
> "He suddenly pointed to a group of people who were holding signs in the front row."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Ewald Alphonso: ""Do you see that?""*)

### Węzeł `[524]`
Mówca: **Ewald Alphonso**
> ""Do you see that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[525]`
Mówca: **Narrator**
> "It was a group of Rizians who were holding signs in the Sordish language: "No To War In Merkopa. Peace Between Rumburg and Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Ewald Alphonso: ""Looks like Rizians are also scared of a possible war bet..."*)

### Węzeł `[526]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "Soldiers! Leave Your Barracks! Colonel's Home Is In Need!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Ewald Alphonso: ""They need to be arrested for putting up such signs.""*)

### Węzeł `[527]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Together With Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Tarquin Soll: ""At least you still have the support of somebody.""*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[531]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Against Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Narrator: "Another massive sign displayed the words: "Bring Rayne To..."*)

### Węzeł `[532]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Together With Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Ewald Alphonso: ""Looks like the impeachment case did not damage your foot..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[536]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands With Lileas Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Ewald Alphonso: ""Looks like FC Anrica fans are really into politics. But ..."*)

### Węzeł `[537]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Together With Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "Behind them, a poster was being displayed with my and Lil..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true || BaseGame.Turn0..."*)

### Węzeł `[541]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands With The National Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Ewald Alphonso: ""It really seems like Anrica is going to be lost to the N..."*)

### Węzeł `[542]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Together With Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Ewald Alphonso: ""It seems like Anricans like you a lot.""*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true || BaseGame.Turn09_EnT_SordishRecovery == true || (BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Policy_Welfare_EducationReform == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true || BaseGame.Turn0..."*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true || BaseGame.Tur..."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true || BaseGame.Turn09_EnT_SordishRecovery == true || (BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Policy_Welfare_EducationReform == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  or  (Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Policy_Welfare_EducationReform"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true || BaseGame.Turn09_EnT_SordishRecovery == true || (BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Policy_Welfare_EducationReform == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  or  (Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Policy_Welfare_EducationReform"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Player: ""I wish Serge could have lived to see this day.""*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wish Serge could have lived to see this day.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Kontekst wejściowy (poprzednik):** `[60]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Lucian Galade: ""Truly a tragedy, sir. I know the pain is still fresh.""*)

### Węzeł `[551]`
Mówca: **Lucian Galade**
> ""Truly a tragedy, sir. I know the pain is still fresh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "We made our way towards the Maroon Stadium. The arena was..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_Dead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == true"*)
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Petr_Dead == true)"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_Dead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Petr_Dead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Player: ""I can't believe Petr's not here to see this.""*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Petr_Dead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Petr_Dead"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can't believe Petr's not here to see this.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Petr_Dead"] == true`
- **Kontekst wejściowy (poprzednik):** `[60]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Lucian Galade: ""A tragedy, sir. Mr. Vectern did excel at making public a..."*)

### Węzeł `[556]`
Mówca: **Lucian Galade**
> ""A tragedy, sir. Mr. Vectern did excel at making public appearances, if nothing else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "We made our way towards the Maroon Stadium. The arena was..."*)

### Węzeł `[557]`
Mówca: **Ewald Alphonso**
> ""Well, {BaseGameText.AlphonsoToPlayer}? What do you think about the city's new marketing plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Ewald Alphonso: ""I doubt the Colonel would approve of his name being used..."*)

### Węzeł `[558]`
Mówca: **Ewald Alphonso**
> ""Well, Colonel? How do you feel about being Anrica's new poster boy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Ewald Alphonso: ""It looks like it's working well for the city. And if you..."*)

### Węzeł `[559]`
Mówca: **Ewald Alphonso**
> ""You and I both know Gus. His only allegiance is to his own bank account.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: ""Anyway, we didn't come here to talk about Mr. Manger. We..."*)

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso. How have you been since the trial?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, he certainly isn't. I saw to that myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alphonso. We have unfinished business, don't we?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)

### Węzeł `[563]`
Mówca: **Ewald Alphonso**
> ""We do indeed, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ewald Alphonso: ""You know, it was actually Gus Manger's idea. Turning Anr..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Discontent == true)"*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Ewald Alphonso: ""We do indeed, Mr. President.""*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Discontent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Ewald Alphonso: ""What's unfinished about it? I'd say the Gasom affair wra..."*)

### Węzeł `[567]`
Mówca: **Ewald Alphonso**
> ""What's unfinished about it? I'd say the Gasom affair wrapped up well for the both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ewald Alphonso: ""You know, it was actually Gus Manger's idea. Turning Anr..."*)

### Węzeł `[568]`
Mówca: **Ewald Alphonso**
> ""I've been just fine, {BaseGameText.AlphonsoToPlayer}. I wish I could say the same for my company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ewald Alphonso: ""You know, it was actually Gus Manger's idea. Turning Anr..."*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Discontent == true)"*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Ewald Alphonso: ""You were so invested in getting him out of the picture. ..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Discontent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Ewald Alphonso: ""I do wonder if the trial was the right idea. It hasn't d..."*)

### Węzeł `[572]`
Mówca: **Ewald Alphonso**
> ""I do wonder if the trial was the right idea. It hasn't done much to diminish his outsized legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ewald Alphonso: ""You know, it was actually Gus Manger's idea. Turning Anr..."*)

### Węzeł `[573]`
Mówca: **Ewald Alphonso**
> ""You were so invested in getting him out of the picture. A pity you weren't as invested in other matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ewald Alphonso: ""You know, it was actually Gus Manger's idea. Turning Anr..."*)

### Węzeł `[574]`
Mówca: **Ewald Alphonso**
> ""Honestly, I've never been better. It feels as if a huge weight has been lifted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ewald Alphonso: ""You know, it was actually Gus Manger's idea. Turning Anr..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Discontent == true)"*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Ewald Alphonso: ""I've been just fine, {BaseGameText.AlphonsoToPlayer}. I ..."*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Discontent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Ewald Alphonso: ""Honestly, I've never been better. It feels as if a huge ..."*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Narrator: "It was a group of Anricans who were holding signs that re..."*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)

### Węzeł `[581]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Against Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)

### Węzeł `[582]`
Mówca: **Narrator**
> "Another massive sign displayed the words: "Soldiers! Leave Your Barracks! Save Your Colonel's Dignity!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Ewald Alphonso: ""They need to be arrested for putting up such signs.""*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)"*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Narrator: "Another massive sign displayed the words: "Soldiers! Leav..."*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "Another massive sign displayed the words: "Soldiers! Leav..."*)

### Węzeł `[586]`
Mówca: **Narrator**
> "Another massive sign displayed the words: "Soldiers! Leave Your Barracks! Avenge Your Colonel!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Ewald Alphonso: ""They need to be arrested for putting up such signs.""*)

### Węzeł `[587]`
Mówca: **Narrator**
> "Another massive sign displayed the words: "Bring Rayne To Justice!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Ewald Alphonso: ""Looks like the impeachment case has already lost you the..."*)

### Węzeł `[588]`
Mówca: **Ewald Alphonso**
> ""They need to be arrested for putting up such signs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Player_Italic: "Stay silent."*)
  - -> `[660]` (*Player: ""You're right. They're clearly asking the military to int..."*)
  - -> `[662]` (*Player: ""They are free to express themselves.""*)
  - -> `[663]` (*Player: ""These are some very dangerous signs. How were they even ..."*)
  - -> `[664]` (*Player: ""I wouldn't go that far.""*)

### Węzeł `[589]`
Mówca: **Tarquin Soll**
> ""At least you still have the support of somebody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Italic: "Stay silent."*)
  - -> `[602]` (*Player: ""What does that supposed to mean, Mr. Soll?""*)
  - -> `[604]` (*Player: ""Funny. Do you not see the millions behind me?""*)
  - -> `[605]` (*Player: ""Right. At least that's going good for me.""*)

### Węzeł `[590]`
Mówca: **Ewald Alphonso**
> ""They need to be arrested for putting up such signs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Tarquin Soll: ""How liberal of you, Ewald.""*)

### Węzeł `[591]`
Mówca: **Tarquin Soll**
> ""How liberal of you, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Italic: "Stay silent."*)
  - -> `[606]` (*Player: ""The Colonel is right. They are free to express themselves.""*)
  - -> `[607]` (*Player: ""These are some very dangerous signs. How were they even ..."*)
  - -> `[608]` (*Player: ""Is this your doing too, Mr. Soll?""*)

### Węzeł `[592]`
Mówca: **Ewald Alphonso**
> ""Looks like the impeachment case did not damage your football career.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Tarquin Soll: ""This football craze seems to have numbed the Anricans a ..."*)

### Węzeł `[593]`
Mówca: **Tarquin Soll**
> ""This football craze seems to have numbed the Anricans a little too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Italic: "Stay silent."*)
  - -> `[602]` (*Player: ""What does that supposed to mean, Mr. Soll?""*)
  - -> `[610]` (*Player: ""Why don't you both mind your own business, gentlemen? I ..."*)
  - -> `[609]` (*Player: ""Right. At least that's going good for me.""*)

### Węzeł `[594]`
Mówca: **Ewald Alphonso**
> ""Looks like the impeachment case has already lost you the football fans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Tarquin Soll: ""For good reason.""*)

### Węzeł `[595]`
Mówca: **Narrator**
> "Behind them, a poster was being displayed with my and Lileas Graf's faces. I was portrayed wearing an FC Anrica jersey, while Lileas was displayed as an FC Arvory supporter -- her face crossed off with a red marker."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Ewald Alphonso: ""Looks like FC Anrica fans are really into politics. It's..."*)

### Węzeł `[596]`
Mówca: **Ewald Alphonso**
> ""Looks like FC Anrica fans are really into politics. It's good that they're embracing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Italic: "Stay silent."*)
  - -> `[609]` (*Player: ""Right. At least that's going good for me.""*)
  - -> `[614]` (*Player: ""Of course they would.""*)
  - -> `[613]` (*Player: ""Honestly, I couldn't care less.""*)

### Węzeł `[597]`
Mówca: **Ewald Alphonso**
> ""Looks like FC Anrica fans are really into politics. But unfortunately not into you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Italic: "Stay silent."*)
  - -> `[613]` (*Player: ""Honestly, I couldn't care less.""*)
  - -> `[615]` (*Player: ""If they're choosing Lileas over me, their opinions don't..."*)
  - -> `[616]` (*Player: ""I mean... I can't blame them.""*)

### Węzeł `[598]`
Mówca: **Ewald Alphonso**
> ""It seems like Anricans like you a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Italic: "Stay silent."*)
  - -> `[614]` (*Player: ""Of course they would.""*)
  - -> `[613]` (*Player: ""Honestly, I couldn't care less.""*)
  - -> `[617]` (*Player: ""Well, to be fair, I like Anricans a lot too.""*)

### Węzeł `[599]`
Mówca: **Ewald Alphonso**
> ""It really seems like Anrica is going to be lost to the NFP in the local elections, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Ewald Alphonso: ""They're promoting the NFP in football matches now. What ..."*)

### Węzeł `[600]`
Mówca: **Ewald Alphonso**
> ""They're promoting the NFP in football matches now. What a time to be alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Tarquin Soll: ""That's Mr. Rayne's fault.""*)

### Węzeł `[601]`
Mówca: **Tarquin Soll**
> ""That's Mr. Rayne's fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Italic: "Stay silent."*)
  - -> `[613]` (*Player: ""Honestly, I couldn't care less.""*)
  - -> `[616]` (*Player: ""I mean... I can't blame them.""*)
  - -> `[618]` (*Player: ""What does that supposed to mean, Mr. Soll?""*)
  - -> `[619]` (*Player: ""They can support whoever they want.""*)

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What does that supposed to mean, Mr. Soll?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[589]` (Tarquin Soll), `[593]` (Tarquin Soll), `[611]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Tarquin Soll: ""You lost the support of the mechanisms that matter. And ..."*)

### Węzeł `[603]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[589]` (Tarquin Soll), `[591]` (Tarquin Soll), `[593]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Funny. Do you not see the millions behind me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[589]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Tarquin Soll: ""We'll see about that.""*)

### Węzeł `[605]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Right. At least that's going good for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[589]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Tarquin Soll: ""Enjoy it while you can.""*)

### Węzeł `[606]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Colonel is right. They are free to express themselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[591]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Ewald Alphonso: ""The contents of that expression seems to be extremely ha..."*)

### Węzeł `[607]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are some very dangerous signs. How were they even allowed inside with them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[591]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Ewald Alphonso: ""To be fair, this type of statements are not that uncommo..."*)

### Węzeł `[608]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is this your doing too, Mr. Soll?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[591]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Tarquin Soll: ""You think I'd install a few men with signs to get your a..."*)

### Węzeł `[609]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Right. At least that's going good for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[593]` (Tarquin Soll), `[596]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Tarquin Soll: ""Enjoy it while you can.""*)

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't you both mind your own business, gentlemen? I am already aware of the trial, alright?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[593]` (Tarquin Soll), `[611]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Ewald Alphonso: ""Sure. And good luck with that. I didn't mean anything ba..."*)

### Węzeł `[611]`
Mówca: **Tarquin Soll**
> ""For good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Italic: "Stay silent."*)
  - -> `[602]` (*Player: ""What does that supposed to mean, Mr. Soll?""*)
  - -> `[610]` (*Player: ""Why don't you both mind your own business, gentlemen? I ..."*)
  - -> `[612]` (*Player: ""There's nothing I can do about that now.""*)

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There's nothing I can do about that now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Ewald Alphonso: ""You're right. And good luck with that. I didn't mean any..."*)

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I couldn't care less.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[596]` (Ewald Alphonso), `[597]` (Ewald Alphonso), `[598]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Tarquin Soll: ""Of course you don't.""*)

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course they would.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[596]` (Ewald Alphonso), `[598]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Ewald Alphonso: ""I see you are confident.""*)

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If they're choosing Lileas over me, their opinions don't even matter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[597]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Ewald Alphonso: ""I wouldn't go that far.""*)

### Węzeł `[616]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I mean... I can't blame them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[597]` (Ewald Alphonso), `[601]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Tarquin Soll: ""At least you are aware.""*)

### Węzeł `[617]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, to be fair, I like Anricans a lot too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[598]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Ewald Alphonso: ""Uh... Okay.""*)

### Węzeł `[618]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What does that supposed to mean, Mr. Soll?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[601]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Tarquin Soll: ""You know what it means, Anton. Does everything need to b..."*)

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They can support whoever they want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[601]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Ewald Alphonso: ""Well... That's true.""*)

### Węzeł `[620]`
Mówca: **Ewald Alphonso**
> ""Looks like Rizians are also scared of a possible war between us and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Tarquin Soll: ""The Toras family is a puppet of Queen Livingston. If the..."*)

### Węzeł `[621]`
Mówca: **Tarquin Soll**
> ""The Toras family is a puppet of Queen Livingston. If the queen wants war, Rizians will follow them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Player_Italic: "Stay silent."*)
  - -> `[675]` (*Player: ""They're just a bunch of hippies. Who cares what they say?""*)
  - -> `[677]` (*Player: ""Do you think Rizia would aid Rumburg in a war with us?""*)
  - -> `[678]` (*Player: ""Well, they're right. Nobody wants a war with Rumburg.""*)

### Węzeł `[622]`
Mówca: **Tarquin Soll**
> ""You lost the support of the mechanisms that matter. And you know that doesn't comprise FC Anrica fans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[623]`
Mówca: **Tarquin Soll**
> ""We'll see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[624]`
Mówca: **Tarquin Soll**
> ""Enjoy it while you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[625]`
Mówca: **Ewald Alphonso**
> ""The contents of that expression seems to be extremely harsh. But suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Ewald Alphonso: ""It is you they're targeting after all.""*)

### Węzeł `[626]`
Mówca: **Ewald Alphonso**
> ""It is you they're targeting after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[627]`
Mówca: **Ewald Alphonso**
> ""To be fair, this type of statements are not that uncommon in Anrica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Ewald Alphonso: ""Home of the Colonel, remember?""*)

### Węzeł `[628]`
Mówca: **Ewald Alphonso**
> ""Home of the Colonel, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[629]`
Mówca: **Tarquin Soll**
> ""You think I'd install a few men with signs to get your attention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Tarquin Soll: ""I already have it.""*)

### Węzeł `[630]`
Mówca: **Tarquin Soll**
> ""I already have it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[631]`
Mówca: **Ewald Alphonso**
> ""Sure. And good luck with that. I didn't mean anything bad with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[632]`
Mówca: **Ewald Alphonso**
> ""You're right. And good luck with that. I didn't mean anything bad with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[633]`
Mówca: **Ewald Alphonso**
> ""I see you are confident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[634]`
Mówca: **Tarquin Soll**
> ""Of course you don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[635]`
Mówca: **Ewald Alphonso**
> ""I wouldn't go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[636]`
Mówca: **Tarquin Soll**
> ""At least you are aware.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[637]`
Mówca: **Ewald Alphonso**
> ""Uh... Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Narrator: "He laughed."*)

### Węzeł `[638]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[639]`
Mówca: **Tarquin Soll**
> ""You know what it means, Anton. Does everything need to be explained to you in complete detail for you to understand such a basic concept?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[640]`
Mówca: **Ewald Alphonso**
> ""Well... That's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[641]`
Mówca: **Narrator**
> "Suddenly, a wave of shouting made us focus back on the field. An Anrican player was shown a yellow card."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Narrator: "With only a few minutes left on the clock, it looked as t..."*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Narrator: "With only a few minutes left on the clock, it looked as t..."*)

### Węzeł `[645]`
Mówca: **Narrator**
> "With only a few minutes left on the clock, it looked as though the match would end in a draw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnrica_Wins == true"*)

### Węzeł `[646]`
Mówca: **Narrator**
> "With only a few minutes left on the clock, it looked as though the match would end with a 1-0 loss for FC Anrica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Narrator: "But suddenly, everything changed. Number 10 of Real Monta..."*)

### Węzeł `[647]`
Mówca: **Narrator**
> "But suddenly, everything changed. Number 10 of Real Montaklar dribbled expertly towards the goal and effortlessly scored as Anrican defenders watched him in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Ewald Alphonso: ""I knew it.""*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnrica_Wins == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnrica_Wins == true"*)
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.FCAnrica_Wins == true)"*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnrica_Wins == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.FCAnrica_Wins"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Narrator: "But suddenly, everything changed. The Nibiyan star strike..."*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.FCAnrica_Wins == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.FCAnrica_Wins"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "But suddenly, everything changed. Number 10 of Real Monta..."*)

### Węzeł `[651]`
Mówca: **Narrator**
> "We watched in silence as the scoreboard was modified to display: "FC Anrica: 0 - Real Montaklar: 2.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_LT_FCAnricaLoses = true"*)

### Węzeł `[652]`
Mówca: **Narrator**
> "But suddenly, everything changed. Number 10 of Real Montaklar dribbled expertly towards the goal and effortlessly scored as Anrican defenders watched him in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Ewald Alphonso: ""Really? At the last minute?""*)

### Węzeł `[653]`
Mówca: **Narrator**
> "But suddenly, everything changed. The Nibiyan star striker Leon al-Ogwaldo dribbled expertly towards the goal and effortlessly scored a goal from an incredible distance as Rizian defenders watched him in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Ewald Alphonso: ""YES!""*)

### Węzeł `[654]`
Mówca: **Ewald Alphonso**
> ""YES!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[655]`
Mówca: **Narrator**
> "I noticed Tarquin Soll shifting in his seat and a large smile appeared on his face -- one that I had never seen before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Narrator: "We stood up and watched the scoreboard change to: "FC Anr..."*)

### Węzeł `[656]`
Mówca: **Narrator**
> "We watched in silence as the scoreboard was modified to display: "FC Anrica 1 - Real Montaklar: 2.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_LT_FCAnricaLoseAtLastMinute =..."*)

### Węzeł `[657]`
Mówca: **Ewald Alphonso**
> ""Really? At the last minute?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Narrator: "We watched in silence as the scoreboard was modified to d..."*)

### Węzeł `[658]`
Mówca: **Narrator**
> "We stood up and watched the scoreboard change to: "FC Anrica 2 - Real Montaklar: 1.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Narrator: "The Sordish side broke into massive applause as the refer..."*)

### Węzeł `[659]`
Mówca: **Ewald Alphonso**
> ""I knew it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Narrator: "We watched in silence as the scoreboard was modified to d..."*)

### Węzeł `[660]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right. They're clearly asking the military to intervene. This cannot be allowed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Ewald Alphonso: ""I'd be extremely careful if I were you.""*)

### Węzeł `[661]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They are free to express themselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Ewald Alphonso: ""Until their wishes become a reality...""*)

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are some very dangerous signs. How were they even allowed inside with them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Ewald Alphonso: ""Anrica is full of people like this these days.""*)

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't go that far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Ewald Alphonso: ""Why not? You already went too deep by prosecuting the *h..."*)

### Węzeł `[665]`
Mówca: **Ewald Alphonso**
> ""Why not? You already went too deep by prosecuting the *hero* of the republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[666]`
Mówca: **Ewald Alphonso**
> ""Until their wishes become a reality...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[667]`
Mówca: **Ewald Alphonso**
> ""Anrica is full of people like this these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Ewald Alphonso: ""Home of the Colonel, remember?""*)

### Węzeł `[668]`
Mówca: **Ewald Alphonso**
> ""Home of the Colonel, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[669]`
Mówca: **Ewald Alphonso**
> ""I'd be extremely careful if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[670]`
Mówca: **Narrator**
> "The Rizian side broke into massive applause as the referee blew the final whistle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[671]`
Mówca: **Narrator**
> "The Sordish side broke into massive applause as the referee blew the final whistle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[673]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Narrator: "We stood up and watched the scoreboard change to: "FC Anr..."*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Narrator: "I noticed Tarquin Soll shifting in his seat and a large s..."*)

### Węzeł `[675]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're just a bunch of hippies. Who cares what they say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[621]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[676]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[621]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think Rizia would aid Rumburg in a war with us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[621]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, they're right. Nobody wants a war with Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[621]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Suddenly, a wave of shouting made us focus back on the fi..."*)

### Węzeł `[679]`
Mówca: **Tarquin Soll**
> ""Well then... That settles it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Ewald Alphonso: ""We should go down and console the boys.""*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Ewald Alphonso: ""Not very unexpected, really.""*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Tarquin Soll: ""Well then... That settles it.""*)

### Węzeł `[683]`
Mówca: **Ewald Alphonso**
> ""Not very unexpected, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Ewald Alphonso: ""We should go down and console the boys.""*)

### Węzeł `[684]`
Mówca: **Tarquin Soll**
> ""You must go congratulate them in person, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Ewald Alphonso: ""Yes. This is an historic win. I'll come with you.""*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Ewald Alphonso: ""That's unbelievable. We should go down and congratulate ..."*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Tarquin Soll: ""You must go congratulate them in person, Mr. Rayne.""*)

### Węzeł `[688]`
Mówca: **Ewald Alphonso**
> ""That's unbelievable. We should go down and congratulate the boys in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Narrator: "We left the lounge and went downstairs to congratulate th..."*)

### Węzeł `[689]`
Mówca: **Ewald Alphonso**
> ""Yes. This is an historic win. I'll come with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Narrator: "We left the lounge and went downstairs to congratulate th..."*)

### Węzeł `[690]`
Mówca: **Narrator**
> "We left the lounge and went downstairs to congratulate the team of FC Anrica on their massive win against Real Montaklar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_LT_FCAnricaWins = true"*)

### Węzeł `[691]`
Mówca: **Ewald Alphonso**
> ""We should go down and console the boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Narrator: "We left the lounge and went downstairs to congratulate th..."*)

### Węzeł `[692]`
Mówca: **Narrator**
> "We left the lounge and went downstairs to congratulate the team for their efforts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_LT_FCAnricaWins = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaWins"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Game_FCAnricaRises");"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_LT_FCAnricaLoseAtLastMinute = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaLoseAtLastMinute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Narrator: "The Rizian side broke into massive applause as the refere..."*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_LT_FCAnricaLoses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaLoses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Narrator: "The Rizian side broke into massive applause as the refere..."*)

### Węzeł `[696]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Watching the Merkopan Champions Cup with esteemed guests", "Maroon Stadium", "Anrica");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Watching the Merkopan Champions Cup with esteemed guests","Maroon Stadium","Anrica");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Diplomacy");"*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Game_FCAnricaRises");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Game_FCAnricaRises");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Narrator: "Suddenly, the ball was passed to the famous Sordish strik..."*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "Suddenly, the ball was passed to the famous Sordish strik..."*)

### Węzeł `[701]`
Mówca: **Narrator**
> "Suddenly, the ball was passed to the famous Sordish striker, Hakon Zlater, who was in front of the goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Narrator: "The Sordish crowd went crazy as Zlater's powerful shot br..."*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HousingAssistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HousingAssistance == true"*)
  - -> `[704]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_HousingAssistance == true)"*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HousingAssistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Tarquin Soll: ""Now Rayne is offering proper housing assistance while yo..."*)

### Węzeł `[704]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_HousingAssistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Tarquin Soll: ""And now you're wasting your time on crap like this.""*)

### Węzeł `[705]`
Mówca: **Tarquin Soll**
> ""Now Rayne is offering proper housing assistance while you waste your time on crap like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Tarquin Soll: ""Is this your way of personal redemption -- spending a fe..."*)

### Węzeł `[706]`
Mówca: **Tarquin Soll**
> ""And now you're wasting your time on crap like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Tarquin Soll: ""Is this your way of personal redemption -- spending a fe..."*)
